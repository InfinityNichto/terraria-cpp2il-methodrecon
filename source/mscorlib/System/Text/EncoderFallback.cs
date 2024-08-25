using System;
using Cpp2IlInjected;

namespace System.Text
{
	// Token: 0x0200026F RID: 623
	[Serializable]
	public abstract class EncoderFallback
	{
		// Token: 0x17000218 RID: 536
		// (get) Token: 0x060014F5 RID: 5365 RVA: 0x0000207A File Offset: 0x0000027A
		public static EncoderFallback ReplacementFallback
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x060014F6 RID: 5366 RVA: 0x0000207A File Offset: 0x0000027A
		public static EncoderFallback ExceptionFallback
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x060014F7 RID: 5367
		public abstract EncoderFallbackBuffer CreateFallbackBuffer();

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x060014F8 RID: 5368
		public abstract int MaxCharCount { get; }

		// Token: 0x060014F9 RID: 5369 RVA: 0x0002BBFC File Offset: 0x00029DFC
		protected EncoderFallback()
		{
		}

		// Token: 0x04000B09 RID: 2825
		private static EncoderFallback s_replacementFallback;

		// Token: 0x04000B0A RID: 2826
		private static EncoderFallback s_exceptionFallback;
	}
}
