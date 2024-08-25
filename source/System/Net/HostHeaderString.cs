using System;
using System.Text;

namespace System.Net
{
	// Token: 0x020001D1 RID: 465
	internal class HostHeaderString
	{
		// Token: 0x06000B4C RID: 2892 RVA: 0x00025140 File Offset: 0x00023340
		internal HostHeaderString()
		{
		}

		// Token: 0x06000B4D RID: 2893 RVA: 0x00025154 File Offset: 0x00023354
		internal HostHeaderString(string s)
		{
		}

		// Token: 0x06000B4E RID: 2894 RVA: 0x00025168 File Offset: 0x00023368
		private void Init(string s)
		{
			this.m_String = s;
		}

		// Token: 0x06000B4F RID: 2895 RVA: 0x0002517C File Offset: 0x0002337C
		private void Convert()
		{
			if (!this.m_Converted)
			{
				Encoding @default = Encoding.Default;
				string @string = this.m_String;
				this.m_Bytes = @default;
				Encoding default2 = Encoding.Default;
				byte[] bytes = this.m_Bytes;
				string string2 = this.m_String;
				int num;
				if (num != 0)
				{
					Encoding utf = Encoding.UTF8;
					string string3 = this.m_String;
					this.m_Bytes = utf;
				}
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06000B50 RID: 2896 RVA: 0x000251E0 File Offset: 0x000233E0
		// (set) Token: 0x06000B51 RID: 2897 RVA: 0x000251F4 File Offset: 0x000233F4
		internal string String
		{
			get
			{
				return this.m_String;
			}
			set
			{
				this.m_String = value;
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06000B52 RID: 2898 RVA: 0x00025208 File Offset: 0x00023408
		internal int ByteCount
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000B52)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Net.HostHeaderString::get_ByteCount()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(HostHeaderString::Convert, ldloc:HostHeaderString(this))
	stloc:uint8[](var_0_0C, ldfld:uint8[](HostHeaderString::m_Bytes, ldloc:HostHeaderString(this)))
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

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000B53 RID: 2899 RVA: 0x00025224 File Offset: 0x00023424
		internal byte[] Bytes
		{
			get
			{
				this.Convert();
				return this.m_Bytes;
			}
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x00025240 File Offset: 0x00023440
		internal void Copy(byte[] destBytes, int destByteIndex)
		{
			this.Convert();
			byte[] bytes = this.m_Bytes;
		}

		// Token: 0x040009E8 RID: 2536
		private bool m_Converted;

		// Token: 0x040009E9 RID: 2537
		private string m_String;

		// Token: 0x040009EA RID: 2538
		private byte[] m_Bytes;
	}
}
