using System;
using Cpp2IlInjected;

namespace System.Xml.Schema
{
	// Token: 0x02000161 RID: 353
	internal class XmlBooleanConverter : XmlBaseConverter
	{
		// Token: 0x06000C09 RID: 3081 RVA: 0x0001FC00 File Offset: 0x0001DE00
		protected XmlBooleanConverter(XmlSchemaType schemaType)
		{
			if (!true)
			{
			}
			base..ctor(schemaType);
		}

		// Token: 0x06000C0A RID: 3082 RVA: 0x00003FFD File Offset: 0x000021FD
		public static XmlValueConverter Create(XmlSchemaType schemaType)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000C0B RID: 3083 RVA: 0x0001FC18 File Offset: 0x0001DE18
		public override bool ToBoolean(string value)
		{
			while (value == null)
			{
			}
			return XmlConvert.ToBoolean(value);
		}

		// Token: 0x06000C0C RID: 3084 RVA: 0x0001FC30 File Offset: 0x0001DE30
		public override bool ToBoolean(object value)
		{
			if (value != null)
			{
				Type type = value.GetType();
				bool flag;
				return flag;
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000C0D RID: 3085 RVA: 0x0001FC50 File Offset: 0x0001DE50
		public override string ToString(bool value)
		{
			if (!true)
			{
			}
			return XmlConvert.ToString(true);
		}

		// Token: 0x06000C0E RID: 3086 RVA: 0x0001FC68 File Offset: 0x0001DE68
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

		// Token: 0x06000C0F RID: 3087 RVA: 0x0001FC8C File Offset: 0x0001DE8C
		public override object ChangeType(bool value, Type destinationType)
		{
			/*
An exception occurred when decompiling this method (06000C0F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Xml.Schema.XmlBooleanConverter::ChangeType(System.Boolean,System.Type)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0018:
	stloc:XmlSchemaType(var_9_21, ldfld:XmlSchemaType(XmlBaseConverter::schemaType, ldloc:XmlBooleanConverter[exp:XmlBaseConverter](this)))
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

		// Token: 0x06000C10 RID: 3088 RVA: 0x0001FCBC File Offset: 0x0001DEBC
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
				bool flag = XmlConvert.ToBoolean(value);
				XmlSchemaType schemaType = this.schemaType;
			}
			return "value";
		}

		// Token: 0x06000C11 RID: 3089 RVA: 0x0001FCF0 File Offset: 0x0001DEF0
		public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			if (value != null)
			{
				if (!true)
				{
				}
				Type type = value.GetType();
				return 1;
			}
			return "value";
		}
	}
}
