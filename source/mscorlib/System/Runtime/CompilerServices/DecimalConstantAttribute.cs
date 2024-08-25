using System;

namespace System.Runtime.CompilerServices
{
	// Token: 0x0200046E RID: 1134
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter, Inherited = false)]
	[Serializable]
	public sealed class DecimalConstantAttribute : Attribute
	{
		// Token: 0x0600220B RID: 8715 RVA: 0x0004CD88 File Offset: 0x0004AF88
		[CLSCompliant(false)]
		public DecimalConstantAttribute(byte scale, byte sign, uint hi, uint mid, uint low)
		{
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x0600220C RID: 8716 RVA: 0x0004CD9C File Offset: 0x0004AF9C
		public decimal Value
		{
			get
			{
				decimal dec = this._dec;
				int lo = this._dec.lo;
				return dec;
			}
		}

		// Token: 0x040012AF RID: 4783
		private decimal _dec;
	}
}
