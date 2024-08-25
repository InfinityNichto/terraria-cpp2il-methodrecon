using System;
using UnityEngine.Scripting;

namespace UnityEngine.Playables
{
	// Token: 0x02000152 RID: 338
	[RequiredByNativeCode]
	public interface INotificationReceiver
	{
		// Token: 0x0600064F RID: 1615
		[RequiredByNativeCode]
		void OnNotify(Playable origin, INotification notification, object context);
	}
}
