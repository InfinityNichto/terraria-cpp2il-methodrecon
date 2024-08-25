using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000CF RID: 207
	[Preserve]
	public class JObject : JContainer, IDictionary<string, JToken>, ICollection<KeyValuePair<string, JToken>>, IEnumerable<KeyValuePair<string, JToken>>, IEnumerable, INotifyPropertyChanged, ICustomTypeDescriptor, global::System.ComponentModel.INotifyPropertyChanging
	{
		// Token: 0x17000177 RID: 375
		// (get) Token: 0x060007AE RID: 1966 RVA: 0x000136BC File Offset: 0x000118BC
		protected override IList<JToken> ChildrenTokens
		{
			get
			{
				/*
An exception occurred when decompiling this method (060007AE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IList`1<Newtonsoft.Json.Linq.JToken> Newtonsoft.Json.Linq.JObject::get_ChildrenTokens()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:JPropertyKeyedCollection(var_0_06, ldfld:JPropertyKeyedCollection(JObject::_properties, ldloc:JObject(this)))
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

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x060007AF RID: 1967 RVA: 0x000136D0 File Offset: 0x000118D0
		// (remove) Token: 0x060007B0 RID: 1968 RVA: 0x000136F4 File Offset: 0x000118F4
		public event PropertyChangedEventHandler PropertyChanged
		{
			[CompilerGenerated]
			add
			{
				if (Delegate.Combine(this.PropertyChanged, value) != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (Delegate.Remove(this.PropertyChanged, value) != null)
				{
				}
			}
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x060007B1 RID: 1969 RVA: 0x00013718 File Offset: 0x00011918
		// (remove) Token: 0x060007B2 RID: 1970 RVA: 0x0001373C File Offset: 0x0001193C
		public event global::System.ComponentModel.PropertyChangingEventHandler PropertyChanging
		{
			[CompilerGenerated]
			add
			{
				if (Delegate.Combine(this.PropertyChanging, value) != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (Delegate.Remove(this.PropertyChanging, value) != null)
				{
				}
			}
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x00013760 File Offset: 0x00011960
		public JObject()
		{
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x00013774 File Offset: 0x00011974
		public JObject(JObject other)
			: base(other)
		{
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x00013788 File Offset: 0x00011988
		public JObject(params object[] content)
		{
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x00013798 File Offset: 0x00011998
		public JObject(object content)
		{
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x000137AC File Offset: 0x000119AC
		internal override bool DeepEquals(JToken node)
		{
			if (node != null)
			{
			}
			JPropertyKeyedCollection properties = this._properties;
			bool flag;
			return flag;
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x000137C8 File Offset: 0x000119C8
		internal override int IndexOfItem(JToken item)
		{
			return this._properties.IndexOfReference(item);
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x000137E4 File Offset: 0x000119E4
		internal override void InsertItem(int index, JToken item, bool skipParentCheck)
		{
			if (item != null)
			{
				return;
			}
			base.InsertItem(index, item, skipParentCheck);
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x00013800 File Offset: 0x00011A00
		internal override void ValidateToken(JToken o, JToken existing)
		{
			ValidationUtils.ArgumentNotNull(o, "o");
			if (existing != null)
			{
			}
			JPropertyKeyedCollection properties = this._properties;
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x00013870 File Offset: 0x00011A70
		internal override void MergeItem(object content, JsonMergeSettings settings)
		{
			if (content != null)
			{
				return;
			}
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x000138D0 File Offset: 0x00011AD0
		internal void InternalPropertyChanged(JProperty childProperty)
		{
			string name = childProperty._name;
			if (this._listChanged != null)
			{
				return;
			}
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x000138F0 File Offset: 0x00011AF0
		internal void InternalPropertyChanging(JProperty childProperty)
		{
			string name = childProperty._name;
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x0000212A File Offset: 0x0000032A
		internal override JToken CloneToken()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x060007BF RID: 1983 RVA: 0x00013904 File Offset: 0x00011B04
		public override JTokenType Type
		{
			get
			{
				return JTokenType.Object;
			}
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x00013914 File Offset: 0x00011B14
		public IEnumerable<JProperty> Properties()
		{
			/*
An exception occurred when decompiling this method (060007C0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IEnumerable`1<Newtonsoft.Json.Linq.JProperty> Newtonsoft.Json.Linq.JObject::Properties()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:JPropertyKeyedCollection(var_0_06, ldfld:JPropertyKeyedCollection(JObject::_properties, ldloc:JObject(this)))
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

		// Token: 0x060007C1 RID: 1985 RVA: 0x00013928 File Offset: 0x00011B28
		public JProperty Property(string name)
		{
			while (name != null)
			{
				JPropertyKeyedCollection properties = this._properties;
				bool flag;
				if (flag)
				{
					throw new InvalidCastException();
				}
			}
		}

		// Token: 0x060007C2 RID: 1986 RVA: 0x0001394C File Offset: 0x00011B4C
		public JEnumerable<JToken> PropertyValues()
		{
			/*
An exception occurred when decompiling this method (060007C2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Newtonsoft.Json.Linq.JEnumerable`1<Newtonsoft.Json.Linq.JToken> Newtonsoft.Json.Linq.JObject::PropertyValues()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.IEnumerable`1<class Newtonsoft.Json.Linq.JProperty>(var_0_06, call:IEnumerable`1[exp:class [mscorlib]System.Collections.Generic.IEnumerable`1<class Newtonsoft.Json.Linq.JProperty>](JObject::Properties, ldloc:JObject(this)))
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

		// Token: 0x17000179 RID: 377
		public override JToken this[object key]
		{
			get
			{
				/*
An exception occurred when decompiling this method (060007C3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Newtonsoft.Json.Linq.JToken Newtonsoft.Json.Linq.JObject::get_Item(System.Object)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0010:
	stloc:CultureInfo(var_2_17, callgetter:CultureInfo(CultureInfo::get_InvariantCulture))
	stloc:string(var_3_1E, call:string(MiscellaneousUtils::ToString, ldloc:object(key)))
	stloc:string(var_4_2B, call:string(StringUtils::FormatWith, ldstr:string("Accessed JObject values with invalid key value: {0}. Object property name expected."), ldloc:CultureInfo[exp:IFormatProvider](var_2_17), ldloc:string[exp:object](var_3_1E)))
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
			set
			{
				/*
An exception occurred when decompiling this method (060007C4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Newtonsoft.Json.Linq.JObject::set_Item(System.Object,Newtonsoft.Json.Linq.JToken)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000F:
	stloc:CultureInfo(var_1_16, callgetter:CultureInfo(CultureInfo::get_InvariantCulture))
	stloc:string(var_2_1D, call:string(MiscellaneousUtils::ToString, ldloc:object(key)))
	stloc:string(var_3_2A, call:string(StringUtils::FormatWith, ldstr:string("Set JObject values with invalid key value: {0}. Object property name expected."), ldloc:CultureInfo[exp:IFormatProvider](var_1_16), ldloc:JToken[exp:object](value)))
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

		// Token: 0x1700017A RID: 378
		public JToken this[string propertyName]
		{
			get
			{
				ValidationUtils.ArgumentNotNull(propertyName, "propertyName");
				JProperty jproperty = this.Property(propertyName);
				JToken value;
				if (jproperty != null)
				{
					value = jproperty.Value;
					return value;
				}
				return value;
			}
			set
			{
				JProperty jproperty = this.Property(propertyName);
				if (jproperty != null)
				{
					jproperty.Value = value;
					return;
				}
			}
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x00013A24 File Offset: 0x00011C24
		public new static JObject Load(JsonReader reader)
		{
			JObject jobject;
			return jobject;
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x00013A34 File Offset: 0x00011C34
		public new static JObject Load(JsonReader reader, JsonLoadSettings settings)
		{
			/*
An exception occurred when decompiling this method (060007C8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Newtonsoft.Json.Linq.JObject Newtonsoft.Json.Linq.JObject::Load(Newtonsoft.Json.JsonReader,Newtonsoft.Json.Linq.JsonLoadSettings)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0016:
	stloc:CultureInfo(var_2_1D, callgetter:CultureInfo(CultureInfo::get_InvariantCulture))
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

		// Token: 0x060007C9 RID: 1993 RVA: 0x00013A60 File Offset: 0x00011C60
		public new static JObject Parse(string json)
		{
			JObject jobject;
			return jobject;
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x00013A70 File Offset: 0x00011C70
		public new static JObject Parse(string json, JsonLoadSettings settings)
		{
			if (!false)
			{
				JObject jobject;
				return jobject;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x00013A9C File Offset: 0x00011C9C
		public new static JObject FromObject(object o)
		{
			JsonSerializer jsonSerializer = JsonSerializer.CreateDefault();
			return JObject.FromObject(jsonSerializer, jsonSerializer);
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x00013AB8 File Offset: 0x00011CB8
		public new static JObject FromObject(object o, JsonSerializer jsonSerializer)
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

		// Token: 0x060007CD RID: 1997 RVA: 0x00013AD8 File Offset: 0x00011CD8
		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
			int count = this._properties.Count;
			long num = 0L;
			JToken jtoken = this._properties[(int)num];
			int count2 = this._properties.Count;
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x00013B0C File Offset: 0x00011D0C
		public JToken GetValue(string propertyName)
		{
			return this.GetValue(propertyName, StringComparison.Ordinal);
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x00013B24 File Offset: 0x00011D24
		public JToken GetValue(string propertyName, StringComparison comparison)
		{
			if (propertyName != null)
			{
				JProperty jproperty = this.Property(propertyName);
				if (jproperty != null)
				{
					return jproperty.Value;
				}
			}
			IEnumerator<JToken> enumerator = this._properties.GetEnumerator();
			if (enumerator != null)
			{
			}
			if (enumerator == null)
			{
				JToken jtoken;
				return jtoken;
			}
			long num;
			if (num == 0L)
			{
				throw new InvalidCastException();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x00013B94 File Offset: 0x00011D94
		public bool TryGetValue(string propertyName, StringComparison comparison, [Out] JToken value)
		{
			/*
An exception occurred when decompiling this method (060007D0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Newtonsoft.Json.Linq.JObject::TryGetValue(System.String,System.StringComparison,Newtonsoft.Json.Linq.JToken)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:JToken(var_0_08, call:JToken(JObject::GetValue, ldloc:JObject(this), ldloc:string(propertyName), ldloc:StringComparison(comparison)))
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

		// Token: 0x060007D1 RID: 2001 RVA: 0x00013BAC File Offset: 0x00011DAC
		public void Add(string propertyName, JToken value)
		{
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x00013BBC File Offset: 0x00011DBC
		bool IDictionary<string, JToken>.ContainsKey(string key)
		{
			return this._properties.Contains(key);
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x060007D3 RID: 2003 RVA: 0x00013BD8 File Offset: 0x00011DD8
		ICollection<string> IDictionary<string, JToken>.Keys
		{
			get
			{
				return this._properties.Keys;
			}
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x00013BF0 File Offset: 0x00011DF0
		public bool Remove(string propertyName)
		{
			JProperty jproperty = this.Property(propertyName);
			if (jproperty != null)
			{
				jproperty.Remove();
			}
			return true;
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x00013C10 File Offset: 0x00011E10
		public bool TryGetValue(string propertyName, [Out] JToken value)
		{
			JProperty jproperty = this.Property(propertyName);
			if (jproperty != null)
			{
				JToken value2 = jproperty.Value;
				return;
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x060007D6 RID: 2006 RVA: 0x0000212A File Offset: 0x0000032A
		ICollection<JToken> IDictionary<string, JToken>.Values
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x00013C30 File Offset: 0x00011E30
		void ICollection<KeyValuePair<string, JToken>>.Add(KeyValuePair<string, JToken> item)
		{
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x00013C40 File Offset: 0x00011E40
		void ICollection<KeyValuePair<string, JToken>>.Clear()
		{
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x00013C50 File Offset: 0x00011E50
		bool ICollection<KeyValuePair<string, JToken>>.Contains(KeyValuePair<string, JToken> item)
		{
			/*
An exception occurred when decompiling this method (060007D9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Newtonsoft.Json.Linq.JObject::System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Contains(System.Collections.Generic.KeyValuePair`2<System.String,Newtonsoft.Json.Linq.JToken>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:JToken(var_1_09, callgetter:JToken(JProperty::get_Value, ldloc:JProperty(var_0)))
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

		// Token: 0x060007DA RID: 2010 RVA: 0x00013C68 File Offset: 0x00011E68
		void ICollection<KeyValuePair<string, JToken>>.CopyTo(KeyValuePair<string, JToken>[] array, int arrayIndex)
		{
			if (array != null)
			{
				if (arrayIndex != 0)
				{
				}
				int count = base.Count;
				IEnumerator<JToken> enumerator = this._properties.GetEnumerator();
				return;
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x060007DB RID: 2011 RVA: 0x00013CCC File Offset: 0x00011ECC
		bool ICollection<KeyValuePair<string, JToken>>.IsReadOnly
		{
			get
			{
			}
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x00013CDC File Offset: 0x00011EDC
		bool ICollection<KeyValuePair<string, JToken>>.Remove(KeyValuePair<string, JToken> item)
		{
			/*
An exception occurred when decompiling this method (060007DC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Newtonsoft.Json.Linq.JObject::System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Remove(System.Collections.Generic.KeyValuePair`2<System.String,Newtonsoft.Json.Linq.JToken>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int64(var_0_06, ldfld:int64(int64::m_value, ldc.i4:int32[exp:int64&](0)))
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

		// Token: 0x060007DD RID: 2013 RVA: 0x00013CF4 File Offset: 0x00011EF4
		internal override int GetDeepHashCode()
		{
			return base.ContentsHashCode();
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x0000212A File Offset: 0x0000032A
		public IEnumerator<KeyValuePair<string, JToken>> GetEnumerator()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x00013D08 File Offset: 0x00011F08
		protected virtual void OnPropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				IntPtr invoke_impl = propertyChanged.invoke_impl;
				IntPtr method_code = propertyChanged.method_code;
				IntPtr method = propertyChanged.method;
				return;
			}
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x00013D38 File Offset: 0x00011F38
		protected virtual void OnPropertyChanging(string propertyName)
		{
			global::System.ComponentModel.PropertyChangingEventHandler propertyChanging = this.PropertyChanging;
			if (propertyChanging != null)
			{
				IntPtr invoke_impl = propertyChanging.invoke_impl;
				IntPtr method_code = propertyChanging.method_code;
				IntPtr method = propertyChanging.method;
				return;
			}
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x0000212A File Offset: 0x0000032A
		PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x00013D68 File Offset: 0x00011F68
		PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties(Attribute[] attributes)
		{
			IEnumerator<KeyValuePair<string, JToken>> enumerator = this.GetEnumerator();
			long num = 0L;
			if (enumerator != null)
			{
			}
			if (num == 0L)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x00013DA0 File Offset: 0x00011FA0
		AttributeCollection ICustomTypeDescriptor.GetAttributes()
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x00013DB4 File Offset: 0x00011FB4
		string ICustomTypeDescriptor.GetClassName()
		{
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x00013DC4 File Offset: 0x00011FC4
		string ICustomTypeDescriptor.GetComponentName()
		{
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x0000212A File Offset: 0x0000032A
		TypeConverter ICustomTypeDescriptor.GetConverter()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x00013DD4 File Offset: 0x00011FD4
		EventDescriptor ICustomTypeDescriptor.GetDefaultEvent()
		{
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x00013DE4 File Offset: 0x00011FE4
		PropertyDescriptor ICustomTypeDescriptor.GetDefaultProperty()
		{
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x00013DF4 File Offset: 0x00011FF4
		object ICustomTypeDescriptor.GetEditor(Type editorBaseType)
		{
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x00013E04 File Offset: 0x00012004
		EventDescriptorCollection ICustomTypeDescriptor.GetEvents(Attribute[] attributes)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x00013E18 File Offset: 0x00012018
		EventDescriptorCollection ICustomTypeDescriptor.GetEvents()
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x00013E2C File Offset: 0x0001202C
		object ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd)
		{
		}

		// Token: 0x0400032A RID: 810
		private readonly JPropertyKeyedCollection _properties;

		// Token: 0x0400032B RID: 811
		[CompilerGenerated]
		private PropertyChangedEventHandler PropertyChanged;

		// Token: 0x0400032C RID: 812
		[CompilerGenerated]
		private global::System.ComponentModel.PropertyChangingEventHandler PropertyChanging;

		// Token: 0x020000D0 RID: 208
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060007ED RID: 2029 RVA: 0x00013E3C File Offset: 0x0001203C
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060007EE RID: 2030 RVA: 0x00013E4C File Offset: 0x0001204C
			public <>c()
			{
			}

			// Token: 0x060007EF RID: 2031 RVA: 0x00013E60 File Offset: 0x00012060
			internal JToken <PropertyValues>b__25_0(JProperty p)
			{
				return p.Value;
			}

			// Token: 0x0400032D RID: 813
			public static readonly JObject.<>c <>9;

			// Token: 0x0400032E RID: 814
			public static Func<JProperty, JToken> <>9__25_0;
		}

		// Token: 0x020000D1 RID: 209
		[CompilerGenerated]
		private sealed class <GetEnumerator>d__58 : IEnumerator<KeyValuePair<string, JToken>>, IDisposable, IEnumerator
		{
			// Token: 0x060007F0 RID: 2032 RVA: 0x00013E74 File Offset: 0x00012074
			[DebuggerHidden]
			public <GetEnumerator>d__58(int <>1__state)
			{
				this.<>1__state = <>1__state;
			}

			// Token: 0x060007F1 RID: 2033 RVA: 0x00013E90 File Offset: 0x00012090
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
				int num = this.<>1__state;
				this.<>m__Finally1();
			}

			// Token: 0x060007F2 RID: 2034 RVA: 0x00013EAC File Offset: 0x000120AC
			private bool MoveNext()
			{
				if (this.<>1__state == 0)
				{
					JObject jobject = this.<>4__this;
					IEnumerator<JToken> enumerator = jobject._properties.GetEnumerator();
					jobject._listChanged = enumerator;
					IEnumerator<JToken> enumerator2 = this.<>7__wrap1;
					this.<>1__state = jobject;
					long value = 0.m_value;
					if (enumerator2 != null)
					{
					}
					throw new InvalidCastException();
				}
				throw new OutOfMemoryException();
			}

			// Token: 0x060007F3 RID: 2035 RVA: 0x00013F0C File Offset: 0x0001210C
			private void <>m__Finally1()
			{
				int num = 1;
				IEnumerator<JToken> enumerator = this.<>7__wrap1;
				this.<>1__state = num;
				if (enumerator != null)
				{
					return;
				}
			}

			// Token: 0x1700017E RID: 382
			// (get) Token: 0x060007F4 RID: 2036 RVA: 0x0000212A File Offset: 0x0000032A
			KeyValuePair<string, JToken> IEnumerator<KeyValuePair<string, JToken>>.Current
			{
				[DebuggerHidden]
				get
				{
					throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			// Token: 0x060007F5 RID: 2037 RVA: 0x0000212A File Offset: 0x0000032A
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x1700017F RID: 383
			// (get) Token: 0x060007F6 RID: 2038 RVA: 0x0000212A File Offset: 0x0000032A
			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			// Token: 0x0400032F RID: 815
			private int <>1__state;

			// Token: 0x04000330 RID: 816
			private KeyValuePair<string, JToken> <>2__current;

			// Token: 0x04000331 RID: 817
			public JObject <>4__this;

			// Token: 0x04000332 RID: 818
			private IEnumerator<JToken> <>7__wrap1;
		}
	}
}
