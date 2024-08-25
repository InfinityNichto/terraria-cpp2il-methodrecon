using System;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200042B RID: 1067
	internal sealed class PrimitiveArray
	{
		// Token: 0x06002142 RID: 8514 RVA: 0x0004BADC File Offset: 0x00049CDC
		internal PrimitiveArray(InternalPrimitiveTypeE code, Array array)
		{
			this.Init(code, array);
		}

		// Token: 0x06002143 RID: 8515 RVA: 0x0004BAF8 File Offset: 0x00049CF8
		internal void Init(InternalPrimitiveTypeE code, Array array)
		{
			this.code = code;
		}

		// Token: 0x06002144 RID: 8516 RVA: 0x0004BBE0 File Offset: 0x00049DE0
		internal void SetValue(string value, int index)
		{
			InternalPrimitiveTypeE internalPrimitiveTypeE = this.code;
		}

		// Token: 0x040011CF RID: 4559
		private InternalPrimitiveTypeE code;

		// Token: 0x040011D0 RID: 4560
		private bool[] booleanA;

		// Token: 0x040011D1 RID: 4561
		private char[] charA;

		// Token: 0x040011D2 RID: 4562
		private double[] doubleA;

		// Token: 0x040011D3 RID: 4563
		private short[] int16A;

		// Token: 0x040011D4 RID: 4564
		private int[] int32A;

		// Token: 0x040011D5 RID: 4565
		private long[] int64A;

		// Token: 0x040011D6 RID: 4566
		private sbyte[] sbyteA;

		// Token: 0x040011D7 RID: 4567
		private float[] singleA;

		// Token: 0x040011D8 RID: 4568
		private ushort[] uint16A;

		// Token: 0x040011D9 RID: 4569
		private uint[] uint32A;

		// Token: 0x040011DA RID: 4570
		private ulong[] uint64A;
	}
}
