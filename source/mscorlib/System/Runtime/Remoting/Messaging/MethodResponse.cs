using System;
using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020003B5 RID: 949
	[CLSCompliant(false)]
	[ComVisible(true)]
	[Serializable]
	public class MethodResponse : IMethodReturnMessage, IMethodMessage, IMessage, ISerializable, IInternalMessage
	{
		// Token: 0x06001E5B RID: 7771 RVA: 0x0004257C File Offset: 0x0004077C
		internal MethodResponse(Exception e, IMethodCallMessage msg)
		{
			this._callMsg = msg;
			if (msg != null)
			{
				return;
			}
		}

		// Token: 0x06001E5C RID: 7772 RVA: 0x000425AC File Offset: 0x000407AC
		internal MethodResponse(object returnValue, object[] outArgs, LogicalCallContext callCtx, IMethodCallMessage msg)
		{
			this._callMsg = msg;
		}

		// Token: 0x06001E5D RID: 7773 RVA: 0x000425E0 File Offset: 0x000407E0
		internal MethodResponse(IMethodCallMessage msg, CADMethodReturnMessage retmsg)
		{
			this._callMsg = msg;
		}

		// Token: 0x06001E5E RID: 7774 RVA: 0x0004266C File Offset: 0x0004086C
		internal MethodResponse(SerializationInfo info, StreamingContext context)
		{
			SerializationInfoEnumerator enumerator = info.GetEnumerator();
			bool flag = enumerator.MoveNext();
			SerializationEntry serializationEntry = enumerator.Current;
		}

		// Token: 0x06001E5F RID: 7775 RVA: 0x00042698 File Offset: 0x00040898
		internal void InitMethodProperty(string key, object value)
		{
			uint num = <PrivateImplementationDetails>.ComputeStringHash(key);
			bool flag = key == "__CallContext";
			if (value != null)
			{
				this._callContext = value;
				return;
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06001E60 RID: 7776 RVA: 0x0004277C File Offset: 0x0004097C
		public int ArgCount
		{
			get
			{
				if (this._args != null)
				{
					return;
				}
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06001E61 RID: 7777 RVA: 0x00042794 File Offset: 0x00040994
		public object[] Args
		{
			get
			{
				return this._args;
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06001E62 RID: 7778 RVA: 0x000427A8 File Offset: 0x000409A8
		public Exception Exception
		{
			get
			{
				return this._exception;
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06001E63 RID: 7779 RVA: 0x000427BC File Offset: 0x000409BC
		public LogicalCallContext LogicalCallContext
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001E63)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Runtime.Remoting.Messaging.LogicalCallContext System.Runtime.Remoting.Messaging.MethodResponse::get_LogicalCallContext()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:LogicalCallContext[exp:bool](MethodResponse::_callContext, ldloc:MethodResponse(this)))
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

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06001E64 RID: 7780 RVA: 0x000427D0 File Offset: 0x000409D0
		public MethodBase MethodBase
		{
			get
			{
				MethodBase methodBase = this._methodBase;
				IMethodCallMessage callMsg = this._callMsg;
				if (callMsg != null)
				{
				}
				if (this.MethodName != null && this.TypeName != null)
				{
					return RemotingServices.GetMethodBaseFromMethodMessage(this);
				}
				return this._methodBase;
			}
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06001E65 RID: 7781 RVA: 0x00042814 File Offset: 0x00040A14
		public string MethodName
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001E65)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Runtime.Remoting.Messaging.MethodResponse::get_MethodName()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0012:
	stloc:int64(var_1_18, ldfld:int64(int64::m_value, ldc.i4:int32[exp:int64&](0)))
	stfld:string(MethodResponse::_methodName, ldloc:MethodResponse(this), ldloc:IMethodCallMessage[exp:string](var_0_0E))
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

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06001E66 RID: 7782 RVA: 0x00042840 File Offset: 0x00040A40
		public object MethodSignature
		{
			get
			{
				if (this._methodSignature != null)
				{
				}
				IMethodCallMessage callMsg = this._callMsg;
				while (callMsg == null)
				{
				}
				if (callMsg != null && callMsg != null)
				{
					this._methodSignature = callMsg;
					if (callMsg != null)
					{
					}
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06001E67 RID: 7783 RVA: 0x00042874 File Offset: 0x00040A74
		public object[] OutArgs
		{
			get
			{
				while (this._outArgs != null)
				{
				}
				if (this._args != null)
				{
					if (this._inArgInfo == null)
					{
						MethodBase methodBase = this.MethodBase;
						object[] args = this._args;
					}
					object[] array;
					this._outArgs = array;
					return array;
				}
			}
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06001E68 RID: 7784 RVA: 0x000428B4 File Offset: 0x00040AB4
		public virtual IDictionary Properties
		{
			get
			{
				while (this.ExternalProperties != null)
				{
				}
				return this.ExternalProperties;
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06001E69 RID: 7785 RVA: 0x000428D0 File Offset: 0x00040AD0
		public object ReturnValue
		{
			get
			{
				return this._returnValue;
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06001E6A RID: 7786 RVA: 0x000428E4 File Offset: 0x00040AE4
		public string TypeName
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001E6A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Runtime.Remoting.Messaging.MethodResponse::get_TypeName()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0012:
	stloc:int64(var_1_18, ldfld:int64(int64::m_value, ldc.i4:int32[exp:int64&](0)))
	stfld:string(MethodResponse::_typeName, ldloc:MethodResponse(this), ldloc:IMethodCallMessage[exp:string](var_0_0E))
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

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06001E6B RID: 7787 RVA: 0x00042910 File Offset: 0x00040B10
		// (set) Token: 0x06001E6C RID: 7788 RVA: 0x0004293C File Offset: 0x00040B3C
		public string Uri
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001E6B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Runtime.Remoting.Messaging.MethodResponse::get_Uri()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0012:
	stloc:int64(var_1_18, ldfld:int64(int64::m_value, ldc.i4:int32[exp:int64&](0)))
	stfld:string(MethodResponse::_uri, ldloc:MethodResponse(this), ldloc:IMethodCallMessage[exp:string](var_0_0E))
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
			set
			{
				this._uri = value;
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06001E6D RID: 7789 RVA: 0x00042950 File Offset: 0x00040B50
		// (set) Token: 0x06001E6E RID: 7790 RVA: 0x00042964 File Offset: 0x00040B64
		string IInternalMessage.Uri
		{
			get
			{
				return this.Uri;
			}
			set
			{
				this._uri = value;
			}
		}

		// Token: 0x06001E6F RID: 7791 RVA: 0x00042978 File Offset: 0x00040B78
		public object GetArg(int argNum)
		{
			if (this._args != null)
			{
				return;
			}
		}

		// Token: 0x06001E70 RID: 7792 RVA: 0x00042990 File Offset: 0x00040B90
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (this._exception != null)
			{
				return;
			}
			string typeName = this._typeName;
			info.AddValue("__TypeName", typeName);
			string methodName = this._methodName;
			info.AddValue("__MethodName", methodName);
			Type[] methodSignature = this._methodSignature;
			info.AddValue("__MethodSignature", methodSignature);
			string uri = this._uri;
			info.AddValue("__Uri", uri);
			object returnValue = this._returnValue;
			info.AddValue("__Return", returnValue);
			object[] args = this._args;
			info.AddValue("__OutArgs", args);
			LogicalCallContext callContext = this._callContext;
			info.AddValue("__CallContext", callContext);
			IDictionary internalProperties = this.InternalProperties;
			if (internalProperties != null)
			{
				return;
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06001E71 RID: 7793 RVA: 0x00042A78 File Offset: 0x00040C78
		// (set) Token: 0x06001E72 RID: 7794 RVA: 0x00042A8C File Offset: 0x00040C8C
		Identity IInternalMessage.TargetIdentity
		{
			get
			{
				return this._targetIdentity;
			}
			set
			{
				this._targetIdentity = value;
			}
		}

		// Token: 0x04000F3A RID: 3898
		private string _methodName;

		// Token: 0x04000F3B RID: 3899
		private string _uri;

		// Token: 0x04000F3C RID: 3900
		private string _typeName;

		// Token: 0x04000F3D RID: 3901
		private MethodBase _methodBase;

		// Token: 0x04000F3E RID: 3902
		private object _returnValue;

		// Token: 0x04000F3F RID: 3903
		private Exception _exception;

		// Token: 0x04000F40 RID: 3904
		private Type[] _methodSignature;

		// Token: 0x04000F41 RID: 3905
		private ArgInfo _inArgInfo;

		// Token: 0x04000F42 RID: 3906
		private object[] _args;

		// Token: 0x04000F43 RID: 3907
		private object[] _outArgs;

		// Token: 0x04000F44 RID: 3908
		private IMethodCallMessage _callMsg;

		// Token: 0x04000F45 RID: 3909
		private LogicalCallContext _callContext;

		// Token: 0x04000F46 RID: 3910
		private Identity _targetIdentity;

		// Token: 0x04000F47 RID: 3911
		protected IDictionary ExternalProperties;

		// Token: 0x04000F48 RID: 3912
		protected IDictionary InternalProperties;
	}
}
