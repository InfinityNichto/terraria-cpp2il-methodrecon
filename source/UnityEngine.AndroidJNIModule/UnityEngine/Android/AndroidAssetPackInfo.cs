using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.Android
{
	// Token: 0x02000011 RID: 17
	public class AndroidAssetPackInfo
	{
		// Token: 0x06000180 RID: 384 RVA: 0x000054E0 File Offset: 0x000036E0
		internal AndroidAssetPackInfo(string name, AndroidAssetPackStatus status, ulong size, ulong bytesDownloaded, float transferProgress, AndroidAssetPackError error)
		{
			this.<name>k__BackingField = name;
			this.<status>k__BackingField = status;
			this.<size>k__BackingField = size;
			this.<bytesDownloaded>k__BackingField = bytesDownloaded;
			this.<error>k__BackingField = error;
		}

		// Token: 0x04000035 RID: 53
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly string <name>k__BackingField;

		// Token: 0x04000036 RID: 54
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private readonly AndroidAssetPackStatus <status>k__BackingField;

		// Token: 0x04000037 RID: 55
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private readonly ulong <size>k__BackingField;

		// Token: 0x04000038 RID: 56
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private readonly ulong <bytesDownloaded>k__BackingField;

		// Token: 0x04000039 RID: 57
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly float <transferProgress>k__BackingField;

		// Token: 0x0400003A RID: 58
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private readonly AndroidAssetPackError <error>k__BackingField;
	}
}
