using System;
using System.Runtime.InteropServices;
using Controller;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI.Chat;

// Token: 0x020000F8 RID: 248
public class ControlsButtonTagHandler : ITagHandler
{
	// Token: 0x06000680 RID: 1664 RVA: 0x00014F30 File Offset: 0x00013130
	public static bool MeasureInline(SpriteFont.CharacterSource text, int offset, int endOffset, Vector2 size)
	{
	}

	// Token: 0x06000681 RID: 1665 RVA: 0x00014F48 File Offset: 0x00013148
	private static int DrawButtonControl(SpriteBatch spriteBatch, Vector2 position, Color color, float scale, ControllerActionButton action, bool mesaureOnly = false)
	{
		/*
An exception occurred when decompiling this method (06000681)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 ControlsButtonTagHandler::DrawButtonControl(Microsoft.Xna.Framework.Graphics.SpriteBatch,Microsoft.Xna.Framework.Vector2,Microsoft.Xna.Framework.Graphics.Color,System.Single,Controller.ControllerActionButton,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0066:
	stloc:Axis(var_18_6C, ldfld:Axis(Entry::Axis0, ldloc:Entry(var_1)))
	stloc:float32(var_19_74, ldfld:float32(Entry::Threshold, ldloc:Entry(var_1)))
	stloc:AxisControl(var_20_7E, call:AxisControl(GUIControlsBanner::FromAxis, ldloc:Axis(var_18_6C), ldloc:float32(scale)))
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

	// Token: 0x06000682 RID: 1666 RVA: 0x00014FD4 File Offset: 0x000131D4
	private static int DrawAxisControl(SpriteBatch spriteBatch, Vector2 position, Color color, float scale, ControllerActionVector action, bool mesasure = false)
	{
		/*
An exception occurred when decompiling this method (06000682)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 ControlsButtonTagHandler::DrawAxisControl(Microsoft.Xna.Framework.Graphics.SpriteBatch,Microsoft.Xna.Framework.Vector2,Microsoft.Xna.Framework.Graphics.Color,System.Single,Controller.ControllerActionVector,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_005C:
	stloc:AxisControl(var_17_68, call:AxisControl(GUIControlsBanner::FromAxis, ldfld:Axis(Entry::Axis0, ldloc:Entry(var_1)), ldloc:float32(scale)))
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

	// Token: 0x06000683 RID: 1667 RVA: 0x0001504C File Offset: 0x0001324C
	public static bool PrintInlineMapping(SpriteBatch spriteBatch, Vector2 position, Color color, float scale, SpriteFont.CharacterSource text, int offset, int endOffset, Vector2 size)
	{
		/*
An exception occurred when decompiling this method (06000683)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean ControlsButtonTagHandler::PrintInlineMapping(Microsoft.Xna.Framework.Graphics.SpriteBatch,Microsoft.Xna.Framework.Vector2,Microsoft.Xna.Framework.Graphics.Color,System.Single,Microsoft.Xna.Framework.Graphics.SpriteFont/CharacterSource,System.Int32,System.Int32,Microsoft.Xna.Framework.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stfld:string(CharacterSource::_string, ldloc:CharacterSource[exp:valuetype Microsoft.Xna.Framework.Graphics.SpriteFont/CharacterSource&](text), ldc.i4:int32[exp:string](0))
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

	// Token: 0x06000684 RID: 1668 RVA: 0x00015074 File Offset: 0x00013274
	public static bool MeasureInlineMapping(SpriteFont.CharacterSource text, int offset, int endOffset, Vector2 size)
	{
		/*
An exception occurred when decompiling this method (06000684)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean ControlsButtonTagHandler::MeasureInlineMapping(Microsoft.Xna.Framework.Graphics.SpriteFont/CharacterSource,System.Int32,System.Int32,Microsoft.Xna.Framework.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000B:
	stfld:int32(int32::m_value, ldloc:int32[exp:int32&](offset), ldc.i4:int32(0))
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

	// Token: 0x06000685 RID: 1669 RVA: 0x000150A4 File Offset: 0x000132A4
	public static bool PrintInline(SpriteBatch spriteBatch, Vector2 position, Color color, float scale, SpriteFont.CharacterSource text, int offset, int endOffset, Vector2 size)
	{
	}

	// Token: 0x06000686 RID: 1670 RVA: 0x000150BC File Offset: 0x000132BC
	public TextSnippet Parse(string text, [Optional] Color baseColor, [Optional] string options)
	{
		/*
An exception occurred when decompiling this method (06000686)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.UI.Chat.TextSnippet ControlsButtonTagHandler::Parse(System.String,Microsoft.Xna.Framework.Graphics.Color,System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_2_10, call:string(string::Concat, ldstr:string("[cb:"), ldloc:string(var_1), ldstr:string("]")))
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

	// Token: 0x06000687 RID: 1671 RVA: 0x000150DC File Offset: 0x000132DC
	public ControlsButtonTagHandler()
	{
	}

	// Token: 0x020000F9 RID: 249
	private class ControlsButtonSnippet : TextSnippet
	{
		// Token: 0x06000688 RID: 1672 RVA: 0x000150F0 File Offset: 0x000132F0
		public ControlsButtonSnippet(GUIControllerInputButton.LinkedControlType control)
			: base("")
		{
			this._control = control;
			if (!true)
			{
			}
			this.Color = 1;
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x0001511C File Offset: 0x0001331C
		public static bool Draw(GUIControllerInputButton.LinkedControlType control, bool justCheckingString, [Out] Vector2 size, SpriteBatch spriteBatch, [Optional] Vector2 position, [Optional] Color color, float scale = 1f)
		{
			if (true && true)
			{
				if (!true)
				{
				}
				if (!true)
				{
				}
			}
			justCheckingString.m_value = true;
			return true;
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x00015140 File Offset: 0x00013340
		public override bool UniqueDraw(bool justCheckingString, [Out] Vector2 size, SpriteBatch spriteBatch, [Optional] Vector2 position, [Optional] Color color, float scale = 1f)
		{
			bool flag = ControlsButtonTagHandler.ControlsButtonSnippet.Draw(this._control, justCheckingString, size, spriteBatch, position, color, scale);
			return true;
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x000021DB File Offset: 0x000003DB
		public override float GetStringLength(SpriteFont font)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x040004F5 RID: 1269
		private GUIControllerInputButton.LinkedControlType _control;
	}

	// Token: 0x020000FA RID: 250
	public enum MappingType
	{
		// Token: 0x040004F7 RID: 1271
		Movement,
		// Token: 0x040004F8 RID: 1272
		Aim,
		// Token: 0x040004F9 RID: 1273
		Fire,
		// Token: 0x040004FA RID: 1274
		Jump,
		// Token: 0x040004FB RID: 1275
		Interact,
		// Token: 0x040004FC RID: 1276
		OpenInventory,
		// Token: 0x040004FD RID: 1277
		CloseInventory,
		// Token: 0x040004FE RID: 1278
		CycleLeftPage,
		// Token: 0x040004FF RID: 1279
		CycleRightPage,
		// Token: 0x04000500 RID: 1280
		CyclePreviousHotbarItem,
		// Token: 0x04000501 RID: 1281
		CycleNextHotbarItem,
		// Token: 0x04000502 RID: 1282
		SwitchToWorld,
		// Token: 0x04000503 RID: 1283
		CraftItem,
		// Token: 0x04000504 RID: 1284
		PickupItem,
		// Token: 0x04000505 RID: 1285
		EquipItem,
		// Token: 0x04000506 RID: 1286
		Settings,
		// Token: 0x04000507 RID: 1287
		NavigateInventory,
		// Token: 0x04000508 RID: 1288
		Count
	}
}
