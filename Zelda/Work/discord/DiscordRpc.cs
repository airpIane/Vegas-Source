using System;
using System.Runtime.InteropServices;

namespace Work.discord
{
	// Token: 0x02000017 RID: 23
	internal class DiscordRpc
	{
		// Token: 0x06000091 RID: 145
		[DllImport("discord-rpc-w32.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_Initialize")]
		public static extern void Initialize(string applicationId, ref DiscordRpc.EventHandlers handlers, bool autoRegister, string optionalSteamId);

		// Token: 0x06000092 RID: 146
		[DllImport("discord-rpc-w32.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_RunCallbacks")]
		public static extern void RunCallbacks();

		// Token: 0x06000093 RID: 147
		[DllImport("discord-rpc-w32.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_Shutdown")]
		public static extern void Shutdown();

		// Token: 0x06000094 RID: 148
		[DllImport("discord-rpc-w32.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_UpdatePresence")]
		public static extern void UpdatePresence(ref DiscordRpc.RichPresence presence);

		// Token: 0x06000095 RID: 149 RVA: 0x000B4467 File Offset: 0x000B4467
		internal static void Initialize(string v1, ref object handlers, bool v2, object p)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0200002A RID: 42
		// (Invoke) Token: 0x060000C3 RID: 195
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void DisconnectedCallback(int errorCode, string message);

		// Token: 0x0200002B RID: 43
		// (Invoke) Token: 0x060000C7 RID: 199
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void ErrorCallback(int errorCode, string message);

		// Token: 0x0200002C RID: 44
		public struct EventHandlers
		{
			// Token: 0x04000124 RID: 292
			public DiscordRpc.ReadyCallback readyCallback;

			// Token: 0x04000125 RID: 293
			public DiscordRpc.DisconnectedCallback disconnectedCallback;

			// Token: 0x04000126 RID: 294
			public DiscordRpc.ErrorCallback errorCallback;
		}

		// Token: 0x0200002D RID: 45
		// (Invoke) Token: 0x060000CB RID: 203
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void ReadyCallback();

		// Token: 0x0200002E RID: 46
		[Serializable]
		public struct RichPresence
		{
			// Token: 0x04000127 RID: 295
			public string state;

			// Token: 0x04000128 RID: 296
			public string details;

			// Token: 0x04000129 RID: 297
			public long startTimestamp;

			// Token: 0x0400012A RID: 298
			public long endTimestamp;

			// Token: 0x0400012B RID: 299
			public string largeImageKey;

			// Token: 0x0400012C RID: 300
			public string largeImageText;

			// Token: 0x0400012D RID: 301
			public string smallImageKey;

			// Token: 0x0400012E RID: 302
			public string smallImageText;

			// Token: 0x0400012F RID: 303
			public string partyId;

			// Token: 0x04000130 RID: 304
			public int partySize;

			// Token: 0x04000131 RID: 305
			public int partyMax;

			// Token: 0x04000132 RID: 306
			public string matchSecret;

			// Token: 0x04000133 RID: 307
			public string joinSecret;

			// Token: 0x04000134 RID: 308
			public string spectateSecret;

			// Token: 0x04000135 RID: 309
			public bool instance;
		}
	}
}
