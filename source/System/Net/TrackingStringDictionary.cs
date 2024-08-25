using System;
using System.Collections.Specialized;

namespace System.Net
{
	// Token: 0x0200013A RID: 314
	internal sealed class TrackingStringDictionary : global::System.Collections.Specialized.StringDictionary
	{
		// Token: 0x06000776 RID: 1910 RVA: 0x0001AABC File Offset: 0x00018CBC
		internal TrackingStringDictionary()
		{
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x0001AAD0 File Offset: 0x00018CD0
		internal TrackingStringDictionary(bool isReadOnly)
		{
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06000778 RID: 1912 RVA: 0x0001AAE4 File Offset: 0x00018CE4
		// (set) Token: 0x06000779 RID: 1913 RVA: 0x0001AAF8 File Offset: 0x00018CF8
		internal bool IsChanged
		{
			get
			{
				return this._isChanged;
			}
			set
			{
			}
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x0001AB08 File Offset: 0x00018D08
		public override void Add(string key, string value)
		{
			while (this._isReadOnly)
			{
			}
			base.Add(key, value);
			this._isChanged = true;
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x0001AB2C File Offset: 0x00018D2C
		public override void Clear()
		{
			while (this._isReadOnly)
			{
			}
			base.Clear();
			this._isChanged = true;
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x0001AB50 File Offset: 0x00018D50
		public override void Remove(string key)
		{
			while (this._isReadOnly)
			{
			}
			base.Remove(key);
			this._isChanged = true;
		}

		// Token: 0x1700018F RID: 399
		public override string this[string key]
		{
			get
			{
				return base[key];
			}
			set
			{
				while (this._isReadOnly)
				{
				}
				base[key] = value;
				this._isChanged = true;
			}
		}

		// Token: 0x040005ED RID: 1517
		private readonly bool _isReadOnly;

		// Token: 0x040005EE RID: 1518
		private bool _isChanged;
	}
}
