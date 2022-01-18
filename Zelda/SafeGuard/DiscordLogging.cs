using System;

namespace SafeGuard
{
	// Token: 0x02000005 RID: 5
	internal static class DiscordLogging
	{
		// Token: 0x06000021 RID: 33 RVA: 0x000B4DF8 File Offset: 0x000B4DF8
		public static void DiscordLog(string action, string username, string ip, string geolocatedip = "")
		{
			action = action.ToLower();
			string picture = "https://imgur.com/a/B8x4wks";
			string text = action;
			string a = text;
			string message;
			string title;
			if (!(a == "login"))
			{
				if (!(a == "geoip"))
				{
					if (!(a == "register"))
					{
						if (!(a == "attack"))
						{
							message = username + " Has Done Unknown Function";
							title = "Vegas Unknown";
						}
						else
						{
							message = username + " Has Just Sent An Attack to " + ip + "!";
							title = "login";
						}
					}
					else
					{
						message = username + " Has Registered!";
						title = "register";
					}
				}
				else
				{
					message = string.Concat(new string[]
					{
						username,
						" Has Just GeoLocated this ip: ",
						geolocatedip,
						" from IP: ",
						ip,
						"!"
					});
					title = "geoip";
				}
			}
			else
			{
				message = username + " Has Just Logged In From " + ip + "!";
				title = "login";
			}
			DiscordLogging.LogToDiscord("", new DiscordHookObject
			{
				Message = message,
				Title = title,
				Picture = picture,
				ProgramId = ProgramInformation.ProgramId
			});
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000B4F1C File Offset: 0x000B4F1C
		private static bool LogToDiscord(string apikey, DiscordHookObject DiscordObject)
		{
			bool flag = DiscordObject == null;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				try
				{
					Tools.postRequest("https://safeguardauth.us/LogToDiscordv2?apikey=" + apikey, DiscordObject);
				}
				catch
				{
					return false;
				}
				result = true;
			}
			return result;
		}
	}
}
