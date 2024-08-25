using System;
using System.Collections.Generic;
using UnityEngine.Serialization;

namespace UnityEngine.Events
{
	// Token: 0x02000165 RID: 357
	[Serializable]
	internal class PersistentCallGroup
	{
		// Token: 0x060006AC RID: 1708 RVA: 0x0000BF80 File Offset: 0x0000A180
		public PersistentCallGroup()
		{
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x0000BF94 File Offset: 0x0000A194
		public void Initialize(InvokableCallList invokableList, UnityEventBase unityEventBase)
		{
			List<PersistentCall> calls = this.m_Calls;
			BaseInvokableCall baseInvokableCall;
			while (baseInvokableCall == null)
			{
			}
			invokableList.AddPersistentInvokableCall(baseInvokableCall);
		}

		// Token: 0x0400065E RID: 1630
		[SerializeField]
		[FormerlySerializedAs("m_Listeners")]
		private List<PersistentCall> m_Calls;
	}
}
