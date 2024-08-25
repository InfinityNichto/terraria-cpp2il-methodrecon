using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace System.ComponentModel
{
	// Token: 0x02000395 RID: 917
	public sealed class LicenseManager
	{
		// Token: 0x060017D3 RID: 6099 RVA: 0x00043988 File Offset: 0x00041B88
		private LicenseManager()
		{
		}

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x060017D4 RID: 6100 RVA: 0x0004399C File Offset: 0x00041B9C
		// (set) Token: 0x060017D5 RID: 6101 RVA: 0x000439C8 File Offset: 0x00041BC8
		public static LicenseContext CurrentContext
		{
			get
			{
				if (!true)
				{
				}
				if (!true)
				{
				}
				if (!true)
				{
				}
				if (!false)
				{
				}
				throw new OutOfMemoryException();
			}
			set
			{
				if (!true)
				{
				}
				if (!false)
				{
					return;
				}
				throw new OutOfMemoryException();
			}
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x060017D6 RID: 6102 RVA: 0x000439F8 File Offset: 0x00041BF8
		public static LicenseUsageMode UsageMode
		{
			get
			{
				if (!true)
				{
				}
				if (!true)
				{
					return;
				}
			}
		}

		// Token: 0x060017D7 RID: 6103 RVA: 0x00043A0C File Offset: 0x00041C0C
		private static void CacheProvider(Type type, LicenseProvider provider)
		{
		}

		// Token: 0x060017D8 RID: 6104 RVA: 0x00043A2C File Offset: 0x00041C2C
		public static object CreateWithContext(Type type, LicenseContext creationContext)
		{
			if (!true)
			{
			}
			object obj;
			return obj;
		}

		// Token: 0x060017D9 RID: 6105 RVA: 0x00043A40 File Offset: 0x00041C40
		public static object CreateWithContext(Type type, LicenseContext creationContext, object[] args)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			LicenseContext currentContext = LicenseManager.CurrentContext;
			if (num == 0)
			{
			}
			long num2 = 0L;
			LicenseManager.CurrentContext = currentContext;
			if (num2 != 0L)
			{
				throw new OutOfMemoryException();
			}
			if (!false)
			{
				object obj;
				return obj;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060017DA RID: 6106 RVA: 0x00043A98 File Offset: 0x00041C98
		private static bool GetCachedNoLicenseProvider(Type type)
		{
			if (!true)
			{
			}
			if (!true)
			{
				return;
			}
		}

		// Token: 0x060017DB RID: 6107 RVA: 0x00043AAC File Offset: 0x00041CAC
		private static LicenseProvider GetCachedProvider(Type type)
		{
			if (!true)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x060017DC RID: 6108 RVA: 0x00043AC4 File Offset: 0x00041CC4
		private static LicenseProvider GetCachedProviderInstance(Type providerType)
		{
			if (!true)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x060017DD RID: 6109 RVA: 0x00043ADC File Offset: 0x00041CDC
		public static bool IsLicensed(Type type)
		{
			if (!true)
			{
			}
			bool flag;
			if (flag)
			{
				return flag;
			}
			return flag;
		}

		// Token: 0x060017DE RID: 6110 RVA: 0x00043AF4 File Offset: 0x00041CF4
		public static bool IsValid(Type type)
		{
			if (!true)
			{
			}
			bool flag;
			if (flag)
			{
				return flag;
			}
			return flag;
		}

		// Token: 0x060017DF RID: 6111 RVA: 0x00043B0C File Offset: 0x00041D0C
		public static bool IsValid(Type type, object instance, [Out] License license)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x060017E0 RID: 6112 RVA: 0x00043B20 File Offset: 0x00041D20
		public static void LockContext(object contextUser)
		{
			if (!true)
			{
			}
			if (!false)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060017E1 RID: 6113 RVA: 0x00043B50 File Offset: 0x00041D50
		public static void UnlockContext(object contextUser)
		{
			if (!true)
			{
			}
			if (!false)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060017E2 RID: 6114 RVA: 0x00043B80 File Offset: 0x00041D80
		private static bool ValidateInternal(Type type, object instance, bool allowExceptions, [Out] License license)
		{
			if (!true)
			{
			}
			LicenseContext currentContext = LicenseManager.CurrentContext;
			bool flag;
			return flag;
		}

		// Token: 0x060017E3 RID: 6115 RVA: 0x00043B98 File Offset: 0x00041D98
		private static bool ValidateInternalRecursive(LicenseContext context, Type type, object instance, bool allowExceptions, [Out] License license, [Out] string licenseKey)
		{
			if (!true)
			{
			}
			LicenseProvider licenseProvider;
			bool flag;
			if (licenseProvider != null)
			{
				allowExceptions.m_value = licenseProvider != null;
				if (licenseProvider == null)
				{
					return flag;
				}
				if (type != null)
				{
					goto IL_003B;
				}
			}
			if (type == null)
			{
				return flag;
			}
			IL_003B:
			throw new InvalidCastException();
		}

		// Token: 0x060017E4 RID: 6116 RVA: 0x00043BE8 File Offset: 0x00041DE8
		public static void Validate(Type type)
		{
			if (!true)
			{
			}
			bool flag;
			if (flag)
			{
			}
		}

		// Token: 0x060017E5 RID: 6117 RVA: 0x00043BFC File Offset: 0x00041DFC
		public static License Validate(Type type, object instance)
		{
			/*
An exception occurred when decompiling this method (060017E5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.ComponentModel.License System.ComponentModel.LicenseManager::Validate(System.Type,System.Object)

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

		// Token: 0x060017E6 RID: 6118 RVA: 0x00043C0C File Offset: 0x00041E0C
		// Note: this type is marked as 'beforefieldinit'.
		static LicenseManager()
		{
		}

		// Token: 0x0400122F RID: 4655
		private static readonly object s_selfLock;

		// Token: 0x04001230 RID: 4656
		private static LicenseContext s_context;

		// Token: 0x04001231 RID: 4657
		private static object s_contextLockHolder;

		// Token: 0x04001232 RID: 4658
		private static Hashtable s_providers;

		// Token: 0x04001233 RID: 4659
		private static Hashtable s_providerInstances;

		// Token: 0x04001234 RID: 4660
		private static readonly object s_internalSyncObject;
	}
}
