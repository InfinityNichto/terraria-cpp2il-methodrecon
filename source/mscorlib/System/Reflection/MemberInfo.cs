using System;
using Cpp2IlInjected;

namespace System.Reflection
{
	// Token: 0x020004DA RID: 1242
	[Serializable]
	public abstract class MemberInfo : ICustomAttributeProvider
	{
		// Token: 0x060023B8 RID: 9144 RVA: 0x00050854 File Offset: 0x0004EA54
		protected MemberInfo()
		{
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x060023B9 RID: 9145
		public abstract MemberTypes MemberType { get; }

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x060023BA RID: 9146
		public abstract string Name { get; }

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x060023BB RID: 9147
		public abstract Type DeclaringType { get; }

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x060023BC RID: 9148
		public abstract Type ReflectedType { get; }

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x060023BD RID: 9149 RVA: 0x00050868 File Offset: 0x0004EA68
		public virtual Module Module
		{
			get
			{
				/*
An exception occurred when decompiling this method (060023BD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Reflection.Module System.Reflection.MemberInfo::get_Module()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000C:
	stloc:Exception(var_3_13, callgetter:Exception(NotImplemented::get_ByDesign))
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

		// Token: 0x060023BE RID: 9150
		public abstract bool IsDefined(Type attributeType, bool inherit);

		// Token: 0x060023BF RID: 9151
		public abstract object[] GetCustomAttributes(bool inherit);

		// Token: 0x060023C0 RID: 9152
		public abstract object[] GetCustomAttributes(Type attributeType, bool inherit);

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x060023C1 RID: 9153 RVA: 0x0000207A File Offset: 0x0000027A
		public virtual int MetadataToken
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x060023C2 RID: 9154 RVA: 0x00050888 File Offset: 0x0004EA88
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x060023C3 RID: 9155 RVA: 0x0005089C File Offset: 0x0004EA9C
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x060023C4 RID: 9156 RVA: 0x000508B0 File Offset: 0x0004EAB0
		public static bool operator ==(MemberInfo left, MemberInfo right)
		{
			int num = 1;
			if (left != null)
			{
				if (num == 0)
				{
				}
				bool flag;
				return flag;
			}
			bool flag2;
			return flag2;
		}

		// Token: 0x060023C5 RID: 9157 RVA: 0x000508EC File Offset: 0x0004EAEC
		public static bool operator !=(MemberInfo left, MemberInfo right)
		{
			bool flag;
			return flag;
		}
	}
}
