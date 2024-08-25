using System;

namespace System.Runtime.InteropServices
{
	// Token: 0x02000439 RID: 1081
	[ComVisible(true)]
	[Serializable]
	public enum ComInterfaceType
	{
		// Token: 0x040011FD RID: 4605
		InterfaceIsDual,
		// Token: 0x040011FE RID: 4606
		InterfaceIsIUnknown,
		// Token: 0x040011FF RID: 4607
		InterfaceIsIDispatch,
		// Token: 0x04001200 RID: 4608
		[ComVisible(false)]
		InterfaceIsIInspectable
	}
}
