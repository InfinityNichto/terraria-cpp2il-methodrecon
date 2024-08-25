using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Services
{
	// Token: 0x02000357 RID: 855
	[ComVisible(true)]
	public interface ITrackingHandler
	{
		// Token: 0x06001C88 RID: 7304
		void DisconnectedObject(object obj);

		// Token: 0x06001C89 RID: 7305
		void MarshaledObject(object obj, ObjRef or);

		// Token: 0x06001C8A RID: 7306
		void UnmarshaledObject(object obj, ObjRef or);
	}
}
