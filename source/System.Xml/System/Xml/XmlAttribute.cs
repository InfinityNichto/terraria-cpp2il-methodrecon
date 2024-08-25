using System;
using Cpp2IlInjected;

namespace System.Xml
{
	// Token: 0x02000062 RID: 98
	public class XmlAttribute : XmlNode
	{
		// Token: 0x06000463 RID: 1123 RVA: 0x000111B0 File Offset: 0x0000F3B0
		internal XmlAttribute(XmlName name, XmlDocument doc)
		{
			/*
An exception occurred when decompiling this method (06000463)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Xml.XmlAttribute::.ctor(System.Xml.XmlName,System.Xml.XmlDocument)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_003A:
	stloc:string(var_0_44, call:string(Res::GetString, ldstr:string("The attribute local name cannot be empty.")))
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

		// Token: 0x06000464 RID: 1124 RVA: 0x00011204 File Offset: 0x0000F404
		protected internal XmlAttribute(string prefix, string localName, string namespaceURI, XmlDocument doc)
		{
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000465 RID: 1125 RVA: 0x00011214 File Offset: 0x0000F414
		// (set) Token: 0x06000466 RID: 1126 RVA: 0x00011228 File Offset: 0x0000F428
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

		// Token: 0x06000467 RID: 1127 RVA: 0x00003FFD File Offset: 0x000021FD
		public override XmlNode CloneNode(bool deep)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000468 RID: 1128 RVA: 0x0001123C File Offset: 0x0000F43C
		public override XmlNode ParentNode
		{
			get
			{
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000469 RID: 1129 RVA: 0x0001124C File Offset: 0x0000F44C
		public override string Name
		{
			get
			{
				return this.name.Name;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x0600046A RID: 1130 RVA: 0x00011264 File Offset: 0x0000F464
		public override string LocalName
		{
			get
			{
				return this.name.localName;
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x0600046B RID: 1131 RVA: 0x0001127C File Offset: 0x0000F47C
		public override string NamespaceURI
		{
			get
			{
				return this.name.ns;
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x0600046C RID: 1132 RVA: 0x00011294 File Offset: 0x0000F494
		public override string Prefix
		{
			get
			{
				return this.name.prefix;
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x0600046D RID: 1133 RVA: 0x000112AC File Offset: 0x0000F4AC
		public override XmlNodeType NodeType
		{
			get
			{
				return XmlNodeType.Attribute;
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x0600046E RID: 1134 RVA: 0x000112BC File Offset: 0x0000F4BC
		public override XmlDocument OwnerDocument
		{
			get
			{
				return this.name.ownerDoc;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x0600046F RID: 1135 RVA: 0x00003FFD File Offset: 0x000021FD
		// (set) Token: 0x06000470 RID: 1136 RVA: 0x000112D4 File Offset: 0x0000F4D4
		public override string Value
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170000EB RID: 235
		// (set) Token: 0x06000471 RID: 1137 RVA: 0x000112E4 File Offset: 0x0000F4E4
		public override string InnerText
		{
			set
			{
				bool flag = this.PrepareOwnerElementInElementIdAttrMap();
				string innerText = base.InnerText;
				base.InnerText = value;
				this.ResetOwnerElementInElementIdAttrMap(innerText);
			}
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x00011318 File Offset: 0x0000F518
		internal bool PrepareOwnerElementInElementIdAttrMap()
		{
			if (this != null)
			{
				bool flag;
				return flag;
			}
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x0001132C File Offset: 0x0000F52C
		internal void ResetOwnerElementInElementIdAttrMap(string oldInnerText)
		{
			if (this != null)
			{
				return;
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000474 RID: 1140 RVA: 0x00011340 File Offset: 0x0000F540
		internal override bool IsContainer
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x00011350 File Offset: 0x0000F550
		internal override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc)
		{
			XmlNodeChangedEventArgs xmlNodeChangedEventArgs;
			if (xmlNodeChangedEventArgs != null)
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
				XmlNode.NestTextNodes(xmlLinkedNode, newChild);
				if (xmlNodeChangedEventArgs != null)
				{
					return newChild;
				}
			}
			this.lastChild = newChild;
			if (xmlNodeChangedEventArgs != null)
			{
			}
			return newChild;
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000476 RID: 1142 RVA: 0x000113A0 File Offset: 0x0000F5A0
		// (set) Token: 0x06000477 RID: 1143 RVA: 0x000113B4 File Offset: 0x0000F5B4
		internal override XmlLinkedNode LastNode
		{
			get
			{
				return this.lastChild;
			}
			set
			{
				this.lastChild = value;
			}
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x00003FFD File Offset: 0x000021FD
		internal override bool IsValidChildType(XmlNodeType type)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000479 RID: 1145 RVA: 0x000113C8 File Offset: 0x0000F5C8
		public virtual bool Specified
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x000113D8 File Offset: 0x0000F5D8
		public override XmlNode RemoveChild(XmlNode oldChild)
		{
			bool flag = this.PrepareOwnerElementInElementIdAttrMap();
			return base.RemoveChild(oldChild);
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x00011400 File Offset: 0x0000F600
		public override XmlNode AppendChild(XmlNode newChild)
		{
			bool flag = this.PrepareOwnerElementInElementIdAttrMap();
			return base.AppendChild(newChild);
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x0600047C RID: 1148 RVA: 0x00011428 File Offset: 0x0000F628
		public virtual XmlElement OwnerElement
		{
			get
			{
				if (this.parentNode != null)
				{
					return;
				}
			}
		}

		// Token: 0x170000F0 RID: 240
		// (set) Token: 0x0600047D RID: 1149 RVA: 0x00011440 File Offset: 0x0000F640
		public override string InnerXml
		{
			set
			{
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x0600047E RID: 1150 RVA: 0x00011450 File Offset: 0x0000F650
		public override string BaseURI
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600047E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Xml.XmlAttribute::get_BaseURI()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, logicnot:bool(ldloc:XmlAttribute[exp:bool](this)))
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

		// Token: 0x0600047F RID: 1151 RVA: 0x00011460 File Offset: 0x0000F660
		internal override void SetParent(XmlNode node)
		{
			this.parentNode = node;
		}

		// Token: 0x0400028D RID: 653
		private XmlName name;

		// Token: 0x0400028E RID: 654
		private XmlLinkedNode lastChild;
	}
}
