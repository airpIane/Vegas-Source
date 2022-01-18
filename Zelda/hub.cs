using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using SafeGuard;
using Siticone.UI.AnimatorNS;
using Siticone.UI.WinForms;
using Siticone.UI.WinForms.Enums;
using Work.discord;
using Zelda.usercontrols;

namespace Zelda
{
	// Token: 0x0200000E RID: 14
	public partial class hub : Form
	{
		// Token: 0x0600003E RID: 62 RVA: 0x000B41EF File Offset: 0x000B41EF
		public hub()
		{
			this.InitializeComponent();
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600003F RID: 63 RVA: 0x000B4212 File Offset: 0x000B4212
		// (set) Token: 0x06000040 RID: 64 RVA: 0x000B4219 File Offset: 0x000B4219
		private static WebClient WebClient { get; set; }

		// Token: 0x06000041 RID: 65 RVA: 0x000B88B8 File Offset: 0x000B88B8
		private static byte[] Post(string uri, NameValueCollection pairs)
		{
			byte[] result;
			using (hub.WebClient = new WebClient())
			{
				result = hub.WebClient.UploadValues(uri, pairs);
			}
			return result;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000B4221 File Offset: 0x000B4221
		private static void sendWebHook(string URL, string msg, string username)
		{
			hub.Post(URL, new NameValueCollection
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

		// Token: 0x06000043 RID: 67 RVA: 0x000B41EC File Offset: 0x000B41EC
		private void lookupBTN_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000B41EC File Offset: 0x000B41EC
		private void pingBTN_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000B41EC File Offset: 0x000B41EC
		private void PapingBTN_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000B8900 File Offset: 0x000B8900
		[DebuggerStepThrough]
		private void siticoneButton19_Click(object sender, EventArgs e)
		{
			hub.<siticoneButton19_Click>d__14 <siticoneButton19_Click>d__ = new hub.<siticoneButton19_Click>d__14();
			<siticoneButton19_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<siticoneButton19_Click>d__.<>4__this = this;
			<siticoneButton19_Click>d__.sender = sender;
			<siticoneButton19_Click>d__.e = e;
			<siticoneButton19_Click>d__.<>1__state = -1;
			<siticoneButton19_Click>d__.<>t__builder.Start<hub.<siticoneButton19_Click>d__14>(ref <siticoneButton19_Click>d__);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000B41EC File Offset: 0x000B41EC
		private void Sentd_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000B41EC File Offset: 0x000B41EC
		private void siticoneButton13_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000B424A File Offset: 0x000B424A
		private void DashBTN_Click(object sender, EventArgs e)
		{
			this.dashboard1.Visible = true;
			this.attack1.Visible = false;
			this.spammer1.Visible = false;
			this.tools1.Visible = false;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000B4281 File Offset: 0x000B4281
		private void AttackBTN_Click(object sender, EventArgs e)
		{
			this.dashboard1.Visible = false;
			this.attack1.Visible = true;
			this.spammer1.Visible = false;
			this.tools1.Visible = false;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000B42B8 File Offset: 0x000B42B8
		private void ToolBTN_Click(object sender, EventArgs e)
		{
			this.dashboard1.Visible = false;
			this.attack1.Visible = false;
			this.spammer1.Visible = false;
			this.tools1.Visible = true;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000B8948 File Offset: 0x000B8948
		private void DiscordBTN_Click(object sender, EventArgs e)
		{
			ResponseInformation.count = DeveloperFunctions.CountCall(ProgramInformation.ProgramId);
			this.handlers = default(DiscordRpc.EventHandlers);
			DiscordRpc.Initialize("908759381636698153", ref this.handlers, true, null);
			this.handlers = default(DiscordRpc.EventHandlers);
			DiscordRpc.Initialize("883757615694356550", ref this.handlers, true, null);
			this.presence.details = "t.me/vegasservices";
			this.presence.state = "Logged in as: " + ResponseInformation.loginresponse.UserName;
			this.presence.largeImageKey = "logo";
			this.presence.smallImageKey = "small";
			this.presence.largeImageText = "Starting at $5";
			this.presence.smallImageText = "";
			this.presence.startTimestamp = DateTimeOffset.Now.ToUnixTimeSeconds();
			DiscordRpc.UpdatePresence(ref this.presence);
			MessageBox.Show("Discord RPC Enabled");
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000B42EF File Offset: 0x000B42EF
		private void SupportBTN_Click(object sender, EventArgs e)
		{
			this.dashboard1.Visible = false;
			this.attack1.Visible = false;
			this.spammer1.Visible = false;
			this.tools1.Visible = false;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000B41EC File Offset: 0x000B41EC
		private void SettingsBTN_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000B41EC File Offset: 0x000B41EC
		private void Dashboard_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000B41EC File Offset: 0x000B41EC
		private void SendBTN_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000B41EC File Offset: 0x000B41EC
		private void siticonePanel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000B41EC File Offset: 0x000B41EC
		private void MethodCB_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000B8A44 File Offset: 0x000B8A44
		[DebuggerStepThrough]
		private void Serverslection_SelectedIndexChanged(object sender, EventArgs e)
		{
			hub.<Serverslection_SelectedIndexChanged>d__27 <Serverslection_SelectedIndexChanged>d__ = new hub.<Serverslection_SelectedIndexChanged>d__27();
			<Serverslection_SelectedIndexChanged>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Serverslection_SelectedIndexChanged>d__.<>4__this = this;
			<Serverslection_SelectedIndexChanged>d__.sender = sender;
			<Serverslection_SelectedIndexChanged>d__.e = e;
			<Serverslection_SelectedIndexChanged>d__.<>1__state = -1;
			<Serverslection_SelectedIndexChanged>d__.<>t__builder.Start<hub.<Serverslection_SelectedIndexChanged>d__27>(ref <Serverslection_SelectedIndexChanged>d__);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x000B41EC File Offset: 0x000B41EC
		private void hub_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000B41EC File Offset: 0x000B41EC
		private void SendBTN_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000B41EC File Offset: 0x000B41EC
		private void AttackDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000B41EC File Offset: 0x000B41EC
		private void siticoneButton2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000B41EC File Offset: 0x000B41EC
		private void discord_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000B41EC File Offset: 0x000B41EC
		private void LogsBox_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000B41EC File Offset: 0x000B41EC
		private void siticoneControlBox2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000B4326 File Offset: 0x000B4326
		private void siticoneControlBox1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x04000059 RID: 89
		private DiscordRpc.EventHandlers handlers;

		// Token: 0x0400005A RID: 90
		private DiscordRpc.RichPresence presence;

		// Token: 0x0400005B RID: 91
		private int time2 = 99999;

		// Token: 0x0400005C RID: 92
		private int value;
	}
}
