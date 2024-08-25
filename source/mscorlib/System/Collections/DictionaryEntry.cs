using System;
using Cpp2IlInjected;

namespace System.Collections
{
	// Token: 0x020005E1 RID: 1505
	[Serializable]
	public struct DictionaryEntry
	{
		// Token: 0x06002D9B RID: 11675 RVA: 0x00064DD4 File Offset: 0x00062FD4
		public DictionaryEntry(object key, object value)
		{
			this._key = key;
			this._value = value;
		}

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x06002D9C RID: 11676 RVA: 0x0000207A File Offset: 0x0000027A
		public object Key
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x06002D9D RID: 11677 RVA: 0x00064DF0 File Offset: 0x00062FF0
		public object Value
		{
			get
			{
				return this._value;
			}
		}

		// Token: 0x0400199F RID: 6559
		private object _key;

		// Token: 0x040019A0 RID: 6560
		private object _value;
	}
}
