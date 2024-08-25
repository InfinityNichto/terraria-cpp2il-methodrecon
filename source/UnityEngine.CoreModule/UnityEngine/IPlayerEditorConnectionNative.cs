using System;

namespace UnityEngine
{
	// Token: 0x02000076 RID: 118
	internal interface IPlayerEditorConnectionNative
	{
		// Token: 0x060001D9 RID: 473
		void Initialize();

		// Token: 0x060001DA RID: 474
		void DisconnectAll();

		// Token: 0x060001DB RID: 475
		void SendMessage(Guid messageId, byte[] data, int playerId);

		// Token: 0x060001DC RID: 476
		bool TrySendMessage(Guid messageId, byte[] data, int playerId);

		// Token: 0x060001DD RID: 477
		void Poll();

		// Token: 0x060001DE RID: 478
		void RegisterInternal(Guid messageId);

		// Token: 0x060001DF RID: 479
		void UnregisterInternal(Guid messageId);

		// Token: 0x060001E0 RID: 480
		bool IsConnected();
	}
}
