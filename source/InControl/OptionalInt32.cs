using System;
using System.Globalization;
using Cpp2IlInjected;
using UnityEngine;

namespace InControl
{
	// Token: 0x02000068 RID: 104
	[Serializable]
	public struct OptionalInt32
	{
		// Token: 0x060004BF RID: 1215 RVA: 0x0000F868 File Offset: 0x0000DA68
		public OptionalInt32(int value)
		{
			this.value = value;
			this.hasValue = true;
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x060004C0 RID: 1216 RVA: 0x000025E1 File Offset: 0x000007E1
		public bool HasValue
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x060004C1 RID: 1217 RVA: 0x000025E1 File Offset: 0x000007E1
		public bool HasNoValue
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x060004C2 RID: 1218 RVA: 0x0000F884 File Offset: 0x0000DA84
		// (set) Token: 0x060004C3 RID: 1219 RVA: 0x0000F898 File Offset: 0x0000DA98
		public int Value
		{
			get
			{
				return this.value;
			}
			set
			{
				this.value = value;
				this.hasValue = true;
			}
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x0000F8B4 File Offset: 0x0000DAB4
		public void Clear()
		{
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x0000F8C4 File Offset: 0x0000DAC4
		public int GetValueOrDefault(int defaultValue)
		{
			return this.value;
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x0000F8D8 File Offset: 0x0000DAD8
		public int GetValueOrZero()
		{
			return this.value;
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x0000F8F0 File Offset: 0x0000DAF0
		public void SetValue(int value)
		{
			this.value = value;
			this.hasValue = true;
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x0000F90C File Offset: 0x0000DB0C
		public override bool Equals(object other)
		{
			if (other == null)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x0000F920 File Offset: 0x0000DB20
		public bool Equals(OptionalInt32 other)
		{
			/*
An exception occurred when decompiling this method (060004C9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean InControl.OptionalInt32::Equals(InControl.OptionalInt32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_1_08, ldfld:int32(OptionalInt32::value, ldloc:valuetype InControl.OptionalInt32&(this)))
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

		// Token: 0x060004CA RID: 1226 RVA: 0x0000F938 File Offset: 0x0000DB38
		public bool Equals(int other)
		{
			/*
An exception occurred when decompiling this method (060004CA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean InControl.OptionalInt32::Equals(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(OptionalInt32::value, ldloc:valuetype InControl.OptionalInt32&(this)))
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

		// Token: 0x060004CB RID: 1227 RVA: 0x0000F950 File Offset: 0x0000DB50
		public static bool operator ==(OptionalInt32 a, OptionalInt32 b)
		{
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x0000F960 File Offset: 0x0000DB60
		public static bool operator !=(OptionalInt32 a, OptionalInt32 b)
		{
			return true;
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x000025E1 File Offset: 0x000007E1
		public static bool operator ==(OptionalInt32 a, int b)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x000025E1 File Offset: 0x000007E1
		public static bool operator !=(OptionalInt32 a, int b)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x000025E1 File Offset: 0x000007E1
		private static int CombineHashCodes(int h1, int h2)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x0000F970 File Offset: 0x0000DB70
		public override int GetHashCode()
		{
			int num;
			return num.GetHashCode();
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x0000F984 File Offset: 0x0000DB84
		public override string ToString()
		{
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			string text;
			return text;
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x0000F9A0 File Offset: 0x0000DBA0
		public static implicit operator OptionalInt32(int value)
		{
			return 1;
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x0000F9B0 File Offset: 0x0000DBB0
		public static explicit operator int(OptionalInt32 optional)
		{
			int num;
			return num;
		}

		// Token: 0x040003EA RID: 1002
		[SerializeField]
		private bool hasValue;

		// Token: 0x040003EB RID: 1003
		[SerializeField]
		private int value;
	}
}
