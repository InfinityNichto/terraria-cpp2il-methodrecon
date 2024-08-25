using System;
using System.Globalization;
using System.IO;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json
{
	// Token: 0x0200002C RID: 44
	[Preserve]
	public class JsonTextWriter : JsonWriter
	{
		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000108 RID: 264 RVA: 0x00004DC0 File Offset: 0x00002FC0
		private Base64Encoder Base64Encoder
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000108)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Newtonsoft.Json.Utilities.Base64Encoder Newtonsoft.Json.JsonTextWriter::get_Base64Encoder()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:TextWriter(var_0_0E, ldfld:TextWriter(JsonTextWriter::_writer, ldloc:JsonTextWriter(this)))
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

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000109 RID: 265 RVA: 0x00004DDC File Offset: 0x00002FDC
		// (set) Token: 0x0600010A RID: 266 RVA: 0x00004DF0 File Offset: 0x00002FF0
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

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600010B RID: 267 RVA: 0x00004E08 File Offset: 0x00003008
		// (set) Token: 0x0600010C RID: 268 RVA: 0x00004E1C File Offset: 0x0000301C
		public int Indentation
		{
			get
			{
				return this._indentation;
			}
			set
			{
				this._indentation = value;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600010D RID: 269 RVA: 0x00004E30 File Offset: 0x00003030
		// (set) Token: 0x0600010E RID: 270 RVA: 0x00004E44 File Offset: 0x00003044
		public char QuoteChar
		{
			get
			{
				return this._quoteChar;
			}
			set
			{
				this._quoteChar = value;
				this.UpdateCharEscapeFlags();
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600010F RID: 271 RVA: 0x00004E60 File Offset: 0x00003060
		// (set) Token: 0x06000110 RID: 272 RVA: 0x00004E74 File Offset: 0x00003074
		public char IndentChar
		{
			get
			{
				return this._indentChar;
			}
			set
			{
				char indentChar = this._indentChar;
				this._indentChar = value;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000111 RID: 273 RVA: 0x00004E90 File Offset: 0x00003090
		// (set) Token: 0x06000112 RID: 274 RVA: 0x00004EA4 File Offset: 0x000030A4
		public bool QuoteName
		{
			get
			{
				return this._quoteName;
			}
			set
			{
			}
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00004EB4 File Offset: 0x000030B4
		public JsonTextWriter(TextWriter textWriter)
		{
			do
			{
				if (!true)
				{
				}
				base..ctor();
			}
			while (textWriter == null);
			this._writer = textWriter;
			this._quoteChar = '"';
			this._quoteName = true;
			this._indentChar = ' ';
			this._indentation = 2;
			this.UpdateCharEscapeFlags();
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00004EF8 File Offset: 0x000030F8
		public override void Flush()
		{
			TextWriter writer = this._writer;
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00004F0C File Offset: 0x0000310C
		public override void Close()
		{
			base.Close();
			char[] writeBuffer = this._writeBuffer;
			if (writeBuffer != null)
			{
				BufferUtils.ReturnBuffer(this._arrayPool, writeBuffer);
			}
			if (this.<CloseOutput>k__BackingField && this._writer != null)
			{
				return;
			}
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00004F48 File Offset: 0x00003148
		public override void WriteStartObject()
		{
			base.InternalWriteStart(JsonToken.StartObject, JsonContainerType.Object);
			TextWriter writer = this._writer;
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00004F64 File Offset: 0x00003164
		public override void WriteStartArray()
		{
			base.InternalWriteStart(JsonToken.StartArray, JsonContainerType.Array);
			TextWriter writer = this._writer;
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00004F80 File Offset: 0x00003180
		public override void WriteStartConstructor(string name)
		{
			base.InternalWriteStart(JsonToken.StartConstructor, JsonContainerType.Constructor);
			TextWriter writer = this._writer;
			TextWriter writer2 = this._writer;
			TextWriter writer3 = this._writer;
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00004FAC File Offset: 0x000031AC
		protected override void WriteEnd(JsonToken token)
		{
			TextWriter writer = this._writer;
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00004FC4 File Offset: 0x000031C4
		public override void WritePropertyName(string name)
		{
			base.InternalWritePropertyName(name);
			bool quoteName = this._quoteName;
			this.WriteEscapedString(name, quoteName);
			TextWriter writer = this._writer;
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00004FF0 File Offset: 0x000031F0
		public override void WritePropertyName(string name, bool escape)
		{
			long num = 0L;
			base.InternalWritePropertyName(name);
			bool quoteName = this._quoteName;
			this.WriteEscapedString(name, num != 0L);
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00005050 File Offset: 0x00003250
		internal override void OnStringEscapeHandlingChanged()
		{
			this.UpdateCharEscapeFlags();
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00005064 File Offset: 0x00003264
		private void UpdateCharEscapeFlags()
		{
			StringEscapeHandling stringEscapeHandling = this._stringEscapeHandling;
			char quoteChar = this._quoteChar;
			if (!true)
			{
			}
			bool[] charEscapeFlags = JavaScriptUtils.GetCharEscapeFlags(stringEscapeHandling, quoteChar);
			this._charEscapeFlags = charEscapeFlags;
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00005094 File Offset: 0x00003294
		protected override void WriteIndent()
		{
			TextWriter writer = this._writer;
			int top = base.Top;
			int indentation = this._indentation;
			char[] indentChars = this._indentChars;
			if (indentChars == null)
			{
				char indentChar = this._indentChar;
				string text;
				char[] array = text.ToCharArray();
				this._indentChars = array;
			}
			if (indentChars == null)
			{
			}
			int num = 10;
			int num2 = Math.Min(43159552, num);
			TextWriter writer2 = this._writer;
			char[] indentChars2 = this._indentChars;
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00005108 File Offset: 0x00003308
		protected override void WriteValueDelimiter()
		{
			TextWriter writer = this._writer;
		}

		// Token: 0x06000120 RID: 288 RVA: 0x0000511C File Offset: 0x0000331C
		protected override void WriteIndentSpace()
		{
			TextWriter writer = this._writer;
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00005130 File Offset: 0x00003330
		private void WriteValueInternal(string value, JsonToken token)
		{
			TextWriter writer = this._writer;
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00005144 File Offset: 0x00003344
		public override void WriteValue(object value)
		{
			base.WriteValue(value);
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00005158 File Offset: 0x00003358
		public override void WriteNull()
		{
			base.InternalWriteValue(JsonToken.Null);
			if (!true)
			{
			}
			TextWriter writer = this._writer;
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00005178 File Offset: 0x00003378
		public override void WriteUndefined()
		{
			base.InternalWriteValue(JsonToken.Undefined);
			if (!true)
			{
			}
			TextWriter writer = this._writer;
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00005198 File Offset: 0x00003398
		public override void WriteRaw(string json)
		{
			base.InternalWriteRaw();
			TextWriter writer = this._writer;
		}

		// Token: 0x06000126 RID: 294 RVA: 0x000051B4 File Offset: 0x000033B4
		public override void WriteValue(string value)
		{
			base.InternalWriteValue(JsonToken.String);
			if (value != null)
			{
				this.WriteEscapedString(value, true);
				return;
			}
			if (!true)
			{
			}
			TextWriter writer = this._writer;
		}

		// Token: 0x06000127 RID: 295 RVA: 0x000051E0 File Offset: 0x000033E0
		private void WriteEscapedString(string value, bool quote)
		{
			char[] writeBuffer = this._writeBuffer;
			if (writeBuffer == null)
			{
				char[] array = BufferUtils.RentBuffer(this._arrayPool, 35);
				this._writeBuffer = array;
			}
			TextWriter writer = this._writer;
			char quoteChar = this._quoteChar;
			bool[] charEscapeFlags = this._charEscapeFlags;
			StringEscapeHandling stringEscapeHandling = this._stringEscapeHandling;
			IArrayPool<char> arrayPool = this._arrayPool;
			if (writeBuffer == null)
			{
			}
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00005238 File Offset: 0x00003438
		public override void WriteValue(int value)
		{
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00005248 File Offset: 0x00003448
		[CLSCompliant(false)]
		public override void WriteValue(uint value)
		{
			base.InternalWriteValue(JsonToken.Integer);
			this.WriteIntegerValue((long)value);
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00005264 File Offset: 0x00003464
		public override void WriteValue(long value)
		{
			base.InternalWriteValue(JsonToken.Integer);
			this.WriteIntegerValue(value);
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00005280 File Offset: 0x00003480
		[CLSCompliant(false)]
		public override void WriteValue(ulong value)
		{
			base.InternalWriteValue(JsonToken.Integer);
			this.WriteIntegerValue(value);
		}

		// Token: 0x0600012C RID: 300 RVA: 0x0000529C File Offset: 0x0000349C
		public override void WriteValue(float value)
		{
			base.InternalWriteValue(JsonToken.Float);
			FloatFormatHandling floatFormatHandling = this._floatFormatHandling;
			char quoteChar = this._quoteChar;
			if (!true)
			{
			}
			long num = 0L;
			string text = JsonConvert.ToString(value, floatFormatHandling, quoteChar, num != 0L);
			TextWriter writer = this._writer;
		}

		// Token: 0x0600012D RID: 301 RVA: 0x000052D8 File Offset: 0x000034D8
		public override void WriteValue(float? value)
		{
			base.InternalWriteValue(JsonToken.Float);
			FloatFormatHandling floatFormatHandling = this._floatFormatHandling;
			char quoteChar = this._quoteChar;
			if (!true)
			{
			}
			TextWriter writer = this._writer;
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00005308 File Offset: 0x00003508
		public override void WriteValue(double value)
		{
			base.InternalWriteValue(JsonToken.Float);
			FloatFormatHandling floatFormatHandling = this._floatFormatHandling;
			char quoteChar = this._quoteChar;
			if (!true)
			{
			}
			long num = 0L;
			string text = JsonConvert.ToString(value, floatFormatHandling, quoteChar, num != 0L);
			TextWriter writer = this._writer;
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00005344 File Offset: 0x00003544
		public override void WriteValue(double? value)
		{
			base.InternalWriteValue(JsonToken.Float);
			FloatFormatHandling floatFormatHandling = this._floatFormatHandling;
			char quoteChar = this._quoteChar;
			if (!true)
			{
			}
			TextWriter writer = this._writer;
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00005374 File Offset: 0x00003574
		public override void WriteValue(bool value)
		{
			base.InternalWriteValue(JsonToken.Boolean);
			if (!true)
			{
			}
			string text = JsonConvert.ToString(true);
			TextWriter writer = this._writer;
		}

		// Token: 0x06000131 RID: 305 RVA: 0x0000539C File Offset: 0x0000359C
		public override void WriteValue(short value)
		{
		}

		// Token: 0x06000132 RID: 306 RVA: 0x000053AC File Offset: 0x000035AC
		[CLSCompliant(false)]
		public override void WriteValue(ushort value)
		{
		}

		// Token: 0x06000133 RID: 307 RVA: 0x000053BC File Offset: 0x000035BC
		public override void WriteValue(char value)
		{
			base.InternalWriteValue(JsonToken.String);
			if (!true)
			{
			}
			string text = JsonConvert.ToString(value);
			TextWriter writer = this._writer;
		}

		// Token: 0x06000134 RID: 308 RVA: 0x000053E4 File Offset: 0x000035E4
		public override void WriteValue(byte value)
		{
		}

		// Token: 0x06000135 RID: 309 RVA: 0x000053F4 File Offset: 0x000035F4
		[CLSCompliant(false)]
		public override void WriteValue(sbyte value)
		{
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00005404 File Offset: 0x00003604
		public override void WriteValue(decimal value)
		{
			base.InternalWriteValue(JsonToken.Float);
			if (!true)
			{
			}
			string text = JsonConvert.ToString(value);
			TextWriter writer = this._writer;
		}

		// Token: 0x06000137 RID: 311 RVA: 0x0000542C File Offset: 0x0000362C
		public override void WriteValue(DateTime value)
		{
			int num = 1;
			DateTimeZoneHandling dateTimeZoneHandling = this._dateTimeZoneHandling;
			if (num == 0)
			{
			}
			DateTime dateTime = DateTimeUtils.EnsureDateTime(value, dateTimeZoneHandling);
			bool flag = string.IsNullOrEmpty(this._dateFormatString);
			if (this._writeBuffer == null)
			{
				IArrayPool<char> arrayPool = this._arrayPool;
				int num2 = 35;
				char[] array = BufferUtils.RentBuffer(arrayPool, num2);
				this._writeBuffer = array;
			}
			char quoteChar = this._quoteChar;
			DateFormatHandling dateFormatHandling = this._dateFormatHandling;
			char[] writeBuffer = this._writeBuffer;
			char quoteChar2 = this._quoteChar;
			TextWriter writer = this._writer;
		}

		// Token: 0x06000138 RID: 312 RVA: 0x000054E4 File Offset: 0x000036E4
		public override void WriteValue(byte[] value)
		{
			if (value != null)
			{
				base.InternalWriteValue(JsonToken.Bytes);
				TextWriter writer = this._writer;
				char quoteChar = this._quoteChar;
				Base64Encoder base64Encoder = this.Base64Encoder;
				this.Base64Encoder.Flush();
				TextWriter writer2 = this._writer;
				char quoteChar2 = this._quoteChar;
				return;
			}
		}

		// Token: 0x06000139 RID: 313 RVA: 0x0000552C File Offset: 0x0000372C
		public override void WriteValue(DateTimeOffset value)
		{
			bool flag = string.IsNullOrEmpty(this._dateFormatString);
			if (this._writeBuffer == null)
			{
				IArrayPool<char> arrayPool = this._arrayPool;
				int num = 35;
				char[] array = BufferUtils.RentBuffer(arrayPool, num);
				this._writeBuffer = array;
			}
			char quoteChar = this._quoteChar;
			if (this._dateFormatHandling != DateFormatHandling.IsoDateFormat)
			{
				return;
			}
			DateFormatHandling dateFormatHandling = this._dateFormatHandling;
			char[] writeBuffer = this._writeBuffer;
			char quoteChar2 = this._quoteChar;
			TextWriter writer = this._writer;
		}

		// Token: 0x0600013A RID: 314 RVA: 0x000055D0 File Offset: 0x000037D0
		public override void WriteValue(Guid value)
		{
			base.InternalWriteValue(JsonToken.String);
			if (!true)
			{
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			TextWriter writer = this._writer;
			char quoteChar = this._quoteChar;
			TextWriter writer2 = this._writer;
			TextWriter writer3 = this._writer;
			char quoteChar2 = this._quoteChar;
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00005618 File Offset: 0x00003818
		public override void WriteValue(TimeSpan value)
		{
			base.InternalWriteValue(JsonToken.String);
			TextWriter writer = this._writer;
			char quoteChar = this._quoteChar;
			TextWriter writer2 = this._writer;
			TextWriter writer3 = this._writer;
			char quoteChar2 = this._quoteChar;
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00005654 File Offset: 0x00003854
		public override void WriteValue(Uri value)
		{
			if (!true)
			{
			}
		}

		// Token: 0x0600013D RID: 317 RVA: 0x0000567C File Offset: 0x0000387C
		public override void WriteComment(string text)
		{
			base.InternalWriteComment();
			TextWriter writer = this._writer;
			TextWriter writer2 = this._writer;
			TextWriter writer3 = this._writer;
		}

		// Token: 0x0600013E RID: 318 RVA: 0x000056A4 File Offset: 0x000038A4
		public override void WriteWhitespace(string ws)
		{
			/*
An exception occurred when decompiling this method (0600013E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Newtonsoft.Json.JsonTextWriter::WriteWhitespace(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(JsonWriter::InternalWriteWhitespace, ldloc:JsonTextWriter[exp:JsonWriter](this), ldloc:string(ws))
	stloc:TextWriter(var_0_0D, ldfld:TextWriter(JsonTextWriter::_writer, ldloc:JsonTextWriter(this)))
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

		// Token: 0x0600013F RID: 319 RVA: 0x000056C0 File Offset: 0x000038C0
		private void EnsureWriteBuffer()
		{
			if (this._writeBuffer == null)
			{
				char[] array = BufferUtils.RentBuffer(this._arrayPool, 35);
				this._writeBuffer = array;
			}
		}

		// Token: 0x06000140 RID: 320 RVA: 0x000056EC File Offset: 0x000038EC
		private void WriteIntegerValue(long value)
		{
			TextWriter writer = this._writer;
			int num = 45;
			this.WriteIntegerValue((ulong)num);
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00005714 File Offset: 0x00003914
		private void WriteIntegerValue(ulong uvalue)
		{
			TextWriter writer = this._writer;
		}

		// Token: 0x040000BB RID: 187
		private readonly TextWriter _writer;

		// Token: 0x040000BC RID: 188
		private Base64Encoder _base64Encoder;

		// Token: 0x040000BD RID: 189
		private char _indentChar;

		// Token: 0x040000BE RID: 190
		private int _indentation;

		// Token: 0x040000BF RID: 191
		private char _quoteChar;

		// Token: 0x040000C0 RID: 192
		private bool _quoteName;

		// Token: 0x040000C1 RID: 193
		private bool[] _charEscapeFlags;

		// Token: 0x040000C2 RID: 194
		private char[] _writeBuffer;

		// Token: 0x040000C3 RID: 195
		private IArrayPool<char> _arrayPool;

		// Token: 0x040000C4 RID: 196
		private char[] _indentChars;
	}
}
