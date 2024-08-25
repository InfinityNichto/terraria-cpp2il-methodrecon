using System;
using System.Runtime.InteropServices;
using System.Text;

namespace System.IO
{
	// Token: 0x0200056F RID: 1391
	internal class UnexceptionalStreamReader : StreamReader
	{
		// Token: 0x060029EB RID: 10731 RVA: 0x0005B280 File Offset: 0x00059480
		static UnexceptionalStreamReader()
		{
			int stringLength = Environment.NewLine._stringLength;
			string newLine = Environment.NewLine;
			int stringLength2 = newLine._stringLength;
			long num = 0L;
			char c = newLine[(int)num];
		}

		// Token: 0x060029EC RID: 10732 RVA: 0x0005B2B8 File Offset: 0x000594B8
		public UnexceptionalStreamReader(Stream stream, Encoding encoding)
		{
			if (!true)
			{
			}
			base..ctor(stream, encoding);
		}

		// Token: 0x060029ED RID: 10733 RVA: 0x0005B2D0 File Offset: 0x000594D0
		public override int Peek()
		{
			return base.Peek();
		}

		// Token: 0x060029EE RID: 10734 RVA: 0x0005B2E8 File Offset: 0x000594E8
		public override int Read()
		{
			return base.Read();
		}

		// Token: 0x060029EF RID: 10735 RVA: 0x0005B300 File Offset: 0x00059500
		public override int Read([In] [Out] char[] dest_buffer, int index, int count)
		{
			int num = 1;
			if (dest_buffer != null)
			{
				if (num == 0)
				{
				}
				return base.Read();
			}
			return "index";
		}

		// Token: 0x060029F0 RID: 10736 RVA: 0x0005B328 File Offset: 0x00059528
		private bool CheckEOL(char current)
		{
			if (!true)
			{
			}
			if (Environment.NewLine[(int)current] == '\0')
			{
				return;
			}
		}

		// Token: 0x060029F1 RID: 10737 RVA: 0x0005B350 File Offset: 0x00059550
		public override string ReadLine()
		{
			return base.ReadLine();
		}

		// Token: 0x060029F2 RID: 10738 RVA: 0x0005B36C File Offset: 0x0005956C
		public override string ReadToEnd()
		{
			return base.ReadToEnd();
		}

		// Token: 0x04001687 RID: 5767
		private static bool[] newline;

		// Token: 0x04001688 RID: 5768
		private static char newlineChar;
	}
}
