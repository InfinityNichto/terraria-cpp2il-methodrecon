using System;
using System.Globalization;
using Cpp2IlInjected;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000E0 RID: 224
	[Preserve]
	public class JValue : JToken, IFormattable, IComparable, IConvertible
	{
		// Token: 0x06000938 RID: 2360 RVA: 0x00016744 File Offset: 0x00014944
		internal JValue(object value, JTokenType type)
		{
			if (!true)
			{
			}
			base..ctor();
			this._value = value;
			this._valueType = type;
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x00016768 File Offset: 0x00014968
		public JValue(JValue other)
		{
			object value = other._value;
			if (!true)
			{
			}
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x00016780 File Offset: 0x00014980
		public JValue(long value)
		{
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x00016790 File Offset: 0x00014990
		public JValue(decimal value)
		{
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x000167A0 File Offset: 0x000149A0
		public JValue(char value)
		{
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x000167B0 File Offset: 0x000149B0
		[CLSCompliant(false)]
		public JValue(ulong value)
		{
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x000167C0 File Offset: 0x000149C0
		public JValue(double value)
		{
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x000167D0 File Offset: 0x000149D0
		public JValue(float value)
		{
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x000167E0 File Offset: 0x000149E0
		public JValue(DateTime value)
		{
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x000167F0 File Offset: 0x000149F0
		public JValue(DateTimeOffset value)
		{
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x00016800 File Offset: 0x00014A00
		public JValue(bool value)
		{
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x00016810 File Offset: 0x00014A10
		public JValue(string value)
		{
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x00016820 File Offset: 0x00014A20
		public JValue(Guid value)
		{
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x00016830 File Offset: 0x00014A30
		public JValue(Uri value)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x00016840 File Offset: 0x00014A40
		public JValue(TimeSpan value)
		{
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x00016850 File Offset: 0x00014A50
		public JValue(object value)
		{
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x00016860 File Offset: 0x00014A60
		internal override bool DeepEquals(JToken node)
		{
			if (node != null)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000949 RID: 2377 RVA: 0x00016878 File Offset: 0x00014A78
		public override bool HasValues
		{
			get
			{
			}
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x00016888 File Offset: 0x00014A88
		internal static int Compare(JTokenType valueType, object objA, object objB)
		{
			int num = 1;
			if (valueType == JTokenType.None)
			{
				int num2;
				return num2;
			}
			if (objA != null)
			{
				if (num == 0)
				{
				}
				CultureInfo invariantCulture = CultureInfo.InvariantCulture;
				string text = Convert.ToString(valueType, invariantCulture);
				CultureInfo invariantCulture2 = CultureInfo.InvariantCulture;
				string text2 = Convert.ToString(objA, invariantCulture2);
				int num2 = string.CompareOrdinal(text, text2);
				return num2;
			}
			return 1;
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x000169F4 File Offset: 0x00014BF4
		private static int CompareFloat(object objA, object objB)
		{
			if (!true)
			{
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			CultureInfo invariantCulture2 = CultureInfo.InvariantCulture;
			double num = Convert.ToDouble(objA, invariantCulture2);
			double num2;
			bool flag = MathUtils.ApproxEquals(num2, num);
			int num3;
			return num3;
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x0000212A File Offset: 0x0000032A
		internal override JToken CloneToken()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x0000212A File Offset: 0x0000032A
		public static JValue CreateComment(string value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x0000212A File Offset: 0x0000032A
		public static JValue CreateString(string value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x00016A34 File Offset: 0x00014C34
		public static JValue CreateNull()
		{
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x00016A44 File Offset: 0x00014C44
		public static JValue CreateUndefined()
		{
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x00016A54 File Offset: 0x00014C54
		private static JTokenType GetValueType(JTokenType? current, object value)
		{
			/*
An exception occurred when decompiling this method (06000951)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Newtonsoft.Json.Linq.JTokenType Newtonsoft.Json.Linq.JValue::GetValueType(System.Nullable`1<Newtonsoft.Json.Linq.JTokenType>,System.Object)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0016:
	stloc:CultureInfo(var_10_2E, callgetter:CultureInfo(CultureInfo::get_InvariantCulture))
	stloc:Type(var_11_36, call:Type(object::GetType, ldloc:valuetype [mscorlib]System.Nullable`1<valuetype Newtonsoft.Json.Linq.JTokenType>[exp:object](current)))
	stloc:string(var_12_46, call:string(StringUtils::FormatWith, ldstr:string("Could not determine JSON object type for type {0}."), ldloc:CultureInfo[exp:IFormatProvider](var_10_2E), ldloc:Type[exp:object](var_11_36)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
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

		// Token: 0x06000952 RID: 2386 RVA: 0x00016AA8 File Offset: 0x00014CA8
		private static JTokenType GetStringValueType(JTokenType? current)
		{
			return JTokenType.Object;
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06000953 RID: 2387 RVA: 0x00016AB8 File Offset: 0x00014CB8
		public override JTokenType Type
		{
			get
			{
				return this._valueType;
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06000954 RID: 2388 RVA: 0x00016ACC File Offset: 0x00014CCC
		// (set) Token: 0x06000955 RID: 2389 RVA: 0x00016AE0 File Offset: 0x00014CE0
		public new object Value
		{
			get
			{
				return this._value;
			}
			set
			{
				object value2 = this._value;
				if (value2 != null)
				{
					Type type = value2.GetType();
					if (value != null)
					{
						Type type2 = value.GetType();
						return;
					}
				}
				else
				{
					while (value != null)
					{
					}
				}
				JTokenType valueType = this._valueType;
				JTokenType jtokenType;
				this._valueType = jtokenType;
				this._value = value;
			}
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x00016B28 File Offset: 0x00014D28
		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
			int num = 1;
			if (converters != null && num != 0)
			{
				object value = this._value;
				if (value != null)
				{
					Type type = value.GetType();
					JsonConverter jsonConverter;
					if (jsonConverter != null)
					{
						object value2 = this._value;
						JsonSerializer jsonSerializer = JsonSerializer.CreateDefault();
						return;
					}
				}
			}
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x00016C0C File Offset: 0x00014E0C
		internal override int GetDeepHashCode()
		{
			if (this._value != null)
			{
			}
			JTokenType valueType = this._valueType;
			int num;
			return num;
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x00016C2C File Offset: 0x00014E2C
		private static bool ValuesEquals(JValue v1, JValue v2)
		{
			JTokenType valueType = v1._valueType;
			object value = v1._value;
			return true;
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x00016C4C File Offset: 0x00014E4C
		public bool Equals(JValue other)
		{
			if (other != null)
			{
				return JValue.ValuesEquals(this, other);
			}
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x00016C68 File Offset: 0x00014E68
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
				return base.Equals(obj);
			}
			bool flag;
			return flag;
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x00016C84 File Offset: 0x00014E84
		public override int GetHashCode()
		{
			/*
An exception occurred when decompiling this method (0600095B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Newtonsoft.Json.Linq.JValue::GetHashCode()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, logicnot:bool(ldfld:object[exp:bool](JValue::_value, ldloc:JValue(this))))
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

		// Token: 0x0600095C RID: 2396 RVA: 0x00016C98 File Offset: 0x00014E98
		public override string ToString()
		{
			/*
An exception occurred when decompiling this method (0600095C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String Newtonsoft.Json.Linq.JValue::ToString()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, logicnot:bool(ldfld:object[exp:bool](JValue::_value, ldloc:JValue(this))))
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

		// Token: 0x0600095D RID: 2397 RVA: 0x00016CAC File Offset: 0x00014EAC
		public string ToString(string format)
		{
			if (!true)
			{
			}
			CultureInfo currentCulture = CultureInfo.CurrentCulture;
			return this.ToString(format, currentCulture);
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x00016CCC File Offset: 0x00014ECC
		public string ToString(IFormatProvider formatProvider)
		{
			string text;
			return text;
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x00016CDC File Offset: 0x00014EDC
		public string ToString(string format, IFormatProvider formatProvider)
		{
			/*
An exception occurred when decompiling this method (0600095F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String Newtonsoft.Json.Linq.JValue::ToString(System.String,System.IFormatProvider)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000D:
	stloc:object(var_1_13, ldfld:object(JValue::_value, ldloc:JValue(this)))
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

		// Token: 0x06000960 RID: 2400 RVA: 0x00016CFC File Offset: 0x00014EFC
		int IComparable.CompareTo(object obj)
		{
			if (obj != null)
			{
				JTokenType valueType = this._valueType;
				object value = this._value;
				return JValue.Compare(valueType, value, obj);
			}
			return 1;
		}

		// Token: 0x06000961 RID: 2401 RVA: 0x00016D24 File Offset: 0x00014F24
		public int CompareTo(JValue obj)
		{
			if (obj != null)
			{
				JTokenType valueType = this._valueType;
				object value = this._value;
				object value2 = obj._value;
				return JValue.Compare(valueType, value, value2);
			}
			return 1;
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x00016D54 File Offset: 0x00014F54
		TypeCode IConvertible.GetTypeCode()
		{
			/*
An exception occurred when decompiling this method (06000962)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.TypeCode Newtonsoft.Json.Linq.JValue::System.IConvertible.GetTypeCode()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000D:
	stloc:int32(var_1_13, ldfld:int32(int32::m_value, ldc.i4:int32[exp:int32&](1)))
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

		// Token: 0x06000963 RID: 2403 RVA: 0x00016D74 File Offset: 0x00014F74
		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			if (!true)
			{
			}
			return (bool)this;
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x00016D8C File Offset: 0x00014F8C
		char IConvertible.ToChar(IFormatProvider provider)
		{
			if (!true)
			{
			}
			return (char)this;
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x00016DA4 File Offset: 0x00014FA4
		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			if (!true)
			{
			}
			return (sbyte)this;
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x00016DBC File Offset: 0x00014FBC
		byte IConvertible.ToByte(IFormatProvider provider)
		{
			if (!true)
			{
			}
			return (byte)this;
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x00016DD4 File Offset: 0x00014FD4
		short IConvertible.ToInt16(IFormatProvider provider)
		{
			if (!true)
			{
			}
			return (short)this;
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x00016DEC File Offset: 0x00014FEC
		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			if (!true)
			{
			}
			return (ushort)this;
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x00016E04 File Offset: 0x00015004
		int IConvertible.ToInt32(IFormatProvider provider)
		{
			if (!true)
			{
			}
			return (int)this;
		}

		// Token: 0x0600096A RID: 2410 RVA: 0x00016E1C File Offset: 0x0001501C
		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			if (!true)
			{
			}
			return (uint)this;
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x00016E34 File Offset: 0x00015034
		long IConvertible.ToInt64(IFormatProvider provider)
		{
			if (!true)
			{
			}
			return (long)this;
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x00016E4C File Offset: 0x0001504C
		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			if (!true)
			{
			}
			return (ulong)this;
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x00016E64 File Offset: 0x00015064
		float IConvertible.ToSingle(IFormatProvider provider)
		{
			/*
An exception occurred when decompiling this method (0600096D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Newtonsoft.Json.Linq.JValue::System.IConvertible.ToSingle(System.IFormatProvider)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:float32(var_0_09, call:float32(JToken::op_Explicit, ldloc:JValue[exp:JToken](this)))
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

		// Token: 0x0600096E RID: 2414 RVA: 0x00016E7C File Offset: 0x0001507C
		double IConvertible.ToDouble(IFormatProvider provider)
		{
			/*
An exception occurred when decompiling this method (0600096E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Double Newtonsoft.Json.Linq.JValue::System.IConvertible.ToDouble(System.IFormatProvider)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:float64(var_0_09, call:float64(JToken::op_Explicit, ldloc:JValue[exp:JToken](this)))
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

		// Token: 0x0600096F RID: 2415 RVA: 0x00016E94 File Offset: 0x00015094
		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			if (!true)
			{
			}
			decimal num = (decimal)this;
			return 1;
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x00016EAC File Offset: 0x000150AC
		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			if (!true)
			{
			}
			DateTime dateTime = (DateTime)this;
			return 1;
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x00016EC4 File Offset: 0x000150C4
		object IConvertible.ToType(Type conversionType, IFormatProvider provider)
		{
			return base.ToObject(conversionType);
		}

		// Token: 0x04000384 RID: 900
		private JTokenType _valueType;

		// Token: 0x04000385 RID: 901
		private object _value;
	}
}
