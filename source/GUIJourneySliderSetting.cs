using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent.Creative;

// Token: 0x02000186 RID: 390
public class GUIJourneySliderSetting : GUISliderSetting
{
	// Token: 0x06000B06 RID: 2822 RVA: 0x00037720 File Offset: 0x00035920
	public GUIJourneySliderSetting(GUISettingID id)
		: base(id)
	{
		GUISettingID id2 = this._id;
	}

	// Token: 0x06000B07 RID: 2823 RVA: 0x00037740 File Offset: 0x00035940
	public void WindBackingHandler(Vector2 position, Vector2 size, Slider_Layout layout, bool controllerOver)
	{
		Rectangle controlRegion = ControlAnchor.GetControlRegion(ControlAnchor.ControlId.Button);
		float sliderValue = CreativePowerManager.Instance.GetPower<CreativePowers.ModifyWindDirectionAndStrength>().GetSliderValue();
		bool wasDragging = this.dragState.wasDragging;
		if (!wasDragging)
		{
		}
		DateTime now = DateTime.Now;
		if (wasDragging)
		{
			this.lastShown = now;
			return;
		}
		DateTime dateTime = this.lastShown;
		double totalSeconds = (now - dateTime).TotalSeconds;
	}

	// Token: 0x06000B08 RID: 2824 RVA: 0x00037990 File Offset: 0x00035B90
	public void RainBackingHandler(Vector2 position, Vector2 size, Slider_Layout layout, bool controllerOver)
	{
		Rectangle controlRegion = ControlAnchor.GetControlRegion(ControlAnchor.ControlId.Button);
		float sliderValue = CreativePowerManager.Instance.GetPower<CreativePowers.ModifyRainPower>().GetSliderValue();
		bool wasDragging = this.dragState.wasDragging;
		if (!wasDragging)
		{
		}
		DateTime now = DateTime.Now;
		if (wasDragging)
		{
			this.lastShown = now;
			return;
		}
		DateTime dateTime = this.lastShown;
		double totalSeconds = (now - dateTime).TotalSeconds;
	}

	// Token: 0x06000B09 RID: 2825 RVA: 0x00037BDC File Offset: 0x00035DDC
	public void DifficultyBackingHandler(Vector2 position, Vector2 size, Slider_Layout layout, bool controllerOver)
	{
		Rectangle controlRegion = ControlAnchor.GetControlRegion(ControlAnchor.ControlId.Button);
		!!0 power = CreativePowerManager.Instance.GetPower();
		bool wasDragging = this.dragState.wasDragging;
		if (!wasDragging)
		{
		}
		DateTime now = DateTime.Now;
		if (wasDragging)
		{
			this.lastShown = now;
			return;
		}
		DateTime dateTime = this.lastShown;
		double totalSeconds = (now - dateTime).TotalSeconds;
	}

	// Token: 0x06000B0A RID: 2826 RVA: 0x00037EB0 File Offset: 0x000360B0
	public override void Draw()
	{
		int num = 1;
		base.Draw();
		GUISettingID id = this._id;
		if (num == 0)
		{
		}
	}

	// Token: 0x06000B0B RID: 2827 RVA: 0x000021DB File Offset: 0x000003DB
	protected override SettingsOverlaySlider_Layout GetLayout()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000B0C RID: 2828 RVA: 0x00037ED0 File Offset: 0x000360D0
	// Note: this type is marked as 'beforefieldinit'.
	static GUIJourneySliderSetting()
	{
	}

	// Token: 0x04000B8F RID: 2959
	private DateTime lastShown;

	// Token: 0x04000B90 RID: 2960
	private static GUIJourneySliderSetting.ColorFadeBackup fadeSettings;

	// Token: 0x04000B91 RID: 2961
	private float iconScale;

	// Token: 0x02000187 RID: 391
	public struct ColorFadeBackup
	{
		// Token: 0x06000B0D RID: 2829 RVA: 0x00037EE0 File Offset: 0x000360E0
		public void ApplyFade(TransactionButton_Layout layout, float fadeAmount)
		{
			this.IconColour = 1;
			this.PressedIconColour = 1;
			Color color = layout.Label.Color;
			this.LabelColor = color;
			this.PressedLabelColor = color;
			if (color == null)
			{
			}
			Color color2 = color * fadeAmount;
			String_Layout label = layout.Label;
			Color color3 = label.Color * fadeAmount;
			label.Color = color3;
			Color color4 = color3 * fadeAmount;
		}

		// Token: 0x06000B0E RID: 2830 RVA: 0x00037F48 File Offset: 0x00036148
		public void RestoreFade(TransactionButton_Layout layout)
		{
			Color pressedIconColour = this.PressedIconColour;
			String_Layout label = layout.Label;
			Color labelColor = this.LabelColor;
			label.Color = labelColor;
			Color pressedLabelColor = this.PressedLabelColor;
		}

		// Token: 0x04000B92 RID: 2962
		private Color IconColour;

		// Token: 0x04000B93 RID: 2963
		private Color PressedIconColour;

		// Token: 0x04000B94 RID: 2964
		private Color LabelColor;

		// Token: 0x04000B95 RID: 2965
		private Color PressedLabelColor;
	}
}
