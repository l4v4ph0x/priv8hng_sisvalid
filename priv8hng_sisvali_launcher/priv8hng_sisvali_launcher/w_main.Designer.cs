namespace priv8hng_sisvali_launcher
{
	partial class w_main
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(w_main));
            this.c_panel = new System.Windows.Forms.Panel();
            this.btn_minimize = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Label();
            this.w_title = new System.Windows.Forms.Label();
            this.btn_download = new System.Windows.Forms.Button();
            this.progb_download = new System.Windows.Forms.ProgressBar();
            this.progb_all = new System.Windows.Forms.ProgressBar();
            this.lb_file = new System.Windows.Forms.Label();
            this.btn_settings = new System.Windows.Forms.Button();
            this.container = new System.Windows.Forms.Panel();
            this.pb_back = new System.Windows.Forms.PictureBox();
            this.c_panel.SuspendLayout();
            this.container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_back)).BeginInit();
            this.SuspendLayout();
            // 
            // c_panel
            // 
            this.c_panel.Controls.Add(this.btn_minimize);
            this.c_panel.Controls.Add(this.btn_close);
            this.c_panel.Controls.Add(this.w_title);
            this.c_panel.Location = new System.Drawing.Point(0, 0);
            this.c_panel.Name = "c_panel";
            this.c_panel.Size = new System.Drawing.Size(750, 18);
            this.c_panel.TabIndex = 0;
            this.c_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.c_panel_MouseDown);
            this.c_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.c_panel_MouseMove);
            this.c_panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.c_panel_MouseUp);
            // 
            // btn_minimize
            // 
            this.btn_minimize.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.ForeColor = System.Drawing.Color.Black;
            this.btn_minimize.Location = new System.Drawing.Point(714, 5);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(12, 13);
            this.btn_minimize.TabIndex = 2;
            this.btn_minimize.Text = "-";
            this.btn_minimize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            this.btn_minimize.MouseEnter += new System.EventHandler(this.btn_minimize_MouseEnter);
            this.btn_minimize.MouseLeave += new System.EventHandler(this.btn_minimize_MouseLeave);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.ForeColor = System.Drawing.Color.Black;
            this.btn_close.Location = new System.Drawing.Point(730, 5);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(12, 13);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = "x";
            this.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            this.btn_close.MouseEnter += new System.EventHandler(this.btn_close_MouseEnter);
            this.btn_close.MouseLeave += new System.EventHandler(this.btn_close_MouseLeave);
            // 
            // w_title
            // 
            this.w_title.AutoSize = true;
            this.w_title.BackColor = System.Drawing.Color.Transparent;
            this.w_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.w_title.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.w_title.Location = new System.Drawing.Point(10, 2);
            this.w_title.Name = "w_title";
            this.w_title.Size = new System.Drawing.Size(118, 16);
            this.w_title.TabIndex = 0;
            this.w_title.Text = "Title Goes Here";
            this.w_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.c_panel_MouseDown);
            this.w_title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.c_panel_MouseMove);
            this.w_title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.c_panel_MouseUp);
            // 
            // btn_download
            // 
            this.btn_download.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_download.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_download.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_download.Location = new System.Drawing.Point(572, 425);
            this.btn_download.Name = "btn_download";
            this.btn_download.Size = new System.Drawing.Size(166, 28);
            this.btn_download.TabIndex = 2;
            this.btn_download.Text = "Update/Download";
            this.btn_download.UseVisualStyleBackColor = true;
            this.btn_download.Click += new System.EventHandler(this.btn_download_Click);
            // 
            // progb_download
            // 
            this.progb_download.Location = new System.Drawing.Point(108, 425);
            this.progb_download.Name = "progb_download";
            this.progb_download.Size = new System.Drawing.Size(458, 11);
            this.progb_download.TabIndex = 3;
            // 
            // progb_all
            // 
            this.progb_all.Location = new System.Drawing.Point(108, 442);
            this.progb_all.Name = "progb_all";
            this.progb_all.Size = new System.Drawing.Size(458, 11);
            this.progb_all.TabIndex = 4;
            // 
            // lb_file
            // 
            this.lb_file.AutoSize = true;
            this.lb_file.BackColor = System.Drawing.Color.Transparent;
            this.lb_file.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_file.Location = new System.Drawing.Point(12, 460);
            this.lb_file.Name = "lb_file";
            this.lb_file.Size = new System.Drawing.Size(0, 13);
            this.lb_file.TabIndex = 5;
            // 
            // btn_settings
            // 
            this.btn_settings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_settings.Location = new System.Drawing.Point(12, 425);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(90, 28);
            this.btn_settings.TabIndex = 6;
            this.btn_settings.Text = "Settings";
            this.btn_settings.UseVisualStyleBackColor = true;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // container
            // 
            this.container.Controls.Add(this.pb_back);
            this.container.Location = new System.Drawing.Point(12, 24);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(726, 398);
            this.container.TabIndex = 7;
            // 
            // pb_back
            // 
            this.pb_back.Image = global::priv8hng_sisvali_launcher.Properties.Resources.the_heroes_of_aurelia__by_nicklausofkrieg_d4jub0d_png;
            this.pb_back.Location = new System.Drawing.Point(0, 9);
            this.pb_back.Name = "pb_back";
            this.pb_back.Size = new System.Drawing.Size(726, 380);
            this.pb_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_back.TabIndex = 2;
            this.pb_back.TabStop = false;
            // 
            // w_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(750, 480);
            this.Controls.Add(this.container);
            this.Controls.Add(this.btn_settings);
            this.Controls.Add(this.lb_file);
            this.Controls.Add(this.progb_all);
            this.Controls.Add(this.progb_download);
            this.Controls.Add(this.btn_download);
            this.Controls.Add(this.c_panel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightSalmon;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "w_main";
            this.c_panel.ResumeLayout(false);
            this.c_panel.PerformLayout();
            this.container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel c_panel;
		private System.Windows.Forms.Label w_title;
		private System.Windows.Forms.Label btn_close;
		private System.Windows.Forms.Label btn_minimize;
		private System.Windows.Forms.Button btn_download;
		private System.Windows.Forms.ProgressBar progb_download;
		private System.Windows.Forms.ProgressBar progb_all;
		private System.Windows.Forms.Label lb_file;
		private System.Windows.Forms.Button btn_settings;
		private System.Windows.Forms.Panel container;
		private System.Windows.Forms.PictureBox pb_back;
	}
}

