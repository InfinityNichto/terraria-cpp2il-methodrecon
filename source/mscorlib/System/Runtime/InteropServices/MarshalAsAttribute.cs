using System;

namespace System.Runtime.InteropServices
{
	// Token: 0x02000454 RID: 1108
	[ComVisible(true)]
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue, Inherited = false)]
	[StructLayout(0)]
	public sealed class MarshalAsAttribute : Attribute
	{
		// Token: 0x060021E2 RID: 8674 RVA: 0x0004CA48 File Offset: 0x0004AC48
		public MarshalAsAttribute(UnmanagedType unmanagedType)
		{
			this.utype = unmanagedType;
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x060021E3 RID: 8675 RVA: 0x0004CA64 File Offset: 0x0004AC64
		public UnmanagedType Value
		{
			get
			{
				return this.utype;
			}
		}

		// Token: 0x060021E4 RID: 8676 RVA: 0x0004CA78 File Offset: 0x0004AC78
		internal MarshalAsAttribute Copy()
		{
			object obj;
			if (obj != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x0400128A RID: 4746
		public string MarshalCookie;

		// Token: 0x0400128B RID: 4747
		[ComVisible(true)]
		public string MarshalType;

		// Token: 0x0400128C RID: 4748
		[ComVisible(true)]
		public Type MarshalTypeRef;

		// Token: 0x0400128D RID: 4749
		public Type SafeArrayUserDefinedSubType;

		// Token: 0x0400128E RID: 4750
		private UnmanagedType utype;

		// Token: 0x0400128F RID: 4751
		public UnmanagedType ArraySubType;

		// Token: 0x04001290 RID: 4752
		public VarEnum SafeArraySubType;

		// Token: 0x04001291 RID: 4753
		public int SizeConst;

		// Token: 0x04001292 RID: 4754
		public int IidParameterIndex;

		// Token: 0x04001293 RID: 4755
		public short SizeParamIndex;
	}
}
