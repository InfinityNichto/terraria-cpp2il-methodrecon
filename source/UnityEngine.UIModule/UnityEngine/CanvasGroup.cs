using System;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x0200000A RID: 10
	[NativeHeader("Modules/UI/CanvasGroup.h")]
	[NativeClass("UI::CanvasGroup")]
	public sealed class CanvasGroup : Behaviour, ICanvasRaycastFilter
	{
		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000058 RID: 88 RVA: 0x000027C4 File Offset: 0x000009C4
		// (set) Token: 0x06000059 RID: 89 RVA: 0x000027D8 File Offset: 0x000009D8
		[NativeProperty("Alpha", false, TargetType.Function)]
		public float alpha
		{
			get
			{
				throw new MissingMethodException();
			}
			set
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600005A RID: 90 RVA: 0x000027EC File Offset: 0x000009EC
		[NativeProperty("Interactable", false, TargetType.Function)]
		public bool interactable
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00002800 File Offset: 0x00000A00
		[NativeProperty("BlocksRaycasts", false, TargetType.Function)]
		public bool blocksRaycasts
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600005C RID: 92 RVA: 0x00002814 File Offset: 0x00000A14
		[NativeProperty("IgnoreParentGroups", false, TargetType.Function)]
		public bool ignoreParentGroups
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002828 File Offset: 0x00000A28
		public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
		{
			throw new MissingMethodException();
		}
	}
}
