using System;
using System.Collections;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Proxies;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using Cpp2IlInjected;

namespace System.Runtime.Remoting
{
	// Token: 0x02000349 RID: 841
	[ComVisible(true)]
	public static class RemotingServices
	{
		// Token: 0x06001C1E RID: 7198 RVA: 0x0003D1E0 File Offset: 0x0003B3E0
		static RemotingServices()
		{
			RemotingServices.RegisterInternalChannels();
			Type type;
			ServerIdentity serverIdentity = RemotingServices.CreateWellKnownServerIdentity(type, "RemoteActivationService.rem", WellKnownObjectMode.Singleton);
			Type type2;
			MethodInfo method = type2.GetMethod("FieldSetter", BindingFlags.Instance | BindingFlags.NonPublic);
			Type type3;
			MethodInfo method2 = type3.GetMethod("FieldGetter", BindingFlags.Instance | BindingFlags.NonPublic);
		}

		// Token: 0x06001C1F RID: 7199 RVA: 0x0003D220 File Offset: 0x0003B420
		internal static object InternalExecute(MethodBase method, object obj, object[] parameters, [Out] object[] out_args)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001C20 RID: 7200 RVA: 0x0003D234 File Offset: 0x0003B434
		internal static MethodBase GetVirtualMethod(Type type, MethodBase method)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001C21 RID: 7201 RVA: 0x0000207A File Offset: 0x0000027A
		public static bool IsTransparentProxy(object proxy)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001C22 RID: 7202 RVA: 0x0003D248 File Offset: 0x0003B448
		internal static IMethodReturnMessage InternalExecuteMessage(MarshalByRefObject target, IMethodCallMessage reqMsg)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001C23 RID: 7203 RVA: 0x0003D2B8 File Offset: 0x0003B4B8
		[ComVisible(true)]
		public static object Connect(Type classToProxy, string url)
		{
			if (!true)
			{
			}
			object obj;
			return obj;
		}

		// Token: 0x06001C24 RID: 7204 RVA: 0x0003D2CC File Offset: 0x0003B4CC
		[ComVisible(true)]
		public static object Connect(Type classToProxy, string url, object data)
		{
			if (!true)
			{
			}
			object obj;
			return obj;
		}

		// Token: 0x06001C25 RID: 7205 RVA: 0x0003D2E0 File Offset: 0x0003B4E0
		public static Type GetServerTypeForUri(string URI)
		{
			for (;;)
			{
				if (!true)
				{
				}
				Identity identity;
				if (identity != null)
				{
					return;
				}
			}
		}

		// Token: 0x06001C26 RID: 7206 RVA: 0x0003D2F4 File Offset: 0x0003B4F4
		public static object Unmarshal(ObjRef objectRef)
		{
			if (!true)
			{
			}
			object obj;
			return obj;
		}

		// Token: 0x06001C27 RID: 7207 RVA: 0x0003D308 File Offset: 0x0003B508
		public static object Unmarshal(ObjRef objectRef, bool fRefine)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			object obj;
			return obj;
		}

		// Token: 0x06001C28 RID: 7208 RVA: 0x0000207A File Offset: 0x0000027A
		public static ObjRef Marshal(MarshalByRefObject Obj)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001C29 RID: 7209 RVA: 0x0000207A File Offset: 0x0000027A
		public static ObjRef Marshal(MarshalByRefObject Obj, string ObjURI, Type RequestedType)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001C2A RID: 7210 RVA: 0x0003D348 File Offset: 0x0003B548
		private static string NewUri()
		{
			if (!true)
			{
			}
			return 0;
		}

		// Token: 0x06001C2B RID: 7211 RVA: 0x0000207A File Offset: 0x0000027A
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static RealProxy GetRealProxy(object proxy)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001C2C RID: 7212 RVA: 0x0003D424 File Offset: 0x0003B624
		public static MethodBase GetMethodBaseFromMethodMessage(IMethodMessage msg)
		{
			bool flag;
			bool value = flag.m_value;
			bool value2 = flag.m_value;
			if (!flag)
			{
				throw new InvalidCastException();
			}
			MethodBase methodBase;
			return methodBase;
		}

		// Token: 0x06001C2D RID: 7213 RVA: 0x0003D44C File Offset: 0x0003B64C
		internal static MethodBase GetMethodBaseFromName(Type type, string methodName, Type[] signature)
		{
			if (!true)
			{
			}
			MethodBase methodBase;
			return methodBase;
		}

