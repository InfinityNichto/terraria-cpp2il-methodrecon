using System;
using Cpp2IlInjected;

namespace System.Text
{
	// Token: 0x02000261 RID: 609
	[Serializable]
	public sealed class DecoderExceptionFallback : DecoderFallback
	{
		// Token: 0x06001495 RID: 5269 RVA: 0x0002B2E4 File Offset: 0x000294E4
		public DecoderExceptionFallback()
		{
		}

		// Token: 0x06001496 RID: 5270 RVA: 0x0000207A File Offset: 0x0000027A
		public override DecoderFallbackBuffer CreateFallbackBuffer()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06001497 RID: 5271 RVA: 0x0002B2F8 File Offset: 0x000294F8
		public override int MaxCharCount
		{
			get
			{
			}
		}

		// Token: 0x06001498 RID: 5272 RVA: 0x0002B308 File Offset: 0x00029508
		public override bool Equals(object value)
		{
			if (value != null)
			{
				return;
			}
		}

		// Token: 0x06001499 RID: 5273 RVA: 0x0002B31C File Offset: 0x0002951C
		public override int GetHashCode()
		{
			return 879;
		}
	}
}
