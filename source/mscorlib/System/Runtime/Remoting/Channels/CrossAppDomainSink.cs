using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Threading;

namespace System.Runtime.Remoting.Channels
{
	// Token: 0x02000378 RID: 888
	[MonoTODO("Handle domain unloading?")]
	internal class CrossAppDomainSink : IMessageSink
	{
		// Token: 0x06001D35 RID: 7477 RVA: 0x0003FE78 File Offset: 0x0003E078
		internal CrossAppDomainSink(int domainID)
		{
			this._domainID = domainID;
		}

		// Token: 0x06001D36 RID: 7478 RVA: 0x0003FE94 File Offset: 0x0003E094
		internal static CrossAppDomainSink GetSink(int domainID)
		{
			if (!true)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06001D37 RID: 7479 RVA: 0x0003FEC8 File Offset: 0x0003E0C8
		internal int TargetDomainId
		{
			get
			{
				return this._domainID;
			}
		}

		// Token: 0x06001D38 RID: 7480 RVA: 0x0003FEDC File Offset: 0x0003E0DC
		private static CrossAppDomainSink.ProcessMessageRes ProcessMessageInDomain(byte[] arrRequest, CADMethodCallMessage cadMsg)
		{
			/*
An exception occurred when decompiling this method (06001D38)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Runtime.Remoting.Channels.CrossAppDomainSink/ProcessMessageRes System.Runtime.Remoting.Channels.CrossAppDomainSink::ProcessMessageInDomain(System.Byte[],System.Runtime.Remoting.Messaging.CADMethodCallMessage)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:AppDomain(var_1_07, callgetter:AppDomain(AppDomain::get_CurrentDomain))
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

		// Token: 0x06001D39 RID: 7481 RVA: 0x0003FEF4 File Offset: 0x0003E0F4
		public virtual IMessage SyncProcessMessage(IMessage msgRequest)
		{
			CADMethodCallMessage cadmethodCallMessage = CADMethodCallMessage.Create(msgRequest);
			if (cadmethodCallMessage != null)
			{
			}
			MemoryStream memoryStream = CADSerializer.SerializeMessage(msgRequest);
			Context currentContext = Thread.CurrentContext;
			int domainID = this._domainID;
			if (memoryStream != null && memoryStream == null)
			{
				throw new ArrayTypeMismatchException();
			}
			if (cadmethodCallMessage != null && cadmethodCallMessage == null)
			{
				throw new ArrayTypeMismatchException();
			}
			long num = 0L;
			int num2 = 3;
			Context context = AppDomain.InternalSetContext(currentContext);
			if (num == 0L && num2 == 0 && domainID != 0)
			{
				IMessage message;
				return message;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001D3A RID: 7482 RVA: 0x0003FF9C File Offset: 0x0003E19C
		public virtual IMessageCtrl AsyncProcessMessage(IMessage reqMsg, IMessageSink replySink)
		{
		}

		// Token: 0x06001D3B RID: 7483 RVA: 0x0003FFAC File Offset: 0x0003E1AC
		public void SendAsyncMessage(object data)
		{
			if (data != null)
			{
			}
		}

		// Token: 0x06001D3C RID: 7484 RVA: 0x0003FFC4 File Offset: 0x0003E1C4
		// Note: this type is marked as 'beforefieldinit'.
		static CrossAppDomainSink()
		{
			Type type;
			MethodInfo method = type.GetMethod("ProcessMessageInDomain", BindingFlags.Static | BindingFlags.NonPublic);
		}

		// Token: 0x06001D3D RID: 7485 RVA: 0x0003FFE0 File Offset: 0x0003E1E0
		[CompilerGenerated]
		private void <AsyncProcessMessage>b__10_0(object data)
		{
			this.SendAsyncMessage(data);
		}

		// Token: 0x04000EBF RID: 3775
		private static Hashtable s_sinks;

		// Token: 0x04000EC0 RID: 3776
		private static MethodInfo processMessageMethod;

		// Token: 0x04000EC1 RID: 3777
		private int _domainID;

		// Token: 0x02000379 RID: 889
		private struct ProcessMessageRes
		{
			// Token: 0x04000EC2 RID: 3778
			public byte[] arrResponse;

			// Token: 0x04000EC3 RID: 3779
			public CADMethodReturnMessage cadMrm;
		}
	}
}
