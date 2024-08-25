using System;

namespace System.Xml
{
	// Token: 0x0200006D RID: 109
	public class XmlElement : XmlLinkedNode
	{
		// Token: 0x0600052F RID: 1327 RVA: 0x00012848 File Offset: 0x00010A48
		internal XmlElement(XmlName name, bool empty, XmlDocument doc)
		{
			/*
An exception occurred when decompiling this method (0600052F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Xml.XmlElement::.ctor(System.Xml.XmlName,System.Boolean,System.Xml.XmlDocument)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0041:
	stloc:string(var_0_4B, call:string(Res::GetString, ldstr:string("The local name for elements or attributes cannot be null or an empty string.")))
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

		// Token: 0x06000530 RID: 1328 RVA: 0x000128A0 File Offset: 0x00010AA0
		protected internal XmlElement(string prefix, string localName, string namespaceURI, XmlDocument doc)
		{
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000531 RID: 1329 RVA: 0x000128B0 File Offset: 0x00010AB0
		// (set) Token: 0x06000532 RID: 1330 RVA: 0x000128C4 File Offset: 0x00010AC4
		internal XmlName XmlName
		{
			get
			{
				return this.name;
			}
			set
			{
				this.name = value;
			}
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x000128D8 File Offset: 0x00010AD8
		public override XmlNode CloneNode(bool deep)
		{
			XmlLinkedNode xmlLinkedNode = this.lastChild;
			XmlLinkedNode xmlLinkedNode2 = this.lastChild;
			base.RemoveAll();
			this.lastChild = this;
			if (xmlLinkedNode2 != null)
			{
			}
			if (xmlLinkedNode2 != null)
			{
			}
			if (this != null)
			{
			}
			if (this != null)
			{
			}
			long num = 0L;
			int num2 = 3;
			if (this != null)
			{
			}
			if (num == 0L)
			{
				if (num2 == 0)
				{
				}
				throw new InvalidCastException();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000534 RID: 1332 RVA: 0x00012948 File Offset: 0x00010B48
		public override string Name
		{
			get
			{
				return this.name.Name;
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000535 RID: 1333 RVA: 0x00012960 File Offset: 0x00010B60
		public override string LocalName
		{
			get
			{
				return this.name.localName;
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000536 RID: 1334 RVA: 0x00012978 File Offset: 0x00010B78
		public override string NamespaceURI
		{
			get
			{
				return this.name.ns;
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000537 RID: 1335 RVA: 0x00012990 File Offset: 0x00010B90
		public override string Prefix
		{
			get
			{
				return this.name.prefix;
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000538 RID: 1336 RVA: 0x000129A8 File Offset: 0x00010BA8
		public override XmlNodeType NodeType
		{
			get
			{
				return XmlNodeType.Element;
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000539 RID: 1337 RVA: 0x000129B8 File Offset: 0x00010BB8
		public override XmlNode ParentNode
		{
			get
			{
				return this.parentNode;
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x0600053A RID: 1338 RVA: 0x000129CC File Offset: 0x00010BCC
		public override XmlDocument OwnerDocument
		{
			get
			{
				return this.name.ownerDoc;
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x0600053B RID: 1339 RVA: 0x000129E4 File Offset: 0x00010BE4
		internal override bool IsContainer
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x000129F4 File Offset: 0x00010BF4
		internal override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc)
		{
			XmlNodeChangedEventArgs insertEventArgsForLoad = doc.GetInsertEventArgsForLoad(newChild, this);
			if (insertEventArgsForLoad != null)
			{
			}
			if (newChild != null)
			{
			}
			XmlLinkedNode xmlLinkedNode = this.lastChild;
			if (xmlLinkedNode != null)
			{
				XmlLinkedNode next = xmlLinkedNode.next;
				xmlLinkedNode.next = newChild;
				this.lastChild = newChild;
				newChild.parentNode = xmlLinkedNode;
				if (insertEventArgsForLoad == null)
				{
					return newChild;
				}
			}
			else
			{
				this.lastChild = newChild;
				if (insertEventArgsForLoad != null)
				{
				}
			}
			return newChild;
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x0600053D RID: 1341 RVA: 0x00012A4C File Offset: 0x00010C4C
		// (set) Token: 0x0600053E RID: 1342 RVA: 0x00012A60 File Offset: 0x00010C60
		public bool IsEmpty
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600053D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Xml.XmlElement::get_IsEmpty()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:XmlLinkedNode(var_0_06, ldfld:XmlLinkedNode(XmlElement::lastChild, ldloc:XmlElement(this)))
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
				XmlLinkedNode xmlLinkedNode = this.lastChild;
				base.RemoveAll();
				this.lastChild = this;
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x0600053F RID: 1343 RVA: 0x00012A84 File Offset: 0x00010C84
		// (set) Token: 0x06000540 RID: 1344 RVA: 0x00012A98 File Offset: 0x00010C98
		internal override XmlLinkedNode LastNode
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600053F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.XmlLinkedNode System.Xml.XmlElement::get_LastNode()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:XmlLinkedNode(var_0_06, ldfld:XmlLinkedNode(XmlElement::lastChild, ldloc:XmlElement(this)))
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
				this.lastChild = value;
			}
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x00012AAC File Offset: 0x00010CAC
		internal override bool IsValidChildType(XmlNodeType type)
		{
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000542 RID: 1346 RVA: 0x00012ABC File Offset: 0x00010CBC
		public override XmlAttributeCollection Attributes
		{
			get
			{
				while (this.attributes != null)
				{
				}
				if (this.attributes != null)
				{
				}
				if (!false)
				{
					return this.attributes;
				}
				throw new OutOfMemoryException();
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000543 RID: 1347 RVA: 0x00012AFC File Offset: 0x00010CFC
		public virtual bool HasAttributes
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000543)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Xml.XmlElement::get_HasAttributes()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, logicnot:bool(ldfld:XmlAttributeCollection[exp:bool](XmlElement::attributes, ldloc:XmlElement(this))))
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

		// Token: 0x06000544 RID: 1348 RVA: 0x00012B10 File Offset: 0x00010D10
		public virtual XmlAttribute SetAttributeNode(XmlAttribute newAttr)
		{
			/*
An exception occurred when decompiling this method (06000544)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.XmlAttribute System.Xml.XmlElement::SetAttributeNode(System.Xml.XmlAttribute)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000C:
	stloc:string(var_0_16, call:string(Res::GetString, ldstr:string("The 'Attribute' node cannot be inserted because it is already an attribute of another element.")))
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

		// Token: 0x06000545 RID: 1349 RVA: 0x00012B34 File Offset: 0x00010D34
		public virtual void RemoveAllAttributes()
		{
			this.attributes.RemoveAll();
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x00012B50 File Offset: 0x00010D50
		public override void RemoveAll()
		{
			base.RemoveAll();
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x00012B64 File Offset: 0x00010D64
		internal void RemoveAllChildren()
		{
			base.RemoveAll();
		}

		// Token: 0x17000144 RID: 324
		// (set) Token: 0x06000548 RID: 1352 RVA: 0x00012B78 File Offset: 0x00010D78
		public override string InnerXml
		{
			set
			{
				base.RemoveAll();
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000549 RID: 1353 RVA: 0x00012B8C File Offset: 0x00010D8C
		// (set) Token: 0x0600054A RID: 1354 RVA: 0x00012BA0 File Offset: 0x00010DA0
		public override string InnerText
		{
			get
			{
				return base.InnerText;
			}
			set
			{
				if (this != null)
				{
					XmlLinkedNode next = this.next;
				}
				base.RemoveAll();
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x0600054B RID: 1355 RVA: 0x00012BC0 File Offset: 0x00010DC0
		public override XmlNode NextSibling
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600054B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.XmlNode System.Xml.XmlElement::get_NextSibling()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:XmlLinkedNode(var_0_0E, ldfld:XmlLinkedNode(XmlLinkedNode::next, ldloc:XmlElement[exp:XmlLinkedNode](this)))
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

		// Token: 0x0600054C RID: 1356 RVA: 0x00012BE0 File Offset: 0x00010DE0
		internal override void SetParent(XmlNode node)
		{
			this.parentNode = node;
		}

		// Token: 0x040002CC RID: 716
		private XmlName name;

		// Token: 0x040002CD RID: 717
		private XmlAttributeCollection attributes;

		// Token: 0x040002CE RID: 718
		private XmlLinkedNode lastChild;
	}
}
