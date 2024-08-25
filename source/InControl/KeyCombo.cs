using System;
using System.Collections.Generic;
using System.IO;
using Cpp2IlInjected;

namespace InControl
{
	// Token: 0x0200000C RID: 12
	public struct KeyCombo
	{
		// Token: 0x06000045 RID: 69 RVA: 0x00002748 File Offset: 0x00000948
		public KeyCombo(params Key[] keys)
		{
			long num = 0L;
			long num2 = 0L;
			this.includeSize = (int)num2;
			this.includeData = (ulong)num;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x0000276C File Offset: 0x0000096C
		private void AddIncludeInt(int key)
		{
			ulong num = this.includeData;
			this.includeData = num;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002788 File Offset: 0x00000988
		private int GetIncludeInt(int index)
		{
			/*
An exception occurred when decompiling this method (06000047)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 InControl.KeyCombo::GetIncludeInt(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint64(var_0_06, ldfld:uint64(KeyCombo::includeData, ldloc:valuetype InControl.KeyCombo&(this)))
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

		// Token: 0x06000048 RID: 72 RVA: 0x0000279C File Offset: 0x0000099C
		[Obsolete("Use KeyCombo.AddInclude instead.")]
		public void Add(Key key)
		{
			ulong num = this.includeData;
			this.includeData = num;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000027B8 File Offset: 0x000009B8
		[Obsolete("Use KeyCombo.GetInclude instead.")]
		public Key Get(int index)
		{
			return this.GetInclude(index);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000027CC File Offset: 0x000009CC
		public void AddInclude(Key key)
		{
			ulong num = this.includeData;
			this.includeData = num;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000027E8 File Offset: 0x000009E8
		public Key GetInclude(int index)
		{
			/*
An exception occurred when decompiling this method (0600004B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling InControl.Key InControl.KeyCombo::GetInclude(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint64(var_0_06, ldfld:uint64(KeyCombo::includeData, ldloc:valuetype InControl.KeyCombo&(this)))
	stloc:string(var_3_18, call:string(string::Concat, ldstr:string("Index "), ldloc:string(var_1), ldstr:string(" is out of the range 0.."), ldloc:string(var_2)))
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

		// Token: 0x0600004C RID: 76 RVA: 0x00002810 File Offset: 0x00000A10
		private void AddExcludeInt(int key)
		{
			int num = this.excludeSize;
			ulong num2 = this.excludeData;
			this.excludeData = num2;
			this.excludeSize = num;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x0000283C File Offset: 0x00000A3C
		private int GetExcludeInt(int index)
		{
			/*
An exception occurred when decompiling this method (0600004D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 InControl.KeyCombo::GetExcludeInt(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint64(var_0_06, ldfld:uint64(KeyCombo::excludeData, ldloc:valuetype InControl.KeyCombo&(this)))
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

		// Token: 0x0600004E RID: 78 RVA: 0x00002850 File Offset: 0x00000A50
		public void AddExclude(Key key)
		{
			int num = this.excludeSize;
			ulong num2 = this.excludeData;
			this.excludeData = num2;
			this.excludeSize = num;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x0000287C File Offset: 0x00000A7C
		public Key GetExclude(int index)
		{
			/*
An exception occurred when decompiling this method (0600004F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling InControl.Key InControl.KeyCombo::GetExclude(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(KeyCombo::excludeSize, ldloc:valuetype InControl.KeyCombo&(this)))
	stloc:uint64(var_1_0D, ldfld:uint64(KeyCombo::excludeData, ldloc:valuetype InControl.KeyCombo&(this)))
	stloc:string(var_4_1F, call:string(string::Concat, ldstr:string("Index "), ldloc:string(var_2), ldstr:string(" is out of the range 0.."), ldloc:string(var_3)))
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

		// Token: 0x06000050 RID: 80 RVA: 0x000028AC File Offset: 0x00000AAC
		public static KeyCombo With(params Key[] keys)
		{
			KeyCombo keyCombo;
			return keyCombo;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000028BC File Offset: 0x00000ABC
		public KeyCombo AndNot(params Key[] keys)
		{
			int num = this.excludeSize;
			ulong num2 = this.excludeData;
			this.excludeSize = num;
			int num3 = this.includeSize;
			KeyCombo keyCombo;
			keyCombo.includeSize = num3;
			return keyCombo;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000028F4 File Offset: 0x00000AF4
		public void Clear()
		{
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000053 RID: 83 RVA: 0x000025E1 File Offset: 0x000007E1
		[Obsolete("Use KeyCombo.IncludeCount instead.")]
		public int Count
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000054 RID: 84 RVA: 0x000025E1 File Offset: 0x000007E1
		public int IncludeCount
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00002904 File Offset: 0x00000B04
		public int ExcludeCount
		{
			get
			{
				return this.excludeSize;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000056 RID: 86 RVA: 0x00002918 File Offset: 0x00000B18
		public bool IsPressed
		{
			get
			{
				ulong num = this.includeData;
				bool flag;
				return flag;
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002958 File Offset: 0x00000B58
		public static KeyCombo Detect(bool modifiersAsKeys)
		{
			/*
An exception occurred when decompiling this method (06000057)

ICSharpCode.Decompiler.DecompilerException: Error decompiling InControl.KeyCombo InControl.KeyCombo::Detect(System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0007:
	stloc:int64(var_4_08, ldc.i4:int64(0))
	stfld:uint64(KeyCombo::includeData, ldloc:KeyCombo[exp:valuetype InControl.KeyCombo&](var_0), ldloc:int64[exp:uint64](var_4_08))
	stfld:uint64(KeyCombo::includeData, ldloc:KeyCombo[exp:valuetype InControl.KeyCombo&](var_0), ldloc:int64[exp:uint64](var_4_08))
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

		// Token: 0x06000058 RID: 88 RVA: 0x0000298C File Offset: 0x00000B8C
		public override string ToString()
		{
			if (!true)
			{
			}
			ulong num = this.includeData;
			string text;
			if (false)
			{
				text = "" + " ";
			}
			ulong num2 = this.includeData;
			string text2;
			return text + text2;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000029C4 File Offset: 0x00000BC4
		public static bool operator ==(KeyCombo a, KeyCombo b)
		{
			/*
An exception occurred when decompiling this method (06000059)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean InControl.KeyCombo::op_Equality(InControl.KeyCombo,InControl.KeyCombo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint64(var_0_06, ldfld:uint64(KeyCombo::includeData, ldloc:KeyCombo[exp:valuetype InControl.KeyCombo&](a)))
	stloc:uint64(var_1_0D, ldfld:uint64(KeyCombo::excludeData, ldloc:KeyCombo[exp:valuetype InControl.KeyCombo&](a)))
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

		// Token: 0x0600005A RID: 90 RVA: 0x000029E0 File Offset: 0x00000BE0
		public static bool operator !=(KeyCombo a, KeyCombo b)
		{
			ulong num = a.includeData;
			ulong num2 = a.excludeData;
			return true;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000029FC File Offset: 0x00000BFC
		public override bool Equals(object other)
		{
			if (other != null)
			{
				ulong num = this.includeData;
				ulong num2 = this.excludeData;
				return;
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002A1C File Offset: 0x00000C1C
		public override int GetHashCode()
		{
			int num;
			return num;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002A2C File Offset: 0x00000C2C
		internal void Load(BinaryReader reader, ushort dataFormatVersion)
		{
			this.includeSize = reader;
			this.includeData = reader;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002A70 File Offset: 0x00000C70
		internal void Save(BinaryWriter writer)
		{
			ulong num = this.includeData;
			int num2 = this.excludeSize;
			ulong num3 = this.excludeData;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002A94 File Offset: 0x00000C94
		// Note: this type is marked as 'beforefieldinit'.
		static KeyCombo()
		{
		}

		// Token: 0x040000A8 RID: 168
		private int includeSize;

		// Token: 0x040000A9 RID: 169
		private ulong includeData;

		// Token: 0x040000AA RID: 170
		private int excludeSize;

		// Token: 0x040000AB RID: 171
		private ulong excludeData;

		// Token: 0x040000AC RID: 172
		private static Dictionary<ulong, string> cachedStrings;
	}
}
