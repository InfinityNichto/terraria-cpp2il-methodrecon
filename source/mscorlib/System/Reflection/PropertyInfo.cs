using System;
using System.Diagnostics;
using System.Globalization;
using Cpp2IlInjected;

namespace System.Reflection
{
	// Token: 0x020004E8 RID: 1256
	[Serializable]
	public abstract class PropertyInfo : MemberInfo
	{
		// Token: 0x06002419 RID: 9241 RVA: 0x00050DCC File Offset: 0x0004EFCC
		protected PropertyInfo()
		{
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x0600241A RID: 9242 RVA: 0x00050DE0 File Offset: 0x0004EFE0
		public override MemberTypes MemberType
		{
			get
			{
				return MemberTypes.Property;
			}
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x0600241B RID: 9243
		public abstract Type PropertyType { get; }

		// Token: 0x0600241C RID: 9244
		public abstract ParameterInfo[] GetIndexParameters();

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x0600241D RID: 9245
		public abstract bool CanRead { get; }

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x0600241E RID: 9246
		public abstract bool CanWrite { get; }

		// Token: 0x0600241F RID: 9247 RVA: 0x0000207A File Offset: 0x0000027A
		public MethodInfo GetGetMethod()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002420 RID: 9248
		public abstract MethodInfo GetGetMethod(bool nonPublic);

		// Token: 0x06002421 RID: 9249 RVA: 0x0000207A File Offset: 0x0000027A
		public MethodInfo GetSetMethod()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002422 RID: 9250
		public abstract MethodInfo GetSetMethod(bool nonPublic);

		// Token: 0x06002423 RID: 9251 RVA: 0x0000207A File Offset: 0x0000027A
		[DebuggerHidden]
		[DebuggerStepThrough]
		public object GetValue(object obj)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002424 RID: 9252 RVA: 0x0000207A File Offset: 0x0000027A
		[DebuggerHidden]
		[DebuggerStepThrough]
		public virtual object GetValue(object obj, object[] index)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002425 RID: 9253
		public abstract object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture);

		// Token: 0x06002426 RID: 9254 RVA: 0x00050DF0 File Offset: 0x0004EFF0
		[DebuggerHidden]
		[DebuggerStepThrough]
		public virtual void SetValue(object obj, object value, object[] index)
		{
		}

		// Token: 0x06002427 RID: 9255
		public abstract void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture);

		// Token: 0x06002428 RID: 9256 RVA: 0x00050E00 File Offset: 0x0004F000
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x06002429 RID: 9257 RVA: 0x00050E14 File Offset: 0x0004F014
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x0600242A RID: 9258 RVA: 0x00050E28 File Offset: 0x0004F028
		public static bool operator ==(PropertyInfo left, PropertyInfo right)
		{
			if (left != null)
			{
			}
			return true;
		}

		// Token: 0x0600242B RID: 9259 RVA: 0x00050E3C File Offset: 0x0004F03C
		public static bool operator !=(PropertyInfo left, PropertyInfo right)
		{
			/*
An exception occurred when decompiling this method (0600242B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Reflection.PropertyInfo::op_Inequality(System.Reflection.PropertyInfo,System.Reflection.PropertyInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, logicnot:bool(ldloc:PropertyInfo[exp:bool](left)))
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
	}
}
