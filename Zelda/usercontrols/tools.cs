using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Siticone.UI.WinForms;

namespace Zelda.usercontrols
{
	// Token: 0x02000016 RID: 22
	public class tools : UserControl
	{
		// Token: 0x0600008A RID: 138 RVA: 0x000B444F File Offset: 0x000B444F
		public tools()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600008B RID: 139 RVA: 0x000BF008 File Offset: 0x000BF008
		[DebuggerStepThrough]
		private void siticoneButton19_Click(object sender, EventArgs e)
		{
			tools.<siticoneButton19_Click>d__1 <siticoneButton19_Click>d__ = new tools.<siticoneButton19_Click>d__1();
			<siticoneButton19_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<siticoneButton19_Click>d__.<>4__this = this;
			<siticoneButton19_Click>d__.sender = sender;
			<siticoneButton19_Click>d__.e = e;
			<siticoneButton19_Click>d__.<>1__state = -1;
			<siticoneButton19_Click>d__.<>t__builder.Start<tools.<siticoneButton19_Click>d__1>(ref <siticoneButton19_Click>d__);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x000BF050 File Offset: 0x000BF050
		private void pingBTN_Click(object sender, EventArgs e)
		{
			Process.Start(new ProcessStartInfo
			{
				FileName = "C:\\windows\\system32\\cmd.exe",
				Arguments = "/c ping -t " + this.tcpip.Text + " "
			});
			this.tcpip.Focus();
		}

		// Token: 0x0600008D RID: 141 RVA: 0x000BF0A4 File Offset: 0x000BF0A4
		private void PapingBTN_Click(object sender, EventArgs e)
		{
			try
			{
				Process[] processesByName = Process.GetProcessesByName("paping");
				new Process
				{
					StartInfo = 
					{
						UseShellExecute = false,
						FileName = "paping.exe",
						Arguments = this.tcpip.Text + " -p " + this.tcpport.Text
					}
				}.Start();
			}
			catch
			{
				MessageBox.Show("Error: Missing paping.exe");
			}
		}

		// Token: 0x0600008E RID: 142 RVA: 0x000BF138 File Offset: 0x000BF138
		private void lookupBTN_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("http://ip-api.com/line/" + this.lookup.Text);
			MessageBox.Show(this, text);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x000BF170 File Offset: 0x000BF170
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x000BF1A8 File Offset: 0x000BF1A8
		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(tools));
			this.siticonePanel18 = new SiticonePanel();
			this.richip = new RichTextBox();
			this.siticonePanel13 = new SiticonePanel();
			this.siticoneButton16 = new SiticoneButton();
			this.label27 = new Label();
			this.lookupBTN = new SiticoneButton();
			this.lookup = new SiticoneMaterialTextBox();
			this.siticonePanel12 = new SiticonePanel();
			this.siticoneButton14 = new SiticoneButton();
			this.PapingBTN = new SiticoneButton();
			this.label28 = new Label();
			this.pingBTN = new SiticoneButton();
			this.tcpport = new SiticoneMaterialTextBox();
			this.tcpip = new SiticoneMaterialTextBox();
			this.siticonePanel14 = new SiticonePanel();
			this.siticoneButton17 = new SiticoneButton();
			this.label29 = new Label();
			this.siticoneButton19 = new SiticoneButton();
			this.Portip = new SiticoneMaterialTextBox();
			this.siticonePanel18.SuspendLayout();
			this.siticonePanel13.SuspendLayout();
			this.siticonePanel12.SuspendLayout();
			this.siticonePanel14.SuspendLayout();
			base.SuspendLayout();
			this.siticonePanel18.BorderRadius = 18;
			this.siticonePanel18.Controls.Add(this.richip);
			this.siticonePanel18.FillColor = Color.FromArgb(27, 27, 27);
			this.siticonePanel18.Location = new Point(436, 269);
			this.siticonePanel18.Name = "siticonePanel18";
			this.siticonePanel18.ShadowDecoration.Parent = this.siticonePanel18;
			this.siticonePanel18.Size = new Size(399, 291);
			this.siticonePanel18.TabIndex = 14;
			this.richip.BackColor = Color.FromArgb(27, 27, 27);
			this.richip.BorderStyle = BorderStyle.None;
			this.richip.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.richip.ForeColor = Color.White;
			this.richip.Location = new Point(5, 4);
			this.richip.Name = "richip";
			this.richip.ReadOnly = true;
			this.richip.ScrollBars = RichTextBoxScrollBars.None;
			this.richip.Size = new Size(391, 284);
			this.richip.TabIndex = 9;
			this.richip.Text = "";
			this.siticonePanel13.BorderRadius = 18;
			this.siticonePanel13.Controls.Add(this.siticoneButton16);
			this.siticonePanel13.Controls.Add(this.label27);
			this.siticonePanel13.Controls.Add(this.lookupBTN);
			this.siticonePanel13.Controls.Add(this.lookup);
			this.siticonePanel13.FillColor = Color.FromArgb(27, 27, 27);
			this.siticonePanel13.Location = new Point(436, 14);
			this.siticonePanel13.Name = "siticonePanel13";
			this.siticonePanel13.ShadowDecoration.Parent = this.siticonePanel13;
			this.siticonePanel13.Size = new Size(399, 246);
			this.siticonePanel13.TabIndex = 12;
			this.siticoneButton16.BorderColor = Color.FromArgb(27, 27, 27);
			this.siticoneButton16.CheckedState.Parent = this.siticoneButton16;
			this.siticoneButton16.CustomBorderColor = Color.Transparent;
			this.siticoneButton16.CustomImages.Parent = this.siticoneButton16;
			this.siticoneButton16.FillColor = Color.FromArgb(27, 27, 27);
			this.siticoneButton16.Font = new Font("Segoe UI", 9f);
			this.siticoneButton16.ForeColor = Color.White;
			this.siticoneButton16.HoveredState.Parent = this.siticoneButton16;
			this.siticoneButton16.Image = (Image)componentResourceManager.GetObject("siticoneButton16.Image");
			this.siticoneButton16.ImageSize = new Size(28, 28);
			this.siticoneButton16.Location = new Point(5, 9);
			this.siticoneButton16.Name = "siticoneButton16";
			this.siticoneButton16.PressedColor = Color.FromArgb(27, 27, 27);
			this.siticoneButton16.ShadowDecoration.Parent = this.siticoneButton16;
			this.siticoneButton16.Size = new Size(51, 51);
			this.siticoneButton16.TabIndex = 3;
			this.label27.AutoSize = true;
			this.label27.BackColor = Color.Transparent;
			this.label27.Font = new Font("Segoe UI Semibold", 9.95f, FontStyle.Bold);
			this.label27.ForeColor = Color.Silver;
			this.label27.Location = new Point(60, 24);
			this.label27.Name = "label27";
			this.label27.Size = new Size(71, 19);
			this.label27.TabIndex = 21;
			this.label27.Text = "IP Lookup";
			this.lookupBTN.BorderRadius = 3;
			this.lookupBTN.CheckedState.Parent = this.lookupBTN;
			this.lookupBTN.CustomImages.Parent = this.lookupBTN;
			this.lookupBTN.FillColor = Color.FromArgb(81, 0, 198);
			this.lookupBTN.Font = new Font("Segoe UI", 9f);
			this.lookupBTN.ForeColor = Color.White;
			this.lookupBTN.HoveredState.Parent = this.lookupBTN;
			this.lookupBTN.Location = new Point(12, 120);
			this.lookupBTN.Name = "lookupBTN";
			this.lookupBTN.ShadowDecoration.Parent = this.lookupBTN;
			this.lookupBTN.Size = new Size(374, 39);
			this.lookupBTN.TabIndex = 7;
			this.lookupBTN.Text = "IP Lookup";
			this.lookupBTN.Click += this.lookupBTN_Click;
			this.lookup.BorderColor = Color.White;
			this.lookup.Cursor = Cursors.IBeam;
			this.lookup.DefaultText = "Host";
			this.lookup.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			this.lookup.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			this.lookup.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			this.lookup.DisabledState.Parent = this.lookup;
			this.lookup.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			this.lookup.FillColor = Color.FromArgb(27, 27, 27);
			this.lookup.FocusedState.BorderColor = Color.FromArgb(81, 0, 198);
			this.lookup.FocusedState.Parent = this.lookup;
			this.lookup.ForeColor = Color.White;
			this.lookup.HoveredState.BorderColor = Color.Silver;
			this.lookup.HoveredState.Parent = this.lookup;
			this.lookup.Location = new Point(12, 64);
			this.lookup.Name = "lookup";
			this.lookup.PasswordChar = '\0';
			this.lookup.PlaceholderText = "";
			this.lookup.SelectedText = "";
			this.lookup.ShadowDecoration.Parent = this.lookup;
			this.lookup.Size = new Size(374, 36);
			this.lookup.TabIndex = 0;
			this.siticonePanel12.BorderRadius = 18;
			this.siticonePanel12.Controls.Add(this.siticoneButton14);
			this.siticonePanel12.Controls.Add(this.PapingBTN);
			this.siticonePanel12.Controls.Add(this.label28);
			this.siticonePanel12.Controls.Add(this.pingBTN);
			this.siticonePanel12.Controls.Add(this.tcpport);
			this.siticonePanel12.Controls.Add(this.tcpip);
			this.siticonePanel12.FillColor = Color.FromArgb(27, 27, 27);
			this.siticonePanel12.Location = new Point(25, 14);
			this.siticonePanel12.Name = "siticonePanel12";
			this.siticonePanel12.ShadowDecoration.Parent = this.siticonePanel12;
			this.siticonePanel12.Size = new Size(399, 246);
			this.siticonePanel12.TabIndex = 11;
			this.siticoneButton14.BorderColor = Color.FromArgb(27, 27, 27);
			this.siticoneButton14.CheckedState.Parent = this.siticoneButton14;
			this.siticoneButton14.CustomBorderColor = Color.Transparent;
			this.siticoneButton14.CustomImages.Parent = this.siticoneButton14;
			this.siticoneButton14.FillColor = Color.FromArgb(27, 27, 27);
			this.siticoneButton14.Font = new Font("Segoe UI", 9f);
			this.siticoneButton14.ForeColor = Color.White;
			this.siticoneButton14.HoveredState.Parent = this.siticoneButton14;
			this.siticoneButton14.Image = (Image)componentResourceManager.GetObject("siticoneButton14.Image");
			this.siticoneButton14.ImageSize = new Size(28, 28);
			this.siticoneButton14.Location = new Point(4, 7);
			this.siticoneButton14.Name = "siticoneButton14";
			this.siticoneButton14.PressedColor = Color.FromArgb(27, 27, 27);
			this.siticoneButton14.ShadowDecoration.Parent = this.siticoneButton14;
			this.siticoneButton14.Size = new Size(51, 51);
			this.siticoneButton14.TabIndex = 4;
			this.PapingBTN.BorderRadius = 3;
			this.PapingBTN.CheckedState.Parent = this.PapingBTN;
			this.PapingBTN.CustomImages.Parent = this.PapingBTN;
			this.PapingBTN.FillColor = Color.FromArgb(81, 0, 198);
			this.PapingBTN.Font = new Font("Segoe UI", 9f);
			this.PapingBTN.ForeColor = Color.White;
			this.PapingBTN.HoveredState.Parent = this.PapingBTN;
			this.PapingBTN.Location = new Point(197, 179);
			this.PapingBTN.Name = "PapingBTN";
			this.PapingBTN.ShadowDecoration.Parent = this.PapingBTN;
			this.PapingBTN.Size = new Size(189, 39);
			this.PapingBTN.TabIndex = 8;
			this.PapingBTN.Text = "PaPing";
			this.PapingBTN.Click += this.PapingBTN_Click;
			this.label28.AutoSize = true;
			this.label28.BackColor = Color.Transparent;
			this.label28.Font = new Font("Segoe UI Semibold", 9.95f, FontStyle.Bold);
			this.label28.ForeColor = Color.Silver;
			this.label28.Location = new Point(58, 26);
			this.label28.Name = "label28";
			this.label28.Size = new Size(86, 19);
			this.label28.TabIndex = 21;
			this.label28.Text = "Ping/Paping";
			this.pingBTN.BorderRadius = 3;
			this.pingBTN.CheckedState.Parent = this.pingBTN;
			this.pingBTN.CustomImages.Parent = this.pingBTN;
			this.pingBTN.FillColor = Color.FromArgb(81, 0, 198);
			this.pingBTN.Font = new Font("Segoe UI", 9f);
			this.pingBTN.ForeColor = Color.White;
			this.pingBTN.HoveredState.Parent = this.pingBTN;
			this.pingBTN.Location = new Point(12, 179);
			this.pingBTN.Name = "pingBTN";
			this.pingBTN.ShadowDecoration.Parent = this.pingBTN;
			this.pingBTN.Size = new Size(179, 39);
			this.pingBTN.TabIndex = 7;
			this.pingBTN.Text = "Ping";
			this.pingBTN.Click += this.pingBTN_Click;
			this.tcpport.BorderColor = Color.White;
			this.tcpport.Cursor = Cursors.IBeam;
			this.tcpport.DefaultText = "Port";
			this.tcpport.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			this.tcpport.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			this.tcpport.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			this.tcpport.DisabledState.Parent = this.tcpport;
			this.tcpport.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			this.tcpport.FillColor = Color.FromArgb(27, 27, 27);
			this.tcpport.FocusedState.BorderColor = Color.FromArgb(81, 0, 198);
			this.tcpport.FocusedState.Parent = this.tcpport;
			this.tcpport.ForeColor = Color.White;
			this.tcpport.HoveredState.BorderColor = Color.Silver;
			this.tcpport.HoveredState.Parent = this.tcpport;
			this.tcpport.Location = new Point(12, 118);
			this.tcpport.Name = "tcpport";
			this.tcpport.PasswordChar = '\0';
			this.tcpport.PlaceholderText = "";
			this.tcpport.SelectedText = "";
			this.tcpport.ShadowDecoration.Parent = this.tcpport;
			this.tcpport.Size = new Size(374, 36);
			this.tcpport.TabIndex = 1;
			this.tcpip.BorderColor = Color.White;
			this.tcpip.Cursor = Cursors.IBeam;
			this.tcpip.DefaultText = "Host";
			this.tcpip.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			this.tcpip.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			this.tcpip.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			this.tcpip.DisabledState.Parent = this.tcpip;
			this.tcpip.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			this.tcpip.FillColor = Color.FromArgb(27, 27, 27);
			this.tcpip.FocusedState.BorderColor = Color.FromArgb(81, 0, 198);
			this.tcpip.FocusedState.Parent = this.tcpip;
			this.tcpip.ForeColor = Color.White;
			this.tcpip.HoveredState.BorderColor = Color.Silver;
			this.tcpip.HoveredState.Parent = this.tcpip;
			this.tcpip.Location = new Point(12, 64);
			this.tcpip.Name = "tcpip";
			this.tcpip.PasswordChar = '\0';
			this.tcpip.PlaceholderText = "";
			this.tcpip.SelectedText = "";
			this.tcpip.ShadowDecoration.Parent = this.tcpip;
			this.tcpip.Size = new Size(374, 36);
			this.tcpip.TabIndex = 0;
			this.siticonePanel14.BorderRadius = 18;
			this.siticonePanel14.Controls.Add(this.siticoneButton17);
			this.siticonePanel14.Controls.Add(this.label29);
			this.siticonePanel14.Controls.Add(this.siticoneButton19);
			this.siticonePanel14.Controls.Add(this.Portip);
			this.siticonePanel14.FillColor = Color.FromArgb(27, 27, 27);
			this.siticonePanel14.Location = new Point(25, 269);
			this.siticonePanel14.Name = "siticonePanel14";
			this.siticonePanel14.ShadowDecoration.Parent = this.siticonePanel14;
			this.siticonePanel14.Size = new Size(399, 291);
			this.siticonePanel14.TabIndex = 13;
			this.siticoneButton17.BorderColor = Color.FromArgb(27, 27, 27);
			this.siticoneButton17.CheckedState.Parent = this.siticoneButton17;
			this.siticoneButton17.CustomBorderColor = Color.Transparent;
			this.siticoneButton17.CustomImages.Parent = this.siticoneButton17;
			this.siticoneButton17.FillColor = Color.FromArgb(27, 27, 27);
			this.siticoneButton17.Font = new Font("Segoe UI", 9f);
			this.siticoneButton17.ForeColor = Color.White;
			this.siticoneButton17.HoveredState.Parent = this.siticoneButton17;
			this.siticoneButton17.Image = (Image)componentResourceManager.GetObject("siticoneButton17.Image");
			this.siticoneButton17.ImageSize = new Size(28, 28);
			this.siticoneButton17.Location = new Point(4, 7);
			this.siticoneButton17.Name = "siticoneButton17";
			this.siticoneButton17.PressedColor = Color.FromArgb(27, 27, 27);
			this.siticoneButton17.ShadowDecoration.Parent = this.siticoneButton17;
			this.siticoneButton17.Size = new Size(51, 51);
			this.siticoneButton17.TabIndex = 4;
			this.label29.AutoSize = true;
			this.label29.BackColor = Color.Transparent;
			this.label29.Font = new Font("Segoe UI Semibold", 9.95f, FontStyle.Bold);
			this.label29.ForeColor = Color.Silver;
			this.label29.Location = new Point(58, 26);
			this.label29.Name = "label29";
			this.label29.Size = new Size(63, 19);
			this.label29.TabIndex = 21;
			this.label29.Text = "Portscan";
			this.siticoneButton19.BorderRadius = 3;
			this.siticoneButton19.CheckedState.Parent = this.siticoneButton19;
			this.siticoneButton19.CustomImages.Parent = this.siticoneButton19;
			this.siticoneButton19.FillColor = Color.FromArgb(81, 0, 198);
			this.siticoneButton19.Font = new Font("Segoe UI", 9f);
			this.siticoneButton19.ForeColor = Color.White;
			this.siticoneButton19.HoveredState.Parent = this.siticoneButton19;
			this.siticoneButton19.Location = new Point(12, 146);
			this.siticoneButton19.Name = "siticoneButton19";
			this.siticoneButton19.ShadowDecoration.Parent = this.siticoneButton19;
			this.siticoneButton19.Size = new Size(374, 39);
			this.siticoneButton19.TabIndex = 7;
			this.siticoneButton19.Text = "Portscan";
			this.siticoneButton19.Click += this.siticoneButton19_Click;
			this.Portip.BorderColor = Color.White;
			this.Portip.Cursor = Cursors.IBeam;
			this.Portip.DefaultText = "Host";
			this.Portip.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			this.Portip.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			this.Portip.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			this.Portip.DisabledState.Parent = this.Portip;
			this.Portip.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			this.Portip.FillColor = Color.FromArgb(27, 27, 27);
			this.Portip.FocusedState.BorderColor = Color.FromArgb(81, 0, 198);
			this.Portip.FocusedState.Parent = this.Portip;
			this.Portip.ForeColor = Color.White;
			this.Portip.HoveredState.BorderColor = Color.Silver;
			this.Portip.HoveredState.Parent = this.Portip;
			this.Portip.Location = new Point(12, 75);
			this.Portip.Name = "Portip";
			this.Portip.PasswordChar = '\0';
			this.Portip.PlaceholderText = "";
			this.Portip.SelectedText = "";
			this.Portip.ShadowDecoration.Parent = this.Portip;
			this.Portip.Size = new Size(374, 36);
			this.Portip.TabIndex = 0;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(27, 27, 27);
			base.Controls.Add(this.siticonePanel18);
			base.Controls.Add(this.siticonePanel13);
			base.Controls.Add(this.siticonePanel12);
			base.Controls.Add(this.siticonePanel14);
			base.Name = "tools";
			base.Size = new Size(861, 575);
			this.siticonePanel18.ResumeLayout(false);
			this.siticonePanel13.ResumeLayout(false);
			this.siticonePanel13.PerformLayout();
			this.siticonePanel12.ResumeLayout(false);
			this.siticonePanel12.PerformLayout();
			this.siticonePanel14.ResumeLayout(false);
			this.siticonePanel14.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x040000BA RID: 186
		private IContainer components = null;

