using System;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Input
{
	// Token: 0x02000359 RID: 857
	public struct MouseState
	{
		// Token: 0x0600163B RID: 5691 RVA: 0x00061AD8 File Offset: 0x0005FCD8
		public MouseState(int x, int y, int scrollWheel, ButtonState leftButton, ButtonState middleButton, ButtonState rightButton, ButtonState xButton1, ButtonState xButton2)
		{
			this._x = x;
			this._scrollWheelValue = y;
			this._scrollWheelValue = scrollWheel;
			this._rightButton = leftButton;
			this._rightButton = rightButton;
			this._xButton1 = middleButton;
			this._xButton1 = xButton1;
		}

		// Token: 0x0600163C RID: 5692 RVA: 0x00061B1C File Offset: 0x0005FD1C
		public MouseState(int x, int y, int scrollWheel, ButtonState leftButton, ButtonState middleButton, ButtonState rightButton, ButtonState xButton1, ButtonState xButton2, int horizontalScrollWheel)
		{
			this._x = x;
			this._scrollWheelValue = y;
			this._scrollWheelValue = scrollWheel;
			this._rightButton = leftButton;
			this._rightButton = rightButton;
			this._xButton1 = middleButton;
			this._xButton1 = xButton1;
		}

		// Token: 0x0600163D RID: 5693 RVA: 0x00061B60 File Offset: 0x0005FD60
		public static bool operator ==(MouseState left, MouseState right)
		{
			/*
An exception occurred when decompiling this method (0600163D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Microsoft.Xna.Framework.Input.MouseState::op_Equality(Microsoft.Xna.Framework.Input.MouseState,Microsoft.Xna.Framework.Input.MouseState)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(MouseState::_y, ldloc:MouseState[exp:valuetype Microsoft.Xna.Framework.Input.MouseState&](left)))
	stloc:ButtonState(var_1_0D, ldfld:ButtonState(MouseState::_leftButton, ldloc:MouseState[exp:valuetype Microsoft.Xna.Framework.Input.MouseState&](left)))
	stloc:ButtonState(var_2_14, ldfld:ButtonState(MouseState::_middleButton, ldloc:MouseState[exp:valuetype Microsoft.Xna.Framework.Input.MouseState&](left)))
	stloc:ButtonState(var_3_1B, ldfld:ButtonState(MouseState::_rightButton, ldloc:MouseState[exp:valuetype Microsoft.Xna.Framework.Input.MouseState&](left)))
	stloc:int32(var_4_22, ldfld:int32(MouseState::_scrollWheelValue, ldloc:MouseState[exp:valuetype Microsoft.Xna.Framework.Input.MouseState&](left)))
	stloc:int32(var_5_2A, ldfld:int32(MouseState::_horizontalScrollWheelValue, ldloc:MouseState[exp:valuetype Microsoft.Xna.Framework.Input.MouseState&](left)))
	stloc:ButtonState(var_6_32, ldfld:ButtonState(MouseState::_xButton1, ldloc:MouseState[exp:valuetype Microsoft.Xna.Framework.Input.MouseState&](left)))
	stloc:ButtonState(var_7_3A, ldfld:ButtonState(MouseState::_xButton2, ldloc:MouseState[exp:valuetype Microsoft.Xna.Framework.Input.MouseState&](left)))
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

		// Token: 0x0600163E RID: 5694 RVA: 0x00061BAC File Offset: 0x0005FDAC
		public static bool operator !=(MouseState left, MouseState right)
		{
			ButtonState xButton = left._xButton1;
			int horizontalScrollWheelValue = left._horizontalScrollWheelValue;
			int scrollWheelValue = left._scrollWheelValue;
			ButtonState rightButton = left._rightButton;
			int y = left._y;
			ButtonState leftButton = left._leftButton;
			ButtonState middleButton = left._middleButton;
			ButtonState xButton2 = left._xButton2;
			return true;
		}

		// Token: 0x0600163F RID: 5695 RVA: 0x00061BF8 File Offset: 0x0005FDF8
		public override bool Equals(object obj)
		{
			/*
An exception occurred when decompiling this method (0600163F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Microsoft.Xna.Framework.Input.MouseState::Equals(System.Object)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:ButtonState(var_1_0B, ldfld:ButtonState(MouseState::_xButton1, ldloc:valuetype Microsoft.Xna.Framework.Input.MouseState&(this)))
	stloc:int32(var_2_12, ldfld:int32(MouseState::_horizontalScrollWheelValue, ldloc:valuetype Microsoft.Xna.Framework.Input.MouseState&(this)))
	stloc:int32(var_3_19, ldfld:int32(MouseState::_horizontalScrollWheelValue, ldloc:valuetype Microsoft.Xna.Framework.Input.MouseState&(this)))
	stloc:ButtonState(var_4_20, ldfld:ButtonState(MouseState::_rightButton, ldloc:valuetype Microsoft.Xna.Framework.Input.MouseState&(this)))
	stloc:ButtonState(var_5_28, ldfld:ButtonState(MouseState::_xButton1, ldloc:valuetype Microsoft.Xna.Framework.Input.MouseState&(this)))
	stloc:int32(var_6_30, ldfld:int32(MouseState::_scrollWheelValue, ldloc:valuetype Microsoft.Xna.Framework.Input.MouseState&(this)))
	stloc:ButtonState(var_7_38, ldfld:ButtonState(MouseState::_rightButton, ldloc:valuetype Microsoft.Xna.Framework.Input.MouseState&(this)))
	stloc:int32(var_8_40, ldfld:int32(MouseState::_x, ldloc:valuetype Microsoft.Xna.Framework.Input.MouseState&(this)))
	stloc:int32(var_9_48, ldfld:int32(MouseState::_scrollWheelValue, ldloc:valuetype Microsoft.Xna.Framework.Input.MouseState&(this)))
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

		// Token: 0x06001640 RID: 5696 RVA: 0x00061C54 File Offset: 0x0005FE54
		public override int GetHashCode()
		{
			/*
An exception occurred when decompiling this method (06001640)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Microsoft.Xna.Framework.Input.MouseState::GetHashCode()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(MouseState::_x, ldloc:valuetype Microsoft.Xna.Framework.Input.MouseState&(this)))
	stloc:int32(var_1_0D, ldfld:int32(MouseState::_scrollWheelValue, ldloc:valuetype Microsoft.Xna.Framework.Input.MouseState&(this)))
	stloc:int32(var_2_14, ldfld:int32(MouseState::_scrollWheelValue, ldloc:valuetype Microsoft.Xna.Framework.Input.MouseState&(this)))
	stloc:ButtonState(var_3_1B, ldfld:ButtonState(MouseState::_rightButton, ldloc:valuetype Microsoft.Xna.Framework.Input.MouseState&(this)))
	stloc:ButtonState(var_4_22, ldfld:ButtonState(MouseState::_xButton2, ldloc:valuetype Microsoft.Xna.Framework.Input.MouseState&(this)))
	stloc:ButtonState(var_5_2A, ldfld:ButtonState(MouseState::_rightButton, ldloc:valuetype Microsoft.Xna.Framework.Input.MouseState&(this)))
	stloc:ButtonState(var_6_32, ldfld:ButtonState(MouseState::_xButton1, ldloc:valuetype Microsoft.Xna.Framework.Input.MouseState&(this)))
	stloc:ButtonState(var_7_3A, ldfld:ButtonState(MouseState::_xButton1, ldloc:valuetype Microsoft.Xna.Framework.Input.MouseState&(this)))
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

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06001641 RID: 5697 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001642 RID: 5698 RVA: 0x00061C9C File Offset: 0x0005FE9C
		public int X
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			internal set
			{
				this._x = value;
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06001643 RID: 5699 RVA: 0x00061CB0 File Offset: 0x0005FEB0
		// (set) Token: 0x06001644 RID: 5700 RVA: 0x00061CC4 File Offset: 0x0005FEC4
		public int Y
		{
			get
			{
				return this._y;
			}
			internal set
			{
				this._y = value;
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06001645 RID: 5701 RVA: 0x00061CD8 File Offset: 0x0005FED8
		public Point Position
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001645)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Point Microsoft.Xna.Framework.Input.MouseState::get_Position()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(MouseState::_x, ldloc:valuetype Microsoft.Xna.Framework.Input.MouseState&(this)))
	stloc:int32(var_1_0D, ldfld:int32(MouseState::_scrollWheelValue, ldloc:valuetype Microsoft.Xna.Framework.Input.MouseState&(this)))
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
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06001646 RID: 5702 RVA: 0x00061CF4 File Offset: 0x0005FEF4
		// (set) Token: 0x06001647 RID: 5703 RVA: 0x00061D08 File Offset: 0x0005FF08
		public ButtonState LeftButton
		{
			get
			{
				return this._leftButton;
			}
			internal set
			{
				this._leftButton = value;
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06001648 RID: 5704 RVA: 0x00061D1C File Offset: 0x0005FF1C
		// (set) Token: 0x06001649 RID: 5705 RVA: 0x00061D30 File Offset: 0x0005FF30
		public ButtonState MiddleButton
		{
			get
			{
				return this._middleButton;
			}
			internal set
			{
				this._middleButton = value;
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x0600164A RID: 5706 RVA: 0x00061D44 File Offset: 0x0005FF44
		// (set) Token: 0x0600164B RID: 5707 RVA: 0x00061D58 File Offset: 0x0005FF58
		public ButtonState RightButton
		{
			get
			{
				return this._rightButton;
			}
			internal set
			{
				this._rightButton = value;
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x0600164C RID: 5708 RVA: 0x00061D6C File Offset: 0x0005FF6C
		// (set) Token: 0x0600164D RID: 5709 RVA: 0x00061D80 File Offset: 0x0005FF80
		public int ScrollWheelValue
		{
			get
			{
				return this._scrollWheelValue;
			}
			internal set
			{
				this._scrollWheelValue = value;
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x0600164E RID: 5710 RVA: 0x00061D94 File Offset: 0x0005FF94
		// (set) Token: 0x0600164F RID: 5711 RVA: 0x00061DA8 File Offset: 0x0005FFA8
		public int HorizontalScrollWheelValue
		{
			get
			{
				return this._horizontalScrollWheelValue;
			}
			internal set
			{
				this._horizontalScrollWheelValue = value;
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06001650 RID: 5712 RVA: 0x00061DBC File Offset: 0x0005FFBC
		// (set) Token: 0x06001651 RID: 5713 RVA: 0x00061DD0 File Offset: 0x0005FFD0
		public ButtonState XButton1
		{
			get
			{
				return this._xButton1;
			}
			internal set
			{
				this._xButton1 = value;
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06001652 RID: 5714 RVA: 0x00061DE4 File Offset: 0x0005FFE4
		// (set) Token: 0x06001653 RID: 5715 RVA: 0x00061DF8 File Offset: 0x0005FFF8
		public ButtonState XButton2
		{
			get
			{
				return this._xButton2;
			}
			internal set
			{
				this._xButton2 = value;
			}
		}

		// Token: 0x04002407 RID: 9223
		private int _x;

		// Token: 0x04002408 RID: 9224
		private int _y;

		// Token: 0x04002409 RID: 9225
		private int _scrollWheelValue;

		// Token: 0x0400240A RID: 9226
		private ButtonState _leftButton;

		// Token: 0x0400240B RID: 9227
		private ButtonState _rightButton;

		// Token: 0x0400240C RID: 9228
		private ButtonState _middleButton;

		// Token: 0x0400240D RID: 9229
		private ButtonState _xButton1;

		// Token: 0x0400240E RID: 9230
		private ButtonState _xButton2;

		// Token: 0x0400240F RID: 9231
		private int _horizontalScrollWheelValue;
	}
}
