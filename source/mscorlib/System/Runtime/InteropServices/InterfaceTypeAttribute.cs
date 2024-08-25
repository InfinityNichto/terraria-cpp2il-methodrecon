using System;

namespace System.Runtime.InteropServices
{
	// Token: 0x0200043A RID: 1082
	[AttributeUsage(AttributeTargets.Interface, Inherited = false)]
	[ComVisible(true)]
	public sealed class InterfaceTypeAttribute : Attribute
	{
		// Token: 0x06002168 RID: 8552 RVA: 0x0004C020 File Offset: 0x0004A220
		public InterfaceTypeAttribute(ComInterfaceType interfaceType)
		{
			this._val = interfaceType;
		}

		// Token: 0x04001201 RID: 4609
		internal ComInterfaceType _val;
	}
}
