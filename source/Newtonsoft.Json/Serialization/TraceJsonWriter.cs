using System;
using System.Globalization;
using System.IO;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000080 RID: 128
	[Preserve]
	internal class TraceJsonWriter : JsonWriter
	{
		// Token: 0x0600047F RID: 1151 RVA: 0x0000BE8C File Offset: 0x0000A08C
		public TraceJsonWriter(JsonWriter innerWriter)
		{
			if (!true)
			{
			}
			base..ctor();
			this._dateTimeZoneHandling = DateTimeZoneHandling.RoundtripKind;
			this.<CloseOutput>k__BackingField = true;
			this._innerWriter = innerWriter;
			if (3 == 0)
			{
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			string newLine = Environment.NewLine;
			string text = "Serialized JSON: " + newLine;
			StringWriter sw = this._sw;
			CultureInfo culture = innerWriter.Culture;
			JsonTextWriter textWriter = this._textWriter;
			DateFormatHandling dateFormatHandling = innerWriter._dateFormatHandling;
			textWriter.DateFormatHandling = dateFormatHandling;
			JsonTextWriter textWriter2 = this._textWriter;
			string dateFormatString = innerWriter._dateFormatString;
			textWriter2._dateFormatString = dateFormatString;
			DateTimeZoneHandling dateTimeZoneHandling = innerWriter._dateTimeZoneHandling;
			textWriter2.DateTimeZoneHandling = dateTimeZoneHandling;
			JsonTextWriter textWriter3 = this._textWriter;
			FloatFormatHandling floatFormatHandling = innerWriter._floatFormatHandling;
			textWriter3.FloatFormatHandling = floatFormatHandling;
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x0000BF44 File Offset: 0x0000A144
		public string GetSerializedJsonMessage()
		{
			/*
An exception occurred when decompiling this method (06000480)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String Newtonsoft.Json.Serialization.TraceJsonWriter::GetSerializedJsonMessage()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:StringWriter(var_0_06, ldfld:StringWriter(TraceJsonWriter::_sw, ldloc:TraceJsonWriter(this)))
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

		// Token: 0x06000481 RID: 1153 RVA: 0x0000BF58 File Offset: 0x0000A158
		public override void WriteValue(decimal value)
		{
			JsonTextWriter textWriter = this._textWriter;
			JsonWriter innerWriter = this._innerWriter;
			if (this._currentPosition.HasIndex)
			{
				int position = this._currentPosition.Position;
				this._currentPosition.Position = position;
			}
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x0000BF98 File Offset: 0x0000A198
		public override void WriteValue(bool value)
		{
			JsonTextWriter textWriter = this._textWriter;
			JsonWriter innerWriter = this._innerWriter;
			if (this._currentPosition.HasIndex)
			{
				int position = this._currentPosition.Position;
				this._currentPosition.Position = position;
			}
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x0000BFD8 File Offset: 0x0000A1D8
		public override void WriteValue(byte value)
		{
			JsonTextWriter textWriter = this._textWriter;
			JsonWriter innerWriter = this._innerWriter;
			if (this._currentPosition.HasIndex)
			{
				int position = this._currentPosition.Position;
				this._currentPosition.Position = position;
			}
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x0000C018 File Offset: 0x0000A218
		public override void WriteValue(byte? value)
		{
			JsonTextWriter textWriter = this._textWriter;
			JsonWriter innerWriter = this._innerWriter;
			base.WriteValue(value);
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x0000C03C File Offset: 0x0000A23C
		public override void WriteValue(char value)
		{
			JsonTextWriter textWriter = this._textWriter;
			JsonWriter innerWriter = this._innerWriter;
			if (this._currentPosition.HasIndex)
			{
				int position = this._currentPosition.Position;
				this._currentPosition.Position = position;
			}
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x0000C07C File Offset: 0x0000A27C
		public override void WriteValue(byte[] value)
		{
			JsonTextWriter textWriter = this._textWriter;
			JsonWriter innerWriter = this._innerWriter;
			base.WriteValue(value);
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x0000C0A0 File Offset: 0x0000A2A0
		public override void WriteValue(DateTime value)
		{
			JsonTextWriter textWriter = this._textWriter;
			JsonWriter innerWriter = this._innerWriter;
			if (this._currentPosition.HasIndex)
			{
				int position = this._currentPosition.Position;
				this._currentPosition.Position = position;
			}
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x0000C0E0 File Offset: 0x0000A2E0
		public override void WriteValue(DateTimeOffset value)
		{
			JsonTextWriter textWriter = this._textWriter;
			JsonWriter innerWriter = this._innerWriter;
			if (this._currentPosition.HasIndex)
			{
				int position = this._currentPosition.Position;
				this._currentPosition.Position = position;
			}
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x0000C120 File Offset: 0x0000A320
		public override void WriteValue(double value)
		{
			JsonTextWriter textWriter = this._textWriter;
			JsonWriter innerWriter = this._innerWriter;
			if (this._currentPosition.HasIndex)
			{
				int position = this._currentPosition.Position;
				this._currentPosition.Position = position;
			}
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x0000C160 File Offset: 0x0000A360
		public override void WriteUndefined()
		{
			JsonTextWriter textWriter = this._textWriter;
			JsonWriter innerWriter = this._innerWriter;
			if (this._currentPosition.HasIndex)
			{
				int position = this._currentPosition.Position;
				this._currentPosition.Position = position;
			}
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x0000C1A0 File Offset: 0x0000A3A0
		public override void WriteNull()
		{
			JsonTextWriter textWriter = this._textWriter;
			JsonWriter innerWriter = this._innerWriter;
			if (this._currentPosition.HasIndex)
			{
				int position = this._currentPosition.Position;
				this._currentPosition.Position = position;
			}
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x0000C1E0 File Offset: 0x0000A3E0
		public override void WriteValue(float value)
		{
			JsonTextWriter textWriter = this._textWriter;
			JsonWriter innerWriter = this._innerWriter;
			if (this._currentPosition.HasIndex)
			{
				int position = this._currentPosition.Position;
				this._currentPosition.Position = position;
			}
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x0000C220 File Offset: 0x0000A420
		public override void WriteValue(Guid value)
		{
			JsonTextWriter textWriter = this._textWriter;
			JsonWriter innerWriter = this._innerWriter;
			if (this._currentPosition.HasIndex)
			{
				int position = this._currentPosition.Position;
				this._currentPosition.Position = position;
			}
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x0000C260 File Offset: 0x0000A460
		public override void WriteValue(int value)
		{
			JsonTextWriter textWriter = this._textWriter;
			JsonWriter innerWriter = this._innerWriter;
			if (this._currentPosition.HasIndex)
			{
				int position = this._currentPosition.Position;
				this._currentPosition.Position = position;
			}
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x0000C2A0 File Offset: 0x0000A4A0
		public override void WriteValue(long value)
		{
			JsonTextWriter textWriter = this._textWriter;
			JsonWriter innerWriter = this._innerWriter;
			if (this._currentPosition.HasIndex)
			{
				int position = this._currentPosition.Position;
				this._currentPosition.Position = position;
			}
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x0000C2E0 File Offset: 0x0000A4E0
		public override void WriteValue(object value)
		{
			JsonTextWriter textWriter = this._textWriter;
			JsonWriter innerWriter = this._innerWriter;
			base.WriteValue(value);
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x0000C304 File Offset: 0x0000A504
		public override void WriteValue(sbyte value)
		{
			JsonTextWriter textWriter = this._textWriter;
			JsonWriter innerWriter = this._innerWriter;
			if (this._currentPosition.HasIndex)
			{
				int position = this._currentPosition.Position;
				this._currentPosition.Position = position;
			}
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x0000C344 File Offset: 0x0000A544
		public override void WriteValue(short value)
		{
			JsonTextWriter textWriter = this._textWriter;
			JsonWriter innerWriter = this._innerWriter;
			if (this._currentPosition.HasIndex)
			{
				int position = this._currentPosition.Position;
				this._currentPosition.Position = position;
			}
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x0000C384 File Offset: 0x0000A584
		public override void WriteValue(string value)
		{
			JsonTextWriter textWriter = this._textWriter;
			JsonWriter innerWriter = this._innerWriter;
			if (this._currentPosition.HasIndex)
			{
				int position = this._currentPosition.Position;
				this._currentPosition.Position = position;
			}
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x0000C3C4 File Offset: 0x0000A5C4
		public override void WriteValue(TimeSpan value)
		{
			JsonTextWriter textWriter = this._textWriter;
			JsonWriter innerWriter = this._innerWriter;
			if (this._currentPosition.HasIndex)
			{
				int position = this._currentPosition.Position;
				this._currentPosition.Position = position;
			}
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x0000C404 File Offset: 0x0000A604
		public override void WriteValue(uint value)
		{
			JsonTextWriter textWriter = this._textWriter;
			JsonWriter innerWriter = this._innerWriter;
			if (this._currentPosition.HasIndex)
			{
				int position = this._currentPosition.Position;
				this._currentPosition.Position = position;
			}
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x0000C444 File Offset: 0x0000A644
		public override void WriteValue(ulong value)
		{
			JsonTextWriter textWriter = this._textWriter;
			JsonWriter innerWriter = this._innerWriter;
			if (this._currentPosition.HasIndex)
			{
				int position = this._currentPosition.Position;
				this._currentPosition.Position = position;
			}
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x0000C484 File Offset: 0x0000A684
		public override void WriteValue(Uri value)
		{
			JsonTextWriter textWriter = this._textWriter;
			JsonWriter innerWriter = this._innerWriter;
			base.WriteValue(value);
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x0000C4A8 File Offset: 0x0000A6A8
		public override void WriteValue(ushort value)
		{
			JsonTextWriter textWriter = this._textWriter;
			JsonWriter innerWriter = this._innerWriter;
			if (this._currentPosition.HasIndex)
			{
				int position = this._currentPosition.Position;
				this._currentPosition.Position = position;
			}
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x0000C4E8 File Offset: 0x0000A6E8
		public override void WriteWhitespace(string ws)
		{
			JsonTextWriter textWriter = this._textWriter;
			JsonWriter innerWriter = this._innerWriter;
			base.InternalWriteWhitespace(ws);
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x0000C50C File Offset: 0x0000A70C
		public override void WriteComment(string text)
		{
			JsonTextWriter textWriter = this._textWriter;
			JsonWriter innerWriter = this._innerWriter;
			base.AutoComplete(JsonToken.Comment);
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x0000C530 File Offset: 0x0000A730
		public override void WriteStartArray()
		{
			JsonTextWriter textWriter = this._textWriter;
			base.InternalWriteStart(JsonToken.StartArray, JsonContainerType.Array);
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x0000C54C File Offset: 0x0000A74C
		public override void WriteEndArray()
		{
			JsonTextWriter textWriter = this._textWriter;
			JsonWriter innerWriter = this._innerWriter;
			base.AutoCompleteClose(JsonContainerType.Array);
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x0000C570 File Offset: 0x0000A770
		public override void WriteStartConstructor(string name)
		{
			JsonTextWriter textWriter = this._textWriter;
			JsonWriter innerWriter = this._innerWriter;
			base.InternalWriteStart(JsonToken.StartConstructor, JsonContainerType.Constructor);
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x0000C594 File Offset: 0x0000A794
		public override void WriteEndConstructor()
		{
			JsonTextWriter textWriter = this._textWriter;
			JsonWriter innerWriter = this._innerWriter;
			base.AutoCompleteClose(JsonContainerType.Constructor);
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x0000C5B8 File Offset: 0x0000A7B8
		public override void WritePropertyName(string name)
		{
			JsonTextWriter textWriter = this._textWriter;
			JsonWriter innerWriter = this._innerWriter;
			this._currentPosition.PropertyName = name;
			base.AutoComplete(JsonToken.PropertyName);
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x0000C5E8 File Offset: 0x0000A7E8
		public override void WritePropertyName(string name, bool escape)
		{
			JsonTextWriter textWriter = this._textWriter;
			JsonWriter innerWriter = this._innerWriter;
			this._currentPosition.PropertyName = name;
			base.AutoComplete(JsonToken.PropertyName);
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x0000C618 File Offset: 0x0000A818
		public override void WriteStartObject()
		{
			JsonTextWriter textWriter = this._textWriter;
			JsonWriter innerWriter = this._innerWriter;
			base.InternalWriteStart(JsonToken.StartObject, JsonContainerType.Object);
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x0000C63C File Offset: 0x0000A83C
		public override void WriteEndObject()
		{
			JsonTextWriter textWriter = this._textWriter;
			JsonWriter innerWriter = this._innerWriter;
			base.AutoCompleteClose(JsonContainerType.Object);
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x0000C660 File Offset: 0x0000A860
		public override void WriteRawValue(string json)
		{
			JsonTextWriter textWriter = this._textWriter;
			JsonWriter innerWriter = this._innerWriter;
			if (this._currentPosition.HasIndex)
			{
				int position = this._currentPosition.Position;
				this._currentPosition.Position = position;
			}
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x0000C6A0 File Offset: 0x0000A8A0
		public override void WriteRaw(string json)
		{
			JsonTextWriter textWriter = this._textWriter;
			JsonWriter innerWriter = this._innerWriter;
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x0000C6BC File Offset: 0x0000A8BC
		public override void Close()
		{
			JsonTextWriter textWriter = this._textWriter;
			JsonWriter innerWriter = this._innerWriter;
			base.AutoCompleteAll();
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x0000C6E0 File Offset: 0x0000A8E0
		public override void Flush()
		{
			JsonTextWriter textWriter = this._textWriter;
			JsonWriter innerWriter = this._innerWriter;
		}

		// Token: 0x04000217 RID: 535
		private readonly JsonWriter _innerWriter;

		// Token: 0x04000218 RID: 536
		private readonly JsonTextWriter _textWriter;

		// Token: 0x04000219 RID: 537
		private readonly StringWriter _sw;
	}
}
