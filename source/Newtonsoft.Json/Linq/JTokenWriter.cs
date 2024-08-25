using System;
using System.Globalization;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000D4 RID: 212
	[Preserve]
	public class JTokenWriter : JsonWriter
	{
		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06000826 RID: 2086 RVA: 0x00014408 File Offset: 0x00012608
		public JToken CurrentToken
		{
			get
			{
				return this._current;
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06000827 RID: 2087 RVA: 0x0001441C File Offset: 0x0001261C
		public JToken Token
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000827)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Newtonsoft.Json.Linq.JToken Newtonsoft.Json.Linq.JTokenWriter::get_Token()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:JContainer(var_0_06, ldfld:JContainer(JTokenWriter::_token, ldloc:JTokenWriter(this)))
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

		// Token: 0x06000828 RID: 2088 RVA: 0x00014430 File Offset: 0x00012630
		public JTokenWriter(JContainer container)
		{
			if (!true)
			{
			}
			base..ctor();
			ValidationUtils.ArgumentNotNull(container, "container");
			this._token = container;
			this._parent = container;
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x00014460 File Offset: 0x00012660
		public JTokenWriter()
		{
			if (!true)
			{
			}
			base..ctor();
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x00014478 File Offset: 0x00012678
		public override void Flush()
		{
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x00014488 File Offset: 0x00012688
		public override void Close()
		{
			base.Close();
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x0001449C File Offset: 0x0001269C
		public override void WriteStartObject()
		{
			base.WriteStartObject();
			if (this._parent != null)
			{
				return;
			}
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x000144B8 File Offset: 0x000126B8
		private void AddParent(JContainer container)
		{
			JContainer parent = this._parent;
			if (parent != null)
			{
				parent.AddAndSkipParentCheck(container);
				return;
			}
			this._token = container;
			this._parent = container;
			this._current = container;
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x000144EC File Offset: 0x000126EC
		private void RemoveParent()
		{
			JContainer parent = this._parent;
			this._current = parent;
			JContainer parent2 = parent._parent;
			this._parent = parent2;
			if (parent2 != null)
			{
				JContainer parent3 = this._parent._parent;
				this._parent = parent3;
			}
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x0001452C File Offset: 0x0001272C
		public override void WriteStartArray()
		{
			base.WriteStartArray();
			if (this._parent != null)
			{
				return;
			}
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x00014548 File Offset: 0x00012748
		public override void WriteStartConstructor(string name)
		{
			base.WriteStartConstructor(name);
			if (this._parent != null)
			{
				return;
			}
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x00014568 File Offset: 0x00012768
		protected override void WriteEnd(JsonToken token)
		{
			JContainer parent = this._parent;
			this._current = parent;
			JContainer parent2 = parent._parent;
			this._parent = parent2;
			if (parent2 != null)
			{
				JContainer parent3 = this._parent._parent;
				this._parent = parent3;
			}
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x000145A8 File Offset: 0x000127A8
		public override void WritePropertyName(string name)
		{
			if (this._parent != null)
			{
			}
			if (this._parent != null)
			{
				return;
			}
			base.WritePropertyName(name);
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x000145D0 File Offset: 0x000127D0
		private void AddValue(object value, JsonToken token)
		{
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x000145E0 File Offset: 0x000127E0
		internal void AddValue(JValue value, JsonToken token)
		{
			if (this._parent != null)
			{
				JContainer parent = this._parent;
				JContainer parent2 = this._parent;
				this._current = parent;
				JContainer parent3 = this._parent._parent;
				this._parent = parent3;
				return;
			}
			JValue jvalue;
			if (value == null)
			{
				jvalue = JValue.CreateNull();
			}
			this._value = jvalue;
			this._current = jvalue;
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x0001463C File Offset: 0x0001283C
		public override void WriteValue(object value)
		{
			base.WriteValue(value);
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x00014650 File Offset: 0x00012850
		public override void WriteNull()
		{
			base.WriteNull();
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x00014664 File Offset: 0x00012864
		public override void WriteUndefined()
		{
			base.WriteUndefined();
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x00014678 File Offset: 0x00012878
		public override void WriteRaw(string json)
		{
			base.WriteRaw(json);
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x0001468C File Offset: 0x0001288C
		public override void WriteComment(string text)
		{
			base.WriteComment(text);
			JValue jvalue = JValue.CreateComment(text);
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x000146A8 File Offset: 0x000128A8
		public override void WriteValue(string value)
		{
			base.WriteValue(value);
			this.AddValue(value, JsonToken.String);
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x000146C8 File Offset: 0x000128C8
		public override void WriteValue(int value)
		{
			base.WriteValue(value);
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x000146DC File Offset: 0x000128DC
		[CLSCompliant(false)]
		public override void WriteValue(uint value)
		{
			base.WriteValue(value);
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x000146F0 File Offset: 0x000128F0
		public override void WriteValue(long value)
		{
			base.WriteValue(value);
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x00014704 File Offset: 0x00012904
		[CLSCompliant(false)]
		public override void WriteValue(ulong value)
		{
			base.WriteValue(value);
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x00014718 File Offset: 0x00012918
		public override void WriteValue(float value)
		{
			base.WriteValue(value);
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x0001472C File Offset: 0x0001292C
		public override void WriteValue(double value)
		{
			base.WriteValue(value);
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x00014740 File Offset: 0x00012940
		public override void WriteValue(bool value)
		{
			base.WriteValue(value);
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x00014754 File Offset: 0x00012954
		public override void WriteValue(short value)
		{
			base.WriteValue(value);
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x00014768 File Offset: 0x00012968
		[CLSCompliant(false)]
		public override void WriteValue(ushort value)
		{
			base.WriteValue(value);
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x0001477C File Offset: 0x0001297C
		public override void WriteValue(char value)
		{
			base.WriteValue(value);
			if (!true)
			{
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			string text;
			this.AddValue(text, JsonToken.String);
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x000147A4 File Offset: 0x000129A4
		public override void WriteValue(byte value)
		{
			base.WriteValue(value);
		}

		// Token: 0x06000846 RID: 2118 RVA: 0x000147B8 File Offset: 0x000129B8
		[CLSCompliant(false)]
		public override void WriteValue(sbyte value)
		{
			base.WriteValue(value);
		}

		// Token: 0x06000847 RID: 2119 RVA: 0x000147CC File Offset: 0x000129CC
		public override void WriteValue(decimal value)
		{
			base.WriteValue(value);
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x000147E0 File Offset: 0x000129E0
		public override void WriteValue(DateTime value)
		{
			base.WriteValue(value);
			DateTimeZoneHandling dateTimeZoneHandling = this._dateTimeZoneHandling;
			if (!true)
			{
			}
			DateTime dateTime = DateTimeUtils.EnsureDateTime(value, dateTimeZoneHandling);
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x00014808 File Offset: 0x00012A08
		public override void WriteValue(DateTimeOffset value)
		{
			base.WriteValue(value);
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x0001481C File Offset: 0x00012A1C
		public override void WriteValue(byte[] value)
		{
			base.WriteValue(value);
			this.AddValue(value, JsonToken.Bytes);
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x0001483C File Offset: 0x00012A3C
		public override void WriteValue(TimeSpan value)
		{
			base.WriteValue(value);
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x00014850 File Offset: 0x00012A50
		public override void WriteValue(Guid value)
		{
			base.WriteValue(value);
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x00014864 File Offset: 0x00012A64
		public override void WriteValue(Uri value)
		{
			base.WriteValue(value);
			this.AddValue(value, JsonToken.String);
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x00014884 File Offset: 0x00012A84
		internal override void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments)
		{
			if (reader == null)
			{
				long num;
				base.WriteToken(reader, num != 0L, writeDateConstructorAsDate, writeComments);
				return;
			}
			if (this._parent != null)
			{
				JContainer parent = this._parent;
				JContainer parent2 = this._parent;
				this._current = parent;
				JContainer parent3 = this._parent;
				long num = 0L;
				JContainer parent4 = parent3._parent;
				this._parent = parent4;
				return;
			}
			JContainer token = this._token;
			this._current = reader;
			if (token != null || this._value != null)
			{
				return;
			}
			if (reader != null)
			{
				return;
			}
		}

		// Token: 0x04000338 RID: 824
		private JContainer _token;

		// Token: 0x04000339 RID: 825
		private JContainer _parent;

		// Token: 0x0400033A RID: 826
		private JValue _value;

		// Token: 0x0400033B RID: 827
		private JToken _current;
	}
}
