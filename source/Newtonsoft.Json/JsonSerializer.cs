using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using Cpp2IlInjected;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json
{
	// Token: 0x02000035 RID: 53
	[Preserve]
	public class JsonSerializer
	{
		// Token: 0x14000003 RID: 3
		// (add) Token: 0x060001EE RID: 494 RVA: 0x00006E9C File Offset: 0x0000509C
		// (remove) Token: 0x060001EF RID: 495 RVA: 0x00006EC4 File Offset: 0x000050C4
		public virtual event EventHandler<ErrorEventArgs> Error
		{
			[CompilerGenerated]
			add
			{
				Delegate @delegate = Delegate.Combine(this.Error, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = Delegate.Remove(this.Error, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x00006EEC File Offset: 0x000050EC
		// (set) Token: 0x060001F1 RID: 497 RVA: 0x00006F00 File Offset: 0x00005100
		public virtual IReferenceResolver ReferenceResolver
		{
			get
			{
				return this.GetReferenceResolver();
			}
			set
			{
				while (value == null)
				{
				}
				this._referenceResolver = value;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x00006F18 File Offset: 0x00005118
		// (set) Token: 0x060001F3 RID: 499 RVA: 0x00006F2C File Offset: 0x0000512C
		public virtual SerializationBinder Binder
		{
			get
			{
				return this._binder;
			}
			set
			{
				while (value == null)
				{
				}
				this._binder = value;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x00006F44 File Offset: 0x00005144
		// (set) Token: 0x060001F5 RID: 501 RVA: 0x00006F58 File Offset: 0x00005158
		public virtual ITraceWriter TraceWriter
		{
			get
			{
				return this._traceWriter;
			}
			set
			{
				this._traceWriter = value;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x00006F6C File Offset: 0x0000516C
		// (set) Token: 0x060001F7 RID: 503 RVA: 0x00006F80 File Offset: 0x00005180
		public virtual IEqualityComparer EqualityComparer
		{
			get
			{
				return this._equalityComparer;
			}
			set
			{
				this._equalityComparer = value;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x00006F94 File Offset: 0x00005194
		// (set) Token: 0x060001F9 RID: 505 RVA: 0x00006FA8 File Offset: 0x000051A8
		public virtual TypeNameHandling TypeNameHandling
		{
			get
			{
				return this._typeNameHandling;
			}
			set
			{
				this._typeNameHandling = value;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060001FA RID: 506 RVA: 0x00006FBC File Offset: 0x000051BC
		// (set) Token: 0x060001FB RID: 507 RVA: 0x00006FD0 File Offset: 0x000051D0
		public virtual FormatterAssemblyStyle TypeNameAssemblyFormat
		{
			get
			{
				return this._typeNameAssemblyFormat;
			}
			set
			{
				this._typeNameAssemblyFormat = value;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060001FC RID: 508 RVA: 0x00006FE4 File Offset: 0x000051E4
		// (set) Token: 0x060001FD RID: 509 RVA: 0x00006FF8 File Offset: 0x000051F8
		public virtual PreserveReferencesHandling PreserveReferencesHandling
		{
			get
			{
				return this._preserveReferencesHandling;
			}
			set
			{
				this._preserveReferencesHandling = value;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060001FE RID: 510 RVA: 0x0000700C File Offset: 0x0000520C
		// (set) Token: 0x060001FF RID: 511 RVA: 0x00007020 File Offset: 0x00005220
		public virtual ReferenceLoopHandling ReferenceLoopHandling
		{
			get
			{
				return this._referenceLoopHandling;
			}
			set
			{
				this._referenceLoopHandling = value;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000200 RID: 512 RVA: 0x00007034 File Offset: 0x00005234
		// (set) Token: 0x06000201 RID: 513 RVA: 0x00007048 File Offset: 0x00005248
		public virtual MissingMemberHandling MissingMemberHandling
		{
			get
			{
				return this._missingMemberHandling;
			}
			set
			{
				this._missingMemberHandling = value;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000202 RID: 514 RVA: 0x0000705C File Offset: 0x0000525C
		// (set) Token: 0x06000203 RID: 515 RVA: 0x00007070 File Offset: 0x00005270
		public virtual NullValueHandling NullValueHandling
		{
			get
			{
				return this._nullValueHandling;
			}
			set
			{
				this._nullValueHandling = value;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000204 RID: 516 RVA: 0x00007084 File Offset: 0x00005284
		// (set) Token: 0x06000205 RID: 517 RVA: 0x00007098 File Offset: 0x00005298
		public virtual DefaultValueHandling DefaultValueHandling
		{
			get
			{
				return this._defaultValueHandling;
			}
			set
			{
				this._defaultValueHandling = value;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000206 RID: 518 RVA: 0x000070AC File Offset: 0x000052AC
		// (set) Token: 0x06000207 RID: 519 RVA: 0x000070C0 File Offset: 0x000052C0
		public virtual ObjectCreationHandling ObjectCreationHandling
		{
			get
			{
				return this._objectCreationHandling;
			}
			set
			{
				this._objectCreationHandling = value;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000208 RID: 520 RVA: 0x000070D4 File Offset: 0x000052D4
		// (set) Token: 0x06000209 RID: 521 RVA: 0x000070E8 File Offset: 0x000052E8
		public virtual ConstructorHandling ConstructorHandling
		{
			get
			{
				return this._constructorHandling;
			}
			set
			{
				this._constructorHandling = value;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600020A RID: 522 RVA: 0x000070FC File Offset: 0x000052FC
		// (set) Token: 0x0600020B RID: 523 RVA: 0x00007110 File Offset: 0x00005310
		public virtual MetadataPropertyHandling MetadataPropertyHandling
		{
			get
			{
				return this._metadataPropertyHandling;
			}
			set
			{
				this._metadataPropertyHandling = value;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600020C RID: 524 RVA: 0x00007124 File Offset: 0x00005324
		public virtual JsonConverterCollection Converters
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600020C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Newtonsoft.Json.JsonConverterCollection Newtonsoft.Json.JsonSerializer::get_Converters()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:JsonConverterCollection[exp:bool](JsonSerializer::_converters, ldloc:JsonSerializer(this)))
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

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600020D RID: 525 RVA: 0x00007138 File Offset: 0x00005338
		// (set) Token: 0x0600020E RID: 526 RVA: 0x0000714C File Offset: 0x0000534C
		public virtual IContractResolver ContractResolver
		{
			get
			{
				return this._contractResolver;
			}
			set
			{
				if (value == null)
				{
					if (!true)
					{
					}
					if (!true)
					{
					}
				}
				this._contractResolver = 1;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600020F RID: 527 RVA: 0x0000716C File Offset: 0x0000536C
		// (set) Token: 0x06000210 RID: 528 RVA: 0x00007190 File Offset: 0x00005390
		public virtual StreamingContext Context
		{
			get
			{
				StreamingContext context = this._context;
				StreamingContextStates state = this._context.m_state;
				return context;
			}
			set
			{
				this._context = value;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000211 RID: 529 RVA: 0x000071A4 File Offset: 0x000053A4
		// (set) Token: 0x06000212 RID: 530 RVA: 0x000071C0 File Offset: 0x000053C0
		public virtual Formatting Formatting
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000211)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Newtonsoft.Json.Formatting Newtonsoft.Json.JsonSerializer::get_Formatting()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:valuetype [mscorlib]System.Nullable`1<valuetype Newtonsoft.Json.Formatting>(var_0_06, ldfld:valuetype [mscorlib]System.Nullable`1<valuetype Newtonsoft.Json.Formatting>(JsonSerializer::_formatting, ldloc:JsonSerializer(this)))
	stloc:valuetype [mscorlib]System.Nullable`1<valuetype Newtonsoft.Json.DateFormatHandling>(var_1_0D, ldfld:valuetype [mscorlib]System.Nullable`1<valuetype Newtonsoft.Json.DateFormatHandling>(JsonSerializer::_dateFormatHandling, ldloc:JsonSerializer(this)))
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
			set
			{
				this._formatting = 1;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000213 RID: 531 RVA: 0x000071D4 File Offset: 0x000053D4
		// (set) Token: 0x06000214 RID: 532 RVA: 0x000071F0 File Offset: 0x000053F0
		public virtual DateFormatHandling DateFormatHandling
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000213)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Newtonsoft.Json.DateFormatHandling Newtonsoft.Json.JsonSerializer::get_DateFormatHandling()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:valuetype [mscorlib]System.Nullable`1<valuetype Newtonsoft.Json.DateFormatHandling>(var_0_06, ldfld:valuetype [mscorlib]System.Nullable`1<valuetype Newtonsoft.Json.DateFormatHandling>(JsonSerializer::_dateFormatHandling, ldloc:JsonSerializer(this)))
	stloc:valuetype [mscorlib]System.Nullable`1<valuetype Newtonsoft.Json.DateTimeZoneHandling>(var_1_0D, ldfld:valuetype [mscorlib]System.Nullable`1<valuetype Newtonsoft.Json.DateTimeZoneHandling>(JsonSerializer::_dateTimeZoneHandling, ldloc:JsonSerializer(this)))
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
			set
			{
				this._dateFormatHandling = 1;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000215 RID: 533 RVA: 0x00007204 File Offset: 0x00005404
		// (set) Token: 0x06000216 RID: 534 RVA: 0x00007220 File Offset: 0x00005420
		public virtual DateTimeZoneHandling DateTimeZoneHandling
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000215)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Newtonsoft.Json.DateTimeZoneHandling Newtonsoft.Json.JsonSerializer::get_DateTimeZoneHandling()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:valuetype [mscorlib]System.Nullable`1<valuetype Newtonsoft.Json.DateTimeZoneHandling>(var_0_06, ldfld:valuetype [mscorlib]System.Nullable`1<valuetype Newtonsoft.Json.DateTimeZoneHandling>(JsonSerializer::_dateTimeZoneHandling, ldloc:JsonSerializer(this)))
	stloc:valuetype [mscorlib]System.Nullable`1<valuetype Newtonsoft.Json.DateParseHandling>(var_1_0D, ldfld:valuetype [mscorlib]System.Nullable`1<valuetype Newtonsoft.Json.DateParseHandling>(JsonSerializer::_dateParseHandling, ldloc:JsonSerializer(this)))
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
			set
			{
				this._dateTimeZoneHandling = 1;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000217 RID: 535 RVA: 0x00007234 File Offset: 0x00005434
		// (set) Token: 0x06000218 RID: 536 RVA: 0x00007250 File Offset: 0x00005450
		public virtual DateParseHandling DateParseHandling
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000217)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Newtonsoft.Json.DateParseHandling Newtonsoft.Json.JsonSerializer::get_DateParseHandling()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:valuetype [mscorlib]System.Nullable`1<valuetype Newtonsoft.Json.DateParseHandling>(var_0_06, ldfld:valuetype [mscorlib]System.Nullable`1<valuetype Newtonsoft.Json.DateParseHandling>(JsonSerializer::_dateParseHandling, ldloc:JsonSerializer(this)))
	stloc:valuetype [mscorlib]System.Nullable`1<valuetype Newtonsoft.Json.FloatFormatHandling>(var_1_0D, ldfld:valuetype [mscorlib]System.Nullable`1<valuetype Newtonsoft.Json.FloatFormatHandling>(JsonSerializer::_floatFormatHandling, ldloc:JsonSerializer(this)))
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
			set
			{
				this._dateParseHandling = 1;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000219 RID: 537 RVA: 0x00007264 File Offset: 0x00005464
		// (set) Token: 0x0600021A RID: 538 RVA: 0x00007280 File Offset: 0x00005480
		public virtual FloatParseHandling FloatParseHandling
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000219)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Newtonsoft.Json.FloatParseHandling Newtonsoft.Json.JsonSerializer::get_FloatParseHandling()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:valuetype [mscorlib]System.Nullable`1<valuetype Newtonsoft.Json.FloatParseHandling>(var_0_06, ldfld:valuetype [mscorlib]System.Nullable`1<valuetype Newtonsoft.Json.FloatParseHandling>(JsonSerializer::_floatParseHandling, ldloc:JsonSerializer(this)))
	stloc:valuetype [mscorlib]System.Nullable`1<valuetype Newtonsoft.Json.StringEscapeHandling>(var_1_0D, ldfld:valuetype [mscorlib]System.Nullable`1<valuetype Newtonsoft.Json.StringEscapeHandling>(JsonSerializer::_stringEscapeHandling, ldloc:JsonSerializer(this)))
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
			set
			{
				this._floatParseHandling = 1;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600021B RID: 539 RVA: 0x00007294 File Offset: 0x00005494
		// (set) Token: 0x0600021C RID: 540 RVA: 0x000072B0 File Offset: 0x000054B0
		public virtual FloatFormatHandling FloatFormatHandling
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600021B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Newtonsoft.Json.FloatFormatHandling Newtonsoft.Json.JsonSerializer::get_FloatFormatHandling()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:valuetype [mscorlib]System.Nullable`1<valuetype Newtonsoft.Json.FloatFormatHandling>(var_0_06, ldfld:valuetype [mscorlib]System.Nullable`1<valuetype Newtonsoft.Json.FloatFormatHandling>(JsonSerializer::_floatFormatHandling, ldloc:JsonSerializer(this)))
	stloc:valuetype [mscorlib]System.Nullable`1<valuetype Newtonsoft.Json.FloatParseHandling>(var_1_0D, ldfld:valuetype [mscorlib]System.Nullable`1<valuetype Newtonsoft.Json.FloatParseHandling>(JsonSerializer::_floatParseHandling, ldloc:JsonSerializer(this)))
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
			set
			{
				this._floatFormatHandling = 1;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x0600021D RID: 541 RVA: 0x000072C4 File Offset: 0x000054C4
		// (set) Token: 0x0600021E RID: 542 RVA: 0x000072E0 File Offset: 0x000054E0
		public virtual StringEscapeHandling StringEscapeHandling
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600021D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Newtonsoft.Json.StringEscapeHandling Newtonsoft.Json.JsonSerializer::get_StringEscapeHandling()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:valuetype [mscorlib]System.Nullable`1<valuetype Newtonsoft.Json.StringEscapeHandling>(var_0_06, ldfld:valuetype [mscorlib]System.Nullable`1<valuetype Newtonsoft.Json.StringEscapeHandling>(JsonSerializer::_stringEscapeHandling, ldloc:JsonSerializer(this)))
	stloc:CultureInfo(var_1_0D, ldfld:CultureInfo(JsonSerializer::_culture, ldloc:JsonSerializer(this)))
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
			set
			{
				this._stringEscapeHandling = 1;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600021F RID: 543 RVA: 0x000072F4 File Offset: 0x000054F4
		// (set) Token: 0x06000220 RID: 544 RVA: 0x00007310 File Offset: 0x00005510
		public virtual string DateFormatString
		{
			get
			{
				string dateFormatString = this._dateFormatString;
				return "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK";
			}
			set
			{
				this._dateFormatString = value;
				this._dateFormatStringSet = true;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000221 RID: 545 RVA: 0x0000732C File Offset: 0x0000552C
		// (set) Token: 0x06000222 RID: 546 RVA: 0x00007344 File Offset: 0x00005544
		public virtual CultureInfo Culture
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000221)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Globalization.CultureInfo Newtonsoft.Json.JsonSerializer::get_Culture()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	brtrue(IL_0000, ldc.i4:bool(1))
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
			set
			{
				this._culture = value;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000223 RID: 547 RVA: 0x00007358 File Offset: 0x00005558
		// (set) Token: 0x06000224 RID: 548 RVA: 0x0000736C File Offset: 0x0000556C
		public virtual int? MaxDepth
		{
			get
			{
				return this._maxDepth;
			}
			set
			{
				this._maxDepth = value;
				this._maxDepthSet = true;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000225 RID: 549 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x06000226 RID: 550 RVA: 0x00007388 File Offset: 0x00005588
		public virtual bool CheckAdditionalContent
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00007398 File Offset: 0x00005598
		internal bool IsCheckAdditionalContentSet()
		{
			/*
An exception occurred when decompiling this method (06000227)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Newtonsoft.Json.JsonSerializer::IsCheckAdditionalContentSet()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:valuetype [mscorlib]System.Nullable`1<bool>(var_0_06, ldfld:valuetype [mscorlib]System.Nullable`1<bool>(JsonSerializer::_checkAdditionalContent, ldloc:JsonSerializer(this)))
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

		// Token: 0x06000228 RID: 552 RVA: 0x000073AC File Offset: 0x000055AC
		public JsonSerializer()
		{
			if (!true)
			{
			}
			this._context.m_additionalContext = 1;
			if (!true)
			{
			}
			this._contractResolver = 1;
		}

		// Token: 0x06000229 RID: 553 RVA: 0x0000212A File Offset: 0x0000032A
		public static JsonSerializer Create()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600022A RID: 554 RVA: 0x000073D8 File Offset: 0x000055D8
		public static JsonSerializer Create(JsonSerializerSettings settings)
		{
			JsonSerializer jsonSerializer = JsonSerializer.Create();
			JsonSerializer.ApplySerializerSettings(jsonSerializer, settings);
			return jsonSerializer;
		}

		// Token: 0x0600022B RID: 555 RVA: 0x000073F4 File Offset: 0x000055F4
		public static JsonSerializer CreateDefault()
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (true)
			{
			}
			JsonSerializer jsonSerializer;
			return jsonSerializer;
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00007410 File Offset: 0x00005610
		public static JsonSerializer CreateDefault(JsonSerializerSettings settings)
		{
			JsonSerializer jsonSerializer = JsonSerializer.CreateDefault();
			JsonSerializer.ApplySerializerSettings(jsonSerializer, settings);
			return jsonSerializer;
		}

		// Token: 0x0600022D RID: 557 RVA: 0x0000742C File Offset: 0x0000562C
		private static void ApplySerializerSettings(JsonSerializer serializer, JsonSerializerSettings settings)
		{
			bool flag = CollectionUtils.IsNullOrEmpty(settings.<Converters>k__BackingField);
			IList<JsonConverter> <Converters>k__BackingField = settings.<Converters>k__BackingField;
		}

		// Token: 0x0600022E RID: 558 RVA: 0x0000764C File Offset: 0x0000584C
		public void Populate(TextReader reader, object target)
		{
		}

		// Token: 0x0600022F RID: 559 RVA: 0x0000765C File Offset: 0x0000585C
		public void Populate(JsonReader reader, object target)
		{
		}

		// Token: 0x06000230 RID: 560 RVA: 0x0000766C File Offset: 0x0000586C
		internal virtual void PopulateInternal(JsonReader reader, object target)
		{
			ValidationUtils.ArgumentNotNull(reader, "reader");
			ValidationUtils.ArgumentNotNull(target, "target");
			if (this != null)
			{
				return;
			}
			if (false)
			{
				return;
			}
		}

		// Token: 0x06000231 RID: 561 RVA: 0x0000212A File Offset: 0x0000032A
		public object Deserialize(JsonReader reader)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000232 RID: 562 RVA: 0x0000212A File Offset: 0x0000032A
		public object Deserialize(TextReader reader, Type objectType)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00007698 File Offset: 0x00005898
		public T Deserialize<T>(JsonReader cpp2il__autoParamName__idx_1)
		{
			throw new InvalidCastException();
		}

		// Token: 0x06000234 RID: 564 RVA: 0x0000212A File Offset: 0x0000032A
		public object Deserialize(JsonReader reader, Type objectType)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000235 RID: 565 RVA: 0x000076AC File Offset: 0x000058AC
		internal virtual object DeserializeInternal(JsonReader reader, Type objectType)
		{
			ValidationUtils.ArgumentNotNull(reader, "reader");
			if (this != null)
			{
			}
			if (false)
			{
			}
			object obj;
			return obj;
		}

		// Token: 0x06000236 RID: 566 RVA: 0x000076CC File Offset: 0x000058CC
		private void SetupReader(JsonReader reader, [Out] CultureInfo previousCulture, [Out] DateTimeZoneHandling? previousDateTimeZoneHandling, [Out] DateParseHandling? previousDateParseHandling, [Out] FloatParseHandling? previousFloatParseHandling, [Out] int? previousMaxDepth, [Out] string previousDateFormatString)
		{
			CultureInfo culture = this._culture;
			CultureInfo culture2 = reader.Culture;
		}

		// Token: 0x06000237 RID: 567 RVA: 0x000077F0 File Offset: 0x000059F0
		private void ResetReader(JsonReader reader, CultureInfo previousCulture, DateTimeZoneHandling? previousDateTimeZoneHandling, DateParseHandling? previousDateParseHandling, FloatParseHandling? previousFloatParseHandling, int? previousMaxDepth, string previousDateFormatString)
		{
			if (previousCulture != null)
			{
				reader._culture = previousCulture;
			}
			if (this._maxDepthSet)
			{
				reader.MaxDepth = previousMaxDepth;
			}
			if (this._dateFormatStringSet)
			{
				reader._dateFormatString = previousDateFormatString;
				return;
			}
			if (reader != null)
			{
			}
		}

		// Token: 0x06000238 RID: 568 RVA: 0x0000782C File Offset: 0x00005A2C
		public void Serialize(TextWriter textWriter, object value)
		{
		}

		// Token: 0x06000239 RID: 569 RVA: 0x0000783C File Offset: 0x00005A3C
		public void Serialize(JsonWriter jsonWriter, object value, Type objectType)
		{
		}

		// Token: 0x0600023A RID: 570 RVA: 0x0000784C File Offset: 0x00005A4C
		public void Serialize(TextWriter textWriter, object value, Type objectType)
		{
		}

		// Token: 0x0600023B RID: 571 RVA: 0x0000785C File Offset: 0x00005A5C
		public void Serialize(JsonWriter jsonWriter, object value)
		{
		}

		// Token: 0x0600023C RID: 572 RVA: 0x0000212A File Offset: 0x0000032A
		internal virtual void SerializeInternal(JsonWriter jsonWriter, object value, Type objectType)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600023D RID: 573 RVA: 0x0000786C File Offset: 0x00005A6C
		internal IReferenceResolver GetReferenceResolver()
		{
			/*
An exception occurred when decompiling this method (0600023D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Newtonsoft.Json.Serialization.IReferenceResolver Newtonsoft.Json.JsonSerializer::GetReferenceResolver()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:IReferenceResolver[exp:bool](JsonSerializer::_referenceResolver, ldloc:JsonSerializer(this)))
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

		// Token: 0x0600023E RID: 574 RVA: 0x00007880 File Offset: 0x00005A80
		internal JsonConverter GetMatchingConverter(Type type)
		{
			return JsonSerializer.GetMatchingConverter(this._converters, type);
		}

		// Token: 0x0600023F RID: 575 RVA: 0x0000789C File Offset: 0x00005A9C
		internal static JsonConverter GetMatchingConverter(IList<JsonConverter> converters, Type objectType)
		{
		}

		// Token: 0x06000240 RID: 576 RVA: 0x000078AC File Offset: 0x00005AAC
		internal void OnError(ErrorEventArgs e)
		{
			if (this.Error != null)
			{
				return;
			}
		}

		// Token: 0x040000EF RID: 239
		internal TypeNameHandling _typeNameHandling;

		// Token: 0x040000F0 RID: 240
		internal FormatterAssemblyStyle _typeNameAssemblyFormat;

		// Token: 0x040000F1 RID: 241
		internal PreserveReferencesHandling _preserveReferencesHandling;

		// Token: 0x040000F2 RID: 242
		internal ReferenceLoopHandling _referenceLoopHandling;

		// Token: 0x040000F3 RID: 243
		internal MissingMemberHandling _missingMemberHandling;

		// Token: 0x040000F4 RID: 244
		internal ObjectCreationHandling _objectCreationHandling;

		// Token: 0x040000F5 RID: 245
		internal NullValueHandling _nullValueHandling;

		// Token: 0x040000F6 RID: 246
		internal DefaultValueHandling _defaultValueHandling;

		// Token: 0x040000F7 RID: 247
		internal ConstructorHandling _constructorHandling;

		// Token: 0x040000F8 RID: 248
		internal MetadataPropertyHandling _metadataPropertyHandling;

		// Token: 0x040000F9 RID: 249
		internal JsonConverterCollection _converters;

		// Token: 0x040000FA RID: 250
		internal IContractResolver _contractResolver;

		// Token: 0x040000FB RID: 251
		internal ITraceWriter _traceWriter;

		// Token: 0x040000FC RID: 252
		internal IEqualityComparer _equalityComparer;

		// Token: 0x040000FD RID: 253
		internal SerializationBinder _binder;

		// Token: 0x040000FE RID: 254
		internal StreamingContext _context;

		// Token: 0x040000FF RID: 255
		private IReferenceResolver _referenceResolver;

		// Token: 0x04000100 RID: 256
		private Formatting? _formatting;

		// Token: 0x04000101 RID: 257
		private DateFormatHandling? _dateFormatHandling;

		// Token: 0x04000102 RID: 258
		private DateTimeZoneHandling? _dateTimeZoneHandling;

		// Token: 0x04000103 RID: 259
		private DateParseHandling? _dateParseHandling;

		// Token: 0x04000104 RID: 260
		private FloatFormatHandling? _floatFormatHandling;

		// Token: 0x04000105 RID: 261
		private FloatParseHandling? _floatParseHandling;

		// Token: 0x04000106 RID: 262
		private StringEscapeHandling? _stringEscapeHandling;

		// Token: 0x04000107 RID: 263
		private CultureInfo _culture;

		// Token: 0x04000108 RID: 264
		private int? _maxDepth;

		// Token: 0x04000109 RID: 265
		private bool _maxDepthSet;

		// Token: 0x0400010A RID: 266
		private bool? _checkAdditionalContent;

		// Token: 0x0400010B RID: 267
		private string _dateFormatString;

		// Token: 0x0400010C RID: 268
		private bool _dateFormatStringSet;

		// Token: 0x0400010D RID: 269
		[CompilerGenerated]
		private EventHandler<ErrorEventArgs> Error;
	}
}
