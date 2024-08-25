using System;

namespace UnityEngine.UI
{
	// Token: 0x0200000D RID: 13
	public interface IClippable
	{
		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000051 RID: 81
		GameObject gameObject { get; }

		// Token: 0x06000052 RID: 82
		void RecalculateClipping();

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000053 RID: 83
		RectTransform rectTransform { get; }

		// Token: 0x06000054 RID: 84
		void Cull(Rect clipRect, bool validRect);

		// Token: 0x06000055 RID: 85
		void SetClipRect(Rect value, bool validRect);

		// Token: 0x06000056 RID: 86
		void SetClipSoftness(Vector2 clipSoftness);
	}
}
