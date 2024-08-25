using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata
{
	// Token: 0x0200038E RID: 910
	[AttributeUsage(AttributeTargets.Field)]
	[ComVisible(true)]
	public sealed class SoapFieldAttribute : SoapAttribute
	{
		// Token: 0x06001D71 RID: 7537 RVA: 0x00040438 File Offset: 0x0003E638
		public SoapFieldAttribute()
		{
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06001D72 RID: 7538 RVA: 0x0004044C File Offset: 0x0003E64C
		public string XmlElementName
		{
			get
			{
				return this._elementName;
			}
		}

		// Token: 0x06001D73 RID: 7539 RVA: 0x00040460 File Offset: 0x0003E660
		public bool IsInteropXmlElement()
		{
			return this._isElement;
		}

		// Token: 0x06001D74 RID: 7540 RVA: 0x00040474 File Offset: 0x0003E674
		internal override void SetReflectionObject(object reflectionObject)
		{
			if (reflectionObject != null)
			{
			}
			if (this._elementName == null)
			{
				this._elementName = reflectionObject;
			}
		}

		// Token: 0x04000ED1 RID: 3793
		private string _elementName;

		// Token: 0x04000ED2 RID: 3794
		private bool _isElement;
	}
}
