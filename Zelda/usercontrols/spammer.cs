using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using Siticone.UI.WinForms;

namespace Zelda.usercontrols
{
	// Token: 0x02000014 RID: 20
	public class spammer : UserControl
	{
		// Token: 0x0600007D RID: 125 RVA: 0x000B43DC File Offset: 0x000B43DC
		public spammer()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600007E RID: 126 RVA: 0x000B43FF File Offset: 0x000B43FF
		private static void sendWebHook(string URL, string msg, string username)
		{
			spammer.Post(URL, new NameValueCollection
			{
				{
					"username",
					username
				},
				{
					"content",
					msg
				}
			});
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600007F RID: 127 RVA: 0x000B4428 File Offset: 0x000B4428
		// (set) Token: 0x06000080 RID: 128 RVA: 0x000B442F File Offset: 0x000B442F
		private static WebClient WebClient { get; set; }

		// Token: 0x06000081 RID: 129 RVA: 0x000BDC28 File Offset: 0x000BDC28
		private static byte[] Post(string uri, NameValueCollection pairs)
		{
			byte[] result;
			using (spammer.WebClient = new WebClient())
			{
				result = spammer.WebClient.UploadValues(uri, pairs);
			}
			return result;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x000BDC70 File Offset: 0x000BDC70
		private void Sentd_Click(object sender, EventArgs e)
		{
			try
			{
				string str = DateTime.Now.ToString("hh:mm:ss");
				spammer.sendWebHook(this.url.Text, string.Concat(new string[]
				{
					this.msg.Text
				}), this.name.Text);
				this.LogsBox.AppendText("Message Sent Successfuly! - " + str + Environment.NewLine);
			}
			catch
			{
				string str2 = DateTime.Now.ToString("hh:mm:ss");
				this.LogsBox.AppendText("Failed To Send Message - " + str2 + Environment.NewLine);
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x000BDD2C File Offset: 0x000BDD2C
		private void siticoneButton13_Click(object sender, EventArgs e)
		{
			try
			{
				WebRequest webRequest = WebRequest.Create(this.url.Text);
				webRequest.Method = "DELETE";
				HttpWebResponse httpWebResponse = (HttpWebResponse)webRequest.GetResponse();
				MessageBox.Show("Discord Tools", "Delete Request To Given Webhook Has Been Sent");
			}
			catch
			{
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x000B41EC File Offset: 0x000B41EC
		private void spammer_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000085 RID: 133 RVA: 0x000BDD8C File Offset: 0x000BDD8C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x000BDDC4 File Offset: 0x000BDDC4
		private void InitializeComponent()
		{
			this.siticonePanel19 = new SiticonePanel();
			this.LogsBox = new RichTextBox();
			this.label30 = new Label();
			this.siticonePanel15 = new SiticonePanel();
			this.siticoneButton13 = new SiticoneButton();
			this.Sentd = new SiticoneButton();
			this.url = new SiticoneMaterialTextBox();
			this.msg = new SiticoneMaterialTextBox();
			this.name = new SiticoneMaterialTextBox();
			this.siticonePanel19.SuspendLayout();
			this.siticonePanel15.SuspendLayout();
			base.SuspendLayout();
			this.siticonePanel19.BorderRadius = 18;
			this.siticonePanel19.Controls.Add(this.LogsBox);
			this.siticonePanel19.FillColor = Color.FromArgb(27, 27, 27);
			this.siticonePanel19.Location = new Point(448, 130);
			this.siticonePanel19.Name = "siticonePanel19";
			this.siticonePanel19.ShadowDecoration.Parent = this.siticonePanel19;
			this.siticonePanel19.Size = new Size(403, 352);
			this.siticonePanel19.TabIndex = 15;
			this.LogsBox.BackColor = Color.FromArgb(27, 27, 27);
			this.LogsBox.BorderStyle = BorderStyle.None;
			this.LogsBox.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.LogsBox.ForeColor = Color.White;
			this.LogsBox.Location = new Point(10, 10);
			this.LogsBox.Name = "LogsBox";
			this.LogsBox.ReadOnly = true;
			this.LogsBox.ScrollBars = RichTextBoxScrollBars.None;
			this.LogsBox.Size = new Size(399, 332);
			this.LogsBox.TabIndex = 10;
			this.LogsBox.Text = "\n";
			this.label30.AutoSize = true;
			this.label30.BackColor = Color.Transparent;
			this.label30.Font = new Font("Segoe UI Semibold", 10.95f, FontStyle.Bold);
			this.label30.ForeColor = Color.Silver;
			this.label30.Location = new Point(360, 97);
			this.label30.Name = "label30";
			this.label30.Size = new Size(130, 20);
			this.label30.TabIndex = 14;
			this.label30.Text = "Discord Spammer";
			this.siticonePanel15.BorderRadius = 18;
			this.siticonePanel15.Controls.Add(this.siticoneButton13);
			this.siticonePanel15.Controls.Add(this.Sentd);
			this.siticonePanel15.Controls.Add(this.url);
			this.siticonePanel15.Controls.Add(this.msg);
			this.siticonePanel15.Controls.Add(this.name);
			this.siticonePanel15.FillColor = Color.FromArgb(27, 27, 27);
			this.siticonePanel15.Location = new Point(13, 130);
			this.siticonePanel15.Name = "siticonePanel15";
			this.siticonePanel15.ShadowDecoration.Parent = this.siticonePanel15;
			this.siticonePanel15.Size = new Size(429, 352);
			this.siticonePanel15.TabIndex = 13;
			this.siticoneButton13.BorderRadius = 3;
			this.siticoneButton13.CheckedState.Parent = this.siticoneButton13;
			this.siticoneButton13.CustomImages.Parent = this.siticoneButton13;
			this.siticoneButton13.FillColor = Color.FromArgb(81, 0, 198);
			this.siticoneButton13.Font = new Font("Segoe UI", 9f);
			this.siticoneButton13.ForeColor = Color.White;
			this.siticoneButton13.HoveredState.Parent = this.siticoneButton13;
			this.siticoneButton13.Location = new Point(318, 188);
			this.siticoneButton13.Name = "siticoneButton13";
			this.siticoneButton13.ShadowDecoration.Parent = this.siticoneButton13;
			this.siticoneButton13.Size = new Size(77, 39);
			this.siticoneButton13.TabIndex = 9;
			this.siticoneButton13.Text = "Clear";
			this.siticoneButton13.Click += this.siticoneButton13_Click;
			this.Sentd.BorderRadius = 3;
			this.Sentd.CheckedState.Parent = this.Sentd;
			this.Sentd.CustomImages.Parent = this.Sentd;
			this.Sentd.FillColor = Color.FromArgb(81, 0, 198);
			this.Sentd.Font = new Font("Segoe UI", 9f);
			this.Sentd.ForeColor = Color.White;
			this.Sentd.HoveredState.Parent = this.Sentd;
			this.Sentd.Location = new Point(21, 188);
			this.Sentd.Name = "Sentd";
			this.Sentd.ShadowDecoration.Parent = this.Sentd;
			this.Sentd.Size = new Size(291, 39);
			this.Sentd.TabIndex = 8;
			this.Sentd.Text = "Send";
			this.Sentd.Click += this.Sentd_Click;
			this.url.BorderColor = Color.White;
			this.url.Cursor = Cursors.IBeam;
			this.url.DefaultText = "Webhook URL";
			this.url.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			this.url.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			this.url.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			this.url.DisabledState.Parent = this.url;
			this.url.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			this.url.FillColor = Color.FromArgb(27, 27, 27);
			this.url.FocusedState.BorderColor = Color.FromArgb(81, 0, 198);
			this.url.FocusedState.Parent = this.url;
			this.url.ForeColor = Color.White;
			this.url.HoveredState.BorderColor = Color.Silver;
			this.url.HoveredState.Parent = this.url;
			this.url.Location = new Point(21, 30);
			this.url.Name = "url";
			this.url.PasswordChar = '\0';
			this.url.PlaceholderText = "";
			this.url.SelectedText = "";
			this.url.ShadowDecoration.Parent = this.url;
			this.url.Size = new Size(374, 36);
			this.url.TabIndex = 3;
			this.msg.BorderColor = Color.White;
			this.msg.Cursor = Cursors.IBeam;
			this.msg.DefaultText = "Webhook Message";
			this.msg.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			this.msg.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			this.msg.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			this.msg.DisabledState.Parent = this.msg;
			this.msg.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			this.msg.FillColor = Color.FromArgb(27, 27, 27);
			this.msg.FocusedState.BorderColor = Color.FromArgb(81, 0, 198);
			this.msg.FocusedState.Parent = this.msg;
			this.msg.ForeColor = Color.White;
			this.msg.HoveredState.BorderColor = Color.Silver;
			this.msg.HoveredState.Parent = this.msg;
			this.msg.Location = new Point(21, 126);
			this.msg.Name = "msg";
			this.msg.PasswordChar = '\0';
			this.msg.PlaceholderText = "";
			this.msg.SelectedText = "";
			this.msg.ShadowDecoration.Parent = this.msg;
			this.msg.Size = new Size(374, 36);
			this.msg.TabIndex = 5;
			this.name.BorderColor = Color.White;
			this.name.Cursor = Cursors.IBeam;
			this.name.DefaultText = "Webhook Name";
			this.name.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			this.name.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			this.name.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			this.name.DisabledState.Parent = this.name;
			this.name.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			this.name.FillColor = Color.FromArgb(27, 27, 27);
			this.name.FocusedState.BorderColor = Color.FromArgb(81, 0, 198);
			this.name.FocusedState.Parent = this.name;
			this.name.ForeColor = Color.White;
			this.name.HoveredState.BorderColor = Color.Silver;
			this.name.HoveredState.Parent = this.name;
			this.name.Location = new Point(21, 78);
			this.name.Name = "name";
			this.name.PasswordChar = '\0';
			this.name.PlaceholderText = "";
			this.name.SelectedText = "";
			this.name.ShadowDecoration.Parent = this.name;
			this.name.Size = new Size(374, 36);
			this.name.TabIndex = 4;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(18, 18, 18);
			base.Controls.Add(this.siticonePanel19);
			base.Controls.Add(this.label30);
			base.Controls.Add(this.siticonePanel15);
			base.Name = "spammer";
			base.Size = new Size(864, 579);
			base.Load += this.spammer_Load;
			this.siticonePanel19.ResumeLayout(false);
			this.siticonePanel15.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040000A8 RID: 168
		private int time2 = 99999;

		// Token: 0x040000A9 RID: 169
		private int value;

		// Token: 0x040000AB RID: 171
		private IContainer components = null;

		// Token: 0x040000AC RID: 172
		private SiticonePanel siticonePanel19;

		// Token: 0x040000AD RID: 173
		private RichTextBox LogsBox;

		// Token: 0x040000AE RID: 174
		private Label label30;

		// Token: 0x040000AF RID: 175
		private SiticonePanel siticonePanel15;

		// Token: 0x040000B0 RID: 176
		private SiticoneButton siticoneButton13;

		// Token: 0x040000B1 RID: 177
		private SiticoneButton Sentd;

		// Token: 0x040000B2 RID: 178
		private SiticoneMaterialTextBox url;

		// Token: 0x040000B3 RID: 179
		private SiticoneMaterialTextBox msg;

		// Token: 0x040000B4 RID: 180
		private SiticoneMaterialTextBox name;
	}
}
