using System;

namespace Mono.Globalization.Unicode
{
	// Token: 0x02000030 RID: 48
	internal class CodePointIndexer
	{
		// Token: 0x060000A5 RID: 165 RVA: 0x00002FC0 File Offset: 0x000011C0
		public CodePointIndexer(int[] starts, int[] ends, int defaultIndex, int defaultCP)
		{
			this.defaultIndex = defaultIndex;
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00002FF8 File Offset: 0x000011F8
		public int ToIndex(int cp)
		{
			CodePointIndexer.TableRange[] array = this.ranges;
			return this.defaultIndex;
		}

		// Token: 0x040000D0 RID: 208
		private readonly CodePointIndexer.TableRange[] ranges;

		// Token: 0x040000D1 RID: 209
		public readonly int TotalCount;

		// Token: 0x040000D2 RID: 210
		private int defaultIndex;

		// Token: 0x040000D3 RID: 211
		private int defaultCP;

		// Token: 0x02000031 RID: 49
		[Serializable]
		internal struct TableRange
		{
			// Token: 0x060000A7 RID: 167 RVA: 0x00003018 File Offset: 0x00001218
			public TableRange(int start, int end, int indexStart)
			{
				this.IndexEnd = indexStart;
				this.Start = start;
				this.Count = end;
			}

			// Token: 0x040000D4 RID: 212
			public readonly int Start;

			// Token: 0x040000D5 RID: 213
			public readonly int End;

			// Token: 0x040000D6 RID: 214
			public readonly int Count;

			// Token: 0x040000D7 RID: 215
			public readonly int IndexStart;

			// Token: 0x040000D8 RID: 216
			public readonly int IndexEnd;
		}
	}
}
