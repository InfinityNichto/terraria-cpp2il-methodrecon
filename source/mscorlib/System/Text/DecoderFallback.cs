using System;
using Cpp2IlInjected;

namespace System.Text
{
	// Token: 0x02000264 RID: 612
	[Serializable]
	public abstract class DecoderFallback
	{
		// Token: 0x17000207 RID: 519
		// (get) Token: 0x060014A2 RID: 5282 RVA: 0x0000207A File Offset: 0x0000027A
		public static DecoderFallback ReplacementFallback
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x060014A3 RID: 5283 RVA: 0x0000207A File Offset: 0x0000027A
		public static DecoderFallback ExceptionFallback
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x060014A4 RID: 5284
		public abstract DecoderFallbackBuffer CreateFallbackBuffer();

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x060014A5 RID: 5285
		public abstract int MaxCharCount { get; }

		// Token: 0x060014A6 RID: 5286 RVA: 0x0002B3F8 File Offset: 0x000295F8
		protected DecoderFallback()
		{
		}

		// Token: 0x04000AF0 RID: 2800
		private static DecoderFallback s_replacementFallback;

		// Token: 0x04000AF1 RID: 2801
		private static DecoderFallback s_exceptionFallback;
	}
}
