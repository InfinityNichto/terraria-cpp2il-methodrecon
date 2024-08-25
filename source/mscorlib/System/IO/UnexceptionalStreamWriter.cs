using System;
using System.Text;

namespace System.IO
{
	// Token: 0x02000570 RID: 1392
	internal class UnexceptionalStreamWriter : StreamWriter
	{
		// Token: 0x060029F3 RID: 10739 RVA: 0x0005B384 File Offset: 0x00059584
		public UnexceptionalStreamWriter(Stream stream, Encoding encoding)
		{
			if (!true)
			{
			}
			base..ctor(stream, encoding, 1024, true);
		}

		// Token: 0x060029F4 RID: 10740 RVA: 0x0005B3A4 File Offset: 0x000595A4
		public override void Flush()
		{
			base.Flush();
		}

		// Token: 0x060029F5 RID: 10741 RVA: 0x0005B3BC File Offset: 0x000595BC
		public override void Write(char[] buffer, int index, int count)
		{
			base.Write(buffer, index, count);
		}

		// Token: 0x060029F6 RID: 10742 RVA: 0x0005B3D8 File Offset: 0x000595D8
		public override void Write(char value)
		{
			base.Write(value);
		}

		// Token: 0x060029F7 RID: 10743 RVA: 0x0005B3F0 File Offset: 0x000595F0
		public override void Write(char[] value)
		{
			base.Write(value);
		}

		// Token: 0x060029F8 RID: 10744 RVA: 0x0005B408 File Offset: 0x00059608
		public override void Write(string value)
		{
			base.Write(value);
		}
	}
}
