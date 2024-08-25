using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace Mono.Security
{
	// Token: 0x02000003 RID: 3
	public class ASN1
	{
		// Token: 0x06000003 RID: 3 RVA: 0x0000206C File Offset: 0x0000026C
		public ASN1(byte tag)
		{
			this.m_nTag = tag;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002088 File Offset: 0x00000288
		public ASN1(byte tag, byte[] data)
		{
			this.m_nTag = tag;
			this.m_aValue = data;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000020AC File Offset: 0x000002AC
		public ASN1(byte[] data)
		{
			int num = 1;
			base..ctor();
			this.m_nTag = (byte)num;
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000006 RID: 6 RVA: 0x000020FC File Offset: 0x000002FC
		public int Count
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000006)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Mono.Security.ASN1::get_Count()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, logicnot:bool(ldfld:ArrayList[exp:bool](ASN1::elist, ldloc:ASN1(this))))
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

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000007 RID: 7 RVA: 0x00002110 File Offset: 0x00000310
		public byte Tag
		{
			get
			{
				return this.m_nTag;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00002124 File Offset: 0x00000324
		public int Length
		{
			get
			{
				if (this.m_aValue != null)
				{
					return;
				}
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000009 RID: 9 RVA: 0x0000213C File Offset: 0x0000033C
		// (set) Token: 0x0600000A RID: 10 RVA: 0x00002164 File Offset: 0x00000364
		public byte[] Value
		{
			get
			{
				if (this.m_aValue == null)
				{
					byte[] aValue = this.m_aValue;
				}
				object obj;
				if (obj == null || obj != null)
				{
				}
				throw new InvalidCastException();
			}
			set
			{
				object obj;
				if (value != null && obj != null)
				{
					if (obj == null)
					{
						throw new InvalidCastException();
					}
					this.m_aValue = obj;
					if (obj == null)
					{
						throw new InvalidCastException();
					}
				}
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002190 File Offset: 0x00000390
		private bool CompareArray(byte[] array1, byte[] array2)
		{
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000021A4 File Offset: 0x000003A4
		public bool CompareValue(byte[] value)
		{
			/*
An exception occurred when decompiling this method (0600000C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Mono.Security.ASN1::CompareValue(System.Byte[])

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint8[](var_0_06, ldfld:uint8[](ASN1::m_aValue, ldloc:ASN1(this)))
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

		// Token: 0x0600000D RID: 13 RVA: 0x000021C0 File Offset: 0x000003C0
		public ASN1 Add(ASN1 asn1)
		{
			if (asn1 == null || this.elist == null)
			{
			}
			return asn1;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000021DC File Offset: 0x000003DC
		public virtual byte[] GetBytes()
		{
			ArrayList arrayList;
			if (this.elist != null)
			{
				arrayList = this.elist;
				int size = arrayList._size;
			}
			if (this.m_aValue == null)
			{
				long num = 0L;
				int num2 = 5;
				if (arrayList != null)
				{
				}
				if (num != 0L)
				{
					throw new OutOfMemoryException();
				}
				if (num2 != 0)
				{
					goto IL_0063;
				}
				ArrayList arrayList2 = this.elist;
				ArrayList arrayList3 = this.elist;
			}
			if (this.m_aValue == null)
			{
			}
			byte nTag = this.m_nTag;
			IL_0063:
			throw new InvalidCastException();
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002268 File Offset: 0x00000468
		protected void Decode(byte[] asn1, int anPos, int anLength)
		{
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002280 File Offset: 0x00000480
		protected void DecodeTLV(byte[] asn1, int pos, [Out] byte tag, [Out] int length, [Out] byte[] content)
		{
			int num = 1;
			tag.m_value = (byte)num;
			length.m_value = asn1;
			length.m_value = asn1;
		}

		// Token: 0x17000005 RID: 5
		public ASN1 this[int index]
		{
			get
			{
				if (this.elist != null && this.elist != null)
				{
					throw new InvalidCastException();
				}
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000022D4 File Offset: 0x000004D4
		public ASN1 Element(int index, byte anTag)
		{
			if (this.elist != null)
			{
				ArrayList arrayList = this.elist;
				if (arrayList != null)
				{
				}
				object[] items = arrayList._items;
				throw new InvalidCastException();
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002304 File Offset: 0x00000504
		public override string ToString()
		{
			/*
An exception occurred when decompiling this method (06000013)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String Mono.Security.ASN1::ToString()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_3_09, callgetter:string(Environment::get_NewLine))
	stloc:uint8[](var_5_10, callgetter:uint8[](ASN1::get_Value, ldloc:ASN1(this)))
	stloc:string(var_7_1A, callgetter:string(Environment::get_NewLine))
	stloc:string(var_11_24, callgetter:string(Environment::get_NewLine))
	stloc:uint8[](var_13_2C, callgetter:uint8[](ASN1::get_Value, ldloc:ASN1(this)))
	stloc:string(var_14_3E, call:string(uint8::ToString, callgetter:uint8[][exp:uint8&](ASN1::get_Value, ldloc:ASN1(this)), ldstr:string("X2")))
	stloc:string(var_17_48, callgetter:string(Environment::get_NewLine))
	stloc:uint8[](var_19_50, callgetter:uint8[](ASN1::get_Value, ldloc:ASN1(this)))
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

		// Token: 0x04000001 RID: 1
		private byte m_nTag;

		// Token: 0x04000002 RID: 2
		private byte[] m_aValue;

		// Token: 0x04000003 RID: 3
		private ArrayList elist;
	}
}
