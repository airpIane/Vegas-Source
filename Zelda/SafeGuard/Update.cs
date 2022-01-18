using System;

namespace SafeGuard
{
	// Token: 0x02000007 RID: 7
	internal static class Update
	{
		// Token: 0x0600002C RID: 44 RVA: 0x000B4185 File Offset: 0x000B4185
		internal static void update()
		{
			ClientFunctions.AutoUpdate(Update.version, ProgramInformation.ProgramId);
		}

		// Token: 0x04000015 RID: 21
		internal static string version = "3.1";
	}
}
