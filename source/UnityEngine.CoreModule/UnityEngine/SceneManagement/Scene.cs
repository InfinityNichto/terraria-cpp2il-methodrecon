using System;
using Cpp2IlInjected;
using UnityEngine.Bindings;

namespace UnityEngine.SceneManagement
{
	// Token: 0x02000124 RID: 292
	[NativeHeader("Runtime/Export/SceneManager/Scene.bindings.h")]
	[Serializable]
	public struct Scene
	{
		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060005DB RID: 1499 RVA: 0x000021B3 File Offset: 0x000003B3
		public int handle
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x000021B3 File Offset: 0x000003B3
		public override int GetHashCode()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x0000A734 File Offset: 0x00008934
		public override bool Equals(object other)
		{
			if (other != null)
			{
				return;
			}
		}

		// Token: 0x040004E6 RID: 1254
		[SerializeField]
		[HideInInspector]
		private int m_Handle;
	}
}
