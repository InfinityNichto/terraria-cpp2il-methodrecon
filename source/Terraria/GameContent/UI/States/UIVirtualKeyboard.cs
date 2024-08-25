using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.GameContent.UI.Elements;
using Terraria.GameInput;
using Terraria.Localization;
using Terraria.UI;

namespace Terraria.GameContent.UI.States
{
	// Token: 0x02000A77 RID: 2679
	public class UIVirtualKeyboard : UIState
	{
		// Token: 0x170008A9 RID: 2217
		// (get) Token: 0x06004F19 RID: 20249 RVA: 0x00278E68 File Offset: 0x00277068
		// (set) Token: 0x06004F1A RID: 20250 RVA: 0x00278E80 File Offset: 0x00277080
		public string Text
		{
			get
			{
				return this._textBox.Text;
			}
			set
			{
			}
		}

		// Token: 0x170008AA RID: 2218
		// (get) Token: 0x06004F1B RID: 20251 RVA: 0x00278E90 File Offset: 0x00277090
		// (set) Token: 0x06004F1C RID: 20252 RVA: 0x00278EA4 File Offset: 0x002770A4
		public bool HideContents
		{
			get
			{
				/*
An exception occurred when decompiling this method (06004F1B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.UI.States.UIVirtualKeyboard::get_HideContents()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:UITextBox(var_0_06, ldfld:UITextBox(UIVirtualKeyboard::_textBox, ldloc:UIVirtualKeyboard(this)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
			set
			{
				UITextBox textBox = this._textBox;
			}
		}

		// Token: 0x06004F1D RID: 20253 RVA: 0x00278EB8 File Offset: 0x002770B8
		public UIVirtualKeyboard(string labelText, string startingText, UIVirtualKeyboard.KeyboardSubmitEvent submitAction, Action cancelAction, int inputMode = 0, bool allowEmpty = false)
		{
			int num = 1;
			this._internalBorderColor = num;
			if (num == 0)
			{
			}
			this._internalBorderColorSelected = num;
			base..ctor();
			this._keyboardContext = inputMode;
			if (num == 0)
			{
				int keyboardContext = this._keyboardContext;
			}
			num.m_value = this;
			this._submitAction = submitAction;
		}

		// Token: 0x06004F1E RID: 20254 RVA: 0x00279290 File Offset: 0x00277490
		public void SetMaxInputLength(int length)
		{
			this._textBox._maxLength = length;
		}

		// Token: 0x06004F1F RID: 20255 RVA: 0x002792AC File Offset: 0x002774AC
		private void BuildSpaceBarArea(UIPanel mainPanel)
		{
			bool flag = this.CanRestore();
			LocalizedText localizedText;
			UITextPanel<object> uitextPanel = this.CreateKeyboardButton(localizedText, 6, 4, 2, true);
		}

		// Token: 0x06004F20 RID: 20256 RVA: 0x002792CC File Offset: 0x002774CC
		private void PressSpace()
		{
			if (this.CustomTextValidationForUpdate != null)
			{
				string text = this.Text + " ";
			}
			this._textBox.Write(" ");
			this.ValidateText();
		}

		// Token: 0x06004F21 RID: 20257 RVA: 0x0027930C File Offset: 0x0027750C
		private bool CanRestore()
		{
			bool edittingSign = this._edittingSign;
			if (!edittingSign || !edittingSign)
			{
			}
			bool edittingChest = this._edittingChest;
			if (!edittingChest || !edittingChest)
			{
				return;
			}
		}

		// Token: 0x06004F22 RID: 20258 RVA: 0x00279334 File Offset: 0x00277534
		private void TypeText(UIMouseEvent evt, UIElement listeningElement)
		{
			if (listeningElement != null)
			{
			}
			string text2;
			if (this.CustomTextValidationForUpdate != null)
			{
				string text = this.Text + text2;
			}
			int stringLength = this.Text._stringLength;
			this._textBox.Write(text2);
			this.ValidateText();
			if (stringLength != 0)
			{
				return;
			}
			int stringLength2 = this.Text._stringLength;
			UIVirtualKeyboard.KeyState keyState = this._keyState;
		}

		// Token: 0x06004F23 RID: 20259 RVA: 0x002793A0 File Offset: 0x002775A0
		public void SetKeyState(UIVirtualKeyboard.KeyState keyState)
		{
			UIVirtualKeyboard.KeyState keyState2 = this._keyState;
		}

		// Token: 0x06004F24 RID: 20260 RVA: 0x00279428 File Offset: 0x00277628
		private void ValidateText()
		{
			int num = 1;
			bool flag = this.TextIsValidForSubmit();
			this._canSubmit = num != 0;
			UITextPanel<LocalizedText> submitButton = this._submitButton;
			if (num == 0)
			{
			}
			UITextPanel<LocalizedText> submitButton2 = this._submitButton;
			if (num != 0)
			{
				return;
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x06004F25 RID: 20261 RVA: 0x00279494 File Offset: 0x00277694
		private bool TextIsValidForSubmit()
		{
			Func<string, bool> customTextValidationForUpdate = this.CustomTextValidationForUpdate;
			string text = this.Text;
			if (customTextValidationForUpdate != null)
			{
			}
			int stringLength = text.Trim()._stringLength;
			if (this._edittingSign || this._edittingChest)
			{
				return true;
			}
			bool allowEmpty = this._allowEmpty;
			return true;
		}

		// Token: 0x06004F26 RID: 20262 RVA: 0x002794D8 File Offset: 0x002776D8
		private void StyleKey<T>(UITextPanel<T> button, bool external = false)
		{
			if (!true)
			{
			}
			Color internalBorderColor = this._internalBorderColor;
		}

		// Token: 0x06004F27 RID: 20263 RVA: 0x002794F0 File Offset: 0x002776F0
		private UITextPanel<object> CreateKeyboardButton(object text, int x, int y, int width = 1, bool style = true)
		{
			UITextPanel<object>[] keyList = this._keyList;
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06004F28 RID: 20264 RVA: 0x0027950C File Offset: 0x0027770C
		private bool ShouldShowKeyboard()
		{
			return PlayerInput.SettingsForUI.ShowGamepadHints;
		}

		// Token: 0x06004F29 RID: 20265 RVA: 0x00279520 File Offset: 0x00277720
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			if (!true)
			{
			}
			bool gameMenu = Main.gameMenu;
			bool showGamepadHints = PlayerInput.SettingsForUI.ShowGamepadHints;
			this.outerLayer2.Remove();
			List<UIElement> elements = this.Elements;
			UIElement uielement = this.outerLayer1;
			UIElement uielement2 = this.outerLayer1;
			base.Append(uielement2);
			this.outerLayer1.Activate();
			this.outerLayer2.Deactivate();
			float labelHeight = this._labelHeight;
			UITextBox textBox = this._textBox;
			float textBoxHeight = this._textBoxHeight;
			textBox.Top = textBoxHeight;
			this._label.Top.Pixels = labelHeight;
			UIText label = this._label;
		}

		// Token: 0x06004F2A RID: 20266 RVA: 0x00279834 File Offset: 0x00277A34
		private bool TryEscapingMenu()
		{
			if (this.CustomEscapeAttempt != null)
			{
			}
			bool edittingSign = this._edittingSign;
			if (edittingSign)
			{
				if (!edittingSign)
				{
				}
				Main.InputTextSignCancel();
			}
			if (this._edittingChest)
			{
				ChestUI.RenameChestCancel();
			}
			bool gameMenu = Main.gameMenu;
			if (this._cancelAction != null)
			{
				UIVirtualKeyboard.Cancel();
				return false;
			}
			IngameFancyUI.Close();
			return true;
		}

		// Token: 0x06004F2B RID: 20267 RVA: 0x00279890 File Offset: 0x00277A90
		private void UpdateOffsetDown()
		{
			int num = 1;
			UITextBox textBox = this._textBox;
			if (num == 0)
			{
			}
			int lastOffsetDown = this._lastOffsetDown;
			int lastOffsetDown2 = this._lastOffsetDown;
			this._lastOffsetDown = lastOffsetDown2;
		}

		// Token: 0x06004F2C RID: 20268 RVA: 0x002798C0 File Offset: 0x00277AC0
		public override void OnActivate()
		{
		}

		// Token: 0x06004F2D RID: 20269 RVA: 0x002798D0 File Offset: 0x00277AD0
		public override void OnDeactivate()
		{
			base.OnDeactivate();
			if (!true)
			{
			}
		}

		// Token: 0x06004F2E RID: 20270 RVA: 0x002798E8 File Offset: 0x00277AE8
		public static void CycleSymbols()
		{
			if (!true)
			{
			}
			if (true)
			{
				return;
			}
		}

		// Token: 0x06004F2F RID: 20271 RVA: 0x00279900 File Offset: 0x00277B00
		public static void BackSpace()
		{
			if (!true)
			{
			}
			if (true)
			{
				if (!true)
				{
				}
				return;
			}
		}

		// Token: 0x170008AB RID: 2219
		// (get) Token: 0x06004F30 RID: 20272 RVA: 0x00279918 File Offset: 0x00277B18
		public static bool CanSubmit
		{
			get
			{
				if (!true)
				{
				}
				if (true)
				{
					return;
				}
			}
		}

		// Token: 0x06004F31 RID: 20273 RVA: 0x0027992C File Offset: 0x00277B2C
		public static void Submit()
		{
			if (!true)
			{
			}
			if (true)
			{
				return;
			}
		}

		// Token: 0x06004F32 RID: 20274 RVA: 0x00279940 File Offset: 0x00277B40
		private void InternalSubmit()
		{
			string text = this.Text.Trim();
			bool flag = this.TextIsValidForSubmit();
			UIVirtualKeyboard.KeyboardSubmitEvent submitAction = this._submitAction;
			IntPtr invoke_impl = submitAction.invoke_impl;
			IntPtr method_code = submitAction.method_code;
			IntPtr method = submitAction.method;
		}

		// Token: 0x06004F33 RID: 20275 RVA: 0x00279980 File Offset: 0x00277B80
		public static void Cancel()
		{
			if (!true)
			{
			}
			if (true)
			{
				if (!true)
				{
				}
				return;
			}
		}

		// Token: 0x06004F34 RID: 20276 RVA: 0x00279998 File Offset: 0x00277B98
		public static void Write(string text)
		{
			if (!true)
			{
			}
			if (true)
			{
				if (!true)
				{
				}
				string text2;
				if (text2._stringLength == 0)
				{
					string text3;
					if (text3._stringLength == 0)
					{
					}
					return;
				}
			}
		}

		// Token: 0x06004F35 RID: 20277 RVA: 0x002799C0 File Offset: 0x00277BC0
		public static void CursorLeft()
		{
			if (!true)
			{
			}
			if (true)
			{
				if (!true)
				{
				}
				return;
			}
		}

		// Token: 0x06004F36 RID: 20278 RVA: 0x002799D8 File Offset: 0x00277BD8
		public static void CursorRight()
		{
			if (!true)
			{
			}
			if (true)
			{
				if (!true)
				{
				}
				return;
			}
		}

		// Token: 0x06004F37 RID: 20279 RVA: 0x002799F0 File Offset: 0x00277BF0
		public static bool CanDisplay(int keyboardContext)
		{
			int screenHeight = Main.screenHeight;
			return true;
		}

		// Token: 0x170008AC RID: 2220
		// (get) Token: 0x06004F38 RID: 20280 RVA: 0x00279A08 File Offset: 0x00277C08
		public static int KeyboardContext
		{
			get
			{
				/*
An exception occurred when decompiling this method (06004F38)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.GameContent.UI.States.UIVirtualKeyboard::get_KeyboardContext()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	brtrue(IL_0000, logicnot:bool(ldc.i4:bool(1)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
		}

		// Token: 0x06004F39 RID: 20281 RVA: 0x00279A1C File Offset: 0x00277C1C
		public static void CacheCanceledInput(int cacheMode)
		{
			string npcChatText = Main.npcChatText;
		}

		// Token: 0x06004F3A RID: 20282 RVA: 0x00279A34 File Offset: 0x00277C34
		private void RestoreCanceledInput(int cacheMode)
		{
			if (!true)
			{
			}
			string npcChatText = Main.npcChatText;
			this.Text = npcChatText;
		}

		// Token: 0x06004F3B RID: 20283 RVA: 0x00279A54 File Offset: 0x00277C54
		private void CopyTextToSign()
		{
			bool edittingSign = this._edittingSign;
			if (edittingSign)
			{
				if (!edittingSign)
				{
				}
				int myPlayer = Main.myPlayer;
				if (!edittingSign)
				{
				}
				if (edittingSign)
				{
					Main.npcChatText = this.Text;
					return;
				}
			}
		}

		// Token: 0x06004F3C RID: 20284 RVA: 0x00279A88 File Offset: 0x00277C88
		private void CopyTextToChest()
		{
			if (this._edittingChest)
			{
				Main.npcChatText = this.Text;
				return;
			}
		}

		// Token: 0x06004F3D RID: 20285 RVA: 0x00279AAC File Offset: 0x00277CAC
		private void FadedMouseOver(UIMouseEvent evt, UIElement listeningElement)
		{
			UIElement target = evt.Target;
			if (target != null)
			{
			}
			if (evt.Target != null)
			{
			}
		}

		// Token: 0x06004F3E RID: 20286 RVA: 0x00279AE8 File Offset: 0x00277CE8
		private void FadedMouseOut(UIMouseEvent evt, UIElement listeningElement)
		{
			int num = 1;
			UIElement target = evt.Target;
			if (num == 0)
			{
			}
			if (target != null)
			{
			}
			if (evt.Target != null)
			{
			}
		}

		// Token: 0x06004F3F RID: 20287 RVA: 0x00279B20 File Offset: 0x00277D20
		// Note: this type is marked as 'beforefieldinit'.
		static UIVirtualKeyboard()
		{
		}

		// Token: 0x06004F40 RID: 20288 RVA: 0x00279B30 File Offset: 0x00277D30
		[CompilerGenerated]
		private void <.ctor>b__50_0(UIMouseEvent evt, UIElement listeningElement)
		{
			UITextPanel<object> shiftButton = this._shiftButton;
			Color internalBorderColorSelected = this._internalBorderColorSelected;
			UIVirtualKeyboard.KeyState keyState = this._keyState;
			UITextPanel<object> shiftButton2 = this._shiftButton;
		}

		// Token: 0x06004F41 RID: 20289 RVA: 0x00279B5C File Offset: 0x00277D5C
		[CompilerGenerated]
		private void <.ctor>b__50_1(UIMouseEvent evt, UIElement listeningElement)
		{
			UITextPanel<object> shiftButton = this._shiftButton;
			Color internalBorderColor = this._internalBorderColor;
			if (!true)
			{
			}
			UIVirtualKeyboard.KeyState keyState = this._keyState;
			UITextPanel<object> shiftButton2 = this._shiftButton;
			if (keyState == UIVirtualKeyboard.KeyState.Default)
			{
			}
		}

		// Token: 0x06004F42 RID: 20290 RVA: 0x00279B8C File Offset: 0x00277D8C
		[CompilerGenerated]
		private void <.ctor>b__50_2(UIMouseEvent evt, UIElement listeningElement)
		{
			UIVirtualKeyboard.KeyState keyState = this._keyState;
		}

		// Token: 0x06004F43 RID: 20291 RVA: 0x00279BA0 File Offset: 0x00277DA0
		[CompilerGenerated]
		private void <.ctor>b__50_3(UIMouseEvent evt, UIElement listeningElement)
		{
			UITextPanel<object> symbolButton = this._symbolButton;
			Color internalBorderColorSelected = this._internalBorderColorSelected;
			UIVirtualKeyboard.KeyState keyState = this._keyState;
			UITextPanel<object> symbolButton2 = this._symbolButton;
		}

		// Token: 0x06004F44 RID: 20292 RVA: 0x00279BCC File Offset: 0x00277DCC
		[CompilerGenerated]
		private void <.ctor>b__50_4(UIMouseEvent evt, UIElement listeningElement)
		{
			UITextPanel<object> symbolButton = this._symbolButton;
			Color internalBorderColor = this._internalBorderColor;
			if (!true)
			{
			}
			UIVirtualKeyboard.KeyState keyState = this._keyState;
			UITextPanel<object> symbolButton2 = this._symbolButton;
			if (keyState == UIVirtualKeyboard.KeyState.Default)
			{
			}
		}

		// Token: 0x06004F45 RID: 20293 RVA: 0x00279BFC File Offset: 0x00277DFC
		[CompilerGenerated]
		private void <.ctor>b__50_5(UIMouseEvent evt, UIElement listeningElement)
		{
			UIVirtualKeyboard.KeyState keyState = this._keyState;
		}

		// Token: 0x06004F46 RID: 20294 RVA: 0x00279C10 File Offset: 0x00277E10
		[CompilerGenerated]
		private void <.ctor>b__50_6(UIMouseEvent evt, UIElement listeningElement)
		{
			this.ValidateText();
		}

		// Token: 0x06004F47 RID: 20295 RVA: 0x00279C24 File Offset: 0x00277E24
		[CompilerGenerated]
		private void <.ctor>b__50_7(UIMouseEvent evt, UIElement listeningElement)
		{
			this.ValidateText();
		}

		// Token: 0x06004F48 RID: 20296 RVA: 0x00279C38 File Offset: 0x00277E38
		[CompilerGenerated]
		private void <.ctor>b__50_9(UIMouseEvent evt, UIElement listeningElement)
		{
			Action cancelAction = this._cancelAction;
			IntPtr invoke_impl = cancelAction.invoke_impl;
			IntPtr method_code = cancelAction.method_code;
			IntPtr method = cancelAction.method;
		}

		// Token: 0x06004F49 RID: 20297 RVA: 0x00279C64 File Offset: 0x00277E64
		[CompilerGenerated]
		private void <.ctor>b__50_12(UIMouseEvent evt, UIElement listeningElement)
		{
			this.ValidateText();
		}

		// Token: 0x06004F4A RID: 20298 RVA: 0x00279C78 File Offset: 0x00277E78
		[CompilerGenerated]
		private void <.ctor>b__50_13(UIMouseEvent evt, UIElement listeningElement)
		{
			this.ValidateText();
		}

		// Token: 0x06004F4B RID: 20299 RVA: 0x00279C8C File Offset: 0x00277E8C
		[CompilerGenerated]
		private void <.ctor>b__50_14(UIMouseEvent evt, UIElement listeningElement)
		{
			bool flag = this.TextIsValidForSubmit();
			UIVirtualKeyboard.KeyboardSubmitEvent submitAction = this._submitAction;
			string text2;
			string text = text2.Trim();
			IntPtr method_code = submitAction.method_code;
			IntPtr invoke_impl = submitAction.invoke_impl;
			IntPtr method = submitAction.method;
		}

		// Token: 0x06004F4C RID: 20300 RVA: 0x00279CC8 File Offset: 0x00277EC8
		[CompilerGenerated]
		private void <.ctor>b__50_17(UIMouseEvent evt, UIElement listeningElement)
		{
			Action cancelAction = this._cancelAction;
			IntPtr invoke_impl = cancelAction.invoke_impl;
			IntPtr method_code = cancelAction.method_code;
			IntPtr method = cancelAction.method;
		}

		// Token: 0x06004F4D RID: 20301 RVA: 0x00279CF4 File Offset: 0x00277EF4
		[CompilerGenerated]
		private void <.ctor>b__50_18(UIMouseEvent evt, UIElement listeningElement)
		{
			this._textBox.Backspace();
			this.ValidateText();
		}

		// Token: 0x0400880F RID: 34831
		private static UIVirtualKeyboard _currentInstance;

		// Token: 0x04008810 RID: 34832
		private static string _cancelCacheSign;

		// Token: 0x04008811 RID: 34833
		private static string _cancelCacheChest;

		// Token: 0x04008812 RID: 34834
		private const string DEFAULT_KEYS = "1234567890qwertyuiopasdfghjkl'zxcvbnm,.?";

		// Token: 0x04008813 RID: 34835
		private const string SHIFT_KEYS = "1234567890QWERTYUIOPASDFGHJKL'ZXCVBNM,.?";

		// Token: 0x04008814 RID: 34836
		private const string SYMBOL_KEYS = "1234567890!@#$%^&*()-_+=/\\{}[]<>;:\"`|~£¥";

		// Token: 0x04008815 RID: 34837
		private const float KEY_SPACING = 4f;

		// Token: 0x04008816 RID: 34838
		private const float KEY_WIDTH = 48f;

		// Token: 0x04008817 RID: 34839
		private const float KEY_HEIGHT = 37f;

		// Token: 0x04008818 RID: 34840
		private UITextPanel<object>[] _keyList;

		// Token: 0x04008819 RID: 34841
		private UITextPanel<object> _shiftButton;

		// Token: 0x0400881A RID: 34842
		private UITextPanel<object> _symbolButton;

		// Token: 0x0400881B RID: 34843
		private UITextBox _textBox;

		// Token: 0x0400881C RID: 34844
		private UITextPanel<LocalizedText> _submitButton;

		// Token: 0x0400881D RID: 34845
		private UITextPanel<LocalizedText> _cancelButton;

		// Token: 0x0400881E RID: 34846
		private UIText _label;

		// Token: 0x0400881F RID: 34847
		private UITextPanel<object> _enterButton;

		// Token: 0x04008820 RID: 34848
		private UITextPanel<object> _spacebarButton;

		// Token: 0x04008821 RID: 34849
		private UITextPanel<object> _restoreButton;

		// Token: 0x04008822 RID: 34850
		private Asset<Texture2D> _textureShift;

		// Token: 0x04008823 RID: 34851
		private Asset<Texture2D> _textureBackspace;

		// Token: 0x04008824 RID: 34852
		private Color _internalBorderColor;

		// Token: 0x04008825 RID: 34853
		private Color _internalBorderColorSelected;

		// Token: 0x04008826 RID: 34854
		private UITextPanel<LocalizedText> _submitButton2;

		// Token: 0x04008827 RID: 34855
		private UITextPanel<LocalizedText> _cancelButton2;

		// Token: 0x04008828 RID: 34856
		private UIElement outerLayer1;

		// Token: 0x04008829 RID: 34857
		private UIElement outerLayer2;

		// Token: 0x0400882A RID: 34858
		private bool _allowEmpty;

		// Token: 0x0400882B RID: 34859
		private UIVirtualKeyboard.KeyState _keyState;

		// Token: 0x0400882C RID: 34860
		private UIVirtualKeyboard.KeyboardSubmitEvent _submitAction;

		// Token: 0x0400882D RID: 34861
		private Action _cancelAction;

		// Token: 0x0400882E RID: 34862
		private int _lastOffsetDown;

		// Token: 0x0400882F RID: 34863
		public static int OffsetDown;

		// Token: 0x04008830 RID: 34864
		public static bool ShouldHideText;

		// Token: 0x04008831 RID: 34865
		private int _keyboardContext;

		// Token: 0x04008832 RID: 34866
		private bool _edittingSign;

		// Token: 0x04008833 RID: 34867
		private bool _edittingChest;

		// Token: 0x04008834 RID: 34868
		private float _textBoxHeight;

		// Token: 0x04008835 RID: 34869
		private float _labelHeight;

		// Token: 0x04008836 RID: 34870
		public Func<string, bool> CustomTextValidationForUpdate;

		// Token: 0x04008837 RID: 34871
		public Func<string, bool> CustomTextValidationForSubmit;

		// Token: 0x04008838 RID: 34872
		public Func<bool> CustomEscapeAttempt;

		// Token: 0x04008839 RID: 34873
		private bool _canSubmit;

		// Token: 0x02000A78 RID: 2680
		public sealed class KeyboardSubmitEvent : MulticastDelegate
		{
			// Token: 0x06004F4E RID: 20302 RVA: 0x00279D14 File Offset: 0x00277F14
			public KeyboardSubmitEvent(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x06004F4F RID: 20303 RVA: 0x00279D68 File Offset: 0x00277F68
			public void Invoke(string text)
			{
				IntPtr method_code = this.method_code;
				IntPtr invoke_impl = this.invoke_impl;
				IntPtr method = this.method;
			}

			// Token: 0x06004F50 RID: 20304 RVA: 0x000021DB File Offset: 0x000003DB
			public IAsyncResult BeginInvoke(string text, AsyncCallback callback, object @object)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06004F51 RID: 20305 RVA: 0x00279D8C File Offset: 0x00277F8C
			public void EndInvoke(IAsyncResult result)
			{
			}
		}

		// Token: 0x02000A79 RID: 2681
		public enum KeyState
		{
			// Token: 0x0400883B RID: 34875
			Default,
			// Token: 0x0400883C RID: 34876
			Symbol,
			// Token: 0x0400883D RID: 34877
			Shift
		}

		// Token: 0x02000A7A RID: 2682
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004F52 RID: 20306 RVA: 0x00279D9C File Offset: 0x00277F9C
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06004F53 RID: 20307 RVA: 0x00279DAC File Offset: 0x00277FAC
			public <>c()
			{
			}

			// Token: 0x06004F54 RID: 20308 RVA: 0x00279DC0 File Offset: 0x00277FC0
			internal void <.ctor>b__50_8(UIMouseEvent evt, UIElement listeningElement)
			{
				if (!true)
				{
				}
				UIVirtualKeyboard.Submit();
			}

			// Token: 0x06004F55 RID: 20309 RVA: 0x00279DD8 File Offset: 0x00277FD8
			internal void <.ctor>b__50_10(UIMouseEvent a, UIElement b)
			{
				if (b != null)
				{
				}
				if (39322 == 0)
				{
				}
			}

			// Token: 0x06004F56 RID: 20310 RVA: 0x00279DF8 File Offset: 0x00277FF8
			internal void <.ctor>b__50_11(UIMouseEvent a, UIElement b)
			{
				if (b != null)
				{
				}
				if (20972 == 0)
				{
				}
			}

			// Token: 0x06004F57 RID: 20311 RVA: 0x00279E18 File Offset: 0x00278018
			internal void <.ctor>b__50_15(UIMouseEvent a, UIElement b)
			{
				if (b != null)
				{
				}
				if (39322 == 0)
				{
				}
			}

			// Token: 0x06004F58 RID: 20312 RVA: 0x00279E38 File Offset: 0x00278038
			internal void <.ctor>b__50_16(UIMouseEvent a, UIElement b)
			{
				if (b != null)
				{
				}
				if (20972 == 0)
				{
				}
			}

			// Token: 0x0400883E RID: 34878
			public static readonly UIVirtualKeyboard.<>c <>9;

			// Token: 0x0400883F RID: 34879
			public static UIElement.MouseEvent <>9__50_8;

			// Token: 0x04008840 RID: 34880
			public static UIElement.MouseEvent <>9__50_10;

			// Token: 0x04008841 RID: 34881
			public static UIElement.MouseEvent <>9__50_11;

			// Token: 0x04008842 RID: 34882
			public static UIElement.MouseEvent <>9__50_15;

			// Token: 0x04008843 RID: 34883
			public static UIElement.MouseEvent <>9__50_16;
		}

		// Token: 0x02000A7B RID: 2683
		[CompilerGenerated]
		private sealed class <>c__DisplayClass52_0
		{
			// Token: 0x06004F59 RID: 20313 RVA: 0x00279E58 File Offset: 0x00278058
			public <>c__DisplayClass52_0()
			{
			}

			// Token: 0x06004F5A RID: 20314 RVA: 0x00279E6C File Offset: 0x0027806C
			internal void <BuildSpaceBarArea>b__0()
			{
				bool flag = this.<>4__this.CanRestore();
				UIVirtualKeyboard uivirtualKeyboard = this.<>4__this;
				bool edittingSign = uivirtualKeyboard._edittingSign;
				LocalizedText text = Language.GetText("UI.SpaceButton");
				UIVirtualKeyboard uivirtualKeyboard2 = this.<>4__this;
				if (!uivirtualKeyboard2._edittingSign)
				{
					bool edittingChest = uivirtualKeyboard2._edittingChest;
				}
				UITextPanel<object> uitextPanel = uivirtualKeyboard.CreateKeyboardButton(text, 2, 4, 43139072, true);
				if (this.<>9__1 == null)
				{
				}
				this.mainPanel.Append(uitextPanel);
				this.<>4__this._spacebarButton = uitextPanel;
				if (edittingSign)
				{
					LocalizedText text2 = Language.GetText("UI.EnterButton");
					if (this.<>9__2 == null)
					{
					}
					UITextPanel<object> uitextPanel2;
					this.mainPanel.Append(uitextPanel2);
					this.<>4__this._enterButton = uitextPanel2;
				}
			}

			// Token: 0x06004F5B RID: 20315 RVA: 0x00279F20 File Offset: 0x00278120
			internal void <BuildSpaceBarArea>b__1(UIMouseEvent evt, UIElement listeningElement)
			{
				this.<>4__this.PressSpace();
			}

			// Token: 0x06004F5C RID: 20316 RVA: 0x00279F38 File Offset: 0x00278138
			internal void <BuildSpaceBarArea>b__2(UIMouseEvent evt, UIElement listeningElement)
			{
				this.<>4__this._textBox.Write("\n");
				this.<>4__this.ValidateText();
			}

			// Token: 0x04008844 RID: 34884
			public UIVirtualKeyboard <>4__this;

			// Token: 0x04008845 RID: 34885
			public UIPanel mainPanel;

			// Token: 0x04008846 RID: 34886
			public Action createTheseTwo;

			// Token: 0x04008847 RID: 34887
			public UIElement.MouseEvent <>9__1;

			// Token: 0x04008848 RID: 34888
			public UIElement.MouseEvent <>9__2;
		}

		// Token: 0x02000A7C RID: 2684
		[CompilerGenerated]
		private sealed class <>c__DisplayClass52_1
		{
			// Token: 0x06004F5D RID: 20317 RVA: 0x00279F68 File Offset: 0x00278168
			public <>c__DisplayClass52_1()
			{
			}

			// Token: 0x06004F5E RID: 20318 RVA: 0x00279F7C File Offset: 0x0027817C
			internal void <BuildSpaceBarArea>b__3(UIMouseEvent evt, UIElement listeningElement)
			{
				this.CS$<>8__locals1.<>4__this.ValidateText();
				this.restoreBar.Remove();
				UIVirtualKeyboard <>4__this = this.CS$<>8__locals1.<>4__this;
				UITextPanel<object> enterButton = <>4__this._enterButton;
				enterButton.Remove();
				UIElement <Parent>k__BackingField = <>4__this.<Parent>k__BackingField;
				enterButton.Remove();
				Action createTheseTwo = this.CS$<>8__locals1.createTheseTwo;
				IntPtr invoke_impl = createTheseTwo.invoke_impl;
				IntPtr method_code = createTheseTwo.method_code;
				IntPtr method = createTheseTwo.method;
			}

			// Token: 0x04008849 RID: 34889
			public UITextPanel<object> restoreBar;

			// Token: 0x0400884A RID: 34890
			public UIVirtualKeyboard.<>c__DisplayClass52_0 CS$<>8__locals1;
		}

		// Token: 0x02000A7D RID: 2685
		[CompilerGenerated]
		private sealed class <>c__DisplayClass60_0<T>
		{
			// Token: 0x06004F5F RID: 20319 RVA: 0x00279FF4 File Offset: 0x002781F4
			public <>c__DisplayClass60_0()
			{
			}

			// Token: 0x06004F60 RID: 20320 RVA: 0x0027A008 File Offset: 0x00278208
			internal void <StyleKey>b__0(UIMouseEvent evt, UIElement listeningElement)
			{
				if (!true)
				{
				}
				if (listeningElement != null)
				{
				}
				if (listeningElement != null)
				{
				}
				if (!this.external)
				{
				}
			}

			// Token: 0x06004F61 RID: 20321 RVA: 0x0027A03C File Offset: 0x0027823C
			internal void <StyleKey>b__1(UIMouseEvent evt, UIElement listeningElement)
			{
				if (!true)
				{
				}
				if (listeningElement != null)
				{
				}
				if (listeningElement != null)
				{
				}
				if (!this.external)
				{
				}
			}

			// Token: 0x0400884B RID: 34891
			public bool external;

			// Token: 0x0400884C RID: 34892
			public UIVirtualKeyboard <>4__this;
		}
	}
}
