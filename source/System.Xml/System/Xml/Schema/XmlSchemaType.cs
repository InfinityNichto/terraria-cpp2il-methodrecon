using System;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	// Token: 0x02000157 RID: 343
	public class XmlSchemaType : XmlSchemaAnnotated
	{
		// Token: 0x06000B11 RID: 2833 RVA: 0x0001E8A8 File Offset: 0x0001CAA8
		public static XmlSchemaSimpleType GetBuiltInSimpleType(XmlTypeCode typeCode)
		{
			if (!true)
			{
			}
			XmlSchemaSimpleType xmlSchemaSimpleType;
			return xmlSchemaSimpleType;
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000B12 RID: 2834 RVA: 0x0001E8BC File Offset: 0x0001CABC
		[XmlIgnore]
		public XmlQualifiedName QualifiedName
		{
			get
			{
				return this.qname;
			}
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06000B13 RID: 2835 RVA: 0x0001E8D0 File Offset: 0x0001CAD0
		[XmlIgnore]
		public XmlSchemaType BaseXmlSchemaType
		{
			get
			{
				return this.baseSchemaType;
			}
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06000B14 RID: 2836 RVA: 0x0001E8E4 File Offset: 0x0001CAE4
		[XmlIgnore]
		public XmlSchemaDatatype Datatype
		{
			get
			{
				return this.datatype;
			}
		}

		// Token: 0x17000332 RID: 818
		// (set) Token: 0x06000B15 RID: 2837 RVA: 0x0001E8F8 File Offset: 0x0001CAF8
		[XmlIgnore]
		public virtual bool IsMixed
		{
			set
			{
			}
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06000B16 RID: 2838 RVA: 0x0001E908 File Offset: 0x0001CB08
		[XmlIgnore]
		public XmlTypeCode TypeCode
		{
			get
			{
				if (!true)
				{
				}
				if (!true)
				{
				}
				if (this.datatype != null)
				{
				}
				return XmlTypeCode.Item;
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06000B17 RID: 2839 RVA: 0x0001E924 File Offset: 0x0001CB24
		[XmlIgnore]
		internal XmlValueConverter ValueConverter
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000B17)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.Schema.XmlValueConverter System.Xml.Schema.XmlSchemaType::get_ValueConverter()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, logicnot:bool(ldfld:XmlSchemaDatatype[exp:bool](XmlSchemaType::datatype, ldloc:XmlSchemaType(this))))
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

		// Token: 0x06000B18 RID: 2840 RVA: 0x0001E938 File Offset: 0x0001CB38
		internal void SetQualifiedName(XmlQualifiedName value)
		{
			this.qname = value;
		}

		// Token: 0x06000B19 RID: 2841 RVA: 0x0001E94C File Offset: 0x0001CB4C
		internal void SetBaseSchemaType(XmlSchemaType value)
		{
			this.baseSchemaType = value;
		}

		// Token: 0x06000B1A RID: 2842 RVA: 0x0001E960 File Offset: 0x0001CB60
		internal void SetDerivedBy(XmlSchemaDerivationMethod value)
		{
			this.derivedBy = value;
		}

		// Token: 0x06000B1B RID: 2843 RVA: 0x0001E974 File Offset: 0x0001CB74
		internal void SetDatatype(XmlSchemaDatatype value)
		{
			this.datatype = value;
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06000B1C RID: 2844 RVA: 0x0001E988 File Offset: 0x0001CB88
		// (set) Token: 0x06000B1D RID: 2845 RVA: 0x0001E99C File Offset: 0x0001CB9C
		internal SchemaElementDecl ElementDecl
		{
			get
			{
				return this.elementDecl;
			}
			set
			{
				this.elementDecl = value;
			}
		}

		// Token: 0x06000B1E RID: 2846 RVA: 0x0001E9B0 File Offset: 0x0001CBB0
		internal void SetContentType(XmlSchemaContentType value)
		{
			this.contentType = value;
		}

		// Token: 0x06000B1F RID: 2847 RVA: 0x0001E9C4 File Offset: 0x0001CBC4
		public XmlSchemaType()
		{
			if (256 == 0)
			{
			}
			base..ctor();
		}

		// Token: 0x040005BB RID: 1467
		private XmlSchemaDerivationMethod final = XmlSchemaDerivationMethod.None;

		// Token: 0x040005BC RID: 1468
		private XmlSchemaDerivationMethod derivedBy;

		// Token: 0x040005BD RID: 1469
		private XmlSchemaType baseSchemaType;

		// Token: 0x040005BE RID: 1470
		private XmlSchemaDatatype datatype;

		// Token: 0x040005BF RID: 1471
		private SchemaElementDecl elementDecl;

		// Token: 0x040005C0 RID: 1472
		private XmlQualifiedName qname;

		// Token: 0x040005C1 RID: 1473
		private XmlSchemaContentType contentType;
	}
}
