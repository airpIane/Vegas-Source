using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Siticone.UI.WinForms;

namespace Zelda.usercontrols
{
	// Token: 0x02000015 RID: 21
	public class ticket : UserControl
	{
		// Token: 0x06000087 RID: 135 RVA: 0x000B4437 File Offset: 0x000B4437
		public ticket()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000088 RID: 136 RVA: 0x000BEA70 File Offset: 0x000BEA70
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x000BEAA8 File Offset: 0x000BEAA8
		private void InitializeComponent()
		{
			this.siticonePanel17 = new SiticonePanel();
			this.siticoneButton2 = new SiticoneButton();
			this.logInRichTextBox1 = new RichTextBox();
			this.siticoneMaterialTextBox1 = new SiticoneMaterialTextBox();
			this.siticonePanel17.SuspendLayout();
			base.SuspendLayout();
			this.siticonePanel17.BorderRadius = 4;
			this.siticonePanel17.Controls.Add(this.siticoneButton2);
			this.siticonePanel17.Controls.Add(this.logInRichTextBox1);
			this.siticonePanel17.FillColor = Color.FromArgb(27, 27, 27);
			this.siticonePanel17.Location = new Point(11, 67);
			this.siticonePanel17.Name = "siticonePanel17";
			this.siticonePanel17.ShadowDecoration.Parent = this.siticonePanel17;
			this.siticonePanel17.Size = new Size(843, 489);
			this.siticonePanel17.TabIndex = 9;
			this.siticoneButton2.BorderRadius = 3;
			this.siticoneButton2.CheckedState.Parent = this.siticoneButton2;
			this.siticoneButton2.CustomImages.Parent = this.siticoneButton2;
			this.siticoneButton2.FillColor = Color.FromArgb(81, 0, 198);
			this.siticoneButton2.Font = new Font("Segoe UI", 9f);
			this.siticoneButton2.ForeColor = Color.White;
			this.siticoneButton2.HoveredState.Parent = this.siticoneButton2;
			this.siticoneButton2.Location = new Point(254, 441);
			this.siticoneButton2.Name = "siticoneButton2";
			this.siticoneButton2.ShadowDecoration.Parent = this.siticoneButton2;
			this.siticoneButton2.Size = new Size(383, 39);
			this.siticoneButton2.TabIndex = 8;
			this.siticoneButton2.Text = "Send Issue";
			this.logInRichTextBox1.BackColor = Color.FromArgb(26, 26, 26);
			this.logInRichTextBox1.BorderStyle = BorderStyle.None;
			this.logInRichTextBox1.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.logInRichTextBox1.ForeColor = Color.White;
			this.logInRichTextBox1.Location = new Point(4, 8);
			this.logInRichTextBox1.Name = "logInRichTextBox1";
			this.logInRichTextBox1.Size = new Size(836, 478);
			this.logInRichTextBox1.TabIndex = 1;
			this.logInRichTextBox1.Text = "Report Here!";
			this.siticoneMaterialTextBox1.BackColor = Color.FromArgb(14, 14, 14);
			this.siticoneMaterialTextBox1.BorderColor = Color.White;
			this.siticoneMaterialTextBox1.Cursor = Cursors.IBeam;
			this.siticoneMaterialTextBox1.DefaultText = "Discord tag";
			this.siticoneMaterialTextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			this.siticoneMaterialTextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			this.siticoneMaterialTextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			this.siticoneMaterialTextBox1.DisabledState.Parent = this.siticoneMaterialTextBox1;
			this.siticoneMaterialTextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			this.siticoneMaterialTextBox1.FillColor = Color.FromArgb(18, 18, 18);
			this.siticoneMaterialTextBox1.FocusedState.BorderColor = Color.FromArgb(81, 0, 198);
			this.siticoneMaterialTextBox1.FocusedState.Parent = this.siticoneMaterialTextBox1;
			this.siticoneMaterialTextBox1.ForeColor = Color.White;
			this.siticoneMaterialTextBox1.HoveredState.BorderColor = Color.Silver;
			this.siticoneMaterialTextBox1.HoveredState.Parent = this.siticoneMaterialTextBox1;
			this.siticoneMaterialTextBox1.Location = new Point(11, 22);
			this.siticoneMaterialTextBox1.Name = "siticoneMaterialTextBox1";
			this.siticoneMaterialTextBox1.PasswordChar = '\0';
			this.siticoneMaterialTextBox1.PlaceholderText = "";
			this.siticoneMaterialTextBox1.SelectedText = "";
			this.siticoneMaterialTextBox1.ShadowDecoration.Parent = this.siticoneMaterialTextBox1;
			this.siticoneMaterialTextBox1.Size = new Size(383, 36);
			this.siticoneMaterialTextBox1.TabIndex = 8;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(18, 18, 18);
			base.Controls.Add(this.siticonePanel17);
			base.Controls.Add(this.siticoneMaterialTextBox1);
			base.Name = "ticket";
			base.Size = new Size(864, 579);
			this.siticonePanel17.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x040000B5 RID: 181
		private IContainer components = null;

		// Token: 0x040000B6 RID: 182
		private SiticonePanel siticonePanel17;

		// Token: 0x040000B7 RID: 183
		private SiticoneButton siticoneButton2;

		// Token: 0x040000B8 RID: 184
		private RichTextBox logInRichTextBox1;

		// Token: 0x040000B9 RID: 185
		private SiticoneMaterialTextBox siticoneMaterialTextBox1;
	}
}
