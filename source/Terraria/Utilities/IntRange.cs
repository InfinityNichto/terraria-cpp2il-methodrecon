using System;
using Cpp2IlInjected;
using Newtonsoft.Json;

namespace Terraria.Utilities
{
	// Token: 0x020004FA RID: 1274
	public struct IntRange
	{
		// Token: 0x060030E3 RID: 12515 RVA: 0x001F7218 File Offset: 0x001F5418
		public IntRange(int minimum, int maximum)
		{
			this.Minimum = minimum;
		}

		// Token: 0x060030E4 RID: 12516 RVA: 0x000021DB File Offset: 0x000003DB
		public static IntRange operator *(IntRange range, float scale)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060030E5 RID: 12517 RVA: 0x000021DB File Offset: 0x000003DB
		public static IntRange operator *(float scale, IntRange range)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060030E6 RID: 12518 RVA: 0x000021DB File Offset: 0x000003DB
		public static IntRange operator /(IntRange range, float scale)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060030E7 RID: 12519 RVA: 0x000021DB File Offset: 0x000003DB
		public static IntRange operator /(float scale, IntRange range)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x04003ACD RID: 15053
		[JsonProperty("Min")]
		public readonly int Minimum;

		// Token: 0x04003ACE RID: 15054
		[JsonProperty("Max")]
		public readonly int Maximum;
	}
}
