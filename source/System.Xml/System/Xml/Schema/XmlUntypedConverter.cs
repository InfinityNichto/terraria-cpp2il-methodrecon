using System;

namespace System.Xml.Schema
{
	// Token: 0x02000164 RID: 356
	internal class XmlUntypedConverter : XmlListConverter
	{
		// Token: 0x06000C1E RID: 3102 RVA: 0x0001FF70 File Offset: 0x0001E170
		protected XmlUntypedConverter()
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x06000C1F RID: 3103 RVA: 0x0001FF84 File Offset: 0x0001E184
		protected XmlUntypedConverter(XmlUntypedConverter atomicConverter, bool allowListToList)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06000C20 RID: 3104 RVA: 0x0001FF94 File Offset: 0x0001E194
		public override bool ToBoolean(string value)
		{
			while (value == null)
			{
			}
			return XmlConvert.ToBoolean(value);
		}

		// Token: 0x06000C21 RID: 3105 RVA: 0x0001FFAC File Offset: 0x0001E1AC
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

		// Token: 0x06000C22 RID: 3106 RVA: 0x0001FFCC File Offset: 0x0001E1CC
		public override DateTime ToDateTime(string value)
		{
			/*
An exception occurred when decompiling this method (06000C22)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.DateTime System.Xml.Schema.XmlUntypedConverter::ToDateTime(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:DateTime(var_0_09, call:DateTime(XmlBaseConverter::UntypedAtomicToDateTime, ldloc:string(value)))
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

		// Token: 0x06000C23 RID: 3107 RVA: 0x0001FFE4 File Offset: 0x0001E1E4
		public override DateTime ToDateTime(object value)
		{
			if (value != null)
			{
				Type type = value.GetType();
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000C24 RID: 3108 RVA: 0x00020000 File Offset: 0x0001E200
		public override DateTimeOffset ToDateTimeOffset(string value)
		{
			/*
An exception occurred when decompiling this method (06000C24)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.DateTimeOffset System.Xml.Schema.XmlUntypedConverter::ToDateTimeOffset(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:DateTimeOffset(var_0_09, call:DateTimeOffset(XmlBaseConverter::UntypedAtomicToDateTimeOffset, ldloc:string(value)))
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

		// Token: 0x06000C25 RID: 3109 RVA: 0x00020018 File Offset: 0x0001E218
		public override DateTimeOffset ToDateTimeOffset(object value)
		{
			if (value != null)
			{
				Type type = value.GetType();
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000C26 RID: 3110 RVA: 0x00020034 File Offset: 0x0001E234
		public override decimal ToDecimal(string value)
		{
			/*
An exception occurred when decompiling this method (06000C26)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Decimal System.Xml.Schema.XmlUntypedConverter::ToDecimal(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Decimal(var_0_09, call:Decimal(XmlConvert::ToDecimal, ldloc:string(value)))
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

		// Token: 0x06000C27 RID: 3111 RVA: 0x0002004C File Offset: 0x0001E24C
		public override decimal ToDecimal(object value)
		{
			if (value != null)
			{
				Type type = value.GetType();
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000C28 RID: 3112 RVA: 0x00020068 File Offset: 0x0001E268
		public override double ToDouble(string value)
		{
			/*
An exception occurred when decompiling this method (06000C28)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Double System.Xml.Schema.XmlUntypedConverter::ToDouble(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float64(var_0_09, call:float64(XmlConvert::ToDouble, ldloc:string(value)))
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

		// Token: 0x06000C29 RID: 3113 RVA: 0x00020080 File Offset: 0x0001E280
		public override double ToDouble(object value)
		{
			if (value != null)
			{
				Type type = value.GetType();
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000C2A RID: 3114 RVA: 0x0002009C File Offset: 0x0001E29C
		public override int ToInt32(string value)
		{
			while (value == null)
			{
			}
			return XmlConvert.ToInt32(value);
		}

		// Token: 0x06000C2B RID: 3115 RVA: 0x000200B4 File Offset: 0x0001E2B4
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

		// Token: 0x06000C2C RID: 3116 RVA: 0x000200D4 File Offset: 0x0001E2D4
		public override long ToInt64(string value)
		{
			while (value == null)
			{
			}
			return XmlConvert.ToInt64(value);
		}

		// Token: 0x06000C2D RID: 3117 RVA: 0x000200EC File Offset: 0x0001E2EC
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

		// Token: 0x06000C2E RID: 3118 RVA: 0x0002010C File Offset: 0x0001E30C
		public override float ToSingle(string value)
		{
			/*
An exception occurred when decompiling this method (06000C2E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single System.Xml.Schema.XmlUntypedConverter::ToSingle(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_09, call:float32(XmlConvert::ToSingle, ldloc:string(value)))
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

		// Token: 0x06000C2F RID: 3119 RVA: 0x00020124 File Offset: 0x0001E324
		public override float ToSingle(object value)
		{
			if (value != null)
			{
				Type type = value.GetType();
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000C30 RID: 3120 RVA: 0x00020140 File Offset: 0x0001E340
		public override string ToString(bool value)
		{
			if (!true)
			{
			}
			return XmlConvert.ToString(true);
		}

		// Token: 0x06000C31 RID: 3121 RVA: 0x00020158 File Offset: 0x0001E358
		public override string ToString(DateTime value)
		{
			if (!true)
			{
			}
			string text;
			return text;
		}

		// Token: 0x06000C32 RID: 3122 RVA: 0x0002016C File Offset: 0x0001E36C
		public override string ToString(DateTimeOffset value)
		{
			if (!true)
			{
			}
			return XmlBaseConverter.DateTimeOffsetToString(value);
		}

		// Token: 0x06000C33 RID: 3123 RVA: 0x00020184 File Offset: 0x0001E384
		public override string ToString(decimal value)
		{
			if (!true)
			{
			}
			return XmlConvert.ToString(value);
		}

		// Token: 0x06000C34 RID: 3124 RVA: 0x0002019C File Offset: 0x0001E39C
		public override string ToString(double value)
		{
			if (!true)
			{
			}
			return XmlConvert.ToString(value);
		}

		// Token: 0x06000C35 RID: 3125 RVA: 0x000201B4 File Offset: 0x0001E3B4
		public override string ToString(int value)
		{
			if (!true)
			{
			}
			return XmlConvert.ToString(value);
		}

		// Token: 0x06000C36 RID: 3126 RVA: 0x000201CC File Offset: 0x0001E3CC
		public override string ToString(long value)
		{
			if (!true)
			{
			}
			return XmlConvert.ToString(value);
		}

		// Token: 0x06000C37 RID: 3127 RVA: 0x000201E4 File Offset: 0x0001E3E4
		public override string ToString(float value)
		{
			if (!true)
			{
			}
			return XmlConvert.ToString(value);
		}

		// Token: 0x06000C38 RID: 3128 RVA: 0x000201FC File Offset: 0x0001E3FC
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

		// Token: 0x06000C39 RID: 3129 RVA: 0x00020260 File Offset: 0x0001E460
		public override object ChangeType(bool value, Type destinationType)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			Type clrTypeDefault = this.clrTypeDefault;
			string text = XmlConvert.ToString(true);
			object obj;
			return obj;
		}

		// Token: 0x06000C3A RID: 3130 RVA: 0x00020284 File Offset: 0x0001E484
		public override object ChangeType(DateTime value, Type destinationType)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			Type clrTypeDefault = this.clrTypeDefault;
			string text = XmlBaseConverter.DateTimeToString(value);
			object obj;
			return obj;
		}

		// Token: 0x06000C3B RID: 3131 RVA: 0x000202A8 File Offset: 0x0001E4A8
		public override object ChangeType(decimal value, Type destinationType)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			Type clrTypeDefault = this.clrTypeDefault;
			string text = XmlConvert.ToString(value);
			object obj;
			return obj;
		}

		// Token: 0x06000C3C RID: 3132 RVA: 0x000202CC File Offset: 0x0001E4CC
		public override object ChangeType(double value, Type destinationType)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			Type clrTypeDefault = this.clrTypeDefault;
			string text = XmlConvert.ToString(value);
			object obj;
			return obj;
		}

		// Token: 0x06000C3D RID: 3133 RVA: 0x000202F4 File Offset: 0x0001E4F4
		public override object ChangeType(int value, Type destinationType)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			Type clrTypeDefault = this.clrTypeDefault;
			string text = XmlConvert.ToString(value);
			object obj;
			return obj;
		}

		// Token: 0x06000C3E RID: 3134 RVA: 0x00020318 File Offset: 0x0001E518
		public override object ChangeType(long value, Type destinationType)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			Type clrTypeDefault = this.clrTypeDefault;
			string text = XmlConvert.ToString(value);
			object obj;
			return obj;
		}

		// Token: 0x06000C3F RID: 3135 RVA: 0x0002033C File Offset: 0x0001E53C
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
				byte b = XmlBaseConverter.Int32ToByte(XmlConvert.ToInt32(value));
				int num2;
				short num = XmlBaseConverter.Int32ToInt16(num2);
				int num3;
				sbyte b2 = XmlBaseConverter.Int32ToSByte(num3);
				int num5;
				ushort num4 = XmlBaseConverter.Int32ToUInt16(num5);
				long num7;
				uint num6 = XmlBaseConverter.Int64ToUInt32(num7);
				decimal num9;
				ulong num8 = XmlBaseConverter.DecimalToUInt64(num9);
				XmlSchemaType schemaType = this.schemaType;
				object obj;
				return obj;
			}
			return "value";
		}

		// Token: 0x06000C40 RID: 3136 RVA: 0x000203AC File Offset: 0x0001E5AC
		public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			if (!true)
			{
			}
			Type type = value.GetType();
			int num;
			byte b = XmlBaseConverter.Int32ToByte(num);
			int num3;
			short num2 = XmlBaseConverter.Int32ToInt16(num3);
			int num4;
			sbyte b2 = XmlBaseConverter.Int32ToSByte(num4);
			int num6;
			ushort num5 = XmlBaseConverter.Int32ToUInt16(num6);
			long num8;
			uint num7 = XmlBaseConverter.Int64ToUInt32(num8);
			decimal num10;
			ulong num9 = XmlBaseConverter.DecimalToUInt64(num10);
			throw new InvalidCastException();
		}

		// Token: 0x06000C41 RID: 3137 RVA: 0x00020424 File Offset: 0x0001E624
		private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			Type type = value.GetType();
			if (value != null)
			{
			}
			return value;
		}

		// Token: 0x06000C42 RID: 3138 RVA: 0x00020444 File Offset: 0x0001E644
		private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			/*
An exception occurred when decompiling this method (06000C42)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Xml.Schema.XmlUntypedConverter::ChangeTypeWildcardSource(System.Object,System.Type,System.Xml.IXmlNamespaceResolver)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:XmlSchemaType(var_2_09, ldfld:XmlSchemaType(XmlBaseConverter::schemaType, ldloc:XmlUntypedConverter[exp:XmlBaseConverter](this)))
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

		// Token: 0x06000C43 RID: 3139 RVA: 0x0002045C File Offset: 0x0001E65C
		protected override object ChangeListType(object value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			Type type = value.GetType();
			if (this.atomicConverter != null)
			{
				bool flag = this.allowListToList;
				if (flag || !flag)
				{
				}
				return base.ChangeListType(value, destinationType, nsResolver);
			}
			string xmlTypeName = base.XmlTypeName;
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000C44 RID: 3140 RVA: 0x000204B4 File Offset: 0x0001E6B4
		private bool SupportsType(Type clrType)
		{
			if (!true)
			{
			}
			return true;
		}

		// Token: 0x06000C45 RID: 3141 RVA: 0x000204C8 File Offset: 0x0001E6C8
		// Note: this type is marked as 'beforefieldinit'.
		static XmlUntypedConverter()
		{
		}

		// Token: 0x04000628 RID: 1576
		private bool allowListToList;

		// Token: 0x04000629 RID: 1577
		public static readonly XmlValueConverter Untyped;

		// Token: 0x0400062A RID: 1578
		public static readonly XmlValueConverter UntypedList;
	}
}
