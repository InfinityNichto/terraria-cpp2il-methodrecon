using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	// Token: 0x02000031 RID: 49
	[Preserve]
	public abstract class JsonReader : IDisposable
	{
		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000160 RID: 352 RVA: 0x00005998 File Offset: 0x00003B98
		protected JsonReader.State CurrentState
		{
			get
			{
				return this._currentState;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000161 RID: 353 RVA: 0x000059AC File Offset: 0x00003BAC
		// (set) Token: 0x06000162 RID: 354 RVA: 0x000059C0 File Offset: 0x00003BC0
		public bool CloseInput
		{
			[CompilerGenerated]
			get
			{
				return this.<CloseInput>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000163 RID: 355 RVA: 0x000059D0 File Offset: 0x00003BD0
		// (set) Token: 0x06000164 RID: 356 RVA: 0x000059E4 File Offset: 0x00003BE4
		public bool SupportMultipleContent
		{
			[CompilerGenerated]
			get
			{
				return this.<SupportMultipleContent>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000165 RID: 357 RVA: 0x000059F4 File Offset: 0x00003BF4
		// (set) Token: 0x06000166 RID: 358 RVA: 0x00005A08 File Offset: 0x00003C08
		public virtual char QuoteChar
		{
			get
			{
				return this._quoteChar;
			}
			protected internal set
			{
				this._quoteChar = value;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000167 RID: 359 RVA: 0x00005A1C File Offset: 0x00003C1C
		// (set) Token: 0x06000168 RID: 360 RVA: 0x00005A30 File Offset: 0x00003C30
		public DateTimeZoneHandling DateTimeZoneHandling
		{
			get
			{
				return this._dateTimeZoneHandling;
			}
			set
			{
				this._dateTimeZoneHandling = value;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000169 RID: 361 RVA: 0x00005A44 File Offset: 0x00003C44
		// (set) Token: 0x0600016A RID: 362 RVA: 0x00005A58 File Offset: 0x00003C58
		public DateParseHandling DateParseHandling
		{
			get
			{
				return this._dateParseHandling;
			}
			set
			{
				this._dateParseHandling = value;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600016B RID: 363 RVA: 0x00005A6C File Offset: 0x00003C6C
		// (set) Token: 0x0600016C RID: 364 RVA: 0x00005A80 File Offset: 0x00003C80
		public FloatParseHandling FloatParseHandling
		{
			get
			{
				return this._floatParseHandling;
			}
			set
			{
				this._floatParseHandling = value;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600016D RID: 365 RVA: 0x00005A94 File Offset: 0x00003C94
		// (set) Token: 0x0600016E RID: 366 RVA: 0x00005AA8 File Offset: 0x00003CA8
		public string DateFormatString
		{
			get
			{
				return this._dateFormatString;
			}
			set
			{
				this._dateFormatString = value;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600016F RID: 367 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x06000170 RID: 368 RVA: 0x00005ABC File Offset: 0x00003CBC
		public int? MaxDepth
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000171 RID: 369 RVA: 0x00005ACC File Offset: 0x00003CCC
		public virtual JsonToken TokenType
		{
			get
			{
				return this._tokenType;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000172 RID: 370 RVA: 0x00005AE0 File Offset: 0x00003CE0
		public virtual object Value
		{
			get
			{
				return this._value;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000173 RID: 371 RVA: 0x00005AF4 File Offset: 0x00003CF4
		public virtual Type ValueType
		{
			get
			{
				object value = this._value;
				Type type;
				if (value != null)
				{
					type = value.GetType();
					return type;
				}
				return type;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000174 RID: 372 RVA: 0x00005B18 File Offset: 0x00003D18
		public virtual int Depth
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000174)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Newtonsoft.Json.JsonReader::get_Depth()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0011:
	stloc:JsonPosition(var_4_19, ldfld:JsonPosition(JsonReader::_currentPosition, ldloc:JsonReader(this)))
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
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000175 RID: 373 RVA: 0x00005B40 File Offset: 0x00003D40
		public virtual string Path
		{
			get
			{
				if (this._currentPosition != null)
				{
					JsonReader.State currentState = this._currentState;
				}
				List<JsonPosition> stack = this._stack;
				string text;
				return text;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000176 RID: 374 RVA: 0x00005B64 File Offset: 0x00003D64
		// (set) Token: 0x06000177 RID: 375 RVA: 0x00005B84 File Offset: 0x00003D84
		public CultureInfo Culture
		{
			get
			{
				CultureInfo culture = this._culture;
				if (culture != null)
				{
					return culture;
				}
				return CultureInfo.InvariantCulture;
			}
			set
			{
				this._culture = value;
			}
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00005B98 File Offset: 0x00003D98
		internal JsonPosition GetPosition(int depth)
		{
			/*
An exception occurred when decompiling this method (06000178)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Newtonsoft.Json.JsonPosition Newtonsoft.Json.JsonReader::GetPosition(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0011:
	stloc:bool(var_3_1C, ldfld:bool(JsonPosition::HasIndex, ldfld:JsonPosition[exp:valuetype Newtonsoft.Json.JsonPosition&](JsonReader::_currentPosition, ldloc:JsonReader(this))))
	stfld:bool(JsonPosition::HasIndex, ldloc:JsonPosition[exp:valuetype Newtonsoft.Json.JsonPosition&](var_0), ldloc:bool(var_3_1C))
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

		// Token: 0x06000179 RID: 377 RVA: 0x00005BC8 File Offset: 0x00003DC8
		protected JsonReader()
		{
			this._dateTimeZoneHandling = DateTimeZoneHandling.RoundtripKind;
			this.<CloseInput>k__BackingField = true;
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00005BEC File Offset: 0x00003DEC
		private void Push(JsonContainerType value)
		{
			if (this._currentPosition.HasIndex)
			{
				int position = this._currentPosition.Position;
				this._currentPosition.Position = position;
			}
			JsonToken tokenType;
			if (this._currentPosition != null)
			{
				if (this._stack == null)
				{
				}
				tokenType = this._tokenType;
				return;
			}
			this._tokenType = tokenType;
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00005C7C File Offset: 0x00003E7C
		private JsonContainerType Pop()
		{
			/*
An exception occurred when decompiling this method (0600017B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Newtonsoft.Json.JsonContainerType Newtonsoft.Json.JsonReader::Pop()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_1:
	brtrue(IL_0000, logicnot:bool(ldfld:valuetype [mscorlib]System.Nullable`1<int32>[exp:bool](JsonReader::_maxDepth, ldloc:JsonReader(this))))
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

		// Token: 0x0600017C RID: 380 RVA: 0x00005CC4 File Offset: 0x00003EC4
		private JsonContainerType Peek()
		{
			/*
An exception occurred when decompiling this method (0600017C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Newtonsoft.Json.JsonContainerType Newtonsoft.Json.JsonReader::Peek()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:JsonPosition(var_0_06, ldfld:JsonPosition(JsonReader::_currentPosition, ldloc:JsonReader(this)))
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

		// Token: 0x0600017D RID: 381
		public abstract bool Read();

		// Token: 0x0600017E RID: 382 RVA: 0x00005CD8 File Offset: 0x00003ED8
		public virtual int? ReadAsInt32()
		{
			JsonToken contentToken = this.GetContentToken();
			if (this != null)
			{
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			int num = Convert.ToInt32(this, invariantCulture);
			JsonPosition currentPosition = this._currentPosition;
			this._tokenType = JsonToken.Integer;
			if (currentPosition != null)
			{
				if (this != null)
				{
				}
				int? num2;
				return num2;
			}
			bool flag = this.<SupportMultipleContent>k__BackingField;
			this._currentState = JsonReader.State.Finished;
			CultureInfo invariantCulture2 = CultureInfo.InvariantCulture;
			throw new InvalidCastException();
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00005D40 File Offset: 0x00003F40
		internal int? ReadInt32String(string s)
		{
			/*
An exception occurred when decompiling this method (0600017F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Nullable`1<System.Int32> Newtonsoft.Json.JsonReader::ReadInt32String(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0046:
	stloc:bool(var_7_4C, ldfld:bool(JsonReader::<SupportMultipleContent>k__BackingField, ldloc:JsonReader(this)))
	stfld:State(JsonReader::_currentState, ldloc:JsonReader(this), ldc.i4:State(12))
	stloc:CultureInfo(var_9_5E, callgetter:CultureInfo(CultureInfo::get_InvariantCulture))
	stloc:JsonReaderException(var_11_68, call:JsonReaderException(JsonReaderException::Create, ldloc:JsonReader(this), ldloc:string(var_10)))
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

		// Token: 0x06000180 RID: 384 RVA: 0x00005DB8 File Offset: 0x00003FB8
		public virtual string ReadAsString()
		{
			JsonToken contentToken = this.GetContentToken();
			string text;
			if (contentToken != JsonToken.None)
			{
				if (this != null)
				{
					throw new InvalidCastException();
				}
			}
			else
			{
				if (this != null)
				{
				}
				long value = 0.m_value;
				if (this != null)
				{
				}
				JsonPosition currentPosition = this._currentPosition;
				int num = 9;
				this._tokenType = (JsonToken)num;
				this._value = text;
				if (currentPosition != null)
				{
				}
				bool flag = this.<SupportMultipleContent>k__BackingField;
				int num2 = 12;
				this._currentState = (JsonReader.State)num2;
			}
			return text;
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00005E58 File Offset: 0x00004058
		public virtual byte[] ReadAsBytes()
		{
			byte[] array;
			if (this.GetContentToken() != JsonToken.None)
			{
				this.ReadIntoWrappedTypeObject();
				this.ReaderReadAndAssert();
				JsonPosition currentPosition = this._currentPosition;
				this._tokenType = JsonToken.Bytes;
				this._value = this;
				if (currentPosition != null)
				{
					if (17 == 0)
					{
					}
					if (this == null)
					{
						return array;
					}
					if (this == null)
					{
						throw new InvalidCastException();
					}
				}
				byte[] array2;
				return array2;
			}
			return array;
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00005ECC File Offset: 0x000040CC
		internal byte[] ReadArrayIntoByteArray()
		{
			JsonToken contentToken = this.GetContentToken();
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			return Convert.ToByte(this, invariantCulture);
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00005F34 File Offset: 0x00004134
		public virtual double? ReadAsDouble()
		{
			JsonToken contentToken = this.GetContentToken();
			if (this != null)
			{
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			double num = Convert.ToDouble(this, invariantCulture);
			JsonPosition currentPosition = this._currentPosition;
			this._tokenType = JsonToken.Float;
			if (currentPosition == null)
			{
				bool flag = this.<SupportMultipleContent>k__BackingField;
			}
			this._currentState = JsonReader.State.Finished;
			double? num2;
			return num2;
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00005F98 File Offset: 0x00004198
		internal double? ReadDoubleString(string s)
		{
			/*
An exception occurred when decompiling this method (06000184)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Nullable`1<System.Double> Newtonsoft.Json.JsonReader::ReadDoubleString(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0043:
	stloc:bool(var_6_49, ldfld:bool(JsonReader::<SupportMultipleContent>k__BackingField, ldloc:JsonReader(this)))
	stfld:State(JsonReader::_currentState, ldloc:JsonReader(this), ldc.i4:State(12))
	stloc:CultureInfo(var_8_5B, callgetter:CultureInfo(CultureInfo::get_InvariantCulture))
	stloc:JsonReaderException(var_10_65, call:JsonReaderException(JsonReaderException::Create, ldloc:JsonReader(this), ldloc:string(var_9)))
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

		// Token: 0x06000185 RID: 389 RVA: 0x0000600C File Offset: 0x0000420C
		public virtual bool? ReadAsBoolean()
		{
			JsonToken contentToken = this.GetContentToken();
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			bool flag = Convert.ToBoolean(this, invariantCulture);
			JsonPosition currentPosition = this._currentPosition;
			int num = 10;
			this._tokenType = (JsonToken)num;
			if (currentPosition != null)
			{
				if (this != null)
				{
				}
				bool? flag2;
				return flag2;
			}
			bool flag3 = this.<SupportMultipleContent>k__BackingField;
			int num2 = 12;
			this._currentState = (JsonReader.State)num2;
			CultureInfo invariantCulture2 = CultureInfo.InvariantCulture;
			string text;
			JsonReaderException ex = JsonReaderException.Create(this, text);
			throw new InvalidCastException();
		}

		// Token: 0x06000186 RID: 390 RVA: 0x0000607C File Offset: 0x0000427C
		internal bool? ReadBooleanString(string s)
		{
			/*
An exception occurred when decompiling this method (06000186)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Nullable`1<System.Boolean> Newtonsoft.Json.JsonReader::ReadBooleanString(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0041:
	stloc:bool(var_6_47, ldfld:bool(JsonReader::<SupportMultipleContent>k__BackingField, ldloc:JsonReader(this)))
	stfld:State(JsonReader::_currentState, ldloc:JsonReader(this), ldc.i4:State(12))
	stloc:CultureInfo(var_8_59, callgetter:CultureInfo(CultureInfo::get_InvariantCulture))
	stloc:JsonReaderException(var_10_63, call:JsonReaderException(JsonReaderException::Create, ldloc:JsonReader(this), ldloc:string(var_9)))
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

		// Token: 0x06000187 RID: 391 RVA: 0x000060F0 File Offset: 0x000042F0
		public virtual decimal? ReadAsDecimal()
		{
			JsonToken contentToken = this.GetContentToken();
			if (this != null)
			{
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			decimal num = Convert.ToDecimal(this, invariantCulture);
			JsonPosition currentPosition = this._currentPosition;
			this._tokenType = JsonToken.Float;
			if (currentPosition == null)
			{
				bool flag = this.<SupportMultipleContent>k__BackingField;
			}
			this._currentState = JsonReader.State.Finished;
			decimal? num2;
			return num2;
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00006154 File Offset: 0x00004354
		internal decimal? ReadDecimalString(string s)
		{
			/*
An exception occurred when decompiling this method (06000188)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Nullable`1<System.Decimal> Newtonsoft.Json.JsonReader::ReadDecimalString(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0047:
	stloc:bool(var_6_4D, ldfld:bool(JsonReader::<SupportMultipleContent>k__BackingField, ldloc:JsonReader(this)))
	stfld:State(JsonReader::_currentState, ldloc:JsonReader(this), ldc.i4:State(12))
	stloc:CultureInfo(var_8_5F, callgetter:CultureInfo(CultureInfo::get_InvariantCulture))
	stloc:JsonReaderException(var_10_69, call:JsonReaderException(JsonReaderException::Create, ldloc:JsonReader(this), ldloc:string(var_9)))
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

		// Token: 0x06000189 RID: 393 RVA: 0x000061CC File Offset: 0x000043CC
		public virtual DateTime? ReadAsDateTime()
		{
			DateTime? dateTime;
			if (this.GetContentToken() != JsonToken.None)
			{
				if (this != null)
				{
				}
				return dateTime;
			}
			return dateTime;
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00006224 File Offset: 0x00004424
		internal DateTime? ReadDateTimeString(string s)
		{
			/*
An exception occurred when decompiling this method (0600018A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Nullable`1<System.DateTime> Newtonsoft.Json.JsonReader::ReadDateTimeString(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_006B:
	stloc:bool(var_12_71, ldfld:bool(JsonReader::<SupportMultipleContent>k__BackingField, ldloc:JsonReader(this)))
	stfld:State(JsonReader::_currentState, ldloc:JsonReader(this), ldc.i4:State(12))
	stloc:CultureInfo(var_14_83, callgetter:CultureInfo(CultureInfo::get_InvariantCulture))
	stloc:JsonReaderException(var_16_8D, call:JsonReaderException(JsonReaderException::Create, ldloc:JsonReader(this), ldloc:string(var_15)))
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

		// Token: 0x0600018B RID: 395 RVA: 0x000062C0 File Offset: 0x000044C0
		public virtual DateTimeOffset? ReadAsDateTimeOffset()
		{
			DateTimeOffset? dateTimeOffset;
			if (this.GetContentToken() != JsonToken.None)
			{
				if (this != null)
				{
				}
				return dateTimeOffset;
			}
			return dateTimeOffset;
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00006314 File Offset: 0x00004514
		internal DateTimeOffset? ReadDateTimeOffsetString(string s)
		{
			/*
An exception occurred when decompiling this method (0600018C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Nullable`1<System.DateTimeOffset> Newtonsoft.Json.JsonReader::ReadDateTimeOffsetString(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_005B:
	stloc:bool(var_9_61, ldfld:bool(JsonReader::<SupportMultipleContent>k__BackingField, ldloc:JsonReader(this)))
	stfld:State(JsonReader::_currentState, ldloc:JsonReader(this), ldc.i4:State(12))
	stloc:CultureInfo(var_11_73, callgetter:CultureInfo(CultureInfo::get_InvariantCulture))
	stloc:JsonReaderException(var_13_7D, call:JsonReaderException(JsonReaderException::Create, ldloc:JsonReader(this), ldloc:string(var_12)))
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

		// Token: 0x0600018D RID: 397 RVA: 0x000063A0 File Offset: 0x000045A0
		internal void ReaderReadAndAssert()
		{
		}

		// Token: 0x0600018E RID: 398 RVA: 0x000063B4 File Offset: 0x000045B4
		internal JsonReaderException CreateUnexpectedEndException()
		{
			JsonReaderException ex;
			return ex;
		}

		// Token: 0x0600018F RID: 399 RVA: 0x000063C4 File Offset: 0x000045C4
		internal void ReadIntoWrappedTypeObject()
		{
			/*
An exception occurred when decompiling this method (0600018F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Newtonsoft.Json.JsonReader::ReadIntoWrappedTypeObject()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0016:
	stloc:CultureInfo(var_4_1D, callgetter:CultureInfo(CultureInfo::get_InvariantCulture))
	stloc:JsonReaderException(var_6_27, call:JsonReaderException(JsonReaderException::Create, ldloc:JsonReader(this), ldloc:string(var_5)))
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

		// Token: 0x06000190 RID: 400 RVA: 0x000063FC File Offset: 0x000045FC
		public void Skip()
		{
		}

		// Token: 0x06000191 RID: 401 RVA: 0x0000640C File Offset: 0x0000460C
		protected void SetToken(JsonToken newToken)
		{
			long num = 0L;
			this.SetToken(newToken, num, true);
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00006424 File Offset: 0x00004624
		protected void SetToken(JsonToken newToken, object value)
		{
			this.SetToken(newToken, value, true);
		}

		// Token: 0x06000193 RID: 403 RVA: 0x0000643C File Offset: 0x0000463C
		internal void SetToken(JsonToken newToken, object value, bool updateIndex)
		{
			this._tokenType = newToken;
			this._value = value;
		}

		// Token: 0x06000194 RID: 404 RVA: 0x000064CC File Offset: 0x000046CC
		internal void SetPostValueState(bool updateIndex)
		{
			if (this._currentPosition != null)
			{
				return;
			}
			bool flag = this.<SupportMultipleContent>k__BackingField;
			int num = 12;
			this._currentState = (JsonReader.State)num;
			if (this._currentPosition.HasIndex)
			{
				int position = this._currentPosition.Position;
				this._currentPosition.Position = position;
			}
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00006518 File Offset: 0x00004718
		private void UpdateScopeWithFinishedValue()
		{
			if (this._currentPosition.HasIndex)
			{
				int position = this._currentPosition.Position;
				this._currentPosition.Position = position;
			}
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0000654C File Offset: 0x0000474C
		private void ValidateEnd(JsonToken endToken)
		{
			JsonContainerType jsonContainerType = this.Pop();
			JsonContainerType typeForCloseToken = this.GetTypeForCloseToken(endToken);
			if (this._currentPosition != null)
			{
				return;
			}
			bool flag = this.<SupportMultipleContent>k__BackingField;
			this._currentState = JsonReader.State.Finished;
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00006594 File Offset: 0x00004794
		protected void SetStateBasedOnCurrent()
		{
			JsonPosition currentPosition = this._currentPosition;
		}

		// Token: 0x06000198 RID: 408 RVA: 0x000065D0 File Offset: 0x000047D0
		private void SetFinished()
		{
			bool flag = this.<SupportMultipleContent>k__BackingField;
			this._currentState = JsonReader.State.Finished;
		}

		// Token: 0x06000199 RID: 409 RVA: 0x000065EC File Offset: 0x000047EC
		private JsonContainerType GetTypeForCloseToken(JsonToken token)
		{
			/*
An exception occurred when decompiling this method (06000199)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Newtonsoft.Json.JsonContainerType Newtonsoft.Json.JsonReader::GetTypeForCloseToken(Newtonsoft.Json.JsonToken)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:CultureInfo(var_1_07, callgetter:CultureInfo(CultureInfo::get_InvariantCulture))
	stloc:JsonReaderException(var_3_0F, call:JsonReaderException(JsonReaderException::Create, ldloc:JsonReader(this), ldloc:string(var_2)))
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

		// Token: 0x0600019A RID: 410 RVA: 0x00006608 File Offset: 0x00004808
		void IDisposable.Dispose()
		{
			GC.SuppressFinalize(this);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0000661C File Offset: 0x0000481C
		protected virtual void Dispose(bool disposing)
		{
			JsonReader.State currentState = this._currentState;
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00006634 File Offset: 0x00004834
		public virtual void Close()
		{
			this._currentState = JsonReader.State.Closed;
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00006648 File Offset: 0x00004848
		internal void ReadAndAssert()
		{
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00006664 File Offset: 0x00004864
		internal bool ReadAndMoveToContent()
		{
			return this.MoveToContent();
		}

		// Token: 0x0600019F RID: 415 RVA: 0x0000667C File Offset: 0x0000487C
		internal bool MoveToContent()
		{
			if (this != null)
			{
			}
			return true;
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00006690 File Offset: 0x00004890
		private JsonToken GetContentToken()
		{
		}

		// Token: 0x040000C9 RID: 201
		private JsonToken _tokenType;

		// Token: 0x040000CA RID: 202
		private object _value;

		// Token: 0x040000CB RID: 203
		internal char _quoteChar;

		// Token: 0x040000CC RID: 204
		internal JsonReader.State _currentState;

		// Token: 0x040000CD RID: 205
		private JsonPosition _currentPosition;

		// Token: 0x040000CE RID: 206
		private CultureInfo _culture;

		// Token: 0x040000CF RID: 207
		private DateTimeZoneHandling _dateTimeZoneHandling;

		// Token: 0x040000D0 RID: 208
		private int? _maxDepth;

		// Token: 0x040000D1 RID: 209
		private bool _hasExceededMaxDepth;

		// Token: 0x040000D2 RID: 210
		internal DateParseHandling _dateParseHandling;

		// Token: 0x040000D3 RID: 211
		internal FloatParseHandling _floatParseHandling;

		// Token: 0x040000D4 RID: 212
		private string _dateFormatString;

		// Token: 0x040000D5 RID: 213
		private List<JsonPosition> _stack;

		// Token: 0x040000D6 RID: 214
		[CompilerGenerated]
		private bool <CloseInput>k__BackingField;

		// Token: 0x040000D7 RID: 215
		[CompilerGenerated]
		private bool <SupportMultipleContent>k__BackingField;

		// Token: 0x02000032 RID: 50
		protected internal enum State
		{
			// Token: 0x040000D9 RID: 217
			Start,
			// Token: 0x040000DA RID: 218
			Complete,
			// Token: 0x040000DB RID: 219
			Property,
			// Token: 0x040000DC RID: 220
			ObjectStart,
			// Token: 0x040000DD RID: 221
			Object,
			// Token: 0x040000DE RID: 222
			ArrayStart,
			// Token: 0x040000DF RID: 223
			Array,
			// Token: 0x040000E0 RID: 224
			Closed,
			// Token: 0x040000E1 RID: 225
			PostValue,
			// Token: 0x040000E2 RID: 226
			ConstructorStart,
			// Token: 0x040000E3 RID: 227
			Constructor,
			// Token: 0x040000E4 RID: 228
			Error,
			// Token: 0x040000E5 RID: 229
			Finished
		}
	}
}
