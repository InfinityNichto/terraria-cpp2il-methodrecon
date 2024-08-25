using System;

namespace System.Text
{
	// Token: 0x02000275 RID: 629
	public abstract class EncodingProvider
	{
		// Token: 0x06001530 RID: 5424
		public abstract Encoding GetEncoding(string name);

		// Token: 0x06001531 RID: 5425
		public abstract Encoding GetEncoding(int codepage);

		// Token: 0x06001532 RID: 5426 RVA: 0x0002C250 File Offset: 0x0002A450
		public virtual Encoding GetEncoding(string name, EncoderFallback encoderFallback, DecoderFallback decoderFallback)
		{
			if (this == null || this != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06001533 RID: 5427 RVA: 0x0002C26C File Offset: 0x0002A46C
		public virtual Encoding GetEncoding(int codepage, EncoderFallback encoderFallback, DecoderFallback decoderFallback)
		{
			if (this == null || this != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06001534 RID: 5428 RVA: 0x0002C288 File Offset: 0x0002A488
		internal static Encoding GetEncodingFromProvider(int codepage)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x06001535 RID: 5429 RVA: 0x0002C2A0 File Offset: 0x0002A4A0
		internal static Encoding GetEncodingFromProvider(string encodingName)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x06001536 RID: 5430 RVA: 0x0002C2B8 File Offset: 0x0002A4B8
		internal static Encoding GetEncodingFromProvider(int codepage, EncoderFallback enc, DecoderFallback dec)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x06001537 RID: 5431 RVA: 0x0002C2D0 File Offset: 0x0002A4D0
		internal static Encoding GetEncodingFromProvider(string encodingName, EncoderFallback enc, DecoderFallback dec)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x06001538 RID: 5432 RVA: 0x0002C2E8 File Offset: 0x0002A4E8
		// Note: this type is marked as 'beforefieldinit'.
		static EncodingProvider()
		{
		}

		// Token: 0x04000B1B RID: 2843
		private static object s_InternalSyncObject;

		// Token: 0x04000B1C RID: 2844
		private static EncodingProvider[] s_providers;
	}
}
