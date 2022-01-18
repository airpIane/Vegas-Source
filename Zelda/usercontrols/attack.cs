using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using SafeGuard;
using Siticone.UI.AnimatorNS;
using Siticone.UI.WinForms;
using Siticone.UI.WinForms.Enums;

namespace Zelda.usercontrols
{
	// Token: 0x02000013 RID: 19
	public class attack : UserControl
	{
		// Token: 0x06000072 RID: 114 RVA: 0x000B43C4 File Offset: 0x000B43C4
		public attack()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000073 RID: 115 RVA: 0x000BAFFC File Offset: 0x000BAFFC
		private void SendBTN_Click(object sender, EventArgs e)
		{
			string text = ClientFunctions.AttackRequest(ResponseInformation.loginresponse.UserName, ResponseInformation.Password, ProgramInformation.ProgramId, this.Host.Text, this.Port.Text, this.MethodCB.Text, this.Time.Text, true);
			MessageBox.Show(text);
			Task.Run(delegate()
			{
				DiscordLogging.DiscordLog("attack", ResponseInformation.loginresponse.UserName, Tools.GetClientIP(), "");
			});
			this.timer1.Start();
			this.AttackDataGrid.Rows.Add(new object[]
			{
				this.Host.Text,
				this.Port.Text,
				this.Time.Text,
				this.MethodCB.Text
			});
			this.siticoneProgressBar1.Value = 0;
			this.SendBTN.Enabled = false;
			this.level1_cooldown.Start();
			this.richTextBox2.Text = "Attack has been sent";
		}

