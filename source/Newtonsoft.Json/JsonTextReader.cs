using System;
using System.Globalization;
using System.IO;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json
{
	// Token: 0x02000029 RID: 41
	[Preserve]
	public class JsonTextReader : JsonReader, IJsonLineInfo
	{
		// Token: 0x060000AC RID: 172 RVA: 0x00003000 File Offset: 0x00001200
		public JsonTextReader(TextReader reader)
		{
			do
			{
				base..ctor();
				this._dateTimeZoneHandling = DateTimeZoneHandling.RoundtripKind;
				this.<CloseInput>k__BackingField = true;
			}
			while (reader == null);
			this._reader = reader;
			this._lineNumber = 1;
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000AD RID: 173 RVA: 0x00003034 File Offset: 0x00001234
		// (set) Token: 0x060000AE RID: 174 RVA: 0x00003048 File Offset: 0x00001248
		public IArrayPool<char> ArrayPool
		{
			get
			{
				return this._arrayPool;
			}
			set
			{
				while (value == null)
				{
				}
				this._arrayPool = value;
			}
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00003060 File Offset: 0x00001260
		private void EnsureBufferNotEmpty()
		{
			IArrayPool<char> arrayPool = this._arrayPool;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0000307C File Offset: 0x0000127C
		private void OnNewLine(int pos)
		{
			int lineNumber = this._lineNumber;
			this._lineStartPos = pos;
			this._isEndOfFile = lineNumber != 0;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x000030A0 File Offset: 0x000012A0
		private void ParseString(char quote, ReadType readType)
		{
			int charPos = this._charPos;
			this._charPos = charPos;
			this.ShiftBufferIfNeeded();
			this.ReadStringIntoBuffer(quote);
			if (this._currentPosition != null)
			{
				return;
			}
			bool <SupportMultipleContent>k__BackingField = this.<SupportMultipleContent>k__BackingField;
			int num = 12;
			bool hasIndex = this._currentPosition.HasIndex;
			this._currentState = (JsonReader.State)num;
			if (hasIndex)
			{
				int position = this._currentPosition.Position;
				this._currentPosition.Position = position;
			}
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x0000322C File Offset: 0x0000142C
		private static void BlockCopyChars(char[] src, int srcOffset, char[] dst, int dstOffset, int count)
		{
			Buffer.BlockCopy(src, srcOffset, dst, dstOffset, count);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00003244 File Offset: 0x00001444
		private void ShiftBufferIfNeeded()
		{
			char[] chars = this._chars;
			int charPos = this._charPos;
			int charsUsed = this._charsUsed;
			int charPos2 = this._charPos;
			char[] chars2 = this._chars;
			int lineStartPos = this._lineStartPos;
			this._lineStartPos = charPos2;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00003284 File Offset: 0x00001484
		private int ReadData(bool append)
		{
			long num = 0L;
			return this.ReadData(append, (int)num);
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0000329C File Offset: 0x0000149C
		private int ReadData(bool append, int charsRequired)
		{
			/*
An exception occurred when decompiling this method (060000B5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Newtonsoft.Json.JsonTextReader::ReadData(System.Boolean,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_00EF:
	stloc:char[](var_22_F5, ldfld:char[](JsonTextReader::_chars, ldloc:JsonTextReader(this)))
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

		// Token: 0x060000B6 RID: 182 RVA: 0x000033A0 File Offset: 0x000015A0
		private bool EnsureChars(int relativePosition, bool append)
		{
			int charsUsed = this._charsUsed;
			int lineStartPos = this._lineStartPos;
			bool flag;
			return flag;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x000033C0 File Offset: 0x000015C0
		private bool ReadChars(int relativePosition, bool append)
		{
			/*
An exception occurred when decompiling this method (060000B7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Newtonsoft.Json.JsonTextReader::ReadChars(System.Int32,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000A:
	brtrue(IL_0000, logicnot:bool(ldloc:int32[exp:bool](var_2)))
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

		// Token: 0x060000B8 RID: 184 RVA: 0x000033DC File Offset: 0x000015DC
		public override bool Read()
		{
			if (this._chars == null)
			{
				IArrayPool<char> arrayPool = this._arrayPool;
				int num = 1024;
				char[] array = BufferUtils.RentBuffer(arrayPool, num);
				this._chars = array;
			}
			JsonReader.State currentState = this._currentState;
			return this.ParsePostValue();
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000034AC File Offset: 0x000016AC
		public override int? ReadAsInt32()
		{
			if (this.ReadNumberValue(ReadType.ReadAsInt32) != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x060000BA RID: 186 RVA: 0x000034C8 File Offset: 0x000016C8
		public override DateTime? ReadAsDateTime()
		{
			if (this.ReadStringValue(ReadType.ReadAsDateTime) != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x060000BB RID: 187 RVA: 0x000034E4 File Offset: 0x000016E4
		public override string ReadAsString()
		{
			if (this.ReadStringValue(ReadType.ReadAsString) != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00003500 File Offset: 0x00001700
		public override byte[] ReadAsBytes()
		{
			if (this._chars == null)
			{
				IArrayPool<char> arrayPool = this._arrayPool;
				int num = 1024;
				char[] array = BufferUtils.RentBuffer(arrayPool, num);
				this._chars = array;
			}
			JsonReader.State currentState = this._currentState;
			this._charPos = (int)currentState;
			if (currentState == JsonReader.State.Start)
			{
			}
			this._charPos = (int)currentState;
			long num2 = 0L;
			this.ProcessCarriageReturn(num2 != 0L);
			this._charPos = (int)currentState;
			base.ReadIntoWrappedTypeObject();
			long num3 = 0L;
			this.ParseComment(num3 != 0L);
			this.ProcessValueComma();
			bool flag = this.ReadNullChar();
			int lineNumber = this._lineNumber;
			this._charPos = (int)currentState;
			this._lineStartPos = (int)currentState;
			this._isEndOfFile = lineNumber != 0;
			char[] chars = this._chars;
			if (this != null)
			{
				if (this != null)
				{
					return base.ReadArrayIntoByteArray();
				}
			}
			else
			{
				long num4 = 0L;
				base.ReaderReadAndAssert();
				JsonPosition currentPosition = this._currentPosition;
				int num5 = 17;
				this._tokenType = (JsonToken)num5;
				this._value = num4;
				long num6;
				if (currentPosition != null)
				{
					num6 = 0L;
				}
				bool <SupportMultipleContent>k__BackingField = this.<SupportMultipleContent>k__BackingField;
				int num7 = 12;
				this._currentState = (JsonReader.State)num7;
				JsonReaderException ex = this.CreateUnexpectedCharacterException((char)num6);
				CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			}
			throw new InvalidCastException();
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0000362C File Offset: 0x0000182C
		private object ReadStringValue(ReadType readType)
		{
			if (this._chars == null)
			{
				IArrayPool<char> arrayPool = this._arrayPool;
				int num = 1024;
				char[] array = BufferUtils.RentBuffer(arrayPool, num);
				this._chars = array;
			}
			JsonReader.State currentState = this._currentState;
			this._charPos = (int)currentState;
			this._charPos = (int)currentState;
			if (currentState == JsonReader.State.Start)
			{
			}
			char[] chars = this._chars;
			long num2 = 0L;
			this.ProcessCarriageReturn(num2 != 0L);
			long num3 = 0L;
			this.ParseComment(num3 != 0L);
			this.ProcessValueComma();
			bool flag = this.ReadNullChar();
			int lineNumber = this._lineNumber;
			this._charPos = (int)currentState;
			this._lineStartPos = (int)currentState;
			this._isEndOfFile = lineNumber != 0;
			JsonReader.State currentState2 = this._currentState;
			object obj;
			return obj;
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00003758 File Offset: 0x00001958
		private JsonReaderException CreateUnexpectedCharacterException(char c)
		{
			if (!true)
			{
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			JsonReaderException ex;
			return ex;
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00003774 File Offset: 0x00001974
		public override bool? ReadAsBoolean()
		{
			if (this._chars == null)
			{
				IArrayPool<char> arrayPool = this._arrayPool;
				int num = 1024;
				char[] array = BufferUtils.RentBuffer(arrayPool, num);
				this._chars = array;
			}
			JsonReader.State currentState = this._currentState;
			this._charPos = (int)currentState;
			this._charPos = (int)currentState;
			if (currentState == JsonReader.State.Start)
			{
			}
			char[] chars = this._chars;
			bool flag = this.ReadNullChar();
			this.ProcessValueComma();
			long num2 = 0L;
			this.ProcessCarriageReturn(num2 != 0L);
			int lineNumber = this._lineNumber;
			this._charPos = (int)currentState;
			this._lineStartPos = (int)currentState;
			this._isEndOfFile = lineNumber != 0;
			long num3 = 0L;
			this.ParseComment(num3 != 0L);
			if (lineNumber == 0)
			{
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			if (lineNumber == 0)
			{
			}
			bool flag2 = Convert.ToBoolean(this, invariantCulture);
			JsonPosition currentPosition = this._currentPosition;
			int num4 = 10;
			this._tokenType = (JsonToken)num4;
			if (currentPosition != null)
			{
			}
			bool <SupportMultipleContent>k__BackingField = this.<SupportMultipleContent>k__BackingField;
			int num5 = 12;
			this._currentState = (JsonReader.State)num5;
			this.HandleNull();
			JsonReader.State currentState2 = this._currentState;
			this._charPos = num5;
			if (num5 == 0)
			{
			}
			string text;
			return base.ReadBooleanString(text);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00003894 File Offset: 0x00001A94
		private void ProcessValueComma()
		{
			int charPos = this._charPos;
			JsonReader.State currentState = this._currentState;
			this._charPos = charPos;
			base.SetStateBasedOnCurrent();
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x000038C8 File Offset: 0x00001AC8
		private object ReadNumberValue(ReadType readType)
		{
			if (this._chars == null)
			{
				IArrayPool<char> arrayPool = this._arrayPool;
				int num = 1024;
				char[] array = BufferUtils.RentBuffer(arrayPool, num);
				this._chars = array;
			}
			JsonReader.State currentState = this._currentState;
			this._charPos = (int)currentState;
			this._charPos = (int)currentState;
			if (currentState == JsonReader.State.Start)
			{
			}
			char[] chars = this._chars;
			bool flag = this.ReadNullChar();
			this.ProcessValueComma();
			long num2 = 0L;
			this.ProcessCarriageReturn(num2 != 0L);
			int lineNumber = this._lineNumber;
			this._charPos = (int)currentState;
			this._lineStartPos = (int)currentState;
			this._isEndOfFile = lineNumber != 0;
			long num3 = 0L;
			this.ParseComment(num3 != 0L);
			this.ReadFinished();
			this.HandleNull();
			return this.ParseNumberNaN(readType);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x000039F0 File Offset: 0x00001BF0
		public override DateTimeOffset? ReadAsDateTimeOffset()
		{
			if (this.ReadStringValue(ReadType.ReadAsDateTimeOffset) != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00003A0C File Offset: 0x00001C0C
		public override decimal? ReadAsDecimal()
		{
			if (this.ReadNumberValue(ReadType.ReadAsDecimal) != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00003A28 File Offset: 0x00001C28
		public override double? ReadAsDouble()
		{
			if (this.ReadNumberValue(ReadType.ReadAsDouble) != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00003A44 File Offset: 0x00001C44
		private void HandleNull()
		{
			int charsUsed = this._charsUsed;
			int lineStartPos = this._lineStartPos;
			int num = 1;
			int num2 = 1;
			bool flag = this.ReadChars(num, num2 != 0);
			int charPos = this._charPos;
			char[] chars = this._chars;
			this.ParseNull();
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00003AB0 File Offset: 0x00001CB0
		private void ReadFinished()
		{
			int charsUsed = this._charsUsed;
			int lineStartPos = this._lineStartPos;
			long num = 0L;
			long num2 = 0L;
			bool flag = this.ReadChars((int)num, num2 != 0L);
			long num3 = 0L;
			bool flag2 = this.EatWhitespace(num3 != 0L);
			if (!this._isEndOfFile)
			{
				char[] chars = this._chars;
				long num4 = 0L;
				this.ParseComment(num4 != 0L);
			}
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00003B20 File Offset: 0x00001D20
		private bool ReadNullChar()
		{
			/*
An exception occurred when decompiling this method (060000C7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Newtonsoft.Json.JsonTextReader::ReadNullChar()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_5_21, ldc.i4:int32(1))
	stfld:bool(JsonTextReader::_isEndOfFile, ldloc:JsonTextReader(this), ldloc:int32[exp:bool](var_5_21))
	stfld:int32(JsonTextReader::_charPos, ldloc:JsonTextReader(this), ldloc:int32(var_4_1A))
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

		// Token: 0x060000C8 RID: 200 RVA: 0x00003B64 File Offset: 0x00001D64
		private void EnsureBuffer()
		{
			if (this._chars == null)
			{
				char[] array = BufferUtils.RentBuffer(this._arrayPool, 1024);
				this._chars = array;
			}
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00003B94 File Offset: 0x00001D94
		private void ReadStringIntoBuffer(char quote)
		{
			int charPos = this._charPos;
			char[] chars = this._chars;
			int num = 1;
			this._charPos = charPos;
			this.ProcessCarriageReturn(num != 0);
			int charPos2 = this._charPos;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00003D64 File Offset: 0x00001F64
		private void WriteCharToBuffer(char writeChar, int lastWritePosition, int writeToPosition)
		{
			IArrayPool<char> arrayPool = this._arrayPool;
			char[] chars = this._chars;
			IArrayPool<char> arrayPool2 = this._arrayPool;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00003D88 File Offset: 0x00001F88
		private char ParseUnicode()
		{
			int charsUsed = this._charsUsed;
			int lineStartPos = this._lineStartPos;
			int num = 4;
			int num2 = 1;
			bool flag = this.ReadChars(num, num2 != 0);
			int charPos = this._charPos;
			char c = Convert.ToChar(ConvertUtils.HexTextToInt(this._chars, charPos, num2));
			int charPos2 = this._charPos;
			this._charPos = charPos2;
			return c;
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00003DF0 File Offset: 0x00001FF0
		private void ReadNumberIntoBuffer()
		{
			int num;
			long num2;
			do
			{
				int charPos = this._charPos;
				char[] chars = this._chars;
				int charsUsed = this._charsUsed;
				this._charPos = charPos;
				num = 1;
				num2 = 0L;
			}
			while (this.ReadData(num != 0, (int)num2) != 0);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00003E4C File Offset: 0x0000204C
		private void ClearRecentString()
		{
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00003E5C File Offset: 0x0000205C
		private bool ParsePostValue()
		{
			int num = 1;
			char[] chars = this._chars;
			if (num == 0)
			{
			}
			int charPos = this._charPos;
			this._charPos = charPos;
			bool flag;
			return flag;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00003F20 File Offset: 0x00002120
		private bool ParseObject()
		{
			int num = 1;
			char[] chars = this._chars;
			if (num == 0)
			{
			}
			int charPos = this._charPos;
			this._charPos = charPos;
			bool flag;
			return flag;
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00003FB8 File Offset: 0x000021B8
		private bool ParseProperty()
		{
			char[] chars = this._chars;
			this.ShiftBufferIfNeeded();
			this.ShiftBufferIfNeeded();
			this.ParseUnquotedProperty();
			long num = 0L;
			if (this.NameTable != null)
			{
				StringReference stringReference = this._stringReference;
				int startIndex = this._stringReference._startIndex;
				IArrayPool<char> arrayPool = this._arrayPool;
				string text;
				if (text == null)
				{
				}
			}
			long num2 = 0L;
			bool flag = this.EatWhitespace(num2 != 0L);
			char[] chars2 = this._chars;
			this._quoteChar = (char)num;
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			char[] chars3 = this._chars;
			return "Invalid character after parsing property name. Expected ':' but got: {0}." != null;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x0000405C File Offset: 0x0000225C
		private bool ValidIdentifierChar(char value)
		{
			if (!true)
			{
			}
			bool flag = char.IsLetterOrDigit(value);
			return true;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00004078 File Offset: 0x00002278
		private void ParseUnquotedProperty()
		{
			int charPos = this._charPos;
			char[] chars = this._chars;
			int charPos2 = this._charPos;
			this._charPos = charPos2;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x000040F4 File Offset: 0x000022F4
		private bool ParseValue()
		{
			if (!true)
			{
			}
			int charPos = this._charPos;
			this._charPos = charPos;
			bool flag;
			return flag;
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00004220 File Offset: 0x00002420
		private void ProcessLineFeed()
		{
			int charPos = this._charPos;
			int lineNumber = this._lineNumber;
			this._charPos = charPos;
			this._lineNumber = charPos;
			this._lineNumber = lineNumber;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00004250 File Offset: 0x00002450
		private void ProcessCarriageReturn(bool append)
		{
			int charsUsed = this._charsUsed;
			int lineStartPos = this._lineStartPos;
			int charPos = this._charPos;
			char[] chars = this._chars;
			this._charPos = charPos;
			int lineNumber = this._lineNumber;
			this._lineStartPos = charPos;
			this._isEndOfFile = lineNumber != 0;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00004298 File Offset: 0x00002498
		private bool EatWhitespace(bool oneOrMore)
		{
			int num;
			long num3;
			long num4;
			do
			{
				num = 1;
				char[] chars = this._chars;
				int lineNumber = this._lineNumber;
				this._charPos = num;
				this._lineStartPos = num;
				this._isEndOfFile = lineNumber != 0;
				long num2 = 0L;
				this.ProcessCarriageReturn(num2 != 0L);
				int charsUsed = this._charsUsed;
				num3 = 0L;
				num4 = 0L;
			}
			while (this.ReadData(num3 != 0L, (int)num4) != 0);
			this._charPos = num;
			if (num == 0)
			{
			}
			int charPos = this._charPos;
			this._charPos = charPos;
			bool flag;
			return flag;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x0000430C File Offset: 0x0000250C
		private void ParseConstructor()
		{
			long num = 0L;
			bool flag = this.EatWhitespace(num != 0L);
			int charPos = this._charPos;
			char[] chars = this._chars;
			int charPos2 = this._charPos;
			this._charPos = charPos;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00004404 File Offset: 0x00002604
		private void ParseNumber(ReadType readType)
		{
			this.ShiftBufferIfNeeded();
			char[] chars = this._chars;
			this.ReadNumberIntoBuffer();
			if (this._currentPosition != null)
			{
				return;
			}
			bool <SupportMultipleContent>k__BackingField = this.<SupportMultipleContent>k__BackingField;
			int num = 12;
			bool hasIndex = this._currentPosition.HasIndex;
			this._currentState = (JsonReader.State)num;
			if (hasIndex)
			{
				int position = this._currentPosition.Position;
				this._currentPosition.Position = position;
			}
			int charPos = this._charPos;
			char[] chars2 = this._chars;
			if (charPos == 0)
			{
			}
			int length = this._stringReference._length;
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x000046F8 File Offset: 0x000028F8
		private void ParseComment(bool setToken)
		{
			int charsUsed = this._charsUsed;
			int lineStartPos = this._lineStartPos;
			int num = 1;
			long num2 = 0L;
			bool flag = this.ReadChars(num, num2 != 0L);
			int charPos = this._charPos;
			char[] chars = this._chars;
		}

		// Token: 0x060000DA RID: 218 RVA: 0x0000482C File Offset: 0x00002A2C
		private void EndComment(bool setToken, int initialPosition, int endPosition)
		{
			char[] chars = this._chars;
			int num = 5;
			this._tokenType = (JsonToken)num;
			string text;
			this._value = text;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00004854 File Offset: 0x00002A54
		private bool MatchValue(string value)
		{
			/*
An exception occurred when decompiling this method (060000DB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Newtonsoft.Json.JsonTextReader::MatchValue(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(string::_stringLength, ldloc:string(value)))
	stloc:int32(var_1_0D, ldfld:int32(JsonTextReader::_charsUsed, ldloc:JsonTextReader(this)))
	stloc:int32(var_2_14, ldfld:int32(JsonTextReader::_lineStartPos, ldloc:JsonTextReader(this)))
	stloc:int32(var_4_1B, ldfld:int32(string::_stringLength, ldloc:string(value)))
	stloc:int64(var_5_1E, ldc.i4:int64(0))
	stloc:int32(var_6_26, ldfld:int32(JsonTextReader::_charPos, ldloc:JsonTextReader(this)))
	stloc:char[](var_7_2E, ldfld:char[](JsonTextReader::_chars, ldloc:JsonTextReader(this)))
	stloc:char(var_8_38, callgetter:char(string::get_Chars, ldloc:string(value), ldloc:int64[exp:int32](var_5_1E)))
	stloc:int32(var_9_40, ldfld:int32(string::_stringLength, ldloc:string(value)))
	stloc:int32(var_13_51, ldfld:int32(JsonTextReader::_charPos, ldloc:JsonTextReader(this)))
	stfld:int32(JsonTextReader::_charPos, ldloc:JsonTextReader(this), ldloc:int32(var_13_51))
	stloc:int32(var_14_61, ldfld:int32(JsonTextReader::_charsUsed, ldloc:JsonTextReader(this)))
	stfld:int32(JsonTextReader::_charPos, ldloc:JsonTextReader(this), ldloc:int32(var_14_61))
	stloc:JsonReaderException(var_15_71, call:JsonReaderException(JsonReader::CreateUnexpectedEndException, ldloc:JsonTextReader[exp:JsonReader](this)))
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

		// Token: 0x060000DC RID: 220 RVA: 0x000048D4 File Offset: 0x00002AD4
		private bool MatchValueWithTrailingSeparator(string value)
		{
			/*
An exception occurred when decompiling this method (060000DC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Newtonsoft.Json.JsonTextReader::MatchValueWithTrailingSeparator(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_0_07, call:bool(JsonTextReader::MatchValue, ldloc:JsonTextReader(this), ldloc:string(value)))
	stloc:int32(var_1_0E, ldfld:int32(JsonTextReader::_charsUsed, ldloc:JsonTextReader(this)))
	stloc:int32(var_2_15, ldfld:int32(JsonTextReader::_lineStartPos, ldloc:JsonTextReader(this)))
	stloc:int64(var_3_17, ldc.i4:int64(0))
	stloc:int64(var_4_19, ldc.i4:int64(0))
	stloc:bool(var_5_24, call:bool(JsonTextReader::ReadChars, ldloc:JsonTextReader(this), ldloc:int64[exp:int32](var_3_17), ldloc:int64[exp:bool](var_4_19)))
	stloc:int32(var_6_2C, ldfld:int32(JsonTextReader::_charPos, ldloc:JsonTextReader(this)))
	stloc:char[](var_7_34, ldfld:char[](JsonTextReader::_chars, ldloc:JsonTextReader(this)))
	stloc:bool(var_8_3D, call:bool(JsonTextReader::IsSeparator, ldloc:JsonTextReader(this), ldloc:int64[exp:char](var_3_17)))
	stloc:char[](var_11_4B, ldfld:char[](JsonTextReader::_chars, ldloc:JsonTextReader(this)))
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

		// Token: 0x060000DD RID: 221 RVA: 0x00004930 File Offset: 0x00002B30
		private bool IsSeparator(char c)
		{
			/*
An exception occurred when decompiling this method (060000DD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Newtonsoft.Json.JsonTextReader::IsSeparator(System.Char)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:State(var_1_08, ldfld:State(JsonReader::_currentState, ldloc:JsonTextReader[exp:JsonReader](this)))
	stloc:int32(var_2_0F, ldfld:int32(JsonTextReader::_charsUsed, ldloc:JsonTextReader(this)))
	stloc:int32(var_3_16, ldfld:int32(JsonTextReader::_lineStartPos, ldloc:JsonTextReader(this)))
	stloc:int32(var_4_18, ldc.i4:int32(1))
	stloc:int64(var_5_1B, ldc.i4:int64(0))
	stloc:bool(var_6_27, call:bool(JsonTextReader::ReadChars, ldloc:JsonTextReader(this), ldloc:int32(var_4_18), ldloc:int64[exp:bool](var_5_1B)))
	stloc:int32(var_8_32, ldfld:int32(JsonTextReader::_charPos, ldloc:JsonTextReader(this)))
	stloc:char[](var_9_3A, ldfld:char[](JsonTextReader::_chars, ldloc:JsonTextReader(this)))
	stloc:bool(var_10_42, call:bool(char::IsWhiteSpace, ldloc:char(c)))
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

		// Token: 0x060000DE RID: 222 RVA: 0x00004988 File Offset: 0x00002B88
		private void ParseTrue()
		{
			if (!true)
			{
			}
		}

		// Token: 0x060000DF RID: 223 RVA: 0x000049A4 File Offset: 0x00002BA4
		private void ParseNull()
		{
			if (!true)
			{
			}
			long num = 0L;
			base.SetToken(JsonToken.Null, num, true);
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x000049CC File Offset: 0x00002BCC
		private void ParseUndefined()
		{
			if (!true)
			{
			}
			long num = 0L;
			base.SetToken(JsonToken.Undefined, num, true);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x000049F4 File Offset: 0x00002BF4
		private void ParseFalse()
		{
			if (!true)
			{
			}
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00004A10 File Offset: 0x00002C10
		private object ParseNumberNegativeInfinity(ReadType readType)
		{
			if (!true)
			{
			}
			if (readType != ReadType.Read || this._floatParseHandling == FloatParseHandling.Double)
			{
			}
			return "Cannot read -Infinity value.";
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00004A3C File Offset: 0x00002C3C
		private object ParseNumberPositiveInfinity(ReadType readType)
		{
			if (!true)
			{
			}
			if (readType != ReadType.Read || this._floatParseHandling == FloatParseHandling.Double)
			{
			}
			return "Cannot read Infinity value.";
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00004A68 File Offset: 0x00002C68
		private object ParseNumberNaN(ReadType readType)
		{
			if (!true)
			{
			}
			if (readType != ReadType.Read || this._floatParseHandling == FloatParseHandling.Double)
			{
			}
			return "Cannot read NaN value.";
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00004A94 File Offset: 0x00002C94
		public override void Close()
		{
			char[] chars = this._chars;
			int num = 7;
			if (chars != null)
			{
			}
			if (num == 0 || this != null)
			{
			}
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00004AB4 File Offset: 0x00002CB4
		public bool HasLineInfo()
		{
			return true;
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x00004AC4 File Offset: 0x00002CC4
		public int LineNumber
		{
			get
			{
				if (this._currentState == JsonReader.State.Start)
				{
					int charPos = this._charPos;
					int lineNumber = this._lineNumber;
				}
				return this._lineNumber;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x00004AF0 File Offset: 0x00002CF0
		public int LinePosition
		{
			get
			{
				/*
An exception occurred when decompiling this method (060000E8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Newtonsoft.Json.JsonTextReader::get_LinePosition()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(JsonTextReader::_charPos, ldloc:JsonTextReader(this)))
	stloc:int32(var_1_0D, ldfld:int32(JsonTextReader::_lineNumber, ldloc:JsonTextReader(this)))
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

		// Token: 0x040000A0 RID: 160
		private const char UnicodeReplacementChar = '\ufffd';

		// Token: 0x040000A1 RID: 161
		private const int MaximumJavascriptIntegerCharacterLength = 380;

		// Token: 0x040000A2 RID: 162
		private readonly TextReader _reader;

		// Token: 0x040000A3 RID: 163
		private char[] _chars;

		// Token: 0x040000A4 RID: 164
		private int _charsUsed;

		// Token: 0x040000A5 RID: 165
		private int _charPos;

		// Token: 0x040000A6 RID: 166
		private int _lineStartPos;

		// Token: 0x040000A7 RID: 167
		private int _lineNumber;

		// Token: 0x040000A8 RID: 168
		private bool _isEndOfFile;

		// Token: 0x040000A9 RID: 169
		private StringBuffer _stringBuffer;

		// Token: 0x040000AA RID: 170
		private StringReference _stringReference;

		// Token: 0x040000AB RID: 171
		private IArrayPool<char> _arrayPool;

		// Token: 0x040000AC RID: 172
		internal PropertyNameTable NameTable;
	}
}
