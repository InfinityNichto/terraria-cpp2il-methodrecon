using System;
using System.Collections;
using System.Collections.Generic;

namespace System.Xml.Schema
{
	// Token: 0x02000167 RID: 359
	internal class XmlListConverter : XmlBaseConverter
	{
		// Token: 0x06000C5E RID: 3166 RVA: 0x00020864 File Offset: 0x0001EA64
		protected XmlListConverter(XmlBaseConverter atomicConverter)
		{
			if (!true)
			{
			}
			base..ctor(atomicConverter);
			this.atomicConverter = atomicConverter;
		}

		// Token: 0x06000C5F RID: 3167 RVA: 0x00020884 File Offset: 0x0001EA84
		protected XmlListConverter(XmlBaseConverter atomicConverter, Type clrTypeDefault)
		{
			if (!true)
			{
			}
			base..ctor(atomicConverter, clrTypeDefault);
			this.atomicConverter = atomicConverter;
		}

		// Token: 0x06000C60 RID: 3168 RVA: 0x000208A4 File Offset: 0x0001EAA4
		protected XmlListConverter(XmlSchemaType schemaType)
		{
			if (!true)
			{
			}
			base..ctor(schemaType);
		}

		// Token: 0x06000C61 RID: 3169 RVA: 0x000208BC File Offset: 0x0001EABC
		public static XmlValueConverter Create(XmlValueConverter atomicConverter)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000C62 RID: 3170 RVA: 0x000208D8 File Offset: 0x0001EAD8
		public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			if (value != null)
			{
			}
			return "value";
		}

		// Token: 0x06000C63 RID: 3171 RVA: 0x000208F0 File Offset: 0x0001EAF0
		protected override object ChangeListType(object value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			Type type = value.GetType();
			Type clrTypeDefault = this.clrTypeDefault;
			if (value != null)
			{
				bool flag = clrTypeDefault == clrTypeDefault;
				bool flag2 = type == clrTypeDefault;
				return value;
			}
			Type type2;
			Exception ex = this.CreateInvalidClrMappingException(type, type2);
			throw new InvalidCastException();
		}

		// Token: 0x06000C64 RID: 3172 RVA: 0x00020994 File Offset: 0x0001EB94
		private bool IsListType(Type type)
		{
			if (!true)
			{
			}
			return true;
		}

		// Token: 0x06000C65 RID: 3173 RVA: 0x000209AC File Offset: 0x0001EBAC
		private T[] ToArray<T>(object cpp2il__autoParamName__idx_1, IXmlNamespaceResolver cpp2il__autoParamName__idx_2)
		{
			if (cpp2il__autoParamName__idx_1 != null)
			{
			}
			XmlValueConverter xmlValueConverter = this.atomicConverter;
			XmlValueConverter xmlValueConverter2 = this.atomicConverter;
			long num = 0L;
			int num2 = 7;
			if (num == 0L)
			{
				if (num2 == 0)
				{
				}
				throw new InvalidCastException();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000C66 RID: 3174 RVA: 0x000209F4 File Offset: 0x0001EBF4
		private IList ToList(object list, IXmlNamespaceResolver nsResolver)
		{
			if (list != null)
			{
			}
			XmlValueConverter xmlValueConverter = this.atomicConverter;
			if (xmlValueConverter == null || xmlValueConverter != null)
			{
				XmlValueConverter xmlValueConverter2 = this.atomicConverter;
				long num = 0L;
				if (list != null)
				{
				}
				if (num != 0L)
				{
					throw new OutOfMemoryException();
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000C67 RID: 3175 RVA: 0x00020A40 File Offset: 0x0001EC40
		private List<string> StringAsList(string value)
		{
			/*
An exception occurred when decompiling this method (06000C67)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.List`1<System.String> System.Xml.Schema.XmlListConverter::StringAsList(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:string[](var_0_09, call:string[](XmlConvert::SplitString, ldloc:string(value)))
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

		// Token: 0x06000C68 RID: 3176 RVA: 0x00020A58 File Offset: 0x0001EC58
		private string ListAsString(IEnumerable list, IXmlNamespaceResolver nsResolver)
		{
			while (list == null)
			{
			}
			int num;
			if (num != 0)
			{
			}
			XmlValueConverter xmlValueConverter = this.atomicConverter;
			long num2 = 0L;
			int num3 = 5;
			if (list != null)
			{
			}
			if (num2 != 0L || num3 == 0)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000C69 RID: 3177 RVA: 0x00020A9C File Offset: 0x0001EC9C
		private new Exception CreateInvalidClrMappingException(Type sourceType, Type destinationType)
		{
			if (!true)
			{
			}
			bool flag = sourceType == destinationType;
			string xmlTypeName = base.XmlTypeName;
			if ((xmlTypeName == null || xmlTypeName != null) && (sourceType == null || sourceType != null))
			{
				string xmlTypeName2 = base.XmlTypeName;
				if ((xmlTypeName2 != null && xmlTypeName2 == null) || (sourceType != null && sourceType == null) || xmlTypeName == null || xmlTypeName != null)
				{
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0400062F RID: 1583
		protected XmlValueConverter atomicConverter;
	}
}
