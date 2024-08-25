using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Controller;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Localization;

// Token: 0x0200028F RID: 655
public class GUIPulldownSetting : GUISettingEntry
{
	// Token: 0x06000F48 RID: 3912 RVA: 0x0004C518 File Offset: 0x0004A718
	public GUIPulldownSetting(GUISettingID id, [Optional] GUIPulldownSetting.ActivateOverlayCallback activateOverlayCallbackOverload, [Optional] GUIPulldownSetting.DeactivateOverlayCallback deactivateOverlayCallbackOverload, [Optional] GUIPulldownSetting.RegisterOverlay registerOverlayOverload)
	{
		this._id = id;
		this.activateOverlayCallback = activateOverlayCallbackOverload;
		this.deactivateOverlayCallback = deactivateOverlayCallbackOverload;
		this.registerOverlayCallback = registerOverlayOverload;
	}

	// Token: 0x06000F49 RID: 3913 RVA: 0x0004C548 File Offset: 0x0004A748
	public void CloseOptions()
	{
		if (this.displayOptions)
		{
			GUIPulldownSetting.DeactivateOverlayCallback deactivateOverlayCallback = this.deactivateOverlayCallback;
			if (deactivateOverlayCallback != null)
			{
				IntPtr invoke_impl = deactivateOverlayCallback.invoke_impl;
				IntPtr method_code = deactivateOverlayCallback.method_code;
				IntPtr method = deactivateOverlayCallback.method;
				return;
			}
			GUIInputRegionExclusive optionsBlocker = this._optionsBlocker;
		}
	}

	// Token: 0x06000F4A RID: 3914 RVA: 0x0004C588 File Offset: 0x0004A788
	public override void DrawOverlay()
	{
		this.drawingOverlay = true;
	}

	// Token: 0x06000F4B RID: 3915 RVA: 0x0004C59C File Offset: 0x0004A79C
	private void DrawFaceButtons()
	{
	}

	// Token: 0x06000F4C RID: 3916 RVA: 0x0004C5D8 File Offset: 0x0004A7D8
	private void DrawOptionFaceButtons(ControllerDevice.ControlScheme scheme)
	{
	}

	// Token: 0x06000F4D RID: 3917 RVA: 0x0004C5E8 File Offset: 0x0004A7E8
	public void RefreshInputRegion()
	{
		if (!true)
		{
		}
		GUISettingID id = this._id;
		int numberOfOptions = this.GetNumberOfOptions();
		this.CloseOptions();
		long num = 0L;
		string option = this.GetOption((int)num);
		string text;
		bool flag = text == option;
	}

	// Token: 0x06000F4E RID: 3918 RVA: 0x0004C6F4 File Offset: 0x0004A8F4
	public override void Draw()
	{
		bool flag = this.displayOptions;
		if (!flag || this.drawingOverlay)
		{
			if (this._optionsBlocker != null)
			{
			}
			if (flag)
			{
				int screenWidth = Main.screenWidth;
				int screenHeight = Main.screenHeight;
			}
			string value = this.GetValue();
			string title = this.GetTitle();
			SpriteFont spriteFont;
			Vector2 vector = spriteFont.MeasureString(title);
			SpriteFont spriteFont2;
			Vector2 vector2 = spriteFont2.MeasureString(value);
			long num = 0L;
			SpriteFont spriteFont3;
			Vector2 vector3 = spriteFont3.MeasureString(value);
			int stringLength = value._stringLength;
			long num2 = 0L;
			string text = value.Substring((int)num2, (int)num);
			SpriteFont spriteFont4;
			Vector2 vector4 = spriteFont4.MeasureString(text);
			string text2 = text + "...";
			GUISettingID id = this._id;
			bool flag2 = this.displayOptions;
			string title2 = this.GetTitle();
			return;
		}
		GUIPulldownSetting.RegisterOverlay registerOverlay = this.registerOverlayCallback;
		if (registerOverlay != null)
		{
			Rectangle gridItemRegion = ControlAnchor._gridItemRegion;
			IntPtr invoke_impl = registerOverlay.invoke_impl;
			IntPtr method_code = registerOverlay.method_code;
			IntPtr method = registerOverlay.method;
			return;
		}
		Rectangle gridItemRegion2 = ControlAnchor._gridItemRegion;
	}

	// Token: 0x06000F4F RID: 3919 RVA: 0x0004CB6C File Offset: 0x0004AD6C
	public void DisablePulldown()
	{
		GUIInputRegionExclusive optionsBlocker = this._optionsBlocker;
		if (optionsBlocker != null)
		{
			optionsBlocker.Active = true;
			GUIPulldownSetting.DeactivateOverlayCallback deactivateOverlayCallback = this.deactivateOverlayCallback;
			if (deactivateOverlayCallback != null)
			{
				IntPtr invoke_impl = deactivateOverlayCallback.invoke_impl;
				IntPtr method_code = deactivateOverlayCallback.method_code;
				IntPtr method = deactivateOverlayCallback.method;
				return;
			}
			GUIInputRegionExclusive optionsBlocker2 = this._optionsBlocker;
		}
	}

	// Token: 0x06000F50 RID: 3920 RVA: 0x000021DB File Offset: 0x000003DB
	public override float GetElementHeight()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000F51 RID: 3921 RVA: 0x0004CBB4 File Offset: 0x0004ADB4
	private bool IsOverOptions(Vector2 cursorPosition)
	{
		return true;
	}

