using System;
using Terraria.Localization;
using UnityEngine;

// Token: 0x0200027A RID: 634
public class GUIPS4MultiplayerChecks
{
	// Token: 0x06000E5F RID: 3679 RVA: 0x00046570 File Offset: 0x00044770
	private void DisplayGenericError(string error)
	{
		this.displayingGenericError = true;
		this.genericError = error;
	}

	// Token: 0x06000E60 RID: 3680 RVA: 0x0004658C File Offset: 0x0004478C
	private void EditorCheckPermissions()
	{
		this.EditorCheckingPermissions = true;
		if (!true)
		{
		}
		DateTime now = DateTime.Now;
		this.EditorCheckStart = now;
	}

	// Token: 0x06000E61 RID: 3681 RVA: 0x000465B4 File Offset: 0x000447B4
	private void EditorCheckPermissionsUpdate()
	{
		if (!true)
		{
		}
		DateTime now = DateTime.Now;
		DateTime editorCheckStart = this.EditorCheckStart;
		double totalSeconds = (now - editorCheckStart).TotalSeconds;
	}

	// Token: 0x06000E62 RID: 3682 RVA: 0x00046624 File Offset: 0x00044824
	public void Begin()
	{
		this.CheckingPS4Permisions = true;
		if (!true)
		{
		}
		bool isEditor = Application.isEditor;
		this.EditorCheckPermissions();
	}

	// Token: 0x06000E63 RID: 3683 RVA: 0x0004664C File Offset: 0x0004484C
	public void Complete(bool passed)
	{
	}

	// Token: 0x06000E64 RID: 3684 RVA: 0x0004665C File Offset: 0x0004485C
	public void Draw()
	{
		if (this.displayingGenericError)
		{
			string text = this.genericError;
			GUITransactionButton.InputState inputState;
			if (inputState == GUITransactionButton.InputState.Clicked)
			{
				long num = 0L;
				this.Complete(num != 0L);
				return;
			}
		}
		else
		{
			string textValue = Language.GetTextValue("PS4.PermissionsCheck");
			if ("PS4.PermissionsCheck" == null)
			{
			}
			if (6899 == 0)
			{
			}
		}
		if (this.EditorCheckingPermissions)
		{
			this.EditorCheckPermissionsUpdate();
		}
		if (this.parentalFailed)
		{
			long num2 = 0L;
			this.Complete(num2 != 0L);
		}
		if (this.displayedPlusSignup)
		{
			long num3 = 0L;
			this.Complete(num3 != 0L);
		}
	}

	// Token: 0x06000E65 RID: 3685 RVA: 0x000466D4 File Offset: 0x000448D4
	public GUIPS4MultiplayerChecks()
	{
	}

	// Token: 0x04001A37 RID: 6711
	public bool CheckingPS4Permisions;

	// Token: 0x04001A38 RID: 6712
	public bool parentalFailed;

	// Token: 0x04001A39 RID: 6713
	private int userId;

	// Token: 0x04001A3A RID: 6714
	private GUIPS4MultiplayerChecks.StateCheck state;

	// Token: 0x04001A3B RID: 6715
	private bool stepPassed;

	// Token: 0x04001A3C RID: 6716
	private bool displayingPS4Error;

	// Token: 0x04001A3D RID: 6717
	private bool displayingGenericError;

	// Token: 0x04001A3E RID: 6718
	private bool displayedPlusSignup;

	// Token: 0x04001A3F RID: 6719
	private string genericError;

	// Token: 0x04001A40 RID: 6720
	private bool XBOError;

	// Token: 0x04001A41 RID: 6721
	private bool stepFailed;

	// Token: 0x04001A42 RID: 6722
	private uint stepErrorCode;

	// Token: 0x04001A43 RID: 6723
	private bool EditorCheckingPermissions;

	// Token: 0x04001A44 RID: 6724
	private DateTime EditorCheckStart;

	// Token: 0x0200027B RID: 635
	public enum StateCheck
	{
		// Token: 0x04001A46 RID: 6726
		Availability,
		// Token: 0x04001A47 RID: 6727
		ParentalCheck,
		// Token: 0x04001A48 RID: 6728
		CheckPlus
	}
}
