using System;
using System.IO;
using Cpp2IlInjected;
using UnityEngine;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x020003AA RID: 938
	public class Texture2D : Texture
	{
		// Token: 0x06001911 RID: 6417 RVA: 0x0006A56C File Offset: 0x0006876C
		public void ResetLoaded()
		{
			if (this._textureLoaded)
			{
				TextureAtlasDB textureAtlas = this._textureAtlas;
				if (textureAtlas == null)
				{
					Texture2D unityTexture = this._unityTexture;
					if (textureAtlas == null)
					{
					}
					Resources.UnloadAsset(this._unityTexture);
					Texture2D unityAlphaTexture = this._unityAlphaTexture;
					if (textureAtlas == null)
					{
					}
					Resources.UnloadAsset(this._unityAlphaTexture);
					Texture2D unityPalTexture = this._unityPalTexture;
					if (textureAtlas == null)
					{
					}
					Resources.UnloadAsset(this._unityPalTexture);
				}
			}
			TextureAtlasDB textureAtlas2 = this._textureAtlas;
			if (textureAtlas2 != null)
			{
				TextureAtlasEntry packedEntry = this.PackedEntry;
				int[] textureWidth = textureAtlas2.TextureWidth;
				bool sharedBatching = this.SharedBatching;
				int[] textureHeight = textureAtlas2.TextureHeight;
				this.UnityHeight = textureHeight;
				if (sharedBatching)
				{
					int[] batchTextureIndex = textureAtlas2.BatchTextureIndex;
					return;
				}
			}
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06001912 RID: 6418 RVA: 0x0006A610 File Offset: 0x00068810
		public int UnityTextureWidth
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001912)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Microsoft.Xna.Framework.Graphics.Texture2D::get_UnityTextureWidth()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_1:
	stloc:TextureAtlasEntry(var_2_1F, ldfld:TextureAtlasEntry(Texture2D::PackedEntry, ldloc:Texture2D(this)))
	stloc:int32[](var_3_26, ldfld:int32[](TextureAtlasDB::TextureWidth, ldloc:TextureAtlasDB(var_1_15)))
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

		// Token: 0x06001913 RID: 6419 RVA: 0x0006A644 File Offset: 0x00068844
		private void LoadCallback(Texture2D tex0, Texture2D tex1, Texture2D tex2, int page)
		{
			this._unityTexture = tex0;
			this._unityAlphaTexture = tex1;
			this._unityPalTexture = tex2;
			this._textureLoaded = true;
			bool flag = this._unityAlphaTexture != tex0;
			Texture2D unityAlphaTexture = this._unityAlphaTexture;
		}

		// Token: 0x06001914 RID: 6420 RVA: 0x0006A6A0 File Offset: 0x000688A0
		private void LoadSourceTexture()
		{
			if (!this.loadRequested)
			{
				this.loadRequested = true;
				string text = this._sourceLoadAsset + "_A";
				string text2 = this._sourceLoadAsset + "_P";
				return;
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06001915 RID: 6421 RVA: 0x0006A774 File Offset: 0x00068974
		public int UnityTextureHeight
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001915)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Microsoft.Xna.Framework.Graphics.Texture2D::get_UnityTextureHeight()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_1:
	stloc:TextureAtlasEntry(var_2_1F, ldfld:TextureAtlasEntry(Texture2D::PackedEntry, ldloc:Texture2D(this)))
	stloc:int32[](var_3_26, ldfld:int32[](TextureAtlasDB::TextureHeight, ldloc:TextureAtlasDB(var_1_15)))
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

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06001916 RID: 6422 RVA: 0x0006A7A8 File Offset: 0x000689A8
		public Texture UnityBindTexture
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001916)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.Texture Microsoft.Xna.Framework.Graphics.Texture2D::get_UnityBindTexture()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000A:
	stloc:RenderTexture(var_2_10, ldfld:RenderTexture(Texture2D::_unityRenderTexture, ldloc:Texture2D(this)))
	stloc:Texture2D(var_3_17, callgetter:Texture2D(Texture2D::get_UnityTexture, ldloc:Texture2D(this)))
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

		// Token: 0x06001917 RID: 6423 RVA: 0x0006A7CC File Offset: 0x000689CC
		public void RefreshAtlasTexture()
		{
			if (!this._textureLoaded)
			{
				TextureAtlasDB textureAtlas = this._textureAtlas;
				if (textureAtlas != null)
				{
					int atlasIndex = this.PackedEntry.AtlasIndex;
					Texture2D texture2D = textureAtlas.AltlasTexture(atlasIndex);
					TextureAtlasEntry packedEntry = this.PackedEntry;
					this._unityTexture = texture2D;
					TextureAtlasDB textureAtlas2 = this._textureAtlas;
					int atlasIndex2 = packedEntry.AtlasIndex;
					Texture2D texture2D2 = textureAtlas2.AltlasAlphaTexture(atlasIndex2);
					TextureAtlasEntry packedEntry2 = this.PackedEntry;
					this._unityAlphaTexture = texture2D2;
					TextureAtlasDB textureAtlas3 = this._textureAtlas;
					int atlasIndex3 = packedEntry2.AtlasIndex;
					Texture2D texture2D3 = textureAtlas3.AltlasPalTexture(atlasIndex3);
					Texture2D unityTexture = this._unityTexture;
					this._unityPalTexture = texture2D3;
					this._textureLoaded = true;
					Texture2D unityTexture2 = this._unityTexture;
					this.UnityWidth = unityTexture;
					this.UnityHeight = unityTexture2;
				}
			}
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06001918 RID: 6424 RVA: 0x0006A88C File Offset: 0x00068A8C
		public Texture2D UnityTexture
		{
			get
			{
				if (this._textureLoaded)
				{
					return this._unityTexture;
				}
				TextureAtlasDB textureAtlas = this._textureAtlas;
				if (textureAtlas != null)
				{
					int atlasIndex = this.PackedEntry.AtlasIndex;
					textureAtlas.LoadTexturesAsync(atlasIndex);
				}
				string sourceLoadAsset = this._sourceLoadAsset;
				bool flag = string.IsNullOrEmpty(sourceLoadAsset);
				this.LoadSourceTexture();
				TextureAtlasEntry packedEntry = this.PackedEntry;
				Texture2D texture2D;
				this._unityTexture = texture2D;
				TextureAtlasDB textureAtlas2 = this._textureAtlas;
				int atlasIndex2 = packedEntry.AtlasIndex;
				Texture2D texture2D2 = textureAtlas2.AltlasAlphaTexture(atlasIndex2);
				TextureAtlasEntry packedEntry2 = this.PackedEntry;
				this._unityAlphaTexture = texture2D2;
				TextureAtlasDB textureAtlas3 = this._textureAtlas;
				int atlasIndex3 = packedEntry2.AtlasIndex;
				Texture2D texture2D3 = textureAtlas3.AltlasPalTexture(atlasIndex3);
				Texture2D unityTexture = this._unityTexture;
				this._unityPalTexture = texture2D3;
				this._textureLoaded = true;
				Texture2D unityTexture2 = this._unityTexture;
				this.UnityWidth = unityTexture;
				this.UnityHeight = unityTexture2;
				return unityTexture2;
			}
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06001919 RID: 6425 RVA: 0x0006A968 File Offset: 0x00068B68
		public Texture2D UnityAlphaTexture
		{
			get
			{
				return this._unityAlphaTexture;
			}
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x0600191A RID: 6426 RVA: 0x0006A97C File Offset: 0x00068B7C
		public Texture2D UnityPalTexture
		{
			get
			{
				return this._unityPalTexture;
			}
		}

		// Token: 0x0600191B RID: 6427 RVA: 0x000021DB File Offset: 0x000003DB
		public static int GetBatchId()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600191C RID: 6428 RVA: 0x0006A990 File Offset: 0x00068B90
		public void RefreshBatchIndex()
		{
			TextureAtlasDB textureAtlas = this._textureAtlas;
			if (textureAtlas != null && this.SharedBatching)
			{
				TextureAtlasEntry packedEntry = this.PackedEntry;
				int[] batchTextureIndex = textureAtlas.BatchTextureIndex;
				return;
			}
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x0600191D RID: 6429 RVA: 0x0006A9C0 File Offset: 0x00068BC0
		public Rectangle Bounds
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600191D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Rectangle Microsoft.Xna.Framework.Graphics.Texture2D::get_Bounds()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Texture2D::Width, ldloc:Texture2D(this)))
	stloc:int32(var_1_0D, ldfld:int32(Texture2D::ArraySize, ldloc:Texture2D(this)))
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

		// Token: 0x0600191E RID: 6430 RVA: 0x0006A9E0 File Offset: 0x00068BE0
		public Texture2D(string sourceAsset, int width, int height)
		{
			this.UnityWidth = width;
			this.Width = height;
		}

		// Token: 0x0600191F RID: 6431 RVA: 0x0006A9FC File Offset: 0x00068BFC
		public Texture2D(Texture2D texture)
		{
			this._unityTexture = texture;
			Texture2D unityTexture = this._unityTexture;
			this.UnityWidth = texture;
			this.UnityHeight = unityTexture;
			this._textureLoaded = true;
		}

		// Token: 0x06001920 RID: 6432 RVA: 0x0006AA2C File Offset: 0x00068C2C
		public Texture2D(RenderTexture texture)
		{
			this._unityRenderTexture = texture;
			this.UnityWidth = texture;
		}

		// Token: 0x06001921 RID: 6433 RVA: 0x0006AA48 File Offset: 0x00068C48
		public Texture2D(Texture2D texture, Texture2D texture2)
		{
			this._unityTexture = texture;
			Texture2D unityTexture = this._unityTexture;
			this.UnityWidth = texture;
			this.UnityHeight = unityTexture;
			this._unityAlphaTexture = texture2;
			this._textureLoaded = true;
		}

		// Token: 0x06001922 RID: 6434 RVA: 0x0006AA80 File Offset: 0x00068C80
		public Texture2D(Texture2D texture, Texture2D texture2, Texture2D texture3)
		{
		}

		// Token: 0x06001923 RID: 6435 RVA: 0x0006AAC8 File Offset: 0x00068CC8
		public Texture2D(Texture2D texture, TextureAtlasEntry entry)
		{
			do
			{
				this.PackedEntry = entry;
			}
			while (entry.AttachedTexture == null);
			Debug.LogError("Texture is already attached");
			this.PackedEntry.AttachedTexture = this;
			Texture2D unityTexture = this._unityTexture;
			Texture2D unityTexture2 = this._unityTexture;
			this.UnityWidth = unityTexture;
			this.UnityHeight = unityTexture2;
			this._unityTexture = texture;
			this._textureLoaded = true;
		}

		// Token: 0x06001924 RID: 6436 RVA: 0x0006AB24 File Offset: 0x00068D24
		public Texture2D(TextureAtlasDB textureAtlas, TextureAtlasEntry entry)
		{
			while (!true)
			{
			}
			Debug.LogError("Texture is already attached");
			this.PackedEntry.AttachedTexture = this;
			this._textureAtlas = textureAtlas;
			int[] textureWidth = textureAtlas.TextureWidth;
			this.UnityWidth = textureWidth;
			int[] textureHeight = textureAtlas.TextureHeight;
			this.UnityHeight = textureHeight;
			if (textureAtlas != null && this.SharedBatching)
			{
				int[] batchTextureIndex = textureAtlas.BatchTextureIndex;
				return;
			}
		}

		// Token: 0x06001925 RID: 6437 RVA: 0x0006AB80 File Offset: 0x00068D80
		private void CreateEmptyTexture(object data)
		{
			int width = this.Width;
			int arraySize = this.ArraySize;
			this._textureLoaded = true;
		}

		// Token: 0x06001926 RID: 6438 RVA: 0x0006ABA4 File Offset: 0x00068DA4
		public Texture2D(GraphicsDevice device, int width, int height)
		{
			bool isMainThread = DrPlatform.IsMainThread;
			this._textureLoaded = true;
		}

		// Token: 0x06001927 RID: 6439 RVA: 0x0006ABC4 File Offset: 0x00068DC4
		public Texture2D(GraphicsDevice device, int width, int height, bool mipmap, SurfaceFormat format)
		{
		}

		// Token: 0x06001928 RID: 6440 RVA: 0x0006ABD4 File Offset: 0x00068DD4
		public Texture2D(GraphicsDevice device, int width, int height, bool mipmap, SurfaceFormat format, int arraySize)
		{
		}

		// Token: 0x06001929 RID: 6441 RVA: 0x0006ABE4 File Offset: 0x00068DE4
		internal Texture2D(GraphicsDevice device, int width, int height, bool mipmap, SurfaceFormat format, Texture2D.SurfaceType type)
		{
		}

		// Token: 0x0600192A RID: 6442 RVA: 0x0006ABF4 File Offset: 0x00068DF4
		protected Texture2D(GraphicsDevice device, int width, int height, bool mipmap, SurfaceFormat format, Texture2D.SurfaceType type, bool shared, int arraySize)
		{
			int num = 257;
			this.SharedBatching = num != 0;
			base..ctor();
			if (num == 0)
			{
			}
			Debug.Log("Created");
			this.Width = width;
			this.ArraySize = height;
			this._format = format;
			long num2 = 0L;
			int num3 = Texture.CalculateMipLevels(width, height, (int)num2);
		}

		// Token: 0x0600192B RID: 6443 RVA: 0x0006AC90 File Offset: 0x00068E90
		public void SaveAsPng(Stream stream, int width, int height)
		{
		}

		// Token: 0x0600192C RID: 6444 RVA: 0x0006ACA0 File Offset: 0x00068EA0
		public void SetData<T>(T[] data, int start, int length)
		{
		}

		// Token: 0x0600192D RID: 6445 RVA: 0x0006ACB0 File Offset: 0x00068EB0
		private static void ConvertToABGR(int pixelHeight, int pixelWidth, int[] pixels)
		{
		}

		// Token: 0x04002778 RID: 10104
		public int UnityWidth;

		// Token: 0x04002779 RID: 10105
		public int UnityHeight;

		// Token: 0x0400277A RID: 10106
		public readonly int Width;

		// Token: 0x0400277B RID: 10107
		public readonly int Height;

		// Token: 0x0400277C RID: 10108
		internal int ArraySize;

		// Token: 0x0400277D RID: 10109
		internal float TexelWidth;

		// Token: 0x0400277E RID: 10110
		internal float TexelHeight;

		// Token: 0x0400277F RID: 10111
		public float TextureOffsetScale;

		// Token: 0x04002780 RID: 10112
		public bool SharedBatching;

		// Token: 0x04002781 RID: 10113
		public bool NonSharedHeadInsert;

		// Token: 0x04002782 RID: 10114
		public TextureAtlasEntry PackedEntry;

		// Token: 0x04002783 RID: 10115
		private bool loadRequested;

		// Token: 0x04002784 RID: 10116
		public static bool ignoreLoad;

		// Token: 0x04002785 RID: 10117
		private bool _textureLoaded;

		// Token: 0x04002786 RID: 10118
		private RenderTexture _unityRenderTexture;

		// Token: 0x04002787 RID: 10119
		private Texture2D _unityTexture;

		// Token: 0x04002788 RID: 10120
		private Texture2D _unityAlphaTexture;

		// Token: 0x04002789 RID: 10121
		private Texture2D _unityPalTexture;

		// Token: 0x0400278A RID: 10122
		public TextureAtlasDB _textureAtlas;

		// Token: 0x0400278B RID: 10123
		private static int _nextTextureId;

		// Token: 0x0400278C RID: 10124
		private readonly int _batchTextureIndex;

		// Token: 0x0400278D RID: 10125
		public int BatchTextureIndex;

		// Token: 0x0400278E RID: 10126
		private string _sourceLoadAsset;

		// Token: 0x020003AB RID: 939
		protected internal enum SurfaceType
		{
			// Token: 0x04002790 RID: 10128
			Texture,
			// Token: 0x04002791 RID: 10129
			RenderTarget,
			// Token: 0x04002792 RID: 10130
			SwapChainRenderTarget
		}

		// Token: 0x020003AC RID: 940
		public sealed class TextureLoader : MulticastDelegate
		{
			// Token: 0x0600192E RID: 6446 RVA: 0x0006ACC0 File Offset: 0x00068EC0
			public TextureLoader(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x0600192F RID: 6447 RVA: 0x0006AD14 File Offset: 0x00068F14
			public Texture2D Invoke(int data)
			{
				/*
An exception occurred when decompiling this method (0600192F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.Texture2D Microsoft.Xna.Framework.Graphics.Texture2D/TextureLoader::Invoke(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:native int(var_0_06, ldfld:native int(Delegate::method_code, ldloc:TextureLoader[exp:Delegate](this)))
	stloc:native int(var_1_0D, ldfld:native int(Delegate::invoke_impl, ldloc:TextureLoader[exp:Delegate](this)))
	stloc:native int(var_2_14, ldfld:native int(Delegate::method, ldloc:TextureLoader[exp:Delegate](this)))
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

			// Token: 0x06001930 RID: 6448 RVA: 0x000021DB File Offset: 0x000003DB
			public IAsyncResult BeginInvoke(int data, AsyncCallback callback, object @object)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06001931 RID: 6449 RVA: 0x000021DB File Offset: 0x000003DB
			public Texture2D EndInvoke(IAsyncResult result)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}
	}
}
