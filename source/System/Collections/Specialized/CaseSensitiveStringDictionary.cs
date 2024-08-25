using System;

namespace System.Collections.Specialized
{
	// Token: 0x02000423 RID: 1059
	internal class CaseSensitiveStringDictionary : StringDictionary
	{
		// Token: 0x06001CAB RID: 7339 RVA: 0x0004E084 File Offset: 0x0004C284
		public CaseSensitiveStringDictionary()
		{
		}

		// Token: 0x1700066D RID: 1645
		public override string this[string key]
		{
			get
			{
				if (key == null || this.contents != null)
				{
				}
				throw new InvalidCastException();
			}
			set
			{
				while (key == null)
				{
				}
				Hashtable contents = this.contents;
			}
		}

		// Token: 0x06001CAE RID: 7342 RVA: 0x0004E0D0 File Offset: 0x0004C2D0
		public override void Add(string key, string value)
		{
			while (key == null)
			{
			}
			Hashtable contents = this.contents;
		}

		// Token: 0x06001CAF RID: 7343 RVA: 0x0004E0E8 File Offset: 0x0004C2E8
		public override void Remove(string key)
		{
			while (key == null)
			{
			}
			Hashtable contents = this.contents;
		}
	}
}
