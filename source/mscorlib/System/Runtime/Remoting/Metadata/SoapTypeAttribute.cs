using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata
{
	// Token: 0x02000391 RID: 913
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface)]
	[ComVisible(true)]
	public sealed class SoapTypeAttribute : SoapAttribute
	{
		// Token: 0x06001D7A RID: 7546 RVA: 0x00040568 File Offset: 0x0003E768
		public SoapTypeAttribute()
		{
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06001D7B RID: 7547 RVA: 0x0004057C File Offset: 0x0003E77C
		public override bool UseAttribute
		{
			get
			{
				return this._useAttribute;
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06001D7C RID: 7548 RVA: 0x00040590 File Offset: 0x0003E790
		public string XmlElementName
		{
			get
			{
				return this._xmlElementName;
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06001D7D RID: 7549 RVA: 0x000405A4 File Offset: 0x0003E7A4
		public override string XmlNamespace
		{
			get
			{
				return this._xmlNamespace;
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06001D7E RID: 7550 RVA: 0x000405B8 File Offset: 0x0003E7B8
		public string XmlTypeName
		{
			get
			{
				return this._xmlTypeName;
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06001D7F RID: 7551 RVA: 0x000405CC File Offset: 0x0003E7CC
		public string XmlTypeNamespace
		{
			get
			{
				return this._xmlTypeNamespace;
			}
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06001D80 RID: 7552 RVA: 0x000405E0 File Offset: 0x0003E7E0
		internal bool IsInteropXmlElement
		{
			get
			{
				return this._isElement;
			}
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06001D81 RID: 7553 RVA: 0x000405F4 File Offset: 0x0003E7F4
		internal bool IsInteropXmlType
		{
			get
			{
				return this._isType;
			}
		}

		// Token: 0x06001D82 RID: 7554 RVA: 0x00040608 File Offset: 0x0003E808
		internal override void SetReflectionObject(object reflectionObject)
		{
			if (reflectionObject != null)
			{
			}
			if (this._xmlElementName == null)
			{
				this._xmlElementName = reflectionObject;
			}
			if (this._xmlTypeName == null)
			{
				this._xmlTypeName = reflectionObject;
			}
			if (this._xmlTypeNamespace == null)
			{
				return;
			}
			if (this._xmlNamespace == null)
			{
				string text;
				this._xmlNamespace = text;
			}
		}

		// Token: 0x04000ED9 RID: 3801
		private bool _useAttribute;

		// Token: 0x04000EDA RID: 3802
		private string _xmlElementName;

		// Token: 0x04000EDB RID: 3803
		private string _xmlNamespace;

		// Token: 0x04000EDC RID: 3804
		private string _xmlTypeName;

		// Token: 0x04000EDD RID: 3805
		private string _xmlTypeNamespace;

		// Token: 0x04000EDE RID: 3806
		private bool _isType;

		// Token: 0x04000EDF RID: 3807
		private bool _isElement;
	}
}
