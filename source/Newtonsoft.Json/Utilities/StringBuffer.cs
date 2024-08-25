using System;
using Cpp2IlInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200006B RID: 107
	[Preserve]
	internal struct StringBuffer
	{
		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060003BE RID: 958 RVA: 0x0000A9F4 File Offset: 0x00008BF4
		// (set) Token: 0x060003BF RID: 959 RVA: 0x0000AA08 File Offset: 0x00008C08
		public int Position
		{
			get
			{
				return this._position;
			}
			set
			{
				this._position = value;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060003C0 RID: 960 RVA: 0x0000212A File Offset: 0x0000032A
		public bool IsEmpty
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x0000AA1C File Offset: 0x00008C1C
		public StringBuffer(IArrayPool<char> bufferPool, int initalSize)
		{
			char[] array = BufferUtils.RentBuffer(bufferPool, initalSize);
			this._buffer = array;
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x0000AA38 File Offset: 0x00008C38
		private StringBuffer(char[] buffer)
		{
			this._buffer = buffer;
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x0000AA4C File Offset: 0x00008C4C
		public void Append(IArrayPool<char> bufferPool, char value)
		{
			int position = this._position;
			int num = 1;
			this.EnsureSize(bufferPool, num);
			int position2 = this._position;
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x0000AA74 File Offset: 0x00008C74
		public void Append(IArrayPool<char> bufferPool, char[] buffer, int startIndex, int count)
		{
			int position = this._position;
			this.EnsureSize(bufferPool, count);
			int position2 = this._position;
			int position3 = this._position;
			this._position = position3;
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x0000AAA8 File Offset: 0x00008CA8
		public void Clear(IArrayPool<char> bufferPool)
		{
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x0000AAB8 File Offset: 0x00008CB8
		private void EnsureSize(IArrayPool<char> bufferPool, int appendLength)
		{
			int position = this._position;
			int position2 = this._position;
			char[] array;
			this._buffer = array;
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x0000AADC File Offset: 0x00008CDC
		public override string ToString()
		{
			int position = this._position;
			string text;
			return text;
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x0000AAF4 File Offset: 0x00008CF4
		public string ToString(int start, int length)
		{
			string text;
			return text;
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060003C9 RID: 969 RVA: 0x0000212A File Offset: 0x0000032A
		public char[] InternalBuffer
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x040001F8 RID: 504
		private char[] _buffer;

		// Token: 0x040001F9 RID: 505
		private int _position;
	}
}
