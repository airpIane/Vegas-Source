using System;
using System.Runtime.CompilerServices;

namespace SafeGuard
{
	// Token: 0x02000003 RID: 3
	public class MethodStats
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000019 RID: 25 RVA: 0x000B411F File Offset: 0x000B411F
		// (set) Token: 0x0600001A RID: 26 RVA: 0x000B4127 File Offset: 0x000B4127
		public string Method
		{
			get
			{
				return this.<Method>k__BackingField;
			}
			set
			{
				this.<Method>k__BackingField = value;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600001B RID: 27 RVA: 0x000B4130 File Offset: 0x000B4130
		// (set) Token: 0x0600001C RID: 28 RVA: 0x000B4138 File Offset: 0x000B4138
		public int Count
		{
			[CompilerGenerated]
			get
			{
				return this.<Count>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Count>k__BackingField = value;
			}
		}

		// Token: 0x0400000C RID: 12
		private string <Method>k__BackingField;

		// Token: 0x0400000D RID: 13
		private int <Count>k__BackingField;
	}
}
