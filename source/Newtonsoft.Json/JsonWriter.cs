using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json
{
	// Token: 0x0200003B RID: 59
	[Preserve]
	public abstract class JsonWriter : IDisposable
	{
		// Token: 0x06000241 RID: 577 RVA: 0x000078C4 File Offset: 0x00005AC4
		internal static JsonWriter.State[][] BuildStateArray()
		{
			if (!true)
			{
			}
			Type type;
			IList<object> values = EnumUtils.GetValues(type);
			long num = 0L;
			int num2 = 7;
			if (values != null)
			{
			}
			if (num == 0L)
			{
				if (num2 == 0)
				{
				}
				throw new InvalidCastException();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00007910 File Offset: 0x00005B10
		static JsonWriter()
		{
			JsonWriter.State[][] array = JsonWriter.BuildStateArray();
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000243 RID: 579 RVA: 0x0000792C File Offset: 0x00005B2C
		// (set) Token: 0x06000244 RID: 580 RVA: 0x00007940 File Offset: 0x00005B40
		public bool CloseOutput
		{
			[CompilerGenerated]
			get
			{
				return this.<CloseOutput>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000245 RID: 581 RVA: 0x00007950 File Offset: 0x00005B50
		protected internal int Top
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000245)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Newtonsoft.Json.JsonWriter::get_Top()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0011:
	stloc:JsonPosition(var_2_17, ldfld:JsonPosition(JsonWriter::_currentPosition, ldloc:JsonWriter(this)))
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

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000246 RID: 582 RVA: 0x00007974 File Offset: 0x00005B74
		public WriteState WriteState
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000246)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Newtonsoft.Json.WriteState Newtonsoft.Json.JsonWriter::get_WriteState()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:State(var_0_06, ldfld:State(JsonWriter::_currentState, ldloc:JsonWriter(this)))
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

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000247 RID: 583 RVA: 0x00007988 File Offset: 0x00005B88
		internal string ContainerPath
		{
			get
			{
				while (this._currentPosition == null || this._stack == null)
				{
				}
				string text;
				return text;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000248 RID: 584 RVA: 0x000079A8 File Offset: 0x00005BA8
		public string Path
		{
			get
			{
				if (this._currentPosition != null)
				{
					JsonWriter.State currentState = this._currentState;
				}
				List<JsonPosition> stack = this._stack;
				string text;
				return text;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000249 RID: 585 RVA: 0x000079CC File Offset: 0x00005BCC
		// (set) Token: 0x0600024A RID: 586 RVA: 0x000079E0 File Offset: 0x00005BE0
		public Formatting Formatting
		{
			get
			{
				return this._formatting;
			}
			set
			{
				this._formatting = value;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600024B RID: 587 RVA: 0x000079F4 File Offset: 0x00005BF4
		// (set) Token: 0x0600024C RID: 588 RVA: 0x00007A08 File Offset: 0x00005C08
		public DateFormatHandling DateFormatHandling
		{
			get
			{
				return this._dateFormatHandling;
			}
			set
			{
				this._dateFormatHandling = value;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600024D RID: 589 RVA: 0x00007A1C File Offset: 0x00005C1C
		// (set) Token: 0x0600024E RID: 590 RVA: 0x00007A30 File Offset: 0x00005C30
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

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600024F RID: 591 RVA: 0x00007A44 File Offset: 0x00005C44
		// (set) Token: 0x06000250 RID: 592 RVA: 0x00007A58 File Offset: 0x00005C58
		public StringEscapeHandling StringEscapeHandling
		{
			get
			{
				return this._stringEscapeHandling;
			}
			set
			{
				this._stringEscapeHandling = value;
			}
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00007A6C File Offset: 0x00005C6C
		internal virtual void OnStringEscapeHandlingChanged()
		{
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000252 RID: 594 RVA: 0x00007A7C File Offset: 0x00005C7C
		// (set) Token: 0x06000253 RID: 595 RVA: 0x00007A90 File Offset: 0x00005C90
		public FloatFormatHandling FloatFormatHandling
		{
			get
			{
				return this._floatFormatHandling;
			}
			set
			{
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000254 RID: 596 RVA: 0x00007AA0 File Offset: 0x00005CA0
		// (set) Token: 0x06000255 RID: 597 RVA: 0x00007AB4 File Offset: 0x00005CB4
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

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000256 RID: 598 RVA: 0x00007AC8 File Offset: 0x00005CC8
		// (set) Token: 0x06000257 RID: 599 RVA: 0x00007AE8 File Offset: 0x00005CE8
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

		// Token: 0x06000258 RID: 600 RVA: 0x00007AFC File Offset: 0x00005CFC
		protected JsonWriter()
		{
			this._dateTimeZoneHandling = DateTimeZoneHandling.RoundtripKind;
			this.<CloseOutput>k__BackingField = true;
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00007B20 File Offset: 0x00005D20
		internal void UpdateScopeWithFinishedValue()
		{
			if (this._currentPosition.HasIndex)
			{
				int position = this._currentPosition.Position;
				this._currentPosition.Position = position;
			}
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00007B54 File Offset: 0x00005D54
		private void Push(JsonContainerType value)
		{
			List<JsonPosition> stack;
			if (this._currentPosition != null)
			{
				if (this._stack == null)
				{
				}
				stack = this._stack;
				return;
			}
			this._stack = stack;
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00007B80 File Offset: 0x00005D80
		private JsonContainerType Pop()
		{
			/*
An exception occurred when decompiling this method (0600025B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Newtonsoft.Json.JsonContainerType Newtonsoft.Json.JsonWriter::Pop()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_2_17, ldfld:int32(List`1::_size, ldloc:class [mscorlib]System.Collections.Generic.List`1<valuetype Newtonsoft.Json.JsonPosition>[exp:List`1](var_0_06)))
	stloc:int32(var_3_23, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<valuetype Newtonsoft.Json.JsonPosition>[exp:List`1](JsonWriter::_stack, ldloc:JsonWriter(this))))
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

		// Token: 0x0600025C RID: 604 RVA: 0x00007BB0 File Offset: 0x00005DB0
		private JsonContainerType Peek()
		{
			/*
An exception occurred when decompiling this method (0600025C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Newtonsoft.Json.JsonContainerType Newtonsoft.Json.JsonWriter::Peek()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:JsonPosition(var_0_06, ldfld:JsonPosition(JsonWriter::_currentPosition, ldloc:JsonWriter(this)))
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

		// Token: 0x0600025D RID: 605
		public abstract void Flush();

		// Token: 0x0600025E RID: 606 RVA: 0x00007BC4 File Offset: 0x00005DC4
		public virtual void Close()
		{
			this.AutoCompleteAll();
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00007BD8 File Offset: 0x00005DD8
		public virtual void WriteStartObject()
		{
			this.InternalWriteStart(JsonToken.StartObject, JsonContainerType.Object);
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00007BF0 File Offset: 0x00005DF0
		public virtual void WriteEndObject()
		{
			this.AutoCompleteClose(JsonContainerType.Object);
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00007C04 File Offset: 0x00005E04
		public virtual void WriteStartArray()
		{
			this.InternalWriteStart(JsonToken.StartArray, JsonContainerType.Array);
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00007C1C File Offset: 0x00005E1C
		public virtual void WriteEndArray()
		{
			this.AutoCompleteClose(JsonContainerType.Array);
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00007C30 File Offset: 0x00005E30
		public virtual void WriteStartConstructor(string name)
		{
			this.InternalWriteStart(JsonToken.StartConstructor, JsonContainerType.Constructor);
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00007C48 File Offset: 0x00005E48
		public virtual void WriteEndConstructor()
		{
			this.AutoCompleteClose(JsonContainerType.Constructor);
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00007C5C File Offset: 0x00005E5C
		public virtual void WritePropertyName(string name)
		{
			this._currentPosition.PropertyName = name;
			this.AutoComplete(JsonToken.PropertyName);
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00007C7C File Offset: 0x00005E7C
		public virtual void WritePropertyName(string name, bool escape)
		{
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00007C8C File Offset: 0x00005E8C
		public virtual void WriteEnd()
		{
			JsonPosition currentPosition = this._currentPosition;
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00007CA0 File Offset: 0x00005EA0
		public void WriteToken(JsonReader reader)
		{
			this.WriteToken(reader, true);
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00007CB8 File Offset: 0x00005EB8
		public void WriteToken(JsonReader reader, bool writeChildren)
		{
			ValidationUtils.ArgumentNotNull(reader, "reader");
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00007CD0 File Offset: 0x00005ED0
		public void WriteToken(JsonToken token, object value)
		{
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00007D64 File Offset: 0x00005F64
		public void WriteToken(JsonToken token)
		{
			long num = 0L;
			this.WriteToken(token, num);
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00007D7C File Offset: 0x00005F7C
		internal virtual void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments)
		{
			if (reader != null)
			{
				return;
			}
			this.WriteConstructorDate(reader);
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00007D98 File Offset: 0x00005F98
		private void WriteConstructorDate(JsonReader reader)
		{
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00007DB0 File Offset: 0x00005FB0
		private void WriteEnd(JsonContainerType type)
		{
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00007DC0 File Offset: 0x00005FC0
		private void AutoCompleteAll()
		{
			int top = this.Top;
			int top2 = this.Top;
		}

		// Token: 0x06000270 RID: 624 RVA: 0x0000212A File Offset: 0x0000032A
		private JsonToken GetCloseTokenForType(JsonContainerType type)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00007DDC File Offset: 0x00005FDC
		private void AutoCompleteClose(JsonContainerType type)
		{
			JsonPosition currentPosition = this._currentPosition;
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00007E30 File Offset: 0x00006030
		protected virtual void WriteEnd(JsonToken token)
		{
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00007E40 File Offset: 0x00006040
		protected virtual void WriteIndent()
		{
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00007E50 File Offset: 0x00006050
		protected virtual void WriteValueDelimiter()
		{
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00007E60 File Offset: 0x00006060
		protected virtual void WriteIndentSpace()
		{
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00007E70 File Offset: 0x00006070
		internal void AutoComplete(JsonToken tokenBeingWritten)
		{
			if (!true)
			{
			}
			Formatting formatting = this._formatting;
			JsonWriter.State currentState = this._currentState;
			if (this._currentState != JsonWriter.State.Start)
			{
			}
		}

		// Token: 0x06000277 RID: 631 RVA: 0x00007EC0 File Offset: 0x000060C0
		public virtual void WriteNull()
		{
			if (this._currentPosition.HasIndex)
			{
				int position = this._currentPosition.Position;
				this._currentPosition.Position = position;
			}
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00007EF4 File Offset: 0x000060F4
		public virtual void WriteUndefined()
		{
			if (this._currentPosition.HasIndex)
			{
				int position = this._currentPosition.Position;
				this._currentPosition.Position = position;
			}
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00007F28 File Offset: 0x00006128
		public virtual void WriteRaw(string json)
		{
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00007F38 File Offset: 0x00006138
		public virtual void WriteRawValue(string json)
		{
			if (this._currentPosition.HasIndex)
			{
				int position = this._currentPosition.Position;
				this._currentPosition.Position = position;
			}
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00007F6C File Offset: 0x0000616C
		public virtual void WriteValue(string value)
		{
			if (this._currentPosition.HasIndex)
			{
				int position = this._currentPosition.Position;
				this._currentPosition.Position = position;
			}
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00007FA0 File Offset: 0x000061A0
		public virtual void WriteValue(int value)
		{
			if (this._currentPosition.HasIndex)
			{
				int position = this._currentPosition.Position;
				this._currentPosition.Position = position;
			}
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00007FD4 File Offset: 0x000061D4
		[CLSCompliant(false)]
		public virtual void WriteValue(uint value)
		{
			if (this._currentPosition.HasIndex)
			{
				int position = this._currentPosition.Position;
				this._currentPosition.Position = position;
			}
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00008008 File Offset: 0x00006208
		public virtual void WriteValue(long value)
		{
			if (this._currentPosition.HasIndex)
			{
				int position = this._currentPosition.Position;
				this._currentPosition.Position = position;
			}
		}

		// Token: 0x0600027F RID: 639 RVA: 0x0000803C File Offset: 0x0000623C
		[CLSCompliant(false)]
		public virtual void WriteValue(ulong value)
		{
			if (this._currentPosition.HasIndex)
			{
				int position = this._currentPosition.Position;
				this._currentPosition.Position = position;
			}
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00008070 File Offset: 0x00006270
		public virtual void WriteValue(float value)
		{
			if (this._currentPosition.HasIndex)
			{
				int position = this._currentPosition.Position;
				this._currentPosition.Position = position;
			}
		}

		// Token: 0x06000281 RID: 641 RVA: 0x000080A4 File Offset: 0x000062A4
		public virtual void WriteValue(double value)
		{
			if (this._currentPosition.HasIndex)
			{
				int position = this._currentPosition.Position;
				this._currentPosition.Position = position;
			}
		}

		// Token: 0x06000282 RID: 642 RVA: 0x000080D8 File Offset: 0x000062D8
		public virtual void WriteValue(bool value)
		{
			if (this._currentPosition.HasIndex)
			{
				int position = this._currentPosition.Position;
				this._currentPosition.Position = position;
			}
		}

		// Token: 0x06000283 RID: 643 RVA: 0x0000810C File Offset: 0x0000630C
		public virtual void WriteValue(short value)
		{
			if (this._currentPosition.HasIndex)
			{
				int position = this._currentPosition.Position;
				this._currentPosition.Position = position;
			}
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00008140 File Offset: 0x00006340
		[CLSCompliant(false)]
		public virtual void WriteValue(ushort value)
		{
			if (this._currentPosition.HasIndex)
			{
				int position = this._currentPosition.Position;
				this._currentPosition.Position = position;
			}
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00008174 File Offset: 0x00006374
		public virtual void WriteValue(char value)
		{
			if (this._currentPosition.HasIndex)
			{
				int position = this._currentPosition.Position;
				this._currentPosition.Position = position;
			}
		}

		// Token: 0x06000286 RID: 646 RVA: 0x000081A8 File Offset: 0x000063A8
		public virtual void WriteValue(byte value)
		{
			if (this._currentPosition.HasIndex)
			{
				int position = this._currentPosition.Position;
				this._currentPosition.Position = position;
			}
		}

		// Token: 0x06000287 RID: 647 RVA: 0x000081DC File Offset: 0x000063DC
		[CLSCompliant(false)]
		public virtual void WriteValue(sbyte value)
		{
			if (this._currentPosition.HasIndex)
			{
				int position = this._currentPosition.Position;
				this._currentPosition.Position = position;
			}
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00008210 File Offset: 0x00006410
		public virtual void WriteValue(decimal value)
		{
			if (this._currentPosition.HasIndex)
			{
				int position = this._currentPosition.Position;
				this._currentPosition.Position = position;
			}
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00008244 File Offset: 0x00006444
		public virtual void WriteValue(DateTime value)
		{
			if (this._currentPosition.HasIndex)
			{
				int position = this._currentPosition.Position;
				this._currentPosition.Position = position;
			}
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00008278 File Offset: 0x00006478
		public virtual void WriteValue(DateTimeOffset value)
		{
			if (this._currentPosition.HasIndex)
			{
				int position = this._currentPosition.Position;
				this._currentPosition.Position = position;
			}
		}

		// Token: 0x0600028B RID: 651 RVA: 0x000082AC File Offset: 0x000064AC
		public virtual void WriteValue(Guid value)
		{
			if (this._currentPosition.HasIndex)
			{
				int position = this._currentPosition.Position;
				this._currentPosition.Position = position;
			}
		}

		// Token: 0x0600028C RID: 652 RVA: 0x000082E0 File Offset: 0x000064E0
		public virtual void WriteValue(TimeSpan value)
		{
			if (this._currentPosition.HasIndex)
			{
				int position = this._currentPosition.Position;
				this._currentPosition.Position = position;
			}
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00008314 File Offset: 0x00006514
		public virtual void WriteValue(int? value)
		{
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00008324 File Offset: 0x00006524
		[CLSCompliant(false)]
		public virtual void WriteValue(uint? value)
		{
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00008334 File Offset: 0x00006534
		public virtual void WriteValue(long? value)
		{
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00008344 File Offset: 0x00006544
		[CLSCompliant(false)]
		public virtual void WriteValue(ulong? value)
		{
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00008354 File Offset: 0x00006554
		public virtual void WriteValue(float? value)
		{
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00008364 File Offset: 0x00006564
		public virtual void WriteValue(double? value)
		{
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00008374 File Offset: 0x00006574
		public virtual void WriteValue(bool? value)
		{
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00008384 File Offset: 0x00006584
		public virtual void WriteValue(short? value)
		{
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00008394 File Offset: 0x00006594
		[CLSCompliant(false)]
		public virtual void WriteValue(ushort? value)
		{
		}

		// Token: 0x06000296 RID: 662 RVA: 0x000083A4 File Offset: 0x000065A4
		public virtual void WriteValue(char? value)
		{
		}

		// Token: 0x06000297 RID: 663 RVA: 0x000083B4 File Offset: 0x000065B4
		public virtual void WriteValue(byte? value)
		{
		}

		// Token: 0x06000298 RID: 664 RVA: 0x000083C4 File Offset: 0x000065C4
		[CLSCompliant(false)]
		public virtual void WriteValue(sbyte? value)
		{
		}

		// Token: 0x06000299 RID: 665 RVA: 0x0000212A File Offset: 0x0000032A
		public virtual void WriteValue(decimal? value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600029A RID: 666 RVA: 0x000083D4 File Offset: 0x000065D4
		public virtual void WriteValue(DateTime? value)
		{
		}

		// Token: 0x0600029B RID: 667 RVA: 0x0000212A File Offset: 0x0000032A
		public virtual void WriteValue(DateTimeOffset? value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600029C RID: 668 RVA: 0x000083E4 File Offset: 0x000065E4
		public virtual void WriteValue(Guid? value)
		{
		}

		// Token: 0x0600029D RID: 669 RVA: 0x000083F4 File Offset: 0x000065F4
		public virtual void WriteValue(TimeSpan? value)
		{
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00008404 File Offset: 0x00006604
		public virtual void WriteValue(byte[] value)
		{
			if (value != null)
			{
				if (this._currentPosition.HasIndex)
				{
					int position = this._currentPosition.Position;
					this._currentPosition.Position = position;
				}
				return;
			}
		}

		// Token: 0x0600029F RID: 671 RVA: 0x0000843C File Offset: 0x0000663C
		public virtual void WriteValue(Uri value)
		{
			if (!true)
			{
			}
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00008474 File Offset: 0x00006674
		public virtual void WriteValue(object value)
		{
			Type type;
			PrimitiveTypeCode typeCode = ConvertUtils.GetTypeCode(type);
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x0000848C File Offset: 0x0000668C
		public virtual void WriteComment(string text)
		{
			this.AutoComplete(JsonToken.Comment);
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x000084A0 File Offset: 0x000066A0
		public virtual void WriteWhitespace(string ws)
		{
			this.InternalWriteWhitespace(ws);
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x000084B4 File Offset: 0x000066B4
		void IDisposable.Dispose()
		{
			GC.SuppressFinalize(this);
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x000084C8 File Offset: 0x000066C8
		protected virtual void Dispose(bool disposing)
		{
			JsonWriter.State currentState = this._currentState;
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x000084E0 File Offset: 0x000066E0
		internal static void WriteValue(JsonWriter writer, PrimitiveTypeCode typeCode, object value)
		{
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x000085D0 File Offset: 0x000067D0
		private static JsonWriterException CreateUnsupportedTypeException(JsonWriter writer, object value)
		{
			if (!true)
			{
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			Type type = writer.GetType();
			string text = "Unsupported type: {0}. Use the JsonSerializer class to get the object's JSON representation.".FormatWith(invariantCulture, type);
			JsonWriterException ex;
			return ex;
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00008600 File Offset: 0x00006800
		protected void SetWriteState(JsonToken token, object value)
		{
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00008650 File Offset: 0x00006850
		internal void InternalWriteEnd(JsonContainerType container)
		{
			this.AutoCompleteClose(container);
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00008664 File Offset: 0x00006864
		internal void InternalWritePropertyName(string name)
		{
			this._currentPosition.PropertyName = name;
			this.AutoComplete(JsonToken.PropertyName);
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00008684 File Offset: 0x00006884
		internal void InternalWriteRaw()
		{
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00008694 File Offset: 0x00006894
		internal void InternalWriteStart(JsonToken token, JsonContainerType container)
		{
			if (this._currentPosition.HasIndex)
			{
				int position = this._currentPosition.Position;
				this._currentPosition.Position = position;
			}
			this.AutoComplete(token);
			this.Push(container);
		}

		// Token: 0x060002AC RID: 684 RVA: 0x000086D4 File Offset: 0x000068D4
		internal void InternalWriteValue(JsonToken token)
		{
			if (this._currentPosition.HasIndex)
			{
				int position = this._currentPosition.Position;
				this._currentPosition.Position = position;
			}
			this.AutoComplete(token);
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00008710 File Offset: 0x00006910
		internal void InternalWriteWhitespace(string ws)
		{
			if (ws != null)
			{
				bool flag = StringUtils.IsWhiteSpace(ws);
			}
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00008728 File Offset: 0x00006928
		internal void InternalWriteComment()
		{
			this.AutoComplete(JsonToken.Comment);
		}

		// Token: 0x04000131 RID: 305
		private static readonly JsonWriter.State[][] StateArray;

		// Token: 0x04000132 RID: 306
		internal static readonly JsonWriter.State[][] StateArrayTempate;

		// Token: 0x04000133 RID: 307
		private List<JsonPosition> _stack;

		// Token: 0x04000134 RID: 308
		private JsonPosition _currentPosition;

		// Token: 0x04000135 RID: 309
		private JsonWriter.State _currentState;

		// Token: 0x04000136 RID: 310
		private Formatting _formatting;

		// Token: 0x04000137 RID: 311
		[CompilerGenerated]
		private bool <CloseOutput>k__BackingField;

		// Token: 0x04000138 RID: 312
		private DateFormatHandling _dateFormatHandling;

		// Token: 0x04000139 RID: 313
		private DateTimeZoneHandling _dateTimeZoneHandling;

		// Token: 0x0400013A RID: 314
		private StringEscapeHandling _stringEscapeHandling;

		// Token: 0x0400013B RID: 315
		private FloatFormatHandling _floatFormatHandling;

		// Token: 0x0400013C RID: 316
		private string _dateFormatString;

		// Token: 0x0400013D RID: 317
		private CultureInfo _culture;

		// Token: 0x0200003C RID: 60
		internal enum State
		{
			// Token: 0x0400013F RID: 319
			Start,
			// Token: 0x04000140 RID: 320
			Property,
			// Token: 0x04000141 RID: 321
			ObjectStart,
			// Token: 0x04000142 RID: 322
			Object,
			// Token: 0x04000143 RID: 323
			ArrayStart,
			// Token: 0x04000144 RID: 324
			Array,
			// Token: 0x04000145 RID: 325
			ConstructorStart,
			// Token: 0x04000146 RID: 326
			Constructor,
			// Token: 0x04000147 RID: 327
			Closed,
			// Token: 0x04000148 RID: 328
			Error
		}
	}
}
