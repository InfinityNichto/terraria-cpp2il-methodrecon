using System;
using Cpp2IlInjected;

namespace System.Xml.Linq
{
	// Token: 0x02000009 RID: 9
	public class XDocument : XContainer
	{
		// Token: 0x0600003F RID: 63 RVA: 0x00002AA8 File Offset: 0x00000CA8
		public XDocument()
		{
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002ABC File Offset: 0x00000CBC
		public XDocument(XDocument other)
			: base(other)
		{
			if (other._declaration != null)
			{
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000041 RID: 65 RVA: 0x00002AD8 File Offset: 0x00000CD8
		// (set) Token: 0x06000042 RID: 66 RVA: 0x00002AEC File Offset: 0x00000CEC
		public XDeclaration Declaration
		{
			get
			{
				return this._declaration;
			}
			set
			{
				this._declaration = value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000043 RID: 67 RVA: 0x00002B00 File Offset: 0x00000D00
		public override XmlNodeType NodeType
		{
			get
			{
				return XmlNodeType.Document;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00002B10 File Offset: 0x00000D10
		public XElement Root
		{
			get
			{
				return this.GetFirstNode<XElement>();
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002B24 File Offset: 0x00000D24
		public override void WriteTo(XmlWriter writer)
		{
			while (writer == null)
			{
			}
			XDeclaration declaration = this._declaration;
			if (declaration != null)
			{
				bool flag = declaration._standalone == "yes";
				return;
			}
			base.WriteContentTo(writer);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002367 File Offset: 0x00000567
		internal override void AddAttribute(XAttribute a)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002367 File Offset: 0x00000567
		internal override void AddAttributeSkipNotify(XAttribute a)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002367 File Offset: 0x00000567
		internal override XNode CloneNode()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002B74 File Offset: 0x00000D74
		private T GetFirstNode<T>() where T : XNode
		{
			object content;
			do
			{
				content = this.content;
				if (content == null)
				{
					return;
				}
				object content2 = this.content;
				while (content == null)
				{
				}
			}
			while (content != null);
			throw new InvalidCastException();
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002BA0 File Offset: 0x00000DA0
		internal static bool IsWhitespace(string s)
		{
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002BB0 File Offset: 0x00000DB0
		internal override void ValidateNode(XNode node, XNode previous)
		{
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002BC8 File Offset: 0x00000DC8
		private void ValidateDocument(XNode previous, XmlNodeType allowBefore, XmlNodeType allowAfter)
		{
			if (this.content != null)
			{
				object content = this.content;
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002BE4 File Offset: 0x00000DE4
		internal override void ValidateString(string s)
		{
			bool flag = XDocument.IsWhitespace(s);
		}

		// Token: 0x0400000E RID: 14
		private XDeclaration _declaration;
	}
}
