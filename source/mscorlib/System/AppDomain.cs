using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Threading;
using Cpp2IlInjected;

namespace System
{
	// Token: 0x02000162 RID: 354
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[StructLayout(0)]
	public sealed class AppDomain : MarshalByRefObject
	{
		// Token: 0x06000E3F RID: 3647 RVA: 0x0001F0C8 File Offset: 0x0001D2C8
		[Intrinsic]
		internal static bool IsAppXModel()
		{
		}

		// Token: 0x06000E40 RID: 3648 RVA: 0x0001F0D8 File Offset: 0x0001D2D8
		private AppDomain()
		{
		}

		// Token: 0x06000E41 RID: 3649 RVA: 0x0000207A File Offset: 0x0000027A
		private string getFriendlyName()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000E42 RID: 3650 RVA: 0x0000207A File Offset: 0x0000027A
		private static AppDomain getCurDomain()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000E43 RID: 3651 RVA: 0x0000207A File Offset: 0x0000027A
		public static AppDomain CurrentDomain
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06000E44 RID: 3652 RVA: 0x0000207A File Offset: 0x0000027A
		private Assembly[] GetAssemblies(bool refOnly)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000E45 RID: 3653 RVA: 0x0000207A File Offset: 0x0000027A
		public Assembly[] GetAssemblies()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000E46 RID: 3654 RVA: 0x0000207A File Offset: 0x0000027A
		public object GetData(string name)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000E47 RID: 3655 RVA: 0x0001F0E8 File Offset: 0x0001D2E8
		public override object InitializeLifetimeService()
		{
		}

