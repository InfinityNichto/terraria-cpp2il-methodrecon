using System;

namespace System.Xml
{
	// Token: 0x02000086 RID: 134
	public class NameTable : XmlNameTable
	{
		// Token: 0x0600063B RID: 1595 RVA: 0x00014A1C File Offset: 0x00012C1C
		public NameTable()
		{
			this.mask = 31;
			int tickCount = Environment.TickCount;
			this.hashCodeRandomizer = tickCount;
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x00014A48 File Offset: 0x00012C48
		public override string Add(string key)
		{
			while (key == null || key._stringLength == 0)
			{
			}
			int num = this.hashCodeRandomizer;
			long num2 = 0L;
			char c = key[(int)num2];
			int stringLength = key._stringLength;
			int num3 = this.mask;
			NameTable.Entry[] array = this.entries;
			return this.AddEntry(key, (int)num2);
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x00014A90 File Offset: 0x00012C90
		public override string Add(char[] key, int start, int len)
		{
			while (len == 0)
			{
			}
			int num = this.hashCodeRandomizer;
			int num2 = this.mask;
			NameTable.Entry[] array = this.entries;
			string text;
			return this.AddEntry(text, 43159552);
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x00014AC8 File Offset: 0x00012CC8
		public override string Get(string value)
		{
			while (value == null || value._stringLength == 0)
			{
			}
			int num = this.hashCodeRandomizer;
			long num2 = 0L;
			char c = value[(int)num2];
			int stringLength = value._stringLength;
			int num3 = this.mask;
			NameTable.Entry[] array = this.entries;
			if (num2 != 0L)
			{
				while (num2 != 0L)
				{
				}
				return;
			}
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x00014B10 File Offset: 0x00012D10
		private string AddEntry(string str, int hashCode)
		{
			int num = this.mask;
			NameTable.Entry[] array = this.entries;
			NameTable.Entry[] array2 = this.entries;
			int num2 = this.count;
			int num3 = this.hashCodeRandomizer;
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x00014B48 File Offset: 0x00012D48
		private void Grow()
		{
			int num = this.mask;
			NameTable.Entry[] array = this.entries;
			int num2 = 1;
			int hashCode = array.hashCode;
			int hashCode2 = array.hashCode;
			this.mask = num2;
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x00014B84 File Offset: 0x00012D84
		private static bool TextEquals(string str1, char[] str2, int str2Start, int str2Length)
		{
		}

		// Token: 0x04000301 RID: 769
		private NameTable.Entry[] entries;

		// Token: 0x04000302 RID: 770
		private int count;

		// Token: 0x04000303 RID: 771
		private int mask;

		// Token: 0x04000304 RID: 772
		private int hashCodeRandomizer;

		// Token: 0x02000087 RID: 135
		private class Entry
		{
			// Token: 0x06000642 RID: 1602 RVA: 0x00014B98 File Offset: 0x00012D98
			internal Entry(string str, int hashCode, NameTable.Entry next)
			{
				this.str = str;
				this.hashCode = hashCode;
				this.next = next;
			}

			// Token: 0x04000305 RID: 773
			internal string str;

			// Token: 0x04000306 RID: 774
			internal int hashCode;

			// Token: 0x04000307 RID: 775
			internal NameTable.Entry next;
		}
	}
}
