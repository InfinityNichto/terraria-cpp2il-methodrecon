using System;

namespace System.Runtime.InteropServices
{
	// Token: 0x02000437 RID: 1079
	[ComVisible(true)]
	[AttributeUsage(AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	public sealed class UnmanagedFunctionPointerAttribute : Attribute
	{
		// Token: 0x06002166 RID: 8550 RVA: 0x0004BFE8 File Offset: 0x0004A1E8
		public UnmanagedFunctionPointerAttribute(CallingConvention callingConvention)
		{
			this.m_callingConvention = callingConvention;
		}

		// Token: 0x040011FA RID: 4602
		private CallingConvention m_callingConvention;
	}
}
