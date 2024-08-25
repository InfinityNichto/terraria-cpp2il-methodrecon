using System;
using System.Runtime.Serialization;

namespace System.Text
{
	// Token: 0x02000263 RID: 611
	[Serializable]
	public sealed class DecoderFallbackException : ArgumentException
	{
		// Token: 0x0600149F RID: 5279 RVA: 0x0002B39C File Offset: 0x0002959C
		public DecoderFallbackException()
			: base("Value does not fall within the expected range.")
		{
			this._HResult = 87;
		}

		// Token: 0x060014A0 RID: 5280 RVA: 0x0002B3BC File Offset: 0x000295BC
		public DecoderFallbackException(string message, byte[] bytesUnknown, int index)
			: base(message)
		{
			this._bytesUnknown = bytesUnknown;
			this._index = index;
		}

		// Token: 0x060014A1 RID: 5281 RVA: 0x0002B3E0 File Offset: 0x000295E0
		private DecoderFallbackException(SerializationInfo serializationInfo, StreamingContext streamingContext)
			: base(serializationInfo, streamingContext)
		{
		}

		// Token: 0x04000AEE RID: 2798
		private byte[] _bytesUnknown;

		// Token: 0x04000AEF RID: 2799
		private int _index;
	}
}
