using System;

namespace UnityEngine.EventSystems
{
	// Token: 0x020000A9 RID: 169
	public interface ICancelHandler : IEventSystemHandler
	{
		// Token: 0x060005E0 RID: 1504
		void OnCancel(BaseEventData eventData);
	}
}
