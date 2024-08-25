using System;
using Cpp2IlInjected;

namespace System.Xml
{
	// Token: 0x02000068 RID: 104
	public class XmlComment : XmlCharacterData
	{
		// Token: 0x060004AD RID: 1197 RVA: 0x00011988 File Offset: 0x0000FB88
		protected internal XmlComment(string comment, XmlDocument doc)
			: base(doc)
		{
			this.data = comment;
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060004AE RID: 1198 RVA: 0x00003FFD File Offset: 0x000021FD
		public override string Name
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060004AF RID: 1199 RVA: 0x00003FFD File Offset: 0x000021FD
		public override string LocalName
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060004B0 RID: 1200 RVA: 0x000119A4 File Offset: 0x0000FBA4
		public override XmlNodeType NodeType
		{
			get
			{
				return XmlNodeType.Comment;
			}
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x00003FFD File Offset: 0x000021FD
		public override XmlNode CloneNode(bool deep)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
