using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Cpp2IlInjected;

namespace System.Text
{
	// Token: 0x02000278 RID: 632
	[Serializable]
	[StructLayout(0)]
	public sealed class StringBuilder : ISerializable
	{
		// Token: 0x06001544 RID: 5444 RVA: 0x0002C4E8 File Offset: 0x0002A6E8
		public StringBuilder()
		{
			this.m_MaxCapacity = 1;
		}

		// Token: 0x06001545 RID: 5445 RVA: 0x0002C504 File Offset: 0x0002A704
		public StringBuilder(int capacity)
		{
		}

		// Token: 0x06001546 RID: 5446 RVA: 0x0002C514 File Offset: 0x0002A714
		public StringBuilder(string value)
		{
			if (value != null)
			{
				int stringLength = value._stringLength;
				return;
			}
		}

		// Token: 0x06001547 RID: 5447 RVA: 0x0002C530 File Offset: 0x0002A730
		public StringBuilder(string value, int capacity)
		{
			if (value != null)
			{
				int stringLength = value._stringLength;
				return;
			}
		}

		// Token: 0x06001548 RID: 5448 RVA: 0x0002C54C File Offset: 0x0002A74C
		public StringBuilder(string value, int startIndex, int length, int capacity)
		{
			if (value == null)
			{
			}
			int num = Math.Max(capacity, length);
			this.m_ChunkLength = length;
			int offsetToStringData = RuntimeHelpers.OffsetToStringData;
			char[] chunkChars = this.m_ChunkChars;
		}

		// Token: 0x06001549 RID: 5449 RVA: 0x0002C598 File Offset: 0x0002A798
		public StringBuilder(int capacity, int maxCapacity)
		{
			if (capacity == 0)
			{
				if (!true)
				{
				}
				int num = Math.Min(16, maxCapacity);
			}
			this.m_MaxCapacity = maxCapacity;
		}

		// Token: 0x0600154A RID: 5450 RVA: 0x0002C5D4 File Offset: 0x0002A7D4
		private StringBuilder(SerializationInfo info, StreamingContext context)
		{
			if (info != null)
			{
				SerializationInfoEnumerator enumerator = info.GetEnumerator();
				bool flag = enumerator.MoveNext();
				string name = enumerator.Name;
				bool flag2 = name == "m_MaxCapacity";
				bool flag3 = name == "m_StringValue";
				bool flag4 = name == "Capacity";
				int @int = info.GetInt32("Capacity");
				return;
			}
		}

		// Token: 0x0600154B RID: 5451 RVA: 0x0002C66C File Offset: 0x0002A86C
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			while (info == null)
			{
			}
			int maxCapacity = this.m_MaxCapacity;
			info.AddValue("m_MaxCapacity", maxCapacity);
			char[] chunkChars = this.m_ChunkChars;
			int chunkOffset = this.m_ChunkOffset;
			info.AddValue("Capacity", maxCapacity);
			info.AddValue("m_StringValue", this);
			long num = 0L;
			info.AddValue("m_currentThread", (int)num);
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x0600154C RID: 5452 RVA: 0x0002C6C4 File Offset: 0x0002A8C4
		// (set) Token: 0x0600154D RID: 5453 RVA: 0x0002C6E0 File Offset: 0x0002A8E0
		public int Capacity
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600154C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Text.StringBuilder::get_Capacity()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:char[](var_0_06, ldfld:char[](StringBuilder::m_ChunkChars, ldloc:StringBuilder(this)))
	stloc:int32(var_1_0D, ldfld:int32(StringBuilder::m_ChunkOffset, ldloc:StringBuilder(this)))
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
				int maxCapacity = this.m_MaxCapacity;
				int chunkLength = this.m_ChunkLength;
				int maxCapacity2 = this.m_MaxCapacity;
				char[] chunkChars = this.m_ChunkChars;
				char[] chunkChars2 = this.m_ChunkChars;
				int chunkLength2 = this.m_ChunkLength;
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x0600154E RID: 5454 RVA: 0x0002C71C File Offset: 0x0002A91C
		public int MaxCapacity
		{
			get
			{
				return this.m_MaxCapacity;
			}
		}

