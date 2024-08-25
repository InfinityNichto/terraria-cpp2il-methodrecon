using System;
using System.Reflection;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x02000399 RID: 921
	internal class ArgInfo
	{
		// Token: 0x06001DA7 RID: 7591 RVA: 0x00040B5C File Offset: 0x0003ED5C
		public ArgInfo(MethodBase method, ArgInfoType type)
		{
			this._method = method;
			int[] paramMap = this._paramMap;
		}

		// Token: 0x06001DA8 RID: 7592 RVA: 0x00040B90 File Offset: 0x0003ED90
		public object[] GetInOutArgs(object[] args)
		{
			int inoutArgCount = this._inoutArgCount;
			int inoutArgCount2 = this._inoutArgCount;
			int[] paramMap = this._paramMap;
			int inoutArgCount3 = this._inoutArgCount;
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x04000EF1 RID: 3825
		private int[] _paramMap;

		// Token: 0x04000EF2 RID: 3826
		private int _inoutArgCount;

		// Token: 0x04000EF3 RID: 3827
		private MethodBase _method;
	}
}
