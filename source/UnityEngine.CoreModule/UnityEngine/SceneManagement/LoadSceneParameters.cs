using System;

namespace UnityEngine.SceneManagement
{
	// Token: 0x02000122 RID: 290
	[Serializable]
	public struct LoadSceneParameters
	{
		// Token: 0x060005CD RID: 1485 RVA: 0x0000A5EC File Offset: 0x000087EC
		public LoadSceneParameters(LoadSceneMode mode)
		{
			this.m_LoadSceneMode = mode;
		}

		// Token: 0x040004E0 RID: 1248
		[SerializeField]
		private LoadSceneMode m_LoadSceneMode;

		// Token: 0x040004E1 RID: 1249
		[SerializeField]
		private LocalPhysicsMode m_LocalPhysicsMode;
	}
}
