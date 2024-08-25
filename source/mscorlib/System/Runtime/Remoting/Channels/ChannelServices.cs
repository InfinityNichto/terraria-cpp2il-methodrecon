using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting.Channels
{
	// Token: 0x02000375 RID: 885
	[ComVisible(true)]
	public sealed class ChannelServices
	{
		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06001D1D RID: 7453 RVA: 0x0003F8CC File Offset: 0x0003DACC
		internal static CrossContextChannel CrossContextChannel
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001D1D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Runtime.Remoting.Contexts.CrossContextChannel System.Runtime.Remoting.Channels.ChannelServices::get_CrossContextChannel()

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
		}

		// Token: 0x06001D1E RID: 7454 RVA: 0x0003F8DC File Offset: 0x0003DADC
		internal static IMessageSink CreateClientChannelSinkChain(string url, object remoteChannelData, [Out] string objectUri)
		{
			while (url == null || url != null)
			{
				if (false)
				{
					IMessageSink messageSink;
					while (messageSink == null)
					{
					}
					return messageSink;
				}
			}
			throw new InvalidCastException();
		}

		// Token: 0x06001D1F RID: 7455 RVA: 0x0003F984 File Offset: 0x0003DB84
		internal static IMessageSink CreateClientChannelSinkChain(IChannelSender sender, string url, object[] channelDataArray, [Out] string objectUri)
		{
			/*
An exception occurred when decompiling this method (06001D1F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Runtime.Remoting.Messaging.IMessageSink System.Runtime.Remoting.Channels.ChannelServices::CreateClientChannelSinkChain(System.Runtime.Remoting.Channels.IChannelSender,System.String,System.Object[],System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int64(var_1_0B, ldfld:int64(int64::m_value, ldc.i4:int32[exp:int64&](0)))
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

		// Token: 0x06001D20 RID: 7456 RVA: 0x0003F99C File Offset: 0x0003DB9C
		[Obsolete("Use RegisterChannel(IChannel,Boolean)")]
		public static void RegisterChannel(IChannel chnl)
		{
			if (!true)
			{
			}
			long num = 0L;
			ChannelServices.RegisterChannel(chnl, num != 0L);
		}

		// Token: 0x06001D21 RID: 7457 RVA: 0x0003F9B8 File Offset: 0x0003DBB8
		public static void RegisterChannel(IChannel chnl, bool ensureSecurity)
		{
			if (chnl == null)
			{
				throw new OutOfMemoryException();
			}
			if (chnl != null)
			{
				return;
			}
			long num = 0L;
			string text = string.Format("Channel {0} is not securable while ensureSecurity is specified as true", num);
		}

		// Token: 0x06001D22 RID: 7458 RVA: 0x0003FA48 File Offset: 0x0003DC48
		internal static void RegisterChannelConfig(ChannelData channel)
		{
			ArrayList serverProviders = channel.ServerProviders;
			if (channel.ServerProviders == null)
			{
				return;
			}
		}

		// Token: 0x06001D23 RID: 7459 RVA: 0x0003FC14 File Offset: 0x0003DE14
		private static object CreateProvider(ProviderData prov)
		{
			if (!true)
			{
			}
			object obj;
			return obj;
		}

		// Token: 0x06001D24 RID: 7460 RVA: 0x0003FC3C File Offset: 0x0003DE3C
		public static IMessage SyncDispatchMessage(IMessage msg)
		{
			if (!true)
			{
			}
			ReturnMessage returnMessage;
			if (returnMessage != null)
			{
				while (returnMessage != null)
				{
				}
			}
			IMessage message;
			return ChannelServices.CheckReturnMessage(message, message);
		}

		// Token: 0x06001D25 RID: 7461 RVA: 0x0003FC5C File Offset: 0x0003DE5C
		private static ReturnMessage CheckIncomingMessage(IMessage msg)
		{
			if ("No receiver for uri " != null)
			{
				return "No receiver for uri ";
			}
			throw new InvalidCastException();
		}

		// Token: 0x06001D26 RID: 7462 RVA: 0x0003FC9C File Offset: 0x0003DE9C
		internal static IMessage CheckReturnMessage(IMessage callMsg, IMessage retMsg)
		{
			while (callMsg == null)
			{
			}
			return callMsg;
		}

		// Token: 0x06001D27 RID: 7463 RVA: 0x0003FCC0 File Offset: 0x0003DEC0
		private static bool IsLocalCall(IMessage callMsg)
		{
			return true;
		}

		// Token: 0x06001D28 RID: 7464 RVA: 0x0003FCD0 File Offset: 0x0003DED0
		internal static object[] GetCurrentChannelInfo()
		{
			if (!true)
			{
			}
			long num = 0L;
			int num2 = 4;
			if (num == 0L)
			{
				long num3 = 0L;
				if (num2 == 0)
				{
				}
				if (num3 == 0L)
				{
				}
				throw new OutOfMemoryException();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001D29 RID: 7465 RVA: 0x0003FD24 File Offset: 0x0003DF24
		// Note: this type is marked as 'beforefieldinit'.
		static ChannelServices()
		{
			if (("Novell.Zenworks.Zmd.Public.UnixServerChannel" == null || "Novell.Zenworks.Zmd.Public.UnixServerChannel" != null) && ("Novell.Zenworks.Zmd.Public.UnixChannel" == null || "Novell.Zenworks.Zmd.Public.UnixChannel" != null))
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x04000EB6 RID: 3766
		private static ArrayList registeredChannels;

		// Token: 0x04000EB7 RID: 3767
		private static ArrayList delayedClientChannels;

		// Token: 0x04000EB8 RID: 3768
		private static CrossContextChannel _crossContextSink;

		// Token: 0x04000EB9 RID: 3769
		internal static string CrossContextUrl;

		// Token: 0x04000EBA RID: 3770
		private static IList oldStartModeTypes;
	}
}
