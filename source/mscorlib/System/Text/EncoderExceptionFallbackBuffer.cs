using System;
using Cpp2IlInjected;

namespace System.Text
{
	// Token: 0x0200026D RID: 621
	public sealed class EncoderExceptionFallbackBuffer : EncoderFallbackBuffer
	{
		// Token: 0x060014EB RID: 5355 RVA: 0x0002BAF4 File Offset: 0x00029CF4
		public EncoderExceptionFallbackBuffer()
		{
		}

		// Token: 0x060014EC RID: 5356 RVA: 0x0000207A File Offset: 0x0000027A
		public override bool Fallback(char charUnknown, int index)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060014ED RID: 5357 RVA: 0x0002BB08 File Offset: 0x00029D08
		public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index)
		{
			bool flag = char.IsHighSurrogate(charUnknownHigh);
			bool flag2 = char.IsLowSurrogate(charUnknownLow);
			int num = char.ConvertToUtf32(charUnknownHigh, charUnknownLow);
			return "charUnknownHigh" != null;
		}

		// Token: 0x060014EE RID: 5358 RVA: 0x0002BB30 File Offset: 0x00029D30
		public override char GetNextChar()
		{
		}

		// Token: 0x060014EF RID: 5359 RVA: 0x0002BB40 File Offset: 0x00029D40
		public override bool MovePrevious()
		{
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x060014F0 RID: 5360 RVA: 0x0002BB50 File Offset: 0x00029D50
		public override int Remaining
		{
			get
			{
			}
		}
	}
}
