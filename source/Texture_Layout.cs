using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Newtonsoft.Json;

// Token: 0x020001C2 RID: 450
[JsonObject(MemberSerialization.OptIn)]
[Serializable]
public class Texture_Layout
{
	// Token: 0x06000BDD RID: 3037 RVA: 0x0003B83C File Offset: 0x00039A3C
	public Texture_Layout()
	{
	}

	// Token: 0x06000BDE RID: 3038 RVA: 0x0003B850 File Offset: 0x00039A50
	public void Copy(Texture_Layout other)
	{
		string textureId = other.TextureId;
		this.TextureId = textureId;
	}

	// Token: 0x06000BDF RID: 3039 RVA: 0x0003B86C File Offset: 0x00039A6C
	public Texture_Layout(string defaultTextureId)
	{
		this.TextureId = defaultTextureId;
	}

	// Token: 0x06000BE0 RID: 3040 RVA: 0x0003B888 File Offset: 0x00039A88
	public void Write(BinaryWriter writer)
	{
		string textureId = this.TextureId;
	}

	// Token: 0x06000BE1 RID: 3041 RVA: 0x0003B89C File Offset: 0x00039A9C
	public void Load(int version, BinaryReader reader)
	{
		this.TextureId = reader;
	}

	// Token: 0x17000145 RID: 325
	// (get) Token: 0x06000BE2 RID: 3042 RVA: 0x0003B8B0 File Offset: 0x00039AB0
	public Texture2D Texture
	{
		get
		{
			/*
An exception occurred when decompiling this method (06000BE2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.Texture2D Texture_Layout::get_Texture()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0047:
	stloc:string(var_7_4D, ldfld:string(Texture_Layout::TextureId, ldloc:Texture_Layout(this)))
	stloc:string(var_9_55, ldfld:string(Texture_Layout::TextureId, ldloc:Texture_Layout(this)))
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

	// Token: 0x06000BE3 RID: 3043 RVA: 0x0003B914 File Offset: 0x00039B14
	public static void Setup(ContentManager manager)
	{
		if (!true)
		{
		}
	}

	// Token: 0x06000BE4 RID: 3044 RVA: 0x0003B924 File Offset: 0x00039B24
	// Note: this type is marked as 'beforefieldinit'.
	static Texture_Layout()
	{
	}

	// Token: 0x04000F38 RID: 3896
	[JsonProperty]
	public string TextureId;

	// Token: 0x04000F39 RID: 3897
	private Texture2D _texture;

	// Token: 0x04000F3A RID: 3898
	private string _lastTextureId;

	// Token: 0x04000F3B RID: 3899
	private static ContentManager _contentManager;

	// Token: 0x04000F3C RID: 3900
	private static Dictionary<string, Texture2D> _textureDictionary;
}
