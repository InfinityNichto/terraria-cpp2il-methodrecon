using System;

namespace System.Xml
{
	// Token: 0x02000006 RID: 6
	internal class XmlRawWriterBase64Encoder : Base64Encoder
	{
		// Token: 0x06000008 RID: 8 RVA: 0x000021AC File Offset: 0x000003AC
		internal XmlRawWriterBase64Encoder(XmlRawWriter rawWriter)
		{
			this.rawWriter = rawWriter;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000021C8 File Offset: 0x000003C8
		internal override void WriteChars(char[] chars, int index, int count)
		{
			XmlRawWriter xmlRawWriter = this.rawWriter;
		}

		// Token: 0x04000009 RID: 9
		private XmlRawWriter rawWriter;
	}
}
