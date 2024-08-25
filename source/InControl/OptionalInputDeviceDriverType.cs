using System;
using Cpp2IlInjected;
using UnityEngine;

namespace InControl
{
	// Token: 0x02000065 RID: 101
	[Serializable]
	public struct OptionalInputDeviceDriverType
	{
		// Token: 0x06000480 RID: 1152 RVA: 0x0000F4A0 File Offset: 0x0000D6A0
		public OptionalInputDeviceDriverType(InputDeviceDriverType value)
		{
			this.value = value;
			this.hasValue = true;
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000481 RID: 1153 RVA: 0x000025E1 File Offset: 0x000007E1
		public bool HasValue
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000482 RID: 1154 RVA: 0x000025E1 File Offset: 0x000007E1
		public bool HasNoValue
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000483 RID: 1155 RVA: 0x0000F4BC File Offset: 0x0000D6BC
		// (set) Token: 0x06000484 RID: 1156 RVA: 0x0000F4D0 File Offset: 0x0000D6D0
		public InputDeviceDriverType Value
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

		// Token: 0x06000485 RID: 1157 RVA: 0x0000F4EC File Offset: 0x0000D6EC
		public void Clear()
		{
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x0000F4FC File Offset: 0x0000D6FC
		public InputDeviceDriverType GetValueOrDefault(InputDeviceDriverType defaultValue)
		{
			return this.value;
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x0000F514 File Offset: 0x0000D714
		public InputDeviceDriverType GetValueOrZero()
		{
			return this.value;
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x0000F52C File Offset: 0x0000D72C
		public void SetValue(InputDeviceDriverType value)
		{
			this.value = value;
			this.hasValue = true;
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x0000F548 File Offset: 0x0000D748
		public override bool Equals(object other)
		{
			if (other == null)
			{
			}
			InputDeviceDriverType inputDeviceDriverType = this.value;
			bool flag;
			return flag;
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x0000F564 File Offset: 0x0000D764
		public bool Equals(OptionalInputDeviceDriverType other)
		{
			/*
An exception occurred when decompiling this method (0600048A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean InControl.OptionalInputDeviceDriverType::Equals(InControl.OptionalInputDeviceDriverType)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:InputDeviceDriverType(var_1_08, ldfld:InputDeviceDriverType(OptionalInputDeviceDriverType::value, ldloc:valuetype InControl.OptionalInputDeviceDriverType&(this)))
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

		// Token: 0x0600048B RID: 1163 RVA: 0x0000F57C File Offset: 0x0000D77C
		public bool Equals(InputDeviceDriverType other)
		{
			/*
An exception occurred when decompiling this method (0600048B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean InControl.OptionalInputDeviceDriverType::Equals(InControl.InputDeviceDriverType)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:InputDeviceDriverType(var_0_06, ldfld:InputDeviceDriverType(OptionalInputDeviceDriverType::value, ldloc:valuetype InControl.OptionalInputDeviceDriverType&(this)))
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

		// Token: 0x0600048C RID: 1164 RVA: 0x000025E1 File Offset: 0x000007E1
		public static bool operator ==(OptionalInputDeviceDriverType a, OptionalInputDeviceDriverType b)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x000025E1 File Offset: 0x000007E1
		public static bool operator !=(OptionalInputDeviceDriverType a, OptionalInputDeviceDriverType b)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x000025E1 File Offset: 0x000007E1
		public static bool operator ==(OptionalInputDeviceDriverType a, InputDeviceDriverType b)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x000025E1 File Offset: 0x000007E1
		public static bool operator !=(OptionalInputDeviceDriverType a, InputDeviceDriverType b)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x000025E1 File Offset: 0x000007E1
		private static int CombineHashCodes(int h1, int h2)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x0000F594 File Offset: 0x0000D794
		public override int GetHashCode()
		{
			int num;
			return num;
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x0000F5A4 File Offset: 0x0000D7A4
		public override string ToString()
		{
			InputDeviceDriverType inputDeviceDriverType = this.value;
			string text;
			return text;
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x0000F5C0 File Offset: 0x0000D7C0
		public static implicit operator OptionalInputDeviceDriverType(InputDeviceDriverType value)
		{
			return 1;
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x0000F5D0 File Offset: 0x0000D7D0
		public static explicit operator InputDeviceDriverType(OptionalInputDeviceDriverType optional)
		{
			InputDeviceDriverType inputDeviceDriverType;
			return inputDeviceDriverType;
		}

		// Token: 0x040003E4 RID: 996
		[SerializeField]
		private bool hasValue;

		// Token: 0x040003E5 RID: 997
		[SerializeField]
		private InputDeviceDriverType value;
	}
}
