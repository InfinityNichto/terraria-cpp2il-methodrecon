using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Collections;

namespace UnityEngine.Profiling.Experimental
{
	// Token: 0x020000F2 RID: 242
	public struct DebugScreenCapture
	{
		// Token: 0x1700010F RID: 271
		// (set) Token: 0x06000521 RID: 1313 RVA: 0x000093D8 File Offset: 0x000075D8
		public NativeArray<byte> rawImageDataReference
		{
			[CompilerGenerated]
			set
			{
				this.<rawImageDataReference>k__BackingField = value;
			}
		}

		// Token: 0x17000110 RID: 272
		// (set) Token: 0x06000522 RID: 1314 RVA: 0x000093EC File Offset: 0x000075EC
		public TextureFormat imageFormat
		{
			[CompilerGenerated]
			set
			{
				this.<imageFormat>k__BackingField = value;
			}
		}

		// Token: 0x17000111 RID: 273
		// (set) Token: 0x06000523 RID: 1315 RVA: 0x00009400 File Offset: 0x00007600
		public int width
		{
			[CompilerGenerated]
			set
			{
				this.<width>k__BackingField = value;
			}
		}

		// Token: 0x17000112 RID: 274
		// (set) Token: 0x06000524 RID: 1316 RVA: 0x00009414 File Offset: 0x00007614
		public int height
		{
			[CompilerGenerated]
			set
			{
				this.<height>k__BackingField = value;
			}
		}

		// Token: 0x0400040E RID: 1038
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private NativeArray<byte> <rawImageDataReference>k__BackingField;

		// Token: 0x0400040F RID: 1039
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private TextureFormat <imageFormat>k__BackingField;

		// Token: 0x04000410 RID: 1040
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private int <width>k__BackingField;

		// Token: 0x04000411 RID: 1041
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private int <height>k__BackingField;
	}
}
