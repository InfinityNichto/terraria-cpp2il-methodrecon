using System;
using Cpp2IlInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000053 RID: 83
	[Preserve]
	internal struct StringReference
	{
		// Token: 0x17000093 RID: 147
		public char this[int i]
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000308 RID: 776 RVA: 0x0000212A File Offset: 0x0000032A
		public char[] Chars
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000309 RID: 777 RVA: 0x00009230 File Offset: 0x00007430
		public int StartIndex
		{
			get
			{
				return this._startIndex;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x0600030A RID: 778 RVA: 0x00009244 File Offset: 0x00007444
		public int Length
		{
			get
			{
				return this._length;
			}
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00009258 File Offset: 0x00007458
		public StringReference(char[] chars, int startIndex, int length)
		{
			this._chars = chars;
			this._startIndex = startIndex;
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00009274 File Offset: 0x00007474
		public override string ToString()
		{
			int startIndex = this._startIndex;
			string text;
			return text;
		}

		// Token: 0x04000191 RID: 401
		private readonly char[] _chars;

		// Token: 0x04000192 RID: 402
		private readonly int _startIndex;

		// Token: 0x04000193 RID: 403
		private readonly int _length;
	}
}
