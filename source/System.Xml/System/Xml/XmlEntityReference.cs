using System;
using Cpp2IlInjected;

namespace System.Xml
{
	// Token: 0x0200006F RID: 111
	public class XmlEntityReference : XmlLinkedNode
	{
		// Token: 0x0600055D RID: 1373 RVA: 0x00012D78 File Offset: 0x00010F78
		protected internal XmlEntityReference(string name, XmlDocument doc)
			: base(doc)
		{
			if (!doc.isLoading)
			{
				int stringLength = name._stringLength;
				long num = 0L;
				char c = name[(int)num];
			}
			XmlNameTable nameTable = doc.NameTable;
			this.name = nameTable;
			doc.fEntRefNodesPresent = true;
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x0600055E RID: 1374 RVA: 0x00012DC8 File Offset: 0x00010FC8
		public override string Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x0600055F RID: 1375 RVA: 0x00012DDC File Offset: 0x00010FDC
		public override string LocalName
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000560 RID: 1376 RVA: 0x00012DF0 File Offset: 0x00010FF0
		// (set) Token: 0x06000561 RID: 1377 RVA: 0x00012E00 File Offset: 0x00011000
		public override string Value
		{
			get
			{
			}
			set
			{
				/*
An exception occurred when decompiling this method (06000561)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Xml.XmlEntityReference::set_Value(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_0A, call:string(Res::GetString, ldstr:string("'EntityReference' nodes have no support for setting value.")))
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

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000562 RID: 1378 RVA: 0x00012E18 File Offset: 0x00011018
		public override XmlNodeType NodeType
		{
			get
			{
				return XmlNodeType.EntityReference;
			}
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x00012E28 File Offset: 0x00011028
		public override XmlNode CloneNode(bool deep)
		{
			/*
An exception occurred when decompiling this method (06000563)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.XmlNode System.Xml.XmlEntityReference::CloneNode(System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_06, ldfld:string(XmlEntityReference::name, ldloc:XmlEntityReference(this)))
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

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000564 RID: 1380 RVA: 0x00012E3C File Offset: 0x0001103C
		public override bool IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000565 RID: 1381 RVA: 0x00012E4C File Offset: 0x0001104C
		internal override bool IsContainer
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x00012E5C File Offset: 0x0001105C
		internal override void SetParent(XmlNode node)
		{
			if (node != null)
			{
				return;
			}
			this.parentNode = this;
			if (node != null && this == null)
			{
				return;
			}
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x00012E7C File Offset: 0x0001107C
		internal override void SetParentForLoad(XmlNode node)
		{
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000568 RID: 1384 RVA: 0x00012E8C File Offset: 0x0001108C
		// (set) Token: 0x06000569 RID: 1385 RVA: 0x00012EA0 File Offset: 0x000110A0
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

		// Token: 0x0600056A RID: 1386 RVA: 0x00012EB4 File Offset: 0x000110B4
		internal override bool IsValidChildType(XmlNodeType type)
		{
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x0600056B RID: 1387 RVA: 0x00003FFD File Offset: 0x000021FD
		public override string BaseURI
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x00012EC4 File Offset: 0x000110C4
		private string ConstructBaseURI(string baseURI, string systemId)
		{
			if (baseURI != null)
			{
				int num = 47;
				long num2 = 0L;
				int num3 = baseURI.LastIndexOf((char)num);
				int stringLength = baseURI._stringLength;
				long num4 = 0L;
				return baseURI.Substring((int)num4, (int)num2);
			}
			return systemId;
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x0600056D RID: 1389 RVA: 0x00012F24 File Offset: 0x00011124
		internal string ChildBaseURI
		{
			get
			{
				XmlEntity xmlEntity;
				string systemId;
				for (;;)
				{
					string text = this.name;
					if (xmlEntity != null)
					{
						systemId = xmlEntity.systemId;
						if (systemId != null)
						{
							break;
						}
					}
				}
				int stringLength = systemId._stringLength;
				string systemId2 = xmlEntity.systemId;
				string text2;
				return text2;
			}
		}

		// Token: 0x040002D7 RID: 727
		private string name;

		// Token: 0x040002D8 RID: 728
		private XmlLinkedNode lastChild;
	}
}
