using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Cpp2IlInjected;

namespace System
{
	// Token: 0x02000170 RID: 368
	[Serializable]
	[StructLayout(0)]
	public abstract class Delegate : ICloneable, ISerializable
	{
		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000EC1 RID: 3777 RVA: 0x0000207A File Offset: 0x0000027A
		public MethodInfo Method
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06000EC2 RID: 3778 RVA: 0x0000207A File Offset: 0x0000027A
		private MethodInfo GetVirtualMethod_internal()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000EC3 RID: 3779 RVA: 0x0001FB60 File Offset: 0x0001DD60
		public object Target
		{
			get
			{
				return this.m_target;
			}
		}

		// Token: 0x06000EC4 RID: 3780 RVA: 0x0000207A File Offset: 0x0000027A
		internal static Delegate CreateDelegate_internal(Type type, object target, MethodInfo info, bool throwOnBindFailure)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000EC5 RID: 3781 RVA: 0x0001FB74 File Offset: 0x0001DD74
		private static bool arg_type_match(Type delArgType, Type argType)
		{
			if (!true)
			{
			}
			return true;
		}

		// Token: 0x06000EC6 RID: 3782 RVA: 0x0001FBA4 File Offset: 0x0001DDA4
		private static bool arg_type_match_this(Type delArgType, Type argType, bool boxedThis)
		{
			bool isValueType = delArgType.IsValueType;
			bool flag;
			return flag;
		}

		// Token: 0x06000EC7 RID: 3783 RVA: 0x0001FBC4 File Offset: 0x0001DDC4
		private static bool return_type_match(Type delReturnType, Type returnType)
		{
			if (!true)
			{
			}
			bool flag = delReturnType == delReturnType;
			bool isValueType = delReturnType.IsValueType;
			return true;
		}

		// Token: 0x06000EC8 RID: 3784 RVA: 0x0001FC08 File Offset: 0x0001DE08
		private static Delegate CreateDelegate(Type type, object firstArgument, MethodInfo method, bool throwOnBindFailure, bool allowClosed)
		{
			if (!true)
			{
			}
			Type type2;
			MethodInfo methodInfo = type2.GetMethod("Invoke");
			if (type != null)
			{
				return "method return type is incompatible";
			}
			return "method return type is incompatible";
		}

		// Token: 0x06000EC9 RID: 3785 RVA: 0x0001FC64 File Offset: 0x0001DE64
		public static Delegate CreateDelegate(Type type, object firstArgument, MethodInfo method)
		{
			Delegate @delegate;
			return @delegate;
		}

		// Token: 0x06000ECA RID: 3786 RVA: 0x0001FC74 File Offset: 0x0001DE74
		public static Delegate CreateDelegate(Type type, MethodInfo method, bool throwOnBindFailure)
		{
			Delegate @delegate;
			return @delegate;
		}

		// Token: 0x06000ECB RID: 3787 RVA: 0x0001FC84 File Offset: 0x0001DE84
		public static Delegate CreateDelegate(Type type, MethodInfo method)
		{
			Delegate @delegate;
			return @delegate;
		}

		// Token: 0x06000ECC RID: 3788 RVA: 0x0001FC94 File Offset: 0x0001DE94
		public static Delegate CreateDelegate(Type type, object target, string method)
		{
			Delegate @delegate;
			return @delegate;
		}

