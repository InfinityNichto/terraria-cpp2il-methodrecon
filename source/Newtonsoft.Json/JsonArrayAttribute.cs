using System;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	// Token: 0x0200001F RID: 31
	[Preserve]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = false)]
	public sealed class JsonArrayAttribute : JsonContainerAttribute
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00002784 File Offset: 0x00000984
		// (set) Token: 0x06000048 RID: 72 RVA: 0x00002798 File Offset: 0x00000998
		public bool AllowNullItems
		{
			get
			{
				return this._allowNullItems;
			}
			set
			{
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000027A8 File Offset: 0x000009A8
		public JsonArrayAttribute()
		{
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000027BC File Offset: 0x000009BC
		public JsonArrayAttribute(bool allowNullItems)
		{
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000027D0 File Offset: 0x000009D0
		public JsonArrayAttribute(string id)
		{
			this.<Id>k__BackingField = id;
		}

		// Token: 0x04000045 RID: 69
		private bool _allowNullItems;
	}
}
