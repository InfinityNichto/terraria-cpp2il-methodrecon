using System;
using System.Xml.Schema;

namespace System.Xml
{
	// Token: 0x02000075 RID: 117
	internal sealed class XmlNameEx : XmlName
	{
		// Token: 0x060005A0 RID: 1440 RVA: 0x00013C00 File Offset: 0x00011E00
		internal XmlNameEx(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next, IXmlSchemaInfo schemaInfo)
		{
			this.prefix = prefix;
			this.localName = localName;
			this.ns = ns;
			this.hashCode = hashCode;
			this.ownerDoc = ownerDoc;
			this.next = next;
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x060005A1 RID: 1441 RVA: 0x00013C88 File Offset: 0x00011E88
		public override XmlSchemaValidity Validity
		{
			get
			{
				if (this.ownerDoc.reportValidity)
				{
					byte b = this.flags;
					return;
				}
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x060005A2 RID: 1442 RVA: 0x00013CAC File Offset: 0x00011EAC
		public override bool IsDefault
		{
			get
			{
				/*
An exception occurred when decompiling this method (060005A2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Xml.XmlNameEx::get_IsDefault()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint8(var_0_06, ldfld:uint8(XmlNameEx::flags, ldloc:XmlNameEx(this)))
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

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x060005A3 RID: 1443 RVA: 0x00013CC0 File Offset: 0x00011EC0
		public override bool IsNil
		{
			get
			{
				/*
An exception occurred when decompiling this method (060005A3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Xml.XmlNameEx::get_IsNil()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint8(var_0_06, ldfld:uint8(XmlNameEx::flags, ldloc:XmlNameEx(this)))
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

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x060005A4 RID: 1444 RVA: 0x00013CD4 File Offset: 0x00011ED4
		public override XmlSchemaSimpleType MemberType
		{
			get
			{
				return this.memberType;
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x060005A5 RID: 1445 RVA: 0x00013CE8 File Offset: 0x00011EE8
		public override XmlSchemaType SchemaType
		{
			get
			{
				return this.schemaType;
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x060005A6 RID: 1446 RVA: 0x00013CFC File Offset: 0x00011EFC
		public override XmlSchemaElement SchemaElement
		{
			get
			{
				if (this.decl != null)
				{
					return;
				}
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x060005A7 RID: 1447 RVA: 0x00013D14 File Offset: 0x00011F14
		public override XmlSchemaAttribute SchemaAttribute
		{
			get
			{
				if (this.decl != null)
				{
					return;
				}
			}
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x00013D2C File Offset: 0x00011F2C
		public void SetValidity(XmlSchemaValidity value)
		{
			byte b = this.flags;
			this.flags = b;
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x00013D48 File Offset: 0x00011F48
		public void SetIsDefault(bool value)
		{
			byte b = this.flags;
			this.flags = b;
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x00013D64 File Offset: 0x00011F64
		public void SetIsNil(bool value)
		{
			byte b = this.flags;
			this.flags = b;
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x00013D80 File Offset: 0x00011F80
		public override bool Equals(IXmlSchemaInfo schemaInfo)
		{
			if (schemaInfo == null)
			{
				return;
			}
			byte b = this.flags;
			byte b2 = this.flags;
			byte b3 = this.flags;
			XmlSchemaSimpleType xmlSchemaSimpleType = this.memberType;
			XmlSchemaType xmlSchemaType = this.schemaType;
			if (this.decl != null)
			{
			}
			if (this.decl != null)
			{
				return;
			}
		}

		// Token: 0x040002E9 RID: 745
		private byte flags;

		// Token: 0x040002EA RID: 746
		private XmlSchemaSimpleType memberType;

		// Token: 0x040002EB RID: 747
		private XmlSchemaType schemaType;

		// Token: 0x040002EC RID: 748
		private object decl;
	}
}
