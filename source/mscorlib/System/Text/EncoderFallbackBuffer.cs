using System;
using Cpp2IlInjected;

namespace System.Text
{
	// Token: 0x02000270 RID: 624
	public abstract class EncoderFallbackBuffer
	{
		// Token: 0x060014FA RID: 5370
		public abstract bool Fallback(char charUnknown, int index);

		// Token: 0x060014FB RID: 5371
		public abstract bool Fallback(char charUnknownHigh, char charUnknownLow, int index);

		// Token: 0x060014FC RID: 5372
		public abstract char GetNextChar();

		// Token: 0x060014FD RID: 5373
		public abstract bool MovePrevious();

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x060014FE RID: 5374
		public abstract int Remaining { get; }

		// Token: 0x060014FF RID: 5375 RVA: 0x0002BC10 File Offset: 0x00029E10
		public virtual void Reset()
		{
		}

		// Token: 0x06001500 RID: 5376 RVA: 0x0002BC20 File Offset: 0x00029E20
		internal void InternalReset()
		{
		}

		// Token: 0x06001501 RID: 5377 RVA: 0x0002BC30 File Offset: 0x00029E30
		internal unsafe void InternalInitialize(char* charStart, char* charEnd, EncoderNLS encoder, bool setEncoder)
		{
			this.charStart = charStart;
			this.charEnd = charEnd;
			this.encoder = encoder;
		}

		// Token: 0x06001502 RID: 5378 RVA: 0x0000207A File Offset: 0x0000027A
		internal char InternalGetNextChar()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001503 RID: 5379 RVA: 0x0002BC54 File Offset: 0x00029E54
		internal unsafe virtual bool InternalFallback(char ch, char* chars)
		{
			char* ptr = this.charStart;
			bool flag = char.IsHighSurrogate(ch);
			char* ptr2 = this.charEnd;
			if (ptr2 == null)
			{
			}
			if (this.bFallingBack)
			{
				int num = this.iRecursionCount;
				this.iRecursionCount = ptr2;
			}
			EncoderNLS encoderNLS = this.encoder;
			bool mustFlush;
			if (encoderNLS != null)
			{
				mustFlush = encoderNLS._mustFlush;
				if (!mustFlush)
				{
					goto IL_0060;
				}
			}
			if (this.bFallingBack)
			{
				int num2 = this.iRecursionCount;
				this.iRecursionCount = (mustFlush ? 1 : 0);
			}
			IL_0060:
			if (this.setEncoder)
			{
				int num3 = 1;
				this.bUsedEncoder = num3 != 0;
				return;
			}
		}

		// Token: 0x06001504 RID: 5380 RVA: 0x0000207A File Offset: 0x0000027A
		internal void ThrowLastCharRecursive(int charRecursive)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001505 RID: 5381 RVA: 0x0002BCD8 File Offset: 0x00029ED8
		protected EncoderFallbackBuffer()
		{
		}

		// Token: 0x04000B0B RID: 2827
		internal unsafe char* charStart;

		// Token: 0x04000B0C RID: 2828
		internal unsafe char* charEnd;

		// Token: 0x04000B0D RID: 2829
		internal EncoderNLS encoder;

		// Token: 0x04000B0E RID: 2830
		internal bool setEncoder;

		// Token: 0x04000B0F RID: 2831
		internal bool bUsedEncoder;

		// Token: 0x04000B10 RID: 2832
		internal bool bFallingBack;

		// Token: 0x04000B11 RID: 2833
		internal int iRecursionCount;
	}
}
