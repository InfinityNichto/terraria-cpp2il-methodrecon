using System;

namespace System.Xml.Schema
{
	// Token: 0x02000132 RID: 306
	internal sealed class SchemaEntity : IDtdEntityInfo
	{
		// Token: 0x06000A61 RID: 2657 RVA: 0x0001D4D8 File Offset: 0x0001B6D8
		internal SchemaEntity(XmlQualifiedName qname, bool isParameter)
		{
			if (!true)
			{
			}
			this.ndata = 1;
			base..ctor();
			this.qname = qname;
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06000A62 RID: 2658 RVA: 0x0001D4FC File Offset: 0x0001B6FC
		string IDtdEntityInfo.Name
		{
			get
			{
				return this.qname.name;
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06000A63 RID: 2659 RVA: 0x0001D514 File Offset: 0x0001B714
		bool IDtdEntityInfo.IsExternal
		{
			get
			{
				return this.isExternal;
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06000A64 RID: 2660 RVA: 0x0001D528 File Offset: 0x0001B728
		bool IDtdEntityInfo.IsDeclaredInExternal
		{
			get
			{
				return this.isDeclaredInExternal;
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06000A65 RID: 2661 RVA: 0x0001D53C File Offset: 0x0001B73C
		bool IDtdEntityInfo.IsUnparsedEntity
		{
			get
			{
				return this.ndata.IsEmpty;
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06000A66 RID: 2662 RVA: 0x0001D554 File Offset: 0x0001B754
		bool IDtdEntityInfo.IsParameterEntity
		{
			get
			{
				return this.isParameter;
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06000A67 RID: 2663 RVA: 0x0001D568 File Offset: 0x0001B768
		string IDtdEntityInfo.BaseUriString
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000A67)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Xml.Schema.SchemaEntity::System.Xml.IDtdEntityInfo.get_BaseUriString()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:string[exp:bool](SchemaEntity::baseURI, ldloc:SchemaEntity(this)))
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

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06000A68 RID: 2664 RVA: 0x0001D57C File Offset: 0x0001B77C
		string IDtdEntityInfo.DeclaredUriString
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000A68)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Xml.Schema.SchemaEntity::System.Xml.IDtdEntityInfo.get_DeclaredUriString()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:string[exp:bool](SchemaEntity::declaredURI, ldloc:SchemaEntity(this)))
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

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06000A69 RID: 2665 RVA: 0x0001D590 File Offset: 0x0001B790
		string IDtdEntityInfo.SystemId
		{
			get
			{
				return this.url;
			}
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06000A6A RID: 2666 RVA: 0x0001D5A4 File Offset: 0x0001B7A4
		string IDtdEntityInfo.PublicId
		{
			get
			{
				return this.pubid;
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06000A6B RID: 2667 RVA: 0x0001D5B8 File Offset: 0x0001B7B8
		string IDtdEntityInfo.Text
		{
			get
			{
				return this.text;
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06000A6C RID: 2668 RVA: 0x0001D5CC File Offset: 0x0001B7CC
		int IDtdEntityInfo.LineNumber
		{
			get
			{
				return this.lineNumber;
			}
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06000A6D RID: 2669 RVA: 0x0001D5E0 File Offset: 0x0001B7E0
		int IDtdEntityInfo.LinePosition
		{
			get
			{
				return this.linePosition;
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06000A6E RID: 2670 RVA: 0x0001D5F4 File Offset: 0x0001B7F4
		internal XmlQualifiedName Name
		{
			get
			{
				return this.qname;
			}
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06000A6F RID: 2671 RVA: 0x0001D608 File Offset: 0x0001B808
		// (set) Token: 0x06000A70 RID: 2672 RVA: 0x0001D61C File Offset: 0x0001B81C
		internal string Url
		{
			get
			{
				return this.url;
			}
			set
			{
				this.isExternal = true;
			}
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06000A71 RID: 2673 RVA: 0x0001D630 File Offset: 0x0001B830
		// (set) Token: 0x06000A72 RID: 2674 RVA: 0x0001D644 File Offset: 0x0001B844
		internal string Pubid
		{
			get
			{
				return this.pubid;
			}
			set
			{
				this.pubid = value;
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06000A73 RID: 2675 RVA: 0x0001D658 File Offset: 0x0001B858
		// (set) Token: 0x06000A74 RID: 2676 RVA: 0x0001D66C File Offset: 0x0001B86C
		internal bool IsExternal
		{
			get
			{
				return this.isExternal;
			}
			set
			{
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06000A75 RID: 2677 RVA: 0x0001D67C File Offset: 0x0001B87C
		// (set) Token: 0x06000A76 RID: 2678 RVA: 0x0001D690 File Offset: 0x0001B890
		internal bool DeclaredInExternal
		{
			get
			{
				return this.isDeclaredInExternal;
			}
			set
			{
			}
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06000A77 RID: 2679 RVA: 0x0001D6A0 File Offset: 0x0001B8A0
		// (set) Token: 0x06000A78 RID: 2680 RVA: 0x0001D6B4 File Offset: 0x0001B8B4
		internal XmlQualifiedName NData
		{
			get
			{
				return this.ndata;
			}
			set
			{
				this.ndata = value;
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06000A79 RID: 2681 RVA: 0x0001D6C8 File Offset: 0x0001B8C8
		// (set) Token: 0x06000A7A RID: 2682 RVA: 0x0001D6DC File Offset: 0x0001B8DC
		internal string Text
		{
			get
			{
				return this.text;
			}
			set
			{
				this.text = value;
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06000A7B RID: 2683 RVA: 0x0001D6F0 File Offset: 0x0001B8F0
		// (set) Token: 0x06000A7C RID: 2684 RVA: 0x0001D704 File Offset: 0x0001B904
		internal int Line
		{
			get
			{
				return this.lineNumber;
			}
			set
			{
				this.lineNumber = value;
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06000A7D RID: 2685 RVA: 0x0001D718 File Offset: 0x0001B918
		// (set) Token: 0x06000A7E RID: 2686 RVA: 0x0001D72C File Offset: 0x0001B92C
		internal int Pos
		{
			get
			{
				return this.linePosition;
			}
			set
			{
				this.linePosition = value;
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06000A7F RID: 2687 RVA: 0x0001D740 File Offset: 0x0001B940
		// (set) Token: 0x06000A80 RID: 2688 RVA: 0x0001D754 File Offset: 0x0001B954
		internal string BaseURI
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000A7F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Xml.Schema.SchemaEntity::get_BaseURI()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:string[exp:bool](SchemaEntity::baseURI, ldloc:SchemaEntity(this)))
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
				this.baseURI = value;
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06000A81 RID: 2689 RVA: 0x0001D768 File Offset: 0x0001B968
		// (set) Token: 0x06000A82 RID: 2690 RVA: 0x0001D77C File Offset: 0x0001B97C
		internal bool ParsingInProgress
		{
			get
			{
				return this.parsingInProgress;
			}
			set
			{
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06000A83 RID: 2691 RVA: 0x0001D78C File Offset: 0x0001B98C
		// (set) Token: 0x06000A84 RID: 2692 RVA: 0x0001D7A0 File Offset: 0x0001B9A0
		internal string DeclaredURI
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000A83)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Xml.Schema.SchemaEntity::get_DeclaredURI()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:string[exp:bool](SchemaEntity::declaredURI, ldloc:SchemaEntity(this)))
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
				this.declaredURI = value;
			}
		}

		// Token: 0x0400053F RID: 1343
		private XmlQualifiedName qname;

		// Token: 0x04000540 RID: 1344
		private string url;

		// Token: 0x04000541 RID: 1345
		private string pubid;

		// Token: 0x04000542 RID: 1346
		private string text;

		// Token: 0x04000543 RID: 1347
		private XmlQualifiedName ndata;

		// Token: 0x04000544 RID: 1348
		private int lineNumber;

		// Token: 0x04000545 RID: 1349
		private int linePosition;

		// Token: 0x04000546 RID: 1350
		private bool isParameter;

		// Token: 0x04000547 RID: 1351
		private bool isExternal;

		// Token: 0x04000548 RID: 1352
		private bool parsingInProgress;

		// Token: 0x04000549 RID: 1353
		private bool isDeclaredInExternal;

		// Token: 0x0400054A RID: 1354
		private string baseURI;

		// Token: 0x0400054B RID: 1355
		private string declaredURI;
	}
}
