using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace Terraria.GameContent
{
	// Token: 0x02000807 RID: 2055
	public class VanillaContentValidator : IContentValidator
	{
		// Token: 0x060041D3 RID: 16851 RVA: 0x00248B88 File Offset: 0x00246D88
		public VanillaContentValidator(string infoFilePath)
		{
			int num = 1;
			this._info = "\r\n|\r|\n";
			base..ctor();
			if (num == 0)
			{
			}
			string text;
			string[] array = Regex.Split(text, "\r\n|\r|\n");
			bool flag = array.StartsWith("//");
			int num2 = 9;
			string[] array2;
			bool flag2 = int.TryParse(array2, num2);
		}

		// Token: 0x060041D4 RID: 16852 RVA: 0x00248BE0 File Offset: 0x00246DE0
		public bool AssetIsValid<T>(T content, string contentPath, [Out] IRejectionReason rejectReason) where T : class
		{
			if (content != null)
			{
			}
			Dictionary<string, VanillaContentValidator.TextureMetaData> info = this._info;
			bool flag;
			return flag;
		}

		// Token: 0x060041D5 RID: 16853 RVA: 0x00248BFC File Offset: 0x00246DFC
		public HashSet<string> GetValidImageFilePaths()
		{
			/*
An exception occurred when decompiling this method (060041D5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.HashSet`1<System.String> Terraria.GameContent.VanillaContentValidator::GetValidImageFilePaths()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000A:
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

		// Token: 0x0400809A RID: 32922
		public static VanillaContentValidator Instance;

		// Token: 0x0400809B RID: 32923
		private Dictionary<string, VanillaContentValidator.TextureMetaData> _info;

		// Token: 0x02000808 RID: 2056
		private struct TextureMetaData
		{
			// Token: 0x060041D6 RID: 16854 RVA: 0x00248C18 File Offset: 0x00246E18
			public bool Matches(Texture2D texture, [Out] IRejectionReason rejectReason)
			{
				int width = texture.Width;
				int height = texture.Height;
				int height2 = this.Height;
				return true;
			}

			// Token: 0x0400809C RID: 32924
			public int Width;

			// Token: 0x0400809D RID: 32925
			public int Height;
		}

		// Token: 0x02000809 RID: 2057
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060041D7 RID: 16855 RVA: 0x00248C40 File Offset: 0x00246E40
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060041D8 RID: 16856 RVA: 0x00248C50 File Offset: 0x00246E50
			public <>c()
			{
			}

			// Token: 0x060041D9 RID: 16857 RVA: 0x000021DB File Offset: 0x000003DB
			internal string <GetValidImageFilePaths>b__4_0(KeyValuePair<string, VanillaContentValidator.TextureMetaData> x)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x0400809E RID: 32926
			public static readonly VanillaContentValidator.<>c <>9;

			// Token: 0x0400809F RID: 32927
			public static Func<KeyValuePair<string, VanillaContentValidator.TextureMetaData>, string> <>9__4_0;
		}
	}
}
