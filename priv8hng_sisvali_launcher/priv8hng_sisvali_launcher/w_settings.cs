using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace priv8hng_sisvali_launcher {
  public partial class w_settings : Form {
    public w_settings() {
      InitializeComponent();
    }

    private void btn_cancel_Click(object sender, EventArgs e) {
      ((w_main)this.w_panel.Parent.Parent).btn_settings_cancel();
    }

    private string lastIp = "255.255.255.255";
    private void tbx_ip_TextChanged(object sender, EventArgs e) {
      IPAddress address;
      if (IPAddress.TryParse(tbx_ip.Text, out address)) {
        lastIp = tbx_ip.Text;
      } else {
        int select = tbx_ip.SelectionStart;
        tbx_ip.Text = lastIp;
        tbx_ip.Select(select - 1, select - 2);
      }
    }

    private string lastPort = "65535";
    private void tbx_port_TextChanged(object sender, EventArgs e) {
      ushort port;
      if (ushort.TryParse(tbx_port.Text, out port)) {
        lastPort = tbx_port.Text;
      } else {
        int select = tbx_port.SelectionStart;
        tbx_port.Text = lastPort;
        tbx_port.Select(select - 1, select - 2);
      }
    }
  }
}
