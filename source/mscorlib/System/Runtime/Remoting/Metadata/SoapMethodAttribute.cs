using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata
{
	// Token: 0x0200038F RID: 911
	[AttributeUsage(AttributeTargets.Method)]
	[ComVisible(true)]
	public sealed class SoapMethodAttribute : SoapAttribute
	{
		// Token: 0x06001D75 RID: 7541 RVA: 0x0004049C File Offset: 0x0003E69C
		public SoapMethodAttribute()
		{
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06001D76 RID: 7542 RVA: 0x000404B0 File Offset: 0x0003E6B0
		public override bool UseAttribute
		{
			get
			{
				return this._useAttribute;
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06001D77 RID: 7543 RVA: 0x000404C4 File Offset: 0x0003E6C4
		public override string XmlNamespace
		{
			get
			{
				return this._namespace;
			}
		}

		// Token: 0x06001D78 RID: 7544 RVA: 0x000404D8 File Offset: 0x0003E6D8
		internal override void SetReflectionObject(object reflectionObject)
		{
			if (reflectionObject != null)
			{
			}
			if (this._responseElement == null)
			{
				string text;
				this._responseElement = text;
			}
			string responseNamespace = this._responseNamespace;
			if (responseNamespace == null)
			{
				if (responseNamespace == null)
				{
				}
				string text2;
				this._responseNamespace = text2;
			}
			if (this._returnElement == null)
			{
				this._returnElement = "return";
			}
			string soapAction = this._soapAction;
			if (soapAction == null)
			{
				if (soapAction == null)
				{
				}
				string text3;
				this._soapAction = text3;
			}
			string @namespace = this._namespace;
			if (@namespace == null)
			{
				if (@namespace == null)
				{
				}
				string text4;
				this._namespace = text4;
			}
		}

		// Token: 0x04000ED3 RID: 3795
		private string _responseElement;

		// Token: 0x04000ED4 RID: 3796
		private string _responseNamespace;

		// Token: 0x04000ED5 RID: 3797
		private string _returnElement;

		// Token: 0x04000ED6 RID: 3798
		private string _soapAction;

		// Token: 0x04000ED7 RID: 3799
		private bool _useAttribute;

		// Token: 0x04000ED8 RID: 3800
		private string _namespace;
	}
}
