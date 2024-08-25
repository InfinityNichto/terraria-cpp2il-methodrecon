using System;
using System.Runtime.InteropServices;

namespace System.Net
{
	// Token: 0x02000238 RID: 568
	internal class DigestHeaderParser
	{
		// Token: 0x06000E2A RID: 3626 RVA: 0x0002D12C File Offset: 0x0002B32C
		public DigestHeaderParser(string header)
		{
			if (!true)
			{
			}
			base..ctor();
			string text = header.Trim();
			this.header = text;
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06000E2B RID: 3627 RVA: 0x0002D150 File Offset: 0x0002B350
		public string Realm
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000E2B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Net.DigestHeaderParser::get_Realm()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string[](var_0_06, ldfld:string[](DigestHeaderParser::values, ldloc:DigestHeaderParser(this)))
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

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06000E2C RID: 3628 RVA: 0x0002D164 File Offset: 0x0002B364
		public string Opaque
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000E2C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Net.DigestHeaderParser::get_Opaque()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string[](var_0_06, ldfld:string[](DigestHeaderParser::values, ldloc:DigestHeaderParser(this)))
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

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06000E2D RID: 3629 RVA: 0x0002D178 File Offset: 0x0002B378
		public string Nonce
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000E2D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Net.DigestHeaderParser::get_Nonce()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string[](var_0_06, ldfld:string[](DigestHeaderParser::values, ldloc:DigestHeaderParser(this)))
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

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06000E2E RID: 3630 RVA: 0x0002D18C File Offset: 0x0002B38C
		public string Algorithm
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000E2E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Net.DigestHeaderParser::get_Algorithm()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string[](var_0_06, ldfld:string[](DigestHeaderParser::values, ldloc:DigestHeaderParser(this)))
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

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06000E2F RID: 3631 RVA: 0x0002D1A0 File Offset: 0x0002B3A0
		public string QOP
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000E2F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Net.DigestHeaderParser::get_QOP()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string[](var_0_06, ldfld:string[](DigestHeaderParser::values, ldloc:DigestHeaderParser(this)))
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

		// Token: 0x06000E30 RID: 3632 RVA: 0x0002D1B4 File Offset: 0x0002B3B4
		public bool Parse()
		{
			bool flag = this.header.ToLower().StartsWith("digest ");
			string text = this.header;
			int num = 6;
			this.pos = num;
			int stringLength = text._stringLength;
			this.length = stringLength;
			this.SkipWhitespace();
			int num2 = this.length;
			string[] array = this.values;
			string text2 = this.header;
			int num3 = this.pos;
			this.pos = num3;
			if (num3 == 0)
			{
			}
			string[] array2 = this.values;
			if (num == 0)
			{
				if ("digest " == null || "digest " != null)
				{
					int num4 = this.length;
					string[] array3 = this.values;
					string[] array4 = this.values;
					if (array3 != null)
					{
						return "digest " != null;
					}
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000E31 RID: 3633 RVA: 0x0002D26C File Offset: 0x0002B46C
		private void SkipWhitespace()
		{
			int num = this.length;
			string[] array = this.values;
			string text = this.header;
			this.pos = num;
			int num2 = this.length;
			string[] array2 = this.values;
			this.pos = num2;
		}

		// Token: 0x06000E32 RID: 3634 RVA: 0x0002D2B0 File Offset: 0x0002B4B0
		private string GetKey()
		{
			this.SkipWhitespace();
			int num = this.length;
			string[] array = this.values;
			string text = this.header;
			int num2 = this.pos;
			int num3 = this.length;
			this.pos = num2;
			string text2 = this.header;
			string text3;
			return text3.Trim().ToLower();
		}

		// Token: 0x06000E33 RID: 3635 RVA: 0x0002D304 File Offset: 0x0002B504
		private bool GetKeywordAndValue([Out] string key, [Out] string value)
		{
			/*
An exception occurred when decompiling this method (06000E33)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Net.DigestHeaderParser::GetKeywordAndValue(System.String,System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_06, call:string(DigestHeaderParser::GetKey, ldloc:DigestHeaderParser(this)))
	stloc:int32(var_1_0D, ldfld:int32(DigestHeaderParser::length, ldloc:DigestHeaderParser(this)))
	stloc:string[](var_2_14, ldfld:string[](DigestHeaderParser::values, ldloc:DigestHeaderParser(this)))
	call:void(DigestHeaderParser::SkipWhitespace, ldloc:DigestHeaderParser(this))
	stloc:int32(var_3_21, ldfld:int32(DigestHeaderParser::length, ldloc:DigestHeaderParser(this)))
	stloc:string[](var_4_28, ldfld:string[](DigestHeaderParser::values, ldloc:DigestHeaderParser(this)))
	stloc:string(var_5_30, ldfld:string(DigestHeaderParser::header, ldloc:DigestHeaderParser(this)))
	stfld:int32(DigestHeaderParser::pos, ldloc:DigestHeaderParser(this), ldloc:int32(var_1_0D))
	call:void(DigestHeaderParser::SkipWhitespace, ldloc:DigestHeaderParser(this))
	stloc:int32(var_7_45, ldfld:int32(DigestHeaderParser::length, ldloc:DigestHeaderParser(this)))
	stloc:string[](var_8_4D, ldfld:string[](DigestHeaderParser::values, ldloc:DigestHeaderParser(this)))
	stloc:string(var_9_55, ldfld:string(DigestHeaderParser::header, ldloc:DigestHeaderParser(this)))
	stloc:int32(var_11_5D, ldfld:int32(DigestHeaderParser::pos, ldloc:DigestHeaderParser(this)))
	stloc:string(var_12_65, ldfld:string(DigestHeaderParser::header, ldloc:DigestHeaderParser(this)))
	stloc:int32(var_13_69, ldc.i4:int32(34))
	stfld:int32(DigestHeaderParser::pos, ldloc:DigestHeaderParser(this), ldloc:int32(var_11_5D))
	stloc:int32(var_14_7E, call:int32(string::IndexOf, ldloc:string(var_12_65), ldloc:int32[exp:char](var_13_69), ldloc:int32(var_11_5D)))
	stfld:int32(DigestHeaderParser::pos, ldloc:DigestHeaderParser(this), ldloc:int32(var_14_7E))
	stloc:string(var_15_8E, ldfld:string(DigestHeaderParser::header, ldloc:DigestHeaderParser(this)))
	stloc:int64(var_16_91, ldc.i4:int64(0))
	stloc:char(var_17_9C, callgetter:char(string::get_Chars, ldloc:string(var_15_8E), ldloc:int32(var_11_5D)))
	stloc:int32(var_18_A4, ldfld:int32(DigestHeaderParser::length, ldloc:DigestHeaderParser(this)))
	stloc:string[](var_19_AC, ldfld:string[](DigestHeaderParser::values, ldloc:DigestHeaderParser(this)))
	stfld:int32(DigestHeaderParser::pos, ldloc:DigestHeaderParser(this), ldloc:int32(var_11_5D))
	stloc:int32(var_20_BC, ldfld:int32(DigestHeaderParser::pos, ldloc:DigestHeaderParser(this)))
	stloc:int32(var_21_C4, ldfld:int32(DigestHeaderParser::length, ldloc:DigestHeaderParser(this)))
	stloc:string(var_23_D8, call:string(string::Substring, ldfld:string(DigestHeaderParser::header, ldloc:DigestHeaderParser(this)), ldloc:int32(var_11_5D), ldloc:int64[exp:int32](var_16_91)))
	stloc:int32(var_24_E0, ldfld:int32(DigestHeaderParser::pos, ldloc:DigestHeaderParser(this)))
	stfld:int32(DigestHeaderParser::pos, ldloc:DigestHeaderParser(this), ldloc:int32(var_24_E0))
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

		// Token: 0x06000E34 RID: 3636 RVA: 0x0002D400 File Offset: 0x0002B600
		// Note: this type is marked as 'beforefieldinit'.
		static DigestHeaderParser()
		{
			if (("realm" == null || "realm" != null) && ("opaque" == null || "opaque" != null) && ("nonce" == null || "nonce" != null) && ("algorithm" == null || "algorithm" != null) && ("qop" == null || "qop" != null))
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x04000BCC RID: 3020
		private string header;

		// Token: 0x04000BCD RID: 3021
		private int length;

		// Token: 0x04000BCE RID: 3022
		private int pos;

		// Token: 0x04000BCF RID: 3023
		private static string[] keywords;

		// Token: 0x04000BD0 RID: 3024
		private string[] values;
	}
}
