using System;
using UnityEngine;

namespace InterfaceMovement
{
	// Token: 0x0200000B RID: 11
	public class ButtonFocus : MonoBehaviour
	{
		// Token: 0x0600003C RID: 60 RVA: 0x00002D10 File Offset: 0x00000F10
		private void Update()
		{
			Button focusedButton = base.transform.parent.GetComponent<ButtonManager>().focusedButton;
			Transform transform = base.transform;
			Vector3 position = base.transform.position;
			Vector3 position2 = focusedButton.transform.position;
			float deltaTime = Time.deltaTime;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002D5C File Offset: 0x00000F5C
		public ButtonFocus()
		{
		}
	}
}
