using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace System.Collections
{
	// Token: 0x020005E0 RID: 1504
	[Serializable]
	public sealed class Comparer : IComparer, ISerializable
	{
		// Token: 0x06002D96 RID: 11670 RVA: 0x00064D10 File Offset: 0x00062F10
		public Comparer(CultureInfo culture)
		{
			do
			{
				base..ctor();
			}
			while (culture == null);
			this._compareInfo = culture;
		}

		// Token: 0x06002D97 RID: 11671 RVA: 0x00064D30 File Offset: 0x00062F30
		private Comparer(SerializationInfo info, StreamingContext context)
		{
			do
			{
				base..ctor();
			}
			while (info == null);
			Type type;
			object value = info.GetValue("CompareInfo", type);
			if (value != null)
			{
				this._compareInfo = value;
				throw new InvalidCastException();
			}
		}

		// Token: 0x06002D98 RID: 11672 RVA: 0x00064D64 File Offset: 0x00062F64
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			while (info == null)
			{
			}
			CompareInfo compareInfo = this._compareInfo;
			info.AddValue("CompareInfo", compareInfo);
		}

		// Token: 0x06002D99 RID: 11673 RVA: 0x00064D88 File Offset: 0x00062F88
		public int Compare(object a, object b)
		{
			/*
An exception occurred when decompiling this method (06002D99)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Collections.Comparer::Compare(System.Object,System.Object)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001A:
	brtrue(IL_0000, logicnot:bool(ldloc:object[exp:bool](b)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
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

		// Token: 0x06002D9A RID: 11674 RVA: 0x00064DB4 File Offset: 0x00062FB4
		// Note: this type is marked as 'beforefieldinit'.
		static Comparer()
		{
			if (!true)
			{
			}
			CultureInfo currentCulture = CultureInfo.CurrentCulture;
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
		}

		// Token: 0x0400199C RID: 6556
		private CompareInfo _compareInfo;

		// Token: 0x0400199D RID: 6557
		public static readonly Comparer Default;

		// Token: 0x0400199E RID: 6558
		public static readonly Comparer DefaultInvariant;
	}
}
