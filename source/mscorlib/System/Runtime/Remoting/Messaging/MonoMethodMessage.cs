using System;
using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020003B7 RID: 951
	[Serializable]
	[StructLayout(0)]
	internal class MonoMethodMessage : IMethodCallMessage, IMethodMessage, IMessage, IMethodReturnMessage, IInternalMessage
	{
		// Token: 0x06001E75 RID: 7797 RVA: 0x00042B44 File Offset: 0x00040D44
		internal void InitMessage(RuntimeMethodInfo method, object[] out_args)
		{
			this.method = method;
			string name = method.name;
			string[] array = this.names;
		}

		// Token: 0x06001E76 RID: 7798 RVA: 0x00042B8C File Offset: 0x00040D8C
		public MonoMethodMessage(MethodBase method, object[] out_args)
		{
			if (method != null)
			{
			}
		}

		// Token: 0x06001E77 RID: 7799 RVA: 0x00042BAC File Offset: 0x00040DAC
		internal MonoMethodMessage(MethodInfo minfo, object[] in_args, object[] out_args)
		{
			object[] array = this.args;
		}

		// Token: 0x06001E78 RID: 7800 RVA: 0x00042BD8 File Offset: 0x00040DD8
		private static MethodInfo GetMethodInfo(Type type, string methodName)
		{
			MethodInfo methodInfo;
			return methodInfo;
		}

		// Token: 0x06001E79 RID: 7801 RVA: 0x00042BF8 File Offset: 0x00040DF8
		public MonoMethodMessage(Type type, string methodName, object[] in_args)
		{
			MethodInfo methodInfo = MonoMethodMessage.GetMethodInfo(type, methodName);
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06001E7A RID: 7802 RVA: 0x00042C10 File Offset: 0x00040E10
		public IDictionary Properties
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001E7A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.IDictionary System.Runtime.Remoting.Messaging.MonoMethodMessage::get_Properties()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:MCMDictionary[exp:bool](MonoMethodMessage::properties, ldloc:MonoMethodMessage(this)))
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

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06001E7B RID: 7803 RVA: 0x00042C24 File Offset: 0x00040E24
		public int ArgCount
		{
			get
			{
				CallType callType = this.CallType;
				if (this.args != null)
				{
					return;
				}
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06001E7C RID: 7804 RVA: 0x00042C44 File Offset: 0x00040E44
		public object[] Args
		{
			get
			{
				return this.args;
			}
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06001E7D RID: 7805 RVA: 0x00042C58 File Offset: 0x00040E58
		// (set) Token: 0x06001E7E RID: 7806 RVA: 0x00042C6C File Offset: 0x00040E6C
		public LogicalCallContext LogicalCallContext
		{
			get
			{
				return this.ctx;
			}
			set
			{
				this.ctx = value;
			}
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06001E7F RID: 7807 RVA: 0x00042C80 File Offset: 0x00040E80
		public MethodBase MethodBase
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001E7F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Reflection.MethodBase System.Runtime.Remoting.Messaging.MonoMethodMessage::get_MethodBase()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:RuntimeMethodInfo(var_0_06, ldfld:RuntimeMethodInfo(MonoMethodMessage::method, ldloc:MonoMethodMessage(this)))
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

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06001E80 RID: 7808 RVA: 0x00042C94 File Offset: 0x00040E94
		public string MethodName
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001E80)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Runtime.Remoting.Messaging.MonoMethodMessage::get_MethodName()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:RuntimeMethodInfo(var_0_06, ldfld:RuntimeMethodInfo(MonoMethodMessage::method, ldloc:MonoMethodMessage(this)))
	stloc:RuntimeMethodInfo(var_3_0F, ldfld:RuntimeMethodInfo(MonoMethodMessage::method, ldloc:MonoMethodMessage(this)))
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

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06001E81 RID: 7809 RVA: 0x00042CB0 File Offset: 0x00040EB0
		public object MethodSignature
		{
			get
			{
				if (this.methodSignature == null)
				{
					RuntimeMethodInfo runtimeMethodInfo = this.method;
					string name = runtimeMethodInfo.name;
					string name2 = runtimeMethodInfo.name;
					Type[] array = this.methodSignature;
					Type[] array2 = this.methodSignature;
				}
				throw new ArrayTypeMismatchException();
			}
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06001E82 RID: 7810 RVA: 0x00042CF0 File Offset: 0x00040EF0
		public string TypeName
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001E82)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Runtime.Remoting.Messaging.MonoMethodMessage::get_TypeName()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:RuntimeMethodInfo(var_0_06, ldfld:RuntimeMethodInfo(MonoMethodMessage::method, ldloc:MonoMethodMessage(this)))
	stloc:RuntimeMethodInfo(var_3_0F, ldfld:RuntimeMethodInfo(MonoMethodMessage::method, ldloc:MonoMethodMessage(this)))
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

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06001E83 RID: 7811 RVA: 0x00042D0C File Offset: 0x00040F0C
		// (set) Token: 0x06001E84 RID: 7812 RVA: 0x00042D20 File Offset: 0x00040F20
		public string Uri
		{
			get
			{
				return this.uri;
			}
			set
			{
				this.uri = value;
			}
		}

		// Token: 0x06001E85 RID: 7813 RVA: 0x00042D34 File Offset: 0x00040F34
		public object GetArg(int arg_num)
		{
			if (this.args != null)
			{
				return;
			}
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06001E86 RID: 7814 RVA: 0x00042D4C File Offset: 0x00040F4C
		public Exception Exception
		{
			get
			{
				return this.exc;
			}
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06001E87 RID: 7815 RVA: 0x00042D60 File Offset: 0x00040F60
		public int OutArgCount
		{
			get
			{
				if (this.args != null)
				{
					byte[] array = this.arg_types;
					return;
				}
			}
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06001E88 RID: 7816 RVA: 0x00042D84 File Offset: 0x00040F84
		public object[] OutArgs
		{
			get
			{
				if (this.args != null)
				{
					int outArgCount = this.OutArgCount;
					byte[] array = this.arg_types;
					object[] array2 = this.args;
				}
				throw new ArrayTypeMismatchException();
			}
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06001E89 RID: 7817 RVA: 0x00042DB8 File Offset: 0x00040FB8
		public object ReturnValue
		{
			get
			{
				return this.rval;
			}
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06001E8A RID: 7818 RVA: 0x00042DCC File Offset: 0x00040FCC
		// (set) Token: 0x06001E8B RID: 7819 RVA: 0x00042DE0 File Offset: 0x00040FE0
		Identity IInternalMessage.TargetIdentity
		{
			get
			{
				return this.identity;
			}
			set
			{
				this.identity = value;
			}
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06001E8C RID: 7820 RVA: 0x00042DF4 File Offset: 0x00040FF4
		public AsyncResult AsyncResult
		{
			get
			{
				return this.asyncResult;
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06001E8D RID: 7821 RVA: 0x00042E08 File Offset: 0x00041008
		internal CallType CallType
		{
			get
			{
				while (this.call_type != CallType.Sync)
				{
				}
				bool flag = RemotingServices.IsOneWay(this.method);
				this.call_type = CallType.OneWay;
				return CallType.OneWay;
			}
		}

		// Token: 0x06001E8E RID: 7822 RVA: 0x00042E38 File Offset: 0x00041038
		public bool NeedsOutProcessing([Out] int outCount)
		{
			/*
An exception occurred when decompiling this method (06001E8E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Runtime.Remoting.Messaging.MonoMethodMessage::NeedsOutProcessing(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint8[](var_0_06, ldfld:uint8[](MonoMethodMessage::arg_types, ldloc:MonoMethodMessage(this)))
	stloc:int64(var_1_08, ldc.i4:int64(0))
	stfld:int32(int32::m_value, ldloc:int32[exp:int32&](outCount), ldloc:int64[exp:int32](var_1_08))
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

		// Token: 0x04000F4B RID: 3915
		private RuntimeMethodInfo method;

		// Token: 0x04000F4C RID: 3916
		private object[] args;

		// Token: 0x04000F4D RID: 3917
		private string[] names;

		// Token: 0x04000F4E RID: 3918
		private byte[] arg_types;

		// Token: 0x04000F4F RID: 3919
		public LogicalCallContext ctx;

		// Token: 0x04000F50 RID: 3920
		public object rval;

		// Token: 0x04000F51 RID: 3921
		public Exception exc;

		// Token: 0x04000F52 RID: 3922
		private AsyncResult asyncResult;

		// Token: 0x04000F53 RID: 3923
		private CallType call_type;

		// Token: 0x04000F54 RID: 3924
		private string uri;

		// Token: 0x04000F55 RID: 3925
		private MCMDictionary properties;

		// Token: 0x04000F56 RID: 3926
		private Identity identity;

		// Token: 0x04000F57 RID: 3927
		private Type[] methodSignature;
	}
}
