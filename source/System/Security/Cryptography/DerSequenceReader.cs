using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace System.Security.Cryptography
{
	// Token: 0x020000ED RID: 237
	internal class DerSequenceReader
	{
		// Token: 0x17000106 RID: 262
		// (set) Token: 0x0600054D RID: 1357 RVA: 0x00015150 File Offset: 0x00013350
		private int ContentLength
		{
			[CompilerGenerated]
			set
			{
				this.<ContentLength>k__BackingField = value;
			}
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x00015164 File Offset: 0x00013364
		internal DerSequenceReader(byte[] data)
		{
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x00015174 File Offset: 0x00013374
		internal DerSequenceReader(byte[] data, int offset, int length)
		{
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x00015184 File Offset: 0x00013384
		private DerSequenceReader(DerSequenceReader.DerTag tagToEat, byte[] data, int offset, int length)
		{
			this._data = data;
			this.ContentLength = offset;
			this.EatTag(tagToEat);
			byte[] data2 = this._data;
			int end = this._end;
			int num = this.<ContentLength>k__BackingField;
			int num2 = DerSequenceReader.ScanContentLength(data2, num, end, offset);
			int position = this._position;
			this.ContentLength = num2;
			this.ContentLength = position;
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000551 RID: 1361 RVA: 0x000151E4 File Offset: 0x000133E4
		internal bool HasData
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000551)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Security.Cryptography.DerSequenceReader::get_HasData()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(DerSequenceReader::_end, ldloc:DerSequenceReader(this)))
	stloc:int32(var_1_0D, ldfld:int32(DerSequenceReader::<ContentLength>k__BackingField, ldloc:DerSequenceReader(this)))
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

		// Token: 0x06000552 RID: 1362 RVA: 0x00015200 File Offset: 0x00013400
		internal byte PeekTag()
		{
			/*
An exception occurred when decompiling this method (06000552)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte System.Security.Cryptography.DerSequenceReader::PeekTag()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(DerSequenceReader::_end, ldloc:DerSequenceReader(this)))
	stloc:int32(var_1_0D, ldfld:int32(DerSequenceReader::<ContentLength>k__BackingField, ldloc:DerSequenceReader(this)))
	stloc:uint8[](var_2_14, ldfld:uint8[](DerSequenceReader::_data, ldloc:DerSequenceReader(this)))
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

		// Token: 0x06000553 RID: 1363 RVA: 0x00015224 File Offset: 0x00013424
		internal void SkipValue()
		{
			byte b = this.PeekTag();
			byte[] data = this._data;
			int end = this._end;
			int num = this.<ContentLength>k__BackingField;
			int position = this._position;
			this._position = position;
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x00015260 File Offset: 0x00013460
		internal byte[] ReadNextEncodedValue()
		{
			/*
An exception occurred when decompiling this method (06000554)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte[] System.Security.Cryptography.DerSequenceReader::ReadNextEncodedValue()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint8(var_0_06, call:uint8(DerSequenceReader::PeekTag, ldloc:DerSequenceReader(this)))
	stloc:int32(var_1_0D, ldfld:int32(DerSequenceReader::_end, ldloc:DerSequenceReader(this)))
	stloc:int32(var_2_14, ldfld:int32(DerSequenceReader::<ContentLength>k__BackingField, ldloc:DerSequenceReader(this)))
	stloc:uint8[](var_3_1B, ldfld:uint8[](DerSequenceReader::_data, ldloc:DerSequenceReader(this)))
	stloc:uint8[](var_5_22, ldfld:uint8[](DerSequenceReader::_data, ldloc:DerSequenceReader(this)))
	stloc:int32(var_6_2A, ldfld:int32(DerSequenceReader::_position, ldloc:DerSequenceReader(this)))
	stloc:int32(var_7_32, ldfld:int32(DerSequenceReader::_position, ldloc:DerSequenceReader(this)))
	stfld:int32(DerSequenceReader::_position, ldloc:DerSequenceReader(this), ldloc:int32(var_7_32))
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

		// Token: 0x06000555 RID: 1365 RVA: 0x000152A8 File Offset: 0x000134A8
		internal bool ReadBoolean()
		{
			/*
An exception occurred when decompiling this method (06000555)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Security.Cryptography.DerSequenceReader::ReadBoolean()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint8[](var_0_06, ldfld:uint8[](DerSequenceReader::_data, ldloc:DerSequenceReader(this)))
	stloc:int32(var_1_0D, ldfld:int32(DerSequenceReader::_end, ldloc:DerSequenceReader(this)))
	stloc:int32(var_2_14, ldfld:int32(DerSequenceReader::<ContentLength>k__BackingField, ldloc:DerSequenceReader(this)))
	stloc:int32(var_4_1B, ldfld:int32(DerSequenceReader::_position, ldloc:DerSequenceReader(this)))
	stfld:int32(DerSequenceReader::_position, ldloc:DerSequenceReader(this), ldloc:int32(var_4_1B))
	stloc:uint8[](var_5_2B, ldfld:uint8[](DerSequenceReader::_data, ldloc:DerSequenceReader(this)))
	stfld:int32(DerSequenceReader::_position, ldloc:DerSequenceReader(this), ldloc:int32(var_4_1B))
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

		// Token: 0x06000556 RID: 1366 RVA: 0x000152EC File Offset: 0x000134EC
		internal int ReadInteger()
		{
			this.EatTag(DerSequenceReader.DerTag.Integer);
			byte[] array = this.ReadContentAsBytes();
			if (!true)
			{
			}
			int num;
			return num;
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x0001530C File Offset: 0x0001350C
		internal byte[] ReadIntegerBytes()
		{
			this.EatTag(DerSequenceReader.DerTag.Integer);
			return this.ReadContentAsBytes();
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x00015328 File Offset: 0x00013528
		internal byte[] ReadBitString()
		{
			/*
An exception occurred when decompiling this method (06000558)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte[] System.Security.Cryptography.DerSequenceReader::ReadBitString()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint8[](var_0_06, ldfld:uint8[](DerSequenceReader::_data, ldloc:DerSequenceReader(this)))
	stloc:int32(var_1_0D, ldfld:int32(DerSequenceReader::_end, ldloc:DerSequenceReader(this)))
	stloc:int32(var_2_14, ldfld:int32(DerSequenceReader::<ContentLength>k__BackingField, ldloc:DerSequenceReader(this)))
	stloc:int32(var_4_1B, ldfld:int32(DerSequenceReader::_position, ldloc:DerSequenceReader(this)))
	stfld:int32(DerSequenceReader::_position, ldloc:DerSequenceReader(this), ldloc:int32(var_4_1B))
	stloc:uint8[](var_5_2B, ldfld:uint8[](DerSequenceReader::_data, ldloc:DerSequenceReader(this)))
	stfld:int32(DerSequenceReader::_position, ldloc:DerSequenceReader(this), ldloc:int32(var_4_1B))
	stloc:uint8[](var_6_3B, ldfld:uint8[](DerSequenceReader::_data, ldloc:DerSequenceReader(this)))
	stloc:int32(var_7_43, ldfld:int32(DerSequenceReader::_position, ldloc:DerSequenceReader(this)))
	stloc:int32(var_8_4B, ldfld:int32(DerSequenceReader::_position, ldloc:DerSequenceReader(this)))
	stfld:int32(DerSequenceReader::_position, ldloc:DerSequenceReader(this), ldloc:int32(var_8_4B))
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

		// Token: 0x06000559 RID: 1369 RVA: 0x0001538C File Offset: 0x0001358C
		internal byte[] ReadOctetString()
		{
			this.EatTag(DerSequenceReader.DerTag.OctetString);
			return this.ReadContentAsBytes();
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x000153A8 File Offset: 0x000135A8
		internal string ReadOidAsString()
		{
			/*
An exception occurred when decompiling this method (0600055A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Security.Cryptography.DerSequenceReader::ReadOidAsString()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0056:
	stloc:BigInteger(var_21_5C, call:BigInteger(BigInteger::op_Implicit, ldc.i4:int32(0)))
	stloc:int32(var_22_64, ldfld:int32(DerSequenceReader::_position, ldloc:DerSequenceReader(this)))
	stfld:int32(DerSequenceReader::_position, ldloc:DerSequenceReader(this), ldloc:int32(var_22_64))
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

		// Token: 0x0600055B RID: 1371 RVA: 0x00015424 File Offset: 0x00013624
		internal string ReadUtf8String()
		{
			byte[] data = this._data;
			int end = this._end;
			int num = this.<ContentLength>k__BackingField;
			int position = this._position;
			this._position = position;
			Encoding utf = Encoding.UTF8;
			byte[] data2 = this._data;
			int position2 = this._position;
			int position3 = this._position;
			this._position = position3;
			string text;
			return text;
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x00015484 File Offset: 0x00013684
		private DerSequenceReader ReadCollectionWithTag(DerSequenceReader.DerTag expected)
		{
			byte[] data = this._data;
			int position = this._position;
			DerSequenceReader.CheckTag(expected, data, position);
			int end = this._end;
			int num = this.<ContentLength>k__BackingField;
			byte[] data2 = this._data;
			byte[] data3 = this._data;
			int position2 = this._position;
			int position3 = this._position;
			this._position = position3;
			return 0;
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x000154E0 File Offset: 0x000136E0
		internal DerSequenceReader ReadSequence()
		{
			return this.ReadCollectionWithTag(DerSequenceReader.DerTag.Sequence);
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x000154F8 File Offset: 0x000136F8
		internal DerSequenceReader ReadSet()
		{
			return this.ReadCollectionWithTag(DerSequenceReader.DerTag.Set);
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x00015510 File Offset: 0x00013710
		internal string ReadPrintableString()
		{
			byte[] data = this._data;
			int end = this._end;
			int num = this.<ContentLength>k__BackingField;
			int position = this._position;
			this._position = position;
			Encoding ascii = Encoding.ASCII;
			byte[] data2 = this._data;
			int position2 = this._position;
			int position3 = this._position;
			this._position = position3;
			string text;
			return text;
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x00015570 File Offset: 0x00013770
		internal string ReadIA5String()
		{
			byte[] data = this._data;
			int end = this._end;
			int num = this.<ContentLength>k__BackingField;
			int position = this._position;
			this._position = position;
			Encoding ascii = Encoding.ASCII;
			byte[] data2 = this._data;
			int position2 = this._position;
			int position3 = this._position;
			this._position = position3;
			string text;
			return text;
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x000155D0 File Offset: 0x000137D0
		internal string ReadT61String()
		{
			byte[] data = this._data;
			int end = this._end;
			int num = this.<ContentLength>k__BackingField;
			int position = this._position;
			this._position = position;
			byte[] data2 = this._data;
			int position2 = this._position;
			int position3 = this._position;
			this._position = position3;
			string text;
			return text;
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x00015638 File Offset: 0x00013838
		internal DateTime ReadX509Date()
		{
			byte b = this.PeekTag();
			DateTime dateTime = this.ReadUtcTime();
			DateTime dateTime2;
			return dateTime2;
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x00015660 File Offset: 0x00013860
		internal DateTime ReadUtcTime()
		{
			DateTime dateTime = this.ReadTime(DerSequenceReader.DerTag.UTCTime, "yyMMddHHmmss'Z'");
			return 1;
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x0001567C File Offset: 0x0001387C
		internal DateTime ReadGeneralizedTime()
		{
			DateTime dateTime = this.ReadTime(DerSequenceReader.DerTag.GeneralizedTime, "yyyyMMddHHmmss'Z'");
			return 1;
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x00015698 File Offset: 0x00013898
		internal string ReadBMPString()
		{
			byte[] data = this._data;
			int end = this._end;
			int num = this.<ContentLength>k__BackingField;
			int position = this._position;
			this._position = position;
			Encoding bigEndianUnicode = Encoding.BigEndianUnicode;
			byte[] data2 = this._data;
			int position2 = this._position;
			int position3 = this._position;
			this._position = position3;
			string text;
			return text;
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x000156F8 File Offset: 0x000138F8
		private static string TrimTrailingNulls(string value)
		{
			string text;
			return text;
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x0001570C File Offset: 0x0001390C
		private DateTime ReadTime(DerSequenceReader.DerTag timeTag, string formatString)
		{
			/*
An exception occurred when decompiling this method (06000567)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.DateTime System.Security.Cryptography.DerSequenceReader::ReadTime(System.Security.Cryptography.DerSequenceReader/DerTag,System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(DerSequenceReader::EatTag, ldloc:DerSequenceReader(this), ldloc:DerTag(timeTag))
	stloc:uint8[](var_0_0D, ldfld:uint8[](DerSequenceReader::_data, ldloc:DerSequenceReader(this)))
	stloc:int32(var_1_14, ldfld:int32(DerSequenceReader::_end, ldloc:DerSequenceReader(this)))
	stloc:int32(var_2_1B, ldfld:int32(DerSequenceReader::<ContentLength>k__BackingField, ldloc:DerSequenceReader(this)))
	stloc:int32(var_4_22, ldfld:int32(DerSequenceReader::_position, ldloc:DerSequenceReader(this)))
	stfld:int32(DerSequenceReader::_position, ldloc:DerSequenceReader(this), ldloc:int32(var_4_22))
	stloc:Encoding(var_6_34, callgetter:Encoding(Encoding::get_ASCII))
	stloc:uint8[](var_7_3C, ldfld:uint8[](DerSequenceReader::_data, ldloc:DerSequenceReader(this)))
	stloc:int32(var_8_44, ldfld:int32(DerSequenceReader::_position, ldloc:DerSequenceReader(this)))
	stloc:int32(var_9_4C, ldfld:int32(DerSequenceReader::_position, ldloc:DerSequenceReader(this)))
	stfld:int32(DerSequenceReader::_position, ldloc:DerSequenceReader(this), ldloc:int32(var_9_4C))
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

		// Token: 0x06000568 RID: 1384 RVA: 0x00015770 File Offset: 0x00013970
		private byte[] ReadContentAsBytes()
		{
			/*
An exception occurred when decompiling this method (06000568)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte[] System.Security.Cryptography.DerSequenceReader::ReadContentAsBytes()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint8[](var_0_06, ldfld:uint8[](DerSequenceReader::_data, ldloc:DerSequenceReader(this)))
	stloc:int32(var_1_0D, ldfld:int32(DerSequenceReader::_end, ldloc:DerSequenceReader(this)))
	stloc:int32(var_2_14, ldfld:int32(DerSequenceReader::<ContentLength>k__BackingField, ldloc:DerSequenceReader(this)))
	stloc:int32(var_4_1B, ldfld:int32(DerSequenceReader::_position, ldloc:DerSequenceReader(this)))
	stfld:int32(DerSequenceReader::_position, ldloc:DerSequenceReader(this), ldloc:int32(var_4_1B))
	stloc:uint8[](var_5_2B, ldfld:uint8[](DerSequenceReader::_data, ldloc:DerSequenceReader(this)))
	stloc:int32(var_6_33, ldfld:int32(DerSequenceReader::_position, ldloc:DerSequenceReader(this)))
	stloc:int32(var_7_3B, ldfld:int32(DerSequenceReader::_position, ldloc:DerSequenceReader(this)))
	stfld:int32(DerSequenceReader::_position, ldloc:DerSequenceReader(this), ldloc:int32(var_7_3B))
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

		// Token: 0x06000569 RID: 1385 RVA: 0x000157C4 File Offset: 0x000139C4
		private void EatTag(DerSequenceReader.DerTag expected)
		{
			int end = this._end;
			int num = this.<ContentLength>k__BackingField;
			byte[] data = this._data;
			DerSequenceReader.CheckTag(expected, data, num);
			int position = this._position;
			this._position = position;
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x000157FC File Offset: 0x000139FC
		private static void CheckTag(DerSequenceReader.DerTag expected, byte[] data, int position)
		{
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x0001580C File Offset: 0x00013A0C
		private int EatLength()
		{
			byte[] data = this._data;
			int end = this._end;
			int num = this.<ContentLength>k__BackingField;
			int position = this._position;
			this._position = position;
			int num2;
			return num2;
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x00015840 File Offset: 0x00013A40
		private static int ScanContentLength(byte[] data, int offset, int end, [Out] int bytesConsumed)
		{
			/*
An exception occurred when decompiling this method (0600056C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Security.Cryptography.DerSequenceReader::ScanContentLength(System.Byte[],System.Int32,System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_01, ldc.i4:int32(1))
	stfld:int32(int32::m_value, ldloc:int32[exp:int32&](end), ldloc:int32(var_0_01))
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

		// Token: 0x0400043E RID: 1086
		internal static DateTimeFormatInfo s_validityDateTimeFormatInfo;

		// Token: 0x0400043F RID: 1087
		private static Encoding s_utf8EncodingWithExceptionFallback;

		// Token: 0x04000440 RID: 1088
		private static Encoding s_latin1Encoding;

		// Token: 0x04000441 RID: 1089
		private readonly byte[] _data;

		// Token: 0x04000442 RID: 1090
		private readonly int _end;

		// Token: 0x04000443 RID: 1091
		private int _position;

		// Token: 0x04000444 RID: 1092
		[CompilerGenerated]
		private int <ContentLength>k__BackingField;

		// Token: 0x020000EE RID: 238
		internal enum DerTag : byte
		{
			// Token: 0x04000446 RID: 1094
			Boolean = 1,
			// Token: 0x04000447 RID: 1095
			Integer,
			// Token: 0x04000448 RID: 1096
			BitString,
			// Token: 0x04000449 RID: 1097
			OctetString,
			// Token: 0x0400044A RID: 1098
			Null,
			// Token: 0x0400044B RID: 1099
			ObjectIdentifier,
			// Token: 0x0400044C RID: 1100
			UTF8String = 12,
			// Token: 0x0400044D RID: 1101
			Sequence = 16,
			// Token: 0x0400044E RID: 1102
			Set,
			// Token: 0x0400044F RID: 1103
			PrintableString = 19,
			// Token: 0x04000450 RID: 1104
			T61String,
			// Token: 0x04000451 RID: 1105
			IA5String = 22,
			// Token: 0x04000452 RID: 1106
			UTCTime,
			// Token: 0x04000453 RID: 1107
			GeneralizedTime,
			// Token: 0x04000454 RID: 1108
			BMPString = 30
		}

		// Token: 0x020000EF RID: 239
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600056D RID: 1389 RVA: 0x0001585C File Offset: 0x00013A5C
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x0600056E RID: 1390 RVA: 0x0001586C File Offset: 0x00013A6C
			public <>c()
			{
			}

			// Token: 0x0600056F RID: 1391 RVA: 0x00015880 File Offset: 0x00013A80
			internal Encoding <ReadT61String>b__45_0()
			{
			}

			// Token: 0x06000570 RID: 1392 RVA: 0x00015890 File Offset: 0x00013A90
			internal Encoding <ReadT61String>b__45_1()
			{
				return Encoding.GetEncoding("iso-8859-1");
			}

			// Token: 0x06000571 RID: 1393 RVA: 0x000158A8 File Offset: 0x00013AA8
			internal DateTimeFormatInfo <ReadTime>b__51_0()
			{
				if (!true)
				{
				}
				CultureInfo invariantCulture = CultureInfo.InvariantCulture;
				object obj;
				if (obj != null)
				{
				}
				throw new InvalidCastException();
			}

			// Token: 0x04000455 RID: 1109
			public static readonly DerSequenceReader.<>c <>9;

			// Token: 0x04000456 RID: 1110
			public static Func<Encoding> <>9__45_0;

			// Token: 0x04000457 RID: 1111
			public static Func<Encoding> <>9__45_1;

			// Token: 0x04000458 RID: 1112
			public static Func<DateTimeFormatInfo> <>9__51_0;
		}
	}
}
