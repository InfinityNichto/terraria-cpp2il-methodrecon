using System;
using System.Threading;
using Cpp2IlInjected;

namespace System.Net
{
	// Token: 0x020001A0 RID: 416
	internal static class NclUtilities
	{
		// Token: 0x06000A76 RID: 2678 RVA: 0x00002050 File Offset: 0x00000250
		internal static bool IsThreadPoolLow()
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06000A77 RID: 2679 RVA: 0x000232CC File Offset: 0x000214CC
		internal static bool HasShutdownStarted
		{
			get
			{
				bool hasShutdownStarted = Environment.HasShutdownStarted;
				return true;
			}
		}

		// Token: 0x06000A78 RID: 2680 RVA: 0x000232F0 File Offset: 0x000214F0
		internal static bool IsCredentialFailure(SecurityStatus error)
		{
		}

		// Token: 0x06000A79 RID: 2681 RVA: 0x0002330C File Offset: 0x0002150C
		internal static bool IsClientFault(SecurityStatus error)
		{
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06000A7A RID: 2682 RVA: 0x00023328 File Offset: 0x00021528
		internal static ContextCallback ContextRelativeDemandCallback
		{
			get
			{
			}
		}

		// Token: 0x06000A7B RID: 2683 RVA: 0x00023338 File Offset: 0x00021538
		private static void DemandCallback(object state)
		{
		}

		// Token: 0x06000A7C RID: 2684 RVA: 0x00023348 File Offset: 0x00021548
		internal static bool GuessWhetherHostIsLoopback(string host)
		{
			string text;
			bool flag = text == "localhost";
			return true;
		}

		// Token: 0x06000A7D RID: 2685 RVA: 0x00023364 File Offset: 0x00021564
		internal static bool IsFatal(Exception exception)
		{
		}

		// Token: 0x06000A7E RID: 2686 RVA: 0x00023378 File Offset: 0x00021578
		internal static bool IsAddressLocal(IPAddress ipAddress)
		{
			/*
An exception occurred when decompiling this method (06000A7E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Net.NclUtilities::IsAddressLocal(System.Net.IPAddress)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class System.Net.IPAddress[](var_0_05, callgetter:class System.Net.IPAddress[](NclUtilities::get_LocalAddresses))
	stloc:uint16[](var_1_0C, ldfld:uint16[](IPAddress::_numbers, ldloc:class System.Net.IPAddress[][exp:IPAddress](var_0_05)))
	stloc:int64(var_3_10, ldc.i4:int64(0))
	stloc:bool(var_4_19, call:bool(IPAddress::Equals, ldloc:class System.Net.IPAddress[][exp:IPAddress](var_0_05), ldloc:IPAddress[exp:object](ipAddress), ldloc:int64[exp:bool](var_3_10)))
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

		// Token: 0x06000A7F RID: 2687 RVA: 0x000233A4 File Offset: 0x000215A4
		private static IPHostEntry GetLocalHost()
		{
			if (!true)
			{
			}
			return Dns.GetHostByName(Dns.GetHostName());
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06000A80 RID: 2688 RVA: 0x000233C0 File Offset: 0x000215C0
		internal static IPAddress[] LocalAddresses
		{
			get
			{
				object localAddressesLock = NclUtilities.LocalAddressesLock;
				IPHostEntry localHost = NclUtilities.GetLocalHost();
				if (localHost != null)
				{
					string hostName = localHost.hostName;
					if (hostName != null)
					{
						int num = 46;
						int num2 = hostName.IndexOf((char)num);
						string text = localHost.hostName.Substring(num2);
					}
					IPAddress[] addressList = localHost.addressList;
					if (addressList != null)
					{
						ushort[] numbers = addressList._numbers;
						ushort[] numbers2 = addressList._numbers;
					}
				}
				long num3 = 0L;
				int num4 = 13;
				if (num3 != 0L)
				{
					throw new OutOfMemoryException();
				}
				if (num4 == 0)
				{
				}
				long num5 = 0L;
				Monitor.Exit(localAddressesLock);
				if (num5 == 0L)
				{
					throw new ArrayTypeMismatchException();
				}
				throw new OutOfMemoryException();
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06000A81 RID: 2689 RVA: 0x00023480 File Offset: 0x00021680
		private static object LocalAddressesLock
		{
			get
			{
				object obj;
				return obj;
			}
		}

		// Token: 0x04000852 RID: 2130
		private static ContextCallback s_ContextRelativeDemandCallback;

		// Token: 0x04000853 RID: 2131
		private static IPAddress[] _LocalAddresses;

		// Token: 0x04000854 RID: 2132
		private static object _LocalAddressesLock;

		// Token: 0x04000855 RID: 2133
		private const int HostNameBufferLength = 256;

		// Token: 0x04000856 RID: 2134
		internal static string _LocalDomainName;
	}
}
