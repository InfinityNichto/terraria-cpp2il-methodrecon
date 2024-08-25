using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2IlInjected;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x02000120 RID: 288
	[Preserve]
	public class BsonReader : JsonReader
	{
		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06000B40 RID: 2880 RVA: 0x0001B1F8 File Offset: 0x000193F8
		// (set) Token: 0x06000B41 RID: 2881 RVA: 0x0001B20C File Offset: 0x0001940C
		[Obsolete("JsonNet35BinaryCompatibility will be removed in a future version of Json.NET.")]
		public bool JsonNet35BinaryCompatibility
		{
			get
			{
				return this._jsonNet35BinaryCompatibility;
			}
			set
			{
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000B42 RID: 2882 RVA: 0x0001B21C File Offset: 0x0001941C
		// (set) Token: 0x06000B43 RID: 2883 RVA: 0x0001B230 File Offset: 0x00019430
		public bool ReadRootValueAsArray
		{
			get
			{
				return this._readRootValueAsArray;
			}
			set
			{
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000B44 RID: 2884 RVA: 0x0001B240 File Offset: 0x00019440
		// (set) Token: 0x06000B45 RID: 2885 RVA: 0x0001B254 File Offset: 0x00019454
		public DateTimeKind DateTimeKindHandling
		{
			get
			{
				return this._dateTimeKindHandling;
			}
			set
			{
				this._dateTimeKindHandling = value;
			}
		}

		// Token: 0x06000B46 RID: 2886 RVA: 0x0001B268 File Offset: 0x00019468
		public BsonReader(Stream stream)
		{
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x0001B278 File Offset: 0x00019478
		public BsonReader(BinaryReader reader)
		{
		}

		// Token: 0x06000B48 RID: 2888 RVA: 0x0001B288 File Offset: 0x00019488
		public BsonReader(Stream stream, bool readRootValueAsArray, DateTimeKind dateTimeKindHandling)
		{
			ValidationUtils.ArgumentNotNull(stream, "stream");
			this._dateTimeKindHandling = dateTimeKindHandling;
		}

		// Token: 0x06000B49 RID: 2889 RVA: 0x0001B2B0 File Offset: 0x000194B0
		public BsonReader(BinaryReader reader, bool readRootValueAsArray, DateTimeKind dateTimeKindHandling)
		{
			ValidationUtils.ArgumentNotNull(reader, "reader");
			this._reader = reader;
			this._dateTimeKindHandling = dateTimeKindHandling;
		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x0001B2DC File Offset: 0x000194DC
		private string ReadElement()
		{
			BsonReader.ContainerContext currentContext = this._currentContext;
			int position = currentContext.Position;
			currentContext.Position = position;
			BinaryReader reader = this._reader;
			this._currentElementType = reader;
			return this.ReadString();
		}

		// Token: 0x06000B4B RID: 2891 RVA: 0x0001B314 File Offset: 0x00019514
		public override bool Read()
		{
			/*
An exception occurred when decompiling this method (06000B4B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Newtonsoft.Json.Bson.BsonReader::Read()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0027:
	stloc:CultureInfo(var_6_2F, callgetter:CultureInfo(CultureInfo::get_InvariantCulture))
	stloc:BsonReaderState(var_7_37, ldfld:BsonReaderState(BsonReader::_bsonReaderState, ldloc:BsonReader(this)))
	stloc:JsonReaderException(var_9_41, call:JsonReaderException(JsonReaderException::Create, ldloc:BsonReader[exp:JsonReader](this), ldloc:string(var_8)))
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

		// Token: 0x06000B4C RID: 2892 RVA: 0x0001B36C File Offset: 0x0001956C
		public override void Close()
		{
			base.Close();
			if (this.<CloseInput>k__BackingField && this._reader != null)
			{
				return;
			}
		}

		// Token: 0x06000B4D RID: 2893 RVA: 0x0001B390 File Offset: 0x00019590
		private bool ReadCodeWScope()
		{
			BsonReader.BsonReaderState bsonReaderState = this._bsonReaderState;
			return "$code" != null;
		}

		// Token: 0x06000B4E RID: 2894 RVA: 0x0001B41C File Offset: 0x0001961C
		private bool ReadReference()
		{
			/*
An exception occurred when decompiling this method (06000B4E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Newtonsoft.Json.Bson.BsonReader::ReadReference()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:State(var_0_06, ldfld:State(JsonReader::_currentState, ldloc:BsonReader[exp:JsonReader](this)))
	stloc:BsonReaderState(var_1_0D, ldfld:BsonReaderState(BsonReader::_bsonReaderState, ldloc:BsonReader(this)))
	stloc:int32(var_2_0F, ldc.i4:int32(3))
	stfld:BsonReaderState(BsonReader::_bsonReaderState, ldloc:BsonReader(this), ldloc:int32[exp:BsonReaderState](var_2_0F))
	stloc:BsonReaderState(var_3_1D, ldfld:BsonReaderState(BsonReader::_bsonReaderState, ldloc:BsonReader(this)))
	stloc:string(var_4_24, call:string(BsonReader::ReadLengthString, ldloc:BsonReader(this)))
	stloc:ContainerContext(var_5_2C, ldfld:ContainerContext(BsonReader::_currentContext, ldloc:BsonReader(this)))
	stloc:int32(var_6_35, ldfld:int32(ContainerContext::Position, ldloc:ContainerContext(var_5_2C)))
	stfld:int32(ContainerContext::Position, ldloc:ContainerContext(var_5_2C), ldloc:int32(var_6_35))
	stloc:BinaryReader(var_7_46, ldfld:BinaryReader(BsonReader::_reader, ldloc:BsonReader(this)))
	stloc:JsonReaderException(var_10_53, call:JsonReaderException(JsonReaderException::Create, ldloc:BsonReader[exp:JsonReader](this), ldloc:string(var_9)))
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

		// Token: 0x06000B4F RID: 2895 RVA: 0x0001B480 File Offset: 0x00019680
		private bool ReadNormal()
		{
			JsonReader.State currentState = this._currentState;
			BsonReader.ContainerContext currentContext = this._currentContext;
			if (currentContext != null)
			{
				int length = currentContext.Length;
				currentContext.Position = length;
				BinaryReader reader = this._reader;
				BsonType type = currentContext.Type;
				this._currentElementType = reader;
				string text = this.ReadString();
				BsonType currentElementType = this._currentElementType;
				this.ReadType(currentElementType);
				bool readRootValueAsArray = this._readRootValueAsArray;
				BsonReader.ContainerContext currentContext2 = this._currentContext;
				int position = currentContext2.Position;
				currentContext2.Position = position;
				BinaryReader reader2 = this._reader;
				BinaryReader reader3 = this._reader;
				this.PopContext();
				BsonReader.ContainerContext currentContext3 = this._currentContext;
				if (currentContext3 != null)
				{
					int position2 = currentContext3.Position;
					currentContext3.Position = position;
				}
			}
			return "Read past end of current container context." != null;
		}

		// Token: 0x06000B50 RID: 2896 RVA: 0x0001B540 File Offset: 0x00019740
		private void PopContext()
		{
			int size = this._stack._size;
			List<BsonReader.ContainerContext> stack = this._stack;
			if (stack._size != 0)
			{
				this._currentContext = stack;
				return;
			}
		}

		// Token: 0x06000B51 RID: 2897 RVA: 0x0000212A File Offset: 0x0000032A
		private void PushContext(BsonReader.ContainerContext newContext)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x0001B570 File Offset: 0x00019770
		private byte ReadByte()
		{
			/*
An exception occurred when decompiling this method (06000B52)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte Newtonsoft.Json.Bson.BsonReader::ReadByte()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:ContainerContext(var_0_06, ldfld:ContainerContext(BsonReader::_currentContext, ldloc:BsonReader(this)))
	stloc:int32(var_1_0D, ldfld:int32(ContainerContext::Position, ldloc:ContainerContext(var_0_06)))
	stfld:int32(ContainerContext::Position, ldloc:ContainerContext(var_0_06), ldloc:int32(var_1_0D))
	stloc:BinaryReader(var_2_1B, ldfld:BinaryReader(BsonReader::_reader, ldloc:BsonReader(this)))
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

		// Token: 0x06000B53 RID: 2899 RVA: 0x0001B598 File Offset: 0x00019798
		private void ReadType(BsonType type)
		{
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x0001B718 File Offset: 0x00019918
		private byte[] ReadBinary([Out] BsonBinaryType binaryType)
		{
			/*
An exception occurred when decompiling this method (06000B54)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte[] Newtonsoft.Json.Bson.BsonReader::ReadBinary(Newtonsoft.Json.Bson.BsonBinaryType)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_006D:
	stloc:ContainerContext(var_9_73, ldfld:ContainerContext(BsonReader::_currentContext, ldloc:BsonReader(this)))
	stloc:int32(var_10_7C, ldfld:int32(ContainerContext::Position, ldloc:ContainerContext(var_9_73)))
	stfld:int32(ContainerContext::Position, ldloc:ContainerContext(var_9_73), ldloc:int32(var_10_7C))
	stloc:BinaryReader(var_11_8D, ldfld:BinaryReader(BsonReader::_reader, ldloc:BsonReader(this)))
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

		// Token: 0x06000B55 RID: 2901 RVA: 0x0001B7B4 File Offset: 0x000199B4
		private string ReadString()
		{
			this.EnsureBuffers();
			long num = 0L;
			BinaryReader reader = this._reader;
			byte[] byteBuffer = this._byteBuffer;
			if (num != 0L)
			{
				long num2 = 0L;
				Encoding utf = Encoding.UTF8;
				byte[] byteBuffer2 = this._byteBuffer;
				char[] charBuffer = this._charBuffer;
				if (num2 != 0L)
				{
				}
				char[] charBuffer2 = this._charBuffer;
				byte[] byteBuffer3 = this._byteBuffer;
				BsonReader.ContainerContext currentContext = this._currentContext;
				int position = currentContext.Position;
				currentContext.Position = position;
			}
			Encoding utf2 = Encoding.UTF8;
			byte[] byteBuffer4 = this._byteBuffer;
			char[] charBuffer3 = this._charBuffer;
			BsonReader.ContainerContext currentContext2 = this._currentContext;
			int position2 = currentContext2.Position;
			currentContext2.Position = position2;
			char[] charBuffer4 = this._charBuffer;
			string text;
			return text;
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x0001B870 File Offset: 0x00019A70
		private string ReadLengthString()
		{
			BsonReader.ContainerContext currentContext = this._currentContext;
			int position = currentContext.Position;
			currentContext.Position = position;
			BinaryReader reader = this._reader;
			BsonReader.ContainerContext currentContext2 = this._currentContext;
			int position2 = currentContext2.Position;
			currentContext2.Position = position2;
			BinaryReader reader2 = this._reader;
			string text;
			return text;
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x0001B8BC File Offset: 0x00019ABC
		private string GetString(int length)
		{
			while (length != 0)
			{
				this.EnsureBuffers();
				long num = 0L;
				long num2 = 0L;
				BinaryReader reader = this._reader;
				byte[] byteBuffer = this._byteBuffer;
				if (reader != null)
				{
					int lastFullCharStop = this.GetLastFullCharStop((int)num);
					if (num2 == 0L)
					{
					}
					Encoding utf = Encoding.UTF8;
					byte[] byteBuffer2 = this._byteBuffer;
					char[] charBuffer = this._charBuffer;
					char[] charBuffer2 = this._charBuffer;
					byte[] byteBuffer3 = this._byteBuffer;
					break;
				}
			}
			Encoding utf2 = Encoding.UTF8;
			byte[] byteBuffer4 = this._byteBuffer;
			char[] charBuffer3 = this._charBuffer;
			char[] charBuffer4 = this._charBuffer;
			string text;
			return text;
		}

		// Token: 0x06000B58 RID: 2904 RVA: 0x0001B948 File Offset: 0x00019B48
		private int GetLastFullCharStop(int start)
		{
			while (this.BytesInSequence((byte)start) != 0)
			{
			}
		}

		// Token: 0x06000B59 RID: 2905 RVA: 0x0001B964 File Offset: 0x00019B64
		private int BytesInSequence(byte b)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06000B5A RID: 2906 RVA: 0x0001B990 File Offset: 0x00019B90
		private void EnsureBuffers()
		{
			if (this._byteBuffer == null)
			{
			}
			if (this._charBuffer == null)
			{
				Encoding utf = Encoding.UTF8;
			}
		}

		// Token: 0x06000B5B RID: 2907 RVA: 0x0001B9B8 File Offset: 0x00019BB8
		private double ReadDouble()
		{
			/*
An exception occurred when decompiling this method (06000B5B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Double Newtonsoft.Json.Bson.BsonReader::ReadDouble()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:ContainerContext(var_0_06, ldfld:ContainerContext(BsonReader::_currentContext, ldloc:BsonReader(this)))
	stloc:int32(var_1_0D, ldfld:int32(ContainerContext::Position, ldloc:ContainerContext(var_0_06)))
	stfld:int32(ContainerContext::Position, ldloc:ContainerContext(var_0_06), ldloc:int32(var_1_0D))
	stloc:BinaryReader(var_2_1B, ldfld:BinaryReader(BsonReader::_reader, ldloc:BsonReader(this)))
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

		// Token: 0x06000B5C RID: 2908 RVA: 0x0001B9E0 File Offset: 0x00019BE0
		private int ReadInt32()
		{
			/*
An exception occurred when decompiling this method (06000B5C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Newtonsoft.Json.Bson.BsonReader::ReadInt32()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:ContainerContext(var_0_06, ldfld:ContainerContext(BsonReader::_currentContext, ldloc:BsonReader(this)))
	stloc:int32(var_1_0D, ldfld:int32(ContainerContext::Position, ldloc:ContainerContext(var_0_06)))
	stfld:int32(ContainerContext::Position, ldloc:ContainerContext(var_0_06), ldloc:int32(var_1_0D))
	stloc:BinaryReader(var_2_1B, ldfld:BinaryReader(BsonReader::_reader, ldloc:BsonReader(this)))
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

		// Token: 0x06000B5D RID: 2909 RVA: 0x0001BA08 File Offset: 0x00019C08
		private long ReadInt64()
		{
			/*
An exception occurred when decompiling this method (06000B5D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int64 Newtonsoft.Json.Bson.BsonReader::ReadInt64()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:ContainerContext(var_0_06, ldfld:ContainerContext(BsonReader::_currentContext, ldloc:BsonReader(this)))
	stloc:int32(var_1_0D, ldfld:int32(ContainerContext::Position, ldloc:ContainerContext(var_0_06)))
	stfld:int32(ContainerContext::Position, ldloc:ContainerContext(var_0_06), ldloc:int32(var_1_0D))
	stloc:BinaryReader(var_2_1B, ldfld:BinaryReader(BsonReader::_reader, ldloc:BsonReader(this)))
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

		// Token: 0x06000B5E RID: 2910 RVA: 0x0001BA30 File Offset: 0x00019C30
		private BsonType ReadType()
		{
			/*
An exception occurred when decompiling this method (06000B5E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Newtonsoft.Json.Bson.BsonType Newtonsoft.Json.Bson.BsonReader::ReadType()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:ContainerContext(var_0_06, ldfld:ContainerContext(BsonReader::_currentContext, ldloc:BsonReader(this)))
	stloc:int32(var_1_0D, ldfld:int32(ContainerContext::Position, ldloc:ContainerContext(var_0_06)))
	stfld:int32(ContainerContext::Position, ldloc:ContainerContext(var_0_06), ldloc:int32(var_1_0D))
	stloc:BinaryReader(var_2_1B, ldfld:BinaryReader(BsonReader::_reader, ldloc:BsonReader(this)))
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

		// Token: 0x06000B5F RID: 2911 RVA: 0x0001BA58 File Offset: 0x00019C58
		private void MovePosition(int count)
		{
			BsonReader.ContainerContext currentContext = this._currentContext;
			int position = currentContext.Position;
			currentContext.Position = position;
		}

		// Token: 0x06000B60 RID: 2912 RVA: 0x0001BA7C File Offset: 0x00019C7C
		private byte[] ReadBytes(int count)
		{
			/*
An exception occurred when decompiling this method (06000B60)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte[] Newtonsoft.Json.Bson.BsonReader::ReadBytes(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:ContainerContext(var_0_06, ldfld:ContainerContext(BsonReader::_currentContext, ldloc:BsonReader(this)))
	stloc:int32(var_1_0D, ldfld:int32(ContainerContext::Position, ldloc:ContainerContext(var_0_06)))
	stfld:int32(ContainerContext::Position, ldloc:ContainerContext(var_0_06), ldloc:int32(var_1_0D))
	stloc:BinaryReader(var_2_1B, ldfld:BinaryReader(BsonReader::_reader, ldloc:BsonReader(this)))
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

		// Token: 0x06000B61 RID: 2913 RVA: 0x0001BAA4 File Offset: 0x00019CA4
		// Note: this type is marked as 'beforefieldinit'.
		static BsonReader()
		{
		}

		// Token: 0x04000430 RID: 1072
		private const int MaxCharBytesSize = 128;

		// Token: 0x04000431 RID: 1073
		private static readonly byte[] SeqRange1;

		// Token: 0x04000432 RID: 1074
		private static readonly byte[] SeqRange2;

		// Token: 0x04000433 RID: 1075
		private static readonly byte[] SeqRange3;

		// Token: 0x04000434 RID: 1076
		private static readonly byte[] SeqRange4;

		// Token: 0x04000435 RID: 1077
		private readonly BinaryReader _reader;

		// Token: 0x04000436 RID: 1078
		private readonly List<BsonReader.ContainerContext> _stack;

		// Token: 0x04000437 RID: 1079
		private byte[] _byteBuffer;

		// Token: 0x04000438 RID: 1080
		private char[] _charBuffer;

		// Token: 0x04000439 RID: 1081
		private BsonType _currentElementType;

		// Token: 0x0400043A RID: 1082
		private BsonReader.BsonReaderState _bsonReaderState;

		// Token: 0x0400043B RID: 1083
		private BsonReader.ContainerContext _currentContext;

		// Token: 0x0400043C RID: 1084
		private bool _readRootValueAsArray;

		// Token: 0x0400043D RID: 1085
		private bool _jsonNet35BinaryCompatibility;

		// Token: 0x0400043E RID: 1086
		private DateTimeKind _dateTimeKindHandling;

		// Token: 0x02000121 RID: 289
		private enum BsonReaderState
		{
			// Token: 0x04000440 RID: 1088
			Normal,
			// Token: 0x04000441 RID: 1089
			ReferenceStart,
			// Token: 0x04000442 RID: 1090
			ReferenceRef,
			// Token: 0x04000443 RID: 1091
			ReferenceId,
			// Token: 0x04000444 RID: 1092
			CodeWScopeStart,
			// Token: 0x04000445 RID: 1093
			CodeWScopeCode,
			// Token: 0x04000446 RID: 1094
			CodeWScopeScope,
			// Token: 0x04000447 RID: 1095
			CodeWScopeScopeObject,
			// Token: 0x04000448 RID: 1096
			CodeWScopeScopeEnd
		}

		// Token: 0x02000122 RID: 290
		private class ContainerContext
		{
			// Token: 0x06000B62 RID: 2914 RVA: 0x0001BAB4 File Offset: 0x00019CB4
			public ContainerContext(BsonType type)
			{
			}

			// Token: 0x04000449 RID: 1097
			public readonly BsonType Type;

			// Token: 0x0400044A RID: 1098
			public int Length;

			// Token: 0x0400044B RID: 1099
			public int Position;
		}
	}
}
