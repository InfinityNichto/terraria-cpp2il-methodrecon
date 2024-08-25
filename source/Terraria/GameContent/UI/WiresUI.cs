using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameInput;

namespace Terraria.GameContent.UI
{
	// Token: 0x02000A67 RID: 2663
	public class WiresUI
	{
		// Token: 0x170008A1 RID: 2209
		// (get) Token: 0x06004E95 RID: 20117 RVA: 0x00277294 File Offset: 0x00275494
		public static bool Open
		{
			get
			{
				/*
An exception occurred when decompiling this method (06004E95)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.UI.WiresUI::get_Open()

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

		// Token: 0x06004E96 RID: 20118 RVA: 0x002772A4 File Offset: 0x002754A4
		public static void HandleWiresUI(SpriteBatch spriteBatch)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06004E97 RID: 20119 RVA: 0x002772B4 File Offset: 0x002754B4
		public WiresUI()
		{
		}

		// Token: 0x06004E98 RID: 20120 RVA: 0x002772C8 File Offset: 0x002754C8
		// Note: this type is marked as 'beforefieldinit'.
		static WiresUI()
		{
		}

		// Token: 0x040087B4 RID: 34740
		private static WiresUI.WiresRadial radial;

		// Token: 0x02000A68 RID: 2664
		public static class Settings
		{
			// Token: 0x170008A2 RID: 2210
			// (get) Token: 0x06004E99 RID: 20121 RVA: 0x000021DB File Offset: 0x000003DB
			// (set) Token: 0x06004E9A RID: 20122 RVA: 0x002772D8 File Offset: 0x002754D8
			public static WiresUI.Settings.MultiToolMode ToolMode
			{
				get
				{
					throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
				set
				{
				}
			}

			// Token: 0x170008A3 RID: 2211
			// (get) Token: 0x06004E9B RID: 20123 RVA: 0x002772E8 File Offset: 0x002754E8
			public static bool DrawWires
			{
				get
				{
					int num = 1;
					if (num == 0)
					{
					}
					if (num != 0)
					{
						if (num == 0)
						{
						}
						if (num == 0)
						{
							return;
						}
					}
					if (num == 0)
					{
					}
					int myPlayer = Main.myPlayer;
					int myPlayer2 = Main.myPlayer;
					int myPlayer3 = Main.myPlayer;
					int myPlayer4 = Main.myPlayer;
				}
			}

			// Token: 0x170008A4 RID: 2212
			// (get) Token: 0x06004E9C RID: 20124 RVA: 0x00277330 File Offset: 0x00275530
			public static bool HideWires
			{
				get
				{
					/*
An exception occurred when decompiling this method (06004E9C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.UI.WiresUI/Settings::get_HideWires()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:int32(var_1_0A, callgetter:int32(Main::get_myPlayer))
	stloc:int32(var_3_12, callgetter:int32(Main::get_myPlayer))
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

			// Token: 0x170008A5 RID: 2213
			// (get) Token: 0x06004E9D RID: 20125 RVA: 0x00277350 File Offset: 0x00275550
			public static bool DrawToolModeUI
			{
				get
				{
					/*
An exception occurred when decompiling this method (06004E9D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.UI.WiresUI/Settings::get_DrawToolModeUI()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:int32(var_1_0A, callgetter:int32(Main::get_myPlayer))
	stloc:int32(var_3_12, callgetter:int32(Main::get_myPlayer))
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

			// Token: 0x170008A6 RID: 2214
			// (get) Token: 0x06004E9E RID: 20126 RVA: 0x000021DB File Offset: 0x000003DB
			// (set) Token: 0x06004E9F RID: 20127 RVA: 0x00277370 File Offset: 0x00275570
			private static int _lastActuatorEnabled
			{
				get
				{
					throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
				set
				{
				}
			}

			// Token: 0x170008A7 RID: 2215
			// (get) Token: 0x06004EA0 RID: 20128 RVA: 0x00277380 File Offset: 0x00275580
			public static bool DrawToolAllowActuators
			{
				get
				{
					/*
An exception occurred when decompiling this method (06004EA0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.UI.WiresUI/Settings::get_DrawToolAllowActuators()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:int32(var_1_0A, callgetter:int32(Main::get_myPlayer))
	stloc:int32(var_3_12, callgetter:int32(Main::get_myPlayer))
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

			// Token: 0x02000A69 RID: 2665
			[Flags]
			public enum MultiToolMode
			{
				// Token: 0x040087B6 RID: 34742
				Red = 1,
				// Token: 0x040087B7 RID: 34743
				Green = 2,
				// Token: 0x040087B8 RID: 34744
				Blue = 4,
				// Token: 0x040087B9 RID: 34745
				Yellow = 8,
				// Token: 0x040087BA RID: 34746
				Actuator = 16,
				// Token: 0x040087BB RID: 34747
				Cutter = 32
			}
		}

		// Token: 0x02000A6A RID: 2666
		public class WiresRadial
		{
			// Token: 0x06004EA1 RID: 20129 RVA: 0x002773A0 File Offset: 0x002755A0
			public void Update()
			{
				this.FlowerUpdate();
				this.LineUpdate();
			}

			// Token: 0x06004EA2 RID: 20130 RVA: 0x002773BC File Offset: 0x002755BC
			private void LineUpdate()
			{
				int num = 1;
				if (num == 0)
				{
				}
				int myPlayer = Main.myPlayer;
				bool drawToolModeUI = WiresUI.Settings.DrawToolModeUI;
				if (num == 0)
				{
				}
				if (num != 0)
				{
					if (num == 0)
					{
						if (num == 0)
						{
						}
						int type = Main.mouseItem.type;
					}
					return;
				}
			}

			// Token: 0x06004EA3 RID: 20131 RVA: 0x00277448 File Offset: 0x00275648
			private void FlowerUpdate()
			{
				if (!true)
				{
				}
				int myPlayer = Main.myPlayer;
				bool drawToolModeUI = WiresUI.Settings.DrawToolModeUI;
				if (this.OnWiresMenu)
				{
					int type = Main.mouseItem.type;
					return;
				}
			}

			// Token: 0x06004EA4 RID: 20132 RVA: 0x00277520 File Offset: 0x00275720
			public void Draw(SpriteBatch spriteBatch)
			{
				this.DrawFlower(spriteBatch);
				this.DrawCursorArea(spriteBatch);
			}

			// Token: 0x06004EA5 RID: 20133 RVA: 0x0027753C File Offset: 0x0027573C
			private void DrawLine(SpriteBatch spriteBatch)
			{
				bool flag = this.active;
				if (flag)
				{
					return;
				}
				float lineOpacity = this._lineOpacity;
				if (!flag)
				{
				}
				Vector2 mouseScreen = Main.MouseScreen;
				int screenWidth = Main.screenWidth;
				int screenHeight = Main.screenHeight;
				if (!flag)
				{
				}
				bool usingGamepad = PlayerInput.UsingGamepad;
				if (!true)
				{
				}
				if (!true)
				{
				}
				bool drawToolAllowActuators = WiresUI.Settings.DrawToolAllowActuators;
				if (17008 == 0)
				{
				}
			}

			// Token: 0x06004EA6 RID: 20134 RVA: 0x002776A8 File Offset: 0x002758A8
			private void DrawFlower(SpriteBatch spriteBatch)
			{
				int num = 1;
				if (num != 0)
				{
					if (num == 0)
					{
					}
					Vector2 mouseScreen = Main.MouseScreen;
					if (num == 0)
					{
					}
					bool usingGamepad = PlayerInput.UsingGamepad;
					if (num == 0)
					{
					}
					bool smartCursorWanted = Main.SmartCursorWanted;
					if (num == 0)
					{
					}
					int num2 = 1;
					if (num2 == 0)
					{
					}
					int value = num2.m_value;
					if (num2 == 0)
					{
					}
					return;
				}
			}

			// Token: 0x06004EA7 RID: 20135 RVA: 0x00277854 File Offset: 0x00275A54
			private void DrawCursorArea(SpriteBatch spriteBatch)
			{
				bool flag = this.active;
				if (flag)
				{
					return;
				}
				float lineOpacity = this._lineOpacity;
				if (!flag)
				{
				}
				Vector2 mouseScreen = Main.MouseScreen;
				if (!flag)
				{
				}
				bool usingGamepad = PlayerInput.UsingGamepad;
				int num = true.ToInt();
				if (!true)
				{
				}
				bool drawToolAllowActuators = WiresUI.Settings.DrawToolAllowActuators;
				if (!true)
				{
				}
				bool usingGamepad2 = PlayerInput.UsingGamepad;
			}

			// Token: 0x06004EA8 RID: 20136 RVA: 0x00277964 File Offset: 0x00275B64
			public WiresRadial()
			{
			}

			// Token: 0x040087BC RID: 34748
			public Vector2 position;

			// Token: 0x040087BD RID: 34749
			public bool active;

			// Token: 0x040087BE RID: 34750
			public bool OnWiresMenu;

			// Token: 0x040087BF RID: 34751
			private float _lineOpacity;
		}
	}
}
