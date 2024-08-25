using System;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x020000D8 RID: 216
	[NativeHeader("Runtime/BaseClasses/TagManager.h")]
	public struct SortingLayer
	{
		// Token: 0x06000473 RID: 1139 RVA: 0x000083A0 File Offset: 0x000065A0
		[FreeFunction("GetTagManager().GetSortingLayerValueFromUniqueID")]
		public static int GetLayerValueFromID(int id)
		{
			throw new MissingMethodException();
		}

		// Token: 0x040003CF RID: 975
		private int m_Id;
	}
}