		// Token: 0x0600154F RID: 5455 RVA: 0x0002C730 File Offset: 0x0002A930
		public int EnsureCapacity(int capacity)
		{
			/*
An exception occurred when decompiling this method (0600154F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Text.StringBuilder::EnsureCapacity(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:char[](var_0_06, ldfld:char[](StringBuilder::m_ChunkChars, ldloc:StringBuilder(this)))
	stloc:int32(var_1_0D, ldfld:int32(StringBuilder::m_ChunkOffset, ldloc:StringBuilder(this)))
	callsetter:int32(StringBuilder::set_Capacity, ldloc:StringBuilder(this), ldloc:int32(capacity))
	stloc:char[](var_2_1B, ldfld:char[](StringBuilder::m_ChunkChars, ldloc:StringBuilder(this)))
	stloc:int32(var_3_22, ldfld:int32(StringBuilder::m_ChunkOffset, ldloc:StringBuilder(this)))
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

		// Token: 0x06001550 RID: 5456 RVA: 0x0002C760 File Offset: 0x0002A960
		public override string ToString()
		{
			/*
An exception occurred when decompiling this method (06001550)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Text.StringBuilder::ToString()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0022:
	stloc:int32(var_4_28, ldfld:int32(StringBuilder::m_ChunkLength, ldloc:StringBuilder(this)))
	stloc:char[](var_5_30, ldfld:char[](StringBuilder::m_ChunkChars, ldloc:StringBuilder(this)))
	brtrue(IL_0000, ldfld:StringBuilder[exp:bool](StringBuilder::m_ChunkPrevious, ldloc:StringBuilder(this)))
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

		// Token: 0x06001551 RID: 5457 RVA: 0x0002C7A8 File Offset: 0x0002A9A8
		public string ToString(int startIndex, int length)
		{
			int chunkLength = this.m_ChunkLength;
			int maxCapacity = this.m_MaxCapacity;
			string text = string.FastAllocateString(length);
			if (text != null)
			{
				int offsetToStringData = RuntimeHelpers.OffsetToStringData;
			}
			return text;
		}

		// Token: 0x06001552 RID: 5458 RVA: 0x0002C7EC File Offset: 0x0002A9EC
		public StringBuilder Clear()
		{
			long num = 0L;
			this.Length = (int)num;
			return this;
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06001553 RID: 5459 RVA: 0x0002C804 File Offset: 0x0002AA04
		// (set) Token: 0x06001554 RID: 5460 RVA: 0x0002C820 File Offset: 0x0002AA20
		public int Length
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001553)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Text.StringBuilder::get_Length()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(StringBuilder::m_ChunkLength, ldloc:StringBuilder(this)))
	stloc:int32(var_1_0D, ldfld:int32(StringBuilder::m_MaxCapacity, ldloc:StringBuilder(this)))
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
				int maxCapacity = this.m_MaxCapacity;
				if (value != 0 || this.m_ChunkPrevious != null)
				{
					int chunkLength = this.m_ChunkLength;
					int maxCapacity2 = this.m_MaxCapacity;
					return;
				}
			}
		}

		// Token: 0x17000225 RID: 549
		[IndexerName("Chars")]
		public char this[int index]
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001555)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Char System.Text.StringBuilder::get_Chars(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	stloc:int32(var_0_06, ldfld:int32(StringBuilder::m_ChunkOffset, ldloc:StringBuilder(this)))
	brtrue(IL_0000, ldfld:StringBuilder[exp:bool](StringBuilder::m_ChunkPrevious, ldloc:StringBuilder(this)))
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
			set
			{
				do
				{
					int chunkOffset = this.m_ChunkOffset;
				}
				while (this.m_ChunkPrevious != null);
			}
		}

		// Token: 0x06001557 RID: 5463 RVA: 0x0002C8D0 File Offset: 0x0002AAD0
		public StringBuilder Append(char value, int repeatCount)
		{
			if (repeatCount != 0)
			{
				int chunkLength = this.m_ChunkLength;
				int maxCapacity = this.m_MaxCapacity;
				int maxCapacity2 = this.m_MaxCapacity;
				char[] chunkChars = this.m_ChunkChars;
				this.m_ChunkLength = chunkLength;
				this.ExpandByABlock(repeatCount);
				char[] chunkChars2 = this.m_ChunkChars;
				long num = 0L;
				this.m_ChunkLength = (int)num;
			}
			return this;
		}

		// Token: 0x06001558 RID: 5464 RVA: 0x0002C924 File Offset: 0x0002AB24
		public StringBuilder Append(char[] value, int startIndex, int charCount)
		{
			StringBuilder stringBuilder;
			if (value != null && charCount != 0)
			{
				stringBuilder = this.Append(value, charCount);
				return stringBuilder;
			}
			return stringBuilder;
		}

		// Token: 0x06001559 RID: 5465 RVA: 0x0002C950 File Offset: 0x0002AB50
		public StringBuilder Append(string value)
		{
			if (value != null)
			{
				char[] chunkChars = this.m_ChunkChars;
				int stringLength = value._stringLength;
				int offsetToStringData = RuntimeHelpers.OffsetToStringData;
				this.AppendHelper(value);
				return this;
			}
			return this;
		}

		// Token: 0x0600155A RID: 5466 RVA: 0x0002C99C File Offset: 0x0002AB9C
		private void AppendHelper(string value)
		{
			if (value != null)
			{
				int offsetToStringData = RuntimeHelpers.OffsetToStringData;
				return;
			}
			int stringLength = value._stringLength;
		}

		// Token: 0x0600155B RID: 5467 RVA: 0x0002C9BC File Offset: 0x0002ABBC
		public StringBuilder Append(string value, int startIndex, int count)
		{
			while (value == null)
			{
				int stringLength;
				if (stringLength == 0)
				{
					return this;
				}
			}
			if (count != 0)
			{
				int stringLength = value._stringLength;
				int offsetToStringData = RuntimeHelpers.OffsetToStringData;
				StringBuilder stringBuilder;
				return stringBuilder;
			}
			return this;
		}

		// Token: 0x0600155C RID: 5468 RVA: 0x0002C9EC File Offset: 0x0002ABEC
		public StringBuilder Append(StringBuilder value)
		{
			StringBuilder stringBuilder;
			if (value != null)
			{
				int chunkLength = value.m_ChunkLength;
				int maxCapacity = value.m_MaxCapacity;
				return stringBuilder;
			}
			return stringBuilder;
		}

		// Token: 0x0600155D RID: 5469 RVA: 0x0002CA10 File Offset: 0x0002AC10
		private StringBuilder AppendCore(StringBuilder value, int startIndex, int count)
		{
			int chunkLength = this.m_ChunkLength;
			int maxCapacity = this.m_MaxCapacity;
			int maxCapacity2 = this.m_MaxCapacity;
			char[] chunkChars = this.m_ChunkChars;
			if (maxCapacity == 0)
			{
			}
			if (Math.Min(0, count) == 0)
			{
				this.ExpandByABlock(count);
				char[] chunkChars2 = this.m_ChunkChars;
				int chunkLength2 = this.m_ChunkLength;
				if (maxCapacity == 0)
				{
				}
				int num = Math.Min(0, count);
			}
			char[] chunkChars3 = this.m_ChunkChars;
			if (chunkChars3 != null)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException();
				while (chunkChars3 != null)
				{
				}
			}
			ThrowHelper.ThrowArgumentOutOfRangeException();
			int chunkLength3 = this.m_ChunkLength;
			this.m_ChunkLength = chunkChars3;
			return value;
		}

		// Token: 0x0600155E RID: 5470 RVA: 0x0002CAB0 File Offset: 0x0002ACB0
		public StringBuilder AppendLine()
		{
			string newLine = Environment.NewLine;
			return this.Append(newLine);
		}

		// Token: 0x0600155F RID: 5471 RVA: 0x0002CACC File Offset: 0x0002ACCC
		public StringBuilder AppendLine(string value)
		{
			StringBuilder stringBuilder = this.Append(value);
			string newLine = Environment.NewLine;
			return this.Append(newLine);
		}

		// Token: 0x06001560 RID: 5472 RVA: 0x0002CAF0 File Offset: 0x0002ACF0
		public void CopyTo(int sourceIndex, Span<char> destination, int count)
		{
			int chunkLength = this.m_ChunkLength;
			int maxCapacity = this.m_MaxCapacity;
			int chunkLength2 = this.m_ChunkLength;
			if (maxCapacity == 0)
			{
			}
			int num = Math.Min(43151360, chunkLength2);
			StringBuilder.ThreadSafeCopy(this.m_ChunkChars, chunkLength2, destination, count, sourceIndex);
			int chunkOffset = this.m_ChunkPrevious.m_ChunkOffset;
		}

		// Token: 0x06001561 RID: 5473 RVA: 0x0002CB40 File Offset: 0x0002AD40
		public StringBuilder Remove(int startIndex, int length)
		{
			int chunkLength = this.m_ChunkLength;
			int maxCapacity = this.m_MaxCapacity;
			if (startIndex == 0)
			{
				long num = 0L;
				this.Length = (int)num;
				return this;
			}
			return this;
		}

		// Token: 0x06001562 RID: 5474 RVA: 0x0002CB78 File Offset: 0x0002AD78
		public StringBuilder Append(char value)
		{
			char[] chunkChars = this.m_ChunkChars;
			return this;
		}

		// Token: 0x06001563 RID: 5475 RVA: 0x0002CB98 File Offset: 0x0002AD98
		public StringBuilder Append(byte value)
		{
			StringBuilder stringBuilder;
			return stringBuilder;
		}

		// Token: 0x06001564 RID: 5476 RVA: 0x0002CBA8 File Offset: 0x0002ADA8
		public StringBuilder Append(int value)
		{
			return this;
		}

		// Token: 0x06001565 RID: 5477 RVA: 0x0002CBB8 File Offset: 0x0002ADB8
		public StringBuilder Append(long value)
		{
			return this;
		}

		// Token: 0x06001566 RID: 5478 RVA: 0x0002CBC8 File Offset: 0x0002ADC8
		public StringBuilder Append(float value)
		{
			return this;
		}

		// Token: 0x06001567 RID: 5479 RVA: 0x0002CBD8 File Offset: 0x0002ADD8
		[CLSCompliant(false)]
		public StringBuilder Append(uint value)
		{
			return this;
		}

		// Token: 0x06001568 RID: 5480 RVA: 0x0002CBE8 File Offset: 0x0002ADE8
		private StringBuilder AppendSpanFormattable<T>(T value) where T : IFormattable
		{
			if (!true)
			{
			}
			CultureInfo currentCulture = CultureInfo.CurrentCulture;
			string text;
			return this.Append(text);
		}

		// Token: 0x06001569 RID: 5481 RVA: 0x0002CC08 File Offset: 0x0002AE08
		public StringBuilder Append(object value)
		{
			if (value != null)
			{
			}
			return this;
		}

		// Token: 0x0600156A RID: 5482 RVA: 0x0002CC1C File Offset: 0x0002AE1C
		public StringBuilder Append(char[] value)
		{
			if (value != null)
			{
			}
			StringBuilder stringBuilder;
			return stringBuilder;
		}

		// Token: 0x0600156B RID: 5483 RVA: 0x0002CC30 File Offset: 0x0002AE30
		public StringBuilder Append(ReadOnlySpan<char> value)
		{
			return this;
		}

		// Token: 0x0600156C RID: 5484 RVA: 0x0002CC40 File Offset: 0x0002AE40
		public StringBuilder Insert(int index, string value)
		{
			int chunkLength = this.m_ChunkLength;
			int maxCapacity = this.m_MaxCapacity;
			if (value != null)
			{
				int offsetToStringData = RuntimeHelpers.OffsetToStringData;
				int stringLength = value._stringLength;
			}
			return this;
		}

		// Token: 0x0600156D RID: 5485 RVA: 0x0002CC70 File Offset: 0x0002AE70
		public StringBuilder Insert(int index, char value)
		{
			this.Insert(index, value, 1);
			return this;
		}

		// Token: 0x0600156E RID: 5486 RVA: 0x0002CC88 File Offset: 0x0002AE88
		public StringBuilder AppendFormat(string format, object arg0)
		{
			StringBuilder stringBuilder;
			return stringBuilder;
		}

		// Token: 0x0600156F RID: 5487 RVA: 0x0002CC98 File Offset: 0x0002AE98
		public StringBuilder AppendFormat(string format, object arg0, object arg1)
		{
			StringBuilder stringBuilder;
			return stringBuilder;
		}

		// Token: 0x06001570 RID: 5488 RVA: 0x0002CCA8 File Offset: 0x0002AEA8
		public StringBuilder AppendFormat(string format, params object[] args)
		{
			while (args == null)
			{
			}
			StringBuilder stringBuilder;
			return stringBuilder;
		}

		// Token: 0x06001571 RID: 5489 RVA: 0x0002CCBC File Offset: 0x0002AEBC
		public StringBuilder AppendFormat(IFormatProvider provider, string format, object arg0)
		{
			StringBuilder stringBuilder;
			return stringBuilder;
		}

		// Token: 0x06001572 RID: 5490 RVA: 0x0000207A File Offset: 0x0000027A
		private static void FormatError()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001573 RID: 5491 RVA: 0x0002CCCC File Offset: 0x0002AECC
		internal StringBuilder AppendFormatHelper(IFormatProvider provider, string format, ParamsArray args)
		{
			while (format == null)
			{
			}
			int stringLength = format._stringLength;
			if (provider != null && provider != null && provider == null)
			{
				throw new InvalidCastException();
			}
			long num = 0L;
			char c = format[(int)num];
			char c2 = format[(int)num];
			char c3 = format[(int)num];
			return this.Append(c);
		}

		// Token: 0x06001574 RID: 5492 RVA: 0x0002CE50 File Offset: 0x0002B050
		public StringBuilder Replace(string oldValue, string newValue)
		{
			int chunkLength = this.m_ChunkLength;
			int maxCapacity = this.m_MaxCapacity;
			StringBuilder stringBuilder;
			return stringBuilder;
		}

		// Token: 0x06001575 RID: 5493 RVA: 0x0002CE6C File Offset: 0x0002B06C
		public StringBuilder Replace(string oldValue, string newValue, int startIndex, int count)
		{
			do
			{
				int chunkLength = this.m_ChunkLength;
				int maxCapacity = this.m_MaxCapacity;
			}
			while (oldValue == null || oldValue._stringLength == 0);
			if (newValue == null)
			{
			}
			StringBuilder chunkPrevious = this.m_ChunkPrevious;
			int chunkOffset = chunkPrevious.m_ChunkOffset;
			if (!this.StartsWith(chunkPrevious, startIndex, count, oldValue) || count == 0)
			{
				int stringLength = oldValue._stringLength;
				if (count == 0)
				{
					goto IL_0055;
				}
			}
			int chunkLength2 = chunkPrevious.m_ChunkLength;
			IL_0055:
			int chunkOffset2 = chunkPrevious.m_ChunkOffset;
			int stringLength2 = oldValue._stringLength;
			int stringLength3 = oldValue._stringLength;
			int chunkOffset3 = this.m_ChunkOffset;
			int chunkOffset4 = this.m_ChunkPrevious.m_ChunkOffset;
			return this;
		}

		// Token: 0x06001576 RID: 5494 RVA: 0x0002CF04 File Offset: 0x0002B104
		[CLSCompliant(false)]
		public unsafe StringBuilder Append(char* value, int valueCount)
		{
			int chunkLength = this.m_ChunkLength;
			int maxCapacity = this.m_MaxCapacity;
			int maxCapacity2 = this.m_MaxCapacity;
			return "The length cannot be greater than the capacity.";
		}

		// Token: 0x06001577 RID: 5495 RVA: 0x0002CF2C File Offset: 0x0002B12C
		private unsafe void Insert(int index, char* value, int valueCount)
		{
			int chunkLength = this.m_ChunkLength;
			int maxCapacity = this.m_MaxCapacity;
		}

		// Token: 0x06001578 RID: 5496 RVA: 0x0002CF48 File Offset: 0x0002B148
		private void ReplaceAllInChunk(int[] replacements, int replacementsCount, StringBuilder sourceChunk, int removeCount, string value)
		{
			if (value != null)
			{
				int offsetToStringData = RuntimeHelpers.OffsetToStringData;
				return;
			}
			int stringLength = value._stringLength;
			int chunkOffset = sourceChunk.m_ChunkOffset;
			int num = 1;
			this.MakeRoom(replacements, replacementsCount, sourceChunk, stringLength, num != 0);
			int stringLength2 = value._stringLength;
			char[] chunkChars = sourceChunk.m_ChunkChars;
		}

		// Token: 0x06001579 RID: 5497 RVA: 0x0002CF9C File Offset: 0x0002B19C
		private bool StartsWith(StringBuilder chunk, int indexInChunk, int count, string value)
		{
			int stringLength = value._stringLength;
			long num = 0L;
			if (count != 0)
			{
				int chunkLength = chunk.m_ChunkLength;
				int chunkOffset = chunk.m_ChunkOffset;
				int chunkOffset2 = this.m_ChunkOffset;
				StringBuilder chunkPrevious = this.m_ChunkPrevious;
				int chunkOffset3 = chunkPrevious.m_ChunkOffset;
				if (chunkPrevious == null)
				{
				}
				char c = value[(int)num];
				char[] chunkChars = this.m_ChunkChars;
				int stringLength2 = value._stringLength;
				return;
			}
		}

		// Token: 0x0600157A RID: 5498 RVA: 0x0002D004 File Offset: 0x0002B204
		private unsafe void ReplaceInPlaceAtChunk(StringBuilder chunk, int indexInChunk, char* value, int count)
		{
			if (count != 0)
			{
				int num = Math.Min(0, count);
				int chunkOffset = this.m_ChunkOffset;
				int chunkOffset2 = this.m_ChunkPrevious.m_ChunkOffset;
				return;
			}
		}

		// Token: 0x0600157B RID: 5499 RVA: 0x0002D038 File Offset: 0x0002B238
		private unsafe static void ThreadSafeCopy(char* sourcePtr, char[] destination, int destinationIndex, int count)
		{
			string.wstrcpy(sourcePtr, sourcePtr, count);
		}

		// Token: 0x0600157C RID: 5500 RVA: 0x0002D050 File Offset: 0x0002B250
		private static void ThreadSafeCopy(char[] source, int sourceIndex, Span<char> destination, int destinationIndex, int count)
		{
		}

		// Token: 0x0600157D RID: 5501 RVA: 0x0002D064 File Offset: 0x0002B264
		private StringBuilder FindChunkForIndex(int index)
		{
			int chunkOffset = this.m_ChunkOffset;
			return this.m_ChunkPrevious.FindChunkForIndex(index);
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x0600157E RID: 5502 RVA: 0x0002D088 File Offset: 0x0002B288
		private Span<char> RemainingCurrentChunk
		{
			get
			{
				char[] chunkChars = this.m_ChunkChars;
				int num = 1;
				if (chunkChars != null)
				{
					ThrowHelper.ThrowArgumentOutOfRangeException();
				}
				if (num != 0)
				{
					ThrowHelper.ThrowArgumentOutOfRangeException();
					return;
				}
			}
		}

		// Token: 0x0600157F RID: 5503 RVA: 0x0002D0B4 File Offset: 0x0002B2B4
		private StringBuilder Next(StringBuilder chunk)
		{
			int chunkLength = chunk.m_ChunkLength;
			int maxCapacity = chunk.m_MaxCapacity;
			int chunkOffset = this.m_ChunkOffset;
			StringBuilder chunkPrevious = this.m_ChunkPrevious;
			int chunkOffset2 = chunkPrevious.m_ChunkOffset;
			return chunkPrevious;
		}

		// Token: 0x06001580 RID: 5504 RVA: 0x0002D0EC File Offset: 0x0002B2EC
		private void ExpandByABlock(int minBlockCharCount)
		{
			int chunkLength = this.m_ChunkLength;
			int maxCapacity = this.m_MaxCapacity;
			int maxCapacity2 = this.m_MaxCapacity;
			int num = 8000;
			int num2 = Math.Min(43151360, num);
			int num3 = Math.Max(minBlockCharCount, num2);
			int chunkLength2 = this.m_ChunkLength;
			char[] chunkChars = this.m_ChunkChars;
			int maxCapacity3 = this.m_MaxCapacity;
			int chunkLength3 = this.m_ChunkLength;
			int maxCapacity4 = this.m_MaxCapacity;
			this.m_MaxCapacity = chunkLength3;
		}

		// Token: 0x06001581 RID: 5505 RVA: 0x0002D15C File Offset: 0x0002B35C
		private StringBuilder(StringBuilder from)
		{
			int chunkLength = from.m_ChunkLength;
			this.m_ChunkLength = chunkLength;
			char[] chunkChars = from.m_ChunkChars;
			this.m_ChunkChars = chunkChars;
			int maxCapacity = from.m_MaxCapacity;
			this.m_MaxCapacity = maxCapacity;
		}

		// Token: 0x06001582 RID: 5506 RVA: 0x0002D19C File Offset: 0x0002B39C
		private void MakeRoom(int index, int count, [Out] StringBuilder chunk, [Out] int indexInChunk, bool doNotMoveFollowingChars)
		{
			int chunkOffset = this.m_ChunkOffset;
			StringBuilder chunkPrevious = this.m_ChunkPrevious;
			int chunkOffset2 = chunkPrevious.m_ChunkOffset;
			char[] chunkChars = chunkPrevious.m_ChunkChars;
			int num = 16;
			int num2 = Math.Max(count, num);
			indexInChunk.m_value = num2;
			int num3;
			indexInChunk.m_value = num3;
		}

		// Token: 0x06001583 RID: 5507 RVA: 0x0002D1E8 File Offset: 0x0002B3E8
		private StringBuilder(int size, int maxCapacity, StringBuilder previousBlock)
		{
			this.m_MaxCapacity = maxCapacity;
			this.m_ChunkPrevious = previousBlock;
			if (previousBlock != null)
			{
				int chunkLength = previousBlock.m_ChunkLength;
				int maxCapacity2 = previousBlock.m_MaxCapacity;
				this.m_ChunkOffset = chunkLength;
			}
		}

		// Token: 0x06001584 RID: 5508 RVA: 0x0002D224 File Offset: 0x0002B424
		private void Remove(int startIndex, int count, [Out] StringBuilder chunk, [Out] int indexInChunk)
		{
			int chunkOffset = this.m_ChunkOffset;
		}

		// Token: 0x04000B24 RID: 2852
		internal char[] m_ChunkChars;

		// Token: 0x04000B25 RID: 2853
		internal StringBuilder m_ChunkPrevious;

		// Token: 0x04000B26 RID: 2854
		internal int m_ChunkLength;

		// Token: 0x04000B27 RID: 2855
		internal int m_ChunkOffset;

		// Token: 0x04000B28 RID: 2856
		internal int m_MaxCapacity;

		// Token: 0x04000B29 RID: 2857
		internal const int DefaultCapacity = 16;

		// Token: 0x04000B2A RID: 2858
		private const string CapacityField = "Capacity";

		// Token: 0x04000B2B RID: 2859
		private const string MaxCapacityField = "m_MaxCapacity";

		// Token: 0x04000B2C RID: 2860
		private const string StringValueField = "m_StringValue";

		// Token: 0x04000B2D RID: 2861
		private const string ThreadIDField = "m_currentThread";

		// Token: 0x04000B2E RID: 2862
		internal const int MaxChunkSize = 8000;

		// Token: 0x04000B2F RID: 2863
		private const int IndexLimit = 1000000;

		// Token: 0x04000B30 RID: 2864
		private const int WidthLimit = 1000000;
	}
}