		// Token: 0x06000074 RID: 116 RVA: 0x000B41EC File Offset: 0x000B41EC
		private void MethodCB_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000BB110 File Offset: 0x000BB110
		[DebuggerStepThrough]
		private void Serverslection_SelectedIndexChanged(object sender, EventArgs e)
		{
			attack.<Serverslection_SelectedIndexChanged>d__3 <Serverslection_SelectedIndexChanged>d__ = new attack.<Serverslection_SelectedIndexChanged>d__3();
			<Serverslection_SelectedIndexChanged>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Serverslection_SelectedIndexChanged>d__.<>4__this = this;
			<Serverslection_SelectedIndexChanged>d__.sender = sender;
			<Serverslection_SelectedIndexChanged>d__.e = e;
			<Serverslection_SelectedIndexChanged>d__.<>1__state = -1;
			<Serverslection_SelectedIndexChanged>d__.<>t__builder.Start<attack.<Serverslection_SelectedIndexChanged>d__3>(ref <Serverslection_SelectedIndexChanged>d__);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000BB158 File Offset: 0x000BB158
		private void level1_cooldown_Tick(object sender, EventArgs e)
		{
			int maximum;
			switch (ResponseInformation.loginresponse.Level)
			{
			case 1:
				maximum = 60;
				break;
			case 2:
				maximum = 30;
				break;
			case 3:
				maximum = 15;
				break;
			case 4:
				maximum = 100;
				break;
			default:
				maximum = 0;
				break;
			}
			this.siticoneProgressBar1.Maximum = maximum;
			bool flag = this.siticoneProgressBar1.Value < this.siticoneProgressBar1.Maximum;
			if (flag)
			{
				this.siticoneProgressBar1.Value = this.siticoneProgressBar1.Value + 1;
			}
			bool flag2 = this.siticoneProgressBar1.Value == this.siticoneProgressBar1.Maximum;
			if (flag2)
			{
				this.level1_cooldown.Stop();
				this.siticoneProgressBar1.Value = this.siticoneProgressBar1.Maximum;
				this.SendBTN.Enabled = true;
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x000B41EC File Offset: 0x000B41EC
		private void siticonePanel2_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000078 RID: 120 RVA: 0x000B41EC File Offset: 0x000B41EC
		private void attack_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000079 RID: 121 RVA: 0x000B41EC File Offset: 0x000B41EC
		private void timer1_Tick(object sender, EventArgs e)
		{
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000B41EC File Offset: 0x000B41EC
		private void siticoneProgressBar1_ValueChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600007B RID: 123 RVA: 0x000BB23C File Offset: 0x000BB23C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000BB274 File Offset: 0x000BB274
		private void InitializeComponent()
		{
			this.components = new Container();
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			Animation animation = new Animation();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(attack));
			this.siticonePanel10 = new SiticonePanel();
			this.label21 = new Label();
			this.richTextBox2 = new RichTextBox();
			this.siticonePanel11 = new SiticonePanel();
			this.label22 = new Label();
			this.AttackDataGrid = new SiticoneDataGridView();
			this.IP = new DataGridViewTextBoxColumn();
			this.P = new DataGridViewTextBoxColumn();
			this.T = new DataGridViewTextBoxColumn();
			this.M = new DataGridViewTextBoxColumn();
			this.siticoneButton11 = new SiticoneButton();
			this.siticonePanel9 = new SiticonePanel();
			this.label26 = new Label();
			this.label25 = new Label();
			this.siticoneButton10 = new SiticoneButton();
			this.siticonePanel8 = new SiticonePanel();
			this.label24 = new Label();
			this.label23 = new Label();
			this.siticoneButton9 = new SiticoneButton();
			this.siticonePanel2 = new SiticonePanel();
			this.siticoneProgressBar1 = new SiticoneProgressBar();
			this.label19 = new Label();
			this.label20 = new Label();
			this.siticoneButton8 = new SiticoneButton();
			this.SendBTN = new SiticoneButton();
			this.siticoneSeparator7 = new SiticoneSeparator();
			this.MethodCB = new SiticoneComboBox();
			this.siticoneSeparator6 = new SiticoneSeparator();
			this.Serverslection = new SiticoneComboBox();
			this.Time = new SiticoneMaterialTextBox();
			this.Port = new SiticoneMaterialTextBox();
			this.Host = new SiticoneMaterialTextBox();
			this.Trans = new SiticoneTransition();
			this.siticoneTransparentDrag1 = new SiticoneTransparentDrag();
			this.level1_cooldown = new Timer(this.components);
			this.timer1 = new Timer(this.components);
			this.imageList1 = new ImageList(this.components);
			this.siticonePanel10.SuspendLayout();
			this.siticonePanel11.SuspendLayout();
			((ISupportInitialize)this.AttackDataGrid).BeginInit();
			this.siticonePanel9.SuspendLayout();
			this.siticonePanel8.SuspendLayout();
			this.siticonePanel2.SuspendLayout();
			base.SuspendLayout();
			this.siticonePanel10.BorderRadius = 18;
			this.siticonePanel10.Controls.Add(this.label21);
			this.siticonePanel10.Controls.Add(this.richTextBox2);
			this.Trans.SetDecoration(this.siticonePanel10, DecorationType.None);
			this.siticonePanel10.FillColor = Color.FromArgb(27, 27, 27);
			this.siticonePanel10.Location = new Point(14, 421);
			this.siticonePanel10.Name = "siticonePanel10";
			this.siticonePanel10.ShadowDecoration.Parent = this.siticonePanel10;
			this.siticonePanel10.Size = new Size(841, 134);
			this.siticonePanel10.TabIndex = 10;
			this.label21.AutoSize = true;
			this.label21.BackColor = Color.Transparent;
			this.Trans.SetDecoration(this.label21, DecorationType.None);
			this.label21.Font = new Font("Segoe UI Semibold", 9.95f, FontStyle.Bold);
			this.label21.ForeColor = Color.Silver;
			this.label21.Location = new Point(7, 6);
			this.label21.Name = "label21";
			this.label21.Size = new Size(54, 19);
			this.label21.TabIndex = 22;
			this.label21.Text = "Output";
			this.richTextBox2.BackColor = Color.FromArgb(27, 27, 27);
			this.richTextBox2.BorderStyle = BorderStyle.None;
			this.Trans.SetDecoration(this.richTextBox2, DecorationType.None);
			this.richTextBox2.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.richTextBox2.ForeColor = Color.White;
			this.richTextBox2.Location = new Point(9, 31);
			this.richTextBox2.Name = "richTextBox2";
			this.richTextBox2.Size = new Size(824, 96);
			this.richTextBox2.TabIndex = 0;
			this.richTextBox2.Text = "Attack hasn't been sent.";
			this.siticonePanel11.BorderRadius = 18;
			this.siticonePanel11.Controls.Add(this.label22);
			this.siticonePanel11.Controls.Add(this.AttackDataGrid);
			this.siticonePanel11.Controls.Add(this.siticoneButton11);
			this.Trans.SetDecoration(this.siticonePanel11, DecorationType.None);
			this.siticonePanel11.FillColor = Color.FromArgb(27, 27, 27);
			this.siticonePanel11.Location = new Point(419, 150);
			this.siticonePanel11.Name = "siticonePanel11";
			this.siticonePanel11.ShadowDecoration.Parent = this.siticonePanel11;
			this.siticonePanel11.Size = new Size(434, 265);
			this.siticonePanel11.TabIndex = 9;
			this.label22.AutoSize = true;
			this.label22.BackColor = Color.Transparent;
			this.Trans.SetDecoration(this.label22, DecorationType.None);
			this.label22.Font = new Font("Segoe UI Semibold", 9.95f, FontStyle.Bold);
			this.label22.ForeColor = Color.Silver;
			this.label22.Location = new Point(47, 14);
			this.label22.Name = "label22";
			this.label22.Size = new Size(82, 19);
			this.label22.TabIndex = 22;
			this.label22.Text = "Attack Logs";
			this.AttackDataGrid.AllowUserToAddRows = false;
			this.AttackDataGrid.AllowUserToDeleteRows = false;
			dataGridViewCellStyle.BackColor = Color.FromArgb(20, 20, 24);
			this.AttackDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
			this.AttackDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			this.AttackDataGrid.BackgroundColor = Color.FromArgb(27, 27, 27);
			this.AttackDataGrid.BorderStyle = BorderStyle.None;
			this.AttackDataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = Color.FromArgb(99, 110, 255);
			dataGridViewCellStyle2.Font = new Font("Segoe UI", 10f);
			dataGridViewCellStyle2.ForeColor = Color.White;
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
			this.AttackDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.AttackDataGrid.ColumnHeadersHeight = 21;
			this.AttackDataGrid.Columns.AddRange(new DataGridViewColumn[]
			{
				this.IP,
				this.P,
				this.T,
				this.M
			});
			this.Trans.SetDecoration(this.AttackDataGrid, DecorationType.None);
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = Color.FromArgb(20, 20, 24);
			dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.5f);
			dataGridViewCellStyle3.ForeColor = Color.White;
			dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(30, 30, 34);
			dataGridViewCellStyle3.SelectionForeColor = Color.White;
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
			this.AttackDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
			this.AttackDataGrid.EnableHeadersVisualStyles = false;
			this.AttackDataGrid.GridColor = Color.FromArgb(27, 27, 27);
			this.AttackDataGrid.Location = new Point(6, 41);
			this.AttackDataGrid.Name = "AttackDataGrid";
			this.AttackDataGrid.ReadOnly = true;
			this.AttackDataGrid.RowHeadersVisible = false;
			this.AttackDataGrid.RowTemplate.Height = 25;
			this.AttackDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.AttackDataGrid.Size = new Size(423, 214);
			this.AttackDataGrid.TabIndex = 3;
			this.AttackDataGrid.Theme = DataGridViewPresetThemes.Default;
			this.AttackDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(20, 20, 24);
			this.AttackDataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.AttackDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
			this.AttackDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
			this.AttackDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
			this.AttackDataGrid.ThemeStyle.BackColor = Color.FromArgb(27, 27, 27);
			this.AttackDataGrid.ThemeStyle.GridColor = Color.FromArgb(27, 27, 27);
			this.AttackDataGrid.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(99, 110, 255);
			this.AttackDataGrid.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
			this.AttackDataGrid.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 10f);
			this.AttackDataGrid.ThemeStyle.HeaderStyle.ForeColor = Color.White;
			this.AttackDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.AttackDataGrid.ThemeStyle.HeaderStyle.Height = 21;
			this.AttackDataGrid.ThemeStyle.ReadOnly = true;
			this.AttackDataGrid.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(20, 20, 24);
			this.AttackDataGrid.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.Single;
			this.AttackDataGrid.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 10.5f);
			this.AttackDataGrid.ThemeStyle.RowsStyle.ForeColor = Color.White;
			this.AttackDataGrid.ThemeStyle.RowsStyle.Height = 25;
			this.AttackDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(30, 30, 34);
			this.AttackDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
			this.IP.HeaderText = "IP";
			this.IP.Name = "IP";
			this.IP.ReadOnly = true;
			this.P.HeaderText = "Port";
			this.P.Name = "P";
			this.P.ReadOnly = true;
			this.T.HeaderText = "Time";
			this.T.Name = "T";
			this.T.ReadOnly = true;
			this.M.HeaderText = "Method";
			this.M.Name = "M";
			this.M.ReadOnly = true;
			this.siticoneButton11.BorderColor = Color.FromArgb(27, 27, 27);
			this.siticoneButton11.CheckedState.FillColor = Color.FromArgb(27, 27, 27);
			this.siticoneButton11.CheckedState.Parent = this.siticoneButton11;
			this.siticoneButton11.CustomBorderColor = Color.Transparent;
			this.siticoneButton11.CustomImages.Parent = this.siticoneButton11;
			this.Trans.SetDecoration(this.siticoneButton11, DecorationType.None);
			this.siticoneButton11.FillColor = Color.FromArgb(27, 27, 27);
			this.siticoneButton11.Font = new Font("Segoe UI", 9f);
			this.siticoneButton11.ForeColor = Color.White;
			this.siticoneButton11.HoveredState.FillColor = Color.FromArgb(27, 27, 27);
			this.siticoneButton11.HoveredState.Parent = this.siticoneButton11;
			this.siticoneButton11.Image = (Image)componentResourceManager.GetObject("siticoneButton11.Image");
			this.siticoneButton11.ImageSize = new Size(28, 28);
			this.siticoneButton11.Location = new Point(3, 4);
			this.siticoneButton11.Name = "siticoneButton11";
			this.siticoneButton11.PressedColor = Color.FromArgb(27, 27, 27);
			this.siticoneButton11.ShadowDecoration.Parent = this.siticoneButton11;
			this.siticoneButton11.Size = new Size(42, 39);
			this.siticoneButton11.TabIndex = 2;
			this.siticonePanel9.BorderRadius = 18;
			this.siticonePanel9.Controls.Add(this.label26);
			this.siticonePanel9.Controls.Add(this.label25);
			this.siticonePanel9.Controls.Add(this.siticoneButton10);
			this.Trans.SetDecoration(this.siticonePanel9, DecorationType.None);
			this.siticonePanel9.FillColor = Color.FromArgb(27, 27, 27);
			this.siticonePanel9.Location = new Point(641, 19);
			this.siticonePanel9.Name = "siticonePanel9";
			this.siticonePanel9.ShadowDecoration.Parent = this.siticonePanel9;
			this.siticonePanel9.Size = new Size(212, 125);
			this.siticonePanel9.TabIndex = 8;
			this.label26.AutoSize = true;
			this.label26.BackColor = Color.Transparent;
			this.Trans.SetDecoration(this.label26, DecorationType.None);
			this.label26.Font = new Font("Segoe UI Semibold", 10.95f, FontStyle.Bold);
			this.label26.ForeColor = Color.FromArgb(81, 0, 198);
			this.label26.Location = new Point(82, 57);
			this.label26.Name = "label26";
			this.label26.Size = new Size(49, 20);
			this.label26.TabIndex = 24;
			this.label26.Text = "16434";
			this.label25.AutoSize = true;
			this.label25.BackColor = Color.Transparent;
			this.Trans.SetDecoration(this.label25, DecorationType.None);
			this.label25.Font = new Font("Segoe UI Semibold", 9.95f, FontStyle.Bold);
			this.label25.ForeColor = Color.Silver;
			this.label25.Location = new Point(59, 13);
			this.label25.Name = "label25";
			this.label25.Size = new Size(100, 19);
			this.label25.TabIndex = 23;
			this.label25.Text = "Global Attacks";
			this.siticoneButton10.BorderColor = Color.FromArgb(27, 27, 27);
			this.siticoneButton10.CheckedState.Parent = this.siticoneButton10;
			this.siticoneButton10.CustomBorderColor = Color.Transparent;
			this.siticoneButton10.CustomImages.Parent = this.siticoneButton10;
			this.Trans.SetDecoration(this.siticoneButton10, DecorationType.None);
			this.siticoneButton10.FillColor = Color.FromArgb(27, 27, 27);
			this.siticoneButton10.Font = new Font("Segoe UI", 9f);
			this.siticoneButton10.ForeColor = Color.White;
			this.siticoneButton10.HoveredState.FillColor = Color.FromArgb(27, 27, 27);
			this.siticoneButton10.HoveredState.Parent = this.siticoneButton10;
			this.siticoneButton10.Image = (Image)componentResourceManager.GetObject("siticoneButton10.Image");
			this.siticoneButton10.ImageSize = new Size(28, 28);
			this.siticoneButton10.Location = new Point(5, 4);
			this.siticoneButton10.Name = "siticoneButton10";
			this.siticoneButton10.PressedColor = Color.FromArgb(27, 27, 27);
			this.siticoneButton10.ShadowDecoration.Parent = this.siticoneButton10;
			this.siticoneButton10.Size = new Size(48, 36);
			this.siticoneButton10.TabIndex = 2;
			this.siticonePanel8.BorderRadius = 18;
			this.siticonePanel8.Controls.Add(this.label24);
			this.siticonePanel8.Controls.Add(this.label23);
			this.siticonePanel8.Controls.Add(this.siticoneButton9);
			this.Trans.SetDecoration(this.siticonePanel8, DecorationType.None);
			this.siticonePanel8.FillColor = Color.FromArgb(27, 27, 27);
			this.siticonePanel8.Location = new Point(419, 19);
			this.siticonePanel8.Name = "siticonePanel8";
			this.siticonePanel8.ShadowDecoration.Parent = this.siticonePanel8;
			this.siticonePanel8.Size = new Size(214, 125);
			this.siticonePanel8.TabIndex = 7;
			this.label24.AutoSize = true;
			this.label24.BackColor = Color.Transparent;
			this.Trans.SetDecoration(this.label24, DecorationType.None);
			this.label24.Font = new Font("Segoe UI Semibold", 10.95f, FontStyle.Bold);
			this.label24.ForeColor = Color.FromArgb(81, 0, 198);
			this.label24.Location = new Point(89, 55);
			this.label24.Name = "label24";
			this.label24.Size = new Size(23, 20);
			this.label24.TabIndex = 23;
			this.label24.Text = "10";
			this.label23.AutoSize = true;
			this.label23.BackColor = Color.Transparent;
			this.Trans.SetDecoration(this.label23, DecorationType.None);
			this.label23.Font = new Font("Segoe UI Semibold", 9.95f, FontStyle.Bold);
			this.label23.ForeColor = Color.Silver;
			this.label23.Location = new Point(54, 11);
			this.label23.Name = "label23";
			this.label23.Size = new Size(126, 19);
			this.label23.TabIndex = 22;
			this.label23.Text = "Servers Connected";
			this.siticoneButton9.BorderColor = Color.FromArgb(27, 27, 27);
			this.siticoneButton9.CheckedState.Parent = this.siticoneButton9;
			this.siticoneButton9.CustomBorderColor = Color.Transparent;
			this.siticoneButton9.CustomImages.Parent = this.siticoneButton9;
			this.Trans.SetDecoration(this.siticoneButton9, DecorationType.None);
			this.siticoneButton9.FillColor = Color.FromArgb(27, 27, 27);
			this.siticoneButton9.Font = new Font("Segoe UI", 9f);
			this.siticoneButton9.ForeColor = Color.White;
			this.siticoneButton9.HoveredState.FillColor = Color.FromArgb(27, 27, 27);
			this.siticoneButton9.HoveredState.Parent = this.siticoneButton9;
			this.siticoneButton9.Image = (Image)componentResourceManager.GetObject("siticoneButton9.Image");
			this.siticoneButton9.ImageSize = new Size(28, 28);
			this.siticoneButton9.Location = new Point(3, 4);
			this.siticoneButton9.Name = "siticoneButton9";
			this.siticoneButton9.PressedColor = Color.FromArgb(27, 27, 27);
			this.siticoneButton9.ShadowDecoration.Parent = this.siticoneButton9;
			this.siticoneButton9.Size = new Size(51, 34);
			this.siticoneButton9.TabIndex = 2;
			this.siticonePanel2.BorderRadius = 18;
			this.siticonePanel2.Controls.Add(this.siticoneProgressBar1);
			this.siticonePanel2.Controls.Add(this.label19);
			this.siticonePanel2.Controls.Add(this.label20);
			this.siticonePanel2.Controls.Add(this.siticoneButton8);
			this.siticonePanel2.Controls.Add(this.SendBTN);
			this.siticonePanel2.Controls.Add(this.siticoneSeparator7);
			this.siticonePanel2.Controls.Add(this.MethodCB);
			this.siticonePanel2.Controls.Add(this.siticoneSeparator6);
			this.siticonePanel2.Controls.Add(this.Serverslection);
			this.siticonePanel2.Controls.Add(this.Time);
			this.siticonePanel2.Controls.Add(this.Port);
			this.siticonePanel2.Controls.Add(this.Host);
			this.Trans.SetDecoration(this.siticonePanel2, DecorationType.None);
			this.siticonePanel2.FillColor = Color.FromArgb(27, 27, 27);
			this.siticonePanel2.Location = new Point(14, 19);
			this.siticonePanel2.Name = "siticonePanel2";
			this.siticonePanel2.ShadowDecoration.Parent = this.siticonePanel2;
			this.siticonePanel2.Size = new Size(399, 397);
			this.siticonePanel2.TabIndex = 6;
			this.siticonePanel2.Paint += this.siticonePanel2_Paint;
			this.siticoneProgressBar1.BackColor = Color.FromArgb(30, 30, 30);
			this.Trans.SetDecoration(this.siticoneProgressBar1, DecorationType.None);
			this.siticoneProgressBar1.FillColor = Color.FromArgb(22, 22, 22);
			this.siticoneProgressBar1.GradientMode = LinearGradientMode.Horizontal;
			this.siticoneProgressBar1.Location = new Point(12, 356);
			this.siticoneProgressBar1.Name = "siticoneProgressBar1";
			this.siticoneProgressBar1.ProgressColor = Color.DarkSlateBlue;
			this.siticoneProgressBar1.ProgressColor2 = Color.DarkSlateBlue;
			this.siticoneProgressBar1.ShadowDecoration.Parent = this.siticoneProgressBar1;
			this.siticoneProgressBar1.Size = new Size(374, 23);
			this.siticoneProgressBar1.TabIndex = 196;
			this.siticoneProgressBar1.TextRenderingHint = TextRenderingHint.SystemDefault;
			this.siticoneProgressBar1.ValueChanged += this.siticoneProgressBar1_ValueChanged;
			this.label19.AutoSize = true;
			this.label19.BackColor = Color.Transparent;
			this.Trans.SetDecoration(this.label19, DecorationType.None);
			this.label19.Font = new Font("Segoe UI Semibold", 7.95f, FontStyle.Bold);
			this.label19.ForeColor = Color.FromArgb(81, 0, 198);
			this.label19.Location = new Point(80, 41);
			this.label19.Name = "label19";
			this.label19.Size = new Size(151, 13);
			this.label19.TabIndex = 22;
			this.label19.Text = "Send Layer 4 Attack, Layer 7.\r\n";
			this.label20.AutoSize = true;
			this.label20.BackColor = Color.Transparent;
			this.Trans.SetDecoration(this.label20, DecorationType.None);
			this.label20.Font = new Font("Segoe UI Semibold", 9.95f, FontStyle.Bold);
			this.label20.ForeColor = Color.Silver;
			this.label20.Location = new Point(80, 19);
			this.label20.Name = "label20";
			this.label20.Size = new Size(79, 19);
			this.label20.TabIndex = 21;
			this.label20.Text = "Attack Hub";
			this.siticoneButton8.BorderColor = Color.FromArgb(27, 27, 27);
			this.siticoneButton8.CheckedState.Parent = this.siticoneButton8;
			this.siticoneButton8.CustomBorderColor = Color.Transparent;
			this.siticoneButton8.CustomImages.Parent = this.siticoneButton8;
			this.Trans.SetDecoration(this.siticoneButton8, DecorationType.None);
			this.siticoneButton8.FillColor = Color.FromArgb(27, 27, 27);
			this.siticoneButton8.Font = new Font("Segoe UI", 9f);
			this.siticoneButton8.ForeColor = Color.White;
			this.siticoneButton8.HoveredState.FillColor = Color.FromArgb(27, 27, 27);
			this.siticoneButton8.HoveredState.Parent = this.siticoneButton8;
			this.siticoneButton8.Image = (Image)componentResourceManager.GetObject("siticoneButton8.Image");
			this.siticoneButton8.ImageSize = new Size(28, 28);
			this.siticoneButton8.Location = new Point(10, 9);
			this.siticoneButton8.Name = "siticoneButton8";
			this.siticoneButton8.PressedColor = Color.FromArgb(27, 27, 27);
			this.siticoneButton8.ShadowDecoration.Parent = this.siticoneButton8;
			this.siticoneButton8.Size = new Size(64, 49);
			this.siticoneButton8.TabIndex = 2;
			this.SendBTN.BorderRadius = 3;
			this.SendBTN.CheckedState.Parent = this.SendBTN;
			this.SendBTN.CustomImages.Parent = this.SendBTN;
			this.Trans.SetDecoration(this.SendBTN, DecorationType.None);
			this.SendBTN.FillColor = Color.FromArgb(81, 0, 198);
			this.SendBTN.Font = new Font("Segoe UI", 9f);
			this.SendBTN.ForeColor = Color.White;
			this.SendBTN.HoveredState.Parent = this.SendBTN;
			this.SendBTN.Location = new Point(12, 302);
			this.SendBTN.Name = "SendBTN";
			this.SendBTN.ShadowDecoration.Parent = this.SendBTN;
			this.SendBTN.Size = new Size(374, 39);
			this.SendBTN.TabIndex = 7;
			this.SendBTN.Text = "Launch Attack";
			this.SendBTN.Click += this.SendBTN_Click;
			this.Trans.SetDecoration(this.siticoneSeparator7, DecorationType.None);
			this.siticoneSeparator7.FillColor = Color.White;
			this.siticoneSeparator7.Location = new Point(12, 270);
			this.siticoneSeparator7.Name = "siticoneSeparator7";
			this.siticoneSeparator7.Size = new Size(374, 10);
			this.siticoneSeparator7.TabIndex = 6;
			this.MethodCB.BackColor = Color.Transparent;
			this.MethodCB.BorderColor = Color.FromArgb(27, 27, 27);
			this.Trans.SetDecoration(this.MethodCB, DecorationType.None);
			this.MethodCB.DrawMode = DrawMode.OwnerDrawFixed;
			this.MethodCB.DropDownStyle = ComboBoxStyle.DropDownList;
			this.MethodCB.FillColor = Color.FromArgb(27, 27, 27);
			this.MethodCB.Font = new Font("Segoe UI", 10f);
			this.MethodCB.ForeColor = Color.White;
			this.MethodCB.FormattingEnabled = true;
			this.MethodCB.HoveredState.BorderColor = Color.FromArgb(27, 27, 27);
			this.MethodCB.HoveredState.FillColor = Color.FromArgb(27, 27, 27);
			this.MethodCB.HoveredState.Parent = this.MethodCB;
			this.MethodCB.ItemHeight = 30;
			this.MethodCB.ItemsAppearance.Parent = this.MethodCB;
			this.MethodCB.Location = new Point(12, 235);
			this.MethodCB.Name = "MethodCB";
			this.MethodCB.ShadowDecoration.Parent = this.MethodCB;
			this.MethodCB.Size = new Size(374, 36);
			this.MethodCB.TabIndex = 5;
			this.MethodCB.SelectedIndexChanged += this.MethodCB_SelectedIndexChanged;
			this.Trans.SetDecoration(this.siticoneSeparator6, DecorationType.None);
			this.siticoneSeparator6.FillColor = Color.White;
			this.siticoneSeparator6.Location = new Point(12, 217);
			this.siticoneSeparator6.Name = "siticoneSeparator6";
			this.siticoneSeparator6.Size = new Size(374, 10);
			this.siticoneSeparator6.TabIndex = 4;
			this.Serverslection.BackColor = Color.Transparent;
			this.Serverslection.BorderColor = Color.FromArgb(27, 27, 27);
			this.Trans.SetDecoration(this.Serverslection, DecorationType.None);
			this.Serverslection.DrawMode = DrawMode.OwnerDrawFixed;
			this.Serverslection.DropDownStyle = ComboBoxStyle.DropDownList;
			this.Serverslection.FillColor = Color.FromArgb(27, 27, 27);
			this.Serverslection.Font = new Font("Segoe UI", 10f);
			this.Serverslection.ForeColor = Color.White;
			this.Serverslection.FormattingEnabled = true;
			this.Serverslection.HoveredState.BorderColor = Color.FromArgb(27, 27, 27);
			this.Serverslection.HoveredState.FillColor = Color.FromArgb(27, 27, 27);
			this.Serverslection.HoveredState.Parent = this.Serverslection;
			this.Serverslection.ItemHeight = 30;
			this.Serverslection.Items.AddRange(new object[]
			{
				"PRIVATE NETWORK",
				"LEAKZ",
				"QUARTZ",
				"DIOR",
				"SMOKEY",
				"ECLIPSE",
				"HYDRO",
				"TCP",
				"HOME-HOLDER"
			});
			this.Serverslection.ItemsAppearance.Parent = this.Serverslection;
			this.Serverslection.Location = new Point(12, 182);
			this.Serverslection.Name = "Serverslection";
			this.Serverslection.ShadowDecoration.Parent = this.Serverslection;
			this.Serverslection.Size = new Size(374, 36);
			this.Serverslection.TabIndex = 3;
			this.Serverslection.SelectedIndexChanged += this.Serverslection_SelectedIndexChanged;
			this.Time.BorderColor = Color.White;
			this.Time.Cursor = Cursors.IBeam;
			this.Trans.SetDecoration(this.Time, DecorationType.None);
			this.Time.DefaultText = "Time";
			this.Time.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			this.Time.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			this.Time.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			this.Time.DisabledState.Parent = this.Time;
			this.Time.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			this.Time.FillColor = Color.FromArgb(27, 27, 27);
			this.Time.FocusedState.BorderColor = Color.FromArgb(81, 0, 198);
			this.Time.FocusedState.Parent = this.Time;
			this.Time.ForeColor = Color.White;
			this.Time.HoveredState.BorderColor = Color.Silver;
			this.Time.HoveredState.Parent = this.Time;
			this.Time.Location = new Point(197, 123);
			this.Time.Name = "Time";
			this.Time.PasswordChar = '\0';
			this.Time.PlaceholderText = "";
			this.Time.SelectedText = "";
			this.Time.ShadowDecoration.Parent = this.Time;
			this.Time.Size = new Size(189, 36);
			this.Time.TabIndex = 2;
			this.Port.BorderColor = Color.White;
			this.Port.Cursor = Cursors.IBeam;
			this.Trans.SetDecoration(this.Port, DecorationType.None);
			this.Port.DefaultText = "Port";
			this.Port.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			this.Port.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			this.Port.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			this.Port.DisabledState.Parent = this.Port;
			this.Port.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			this.Port.FillColor = Color.FromArgb(27, 27, 27);
			this.Port.FocusedState.BorderColor = Color.FromArgb(81, 0, 198);
			this.Port.FocusedState.Parent = this.Port;
			this.Port.ForeColor = Color.White;
			this.Port.HoveredState.BorderColor = Color.Silver;
			this.Port.HoveredState.Parent = this.Port;
			this.Port.Location = new Point(12, 123);
			this.Port.Name = "Port";
			this.Port.PasswordChar = '\0';
			this.Port.PlaceholderText = "";
			this.Port.SelectedText = "";
			this.Port.ShadowDecoration.Parent = this.Port;
			this.Port.Size = new Size(179, 36);
			this.Port.TabIndex = 1;
			this.Host.BorderColor = Color.White;
			this.Host.Cursor = Cursors.IBeam;
			this.Trans.SetDecoration(this.Host, DecorationType.None);
			this.Host.DefaultText = "Host";
			this.Host.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			this.Host.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			this.Host.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			this.Host.DisabledState.Parent = this.Host;
			this.Host.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			this.Host.FillColor = Color.FromArgb(27, 27, 27);
			this.Host.FocusedState.BorderColor = Color.FromArgb(81, 0, 198);
			this.Host.FocusedState.Parent = this.Host;
			this.Host.ForeColor = Color.White;
			this.Host.HoveredState.BorderColor = Color.Silver;
			this.Host.HoveredState.Parent = this.Host;
			this.Host.Location = new Point(12, 64);
			this.Host.Name = "Host";
			this.Host.PasswordChar = '\0';
			this.Host.PlaceholderText = "";
			this.Host.SelectedText = "";
			this.Host.ShadowDecoration.Parent = this.Host;
			this.Host.Size = new Size(374, 36);
			this.Host.TabIndex = 0;
			this.Trans.AnimationType = AnimationType.ScaleAndRotate;
			this.Trans.Cursor = null;
			animation.AnimateOnlyDifferences = true;
			animation.BlindCoeff = (PointF)componentResourceManager.GetObject("animation2.BlindCoeff");
			animation.LeafCoeff = 0f;
			animation.MaxTime = 1f;
			animation.MinTime = 0f;
			animation.MosaicCoeff = (PointF)componentResourceManager.GetObject("animation2.MosaicCoeff");
			animation.MosaicShift = (PointF)componentResourceManager.GetObject("animation2.MosaicShift");
			animation.MosaicSize = 0;
			animation.Padding = new Padding(30);
			animation.RotateCoeff = 0.5f;
			animation.RotateLimit = 0.2f;
			animation.ScaleCoeff = (PointF)componentResourceManager.GetObject("animation2.ScaleCoeff");
			animation.SlideCoeff = (PointF)componentResourceManager.GetObject("animation2.SlideCoeff");
			animation.TimeCoeff = 0f;
			animation.TransparencyCoeff = 0f;
			this.Trans.DefaultAnimation = animation;
			this.siticoneTransparentDrag1.DragEndTransparencyValue = 1.0;
			this.siticoneTransparentDrag1.DragStartTransparencyValue = 0.9;
			this.siticoneTransparentDrag1.TargetDragControl = null;
			this.level1_cooldown.Interval = 1000;
			this.level1_cooldown.Tick += this.level1_cooldown_Tick;
			this.timer1.Interval = 1000;
			this.timer1.Tick += this.timer1_Tick;
			this.imageList1.ColorDepth = ColorDepth.Depth8Bit;
			this.imageList1.ImageSize = new Size(16, 16);
			this.imageList1.TransparentColor = Color.Transparent;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(18, 18, 18);
			base.Controls.Add(this.siticonePanel10);
			base.Controls.Add(this.siticonePanel11);
			base.Controls.Add(this.siticonePanel9);
			base.Controls.Add(this.siticonePanel8);
			base.Controls.Add(this.siticonePanel2);
			this.Trans.SetDecoration(this, DecorationType.None);
			base.Name = "attack";
			base.Size = new Size(861, 575);
			base.Load += this.attack_Load;
			this.siticonePanel10.ResumeLayout(false);
			this.siticonePanel10.PerformLayout();
			this.siticonePanel11.ResumeLayout(false);
			this.siticonePanel11.PerformLayout();
			((ISupportInitialize)this.AttackDataGrid).EndInit();
			this.siticonePanel9.ResumeLayout(false);
			this.siticonePanel9.PerformLayout();
			this.siticonePanel8.ResumeLayout(false);
			this.siticonePanel8.PerformLayout();
			this.siticonePanel2.ResumeLayout(false);
			this.siticonePanel2.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000082 RID: 130
		private IContainer components = null;

		// Token: 0x04000083 RID: 131
		private SiticonePanel siticonePanel10;

		// Token: 0x04000084 RID: 132
		private Label label21;

		// Token: 0x04000085 RID: 133
		private RichTextBox richTextBox2;

		// Token: 0x04000086 RID: 134
		private SiticonePanel siticonePanel11;

		// Token: 0x04000087 RID: 135
		private Label label22;

		// Token: 0x04000088 RID: 136
		private SiticoneDataGridView AttackDataGrid;

		// Token: 0x04000089 RID: 137
		private SiticoneButton siticoneButton11;

		// Token: 0x0400008A RID: 138
		private SiticonePanel siticonePanel9;

		// Token: 0x0400008B RID: 139
		private Label label26;

		// Token: 0x0400008C RID: 140
		private Label label25;

		// Token: 0x0400008D RID: 141
		private SiticoneButton siticoneButton10;

		// Token: 0x0400008E RID: 142
		private SiticonePanel siticonePanel8;

		// Token: 0x0400008F RID: 143
		private Label label24;

		// Token: 0x04000090 RID: 144
		private Label label23;

		// Token: 0x04000091 RID: 145
		private SiticoneButton siticoneButton9;

		// Token: 0x04000092 RID: 146
		private SiticonePanel siticonePanel2;

		// Token: 0x04000093 RID: 147
		private Label label19;

		// Token: 0x04000094 RID: 148
		private Label label20;

		// Token: 0x04000095 RID: 149
		private SiticoneButton siticoneButton8;

		// Token: 0x04000096 RID: 150
		private SiticoneButton SendBTN;

		// Token: 0x04000097 RID: 151
		private SiticoneSeparator siticoneSeparator7;

		// Token: 0x04000098 RID: 152
		private SiticoneComboBox MethodCB;

		// Token: 0x04000099 RID: 153
		private SiticoneSeparator siticoneSeparator6;

		// Token: 0x0400009A RID: 154
		private SiticoneComboBox Serverslection;

		// Token: 0x0400009B RID: 155
		private SiticoneMaterialTextBox Time;

		// Token: 0x0400009C RID: 156
		private SiticoneMaterialTextBox Port;

		// Token: 0x0400009D RID: 157
		private SiticoneMaterialTextBox Host;

		// Token: 0x0400009E RID: 158
		private SiticoneTransition Trans;

		// Token: 0x0400009F RID: 159
		private SiticoneTransparentDrag siticoneTransparentDrag1;

		// Token: 0x040000A0 RID: 160
		private Timer level1_cooldown;

		// Token: 0x040000A1 RID: 161
		private DataGridViewTextBoxColumn IP;

		// Token: 0x040000A2 RID: 162
		private DataGridViewTextBoxColumn P;

		// Token: 0x040000A3 RID: 163
		private DataGridViewTextBoxColumn T;

		// Token: 0x040000A4 RID: 164
		private DataGridViewTextBoxColumn M;

		// Token: 0x040000A5 RID: 165
		private SiticoneProgressBar siticoneProgressBar1;

		// Token: 0x040000A6 RID: 166
		private Timer timer1;

		// Token: 0x040000A7 RID: 167
		private ImageList imageList1;

		// Token: 0x02000022 RID: 34
		private sealed class <>c__DisplayClass3_4
		{
			// Token: 0x060000B1 RID: 177 RVA: 0x000B4552 File Offset: 0x000B4552
			internal Task<string> <Serverslection_SelectedIndexChanged>b__4()
			{
				return this.wc.GetStringAsync("https://pastebin.com/raw/G9AfKdrE");
			}

			// Token: 0x040000E3 RID: 227
			public HttpClient wc;
		}

		// Token: 0x02000025 RID: 37
		private sealed class <>c__DisplayClass3_7
		{
			// Token: 0x060000B7 RID: 183 RVA: 0x000B4588 File Offset: 0x000B4588
			internal Task<string> <Serverslection_SelectedIndexChanged>b__7()
			{
				return this.wc.GetStringAsync("https://pastebin.com/raw/QsfgfWZd");
			}

			// Token: 0x040000E6 RID: 230
			public HttpClient wc;
		}

		// Token: 0x02000026 RID: 38
		private sealed class <>c__DisplayClass3_8
		{
			// Token: 0x060000B9 RID: 185 RVA: 0x000B459A File Offset: 0x000B459A
			internal Task<string> <Serverslection_SelectedIndexChanged>b__8()
			{
				return this.wc.GetStringAsync("https://pastebin.com/raw/GSVZQhAn");
			}

			// Token: 0x040000E7 RID: 231
			public HttpClient wc;
		}

		// Token: 0x02000027 RID: 39
		private sealed class <>c__DisplayClass3_9
		{
			// Token: 0x060000BB RID: 187 RVA: 0x000B45AC File Offset: 0x000B45AC
			internal Task<string> <Serverslection_SelectedIndexChanged>b__9()
			{
				return this.wc.GetStringAsync("https://pastebin.com/raw/WnfUfXXM");
			}

			// Token: 0x040000E8 RID: 232
			public HttpClient wc;
		}
	}
}
