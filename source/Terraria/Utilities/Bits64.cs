using System;
using Cpp2IlInjected;

namespace Terraria.Utilities
{
	// Token: 0x020004F0 RID: 1264
	public struct Bits64
	{
		// Token: 0x1700060C RID: 1548
		public bool this[int i]
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x060030A1 RID: 12449 RVA: 0x000021DB File Offset: 0x000003DB
		public bool IsEmpty
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x060030A2 RID: 12450 RVA: 0x000021DB File Offset: 0x000003DB
		public static implicit operator ulong(Bits64 b)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060030A3 RID: 12451 RVA: 0x000021DB File Offset: 0x000003DB
		public static implicit operator Bits64(ulong v)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x04003AA4 RID: 15012
		private ulong v;
	}
}
