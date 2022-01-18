using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using SafeGuard;
using Siticone.UI.WinForms;
using Siticone.UI.WinForms.Enums;

namespace Zelda
{
	// Token: 0x02000010 RID: 16
	public partial class Register : Form
	{
		// Token: 0x0600005F RID: 95 RVA: 0x000B434A File Offset: 0x000B434A
		public Register()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000B9AF0 File Offset: 0x000B9AF0
		private void siticoneButton1_Click(object sender, EventArgs e)
		{
			ResponseInformation.registerinfo = ClientFunctions.Register(this.user1.Text, this.pass1.Text, this.token.Text, this.email.Text, ProgramInformation.ProgramId);
			bool flag = !ResponseInformation.registerinfo.Failure;
			if (flag)
			{
				ResponseInformation.loginresponse = ClientFunctions.Login(this.user1.Text, this.pass1.Text, ProgramInformation.ProgramId);
				bool failure = ResponseInformation.loginresponse.Failure;
				if (failure)
				{
					MessageBox.Show(ResponseInformation.loginresponse.Message);
				}
				else
				{
					Task.Run(new Action(Register.<>c.<>9.<siticoneButton1_Click>b__1_0));
					MessageBox.Show(ResponseInformation.loginresponse.Message);
					ResponseInformation.Password = this.pass1.Text;
					base.Hide();
					Form1 form = new Form1();
					form.ShowDialog();
					base.Close();
				}
			}
			else
			{
				MessageBox.Show(ResponseInformation.registerinfo.Message);
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000B41EC File Offset: 0x000B41EC
		private void siticoneControlBox2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000B9C0C File Offset: 0x000B9C0C
		private void label4_Click(object sender, EventArgs e)
		{
			base.Hide();
			Form1 form = new Form1();
			form.ShowDialog();
			base.Close();
		}

		// Token: 0x0200001B RID: 27
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060000A2 RID: 162 RVA: 0x000B44AA File Offset: 0x000B44AA
			internal void <siticoneButton1_Click>b__1_0()
			{
				DiscordLogging.DiscordLog("register", ResponseInformation.loginresponse.UserName, Tools.GetClientIP(), "");
			}

			// Token: 0x040000DA RID: 218
			public static readonly Register.<>c <>9 = new Register.<>c();

			// Token: 0x040000DB RID: 219
			public static Action <>9__1_0;
		}
	}
}
