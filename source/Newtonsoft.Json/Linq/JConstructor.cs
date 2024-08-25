using System;
using System.Collections.Generic;
using System.Globalization;
using Cpp2IlInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000CB RID: 203
	[Preserve]
	public class JConstructor : JContainer
	{
		// Token: 0x1700015B RID: 347
		// (get) Token: 0x0600072C RID: 1836 RVA: 0x000128CC File Offset: 0x00010ACC
		protected override IList<JToken> ChildrenTokens
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600072C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IList`1<Newtonsoft.Json.Linq.JToken> Newtonsoft.Json.Linq.JConstructor::get_ChildrenTokens()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.List`1<class Newtonsoft.Json.Linq.JToken>(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.List`1<class Newtonsoft.Json.Linq.JToken>(JConstructor::_values, ldloc:JConstructor(this)))
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

		// Token: 0x0600072D RID: 1837 RVA: 0x000128E0 File Offset: 0x00010AE0
		internal override int IndexOfItem(JToken item)
		{
			List<JToken> values = this._values;
			int num;
			return num;
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x000128F8 File Offset: 0x00010AF8
		internal override void MergeItem(object content, JsonMergeSettings settings)
		{
			if (content != null)
			{
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x0600072F RID: 1839 RVA: 0x0001290C File Offset: 0x00010B0C
		// (set) Token: 0x06000730 RID: 1840 RVA: 0x00012920 File Offset: 0x00010B20
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000731 RID: 1841 RVA: 0x00012934 File Offset: 0x00010B34
		public override JTokenType Type
		{
			get
			{
				return JTokenType.Constructor;
			}
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x00012944 File Offset: 0x00010B44
		public JConstructor()
		{
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x00012958 File Offset: 0x00010B58
		public JConstructor(JConstructor other)
			: base(other)
		{
			string name = other._name;
			this._name = name;
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x0001297C File Offset: 0x00010B7C
		public JConstructor(string name, params object[] content)
		{
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x0001298C File Offset: 0x00010B8C
		public JConstructor(string name, object content)
		{
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x0001299C File Offset: 0x00010B9C
		public JConstructor(string name)
		{
			do
			{
				base..ctor();
				if (name == null)
				{
					return;
				}
			}
			while (name._stringLength == 0);
			this._name = name;
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x000129C4 File Offset: 0x00010BC4
		internal override bool DeepEquals(JToken node)
		{
			if (node != null)
			{
				string name = this._name;
				bool flag;
				return flag;
			}
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x0000212A File Offset: 0x0000032A
		internal override JToken CloneToken()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x000129E0 File Offset: 0x00010BE0
		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
			string name = this._name;
		}

		// Token: 0x1700015E RID: 350
		public override JToken this[object key]
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600073A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Newtonsoft.Json.Linq.JToken Newtonsoft.Json.Linq.JConstructor::get_Item(System.Object)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000E:
	stloc:CultureInfo(var_1_15, callgetter:CultureInfo(CultureInfo::get_InvariantCulture))
	stloc:string(var_2_1C, call:string(MiscellaneousUtils::ToString, ldloc:object(key)))
	stloc:string(var_3_29, call:string(StringUtils::FormatWith, ldstr:string("Accessed JConstructor values with invalid key value: {0}. Argument position index expected."), ldloc:CultureInfo[exp:IFormatProvider](var_1_15), ldloc:string[exp:object](var_2_1C)))
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
An exception occurred when decompiling this method (0600073B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Newtonsoft.Json.Linq.JConstructor::set_Item(System.Object,Newtonsoft.Json.Linq.JToken)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000F:
	stloc:CultureInfo(var_1_16, callgetter:CultureInfo(CultureInfo::get_InvariantCulture))
	stloc:string(var_2_1D, call:string(MiscellaneousUtils::ToString, ldloc:object(key)))
	stloc:string(var_3_2A, call:string(StringUtils::FormatWith, ldstr:string("Set JConstructor values with invalid key value: {0}. Argument position index expected."), ldloc:CultureInfo[exp:IFormatProvider](var_1_16), ldloc:string[exp:object](var_2_1D)))
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

		// Token: 0x0600073C RID: 1852 RVA: 0x00012A94 File Offset: 0x00010C94
		internal override int GetDeepHashCode()
		{
			string name = this._name;
			return base.ContentsHashCode();
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x00012AB0 File Offset: 0x00010CB0
		public new static JConstructor Load(JsonReader reader)
		{
			JConstructor jconstructor;
			return jconstructor;
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x00012AC0 File Offset: 0x00010CC0
		public new static JConstructor Load(JsonReader reader, JsonLoadSettings settings)
		{
			bool flag;
			if (flag)
			{
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			throw new InvalidCastException();
		}

		// Token: 0x04000319 RID: 793
		private string _name;

		// Token: 0x0400031A RID: 794
		private readonly List<JToken> _values;
	}
}
