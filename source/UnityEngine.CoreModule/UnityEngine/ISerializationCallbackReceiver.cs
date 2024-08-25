using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200003C RID: 60
	[RequiredByNativeCode]
	public interface ISerializationCallbackReceiver
	{
		// Token: 0x06000072 RID: 114
		[RequiredByNativeCode]
		void OnBeforeSerialize();

		// Token: 0x06000073 RID: 115
		[RequiredByNativeCode]
		void OnAfterDeserialize();
	}
}
