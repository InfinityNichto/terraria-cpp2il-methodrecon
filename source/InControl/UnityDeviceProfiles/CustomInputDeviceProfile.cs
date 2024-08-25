using System;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020000B9 RID: 185
	[JsonObject(MemberSerialization.OptIn)]
	public class CustomInputDeviceProfile : InputDeviceProfile
	{
		// Token: 0x060005FB RID: 1531 RVA: 0x000174B8 File Offset: 0x000156B8
		public CustomInputDeviceProfile(string deviceName)
		{
			if (2 == 0)
			{
			}
			base..ctor();
			this.deviceName = deviceName;
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x000174DC File Offset: 0x000156DC
		public CustomInputDeviceProfile()
		{
			if (2 == 0)
			{
			}
			base..ctor();
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x000174FC File Offset: 0x000156FC
		public string Save()
		{
			string text;
			return Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(text, "\\t\"JoystickRegex\": null,?\\n", ""), "\\t\"LastResortRegex\": null,?\\n", ""), "\\t\\t\\t\"Invert\": false,?\\n", ""), "\\t\\t\\t\"Scale\": 1,?\\n", ""), "\\t\\t\\t\"Raw\": false,?\\n", ""), "\\t\\t\\t\"IgnoreInitialZeroValue\": false,?\\n", ""), "\\t\\t\\t\"Sensitivity\": 1,?\\n", ""), "\\t\\t\\t\"LowerDeadZone\": 0,?\\n", ""), "\\t\\t\\t\"UpperDeadZone\": 1,?\\n", ""), "\\t\"Sensitivity\": 1,?\\n", ""), "\\t\"LowerDeadZone\": 0.2,?\\n", ""), "\\t\"UpperDeadZone\": 0.9,?\\n", ""), "\\t\\t\\t\"(Source|Target)Range\": {\\n\\t\\t\\t\\t\"Value0\": -1,\\n\\t\\t\\t\\t\"Value1\": 1\\n\\t\\t\\t},?\\n", ""), "\\t\"MinUnityVersion\": {\\n\\t\\t\"Major\": 3,\\n\\t\\t\"Minor\": 0,\\n\\t\\t\"Patch\": 0,\\n\\t\\t\"Build\": 0\\n\\t},?\\n", ""), "\\t\"MaxUnityVersion\": {\\n\\t\\t\"Major\": 9,\\n\\t\\t\"Minor\": 0,\\n\\t\\t\"Patch\": 0,\\n\\t\\t\"Build\": 0\\n\\t},?\\n", "");
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x000175F4 File Offset: 0x000157F4
		public static CustomInputDeviceProfile Load(string data)
		{
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x00017604 File Offset: 0x00015804
		public void SaveToFile()
		{
			string text = this.Save();
			string customProfileFolder = UnityInputDeviceManager.CustomProfileFolder;
			string deviceName = this.deviceName;
			Utility.WriteToFile(customProfileFolder + "/" + deviceName + ".json", text);
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x00017640 File Offset: 0x00015840
		public static CustomInputDeviceProfile LoadFromFile(string filePath)
		{
			if (!true)
			{
			}
			string text;
			return CustomInputDeviceProfile.Load(text);
		}

		// Token: 0x04000411 RID: 1041
		[JsonProperty]
		public bool Configured;

		// Token: 0x04000412 RID: 1042
		[JsonProperty]
		public int ForcedScheme = 2;
	}
}
