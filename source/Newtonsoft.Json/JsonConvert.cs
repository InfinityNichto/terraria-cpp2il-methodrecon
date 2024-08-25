using System;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.Linq;
using Cpp2IlInjected;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json
{
	// Token: 0x02000033 RID: 51
	[Preserve]
	public static class JsonConvert
	{
		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x000066A0 File Offset: 0x000048A0
		// (set) Token: 0x060001A2 RID: 418 RVA: 0x000066B4 File Offset: 0x000048B4
		public static Func<JsonSerializerSettings> DefaultSettings
		{
			[CompilerGenerated]
			get
			{
				if (!true)
				{
				}
				return 1;
			}
			[CompilerGenerated]
			set
			{
				if (!true)
				{
				}
			}
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x000066C4 File Offset: 0x000048C4
		static JsonConvert()
		{
			if (!true)
			{
			}
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x000066D4 File Offset: 0x000048D4
		internal static JsonSerializerSettings GetDefaultSettings()
		{
			/*
An exception occurred when decompiling this method (060001A4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Newtonsoft.Json.JsonSerializerSettings Newtonsoft.Json.JsonConvert::GetDefaultSettings()

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

		// Token: 0x060001A5 RID: 421 RVA: 0x000066E4 File Offset: 0x000048E4
		public static string ToString(DateTime value)
		{
			if (!true)
			{
			}
			string text;
			return text;
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x000066F8 File Offset: 0x000048F8
		public static string ToString(DateTime value, DateFormatHandling format, DateTimeZoneHandling timeZoneHandling)
		{
			if (!true)
			{
			}
			StringWriter stringWriter = StringUtils.CreateStringWriter(64);
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			if (!false)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00006744 File Offset: 0x00004944
		public static string ToString(DateTimeOffset value)
		{
			if (!true)
			{
			}
			string text;
			return text;
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00006758 File Offset: 0x00004958
		public static string ToString(DateTimeOffset value, DateFormatHandling format)
		{
			StringWriter stringWriter = StringUtils.CreateStringWriter(64);
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			if (!false)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x000067A0 File Offset: 0x000049A0
		public static string ToString(bool value)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x060001AA RID: 426 RVA: 0x000067B4 File Offset: 0x000049B4
		public static string ToString(char value)
		{
			if (!true)
			{
			}
			string text;
			return JsonConvert.ToString(text);
		}

		// Token: 0x060001AB RID: 427 RVA: 0x000067CC File Offset: 0x000049CC
		public static string ToString(Enum value)
		{
			string text;
			return text;
		}

		// Token: 0x060001AC RID: 428 RVA: 0x000067DC File Offset: 0x000049DC
		public static string ToString(int value)
		{
			if (!true)
			{
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			string text;
			return text;
		}

		// Token: 0x060001AD RID: 429 RVA: 0x000067F8 File Offset: 0x000049F8
		public static string ToString(short value)
		{
			if (!true)
			{
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			string text;
			return text;
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00006814 File Offset: 0x00004A14
		[CLSCompliant(false)]
		public static string ToString(ushort value)
		{
			if (!true)
			{
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			string text;
			return text;
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00006830 File Offset: 0x00004A30
		[CLSCompliant(false)]
		public static string ToString(uint value)
		{
			if (!true)
			{
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			string text;
			return text;
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x0000684C File Offset: 0x00004A4C
		public static string ToString(long value)
		{
			if (!true)
			{
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			string text;
			return text;
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00006868 File Offset: 0x00004A68
		[CLSCompliant(false)]
		public static string ToString(ulong value)
		{
			if (!true)
			{
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			string text;
			return text;
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00006884 File Offset: 0x00004A84
		public static string ToString(float value)
		{
			if (!true)
			{
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			string text;
			return JsonConvert.EnsureDecimalPlace((double)value, text);
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x000068A4 File Offset: 0x00004AA4
		internal static string ToString(float value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable)
		{
			if (!true)
			{
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			string text2;
			string text = JsonConvert.EnsureDecimalPlace((double)value, text2);
			string text3;
			return text3;
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x000068C8 File Offset: 0x00004AC8
		private static string EnsureFloatFormat(double value, string text, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			string text2;
			return text2;
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x000068E4 File Offset: 0x00004AE4
		public static string ToString(double value)
		{
			if (!true)
			{
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			string text;
			return JsonConvert.EnsureDecimalPlace(value, text);
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00006904 File Offset: 0x00004B04
		internal static string ToString(double value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable)
		{
			if (!true)
			{
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			string text2;
			string text = JsonConvert.EnsureDecimalPlace(value, text2);
			string text3;
			return text3;
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00006928 File Offset: 0x00004B28
		private static string EnsureDecimalPlace(double value, string text)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			string text2;
			return text2;
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x0000693C File Offset: 0x00004B3C
		private static string EnsureDecimalPlace(string text)
		{
			string text2;
			return text2;
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x0000694C File Offset: 0x00004B4C
		public static string ToString(byte value)
		{
			if (!true)
			{
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			string text;
			return text;
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00006968 File Offset: 0x00004B68
		[CLSCompliant(false)]
		public static string ToString(sbyte value)
		{
			if (!true)
			{
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			string text;
			return text;
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00006984 File Offset: 0x00004B84
		public static string ToString(decimal value)
		{
			if (!true)
			{
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			string text;
			return JsonConvert.EnsureDecimalPlace(text);
		}

		// Token: 0x060001BC RID: 444 RVA: 0x000069A4 File Offset: 0x00004BA4
		public static string ToString(Guid value)
		{
			if (!true)
			{
			}
			string text;
			return text;
		}

		// Token: 0x060001BD RID: 445 RVA: 0x000069B8 File Offset: 0x00004BB8
		internal static string ToString(Guid value, char quoteChar)
		{
			if (!true)
			{
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			CultureInfo invariantCulture2 = CultureInfo.InvariantCulture;
			string text;
			string text2;
			return text + text2 + text;
		}

		// Token: 0x060001BE RID: 446 RVA: 0x000069E4 File Offset: 0x00004BE4
		public static string ToString(TimeSpan value)
		{
			if (!true)
			{
			}
			string text;
			return text;
		}

		// Token: 0x060001BF RID: 447 RVA: 0x000069F8 File Offset: 0x00004BF8
		internal static string ToString(TimeSpan value, char quoteChar)
		{
			string text;
			return text;
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00006A08 File Offset: 0x00004C08
		public static string ToString(Uri value)
		{
			if (!true)
			{
			}
			string text;
			return text;
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00006A1C File Offset: 0x00004C1C
		internal static string ToString(Uri value, char quoteChar)
		{
			string text;
			return text;
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00006A2C File Offset: 0x00004C2C
		public static string ToString(string value)
		{
			if (!true)
			{
			}
			string text;
			return text;
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00006A40 File Offset: 0x00004C40
		public static string ToString(string value, char delimiter)
		{
			if (!true)
			{
			}
			string text;
			return text;
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00006A54 File Offset: 0x00004C54
		public static string ToString(string value, char delimiter, StringEscapeHandling stringEscapeHandling)
		{
			string text;
			return text;
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00006A64 File Offset: 0x00004C64
		public static string ToString(object value)
		{
			Type type;
			PrimitiveTypeCode typeCode = ConvertUtils.GetTypeCode(type);
			return JsonConvert.ToString('\0');
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00006B08 File Offset: 0x00004D08
		public static string SerializeObject(object value)
		{
			if (!true)
			{
			}
			string text;
			return text;
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00006B1C File Offset: 0x00004D1C
		public static string SerializeObject(object value, Formatting formatting)
		{
			if (!true)
			{
			}
			string text;
			return text;
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00006B30 File Offset: 0x00004D30
		public static string SerializeObject(object value, params JsonConverter[] converters)
		{
			if (value == null || true)
			{
			}
			string text;
			return text;
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00006B44 File Offset: 0x00004D44
		public static string SerializeObject(object value, Formatting formatting, params JsonConverter[] converters)
		{
			if (formatting == Formatting.None || true)
			{
			}
			string text;
			return text;
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00006B58 File Offset: 0x00004D58
		public static string SerializeObject(object value, JsonSerializerSettings settings)
		{
			if (!true)
			{
			}
			string text;
			return text;
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00006B6C File Offset: 0x00004D6C
		public static string SerializeObject(object value, Type type, JsonSerializerSettings settings)
		{
			string text;
			return text;
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00006B7C File Offset: 0x00004D7C
		public static string SerializeObject(object value, Formatting formatting, JsonSerializerSettings settings)
		{
			if (!true)
			{
			}
			string text;
			return text;
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00006B90 File Offset: 0x00004D90
		public static string SerializeObject(object value, Type type, Formatting formatting, JsonSerializerSettings settings)
		{
			string text;
			return text;
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00006BA0 File Offset: 0x00004DA0
		private static string SerializeObjectInternal(object value, Type type, JsonSerializer jsonSerializer)
		{
			if (!true)
			{
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			if (!false)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00006BD8 File Offset: 0x00004DD8
		public static object DeserializeObject(string value)
		{
			if (!true)
			{
			}
			object obj;
			return obj;
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00006BEC File Offset: 0x00004DEC
		public static object DeserializeObject(string value, JsonSerializerSettings settings)
		{
			if (!true)
			{
			}
			object obj;
			return obj;
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00006C00 File Offset: 0x00004E00
		public static object DeserializeObject(string value, Type type)
		{
			if (!true)
			{
			}
			object obj;
			return obj;
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00006C14 File Offset: 0x00004E14
		public static T DeserializeObject<T>(string value)
		{
			/*
An exception occurred when decompiling this method (060001D2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling T Newtonsoft.Json.JsonConvert::DeserializeObject<T>(System.String)

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

		// Token: 0x060001D3 RID: 467 RVA: 0x00006C24 File Offset: 0x00004E24
		public static T DeserializeAnonymousType<T>(string value, T anonymousTypeObject)
		{
			/*
An exception occurred when decompiling this method (060001D3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling T Newtonsoft.Json.JsonConvert::DeserializeAnonymousType<T>(System.String,T)

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

		// Token: 0x060001D4 RID: 468 RVA: 0x00006C34 File Offset: 0x00004E34
		public static T DeserializeAnonymousType<T>(string value, T anonymousTypeObject, JsonSerializerSettings settings)
		{
			/*
An exception occurred when decompiling this method (060001D4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling T Newtonsoft.Json.JsonConvert::DeserializeAnonymousType<T>(System.String,T,Newtonsoft.Json.JsonSerializerSettings)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:valuetype [mscorlib]System.Nullable`1<valuetype Newtonsoft.Json.FloatParseHandling>(var_0_09, ldfld:valuetype [mscorlib]System.Nullable`1<valuetype Newtonsoft.Json.FloatParseHandling>(JsonSerializerSettings::_floatParseHandling, ldloc:JsonSerializerSettings(settings)))
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

		// Token: 0x060001D5 RID: 469 RVA: 0x00006C4C File Offset: 0x00004E4C
		public static T DeserializeObject<T>(string value, params JsonConverter[] converters)
		{
			object obj;
			while (obj != null)
			{
				if (obj == null)
				{
					throw new InvalidCastException();
				}
			}
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x0000212A File Offset: 0x0000032A
		public static T DeserializeObject<T>(string value, JsonSerializerSettings settings)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00006C68 File Offset: 0x00004E68
		public static object DeserializeObject(string value, Type type, params JsonConverter[] converters)
		{
			if (type == null || true)
			{
			}
			object obj;
			return obj;
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00006C7C File Offset: 0x00004E7C
		public static object DeserializeObject(string value, Type type, JsonSerializerSettings settings)
		{
			ValidationUtils.ArgumentNotNull("value", "value");
			JsonSerializer jsonSerializer;
			if (jsonSerializer._checkAdditionalContent == null)
			{
			}
			if (!false)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00006CC0 File Offset: 0x00004EC0
		public static void PopulateObject(string value, object target)
		{
			if (!true)
			{
			}
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00006CD0 File Offset: 0x00004ED0
		public static void PopulateObject(string value, object target, JsonSerializerSettings settings)
		{
			JsonSerializer jsonSerializer = JsonSerializer.CreateDefault(settings);
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00006D0C File Offset: 0x00004F0C
		public static string SerializeXmlNode(XmlNode node)
		{
			if (!true)
			{
			}
			string text;
			return text;
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00006D20 File Offset: 0x00004F20
		public static string SerializeXmlNode(XmlNode node, Formatting formatting)
		{
			string text;
			return text;
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00006D34 File Offset: 0x00004F34
		public static string SerializeXmlNode(XmlNode node, Formatting formatting, bool omitRootObject)
		{
			string text;
			return text;
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00006D48 File Offset: 0x00004F48
		public static XmlDocument DeserializeXmlNode(string value)
		{
			if (!true)
			{
			}
			XmlDocument xmlDocument;
			return xmlDocument;
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00006D5C File Offset: 0x00004F5C
		public static XmlDocument DeserializeXmlNode(string value, string deserializeRootElementName)
		{
			if (!true)
			{
			}
			XmlDocument xmlDocument;
			return xmlDocument;
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00006D70 File Offset: 0x00004F70
		public static XmlDocument DeserializeXmlNode(string value, string deserializeRootElementName, bool writeArrayAttribute)
		{
			if (!true)
			{
			}
			object obj;
			if (obj != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00006D90 File Offset: 0x00004F90
		public static string SerializeXNode(XObject node)
		{
			if (!true)
			{
			}
			string text;
			return text;
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00006DA4 File Offset: 0x00004FA4
		public static string SerializeXNode(XObject node, Formatting formatting)
		{
			if (!true)
			{
			}
			string text;
			return text;
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00006DB8 File Offset: 0x00004FB8
		public static string SerializeXNode(XObject node, Formatting formatting, bool omitRootObject)
		{
			string text;
			return text;
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00006DCC File Offset: 0x00004FCC
		public static XDocument DeserializeXNode(string value)
		{
			if (!true)
			{
			}
			XDocument xdocument;
			return xdocument;
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00006DE0 File Offset: 0x00004FE0
		public static XDocument DeserializeXNode(string value, string deserializeRootElementName)
		{
			if (!true)
			{
			}
			XDocument xdocument;
			return xdocument;
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00006DF4 File Offset: 0x00004FF4
		public static XDocument DeserializeXNode(string value, string deserializeRootElementName, bool writeArrayAttribute)
		{
			if (!true)
			{
			}
			object obj;
			if (obj != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x040000E6 RID: 230
		[CompilerGenerated]
		private static Func<JsonSerializerSettings> <DefaultSettings>k__BackingField;

		// Token: 0x040000E7 RID: 231
		public static readonly string True;

		// Token: 0x040000E8 RID: 232
		public static readonly string False;

		// Token: 0x040000E9 RID: 233
		public static readonly string Null;

		// Token: 0x040000EA RID: 234
		public static readonly string Undefined;

		// Token: 0x040000EB RID: 235
		public static readonly string PositiveInfinity;

		// Token: 0x040000EC RID: 236
		public static readonly string NegativeInfinity;

		// Token: 0x040000ED RID: 237
		public static readonly string NaN;

		// Token: 0x040000EE RID: 238
		private static readonly JsonSerializerSettings InitialSerializerSettings;
	}
}
