namespace Zelda
{
	// Token: 0x02000010 RID: 16
	public partial class Register : global::System.Windows.Forms.Form
	{
		// Token: 0x06000063 RID: 99 RVA: 0x000B9C38 File Offset: 0x000B9C38
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000B9C70 File Offset: 0x000B9C70
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Zelda.Register));
			this.RegisterPanel = new global::Siticone.UI.WinForms.SiticonePanel();
			this.label6 = new global::System.Windows.Forms.Label();
			this.label7 = new global::System.Windows.Forms.Label();
			this.email = new global::Siticone.UI.WinForms.SiticoneMaterialTextBox();
			this.token = new global::Siticone.UI.WinForms.SiticoneMaterialTextBox();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.siticoneButton1 = new global::Siticone.UI.WinForms.SiticoneButton();
			this.pass1 = new global::Siticone.UI.WinForms.SiticoneMaterialTextBox();
			this.user1 = new global::Siticone.UI.WinForms.SiticoneMaterialTextBox();
			this.siticoneTransparentDrag1 = new global::Siticone.UI.WinForms.SiticoneTransparentDrag();
			this.siticoneTransparentDrag2 = new global::Siticone.UI.WinForms.SiticoneTransparentDrag();
			this.siticoneTransparentDrag3 = new global::Siticone.UI.WinForms.SiticoneTransparentDrag();
			this.siticonePanel3 = new global::Siticone.UI.WinForms.SiticonePanel();
			this.siticoneControlBox2 = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.siticoneControlBox1 = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.RegisterPanel.SuspendLayout();
			this.siticonePanel3.SuspendLayout();
			base.SuspendLayout();
			this.RegisterPanel.Controls.Add(this.label6);
			this.RegisterPanel.Controls.Add(this.label7);
			this.RegisterPanel.Controls.Add(this.email);
			this.RegisterPanel.Controls.Add(this.token);
			this.RegisterPanel.Controls.Add(this.label4);
			this.RegisterPanel.Controls.Add(this.label5);
			this.RegisterPanel.Controls.Add(this.siticoneButton1);
			this.RegisterPanel.Controls.Add(this.pass1);
			this.RegisterPanel.Controls.Add(this.user1);
			this.RegisterPanel.Location = new global::System.Drawing.Point(10, 69);
			this.RegisterPanel.Name = "RegisterPanel";
			this.RegisterPanel.ShadowDecoration.Parent = this.RegisterPanel;
			this.RegisterPanel.Size = new global::System.Drawing.Size(383, 492);
			this.RegisterPanel.TabIndex = 97;
			this.label6.AutoSize = true;
			this.label6.BackColor = global::System.Drawing.Color.Transparent;
			this.label6.Font = new global::System.Drawing.Font("Segoe UI Semibold", 16f, global::System.Drawing.FontStyle.Bold);
			this.label6.ForeColor = global::System.Drawing.Color.FromArgb(81, 0, 198);
			this.label6.Location = new global::System.Drawing.Point(19, 43);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(207, 30);
			this.label6.TabIndex = 94;
			this.label6.Text = "LET'S SIGN YOU UP.";
			this.label7.AutoSize = true;
			this.label7.BackColor = global::System.Drawing.Color.Transparent;
			this.label7.Font = new global::System.Drawing.Font("Segoe UI Semibold", 11f, global::System.Drawing.FontStyle.Bold);
			this.label7.ForeColor = global::System.Drawing.Color.FromArgb(221, 180, 180, 180);
			this.label7.Location = new global::System.Drawing.Point(20, 24);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(176, 20);
			this.label7.TabIndex = 93;
			this.label7.Text = "Welcome to Vegas Panel";
			this.email.BorderColor = global::System.Drawing.Color.FromArgb(81, 0, 198);
			this.email.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.email.DefaultText = "email";
			this.email.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.email.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.email.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.email.DisabledState.Parent = this.email;
			this.email.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.email.FillColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.email.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(81, 0, 198);
			this.email.FocusedState.Parent = this.email;
			this.email.ForeColor = global::System.Drawing.Color.Silver;
			this.email.HoveredState.BorderColor = global::System.Drawing.Color.Gray;
			this.email.HoveredState.Parent = this.email;
			this.email.IconLeft = (global::System.Drawing.Image)componentResourceManager.GetObject("email.IconLeft");
			this.email.Location = new global::System.Drawing.Point(26, 193);
			this.email.Name = "email";
			this.email.PasswordChar = '\0';
			this.email.PlaceholderText = "";
			this.email.SelectedText = "";
			this.email.ShadowDecoration.Parent = this.email;
			this.email.Size = new global::System.Drawing.Size(327, 36);
			this.email.TabIndex = 13;
			this.token.BorderColor = global::System.Drawing.Color.FromArgb(81, 0, 198);
			this.token.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.token.DefaultText = "Token";
			this.token.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.token.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.token.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.token.DisabledState.Parent = this.token;
			this.token.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.token.FillColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.token.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(81, 0, 198);
			this.token.FocusedState.Parent = this.token;
			this.token.ForeColor = global::System.Drawing.Color.Silver;
			this.token.HoveredState.BorderColor = global::System.Drawing.Color.Gray;
			this.token.HoveredState.Parent = this.token;
			this.token.IconLeft = (global::System.Drawing.Image)componentResourceManager.GetObject("token.IconLeft");
			this.token.Location = new global::System.Drawing.Point(26, 240);
			this.token.Name = "token";
			this.token.PasswordChar = '\0';
			this.token.PlaceholderText = "";
			this.token.SelectedText = "";
			this.token.ShadowDecoration.Parent = this.token;
			this.token.Size = new global::System.Drawing.Size(327, 36);
			this.token.TabIndex = 12;
			this.token.UseSystemPasswordChar = true;
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("Segoe UI Semibold", 9.95f, global::System.Drawing.FontStyle.Bold);
			this.label4.ForeColor = global::System.Drawing.Color.FromArgb(81, 0, 198);
			this.label4.Location = new global::System.Drawing.Point(150, 349);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(51, 19);
			this.label4.TabIndex = 11;
			this.label4.Text = "sign in";
			this.label4.Click += new global::System.EventHandler(this.label4_Click);
			this.label5.AutoSize = true;
			this.label5.Font = new global::System.Drawing.Font("Segoe UI Semibold", 9.95f, global::System.Drawing.FontStyle.Bold);
			this.label5.ForeColor = global::System.Drawing.Color.Silver;
			this.label5.Location = new global::System.Drawing.Point(34, 349);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(123, 19);
			this.label5.TabIndex = 10;
			this.label5.Text = "Have an account? ";
			this.siticoneButton1.BorderColor = global::System.Drawing.Color.FromArgb(81, 0, 198);
			this.siticoneButton1.BorderRadius = 1;
			this.siticoneButton1.BorderThickness = 2;
			this.siticoneButton1.CheckedState.Parent = this.siticoneButton1;
			this.siticoneButton1.CustomImages.Parent = this.siticoneButton1;
			this.siticoneButton1.FillColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneButton1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.siticoneButton1.ForeColor = global::System.Drawing.Color.White;
			this.siticoneButton1.HoveredState.Parent = this.siticoneButton1;
			this.siticoneButton1.Location = new global::System.Drawing.Point(26, 292);
			this.siticoneButton1.Name = "siticoneButton1";
			this.siticoneButton1.ShadowDecoration.Parent = this.siticoneButton1;
			this.siticoneButton1.Size = new global::System.Drawing.Size(327, 38);
			this.siticoneButton1.TabIndex = 9;
			this.siticoneButton1.Text = "Register";
			this.siticoneButton1.Click += new global::System.EventHandler(this.siticoneButton1_Click);
			this.pass1.BorderColor = global::System.Drawing.Color.FromArgb(81, 0, 198);
			this.pass1.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.pass1.DefaultText = "Password";
			this.pass1.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.pass1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.pass1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.pass1.DisabledState.Parent = this.pass1;
			this.pass1.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.pass1.FillColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.pass1.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(81, 0, 198);
			this.pass1.FocusedState.Parent = this.pass1;
			this.pass1.ForeColor = global::System.Drawing.Color.Silver;
			this.pass1.HoveredState.BorderColor = global::System.Drawing.Color.Gray;
			this.pass1.HoveredState.Parent = this.pass1;
			this.pass1.IconLeft = (global::System.Drawing.Image)componentResourceManager.GetObject("pass1.IconLeft");
			this.pass1.Location = new global::System.Drawing.Point(26, 147);
			this.pass1.Name = "pass1";
			this.pass1.PasswordChar = '\0';
			this.pass1.PlaceholderText = "";
			this.pass1.SelectedText = "";
			this.pass1.ShadowDecoration.Parent = this.pass1;
			this.pass1.Size = new global::System.Drawing.Size(327, 36);
			this.pass1.TabIndex = 7;
			this.pass1.UseSystemPasswordChar = true;
			this.user1.Animated = false;
			this.user1.BorderColor = global::System.Drawing.Color.FromArgb(81, 0, 198);
			this.user1.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.user1.DefaultText = "Username";
			this.user1.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.user1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.user1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.user1.DisabledState.Parent = this.user1;
			this.user1.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.user1.FillColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.user1.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(81, 0, 198);
			this.user1.FocusedState.Parent = this.user1;
			this.user1.ForeColor = global::System.Drawing.Color.Silver;
			this.user1.HoveredState.BorderColor = global::System.Drawing.Color.Gray;
			this.user1.HoveredState.Parent = this.user1;
			this.user1.IconLeft = (global::System.Drawing.Image)componentResourceManager.GetObject("user1.IconLeft");
			this.user1.Location = new global::System.Drawing.Point(26, 93);
			this.user1.Name = "user1";
			this.user1.PasswordChar = '\0';
			this.user1.PlaceholderText = "";
			this.user1.SelectedText = "";
			this.user1.ShadowDecoration.Parent = this.user1;
			this.user1.Size = new global::System.Drawing.Size(327, 36);
			this.user1.TabIndex = 6;
			this.siticoneTransparentDrag1.DragEndTransparencyValue = 1.0;
			this.siticoneTransparentDrag1.DragStartTransparencyValue = 0.9;
			this.siticoneTransparentDrag1.TargetDragControl = null;
			this.siticoneTransparentDrag2.DragEndTransparencyValue = 1.0;
			this.siticoneTransparentDrag2.DragStartTransparencyValue = 0.9;
			this.siticoneTransparentDrag2.TargetDragControl = this.RegisterPanel;
			this.siticoneTransparentDrag3.DragEndTransparencyValue = 1.0;
			this.siticoneTransparentDrag3.DragStartTransparencyValue = 0.9;
			this.siticoneTransparentDrag3.TargetDragControl = this.label6;
			this.siticonePanel3.BackColor = global::System.Drawing.Color.FromArgb(32, 32, 32);
			this.siticonePanel3.Controls.Add(this.siticoneControlBox2);
			this.siticonePanel3.Controls.Add(this.siticoneControlBox1);
			this.siticonePanel3.Location = new global::System.Drawing.Point(-2, 12);
			this.siticonePanel3.Name = "siticonePanel3";
			this.siticonePanel3.ShadowDecoration.Parent = this.siticonePanel3;
			this.siticonePanel3.Size = new global::System.Drawing.Size(843, 47);
			this.siticonePanel3.TabIndex = 98;
			this.siticoneControlBox2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox2.BorderColor = global::System.Drawing.Color.FromArgb(32, 32, 32);
			this.siticoneControlBox2.FillColor = global::System.Drawing.Color.FromArgb(32, 32, 32);
			this.siticoneControlBox2.HoveredState.Parent = this.siticoneControlBox2;
			this.siticoneControlBox2.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox2.Location = new global::System.Drawing.Point(355, 7);
			this.siticoneControlBox2.Name = "siticoneControlBox2";
			this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
			this.siticoneControlBox2.Size = new global::System.Drawing.Size(45, 37);
			this.siticoneControlBox2.TabIndex = 97;
			this.siticoneControlBox2.Click += new global::System.EventHandler(this.siticoneControlBox2_Click);
			this.siticoneControlBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox1.BorderColor = global::System.Drawing.Color.FromArgb(32, 32, 32);
			this.siticoneControlBox1.ControlBoxType = global::Siticone.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
			this.siticoneControlBox1.FillColor = global::System.Drawing.Color.FromArgb(32, 32, 32);
			this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.Location = new global::System.Drawing.Point(299, 7);
			this.siticoneControlBox1.Name = "siticoneControlBox1";
			this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.Size = new global::System.Drawing.Size(50, 37);
			this.siticoneControlBox1.TabIndex = 1;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			base.ClientSize = new global::System.Drawing.Size(404, 557);
			base.Controls.Add(this.RegisterPanel);
			base.Controls.Add(this.siticonePanel3);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Register";
			this.Text = "Vegas";
			this.RegisterPanel.ResumeLayout(false);
			this.RegisterPanel.PerformLayout();
			this.siticonePanel3.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x0400006E RID: 110
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400006F RID: 111
		private global::Siticone.UI.WinForms.SiticonePanel RegisterPanel;

		// Token: 0x04000070 RID: 112
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000071 RID: 113
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000072 RID: 114
		private global::Siticone.UI.WinForms.SiticoneMaterialTextBox email;

		// Token: 0x04000073 RID: 115
		private global::Siticone.UI.WinForms.SiticoneMaterialTextBox token;

		// Token: 0x04000074 RID: 116
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000075 RID: 117
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000076 RID: 118
		private global::Siticone.UI.WinForms.SiticoneButton siticoneButton1;

		// Token: 0x04000077 RID: 119
		private global::Siticone.UI.WinForms.SiticoneMaterialTextBox pass1;

		// Token: 0x04000078 RID: 120
		private global::Siticone.UI.WinForms.SiticoneMaterialTextBox user1;

		// Token: 0x04000079 RID: 121
		private global::Siticone.UI.WinForms.SiticoneTransparentDrag siticoneTransparentDrag1;

		// Token: 0x0400007A RID: 122
		private global::Siticone.UI.WinForms.SiticoneTransparentDrag siticoneTransparentDrag2;

		// Token: 0x0400007B RID: 123
		private global::Siticone.UI.WinForms.SiticoneTransparentDrag siticoneTransparentDrag3;

		// Token: 0x0400007C RID: 124
		private global::Siticone.UI.WinForms.SiticonePanel siticonePanel3;

		// Token: 0x0400007D RID: 125
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox2;

		// Token: 0x0400007E RID: 126
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;
	}
}
