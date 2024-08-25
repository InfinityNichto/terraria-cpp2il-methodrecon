using System;
using System.Globalization;

namespace System.Collections
{
	// Token: 0x020005F3 RID: 1523
	[Serializable]
	public class CaseInsensitiveComparer : IComparer
	{
		// Token: 0x06002DF3 RID: 11763 RVA: 0x00065380 File Offset: 0x00063580
		public CaseInsensitiveComparer()
		{
			if (!true)
			{
			}
			CultureInfo currentCulture = CultureInfo.CurrentCulture;
			this._compareInfo = currentCulture;
		}

		// Token: 0x06002DF4 RID: 11764 RVA: 0x000653A8 File Offset: 0x000635A8
		public CaseInsensitiveComparer(CultureInfo culture)
		{
			do
			{
				base..ctor();
			}
			while (culture == null);
			this._compareInfo = culture;
		}

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x06002DF5 RID: 11765 RVA: 0x000653C8 File Offset: 0x000635C8
		public static CaseInsensitiveComparer Default
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002DF5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.CaseInsensitiveComparer System.Collections.CaseInsensitiveComparer::get_Default()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:CultureInfo(var_1_0A, callgetter:CultureInfo(CultureInfo::get_CurrentCulture))
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

		// Token: 0x06002DF6 RID: 11766 RVA: 0x000653E0 File Offset: 0x000635E0
		public int Compare(object a, object b)
		{
			long num;
			int num2;
			if (a == null || b == null)
			{
				num = 0L;
				if (b == null)
				{
					return num2;
				}
			}
			if (num != 0L && b != null)
			{
				CompareInfo compareInfo = this._compareInfo;
			}
			return num2;
		}

		// Token: 0x040019B7 RID: 6583
		private CompareInfo _compareInfo;
	}
}
