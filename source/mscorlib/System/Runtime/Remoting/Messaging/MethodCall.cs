using System;
using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Cpp2IlInjected;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020003B1 RID: 945
	[ComVisible(true)]
	[CLSCompliant(false)]
	[Serializable]
	public class MethodCall : IMethodCallMessage, IMethodMessage, IMessage, ISerializable, IInternalMessage
	{
		// Token: 0x06001E1E RID: 7710 RVA: 0x00041A4C File Offset: 0x0003FC4C
		internal MethodCall(SerializationInfo info, StreamingContext context)
		{
			SerializationInfoEnumerator enumerator = info.GetEnumerator();
			bool flag = enumerator.MoveNext();
			SerializationEntry serializationEntry = enumerator.Current;
		}

		// Token: 0x06001E1F RID: 7711 RVA: 0x00041A78 File Offset: 0x0003FC78
		internal MethodCall(CADMethodCallMessage msg)
		{
			string text = string.Copy(msg._uri);
			this._uri = text;
			ArrayList arguments = msg.GetArguments();
			object[] args = msg._args;
			object[] array;
			this._args = array;
			LogicalCallContext logicalCallContext = msg.GetLogicalCallContext(arguments);
			this._callContext = logicalCallContext;
			if (logicalCallContext == null)
			{
			}
			MethodBase method = msg.GetMethod();
			this._methodBase = method;
			int propertyCount = msg._propertyCount;
			int propertyCount2 = msg._propertyCount;
		}

		// Token: 0x06001E20 RID: 7712 RVA: 0x00041AEC File Offset: 0x0003FCEC
		internal MethodCall()
		{
		}

		// Token: 0x06001E21 RID: 7713 RVA: 0x00041B00 File Offset: 0x0003FD00
		internal void CopyFrom(IMethodMessage call)
		{
		}

		// Token: 0x06001E22 RID: 7714 RVA: 0x00041B54 File Offset: 0x0003FD54
		internal virtual void InitMethodProperty(string key, object value)
		{
			uint num = <PrivateImplementationDetails>.ComputeStringHash(key);
			bool flag = key == "__Args";
			if (value == null)
			{
				return;
			}
			if (value != null)
			{
				this._args = value;
				return;
			}
			throw new InvalidCastException();
		}

		// Token: 0x06001E23 RID: 7715 RVA: 0x00041BF4 File Offset: 0x0003FDF4
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			string typeName = this._typeName;
			info.AddValue("__TypeName", typeName);
			string methodName = this._methodName;
			info.AddValue("__MethodName", methodName);
			Type[] methodSignature = this._methodSignature;
			info.AddValue("__MethodSignature", methodSignature);
			object[] args = this._args;
			info.AddValue("__Args", args);
			LogicalCallContext callContext = this._callContext;
			info.AddValue("__CallContext", callContext);
			string uri = this._uri;
			info.AddValue("__Uri", uri);
			Type[] genericArguments = this._genericArguments;
			info.AddValue("__GenericArguments", genericArguments);
			IDictionary internalProperties = this.InternalProperties;
			if (internalProperties != null)
			{
				return;
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06001E24 RID: 7716 RVA: 0x00041CD4 File Offset: 0x0003FED4
		public int ArgCount
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001E24)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Runtime.Remoting.Messaging.MethodCall::get_ArgCount()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:object[](var_0_06, ldfld:object[](MethodCall::_args, ldloc:MethodCall(this)))
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

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06001E25 RID: 7717 RVA: 0x00041CE8 File Offset: 0x0003FEE8
		public object[] Args
		{
			get
			{
				return this._args;
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06001E26 RID: 7718 RVA: 0x00041CFC File Offset: 0x0003FEFC
		public LogicalCallContext LogicalCallContext
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001E26)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Runtime.Remoting.Messaging.LogicalCallContext System.Runtime.Remoting.Messaging.MethodCall::get_LogicalCallContext()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:LogicalCallContext[exp:bool](MethodCall::_callContext, ldloc:MethodCall(this)))
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

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06001E27 RID: 7719 RVA: 0x00041D10 File Offset: 0x0003FF10
		public MethodBase MethodBase
		{
			get
			{
				MethodBase methodBase = this._methodBase;
				this.ResolveMethod();
				return this._methodBase;
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06001E28 RID: 7720 RVA: 0x00041D30 File Offset: 0x0003FF30
		public string MethodName
		{
			get
			{
				string methodName = this._methodName;
				if (methodName == null)
				{
					this._methodName = methodName;
				}
				return methodName;
			}
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06001E29 RID: 7721 RVA: 0x00041D50 File Offset: 0x0003FF50
		public object MethodSignature
		{
			get
			{
				if (this._methodSignature == null)
				{
					MethodBase methodBase = this._methodBase;
					MethodBase methodBase2 = this._methodBase;
					Type[] methodSignature = this._methodSignature;
				}
				Type[] methodSignature2 = this._methodSignature;
				throw new ArrayTypeMismatchException();
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06001E2A RID: 7722 RVA: 0x00041D8C File Offset: 0x0003FF8C
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

		// Token: 0x06001E2B RID: 7723 RVA: 0x00041DA8 File Offset: 0x0003FFA8
		internal virtual void InitDictionary()
		{
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06001E2C RID: 7724 RVA: 0x00041DB8 File Offset: 0x0003FFB8
		public string TypeName
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001E2C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Runtime.Remoting.Messaging.MethodCall::get_TypeName()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:MethodBase(var_0_0E, ldfld:MethodBase(MethodCall::_methodBase, ldloc:MethodCall(this)))
	stfld:string(MethodCall::_typeName, ldloc:MethodCall(this), ldloc:MethodBase[exp:string](var_0_0E))
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

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06001E2D RID: 7725 RVA: 0x0000207A File Offset: 0x0000027A
		// (set) Token: 0x06001E2E RID: 7726 RVA: 0x00041DDC File Offset: 0x0003FFDC
		public string Uri
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
				this._uri = value;
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06001E2F RID: 7727 RVA: 0x00041DF0 File Offset: 0x0003FFF0
		// (set) Token: 0x06001E30 RID: 7728 RVA: 0x00041E04 File Offset: 0x00040004
		string IInternalMessage.Uri
		{
			get
			{
				return this._uri;
			}
			set
			{
				this._uri = value;
			}
		}

		// Token: 0x06001E31 RID: 7729 RVA: 0x00041E18 File Offset: 0x00040018
		public object GetArg(int argNum)
		{
			/*
An exception occurred when decompiling this method (06001E31)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Runtime.Remoting.Messaging.MethodCall::GetArg(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:object[](var_0_06, ldfld:object[](MethodCall::_args, ldloc:MethodCall(this)))
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

		// Token: 0x06001E32 RID: 7730 RVA: 0x00041E2C File Offset: 0x0004002C
		public virtual void Init()
		{
		}

		// Token: 0x06001E33 RID: 7731 RVA: 0x00041E3C File Offset: 0x0004003C
		public void ResolveMethod()
		{
			int num = 1;
			string uri = this._uri;
			Type[] array;
			if (uri != null)
			{
				if (num == 0)
				{
				}
				Type serverTypeForUri = RemotingServices.GetServerTypeForUri(uri);
				string typeName = this._typeName;
				string methodName = this._methodName;
				Type[] methodSignature = this._methodSignature;
				Type type;
				MethodBase methodBaseFromName = RemotingServices.GetMethodBaseFromName(type, methodName, methodSignature);
				this._methodBase = methodBaseFromName;
				bool flag = type != serverTypeForUri;
				bool isInterface = type.IsInterface;
				bool isInterface2 = serverTypeForUri.IsInterface;
				MethodBase methodBase = this._methodBase;
				MethodBase virtualMethod = RemotingServices.GetVirtualMethod(serverTypeForUri, methodBase);
				this._methodBase = virtualMethod;
				string methodName2 = this._methodName;
				if (serverTypeForUri == null)
				{
					return;
				}
			}
			else if (array != null)
			{
				return;
			}
		}

		// Token: 0x06001E34 RID: 7732 RVA: 0x00041F20 File Offset: 0x00040120
		private Type CastTo(string clientType, Type serverType)
		{
			string typeNameFromAssemblyQualifiedName = MethodCall.GetTypeNameFromAssemblyQualifiedName(clientType);
			return serverType;
		}

		// Token: 0x06001E35 RID: 7733 RVA: 0x00041F3C File Offset: 0x0004013C
		private static string GetTypeNameFromAssemblyQualifiedName(string aqname)
		{
			string text;
			return text.Trim();
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06001E36 RID: 7734 RVA: 0x00041F60 File Offset: 0x00040160
		// (set) Token: 0x06001E37 RID: 7735 RVA: 0x00041F74 File Offset: 0x00040174
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

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06001E38 RID: 7736 RVA: 0x00041F88 File Offset: 0x00040188
		private Type[] GenericArguments
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001E38)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Type[] System.Runtime.Remoting.Messaging.MethodCall::get_GenericArguments()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:MethodBase(var_0_0E, callgetter:MethodBase(MethodCall::get_MethodBase, ldloc:MethodCall(this)))
	stfld:class System.Type[](MethodCall::_genericArguments, ldloc:MethodCall(this), ldloc:MethodBase[exp:class System.Type[]](var_0_0E))
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

		// Token: 0x04000F27 RID: 3879
		private string _uri;

		// Token: 0x04000F28 RID: 3880
		private string _typeName;

		// Token: 0x04000F29 RID: 3881
		private string _methodName;

		// Token: 0x04000F2A RID: 3882
		private object[] _args;

		// Token: 0x04000F2B RID: 3883
		private Type[] _methodSignature;

		// Token: 0x04000F2C RID: 3884
		private MethodBase _methodBase;

		// Token: 0x04000F2D RID: 3885
		private LogicalCallContext _callContext;

		// Token: 0x04000F2E RID: 3886
		private Identity _targetIdentity;

		// Token: 0x04000F2F RID: 3887
		private Type[] _genericArguments;

		// Token: 0x04000F30 RID: 3888
		protected IDictionary ExternalProperties;

		// Token: 0x04000F31 RID: 3889
		protected IDictionary InternalProperties;
	}
}
