using System;
using System.Globalization;

namespace Mono.Globalization.Unicode
{
	// Token: 0x0200003F RID: 63
	internal class SortKeyBuffer
	{
		// Token: 0x060000FC RID: 252 RVA: 0x00004494 File Offset: 0x00002694
		public SortKeyBuffer(int lcid)
		{
		}

		// Token: 0x060000FD RID: 253 RVA: 0x000044A8 File Offset: 0x000026A8
		public void Reset()
		{
		}

		// Token: 0x060000FE RID: 254 RVA: 0x000044B8 File Offset: 0x000026B8
		internal void Initialize(CompareOptions options, int lcid, string s, bool frenchSort)
		{
			this.source = s;
			this.lcid = lcid;
			this.processLevel2 = options != CompareOptions.None;
			byte[] array = this.l1b;
			int stringLength = s._stringLength;
			int num = 1;
			this.processLevel2 = num != 0;
			if (array != null)
			{
			}
			if (!this.processLevel2 || this.l2b != null)
			{
			}
			if (this.l3b != null)
			{
			}
			if (this.l4sb == null)
			{
			}
			if (this.l4tb == null)
			{
			}
			if (this.l4kb == null)
			{
			}
			if (this.l4wb == null)
			{
			}
			if (this.l5b == null)
			{
			}
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00004548 File Offset: 0x00002748
		internal void AppendCJKExtension(byte lv1msb, byte lv1lsb)
		{
			if (this.processLevel2)
			{
			}
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00004560 File Offset: 0x00002760
		internal void AppendKana(byte category, byte lv1, byte lv2, byte lv3, bool isSmallKana, byte markType, bool isKatakana, bool isHalfWidth)
		{
			this.AppendNormal(category, lv1, lv2, lv3);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00004578 File Offset: 0x00002778
		internal void AppendNormal(byte category, byte lv1, byte lv2, byte lv3)
		{
			int num = 6;
			this.AppendLevel5((byte)num, lv1);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x000045D4 File Offset: 0x000027D4
		private void AppendLevel5(byte category, byte lv1)
		{
			int num = this.l2;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x000045E8 File Offset: 0x000027E8
		private void AppendBufferPrimitive(byte value, byte[] buf, int bidx)
		{
		}

		// Token: 0x06000104 RID: 260 RVA: 0x000045F8 File Offset: 0x000027F8
		public SortKey GetResultAndReset()
		{
			return this.GetResult();
		}

		// Token: 0x06000105 RID: 261 RVA: 0x0000460C File Offset: 0x0000280C
		private int GetOptimizedLength(byte[] data, int len, byte defaultValue)
		{
		}

		// Token: 0x06000106 RID: 262 RVA: 0x0000461C File Offset: 0x0000281C
		public SortKey GetResult()
		{
			if (this.source._stringLength == 0 || (this.frenchSort && !this.frenchSorted && this.l2b != null))
			{
				int num = this.lcid;
				CompareOptions compareOptions = this.options;
				return;
			}
		}

		// Token: 0x04000125 RID: 293
		private byte[] l1b;

		// Token: 0x04000126 RID: 294
		private byte[] l2b;

		// Token: 0x04000127 RID: 295
		private byte[] l3b;

		// Token: 0x04000128 RID: 296
		private byte[] l4sb;

		// Token: 0x04000129 RID: 297
		private byte[] l4tb;

		// Token: 0x0400012A RID: 298
		private byte[] l4kb;

		// Token: 0x0400012B RID: 299
		private byte[] l4wb;

		// Token: 0x0400012C RID: 300
		private byte[] l5b;

		// Token: 0x0400012D RID: 301
		private string source;

		// Token: 0x0400012E RID: 302
		private int l1;

		// Token: 0x0400012F RID: 303
		private int l2;

		// Token: 0x04000130 RID: 304
		private int l3;

		// Token: 0x04000131 RID: 305
		private int l4s;

		// Token: 0x04000132 RID: 306
		private int l4t;

		// Token: 0x04000133 RID: 307
		private int l4k;

		// Token: 0x04000134 RID: 308
		private int l4w;

		// Token: 0x04000135 RID: 309
		private int l5;

		// Token: 0x04000136 RID: 310
		private int lcid;

		// Token: 0x04000137 RID: 311
		private CompareOptions options;

		// Token: 0x04000138 RID: 312
		private bool processLevel2;

		// Token: 0x04000139 RID: 313
		private bool frenchSort;

		// Token: 0x0400013A RID: 314
		private bool frenchSorted;
	}
}
