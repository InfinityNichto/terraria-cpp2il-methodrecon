using System;
using System.IO;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x020002E9 RID: 745
public class TextureAtlasEntry
{
	// Token: 0x06001148 RID: 4424 RVA: 0x00055B04 File Offset: 0x00053D04
	public TextureAtlasEntry(int textureId)
	{
		this.TextureId = textureId;
	}

	// Token: 0x06001149 RID: 4425 RVA: 0x00055B20 File Offset: 0x00053D20
	public TextureAtlasEntry(int textureId, int atlasIndex, short textureWidth, short textureHeight, short textureOffsetX, short textureOffsetY, short textureScale)
	{
		this.TextureId = textureId;
		this.TextureOffsetX = (short)atlasIndex;
		this.TextureWidth = textureWidth;
		this.TextureHeight = textureHeight;
		this.TextureOffsetX = textureOffsetX;
		this.TextureOffsetY = textureOffsetY;
		this.TextureScale = textureScale;
	}

	// Token: 0x0600114A RID: 4426 RVA: 0x00055B68 File Offset: 0x00053D68
	public void Save(BinaryWriter writer)
	{
		int textureId = this.TextureId;
		int atlasIndex = this.AtlasIndex;
		short textureWidth = this.TextureWidth;
		short textureHeight = this.TextureHeight;
		short textureOffsetX = this.TextureOffsetX;
		short textureOffsetY = this.TextureOffsetY;
		short textureScale = this.TextureScale;
		short tileWidth = this.TileWidth;
		short tileHeight = this.TileHeight;
		bool tileTrimming = this.TileTrimming;
		TextureAtlasEntry.TextureAtlasEntryTiles.SaveTileData(writer, this);
	}

	// Token: 0x0600114B RID: 4427 RVA: 0x000021DB File Offset: 0x000003DB
	public static TextureAtlasEntry Load(BinaryReader loader, short version)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x0600114C RID: 4428 RVA: 0x00055BCC File Offset: 0x00053DCC
	public void LoadData(BinaryReader loader, short version)
	{
		this.AtlasIndex = loader;
		this.TextureWidth = loader;
		this.TextureHeight = loader;
		this.TextureOffsetX = loader;
		this.TextureOffsetY = loader;
		this.TextureScale = loader;
		this.TileWidth = loader;
		this.TileHeight = loader;
		short tileWidth = this.TileWidth;
		TextureAtlasEntry.TextureAtlasEntryTiles.LoadTileData(loader, this);
	}

	// Token: 0x04002114 RID: 8468
	public int TextureId;

	// Token: 0x04002115 RID: 8469
	public int AtlasIndex;

	// Token: 0x04002116 RID: 8470
	public short TextureOffsetX;

	// Token: 0x04002117 RID: 8471
	public short TextureOffsetY;

	// Token: 0x04002118 RID: 8472
	public short TextureWidth;

	// Token: 0x04002119 RID: 8473
	public short TextureHeight;

	// Token: 0x0400211A RID: 8474
	public short TileWidth;

	// Token: 0x0400211B RID: 8475
	public short TileHeight;

	// Token: 0x0400211C RID: 8476
	public bool TileTrimming;

	// Token: 0x0400211D RID: 8477
	public short TextureScale;

	// Token: 0x0400211E RID: 8478
	public int TileDataOffset;

	// Token: 0x0400211F RID: 8479
	public Texture2D AttachedTexture;

	// Token: 0x020002EA RID: 746
	public static class TextureAtlasEntryTiles
	{
		// Token: 0x0600114D RID: 4429 RVA: 0x00055C34 File Offset: 0x00053E34
		public static void Reset()
		{
			if (!true)
			{
			}
		}

		// Token: 0x0600114E RID: 4430 RVA: 0x00055C44 File Offset: 0x00053E44
		public static void LoadTileData(BinaryReader loader, TextureAtlasEntry entry)
		{
			int num = 1;
			int tileDataOffset = entry.TileDataOffset;
			if (num == 0)
			{
			}
		}

		// Token: 0x0600114F RID: 4431 RVA: 0x00055C70 File Offset: 0x00053E70
		public static void SaveTileData(BinaryWriter writer, TextureAtlasEntry entry)
		{
			if (!true)
			{
			}
			if (!entry.TileTrimming)
			{
			}
		}

		// Token: 0x06001150 RID: 4432 RVA: 0x000021DB File Offset: 0x000003DB
		public static int CalculateFrameCount(TextureAtlasEntry entry)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001151 RID: 4433 RVA: 0x00055C88 File Offset: 0x00053E88
		public static int ReserveData(TextureAtlasEntry entry)
		{
			/*
An exception occurred when decompiling this method (06001151)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 TextureAtlasEntry/TextureAtlasEntryTiles::ReserveData(TextureAtlasEntry)

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

		// Token: 0x06001152 RID: 4434 RVA: 0x00055C98 File Offset: 0x00053E98
		// Note: this type is marked as 'beforefieldinit'.
		static TextureAtlasEntryTiles()
		{
		}

		// Token: 0x04002120 RID: 8480
		public static short[] TileOffsetData;

		// Token: 0x04002121 RID: 8481
		private static int TileDataOffset;
	}
}
