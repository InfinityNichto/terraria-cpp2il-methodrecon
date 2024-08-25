using System;
using System.Text;
using System.Threading;

namespace System.IO
{
	// Token: 0x02000572 RID: 1394
	internal class CStreamWriter : StreamWriter
	{
		// Token: 0x060029FF RID: 10751 RVA: 0x0005B4E0 File Offset: 0x000596E0
		public CStreamWriter(Stream stream, Encoding encoding, bool leaveOpen)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06002A00 RID: 10752 RVA: 0x0005B4FC File Offset: 0x000596FC
		public override void Write(char[] buffer, int index, int count)
		{
			if (this.driver.inited)
			{
				long num = 0L;
				bool flag = this.driver.IsSpecialKey(buffer);
				base.Write(buffer, index, (int)num);
				this.driver.WriteSpecialKey(buffer);
				return;
			}
		}

		// Token: 0x06002A01 RID: 10753 RVA: 0x0005B590 File Offset: 0x00059790
		public override void Write(char val)
		{
			Monitor.Enter(this, val != '\0');
			bool flag = this.driver.IsSpecialKey(val);
			this.driver.WriteSpecialKey(val);
		}

		// Token: 0x06002A02 RID: 10754 RVA: 0x0005B604 File Offset: 0x00059804
		public void InternalWriteString(string val)
		{
			base.Write(val);
		}

		// Token: 0x06002A03 RID: 10755 RVA: 0x0005B61C File Offset: 0x0005981C
		public void InternalWriteChar(char val)
		{
			base.Write(val);
		}

		// Token: 0x06002A04 RID: 10756 RVA: 0x0005B634 File Offset: 0x00059834
		public void InternalWriteChars(char[] buffer, int n)
		{
			long num = 0L;
			base.Write(buffer, (int)num, n);
		}

		// Token: 0x06002A05 RID: 10757 RVA: 0x0005B650 File Offset: 0x00059850
		public override void Write(char[] val)
		{
		}

		// Token: 0x06002A06 RID: 10758 RVA: 0x0005B660 File Offset: 0x00059860
		public override void Write(string val)
		{
			if (val != null && this.driver.inited)
			{
				char[] array = val.ToCharArray();
				return;
			}
		}

		// Token: 0x06002A07 RID: 10759 RVA: 0x0005B688 File Offset: 0x00059888
		public override void WriteLine(string val)
		{
		}

		// Token: 0x0400168A RID: 5770
		private TermInfoDriver driver;
	}
}
