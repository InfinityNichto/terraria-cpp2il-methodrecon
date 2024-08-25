using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Win32.SafeHandles;

namespace System.Net.Security
{
	// Token: 0x02000310 RID: 784
	internal static class NegotiateStreamPal
	{
		// Token: 0x06001475 RID: 5237 RVA: 0x00002050 File Offset: 0x00000250
		internal static string QueryContextClientSpecifiedSpn(SafeDeleteContext securityContext)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001476 RID: 5238 RVA: 0x0003E478 File Offset: 0x0003C678
		internal static string QueryContextAuthenticationPackage(SafeDeleteContext securityContext)
		{
			throw new InvalidCastException();
		}

		// Token: 0x06001477 RID: 5239 RVA: 0x0003E48C File Offset: 0x0003C68C
		private static byte[] GssWrap(Microsoft.Win32.SafeHandles.SafeGssContextHandle context, bool encrypt, byte[] buffer, int offset, int count)
		{
			global::Interop.NetSecurityNative.Status status;
			if (status == global::Interop.NetSecurityNative.Status.GSS_S_COMPLETE)
			{
				byte[] array;
				return array;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001478 RID: 5240 RVA: 0x0003E4AC File Offset: 0x0003C6AC
		private static int GssUnwrap(Microsoft.Win32.SafeHandles.SafeGssContextHandle context, byte[] buffer, int offset, int count)
		{
			global::Interop.NetSecurityNative.Status status;
			if (status == global::Interop.NetSecurityNative.Status.GSS_S_COMPLETE)
			{
				int num;
				return num;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001479 RID: 5241 RVA: 0x0003E4D0 File Offset: 0x0003C6D0
		private static bool GssInitSecurityContext(Microsoft.Win32.SafeHandles.SafeGssContextHandle context, Microsoft.Win32.SafeHandles.SafeGssCredHandle credential, bool isNtlm, Microsoft.Win32.SafeHandles.SafeGssNameHandle targetName, global::Interop.NetSecurityNative.GssFlags inFlags, byte[] buffer, [Out] byte[] outputBuffer, [Out] uint outFlags, [Out] int isNtlmUsed)
		{
			if (!true)
			{
			}
			if (inFlags != (global::Interop.NetSecurityNative.GssFlags)0U)
			{
			}
			byte[] array;
			buffer.m_value = array;
			throw new OutOfMemoryException();
		}

		// Token: 0x0600147A RID: 5242 RVA: 0x0003E4FC File Offset: 0x0003C6FC
		private static SecurityStatusPal EstablishSecurityContext(SafeFreeNegoCredentials credential, SafeDeleteContext context, string targetName, ContextFlagsPal inFlags, SecurityBuffer inputBuffer, SecurityBuffer outputBuffer, ContextFlagsPal outFlags)
		{
			if (inFlags != ContextFlagsPal.None)
			{
			}
			byte[] token = inputBuffer.token;
			inputBuffer.size = token;
			if (token == null)
			{
			}
			if (token != null)
			{
				bool flag = Convert.ToBoolean(0);
				int size = inputBuffer.size;
			}
			throw new InvalidCastException();
		}

		// Token: 0x0600147B RID: 5243 RVA: 0x0003E554 File Offset: 0x0003C754
		internal static SecurityStatusPal InitializeSecurityContext(SafeFreeCredentials credentialsHandle, SafeDeleteContext securityContext, string spn, ContextFlagsPal requestedContextFlags, SecurityBuffer[] inSecurityBufferArray, SecurityBuffer outSecurityBuffer, ContextFlagsPal contextFlags)
		{
			if (requestedContextFlags != ContextFlagsPal.None)
			{
			}
			if (requestedContextFlags != ContextFlagsPal.None)
			{
			}
			SecurityStatusPal securityStatusPal;
			return securityStatusPal;
		}

		// Token: 0x0600147C RID: 5244 RVA: 0x00002050 File Offset: 0x00000250
		internal static SecurityStatusPal AcceptSecurityContext(SafeFreeCredentials credentialsHandle, SafeDeleteContext securityContext, ContextFlagsPal requestedContextFlags, SecurityBuffer[] inSecurityBufferArray, SecurityBuffer outSecurityBuffer, ContextFlagsPal contextFlags)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600147D RID: 5245 RVA: 0x0003E57C File Offset: 0x0003C77C
		internal static global::System.ComponentModel.Win32Exception CreateExceptionFromError(SecurityStatusPal statusCode)
		{
			/*
An exception occurred when decompiling this method (0600147D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.ComponentModel.Win32Exception System.Net.Security.NegotiateStreamPal::CreateExceptionFromError(System.Net.SecurityStatusPal)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, logicnot:bool(ldloc:SecurityStatusPal[exp:bool](statusCode)))
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

		// Token: 0x0600147E RID: 5246 RVA: 0x0003E58C File Offset: 0x0003C78C
		internal static int QueryMaxTokenSize(string package)
		{
		}

		// Token: 0x0600147F RID: 5247 RVA: 0x0003E59C File Offset: 0x0003C79C
		internal static SafeFreeCredentials AcquireDefaultCredential(string package, bool isServer)
		{
			SafeFreeCredentials safeFreeCredentials;
			return safeFreeCredentials;
		}

		// Token: 0x06001480 RID: 5248 RVA: 0x0003E5AC File Offset: 0x0003C7AC
		internal static SafeFreeCredentials AcquireCredentialsHandle(string package, bool isServer, NetworkCredential credential)
		{
			string text;
			bool flag = string.IsNullOrWhiteSpace(text);
			int num = 1;
			string text2;
			bool flag2 = string.IsNullOrWhiteSpace(text2);
			if (num != 0)
			{
			}
			return "Server implementation is not supported";
		}

		// Token: 0x06001481 RID: 5249 RVA: 0x00002050 File Offset: 0x00000250
		internal static SecurityStatusPal CompleteAuthToken(SafeDeleteContext securityContext, SecurityBuffer[] inSecurityBufferArray)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001482 RID: 5250 RVA: 0x0003E5D8 File Offset: 0x0003C7D8
		internal static int VerifySignature(SafeDeleteContext securityContext, byte[] buffer, int offset, int count)
		{
			if (securityContext != null)
			{
				int state = securityContext._state;
			}
			if (securityContext != null)
			{
				int state2 = securityContext._state;
			}
			int num;
			return num;
		}

		// Token: 0x06001483 RID: 5251 RVA: 0x0003E620 File Offset: 0x0003C820
		internal static int MakeSignature(SafeDeleteContext securityContext, byte[] buffer, int offset, int count, byte[] output)
		{
			throw new InvalidCastException();
		}
	}
}
