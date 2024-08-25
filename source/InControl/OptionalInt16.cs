using System;
using System.Globalization;
using Cpp2IlInjected;
using UnityEngine;

namespace InControl
{
	// Token: 0x02000067 RID: 103
	[Serializable]
	public struct OptionalInt16
	{
		// Token: 0x060004AA RID: 1194 RVA: 0x0000F720 File Offset: 0x0000D920
		public OptionalInt16(short value)
		{
			this.hasValue = true;
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x060004AB RID: 1195 RVA: 0x000025E1 File Offset: 0x000007E1
		public bool HasValue
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x060004AC RID: 1196 RVA: 0x000025E1 File Offset: 0x000007E1
		public bool HasNoValue
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x060004AD RID: 1197 RVA: 0x0000F734 File Offset: 0x0000D934
		// (set) Token: 0x060004AE RID: 1198 RVA: 0x0000F748 File Offset: 0x0000D948
		public short Value
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

		// Token: 0x060004AF RID: 1199 RVA: 0x0000F764 File Offset: 0x0000D964
		public void Clear()
		{
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x0000F774 File Offset: 0x0000D974
		public short GetValueOrDefault(short defaultValue)
		{
			return this.value;
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x0000F78C File Offset: 0x0000D98C
		public short GetValueOrZero()
		{
			return this.value;
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x0000F7A4 File Offset: 0x0000D9A4
		public void SetValue(short value)
		{
			this.value = value;
			this.hasValue = true;
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x0000F7C0 File Offset: 0x0000D9C0
		public override bool Equals(object other)
		{
			if (other == null)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x0000F7D4 File Offset: 0x0000D9D4
		public bool Equals(OptionalInt16 other)
		{
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x0000F7E4 File Offset: 0x0000D9E4
		public bool Equals(short other)
		{
			/*
An exception occurred when decompiling this method (060004B5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean InControl.OptionalInt16::Equals(System.Int16)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int16(var_0_06, ldfld:int16(OptionalInt16::value, ldloc:valuetype InControl.OptionalInt16&(this)))
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

		// Token: 0x060004B6 RID: 1206 RVA: 0x000025E1 File Offset: 0x000007E1
		public static bool operator ==(OptionalInt16 a, OptionalInt16 b)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x000025E1 File Offset: 0x000007E1
		public static bool operator !=(OptionalInt16 a, OptionalInt16 b)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x0000F7FC File Offset: 0x0000D9FC
		public static bool operator ==(OptionalInt16 a, short b)
		{
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x0000F80C File Offset: 0x0000DA0C
		public static bool operator !=(OptionalInt16 a, short b)
		{
			return true;
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x000025E1 File Offset: 0x000007E1
		private static int CombineHashCodes(int h1, int h2)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x0000F81C File Offset: 0x0000DA1C
		public override int GetHashCode()
		{
			int num;
			return num;
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x0000F82C File Offset: 0x0000DA2C
		public override string ToString()
		{
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			string text;
			return text;
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x0000F848 File Offset: 0x0000DA48
		public static implicit operator OptionalInt16(short value)
		{
			return 1;
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x0000F858 File Offset: 0x0000DA58
		public static explicit operator short(OptionalInt16 optional)
		{
			short num;
			return num;
		}

		// Token: 0x040003E8 RID: 1000
		[SerializeField]
		private bool hasValue;

		// Token: 0x040003E9 RID: 1001
		[SerializeField]
		private short value;
	}
}
