using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	// Token: 0x02000141 RID: 321
	public class XmlSchemaComplexType : XmlSchemaType
	{
		// Token: 0x06000AC3 RID: 2755 RVA: 0x0001E040 File Offset: 0x0001C240
		static XmlSchemaComplexType()
		{
			XmlSchemaComplexType xmlSchemaComplexType = XmlSchemaComplexType.CreateAnyType(XmlSchemaContentProcessing.Lax);
			XmlSchemaComplexType xmlSchemaComplexType2 = XmlSchemaComplexType.CreateAnyType(XmlSchemaContentProcessing.Skip);
			SchemaElementDecl schemaElementDecl = SchemaElementDecl.CreateAnyTypeElementDecl();
			ContentValidator anyTypeContentValidator = XmlSchemaComplexType.AnyTypeContentValidator;
			schemaElementDecl.contentValidator = anyTypeContentValidator;
		}

		// Token: 0x06000AC4 RID: 2756 RVA: 0x0001E070 File Offset: 0x0001C270
		private static XmlSchemaComplexType CreateAnyType(XmlSchemaContentProcessing processContents)
		{
			/*
An exception occurred when decompiling this method (06000AC4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.Schema.XmlSchemaComplexType System.Xml.Schema.XmlSchemaComplexType::CreateAnyType(System.Xml.Schema.XmlSchemaContentProcessing)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0009:
	stloc:SchemaElementDecl(var_1_0E, call:SchemaElementDecl(SchemaElementDecl::CreateAnyTypeElementDecl))
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

		// Token: 0x06000AC5 RID: 2757 RVA: 0x0001E08C File Offset: 0x0001C28C
		public XmlSchemaComplexType()
		{
			if (256 == 0)
			{
			}
			this.contentTypeParticle = 256;
			base..ctor();
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000AC6 RID: 2758 RVA: 0x0001E0BC File Offset: 0x0001C2BC
		[XmlIgnore]
		internal static XmlSchemaComplexType AnyType
		{
			get
			{
				if (!true)
				{
				}
				return 1;
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000AC7 RID: 2759 RVA: 0x0001E0D0 File Offset: 0x0001C2D0
		internal static ContentValidator AnyTypeContentValidator
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000AC7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.Schema.ContentValidator System.Xml.Schema.XmlSchemaComplexType::get_AnyTypeContentValidator()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
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

		// Token: 0x17000314 RID: 788
		// (set) Token: 0x06000AC8 RID: 2760 RVA: 0x0001E0E0 File Offset: 0x0001C2E0
		[XmlAttribute("mixed")]
		[DefaultValue(false)]
		public override bool IsMixed
		{
			set
			{
				byte b = this.pvFlags;
				this.pvFlags = b;
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000AC9 RID: 2761 RVA: 0x0001E0FC File Offset: 0x0001C2FC
		[XmlIgnore]
		public XmlSchemaParticle ContentTypeParticle
		{
			get
			{
				return this.contentTypeParticle;
			}
		}

		// Token: 0x06000ACA RID: 2762 RVA: 0x0001E110 File Offset: 0x0001C310
		internal void SetContentTypeParticle(XmlSchemaParticle value)
		{
			this.contentTypeParticle = value;
		}

		// Token: 0x06000ACB RID: 2763 RVA: 0x0001E124 File Offset: 0x0001C324
		internal void SetAttributeWildcard(XmlSchemaAnyAttribute value)
		{
			this.attributeWildcard = value;
		}

		// Token: 0x04000577 RID: 1399
		private XmlSchemaDerivationMethod block = XmlSchemaDerivationMethod.None;

		// Token: 0x04000578 RID: 1400
		private XmlSchemaParticle contentTypeParticle;

		// Token: 0x04000579 RID: 1401
		private XmlSchemaAnyAttribute attributeWildcard;

		// Token: 0x0400057A RID: 1402
		private static XmlSchemaComplexType anyTypeLax;

		// Token: 0x0400057B RID: 1403
		private static XmlSchemaComplexType anyTypeSkip;

		// Token: 0x0400057C RID: 1404
		private static XmlSchemaComplexType untypedAnyType;

		// Token: 0x0400057D RID: 1405
		private byte pvFlags;
	}
}
