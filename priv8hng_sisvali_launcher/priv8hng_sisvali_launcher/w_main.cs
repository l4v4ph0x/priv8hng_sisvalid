using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Net;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.IO;
using System.Runtime.InteropServices;
using System.Net.Sockets;
using System.Collections.Generic;
using priv8hng_sisvali_launcher.Properties;
using System.Reflection;
using System.Diagnostics;
using System.Threading;

namespace priv8hng_sisvali_launcher {
  public partial class w_main : Form {
    private bool _drag_window = false;
    private Point _drag_offsets = new Point(0, 0);

    private bool _got_files = false;
    string[] lines = null;
    int files_i = 99;

    string host = "http://7.127.35.42:8080/downloads/sisvali/";

    Assembly assembly = Assembly.GetExecutingAssembly();

    PictureBox _pb_back;
    w_settings wsettings;

    /*
[DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl, SetLastError=true)]
static extern int system(string command);
    */

    [DllImport("kernel32.dll")]
    static extern uint WinExec(string lpCmdLine, uint uCmdShow);


    private void gen_client_ini() {
      System.IO.File.WriteAllBytes("client.ini", Resources.client_ini);
    }

    private void read_client_ini(out int side, out string userid, out string password, out string ip, out string port,
    int write_side = -1, string write_userid = "", string write_password = "", string write_ip = "", string write_port = "") {
      int _side = write_side;
      string _userid = write_userid;
      string _password = write_password;
      string _ip = write_ip;
      string _port = write_port;

      string[] lines = System.IO.File.ReadAllLines("client.ini");
      for (int i = 0; i < lines.Length; i++) {
        string line = lines[i].Trim();
        if (line.StartsWith("nickname") && line.Contains("\"") && line.Contains("_") && line.Contains(":")) {
          string[] splitted = line.Split('\"')[1].Split(':');
          string[] splitted2 = splitted[0].Split('_');
          if (_side == -1) {
            try {
              _side = Convert.ToInt32(splitted2[0]);
            } catch (Exception ee) { }
          }

          if (_userid == "") _userid = splitted2[1];
          if (_password == "") _password = splitted[1];
        } else if (line.StartsWith("#-ip") && line.Contains("=")) {
          Regex.Replace(line, " ", "");
          Regex.Replace(line, "\n", "");

          if (_ip == "") _ip = line.Split('=')[1];
        } else if (line.StartsWith("#-port") && line.Contains("=")) {
          Regex.Replace(line, " ", "");
          Regex.Replace(line, "\n", "");

          if (_port == "") _port = line.Split('=')[1];
        }
      }

      side = _side;
      userid = _userid;
      password = _password;
      ip = _ip;
      port = _port;
    }

    private void save_client_ini(string nickname = "", string ip = "", string port = "") {
      List<string> l_lines = new List<string>();
      string[] lines = System.IO.File.ReadAllLines("client.ini");
      for (int i = 0; i < lines.Length; i++) {
        string line = lines[i].Trim();
        if (line.StartsWith("nickname") == true) {
          l_lines.Add(nickname);
        } else if (line.StartsWith("#-ip")) {
          l_lines.Add(ip);
        } else if (line.StartsWith("#-port")) {
          l_lines.Add(port);
        } else l_lines.Add(lines[i]);
      }
      System.IO.File.WriteAllLines("client.ini", l_lines.ToArray());
    }

    private void get_client_ini_vars(out int side, out string userid, out string password, out string ip, out string port) {
      int _side = -1;
      string _userid = "";
      string _password = "";
      string _ip = "";
      string _port = "";

      while (_userid == "" || _password == "" || _ip == "" || _port == "") {
        read_client_ini(out _side, out _userid, out _password, out _ip, out _port,
          _side, _userid, _password, _ip, _port);

        if (_side == -1 || _userid == "" || _password == "" || _ip == "" || _port == "") {
          gen_client_ini();
        }
      }
      save_client_ini("\tnickname=\"" + _side + "_" + _userid + ":" + _password + '\"', "#-ip=" + _ip, "#-port=" + _port);

      side = _side;
      userid = _userid;
      password = _password;
      ip = _ip;
      port = _port;
    }