		// Token: 0x06000E48 RID: 3656 RVA: 0x0000207A File Offset: 0x0000027A
		internal Assembly LoadAssembly(string assemblyRef, Evidence securityEvidence, bool refOnly, StackCrawlMark stackMark)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000E49 RID: 3657 RVA: 0x0001F0F8 File Offset: 0x0001D2F8
		internal Assembly LoadSatellite(AssemblyName assemblyRef, bool throwOnError, StackCrawlMark stackMark)
		{
			/*
An exception occurred when decompiling this method (06000E49)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Reflection.Assembly System.AppDomain::LoadSatellite(System.Reflection.AssemblyName,System.Boolean,System.Threading.StackCrawlMark)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_09, callgetter:string(AssemblyName::get_FullName, ldloc:AssemblyName(assemblyRef)))
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

		// Token: 0x06000E4A RID: 3658 RVA: 0x0001F110 File Offset: 0x0001D310
		public Assembly Load(string assemblyString)
		{
			Assembly assembly;
			return assembly;
		}

		// Token: 0x06000E4B RID: 3659 RVA: 0x0001F120 File Offset: 0x0001D320
		internal Assembly Load(string assemblyString, Evidence assemblySecurity, bool refonly, StackCrawlMark stackMark)
		{
			/*
An exception occurred when decompiling this method (06000E4B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Reflection.Assembly System.AppDomain::Load(System.String,System.Security.Policy.Evidence,System.Boolean,System.Threading.StackCrawlMark)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	brtrue(IL_0000, logicnot:bool(ldfld:int32[exp:bool](string::_stringLength, ldloc:string(assemblyString))))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
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

		// Token: 0x06000E4C RID: 3660 RVA: 0x0001F138 File Offset: 0x0001D338
		private static AppDomain InternalSetDomainByID(int domain_id)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000E4D RID: 3661 RVA: 0x0001F14C File Offset: 0x0001D34C
		private static AppDomain InternalSetDomain(AppDomain context)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000E4E RID: 3662 RVA: 0x0001F160 File Offset: 0x0001D360
		internal static void InternalPushDomainRefByID(int domain_id)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000E4F RID: 3663 RVA: 0x0001F174 File Offset: 0x0001D374
		internal static void InternalPopDomainRef()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000E50 RID: 3664 RVA: 0x0001F188 File Offset: 0x0001D388
		internal static Context InternalSetContext(Context context)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000E51 RID: 3665 RVA: 0x0000207A File Offset: 0x0000027A
		internal static Context InternalGetContext()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000E52 RID: 3666 RVA: 0x0000207A File Offset: 0x0000027A
		internal static Context InternalGetDefaultContext()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000E53 RID: 3667 RVA: 0x0001F19C File Offset: 0x0001D39C
		internal static string InternalGetProcessGuid(string newguid)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000E54 RID: 3668 RVA: 0x0001F1B0 File Offset: 0x0001D3B0
		internal static object InvokeInDomainByID(int domain_id, MethodInfo method, object obj, object[] args)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000E55 RID: 3669 RVA: 0x0001F220 File Offset: 0x0001D420
		internal static string GetProcessGuid()
		{
			string text = Guid.NewGuid().ToString();
			throw new NotSupportedException();
		}

		// Token: 0x06000E56 RID: 3670 RVA: 0x0000207A File Offset: 0x0000027A
		private static bool InternalIsFinalizingForUnload(int domain_id)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000E57 RID: 3671 RVA: 0x0001F240 File Offset: 0x0001D440
		public bool IsFinalizingForUnload()
		{
			/*
An exception occurred when decompiling this method (06000E57)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.AppDomain::IsFinalizingForUnload()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_1_07, call:int32(Thread::GetDomainID))
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

		// Token: 0x06000E58 RID: 3672 RVA: 0x0001F254 File Offset: 0x0001D454
		private int getDomainID()
		{
			return Thread.GetDomainID();
		}

		// Token: 0x06000E59 RID: 3673 RVA: 0x0000207A File Offset: 0x0000027A
		public override string ToString()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000E5A RID: 3674 RVA: 0x0001F268 File Offset: 0x0001D468
		private void DoAssemblyLoad(Assembly assembly)
		{
			AssemblyLoadEventHandler assemblyLoad = this.AssemblyLoad;
			if (assemblyLoad != null)
			{
				IntPtr invoke_impl = assemblyLoad.invoke_impl;
				IntPtr method_code = assemblyLoad.method_code;
				IntPtr method = assemblyLoad.method;
				return;
			}
		}

		// Token: 0x06000E5B RID: 3675 RVA: 0x0001F298 File Offset: 0x0001D498
		private Assembly DoAssemblyResolve(string name, Assembly requestingAssembly, bool refonly)
		{
			if (!refonly)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000E5C RID: 3676 RVA: 0x0001F2C0 File Offset: 0x0001D4C0
		internal Assembly DoTypeResolve(string name)
		{
			if (this.TypeResolve != null)
			{
			}
			long num = 0L;
			IntPtr invoke_impl = this.TypeResolve.invoke_impl;
			if (num != 0L)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000E5D RID: 3677 RVA: 0x0001F300 File Offset: 0x0001D500
		internal Assembly DoResourceResolve(string name, Assembly requesting)
		{
			ResolveEventHandler resourceResolve = this.ResourceResolve;
			if (resourceResolve != null)
			{
				IntPtr invoke_impl = resourceResolve.invoke_impl;
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000E5E RID: 3678 RVA: 0x0001F328 File Offset: 0x0001D528
		private void DoDomainUnload()
		{
			EventHandler domainUnload = this.DomainUnload;
			if (domainUnload != null)
			{
				IntPtr invoke_impl = domainUnload.invoke_impl;
				IntPtr method_code = domainUnload.method_code;
				IntPtr method = domainUnload.method;
				return;
			}
		}

		// Token: 0x06000E5F RID: 3679 RVA: 0x0001F358 File Offset: 0x0001D558
		internal byte[] GetMarshalledDomainObjRef()
		{
			/*
An exception occurred when decompiling this method (06000E5F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte[] System.AppDomain::GetMarshalledDomainObjRef()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:MemoryStream(var_2_06, call:MemoryStream(CADSerializer::SerializeObject, ldloc:ObjRef[exp:object](var_1)))
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

		// Token: 0x06000E60 RID: 3680 RVA: 0x0001F36C File Offset: 0x0001D56C
		internal void ProcessMessageInDomain(byte[] arrRequest, CADMethodCallMessage cadMsg, [Out] byte[] arrResponse, [Out] CADMethodReturnMessage cadMrm)
		{
			if (arrRequest != null)
			{
				return;
			}
			IMessage message;
			MemoryStream memoryStream;
			if (CADMethodReturnMessage.Create(message) == null)
			{
				memoryStream = CADSerializer.SerializeMessage(message);
			}
			arrResponse.m_value = memoryStream;
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000E61 RID: 3681 RVA: 0x0001F394 File Offset: 0x0001D594
		// (remove) Token: 0x06000E62 RID: 3682 RVA: 0x0001F3B8 File Offset: 0x0001D5B8
		public event EventHandler DomainUnload
		{
			[CompilerGenerated]
			add
			{
				if (Delegate.Combine(this.DomainUnload, value) != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (Delegate.Remove(this.DomainUnload, value) != null)
				{
				}
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000E63 RID: 3683 RVA: 0x0001F3DC File Offset: 0x0001D5DC
		// (remove) Token: 0x06000E64 RID: 3684 RVA: 0x0001F400 File Offset: 0x0001D600
		public event UnhandledExceptionEventHandler UnhandledException
		{
			[CompilerGenerated]
			add
			{
				if (Delegate.Combine(this.UnhandledException, value) != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (Delegate.Remove(this.UnhandledException, value) != null)
				{
				}
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000E65 RID: 3685 RVA: 0x0001F424 File Offset: 0x0001D624
		// (remove) Token: 0x06000E66 RID: 3686 RVA: 0x0001F44C File Offset: 0x0001D64C
		public event EventHandler<FirstChanceExceptionEventArgs> FirstChanceException
		{
			[CompilerGenerated]
			add
			{
				Delegate @delegate = Delegate.Combine(this.FirstChanceException, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = Delegate.Remove(this.FirstChanceException, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
		}

		// Token: 0x040005E1 RID: 1505
		private IntPtr _mono_app_domain;

		// Token: 0x040005E2 RID: 1506
		private static string _process_guid;

		// Token: 0x040005E3 RID: 1507
		[ThreadStatic]
		private static Dictionary<string, object> type_resolve_in_progress;

		// Token: 0x040005E4 RID: 1508
		[ThreadStatic]
		private static Dictionary<string, object> assembly_resolve_in_progress;

		// Token: 0x040005E5 RID: 1509
		[ThreadStatic]
		private static Dictionary<string, object> assembly_resolve_in_progress_refonly;

		// Token: 0x040005E6 RID: 1510
		private object _evidence;

		// Token: 0x040005E7 RID: 1511
		private object _granted;

		// Token: 0x040005E8 RID: 1512
		private int _principalPolicy;

		// Token: 0x040005E9 RID: 1513
		[CompilerGenerated]
		private AssemblyLoadEventHandler AssemblyLoad;

		// Token: 0x040005EA RID: 1514
		[CompilerGenerated]
		private ResolveEventHandler AssemblyResolve;

		// Token: 0x040005EB RID: 1515
		[CompilerGenerated]
		private EventHandler DomainUnload;

		// Token: 0x040005EC RID: 1516
		[CompilerGenerated]
		private EventHandler ProcessExit;

		// Token: 0x040005ED RID: 1517
		[CompilerGenerated]
		private ResolveEventHandler ResourceResolve;

		// Token: 0x040005EE RID: 1518
		[CompilerGenerated]
		private ResolveEventHandler TypeResolve;

		// Token: 0x040005EF RID: 1519
		[CompilerGenerated]
		private UnhandledExceptionEventHandler UnhandledException;

		// Token: 0x040005F0 RID: 1520
		[CompilerGenerated]
		private EventHandler<FirstChanceExceptionEventArgs> FirstChanceException;

		// Token: 0x040005F1 RID: 1521
		private object _domain_manager;

		// Token: 0x040005F2 RID: 1522
		[CompilerGenerated]
		private ResolveEventHandler ReflectionOnlyAssemblyResolve;

		// Token: 0x040005F3 RID: 1523
		private object _activation;

		// Token: 0x040005F4 RID: 1524
		private object _applicationIdentity;

		// Token: 0x040005F5 RID: 1525
		private List<string> compatibility_switch;
	}
}
