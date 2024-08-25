using System;
using System.Text;
using Cpp2IlInjected;

namespace System
{
	// Token: 0x0200019C RID: 412
	internal class ArraySpec : ModifierSpec
	{
		// Token: 0x06000FCE RID: 4046 RVA: 0x00021B30 File Offset: 0x0001FD30
		internal ArraySpec(int dimensions, bool bound)
		{
			this.dimensions = dimensions;
		}

		// Token: 0x06000FCF RID: 4047 RVA: 0x00021B4C File Offset: 0x0001FD4C
		public Type Resolve(Type type)
		{
			if (this.bound)
			{
				return type;
			}
			return type;
		}

		// Token: 0x06000FD0 RID: 4048 RVA: 0x00021B68 File Offset: 0x0001FD68
		public StringBuilder Append(StringBuilder sb)
		{
			if (this.bound)
			{
				return sb.Append("[*]");
			}
			int num = 91;
			long num2 = 0L;
			StringBuilder stringBuilder = sb.Append((char)num);
			int num3 = this.dimensions;
			int num4 = 44;
			StringBuilder stringBuilder2 = stringBuilder.Append((char)num4, (int)num2);
			int num5 = 93;
			return stringBuilder2.Append((char)num5);
		}

		// Token: 0x06000FD1 RID: 4049 RVA: 0x0000207A File Offset: 0x0000027A
		public override string ToString()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x04000882 RID: 2178
		private int dimensions;

		// Token: 0x04000883 RID: 2179
		private bool bound;
	}
}
