using System;

namespace UnityEngine.UI.CoroutineTween
{
	// Token: 0x02000088 RID: 136
	internal interface ITweenValue
	{
		// Token: 0x06000553 RID: 1363
		void TweenValue(float floatPercentage);

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000554 RID: 1364
		bool ignoreTimeScale { get; }

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000555 RID: 1365
		float duration { get; }

		// Token: 0x06000556 RID: 1366
		bool ValidTarget();
	}
}
