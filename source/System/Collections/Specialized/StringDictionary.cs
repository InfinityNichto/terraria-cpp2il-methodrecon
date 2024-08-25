using System;
using Cpp2IlInjected;

namespace System.Collections.Specialized
{
	// Token: 0x02000422 RID: 1058
	[Serializable]
	public class StringDictionary : IEnumerable
	{
		// Token: 0x06001CA4 RID: 7332 RVA: 0x0004DFD4 File Offset: 0x0004C1D4
		public StringDictionary()
		{
		}

		// Token: 0x1700066C RID: 1644
		public virtual string this[string key]
		{
			get
			{
				if (key != null)
				{
					Hashtable hashtable = this.contents;
					string text = key.ToLowerInvariant();
					if (hashtable != null)
					{
					}
				}
				throw new InvalidCastException();
			}
			set
			{
				while (key == null)
				{
				}
				Hashtable hashtable = this.contents;
				string text = key.ToLowerInvariant();
			}
		}

		// Token: 0x06001CA7 RID: 7335 RVA: 0x0004E030 File Offset: 0x0004C230
		public virtual void Add(string key, string value)
		{
			while (key == null)
			{
			}
			Hashtable hashtable = this.contents;
			string text = key.ToLowerInvariant();
		}

		// Token: 0x06001CA8 RID: 7336 RVA: 0x0004E050 File Offset: 0x0004C250
		public virtual void Clear()
		{
			Hashtable hashtable = this.contents;
		}

		// Token: 0x06001CA9 RID: 7337 RVA: 0x00002050 File Offset: 0x00000250
		public virtual IEnumerator GetEnumerator()
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001CAA RID: 7338 RVA: 0x0004E064 File Offset: 0x0004C264
		public virtual void Remove(string key)
		{
			while (key == null)
			{
			}
			Hashtable hashtable = this.contents;
			string text = key.ToLowerInvariant();
		}

		// Token: 0x040013B7 RID: 5047
		internal Hashtable contents;
	}
}
