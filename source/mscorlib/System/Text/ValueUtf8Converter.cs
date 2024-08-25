using System;

namespace System.Text
{
	// Token: 0x02000288 RID: 648
	internal ref struct ValueUtf8Converter
	{
		// Token: 0x0600162C RID: 5676 RVA: 0x0002EB18 File Offset: 0x0002CD18
		public ValueUtf8Converter(Span<byte> initialBuffer)
		{
			this._bytes = initialBuffer;
		}

		// Token: 0x0600162D RID: 5677 RVA: 0x0002EB2C File Offset: 0x0002CD2C
		public Span<byte> ConvertAndTerminateString(ReadOnlySpan<char> value)
		{
			Encoding utf = Encoding.UTF8;
			int length = this._bytes._length;
			this.Dispose();
			if (length == 0)
			{
			}
			if (length == 0)
			{
			}
			long num = 0L;
			long num2 = 0L;
			this._bytes = num;
			this._bytes._length = (int)num2;
			Encoding utf2 = Encoding.UTF8;
			Span<byte> bytes = this._bytes;
			int length2 = this._bytes._length;
			Span<byte> bytes2 = this._bytes;
			int length3 = this._bytes._length;
			ThrowHelper.ThrowArgumentOutOfRangeException();
			return this._bytes;
		}

		// Token: 0x0600162E RID: 5678 RVA: 0x0002EBB0 File Offset: 0x0002CDB0
		public void Dispose()
		{
		}

		// Token: 0x04000B5B RID: 2907
		private byte[] _arrayToReturnToPool;

		// Token: 0x04000B5C RID: 2908
		private Span<byte> _bytes;
	}
}
