using System;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	// Token: 0x02000023 RID: 35
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface, AllowMultiple = false)]
	[Preserve]
	public sealed class JsonObjectAttribute : JsonContainerAttribute
	{
		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000065 RID: 101 RVA: 0x000029F4 File Offset: 0x00000BF4
		// (set) Token: 0x06000066 RID: 102 RVA: 0x00002A08 File Offset: 0x00000C08
		public MemberSerialization MemberSerialization
		{
			get
			{
				return this._memberSerialization;
			}
			set
			{
				this._memberSerialization = value;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000067 RID: 103 RVA: 0x00002A1C File Offset: 0x00000C1C
		// (set) Token: 0x06000068 RID: 104 RVA: 0x00002A30 File Offset: 0x00000C30
		public Required ItemRequired
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000067)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Newtonsoft.Json.Required Newtonsoft.Json.JsonObjectAttribute::get_ItemRequired()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:valuetype [mscorlib]System.Nullable`1<valuetype Newtonsoft.Json.Required>(var_0_06, ldfld:valuetype [mscorlib]System.Nullable`1<valuetype Newtonsoft.Json.Required>(JsonObjectAttribute::_itemRequired, ldloc:JsonObjectAttribute(this)))
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
				this._itemRequired = 1;
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002A44 File Offset: 0x00000C44
		public JsonObjectAttribute()
		{
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002A58 File Offset: 0x00000C58
		public JsonObjectAttribute(MemberSerialization memberSerialization)
		{
			this._memberSerialization = memberSerialization;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002A74 File Offset: 0x00000C74
		public JsonObjectAttribute(string id)
		{
			this.<Id>k__BackingField = id;
		}

		// Token: 0x04000056 RID: 86
		private MemberSerialization _memberSerialization;

		// Token: 0x04000057 RID: 87
		internal Required? _itemRequired;
	}
}
