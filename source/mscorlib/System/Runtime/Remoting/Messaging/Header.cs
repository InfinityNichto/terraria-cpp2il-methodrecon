using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020003A8 RID: 936
	[ComVisible(true)]
	[Serializable]
	public class Header
	{
		// Token: 0x04000F23 RID: 3875
		public string HeaderNamespace;

		// Token: 0x04000F24 RID: 3876
		public bool MustUnderstand;

		// Token: 0x04000F25 RID: 3877
		public string Name;

		// Token: 0x04000F26 RID: 3878
		public object Value;
	}
}
