using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using SafeGuard;
using Siticone.UI.AnimatorNS;
using Siticone.UI.WinForms;
using Siticone.UI.WinForms.Enums;

namespace Zelda
{
	// Token: 0x0200000D RID: 13
	public partial class Form1 : Form
	{
		// Token: 0x06000038 RID: 56 RVA: 0x000B41D4 File Offset: 0x000B41D4
		public Form1()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000B738C File Offset: 0x000B738C
		private void LoginBTN_Click(object sender, EventArgs e)
		{
			ResponseInformation.loginresponse = ClientFunctions.Login(this.user.Text, this.pass.Text, ProgramInformation.ProgramId);
			ResponseInformation.Password = this.pass.Text;
			bool failure = ResponseInformation.loginresponse.Failure;
			if (failure)
			{
				MessageBox.Show(ResponseInformation.loginresponse.Message);
			}
			else
			{
				Task.Run(delegate()
				{
					DiscordLogging.DiscordLog("login", ResponseInformation.loginresponse.UserName, Tools.GetClientIP(), "");
				});
				MessageBox.Show(ResponseInformation.loginresponse.Message);
				base.Hide();
				hub hub = new hub();
				hub.ShowDialog();
				base.Close();
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000B7444 File Offset: 0x000B7444
		private void label2_Click(object sender, EventArgs e)
		{
			base.Hide();
			Register register = new Register();
			register.ShowDialog();
			base.Close();
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000B41EC File Offset: 0x000B41EC
		private void siticoneControlBox2_Click(object sender, EventArgs e)
		{
		}
	}
}
