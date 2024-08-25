using System;
using System.Collections;

namespace System.Net
{
	// Token: 0x02000188 RID: 392
	public class CredentialCache : ICredentials, ICredentialsByHost, IEnumerable
	{
		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06000A1D RID: 2589 RVA: 0x000223F0 File Offset: 0x000205F0
		internal bool IsDefaultInCache
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000A1D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Net.CredentialCache::get_IsDefaultInCache()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(CredentialCache::m_NumbDefaultCredInCache, ldloc:CredentialCache(this)))
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

		// Token: 0x06000A1E RID: 2590 RVA: 0x00022404 File Offset: 0x00020604
		public CredentialCache()
		{
		}

		// Token: 0x06000A1F RID: 2591 RVA: 0x00022418 File Offset: 0x00020618
		public void Add(global::System.Uri uriPrefix, string authType, NetworkCredential cred)
		{
			if (!true)
			{
			}
			if (authType != null)
			{
				if (cred != null)
				{
				}
				int version = this.m_version;
				this.m_version = version;
				Hashtable hashtable = this.cache;
				if (cred != null)
				{
					int numbDefaultCredInCache = this.m_NumbDefaultCredInCache;
					this.m_NumbDefaultCredInCache = numbDefaultCredInCache;
				}
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000A20 RID: 2592 RVA: 0x00022460 File Offset: 0x00020660
		public void Add(string host, int port, string authenticationType, NetworkCredential credential)
		{
			if (host == null)
			{
				return;
			}
			if (authenticationType == null)
			{
				return;
			}
			if (host._stringLength != 0)
			{
				if (credential != null)
				{
				}
				int version = this.m_version;
				this.m_version = version;
				Hashtable hashtable = this.cacheForHosts;
				if (credential != null)
				{
					int numbDefaultCredInCache = this.m_NumbDefaultCredInCache;
					this.m_NumbDefaultCredInCache = numbDefaultCredInCache;
				}
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000A21 RID: 2593 RVA: 0x000224BC File Offset: 0x000206BC
		public void Remove(global::System.Uri uriPrefix, string authType)
		{
			if (!true)
			{
			}
			if (authType != null)
			{
				int version = this.m_version;
				this.m_version = version;
				if (this.cache != null)
				{
					int numbDefaultCredInCache = this.m_NumbDefaultCredInCache;
					this.m_NumbDefaultCredInCache = numbDefaultCredInCache;
				}
				Hashtable hashtable = this.cache;
				return;
			}
		}

		// Token: 0x06000A22 RID: 2594 RVA: 0x000224FC File Offset: 0x000206FC
		public void Remove(string host, int port, string authenticationType)
		{
			if (authenticationType != null && host != null)
			{
				int version = this.m_version;
				this.m_version = version;
				if (this.cacheForHosts != null)
				{
					int numbDefaultCredInCache = this.m_NumbDefaultCredInCache;
					this.m_NumbDefaultCredInCache = numbDefaultCredInCache;
				}
				Hashtable hashtable = this.cacheForHosts;
				return;
			}
		}

		// Token: 0x06000A23 RID: 2595 RVA: 0x0002253C File Offset: 0x0002073C
		public NetworkCredential GetCredential(global::System.Uri uriPrefix, string authType)
		{
			do
			{
				if (!true)
				{
				}
			}
			while (authType == null);
			Hashtable hashtable = this.cache;
			if (hashtable != null)
			{
			}
			int count = hashtable._count;
			if (hashtable != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000A24 RID: 2596 RVA: 0x00022574 File Offset: 0x00020774
		public NetworkCredential GetCredential(string host, int port, string authenticationType)
		{
			if (host == null)
			{
				return "host";
			}
			if (authenticationType != null && host._stringLength != 0)
			{
				Hashtable hashtable = this.cacheForHosts;
				if (hashtable != null)
				{
				}
				while (hashtable == null)
				{
				}
				throw new InvalidCastException();
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000A25 RID: 2597 RVA: 0x000225B8 File Offset: 0x000207B8
		public IEnumerator GetEnumerator()
		{
			/*
An exception occurred when decompiling this method (06000A25)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.IEnumerator System.Net.CredentialCache::GetEnumerator()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Hashtable(var_0_06, ldfld:Hashtable(CredentialCache::cache, ldloc:CredentialCache(this)))
	stloc:Hashtable(var_1_0D, ldfld:Hashtable(CredentialCache::cacheForHosts, ldloc:CredentialCache(this)))
	stloc:int32(var_2_14, ldfld:int32(CredentialCache::m_version, ldloc:CredentialCache(this)))
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

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06000A26 RID: 2598 RVA: 0x000225DC File Offset: 0x000207DC
		public static ICredentials DefaultCredentials
		{
			get
			{
				if (!true)
				{
				}
				return 1;
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06000A27 RID: 2599 RVA: 0x000225F0 File Offset: 0x000207F0
		public static NetworkCredential DefaultNetworkCredentials
		{
			get
			{
				if (!true)
				{
				}
				return 1;
			}
		}

		// Token: 0x040007B6 RID: 1974
		private Hashtable cache;

		// Token: 0x040007B7 RID: 1975
		private Hashtable cacheForHosts;

		// Token: 0x040007B8 RID: 1976
		internal int m_version;

		// Token: 0x040007B9 RID: 1977
		private int m_NumbDefaultCredInCache;

		// Token: 0x02000189 RID: 393
		private class CredentialEnumerator : IEnumerator
		{
			// Token: 0x06000A28 RID: 2600 RVA: 0x00022604 File Offset: 0x00020804
			internal CredentialEnumerator(CredentialCache cache, Hashtable table, Hashtable hostTable, int version)
			{
				int num = 1;
				this.m_index = num;
				base..ctor();
				this.m_cache = cache;
				ICredentials[] array = this.m_array;
			}

			// Token: 0x1700020F RID: 527
			// (get) Token: 0x06000A29 RID: 2601 RVA: 0x00022640 File Offset: 0x00020840
			object IEnumerator.Current
			{
				get
				{
					ICredentials[] array = this.m_array;
					CredentialCache cache = this.m_cache;
					int version = this.m_version;
					int version2 = cache.m_version;
					return "Enumeration has either not started or has already finished.";
				}
			}

			// Token: 0x06000A2A RID: 2602 RVA: 0x0002267C File Offset: 0x0002087C
			bool IEnumerator.MoveNext()
			{
				/*
An exception occurred when decompiling this method (06000A2A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Net.CredentialCache/CredentialEnumerator::System.Collections.IEnumerator.MoveNext()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:CredentialCache(var_0_06, ldfld:CredentialCache(CredentialEnumerator::m_cache, ldloc:CredentialEnumerator(this)))
	stloc:int32(var_1_0D, ldfld:int32(CredentialEnumerator::m_version, ldloc:CredentialEnumerator(this)))
	stloc:int32(var_2_14, ldfld:int32(CredentialCache::m_version, ldloc:CredentialCache(var_0_06)))
	stloc:int32(var_3_1B, ldfld:int32(CredentialEnumerator::m_index, ldloc:CredentialEnumerator(this)))
	stloc:class System.Net.ICredentials[](var_4_22, ldfld:class System.Net.ICredentials[](CredentialEnumerator::m_array, ldloc:CredentialEnumerator(this)))
	stloc:string(var_5_2E, call:string(SR::GetString, ldstr:string("Collection was modified; enumeration operation may not execute.")))
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

			// Token: 0x06000A2B RID: 2603 RVA: 0x000226B8 File Offset: 0x000208B8
			void IEnumerator.Reset()
			{
			}

			// Token: 0x040007BA RID: 1978
			private CredentialCache m_cache;

			// Token: 0x040007BB RID: 1979
			private ICredentials[] m_array;

			// Token: 0x040007BC RID: 1980
			private int m_index;

			// Token: 0x040007BD RID: 1981
			private int m_version;
		}
	}
}
