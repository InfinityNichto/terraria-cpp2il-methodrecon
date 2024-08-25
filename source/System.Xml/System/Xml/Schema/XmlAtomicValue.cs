using System;
using System.Runtime.InteropServices;
using System.Xml.XPath;
using Cpp2IlInjected;

namespace System.Xml.Schema
{
	// Token: 0x02000138 RID: 312
	public sealed class XmlAtomicValue : XPathItem, ICloneable
	{
		// Token: 0x06000AA0 RID: 2720 RVA: 0x0001DA5C File Offset: 0x0001BC5C
		internal XmlAtomicValue(XmlSchemaType xmlType, bool value)
		{
			do
			{
				base..ctor();
			}
			while (xmlType == null);
			this.xmlType = xmlType;
			this.clrType = TypeCode.Boolean;
		}

		// Token: 0x06000AA1 RID: 2721 RVA: 0x0001DA80 File Offset: 0x0001BC80
		internal XmlAtomicValue(XmlSchemaType xmlType, DateTime value)
		{
			do
			{
				base..ctor();
			}
			while (xmlType == null);
			this.xmlType = xmlType;
			this.clrType = TypeCode.DateTime;
			this.unionVal = value;
		}

		// Token: 0x06000AA2 RID: 2722 RVA: 0x0001DAAC File Offset: 0x0001BCAC
		internal XmlAtomicValue(XmlSchemaType xmlType, double value)
		{
			do
			{
				base..ctor();
			}
			while (xmlType == null);
			this.xmlType = xmlType;
			this.clrType = TypeCode.Double;
			this.unionVal.boolVal = value != null;
		}

