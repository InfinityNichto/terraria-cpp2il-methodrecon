using System;
using System.Runtime.Serialization;

namespace System.Text
{
	// Token: 0x0200026E RID: 622
	[Serializable]
	public sealed class EncoderFallbackException : ArgumentException
	{
		// Token: 0x060014F1 RID: 5361 RVA: 0x0002BB60 File Offset: 0x00029D60
		public EncoderFallbackException()
			: base("Value does not fall within the expected range.")
		{
			this._HResult = 87;
		}

		// Token: 0x060014F2 RID: 5362 RVA: 0x0002BB80 File Offset: 0x00029D80
		internal EncoderFallbackException(string message, char charUnknown, int index)
			: base(message)
		{
			this._charUnknown = charUnknown;
			this._index = index;
		}

		// Token: 0x060014F3 RID: 5363 RVA: 0x0002BBA4 File Offset: 0x00029DA4
		internal EncoderFallbackException(string message, char charUnknownHigh, char charUnknownLow, int index)
			: base(message)
		{
			if (!true)
			{
			}
			bool flag = char.IsHighSurrogate(charUnknownHigh);
			if (!true)
			{
			}
			bool flag2 = char.IsLowSurrogate(charUnknownLow);
			this._charUnknownHigh = charUnknownHigh;
			this._charUnknownLow = charUnknownLow;
			this._index = index;
		}

		// Token: 0x060014F4 RID: 5364 RVA: 0x0002BBE4 File Offset: 0x00029DE4
		private EncoderFallbackException(SerializationInfo serializationInfo, StreamingContext streamingContext)
			: base(serializationInfo, streamingContext)
		{
		}

		// Token: 0x04000B05 RID: 2821
		private char _charUnknown;

		// Token: 0x04000B06 RID: 2822
		private char _charUnknownHigh;

		// Token: 0x04000B07 RID: 2823
		private char _charUnknownLow;

		// Token: 0x04000B08 RID: 2824
		private int _index;
	}
}
