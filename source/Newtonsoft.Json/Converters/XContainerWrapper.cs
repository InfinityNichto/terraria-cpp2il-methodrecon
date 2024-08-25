using System;
using System.Collections.Generic;
using System.Xml.Linq;
using Cpp2IlInjected;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x02000119 RID: 281
	internal class XContainerWrapper : XObjectWrapper
	{
		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000AEF RID: 2799 RVA: 0x0001A2B8 File Offset: 0x000184B8
		private XContainer Container
		{
			get
			{
				if (this._xmlObject != null)
				{
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x06000AF0 RID: 2800 RVA: 0x0001A2D4 File Offset: 0x000184D4
		public XContainerWrapper(XContainer container)
		{
			if (!true)
			{
			}
			base..ctor();
			this._xmlObject = container;
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000AF1 RID: 2801 RVA: 0x0000212A File Offset: 0x0000032A
		public override List<IXmlNode> ChildNodes
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06000AF2 RID: 2802 RVA: 0x0001A2F4 File Offset: 0x000184F4
		public override IXmlNode ParentNode
		{
			get
			{
				IXmlNode xmlNode;
				if (this.Container.Parent != null)
				{
					xmlNode = XContainerWrapper.WrapNode(this.Container.Parent);
					return xmlNode;
				}
				return xmlNode;
			}
		}

		// Token: 0x06000AF3 RID: 2803 RVA: 0x0001A324 File Offset: 0x00018524
		internal static IXmlNode WrapNode(XObject node)
		{
			throw new InvalidCastException();
		}

		// Token: 0x06000AF4 RID: 2804 RVA: 0x0001A338 File Offset: 0x00018538
		public override IXmlNode AppendChild(IXmlNode newChild)
		{
			XContainer container = this.Container;
			return newChild;
		}

		// Token: 0x04000416 RID: 1046
		private List<IXmlNode> _childNodes;
	}
}
