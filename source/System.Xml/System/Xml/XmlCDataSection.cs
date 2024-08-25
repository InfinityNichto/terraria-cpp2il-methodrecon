using System;
using Cpp2IlInjected;

namespace System.Xml
{
	// Token: 0x02000064 RID: 100
	public class XmlCDataSection : XmlCharacterData
	{
		// Token: 0x06000495 RID: 1173 RVA: 0x00011780 File Offset: 0x0000F980
		protected internal XmlCDataSection(string data, XmlDocument doc)
			: base(doc)
		{
			this.data = data;
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000496 RID: 1174 RVA: 0x00003FFD File Offset: 0x000021FD
		public override string Name
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000497 RID: 1175 RVA: 0x00003FFD File Offset: 0x000021FD
		public override string LocalName
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000498 RID: 1176 RVA: 0x0001179C File Offset: 0x0000F99C
		public override XmlNodeType NodeType
		{
			get
			{
				return XmlNodeType.CDATA;
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000499 RID: 1177 RVA: 0x000117AC File Offset: 0x0000F9AC
		public override XmlNode ParentNode
		{
			get
			{
				return this.parentNode;
			}
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x00003FFD File Offset: 0x000021FD
		public override XmlNode CloneNode(bool deep)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x0600049B RID: 1179 RVA: 0x000117C8 File Offset: 0x0000F9C8
		internal override bool IsText
		{
			get
			{
				return true;
			}
		}
	}
}
