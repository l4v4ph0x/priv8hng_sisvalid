namespace priv8hng_sisvali_launcher
{
	partial class w_settings
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
			this.w_panel = new System.Windows.Forms.Panel();
			this.btn_cancel = new System.Windows.Forms.Button();
			this.tbx_password = new System.Windows.Forms.TextBox();
			this.lb_password = new System.Windows.Forms.Label();
			this.tbx_userid = new System.Windows.Forms.TextBox();
			this.lb_userid = new System.Windows.Forms.Label();
			this.lb_side = new System.Windows.Forms.Label();
			this.cobx_side = new System.Windows.Forms.ComboBox();
			this.lb_ip = new System.Windows.Forms.Label();
			this.tbx_ip = new System.Windows.Forms.TextBox();
			this.lb_port = new System.Windows.Forms.Label();
			this.tbx_port = new System.Windows.Forms.TextBox();
			this.w_panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// w_panel
			// 
			this.w_panel.Controls.Add(this.tbx_port);
			this.w_panel.Controls.Add(this.lb_port);
			this.w_panel.Controls.Add(this.tbx_ip);
			this.w_panel.Controls.Add(this.lb_ip);
			this.w_panel.Controls.Add(this.btn_cancel);
			this.w_panel.Controls.Add(this.tbx_password);
			this.w_panel.Controls.Add(this.lb_password);
			this.w_panel.Controls.Add(this.tbx_userid);
			this.w_panel.Controls.Add(this.lb_userid);
			this.w_panel.Controls.Add(this.lb_side);
			this.w_panel.Controls.Add(this.cobx_side);
			this.w_panel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.w_panel.Font = new System.Drawing.Font("Liberation Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.w_panel.ForeColor = System.Drawing.Color.LightSalmon;
			this.w_panel.Location = new System.Drawing.Point(0, 0);
			this.w_panel.Name = "w_panel";
			this.w_panel.Size = new System.Drawing.Size(726, 398);
			this.w_panel.TabIndex = 0;
			// 
			// btn_cancel
			// 
			this.btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
			this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_cancel.Font = new System.Drawing.Font("Liberation Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_cancel.Location = new System.Drawing.Point(0, 363);
			this.btn_cancel.Name = "btn_cancel";
			this.btn_cancel.Size = new System.Drawing.Size(90, 28);
			this.btn_cancel.TabIndex = 6;
			this.btn_cancel.Text = "Cancel";
			this.btn_cancel.UseVisualStyleBackColor = true;
			this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
			// 
			// tbx_password
			// 
			this.tbx_password.Location = new System.Drawing.Point(375, 12);
			this.tbx_password.MaxLength = 45;
			this.tbx_password.Name = "tbx_password";
			this.tbx_password.Size = new System.Drawing.Size(150, 20);
			this.tbx_password.TabIndex = 5;
			// 
			// lb_password
			// 
			this.lb_password.AutoSize = true;
			this.lb_password.Location = new System.Drawing.Point(314, 15);
			this.lb_password.Name = "lb_password";
			this.lb_password.Size = new System.Drawing.Size(55, 12);
			this.lb_password.TabIndex = 4;
			this.lb_password.Text = "Password";
			// 
			// tbx_userid
			// 
			this.tbx_userid.Location = new System.Drawing.Point(158, 12);
			this.tbx_userid.MaxLength = 19;
			this.tbx_userid.Name = "tbx_userid";
			this.tbx_userid.Size = new System.Drawing.Size(150, 20);
			this.tbx_userid.TabIndex = 3;
			// 
			// lb_userid
			// 
			this.lb_userid.AutoSize = true;
			this.lb_userid.Location = new System.Drawing.Point(115, 15);
			this.lb_userid.Name = "lb_userid";
			this.lb_userid.Size = new System.Drawing.Size(37, 12);
			this.lb_userid.TabIndex = 2;
			this.lb_userid.Text = "UserID";
			// 
			// lb_side
			// 
			this.lb_side.AutoSize = true;
			this.lb_side.Location = new System.Drawing.Point(12, 15);
			this.lb_side.Name = "lb_side";
			this.lb_side.Size = new System.Drawing.Size(26, 12);
			this.lb_side.TabIndex = 1;
			this.lb_side.Text = "Side";
			// 
			// cobx_side
			// 
			this.cobx_side.FormattingEnabled = true;
			this.cobx_side.Items.AddRange(new object[] {
            "US",
            "GM"});
			this.cobx_side.Location = new System.Drawing.Point(44, 12);
			this.cobx_side.Name = "cobx_side";
			this.cobx_side.Size = new System.Drawing.Size(65, 20);
			this.cobx_side.TabIndex = 0;
			// 
			// lb_ip
			// 
			this.lb_ip.AutoSize = true;
			this.lb_ip.Location = new System.Drawing.Point(12, 41);
			this.lb_ip.Name = "lb_ip";
			this.lb_ip.Size = new System.Drawing.Size(82, 12);
			this.lb_ip.TabIndex = 7;
			this.lb_ip.Text = "Server Address";
			// 
			// tbx_ip
			// 
			this.tbx_ip.Location = new System.Drawing.Point(100, 38);
			this.tbx_ip.MaxLength = 15;
			this.tbx_ip.Name = "tbx_ip";
			this.tbx_ip.Size = new System.Drawing.Size(150, 20);
			this.tbx_ip.TabIndex = 8;
			this.tbx_ip.Text = "255.255.255.255";
			this.tbx_ip.TextChanged += new System.EventHandler(this.tbx_ip_TextChanged);
			// 
			// lb_port
			// 
			this.lb_port.AutoSize = true;
			this.lb_port.Location = new System.Drawing.Point(256, 41);
			this.lb_port.Name = "lb_port";
			this.lb_port.Size = new System.Drawing.Size(60, 12);
			this.lb_port.TabIndex = 9;
			this.lb_port.Text = "Server Port";
			// 
			// tbx_port
			// 
			this.tbx_port.Location = new System.Drawing.Point(322, 38);
			this.tbx_port.MaxLength = 5;
			this.tbx_port.Name = "tbx_port";
			this.tbx_port.Size = new System.Drawing.Size(75, 20);
			this.tbx_port.TabIndex = 10;
			this.tbx_port.Text = "65535";
			this.tbx_port.TextChanged += new System.EventHandler(this.tbx_port_TextChanged);
			// 
			// w_settings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(726, 398);
			this.Controls.Add(this.w_panel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "w_settings";
			this.Text = "w_settings";
			this.w_panel.ResumeLayout(false);
			this.w_panel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel w_panel;
		private System.Windows.Forms.Label lb_password;
		private System.Windows.Forms.Label lb_userid;
		private System.Windows.Forms.Label lb_side;
		public System.Windows.Forms.ComboBox cobx_side;
		public System.Windows.Forms.TextBox tbx_userid;
		public System.Windows.Forms.TextBox tbx_password;
		private System.Windows.Forms.Button btn_cancel;
		private System.Windows.Forms.Label lb_port;
		private System.Windows.Forms.Label lb_ip;
		public System.Windows.Forms.TextBox tbx_port;
		public System.Windows.Forms.TextBox tbx_ip;
	}
}