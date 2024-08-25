using System;
using System.Collections;
using Cpp2IlInjected;

namespace System.Xml.Schema
{
	// Token: 0x020000DD RID: 221
	internal abstract class DatatypeImplementation : XmlSchemaDatatype
	{
		// Token: 0x0600086F RID: 2159 RVA: 0x0001AAFC File Offset: 0x00018CFC
		static DatatypeImplementation()
		{
			XmlSchemaDatatype xmlSchemaDatatype;
			if (xmlSchemaDatatype != null)
			{
				return;
			}
			XmlSchemaDatatype xmlSchemaDatatype2;
			if (xmlSchemaDatatype2 != null)
			{
				return;
			}
			XmlSchemaDatatype xmlSchemaDatatype3;
			if (xmlSchemaDatatype3 != null)
			{
				throw new InvalidCastException();
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000870 RID: 2160 RVA: 0x0001AB3C File Offset: 0x00018D3C
		internal static XmlSchemaSimpleType AnySimpleType
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000870)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.Schema.XmlSchemaSimpleType System.Xml.Schema.DatatypeImplementation::get_AnySimpleType()

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

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000871 RID: 2161 RVA: 0x0001AB4C File Offset: 0x00018D4C
		internal static XmlSchemaSimpleType UntypedAtomicType
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000871)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.Schema.XmlSchemaSimpleType System.Xml.Schema.DatatypeImplementation::get_UntypedAtomicType()

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

