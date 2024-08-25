using System;
using Cpp2IlInjected;
using Newtonsoft.Json;

namespace Terraria.Utilities.Terraria.Utilities
{
	// Token: 0x0200050A RID: 1290
	public struct FloatRange
	{
		// Token: 0x06003132 RID: 12594 RVA: 0x001F7BE4 File Offset: 0x001F5DE4
		public FloatRange(float minimum, float maximum)
		{
		}

		// Token: 0x06003133 RID: 12595 RVA: 0x000021DB File Offset: 0x000003DB
		public static FloatRange operator *(FloatRange range, float scale)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003134 RID: 12596 RVA: 0x000021DB File Offset: 0x000003DB
		public static FloatRange operator *(float scale, FloatRange range)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003135 RID: 12597 RVA: 0x000021DB File Offset: 0x000003DB
		public static FloatRange operator /(FloatRange range, float scale)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003136 RID: 12598 RVA: 0x000021DB File Offset: 0x000003DB
		public static FloatRange operator /(float scale, FloatRange range)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x04003AFB RID: 15099
		[JsonProperty("Min")]
		public readonly float Minimum;

		// Token: 0x04003AFC RID: 15100
		[JsonProperty("Max")]
		public readonly float Maximum;
	}
}
