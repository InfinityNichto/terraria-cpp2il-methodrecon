using System;
using Cpp2IlInjected;

namespace System.Xml.Schema
{
	// Token: 0x0200015E RID: 350
	internal class XmlNumeric10Converter : XmlBaseConverter
	{
		// Token: 0x06000BD9 RID: 3033 RVA: 0x0001F544 File Offset: 0x0001D744
		protected XmlNumeric10Converter(XmlSchemaType schemaType)
		{
			if (!true)
			{
			}
			base..ctor(schemaType);
		}

		// Token: 0x06000BDA RID: 3034 RVA: 0x00003FFD File Offset: 0x000021FD
		public static XmlValueConverter Create(XmlSchemaType schemaType)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000BDB RID: 3035 RVA: 0x0001F55C File Offset: 0x0001D75C
		public override decimal ToDecimal(string value)
		{
			/*
An exception occurred when decompiling this method (06000BDB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Decimal System.Xml.Schema.XmlNumeric10Converter::ToDecimal(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:XmlTypeCode(var_0_09, ldfld:XmlTypeCode(XmlBaseConverter::typeCode, ldloc:XmlNumeric10Converter[exp:XmlBaseConverter](this)))
	stloc:Decimal(var_1_10, call:Decimal(XmlConvert::ToDecimal, ldloc:string(value)))
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

		// Token: 0x06000BDC RID: 3036 RVA: 0x0001F57C File Offset: 0x0001D77C
		public override decimal ToDecimal(object value)
		{
			if (value != null)
			{
				Type type = value.GetType();
				if (value == null)
				{
				}
				throw new InvalidCastException();
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000BDD RID: 3037 RVA: 0x0001F5A4 File Offset: 0x0001D7A4
		public override int ToInt32(long value)
		{
			if (!true)
			{
			}
			return XmlBaseConverter.Int64ToInt32(value);
		}

		// Token: 0x06000BDE RID: 3038 RVA: 0x0001F5BC File Offset: 0x0001D7BC
		public override int ToInt32(string value)
		{
			while (value == null)
			{
			}
			XmlTypeCode typeCode = this.typeCode;
			return XmlBaseConverter.DecimalToInt32(XmlConvert.ToDecimal(value));
		}

		// Token: 0x06000BDF RID: 3039 RVA: 0x0001F5E0 File Offset: 0x0001D7E0
		public override int ToInt32(object value)
		{
			if (value != null)
			{
				Type type = value.GetType();
				int num;
				return num;
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000BE0 RID: 3040 RVA: 0x00003FFD File Offset: 0x000021FD
		public override long ToInt64(int value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000BE1 RID: 3041 RVA: 0x0001F604 File Offset: 0x0001D804
		public override long ToInt64(string value)
		{
			while (value == null)
			{
			}
			XmlTypeCode typeCode = this.typeCode;
			return XmlBaseConverter.DecimalToInt64(XmlConvert.ToDecimal(value));
		}

		// Token: 0x06000BE2 RID: 3042 RVA: 0x0001F628 File Offset: 0x0001D828
		public override long ToInt64(object value)
		{
			if (value != null)
			{
				Type type = value.GetType();
				long num;
				return num;
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000BE3 RID: 3043 RVA: 0x0001F648 File Offset: 0x0001D848
		public override string ToString(decimal value)
		{
			XmlTypeCode typeCode = this.typeCode;
			return XmlConvert.ToString(decimal.Truncate(value));
		}

		// Token: 0x06000BE4 RID: 3044 RVA: 0x0001F668 File Offset: 0x0001D868
		public override string ToString(int value)
		{
			if (!true)
			{
			}
			return XmlConvert.ToString(value);
		}

		// Token: 0x06000BE5 RID: 3045 RVA: 0x0001F680 File Offset: 0x0001D880
		public override string ToString(long value)
		{
			if (!true)
			{
			}
			return XmlConvert.ToString(value);
		}

		// Token: 0x06000BE6 RID: 3046 RVA: 0x0001F698 File Offset: 0x0001D898
		public override string ToString(object value, IXmlNamespaceResolver nsResolver)
		{
			if (value != null)
			{
				Type type = value.GetType();
				string text;
				return text;
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000BE7 RID: 3047 RVA: 0x0001F6C0 File Offset: 0x0001D8C0
		public override object ChangeType(decimal value, Type destinationType)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			Type clrTypeDefault = this.clrTypeDefault;
			int num = XmlBaseConverter.DecimalToInt32(value);
			long num2 = XmlBaseConverter.DecimalToInt64(value);
			object obj;
			return obj;
		}

		// Token: 0x06000BE8 RID: 3048 RVA: 0x0001F6EC File Offset: 0x0001D8EC
		public override object ChangeType(int value, Type destinationType)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			Type clrTypeDefault = this.clrTypeDefault;
			decimal num = value;
			string text = XmlConvert.ToString(value);
			XmlSchemaType schemaType = this.schemaType;
			object obj;
			return obj;
		}

		// Token: 0x06000BE9 RID: 3049 RVA: 0x0001F720 File Offset: 0x0001D920
		public override object ChangeType(long value, Type destinationType)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			Type clrTypeDefault = this.clrTypeDefault;
			decimal num = value;
			int num2 = XmlBaseConverter.Int64ToInt32(value);
			string text = XmlConvert.ToString(value);
			XmlSchemaType schemaType = this.schemaType;
			object obj;
			return obj;
		}

		// Token: 0x06000BEA RID: 3050 RVA: 0x0001F75C File Offset: 0x0001D95C
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

		// Token: 0x06000BEB RID: 3051 RVA: 0x0001F788 File Offset: 0x0001D988
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
			}
			return "value";
		}

		// Token: 0x06000BEC RID: 3052 RVA: 0x0001F7C4 File Offset: 0x0001D9C4
		private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			Type type = value.GetType();
			return value;
		}

		// Token: 0x06000BED RID: 3053 RVA: 0x0001F7E4 File Offset: 0x0001D9E4
		private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			/*
An exception occurred when decompiling this method (06000BED)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Xml.Schema.XmlNumeric10Converter::ChangeTypeWildcardSource(System.Object,System.Type,System.Xml.IXmlNamespaceResolver)

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
}
