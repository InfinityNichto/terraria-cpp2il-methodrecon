using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace ReLogic.Utilities
{
	// Token: 0x02000B05 RID: 2821
	public static class ReinterpretCast
	{
		// Token: 0x06005283 RID: 21123 RVA: 0x000021DB File Offset: 0x000003DB
		public static float UIntAsFloat(uint value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06005284 RID: 21124 RVA: 0x000021DB File Offset: 0x000003DB
		public static float IntAsFloat(int value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06005285 RID: 21125 RVA: 0x000021DB File Offset: 0x000003DB
		public static uint FloatAsUInt(float value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06005286 RID: 21126 RVA: 0x000021DB File Offset: 0x000003DB
		public static int FloatAsInt(float value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x02000B06 RID: 2822
		[StructLayout(2)]
		private struct IntFloat
		{
			// Token: 0x06005287 RID: 21127 RVA: 0x00283204 File Offset: 0x00281404
			public IntFloat(int value)
			{
				this.IntValue = value;
			}

			// Token: 0x06005288 RID: 21128 RVA: 0x00283218 File Offset: 0x00281418
			public IntFloat(float value)
			{
			}

			// Token: 0x04008ACB RID: 35531
			public readonly int IntValue;

			// Token: 0x04008ACC RID: 35532
			public readonly float FloatValue;
		}

		// Token: 0x02000B07 RID: 2823
		[StructLayout(2)]
		private struct UIntFloat
		{
			// Token: 0x06005289 RID: 21129 RVA: 0x00283228 File Offset: 0x00281428
			public UIntFloat(uint value)
			{
				this.UIntValue = value;
			}

			// Token: 0x0600528A RID: 21130 RVA: 0x0028323C File Offset: 0x0028143C
			public UIntFloat(float value)
			{
			}

			// Token: 0x04008ACD RID: 35533
			public readonly uint UIntValue;

			// Token: 0x04008ACE RID: 35534
			public readonly float FloatValue;
		}
	}
}
