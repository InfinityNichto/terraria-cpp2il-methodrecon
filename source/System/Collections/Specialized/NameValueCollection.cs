using System;
using System.Runtime.Serialization;
using Cpp2IlInjected;

namespace System.Collections.Specialized
{
	// Token: 0x0200041D RID: 1053
	[Serializable]
	public class NameValueCollection : NameObjectCollectionBase
	{
		// Token: 0x06001C4C RID: 7244 RVA: 0x0004D668 File Offset: 0x0004B868
		public NameValueCollection()
		{
			if (!true)
			{
			}
			base..ctor();
		}

		// Token: 0x06001C4D RID: 7245 RVA: 0x0004D680 File Offset: 0x0004B880
		public NameValueCollection(int capacity)
		{
			if (!true)
			{
			}
			base..ctor(capacity);
		}

		// Token: 0x06001C4E RID: 7246 RVA: 0x0004D698 File Offset: 0x0004B898
		public NameValueCollection(int capacity, IEqualityComparer equalityComparer)
		{
			if (!true)
			{
			}
			base..ctor(equalityComparer);
			base.Reset(capacity);
		}

		// Token: 0x06001C4F RID: 7247 RVA: 0x0004D6B8 File Offset: 0x0004B8B8
		protected NameValueCollection(SerializationInfo info, StreamingContext context)
		{
			if (!true)
			{
			}
			base..ctor();
			this._serializationInfo = info;
		}

		// Token: 0x06001C50 RID: 7248 RVA: 0x0004D6D8 File Offset: 0x0004B8D8
		protected void InvalidateCachedArrays()
		{
		}

		// Token: 0x06001C51 RID: 7249 RVA: 0x0004D6E8 File Offset: 0x0004B8E8
		private static string GetAsOneString(ArrayList list)
		{
			throw new InvalidCastException();
		}

		// Token: 0x06001C52 RID: 7250 RVA: 0x0004D714 File Offset: 0x0004B914
		private static string[] GetAsStringArray(ArrayList list)
		{
		}

		// Token: 0x06001C53 RID: 7251 RVA: 0x0004D724 File Offset: 0x0004B924
		public void Add(NameValueCollection c)
		{
			while (c == null)
			{
			}
			if (c != null)
			{
				ArrayList entriesArray = c._entriesArray;
				return;
			}
		}

		// Token: 0x06001C54 RID: 7252 RVA: 0x0004D744 File Offset: 0x0004B944
		public virtual void Clear()
		{
			while (this._readOnly)
			{
			}
			base.BaseClear();
		}

		// Token: 0x06001C55 RID: 7253 RVA: 0x00002050 File Offset: 0x00000250
		public bool HasKeys()
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001C56 RID: 7254 RVA: 0x0004D760 File Offset: 0x0004B960
		internal virtual bool InternalHasKeys()
		{
			/*
An exception occurred when decompiling this method (06001C56)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Collections.Specialized.NameValueCollection::InternalHasKeys()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Hashtable(var_0_06, ldfld:Hashtable(NameObjectCollectionBase::_entriesTable, ldloc:NameValueCollection[exp:NameObjectCollectionBase](this)))
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

		// Token: 0x06001C57 RID: 7255 RVA: 0x0004D774 File Offset: 0x0004B974
		public virtual void Add(string name, string value)
		{
			if (this._readOnly)
			{
				throw new InvalidCastException();
			}
			NameObjectCollectionBase.NameObjectEntry nameObjectEntry;
			if (nameObjectEntry.Value == null)
			{
				if (value != null)
				{
				}
				return;
			}
			if (value != null)
			{
				return;
			}
		}

		// Token: 0x06001C58 RID: 7256 RVA: 0x0004D7A4 File Offset: 0x0004B9A4
		public virtual string Get(string name)
		{
			NameObjectCollectionBase.NameObjectEntry nameObjectEntry;
			if (nameObjectEntry == null || nameObjectEntry.Value != null)
			{
			}
			string text;
			return text;
		}

		// Token: 0x06001C59 RID: 7257 RVA: 0x0004D7C4 File Offset: 0x0004B9C4
		public virtual string[] GetValues(string name)
		{
			NameObjectCollectionBase.NameObjectEntry nameObjectEntry = base.FindEntry(name);
			if (nameObjectEntry == null || nameObjectEntry.Value != null)
			{
			}
			string[] array;
			return array;
		}

		// Token: 0x06001C5A RID: 7258 RVA: 0x0004D7EC File Offset: 0x0004B9EC
		public virtual void Set(string name, string value)
		{
			while (this._readOnly)
			{
			}
		}

		// Token: 0x06001C5B RID: 7259 RVA: 0x0004D804 File Offset: 0x0004BA04
		public virtual void Remove(string name)
		{
			base.BaseRemove(name);
		}

		// Token: 0x17000651 RID: 1617
		public string this[string name]
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x06001C5E RID: 7262 RVA: 0x0004D828 File Offset: 0x0004BA28
		public virtual string Get(int index)
		{
			if (base.BaseGet(index) != null)
			{
			}
			string text;
			return text;
		}

		// Token: 0x06001C5F RID: 7263 RVA: 0x0004D848 File Offset: 0x0004BA48
		public virtual string[] GetValues(int index)
		{
			if (base.BaseGet(index) != null)
			{
			}
			string[] array;
			return array;
		}

		// Token: 0x06001C60 RID: 7264 RVA: 0x0004D868 File Offset: 0x0004BA68
		public virtual string GetKey(int index)
		{
			return base.BaseGetKey(index);
		}

		// Token: 0x17000652 RID: 1618
		public string this[int index]
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x06001C62 RID: 7266 RVA: 0x0004D87C File Offset: 0x0004BA7C
		public virtual string[] AllKeys
		{
			get
			{
				string[] array;
				if (this._allKeys == null)
				{
					array = base.BaseGetAllKeys();
					this._allKeys = array;
				}
				return array;
			}
		}

		// Token: 0x06001C63 RID: 7267 RVA: 0x0004D8A0 File Offset: 0x0004BAA0
		internal NameValueCollection(DBNull dummy)
		{
			if (!true)
			{
			}
			base..ctor();
		}

		// Token: 0x040013A9 RID: 5033
		private string[] _all;

		// Token: 0x040013AA RID: 5034
		private string[] _allKeys;
	}
}
