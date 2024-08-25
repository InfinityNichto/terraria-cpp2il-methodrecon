using System;
using System.Globalization;

namespace System
{
	// Token: 0x020000FF RID: 255
	[Serializable]
	public class OrdinalComparer : StringComparer
	{
		// Token: 0x06000991 RID: 2449 RVA: 0x00017070 File Offset: 0x00015270
		internal OrdinalComparer(bool ignoreCase)
		{
			if (!true)
			{
			}
			base..ctor();
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x00017088 File Offset: 0x00015288
		public override int Compare(string x, string y)
		{
			if (x == null || y == null)
			{
				return 1;
			}
			if (this._ignoreCase)
			{
				return string.Compare(x, y, StringComparison.OrdinalIgnoreCase);
			}
			return string.CompareOrdinal(y, y);
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x000170B8 File Offset: 0x000152B8
		public override bool Equals(string x, string y)
		{
			if (x != null && y != null)
			{
				if (!this._ignoreCase)
				{
					return y.Equals(y);
				}
				int stringLength = x._stringLength;
				int stringLength2 = y._stringLength;
				int num = string.Compare(x, y, StringComparison.OrdinalIgnoreCase);
			}
			return true;
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x000170F8 File Offset: 0x000152F8
		public override int GetHashCode(string obj)
		{
			if (obj != null && this._ignoreCase)
			{
				return CompareInfo.GetIgnoreCaseHash(obj);
			}
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x00017118 File Offset: 0x00015318
		public override bool Equals(object obj)
		{
			/*
An exception occurred when decompiling this method (06000995)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.OrdinalComparer::Equals(System.Object)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:bool(var_1_0B, ldfld:bool(OrdinalComparer::_ignoreCase, ldloc:OrdinalComparer(this)))
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

		// Token: 0x06000996 RID: 2454 RVA: 0x00017130 File Offset: 0x00015330
		public override int GetHashCode()
		{
			bool ignoreCase = this._ignoreCase;
			return "OrdinalComparer";
		}

		// Token: 0x040003A8 RID: 936
		private readonly bool _ignoreCase;
	}
}
