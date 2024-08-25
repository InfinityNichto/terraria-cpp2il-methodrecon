using System;
using UnityEngine;

namespace InterfaceMovement
{
	// Token: 0x0200000A RID: 10
	public class Button : MonoBehaviour
	{
		// Token: 0x06000039 RID: 57 RVA: 0x00002C9C File Offset: 0x00000E9C
		private void Start()
		{
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002CAC File Offset: 0x00000EAC
		private void Update()
		{
			bool flag = base.transform.parent.GetComponent<ButtonManager>().focusedButton == this;
			Color color = this.cachedRenderer.material.color;
			float deltaTime = Time.deltaTime;
			Material material = this.cachedRenderer.material;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002CFC File Offset: 0x00000EFC
		public Button()
		{
		}

		// Token: 0x04000022 RID: 34
		private Renderer cachedRenderer;

		// Token: 0x04000023 RID: 35
		public Button up;

		// Token: 0x04000024 RID: 36
		public Button down;

		// Token: 0x04000025 RID: 37
		public Button left;

		// Token: 0x04000026 RID: 38
		public Button right;
	}
}
