using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x02000185 RID: 389
	[ComVisible(true)]
	[Serializable]
	[StructLayout(0)]
	public abstract class MulticastDelegate : Delegate
	{
		// Token: 0x06000F26 RID: 3878 RVA: 0x00020538 File Offset: 0x0001E738
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			DelegateSerializationHolder.GetDelegateData(this, info, context);
		}

		// Token: 0x06000F27 RID: 3879 RVA: 0x00020550 File Offset: 0x0001E750
		public sealed override bool Equals(object obj)
		{
			bool flag = base.Equals(obj);
			if (obj != null)
			{
			}
			Delegate[] array = this.delegates;
			if (array != null)
			{
				IntPtr invoke_impl = array.invoke_impl;
				object target = array.m_target;
				Delegate[] array2 = this.delegates;
				return;
			}
		}

		// Token: 0x06000F28 RID: 3880 RVA: 0x00020590 File Offset: 0x0001E790
		public sealed override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06000F29 RID: 3881 RVA: 0x000205A4 File Offset: 0x0001E7A4
		protected override MethodInfo GetMethodImpl()
		{
			Delegate[] array = this.delegates;
			if (array != null)
			{
				IntPtr invoke_impl = array.invoke_impl;
				object target = array.m_target;
			}
			MethodInfo methodInfo;
			return methodInfo;
		}

		// Token: 0x06000F2A RID: 3882 RVA: 0x000205CC File Offset: 0x0001E7CC
		public sealed override Delegate[] GetInvocationList()
		{
			object obj;
			if (this.delegates != null)
			{
				if (obj != null)
				{
					if (obj == null)
					{
						throw new InvalidCastException();
					}
				}
			}
			else if (obj != null)
			{
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000F2B RID: 3883 RVA: 0x000205F8 File Offset: 0x0001E7F8
		protected sealed override Delegate CombineImpl(Delegate follow)
		{
			if (follow == null)
			{
				Delegate[] array;
				return array;
			}
			Delegate[] array2 = this.delegates;
			Delegate[] array3;
			if (array2 != null)
			{
				IntPtr invoke_impl = array2.invoke_impl;
				Delegate[] array = this.delegates;
				IntPtr invoke_impl2 = array.invoke_impl;
				array3 = this.delegates;
				Delegate[] array4 = this.delegates;
				IntPtr invoke_impl3 = array3.invoke_impl;
				return array;
			}
			this.delegates = array3;
			if (this != null)
			{
				array3.m_target = this;
				Delegate[] array5 = this.delegates;
				IntPtr invoke_impl4 = this.invoke_impl;
				IntPtr invoke_impl5 = this.delegates.invoke_impl;
				Delegate[] array6 = this.delegates;
				if (follow != null)
				{
					IntPtr invoke_impl6 = array6.invoke_impl;
					return follow;
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000F2C RID: 3884 RVA: 0x000206A8 File Offset: 0x0001E8A8
		private int LastIndexOf(Delegate[] haystack, Delegate[] needle)
		{
			/*
An exception occurred when decompiling this method (06000F2C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.MulticastDelegate::LastIndexOf(System.Delegate[],System.Delegate[])

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:native int(var_0_06, ldfld:native int(Delegate::invoke_impl, ldloc:class System.Delegate[][exp:Delegate](haystack)))
	stloc:native int(var_1_0D, ldfld:native int(Delegate::invoke_impl, ldloc:class System.Delegate[][exp:Delegate](needle)))
	stloc:object(var_4_18, ldfld:object(Delegate::m_target, ldloc:class System.Delegate[][exp:Delegate](needle)))
	stloc:native int(var_6_23, ldfld:native int(Delegate::invoke_impl, ldloc:class System.Delegate[][exp:Delegate](needle)))
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

		// Token: 0x06000F2D RID: 3885 RVA: 0x000206DC File Offset: 0x0001E8DC
		protected sealed override Delegate RemoveImpl(Delegate value)
		{
			if (value != null)
			{
				if (this.delegates != null)
				{
					Delegate[] array = this.delegates;
					IntPtr invoke_impl = this.delegates.invoke_impl;
					this.delegates = 0;
					Delegate[] array2 = this.delegates;
					Delegate[] array3 = this.delegates;
					Delegate[] array4 = this.delegates;
					IntPtr invoke_impl2 = array3.invoke_impl;
					return array3;
				}
				int num;
				if (num != 0)
				{
				}
			}
			throw new InvalidCastException();
		}

		// Token: 0x0400068A RID: 1674
		private Delegate[] delegates;
	}
}