		// Token: 0x06001C2E RID: 7214 RVA: 0x0003D478 File Offset: 0x0003B678
		private static MethodBase FindInterfaceMethod(Type type, string methodName, Type[] signature)
		{
			int num = 1;
			if (methodName != null)
			{
			}
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x06001C2F RID: 7215 RVA: 0x0003D494 File Offset: 0x0003B694
		public static void GetObjectData(object obj, SerializationInfo info, StreamingContext context)
		{
			/*
An exception occurred when decompiling this method (06001C2F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Runtime.Remoting.RemotingServices::GetObjectData(System.Object,System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldloc:object[exp:bool](obj))
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

		// Token: 0x06001C30 RID: 7216 RVA: 0x0003D4A4 File Offset: 0x0003B6A4
		public static bool IsOneWay(MethodBase method)
		{
			/*
An exception occurred when decompiling this method (06001C30)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Runtime.Remoting.RemotingServices::IsOneWay(System.Reflection.MethodBase)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
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

		// Token: 0x06001C31 RID: 7217 RVA: 0x0003D4B4 File Offset: 0x0003B6B4
		internal static object CreateClientProxy(ActivatedClientTypeEntry entry, object[] activationAttributes)
		{
			if (entry != null)
			{
			}
			object obj;
			return obj;
		}

		// Token: 0x06001C32 RID: 7218 RVA: 0x0003D4C8 File Offset: 0x0003B6C8
		internal static object CreateClientProxy(Type objectType, string url, object[] activationAttributes)
		{
			/*
An exception occurred when decompiling this method (06001C32)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Runtime.Remoting.RemotingServices::CreateClientProxy(System.Type,System.String,System.Object[])

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_2_0B, call:string(string::Concat, ldloc:string(var_1), ldstr:string("RemoteActivationService.rem")))
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

		// Token: 0x06001C33 RID: 7219 RVA: 0x0003D4E0 File Offset: 0x0003B6E0
		internal static object CreateClientProxy(WellKnownClientTypeEntry entry)
		{
			if (!true)
			{
			}
			object obj;
			return obj;
		}

		// Token: 0x06001C34 RID: 7220 RVA: 0x0003D4F4 File Offset: 0x0003B6F4
		internal static object CreateClientProxyForContextBound(Type type, object[] activationAttributes)
		{
			int num = 1;
			Type type2;
			if (Attribute.GetCustomAttribute(type2, type2, num != 0) != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06001C35 RID: 7221 RVA: 0x0003D514 File Offset: 0x0003B714
		internal static Identity GetIdentityForUri(string uri)
		{
			if (!true)
			{
			}
			if (false)
			{
				throw new OutOfMemoryException();
			}
			string text;
			if (text != null)
			{
				throw new InvalidCastException();
			}
			if (!false)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001C36 RID: 7222 RVA: 0x0003D544 File Offset: 0x0003B744
		private static string RemoveAppNameFromUri(string uri)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (uri != null)
			{
				string text = "/" + uri + "/";
				bool flag = text.StartsWith(text);
				int stringLength = text._stringLength;
				string text2;
				return text2;
			}
		}

		// Token: 0x06001C37 RID: 7223 RVA: 0x0003D580 File Offset: 0x0003B780
		internal static ClientIdentity GetOrCreateClientIdentity(ObjRef objRef, Type proxyType, [Out] object clientProxy)
		{
			IMessageSink messageSink;
			if (messageSink != null)
			{
			}
			if (!false)
			{
				MarshalByRefObject marshalByRefObject;
				while (marshalByRefObject != null)
				{
				}
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001C38 RID: 7224 RVA: 0x0003D5B4 File Offset: 0x0003B7B4
		private static IMessageSink GetClientChannelSinkChain(string url, object channelData, [Out] string objectUri)
		{
			if (!true)
			{
			}
			IMessageSink messageSink;
			if (messageSink != null)
			{
				return messageSink;
			}
			return "Cannot create channel sink to connect to the remote object. An appropriate channel has probably not been registered.";
		}

		// Token: 0x06001C39 RID: 7225 RVA: 0x0003D5DC File Offset: 0x0003B7DC
		internal static ClientActivatedIdentity CreateContextBoundObjectIdentity(Type objectType)
		{
			/*
An exception occurred when decompiling this method (06001C39)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Runtime.Remoting.ClientActivatedIdentity System.Runtime.Remoting.RemotingServices::CreateContextBoundObjectIdentity(System.Type)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	brtrue(IL_0000, ldc.i4:bool(1))
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

		// Token: 0x06001C3A RID: 7226 RVA: 0x0003D5F0 File Offset: 0x0003B7F0
		internal static ClientActivatedIdentity CreateClientActivatedServerIdentity(MarshalByRefObject realObject, Type objectType, string objectUri)
		{
			if (!true)
			{
			}
			Context defaultContext = Context.DefaultContext;
			if (!true)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06001C3B RID: 7227 RVA: 0x0003D610 File Offset: 0x0003B810
		internal static ServerIdentity CreateWellKnownServerIdentity(Type objectType, string objectUri, WellKnownObjectMode mode)
		{
			/*
An exception occurred when decompiling this method (06001C3B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Runtime.Remoting.ServerIdentity System.Runtime.Remoting.RemotingServices::CreateWellKnownServerIdentity(System.Type,System.String,System.Runtime.Remoting.WellKnownObjectMode)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:Context(var_1_0A, callgetter:Context(Context::get_DefaultContext))
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

		// Token: 0x06001C3C RID: 7228 RVA: 0x0003D628 File Offset: 0x0003B828
		private static void RegisterServerIdentity(ServerIdentity identity)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			string objectUri = identity._objectUri;
			if (!true)
			{
			}
			string objectUri2 = identity._objectUri;
			long num = 0L;
			if (true)
			{
			}
			if (num == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001C3D RID: 7229 RVA: 0x0003D678 File Offset: 0x0003B878
		internal static object GetProxyForRemoteObject(ObjRef objref, Type classToProxy)
		{
			Identity identity;
			if (identity != null)
			{
			}
			object obj;
			return obj;
		}

		// Token: 0x06001C3E RID: 7230 RVA: 0x0003D68C File Offset: 0x0003B88C
		internal static object GetRemoteObject(ObjRef objRef, Type proxyType)
		{
			/*
An exception occurred when decompiling this method (06001C3E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Runtime.Remoting.RemotingServices::GetRemoteObject(System.Runtime.Remoting.ObjRef,System.Type)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
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

		// Token: 0x06001C3F RID: 7231 RVA: 0x0003D69C File Offset: 0x0003B89C
		internal static byte[] SerializeCallData(object obj)
		{
			bool isNull = Thread.CurrentThread.GetExecutionContextReader().LogicalCallContext.IsNull;
			if (!false)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001C40 RID: 7232 RVA: 0x0003D6E4 File Offset: 0x0003B8E4
		internal static object DeserializeCallData(byte[] array)
		{
			long num = 0L;
			int num2 = 3;
			object obj;
			Monitor.Exit(obj);
			if (num == 0L)
			{
				if (num2 == 0)
				{
					if (obj != null)
					{
						return obj;
					}
				}
				if (num != 0L)
				{
				}
				LogicalCallContext logicalCallContext = Thread.CurrentThread.GetMutableExecutionContext().LogicalCallContext;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001C41 RID: 7233 RVA: 0x0003D740 File Offset: 0x0003B940
		internal static byte[] SerializeExceptionData(Exception ex)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			long num = 0L;
			if (true)
			{
			}
			if (num == 0L)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001C42 RID: 7234 RVA: 0x0003D76C File Offset: 0x0003B96C
		private static void RegisterInternalChannels()
		{
			if (!true)
			{
			}
			CrossAppDomainChannel.RegisterCrossAppDomainChannel();
		}

		// Token: 0x06001C43 RID: 7235 RVA: 0x0003D784 File Offset: 0x0003B984
		internal static void DisposeIdentity(Identity ident)
		{
			if (!true)
			{
			}
			if (ident._disposed)
			{
				return;
			}
			string objectUri = ident._objectUri;
			int num = 1;
			long num2 = 0L;
			ident._disposed = num != 0;
			if (num != 0)
			{
			}
			if (num2 == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001C44 RID: 7236 RVA: 0x0003D7DC File Offset: 0x0003B9DC
		internal static Identity GetMessageTargetIdentity(IMessage msg)
		{
			if (!true)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06001C45 RID: 7237 RVA: 0x0003D820 File Offset: 0x0003BA20
		internal static void SetMessageTargetIdentity(IMessage msg, Identity ident)
		{
			if (msg == null)
			{
				return;
			}
			if (msg == null)
			{
				return;
			}
			if (msg != null && msg != null)
			{
				return;
			}
			throw new InvalidCastException();
		}

		// Token: 0x06001C46 RID: 7238 RVA: 0x0003D84C File Offset: 0x0003BA4C
		internal static bool UpdateOutArgObject(ParameterInfo pi, object local, object remote)
		{
			if (pi != null)
			{
			}
			if (pi != null)
			{
			}
			if (local != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06001C47 RID: 7239 RVA: 0x0003D874 File Offset: 0x0003BA74
		private static string GetNormalizedUri(string uri)
		{
			string text;
			return text;
		}

		// Token: 0x04000E53 RID: 3667
		private static Hashtable uri_hash;

		// Token: 0x04000E54 RID: 3668
		private static BinaryFormatter _serializationFormatter;

		// Token: 0x04000E55 RID: 3669
		private static BinaryFormatter _deserializationFormatter;

		// Token: 0x04000E56 RID: 3670
		private static string app_id;

		// Token: 0x04000E57 RID: 3671
		private static readonly object app_id_lock;

		// Token: 0x04000E58 RID: 3672
		private static int next_id;

		// Token: 0x04000E59 RID: 3673
		private static readonly MethodInfo FieldSetterMethod;

		// Token: 0x04000E5A RID: 3674
		private static readonly MethodInfo FieldGetterMethod;

		// Token: 0x0200034A RID: 842
		[Serializable]
		private class CACD
		{
			// Token: 0x06001C48 RID: 7240 RVA: 0x0003D884 File Offset: 0x0003BA84
			public CACD()
			{
			}

			// Token: 0x04000E5B RID: 3675
			public object d;

			// Token: 0x04000E5C RID: 3676
			public object c;
		}
	}
}
