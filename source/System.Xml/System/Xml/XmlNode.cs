using System;
using System.Collections;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2IlInjected;

namespace System.Xml
{
	// Token: 0x02000079 RID: 121
	[DefaultMember("Item")]
	[DebuggerDisplay("{debuggerDisplayProxy}")]
	public abstract class XmlNode : ICloneable, IEnumerable
	{
		// Token: 0x060005C2 RID: 1474 RVA: 0x00013FB0 File Offset: 0x000121B0
		internal XmlNode()
		{
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x00013FC4 File Offset: 0x000121C4
		internal XmlNode(XmlDocument doc)
		{
			/*
An exception occurred when decompiling this method (060005C3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Xml.XmlNode::.ctor(System.Xml.XmlDocument)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0011:
	stloc:string(var_0_1B, call:string(Res::GetString, ldstr:string("Cannot create a node without an owner document.")))
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

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x060005C4 RID: 1476
		public abstract string Name { get; }

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x060005C5 RID: 1477 RVA: 0x00013FEC File Offset: 0x000121EC
		// (set) Token: 0x060005C6 RID: 1478 RVA: 0x00013FFC File Offset: 0x000121FC
		public virtual string Value
		{
			get
			{
			}
			set
			{
				/*
An exception occurred when decompiling this method (060005C6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Xml.XmlNode::set_Value(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:CultureInfo(var_1_07, callgetter:CultureInfo(CultureInfo::get_InvariantCulture))
	stloc:string(var_2_12, call:string(Res::GetString, ldstr:string("Cannot set a value on node type '{0}'.")))
	stloc:string(var_4_1B, call:string(string::Format, ldloc:CultureInfo[exp:IFormatProvider](var_1_07), ldloc:string(var_2_12), ldloc:string[exp:object](var_3)))
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

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x060005C7 RID: 1479
		public abstract XmlNodeType NodeType { get; }

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x060005C8 RID: 1480 RVA: 0x00014028 File Offset: 0x00012228
		public virtual XmlNode ParentNode
		{
			get
			{
				XmlNode xmlNode = this.parentNode;
				XmlNode xmlNode2 = this.parentNode;
				if (xmlNode2 != null)
				{
				}
				return xmlNode2;
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x060005C9 RID: 1481 RVA: 0x00003FFD File Offset: 0x000021FD
		public virtual XmlNodeList ChildNodes
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x060005CA RID: 1482 RVA: 0x00014050 File Offset: 0x00012250
		public virtual XmlNode PreviousSibling
		{
			get
			{
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x060005CB RID: 1483 RVA: 0x00014060 File Offset: 0x00012260
		public virtual XmlNode NextSibling
		{
			get
			{
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x060005CC RID: 1484 RVA: 0x00014070 File Offset: 0x00012270
		public virtual XmlAttributeCollection Attributes
		{
			get
			{
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x060005CD RID: 1485 RVA: 0x00014080 File Offset: 0x00012280
		public virtual XmlDocument OwnerDocument
		{
			get
			{
				XmlNode xmlNode = this.parentNode;
				if (this.parentNode != null)
				{
				}
				XmlNode xmlNode2 = this.parentNode;
				throw new InvalidCastException();
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x060005CE RID: 1486 RVA: 0x000140A8 File Offset: 0x000122A8
		public virtual XmlNode FirstChild
		{
			get
			{
				if (this != null)
				{
				}
				return this;
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x060005CF RID: 1487 RVA: 0x000140BC File Offset: 0x000122BC
		public virtual XmlNode LastChild
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x060005D0 RID: 1488 RVA: 0x000140CC File Offset: 0x000122CC
		internal virtual bool IsContainer
		{
			get
			{
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x060005D1 RID: 1489 RVA: 0x000140DC File Offset: 0x000122DC
		// (set) Token: 0x060005D2 RID: 1490 RVA: 0x000140EC File Offset: 0x000122EC
		internal virtual XmlLinkedNode LastNode
		{
			get
			{
			}
			set
			{
			}
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x000140FC File Offset: 0x000122FC
		internal bool AncestorNode(XmlNode node)
		{
			if (this != null)
			{
			}
			return true;
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x00014110 File Offset: 0x00012310
		public virtual XmlNode RemoveChild(XmlNode oldChild)
		{
			if (this != null)
			{
			}
			if (oldChild != null)
			{
			}
			this.parentNode = oldChild;
			return oldChild;
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x00014168 File Offset: 0x00012368
		public virtual XmlNode AppendChild(XmlNode newChild)
		{
			if (this == null)
			{
				return this;
			}
			bool flag = this.AncestorNode(newChild);
			if (newChild != null)
			{
			}
			if (newChild != null)
			{
			}
			if (newChild != null)
			{
				while (newChild != null)
				{
				}
				return this;
			}
			return newChild;
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x000141DC File Offset: 0x000123DC
		internal virtual XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc)
		{
			XmlNodeChangedEventArgs insertEventArgsForLoad = doc.GetInsertEventArgsForLoad(newChild, this);
			if (insertEventArgsForLoad != null)
			{
			}
			if (newChild != null)
			{
			}
			if (this != null)
			{
				newChild.parentNode = this;
				if (insertEventArgsForLoad == null)
				{
					return newChild;
				}
			}
			else if (insertEventArgsForLoad != null)
			{
			}
			return newChild;
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x00014214 File Offset: 0x00012414
		internal virtual bool IsValidChildType(XmlNodeType type)
		{
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x00014224 File Offset: 0x00012424
		internal virtual bool CanInsertAfter(XmlNode newChild, XmlNode refChild)
		{
			return true;
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x060005D9 RID: 1497 RVA: 0x00003FFD File Offset: 0x000021FD
		public virtual bool HasChildNodes
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x060005DA RID: 1498
		public abstract XmlNode CloneNode(bool deep);

		// Token: 0x060005DB RID: 1499 RVA: 0x00014234 File Offset: 0x00012434
		internal virtual void CopyChildren(XmlDocument doc, XmlNode container, bool deep)
		{
			if (container != null)
			{
				while (container != null)
				{
				}
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x060005DC RID: 1500 RVA: 0x00003FFD File Offset: 0x000021FD
		public virtual string NamespaceURI
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x060005DD RID: 1501 RVA: 0x00003FFD File Offset: 0x000021FD
		public virtual string Prefix
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x060005DE RID: 1502
		public abstract string LocalName { get; }

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x060005DF RID: 1503 RVA: 0x00014248 File Offset: 0x00012448
		public virtual bool IsReadOnly
		{
			get
			{
				return XmlNode.HasReadOnlyParent(this);
			}
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x0001425C File Offset: 0x0001245C
		internal static bool HasReadOnlyParent(XmlNode n)
		{
			throw new InvalidCastException();
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x00003FFD File Offset: 0x000021FD
		object ICloneable.Clone()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x00003FFD File Offset: 0x000021FD
		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x00014274 File Offset: 0x00012474
		private void AppendChildText(StringBuilder builder)
		{
			if (this != null)
			{
				if (this != null)
				{
					this.AppendChildText(builder);
					return;
				}
				while (this != null)
				{
				}
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x060005E4 RID: 1508 RVA: 0x00014294 File Offset: 0x00012494
		// (set) Token: 0x060005E5 RID: 1509 RVA: 0x000142A8 File Offset: 0x000124A8
		public virtual string InnerText
		{
			get
			{
				/*
An exception occurred when decompiling this method (060005E4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Xml.XmlNode::get_InnerText()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	brtrue(IL_0000, logicnot:bool(ldloc:XmlNode[exp:bool](this)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
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
				if (this != null && this == null)
				{
					return;
				}
			}
		}

		// Token: 0x17000188 RID: 392
		// (set) Token: 0x060005E6 RID: 1510 RVA: 0x000142BC File Offset: 0x000124BC
		public virtual string InnerXml
		{
			set
			{
				/*
An exception occurred when decompiling this method (060005E6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Xml.XmlNode::set_InnerXml(System.String)

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

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x060005E7 RID: 1511 RVA: 0x000142D4 File Offset: 0x000124D4
		public virtual string BaseURI
		{
			get
			{
				if (this != null)
				{
					while (this != null)
					{
					}
				}
				string text;
				return text;
			}
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x000142F0 File Offset: 0x000124F0
		public virtual void RemoveAll()
		{
			if (this != null)
			{
				while (this != null)
				{
				}
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x060005E9 RID: 1513 RVA: 0x00014304 File Offset: 0x00012504
		internal XmlDocument Document
		{
			get
			{
				throw new InvalidCastException();
			}
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x00014318 File Offset: 0x00012518
		public virtual string GetPrefixOfNamespace(string namespaceURI)
		{
			/*
An exception occurred when decompiling this method (060005EA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Xml.XmlNode::GetPrefixOfNamespace(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, call:string[exp:bool](XmlNode::GetPrefixOfNamespaceStrict, ldloc:XmlNode(this), ldloc:string(namespaceURI)))
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

		// Token: 0x060005EB RID: 1515 RVA: 0x00014330 File Offset: 0x00012530
		internal string GetPrefixOfNamespaceStrict(string namespaceURI)
		{
			XmlDocument document = this.Document;
			if (document != null)
			{
				XmlNameTable nameTable = document.NameTable;
				if (this != null)
				{
					XmlAttribute xmlAttribute;
					if (xmlAttribute.parentNode != null)
					{
						string strXmlns = document.strXmlns;
					}
					string strXmlns2 = document.strXmlns;
					while (this != null)
					{
					}
				}
				string strReservedXml = document.strReservedXml;
				string strReservedXmlns = document.strReservedXmlns;
				return document.strXml;
			}
			throw new InvalidCastException();
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x0001439C File Offset: 0x0001259C
		internal virtual void SetParent(XmlNode node)
		{
			if (node == null)
			{
			}
			this.parentNode = this;
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x000143B4 File Offset: 0x000125B4
		internal virtual void SetParentForLoad(XmlNode node)
		{
			this.parentNode = node;
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x000143C8 File Offset: 0x000125C8
		internal static void SplitName(string name, [Out] string prefix, [Out] string localName)
		{
			int num = 58;
			int num2 = name.IndexOf((char)num);
			int stringLength = name._stringLength;
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x00014404 File Offset: 0x00012604
		internal virtual XmlNode FindChild(XmlNodeType type)
		{
			if (this != null)
			{
				return this;
			}
			return this;
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x00014418 File Offset: 0x00012618
		internal virtual XmlNodeChangedEventArgs GetEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action)
		{
			/*
An exception occurred when decompiling this method (060005F0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.XmlNodeChangedEventArgs System.Xml.XmlNode::GetEventArgs(System.Xml.XmlNode,System.Xml.XmlNode,System.Xml.XmlNode,System.String,System.String,System.Xml.XmlNodeChangedAction)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0009:
	stloc:string(var_0_13, call:string(Res::GetString, ldstr:string("This node is read-only. It cannot be modified.")))
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

		// Token: 0x060005F1 RID: 1521 RVA: 0x00014438 File Offset: 0x00012638
		internal virtual void BeforeEvent(XmlNodeChangedEventArgs args)
		{
			if (args != null)
			{
				return;
			}
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x0001444C File Offset: 0x0001264C
		internal virtual void AfterEvent(XmlNodeChangedEventArgs args)
		{
			if (args != null)
			{
				return;
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x060005F3 RID: 1523 RVA: 0x00014460 File Offset: 0x00012660
		internal virtual bool IsText
		{
			get
			{
			}
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x00014470 File Offset: 0x00012670
		internal static void NestTextNodes(XmlNode prevNode, XmlNode nextNode)
		{
			nextNode.parentNode = prevNode;
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x00014484 File Offset: 0x00012684
		internal static void UnnestTextNodes(XmlNode prevNode, XmlNode nextNode)
		{
			nextNode.parentNode = prevNode;
		}

		// Token: 0x040002F2 RID: 754
		internal XmlNode parentNode;
	}
}
