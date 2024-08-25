using System;
using Cpp2IlInjected;
using UnityEngine;

namespace InControl
{
	// Token: 0x02000066 RID: 102
	[Serializable]
	public struct OptionalInputDeviceTransportType
	{
		// Token: 0x06000495 RID: 1173 RVA: 0x0000F5E0 File Offset: 0x0000D7E0
		public OptionalInputDeviceTransportType(InputDeviceTransportType value)
		{
			this.value = value;
			this.hasValue = true;
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000496 RID: 1174 RVA: 0x000025E1 File Offset: 0x000007E1
		public bool HasValue
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000497 RID: 1175 RVA: 0x000025E1 File Offset: 0x000007E1
		public bool HasNoValue
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000498 RID: 1176 RVA: 0x0000F5FC File Offset: 0x0000D7FC
		// (set) Token: 0x06000499 RID: 1177 RVA: 0x0000F610 File Offset: 0x0000D810
		public InputDeviceTransportType Value
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

		// Token: 0x0600049A RID: 1178 RVA: 0x0000F62C File Offset: 0x0000D82C
		public void Clear()
		{
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x0000F63C File Offset: 0x0000D83C
		public InputDeviceTransportType GetValueOrDefault(InputDeviceTransportType defaultValue)
		{
			return this.value;
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x0000F654 File Offset: 0x0000D854
		public InputDeviceTransportType GetValueOrZero()
		{
			return this.value;
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x0000F66C File Offset: 0x0000D86C
		public void SetValue(InputDeviceTransportType value)
		{
			this.value = value;
			this.hasValue = true;
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x0000F688 File Offset: 0x0000D888
		public override bool Equals(object other)
		{
			if (other == null)
			{
			}
			InputDeviceTransportType inputDeviceTransportType = this.value;
			bool flag;
			return flag;
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x0000F6A4 File Offset: 0x0000D8A4
		public bool Equals(OptionalInputDeviceTransportType other)
		{
			/*
An exception occurred when decompiling this method (0600049F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean InControl.OptionalInputDeviceTransportType::Equals(InControl.OptionalInputDeviceTransportType)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:InputDeviceTransportType(var_1_08, ldfld:InputDeviceTransportType(OptionalInputDeviceTransportType::value, ldloc:valuetype InControl.OptionalInputDeviceTransportType&(this)))
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

		// Token: 0x060004A0 RID: 1184 RVA: 0x0000F6BC File Offset: 0x0000D8BC
		public bool Equals(InputDeviceTransportType other)
		{
			/*
An exception occurred when decompiling this method (060004A0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean InControl.OptionalInputDeviceTransportType::Equals(InControl.InputDeviceTransportType)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:InputDeviceTransportType(var_0_06, ldfld:InputDeviceTransportType(OptionalInputDeviceTransportType::value, ldloc:valuetype InControl.OptionalInputDeviceTransportType&(this)))
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

		// Token: 0x060004A1 RID: 1185 RVA: 0x000025E1 File Offset: 0x000007E1
		public static bool operator ==(OptionalInputDeviceTransportType a, OptionalInputDeviceTransportType b)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x000025E1 File Offset: 0x000007E1
		public static bool operator !=(OptionalInputDeviceTransportType a, OptionalInputDeviceTransportType b)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x000025E1 File Offset: 0x000007E1
		public static bool operator ==(OptionalInputDeviceTransportType a, InputDeviceTransportType b)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x000025E1 File Offset: 0x000007E1
		public static bool operator !=(OptionalInputDeviceTransportType a, InputDeviceTransportType b)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x000025E1 File Offset: 0x000007E1
		private static int CombineHashCodes(int h1, int h2)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x0000F6D4 File Offset: 0x0000D8D4
		public override int GetHashCode()
		{
			int num;
			return num;
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x0000F6E4 File Offset: 0x0000D8E4
		public override string ToString()
		{
			InputDeviceTransportType inputDeviceTransportType = this.value;
			string text;
			return text;
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x0000F700 File Offset: 0x0000D900
		public static implicit operator OptionalInputDeviceTransportType(InputDeviceTransportType value)
		{
			return 1;
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x0000F710 File Offset: 0x0000D910
		public static explicit operator InputDeviceTransportType(OptionalInputDeviceTransportType optional)
		{
			InputDeviceTransportType inputDeviceTransportType;
			return inputDeviceTransportType;
		}

		// Token: 0x040003E6 RID: 998
		[SerializeField]
		private bool hasValue;

		// Token: 0x040003E7 RID: 999
		[SerializeField]
		private InputDeviceTransportType value;
	}
}
