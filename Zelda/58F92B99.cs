using System;
using System.Net.Security;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

// Token: 0x0200003A RID: 58
public class 58F92B99
{
	// Token: 0x060000FD RID: 253 RVA: 0x000C2DEC File Offset: 0x000C2DEC
	public 58F92B99(long 056E1E3F)
	{
		object[] 72C3372A = new object[]
		{
			this,
			056E1E3F
		};
		new 0B005140().35C217A7(72C3372A, 68999);
	}

	// Token: 0x060000FE RID: 254 RVA: 0x000C2E24 File Offset: 0x000C2E24
	public 58F92B99(byte[] 6D504B45)
	{
		object[] 72C3372A = new object[]
		{
			this,
			6D504B45
		};
		new 0B005140().35C217A7(72C3372A, 71542);
	}

	// Token: 0x04000167 RID: 359
	private readonly byte[] 48D95EF3;

	// Token: 0x04000168 RID: 360
	private byte[] 30947E93;

	// Token: 0x04000169 RID: 361
	private readonly object 0FE55E31;

	// Token: 0x0400016A RID: 362
	private 254311F2 4FF77A58;

	// Token: 0x0400016B RID: 363
	private long 7B0C3C9B;

	// Token: 0x0400016C RID: 364
	private readonly int 235C497A;

	// Token: 0x0400016D RID: 365
	private int 71EC6A67;

	// Token: 0x0400016E RID: 366
	private uint 24F75CF2;

	// Token: 0x0200004C RID: 76
	public class 44417DE4
	{
		// Token: 0x060001DE RID: 478 RVA: 0x000D2D98 File Offset: 0x000D2D98
		protected bool 50221B25(byte[] 4B4B073B)
		{
			int num = BitConverter.ToInt32(4B4B073B, 32);
			if (num == 0)
			{
				return false;
			}
			int index = BitConverter.ToInt32(4B4B073B, 28);
			this.5EBB038B = Encoding.UTF8.GetString(4B4B073B, index, num);
			if (this.5EBB038B[this.5EBB038B.Length - 1] != '/')
			{
				this.5EBB038B += "/";
			}
			return true;
		}

		// Token: 0x060001DF RID: 479 RVA: 0x000B4AD1 File Offset: 0x000B4AD1
		protected void 775263D8()
		{
			this.5EBB038B = Convert.ToBase64String(Encoding.UTF8.GetBytes(this.5EBB038B));
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x000B4AEE File Offset: 0x000B4AEE
		protected void 31110F39(string 71FC3037, string 2B7E4374)
		{
			this.68B87003(71FC3037, false);
			this.68B87003(2B7E4374, true);
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x000D2E04 File Offset: 0x000D2E04
		private void 68B87003(string 1B213E9A, bool 79242D57)
		{
			if (79242D57)
			{
				StringBuilder stringBuilder = new StringBuilder(this.5EBB038B);
				foreach (char c in 1B213E9A)
				{
					if (c != '+')
					{
						if (c != '/')
						{
							if (c != '=')
							{
								stringBuilder.Append(c);
							}
							else
							{
								stringBuilder.Append("%3D");
							}
						}
						else
						{
							stringBuilder.Append("%2F");
						}
					}
					else
					{
						stringBuilder.Append("%2B");
					}
				}
				this.5EBB038B = stringBuilder.ToString();
				return;
			}
			this.5EBB038B += 1B213E9A;
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x000B4B00 File Offset: 0x000B4B00
		// (set) Token: 0x060001E3 RID: 483 RVA: 0x000B4B08 File Offset: 0x000B4B08
		public string 5EBB038B
		{
			[CompilerGenerated]
			get
			{
				return this.716D57ED;
			}
			[CompilerGenerated]
			private set
			{
				this.716D57ED = value;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x000B4B11 File Offset: 0x000B4B11
		// (set) Token: 0x060001E5 RID: 485 RVA: 0x000B4B19 File Offset: 0x000B4B19
		public string 75D06490
		{
			get
			{
				return this.210300B3;
			}
			private set
			{
				this.210300B3 = value;
			}
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x000C25B4 File Offset: 0x000C25B4
		public 44417DE4()
		{
			uint num = 1517715308U;
			if (1002778062 << (int)num != 0)
			{
				num = 66812164U + num;
				base..ctor();
			}
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x000D2EA0 File Offset: 0x000D2EA0
		public unsafe static object 7B2D5C7F(void* 74F86A63)
		{
			uint num = 1095968429U;
			num %= 959387433U;
			Type typeFromHandle = typeof(void*);
			num = 2070232642U % num;
			return Pointer.Box(74F86A63, typeFromHandle);
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x000D2ED4 File Offset: 0x000D2ED4
		public unsafe static void* 7AF95467(object 2BBC4E15)
		{
			uint num = 407577537U;
			num ^= 974480022U;
			return Pointer.Unbox(2BBC4E15);
		}

		// Token: 0x040001D6 RID: 470
		private string 716D57ED;

		// Token: 0x040001D7 RID: 471
		private string 210300B3;

		// Token: 0x0200007C RID: 124
		[Serializable]
		private sealed class 4A3D128C
		{
			// Token: 0x06000381 RID: 897 RVA: 0x000C25B4 File Offset: 0x000C25B4
			public 4A3D128C()
			{
				uint num = 1517715308U;
				if (1002778062 << (int)num != 0)
				{
					num = 66812164U + num;
					base..ctor();
				}
			}

			// Token: 0x06000382 RID: 898 RVA: 0x000C2644 File Offset: 0x000C2644
			internal bool 647914D6(object 5D475388, X509Certificate 2D7A2737, X509Chain 2A307BE2, SslPolicyErrors 356601C0)
			{
				return true;
			}

			// Token: 0x04000233 RID: 563
			public static readonly 58F92B99.44417DE4.4A3D128C 63F511B8 = new 58F92B99.44417DE4.4A3D128C();

			// Token: 0x04000234 RID: 564
			public static RemoteCertificateValidationCallback 4CBC4A7E;
		}
	}

	// Token: 0x0200004D RID: 77
	public class 509908D7 : 58F92B99.44417DE4
	{
		// Token: 0x040001D8 RID: 472
		private string 2DC609CB;
	}

	// Token: 0x0200004E RID: 78
	public class 3C6D1ACE : 58F92B99.44417DE4
	{
	}
}
