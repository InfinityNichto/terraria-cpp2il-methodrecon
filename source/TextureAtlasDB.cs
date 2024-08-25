using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using UnityEngine;

// Token: 0x020002E6 RID: 742
public class TextureAtlasDB
{
	// Token: 0x17000197 RID: 407
	// (get) Token: 0x06001124 RID: 4388 RVA: 0x0005542C File Offset: 0x0005362C
	public static bool DefaultTexturesHigh
	{
		get
		{
			long deviceMemory = GUILowMemoryPopup.DeviceMemory;
			return SystemInfo.SupportsTextureFormat(TextureFormat.ETC2_RGBA8);
		}
	}

	// Token: 0x06001125 RID: 4389 RVA: 0x0005544C File Offset: 0x0005364C
	public static void LoadTextureDBs()
	{
		if (!true)
		{
		}
		if (!TextureAtlasDB.DefaultTexturesHigh)
		{
		}
		string text;
		TextureAtlasDB textureAtlasDB = TextureAtlasDB.LoadDB(text, false);
	}

	// Token: 0x06001126 RID: 4390 RVA: 0x00055478 File Offset: 0x00053678
	public static bool LoadTexture(string file, [Out] TextureAtlasDB atlas, [Out] TextureAtlasEntry atlasEntry)
	{
		string text;
		int num = UID.Generate(text + ".png");
		if (".png" == null)
		{
		}
		if (".png" == null)
		{
			return;
		}
	}

