using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameInput;
using Terraria.Localization;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000ACB RID: 2763
	public class UISearchBar : UIElement
	{
		// Token: 0x14000060 RID: 96
		// (add) Token: 0x0600513C RID: 20796 RVA: 0x0027FD4C File Offset: 0x0027DF4C
		// (remove) Token: 0x0600513D RID: 20797 RVA: 0x0027FD74 File Offset: 0x0027DF74
		public event Action<string> OnContentsChanged
		{
			[CompilerGenerated]
			add
			{
				Delegate @delegate = Delegate.Combine(this.OnContentsChanged, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = Delegate.Remove(this.OnContentsChanged, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
		}

		// Token: 0x14000061 RID: 97
		// (add) Token: 0x0600513E RID: 20798 RVA: 0x0027FD9C File Offset: 0x0027DF9C
		// (remove) Token: 0x0600513F RID: 20799 RVA: 0x0027FDC0 File Offset: 0x0027DFC0
		public event Action OnStartTakingInput
		{
			[CompilerGenerated]
			add
			{
				if (Delegate.Combine(this.OnStartTakingInput, value) != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (Delegate.Remove(this.OnStartTakingInput, value) != null)
				{
				}
			}
		}

		// Token: 0x14000062 RID: 98
		// (add) Token: 0x06005140 RID: 20800 RVA: 0x0027FDE4 File Offset: 0x0027DFE4
		// (remove) Token: 0x06005141 RID: 20801 RVA: 0x0027FE08 File Offset: 0x0027E008
		public event Action OnEndTakingInput
		{
			[CompilerGenerated]
			add
			{
				if (Delegate.Combine(this.OnEndTakingInput, value) != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (Delegate.Remove(this.OnEndTakingInput, value) != null)
				{
				}
			}
		}

		// Token: 0x14000063 RID: 99
		// (add) Token: 0x06005142 RID: 20802 RVA: 0x0027FE2C File Offset: 0x0027E02C
		// (remove) Token: 0x06005143 RID: 20803 RVA: 0x0027FE50 File Offset: 0x0027E050
		public event Action OnCanceledTakingInput
		{
			[CompilerGenerated]
			add
			{
				if (Delegate.Combine(this.OnCanceledTakingInput, value) != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (Delegate.Remove(this.OnCanceledTakingInput, value) != null)
				{
				}
			}
		}

		// Token: 0x14000064 RID: 100
		// (add) Token: 0x06005144 RID: 20804 RVA: 0x0027FE74 File Offset: 0x0027E074
		// (remove) Token: 0x06005145 RID: 20805 RVA: 0x0027FE98 File Offset: 0x0027E098
		public event Action OnNeedingVirtualKeyboard
		{
			[CompilerGenerated]
			add
			{
				if (Delegate.Combine(this.OnNeedingVirtualKeyboard, value) != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (Delegate.Remove(this.OnNeedingVirtualKeyboard, value) != null)
				{
				}
			}
		}

		// Token: 0x170008CB RID: 2251
		// (get) Token: 0x06005146 RID: 20806 RVA: 0x0027FEBC File Offset: 0x0027E0BC
		public bool HasContents
		{
			get
			{
				return string.IsNullOrWhiteSpace(this.actualContents);
			}
		}

		// Token: 0x170008CC RID: 2252
		// (get) Token: 0x06005147 RID: 20807 RVA: 0x0027FED4 File Offset: 0x0027E0D4
		public bool IsWritingText
		{
			get
			{
				return this.isWritingText;
			}
		}

		// Token: 0x06005148 RID: 20808 RVA: 0x0027FEE8 File Offset: 0x0027E0E8
		public UISearchBar(LocalizedText emptyContentText, float scale)
		{
			if (!true)
			{
			}
			base..ctor();
			this._textToShowWhenEmpty = emptyContentText;
			this.HAlign = 0f;
			base.Append(this);
			this._text = this;
		}

		// Token: 0x06005149 RID: 20809 RVA: 0x0027FF20 File Offset: 0x0027E120
		public void SetContents(string contents, bool forced = false)
		{
			bool flag = this.actualContents == contents;
			this.actualContents = contents;
			bool flag2 = string.IsNullOrEmpty(contents);
			UITextBox text = this._text;
			LocalizedText textToShowWhenEmpty = this._textToShowWhenEmpty;
			UITextBox text2 = this._text;
			float textScale = this._textScale;
			string <Value>k__BackingField = textToShowWhenEmpty.<Value>k__BackingField;
		}

		// Token: 0x0600514A RID: 20810 RVA: 0x0027FFA8 File Offset: 0x0027E1A8
		public void TrimDisplayIfOverElementDimensions(int padding)
		{
			float width = this._dimensions.Width;
			float x = this._dimensions.X;
			float y = this._dimensions.Y;
			float height = this._dimensions.Height;
			UITextBox text = this._text;
			float x2 = text._dimensions.X;
			float y2 = text._dimensions.Y;
			UITextBox text2 = this._text;
			float pixels = text2.MinWidth.Pixels;
			float pixels2 = text2.MinHeight.Pixels;
			int stringLength = this._text.Text._stringLength;
			string text3 = this._text.Text;
			int stringLength2 = this._text.Text._stringLength;
			UITextBox text4 = this._text;
			float x3 = text4._dimensions.X;
			float y3 = text4._dimensions.Y;
			UITextBox text5 = this._text;
			float pixels3 = text5.MinWidth.Pixels;
			float pixels4 = text5.MinHeight.Pixels;
			string text6 = this._text.Text;
			this.actualContents = text6;
		}

		// Token: 0x0600514B RID: 20811 RVA: 0x002800BC File Offset: 0x0027E2BC
		public override void LeftMouseDown(UIMouseEvent evt)
		{
			base.LeftMouseDown(evt);
		}

		// Token: 0x0600514C RID: 20812 RVA: 0x002800D0 File Offset: 0x0027E2D0
		public override void MouseOver(UIMouseEvent evt)
		{
			base.MouseOver(evt);
		}

		// Token: 0x0600514D RID: 20813 RVA: 0x002800E4 File Offset: 0x0027E2E4
		public override void Update(GameTime gameTime)
		{
			if (!this.isWritingText)
			{
				base.Update(gameTime);
				return;
			}
			bool showGamepadHints = PlayerInput.SettingsForUI.ShowGamepadHints;
			Action onNeedingVirtualKeyboard = this.OnNeedingVirtualKeyboard;
			if (onNeedingVirtualKeyboard != null)
			{
				IntPtr invoke_impl = onNeedingVirtualKeyboard.invoke_impl;
				IntPtr method_code = onNeedingVirtualKeyboard.method_code;
				IntPtr method = onNeedingVirtualKeyboard.method;
				return;
			}
		}

		// Token: 0x0600514E RID: 20814 RVA: 0x00280134 File Offset: 0x0027E334
		private bool NeedsVirtualkeyboard()
		{
			return PlayerInput.SettingsForUI.ShowGamepadHints;
		}

		// Token: 0x0600514F RID: 20815 RVA: 0x00280148 File Offset: 0x0027E348
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			base.DrawSelf(spriteBatch);
			bool flag = this.isWritingText;
			if (flag)
			{
				if (!flag)
				{
				}
				if (!flag)
				{
				}
				int screenWidth = Main.screenWidth;
				float x = this._text._dimensions.X;
				Rectangle rectangle;
				int bottom = rectangle.Bottom;
				string text = this.actualContents;
				this.ToggleTakingText();
				long num = 0L;
				string text2;
				this.SetContents(text2, num != 0L);
				int screenWidth2 = Main.screenWidth;
				UITextBox text3 = this._text;
				float x2 = text3._dimensions.X;
				Rectangle rectangle2;
				int bottom2 = rectangle2.Bottom;
			}
		}

		// Token: 0x06005150 RID: 20816 RVA: 0x0028020C File Offset: 0x0027E40C
		public void ToggleTakingText()
		{
			for (;;)
			{
				bool flag = this.isWritingText;
				UITextBox text = this._text;
				this.isWritingText = flag;
				text.ShowInputTicker = flag;
				if (!flag)
				{
				}
				Main.clrInput();
				if (this.isWritingText)
				{
					break;
				}
				if (this.OnEndTakingInput == null)
				{
					return;
				}
			}
			Action onStartTakingInput = this.OnStartTakingInput;
			if (onStartTakingInput != null)
			{
				IntPtr invoke_impl = onStartTakingInput.invoke_impl;
				IntPtr method_code = onStartTakingInput.method_code;
				IntPtr method = onStartTakingInput.method;
				return;
			}
		}

		// Token: 0x040089DA RID: 35290
		private readonly LocalizedText _textToShowWhenEmpty;

		// Token: 0x040089DB RID: 35291
		private UITextBox _text;

		// Token: 0x040089DC RID: 35292
		private string actualContents;

		// Token: 0x040089DD RID: 35293
		private float _textScale;

		// Token: 0x040089DE RID: 35294
		private bool isWritingText;

		// Token: 0x040089DF RID: 35295
		[CompilerGenerated]
		private Action<string> OnContentsChanged;

		// Token: 0x040089E0 RID: 35296
		[CompilerGenerated]
		private Action OnStartTakingInput;

		// Token: 0x040089E1 RID: 35297
		[CompilerGenerated]
		private Action OnEndTakingInput;

		// Token: 0x040089E2 RID: 35298
		[CompilerGenerated]
		private Action OnCanceledTakingInput;

		// Token: 0x040089E3 RID: 35299
		[CompilerGenerated]
		private Action OnNeedingVirtualKeyboard;
	}
}
