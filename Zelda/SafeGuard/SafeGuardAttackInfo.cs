using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SafeGuard
{
	// Token: 0x02000004 RID: 4
	internal static class SafeGuardAttackInfo
	{
		// Token: 0x0600001E RID: 30 RVA: 0x000B4CC0 File Offset: 0x000B4CC0
		public static List<AttackLog> GetRunningAttacks()
		{
			try
			{
				SafeGuardAttackInfo.RunningAttacks = JsonConvert.DeserializeObject<List<AttackLog>>(Tools.getRequest("https://safeguardauth.us/GetOnGoingAttacks?programid=" + ProgramInformation.ProgramId + "&username=" + ResponseInformation.loginresponse.UserName));
			}
			catch
			{
				SafeGuardAttackInfo.RunningAttacks = new List<AttackLog>();
			}
			return SafeGuardAttackInfo.RunningAttacks;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000B4D28 File Offset: 0x000B4D28
		public static List<AttackLog> GetAmountOfAttacks(int num)
		{
			try
			{
				SafeGuardAttackInfo.PastAttacks = JsonConvert.DeserializeObject<List<AttackLog>>(Tools.getRequest(string.Format("https://safeguardauth.us/GetPassedAttacks?programid={0}&username={1}&num={2}", ProgramInformation.ProgramId, ResponseInformation.loginresponse.UserName, num)));
			}
			catch
			{
				SafeGuardAttackInfo.PastAttacks = new List<AttackLog>();
			}
			return SafeGuardAttackInfo.PastAttacks;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000B4D90 File Offset: 0x000B4D90
		public static List<MethodStats> GetMethodInformation()
		{
			try
			{
				SafeGuardAttackInfo.MethodInformation = JsonConvert.DeserializeObject<List<MethodStats>>(Tools.getRequest("https://safeguardauth.us/GetMethodStats?programid=" + ProgramInformation.ProgramId + "&username=" + ResponseInformation.loginresponse.UserName));
			}
			catch
			{
				SafeGuardAttackInfo.MethodInformation = new List<MethodStats>();
			}
			return SafeGuardAttackInfo.MethodInformation;
		}

		// Token: 0x0400000E RID: 14
		internal static List<AttackLog> RunningAttacks;

		// Token: 0x0400000F RID: 15
		internal static List<AttackLog> PastAttacks;

		// Token: 0x04000010 RID: 16
		internal static List<MethodStats> MethodInformation;
	}
}
