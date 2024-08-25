using System;

namespace System.Xml
{
	// Token: 0x0200006E RID: 110
	public class XmlEntity : XmlNode
	{
		// Token: 0x0600054D RID: 1357 RVA: 0x00012BF4 File Offset: 0x00010DF4
		internal XmlEntity(string name, string strdata, string publicId, string systemId, string notationName, XmlDocument doc)
			: base(doc)
		{
			XmlNameTable nameTable = doc.NameTable;
			this.notationName = notationName;
			this.name = nameTable;
			this.publicId = publicId;
			this.systemId = systemId;
			this.unparsedReplacementStr = strdata;
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x00012C38 File Offset: 0x00010E38
		public override XmlNode CloneNode(bool deep)
		{
			/*
An exception occurred when decompiling this method (0600054E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.XmlNode System.Xml.XmlEntity::CloneNode(System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_0A, call:string(Res::GetString, ldstr:string("'Entity' and 'Notation' nodes cannot be cloned.")))
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

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x0600054F RID: 1359 RVA: 0x00012C50 File Offset: 0x00010E50
		public override bool IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000550 RID: 1360 RVA: 0x00012C60 File Offset: 0x00010E60
		public override string Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06000551 RID: 1361 RVA: 0x00012C74 File Offset: 0x00010E74
		public override string LocalName
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000552 RID: 1362 RVA: 0x00012C88 File Offset: 0x00010E88
		// (set) Token: 0x06000553 RID: 1363 RVA: 0x00012C9C File Offset: 0x00010E9C
		public override string InnerText
		{
			get
			{
				return base.InnerText;
			}
			set
			{
				/*
An exception occurred when decompiling this method (06000553)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Xml.XmlEntity::set_InnerText(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_0A, call:string(Res::GetString, ldstr:string("The 'InnerText' of an 'Entity' node is read-only and cannot be set.")))
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

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000554 RID: 1364 RVA: 0x00012CB4 File Offset: 0x00010EB4
		internal override bool IsContainer
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000555 RID: 1365 RVA: 0x00012CC4 File Offset: 0x00010EC4
		// (set) Token: 0x06000556 RID: 1366 RVA: 0x00012CF0 File Offset: 0x00010EF0
		internal override XmlLinkedNode LastNode
		{
			get
			{
				while (this.lastChild != null)
				{
				}
				if (this.childrenFoliating)
				{
				}
				this.childrenFoliating = true;
				return this.lastChild;
			}
			set
			{
				this.lastChild = value;
			}
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x00012D04 File Offset: 0x00010F04
		internal override bool IsValidChildType(XmlNodeType type)
		{
			return true;
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000558 RID: 1368 RVA: 0x00012D14 File Offset: 0x00010F14
		public override XmlNodeType NodeType
		{
			get
			{
				return XmlNodeType.Entity;
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000559 RID: 1369 RVA: 0x00012D24 File Offset: 0x00010F24
		public string SystemId
		{
			get
			{
				return this.systemId;
			}
		}

		// Token: 0x1700014F RID: 335
		// (set) Token: 0x0600055A RID: 1370 RVA: 0x00012D38 File Offset: 0x00010F38
		public override string InnerXml
		{
			set
			{
				/*
An exception occurred when decompiling this method (0600055A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Xml.XmlEntity::set_InnerXml(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_0A, call:string(Res::GetString, ldstr:string("Cannot set the 'InnerXml' for the current node because it is either read-only or cannot have children.")))
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

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x0600055B RID: 1371 RVA: 0x00012D50 File Offset: 0x00010F50
		public override string BaseURI
		{
			get
			{
				return this.baseURI;
			}
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x00012D64 File Offset: 0x00010F64
		internal void SetBaseURI(string inBaseURI)
		{
			this.baseURI = inBaseURI;
		}

		// Token: 0x040002CF RID: 719
		private string publicId;

		// Token: 0x040002D0 RID: 720
		private string systemId;

		// Token: 0x040002D1 RID: 721
		private string notationName;

		// Token: 0x040002D2 RID: 722
		private string name;

		// Token: 0x040002D3 RID: 723
		private string unparsedReplacementStr;

		// Token: 0x040002D4 RID: 724
		private string baseURI;

		// Token: 0x040002D5 RID: 725
		private XmlLinkedNode lastChild;

		// Token: 0x040002D6 RID: 726
		private bool childrenFoliating;
	}
}
