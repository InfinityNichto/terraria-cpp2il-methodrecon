using System;
using System.Collections.Concurrent;
using System.Threading;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics
{
	// Token: 0x02000734 RID: 1844
	internal static class TextureManager
	{
		// Token: 0x06003D06 RID: 15622 RVA: 0x002383A8 File Offset: 0x002365A8
		public static void Initialize()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06003D07 RID: 15623 RVA: 0x002383B8 File Offset: 0x002365B8
		public static Texture2D Load(string name)
		{
			if (!true)
			{
			}
			Texture2D texture2D;
			return texture2D;
		}

		// Token: 0x06003D08 RID: 15624 RVA: 0x002383D0 File Offset: 0x002365D0
		public static Ref<Texture2D> Retrieve(string name)
		{
			/*
An exception occurred when decompiling this method (06003D08)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.Ref`1<Microsoft.Xna.Framework.Graphics.Texture2D> Terraria.Graphics.TextureManager::Retrieve(System.String)

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

		// Token: 0x06003D09 RID: 15625 RVA: 0x002383E0 File Offset: 0x002365E0
		public static void Run(object context)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x06003D0A RID: 15626 RVA: 0x002383FC File Offset: 0x002365FC
		// Note: this type is marked as 'beforefieldinit'.
		static TextureManager()
		{
		}

		// Token: 0x04007BFE RID: 31742
		private static ConcurrentDictionary<string, Texture2D> _textures;

		// Token: 0x04007BFF RID: 31743
		private static ConcurrentQueue<TextureManager.LoadPair> _loadQueue;

		// Token: 0x04007C00 RID: 31744
		private static Thread _loadThread;

		// Token: 0x04007C01 RID: 31745
		private static readonly object _loadThreadLock;

		// Token: 0x04007C02 RID: 31746
		public static Texture2D BlankTexture;

		// Token: 0x02000735 RID: 1845
		private struct LoadPair
		{
			// Token: 0x06003D0B RID: 15627 RVA: 0x0023840C File Offset: 0x0023660C
			public LoadPair(string path, Ref<Texture2D> textureRef)
			{
				this.Path = path;
				this.TextureRef = textureRef;
			}

			// Token: 0x04007C03 RID: 31747
			public string Path;

			// Token: 0x04007C04 RID: 31748
			public Ref<Texture2D> TextureRef;
		}
	}
}
