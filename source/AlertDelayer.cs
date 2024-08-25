using System;
using UnityEngine;

// Token: 0x02000024 RID: 36
public class AlertDelayer : MonoBehaviour
{
	// Token: 0x060000AF RID: 175 RVA: 0x00003654 File Offset: 0x00001854
	private void Update()
	{
		float num = this.delayTime;
		float deltaTime = Time.deltaTime;
		bool flag = this.button2 == "";
		string text = this.button1;
	}

	// Token: 0x060000B0 RID: 176 RVA: 0x00003694 File Offset: 0x00001894
	public AlertDelayer()
	{
	}

	// Token: 0x04000075 RID: 117
	public string title = "";

	// Token: 0x04000076 RID: 118
	public string message = "";

	// Token: 0x04000077 RID: 119
	public string button1 = "";

	// Token: 0x04000078 RID: 120
	public string button2 = "";

	// Token: 0x04000079 RID: 121
	public string buttonDefault = "";

	// Token: 0x0400007A RID: 122
	public float delayTime;

	// Token: 0x0400007B RID: 123
	public Alert.AlertShownReason reason;

	// Token: 0x0400007C RID: 124
	public string hapticId = "";
}
