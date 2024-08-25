using System;
using System.Xml.Schema;

namespace System.Xml
{
	// Token: 0x02000061 RID: 97
	internal class DomNameTable
	{
		// Token: 0x0600045F RID: 1119 RVA: 0x00011068 File Offset: 0x0000F268
		public DomNameTable(XmlDocument document)
		{
			this.ownerDocument = document;
			XmlNameTable xmlNameTable = document.implementation.nameTable;
			this.nameTable = xmlNameTable;
			this.mask = 63;
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x000110A0 File Offset: 0x0000F2A0
		public XmlName GetName(string prefix, string localName, string ns, IXmlSchemaInfo schemaInfo)
		{
			/*
An exception occurred when decompiling this method (06000460)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.XmlName System.Xml.DomNameTable::GetName(System.String,System.String,System.String,System.Xml.Schema.IXmlSchemaInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0038:
	brtrue(IL_0038, ldloc:string[exp:bool](ns))
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

		// Token: 0x06000461 RID: 1121 RVA: 0x000110E8 File Offset: 0x0000F2E8
		public XmlName AddName(string prefix, string localName, string ns, IXmlSchemaInfo schemaInfo)
		{
			XmlName xmlName;
			if (prefix != null)
			{
				if (ns != null)
				{
					int hashCode = XmlName.GetHashCode(localName);
					int num = this.mask;
					XmlName[] array = this.entries;
					XmlNameTable xmlNameTable = this.nameTable;
					XmlNameTable xmlNameTable2 = this.nameTable;
					XmlNameTable xmlNameTable3 = this.nameTable;
					int num2 = this.mask;
					XmlName[] array2 = this.entries;
					XmlDocument xmlDocument = this.ownerDocument;
					XmlName[] array3 = this.entries;
					if (xmlName == null || xmlName != null)
					{
						int num3 = this.count;
						XmlDocument xmlDocument2 = this.ownerDocument;
						this.Grow();
						return xmlName;
					}
					throw new ArrayTypeMismatchException();
				}
			}
			else
			{
				while (ns != null)
				{
				}
			}
			return xmlName;
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x00011174 File Offset: 0x0000F374
		private void Grow()
		{
			int num = this.mask;
			XmlName[] array = this.entries;
			int num2 = 1;
			string localName = array.localName;
			string localName2 = array.localName;
			this.mask = num2;
		}

		// Token: 0x04000288 RID: 648
		private XmlName[] entries;

		// Token: 0x04000289 RID: 649
		private int count;

		// Token: 0x0400028A RID: 650
		private int mask;

		// Token: 0x0400028B RID: 651
		private XmlDocument ownerDocument;

		// Token: 0x0400028C RID: 652
		private XmlNameTable nameTable;
	}
}
