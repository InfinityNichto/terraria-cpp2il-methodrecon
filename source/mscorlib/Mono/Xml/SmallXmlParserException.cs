using System;

namespace Mono.Xml
{
	// Token: 0x0200002E RID: 46
	internal class SmallXmlParserException : SystemException
	{
		// Token: 0x060000A3 RID: 163 RVA: 0x00002F90 File Offset: 0x00001190
		public SmallXmlParserException(string msg, int line, int column)
		{
			string text;
			base..ctor(text);
			this.line = line;
		}

		// Token: 0x040000CE RID: 206
		private int line;

		// Token: 0x040000CF RID: 207
		private int column;
	}
}
