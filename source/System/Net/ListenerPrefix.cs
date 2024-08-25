using System;

namespace System.Net
{
	// Token: 0x02000262 RID: 610
	internal sealed class ListenerPrefix
	{
		// Token: 0x0600106D RID: 4205 RVA: 0x00033F84 File Offset: 0x00032184
		public ListenerPrefix(string prefix)
		{
			this.original = prefix;
			this.Parse(prefix);
		}

		// Token: 0x0600106E RID: 4206 RVA: 0x00033FA8 File Offset: 0x000321A8
		public override string ToString()
		{
			return this.original;
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x0600106F RID: 4207 RVA: 0x00033FBC File Offset: 0x000321BC
		// (set) Token: 0x06001070 RID: 4208 RVA: 0x00033FD0 File Offset: 0x000321D0
		public IPAddress[] Addresses
		{
			get
			{
				return this.addresses;
			}
			set
			{
				this.addresses = value;
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06001071 RID: 4209 RVA: 0x00033FE4 File Offset: 0x000321E4
		public bool Secure
		{
			get
			{
				return this.secure;
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06001072 RID: 4210 RVA: 0x00033FF8 File Offset: 0x000321F8
		public string Host
		{
			get
			{
				return this.host;
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06001073 RID: 4211 RVA: 0x0003400C File Offset: 0x0003220C
		public int Port
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001073)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Net.ListenerPrefix::get_Port()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint16(var_0_06, ldfld:uint16(ListenerPrefix::port, ldloc:ListenerPrefix(this)))
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

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06001074 RID: 4212 RVA: 0x00034020 File Offset: 0x00032220
		public string Path
		{
			get
			{
				return this.path;
			}
		}

		// Token: 0x06001075 RID: 4213 RVA: 0x00034034 File Offset: 0x00032234
		public override bool Equals(object o)
		{
			if (o != null)
			{
			}
			string text = this.original;
			bool flag;
			return flag;
		}

		// Token: 0x06001076 RID: 4214 RVA: 0x00034050 File Offset: 0x00032250
		public override int GetHashCode()
		{
			/*
An exception occurred when decompiling this method (06001076)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Net.ListenerPrefix::GetHashCode()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_06, ldfld:string(ListenerPrefix::original, ldloc:ListenerPrefix(this)))
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

		// Token: 0x06001077 RID: 4215 RVA: 0x00034064 File Offset: 0x00032264
		private void Parse(string uri)
		{
			bool flag = uri.StartsWith("https://");
			int num = 1;
			this.secure = num != 0;
		}

		// Token: 0x06001078 RID: 4216 RVA: 0x00034154 File Offset: 0x00032354
		public static void CheckUri(string uri)
		{
			if (uri != null)
			{
				bool flag = uri.StartsWith("http://");
				bool flag2 = uri.StartsWith("https://");
				int stringLength = uri._stringLength;
				int num = 58;
				int num2 = uri.IndexOf((char)num);
				int num3 = 58;
				int num4 = uri.IndexOf((char)num3, 0, stringLength);
				char c = uri[0];
				int num5 = uri.IndexOf("]:");
				int num6 = 47;
				int num7 = uri.IndexOf((char)num6, 0, stringLength);
				string text = uri.Substring(num6, 0);
				long num8 = 0L;
				int num9 = int.Parse(text);
				int stringLength2 = uri._stringLength;
				char c2 = uri[(int)num8];
				return;
			}
		}

		// Token: 0x04000CEE RID: 3310
		private string original;

		// Token: 0x04000CEF RID: 3311
		private string host;

		// Token: 0x04000CF0 RID: 3312
		private ushort port;

		// Token: 0x04000CF1 RID: 3313
		private string path;

		// Token: 0x04000CF2 RID: 3314
		private bool secure;

		// Token: 0x04000CF3 RID: 3315
		private IPAddress[] addresses;

		// Token: 0x04000CF4 RID: 3316
		public HttpListener Listener;
	}
}
