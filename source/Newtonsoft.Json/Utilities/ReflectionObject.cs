using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200004F RID: 79
	[Preserve]
	internal class ReflectionObject
	{
		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060002F7 RID: 759 RVA: 0x00009044 File Offset: 0x00007244
		// (set) Token: 0x060002F8 RID: 760 RVA: 0x00009058 File Offset: 0x00007258
		public ObjectConstructor<object> Creator
		{
			[CompilerGenerated]
			get
			{
				return this.<Creator>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Creator>k__BackingField = value;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060002F9 RID: 761 RVA: 0x0000906C File Offset: 0x0000726C
		// (set) Token: 0x060002FA RID: 762 RVA: 0x00009080 File Offset: 0x00007280
		public IDictionary<string, ReflectionMember> Members
		{
			[CompilerGenerated]
			get
			{
				return this.<Members>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Members>k__BackingField = value;
			}
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00009094 File Offset: 0x00007294
		public ReflectionObject()
		{
		}

		// Token: 0x060002FC RID: 764 RVA: 0x000090A8 File Offset: 0x000072A8
		public object GetValue(object target, string member)
		{
			/*
An exception occurred when decompiling this method (060002FC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object Newtonsoft.Json.Utilities.ReflectionObject::GetValue(System.Object,System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.IDictionary`2<string, class Newtonsoft.Json.Utilities.ReflectionMember>(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.IDictionary`2<string, class Newtonsoft.Json.Utilities.ReflectionMember>(ReflectionObject::<Members>k__BackingField, ldloc:ReflectionObject(this)))
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

		// Token: 0x060002FD RID: 765 RVA: 0x000090BC File Offset: 0x000072BC
		public void SetValue(object target, string member, object value)
		{
			IDictionary<string, ReflectionMember> dictionary = this.<Members>k__BackingField;
		}

		// Token: 0x060002FE RID: 766 RVA: 0x000090D4 File Offset: 0x000072D4
		public Type GetType(string member)
		{
			/*
An exception occurred when decompiling this method (060002FE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Type Newtonsoft.Json.Utilities.ReflectionObject::GetType(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.IDictionary`2<string, class Newtonsoft.Json.Utilities.ReflectionMember>(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.IDictionary`2<string, class Newtonsoft.Json.Utilities.ReflectionMember>(ReflectionObject::<Members>k__BackingField, ldloc:ReflectionObject(this)))
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

		// Token: 0x060002FF RID: 767 RVA: 0x000090E8 File Offset: 0x000072E8
		public static ReflectionObject Create(Type t, params string[] memberNames)
		{
			ReflectionObject reflectionObject;
			return reflectionObject;
		}

		// Token: 0x06000300 RID: 768 RVA: 0x000090F8 File Offset: 0x000072F8
		public static ReflectionObject Create(Type t, MethodBase creator, params string[] memberNames)
		{
			if (!true)
			{
			}
			ReflectionDelegateFactory reflectionDelegateFactory = JsonTypeReflector.ReflectionDelegateFactory;
			if (t != null)
			{
			}
			long num = 0L;
			MemberInfo memberInfo;
			bool flag = ReflectionUtils.CanReadMemberValue(memberInfo, num != 0L);
			Func func = reflectionDelegateFactory.CreateGet(memberInfo);
			long num2 = 0L;
			long num3 = 0L;
			bool flag2 = ReflectionUtils.CanSetMemberValue(memberInfo, num2 != 0L, num3 != 0L);
			Action action = reflectionDelegateFactory.CreateSet(memberInfo);
			if (memberInfo != null)
			{
			}
			long num4 = 0L;
			bool flag3 = ReflectionUtils.CanReadMemberValue(memberInfo, num4 != 0L);
			Func func2 = reflectionDelegateFactory.CreateGet(memberInfo);
			long num5 = 0L;
			long num6 = 0L;
			bool flag4 = ReflectionUtils.CanSetMemberValue(memberInfo, num5 != 0L, num6 != 0L);
			Action action2 = reflectionDelegateFactory.CreateSet(memberInfo);
			Type memberUnderlyingType = ReflectionUtils.GetMemberUnderlyingType(memberInfo);
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			CultureInfo invariantCulture2 = CultureInfo.InvariantCulture;
			throw new InvalidCastException();
		}

		// Token: 0x0400018C RID: 396
		[CompilerGenerated]
		private ObjectConstructor<object> <Creator>k__BackingField;

		// Token: 0x0400018D RID: 397
		[CompilerGenerated]
		private IDictionary<string, ReflectionMember> <Members>k__BackingField;

		// Token: 0x02000050 RID: 80
		[CompilerGenerated]
		private sealed class <>c__DisplayClass13_0
		{
			// Token: 0x06000301 RID: 769 RVA: 0x000091A8 File Offset: 0x000073A8
			public <>c__DisplayClass13_0()
			{
			}

			// Token: 0x06000302 RID: 770 RVA: 0x000091BC File Offset: 0x000073BC
			internal object <Create>b__0(object[] args)
			{
				/*
An exception occurred when decompiling this method (06000302)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object Newtonsoft.Json.Utilities.ReflectionObject/<>c__DisplayClass13_0::<Create>b__0(System.Object[])

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Func`1<object>(var_0_06, ldfld:class [mscorlib]System.Func`1<object>('<>c__DisplayClass13_0'::ctor, ldloc:'<>c__DisplayClass13_0'(this)))
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

			// Token: 0x0400018E RID: 398
			public Func<object> ctor;
		}

		// Token: 0x02000051 RID: 81
		[CompilerGenerated]
		private sealed class <>c__DisplayClass13_1
		{
			// Token: 0x06000303 RID: 771 RVA: 0x000091D0 File Offset: 0x000073D0
			public <>c__DisplayClass13_1()
			{
			}

			// Token: 0x06000304 RID: 772 RVA: 0x000091E4 File Offset: 0x000073E4
			internal object <Create>b__1(object target)
			{
				MethodCall<object, object> methodCall = this.call;
				return 1;
			}

			// Token: 0x0400018F RID: 399
			public MethodCall<object, object> call;
		}

		// Token: 0x02000052 RID: 82
		[CompilerGenerated]
		private sealed class <>c__DisplayClass13_2
		{
			// Token: 0x06000305 RID: 773 RVA: 0x000091FC File Offset: 0x000073FC
			public <>c__DisplayClass13_2()
			{
			}

			// Token: 0x06000306 RID: 774 RVA: 0x00009210 File Offset: 0x00007410
			internal void <Create>b__2(object target, object arg)
			{
				MethodCall<object, object> methodCall = this.call;
				if (arg == null || arg != null)
				{
					return;
				}
				throw new ArrayTypeMismatchException();
			}

			// Token: 0x04000190 RID: 400
			public MethodCall<object, object> call;
		}
	}
}
