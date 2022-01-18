using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Zelda.Properties
{
	// Token: 0x02000012 RID: 18
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.0.3.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000069 RID: 105 RVA: 0x000BAF78 File Offset: 0x000BAF78
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600006C RID: 108 RVA: 0x000BAFB4 File Offset: 0x000BAFB4
		// (set) Token: 0x0600006D RID: 109 RVA: 0x000B4385 File Offset: 0x000B4385
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string msg
		{
			get
			{
				return (string)this["msg"];
			}
			set
			{
				this["msg"] = value;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600006E RID: 110 RVA: 0x000BAFD8 File Offset: 0x000BAFD8
		// (set) Token: 0x0600006F RID: 111 RVA: 0x000B4395 File Offset: 0x000B4395
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string username
		{
			get
			{
				return (string)this["username"];
			}
			set
			{
				this["username"] = value;
			}
		}

		// Token: 0x04000081 RID: 129
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
