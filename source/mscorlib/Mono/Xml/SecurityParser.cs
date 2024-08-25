using System;
using System.Collections;
using System.Security;

namespace Mono.Xml
{
	// Token: 0x02000029 RID: 41
	internal class SecurityParser : SmallXmlParser, SmallXmlParser.IContentHandler
	{
		// Token: 0x0600006C RID: 108 RVA: 0x00002650 File Offset: 0x00000850
		public SecurityParser()
		{
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002664 File Offset: 0x00000864
		public void LoadXml(string xml)
		{
			Stack stack = this.stack;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002678 File Offset: 0x00000878
		public SecurityElement ToXml()
		{
			return this.root;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0000268C File Offset: 0x0000088C
		public void OnStartParsing(SmallXmlParser parser)
		{
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0000269C File Offset: 0x0000089C
		public void OnProcessingInstruction(string name, string text)
		{
		}

		// Token: 0x06000071 RID: 113 RVA: 0x000026AC File Offset: 0x000008AC
		public void OnIgnorableWhitespace(string s)
		{
		}

		// Token: 0x06000072 RID: 114 RVA: 0x000026BC File Offset: 0x000008BC
		public void OnStartElement(string name, SmallXmlParser.IAttrList attrs)
		{
			if (this.root != null)
			{
				if (this.stack != null)
				{
				}
				return;
			}
			Stack stack = this.stack;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x000026F4 File Offset: 0x000008F4
		public void OnEndElement(string name)
		{
			Stack stack = this.stack;
			if (stack != null)
			{
				this.current = stack;
				throw new InvalidCastException();
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002718 File Offset: 0x00000918
		public void OnChars(string ch)
		{
			SecurityElement securityElement = this.current;
			if (!true)
			{
			}
			string text = SecurityElement.Escape(ch);
			securityElement.Text = text;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00002740 File Offset: 0x00000940
		public void OnEndParsing(SmallXmlParser parser)
		{
		}

		// Token: 0x040000BD RID: 189
		private SecurityElement root;

		// Token: 0x040000BE RID: 190
		private SecurityElement current;

		// Token: 0x040000BF RID: 191
		private Stack stack;
	}
}
