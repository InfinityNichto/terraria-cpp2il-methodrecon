using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000D2 RID: 210
	[Preserve]
	public class JArray : JContainer, IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable
	{
		// Token: 0x17000180 RID: 384
		// (get) Token: 0x060007F7 RID: 2039 RVA: 0x00013F30 File Offset: 0x00012130
		protected override IList<JToken> ChildrenTokens
		{
			get
			{
				/*
An exception occurred when decompiling this method (060007F7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IList`1<Newtonsoft.Json.Linq.JToken> Newtonsoft.Json.Linq.JArray::get_ChildrenTokens()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.List`1<class Newtonsoft.Json.Linq.JToken>(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.List`1<class Newtonsoft.Json.Linq.JToken>(JArray::_values, ldloc:JArray(this)))
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

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x060007F8 RID: 2040 RVA: 0x00013F44 File Offset: 0x00012144
		public override JTokenType Type
		{
			get
			{
				return JTokenType.Array;
			}
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x00013F54 File Offset: 0x00012154
		public JArray()
		{
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x00013F68 File Offset: 0x00012168
		public JArray(JArray other)
			: base(other)
		{
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x00013F7C File Offset: 0x0001217C
		public JArray(params object[] content)
		{
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x00013F8C File Offset: 0x0001218C
		public JArray(object content)
		{
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x00013FA0 File Offset: 0x000121A0
		internal override bool DeepEquals(JToken node)
		{
			if (node != null)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x0000212A File Offset: 0x0000032A
		internal override JToken CloneToken()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x00013FB4 File Offset: 0x000121B4
		public new static JArray Load(JsonReader reader)
		{
			JArray jarray;
			return jarray;
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x00013FC4 File Offset: 0x000121C4
		public new static JArray Load(JsonReader reader, JsonLoadSettings settings)
		{
			/*
An exception occurred when decompiling this method (06000800)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Newtonsoft.Json.Linq.JArray Newtonsoft.Json.Linq.JArray::Load(Newtonsoft.Json.JsonReader,Newtonsoft.Json.Linq.JsonLoadSettings)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:CultureInfo(var_2_07, callgetter:CultureInfo(CultureInfo::get_InvariantCulture))
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

		// Token: 0x06000801 RID: 2049 RVA: 0x00013FD8 File Offset: 0x000121D8
		public new static JArray Parse(string json)
		{
			JArray jarray;
			return jarray;
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x00013FE8 File Offset: 0x000121E8
		public new static JArray Parse(string json, JsonLoadSettings settings)
		{
			if (!false)
			{
				JArray jarray;
				return jarray;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x00014014 File Offset: 0x00012214
		public new static JArray FromObject(object o)
		{
			JsonSerializer jsonSerializer = JsonSerializer.CreateDefault();
			return JArray.FromObject(jsonSerializer, jsonSerializer);
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x00014030 File Offset: 0x00012230
		public new static JArray FromObject(object o, JsonSerializer jsonSerializer)
		{
			if (!true)
			{
			}
			JToken jtoken;
			if (jtoken != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x00014050 File Offset: 0x00012250
		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
			int size = this._values._size;
			int size2 = this._values._size;
		}

		// Token: 0x17000182 RID: 386
		public override JToken this[object key]
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000806)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Newtonsoft.Json.Linq.JToken Newtonsoft.Json.Linq.JArray::get_Item(System.Object)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:CultureInfo(var_1_0A, callgetter:CultureInfo(CultureInfo::get_InvariantCulture))
	stloc:string(var_2_11, call:string(MiscellaneousUtils::ToString, ldloc:object(key)))
	stloc:string(var_3_1E, call:string(StringUtils::FormatWith, ldstr:string("Accessed JArray values with invalid key value: {0}. Int32 array index expected."), ldloc:CultureInfo[exp:IFormatProvider](var_1_0A), ldloc:string[exp:object](var_2_11)))
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
			set
			{
				/*
An exception occurred when decompiling this method (06000807)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Newtonsoft.Json.Linq.JArray::set_Item(System.Object,Newtonsoft.Json.Linq.JToken)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000F:
	stloc:CultureInfo(var_1_16, callgetter:CultureInfo(CultureInfo::get_InvariantCulture))
	stloc:string(var_2_1D, call:string(MiscellaneousUtils::ToString, ldloc:object(key)))
	stloc:string(var_3_2A, call:string(StringUtils::FormatWith, ldstr:string("Set JArray values with invalid key value: {0}. Int32 array index expected."), ldloc:CultureInfo[exp:IFormatProvider](var_1_16), ldloc:string[exp:object](var_2_1D)))
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

		// Token: 0x17000183 RID: 387
		public JToken this[int index]
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x000140EC File Offset: 0x000122EC
		internal override int IndexOfItem(JToken item)
		{
			List<JToken> values = this._values;
			int num;
			return num;
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x00014104 File Offset: 0x00012304
		internal override void MergeItem(object content, JsonMergeSettings settings)
		{
			if (content == null)
			{
				return;
			}
			if (content != null)
			{
				return;
			}
			throw new InvalidCastException();
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x0000212A File Offset: 0x0000032A
		public int IndexOf(JToken item)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x00014124 File Offset: 0x00012324
		public void Insert(int index, JToken item)
		{
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x00014134 File Offset: 0x00012334
		public void RemoveAt(int index)
		{
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x00014144 File Offset: 0x00012344
		public IEnumerator<JToken> GetEnumerator()
		{
			IEnumerator enumerator;
			return enumerator;
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x00014154 File Offset: 0x00012354
		public void Add(JToken item)
		{
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x00014164 File Offset: 0x00012364
		public void Clear()
		{
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x0000212A File Offset: 0x0000032A
		public bool Contains(JToken item)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x00014174 File Offset: 0x00012374
		public void CopyTo(JToken[] array, int arrayIndex)
		{
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06000814 RID: 2068 RVA: 0x00014184 File Offset: 0x00012384
		public bool IsReadOnly
		{
			get
			{
			}
		}

		// Token: 0x06000815 RID: 2069 RVA: 0x0000212A File Offset: 0x0000032A
		public bool Remove(JToken item)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000816 RID: 2070 RVA: 0x00014194 File Offset: 0x00012394
		internal override int GetDeepHashCode()
		{
			return base.ContentsHashCode();
		}

		// Token: 0x04000333 RID: 819
		private readonly List<JToken> _values;
	}
}
