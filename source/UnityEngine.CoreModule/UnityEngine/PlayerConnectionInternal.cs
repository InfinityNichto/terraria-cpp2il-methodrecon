using System;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000077 RID: 119
	[NativeHeader("Runtime/Export/PlayerConnection/PlayerConnectionInternal.bindings.h")]
	internal class PlayerConnectionInternal : IPlayerEditorConnectionNative
	{
		// Token: 0x060001E1 RID: 481 RVA: 0x00004ABC File Offset: 0x00002CBC
		void IPlayerEditorConnectionNative.SendMessage(Guid messageId, byte[] data, int playerId)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00004AD0 File Offset: 0x00002CD0
		bool IPlayerEditorConnectionNative.TrySendMessage(Guid messageId, byte[] data, int playerId)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00004AE4 File Offset: 0x00002CE4
		void IPlayerEditorConnectionNative.Poll()
		{
			throw new MissingMethodException();
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00004AF8 File Offset: 0x00002CF8
		void IPlayerEditorConnectionNative.RegisterInternal(Guid messageId)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00004B0C File Offset: 0x00002D0C
		void IPlayerEditorConnectionNative.UnregisterInternal(Guid messageId)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00004B20 File Offset: 0x00002D20
		void IPlayerEditorConnectionNative.Initialize()
		{
			throw new MissingMethodException();
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00004B34 File Offset: 0x00002D34
		bool IPlayerEditorConnectionNative.IsConnected()
		{
			throw new MissingMethodException();
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00004B48 File Offset: 0x00002D48
		void IPlayerEditorConnectionNative.DisconnectAll()
		{
			throw new MissingMethodException();
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00004B5C File Offset: 0x00002D5C
		[FreeFunction("PlayerConnection_Bindings::IsConnected")]
		private static bool IsConnected()
		{
			throw new MissingMethodException();
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00004B70 File Offset: 0x00002D70
		[FreeFunction("PlayerConnection_Bindings::Initialize")]
		private static void Initialize()
		{
			throw new MissingMethodException();
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00004B84 File Offset: 0x00002D84
		[FreeFunction("PlayerConnection_Bindings::RegisterInternal")]
		private static void RegisterInternal(string messageId)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00004B98 File Offset: 0x00002D98
		[FreeFunction("PlayerConnection_Bindings::UnregisterInternal")]
		private static void UnregisterInternal(string messageId)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00004BAC File Offset: 0x00002DAC
		[FreeFunction("PlayerConnection_Bindings::SendMessage")]
		private static void SendMessage(string messageId, byte[] data, int playerId)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00004BC0 File Offset: 0x00002DC0
		[FreeFunction("PlayerConnection_Bindings::TrySendMessage")]
		private static bool TrySendMessage(string messageId, byte[] data, int playerId)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00004BD4 File Offset: 0x00002DD4
		[FreeFunction("PlayerConnection_Bindings::PollInternal")]
		private static void PollInternal()
		{
			throw new MissingMethodException();
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00004BE8 File Offset: 0x00002DE8
		[FreeFunction("PlayerConnection_Bindings::DisconnectAll")]
		private static void DisconnectAll()
		{
			throw new MissingMethodException();
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00004BFC File Offset: 0x00002DFC
		public PlayerConnectionInternal()
		{
		}
	}
}
