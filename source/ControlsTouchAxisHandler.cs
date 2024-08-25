using System;
using System.Runtime.InteropServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI.Chat;

// Token: 0x020000FE RID: 254
public class ControlsTouchAxisHandler : ITagHandler
{
	// Token: 0x06000694 RID: 1684 RVA: 0x00015318 File Offset: 0x00013518
	public static bool MeasureInline(SpriteFont.CharacterSource text, int offset, int endOffset, Vector2 size)
	{
		/*
An exception occurred when decompiling this method (06000694)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean ControlsTouchAxisHandler::MeasureInline(Microsoft.Xna.Framework.Graphics.SpriteFont/CharacterSource,System.Int32,System.Int32,Microsoft.Xna.Framework.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_01, ldc.i4:int32(1))
	stfld:int32(int32::m_value, ldloc:int32[exp:int32&](endOffset), ldloc:int32(var_0_01))
	stloc:int32(var_11_10, ldfld:int32(Texture2D::Width, ldloc:Texture2D(var_10)))
	stloc:int32(var_13_19, ldfld:int32(Texture2D::Height, ldloc:Texture2D(var_12)))
	stloc:int32(var_17_25, ldfld:int32(Texture2D::Width, ldloc:Texture2D(var_16)))
	stloc:int32(var_19_2E, ldfld:int32(Texture2D::Height, ldloc:Texture2D(var_18)))
	stloc:Vector2(var_22_37, call:Vector2(Utils::Size, ldloc:Rectangle(var_21)))
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

	// Token: 0x06000695 RID: 1685 RVA: 0x0001536C File Offset: 0x0001356C
	public static bool PrintInline(SpriteBatch spriteBatch, Vector2 position, Color color, float scale, SpriteFont.CharacterSource text, int offset, int endOffset, Vector2 size)
	{
		/*
An exception occurred when decompiling this method (06000695)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean ControlsTouchAxisHandler::PrintInline(Microsoft.Xna.Framework.Graphics.SpriteBatch,Microsoft.Xna.Framework.Vector2,Microsoft.Xna.Framework.Graphics.Color,System.Single,Microsoft.Xna.Framework.Graphics.SpriteFont/CharacterSource,System.Int32,System.Int32,Microsoft.Xna.Framework.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stfld:string(CharacterSource::_string, ldloc:CharacterSource[exp:valuetype Microsoft.Xna.Framework.Graphics.SpriteFont/CharacterSource&](text), ldc.i4:int32[exp:string](0))
	stloc:int32(var_11_11, ldfld:int32(Texture2D::Width, ldloc:Texture2D(var_10)))
	stloc:int32(var_13_1A, ldfld:int32(Texture2D::Height, ldloc:Texture2D(var_12)))
	stloc:int32(var_18_29, ldfld:int32(Texture2D::Width, ldloc:Texture2D(var_17)))
	stloc:int32(var_20_32, ldfld:int32(Texture2D::Height, ldloc:Texture2D(var_19)))
	stloc:int32(var_23_3E, ldfld:int32(CharacterSource::Length, ldloc:CharacterSource[exp:valuetype Microsoft.Xna.Framework.Graphics.SpriteFont/CharacterSource&](text)))
	stloc:StringBuilder(var_24_47, ldfld:StringBuilder(CharacterSource::_builder, ldloc:CharacterSource[exp:valuetype Microsoft.Xna.Framework.Graphics.SpriteFont/CharacterSource&](text)))
	stloc:int32(var_25_50, ldfld:int32(CharacterSource::Length, ldloc:CharacterSource[exp:valuetype Microsoft.Xna.Framework.Graphics.SpriteFont/CharacterSource&](text)))
	stloc:int32(var_27_59, ldfld:int32(Texture2D::Width, ldloc:Texture2D(var_26)))
	stloc:int32(var_29_62, ldfld:int32(Texture2D::Height, ldloc:Texture2D(var_28)))
	stloc:Vector2(var_32_6B, call:Vector2(Utils::Size, ldloc:Rectangle(var_31)))
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

	// Token: 0x06000696 RID: 1686 RVA: 0x000153E8 File Offset: 0x000135E8
	public TextSnippet Parse(string text, [Optional] Color baseColour, [Optional] string options)
	{
	}

	// Token: 0x06000697 RID: 1687 RVA: 0x000153F8 File Offset: 0x000135F8
	public ControlsTouchAxisHandler()
	{
	}
}
