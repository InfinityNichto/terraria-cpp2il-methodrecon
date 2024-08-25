using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata
{
	// Token: 0x0200038D RID: 909
	[ComVisible(true)]
	public class SoapAttribute : Attribute
	{
		// Token: 0x06001D6D RID: 7533 RVA: 0x000403E8 File Offset: 0x0003E5E8
		public SoapAttribute()
		{
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06001D6E RID: 7534 RVA: 0x000403FC File Offset: 0x0003E5FC
		public virtual bool UseAttribute
		{
			get
			{
				return this._useAttribute;
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06001D6F RID: 7535 RVA: 0x00040410 File Offset: 0x0003E610
		public virtual string XmlNamespace
		{
			get
			{
				return this.ProtXmlNamespace;
			}
		}

		// Token: 0x06001D70 RID: 7536 RVA: 0x00040424 File Offset: 0x0003E624
		internal virtual void SetReflectionObject(object reflectionObject)
		{
			this.ReflectInfo = reflectionObject;
		}

		// Token: 0x04000ECE RID: 3790
		private bool _useAttribute;

		// Token: 0x04000ECF RID: 3791
		protected string ProtXmlNamespace;

		// Token: 0x04000ED0 RID: 3792
		protected object ReflectInfo;
	}
}
