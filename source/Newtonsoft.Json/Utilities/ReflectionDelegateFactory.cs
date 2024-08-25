using System;
using System.Reflection;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000044 RID: 68
	[Preserve]
	internal abstract class ReflectionDelegateFactory
	{
		// Token: 0x060002C7 RID: 711 RVA: 0x00008CC0 File Offset: 0x00006EC0
		public Func<T, object> CreateGet<T>(MemberInfo memberInfo)
		{
			/*
An exception occurred when decompiling this method (060002C7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Func`2<T,System.Object> Newtonsoft.Json.Utilities.ReflectionDelegateFactory::CreateGet<T>(System.Reflection.MemberInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:CultureInfo(var_1_0A, callgetter:CultureInfo(CultureInfo::get_InvariantCulture))
	stloc:string(var_2_17, call:string(StringUtils::FormatWith, ldstr:string("Could not create getter for {0}."), ldloc:CultureInfo[exp:IFormatProvider](var_1_0A), ldloc:MemberInfo[exp:object](memberInfo)))
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

		// Token: 0x060002C8 RID: 712 RVA: 0x00008CE4 File Offset: 0x00006EE4
		public Action<T, object> CreateSet<T>(MemberInfo memberInfo)
		{
			/*
An exception occurred when decompiling this method (060002C8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Action`2<T,System.Object> Newtonsoft.Json.Utilities.ReflectionDelegateFactory::CreateSet<T>(System.Reflection.MemberInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:CultureInfo(var_1_0A, callgetter:CultureInfo(CultureInfo::get_InvariantCulture))
	stloc:string(var_2_17, call:string(StringUtils::FormatWith, ldstr:string("Could not create setter for {0}."), ldloc:CultureInfo[exp:IFormatProvider](var_1_0A), ldloc:MemberInfo[exp:object](memberInfo)))
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

		// Token: 0x060002C9 RID: 713
		public abstract MethodCall<T, object> CreateMethodCall<T>(MethodBase method);

		// Token: 0x060002CA RID: 714
		public abstract ObjectConstructor<object> CreateParameterizedConstructor(MethodBase method);

		// Token: 0x060002CB RID: 715
		public abstract Func<T> CreateDefaultConstructor<T>(Type type);

		// Token: 0x060002CC RID: 716
		public abstract Func<T, object> CreateGet<T>(PropertyInfo propertyInfo);

		// Token: 0x060002CD RID: 717
		public abstract Func<T, object> CreateGet<T>(FieldInfo fieldInfo);

		// Token: 0x060002CE RID: 718
		public abstract Action<T, object> CreateSet<T>(FieldInfo fieldInfo);

		// Token: 0x060002CF RID: 719
		public abstract Action<T, object> CreateSet<T>(PropertyInfo propertyInfo);

		// Token: 0x060002D0 RID: 720 RVA: 0x00008D08 File Offset: 0x00006F08
		protected ReflectionDelegateFactory()
		{
		}
	}
}