    public w_main() {
      InitializeComponent();

      this.c_panel.Paint += new PaintEventHandler(set_background);
      this.BackColor = Color.FromArgb(28, 32, 33);

      // setting window title
      w_title.Text = "priv8hng sisvali Launcher";
      // setting title to center
      w_title.Location = new Point(this.Width / 2 - w_title.Width / 2, w_title.Location.Y);

      //var ping = new Ping();
      //var reply = ping.Send(new IPAddress(new byte[]{25,68,202,110}), 3000);


      if (!System.IO.File.Exists("client.ini")) {
        gen_client_ini();
      }
      wsettings = new w_settings();
    }

    public static bool PingHost(string _HostURI, int _PortNumber) {
      try {
        UdpClient client = new UdpClient(_HostURI, _PortNumber);
        return true;
      } catch (Exception ex) {
        //MessageBox.Show("Error pinging host:'" + _HostURI + ":" + _PortNumber.ToString() + "'");
        return false;
      }
    }

    private void set_background(Object sender, PaintEventArgs e) {
      Graphics graphics = e.Graphics;
      Rectangle gradient_rectangle = new Rectangle(0, 0, this.c_panel.Width, this.c_panel.Height);
      Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(71, 75, 76), Color.FromArgb(28, 32, 33), 90f);
      graphics.FillRectangle(b, gradient_rectangle);
    }

    private void c_panel_MouseDown(object sender, MouseEventArgs e) {
      _drag_offsets = new Point(Cursor.Position.X - this.Location.X, Cursor.Position.Y - this.Location.Y);
      _drag_window = true;
    }

    private void c_panel_MouseMove(object sender, MouseEventArgs e) {
      if (_drag_window == true)
        this.Location = new Point(Cursor.Position.X - _drag_offsets.X, Cursor.Position.Y - _drag_offsets.Y);
    }

    private void c_panel_MouseUp(object sender, MouseEventArgs e) {
      _drag_window = false;
    }

    private void btn_minimize_MouseEnter(object sender, EventArgs e) {
      btn_minimize.BackColor = Color.Gray;
    }

    private void btn_minimize_MouseLeave(object sender, EventArgs e) {
      btn_minimize.BackColor = Color.WhiteSmoke;
    }

    private void btn_close_MouseEnter(object sender, EventArgs e) {
      btn_close.BackColor = Color.Gray;
    }

    private void btn_close_MouseLeave(object sender, EventArgs e) {
      btn_close.BackColor = Color.WhiteSmoke;
    }

    private void btn_minimize_Click(object sender, EventArgs e) {
      this.WindowState = FormWindowState.Minimized;
    }

    private void btn_close_Click(object sender, EventArgs e) {
      Environment.Exit(0);
    }

    private void btn_download_Click(object sender, EventArgs e) {
      if (lines == null) {
        btn_download.Enabled = false;
        File.Delete("files.txt");
        File.Delete("files.zip");

        if (!File.Exists("unzip.exe")) {
          lb_file.Text = "Downloading: unzip.exe";
          download(host + "unzip.exe", "unzip.exe");
        }
        progb_all.Value = 0;

        if (File.Exists("unzip.exe"))
          client_DownloadFileCompleted(sender, null);
      } else {
        int side = -1;
        string userid = "";
        string password = "";
        string ip = "";
        string port = "";

        get_client_ini_vars(out side, out userid, out password, out ip, out port);

        //system("start sisvali.exe / ip " + ip + " port " + port + " /R \"ircserver=" + ip + ":6667\"");
        WinExec("cmd /c start sisvali.exe / ip " + ip + " port " + port + " /R \"ircserver=" + ip + ":6667\"", 0);
      }
    }

    private void download(string url, string file) {
      progb_download.Value = 0;

      WebClient client = new WebClient();
      client.Headers.Add("User-Agent", "Mozilla/4.0 (compatible; MSIE 8.0)");
      client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);

      client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
      // Starts the download
      client.DownloadFileAsync(new Uri(url), file);

