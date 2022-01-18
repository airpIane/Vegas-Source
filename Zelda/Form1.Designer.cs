namespace Zelda
{
	// Token: 0x0200000D RID: 13
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x0600003C RID: 60 RVA: 0x000B7470 File Offset: 0x000B7470
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000B74A8 File Offset: 0x000B74A8
		private void InitializeComponent()
		{
			global::Siticone.UI.AnimatorNS.Animation animation = new global::Siticone.UI.AnimatorNS.Animation();
			global::Siticone.UI.AnimatorNS.Animation animation2 = new global::Siticone.UI.AnimatorNS.Animation();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Zelda.Form1));
			this.siticoneTransparentDrag3 = new global::Siticone.UI.WinForms.SiticoneTransparentDrag();
			this.siticoneMaterialTextBox1 = new global::Siticone.UI.WinForms.SiticoneMaterialTextBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label12 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.LoginBTN = new global::Siticone.UI.WinForms.SiticoneButton();
			this.pass = new global::Siticone.UI.WinForms.SiticoneMaterialTextBox();
			this.siticoneTransition1 = new global::Siticone.UI.WinForms.SiticoneTransition();
			this.user = new global::Siticone.UI.WinForms.SiticoneMaterialTextBox();
			this.siticoneControlBox2 = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.siticonePanel3 = new global::Siticone.UI.WinForms.SiticonePanel();
			this.siticoneControlBox1 = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.siticonePanel1 = new global::Siticone.UI.WinForms.SiticonePanel();
			this.siticoneTransparentDrag1 = new global::Siticone.UI.WinForms.SiticoneTransparentDrag();
			this.Trans = new global::Siticone.UI.WinForms.SiticoneTransition();
			this.siticoneTransparentDrag2 = new global::Siticone.UI.WinForms.SiticoneTransparentDrag();
			this.siticonePanel3.SuspendLayout();
			this.siticonePanel1.SuspendLayout();
			base.SuspendLayout();
			this.siticoneTransparentDrag3.DragEndTransparencyValue = 1.0;
			this.siticoneTransparentDrag3.DragStartTransparencyValue = 0.9;
			this.siticoneTransparentDrag3.TargetDragControl = null;
			this.siticoneMaterialTextBox1.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.Trans.SetDecoration(this.siticoneMaterialTextBox1, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.siticoneTransition1.SetDecoration(this.siticoneMaterialTextBox1, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.siticoneMaterialTextBox1.DefaultText = "";
			this.siticoneMaterialTextBox1.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.siticoneMaterialTextBox1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.siticoneMaterialTextBox1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.siticoneMaterialTextBox1.DisabledState.Parent = this.siticoneMaterialTextBox1;
			this.siticoneMaterialTextBox1.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.siticoneMaterialTextBox1.FillColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneMaterialTextBox1.FocusedState.BorderColor = global::System.Drawing.Color.Red;
			this.siticoneMaterialTextBox1.FocusedState.Parent = this.siticoneMaterialTextBox1;
			this.siticoneMaterialTextBox1.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.siticoneMaterialTextBox1.HoveredState.Parent = this.siticoneMaterialTextBox1;
			this.siticoneMaterialTextBox1.Location = new global::System.Drawing.Point(113, 370);
			this.siticoneMaterialTextBox1.Name = "siticoneMaterialTextBox1";
			this.siticoneMaterialTextBox1.PasswordChar = '\0';
			this.siticoneMaterialTextBox1.PlaceholderText = "";
			this.siticoneMaterialTextBox1.SelectedText = "";
			this.siticoneMaterialTextBox1.ShadowDecoration.Parent = this.siticoneMaterialTextBox1;
			this.siticoneMaterialTextBox1.Size = new global::System.Drawing.Size(200, 36);
			this.siticoneMaterialTextBox1.TabIndex = 84;
			this.label3.AutoSize = true;
			this.label3.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.label3, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.Trans.SetDecoration(this.label3, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.label3.Font = new global::System.Drawing.Font("Segoe UI Semibold", 16f, global::System.Drawing.FontStyle.Bold);
			this.label3.ForeColor = global::System.Drawing.Color.FromArgb(81, 0, 198);
			this.label3.Location = new global::System.Drawing.Point(19, 43);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(205, 30);
			this.label3.TabIndex = 83;
			this.label3.Text = "LET'S SIGN YOU IN.";
			this.label12.AutoSize = true;
			this.label12.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.label12, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.Trans.SetDecoration(this.label12, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.label12.Font = new global::System.Drawing.Font("Segoe UI Semibold", 11f, global::System.Drawing.FontStyle.Bold);
			this.label12.ForeColor = global::System.Drawing.Color.FromArgb(221, 180, 180, 180);
			this.label12.Location = new global::System.Drawing.Point(20, 24);
			this.label12.Name = "label12";
			this.label12.Size = new global::System.Drawing.Size(176, 20);
			this.label12.TabIndex = 82;
			this.label12.Text = "Welcome to Vegas Panel";
			this.label2.AutoSize = true;
			this.siticoneTransition1.SetDecoration(this.label2, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.Trans.SetDecoration(this.label2, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.label2.Font = new global::System.Drawing.Font("Segoe UI Semibold", 9.95f, global::System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = global::System.Drawing.Color.FromArgb(81, 0, 198);
			this.label2.Location = new global::System.Drawing.Point(86, 321);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(57, 19);
			this.label2.TabIndex = 5;
			this.label2.Text = "Sign up";
			this.label2.Click += new global::System.EventHandler(this.label2_Click);
			this.label1.AutoSize = true;
			this.siticoneTransition1.SetDecoration(this.label1, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.Trans.SetDecoration(this.label1, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.label1.Font = new global::System.Drawing.Font("Segoe UI Semibold", 9.95f, global::System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = global::System.Drawing.Color.Silver;
			this.label1.Location = new global::System.Drawing.Point(19, 321);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(72, 19);
			this.label1.TabIndex = 4;
			this.label1.Text = "New User,";
			this.LoginBTN.BorderColor = global::System.Drawing.Color.FromArgb(81, 0, 198);
			this.LoginBTN.BorderRadius = 1;
			this.LoginBTN.BorderThickness = 2;
			this.LoginBTN.CheckedState.Parent = this.LoginBTN;
			this.LoginBTN.CustomImages.Parent = this.LoginBTN;
			this.Trans.SetDecoration(this.LoginBTN, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.siticoneTransition1.SetDecoration(this.LoginBTN, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.LoginBTN.FillColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.LoginBTN.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.LoginBTN.ForeColor = global::System.Drawing.Color.White;
			this.LoginBTN.HoveredState.Parent = this.LoginBTN;
			this.LoginBTN.Location = new global::System.Drawing.Point(18, 238);
			this.LoginBTN.Name = "LoginBTN";
			this.LoginBTN.ShadowDecoration.Parent = this.LoginBTN;
			this.LoginBTN.Size = new global::System.Drawing.Size(327, 38);
			this.LoginBTN.TabIndex = 3;
			this.LoginBTN.Text = "Login";
			this.LoginBTN.Click += new global::System.EventHandler(this.LoginBTN_Click);
			this.pass.BorderColor = global::System.Drawing.Color.FromArgb(81, 0, 198);
			this.pass.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.Trans.SetDecoration(this.pass, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.siticoneTransition1.SetDecoration(this.pass, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.pass.DefaultText = "Password";
			this.pass.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.pass.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.pass.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.pass.DisabledState.Parent = this.pass;
			this.pass.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.pass.FillColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.pass.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(81, 0, 198);
			this.pass.FocusedState.Parent = this.pass;
			this.pass.ForeColor = global::System.Drawing.Color.Silver;
			this.pass.HoveredState.BorderColor = global::System.Drawing.Color.Gray;
			this.pass.HoveredState.Parent = this.pass;
			this.pass.IconLeft = (global::System.Drawing.Image)componentResourceManager.GetObject("pass.IconLeft");
			this.pass.Location = new global::System.Drawing.Point(18, 159);
			this.pass.Name = "pass";
			this.pass.PasswordChar = '\0';
			this.pass.PlaceholderText = "";
			this.pass.SelectedText = "";
			this.pass.ShadowDecoration.Parent = this.pass;
			this.pass.Size = new global::System.Drawing.Size(327, 36);
			this.pass.TabIndex = 1;
			this.pass.UseSystemPasswordChar = true;
			this.siticoneTransition1.Cursor = null;
			animation.AnimateOnlyDifferences = true;
			animation.BlindCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation2.BlindCoeff");
			animation.LeafCoeff = 0f;
			animation.MaxTime = 1f;
			animation.MinTime = 0f;
			animation.MosaicCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation2.MosaicCoeff");
			animation.MosaicShift = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation2.MosaicShift");
			animation.MosaicSize = 0;
			animation.Padding = new global::System.Windows.Forms.Padding(0);
			animation.RotateCoeff = 0f;
			animation.RotateLimit = 0f;
			animation.ScaleCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation2.ScaleCoeff");
			animation.SlideCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation2.SlideCoeff");
			animation.TimeCoeff = 0f;
			animation.TransparencyCoeff = 0f;
			this.siticoneTransition1.DefaultAnimation = animation;
			this.user.BorderColor = global::System.Drawing.Color.FromArgb(81, 0, 198);
			this.user.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.Trans.SetDecoration(this.user, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.siticoneTransition1.SetDecoration(this.user, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.user.DefaultText = "Username";
			this.user.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.user.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.user.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.user.DisabledState.Parent = this.user;
			this.user.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.user.FillColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.user.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(81, 0, 198);
			this.user.FocusedState.Parent = this.user;
			this.user.ForeColor = global::System.Drawing.Color.Silver;
			this.user.HoveredState.BorderColor = global::System.Drawing.Color.Gray;
			this.user.HoveredState.Parent = this.user;
			this.user.IconLeft = (global::System.Drawing.Image)componentResourceManager.GetObject("user.IconLeft");
			this.user.Location = new global::System.Drawing.Point(18, 101);
			this.user.Name = "user";
			this.user.PasswordChar = '\0';
			this.user.PlaceholderText = "";
			this.user.SelectedText = "";
			this.user.ShadowDecoration.Parent = this.user;
			this.user.Size = new global::System.Drawing.Size(327, 36);
			this.user.TabIndex = 0;
			this.siticoneControlBox2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox2.BorderColor = global::System.Drawing.Color.FromArgb(32, 32, 32);
			this.siticoneControlBox2.ControlBoxType = global::Siticone.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
			this.Trans.SetDecoration(this.siticoneControlBox2, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.siticoneTransition1.SetDecoration(this.siticoneControlBox2, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.siticoneControlBox2.FillColor = global::System.Drawing.Color.FromArgb(32, 32, 32);
			this.siticoneControlBox2.HoveredState.Parent = this.siticoneControlBox2;
			this.siticoneControlBox2.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox2.Location = new global::System.Drawing.Point(301, 7);
			this.siticoneControlBox2.Name = "siticoneControlBox2";
			this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
			this.siticoneControlBox2.Size = new global::System.Drawing.Size(50, 37);
			this.siticoneControlBox2.TabIndex = 2;
			this.siticoneControlBox2.Click += new global::System.EventHandler(this.siticoneControlBox2_Click);
			this.siticonePanel3.BackColor = global::System.Drawing.Color.FromArgb(32, 32, 32);
			this.siticonePanel3.Controls.Add(this.siticoneControlBox2);
			this.siticonePanel3.Controls.Add(this.siticoneControlBox1);
			this.Trans.SetDecoration(this.siticonePanel3, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.siticoneTransition1.SetDecoration(this.siticonePanel3, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.siticonePanel3.Location = new global::System.Drawing.Point(-1, -1);
			this.siticonePanel3.Name = "siticonePanel3";
			this.siticonePanel3.ShadowDecoration.Parent = this.siticonePanel3;
			this.siticonePanel3.Size = new global::System.Drawing.Size(843, 52);
			this.siticonePanel3.TabIndex = 97;
			this.siticoneControlBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox1.BorderColor = global::System.Drawing.Color.FromArgb(32, 32, 32);
			this.Trans.SetDecoration(this.siticoneControlBox1, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.siticoneTransition1.SetDecoration(this.siticoneControlBox1, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.siticoneControlBox1.FillColor = global::System.Drawing.Color.FromArgb(32, 32, 32);
			this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.Location = new global::System.Drawing.Point(357, 7);
			this.siticoneControlBox1.Name = "siticoneControlBox1";
			this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.Size = new global::System.Drawing.Size(45, 37);
			this.siticoneControlBox1.TabIndex = 0;
			this.siticonePanel1.Controls.Add(this.siticoneMaterialTextBox1);
			this.siticonePanel1.Controls.Add(this.label3);
			this.siticonePanel1.Controls.Add(this.label12);
			this.siticonePanel1.Controls.Add(this.label2);
			this.siticonePanel1.Controls.Add(this.label1);
			this.siticonePanel1.Controls.Add(this.LoginBTN);
			this.siticonePanel1.Controls.Add(this.pass);
			this.siticonePanel1.Controls.Add(this.user);
			this.Trans.SetDecoration(this.siticonePanel1, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.siticoneTransition1.SetDecoration(this.siticonePanel1, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.siticonePanel1.Location = new global::System.Drawing.Point(12, 54);
			this.siticonePanel1.Name = "siticonePanel1";
			this.siticonePanel1.ShadowDecoration.Parent = this.siticonePanel1;
			this.siticonePanel1.Size = new global::System.Drawing.Size(382, 502);
			this.siticonePanel1.TabIndex = 96;
			this.siticoneTransparentDrag1.DragEndTransparencyValue = 1.0;
			this.siticoneTransparentDrag1.DragStartTransparencyValue = 0.9;
			this.siticoneTransparentDrag1.TargetDragControl = this.siticonePanel3;
			this.Trans.AnimationType = global::Siticone.UI.AnimatorNS.AnimationType.ScaleAndRotate;
			this.Trans.Cursor = null;
			animation2.AnimateOnlyDifferences = true;
			animation2.BlindCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation1.BlindCoeff");
			animation2.LeafCoeff = 0f;
			animation2.MaxTime = 1f;
			animation2.MinTime = 0f;
			animation2.MosaicCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation1.MosaicCoeff");
			animation2.MosaicShift = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation1.MosaicShift");
			animation2.MosaicSize = 0;
			animation2.Padding = new global::System.Windows.Forms.Padding(30);
			animation2.RotateCoeff = 0.5f;
			animation2.RotateLimit = 0.2f;
			animation2.ScaleCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation1.ScaleCoeff");
			animation2.SlideCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation1.SlideCoeff");
			animation2.TimeCoeff = 0f;
			animation2.TransparencyCoeff = 0f;
			this.Trans.DefaultAnimation = animation2;
			this.siticoneTransparentDrag2.DragEndTransparencyValue = 1.0;
			this.siticoneTransparentDrag2.DragStartTransparencyValue = 0.9;
			this.siticoneTransparentDrag2.TargetDragControl = this.siticonePanel3;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			base.ClientSize = new global::System.Drawing.Size(404, 554);
			base.Controls.Add(this.siticonePanel3);
			base.Controls.Add(this.siticonePanel1);
			this.Trans.SetDecoration(this, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.siticoneTransition1.SetDecoration(this, global::Siticone.UI.AnimatorNS.DecorationType.None);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Form1";
			this.Text = "Vegas";
			this.siticonePanel3.ResumeLayout(false);
			this.siticonePanel1.ResumeLayout(false);
			this.siticonePanel1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000047 RID: 71
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000048 RID: 72
		private global::Siticone.UI.WinForms.SiticoneTransparentDrag siticoneTransparentDrag3;

		// Token: 0x04000049 RID: 73
		private global::Siticone.UI.WinForms.SiticoneMaterialTextBox siticoneMaterialTextBox1;

		// Token: 0x0400004A RID: 74
		private global::Siticone.UI.WinForms.SiticoneTransition Trans;

		// Token: 0x0400004B RID: 75
		private global::Siticone.UI.WinForms.SiticoneTransition siticoneTransition1;

		// Token: 0x0400004C RID: 76
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400004D RID: 77
		private global::System.Windows.Forms.Label label12;

		// Token: 0x0400004E RID: 78
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400004F RID: 79
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000050 RID: 80
		private global::Siticone.UI.WinForms.SiticoneButton LoginBTN;

		// Token: 0x04000051 RID: 81
		private global::Siticone.UI.WinForms.SiticoneMaterialTextBox pass;

		// Token: 0x04000052 RID: 82
		private global::Siticone.UI.WinForms.SiticoneMaterialTextBox user;

		// Token: 0x04000053 RID: 83
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox2;

		// Token: 0x04000054 RID: 84
		private global::Siticone.UI.WinForms.SiticonePanel siticonePanel3;

		// Token: 0x04000055 RID: 85
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;

		// Token: 0x04000056 RID: 86
		private global::Siticone.UI.WinForms.SiticonePanel siticonePanel1;

		// Token: 0x04000057 RID: 87
		private global::Siticone.UI.WinForms.SiticoneTransparentDrag siticoneTransparentDrag1;

		// Token: 0x04000058 RID: 88
		private global::Siticone.UI.WinForms.SiticoneTransparentDrag siticoneTransparentDrag2;
	}
}
