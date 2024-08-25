using System;
using System.Configuration.Internal;
using System.Xml;

namespace System.Configuration
{
	// Token: 0x02000495 RID: 1173
	public sealed class ConfigXmlDocument : XmlDocument, IConfigErrorInfo
	{
		// Token: 0x06001FD4 RID: 8148 RVA: 0x000526C4 File Offset: 0x000508C4
		public ConfigXmlDocument()
		{
			throw new NotSupportedException();
		}

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x06001FD5 RID: 8149 RVA: 0x000526D8 File Offset: 0x000508D8
		public string Filename
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x06001FD6 RID: 8150 RVA: 0x000526EC File Offset: 0x000508EC
		public int LineNumber
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x06001FD7 RID: 8151 RVA: 0x00052700 File Offset: 0x00050900
		string IConfigErrorInfo.get_Filename()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001FD8 RID: 8152 RVA: 0x00052714 File Offset: 0x00050914
		int IConfigErrorInfo.get_LineNumber()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001FD9 RID: 8153 RVA: 0x00052728 File Offset: 0x00050928
		public void LoadSingleElement(string filename, XmlTextReader sourceReader)
		{
			throw new NotSupportedException();
		}
	}
}