		// Token: 0x040000BB RID: 187
		private SiticonePanel siticonePanel18;

		// Token: 0x040000BC RID: 188
		private RichTextBox richip;

		// Token: 0x040000BD RID: 189
		private SiticonePanel siticonePanel13;

		// Token: 0x040000BE RID: 190
		private SiticoneButton siticoneButton16;

		// Token: 0x040000BF RID: 191
		private Label label27;

		// Token: 0x040000C0 RID: 192
		private SiticoneButton lookupBTN;

		// Token: 0x040000C1 RID: 193
		private SiticoneMaterialTextBox lookup;

		// Token: 0x040000C2 RID: 194
		private SiticonePanel siticonePanel12;

		// Token: 0x040000C3 RID: 195
		private SiticoneButton siticoneButton14;

		// Token: 0x040000C4 RID: 196
		private SiticoneButton PapingBTN;

		// Token: 0x040000C5 RID: 197
		private Label label28;

		// Token: 0x040000C6 RID: 198
		private SiticoneButton pingBTN;

		// Token: 0x040000C7 RID: 199
		private SiticoneMaterialTextBox tcpport;

		// Token: 0x040000C8 RID: 200
		private SiticoneMaterialTextBox tcpip;

		// Token: 0x040000C9 RID: 201
		private SiticonePanel siticonePanel14;

		// Token: 0x040000CA RID: 202
		private SiticoneButton siticoneButton17;

		// Token: 0x040000CB RID: 203
		private Label label29;

		// Token: 0x040000CC RID: 204
		private SiticoneButton siticoneButton19;

		// Token: 0x040000CD RID: 205
		private SiticoneMaterialTextBox Portip;
	}
}
