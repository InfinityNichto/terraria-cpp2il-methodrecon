using System;
using System.Runtime.CompilerServices;

namespace Terraria.Social.Base
{
	// Token: 0x02000537 RID: 1335
	public class WorkshopItemPublishSettings
	{
		// Token: 0x06003220 RID: 12832 RVA: 0x001F9488 File Offset: 0x001F7688
		public string[] GetUsedTagsInternalNames()
		{
			/*
An exception occurred when decompiling this method (06003220)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String[] Terraria.Social.Base.WorkshopItemPublishSettings::GetUsedTagsInternalNames()

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

		// Token: 0x06003221 RID: 12833 RVA: 0x001F94A4 File Offset: 0x001F76A4
		public WorkshopItemPublishSettings()
		{
		}

		// Token: 0x04003B78 RID: 15224
		public WorkshopTagOption[] UsedTags;

		// Token: 0x04003B79 RID: 15225
		public WorkshopItemPublicSettingId Publicity;

		// Token: 0x04003B7A RID: 15226
		public string PreviewImagePath;

		// Token: 0x02000538 RID: 1336
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06003222 RID: 12834 RVA: 0x001F94BC File Offset: 0x001F76BC
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06003223 RID: 12835 RVA: 0x001F94CC File Offset: 0x001F76CC
			public <>c()
			{
			}

			// Token: 0x06003224 RID: 12836 RVA: 0x001F94E0 File Offset: 0x001F76E0
			internal string <GetUsedTagsInternalNames>b__3_0(WorkshopTagOption x)
			{
				return x.InternalNameForAPIs;
			}

			// Token: 0x04003B7B RID: 15227
			public static readonly WorkshopItemPublishSettings.<>c <>9;

			// Token: 0x04003B7C RID: 15228
			public static Func<WorkshopTagOption, string> <>9__3_0;
		}
	}
}
