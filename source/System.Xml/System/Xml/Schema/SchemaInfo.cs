using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace System.Xml.Schema
{
	// Token: 0x02000133 RID: 307
	internal class SchemaInfo : IDtdInfo
	{
		// Token: 0x06000A85 RID: 2693 RVA: 0x0001D7B4 File Offset: 0x0001B9B4
		internal SchemaInfo()
		{
			if (!true)
			{
			}
			this.docTypeName = 1;
			base..ctor();
		}

		// Token: 0x170002F4 RID: 756
		// (set) Token: 0x06000A86 RID: 2694 RVA: 0x0001D7D4 File Offset: 0x0001B9D4
		public XmlQualifiedName DocTypeName
		{
			set
			{
				this.docTypeName = value;
			}
		}

		// Token: 0x170002F5 RID: 757
		// (set) Token: 0x06000A87 RID: 2695 RVA: 0x0001D7E8 File Offset: 0x0001B9E8
		internal string InternalDtdSubset
		{
			set
			{
				this.internalDtdSubset = value;
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06000A88 RID: 2696 RVA: 0x0001D7FC File Offset: 0x0001B9FC
		internal Dictionary<XmlQualifiedName, SchemaElementDecl> ElementDecls
		{
			get
			{
				return this.elementDecls;
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06000A89 RID: 2697 RVA: 0x0001D810 File Offset: 0x0001BA10
		internal Dictionary<XmlQualifiedName, SchemaElementDecl> UndeclaredElementDecls
		{
			get
			{
				return this.undeclaredElementDecls;
			}
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06000A8A RID: 2698 RVA: 0x0001D824 File Offset: 0x0001BA24
		internal Dictionary<XmlQualifiedName, SchemaEntity> GeneralEntities
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000A8A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.Dictionary`2<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaEntity> System.Xml.Schema.SchemaInfo::get_GeneralEntities()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<class System.Xml.XmlQualifiedName, class System.Xml.Schema.SchemaEntity>[exp:bool](SchemaInfo::generalEntities, ldloc:SchemaInfo(this)))
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

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06000A8B RID: 2699 RVA: 0x0001D838 File Offset: 0x0001BA38
		internal Dictionary<XmlQualifiedName, SchemaEntity> ParameterEntities
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000A8B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.Dictionary`2<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaEntity> System.Xml.Schema.SchemaInfo::get_ParameterEntities()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<class System.Xml.XmlQualifiedName, class System.Xml.Schema.SchemaEntity>[exp:bool](SchemaInfo::parameterEntities, ldloc:SchemaInfo(this)))
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

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000A8C RID: 2700 RVA: 0x0001D84C File Offset: 0x0001BA4C
		// (set) Token: 0x06000A8D RID: 2701 RVA: 0x0001D860 File Offset: 0x0001BA60
		internal SchemaType SchemaType
		{
			get
			{
				return this.schemaType;
			}
			set
			{
				this.schemaType = value;
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06000A8E RID: 2702 RVA: 0x0001D874 File Offset: 0x0001BA74
		internal Dictionary<string, SchemaNotation> Notations
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000A8E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.Dictionary`2<System.String,System.Xml.Schema.SchemaNotation> System.Xml.Schema.SchemaInfo::get_Notations()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<string, class System.Xml.Schema.SchemaNotation>[exp:bool](SchemaInfo::notations, ldloc:SchemaInfo(this)))
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

		// Token: 0x06000A8F RID: 2703 RVA: 0x0001D888 File Offset: 0x0001BA88
		internal void Finish()
		{
			int num = 1;
			int num2 = 1;
			this.hasNonCDataAttributes = num2 != 0;
			while (num == 0)
			{
			}
			this.hasDefaultAttributes = num2 != 0;
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000A90 RID: 2704 RVA: 0x0001D8C0 File Offset: 0x0001BAC0
		bool IDtdInfo.HasDefaultAttributes
		{
			get
			{
				return this.hasDefaultAttributes;
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000A91 RID: 2705 RVA: 0x0001D8D4 File Offset: 0x0001BAD4
		bool IDtdInfo.HasNonCDataAttributes
		{
			get
			{
				return this.hasNonCDataAttributes;
			}
		}

		// Token: 0x06000A92 RID: 2706 RVA: 0x00003FFD File Offset: 0x000021FD
		IDtdAttributeListInfo IDtdInfo.LookupAttributeList(string prefix, string localName)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x0001D8E8 File Offset: 0x0001BAE8
		IDtdEntityInfo IDtdInfo.LookupEntity(string name)
		{
			if (this.generalEntities != null)
			{
				Dictionary<XmlQualifiedName, SchemaEntity> dictionary = this.generalEntities;
				return;
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000A94 RID: 2708 RVA: 0x0001D908 File Offset: 0x0001BB08
		XmlQualifiedName IDtdInfo.Name
		{
			get
			{
				return this.docTypeName;
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000A95 RID: 2709 RVA: 0x0001D91C File Offset: 0x0001BB1C
		string IDtdInfo.InternalDtdSubset
		{
			get
			{
				return this.internalDtdSubset;
			}
		}

		// Token: 0x0400054C RID: 1356
		private Dictionary<XmlQualifiedName, SchemaElementDecl> elementDecls;

		// Token: 0x0400054D RID: 1357
		private Dictionary<XmlQualifiedName, SchemaElementDecl> undeclaredElementDecls;

		// Token: 0x0400054E RID: 1358
		private Dictionary<XmlQualifiedName, SchemaEntity> generalEntities;

		// Token: 0x0400054F RID: 1359
		private Dictionary<XmlQualifiedName, SchemaEntity> parameterEntities;

		// Token: 0x04000550 RID: 1360
		private XmlQualifiedName docTypeName;

		// Token: 0x04000551 RID: 1361
		private string internalDtdSubset;

		// Token: 0x04000552 RID: 1362
		private bool hasNonCDataAttributes;

		// Token: 0x04000553 RID: 1363
		private bool hasDefaultAttributes;

		// Token: 0x04000554 RID: 1364
		private Dictionary<string, bool> targetNamespaces;

		// Token: 0x04000555 RID: 1365
		private Dictionary<XmlQualifiedName, SchemaAttDef> attributeDecls;

		// Token: 0x04000556 RID: 1366
		private SchemaType schemaType;

		// Token: 0x04000557 RID: 1367
		private Dictionary<XmlQualifiedName, SchemaElementDecl> elementDeclsByType;

		// Token: 0x04000558 RID: 1368
		private Dictionary<string, SchemaNotation> notations;
	}
}
