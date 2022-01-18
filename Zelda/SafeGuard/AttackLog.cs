using System;
using System.Runtime.CompilerServices;

namespace SafeGuard
{
	// Token: 0x02000002 RID: 2
	public class AttackLog
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000002 RID: 2 RVA: 0x000B405B File Offset: 0x000B405B
		// (set) Token: 0x06000003 RID: 3 RVA: 0x000B4063 File Offset: 0x000B4063
		public long Id
		{
			get
			{
				return this.<Id>k__BackingField;
			}
			set
			{
				this.<Id>k__BackingField = value;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000004 RID: 4 RVA: 0x000B406C File Offset: 0x000B406C
		// (set) Token: 0x06000005 RID: 5 RVA: 0x000B4074 File Offset: 0x000B4074
		public string AttkIp
		{
			get
			{
				return this.<AttkIp>k__BackingField;
			}
			set
			{
				this.<AttkIp>k__BackingField = value;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000006 RID: 6 RVA: 0x000B407D File Offset: 0x000B407D
		// (set) Token: 0x06000007 RID: 7 RVA: 0x000B4085 File Offset: 0x000B4085
		public int AttkPort { get; set; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000008 RID: 8 RVA: 0x000B408E File Offset: 0x000B408E
		// (set) Token: 0x06000009 RID: 9 RVA: 0x000B4096 File Offset: 0x000B4096
		public int AttkTime
		{
			get
			{
				return this.<AttkTime>k__BackingField;
			}
			set
			{
				this.<AttkTime>k__BackingField = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000A RID: 10 RVA: 0x000B409F File Offset: 0x000B409F
		// (set) Token: 0x0600000B RID: 11 RVA: 0x000B40A7 File Offset: 0x000B40A7
		public string AttkMethod
		{
			get
			{
				return this.<AttkMethod>k__BackingField;
			}
			set
			{
				this.<AttkMethod>k__BackingField = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000C RID: 12 RVA: 0x000B40B0 File Offset: 0x000B40B0
		// (set) Token: 0x0600000D RID: 13 RVA: 0x000B40B8 File Offset: 0x000B40B8
		public string Client
		{
			get
			{
				return this.<Client>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Client>k__BackingField = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000E RID: 14 RVA: 0x000B40C1 File Offset: 0x000B40C1
		// (set) Token: 0x0600000F RID: 15 RVA: 0x000B40C9 File Offset: 0x000B40C9
		public string ClientIp { get; set; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000010 RID: 16 RVA: 0x000B40D2 File Offset: 0x000B40D2
		// (set) Token: 0x06000011 RID: 17 RVA: 0x000B40DA File Offset: 0x000B40DA
		public long ProgramId { get; set; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000012 RID: 18 RVA: 0x000B40E3 File Offset: 0x000B40E3
		// (set) Token: 0x06000013 RID: 19 RVA: 0x000B40EB File Offset: 0x000B40EB
		public DateTime Timestamp
		{
			get
			{
				return this.<Timestamp>k__BackingField;
			}
			set
			{
				this.<Timestamp>k__BackingField = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000014 RID: 20 RVA: 0x000B40F4 File Offset: 0x000B40F4
		// (set) Token: 0x06000015 RID: 21 RVA: 0x000B40FC File Offset: 0x000B40FC
		public bool ManuallyStopped
		{
			get
			{
				return this.<ManuallyStopped>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ManuallyStopped>k__BackingField = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000016 RID: 22 RVA: 0x000B4105 File Offset: 0x000B4105
		// (set) Token: 0x06000017 RID: 23 RVA: 0x000B410D File Offset: 0x000B410D
		public long TimeInMS { get; set; }

		// Token: 0x04000005 RID: 5
		private string <AttkMethod>k__BackingField;

		// Token: 0x04000006 RID: 6
		private string <Client>k__BackingField;
	}
}
