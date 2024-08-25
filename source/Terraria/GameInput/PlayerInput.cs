using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Terraria.GameContent.UI.Chat;
using Terraria.IO;

namespace Terraria.GameInput
{
	// Token: 0x020006C5 RID: 1733
	public class PlayerInput
	{
		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x06003979 RID: 14713 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x0600397A RID: 14714 RVA: 0x0022DEE8 File Offset: 0x0022C0E8
		public static TriggersPack Triggers
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x0600397B RID: 14715 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x0600397C RID: 14716 RVA: 0x0022DEF8 File Offset: 0x0022C0F8
		public static MouseState MouseInfo
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
				int horizontalScrollWheelValue = value._horizontalScrollWheelValue;
				int x = value._x;
				int y = value._y;
			}
		}

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x0600397D RID: 14717 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x0600397E RID: 14718 RVA: 0x0022DF1C File Offset: 0x0022C11C
		public static MouseState MouseInfoOld
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
				int horizontalScrollWheelValue = value._horizontalScrollWheelValue;
				int x = value._x;
				int y = value._y;
			}
		}

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x0600397F RID: 14719 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06003980 RID: 14720 RVA: 0x0022DF40 File Offset: 0x0022C140
		public static int MouseX
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x06003981 RID: 14721 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06003982 RID: 14722 RVA: 0x0022DF50 File Offset: 0x0022C150
		public static int MouseY
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x06003983 RID: 14723 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06003984 RID: 14724 RVA: 0x0022DF60 File Offset: 0x0022C160
		public static bool LockGamepadTileUseButton
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x06003985 RID: 14725 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06003986 RID: 14726 RVA: 0x0022DF70 File Offset: 0x0022C170
		public static int PreUIX
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x06003987 RID: 14727 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06003988 RID: 14728 RVA: 0x0022DF80 File Offset: 0x0022C180
		public static int PreUIY
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x06003989 RID: 14729 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x0600398A RID: 14730 RVA: 0x0022DF90 File Offset: 0x0022C190
		public static int PreLockOnX
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x0600398B RID: 14731 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x0600398C RID: 14732 RVA: 0x0022DFA0 File Offset: 0x0022C1A0
		public static int PreLockOnY
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x0600398D RID: 14733 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x0600398E RID: 14734 RVA: 0x0022DFB0 File Offset: 0x0022C1B0
		public static int ScrollWheelValue
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x0600398F RID: 14735 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06003990 RID: 14736 RVA: 0x0022DFC0 File Offset: 0x0022C1C0
		public static int ScrollWheelValueOld
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x06003991 RID: 14737 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06003992 RID: 14738 RVA: 0x0022DFD0 File Offset: 0x0022C1D0
		public static int ScrollWheelDelta
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x14000044 RID: 68
		// (add) Token: 0x06003993 RID: 14739 RVA: 0x0022DFE0 File Offset: 0x0022C1E0
		// (remove) Token: 0x06003994 RID: 14740 RVA: 0x0022DFFC File Offset: 0x0022C1FC
		public static event Action OnBindingChange
		{
			[CompilerGenerated]
			add
			{
				if (!true)
				{
				}
				Delegate @delegate;
				if (@delegate != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (!true)
				{
				}
				Delegate @delegate;
				if (@delegate != null)
				{
				}
			}
		}

		// Token: 0x14000045 RID: 69
		// (add) Token: 0x06003995 RID: 14741 RVA: 0x0022E018 File Offset: 0x0022C218
		// (remove) Token: 0x06003996 RID: 14742 RVA: 0x0022E034 File Offset: 0x0022C234
		public static event Action OnActionableInput
		{
			[CompilerGenerated]
			add
			{
				if (!true)
				{
				}
				Delegate @delegate;
				if (@delegate != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (!true)
				{
				}
				Delegate @delegate;
				if (@delegate != null)
				{
				}
			}
		}

		// Token: 0x06003997 RID: 14743 RVA: 0x0022E050 File Offset: 0x0022C250
		public static void ListenFor(string triggerName, InputMode inputmode)
		{
			if (!true)
			{
			}
		}

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x06003998 RID: 14744 RVA: 0x0022E060 File Offset: 0x0022C260
		public static string ListeningTrigger
		{
			get
			{
				/*
An exception occurred when decompiling this method (06003998)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String Terraria.GameInput.PlayerInput::get_ListeningTrigger()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
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

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x06003999 RID: 14745 RVA: 0x0022E070 File Offset: 0x0022C270
		public static bool CurrentlyRebinding
		{
			get
			{
				/*
An exception occurred when decompiling this method (06003999)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameInput.PlayerInput::get_CurrentlyRebinding()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
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

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x0600399A RID: 14746 RVA: 0x0022E080 File Offset: 0x0022C280
		public static bool InvisibleGamepadInMenus
		{
			get
			{
				int num = 1;
				if (num == 0)
				{
				}
				bool gameMenu = Main.gameMenu;
				if (num == 0)
				{
				}
				bool ingameOptionsWindow = Main.ingameOptionsWindow;
				if (num == 0)
				{
				}
				bool playerInventory = Main.playerInventory;
				if (num == 0)
				{
				}
				int myPlayer = Main.myPlayer;
				if (num == 0)
				{
				}
				int myPlayer2 = Main.myPlayer;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				if (num != 0)
				{
					if (num == 0)
					{
					}
					bool cursorIsBusy = PlayerInput.CursorIsBusy;
					if (num == 0)
					{
					}
				}
				if (num == 0)
				{
				}
				while (num == 0)
				{
				}
			}
		}

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x0600399B RID: 14747 RVA: 0x0022E0F0 File Offset: 0x0022C2F0
		public static PlayerInputProfile CurrentProfile
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600399B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.GameInput.PlayerInputProfile Terraria.GameInput.PlayerInput::get_CurrentProfile()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
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

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x0600399C RID: 14748 RVA: 0x0022E100 File Offset: 0x0022C300
		public static KeyConfiguration ProfileGamepadUI
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600399C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.GameInput.KeyConfiguration Terraria.GameInput.PlayerInput::get_ProfileGamepadUI()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	brtrue(IL_0000, ldc.i4:bool(1))
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

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x0600399D RID: 14749 RVA: 0x0022E114 File Offset: 0x0022C314
		public static bool UsingGamepad
		{
			get
			{
				if (!true)
				{
				}
				return true;
			}
		}

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x0600399E RID: 14750 RVA: 0x0022E128 File Offset: 0x0022C328
		public static bool UsingGamepadUI
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600399E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameInput.PlayerInput::get_UsingGamepadUI()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
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

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x0600399F RID: 14751 RVA: 0x0022E138 File Offset: 0x0022C338
		public static bool IgnoreMouseInterface
		{
			get
			{
				if (!true)
				{
				}
				int itemAnimation = Main.LocalPlayer.itemAnimation;
				return PlayerInput.UsingGamepad;
			}
		}

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x060039A0 RID: 14752 RVA: 0x0022E160 File Offset: 0x0022C360
		public static bool SteamDeckIsUsed
		{
			get
			{
				/*
An exception occurred when decompiling this method (060039A0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameInput.PlayerInput::get_SteamDeckIsUsed()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
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

		// Token: 0x060039A1 RID: 14753 RVA: 0x0022E170 File Offset: 0x0022C370
		private static bool InvalidateKeyboardSwap()
		{
			/*
An exception occurred when decompiling this method (060039A1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameInput.PlayerInput::InvalidateKeyboardSwap()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0014:
	stloc:StringBuilder(var_6_20, call:StringBuilder(StringBuilder::Append, ldloc:StringBuilder(var_5), ldstr:string(", ")))
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

		// Token: 0x060039A2 RID: 14754 RVA: 0x0022E1A4 File Offset: 0x0022C3A4
		public static void ResetInputsOnActiveStateChange()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			KeyboardState state = Keyboard.GetState();
			if (num == 0)
			{
			}
			KeyboardState state2 = Keyboard.GetState();
			KeyboardState state3 = Keyboard.GetState();
			PlayerInput.Triggers.Reset();
			PlayerInput.Triggers.Reset();
			StringBuilder stringBuilder2;
			StringBuilder stringBuilder = stringBuilder2.Append(", ");
		}

		// Token: 0x060039A3 RID: 14755 RVA: 0x0022E200 File Offset: 0x0022C400
		public static void TryEnteringFastUseModeForInventorySlot(int inventorySlot)
		{
			if (!true)
			{
			}
			Player localPlayer = Main.LocalPlayer;
		}

		// Token: 0x060039A4 RID: 14756 RVA: 0x0022E218 File Offset: 0x0022C418
		public static void TryEnteringFastUseModeForMouseItem()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			Player localPlayer = Main.LocalPlayer;
		}

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x060039A5 RID: 14757 RVA: 0x0022E238 File Offset: 0x0022C438
		public static bool ShouldFastUseItem
		{
			get
			{
				if (!true)
				{
				}
				bool flag;
				return flag;
			}
		}

		// Token: 0x060039A6 RID: 14758 RVA: 0x0022E24C File Offset: 0x0022C44C
		public static void TryEndingFastUse()
		{
			if (!true)
			{
			}
		}

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x060039A7 RID: 14759 RVA: 0x0022E25C File Offset: 0x0022C45C
		public static bool InBuildingMode
		{
			get
			{
				/*
An exception occurred when decompiling this method (060039A7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameInput.PlayerInput::get_InBuildingMode()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
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

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x060039A8 RID: 14760 RVA: 0x0022E26C File Offset: 0x0022C46C
		public static int RealScreenWidth
		{
			get
			{
				/*
An exception occurred when decompiling this method (060039A8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.GameInput.PlayerInput::get_RealScreenWidth()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
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

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x060039A9 RID: 14761 RVA: 0x0022E27C File Offset: 0x0022C47C
		public static int RealScreenHeight
		{
			get
			{
				return 41697280;
			}
		}

		// Token: 0x060039AA RID: 14762 RVA: 0x0022E290 File Offset: 0x0022C490
		public static void SetSelectedProfile(string name)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x060039AB RID: 14763 RVA: 0x0022E2A4 File Offset: 0x0022C4A4
		public static void Initialize()
		{
			if (!true)
			{
			}
			Preferences inputProfiles = Main.InputProfiles;
			PlayerInput.SetSelectedProfile("Custom");
			PlayerInput.Triggers.Initialize();
		}

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x060039AC RID: 14764 RVA: 0x0022E2D4 File Offset: 0x0022C4D4
		public static bool CursorIsBusy
		{
			get
			{
				if (!true)
				{
				}
				return true;
			}
		}

		// Token: 0x060039AD RID: 14765 RVA: 0x0022E2E8 File Offset: 0x0022C4E8
		public static bool IsGamepadButtonLockedFromUse(string keyName)
		{
			/*
An exception occurred when decompiling this method (060039AD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameInput.PlayerInput::IsGamepadButtonLockedFromUse(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
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

		// Token: 0x060039AE RID: 14766 RVA: 0x0022E2F8 File Offset: 0x0022C4F8
		public static void UpdateInput()
		{
			int num = 1;
			PlayerInput.SettingsForUI.UpdateCounters();
			if (num == 0)
			{
			}
			PlayerInput.Triggers.Reset();
			PlayerInput.ScrollWheelValueOld = PlayerInput.ScrollWheelValue;
			PlayerInput.ScrollWheelValue = 0;
			if (num == 0)
			{
			}
			if (true)
			{
				return;
			}
			if (!true)
			{
			}
			bool usingGamepad = PlayerInput.UsingGamepad;
			if (!true)
			{
			}
			TriggersSet current = PlayerInput.Triggers.Current;
			int num2 = 1;
			PlayerInput.MouseInput();
			bool flag = PlayerInput.KeyboardInput();
			bool flag2 = PlayerInput.GamePadInput();
			PlayerInput.Triggers.Update();
			PlayerInput.PostInput();
			int scrollWheelValue = PlayerInput.ScrollWheelValue;
			PlayerInput.ScrollWheelDelta = PlayerInput.ScrollWheelValueOld;
			int scrollWheelDelta = PlayerInput.ScrollWheelDelta;
			PlayerInput.UpdateMainMouse();
			Main.mouseLeftRelease = Main.mouseLeft;
			Main.mouseRightRelease = Main.mouseRight;
			Main.mouseLeft = PlayerInput.Triggers.Current.MouseLeft;
			Main.mouseRight = PlayerInput.Triggers.Current.MouseRight;
			Cursor cursor;
			int num3;
			if (cursor != null)
			{
				num3 = 1;
				return;
			}
			Main.mouseLeft = num3 != 0;
			Cursor cursor2;
			if (cursor2 != null)
			{
				return;
			}
			Main.mouseRight = true;
			PlayerInput.CacheZoomableValues();
			if (num2 == 0)
			{
			}
		}

		// Token: 0x060039AF RID: 14767 RVA: 0x0022E3F4 File Offset: 0x0022C5F4
		public static void UpdateMainMouse()
		{
			if (!true)
			{
			}
			Main.lastMouseX = Main.mouseX;
			Main.lastMouseY = Main.mouseY;
			if (!true)
			{
			}
			Main.mouseX = PlayerInput.MouseX;
			Main.mouseY = PlayerInput.MouseY;
			Main.worldMouseX = Main.mouseX;
			Main.worldMouseY = Main.mouseY;
		}

		// Token: 0x060039B0 RID: 14768 RVA: 0x0022E44C File Offset: 0x0022C64C
		public static void CacheZoomableValues()
		{
			if (!true)
			{
			}
			PlayerInput.CacheOriginalInput();
			PlayerInput.CacheOriginalScreenDimensions();
		}

		// Token: 0x060039B1 RID: 14769 RVA: 0x0022E468 File Offset: 0x0022C668
		public static void CacheMousePositionForZoom()
		{
			if (!true)
			{
			}
			int mouseX = Main.mouseX;
			int mouseY = Main.mouseY;
		}

		// Token: 0x060039B2 RID: 14770 RVA: 0x0022E488 File Offset: 0x0022C688
		private static void CacheOriginalInput()
		{
			if (!true)
			{
			}
			int mouseX = Main.mouseX;
			int mouseY = Main.mouseY;
			int lastMouseX = Main.lastMouseX;
			int lastMouseY = Main.lastMouseY;
		}

		// Token: 0x060039B3 RID: 14771 RVA: 0x0022E4BC File Offset: 0x0022C6BC
		public static void CacheOriginalScreenDimensions()
		{
			if (!true)
			{
			}
			int screenWidth = Main.screenWidth;
			int screenHeight = Main.screenHeight;
		}

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x060039B4 RID: 14772 RVA: 0x0022E4DC File Offset: 0x0022C6DC
		public static Vector2 OriginalScreenSize
		{
			get
			{
				if (!true)
				{
				}
				return 1;
			}
		}

		// Token: 0x060039B5 RID: 14773 RVA: 0x0022E4F0 File Offset: 0x0022C6F0
		private static bool GamePadInput()
		{
			/*
An exception occurred when decompiling this method (060039B5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameInput.PlayerInput::GamePadInput()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	callsetter:int32(PlayerInput::set_ScrollWheelValue, callgetter:int32(PlayerInput::get_ScrollWheelValue))
	stloc:bool(var_1_14, callgetter:bool(Main::get_SettingBlockGamepadsEntirely))
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

		// Token: 0x060039B6 RID: 14774 RVA: 0x0022E514 File Offset: 0x0022C714
		private static void MouseInput()
		{
			int num = 1;
			if (num == 0)
			{
			}
			PlayerInput.MouseInfoOld = PlayerInput.MouseInfo;
			if (num == 0)
			{
			}
			PlayerInput.MouseInfo = Mouse.GetState();
			int scrollWheelValue = PlayerInput.ScrollWheelValue;
			MouseState mouseInfo = PlayerInput.MouseInfo;
			MouseState mouseInfo2 = PlayerInput.MouseInfo;
			MouseState mouseInfoOld = PlayerInput.MouseInfoOld;
			if (num == 0)
			{
			}
			MouseState mouseInfo3 = PlayerInput.MouseInfo;
			MouseState mouseInfoOld2 = PlayerInput.MouseInfoOld;
			if (num == 0)
			{
			}
			MouseState mouseInfo4 = PlayerInput.MouseInfo;
			MouseState mouseInfoOld3 = PlayerInput.MouseInfoOld;
		}

		// Token: 0x060039B7 RID: 14775 RVA: 0x0022E5CC File Offset: 0x0022C7CC
		private static bool KeyboardInput()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num != 0)
			{
				if (!false)
				{
				}
				string text;
				bool flag = Main.blockKey != text;
				string blockKey = Main.blockKey;
				string text2;
				bool flag2 = text2 == blockKey;
				string text3;
				Main.blockKey = text3;
				if (!true)
				{
				}
				bool gameMenu = Main.gameMenu;
				if (!true)
				{
				}
			}
			long num2 = 0L;
			if (num2 == 0L)
			{
				if (num2 == 0L)
				{
				}
				if (num2 == 0L)
				{
				}
				if (num2 == 0L)
				{
				}
				TriggersSet old = PlayerInput.Triggers.Old;
				TriggersSet current = PlayerInput.Triggers.Current;
				TriggersSet current2 = PlayerInput.Triggers.Current;
				return;
			}
		}

		// Token: 0x060039B8 RID: 14776 RVA: 0x0022E668 File Offset: 0x0022C868
		private static void DebugKeys(List<Keys> keys)
		{
		}

		// Token: 0x060039B9 RID: 14777 RVA: 0x0022E678 File Offset: 0x0022C878
		private static void FixDerpedRebinds()
		{
		}

		// Token: 0x060039BA RID: 14778 RVA: 0x0022E688 File Offset: 0x0022C888
		private static bool CheckRebindingProcessGamepad(string newKey)
		{
		}

		// Token: 0x060039BB RID: 14779 RVA: 0x0022E698 File Offset: 0x0022C898
		private static bool CheckRebindingProcessKeyboard(string newKey)
		{
		}

		// Token: 0x060039BC RID: 14780 RVA: 0x0022E6A8 File Offset: 0x0022C8A8
		private static void PostInput()
		{
			if (!true)
			{
			}
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			bool hotbarPlus = PlayerInput.Triggers.Current.HotbarPlus;
			int num2 = true.ToInt();
			int num3 = PlayerInput.Triggers.Current.HotbarMinus.ToInt();
			TriggersSet current = PlayerInput.Triggers.Current;
			int num4 = 1;
			current.RadialHotbar = num4 != 0;
			TriggersSet justReleased = PlayerInput.Triggers.JustReleased;
			long num5 = 0L;
			justReleased.RadialHotbar = num5 != 0L;
		}

		// Token: 0x060039BD RID: 14781 RVA: 0x0022E750 File Offset: 0x0022C950
		private static void HandleDpadSnap()
		{
		}

		// Token: 0x060039BE RID: 14782 RVA: 0x0022E818 File Offset: 0x0022CA18
		public static string BuildCommand(string CommandText, bool Last, params List<string>[] Bindings)
		{
			int num = 1;
			string text5;
			if (num != 0)
			{
				if (num == 0)
				{
				}
				string text2;
				string text = "" + text2;
				if (num == 0)
				{
				}
				string text3;
				int stringLength = text3._stringLength;
				string text4 = text + "/" + text3;
				int stringLength2 = text4._stringLength;
				text5 = text4 + ": " + text3;
			}
			return text5;
		}

		// Token: 0x060039BF RID: 14783 RVA: 0x0022E87C File Offset: 0x0022CA7C
		private static string GenerateGlyphList(List<string> list)
		{
			if (true)
			{
				string text = GlyphTagHandler.GenerateTag("");
				string text2 = GlyphTagHandler.GenerateTag(text);
				return text + "/" + text2;
			}
			return "";
		}

		// Token: 0x060039C0 RID: 14784 RVA: 0x0022E8B4 File Offset: 0x0022CAB4
		private static string GenerateRawInputList(List<string> list)
		{
			if (true)
			{
				return "" + "/" + "";
			}
			return "";
		}

		// Token: 0x060039C1 RID: 14785 RVA: 0x0022E8E0 File Offset: 0x0022CAE0
		public static void NavigatorCachePosition()
		{
		}

		// Token: 0x060039C2 RID: 14786 RVA: 0x0022E8F0 File Offset: 0x0022CAF0
		public static void NavigatorUnCachePosition()
		{
		}

		// Token: 0x060039C3 RID: 14787 RVA: 0x0022E900 File Offset: 0x0022CB00
		public static void LockOnCachePosition()
		{
			if (!true)
			{
			}
			PlayerInput.PreLockOnX = PlayerInput.MouseX;
			PlayerInput.PreLockOnY = PlayerInput.MouseY;
		}

		// Token: 0x060039C4 RID: 14788 RVA: 0x0022E924 File Offset: 0x0022CB24
		public static void LockOnUnCachePosition()
		{
			if (!true)
			{
			}
			PlayerInput.MouseX = PlayerInput.PreLockOnX;
			PlayerInput.MouseY = PlayerInput.PreLockOnY;
		}

		// Token: 0x060039C5 RID: 14789 RVA: 0x0022E948 File Offset: 0x0022CB48
		public static void PrettyPrintProfiles(string text)
		{
			if ("\r\n" == null || "\r\n" != null)
			{
				string text3;
				string text2 = "\r\n" + text3 + "{\r\n  ";
				string text5;
				string text4 = text5.Replace(": {\r\n  ", text2);
				string text7;
				string text6 = text7.Replace("[\r\n      ", "[").Replace("\"\r\n      ", "\"").Replace("\",\r\n        ", "\", ")
					.Replace("\",\r\n      ", "\", ")
					.Replace("\r\n    ]", "]");
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060039C6 RID: 14790 RVA: 0x0022E9E4 File Offset: 0x0022CBE4
		public static void PrettyPrintProfilesOld(string text)
		{
			string text3;
			string text2 = text3.Replace("[\r\n      ", "[").Replace("\"\r\n      ", "\"").Replace("\",\r\n      ", "\", ")
				.Replace("\r\n    ]", "]");
		}

		// Token: 0x060039C7 RID: 14791 RVA: 0x0022EA30 File Offset: 0x0022CC30
		public static void Reset(KeyConfiguration c, PresetProfiles style, InputMode mode)
		{
		}

		// Token: 0x060039C8 RID: 14792 RVA: 0x0022F070 File Offset: 0x0022D270
		public static void SetZoom_UI()
		{
		}

		// Token: 0x060039C9 RID: 14793 RVA: 0x0022F080 File Offset: 0x0022D280
		public static void SetZoom_World()
		{
		}

		// Token: 0x060039CA RID: 14794 RVA: 0x0022F090 File Offset: 0x0022D290
		public static void SetZoom_Unscaled()
		{
		}

		// Token: 0x060039CB RID: 14795 RVA: 0x0022F0A0 File Offset: 0x0022D2A0
		public static void SetZoom_Test()
		{
		}

		// Token: 0x060039CC RID: 14796 RVA: 0x0022F0B0 File Offset: 0x0022D2B0
		public static void SetZoom_MouseInWorld()
		{
		}

		// Token: 0x060039CD RID: 14797 RVA: 0x0022F0C0 File Offset: 0x0022D2C0
		public static void SetDesiredZoomContext(ZoomContext context)
		{
		}

		// Token: 0x060039CE RID: 14798 RVA: 0x0022F0D0 File Offset: 0x0022D2D0
		public static void SetZoom_Context()
		{
		}

		// Token: 0x060039CF RID: 14799 RVA: 0x0022F0E0 File Offset: 0x0022D2E0
		private static void SetZoom_Scaled(float scale)
		{
		}

		// Token: 0x060039D0 RID: 14800 RVA: 0x0022F0F0 File Offset: 0x0022D2F0
		public PlayerInput()
		{
		}

		// Token: 0x060039D1 RID: 14801 RVA: 0x0022F104 File Offset: 0x0022D304
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerInput()
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (true)
			{
				return;
			}
			if (!true)
			{
			}
			if ("" == null)
			{
			}
			Type type;
			Array values = Enum.GetValues(type);
			if (values != null && (values == null || values == null))
			{
				throw new InvalidCastException();
			}
		}

		// Token: 0x040079E0 RID: 31200
		public static Vector2 RawMouseScale;

		// Token: 0x040079E1 RID: 31201
		public static bool GrappleAndInteractAreShared;

		// Token: 0x040079E2 RID: 31202
		public static SmartSelectGamepadPointer smartSelectPointer;

		// Token: 0x040079E3 RID: 31203
		private static StringBuilder _invalidatorCheck;

		// Token: 0x040079E4 RID: 31204
		private static StringBuilder ff;

		// Token: 0x040079E5 RID: 31205
		private static bool _lastActivityState;

		// Token: 0x040079E6 RID: 31206
		public static int ScrollWheelDeltaForUI;

		// Token: 0x040079E7 RID: 31207
		public static bool GamepadAllowScrolling;

		// Token: 0x040079E8 RID: 31208
		public static int GamepadScrollValue;

		// Token: 0x040079E9 RID: 31209
		public static Vector2 GamepadThumbstickLeft;

		// Token: 0x040079EA RID: 31210
		public static Vector2 GamepadThumbstickRight;

		// Token: 0x040079EB RID: 31211
		private static PlayerInput.FastUseItemMemory _fastUseMemory;

		// Token: 0x040079EC RID: 31212
		[CompilerGenerated]
		private static Action OnBindingChange;

		// Token: 0x040079ED RID: 31213
		[CompilerGenerated]
		private static Action OnActionableInput;

		// Token: 0x040079EE RID: 31214
		private static string _listeningTrigger;

		// Token: 0x040079EF RID: 31215
		private static InputMode _listeningInputMode;

		// Token: 0x040079F0 RID: 31216
		private static bool _canReleaseRebindingLock;

		// Token: 0x040079F1 RID: 31217
		private static int _memoOfLastPoint;

		// Token: 0x040079F2 RID: 31218
		public static int NavigatorRebindingLock;

		// Token: 0x040079F3 RID: 31219
		public static string BlockedKey;

		// Token: 0x040079F4 RID: 31220
		public static Dictionary<string, PlayerInputProfile> Profiles;

		// Token: 0x040079F5 RID: 31221
		public static Dictionary<string, PlayerInputProfile> OriginalProfiles;

		// Token: 0x040079F6 RID: 31222
		private static string _selectedProfile;

		// Token: 0x040079F7 RID: 31223
		private static PlayerInputProfile _currentProfile;

		// Token: 0x040079F8 RID: 31224
		public static InputMode CurrentInputMode;

		// Token: 0x040079F9 RID: 31225
		private static Buttons[] ButtonsGamepad;

		// Token: 0x040079FA RID: 31226
		public static bool UseSteamDeckIfPossible;

		// Token: 0x040079FB RID: 31227
		public static List<string> MouseKeys;

		// Token: 0x040079FC RID: 31228
		private static bool _InBuildingMode;

		// Token: 0x040079FD RID: 31229
		private static int _UIPointForBuildingMode;

		// Token: 0x040079FE RID: 31230
		public static bool WritingText;

		// Token: 0x040079FF RID: 31231
		private static int _originalMouseX;

		// Token: 0x04007A00 RID: 31232
		private static int _originalMouseY;

		// Token: 0x04007A01 RID: 31233
		private static int _originalLastMouseX;

		// Token: 0x04007A02 RID: 31234
		private static int _originalLastMouseY;

		// Token: 0x04007A03 RID: 31235
		private static int _originalScreenWidth;

		// Token: 0x04007A04 RID: 31236
		private static int _originalScreenHeight;

		// Token: 0x04007A05 RID: 31237
		private static ZoomContext _currentWantedZoom;

		// Token: 0x04007A06 RID: 31238
		private static List<string> _buttonsLocked;

		// Token: 0x04007A07 RID: 31239
		private static int[] DpadSnapCooldown;

		// Token: 0x020006C6 RID: 1734
		public class MiscSettingsTEMP
		{
			// Token: 0x060039D2 RID: 14802 RVA: 0x0022F144 File Offset: 0x0022D344
			public MiscSettingsTEMP()
			{
			}

			// Token: 0x060039D3 RID: 14803 RVA: 0x0022F158 File Offset: 0x0022D358
			// Note: this type is marked as 'beforefieldinit'.
			static MiscSettingsTEMP()
			{
			}

			// Token: 0x04007A08 RID: 31240
			public static bool HotbarRadialShouldBeUsed;
		}

		// Token: 0x020006C7 RID: 1735
		public static class SettingsForUI
		{
			// Token: 0x1700070B RID: 1803
			// (get) Token: 0x060039D4 RID: 14804 RVA: 0x000021DB File Offset: 0x000003DB
			// (set) Token: 0x060039D5 RID: 14805 RVA: 0x0022F168 File Offset: 0x0022D368
			public static CursorMode CurrentCursorMode
			{
				[CompilerGenerated]
				get
				{
					throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x060039D6 RID: 14806 RVA: 0x0022F178 File Offset: 0x0022D378
			public static void SetCursorMode(CursorMode cursorMode)
			{
				if (cursorMode == CursorMode.Mouse)
				{
					return;
				}
			}

			// Token: 0x1700070C RID: 1804
			// (get) Token: 0x060039D7 RID: 14807 RVA: 0x0022F18C File Offset: 0x0022D38C
			public static bool ShowGamepadHints
			{
				get
				{
					if (!true)
					{
					}
					bool usingGamepad = PlayerInput.UsingGamepad;
					return true;
				}
			}

			// Token: 0x1700070D RID: 1805
			// (get) Token: 0x060039D8 RID: 14808 RVA: 0x0022F1AC File Offset: 0x0022D3AC
			public static bool AllowSecondaryGamepadAim
			{
				get
				{
					return true;
				}
			}

			// Token: 0x1700070E RID: 1806
			// (get) Token: 0x060039D9 RID: 14809 RVA: 0x0022F1C0 File Offset: 0x0022D3C0
			public static bool PushEquipmentAreaUp
			{
				get
				{
					if (!true)
					{
					}
					bool usingGamepad = PlayerInput.UsingGamepad;
					if (!true)
					{
					}
					if (!true)
					{
						return;
					}
				}
			}

			// Token: 0x1700070F RID: 1807
			// (get) Token: 0x060039DA RID: 14810 RVA: 0x0022F1E0 File Offset: 0x0022D3E0
			public static bool ShowGamepadCursor
			{
				get
				{
					if (!true)
					{
					}
					if (!true)
					{
					}
					if (true)
					{
					}
					return PlayerInput.UsingGamepad;
				}
			}

			// Token: 0x17000710 RID: 1808
			// (get) Token: 0x060039DB RID: 14811 RVA: 0x0022F200 File Offset: 0x0022D400
			public static bool HighlightThingsForMouse
			{
				get
				{
					if (!true)
					{
					}
					bool usingGamepadUI = PlayerInput.UsingGamepadUI;
					return true;
				}
			}

			// Token: 0x17000711 RID: 1809
			// (get) Token: 0x060039DC RID: 14812 RVA: 0x000021DB File Offset: 0x000003DB
			// (set) Token: 0x060039DD RID: 14813 RVA: 0x0022F21C File Offset: 0x0022D41C
			public static int FramesSinceLastTimeInMouseMode
			{
				[CompilerGenerated]
				get
				{
					throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000712 RID: 1810
			// (get) Token: 0x060039DE RID: 14814 RVA: 0x000021DB File Offset: 0x000003DB
			public static bool PreventHighlightsForGamepad
			{
				get
				{
					throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			// Token: 0x060039DF RID: 14815 RVA: 0x0022F22C File Offset: 0x0022D42C
			public static void UpdateCounters()
			{
			}

			// Token: 0x060039E0 RID: 14816 RVA: 0x0022F23C File Offset: 0x0022D43C
			public static void TryRevertingToMouseMode()
			{
			}

			// Token: 0x04007A09 RID: 31241
			[CompilerGenerated]
			private static CursorMode <CurrentCursorMode>k__BackingField;

			// Token: 0x04007A0A RID: 31242
			[CompilerGenerated]
			private static int <FramesSinceLastTimeInMouseMode>k__BackingField;
		}

		// Token: 0x020006C8 RID: 1736
		private struct FastUseItemMemory
		{
			// Token: 0x060039E1 RID: 14817 RVA: 0x0022F260 File Offset: 0x0022D460
			public bool TryStartForItemSlot(Player player, int itemSlot)
			{
				/*
An exception occurred when decompiling this method (060039E1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameInput.PlayerInput/FastUseItemMemory::TryStartForItemSlot(Terraria.Player,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_002C:
	stloc:int64(var_4_2D, ldc.i4:int64(0))
	call:void(ItemSlot::PickupItemIntoMouse, ldloc:class Terraria.Item[](var_2_18), ldloc:int64[exp:int32](var_4_2D), ldloc:int32(itemSlot), ldloc:Player(player))
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

			// Token: 0x060039E2 RID: 14818 RVA: 0x0022F2A8 File Offset: 0x0022D4A8
			public bool TryStartForMouse(Player player)
			{
				this._player = player;
				this._slot = 1;
				if (!true)
				{
				}
				Item mouseItem = Main.mouseItem;
				this._shouldFastUse = 257 != 0;
				this._itemType = 1;
				return true;
			}

			// Token: 0x060039E3 RID: 14819 RVA: 0x0022F2E4 File Offset: 0x0022D4E4
			public void Clear()
			{
			}

			// Token: 0x060039E4 RID: 14820 RVA: 0x0022F2F4 File Offset: 0x0022D4F4
			public bool CanFastUse()
			{
				/*
An exception occurred when decompiling this method (060039E4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameInput.PlayerInput/FastUseItemMemory::CanFastUse()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_0_06, ldfld:bool(FastUseItemMemory::_shouldFastUse, ldloc:valuetype Terraria.GameInput.PlayerInput/FastUseItemMemory&(this)))
	stloc:bool(var_1_0D, ldfld:bool(FastUseItemMemory::_isMouseItem, ldloc:valuetype Terraria.GameInput.PlayerInput/FastUseItemMemory&(this)))
	stloc:Item(var_3_15, callgetter:Item(Main::get_mouseItem))
	stloc:Vector2(var_5_29, ldfld:Vector2(Entity::position, ldfld:class Terraria.Item[][exp:Entity](Player::inventory, ldfld:Player(FastUseItemMemory::_player, ldloc:valuetype Terraria.GameInput.PlayerInput/FastUseItemMemory&(this)))))
	stloc:int32(var_6_31, ldfld:int32(FastUseItemMemory::_itemType, ldloc:valuetype Terraria.GameInput.PlayerInput/FastUseItemMemory&(this)))
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

			// Token: 0x060039E5 RID: 14821 RVA: 0x0022F334 File Offset: 0x0022D534
			public void EndFastUse()
			{
				if (this._shouldFastUse && !this._isMouseItem)
				{
					Vector2 position = this._player.inventory.position;
					Item mouseItem = Main.mouseItem;
					Vector2 position2 = this._player.inventory.position;
					Item[] inventory = this._player.inventory;
					if (mouseItem != null && mouseItem == null)
					{
						throw new ArrayTypeMismatchException();
					}
				}
			}

			// Token: 0x04007A0B RID: 31243
			private int _slot;

			// Token: 0x04007A0C RID: 31244
			private int _itemType;

			// Token: 0x04007A0D RID: 31245
			private bool _shouldFastUse;

			// Token: 0x04007A0E RID: 31246
			private bool _isMouseItem;

			// Token: 0x04007A0F RID: 31247
			private Player _player;
		}
	}
}
