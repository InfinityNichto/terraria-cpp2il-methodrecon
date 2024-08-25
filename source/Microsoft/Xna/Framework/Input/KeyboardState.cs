using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Input
{
	// Token: 0x02000351 RID: 849
	public struct KeyboardState
	{
		// Token: 0x060015CD RID: 5581 RVA: 0x0006123C File Offset: 0x0005F43C
		private bool InternalGetKey(Keys key)
		{
			/*
An exception occurred when decompiling this method (060015CD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Microsoft.Xna.Framework.Input.KeyboardState::InternalGetKey(Microsoft.Xna.Framework.Input.Keys)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_1_07, callgetter:bool(ControllerActionManager::get_AnyControllerConnected))
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

		// Token: 0x060015CE RID: 5582 RVA: 0x00061254 File Offset: 0x0005F454
		internal void InternalSetKey(Keys key)
		{
		}

		// Token: 0x060015CF RID: 5583 RVA: 0x00061268 File Offset: 0x0005F468
		internal void InternalClearKey(Keys key)
		{
		}

		// Token: 0x060015D0 RID: 5584 RVA: 0x0006127C File Offset: 0x0005F47C
		internal void InternalClearAllKeys()
		{
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x060015D1 RID: 5585 RVA: 0x0006128C File Offset: 0x0005F48C
		// (set) Token: 0x060015D2 RID: 5586 RVA: 0x000612A0 File Offset: 0x0005F4A0
		public bool CapsLock
		{
			[CompilerGenerated]
			readonly get
			{
				return this.<CapsLock>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x060015D3 RID: 5587 RVA: 0x000612B0 File Offset: 0x0005F4B0
		// (set) Token: 0x060015D4 RID: 5588 RVA: 0x000612C4 File Offset: 0x0005F4C4
		public bool NumLock
		{
			[CompilerGenerated]
			readonly get
			{
				return this.<NumLock>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060015D5 RID: 5589 RVA: 0x000612D4 File Offset: 0x0005F4D4
		internal KeyboardState(List<Keys> keys, bool capsLock = false, bool numLock = false)
		{
			this.<CapsLock>k__BackingField = true;
			if (keys != null)
			{
				return;
			}
		}

		// Token: 0x060015D6 RID: 5590 RVA: 0x00061300 File Offset: 0x0005F500
		public KeyboardState(Keys[] keys, bool capsLock = false, bool numLock = false)
		{
			if (keys != null)
			{
				this.InternalSetKey(keys);
			}
		}

		// Token: 0x060015D7 RID: 5591 RVA: 0x0006131C File Offset: 0x0005F51C
		public KeyboardState(params Keys[] keys)
		{
			if (keys != null)
			{
				this.InternalSetKey(keys);
			}
		}

		// Token: 0x17000267 RID: 615
		public KeyState this[Keys key]
		{
			get
			{
				/*
An exception occurred when decompiling this method (060015D8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Input.KeyState Microsoft.Xna.Framework.Input.KeyboardState::get_Item(Microsoft.Xna.Framework.Input.Keys)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_0_07, call:bool(KeyboardState::InternalGetKey, ldloc:valuetype Microsoft.Xna.Framework.Input.KeyboardState&(this), ldloc:Keys(key)))
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

		// Token: 0x060015D9 RID: 5593 RVA: 0x0006134C File Offset: 0x0005F54C
		public bool IsKeyDown(Keys key)
		{
			return this.InternalGetKey(key);
		}

		// Token: 0x060015DA RID: 5594 RVA: 0x00061360 File Offset: 0x0005F560
		public bool IsKeyUp(Keys key)
		{
			return this.InternalGetKey(key);
		}

		// Token: 0x060015DB RID: 5595 RVA: 0x000021DB File Offset: 0x000003DB
		private static uint CountBits(uint v)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060015DC RID: 5596 RVA: 0x00061374 File Offset: 0x0005F574
		private static int AddKeysToArray(uint keys, int offset, Keys[] pressedKeys, int index)
		{
		}

		// Token: 0x060015DD RID: 5597 RVA: 0x00061384 File Offset: 0x0005F584
		public Keys[] GetPressedKeys()
		{
			long num9;
			do
			{
				if (!true)
				{
				}
				uint num = this.keys1;
				uint num2 = this.keys6;
				long num3 = 0L;
				uint num4 = this.keys1;
				long num5;
				if (num4 != 0U)
				{
					if (num3 == 0L)
					{
					}
					num5 = 0L;
				}
				if (num4 == 0U || num5 == 0L)
				{
				}
				long num6;
				if (this.keys3 != 0U)
				{
					if (num5 == 0L)
					{
					}
					num6 = 0L;
				}
				long num7;
				if (this.keys4 != 0U)
				{
					if (num6 == 0L)
					{
					}
					num7 = 0L;
				}
				long num8;
				if (this.keys5 != 0U)
				{
					if (num7 == 0L)
					{
					}
					num8 = 0L;
				}
				if (this.keys6 != 0U)
				{
					if (num8 == 0L)
					{
					}
					num9 = 0L;
				}
			}
			while (this.keys7 == 0U);
			if (num9 == 0L)
			{
				return;
			}
		}

		// Token: 0x060015DE RID: 5598 RVA: 0x00061408 File Offset: 0x0005F608
		public override int GetHashCode()
		{
			/*
An exception occurred when decompiling this method (060015DE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Microsoft.Xna.Framework.Input.KeyboardState::GetHashCode()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint32(var_0_06, ldfld:uint32(KeyboardState::keys0, ldloc:valuetype Microsoft.Xna.Framework.Input.KeyboardState&(this)))
	stloc:uint32(var_1_0D, ldfld:uint32(KeyboardState::keys2, ldloc:valuetype Microsoft.Xna.Framework.Input.KeyboardState&(this)))
	stloc:uint32(var_2_14, ldfld:uint32(KeyboardState::keys2, ldloc:valuetype Microsoft.Xna.Framework.Input.KeyboardState&(this)))
	stloc:uint32(var_3_1B, ldfld:uint32(KeyboardState::keys4, ldloc:valuetype Microsoft.Xna.Framework.Input.KeyboardState&(this)))
	stloc:uint32(var_4_22, ldfld:uint32(KeyboardState::keys4, ldloc:valuetype Microsoft.Xna.Framework.Input.KeyboardState&(this)))
	stloc:uint32(var_5_2A, ldfld:uint32(KeyboardState::keys6, ldloc:valuetype Microsoft.Xna.Framework.Input.KeyboardState&(this)))
	stloc:uint32(var_6_32, ldfld:uint32(KeyboardState::keys6, ldloc:valuetype Microsoft.Xna.Framework.Input.KeyboardState&(this)))
	stloc:bool(var_7_3A, ldfld:bool(KeyboardState::<CapsLock>k__BackingField, ldloc:valuetype Microsoft.Xna.Framework.Input.KeyboardState&(this)))
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

		// Token: 0x060015DF RID: 5599 RVA: 0x00061450 File Offset: 0x0005F650
		public static bool operator ==(KeyboardState a, KeyboardState b)
		{
			/*
An exception occurred when decompiling this method (060015DF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Microsoft.Xna.Framework.Input.KeyboardState::op_Equality(Microsoft.Xna.Framework.Input.KeyboardState,Microsoft.Xna.Framework.Input.KeyboardState)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint32(var_0_06, ldfld:uint32(KeyboardState::keys1, ldloc:KeyboardState[exp:valuetype Microsoft.Xna.Framework.Input.KeyboardState&](a)))
	stloc:uint32(var_1_0D, ldfld:uint32(KeyboardState::keys2, ldloc:KeyboardState[exp:valuetype Microsoft.Xna.Framework.Input.KeyboardState&](a)))
	stloc:uint32(var_2_14, ldfld:uint32(KeyboardState::keys3, ldloc:KeyboardState[exp:valuetype Microsoft.Xna.Framework.Input.KeyboardState&](a)))
	stloc:uint32(var_3_1B, ldfld:uint32(KeyboardState::keys4, ldloc:KeyboardState[exp:valuetype Microsoft.Xna.Framework.Input.KeyboardState&](a)))
	stloc:uint32(var_4_22, ldfld:uint32(KeyboardState::keys5, ldloc:KeyboardState[exp:valuetype Microsoft.Xna.Framework.Input.KeyboardState&](a)))
	stloc:uint32(var_5_2A, ldfld:uint32(KeyboardState::keys6, ldloc:KeyboardState[exp:valuetype Microsoft.Xna.Framework.Input.KeyboardState&](a)))
	stloc:uint32(var_6_32, ldfld:uint32(KeyboardState::keys7, ldloc:KeyboardState[exp:valuetype Microsoft.Xna.Framework.Input.KeyboardState&](a)))
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

		// Token: 0x060015E0 RID: 5600 RVA: 0x00061494 File Offset: 0x0005F694
		public static bool operator !=(KeyboardState a, KeyboardState b)
		{
			/*
An exception occurred when decompiling this method (060015E0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Microsoft.Xna.Framework.Input.KeyboardState::op_Inequality(Microsoft.Xna.Framework.Input.KeyboardState,Microsoft.Xna.Framework.Input.KeyboardState)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	stloc:uint32(var_0_06, ldfld:uint32(KeyboardState::keys0, ldloc:KeyboardState[exp:valuetype Microsoft.Xna.Framework.Input.KeyboardState&](a)))
	stloc:uint32(var_1_0D, ldfld:uint32(KeyboardState::keys2, ldloc:KeyboardState[exp:valuetype Microsoft.Xna.Framework.Input.KeyboardState&](a)))
	stloc:uint32(var_2_14, ldfld:uint32(KeyboardState::keys2, ldloc:KeyboardState[exp:valuetype Microsoft.Xna.Framework.Input.KeyboardState&](a)))
	stloc:uint32(var_3_1B, ldfld:uint32(KeyboardState::keys4, ldloc:KeyboardState[exp:valuetype Microsoft.Xna.Framework.Input.KeyboardState&](a)))
	stloc:uint32(var_4_22, ldfld:uint32(KeyboardState::keys4, ldloc:KeyboardState[exp:valuetype Microsoft.Xna.Framework.Input.KeyboardState&](a)))
	stloc:uint32(var_5_2A, ldfld:uint32(KeyboardState::keys6, ldloc:KeyboardState[exp:valuetype Microsoft.Xna.Framework.Input.KeyboardState&](a)))
	stloc:uint32(var_6_32, ldfld:uint32(KeyboardState::keys6, ldloc:KeyboardState[exp:valuetype Microsoft.Xna.Framework.Input.KeyboardState&](a)))
	stloc:bool(var_7_3A, ldfld:bool(KeyboardState::<CapsLock>k__BackingField, ldloc:KeyboardState[exp:valuetype Microsoft.Xna.Framework.Input.KeyboardState&](a)))
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x060015E1 RID: 5601 RVA: 0x000614E0 File Offset: 0x0005F6E0
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
			}
			uint num = this.keys0;
			uint num2 = this.keys2;
			uint num3 = this.keys2;
			uint num4 = this.keys4;
			uint num5 = this.keys4;
			uint num6 = this.keys6;
			uint num7 = this.keys6;
			bool flag = this.<CapsLock>k__BackingField;
			throw new InvalidCastException();
		}

		// Token: 0x060015E2 RID: 5602 RVA: 0x00061538 File Offset: 0x0005F738
		// Note: this type is marked as 'beforefieldinit'.
		static KeyboardState()
		{
		}

		// Token: 0x04002339 RID: 9017
		private static Keys[] empty;

		// Token: 0x0400233A RID: 9018
		private uint keys0;

		// Token: 0x0400233B RID: 9019
		private uint keys1;

		// Token: 0x0400233C RID: 9020
		private uint keys2;

		// Token: 0x0400233D RID: 9021
		private uint keys3;

		// Token: 0x0400233E RID: 9022
		private uint keys4;

		// Token: 0x0400233F RID: 9023
		private uint keys5;

		// Token: 0x04002340 RID: 9024
		private uint keys6;

		// Token: 0x04002341 RID: 9025
		private uint keys7;

		// Token: 0x04002342 RID: 9026
		[CompilerGenerated]
		private bool <CapsLock>k__BackingField;

		// Token: 0x04002343 RID: 9027
		[CompilerGenerated]
		private bool <NumLock>k__BackingField;

		// Token: 0x04002344 RID: 9028
		private static Keys[] keysArray1;

		// Token: 0x04002345 RID: 9029
		private static Keys[] keysArray2;

		// Token: 0x04002346 RID: 9030
		private static Keys[] keysArray3;

		// Token: 0x04002347 RID: 9031
		private static Keys[] keysArray4;

		// Token: 0x04002348 RID: 9032
		private static Keys[] keysArray5;

		// Token: 0x04002349 RID: 9033
		private static Keys[] keysArray6;

		// Token: 0x0400234A RID: 9034
		private static Keys[] keysArray7;

		// Token: 0x0400234B RID: 9035
		private static Keys[] keysArray8;
	}
}
