using System;

namespace UnityEngine.Events
{
	// Token: 0x0200015A RID: 346
	internal class UnityEventTools
	{
		// Token: 0x06000677 RID: 1655 RVA: 0x0000B7DC File Offset: 0x000099DC
		internal static string TidyAssemblyTypeName(string assemblyTypeName)
		{
			bool flag = string.IsNullOrEmpty(", Version=");
			if (", Version=" == null)
			{
			}
			if (", Version=" == null)
			{
			}
			int num2;
			int num3;
			int num = Math.Min(num2, num3);
			if (", Version=" == null)
			{
			}
			int num5;
			int num4 = Math.Min(num5, num);
			string text;
			int num6 = text.IndexOf(", UnityEngine.");
			bool flag2 = text.EndsWith("Module");
			long num7 = 0L;
			return text.Substring((int)num7, num6) + ", UnityEngine";
		}
	}
}
