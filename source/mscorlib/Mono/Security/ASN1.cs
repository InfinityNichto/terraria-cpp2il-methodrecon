using System;
using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Mono.Security
{
	// Token: 0x02000040 RID: 64
	[DefaultMember("Item")]
	internal class ASN1
	{
		// Token: 0x06000107 RID: 263 RVA: 0x00004698 File Offset: 0x00002898
		public ASN1(byte tag)
		{
			this.m_nTag = tag;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x000046B4 File Offset: 0x000028B4
		public ASN1(byte tag, byte[] data)
		{
			this.m_nTag = tag;
			this.m_aValue = data;
		}

		// Token: 0x06000109 RID: 265 RVA: 0x000046D8 File Offset: 0x000028D8
		public ASN1(byte[] data)
		{
			int num = 1;
			base..ctor();
			this.m_nTag = (byte)num;
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600010A RID: 266 RVA: 0x00004728 File Offset: 0x00002928
		public int Count
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600010A)

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

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600010B RID: 267 RVA: 0x0000473C File Offset: 0x0000293C
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
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00004764 File Offset: 0x00002964
		public ASN1 Add(ASN1 asn1)
		{
			if (this.elist == null)
			{
			}
			return asn1;
		}

		// Token: 0x0600010D RID: 269 RVA: 0x0000477C File Offset: 0x0000297C
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

		// Token: 0x0600010E RID: 270 RVA: 0x00004808 File Offset: 0x00002A08
		protected void Decode(byte[] asn1, int anPos, int anLength)
		{
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00004820 File Offset: 0x00002A20
		protected void DecodeTLV(byte[] asn1, int pos, [Out] byte tag, [Out] int length, [Out] byte[] content)
		{
			int num = 1;
			tag.m_value = (byte)num;
			length.m_value = asn1;
			length.m_value = asn1;
		}

		// Token: 0x06000110 RID: 272 RVA: 0x0000484C File Offset: 0x00002A4C
		public override string ToString()
		{
			/*
An exception occurred when decompiling this method (06000110)

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

		// Token: 0x0400013B RID: 315
		private byte m_nTag;

		// Token: 0x0400013C RID: 316
		private byte[] m_aValue;

		// Token: 0x0400013D RID: 317
		private ArrayList elist;
	}
}
