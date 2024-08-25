using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameInput;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000AD3 RID: 2771
	public class UIVerticalSlider : UISliderBase
	{
		// Token: 0x06005195 RID: 20885 RVA: 0x00280C34 File Offset: 0x0027EE34
		public UIVerticalSlider(Func<float> getStatus, Action<float> setStatusKeyboard, Action setStatusGamepad, Color color)
		{
			if (!true)
			{
			}
			this.FilledColor = 1;
			if (!true)
			{
			}
			this.EmptyColor = 1;
			base..ctor();
			if (getStatus == null)
			{
				if (!true)
				{
				}
				if (getStatus != null || !true)
				{
				}
			}
			if (setStatusKeyboard != null || setStatusKeyboard == null)
			{
			}
			this._slideGamepadAction = setStatusGamepad;
		}

		// Token: 0x06005196 RID: 20886 RVA: 0x00280C74 File Offset: 0x0027EE74
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			bool mouseLeft = Main.mouseLeft;
			int usageLevel = base.GetUsageLevel();
			Func<float> getSliderValue = this._getSliderValue;
			bool mouseLeft2 = PlayerInput.Triggers.Current.MouseLeft;
			bool usingGamepad = PlayerInput.UsingGamepad;
			if (this._isReallyMouseOvered)
			{
				Action slideGamepadAction = this._slideGamepadAction;
				IntPtr invoke_impl = slideGamepadAction.invoke_impl;
				IntPtr method_code = slideGamepadAction.method_code;
				IntPtr method = slideGamepadAction.method;
			}
		}

		// Token: 0x06005197 RID: 20887 RVA: 0x00280CF8 File Offset: 0x0027EEF8
		private bool DrawValueBarDynamicWidth(SpriteBatch spriteBatch, [Out] float sliderValueThatWasSet)
		{
			int num = 1;
			if (num == 0)
			{
			}
			float x = this._dimensions.X;
			if (num == 0)
			{
			}
			float precent = this.Left.Precent;
			int num2 = 32768;
			int num3 = 2;
			int num4 = 2;
			Rectangle rectangle;
			rectangle.Inflate(num3, num4);
			Vector2 mouseScreen = Main.MouseScreen;
			if (num2 == 0)
			{
			}
			int mouseY = Main.mouseY;
			if (num2 == 0)
			{
				return;
			}
		}

		// Token: 0x04008A13 RID: 35347
		public float FillPercent;

		// Token: 0x04008A14 RID: 35348
		public Color FilledColor;

		// Token: 0x04008A15 RID: 35349
		public Color EmptyColor;

		// Token: 0x04008A16 RID: 35350
		private Func<float> _getSliderValue;

		// Token: 0x04008A17 RID: 35351
		private Action<float> _slideKeyboardAction;

		// Token: 0x04008A18 RID: 35352
		private Func<float, Color> _blipFunc;

		// Token: 0x04008A19 RID: 35353
		private Action _slideGamepadAction;

		// Token: 0x04008A1A RID: 35354
		private bool _isReallyMouseOvered;

		// Token: 0x04008A1B RID: 35355
		private bool _soundedUsage;

		// Token: 0x04008A1C RID: 35356
		private bool _alreadyHovered;

		// Token: 0x02000AD4 RID: 2772
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06005198 RID: 20888 RVA: 0x00280D88 File Offset: 0x0027EF88
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06005199 RID: 20889 RVA: 0x00280D98 File Offset: 0x0027EF98
			public <>c()
			{
			}

			// Token: 0x0600519A RID: 20890 RVA: 0x000021DB File Offset: 0x000003DB
			internal float <.ctor>b__10_0()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x0600519B RID: 20891 RVA: 0x00280DAC File Offset: 0x0027EFAC
			internal void <.ctor>b__10_1(float s)
			{
			}

			// Token: 0x04008A1D RID: 35357
			public static readonly UIVerticalSlider.<>c <>9;

			// Token: 0x04008A1E RID: 35358
			public static Func<float> <>9__10_0;

			// Token: 0x04008A1F RID: 35359
			public static Action<float> <>9__10_1;
		}
	}
}
