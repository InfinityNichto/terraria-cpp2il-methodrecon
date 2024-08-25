using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameInput;
using Terraria.Localization;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000AAB RID: 2731
	public class UIColoredSlider : UISliderBase
	{
		// Token: 0x06005078 RID: 20600 RVA: 0x0027D578 File Offset: 0x0027B778
		public UIColoredSlider(LocalizedText textKey, Func<float> getStatus, Action<float> setStatusKeyboard, Action setStatusGamepad, Func<float, Color> blipColorFunction, Color color)
		{
			int num = 1;
			base..ctor();
			num.m_value = color;
			this._textKey = textKey;
			if (getStatus == null)
			{
				if (num == 0)
				{
				}
				if (getStatus != null || num == 0)
				{
				}
			}
			if (setStatusKeyboard != null || setStatusKeyboard == null)
			{
			}
			if (blipColorFunction != null || blipColorFunction == null)
			{
			}
			this._slideGamepadAction = setStatusGamepad;
		}

		// Token: 0x06005079 RID: 20601 RVA: 0x0027D5C0 File Offset: 0x0027B7C0
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			bool mouseLeft = Main.mouseLeft;
			int usageLevel = base.GetUsageLevel();
			base.DrawSelf(spriteBatch);
			float x = this._dimensions.X;
			float y = this._dimensions.Y;
			float width = this._dimensions.Width;
			bool <IsMouseHovering>k__BackingField = this.<IsMouseHovering>k__BackingField;
			if (!<IsMouseHovering>k__BackingField)
			{
			}
			if (<IsMouseHovering>k__BackingField)
			{
				return;
			}
			IntPtr invoke_impl;
			if (500 != 0)
			{
				if (500 == 0)
				{
				}
				Func<float> getStatusTextAct = this._getStatusTextAct;
				Func<float, Color> blipFunc = this._blipFunc;
				bool mouseLeft2 = PlayerInput.Triggers.Current.MouseLeft;
				bool usingGamepad = PlayerInput.UsingGamepad;
				if (this._isReallyMouseOvered)
				{
					Action slideGamepadAction = this._slideGamepadAction;
					invoke_impl = slideGamepadAction.invoke_impl;
					IntPtr method_code = slideGamepadAction.method_code;
					IntPtr method = slideGamepadAction.method;
				}
				return;
			}
			while (invoke_impl != 0)
			{
			}
		}

		// Token: 0x0600507A RID: 20602 RVA: 0x0027D6A4 File Offset: 0x0027B8A4
		private float DrawValueBar(SpriteBatch sb, Vector2 drawPosition, float drawScale, float sliderPosition, int lockMode, [Out] bool wasInBar, Func<float, Color> blipColorFunc)
		{
			/*
An exception occurred when decompiling this method (0600507A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.GameContent.UI.Elements.UIColoredSlider::DrawValueBar(Microsoft.Xna.Framework.Graphics.SpriteBatch,Microsoft.Xna.Framework.Vector2,System.Single,System.Single,System.Int32,System.Boolean,System.Func`2<System.Single,Microsoft.Xna.Framework.Graphics.Color>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0055:
	stloc:int32(var_17_5D, callgetter:int32(Main::get_mouseX))
	stloc:int32(var_19_67, callgetter:int32(Main::get_mouseX))
	stloc:int32(var_21_71, callgetter:int32(Main::get_mouseX))
	stfld:int32(int32::m_value, ldloc:int32[exp:int32&](var_5_1B), ldloc:int32(var_9_32))
	stloc:int32(var_23_84, callgetter:int32(Main::get_mouseX))
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

		// Token: 0x0400893C RID: 35132
		private Color _color;

		// Token: 0x0400893D RID: 35133
		private LocalizedText _textKey;

		// Token: 0x0400893E RID: 35134
		private Func<float> _getStatusTextAct;

		// Token: 0x0400893F RID: 35135
		private Action<float> _slideKeyboardAction;

		// Token: 0x04008940 RID: 35136
		private Func<float, Color> _blipFunc;

		// Token: 0x04008941 RID: 35137
		private Action _slideGamepadAction;

		// Token: 0x04008942 RID: 35138
		private const bool BOTHER_WITH_TEXT = false;

		// Token: 0x04008943 RID: 35139
		private bool _isReallyMouseOvered;

		// Token: 0x04008944 RID: 35140
		private bool _alreadyHovered;

		// Token: 0x04008945 RID: 35141
		private bool _soundedUsage;

		// Token: 0x02000AAC RID: 2732
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600507B RID: 20603 RVA: 0x0027D738 File Offset: 0x0027B938
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x0600507C RID: 20604 RVA: 0x0027D748 File Offset: 0x0027B948
			public <>c()
			{
			}

			// Token: 0x0600507D RID: 20605 RVA: 0x000021DB File Offset: 0x000003DB
			internal float <.ctor>b__10_0()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x0600507E RID: 20606 RVA: 0x0027D75C File Offset: 0x0027B95C
			internal void <.ctor>b__10_1(float s)
			{
			}

			// Token: 0x0600507F RID: 20607 RVA: 0x0027D76C File Offset: 0x0027B96C
			internal Color <.ctor>b__10_2(float s)
			{
				if (!true)
				{
				}
				return 1;
			}

			// Token: 0x04008946 RID: 35142
			public static readonly UIColoredSlider.<>c <>9;

			// Token: 0x04008947 RID: 35143
			public static Func<float> <>9__10_0;

			// Token: 0x04008948 RID: 35144
			public static Action<float> <>9__10_1;

			// Token: 0x04008949 RID: 35145
			public static Func<float, Color> <>9__10_2;
		}
	}
}
