using System;
using Cpp2IlInjected;

namespace System.Text
{
	// Token: 0x0200026C RID: 620
	[Serializable]
	public sealed class EncoderExceptionFallback : EncoderFallback
	{
		// Token: 0x060014E6 RID: 5350 RVA: 0x0002BAA8 File Offset: 0x00029CA8
		public EncoderExceptionFallback()
		{
		}

		// Token: 0x060014E7 RID: 5351 RVA: 0x0000207A File Offset: 0x0000027A
		public override EncoderFallbackBuffer CreateFallbackBuffer()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x060014E8 RID: 5352 RVA: 0x0002BABC File Offset: 0x00029CBC
		public override int MaxCharCount
		{
			get
			{
			}
		}

		// Token: 0x060014E9 RID: 5353 RVA: 0x0002BACC File Offset: 0x00029CCC
		public override bool Equals(object value)
		{
			if (value != null)
			{
				return;
			}
		}

		// Token: 0x060014EA RID: 5354 RVA: 0x0002BAE0 File Offset: 0x00029CE0
		public override int GetHashCode()
		{
			return 654;
		}
	}
}
