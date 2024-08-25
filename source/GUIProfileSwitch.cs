using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000165 RID: 357
public class GUIProfileSwitch
{
	// Token: 0x060009F5 RID: 2549 RVA: 0x0002F278 File Offset: 0x0002D478
	public void Show(VirtualControlsHardwareConfigurationMapping_Layout origin)
	{
		this.Visible = true;
		this.buttonOrigin = origin;
	}

	// Token: 0x060009F6 RID: 2550 RVA: 0x000021DB File Offset: 0x000003DB
	public void CycleNextProfile()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x060009F7 RID: 2551 RVA: 0x0002F294 File Offset: 0x0002D494
	public bool IsOver(Vector2 cursorPosition)
	{
		if (this.Visible)
		{
			VirtualControlsHardwareConfigurationMapping_Layout virtualControlsHardwareConfigurationMapping_Layout = this.buttonOrigin;
			VirtualControlsButtonConfiguration_Layout buttonConfiguration = virtualControlsHardwareConfigurationMapping_Layout.Style.ButtonConfiguration;
			VirtualControlsHardwareConfigurationMapping_Layout virtualControlsHardwareConfigurationMapping_Layout2 = this.buttonOrigin;
			QuickActionButton_Layout tealLayout = buttonConfiguration.TealLayout;
			Texture_Layout backingNormal = tealLayout.BackingNormal;
			tealLayout.AnchorControl = virtualControlsHardwareConfigurationMapping_Layout;
			tealLayout.Location = virtualControlsHardwareConfigurationMapping_Layout2;
			Texture2D texture = backingNormal.Texture;
			if (virtualControlsHardwareConfigurationMapping_Layout == null)
			{
			}
			Rectangle region = GUIButton.GetRegion(tealLayout, texture);
			ControlAnchor.SetGridItemRegion(region);
			VirtualControlsHardwareConfigurationMapping_Layout virtualControlsHardwareConfigurationMapping_Layout3 = this.buttonOrigin;
			ControlAnchor.ControlId anchorControl = virtualControlsHardwareConfigurationMapping_Layout3.AnchorControl;
			bool flag;
			return flag;
		}
	}

	// Token: 0x060009F8 RID: 2552 RVA: 0x0002F31C File Offset: 0x0002D51C
	public void Draw()
	{
		bool visible = this.Visible;
		if (visible)
		{
			if (!visible)
			{
			}
			VirtualControlsHardwareConfigurationMapping_Layout virtualControlsHardwareConfigurationMapping_Layout = this.buttonOrigin;
			VirtualControlsButtonConfiguration_Layout buttonConfiguration = virtualControlsHardwareConfigurationMapping_Layout.Style.ButtonConfiguration;
			VirtualControlsHardwareConfigurationMapping_Layout virtualControlsHardwareConfigurationMapping_Layout2 = this.buttonOrigin;
			QuickActionButton_Layout tealLayout = buttonConfiguration.TealLayout;
			Texture_Layout backingNormal = tealLayout.BackingNormal;
			tealLayout.AnchorControl = virtualControlsHardwareConfigurationMapping_Layout;
			tealLayout.Location = virtualControlsHardwareConfigurationMapping_Layout2;
			Texture2D texture = backingNormal.Texture;
			if (virtualControlsHardwareConfigurationMapping_Layout == null)
			{
			}
			ControlAnchor.SetGridItemRegion(GUIButton.GetRegion(tealLayout, texture));
			ControlAnchor.ControlId anchorControl = this.buttonOrigin.AnchorControl;
			return;
		}
	}

	// Token: 0x060009F9 RID: 2553 RVA: 0x0002F3E8 File Offset: 0x0002D5E8
	public GUIProfileSwitch()
	{
	}

	// Token: 0x040009D0 RID: 2512
	public bool Visible;

	// Token: 0x040009D1 RID: 2513
	private VirtualControlsHardwareConfigurationMapping_Layout buttonOrigin;

	// Token: 0x040009D2 RID: 2514
	private List<VirtualControlsProfile_Layout> profiles;

	// Token: 0x040009D3 RID: 2515
	private float Profile1Scale;

	// Token: 0x040009D4 RID: 2516
	private float Profile2Scale;

	// Token: 0x040009D5 RID: 2517
	private float Profile3Scale;

	// Token: 0x040009D6 RID: 2518
	private float Profile4Scale;
}
