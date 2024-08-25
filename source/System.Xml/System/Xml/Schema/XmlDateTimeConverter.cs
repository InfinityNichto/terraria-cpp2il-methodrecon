using System;
using Cpp2IlInjected;

namespace System.Xml.Schema
{
	// Token: 0x02000160 RID: 352
	internal class XmlDateTimeConverter : XmlBaseConverter
	{
		// Token: 0x06000BFB RID: 3067 RVA: 0x0001F9A4 File Offset: 0x0001DBA4
		protected XmlDateTimeConverter(XmlSchemaType schemaType)
		{
			if (!true)
			{
			}
			base..ctor(schemaType);
		}

		// Token: 0x06000BFC RID: 3068 RVA: 0x00003FFD File Offset: 0x000021FD
		public static XmlValueConverter Create(XmlSchemaType schemaType)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000BFD RID: 3069 RVA: 0x0001F9BC File Offset: 0x0001DBBC
		public override DateTime ToDateTime(DateTimeOffset value)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06000BFE RID: 3070 RVA: 0x0001F9D0 File Offset: 0x0001DBD0
		public override DateTime ToDateTime(string value)
		{
			/*
An exception occurred when decompiling this method (06000BFE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.DateTime System.Xml.Schema.XmlDateTimeConverter::ToDateTime(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:XmlTypeCode(var_0_09, ldfld:XmlTypeCode(XmlBaseConverter::typeCode, ldloc:XmlDateTimeConverter[exp:XmlBaseConverter](this)))
	stloc:DateTime(var_1_10, call:DateTime(XmlBaseConverter::StringToTime, ldloc:string(value)))
	stloc:DateTime(var_2_17, call:DateTime(XmlBaseConverter::StringToGMonthDay, ldloc:string(value)))
	stloc:DateTime(var_3_1E, call:DateTime(XmlBaseConverter::StringToGYearMonth, ldloc:string(value)))
	stloc:DateTime(var_4_25, call:DateTime(XmlBaseConverter::StringToDateTime, ldloc:string(value)))
	stloc:DateTime(var_5_2D, call:DateTime(XmlBaseConverter::StringToDate, ldloc:string(value)))
	stloc:DateTime(var_6_35, call:DateTime(XmlBaseConverter::StringToGYear, ldloc:string(value)))
	stloc:DateTime(var_7_3D, call:DateTime(XmlBaseConverter::StringToGDay, ldloc:string(value)))
	stloc:DateTime(var_8_45, call:DateTime(XmlBaseConverter::StringToGMonth, ldloc:string(value)))
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

		// Token: 0x06000BFF RID: 3071 RVA: 0x0001FA24 File Offset: 0x0001DC24
		public override DateTime ToDateTime(object value)
		{
			if (value != null)
			{
				Type type = value.GetType();
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000C00 RID: 3072 RVA: 0x0001FA40 File Offset: 0x0001DC40
		public override DateTimeOffset ToDateTimeOffset(DateTime value)
		{
			DateTimeOffset dateTimeOffset;
			return dateTimeOffset;
		}

		// Token: 0x06000C01 RID: 3073 RVA: 0x0001FA50 File Offset: 0x0001DC50
		public override DateTimeOffset ToDateTimeOffset(string value)
		{
			/*
An exception occurred when decompiling this method (06000C01)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.DateTimeOffset System.Xml.Schema.XmlDateTimeConverter::ToDateTimeOffset(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:XmlTypeCode(var_0_09, ldfld:XmlTypeCode(XmlBaseConverter::typeCode, ldloc:XmlDateTimeConverter[exp:XmlBaseConverter](this)))
	stloc:DateTimeOffset(var_1_10, call:DateTimeOffset(XmlBaseConverter::StringToTimeOffset, ldloc:string(value)))
	stloc:DateTimeOffset(var_2_17, call:DateTimeOffset(XmlBaseConverter::StringToGMonthDayOffset, ldloc:string(value)))
	stloc:DateTimeOffset(var_3_1E, call:DateTimeOffset(XmlBaseConverter::StringToGYearMonthOffset, ldloc:string(value)))
	stloc:DateTimeOffset(var_4_25, call:DateTimeOffset(XmlBaseConverter::StringToDateTimeOffset, ldloc:string(value)))
	stloc:DateTimeOffset(var_5_2D, call:DateTimeOffset(XmlBaseConverter::StringToDateOffset, ldloc:string(value)))
	stloc:DateTimeOffset(var_6_35, call:DateTimeOffset(XmlBaseConverter::StringToGYearOffset, ldloc:string(value)))
	stloc:DateTimeOffset(var_7_3D, call:DateTimeOffset(XmlBaseConverter::StringToGDayOffset, ldloc:string(value)))
	stloc:DateTimeOffset(var_8_45, call:DateTimeOffset(XmlBaseConverter::StringToGMonthOffset, ldloc:string(value)))
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

		// Token: 0x06000C02 RID: 3074 RVA: 0x0001FAA4 File Offset: 0x0001DCA4
		public override DateTimeOffset ToDateTimeOffset(object value)
		{
			if (value != null)
			{
				Type type = value.GetType();
				if (value == null)
				{
				}
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000C03 RID: 3075 RVA: 0x0001FAC4 File Offset: 0x0001DCC4
		public override string ToString(DateTime value)
		{
			XmlTypeCode typeCode = this.typeCode;
			return XmlBaseConverter.TimeToString(value);
		}

		// Token: 0x06000C04 RID: 3076 RVA: 0x0001FB10 File Offset: 0x0001DD10
		public override string ToString(DateTimeOffset value)
		{
			XmlTypeCode typeCode = this.typeCode;
			return XmlBaseConverter.TimeOffsetToString(value);
		}

		// Token: 0x06000C05 RID: 3077 RVA: 0x0001FB5C File Offset: 0x0001DD5C
		public override string ToString(object value, IXmlNamespaceResolver nsResolver)
		{
			if (value != null)
			{
				Type type = value.GetType();
				if (this != null)
				{
				}
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000C06 RID: 3078 RVA: 0x0001FB7C File Offset: 0x0001DD7C
		public override object ChangeType(DateTime value, Type destinationType)
		{
			/*
An exception occurred when decompiling this method (06000C06)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Xml.Schema.XmlDateTimeConverter::ChangeType(System.DateTime,System.Type)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0006:
	stloc:Type(var_2_0C, ldfld:Type(XmlBaseConverter::clrTypeDefault, ldloc:XmlDateTimeConverter[exp:XmlBaseConverter](this)))
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

		// Token: 0x06000C07 RID: 3079 RVA: 0x0001FB98 File Offset: 0x0001DD98
		public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			if (value != null)
			{
				if (!true)
				{
				}
				if (!true)
				{
				}
				Type clrTypeDefault = this.clrTypeDefault;
				XmlSchemaType schemaType = this.schemaType;
			}
			return "value";
		}

		// Token: 0x06000C08 RID: 3080 RVA: 0x0001FBC4 File Offset: 0x0001DDC4
		public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			if (value != null)
			{
				if (!true)
				{
				}
				Type type = value.GetType();
				Type clrTypeDefault = this.clrTypeDefault;
				XmlSchemaDerivationMethod final = this.schemaType.final;
				throw new InvalidCastException();
			}
			return "value";
		}
	}
}
