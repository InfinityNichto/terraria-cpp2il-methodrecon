using System;
using System.Threading;
using System.Xml.Schema;
using Cpp2IlInjected;

namespace System.Xml
{
	// Token: 0x02000074 RID: 116
	internal class XmlName : IXmlSchemaInfo
	{
		// Token: 0x0600058F RID: 1423 RVA: 0x00013A10 File Offset: 0x00011C10
		public static XmlName Create(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next, IXmlSchemaInfo schemaInfo)
		{
			/*
An exception occurred when decompiling this method (0600058F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.XmlName System.Xml.XmlName::Create(System.String,System.String,System.String,System.Int32,System.Xml.XmlDocument,System.Xml.XmlName,System.Xml.Schema.IXmlSchemaInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, logicnot:bool(ldloc:XmlName[exp:bool](next)))
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

		// Token: 0x06000590 RID: 1424 RVA: 0x00013A20 File Offset: 0x00011C20
		internal XmlName(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next)
		{
			this.prefix = prefix;
			this.localName = localName;
			this.ns = ns;
			this.hashCode = hashCode;
			this.ownerDoc = ownerDoc;
			this.next = next;
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000591 RID: 1425 RVA: 0x00013A60 File Offset: 0x00011C60
		public string LocalName
		{
			get
			{
				return this.localName;
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000592 RID: 1426 RVA: 0x00013A74 File Offset: 0x00011C74
		public string NamespaceURI
		{
			get
			{
				return this.ns;
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000593 RID: 1427 RVA: 0x00013A88 File Offset: 0x00011C88
		public string Prefix
		{
			get
			{
				return this.prefix;
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000594 RID: 1428 RVA: 0x00013A9C File Offset: 0x00011C9C
		public int HashCode
		{
			get
			{
				return this.hashCode;
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000595 RID: 1429 RVA: 0x00013AB0 File Offset: 0x00011CB0
		public XmlDocument OwnerDocument
		{
			get
			{
				return this.ownerDoc;
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000596 RID: 1430 RVA: 0x00013AC4 File Offset: 0x00011CC4
		public string Name
		{
			get
			{
				string text5;
				if (this.name == null)
				{
					string text = this.prefix;
					string text2 = this.localName;
					int stringLength = text._stringLength;
					int stringLength2 = text2._stringLength;
					string text3 = text + ":" + text2;
					XmlDocument xmlDocument = this.ownerDoc;
					long num = 0L;
					XmlNameTable nameTable = xmlDocument.NameTable;
					Monitor.Enter(nameTable, num != 0L);
					if (this.name != null)
					{
					}
					XmlNameTable nameTable2 = this.ownerDoc.NameTable;
					long num2 = 0L;
					this.name = nameTable2;
					Monitor.Exit(nameTable);
					if (num2 != 0L)
					{
						throw new OutOfMemoryException();
					}
					if (2 != 0)
					{
						string text4 = this.name;
					}
					text5 = this.prefix;
					this.name = text5;
				}
				return text5;
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000597 RID: 1431 RVA: 0x00013B90 File Offset: 0x00011D90
		public virtual XmlSchemaValidity Validity
		{
			get
			{
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000598 RID: 1432 RVA: 0x00013BA0 File Offset: 0x00011DA0
		public virtual bool IsDefault
		{
			get
			{
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000599 RID: 1433 RVA: 0x00013BB0 File Offset: 0x00011DB0
		public virtual bool IsNil
		{
			get
			{
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x0600059A RID: 1434 RVA: 0x00013BC0 File Offset: 0x00011DC0
		public virtual XmlSchemaSimpleType MemberType
		{
			get
			{
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x0600059B RID: 1435 RVA: 0x00013BD0 File Offset: 0x00011DD0
		public virtual XmlSchemaType SchemaType
		{
			get
			{
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x0600059C RID: 1436 RVA: 0x00013BE0 File Offset: 0x00011DE0
		public virtual XmlSchemaElement SchemaElement
		{
			get
			{
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x0600059D RID: 1437 RVA: 0x00013BF0 File Offset: 0x00011DF0
		public virtual XmlSchemaAttribute SchemaAttribute
		{
			get
			{
			}
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x00003FFD File Offset: 0x000021FD
		public virtual bool Equals(IXmlSchemaInfo schemaInfo)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x00003FFD File Offset: 0x000021FD
		public static int GetHashCode(string name)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x040002E2 RID: 738
		private string prefix;

		// Token: 0x040002E3 RID: 739
		private string localName;

		// Token: 0x040002E4 RID: 740
		private string ns;

		// Token: 0x040002E5 RID: 741
		private string name;

		// Token: 0x040002E6 RID: 742
		private int hashCode;

		// Token: 0x040002E7 RID: 743
		internal XmlDocument ownerDoc;

		// Token: 0x040002E8 RID: 744
		internal XmlName next;
	}
}
