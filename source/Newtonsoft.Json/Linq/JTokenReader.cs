using System;
using Cpp2IlInjected;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000D3 RID: 211
	[Preserve]
	public class JTokenReader : JsonReader, IJsonLineInfo
	{
		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000817 RID: 2071 RVA: 0x000141A8 File Offset: 0x000123A8
		public JToken CurrentToken
		{
			get
			{
				return this._current;
			}
		}

		// Token: 0x06000818 RID: 2072 RVA: 0x000141BC File Offset: 0x000123BC
		public JTokenReader(JToken token)
		{
			ValidationUtils.ArgumentNotNull(token, "token");
			this._root = token;
		}

		// Token: 0x06000819 RID: 2073 RVA: 0x000141E4 File Offset: 0x000123E4
		internal JTokenReader(JToken token, string initialPath)
		{
			this._initialPath = initialPath;
		}

		// Token: 0x0600081A RID: 2074 RVA: 0x000141F8 File Offset: 0x000123F8
		public override bool Read()
		{
			if (this._currentState != JsonReader.State.Start)
			{
				JToken current = this._current;
				if (current != null)
				{
					return this.ReadOver(current);
				}
			}
			else
			{
				JToken root = this._root;
				this._current = root;
				this.SetToken(root);
			}
			JToken parent = this._parent;
			bool flag;
			return flag;
		}

		// Token: 0x0600081B RID: 2075 RVA: 0x00014244 File Offset: 0x00012444
		private bool ReadOver(JToken t)
		{
			JToken root = this._root;
			JToken next = t._next;
			if (next != null)
			{
				JContainer parent = t._parent;
				this._current = next;
				this.SetToken(next);
				return true;
			}
			JContainer parent2 = t._parent;
			if (parent2 != null)
			{
				return this.SetEnd(parent2);
			}
		}

		// Token: 0x0600081C RID: 2076 RVA: 0x00014290 File Offset: 0x00012490
		private bool ReadToEnd()
		{
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x0000212A File Offset: 0x0000032A
		private JsonToken? GetEndToken(JContainer c)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600081E RID: 2078 RVA: 0x000142A0 File Offset: 0x000124A0
		private bool ReadInto(JContainer c)
		{
			if (c != null)
			{
				this.SetToken(c);
				this._parent = c;
				this._current = c;
				return true;
			}
			return this.SetEnd(c);
		}

		// Token: 0x0600081F RID: 2079 RVA: 0x000142D0 File Offset: 0x000124D0
		private bool SetEnd(JContainer c)
		{
			this._parent = c;
			this._current = c;
			return true;
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x000142F4 File Offset: 0x000124F4
		private void SetToken(JToken token)
		{
		}

		// Token: 0x06000821 RID: 2081 RVA: 0x00014320 File Offset: 0x00012520
		private string SafeToString(object value)
		{
			if (value != null)
			{
				return;
			}
		}

		// Token: 0x06000822 RID: 2082 RVA: 0x00014334 File Offset: 0x00012534
		bool IJsonLineInfo.HasLineInfo()
		{
			/*
An exception occurred when decompiling this method (06000822)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Newtonsoft.Json.Linq.JTokenReader::Newtonsoft.Json.IJsonLineInfo.HasLineInfo()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0010:
	stloc:int64(var_0_16, ldfld:int64(int64::m_value, ldc.i4:int32[exp:int64&](0)))
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

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06000823 RID: 2083 RVA: 0x00014358 File Offset: 0x00012558
		int IJsonLineInfo.LineNumber
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000823)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Newtonsoft.Json.Linq.JTokenReader::Newtonsoft.Json.IJsonLineInfo.get_LineNumber()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0010:
	stloc:int64(var_0_16, ldfld:int64(int64::m_value, ldc.i4:int32[exp:int64&](0)))
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

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06000824 RID: 2084 RVA: 0x0001437C File Offset: 0x0001257C
		int IJsonLineInfo.LinePosition
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000824)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Newtonsoft.Json.Linq.JTokenReader::Newtonsoft.Json.IJsonLineInfo.get_LinePosition()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0010:
	stloc:int64(var_0_16, ldfld:int64(int64::m_value, ldc.i4:int32[exp:int64&](0)))
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

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06000825 RID: 2085 RVA: 0x000143A0 File Offset: 0x000125A0
		public override string Path
		{
			get
			{
				string path = base.Path;
				string path2;
				if (this._initialPath == null)
				{
					path2 = this._root.Path;
					this._initialPath = path2;
				}
				bool flag = string.IsNullOrEmpty(path2);
				bool flag2 = string.IsNullOrEmpty(path);
				return this._initialPath;
			}
		}

		// Token: 0x04000334 RID: 820
		private readonly JToken _root;

		// Token: 0x04000335 RID: 821
		private string _initialPath;

		// Token: 0x04000336 RID: 822
		private JToken _parent;

		// Token: 0x04000337 RID: 823
		private JToken _current;
	}
}
