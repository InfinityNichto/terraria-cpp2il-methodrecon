using System;
using System.Globalization;
using Cpp2IlInjected;
using UnityEngine;

namespace InControl
{
	// Token: 0x02000069 RID: 105
	[Serializable]
	public struct OptionalUInt16
	{
		// Token: 0x060004D4 RID: 1236 RVA: 0x0000F9C0 File Offset: 0x0000DBC0
		public OptionalUInt16(ushort value)
		{
			this.value = value;
			this.hasValue = true;
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x060004D5 RID: 1237 RVA: 0x000025E1 File Offset: 0x000007E1
		public bool HasValue
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x060004D6 RID: 1238 RVA: 0x000025E1 File Offset: 0x000007E1
		public bool HasNoValue
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x060004D7 RID: 1239 RVA: 0x0000F9DC File Offset: 0x0000DBDC
		// (set) Token: 0x060004D8 RID: 1240 RVA: 0x0000F9F0 File Offset: 0x0000DBF0
		public ushort Value
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

		// Token: 0x060004D9 RID: 1241 RVA: 0x0000FA0C File Offset: 0x0000DC0C
		public void Clear()
		{
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x0000FA1C File Offset: 0x0000DC1C
		public ushort GetValueOrDefault(ushort defaultValue)
		{
			return this.value;
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x0000FA34 File Offset: 0x0000DC34
		public ushort GetValueOrZero()
		{
			return this.value;
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x0000FA4C File Offset: 0x0000DC4C
		public void SetValue(ushort value)
		{
			this.value = value;
			this.hasValue = true;
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x0000FA68 File Offset: 0x0000DC68
		public override bool Equals(object other)
		{
			if (other == null)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x0000FA7C File Offset: 0x0000DC7C
		public bool Equals(OptionalUInt16 other)
		{
			/*
An exception occurred when decompiling this method (060004DE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean InControl.OptionalUInt16::Equals(InControl.OptionalUInt16)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint16(var_1_08, ldfld:uint16(OptionalUInt16::value, ldloc:valuetype InControl.OptionalUInt16&(this)))
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

		// Token: 0x060004DF RID: 1247 RVA: 0x0000FA94 File Offset: 0x0000DC94
		public bool Equals(ushort other)
		{
			/*
An exception occurred when decompiling this method (060004DF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean InControl.OptionalUInt16::Equals(System.UInt16)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint16(var_0_06, ldfld:uint16(OptionalUInt16::value, ldloc:valuetype InControl.OptionalUInt16&(this)))
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

		// Token: 0x060004E0 RID: 1248 RVA: 0x000025E1 File Offset: 0x000007E1
		public static bool operator ==(OptionalUInt16 a, OptionalUInt16 b)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x000025E1 File Offset: 0x000007E1
		public static bool operator !=(OptionalUInt16 a, OptionalUInt16 b)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x000025E1 File Offset: 0x000007E1
		public static bool operator ==(OptionalUInt16 a, ushort b)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x000025E1 File Offset: 0x000007E1
		public static bool operator !=(OptionalUInt16 a, ushort b)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x000025E1 File Offset: 0x000007E1
		private static int CombineHashCodes(int h1, int h2)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x0000FAAC File Offset: 0x0000DCAC
		public override int GetHashCode()
		{
			int num;
			return num;
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x0000FABC File Offset: 0x0000DCBC
		public override string ToString()
		{
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			string text;
			return text;
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x0000FAD8 File Offset: 0x0000DCD8
		public static implicit operator OptionalUInt16(ushort value)
		{
			return 1;
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x0000FAE8 File Offset: 0x0000DCE8
		public static explicit operator ushort(OptionalUInt16 optional)
		{
			ushort num;
			return num;
		}

		// Token: 0x040003EC RID: 1004
		[SerializeField]
		private bool hasValue;

		// Token: 0x040003ED RID: 1005
		[SerializeField]
		private ushort value;
	}
}