	// Token: 0x17000198 RID: 408
	// (get) Token: 0x06001127 RID: 4391 RVA: 0x000554AC File Offset: 0x000536AC
	private string ContentRoot
	{
		get
		{
			/*
An exception occurred when decompiling this method (06001127)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String TextureAtlasDB::get_ContentRoot()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_0_06, ldfld:bool(TextureAtlasDB::UseLowResTextures, ldloc:TextureAtlasDB(this)))
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

	// Token: 0x06001128 RID: 4392 RVA: 0x000021DB File Offset: 0x000003DB
	private static TextureAtlasDB LoadDB(string id, bool useLowResTextures = false)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06001129 RID: 4393 RVA: 0x000554C0 File Offset: 0x000536C0
	public TextureAtlasDB(string id)
	{
		this.Id = id;
	}

	// Token: 0x0600112A RID: 4394 RVA: 0x000554E4 File Offset: 0x000536E4
	public void SetNumberOfAtlasPages(short pages)
	{
		global::UnityEngine.Texture2D[] textures = this.Textures;
		global::UnityEngine.Texture2D[] textures2 = this.Textures;
		global::UnityEngine.Texture2D[] texturesAlpha = this.TexturesAlpha;
		global::UnityEngine.Texture2D[] texturesAlpha2 = this.TexturesAlpha;
		global::UnityEngine.Texture2D[] texturesPal = this.TexturesPal;
		global::UnityEngine.Texture2D[] texturesPal2 = this.TexturesPal;
		this.NumberOfPages = pages;
		int num = 2048;
		int[] batchTextureIndex = this.BatchTextureIndex;
		int batchId = Microsoft.Xna.Framework.Graphics.Texture2D.GetBatchId();
		batchTextureIndex.m_value = batchId;
		this.TextureWidth.m_value = num;
		this.TextureHeight.m_value = num;
	}

	// Token: 0x0600112B RID: 4395 RVA: 0x00055564 File Offset: 0x00053764
	private void LoadTextures()
	{
		global::UnityEngine.Texture2D[] textures = this.Textures;
		long num = 0L;
		global::UnityEngine.Texture2D texture2D = this.AltlasTexture((int)num);
		global::UnityEngine.Texture2D[] textures2 = this.Textures;
	}

	// Token: 0x0600112C RID: 4396 RVA: 0x0005558C File Offset: 0x0005378C
	public void AddEntry(TextureAtlasEntry entry)
	{
		Dictionary<int, TextureAtlasEntry> atlasEntries = this.AtlasEntries;
		int textureId = entry.TextureId;
	}

	// Token: 0x0600112D RID: 4397 RVA: 0x000555A8 File Offset: 0x000537A8
	public void Load()
	{
		string contentRoot = this.ContentRoot;
		string id = this.Id;
		TextAsset textAsset = ContentManager.LoadUnityResource<TextAsset>(contentRoot + id);
		if (textAsset.bytes != null)
		{
			byte[] bytes = textAsset.bytes;
			return;
		}
		long num = 0L;
		this.SetNumberOfAtlasPages((short)num);
	}

	// Token: 0x0600112E RID: 4398 RVA: 0x0005569C File Offset: 0x0005389C
	public byte[] Save()
	{
		short numberOfPages = this.NumberOfPages;
		int[] textureWidth = this.TextureWidth;
		int[] textureHeight = this.TextureHeight;
		Dictionary<int, TextureAtlasEntry> atlasEntries = this.AtlasEntries;
		Dictionary<int, TextureAtlasEntry> atlasEntries2 = this.AtlasEntries;
		long num = 0L;
		int num2 = 6;
		if (num != 0L)
		{
			throw new OutOfMemoryException();
		}
		if (num2 == 0)
		{
		}
		if (!false)
		{
			if (!false)
			{
			}
			throw new OutOfMemoryException();
		}
		throw new OutOfMemoryException();
	}

	// Token: 0x0600112F RID: 4399 RVA: 0x0005573C File Offset: 0x0005393C
	private void LoadCallback(global::UnityEngine.Texture2D tex0, global::UnityEngine.Texture2D tex1, global::UnityEngine.Texture2D tex2, int page)
	{
		do
		{
			global::UnityEngine.Texture2D[] textures = this.Textures;
			if (tex0 != null && tex0 == null)
			{
				goto IL_0050;
			}
			global::UnityEngine.Texture2D[] texturesAlpha = this.TexturesAlpha;
			if (tex1 != null && tex1 == null)
			{
				goto IL_0050;
			}
			global::UnityEngine.Texture2D[] texturesPal = this.TexturesPal;
			if (tex2 != null && tex2 == null)
			{
				goto IL_0050;
			}
			global::UnityEngine.Texture2D[] textures2 = this.Textures;
			int[] textureWidth = this.TextureWidth;
			global::UnityEngine.Texture2D[] textures3 = this.Textures;
			int[] textureHeight = this.TextureHeight;
		}
		while (this.AtlasEntries == null);
		return;
		IL_0050:
		throw new ArrayTypeMismatchException();
	}

	// Token: 0x06001130 RID: 4400 RVA: 0x000557B8 File Offset: 0x000539B8
	public void LoadTexturesAsync(int index)
	{
		global::UnityEngine.Texture2D[] textures = this.Textures;
		bool[] texturesLoadRequested = this.TexturesLoadRequested;
		int num = 1;
		texturesLoadRequested.m_value = num != 0;
		string contentRoot = this.ContentRoot;
		string id = this.Id;
		string text2;
		string text = contentRoot + id + text2;
		string text3 = text + "_A";
		string text4 = text + "_P";
	}

	// Token: 0x06001131 RID: 4401 RVA: 0x00055818 File Offset: 0x00053A18
	public global::UnityEngine.Texture2D AltlasTexture(int index)
	{
		global::UnityEngine.Texture2D[] textures = this.Textures;
		global::UnityEngine.Texture2D[] textures2 = this.Textures;
		string contentRoot = this.ContentRoot;
		string id = this.Id;
		string text;
		global::UnityEngine.Texture2D texture2D = ContentManager.LoadUnityResource<global::UnityEngine.Texture2D>(contentRoot + id + text);
		if (texture2D == null || texture2D != null)
		{
			global::UnityEngine.Texture2D[] textures3 = this.Textures;
			int[] textureWidth = this.TextureWidth;
			global::UnityEngine.Texture2D[] textures4 = this.Textures;
			int[] textureHeight = this.TextureHeight;
			global::UnityEngine.Texture2D[] texturesAlpha = this.TexturesAlpha;
			string contentRoot2 = this.ContentRoot;
			string id2 = this.Id;
			string text2;
			global::UnityEngine.Texture2D texture2D2 = ContentManager.LoadUnityResource<global::UnityEngine.Texture2D>(contentRoot2 + id2 + text2 + "_A");
			if (texture2D2 == null || texture2D2 != null)
			{
				global::UnityEngine.Texture2D[] texturesPal = this.TexturesPal;
				string contentRoot3 = this.ContentRoot;
				string id3 = this.Id;
				string text3;
				global::UnityEngine.Texture2D texture2D3 = ContentManager.LoadUnityResource<global::UnityEngine.Texture2D>(contentRoot3 + id3 + text3 + "_P");
				if (texture2D3 == null || texture2D3 != null)
				{
					global::UnityEngine.Texture2D[] textures5 = this.Textures;
					return texture2D3;
				}
			}
		}
		throw new ArrayTypeMismatchException();
	}

	// Token: 0x06001132 RID: 4402 RVA: 0x000558FC File Offset: 0x00053AFC
	public global::UnityEngine.Texture2D AltlasAlphaTexture(int index)
	{
		/*
An exception occurred when decompiling this method (06001132)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.Texture2D TextureAtlasDB::AltlasAlphaTexture(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [UnityEngine.CoreModule]UnityEngine.Texture2D[](var_0_06, ldfld:class [UnityEngine.CoreModule]UnityEngine.Texture2D[](TextureAtlasDB::TexturesAlpha, ldloc:TextureAtlasDB(this)))
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

	// Token: 0x06001133 RID: 4403 RVA: 0x00055910 File Offset: 0x00053B10
	public global::UnityEngine.Texture2D AltlasPalTexture(int index)
	{
		/*
An exception occurred when decompiling this method (06001133)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.Texture2D TextureAtlasDB::AltlasPalTexture(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [UnityEngine.CoreModule]UnityEngine.Texture2D[](var_0_06, ldfld:class [UnityEngine.CoreModule]UnityEngine.Texture2D[](TextureAtlasDB::TexturesPal, ldloc:TextureAtlasDB(this)))
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

	// Token: 0x06001134 RID: 4404 RVA: 0x00055924 File Offset: 0x00053B24
	public bool GetTexture(int fileUID, [Out] TextureAtlasDB atlas, [Out] TextureAtlasEntry atlasEntry)
	{
		Dictionary<int, TextureAtlasEntry> atlasEntries = this.AtlasEntries;
		return true;
	}

	// Token: 0x06001135 RID: 4405 RVA: 0x0005593C File Offset: 0x00053B3C
	private static void SwitchAtlas(int atlas, bool useLowRes)
	{
		int num = 1;
		if (num == 0)
		{
		}
		if (num == 0)
		{
		}
	}

	// Token: 0x17000199 RID: 409
	// (get) Token: 0x06001136 RID: 4406 RVA: 0x00055954 File Offset: 0x00053B54
	// (set) Token: 0x06001137 RID: 4407 RVA: 0x00055964 File Offset: 0x00053B64
	public static bool UITexturesHigh
	{
		get
		{
			/*
An exception occurred when decompiling this method (06001136)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean TextureAtlasDB::get_UITexturesHigh()

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
		set
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			TextureAtlasDB.SwitchAtlas(12, value);
			TextureAtlasDB.SwitchAtlas(13, value);
			TextureAtlasDB.SwitchAtlas(14, value);
			TextureAtlasDB.SwitchAtlas(7, value);
		}
	}

	// Token: 0x1700019A RID: 410
	// (get) Token: 0x06001138 RID: 4408 RVA: 0x00055998 File Offset: 0x00053B98
	// (set) Token: 0x06001139 RID: 4409 RVA: 0x000559A8 File Offset: 0x00053BA8
	public static bool CharacterTexturesHigh
	{
		get
		{
			/*
An exception occurred when decompiling this method (06001138)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean TextureAtlasDB::get_CharacterTexturesHigh()

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
		set
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			TextureAtlasDB.SwitchAtlas(6, value);
			TextureAtlasDB.SwitchAtlas(2, value);
		}
	}

	// Token: 0x1700019B RID: 411
	// (get) Token: 0x0600113A RID: 4410 RVA: 0x000559CC File Offset: 0x00053BCC
	// (set) Token: 0x0600113B RID: 4411 RVA: 0x000559DC File Offset: 0x00053BDC
	public static bool ProjectileTexturesHigh
	{
		get
		{
			/*
An exception occurred when decompiling this method (0600113A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean TextureAtlasDB::get_ProjectileTexturesHigh()

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
		set
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
		}
	}

	// Token: 0x1700019C RID: 412
	// (get) Token: 0x0600113C RID: 4412 RVA: 0x000559F0 File Offset: 0x00053BF0
	// (set) Token: 0x0600113D RID: 4413 RVA: 0x00055A00 File Offset: 0x00053C00
	public static bool BackgroundTexturesHigh
	{
		get
		{
			/*
An exception occurred when decompiling this method (0600113C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean TextureAtlasDB::get_BackgroundTexturesHigh()

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
		set
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			TextureAtlasDB.SwitchAtlas(15, value);
			TextureAtlasDB.SwitchAtlas(1, value);
			TextureAtlasDB.SwitchAtlas(11, value);
		}
	}

	// Token: 0x1700019D RID: 413
	// (get) Token: 0x0600113E RID: 4414 RVA: 0x00055A2C File Offset: 0x00053C2C
	// (set) Token: 0x0600113F RID: 4415 RVA: 0x00055A3C File Offset: 0x00053C3C
	public static bool GoreTexturesHigh
	{
		get
		{
			/*
An exception occurred when decompiling this method (0600113E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean TextureAtlasDB::get_GoreTexturesHigh()

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
		set
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
		}
	}

	// Token: 0x1700019E RID: 414
	// (get) Token: 0x06001140 RID: 4416 RVA: 0x00055A50 File Offset: 0x00053C50
	// (set) Token: 0x06001141 RID: 4417 RVA: 0x00055A60 File Offset: 0x00053C60
	public static bool GlowTexturesHigh
	{
		get
		{
			/*
An exception occurred when decompiling this method (06001140)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean TextureAtlasDB::get_GlowTexturesHigh()

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
		set
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
		}
	}

	// Token: 0x1700019F RID: 415
	// (get) Token: 0x06001142 RID: 4418 RVA: 0x00055A74 File Offset: 0x00053C74
	// (set) Token: 0x06001143 RID: 4419 RVA: 0x00055A84 File Offset: 0x00053C84
	public static bool EnvironmentTexturesHigh
	{
		get
		{
			/*
An exception occurred when decompiling this method (06001142)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean TextureAtlasDB::get_EnvironmentTexturesHigh()

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
		set
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			TextureAtlasDB.SwitchAtlas(0, value);
			TextureAtlasDB.SwitchAtlas(3, value);
			TextureAtlasDB.SwitchAtlas(4, value);
			TextureAtlasDB.SwitchAtlas(5, value);
		}
	}

	// Token: 0x06001144 RID: 4420 RVA: 0x00055AB4 File Offset: 0x00053CB4
	public static bool PendingAssetUnload()
	{
		if (!true)
		{
		}
		return true;
	}

	// Token: 0x06001145 RID: 4421 RVA: 0x00055AC8 File Offset: 0x00053CC8
	public static void ActionPendingUnloadAssets(bool fromLowMemory = false)
	{
	}

	// Token: 0x06001146 RID: 4422 RVA: 0x00055AE4 File Offset: 0x00053CE4
	public static void UnloadAssets()
	{
		if (!true)
		{
		}
	}

	// Token: 0x06001147 RID: 4423 RVA: 0x00055AF4 File Offset: 0x00053CF4
	// Note: this type is marked as 'beforefieldinit'.
	static TextureAtlasDB()
	{
	}

	// Token: 0x040020EA RID: 8426
	public int[] BatchTextureIndex;

	// Token: 0x040020EB RID: 8427
	public int[] TextureWidth;

	// Token: 0x040020EC RID: 8428
	public int[] TextureHeight;

	// Token: 0x040020ED RID: 8429
	private bool UseLowResTextures = true;

	// Token: 0x040020EE RID: 8430
	private short NumberOfPages;

	// Token: 0x040020EF RID: 8431
	private string Id;

	// Token: 0x040020F0 RID: 8432
	private bool loaded;

	// Token: 0x040020F1 RID: 8433
	private bool[] TexturesLoadRequested;

	// Token: 0x040020F2 RID: 8434
	private global::UnityEngine.Texture2D[] Textures;

	// Token: 0x040020F3 RID: 8435
	private global::UnityEngine.Texture2D[] TexturesAlpha;

	// Token: 0x040020F4 RID: 8436
	private global::UnityEngine.Texture2D[] TexturesPal;

	// Token: 0x040020F5 RID: 8437
	private Dictionary<int, TextureAtlasEntry> AtlasEntries;

	// Token: 0x040020F6 RID: 8438
	public static List<TextureAtlasDB> AltlasDBs;

	// Token: 0x040020F7 RID: 8439
	private static bool _uiTexturesHigh;

	// Token: 0x040020F8 RID: 8440
	private static bool _characterTexturesHigh;

	// Token: 0x040020F9 RID: 8441
	private static bool _projectileTexturesHigh;

	// Token: 0x040020FA RID: 8442
	private static bool _backgroundTexturesHigh;

	// Token: 0x040020FB RID: 8443
	private static bool _goreTexturesHigh;

	// Token: 0x040020FC RID: 8444
	private static bool _glowTexturesHigh;

	// Token: 0x040020FD RID: 8445
	private static bool _environmentTexturesHigh;

	// Token: 0x040020FE RID: 8446
	private static List<TextureAtlasDB.SwitchEntry> pendingSwitches;

	// Token: 0x040020FF RID: 8447
	private static bool PendingUnload;

	// Token: 0x020002E7 RID: 743
	public enum AtlasIds
	{
		// Token: 0x04002101 RID: 8449
		Tiles,
		// Token: 0x04002102 RID: 8450
		Misc,
		// Token: 0x04002103 RID: 8451
		NPC,
		// Token: 0x04002104 RID: 8452
		Walls,
		// Token: 0x04002105 RID: 8453
		Waterfall,
		// Token: 0x04002106 RID: 8454
		Trees,
		// Token: 0x04002107 RID: 8455
		Player,
		// Token: 0x04002108 RID: 8456
		Item,
		// Token: 0x04002109 RID: 8457
		Projectile,
		// Token: 0x0400210A RID: 8458
		Gore,
		// Token: 0x0400210B RID: 8459
		Glow,
		// Token: 0x0400210C RID: 8460
		MapBG,
		// Token: 0x0400210D RID: 8461
		UI,
		// Token: 0x0400210E RID: 8462
		Buff,
		// Token: 0x0400210F RID: 8463
		MiniMap,
		// Token: 0x04002110 RID: 8464
		Background,
		// Token: 0x04002111 RID: 8465
		Count
	}

	// Token: 0x020002E8 RID: 744
	private struct SwitchEntry
	{
		// Token: 0x04002112 RID: 8466
		public int atlas;

		// Token: 0x04002113 RID: 8467
		public bool useLowRes;
	}
}
