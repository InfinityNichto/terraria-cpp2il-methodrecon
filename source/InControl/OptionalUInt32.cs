using System;
using System.Globalization;
using Cpp2IlInjected;
using UnityEngine;

namespace InControl
{
	// Token: 0x0200006A RID: 106
	[Serializable]
	public struct OptionalUInt32
	{
		// Token: 0x060004E9 RID: 1257 RVA: 0x0000FAF8 File Offset: 0x0000DCF8
		public OptionalUInt32(uint value)
		{
			this.value = value;
			this.hasValue = true;
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x060004EA RID: 1258 RVA: 0x000025E1 File Offset: 0x000007E1
		public bool HasValue
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x060004EB RID: 1259 RVA: 0x000025E1 File Offset: 0x000007E1
		public bool HasNoValue
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x060004EC RID: 1260 RVA: 0x0000FB14 File Offset: 0x0000DD14
		// (set) Token: 0x060004ED RID: 1261 RVA: 0x0000FB28 File Offset: 0x0000DD28
		public uint Value
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

		// Token: 0x060004EE RID: 1262 RVA: 0x0000FB44 File Offset: 0x0000DD44
		public void Clear()
		{
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x0000FB54 File Offset: 0x0000DD54
		public uint GetValueOrDefault(uint defaultValue)
		{
			return this.value;
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x0000FB68 File Offset: 0x0000DD68
		public uint GetValueOrZero()
		{
			return this.value;
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x0000FB80 File Offset: 0x0000DD80
		public void SetValue(uint value)
		{
			this.hasValue = true;
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x0000FB94 File Offset: 0x0000DD94
		public override bool Equals(object other)
		{
			if (other == null)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x0000FBA8 File Offset: 0x0000DDA8
		public bool Equals(OptionalUInt32 other)
		{
			/*
An exception occurred when decompiling this method (060004F3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean InControl.OptionalUInt32::Equals(InControl.OptionalUInt32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint32(var_1_08, ldfld:uint32(OptionalUInt32::value, ldloc:valuetype InControl.OptionalUInt32&(this)))
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

		// Token: 0x060004F4 RID: 1268 RVA: 0x0000FBC0 File Offset: 0x0000DDC0
		public bool Equals(uint other)
		{
			/*
An exception occurred when decompiling this method (060004F4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean InControl.OptionalUInt32::Equals(System.UInt32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint32(var_0_06, ldfld:uint32(OptionalUInt32::value, ldloc:valuetype InControl.OptionalUInt32&(this)))
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

		// Token: 0x060004F5 RID: 1269 RVA: 0x0000FBD4 File Offset: 0x0000DDD4
		public static bool operator ==(OptionalUInt32 a, OptionalUInt32 b)
		{
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x0000FBE4 File Offset: 0x0000DDE4
		public static bool operator !=(OptionalUInt32 a, OptionalUInt32 b)
		{
			return true;
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x000025E1 File Offset: 0x000007E1
		public static bool operator ==(OptionalUInt32 a, uint b)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x000025E1 File Offset: 0x000007E1
		public static bool operator !=(OptionalUInt32 a, uint b)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x000025E1 File Offset: 0x000007E1
		private static int CombineHashCodes(int h1, int h2)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x0000FBF4 File Offset: 0x0000DDF4
		public override int GetHashCode()
		{
			int num;
			return num;
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x0000FC04 File Offset: 0x0000DE04
		public override string ToString()
		{
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			string text;
			return text;
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x0000FC20 File Offset: 0x0000DE20
		public static implicit operator OptionalUInt32(uint value)
		{
			return 1;
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x0000FC30 File Offset: 0x0000DE30
		public static explicit operator uint(OptionalUInt32 optional)
		{
			uint num;
			return num;
		}

		// Token: 0x040003EE RID: 1006
		[SerializeField]
		private bool hasValue;

		// Token: 0x040003EF RID: 1007
		[SerializeField]
		private uint value;
	}
}
