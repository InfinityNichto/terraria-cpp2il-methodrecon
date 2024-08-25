using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.Android
{
	// Token: 0x02000012 RID: 18
	public class AndroidAssetPackState
	{
		// Token: 0x06000181 RID: 385 RVA: 0x00005518 File Offset: 0x00003718
		internal AndroidAssetPackState(string name, AndroidAssetPackStatus status, AndroidAssetPackError error)
		{
			this.<name>k__BackingField = name;
			this.<status>k__BackingField = status;
		}

		// Token: 0x0400003B RID: 59
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly string <name>k__BackingField;

		// Token: 0x0400003C RID: 60
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly AndroidAssetPackStatus <status>k__BackingField;

		// Token: 0x0400003D RID: 61
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private readonly AndroidAssetPackError <error>k__BackingField;
	}
}
