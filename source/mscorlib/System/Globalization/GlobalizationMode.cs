using System;
using System.Runtime.CompilerServices;

namespace System.Globalization
{
	// Token: 0x020005A7 RID: 1447
	internal static class GlobalizationMode
	{
		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x06002B69 RID: 11113 RVA: 0x0005F974 File Offset: 0x0005DB74
		internal static bool Invariant
		{
			[CompilerGenerated]
			get
			{
				if (!true)
				{
				}
				return true;
			}
		}

		// Token: 0x06002B6A RID: 11114 RVA: 0x0005F988 File Offset: 0x0005DB88
		private static bool GetGlobalizationInvariantMode()
		{
		}

		// Token: 0x06002B6B RID: 11115 RVA: 0x0005F998 File Offset: 0x0005DB98
		// Note: this type is marked as 'beforefieldinit'.
		static GlobalizationMode()
		{
		}

		// Token: 0x04001818 RID: 6168
		[CompilerGenerated]
		private static readonly bool <Invariant>k__BackingField;
	}
}
