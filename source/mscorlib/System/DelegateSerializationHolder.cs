using System;
using System.Reflection;
using System.Runtime.Serialization;
using Cpp2IlInjected;

namespace System
{
	// Token: 0x02000171 RID: 369
	[Serializable]
	internal class DelegateSerializationHolder : ISerializable, IObjectReference
	{
		// Token: 0x06000EE1 RID: 3809 RVA: 0x0001FEA8 File Offset: 0x0001E0A8
		private DelegateSerializationHolder(SerializationInfo info, StreamingContext ctx)
		{
			if (!true)
			{
			}
			Type type;
			object value = info.GetValue("Delegate", type);
			if (value != null)
			{
				while (value != null)
				{
				}
				return;
			}
		}

		// Token: 0x06000EE2 RID: 3810 RVA: 0x0001FEF4 File Offset: 0x0001E0F4
		public static void GetDelegateData(Delegate instance, SerializationInfo info, StreamingContext ctx)
		{
			IntPtr invoke_impl = instance.invoke_impl;
			string text2;
			string text = "target" + text2;
		}

		// Token: 0x06000EE3 RID: 3811 RVA: 0x0000207A File Offset: 0x0000027A
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000EE4 RID: 3812 RVA: 0x0001FF3C File Offset: 0x0001E13C
		public object GetRealObject(StreamingContext context)
		{
			/*
An exception occurred when decompiling this method (06000EE4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.DelegateSerializationHolder::GetRealObject(System.Runtime.Serialization.StreamingContext)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Delegate(var_0_06, ldfld:Delegate(DelegateSerializationHolder::_delegate, ldloc:DelegateSerializationHolder(this)))
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

		// Token: 0x04000669 RID: 1641
		private Delegate _delegate;

		// Token: 0x02000172 RID: 370
		[Serializable]
		private class DelegateEntry
		{
			// Token: 0x06000EE5 RID: 3813 RVA: 0x0001FF50 File Offset: 0x0001E150
			public DelegateEntry(Delegate del, string targetLabel)
			{
			}

			// Token: 0x06000EE6 RID: 3814 RVA: 0x0001FF88 File Offset: 0x0001E188
			public Delegate DeserializeDelegate(SerializationInfo info, int index)
			{
				if (this.target != null)
				{
				}
				long num = 0L;
				string text2;
				string text = "method" + text2;
				Type type;
				if (info.GetValueNoThrow(text, type) != null)
				{
				}
				Assembly assembly = Assembly.Load(this.assembly);
				string text3 = this.type;
				if (num != 0L)
				{
					string text4 = this.methodName;
					Delegate @delegate;
					return @delegate;
				}
				Delegate delegate2;
				return delegate2;
			}

			// Token: 0x0400066A RID: 1642
			private string type = del;

			// Token: 0x0400066B RID: 1643
			private string assembly = del;

			// Token: 0x0400066C RID: 1644
			private object target = targetLabel;

			// Token: 0x0400066D RID: 1645
			private string targetTypeAssembly = del;

			// Token: 0x0400066E RID: 1646
			private string targetTypeName = del;

			// Token: 0x0400066F RID: 1647
			private string methodName = del;

			// Token: 0x04000670 RID: 1648
			public DelegateSerializationHolder.DelegateEntry delegateEntry;
		}
	}
}
