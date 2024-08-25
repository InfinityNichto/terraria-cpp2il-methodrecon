using System;
using System.Collections;

namespace System.Runtime.Remoting
{
	// Token: 0x02000346 RID: 838
	internal class ProviderData
	{
		// Token: 0x06001C17 RID: 7191 RVA: 0x0003D060 File Offset: 0x0003B260
		public void CopyFrom(ProviderData other)
		{
			if (this.Ref == null)
			{
				string @ref = other.Ref;
				this.Ref = @ref;
			}
			if (this.Id == null)
			{
				string id = other.Id;
				this.Id = id;
			}
			if (this.Type == null)
			{
				string type = other.Type;
				this.Type = type;
			}
			Hashtable customProperties = other.CustomProperties;
		}

		// Token: 0x06001C18 RID: 7192 RVA: 0x0003D160 File Offset: 0x0003B360
		public ProviderData()
		{
		}

		// Token: 0x04000E4E RID: 3662
		internal string Ref;

		// Token: 0x04000E4F RID: 3663
		internal string Type;

		// Token: 0x04000E50 RID: 3664
		internal string Id;

		// Token: 0x04000E51 RID: 3665
		internal Hashtable CustomProperties;

		// Token: 0x04000E52 RID: 3666
		internal IList CustomData;
	}
}