		// Token: 0x06000AA3 RID: 2723 RVA: 0x0001DAE0 File Offset: 0x0001BCE0
		internal XmlAtomicValue(XmlSchemaType xmlType, int value)
		{
			do
			{
				base..ctor();
			}
			while (xmlType == null);
			this.xmlType = xmlType;
			this.clrType = TypeCode.Int32;
			this.unionVal = value;
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x0001DB0C File Offset: 0x0001BD0C
		internal XmlAtomicValue(XmlSchemaType xmlType, long value)
		{
			do
			{
				base..ctor();
			}
			while (xmlType == null);
			this.xmlType = xmlType;
			this.clrType = TypeCode.Int64;
			this.unionVal = value;
		}

		// Token: 0x06000AA5 RID: 2725 RVA: 0x0001DB38 File Offset: 0x0001BD38
		internal XmlAtomicValue(XmlSchemaType xmlType, string value)
		{
			do
			{
				base..ctor();
				if (value == null)
				{
					return;
				}
			}
			while (xmlType == null);
			this.xmlType = xmlType;
			this.objVal = value;
		}

		// Token: 0x06000AA6 RID: 2726 RVA: 0x0001DB60 File Offset: 0x0001BD60
		internal XmlAtomicValue(XmlSchemaType xmlType, string value, IXmlNamespaceResolver nsResolver)
		{
			do
			{
				base..ctor();
				if (value == null)
				{
					return;
				}
			}
			while (xmlType == null);
			this.xmlType = xmlType;
			this.objVal = value;
			if (nsResolver != null)
			{
				XmlTypeCode typeCode = xmlType.TypeCode;
				XmlSchemaType xmlSchemaType = this.xmlType;
				return;
			}
		}

		// Token: 0x06000AA7 RID: 2727 RVA: 0x0001DB9C File Offset: 0x0001BD9C
		internal XmlAtomicValue(XmlSchemaType xmlType, object value)
		{
			do
			{
				base..ctor();
				if (value == null)
				{
					return;
				}
			}
			while (xmlType == null);
		}

		// Token: 0x06000AA8 RID: 2728 RVA: 0x0001DBB8 File Offset: 0x0001BDB8
		internal XmlAtomicValue(XmlSchemaType xmlType, object value, IXmlNamespaceResolver nsResolver)
		{
			do
			{
				base..ctor();
				if (value == null)
				{
					return;
				}
			}
			while (xmlType == null);
			this.xmlType = xmlType;
			this.objVal = value;
			if (nsResolver != null)
			{
				XmlTypeCode typeCode = xmlType.TypeCode;
				XmlSchemaType xmlSchemaType = this.xmlType;
				object obj = this.objVal;
				return;
			}
		}

		// Token: 0x06000AA9 RID: 2729 RVA: 0x00003FFD File Offset: 0x000021FD
		object ICloneable.Clone()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000AAA RID: 2730 RVA: 0x0001DBFC File Offset: 0x0001BDFC
		public override XmlSchemaType XmlType
		{
			get
			{
				return this.xmlType;
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000AAB RID: 2731 RVA: 0x0001DC10 File Offset: 0x0001BE10
		public override Type ValueType
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000AAB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Type System.Xml.Schema.XmlAtomicValue::get_ValueType()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:XmlSchemaDatatype(var_0_0B, ldfld:XmlSchemaDatatype(XmlSchemaType::datatype, ldfld:XmlSchemaType(XmlAtomicValue::xmlType, ldloc:XmlAtomicValue(this))))
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

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000AAC RID: 2732 RVA: 0x0001DC28 File Offset: 0x0001BE28
		public override object TypedValue
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000AAC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Xml.Schema.XmlAtomicValue::get_TypedValue()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001B:
	stloc:TypeCode(var_2_21, ldfld:TypeCode(XmlAtomicValue::clrType, ldloc:XmlAtomicValue(this)))
	stloc:Union(var_3_28, ldfld:Union(XmlAtomicValue::unionVal, ldloc:XmlAtomicValue(this)))
	stloc:Union(var_4_2F, ldfld:Union(XmlAtomicValue::unionVal, ldloc:XmlAtomicValue(this)))
	stloc:Union(var_5_37, ldfld:Union(XmlAtomicValue::unionVal, ldloc:XmlAtomicValue(this)))
	stloc:bool(var_6_44, ldfld:bool(Union::boolVal, ldfld:Union[exp:valuetype System.Xml.Schema.XmlAtomicValue/Union&](XmlAtomicValue::unionVal, ldloc:XmlAtomicValue(this))))
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

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000AAD RID: 2733 RVA: 0x0001DC7C File Offset: 0x0001BE7C
		public override bool ValueAsBoolean
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000AAD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Xml.Schema.XmlAtomicValue::get_ValueAsBoolean()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0014:
	stloc:TypeCode(var_1_1A, ldfld:TypeCode(XmlAtomicValue::clrType, ldloc:XmlAtomicValue(this)))
	stloc:Union(var_2_21, ldfld:Union(XmlAtomicValue::unionVal, ldloc:XmlAtomicValue(this)))
	stloc:Union(var_3_28, ldfld:Union(XmlAtomicValue::unionVal, ldloc:XmlAtomicValue(this)))
	stloc:Union(var_4_2F, ldfld:Union(XmlAtomicValue::unionVal, ldloc:XmlAtomicValue(this)))
	stloc:bool(var_5_3C, ldfld:bool(Union::boolVal, ldfld:Union[exp:valuetype System.Xml.Schema.XmlAtomicValue/Union&](XmlAtomicValue::unionVal, ldloc:XmlAtomicValue(this))))
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

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000AAE RID: 2734 RVA: 0x0001DCC8 File Offset: 0x0001BEC8
		public override DateTime ValueAsDateTime
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000AAE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.DateTime System.Xml.Schema.XmlAtomicValue::get_ValueAsDateTime()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0014:
	stloc:TypeCode(var_1_1A, ldfld:TypeCode(XmlAtomicValue::clrType, ldloc:XmlAtomicValue(this)))
	stloc:Union(var_2_21, ldfld:Union(XmlAtomicValue::unionVal, ldloc:XmlAtomicValue(this)))
	stloc:Union(var_3_28, ldfld:Union(XmlAtomicValue::unionVal, ldloc:XmlAtomicValue(this)))
	stloc:Union(var_4_2F, ldfld:Union(XmlAtomicValue::unionVal, ldloc:XmlAtomicValue(this)))
	stloc:Union(var_5_37, ldfld:Union(XmlAtomicValue::unionVal, ldloc:XmlAtomicValue(this)))
	stloc:bool(var_6_44, ldfld:bool(Union::boolVal, ldfld:Union[exp:valuetype System.Xml.Schema.XmlAtomicValue/Union&](XmlAtomicValue::unionVal, ldloc:XmlAtomicValue(this))))
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

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000AAF RID: 2735 RVA: 0x0001DD1C File Offset: 0x0001BF1C
		public override double ValueAsDouble
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000AAF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Double System.Xml.Schema.XmlAtomicValue::get_ValueAsDouble()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0014:
	stloc:TypeCode(var_1_1A, ldfld:TypeCode(XmlAtomicValue::clrType, ldloc:XmlAtomicValue(this)))
	stloc:Union(var_2_21, ldfld:Union(XmlAtomicValue::unionVal, ldloc:XmlAtomicValue(this)))
	stloc:Union(var_3_28, ldfld:Union(XmlAtomicValue::unionVal, ldloc:XmlAtomicValue(this)))
	stloc:Union(var_4_2F, ldfld:Union(XmlAtomicValue::unionVal, ldloc:XmlAtomicValue(this)))
	stloc:Union(var_5_37, ldfld:Union(XmlAtomicValue::unionVal, ldloc:XmlAtomicValue(this)))
	stloc:bool(var_6_44, ldfld:bool(Union::boolVal, ldfld:Union[exp:valuetype System.Xml.Schema.XmlAtomicValue/Union&](XmlAtomicValue::unionVal, ldloc:XmlAtomicValue(this))))
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

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000AB0 RID: 2736 RVA: 0x0001DD70 File Offset: 0x0001BF70
		public override int ValueAsInt
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000AB0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Xml.Schema.XmlAtomicValue::get_ValueAsInt()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0014:
	stloc:TypeCode(var_1_1A, ldfld:TypeCode(XmlAtomicValue::clrType, ldloc:XmlAtomicValue(this)))
	stloc:Union(var_2_21, ldfld:Union(XmlAtomicValue::unionVal, ldloc:XmlAtomicValue(this)))
	stloc:Union(var_3_28, ldfld:Union(XmlAtomicValue::unionVal, ldloc:XmlAtomicValue(this)))
	stloc:Union(var_4_2F, ldfld:Union(XmlAtomicValue::unionVal, ldloc:XmlAtomicValue(this)))
	stloc:Union(var_5_37, ldfld:Union(XmlAtomicValue::unionVal, ldloc:XmlAtomicValue(this)))
	stloc:bool(var_6_44, ldfld:bool(Union::boolVal, ldfld:Union[exp:valuetype System.Xml.Schema.XmlAtomicValue/Union&](XmlAtomicValue::unionVal, ldloc:XmlAtomicValue(this))))
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

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000AB1 RID: 2737 RVA: 0x0001DDC4 File Offset: 0x0001BFC4
		public override long ValueAsLong
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000AB1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int64 System.Xml.Schema.XmlAtomicValue::get_ValueAsLong()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0014:
	stloc:TypeCode(var_1_1A, ldfld:TypeCode(XmlAtomicValue::clrType, ldloc:XmlAtomicValue(this)))
	stloc:Union(var_2_21, ldfld:Union(XmlAtomicValue::unionVal, ldloc:XmlAtomicValue(this)))
	stloc:Union(var_3_28, ldfld:Union(XmlAtomicValue::unionVal, ldloc:XmlAtomicValue(this)))
	stloc:Union(var_4_2F, ldfld:Union(XmlAtomicValue::unionVal, ldloc:XmlAtomicValue(this)))
	stloc:Union(var_5_37, ldfld:Union(XmlAtomicValue::unionVal, ldloc:XmlAtomicValue(this)))
	stloc:bool(var_6_44, ldfld:bool(Union::boolVal, ldfld:Union[exp:valuetype System.Xml.Schema.XmlAtomicValue/Union&](XmlAtomicValue::unionVal, ldloc:XmlAtomicValue(this))))
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

		// Token: 0x06000AB2 RID: 2738 RVA: 0x0001DE18 File Offset: 0x0001C018
		public override object ValueAs(Type type, IXmlNamespaceResolver nsResolver)
		{
			/*
An exception occurred when decompiling this method (06000AB2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Xml.Schema.XmlAtomicValue::ValueAs(System.Type,System.Xml.IXmlNamespaceResolver)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0025:
	stloc:TypeCode(var_5_2B, ldfld:TypeCode(XmlAtomicValue::clrType, ldloc:XmlAtomicValue(this)))
	stloc:Union(var_6_33, ldfld:Union(XmlAtomicValue::unionVal, ldloc:XmlAtomicValue(this)))
	stloc:Union(var_7_3B, ldfld:Union(XmlAtomicValue::unionVal, ldloc:XmlAtomicValue(this)))
	stloc:Union(var_8_43, ldfld:Union(XmlAtomicValue::unionVal, ldloc:XmlAtomicValue(this)))
	stloc:Union(var_9_4B, ldfld:Union(XmlAtomicValue::unionVal, ldloc:XmlAtomicValue(this)))
	stloc:bool(var_10_58, ldfld:bool(Union::boolVal, ldfld:Union[exp:valuetype System.Xml.Schema.XmlAtomicValue/Union&](XmlAtomicValue::unionVal, ldloc:XmlAtomicValue(this))))
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

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000AB3 RID: 2739 RVA: 0x0001DE80 File Offset: 0x0001C080
		public override string Value
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000AB3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Xml.Schema.XmlAtomicValue::get_Value()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001B:
	stloc:TypeCode(var_2_21, ldfld:TypeCode(XmlAtomicValue::clrType, ldloc:XmlAtomicValue(this)))
	stloc:Union(var_3_28, ldfld:Union(XmlAtomicValue::unionVal, ldloc:XmlAtomicValue(this)))
	stloc:Union(var_4_2F, ldfld:Union(XmlAtomicValue::unionVal, ldloc:XmlAtomicValue(this)))
	stloc:Union(var_5_37, ldfld:Union(XmlAtomicValue::unionVal, ldloc:XmlAtomicValue(this)))
	stloc:Union(var_6_3F, ldfld:Union(XmlAtomicValue::unionVal, ldloc:XmlAtomicValue(this)))
	stloc:bool(var_7_4C, ldfld:bool(Union::boolVal, ldfld:Union[exp:valuetype System.Xml.Schema.XmlAtomicValue/Union&](XmlAtomicValue::unionVal, ldloc:XmlAtomicValue(this))))
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

		// Token: 0x06000AB4 RID: 2740 RVA: 0x00003FFD File Offset: 0x000021FD
		public override string ToString()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000AB5 RID: 2741 RVA: 0x0001DEDC File Offset: 0x0001C0DC
		private string GetPrefixFromQName(string value)
		{
			if (!true)
			{
			}
			int num;
			string text;
			if (num != 0)
			{
				int stringLength = value._stringLength;
				return text;
			}
			return text;
		}

		// Token: 0x04000563 RID: 1379
		private XmlSchemaType xmlType;

		// Token: 0x04000564 RID: 1380
		private object objVal;

		// Token: 0x04000565 RID: 1381
		private TypeCode clrType;

		// Token: 0x04000566 RID: 1382
		private XmlAtomicValue.Union unionVal;

		// Token: 0x04000567 RID: 1383
		private XmlAtomicValue.NamespacePrefixForQName nsPrefix;

		// Token: 0x02000139 RID: 313
		[StructLayout(2, Pack = 1)]
		private struct Union
		{
			// Token: 0x04000568 RID: 1384
			public bool boolVal;

			// Token: 0x04000569 RID: 1385
			public double dblVal;

			// Token: 0x0400056A RID: 1386
			public long i64Val;

			// Token: 0x0400056B RID: 1387
			public int i32Val;

			// Token: 0x0400056C RID: 1388
			public DateTime dtVal;
		}

		// Token: 0x0200013A RID: 314
		private class NamespacePrefixForQName : IXmlNamespaceResolver
		{
			// Token: 0x06000AB6 RID: 2742 RVA: 0x0001DEFC File Offset: 0x0001C0FC
			public NamespacePrefixForQName(string prefix, string ns)
			{
				this.prefix = prefix;
				this.ns = ns;
			}

			// Token: 0x06000AB7 RID: 2743 RVA: 0x0001DF20 File Offset: 0x0001C120
			public string LookupNamespace(string prefix)
			{
				string text = this.prefix;
				bool flag = prefix == text;
				return this.ns;
			}

			// Token: 0x06000AB8 RID: 2744 RVA: 0x0001DF44 File Offset: 0x0001C144
			public string LookupPrefix(string namespaceName)
			{
				bool flag = this.ns == namespaceName;
				return this.prefix;
			}

			// Token: 0x0400056D RID: 1389
			public string prefix;

			// Token: 0x0400056E RID: 1390
			public string ns;
		}
	}
}
