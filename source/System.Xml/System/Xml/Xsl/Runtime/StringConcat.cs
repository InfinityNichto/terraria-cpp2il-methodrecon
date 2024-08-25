using System;
using System.Collections.Generic;
using System.ComponentModel;
using Cpp2IlInjected;

namespace System.Xml.Xsl.Runtime
{
	// Token: 0x020000C1 RID: 193
	[EditorBrowsable(EditorBrowsableState.Never)]
	public struct StringConcat
	{
		// Token: 0x060007FD RID: 2045 RVA: 0x00019B9C File Offset: 0x00017D9C
		public void Clear()
		{
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x060007FE RID: 2046 RVA: 0x00019BAC File Offset: 0x00017DAC
		internal int Count
		{
			get
			{
				return this.idxStr;
			}
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x00019BC0 File Offset: 0x00017DC0
		public string GetResult()
		{
			int num = this.idxStr;
			List<string> list = this.strList;
			string text;
			return text;
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x00003FFD File Offset: 0x000021FD
		internal void ConcatNoDelimiter(string s)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0400040F RID: 1039
		private string s1;

		// Token: 0x04000410 RID: 1040
		private string s2;

		// Token: 0x04000411 RID: 1041
		private string s3;

		// Token: 0x04000412 RID: 1042
		private string s4;

		// Token: 0x04000413 RID: 1043
		private string delimiter;

		// Token: 0x04000414 RID: 1044
		private List<string> strList;

		// Token: 0x04000415 RID: 1045
		private int idxStr;
	}
}
