using System;
using System.Collections;
using System.Runtime.Serialization;
using Cpp2IlInjected;

namespace System.Net
{
	// Token: 0x02000212 RID: 530
	[Serializable]
	public class CookieCollection : ICollection, IEnumerable
	{
		// Token: 0x06000D13 RID: 3347 RVA: 0x00029BFC File Offset: 0x00027DFC
		public CookieCollection()
		{
			if (!true)
			{
			}
			this.m_TimeStamp = 1;
			base..ctor();
			this.m_IsReadOnly = true;
		}

		// Token: 0x06000D14 RID: 3348 RVA: 0x00029C20 File Offset: 0x00027E20
		internal CookieCollection(bool IsReadOnly)
		{
			this.m_TimeStamp = 1;
			base..ctor();
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000D15 RID: 3349 RVA: 0x00029C3C File Offset: 0x00027E3C
		public bool IsReadOnly
		{
			get
			{
				return this.m_IsReadOnly;
			}
		}

		// Token: 0x170002B8 RID: 696
		public Cookie this[int index]
		{
			get
			{
				ArrayList list = this.m_list;
				if (this.m_list != null)
				{
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x170002B9 RID: 697
		public Cookie this[string name]
		{
			get
			{
				ArrayList list = this.m_list;
				if (list != null)
				{
				}
				int num;
				while (num != 0)
				{
				}
				long num2 = 0L;
				if (list != null)
				{
				}
				if (num2 == 0L)
				{
					throw new InvalidCastException();
				}
				throw new OutOfMemoryException();
			}
		}

		// Token: 0x06000D18 RID: 3352 RVA: 0x00029CB4 File Offset: 0x00027EB4
		public void Add(Cookie cookie)
		{
			while (cookie == null)
			{
			}
			int version = this.m_version;
			this.m_version = version;
			int num = this.IndexOf(cookie);
			ArrayList list = this.m_list;
		}

		// Token: 0x06000D19 RID: 3353 RVA: 0x00029CE4 File Offset: 0x00027EE4
		public void Add(CookieCollection cookies)
		{
			if (cookies != null)
			{
				IEnumerator enumerator = cookies.GetEnumerator();
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06000D1A RID: 3354 RVA: 0x00029D24 File Offset: 0x00027F24
		public int Count
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000D1A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Net.CookieCollection::get_Count()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:ArrayList(var_0_06, ldfld:ArrayList(CookieCollection::m_list, ldloc:CookieCollection(this)))
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

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06000D1B RID: 3355 RVA: 0x00029D38 File Offset: 0x00027F38
		public bool IsSynchronized
		{
			get
			{
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000D1C RID: 3356 RVA: 0x00002050 File Offset: 0x00000250
		public object SyncRoot
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06000D1D RID: 3357 RVA: 0x00029D48 File Offset: 0x00027F48
		public void CopyTo(Array array, int index)
		{
			ArrayList list = this.m_list;
		}

		// Token: 0x06000D1E RID: 3358 RVA: 0x00029D5C File Offset: 0x00027F5C
		public void CopyTo(Cookie[] array, int index)
		{
			ArrayList list = this.m_list;
		}

		// Token: 0x06000D1F RID: 3359 RVA: 0x00029D70 File Offset: 0x00027F70
		internal DateTime TimeStamp(CookieCollection.Stamp how)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06000D20 RID: 3360 RVA: 0x00029D9C File Offset: 0x00027F9C
		internal bool IsOtherVersionSeen
		{
			get
			{
				return this.m_has_other_versions;
			}
		}

		// Token: 0x06000D21 RID: 3361 RVA: 0x00029DB0 File Offset: 0x00027FB0
		internal int InternalAdd(Cookie cookie, bool isStrict)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			ArrayList list = this.m_list;
			if (list != null)
			{
			}
			if (list != null)
			{
				ArrayList list2 = this.m_list;
			}
			CookieVariant cookieVariant = cookie.m_cookieVariant;
			ArrayList list3 = this.m_list;
			long num = 0L;
			int num2 = 7;
			if (list == null || cookieVariant != CookieVariant.Unknown)
			{
			}
			if (num == 0L)
			{
				if (num2 == 0)
				{
					ArrayList list4 = this.m_list;
					ArrayList list5 = this.m_list;
					int version = cookie.m_version;
					int num3 = 1;
					this.m_has_other_versions = num3 != 0;
				}
				throw new InvalidCastException();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000D22 RID: 3362 RVA: 0x00029E40 File Offset: 0x00028040
		internal int IndexOf(Cookie cookie)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			ArrayList list = this.m_list;
			if (list != null)
			{
			}
			return 43163648;
		}

		// Token: 0x06000D23 RID: 3363 RVA: 0x00029E9C File Offset: 0x0002809C
		internal void RemoveAt(int idx)
		{
			ArrayList list = this.m_list;
		}

		// Token: 0x06000D24 RID: 3364 RVA: 0x00029EB0 File Offset: 0x000280B0
		public IEnumerator GetEnumerator()
		{
			/*
An exception occurred when decompiling this method (06000D24)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.IEnumerator System.Net.CookieCollection::GetEnumerator()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:ArrayList(var_0_06, ldfld:ArrayList(CookieCollection::m_list, ldloc:CookieCollection(this)))
	stloc:int32(var_1_0D, ldfld:int32(CookieCollection::m_version, ldloc:CookieCollection(this)))
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

		// Token: 0x04000B34 RID: 2868
		internal int m_version;

		// Token: 0x04000B35 RID: 2869
		private ArrayList m_list;

		// Token: 0x04000B36 RID: 2870
		private DateTime m_TimeStamp;

		// Token: 0x04000B37 RID: 2871
		private bool m_has_other_versions;

		// Token: 0x04000B38 RID: 2872
		[OptionalField]
		private bool m_IsReadOnly;

		// Token: 0x02000213 RID: 531
		internal enum Stamp
		{
			// Token: 0x04000B3A RID: 2874
			Check,
			// Token: 0x04000B3B RID: 2875
			Set,
			// Token: 0x04000B3C RID: 2876
			SetToUnused,
			// Token: 0x04000B3D RID: 2877
			SetToMaxUsed
		}

		// Token: 0x02000214 RID: 532
		private class CookieCollectionEnumerator : IEnumerator
		{
			// Token: 0x06000D25 RID: 3365 RVA: 0x00029ECC File Offset: 0x000280CC
			internal CookieCollectionEnumerator(CookieCollection cookies)
			{
				this.m_cookies = cookies;
				ArrayList list = cookies.m_list;
				this.m_count = list;
			}

			// Token: 0x170002BE RID: 702
			// (get) Token: 0x06000D26 RID: 3366 RVA: 0x00029EF4 File Offset: 0x000280F4
			object IEnumerator.Current
			{
				get
				{
					int index = this.m_index;
					int count = this.m_count;
					CookieCollection cookies = this.m_cookies;
					int version = this.m_version;
					int version2 = cookies.m_version;
					Cookie cookie = cookies[index];
					return "Enumeration has either not started or has already finished.";
				}
			}

			// Token: 0x06000D27 RID: 3367 RVA: 0x00029F40 File Offset: 0x00028140
			bool IEnumerator.MoveNext()
			{
				/*
An exception occurred when decompiling this method (06000D27)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Net.CookieCollection/CookieCollectionEnumerator::System.Collections.IEnumerator.MoveNext()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:CookieCollection(var_0_06, ldfld:CookieCollection(CookieCollectionEnumerator::m_cookies, ldloc:CookieCollectionEnumerator(this)))
	stloc:int32(var_1_0D, ldfld:int32(CookieCollectionEnumerator::m_version, ldloc:CookieCollectionEnumerator(this)))
	stloc:int32(var_2_14, ldfld:int32(CookieCollection::m_version, ldloc:CookieCollection(var_0_06)))
	stloc:int32(var_3_1B, ldfld:int32(CookieCollectionEnumerator::m_count, ldloc:CookieCollectionEnumerator(this)))
	stloc:int32(var_4_22, ldfld:int32(CookieCollectionEnumerator::m_version, ldloc:CookieCollectionEnumerator(this)))
	stfld:int32(CookieCollectionEnumerator::m_index, ldloc:CookieCollectionEnumerator(this), ldloc:int32(var_4_22))
	stloc:string(var_5_36, call:string(SR::GetString, ldstr:string("Collection was modified; enumeration operation may not execute.")))
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

			// Token: 0x06000D28 RID: 3368 RVA: 0x00029F84 File Offset: 0x00028184
			void IEnumerator.Reset()
			{
			}

			// Token: 0x04000B3E RID: 2878
			private CookieCollection m_cookies;

			// Token: 0x04000B3F RID: 2879
			private int m_count;

			// Token: 0x04000B40 RID: 2880
			private int m_index;

			// Token: 0x04000B41 RID: 2881
			private int m_version;
		}
	}
}