	// Token: 0x06000F52 RID: 3922 RVA: 0x0004CBF0 File Offset: 0x0004ADF0
	public int GetNumberOfOptions()
	{
		GUISettingID id = this._id;
		return 2;
	}

	// Token: 0x1700018A RID: 394
	// (get) Token: 0x06000F53 RID: 3923 RVA: 0x000021DB File Offset: 0x000003DB
	private static List<int> optionRedirection
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x06000F54 RID: 3924 RVA: 0x0004CC38 File Offset: 0x0004AE38
	private string GetOption(int index)
	{
		bool flag = this.displayOptions;
		if (!flag || !flag)
		{
		}
		GUISettingID id = this._id;
		string text;
		return text;
	}

	// Token: 0x06000F55 RID: 3925 RVA: 0x0004CD88 File Offset: 0x0004AF88
	private void SetOption(int index)
	{
		bool flag = this.displayOptions;
		if (!flag || !flag)
		{
		}
	}

	// Token: 0x06000F56 RID: 3926 RVA: 0x0004CEDC File Offset: 0x0004B0DC
	private string GetTitle()
	{
		GUISettingID id = this._id;
		return "Mobile.MiniMapBorderStyleTitle";
	}

	// Token: 0x06000F57 RID: 3927 RVA: 0x0004CF50 File Offset: 0x0004B150
	private string GetLanguageFromLegacyId(int legacyId)
	{
		return Language.GetTextValue("Language.English");
	}

	// Token: 0x06000F58 RID: 3928 RVA: 0x0004CF6C File Offset: 0x0004B16C
	private string GetValue()
	{
		GUISettingID id = this._id;
		return "ControllerSchemes.";
	}

	// Token: 0x06000F59 RID: 3929 RVA: 0x0004D0F4 File Offset: 0x0004B2F4
	// Note: this type is marked as 'beforefieldinit'.
	static GUIPulldownSetting()
	{
	}

	// Token: 0x04001B72 RID: 7026
	private GUIPulldownSetting.ActivateOverlayCallback activateOverlayCallback;

	// Token: 0x04001B73 RID: 7027
	private GUIPulldownSetting.DeactivateOverlayCallback deactivateOverlayCallback;

	// Token: 0x04001B74 RID: 7028
	private GUIPulldownSetting.RegisterOverlay registerOverlayCallback;

	// Token: 0x04001B75 RID: 7029
	private float scale;

	// Token: 0x04001B76 RID: 7030
	private bool drawingOverlay;

	// Token: 0x04001B77 RID: 7031
	public int selectedPosition;

	// Token: 0x04001B78 RID: 7032
	private float _offset;

	// Token: 0x04001B79 RID: 7033
	public bool displayOptions;

	// Token: 0x04001B7A RID: 7034
	private GUIInputRegionExclusive _optionsBlocker;

	// Token: 0x04001B7B RID: 7035
	private static int[] LanguageMappingIndices;

	// Token: 0x02000290 RID: 656
	public sealed class ActivateOverlayCallback : MulticastDelegate
	{
		// Token: 0x06000F5A RID: 3930 RVA: 0x0004D104 File Offset: 0x0004B304
		public ActivateOverlayCallback(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x06000F5B RID: 3931 RVA: 0x0004D164 File Offset: 0x0004B364
		public void Invoke(GUIPulldownSetting overlayEntry, Rectangle overlayRegion, int selectedOption, float offset)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}

		// Token: 0x06000F5C RID: 3932 RVA: 0x000021DB File Offset: 0x000003DB
		public IAsyncResult BeginInvoke(GUIPulldownSetting overlayEntry, Rectangle overlayRegion, int selectedOption, float offset, AsyncCallback callback, object @object)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000F5D RID: 3933 RVA: 0x0004D188 File Offset: 0x0004B388
		public void EndInvoke(IAsyncResult result)
		{
		}
	}

	// Token: 0x02000291 RID: 657
	public sealed class RegisterOverlay : MulticastDelegate
	{
		// Token: 0x06000F5E RID: 3934 RVA: 0x0004D198 File Offset: 0x0004B398
		public RegisterOverlay(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x06000F5F RID: 3935 RVA: 0x0004D1F8 File Offset: 0x0004B3F8
		public void Invoke(GUIPulldownSetting overlayEntry, Rectangle overlayRegion)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}

		// Token: 0x06000F60 RID: 3936 RVA: 0x000021DB File Offset: 0x000003DB
		public IAsyncResult BeginInvoke(GUIPulldownSetting overlayEntry, Rectangle overlayRegion, AsyncCallback callback, object @object)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000F61 RID: 3937 RVA: 0x0004D21C File Offset: 0x0004B41C
		public void EndInvoke(IAsyncResult result)
		{
		}
	}

	// Token: 0x02000292 RID: 658
	public sealed class DeactivateOverlayCallback : MulticastDelegate
	{
		// Token: 0x06000F62 RID: 3938 RVA: 0x0004D22C File Offset: 0x0004B42C
		public DeactivateOverlayCallback(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x06000F63 RID: 3939 RVA: 0x0004D280 File Offset: 0x0004B480
		public void Invoke()
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}

		// Token: 0x06000F64 RID: 3940 RVA: 0x000021DB File Offset: 0x000003DB
		public IAsyncResult BeginInvoke(AsyncCallback callback, object @object)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000F65 RID: 3941 RVA: 0x0004D2A4 File Offset: 0x0004B4A4
		public void EndInvoke(IAsyncResult result)
		{
		}
	}
}
