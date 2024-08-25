using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Controller;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI.Chat;
using UnityEngine;

// Token: 0x020000FB RID: 251
public class ControlsKeyboardTagHandler : ITagHandler
{
	// Token: 0x0600068C RID: 1676 RVA: 0x00015164 File Offset: 0x00013364
	private static void DrawKeyboardBinding(SpriteBatch spriteBatch, SpriteFont spriteFont, Microsoft.Xna.Framework.Vector2 position, Microsoft.Xna.Framework.Graphics.Color color, float scale, string bindingText, bool measure = false)
	{
	}

	// Token: 0x0600068D RID: 1677 RVA: 0x00015174 File Offset: 0x00013374
	public static bool PrintInlineMapping(SpriteBatch spriteBatch, SpriteFont spriteFont, Microsoft.Xna.Framework.Vector2 position, Microsoft.Xna.Framework.Graphics.Color color, float scale, SpriteFont.CharacterSource text, int offset, int endOffset, Microsoft.Xna.Framework.Vector2 size)
	{
		/*
An exception occurred when decompiling this method (0600068D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean ControlsKeyboardTagHandler::PrintInlineMapping(Microsoft.Xna.Framework.Graphics.SpriteBatch,Microsoft.Xna.Framework.Graphics.SpriteFont,Microsoft.Xna.Framework.Vector2,Microsoft.Xna.Framework.Graphics.Color,System.Single,Microsoft.Xna.Framework.Graphics.SpriteFont/CharacterSource,System.Int32,System.Int32,Microsoft.Xna.Framework.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0047:
	stloc:string(var_22_5B, call:string(Language::GetTextValue, call:string(string::Concat, ldstr:string("KeyboardBindings."), ldstr:string("MouseWheel"))))
	stfld:string(CharacterSource::_string, ldloc:CharacterSource[exp:valuetype Microsoft.Xna.Framework.Graphics.SpriteFont/CharacterSource&](text), ldc.i4:int32[exp:string](0))
	stloc:string(var_23_71, call:string(string::Concat, ldloc:string(var_22_5B), ldstr:string(" ")))
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

	// Token: 0x0600068E RID: 1678 RVA: 0x000151F8 File Offset: 0x000133F8
	public static bool MeasureInlineMapping(SpriteFont spriteFont, SpriteFont.CharacterSource text, int offset, int endOffset, Microsoft.Xna.Framework.Vector2 tagSize)
	{
		Dictionary<char, int> glyphIndex = spriteFont._glyphIndex;
		Dictionary<char, int> glyphIndex2 = spriteFont._glyphIndex;
		Dictionary<char, int> glyphIndex3 = spriteFont._glyphIndex;
		ControllerActionAxis.Entry entry;
		KeyCode key = entry.Key0;
		ControllerActionAxis.Entry entry2;
		KeyCode key2 = entry2.Key1;
		bool flag;
		return flag;
	}

	// Token: 0x0600068F RID: 1679 RVA: 0x00015284 File Offset: 0x00013484
	public TextSnippet Parse(string text, [Optional] Microsoft.Xna.Framework.Graphics.Color baseColor, [Optional] string options)
	{
		/*
An exception occurred when decompiling this method (0600068F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.UI.Chat.TextSnippet ControlsKeyboardTagHandler::Parse(System.String,Microsoft.Xna.Framework.Graphics.Color,System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_2_10, call:string(string::Concat, ldstr:string("[km:"), ldloc:string(var_1), ldstr:string("]")))
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

	// Token: 0x06000690 RID: 1680 RVA: 0x000152A4 File Offset: 0x000134A4
	public ControlsKeyboardTagHandler()
	{
	}

	// Token: 0x020000FC RID: 252
	public class ControlsKeyboardSnippet : TextSnippet
	{
		// Token: 0x06000691 RID: 1681 RVA: 0x000152B8 File Offset: 0x000134B8
		public ControlsKeyboardSnippet(GUIControllerInputButton.LinkedControlType control)
			: base("")
		{
			this._control = control;
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x000152D8 File Offset: 0x000134D8
		public static bool Draw(string binding, bool justCheckingString, [Out] Microsoft.Xna.Framework.Vector2 size, SpriteBatch spriteBatch, SpriteFont spriteFont, [Optional] Microsoft.Xna.Framework.Vector2 position, [Optional] Microsoft.Xna.Framework.Graphics.Color color, float scale = 1f)
		{
			if (true && true)
			{
				if (17279 == 0)
				{
				}
				if (!true)
				{
				}
			}
			return true;
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x000152F8 File Offset: 0x000134F8
		public override float GetStringLength(SpriteFont font)
		{
			/*
An exception occurred when decompiling this method (06000693)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single ControlsKeyboardTagHandler/ControlsKeyboardSnippet::GetStringLength(Microsoft.Xna.Framework.Graphics.SpriteFont)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_06, ldfld:string(ControlsKeyboardSnippet::_binding, ldloc:ControlsKeyboardSnippet(this)))
	stloc:float32(var_1_13, call:float32(Vector2::Length, call:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](SpriteFont::MeasureString, ldloc:SpriteFont(font), ldloc:string(var_0_06))))
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

		// Token: 0x04000509 RID: 1289
		private readonly GUIControllerInputButton.LinkedControlType _control;

		// Token: 0x0400050A RID: 1290
		private readonly string _binding;
	}

	// Token: 0x020000FD RID: 253
	public enum MappingType
	{
		// Token: 0x0400050C RID: 1292
		MoveUp,
		// Token: 0x0400050D RID: 1293
		MoveDown,
		// Token: 0x0400050E RID: 1294
		MoveLeft,
		// Token: 0x0400050F RID: 1295
		MoveRight,
		// Token: 0x04000510 RID: 1296
		Aim,
		// Token: 0x04000511 RID: 1297
		Fire,
		// Token: 0x04000512 RID: 1298
		Jump,
		// Token: 0x04000513 RID: 1299
		Interact,
		// Token: 0x04000514 RID: 1300
		InventoryToggle,
		// Token: 0x04000515 RID: 1301
		CycleLeftPage,
		// Token: 0x04000516 RID: 1302
		CycleRightPage,
		// Token: 0x04000517 RID: 1303
		CyclePreviousHotbarItem,
		// Token: 0x04000518 RID: 1304
		CycleNextHotbarItem,
		// Token: 0x04000519 RID: 1305
		SwitchToWorld,
		// Token: 0x0400051A RID: 1306
		CraftItem,
		// Token: 0x0400051B RID: 1307
		PickupItem,
		// Token: 0x0400051C RID: 1308
		EquipItem,
		// Token: 0x0400051D RID: 1309
		Settings,
		// Token: 0x0400051E RID: 1310
		NavigateInventory,
		// Token: 0x0400051F RID: 1311
		Teleport,
		// Token: 0x04000520 RID: 1312
		ZoomIn,
		// Token: 0x04000521 RID: 1313
		ZoomOut,
		// Token: 0x04000522 RID: 1314
		NavigateHotbar,
		// Token: 0x04000523 RID: 1315
		Count
	}
}