		// Token: 0x06000872 RID: 2162 RVA: 0x0001AB5C File Offset: 0x00018D5C
		internal new static DatatypeImplementation FromXmlTokenizedType(XmlTokenizedType token)
		{
			/*
An exception occurred when decompiling this method (06000872)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.Schema.DatatypeImplementation System.Xml.Schema.DatatypeImplementation::FromXmlTokenizedType(System.Xml.XmlTokenizedType)

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

		// Token: 0x06000873 RID: 2163 RVA: 0x0001AB6C File Offset: 0x00018D6C
		private static DatatypeImplementation FromTypeName(string name)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x00003FFD File Offset: 0x000021FD
		internal static XmlSchemaSimpleType StartBuiltinType(XmlQualifiedName qname, XmlSchemaDatatype dataType)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x0001AB84 File Offset: 0x00018D84
		internal static void FinishBuiltinType(XmlSchemaSimpleType derivedType, XmlSchemaSimpleType baseType)
		{
			XmlSchemaDatatype datatype = derivedType.datatype;
			int num = 4;
			derivedType.baseSchemaType = baseType;
			derivedType.derivedBy = (XmlSchemaDerivationMethod)num;
			if (datatype == null)
			{
				XmlQualifiedName qualifiedName = baseType.QualifiedName;
			}
			XmlSchemaDatatype datatype2 = derivedType.datatype;
			XmlSchemaDatatype datatype3 = derivedType.datatype;
			int num2 = 8;
			derivedType.derivedBy = (XmlSchemaDerivationMethod)num2;
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x0001ABD0 File Offset: 0x00018DD0
		internal static void CreateBuiltinTypes()
		{
			if (!true)
			{
			}
			DatatypeImplementation datatypeImplementation;
			XmlSchemaSimpleType xmlSchemaSimpleType;
			datatypeImplementation.parentSchemaType = xmlSchemaSimpleType;
			DatatypeImplementation datatypeImplementation2;
			XmlSchemaSimpleType xmlSchemaSimpleType2;
			datatypeImplementation2.parentSchemaType = xmlSchemaSimpleType2;
			XmlSchemaDatatypeVariety xmlSchemaDatatypeVariety = datatypeImplementation2.variety;
			if (xmlSchemaDatatypeVariety == XmlSchemaDatatypeVariety.Atomic)
			{
				if (xmlSchemaDatatypeVariety == XmlSchemaDatatypeVariety.Atomic)
				{
				}
				if (xmlSchemaSimpleType2 != null && xmlSchemaSimpleType2 == null)
				{
					throw new ArrayTypeMismatchException();
				}
			}
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x0001AC28 File Offset: 0x00018E28
		internal static XmlSchemaSimpleType GetSimpleTypeFromTypeCode(XmlTypeCode typeCode)
		{
			/*
An exception occurred when decompiling this method (06000877)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.Schema.XmlSchemaSimpleType System.Xml.Schema.DatatypeImplementation::GetSimpleTypeFromTypeCode(System.Xml.Schema.XmlTypeCode)

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

		// Token: 0x06000878 RID: 2168 RVA: 0x0001AC38 File Offset: 0x00018E38
		internal XmlSchemaDatatype DeriveByList(int minSize, XmlSchemaType schemaType)
		{
			XmlSchemaDatatypeVariety xmlSchemaDatatypeVariety = this.variety;
			if (!true)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x00003FFD File Offset: 0x000021FD
		internal override bool IsEqual(object o1, object o2)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x0001AC54 File Offset: 0x00018E54
		internal virtual XmlValueConverter CreateValueConverter(XmlSchemaType schemaType)
		{
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x0600087B RID: 2171 RVA: 0x0001AC64 File Offset: 0x00018E64
		internal override FacetsChecker FacetsChecker
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600087B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.Schema.FacetsChecker System.Xml.Schema.DatatypeImplementation::get_FacetsChecker()

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

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x0600087C RID: 2172 RVA: 0x0001AC74 File Offset: 0x00018E74
		internal override XmlValueConverter ValueConverter
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600087C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.Schema.XmlValueConverter System.Xml.Schema.DatatypeImplementation::get_ValueConverter()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:XmlSchemaType(var_0_0E, ldfld:XmlSchemaType(DatatypeImplementation::parentSchemaType, ldloc:DatatypeImplementation(this)))
	stfld:XmlValueConverter(DatatypeImplementation::valueConverter, ldloc:DatatypeImplementation(this), ldloc:DatatypeImplementation[exp:XmlValueConverter](this))
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

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x0600087D RID: 2173 RVA: 0x0001AC98 File Offset: 0x00018E98
		public override XmlTokenizedType TokenizedType
		{
			get
			{
				return XmlTokenizedType.None;
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x0600087E RID: 2174 RVA: 0x0001ACA8 File Offset: 0x00018EA8
		public override Type ValueType
		{
			get
			{
				if (!true)
				{
				}
				Type type;
				return type;
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x0600087F RID: 2175 RVA: 0x0001ACBC File Offset: 0x00018EBC
		public override XmlSchemaDatatypeVariety Variety
		{
			get
			{
				return this.variety;
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000880 RID: 2176 RVA: 0x0001ACD0 File Offset: 0x00018ED0
		public override XmlTypeCode TypeCode
		{
			get
			{
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000881 RID: 2177 RVA: 0x0001ACE0 File Offset: 0x00018EE0
		internal override RestrictionFacets Restriction
		{
			get
			{
				return this.restriction;
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000882 RID: 2178
		internal abstract Type ListValueType { get; }

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000883 RID: 2179 RVA: 0x0001ACF4 File Offset: 0x00018EF4
		internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet
		{
			get
			{
			}
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x0001AD04 File Offset: 0x00018F04
		public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr)
		{
			if (this == null)
			{
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x0001AD30 File Offset: 0x00018F30
		internal string GetTypeName()
		{
			XmlSchemaType xmlSchemaType = this.parentSchemaType;
			if (xmlSchemaType != null)
			{
				XmlQualifiedName qualifiedName = xmlSchemaType.QualifiedName;
				if (qualifiedName.name._stringLength != 0 || qualifiedName.ns._stringLength != 0)
				{
					XmlQualifiedName qualifiedName2 = xmlSchemaType.QualifiedName;
				}
			}
			return base.TypeCodeString;
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x0001AD78 File Offset: 0x00018F78
		protected int Compare(byte[] value1, byte[] value2)
		{
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x0001AD88 File Offset: 0x00018F88
		protected DatatypeImplementation()
		{
		}

		// Token: 0x04000470 RID: 1136
		private XmlSchemaDatatypeVariety variety;

		// Token: 0x04000471 RID: 1137
		private RestrictionFacets restriction;

		// Token: 0x04000472 RID: 1138
		private DatatypeImplementation baseType;

		// Token: 0x04000473 RID: 1139
		private XmlValueConverter valueConverter;

		// Token: 0x04000474 RID: 1140
		private XmlSchemaType parentSchemaType;

		// Token: 0x04000475 RID: 1141
		private static Hashtable builtinTypes;

		// Token: 0x04000476 RID: 1142
		private static XmlSchemaSimpleType[] enumToTypeCode;

		// Token: 0x04000477 RID: 1143
		private static XmlSchemaSimpleType anySimpleType;

		// Token: 0x04000478 RID: 1144
		private static XmlSchemaSimpleType anyAtomicType;

		// Token: 0x04000479 RID: 1145
		private static XmlSchemaSimpleType untypedAtomicType;

		// Token: 0x0400047A RID: 1146
		private static XmlSchemaSimpleType yearMonthDurationType;

		// Token: 0x0400047B RID: 1147
		private static XmlSchemaSimpleType dayTimeDurationType;

		// Token: 0x0400047C RID: 1148
		internal static XmlQualifiedName QnAnySimpleType;

		// Token: 0x0400047D RID: 1149
		internal static XmlQualifiedName QnAnyType;

		// Token: 0x0400047E RID: 1150
		internal static FacetsChecker stringFacetsChecker;

		// Token: 0x0400047F RID: 1151
		internal static FacetsChecker miscFacetsChecker;

		// Token: 0x04000480 RID: 1152
		internal static FacetsChecker numeric2FacetsChecker;

		// Token: 0x04000481 RID: 1153
		internal static FacetsChecker binaryFacetsChecker;

		// Token: 0x04000482 RID: 1154
		internal static FacetsChecker dateTimeFacetsChecker;

		// Token: 0x04000483 RID: 1155
		internal static FacetsChecker durationFacetsChecker;

		// Token: 0x04000484 RID: 1156
		internal static FacetsChecker listFacetsChecker;

		// Token: 0x04000485 RID: 1157
		internal static FacetsChecker qnameFacetsChecker;

		// Token: 0x04000486 RID: 1158
		internal static FacetsChecker unionFacetsChecker;

		// Token: 0x04000487 RID: 1159
		private static readonly DatatypeImplementation c_anySimpleType;

		// Token: 0x04000488 RID: 1160
		private static readonly DatatypeImplementation c_anyURI;

		// Token: 0x04000489 RID: 1161
		private static readonly DatatypeImplementation c_base64Binary;

		// Token: 0x0400048A RID: 1162
		private static readonly DatatypeImplementation c_boolean;

		// Token: 0x0400048B RID: 1163
		private static readonly DatatypeImplementation c_byte;

		// Token: 0x0400048C RID: 1164
		private static readonly DatatypeImplementation c_char;

		// Token: 0x0400048D RID: 1165
		private static readonly DatatypeImplementation c_date;

		// Token: 0x0400048E RID: 1166
		private static readonly DatatypeImplementation c_dateTime;

		// Token: 0x0400048F RID: 1167
		private static readonly DatatypeImplementation c_dateTimeNoTz;

		// Token: 0x04000490 RID: 1168
		private static readonly DatatypeImplementation c_dateTimeTz;

		// Token: 0x04000491 RID: 1169
		private static readonly DatatypeImplementation c_day;

		// Token: 0x04000492 RID: 1170
		private static readonly DatatypeImplementation c_decimal;

		// Token: 0x04000493 RID: 1171
		private static readonly DatatypeImplementation c_double;

		// Token: 0x04000494 RID: 1172
		private static readonly DatatypeImplementation c_doubleXdr;

		// Token: 0x04000495 RID: 1173
		private static readonly DatatypeImplementation c_duration;

		// Token: 0x04000496 RID: 1174
		private static readonly DatatypeImplementation c_ENTITY;

		// Token: 0x04000497 RID: 1175
		private static readonly DatatypeImplementation c_ENTITIES;

		// Token: 0x04000498 RID: 1176
		private static readonly DatatypeImplementation c_ENUMERATION;

		// Token: 0x04000499 RID: 1177
		private static readonly DatatypeImplementation c_fixed;

		// Token: 0x0400049A RID: 1178
		private static readonly DatatypeImplementation c_float;

		// Token: 0x0400049B RID: 1179
		private static readonly DatatypeImplementation c_floatXdr;

		// Token: 0x0400049C RID: 1180
		private static readonly DatatypeImplementation c_hexBinary;

		// Token: 0x0400049D RID: 1181
		private static readonly DatatypeImplementation c_ID;

		// Token: 0x0400049E RID: 1182
		private static readonly DatatypeImplementation c_IDREF;

		// Token: 0x0400049F RID: 1183
		private static readonly DatatypeImplementation c_IDREFS;

		// Token: 0x040004A0 RID: 1184
		private static readonly DatatypeImplementation c_int;

		// Token: 0x040004A1 RID: 1185
		private static readonly DatatypeImplementation c_integer;

		// Token: 0x040004A2 RID: 1186
		private static readonly DatatypeImplementation c_language;

		// Token: 0x040004A3 RID: 1187
		private static readonly DatatypeImplementation c_long;

		// Token: 0x040004A4 RID: 1188
		private static readonly DatatypeImplementation c_month;

		// Token: 0x040004A5 RID: 1189
		private static readonly DatatypeImplementation c_monthDay;

		// Token: 0x040004A6 RID: 1190
		private static readonly DatatypeImplementation c_Name;

		// Token: 0x040004A7 RID: 1191
		private static readonly DatatypeImplementation c_NCName;

		// Token: 0x040004A8 RID: 1192
		private static readonly DatatypeImplementation c_negativeInteger;

		// Token: 0x040004A9 RID: 1193
		private static readonly DatatypeImplementation c_NMTOKEN;

		// Token: 0x040004AA RID: 1194
		private static readonly DatatypeImplementation c_NMTOKENS;

		// Token: 0x040004AB RID: 1195
		private static readonly DatatypeImplementation c_nonNegativeInteger;

		// Token: 0x040004AC RID: 1196
		private static readonly DatatypeImplementation c_nonPositiveInteger;

		// Token: 0x040004AD RID: 1197
		private static readonly DatatypeImplementation c_normalizedString;

		// Token: 0x040004AE RID: 1198
		private static readonly DatatypeImplementation c_NOTATION;

		// Token: 0x040004AF RID: 1199
		private static readonly DatatypeImplementation c_positiveInteger;

		// Token: 0x040004B0 RID: 1200
		private static readonly DatatypeImplementation c_QName;

		// Token: 0x040004B1 RID: 1201
		private static readonly DatatypeImplementation c_QNameXdr;

		// Token: 0x040004B2 RID: 1202
		private static readonly DatatypeImplementation c_short;

		// Token: 0x040004B3 RID: 1203
		private static readonly DatatypeImplementation c_string;

		// Token: 0x040004B4 RID: 1204
		private static readonly DatatypeImplementation c_time;

		// Token: 0x040004B5 RID: 1205
		private static readonly DatatypeImplementation c_timeNoTz;

		// Token: 0x040004B6 RID: 1206
		private static readonly DatatypeImplementation c_timeTz;

		// Token: 0x040004B7 RID: 1207
		private static readonly DatatypeImplementation c_token;

		// Token: 0x040004B8 RID: 1208
		private static readonly DatatypeImplementation c_unsignedByte;

		// Token: 0x040004B9 RID: 1209
		private static readonly DatatypeImplementation c_unsignedInt;

		// Token: 0x040004BA RID: 1210
		private static readonly DatatypeImplementation c_unsignedLong;

		// Token: 0x040004BB RID: 1211
		private static readonly DatatypeImplementation c_unsignedShort;

		// Token: 0x040004BC RID: 1212
		private static readonly DatatypeImplementation c_uuid;

		// Token: 0x040004BD RID: 1213
		private static readonly DatatypeImplementation c_year;

		// Token: 0x040004BE RID: 1214
		private static readonly DatatypeImplementation c_yearMonth;

		// Token: 0x040004BF RID: 1215
		internal static readonly DatatypeImplementation c_normalizedStringV1Compat;

		// Token: 0x040004C0 RID: 1216
		internal static readonly DatatypeImplementation c_tokenV1Compat;

		// Token: 0x040004C1 RID: 1217
		private static readonly DatatypeImplementation c_anyAtomicType;

		// Token: 0x040004C2 RID: 1218
		private static readonly DatatypeImplementation c_dayTimeDuration;

		// Token: 0x040004C3 RID: 1219
		private static readonly DatatypeImplementation c_untypedAtomicType;

		// Token: 0x040004C4 RID: 1220
		private static readonly DatatypeImplementation c_yearMonthDuration;

		// Token: 0x040004C5 RID: 1221
		private static readonly DatatypeImplementation[] c_tokenizedTypes;

		// Token: 0x040004C6 RID: 1222
		private static readonly DatatypeImplementation[] c_tokenizedTypesXsd;

		// Token: 0x040004C7 RID: 1223
		private static readonly DatatypeImplementation.SchemaDatatypeMap[] c_XdrTypes;

		// Token: 0x040004C8 RID: 1224
		private static readonly DatatypeImplementation.SchemaDatatypeMap[] c_XsdTypes;

		// Token: 0x020000DE RID: 222
		private class SchemaDatatypeMap : IComparable
		{
			// Token: 0x06000888 RID: 2184 RVA: 0x0001AD9C File Offset: 0x00018F9C
			internal SchemaDatatypeMap(string name, DatatypeImplementation type)
			{
				this.name = name;
				this.type = type;
			}

			// Token: 0x06000889 RID: 2185 RVA: 0x0001ADC0 File Offset: 0x00018FC0
			internal SchemaDatatypeMap(string name, DatatypeImplementation type, int parentIndex)
			{
				this.name = name;
				this.type = type;
				this.parentIndex = parentIndex;
			}

			// Token: 0x0600088A RID: 2186 RVA: 0x00003FFD File Offset: 0x000021FD
			public static explicit operator DatatypeImplementation(DatatypeImplementation.SchemaDatatypeMap sdm)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x17000215 RID: 533
			// (get) Token: 0x0600088B RID: 2187 RVA: 0x0001ADE8 File Offset: 0x00018FE8
			public string Name
			{
				get
				{
					return this.name;
				}
			}

			// Token: 0x17000216 RID: 534
			// (get) Token: 0x0600088C RID: 2188 RVA: 0x0001ADFC File Offset: 0x00018FFC
			public int ParentIndex
			{
				get
				{
					return this.parentIndex;
				}
			}

			// Token: 0x0600088D RID: 2189 RVA: 0x0001AE10 File Offset: 0x00019010
			public int CompareTo(object obj)
			{
				string text = this.name;
				if (obj != null)
				{
				}
				int num;
				return num;
			}

			// Token: 0x040004C9 RID: 1225
			private string name;

			// Token: 0x040004CA RID: 1226
			private DatatypeImplementation type;

			// Token: 0x040004CB RID: 1227
			private int parentIndex;
		}
	}
}
