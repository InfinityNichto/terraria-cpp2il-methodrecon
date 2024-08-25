using System;
using System.Globalization;

namespace System.ComponentModel
{
	// Token: 0x020003C3 RID: 963
	public abstract class TypeListConverter : TypeConverter
	{
		// Token: 0x0600199A RID: 6554 RVA: 0x00047600 File Offset: 0x00045800
		protected TypeListConverter(Type[] types)
		{
			this._types = types;
		}

		// Token: 0x0600199B RID: 6555 RVA: 0x0004761C File Offset: 0x0004581C
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			if (!true)
			{
			}
			Type type;
			bool flag = sourceType == type;
			return true;
		}

		// Token: 0x0600199C RID: 6556 RVA: 0x00047640 File Offset: 0x00045840
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			if (!true)
			{
			}
			Type type;
			bool flag = destinationType == type;
			return true;
		}

		// Token: 0x0600199D RID: 6557 RVA: 0x00047664 File Offset: 0x00045864
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			if (value != null)
			{
			}
			return base.ConvertFrom(context, culture, value);
		}

		// Token: 0x0600199E RID: 6558 RVA: 0x00047688 File Offset: 0x00045888
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (!true)
			{
			}
			Type type;
			bool flag = destinationType == type;
			if (value != null)
			{
				return value;
			}
			return "(none)";
		}

		// Token: 0x0600199F RID: 6559 RVA: 0x000476C0 File Offset: 0x000458C0
		public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
		{
			/*
An exception occurred when decompiling this method (0600199F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.ComponentModel.TypeConverter/StandardValuesCollection System.ComponentModel.TypeListConverter::GetStandardValues(System.ComponentModel.ITypeDescriptorContext)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_1:
	stloc:class [mscorlib]System.Type[](var_0_16, ldfld:class [mscorlib]System.Type[](TypeListConverter::_types, ldloc:TypeListConverter(this)))
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

		// Token: 0x060019A0 RID: 6560 RVA: 0x000476E4 File Offset: 0x000458E4
		public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
		{
			return true;
		}

		// Token: 0x060019A1 RID: 6561 RVA: 0x000476F4 File Offset: 0x000458F4
		public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
		{
			return true;
		}

		// Token: 0x040012D8 RID: 4824
		private readonly Type[] _types;

		// Token: 0x040012D9 RID: 4825
		private TypeConverter.StandardValuesCollection _values;
	}
}
