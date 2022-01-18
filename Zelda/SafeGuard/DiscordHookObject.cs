using System;
using System.Runtime.CompilerServices;

namespace SafeGuard
{
	// Token: 0x02000006 RID: 6
	public class DiscordHookObject
	{
		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000023 RID: 35 RVA: 0x000B4141 File Offset: 0x000B4141
		// (set) Token: 0x06000024 RID: 36 RVA: 0x000B4149 File Offset: 0x000B4149
		public string Message
		{
			[CompilerGenerated]
			get
			{
				return this.<Message>k__BackingField;
			}
			set
			{
				this.<Message>k__BackingField = value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000025 RID: 37 RVA: 0x000B4152 File Offset: 0x000B4152
		// (set) Token: 0x06000026 RID: 38 RVA: 0x000B415A File Offset: 0x000B415A
		public string Title
		{
			get
			{
				return this.<Title>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Title>k__BackingField = value;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000027 RID: 39 RVA: 0x000B4163 File Offset: 0x000B4163
		// (set) Token: 0x06000028 RID: 40 RVA: 0x000B416B File Offset: 0x000B416B
		public string Picture { get; set; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000029 RID: 41 RVA: 0x000B4174 File Offset: 0x000B4174
		// (set) Token: 0x0600002A RID: 42 RVA: 0x000B417C File Offset: 0x000B417C
		public string ProgramId
		{
			get
			{
				return this.<ProgramId>k__BackingField;
			}
			set
			{
				this.<ProgramId>k__BackingField = value;
			}
		}

		// Token: 0x04000014 RID: 20
		private string <ProgramId>k__BackingField;
	}
}
