using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000022 RID: 34
public class Alert : Singleton<Alert>
{
	// Token: 0x060000A2 RID: 162 RVA: 0x00003458 File Offset: 0x00001658
	public override void Init()
	{
	}

	// Token: 0x060000A3 RID: 163 RVA: 0x00003468 File Offset: 0x00001668
	public override void Shutdown()
	{
	}

	// Token: 0x060000A4 RID: 164 RVA: 0x00003478 File Offset: 0x00001678
	private void PCDismissCallback(int index)
	{
		if (this.DismissedWithButton != null)
		{
			return;
		}
	}

	// Token: 0x060000A5 RID: 165 RVA: 0x00003490 File Offset: 0x00001690
	public void InternalShowDelayed(Alert.AlertShownReason reason, string title, string message, string button, string hapticId = "")
	{
		this._defaultButton = button;
	}

	// Token: 0x060000A6 RID: 166 RVA: 0x000034A8 File Offset: 0x000016A8
	public void InternalShowDelayed(Alert.AlertShownReason reason, string title, string message, string button1, string button2, string buttonDefault, string hapticId = "")
	{
		this._defaultButton = buttonDefault;
	}

	// Token: 0x060000A7 RID: 167 RVA: 0x000034C0 File Offset: 0x000016C0
	private AlertDelayer GetAlertDelayObject()
	{
		GameObject delayObject = this._delayObject;
		if (!true)
		{
		}
		return this._delayObject.GetComponent<AlertDelayer>();
	}

	// Token: 0x060000A8 RID: 168 RVA: 0x000034E4 File Offset: 0x000016E4
	public void Show(Alert.AlertShownReason reason, string title, string message, string button, string hapticId = "")
	{
		AlertDelayer alertDelayObject = this.GetAlertDelayObject();
		alertDelayObject.title = title;
		alertDelayObject.message = message;
		alertDelayObject.button1 = button;
		alertDelayObject.buttonDefault = button;
		alertDelayObject.delayTime = (float)16000;
		alertDelayObject.hapticId = reason;
		alertDelayObject.hapticId = hapticId;
	}

	// Token: 0x060000A9 RID: 169 RVA: 0x00003530 File Offset: 0x00001730
	public void Show(Alert.AlertShownReason reason, string title, string message, string button1, string button2, string buttonDefault, string hapticId = "")
	{
		AlertDelayer alertDelayObject = this.GetAlertDelayObject();
		alertDelayObject.title = title;
		alertDelayObject.message = message;
		alertDelayObject.button1 = button1;
		alertDelayObject.button2 = button2;
		alertDelayObject.buttonDefault = buttonDefault;
		alertDelayObject.delayTime = (float)16000;
		alertDelayObject.hapticId = reason;
		alertDelayObject.hapticId = hapticId;
	}

	// Token: 0x14000001 RID: 1
	// (add) Token: 0x060000AA RID: 170 RVA: 0x00003584 File Offset: 0x00001784
	// (remove) Token: 0x060000AB RID: 171 RVA: 0x000035AC File Offset: 0x000017AC
	public event Action<int> DismissedWithButton
	{
		[CompilerGenerated]
		add
		{
			Delegate @delegate = Delegate.Combine(this.DismissedWithButton, value);
			if (@delegate != null && @delegate == null)
			{
				return;
			}
		}
		[CompilerGenerated]
		remove
		{
			Delegate @delegate = Delegate.Remove(this.DismissedWithButton, value);
			if (@delegate != null && @delegate == null)
			{
				return;
			}
		}
	}

	// Token: 0x060000AC RID: 172 RVA: 0x000035D4 File Offset: 0x000017D4
	private void AlertButtonClicked(string button)
	{
		AndroidImmersive.Activate();
		if (this.DismissedWithButton != null)
		{
			string[] buttons = this._buttons;
			string[] buttons2 = this._buttons;
			return;
		}
	}

	// Token: 0x060000AD RID: 173 RVA: 0x00003608 File Offset: 0x00001808
	private void AlertCancelled()
	{
		AndroidImmersive.Activate();
		if (this._buttons != null)
		{
			string defaultButton = this._defaultButton;
			this.AlertButtonClicked(defaultButton);
			return;
		}
	}

	// Token: 0x060000AE RID: 174 RVA: 0x00003634 File Offset: 0x00001834
	public Alert()
	{
	}

	// Token: 0x0400006B RID: 107
	[CompilerGenerated]
	private Action<int> DismissedWithButton;

	// Token: 0x0400006C RID: 108
	private string[] _buttons;

	// Token: 0x0400006D RID: 109
	private string _defaultButton = "";

	// Token: 0x0400006E RID: 110
	private GameObject _delayObject;

	// Token: 0x02000023 RID: 35
	public enum AlertShownReason
	{
		// Token: 0x04000070 RID: 112
		PlatformError,
		// Token: 0x04000071 RID: 113
		NetworkingIssue,
		// Token: 0x04000072 RID: 114
		DebugIAP,
		// Token: 0x04000073 RID: 115
		ToolsMistake,
		// Token: 0x04000074 RID: 116
		AppRating
	}
}
