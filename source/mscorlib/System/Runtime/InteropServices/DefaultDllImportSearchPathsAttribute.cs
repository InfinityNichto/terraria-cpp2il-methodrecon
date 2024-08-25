using System;

namespace System.Runtime.InteropServices
{
	// Token: 0x02000448 RID: 1096
	[ComVisible(false)]
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Method, AllowMultiple = false)]
	public sealed class DefaultDllImportSearchPathsAttribute : Attribute
	{
		// Token: 0x06002172 RID: 8562 RVA: 0x0004C108 File Offset: 0x0004A308
		public DefaultDllImportSearchPathsAttribute(DllImportSearchPath paths)
		{
			this._paths = paths;
		}

		// Token: 0x04001266 RID: 4710
		internal DllImportSearchPath _paths;
	}
}
