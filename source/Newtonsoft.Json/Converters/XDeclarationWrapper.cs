using System;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.Linq;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x02000113 RID: 275
	internal class XDeclarationWrapper : XObjectWrapper, IXmlDeclaration, IXmlNode
	{
		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06000AC0 RID: 2752 RVA: 0x00019E7C File Offset: 0x0001807C
		// (set) Token: 0x06000AC1 RID: 2753 RVA: 0x00019E90 File Offset: 0x00018090
		internal XDeclaration Declaration
		{
			[CompilerGenerated]
			get
			{
				return this.<Declaration>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Declaration>k__BackingField = value;
			}
		}

		// Token: 0x06000AC2 RID: 2754 RVA: 0x00019EA4 File Offset: 0x000180A4
		public XDeclarationWrapper(XDeclaration declaration)
		{
			if (!true)
			{
			}
			base..ctor();
			this.Declaration = declaration;
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06000AC3 RID: 2755 RVA: 0x00019EC4 File Offset: 0x000180C4
		public override XmlNodeType NodeType
		{
			get
			{
				return XmlNodeType.XmlDeclaration;
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06000AC4 RID: 2756 RVA: 0x00019ED4 File Offset: 0x000180D4
		public string Version
		{
			get
			{
				return this.<Declaration>k__BackingField._version;
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06000AC5 RID: 2757 RVA: 0x00019EEC File Offset: 0x000180EC
		// (set) Token: 0x06000AC6 RID: 2758 RVA: 0x00019F04 File Offset: 0x00018104
		public string Encoding
		{
			get
			{
				return this.<Declaration>k__BackingField._encoding;
			}
			set
			{
				this.<Declaration>k__BackingField._encoding = value;
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06000AC7 RID: 2759 RVA: 0x00019F20 File Offset: 0x00018120
		// (set) Token: 0x06000AC8 RID: 2760 RVA: 0x00019F38 File Offset: 0x00018138
		public string Standalone
		{
			get
			{
				return this.<Declaration>k__BackingField._standalone;
			}
			set
			{
				this.<Declaration>k__BackingField._standalone = value;
			}
		}

		// Token: 0x04000414 RID: 1044
		[CompilerGenerated]
		private XDeclaration <Declaration>k__BackingField;
	}
}
