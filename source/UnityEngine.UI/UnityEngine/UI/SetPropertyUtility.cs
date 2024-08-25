using System;

namespace UnityEngine.UI
{
	// Token: 0x0200006A RID: 106
	internal static class SetPropertyUtility
	{
		// Token: 0x06000457 RID: 1111 RVA: 0x0000DFE0 File Offset: 0x0000C1E0
		public static bool SetColor(Color currentValue, Color newValue)
		{
			return true;
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x0000DFF0 File Offset: 0x0000C1F0
		public static bool SetStruct<T>(T currentValue, T newValue) where T : struct
		{
			return true;
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x0000E000 File Offset: 0x0000C200
		public static bool SetClass<T>(T currentValue, T newValue) where T : class
		{
			return true;
		}
	}
}