		// Token: 0x06000ECD RID: 3789 RVA: 0x0001FCA4 File Offset: 0x0001DEA4
		private static MethodInfo GetCandidateMethod(Type type, Type target, string method, BindingFlags bflags, bool ignoreCase, bool throwOnBindFailure)
		{
			do
			{
				if (!true)
				{
				}
			}
			while (target == null);
			Type type2;
			MethodInfo methodInfo = type2.GetMethod("Invoke");
			int num = 50;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000ECE RID: 3790 RVA: 0x0001FCE0 File Offset: 0x0001DEE0
		public static Delegate CreateDelegate(Type type, Type target, string method, bool ignoreCase, bool throwOnBindFailure)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x06000ECF RID: 3791 RVA: 0x0001FCF4 File Offset: 0x0001DEF4
		public static Delegate CreateDelegate(Type type, Type target, string method)
		{
			Delegate @delegate;
			return @delegate;
		}

		// Token: 0x06000ED0 RID: 3792 RVA: 0x0001FD04 File Offset: 0x0001DF04
		public static Delegate CreateDelegate(Type type, Type target, string method, bool ignoreCase)
		{
			Delegate @delegate;
			return @delegate;
		}

		// Token: 0x06000ED1 RID: 3793 RVA: 0x0001FD14 File Offset: 0x0001DF14
		public static Delegate CreateDelegate(Type type, object target, string method, bool ignoreCase, bool throwOnBindFailure)
		{
			while (type == null)
			{
			}
		}

		// Token: 0x06000ED2 RID: 3794 RVA: 0x0001FD28 File Offset: 0x0001DF28
		public static Delegate CreateDelegate(Type type, object target, string method, bool ignoreCase)
		{
			Delegate @delegate;
			return @delegate;
		}

		// Token: 0x06000ED3 RID: 3795 RVA: 0x0000207A File Offset: 0x0000027A
		public virtual object Clone()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000ED4 RID: 3796 RVA: 0x0001FD38 File Offset: 0x0001DF38
		public override bool Equals(object obj)
		{
			DelegateData delegateData;
			if (obj != null)
			{
				object target = this.m_target;
				delegateData = this.data;
				if (delegateData != null)
				{
					Type target_type = delegateData.target_type;
					DelegateData delegateData2 = this.data;
					string method_name = delegateData.method_name;
					string method_name2 = delegateData2.method_name;
					return method_name == method_name2;
				}
			}
			else if (delegateData != null)
			{
				Type target_type2 = delegateData.target_type;
				DelegateData delegateData2;
				if (delegateData2 == null)
				{
				}
			}
			if (delegateData == null)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06000ED5 RID: 3797 RVA: 0x0001FDA0 File Offset: 0x0001DFA0
		public override int GetHashCode()
		{
			return RuntimeHelpers.GetHashCode(this.m_target);
		}

		// Token: 0x06000ED6 RID: 3798 RVA: 0x0001FDB8 File Offset: 0x0001DFB8
		protected virtual MethodInfo GetMethodImpl()
		{
			MethodInfo methodInfo = this.method_info;
			IntPtr intPtr = this.method;
			if (this.method_is_virtual)
			{
				this.method_info = this;
			}
			MethodBase methodBase;
			while (methodBase == null)
			{
			}
			this.method_info = methodBase;
			return this.method_info;
		}

		// Token: 0x06000ED7 RID: 3799 RVA: 0x0001FDF8 File Offset: 0x0001DFF8
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			DelegateSerializationHolder.GetDelegateData(this, info, context);
		}

		// Token: 0x06000ED8 RID: 3800 RVA: 0x0001FE10 File Offset: 0x0001E010
		public virtual Delegate[] GetInvocationList()
		{
			if (this == null || this != null)
			{
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000ED9 RID: 3801 RVA: 0x0001FE28 File Offset: 0x0001E028
		public static Delegate Combine(Delegate a, Delegate b)
		{
			if (a != null)
			{
			}
			return a;
		}

		// Token: 0x06000EDA RID: 3802 RVA: 0x0001FE48 File Offset: 0x0001E048
		[ComVisible(true)]
		public static Delegate Combine(params Delegate[] delegates)
		{
			Delegate @delegate;
			return @delegate;
		}

		// Token: 0x06000EDB RID: 3803 RVA: 0x0000207A File Offset: 0x0000027A
		protected virtual Delegate CombineImpl(Delegate d)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000EDC RID: 3804 RVA: 0x0001FE5C File Offset: 0x0001E05C
		public static Delegate Remove(Delegate source, Delegate value)
		{
			/*
An exception occurred when decompiling this method (06000EDC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Delegate System.Delegate::Remove(System.Delegate,System.Delegate)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:string(var_1_0F, call:string(string::Format, ldstr:string("Incompatible Delegate Types. First is {0} second is {1}."), ldloc:bool[exp:object](var_0), ldloc:Delegate[exp:object](source)))
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

		// Token: 0x06000EDD RID: 3805 RVA: 0x0001FE78 File Offset: 0x0001E078
		protected virtual Delegate RemoveImpl(Delegate d)
		{
			return this;
		}

		// Token: 0x06000EDE RID: 3806 RVA: 0x0001FE88 File Offset: 0x0001E088
		public static bool operator ==(Delegate d1, Delegate d2)
		{
			/*
An exception occurred when decompiling this method (06000EDE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Delegate::op_Equality(System.Delegate,System.Delegate)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, logicnot:bool(ldloc:Delegate[exp:bool](d1)))
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

		// Token: 0x06000EDF RID: 3807 RVA: 0x0001FE98 File Offset: 0x0001E098
		public static bool operator !=(Delegate d1, Delegate d2)
		{
			/*
An exception occurred when decompiling this method (06000EDF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Delegate::op_Inequality(System.Delegate,System.Delegate)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, logicnot:bool(ldloc:Delegate[exp:bool](d1)))
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

		// Token: 0x06000EE0 RID: 3808 RVA: 0x0000207A File Offset: 0x0000027A
		internal static MulticastDelegate AllocDelegateLike_internal(Delegate d)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0400065C RID: 1628
		private IntPtr method_ptr;

		// Token: 0x0400065D RID: 1629
		private IntPtr invoke_impl;

		// Token: 0x0400065E RID: 1630
		private object m_target;

		// Token: 0x0400065F RID: 1631
		private IntPtr method;

		// Token: 0x04000660 RID: 1632
		private IntPtr delegate_trampoline;

		// Token: 0x04000661 RID: 1633
		private IntPtr extra_arg;

		// Token: 0x04000662 RID: 1634
		private IntPtr method_code;

		// Token: 0x04000663 RID: 1635
		private IntPtr interp_method;

		// Token: 0x04000664 RID: 1636
		private IntPtr interp_invoke_impl;

		// Token: 0x04000665 RID: 1637
		private MethodInfo method_info;

		// Token: 0x04000666 RID: 1638
		private MethodInfo original_method_info;

		// Token: 0x04000667 RID: 1639
		private DelegateData data;

		// Token: 0x04000668 RID: 1640
		private bool method_is_virtual;
	}
}
