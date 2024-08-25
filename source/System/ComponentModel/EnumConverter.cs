using System;
using System.Collections;
using System.Globalization;
using System.Reflection;

namespace System.ComponentModel
{
	// Token: 0x020003E2 RID: 994
	public class EnumConverter : TypeConverter
	{
		// Token: 0x06001A41 RID: 6721 RVA: 0x000489D0 File Offset: 0x00046BD0
		public EnumConverter(Type type)
		{
			this.type = type;
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x06001A42 RID: 6722 RVA: 0x000489EC File Offset: 0x00046BEC
		protected Type EnumType
		{
			get
			{
				return this.type;
			}
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x06001A43 RID: 6723 RVA: 0x00048A00 File Offset: 0x00046C00
		// (set) Token: 0x06001A44 RID: 6724 RVA: 0x00048A14 File Offset: 0x00046C14
		protected TypeConverter.StandardValuesCollection Values
		{
			get
			{
				return this.values;
			}
			set
			{
				this.values = value;
			}
		}

		// Token: 0x06001A45 RID: 6725 RVA: 0x00048A28 File Offset: 0x00046C28
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			if (!true)
			{
			}
			Type type;
			bool flag = sourceType == type;
			Type type2;
			bool flag2 = sourceType == type2;
			return true;
		}

		// Token: 0x06001A46 RID: 6726 RVA: 0x00048A4C File Offset: 0x00046C4C
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			if (!true)
			{
			}
			Type type;
			bool flag = destinationType == type;
			Type type2;
			bool flag2 = destinationType == type2;
			return true;
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x06001A47 RID: 6727 RVA: 0x00048A70 File Offset: 0x00046C70
		protected virtual IComparer Comparer
		{
			get
			{
				if (!true)
				{
				}
				return 1;
			}
		}

		// Token: 0x06001A48 RID: 6728 RVA: 0x00048A84 File Offset: 0x00046C84
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			if (value != null)
			{
			}
			if (value == null)
			{
				object obj;
				return obj;
			}
			if (value != null && value == null)
			{
				throw new InvalidCastException();
			}
			string[] array;
			long num = Convert.ToInt64(array, culture);
			object obj2;
			return obj2;
		}

		// Token: 0x06001A49 RID: 6729 RVA: 0x00048B24 File Offset: 0x00046D24
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (!true)
			{
			}
			Type type;
			bool flag = type == type;
			if (value != null)
			{
				Type underlyingType = Enum.GetUnderlyingType(this.type);
				Type type2;
				FieldInfo fieldInfo;
				if (value != null)
				{
					bool flag2 = value.GetType() != underlyingType;
					if (value == null)
					{
						throw new InvalidCastException();
					}
					if (value != null)
					{
						return value;
					}
					goto IL_012C;
				}
				else if ((type2 != null && type2 == null) || (fieldInfo != null && fieldInfo == null) || (value != null && value == null))
				{
					throw new ArrayTypeMismatchException();
				}
			}
			else
			{
				Type underlyingType;
				Type type3;
				bool flag3 = underlyingType == type3;
				if (value != null)
				{
					Type type4 = this.type;
					int num = 44;
					string text;
					int num2 = text.IndexOf((char)num);
					Type underlyingType2 = Enum.GetUnderlyingType(this.type);
					if (value != null)
					{
						if (value == null)
						{
							goto IL_012C;
						}
						if (value != null)
						{
							return value;
						}
						throw new InvalidCastException();
					}
				}
			}
			Array array;
			int length = array.Length;
			int length2 = array.Length;
			long num3 = 0L;
			object value2 = array.GetValue((int)num3);
			if (value2 == null)
			{
				return value2;
			}
			int length3 = array.Length;
			int num4 = 1;
			long num5;
			while (num5 != 0L)
			{
			}
			if (num4 == 0)
			{
			}
			object obj;
			if (obj != null)
			{
			}
			return obj;
			IL_012C:
			throw new InvalidCastException();
		}

		// Token: 0x06001A4A RID: 6730 RVA: 0x00048C74 File Offset: 0x00046E74
		public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
		{
			if (this.values == null)
			{
				Type reflectionType = TypeDescriptor.GetReflectionType(this.type);
				Type type = this.type;
				if (type != null)
				{
					long num = 0L;
					Type type2;
					if (type2 != null)
					{
					}
					if ((!false || num != 0L) && type2 != null)
					{
						Type type3 = this.type;
						if (num == 0L)
						{
						}
						object obj;
						if (obj != null)
						{
						}
					}
				}
				if (this != null)
				{
				}
			}
			throw new InvalidCastException();
		}

		// Token: 0x06001A4B RID: 6731 RVA: 0x00048CD4 File Offset: 0x00046ED4
		public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
		{
			/*
An exception occurred when decompiling this method (06001A4B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.ComponentModel.EnumConverter::GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	stloc:Type(var_0_06, ldfld:Type(EnumConverter::type, ldloc:EnumConverter(this)))
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

		// Token: 0x06001A4C RID: 6732 RVA: 0x00048CEC File Offset: 0x00046EEC
		public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
		{
			return true;
		}

		// Token: 0x06001A4D RID: 6733 RVA: 0x00048CFC File Offset: 0x00046EFC
		public override bool IsValid(ITypeDescriptorContext context, object value)
		{
			Type type = this.type;
			if (!true)
			{
			}
			return Enum.IsDefined(type, value);
		}

		// Token: 0x04001309 RID: 4873
		private TypeConverter.StandardValuesCollection values;

		// Token: 0x0400130A RID: 4874
		private Type type;
	}
}
