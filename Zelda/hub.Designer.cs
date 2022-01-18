namespace Zelda
{
	// Token: 0x0200000E RID: 14
	public partial class hub : global::System.Windows.Forms.Form
	{
		// Token: 0x0600005C RID: 92 RVA: 0x000B8A8C File Offset: 0x000B8A8C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000B8AC4 File Offset: 0x000B8AC4
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Siticone.UI.AnimatorNS.Animation animation = new global::Siticone.UI.AnimatorNS.Animation();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Zelda.hub));
			this.Trans = new global::Siticone.UI.WinForms.SiticoneTransition();
			this.label2 = new global::System.Windows.Forms.Label();
			this.siticonePanel1 = new global::Siticone.UI.WinForms.SiticonePanel();
			this.DashBTN = new global::Siticone.UI.WinForms.SiticoneButton();
			this.DiscordBTN = new global::Siticone.UI.WinForms.SiticoneButton();
			this.ToolBTN = new global::Siticone.UI.WinForms.SiticoneButton();
			this.AttackBTN = new global::Siticone.UI.WinForms.SiticoneButton();
			this.dashboard1 = new global::Zelda.dashboard();
			this.attack1 = new global::Zelda.usercontrols.attack();
			this.spammer1 = new global::Zelda.usercontrols.spammer();
			this.tools1 = new global::Zelda.usercontrols.tools();
			this.siticoneControlBox2 = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.siticoneControlBox1 = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.siticoneTransparentDrag1 = new global::Siticone.UI.WinForms.SiticoneTransparentDrag();
			this.cooldown = new global::System.Windows.Forms.Timer(this.components);
			this.siticonePanel1.SuspendLayout();
			base.SuspendLayout();
			this.Trans.AnimationType = global::Siticone.UI.AnimatorNS.AnimationType.ScaleAndRotate;
			this.Trans.Cursor = null;
			animation.AnimateOnlyDifferences = true;
			animation.BlindCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation1.BlindCoeff");
			animation.LeafCoeff = 0f;
			animation.MaxTime = 1f;
			animation.MinTime = 0f;
			animation.MosaicCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation1.MosaicCoeff");
			animation.MosaicShift = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation1.MosaicShift");
			animation.MosaicSize = 0;
			animation.Padding = new global::System.Windows.Forms.Padding(30);
			animation.RotateCoeff = 0.5f;
			animation.RotateLimit = 0.2f;
			animation.ScaleCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation1.ScaleCoeff");
			animation.SlideCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation1.SlideCoeff");
			animation.TimeCoeff = 0f;
			animation.TransparencyCoeff = 0f;
			this.Trans.DefaultAnimation = animation;
			this.label2.AutoSize = true;
			this.label2.BackColor = global::System.Drawing.Color.Transparent;
			this.Trans.SetDecoration(this.label2, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.label2.Font = new global::System.Drawing.Font("Segoe UI Semibold", 11f, global::System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = global::System.Drawing.Color.FromArgb(221, 180, 180, 180);
			this.label2.Location = new global::System.Drawing.Point(114, 3);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(91, 20);
			this.label2.TabIndex = 91;
			this.label2.Text = "Vegas Panel";
			this.siticonePanel1.BorderColor = global::System.Drawing.Color.FromArgb(255, 128, 128);
			this.siticonePanel1.BorderRadius = 18;
			this.siticonePanel1.Controls.Add(this.DashBTN);
			this.siticonePanel1.Controls.Add(this.DiscordBTN);
			this.siticonePanel1.Controls.Add(this.ToolBTN);
			this.siticonePanel1.Controls.Add(this.AttackBTN);
			this.Trans.SetDecoration(this.siticonePanel1, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.siticonePanel1.FillColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticonePanel1.Location = new global::System.Drawing.Point(8, 11);
			this.siticonePanel1.Name = "siticonePanel1";
			this.siticonePanel1.ShadowDecoration.Parent = this.siticonePanel1;
			this.siticonePanel1.Size = new global::System.Drawing.Size(100, 603);
			this.siticonePanel1.TabIndex = 84;
			this.siticonePanel1.Paint += new global::System.Windows.Forms.PaintEventHandler(this.siticonePanel1_Paint);
			this.DashBTN.BorderColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.DashBTN.CheckedState.Parent = this.DashBTN;
			this.DashBTN.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.DashBTN.CustomImages.Parent = this.DashBTN;
			this.Trans.SetDecoration(this.DashBTN, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.DashBTN.FillColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.DashBTN.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.DashBTN.ForeColor = global::System.Drawing.Color.White;
			this.DashBTN.HoveredState.FillColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.DashBTN.HoveredState.Parent = this.DashBTN;
			this.DashBTN.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("DashBTN.Image");
			this.DashBTN.ImageSize = new global::System.Drawing.Size(28, 28);
			this.DashBTN.Location = new global::System.Drawing.Point(19, 98);
			this.DashBTN.Name = "DashBTN";
			this.DashBTN.PressedColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.DashBTN.ShadowDecoration.Parent = this.DashBTN;
			this.DashBTN.Size = new global::System.Drawing.Size(64, 49);
			this.DashBTN.TabIndex = 1;
			this.DashBTN.Click += new global::System.EventHandler(this.DashBTN_Click);
			this.DiscordBTN.BorderColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.DiscordBTN.CheckedState.Parent = this.DiscordBTN;
			this.DiscordBTN.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.DiscordBTN.CustomImages.Parent = this.DiscordBTN;
			this.Trans.SetDecoration(this.DiscordBTN, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.DiscordBTN.FillColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.DiscordBTN.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.DiscordBTN.ForeColor = global::System.Drawing.Color.White;
			this.DiscordBTN.HoveredState.FillColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.DiscordBTN.HoveredState.Parent = this.DiscordBTN;
			this.DiscordBTN.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("DiscordBTN.Image");
			this.DiscordBTN.ImageSize = new global::System.Drawing.Size(26, 26);
			this.DiscordBTN.Location = new global::System.Drawing.Point(19, 251);
			this.DiscordBTN.Name = "DiscordBTN";
			this.DiscordBTN.PressedColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.DiscordBTN.ShadowDecoration.Parent = this.DiscordBTN;
			this.DiscordBTN.Size = new global::System.Drawing.Size(64, 49);
			this.DiscordBTN.TabIndex = 4;
			this.DiscordBTN.TextOffset = new global::System.Drawing.Point(2, 0);
			this.DiscordBTN.Click += new global::System.EventHandler(this.DiscordBTN_Click);
			this.ToolBTN.BorderColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.ToolBTN.CheckedState.Parent = this.ToolBTN;
			this.ToolBTN.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.ToolBTN.CustomImages.Parent = this.ToolBTN;
			this.Trans.SetDecoration(this.ToolBTN, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.ToolBTN.FillColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.ToolBTN.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.ToolBTN.ForeColor = global::System.Drawing.Color.White;
			this.ToolBTN.HoveredState.FillColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.ToolBTN.HoveredState.Parent = this.ToolBTN;
			this.ToolBTN.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ToolBTN.Image");
			this.ToolBTN.ImageSize = new global::System.Drawing.Size(26, 26);
			this.ToolBTN.Location = new global::System.Drawing.Point(19, 200);
			this.ToolBTN.Name = "ToolBTN";
			this.ToolBTN.PressedColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.ToolBTN.ShadowDecoration.Parent = this.ToolBTN;
			this.ToolBTN.Size = new global::System.Drawing.Size(64, 49);
			this.ToolBTN.TabIndex = 3;
			this.ToolBTN.TextOffset = new global::System.Drawing.Point(2, 0);
			this.ToolBTN.Click += new global::System.EventHandler(this.ToolBTN_Click);
			this.AttackBTN.BorderColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.AttackBTN.CheckedState.Parent = this.AttackBTN;
			this.AttackBTN.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.AttackBTN.CustomImages.Parent = this.AttackBTN;
			this.Trans.SetDecoration(this.AttackBTN, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.AttackBTN.FillColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.AttackBTN.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.AttackBTN.ForeColor = global::System.Drawing.Color.White;
			this.AttackBTN.HoveredState.FillColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.AttackBTN.HoveredState.Parent = this.AttackBTN;
			this.AttackBTN.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("AttackBTN.Image");
			this.AttackBTN.ImageSize = new global::System.Drawing.Size(26, 26);
			this.AttackBTN.Location = new global::System.Drawing.Point(19, 149);
			this.AttackBTN.Name = "AttackBTN";
			this.AttackBTN.PressedColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.AttackBTN.ShadowDecoration.Parent = this.AttackBTN;
			this.AttackBTN.Size = new global::System.Drawing.Size(64, 49);
			this.AttackBTN.TabIndex = 2;
			this.AttackBTN.Click += new global::System.EventHandler(this.AttackBTN_Click);
			this.dashboard1.BackColor = global::System.Drawing.Color.FromArgb(18, 18, 18);
			this.Trans.SetDecoration(this.dashboard1, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.dashboard1.Location = new global::System.Drawing.Point(114, 30);
			this.dashboard1.Name = "dashboard1";
			this.dashboard1.Size = new global::System.Drawing.Size(861, 575);
			this.dashboard1.TabIndex = 92;
			this.dashboard1.Visible = false;
			this.attack1.BackColor = global::System.Drawing.Color.FromArgb(18, 18, 18);
			this.Trans.SetDecoration(this.attack1, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.attack1.Location = new global::System.Drawing.Point(114, 30);
			this.attack1.Name = "attack1";
			this.attack1.Size = new global::System.Drawing.Size(861, 575);
			this.attack1.TabIndex = 93;
			this.spammer1.BackColor = global::System.Drawing.Color.FromArgb(18, 18, 18);
			this.Trans.SetDecoration(this.spammer1, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.spammer1.Location = new global::System.Drawing.Point(114, 30);
			this.spammer1.Name = "spammer1";
			this.spammer1.Size = new global::System.Drawing.Size(864, 579);
			this.spammer1.TabIndex = 94;
			this.spammer1.Visible = false;
			this.tools1.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.Trans.SetDecoration(this.tools1, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.tools1.Location = new global::System.Drawing.Point(114, 30);
			this.tools1.Name = "tools1";
			this.tools1.Size = new global::System.Drawing.Size(861, 575);
			this.tools1.TabIndex = 95;
			this.tools1.Visible = false;
			this.siticoneControlBox2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox2.BorderColor = global::System.Drawing.Color.FromArgb(32, 32, 32);
			this.siticoneControlBox2.ControlBoxType = global::Siticone.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
			this.Trans.SetDecoration(this.siticoneControlBox2, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.siticoneControlBox2.FillColor = global::System.Drawing.Color.FromArgb(32, 32, 32);
			this.siticoneControlBox2.HoveredState.Parent = this.siticoneControlBox2;
			this.siticoneControlBox2.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox2.Location = new global::System.Drawing.Point(877, 3);
			this.siticoneControlBox2.Name = "siticoneControlBox2";
			this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
			this.siticoneControlBox2.Size = new global::System.Drawing.Size(50, 37);
			this.siticoneControlBox2.TabIndex = 97;
			this.siticoneControlBox2.Click += new global::System.EventHandler(this.siticoneControlBox2_Click);
			this.siticoneControlBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox1.BorderColor = global::System.Drawing.Color.FromArgb(32, 32, 32);
			this.Trans.SetDecoration(this.siticoneControlBox1, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.siticoneControlBox1.FillColor = global::System.Drawing.Color.FromArgb(32, 32, 32);
			this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.Location = new global::System.Drawing.Point(933, 3);
			this.siticoneControlBox1.Name = "siticoneControlBox1";
			this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.Size = new global::System.Drawing.Size(45, 37);
			this.siticoneControlBox1.TabIndex = 96;
			this.siticoneControlBox1.Click += new global::System.EventHandler(this.siticoneControlBox1_Click);
			this.siticoneTransparentDrag1.DragEndTransparencyValue = 1.0;
			this.siticoneTransparentDrag1.DragStartTransparencyValue = 0.9;
			this.siticoneTransparentDrag1.TargetDragControl = this.siticonePanel1;
			this.cooldown.Interval = 1000;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(18, 18, 18);
			base.ClientSize = new global::System.Drawing.Size(987, 617);
			base.Controls.Add(this.siticoneControlBox2);
			base.Controls.Add(this.siticoneControlBox1);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.siticonePanel1);
			base.Controls.Add(this.attack1);
			base.Controls.Add(this.dashboard1);
			base.Controls.Add(this.tools1);
			base.Controls.Add(this.spammer1);
			this.Trans.SetDecoration(this, global::Siticone.UI.AnimatorNS.DecorationType.None);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "hub";
			this.Text = "Vegas";
			base.Load += new global::System.EventHandler(this.hub_Load);
			this.siticonePanel1.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400005E RID: 94
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400005F RID: 95
		private global::Siticone.UI.WinForms.SiticoneTransition Trans;

		// Token: 0x04000060 RID: 96
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000061 RID: 97
		private global::Siticone.UI.WinForms.SiticonePanel siticonePanel1;

		// Token: 0x04000062 RID: 98
		private global::Siticone.UI.WinForms.SiticoneButton DashBTN;

		// Token: 0x04000063 RID: 99
		private global::Siticone.UI.WinForms.SiticoneButton ToolBTN;

		// Token: 0x04000064 RID: 100
		private global::Siticone.UI.WinForms.SiticoneButton AttackBTN;

		// Token: 0x04000065 RID: 101
		private global::Siticone.UI.WinForms.SiticoneTransparentDrag siticoneTransparentDrag1;

		// Token: 0x04000066 RID: 102
		private global::System.Windows.Forms.Timer cooldown;

		// Token: 0x04000067 RID: 103
		private global::Zelda.dashboard dashboard1;

		// Token: 0x04000068 RID: 104
		private global::Zelda.usercontrols.attack attack1;

		// Token: 0x04000069 RID: 105
		private global::Zelda.usercontrols.spammer spammer1;

		// Token: 0x0400006A RID: 106
		private global::Zelda.usercontrols.tools tools1;

		// Token: 0x0400006B RID: 107
		private global::Siticone.UI.WinForms.SiticoneButton DiscordBTN;

		// Token: 0x0400006C RID: 108
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox2;

		// Token: 0x0400006D RID: 109
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;
	}
}
