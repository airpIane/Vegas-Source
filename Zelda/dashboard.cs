using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using SafeGuard;
using Siticone.Desktop.UI.WinForms;

namespace Zelda
{
	// Token: 0x0200000C RID: 12
	public class dashboard : UserControl
	{
		// Token: 0x06000034 RID: 52 RVA: 0x000B41BC File Offset: 0x000B41BC
		public dashboard()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000B54EC File Offset: 0x000B54EC
		private void dashboard_Load(object sender, EventArgs e)
		{
			this.username.Text = (ResponseInformation.loginresponse.UserName ?? "");
			this.users.Text = string.Format("{0}", ResponseInformation.count.UserCount);
			this.expire.Text = string.Format("{0}", ResponseInformation.loginresponse.ExpirationDate);
			this.servers.Text = string.Format("{0}", ResponseInformation.count.BotnetCount);
			TimeSpan timeSpan = ResponseInformation.loginresponse.ExpirationDate - DateTime.Now;
			bool flag = timeSpan.Days > 365;
			if (flag)
			{
				this.expire.Text = "Lifetime";
			}
			else
			{
				bool flag2 = timeSpan.Days < 365 && timeSpan.Days > 1;
				if (flag2)
				{
					this.expire.Text = string.Format("{0} days", timeSpan.Days);
				}
				else
				{
					this.expire.Text = string.Format("{0} hours", timeSpan.Hours);
				}
			}
			switch (ResponseInformation.loginresponse.Level)
			{
			case 1:
				this.cons.Text = "1";
				this.boottime.Text = "300";
				this.level.Text = "1";
				break;
			case 2:
				this.cons.Text = "2";
				this.boottime.Text = "600";
				this.level.Text = "2";
				break;
			case 3:
				this.cons.Text = "3";
				this.boottime.Text = "800";
				this.level.Text = "3";
				break;
			case 4:
				this.cons.Text = "3";
				this.boottime.Text = "1200";
				this.level.Text = "3";
				break;
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000B573C File Offset: 0x000B573C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000B5774 File Offset: 0x000B5774
		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(dashboard));
			this.siticonePanel7 = new SiticonePanel();
			this.siticoneSeparator5 = new SiticoneSeparator();
			this.boottime = new Label();
			this.label16 = new Label();
			this.siticoneSeparator4 = new SiticoneSeparator();
			this.expire = new Label();
			this.label14 = new Label();
			this.siticoneSeparator3 = new SiticoneSeparator();
			this.level = new Label();
			this.label12 = new Label();
			this.siticoneSeparator2 = new SiticoneSeparator();
			this.username = new Label();
			this.label10 = new Label();
			this.siticoneSeparator1 = new SiticoneSeparator();
			this.siticoneButton7 = new SiticoneButton();
			this.label9 = new Label();
			this.siticonePanel6 = new SiticonePanel();
			this.richTextBox1 = new RichTextBox();
			this.label7 = new Label();
			this.siticoneButton6 = new SiticoneButton();
			this.siticonePanel5 = new SiticonePanel();
			this.label5 = new Label();
			this.label6 = new Label();
			this.pictureBox3 = new PictureBox();
			this.siticonePanel4 = new SiticonePanel();
			this.servers = new Label();
			this.label4 = new Label();
			this.pictureBox2 = new PictureBox();
			this.siticonePanel3 = new SiticonePanel();
			this.users = new Label();
			this.label1 = new Label();
			this.pictureBox1 = new PictureBox();
			this.siticonePanel7.SuspendLayout();
			this.siticonePanel6.SuspendLayout();
			this.siticonePanel5.SuspendLayout();
			((ISupportInitialize)this.pictureBox3).BeginInit();
			this.siticonePanel4.SuspendLayout();
			((ISupportInitialize)this.pictureBox2).BeginInit();
			this.siticonePanel3.SuspendLayout();
			((ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.siticonePanel7.BorderColor = Color.FromArgb(255, 128, 128);
			this.siticonePanel7.BorderRadius = 18;
			this.siticonePanel7.Controls.Add(this.cons);
			this.siticonePanel7.Controls.Add(this.label18);
			this.siticonePanel7.Controls.Add(this.siticoneSeparator5);
			this.siticonePanel7.Controls.Add(this.boottime);
			this.siticonePanel7.Controls.Add(this.label16);
			this.siticonePanel7.Controls.Add(this.siticoneSeparator4);
			this.siticonePanel7.Controls.Add(this.expire);
			this.siticonePanel7.Controls.Add(this.label14);
			this.siticonePanel7.Controls.Add(this.siticoneSeparator3);
			this.siticonePanel7.Controls.Add(this.level);
			this.siticonePanel7.Controls.Add(this.label12);
			this.siticonePanel7.Controls.Add(this.siticoneSeparator2);
			this.siticonePanel7.Controls.Add(this.username);
			this.siticonePanel7.Controls.Add(this.label10);
			this.siticonePanel7.Controls.Add(this.siticoneSeparator1);
			this.siticonePanel7.Controls.Add(this.siticoneButton7);
			this.siticonePanel7.Controls.Add(this.label9);
			this.siticonePanel7.FillColor = Color.FromArgb(27, 27, 27);
			this.siticonePanel7.Location = new Point(573, 191);
			this.siticonePanel7.Name = "siticonePanel7";
			this.siticonePanel7.ShadowDecoration.Parent = this.siticonePanel7;
			this.siticonePanel7.Size = new Size(271, 354);
			this.siticonePanel7.TabIndex = 14;
			this.cons.AutoSize = true;
			this.cons.BackColor = Color.Transparent;
			this.cons.Font = new Font("Segoe UI Semibold", 10.95f, FontStyle.Bold);
			this.cons.ForeColor = Color.FromArgb(81, 0, 198);
			this.cons.Location = new Point(164, 204);
			this.cons.Name = "cons";
			this.cons.Size = new Size(37, 20);
			this.cons.TabIndex = 32;
			this.cons.Text = "N/A";
			this.label18.AutoSize = true;
			this.label18.BackColor = Color.Transparent;
			this.label18.Font = new Font("Segoe UI Semibold", 9.95f, FontStyle.Bold);
			this.label18.ForeColor = Color.Silver;
			this.label18.Location = new Point(7, 206);
			this.label18.Name = "label18";
			this.label18.Size = new Size(79, 19);
			this.label18.TabIndex = 31;
			this.label18.Text = "Concurrent";
			this.siticoneSeparator5.BackColor = Color.Transparent;
			this.siticoneSeparator5.Location = new Point(5, 225);
			this.siticoneSeparator5.Name = "siticoneSeparator5";
			this.siticoneSeparator5.Size = new Size(262, 10);
			this.siticoneSeparator5.TabIndex = 30;
			this.boottime.AutoSize = true;
			this.boottime.BackColor = Color.Transparent;
			this.boottime.Font = new Font("Segoe UI Semibold", 10.95f, FontStyle.Bold);
			this.boottime.ForeColor = Color.FromArgb(81, 0, 198);
			this.boottime.Location = new Point(164, 166);
			this.boottime.Name = "boottime";
			this.boottime.Size = new Size(33, 20);
			this.boottime.TabIndex = 29;
			this.boottime.Text = "300";
			this.label16.AutoSize = true;
			this.label16.BackColor = Color.Transparent;
			this.label16.Font = new Font("Segoe UI Semibold", 9.95f, FontStyle.Bold);
			this.label16.ForeColor = Color.Silver;
			this.label16.Location = new Point(7, 167);
			this.label16.Name = "label16";
			this.label16.Size = new Size(76, 19);
			this.label16.TabIndex = 28;
			this.label16.Text = "Time Limit";
			this.siticoneSeparator4.BackColor = Color.Transparent;
			this.siticoneSeparator4.Location = new Point(5, 186);
			this.siticoneSeparator4.Name = "siticoneSeparator4";
			this.siticoneSeparator4.Size = new Size(262, 10);
			this.siticoneSeparator4.TabIndex = 27;
			this.expire.AutoSize = true;
			this.expire.BackColor = Color.Transparent;
			this.expire.Font = new Font("Segoe UI Semibold", 10.95f, FontStyle.Bold);
			this.expire.ForeColor = Color.FromArgb(81, 0, 198);
			this.expire.Location = new Point(164, 126);
			this.expire.Name = "expire";
			this.expire.Size = new Size(73, 20);
			this.expire.TabIndex = 26;
			this.expire.Text = "9/21/1990";
			this.label14.AutoSize = true;
			this.label14.BackColor = Color.Transparent;
			this.label14.Font = new Font("Segoe UI Semibold", 9.95f, FontStyle.Bold);
			this.label14.ForeColor = Color.Silver;
			this.label14.Location = new Point(7, 126);
			this.label14.Name = "label14";
			this.label14.Size = new Size(47, 19);
			this.label14.TabIndex = 25;
			this.label14.Text = "Expire";
			this.siticoneSeparator3.BackColor = Color.Transparent;
			this.siticoneSeparator3.Location = new Point(5, 145);
			this.siticoneSeparator3.Name = "siticoneSeparator3";
			this.siticoneSeparator3.Size = new Size(262, 10);
			this.siticoneSeparator3.TabIndex = 24;
			this.level.AutoSize = true;
			this.level.BackColor = Color.Transparent;
			this.level.Font = new Font("Segoe UI Semibold", 10.95f, FontStyle.Bold);
			this.level.ForeColor = Color.FromArgb(81, 0, 198);
			this.level.Location = new Point(164, 86);
			this.level.Name = "level";
			this.level.Size = new Size(15, 20);
			this.level.TabIndex = 23;
			this.level.Text = "1";
			this.label12.AutoSize = true;
			this.label12.BackColor = Color.Transparent;
			this.label12.Font = new Font("Segoe UI Semibold", 9.95f, FontStyle.Bold);
			this.label12.ForeColor = Color.Silver;
			this.label12.Location = new Point(7, 87);
			this.label12.Name = "label12";
			this.label12.Size = new Size(41, 19);
			this.label12.TabIndex = 22;
			this.label12.Text = "Level";
			this.siticoneSeparator2.BackColor = Color.Transparent;
			this.siticoneSeparator2.Location = new Point(5, 106);
			this.siticoneSeparator2.Name = "siticoneSeparator2";
			this.siticoneSeparator2.Size = new Size(262, 10);
			this.siticoneSeparator2.TabIndex = 21;
			this.username.AutoSize = true;
			this.username.BackColor = Color.Transparent;
			this.username.Font = new Font("Segoe UI Semibold", 10.95f, FontStyle.Bold);
			this.username.ForeColor = Color.FromArgb(81, 0, 198);
			this.username.Location = new Point(164, 49);
			this.username.Name = "username";
			this.username.Size = new Size(47, 20);
			this.username.TabIndex = 20;
			this.username.Text = "Zelda";
			this.label10.AutoSize = true;
			this.label10.BackColor = Color.Transparent;
			this.label10.Font = new Font("Segoe UI Semibold", 9.95f, FontStyle.Bold);
			this.label10.ForeColor = Color.Silver;
			this.label10.Location = new Point(7, 49);
			this.label10.Name = "label10";
			this.label10.Size = new Size(71, 19);
			this.label10.TabIndex = 19;
			this.label10.Text = "Username";
			this.siticoneSeparator1.BackColor = Color.Transparent;
			this.siticoneSeparator1.Location = new Point(5, 68);
			this.siticoneSeparator1.Name = "siticoneSeparator1";
			this.siticoneSeparator1.Size = new Size(262, 10);
			this.siticoneSeparator1.TabIndex = 18;
			this.siticoneButton7.BackColor = Color.Transparent;
			this.siticoneButton7.BorderRadius = 4;
			this.siticoneButton7.CheckedState.Parent = this.siticoneButton7;
			this.siticoneButton7.CustomBorderColor = Color.Transparent;
			this.siticoneButton7.CustomImages.Parent = this.siticoneButton7;
			this.siticoneButton7.FillColor = Color.FromArgb(104, 28, 205);
			this.siticoneButton7.Font = new Font("Segoe UI", 9f);
			this.siticoneButton7.ForeColor = Color.White;
			this.siticoneButton7.HoverState.Parent = this.siticoneButton7;
			this.siticoneButton7.ImageSize = new Size(26, 26);
			this.siticoneButton7.Location = new Point(3, 5);
			this.siticoneButton7.Name = "siticoneButton7";
			this.siticoneButton7.ShadowDecoration.Parent = this.siticoneButton7;
			this.siticoneButton7.Size = new Size(29, 29);
			this.siticoneButton7.TabIndex = 17;
			this.siticoneButton7.TextOffset = new Point(2, 0);
			this.label9.AutoSize = true;
			this.label9.BackColor = Color.Transparent;
			this.label9.Font = new Font("Segoe UI Semibold", 10.95f, FontStyle.Bold);
			this.label9.ForeColor = Color.Silver;
			this.label9.Location = new Point(38, 8);
			this.label9.Name = "label9";
			this.label9.Size = new Size(85, 20);
			this.label9.TabIndex = 15;
			this.label9.Text = "Profile Info";
			this.siticonePanel6.BorderColor = Color.FromArgb(255, 128, 128);
			this.siticonePanel6.BorderRadius = 18;
			this.siticonePanel6.Controls.Add(this.richTextBox1);
			this.siticonePanel6.Controls.Add(this.label7);
			this.siticonePanel6.Controls.Add(this.siticoneButton6);
			this.siticonePanel6.FillColor = Color.FromArgb(27, 27, 27);
			this.siticonePanel6.Location = new Point(16, 191);
			this.siticonePanel6.Name = "siticonePanel6";
			this.siticonePanel6.ShadowDecoration.Parent = this.siticonePanel6;
			this.siticonePanel6.Size = new Size(549, 354);
			this.siticonePanel6.TabIndex = 13;
			this.richTextBox1.BackColor = Color.FromArgb(27, 27, 27);
			this.richTextBox1.BorderStyle = BorderStyle.None;
			this.richTextBox1.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.richTextBox1.ForeColor = Color.White;
			this.richTextBox1.Location = new Point(4, 42);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new Size(542, 305);
			this.richTextBox1.TabIndex = 8;
			this.richTextBox1.Text = "from now on only level 3 & 4 users get access to private network :)";
			this.label7.AutoSize = true;
			this.label7.BackColor = Color.Transparent;
			this.label7.Font = new Font("Segoe UI Semibold", 8.95f, FontStyle.Bold);
			this.label7.ForeColor = Color.Silver;
			this.label7.Location = new Point(37, 12);
			this.label7.Name = "label7";
			this.label7.Size = new Size(85, 15);
			this.label7.TabIndex = 7;
			this.label7.Text = "News, Updates";
			this.siticoneButton6.BackColor = Color.Transparent;
			this.siticoneButton6.BorderRadius = 4;
			this.siticoneButton6.CheckedState.Parent = this.siticoneButton6;
			this.siticoneButton6.CustomBorderColor = Color.Transparent;
			this.siticoneButton6.CustomImages.Parent = this.siticoneButton6;
			this.siticoneButton6.FillColor = Color.FromArgb(104, 28, 205);
			this.siticoneButton6.Font = new Font("Segoe UI", 9f);
			this.siticoneButton6.ForeColor = Color.White;
			this.siticoneButton6.HoverState.Parent = this.siticoneButton6;
			this.siticoneButton6.ImageSize = new Size(26, 26);
			this.siticoneButton6.Location = new Point(4, 5);
			this.siticoneButton6.Name = "siticoneButton6";
			this.siticoneButton6.ShadowDecoration.Parent = this.siticoneButton6;
			this.siticoneButton6.Size = new Size(29, 29);
			this.siticoneButton6.TabIndex = 6;
			this.siticoneButton6.TextOffset = new Point(2, 0);
			this.siticonePanel5.BorderColor = Color.FromArgb(255, 128, 128);
			this.siticonePanel5.BorderRadius = 18;
			this.siticonePanel5.Controls.Add(this.label5);
			this.siticonePanel5.Controls.Add(this.label6);
			this.siticonePanel5.Controls.Add(this.pictureBox3);
			this.siticonePanel5.FillColor = Color.FromArgb(27, 27, 27);
			this.siticonePanel5.Location = new Point(573, 30);
			this.siticonePanel5.Name = "siticonePanel5";
			this.siticonePanel5.ShadowDecoration.Parent = this.siticonePanel5;
			this.siticonePanel5.Size = new Size(271, 151);
			this.siticonePanel5.TabIndex = 12;
			this.label5.AutoSize = true;
			this.label5.BackColor = Color.Transparent;
			this.label5.Font = new Font("Segoe UI Semibold", 10.95f, FontStyle.Bold);
			this.label5.ForeColor = Color.FromArgb(81, 0, 198);
			this.label5.Location = new Point(140, 84);
			this.label5.Name = "label5";
			this.label5.Size = new Size(103, 20);
			this.label5.TabIndex = 13;
			this.label5.Text = "VEGAS-GAME";
			this.label6.AutoSize = true;
			this.label6.BackColor = Color.Transparent;
			this.label6.Font = new Font("Segoe UI Semibold", 10.95f, FontStyle.Bold);
			this.label6.ForeColor = Color.Silver;
			this.label6.Location = new Point(124, 27);
			this.label6.Name = "label6";
			this.label6.Size = new Size(130, 20);
			this.label6.TabIndex = 12;
			this.label6.Text = "Top Used Method";
			this.pictureBox3.BackColor = Color.Transparent;
			this.pictureBox3.Image = (Image)componentResourceManager.GetObject("pictureBox3.Image");
			this.pictureBox3.Location = new Point(3, 2);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new Size(99, 145);
			this.pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
			this.pictureBox3.TabIndex = 11;
			this.pictureBox3.TabStop = false;
			this.siticonePanel4.BorderColor = Color.FromArgb(255, 128, 128);
			this.siticonePanel4.BorderRadius = 18;
			this.siticonePanel4.Controls.Add(this.servers);
			this.siticonePanel4.Controls.Add(this.label4);
			this.siticonePanel4.Controls.Add(this.pictureBox2);
			this.siticonePanel4.FillColor = Color.FromArgb(27, 27, 27);
			this.siticonePanel4.Location = new Point(294, 30);
			this.siticonePanel4.Name = "siticonePanel4";
			this.siticonePanel4.ShadowDecoration.Parent = this.siticonePanel4;
			this.siticonePanel4.Size = new Size(271, 151);
			this.siticonePanel4.TabIndex = 11;
			this.servers.AutoSize = true;
			this.servers.BackColor = Color.Transparent;
			this.servers.Font = new Font("Segoe UI Semibold", 10.95f, FontStyle.Bold);
			this.servers.ForeColor = Color.FromArgb(81, 0, 198);
			this.servers.Location = new Point(160, 84);
			this.servers.Name = "servers";
			this.servers.Size = new Size(33, 20);
			this.servers.TabIndex = 10;
			this.servers.Text = "000";
			this.label4.AutoSize = true;
			this.label4.BackColor = Color.Transparent;
			this.label4.Font = new Font("Segoe UI Semibold", 10.95f, FontStyle.Bold);
			this.label4.ForeColor = Color.Silver;
			this.label4.Location = new Point(131, 29);
			this.label4.Name = "label4";
			this.label4.Size = new Size(97, 20);
			this.label4.TabIndex = 9;
			this.label4.Text = "Total Servers";
			this.pictureBox2.BackColor = Color.Transparent;
			this.pictureBox2.Image = (Image)componentResourceManager.GetObject("pictureBox2.Image");
			this.pictureBox2.Location = new Point(3, 3);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new Size(99, 145);
			this.pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
			this.pictureBox2.TabIndex = 8;
			this.pictureBox2.TabStop = false;
			this.siticonePanel3.BorderColor = Color.FromArgb(255, 128, 128);
			this.siticonePanel3.BorderRadius = 18;
			this.siticonePanel3.Controls.Add(this.users);
			this.siticonePanel3.Controls.Add(this.label1);
			this.siticonePanel3.Controls.Add(this.pictureBox1);
			this.siticonePanel3.FillColor = Color.FromArgb(27, 27, 27);
			this.siticonePanel3.Location = new Point(16, 30);
			this.siticonePanel3.Name = "siticonePanel3";
			this.siticonePanel3.ShadowDecoration.Parent = this.siticonePanel3;
			this.siticonePanel3.Size = new Size(271, 151);
			this.siticonePanel3.TabIndex = 10;
			this.users.AutoSize = true;
			this.users.BackColor = Color.Transparent;
			this.users.Font = new Font("Segoe UI Semibold", 10.95f, FontStyle.Bold);
			this.users.ForeColor = Color.FromArgb(81, 0, 198);
			this.users.Location = new Point(160, 84);
			this.users.Name = "users";
			this.users.Size = new Size(33, 20);
			this.users.TabIndex = 7;
			this.users.Text = "000";
			this.label1.AutoSize = true;
			this.label1.BackColor = Color.Transparent;
			this.label1.Font = new Font("Segoe UI Semibold", 10.95f, FontStyle.Bold);
			this.label1.ForeColor = Color.Silver;
			this.label1.Location = new Point(127, 29);
			this.label1.Name = "label1";
			this.label1.Size = new Size(126, 20);
			this.label1.TabIndex = 6;
			this.label1.Text = "Active Customers";
			this.pictureBox1.BackColor = Color.Transparent;
			this.pictureBox1.Image = (Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new Point(3, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new Size(99, 145);
			this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(18, 18, 18);
			base.Controls.Add(this.siticonePanel7);
			base.Controls.Add(this.siticonePanel6);
			base.Controls.Add(this.siticonePanel5);
			base.Controls.Add(this.siticonePanel4);
			base.Controls.Add(this.siticonePanel3);
			base.Name = "dashboard";
			base.Size = new Size(861, 575);
			base.Load += this.dashboard_Load;
			this.siticonePanel7.ResumeLayout(false);
			this.siticonePanel7.PerformLayout();
			this.siticonePanel6.ResumeLayout(false);
			this.siticonePanel6.PerformLayout();
			this.siticonePanel5.ResumeLayout(false);
			this.siticonePanel5.PerformLayout();
			((ISupportInitialize)this.pictureBox3).EndInit();
			this.siticonePanel4.ResumeLayout(false);
			this.siticonePanel4.PerformLayout();
			((ISupportInitialize)this.pictureBox2).EndInit();
			this.siticonePanel3.ResumeLayout(false);
			this.siticonePanel3.PerformLayout();
			((ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000024 RID: 36
		private IContainer components = null;

		// Token: 0x04000025 RID: 37
		private SiticonePanel siticonePanel7;

		// Token: 0x04000026 RID: 38
		private Label cons;

		// Token: 0x04000027 RID: 39
		private Label label18;

		// Token: 0x04000028 RID: 40
		private SiticoneSeparator siticoneSeparator5;

		// Token: 0x04000029 RID: 41
		private Label boottime;

		// Token: 0x0400002A RID: 42
		private Label label16;

		// Token: 0x0400002B RID: 43
		private SiticoneSeparator siticoneSeparator4;

		// Token: 0x0400002C RID: 44
		private Label expire;

		// Token: 0x0400002D RID: 45
		private Label label14;

		// Token: 0x0400002E RID: 46
		private SiticoneSeparator siticoneSeparator3;

		// Token: 0x0400002F RID: 47
		private Label level;

		// Token: 0x04000030 RID: 48
		private Label label12;

		// Token: 0x04000031 RID: 49
		private SiticoneSeparator siticoneSeparator2;

		// Token: 0x04000032 RID: 50
		private Label username;

		// Token: 0x04000033 RID: 51
		private Label label10;

		// Token: 0x04000034 RID: 52
		private SiticoneSeparator siticoneSeparator1;

		// Token: 0x04000035 RID: 53
		private SiticoneButton siticoneButton7;

		// Token: 0x04000036 RID: 54
		private Label label9;

		// Token: 0x04000037 RID: 55
		private SiticonePanel siticonePanel6;

		// Token: 0x04000038 RID: 56
		private RichTextBox richTextBox1;

		// Token: 0x04000039 RID: 57
		private Label label7;

		// Token: 0x0400003A RID: 58
		private SiticoneButton siticoneButton6;

		// Token: 0x0400003B RID: 59
		private SiticonePanel siticonePanel5;

		// Token: 0x0400003C RID: 60
		private Label label5;

		// Token: 0x0400003D RID: 61
		private Label label6;

		// Token: 0x0400003E RID: 62
		private PictureBox pictureBox3;

		// Token: 0x0400003F RID: 63
		private SiticonePanel siticonePanel4;

		// Token: 0x04000040 RID: 64
		private Label servers;

		// Token: 0x04000041 RID: 65
		private Label label4;

		// Token: 0x04000042 RID: 66
		private PictureBox pictureBox2;

		// Token: 0x04000043 RID: 67
		private SiticonePanel siticonePanel3;

		// Token: 0x04000044 RID: 68
		private Label users;

		// Token: 0x04000045 RID: 69
		private Label label1;

		// Token: 0x04000046 RID: 70
		private PictureBox pictureBox1;

        public object DeveloperFunctions { get; private set; }
    }
}
