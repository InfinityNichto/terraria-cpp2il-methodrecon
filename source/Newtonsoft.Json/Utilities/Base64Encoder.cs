using System;
using System.IO;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000040 RID: 64
	[Preserve]
	internal class Base64Encoder
	{
		// Token: 0x060002B8 RID: 696 RVA: 0x000089EC File Offset: 0x00006BEC
		public Base64Encoder(TextWriter writer)
		{
			ValidationUtils.ArgumentNotNull(writer, "writer");
			this._writer = writer;
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00008A14 File Offset: 0x00006C14
		public void Encode(byte[] buffer, int index, int count)
		{
			if (buffer != null)
			{
				int leftOverBytesCount = this._leftOverBytesCount;
				return;
			}
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00008AF0 File Offset: 0x00006CF0
		public void Flush()
		{
			int leftOverBytesCount = this._leftOverBytesCount;
			byte[] leftOverBytes = this._leftOverBytes;
			char[] charsLine = this._charsLine;
			long num = 0L;
			long num2 = 0L;
			int num3 = Convert.ToBase64CharArray(leftOverBytes, (int)num, leftOverBytesCount, charsLine, (int)num2);
			char[] charsLine2 = this._charsLine;
			TextWriter writer = this._writer;
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00008B34 File Offset: 0x00006D34
		private void WriteChars(char[] chars, int index, int count)
		{
			TextWriter writer = this._writer;
		}

		// Token: 0x04000171 RID: 369
		private const int Base64LineSize = 76;

		// Token: 0x04000172 RID: 370
		private const int LineSizeInBytes = 57;

		// Token: 0x04000173 RID: 371
		private readonly char[] _charsLine;

		// Token: 0x04000174 RID: 372
		private readonly TextWriter _writer;

		// Token: 0x04000175 RID: 373
		private byte[] _leftOverBytes;

		// Token: 0x04000176 RID: 374
		private int _leftOverBytesCount;
	}
}