      //btn_download.Text = "Download In Process";
      //btn_download.Enabled = false;
    }

    void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e) {
      double bytesIn = double.Parse(e.BytesReceived.ToString());
      double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
      double percentage = bytesIn / totalBytes * 100;
      progb_download.Value = int.Parse(Math.Truncate(percentage).ToString());
    }

    void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e) {
      if (_got_files == false) {
        if (File.Exists("files.zip")) {
          _got_files = true;

          System.Threading.Thread.Sleep(1000);

        unpack_files_txt:
          lb_file.Text = "Unpacking: files.zip";
          //system("unzip.exe files.zip -d \""+Directory.GetCurrentDirectory()+"\"");

          Process p = new Process();
          p.StartInfo.FileName = "unzip.exe";
          p.StartInfo.Arguments = "files.zip -d \"" + Directory.GetCurrentDirectory() + "\"";
          p.StartInfo.CreateNoWindow = true;
          p.Start();
          p.WaitForExit();

          for (; ; System.Threading.Thread.Sleep(100)) {
            if (File.Exists("files.txt"))
              break;
            else goto unpack_files_txt;

          }

          File.Delete("files.zip");

          lines = System.IO.File.ReadAllLines("files.txt");

          files_i = 0;
        } else {
          lb_file.Text = "Downloading: files.zip";

          Thread t = new Thread(() => download(host + "files.zip", "files.zip"));
          t.Start();

          //download(host + "files.zip", "files.zip");
        }
      }

      if (lines != null) {
        if (files_i < lines.Length) {
          double percentage = (double)files_i / (double)lines.Length * (double)100;
          progb_all.Value = int.Parse(Math.Truncate(percentage).ToString());

          if (files_i < lines.Length) {
            string[] exploded = Regex.Split(lines[files_i], "::");
            createDirIfNeed(exploded[1]);
            bool exists = false;

            if (!File.Exists(exploded[1]) || GetMD5HashFromFile(exploded[1]) != exploded[2]) {
              if (File.Exists(exploded[1])) File.Delete(exploded[1]);
              lb_file.Text = "Downloading: " + exploded[1];
              download(exploded[0], exploded[1]);
            } else exists = true;

            files_i++;

            if (exists == true) {
              //lb_file.Text = "";
              client_DownloadFileCompleted(sender, e);
            }
          }
        } else {
          progb_all.Value = 100;
          File.Delete("files.txt");
          lb_file.Text = "";
          btn_download.Text = "Play";
          btn_download.Enabled = true;
        }
      }
    }

    public static string GetMD5HashFromFile(string filename) {
      using (var md5 = new MD5CryptoServiceProvider()) {
        var buffer = md5.ComputeHash(File.ReadAllBytes(filename));
        var sb = new StringBuilder();

        for (int i = 0; i < buffer.Length; i++)
          sb.Append(buffer[i].ToString("x2"));

        return sb.ToString();
      }
    }

    void createDirIfNeed(string line) {
      if (line.Contains("/")) {
        string[] exploded = Regex.Split(line, "/");

        for (int i = 0; i < exploded.Length - 1; i++) {
          string dir = exploded[0];

          for (int j = 0; j < i; j++)
            dir += "/" + exploded[j + 1];

          if (!System.IO.Directory.Exists(dir))
            System.IO.Directory.CreateDirectory(dir);
        }
      }
    }

    public void btn_settings_cancel() {
      wsettings.Controls.Add(container.Controls[0]);
      container.Controls.Clear();
      container.Controls.Add(_pb_back);

      btn_settings.Text = "Settings";
    }

    private void btn_settings_Click(object sender, EventArgs e) {
      if (btn_settings.Text == "Settings") {
        int side = -1;
        string userid = "";
        string password = "";
        string ip = "";
        string port = "";

        get_client_ini_vars(out side, out userid, out password, out ip, out port);

        wsettings.cobx_side.SelectedIndex = side;
        wsettings.tbx_userid.Text = userid;
        wsettings.tbx_password.Text = password;
        wsettings.tbx_ip.Text = ip;
        wsettings.tbx_port.Text = port;

        _pb_back = pb_back;
        container.Controls.Clear();
        container.Controls.Add(wsettings.Controls[0]);

        btn_settings.Text = "Save";
      } else {
        string nickname = "\tnickname=\"" + wsettings.cobx_side.SelectedIndex + "_" + wsettings.tbx_userid.Text + ":" + wsettings.tbx_password.Text + '\"';
        string ip = "#-ip=" + wsettings.tbx_ip.Text;
        string port = "#-port=" + wsettings.tbx_port.Text;
        save_client_ini(nickname, ip, port);

        btn_settings_cancel();
      }
    }
  }
}
