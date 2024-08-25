using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace InControl
{
	// Token: 0x02000026 RID: 38
	public class OneAxisInputControl : IInputControl
	{
		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000174 RID: 372 RVA: 0x00004C50 File Offset: 0x00002E50
		// (set) Token: 0x06000175 RID: 373 RVA: 0x00004C64 File Offset: 0x00002E64
		public ulong UpdateTick
		{
			[CompilerGenerated]
			get
			{
				return this.<UpdateTick>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				this.<UpdateTick>k__BackingField = value;
			}
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00004C78 File Offset: 0x00002E78
		private void PrepareForUpdate(ulong updateTick)
		{
			while (!this.isNullControl)
			{
				ulong num = this.pendingTick;
				if (!this.pendingCommit)
				{
					float rawValue = this.thisState.RawValue;
					this.pendingTick = updateTick;
					this.lastState.RawValue = rawValue;
					this.pendingCommit = true;
					break;
				}
			}
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00004CC4 File Offset: 0x00002EC4
		public bool UpdateWithState(bool state, ulong updateTick, float deltaTime)
		{
			/*
An exception occurred when decompiling this method (06000177)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean InControl.OneAxisInputControl::UpdateWithState(System.Boolean,System.UInt64,System.Single)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0008:
	call:void(OneAxisInputControl::PrepareForUpdate, ldloc:OneAxisInputControl(this), ldloc:uint64(updateTick))
	stfld:InputControlState(OneAxisInputControl::nextState, ldloc:OneAxisInputControl(this), ldc.i4:int32[exp:InputControlState](1))
	brtrue(IL_0000, logicnot:bool(ldfld:InputControlState[exp:bool](OneAxisInputControl::nextState, ldloc:OneAxisInputControl(this))))
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

		// Token: 0x06000178 RID: 376 RVA: 0x00004CF0 File Offset: 0x00002EF0
		public bool UpdateWithValue(float value, ulong updateTick, float deltaTime)
		{
			bool flag = this.isNullControl;
			if (!flag)
			{
				this.PrepareForUpdate(updateTick);
				if (!flag)
				{
				}
				float num = Utility.Abs(value);
				float rawValue = this.nextState.RawValue;
				float num2 = Utility.Abs(deltaTime);
				bool raw = this.Raw;
				if (!raw)
				{
					float num3 = this.lowerDeadZone;
					float num4 = this.upperDeadZone;
					if (!raw)
					{
					}
					float num5 = Utility.ApplyDeadZone(value, deltaTime, num);
				}
				float num6 = this.stateThreshold;
				return;
			}
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00004D6C File Offset: 0x00002F6C
		internal bool UpdateWithRawValue(float value, ulong updateTick, float deltaTime)
		{
			if (!this.isNullControl)
			{
				int num = 1;
				this.Raw = num != 0;
				this.PrepareForUpdate(updateTick);
				if (num == 0)
				{
				}
				float num2 = Utility.Abs(value);
				float rawValue = this.nextState.RawValue;
				float num3 = Utility.Abs(deltaTime);
				float num4 = this.stateThreshold;
				return;
			}
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00004DC4 File Offset: 0x00002FC4
		internal void SetValue(float value, ulong updateTick)
		{
			if (this.isNullControl)
			{
				return;
			}
			ulong num = this.pendingTick;
			float rawValue = this.thisState.RawValue;
			int num2 = 1;
			this.pendingTick = updateTick;
			this.lastState.RawValue = rawValue;
			this.pendingCommit = num2 != 0;
			float num3 = this.stateThreshold;
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00004E10 File Offset: 0x00003010
		public void ClearInputState()
		{
			this.wasRepeated = 256 != 0;
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00004E28 File Offset: 0x00003028
		public void Commit()
		{
			if (!this.isNullControl)
			{
				InputControlState inputControlState = this.nextState;
				ulong num = this.pendingTick;
				return;
			}
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00004EC0 File Offset: 0x000030C0
		public void CommitWithState(bool state, ulong updateTick, float deltaTime)
		{
			if (!this.isNullControl)
			{
				this.PrepareForUpdate(updateTick);
				this.nextState = 1;
				return;
			}
			this.Commit();
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00004EF4 File Offset: 0x000030F4
		public void CommitWithValue(float value, ulong updateTick, float deltaTime)
		{
			bool flag = this.UpdateWithValue(value, updateTick, deltaTime);
			this.Commit();
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00004F14 File Offset: 0x00003114
		internal void CommitWithSides(InputControl negativeSide, InputControl positiveSide, ulong updateTick, float deltaTime)
		{
			float num = negativeSide.lowerDeadZone;
			float num2 = positiveSide.lowerDeadZone;
			this.lowerDeadZone = num;
			float num3 = negativeSide.upperDeadZone;
			float num4 = positiveSide.upperDeadZone;
			this.upperDeadZone = num3;
			if (negativeSide.Raw)
			{
				return;
			}
			bool raw = positiveSide.Raw;
			this.Raw = raw;
			if (negativeSide.enabled && negativeSide.ownerEnabled)
			{
				float rawValue = negativeSide.thisState.RawValue;
			}
			if (positiveSide.enabled && positiveSide.ownerEnabled)
			{
				float rawValue2 = positiveSide.thisState.RawValue;
			}
			this.Commit();
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000180 RID: 384 RVA: 0x00004FA8 File Offset: 0x000031A8
		public bool State
		{
			get
			{
				if (this.enabled && this.ownerEnabled)
				{
					InputControlState inputControlState = this.thisState;
					return;
				}
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000181 RID: 385 RVA: 0x00004FD0 File Offset: 0x000031D0
		public bool LastState
		{
			get
			{
				if (this.enabled && this.ownerEnabled)
				{
					InputControlState inputControlState = this.lastState;
					return;
				}
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000182 RID: 386 RVA: 0x00004FF8 File Offset: 0x000031F8
		public float Value
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000182)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single InControl.OneAxisInputControl::get_Value()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_1:
	stloc:float32(var_0_1B, ldfld:float32(InputControlState::Value, ldfld:InputControlState[exp:valuetype InControl.InputControlState&](OneAxisInputControl::thisState, ldloc:OneAxisInputControl(this))))
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

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000183 RID: 387 RVA: 0x00005020 File Offset: 0x00003220
		public float LastValue
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000183)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single InControl.OneAxisInputControl::get_LastValue()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_1:
	stloc:float32(var_0_1B, ldfld:float32(InputControlState::Value, ldfld:InputControlState[exp:valuetype InControl.InputControlState&](OneAxisInputControl::lastState, ldloc:OneAxisInputControl(this))))
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

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000184 RID: 388 RVA: 0x00005048 File Offset: 0x00003248
		public float RawValue
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000184)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single InControl.OneAxisInputControl::get_RawValue()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_1:
	stloc:float32(var_0_1B, ldfld:float32(InputControlState::RawValue, ldfld:InputControlState[exp:valuetype InControl.InputControlState&](OneAxisInputControl::thisState, ldloc:OneAxisInputControl(this))))
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

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000185 RID: 389 RVA: 0x00005070 File Offset: 0x00003270
		internal float NextRawValue
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000185)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single InControl.OneAxisInputControl::get_NextRawValue()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_1:
	stloc:float32(var_0_1B, ldfld:float32(InputControlState::RawValue, ldfld:InputControlState[exp:valuetype InControl.InputControlState&](OneAxisInputControl::nextState, ldloc:OneAxisInputControl(this))))
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

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000186 RID: 390 RVA: 0x00005098 File Offset: 0x00003298
		internal bool HasInput
		{
			get
			{
				if (this.enabled && this.ownerEnabled)
				{
					float value = this.thisState.Value;
					bool flag;
					return flag;
				}
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000187 RID: 391 RVA: 0x000050C8 File Offset: 0x000032C8
		public bool HasChanged
		{
			get
			{
				if (this.enabled && this.ownerEnabled)
				{
					float rawValue = this.thisState.RawValue;
					float rawValue2 = this.lastState.RawValue;
					bool flag;
					return flag;
				}
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000188 RID: 392 RVA: 0x00005100 File Offset: 0x00003300
		public bool IsPressed
		{
			get
			{
				if (this.enabled && this.ownerEnabled)
				{
					InputControlState inputControlState = this.thisState;
					return;
				}
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000189 RID: 393 RVA: 0x00005128 File Offset: 0x00003328
		public bool WasPressed
		{
			get
			{
				if (this.enabled && this.ownerEnabled)
				{
					InputControlState inputControlState = this.thisState;
					return;
				}
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600018A RID: 394 RVA: 0x00005150 File Offset: 0x00003350
		public bool WasReleased
		{
			get
			{
				if (this.enabled && this.ownerEnabled)
				{
					InputControlState inputControlState = this.thisState;
					InputControlState inputControlState2 = this.lastState;
					return;
				}
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600018B RID: 395 RVA: 0x0000517C File Offset: 0x0000337C
		public bool WasRepeated
		{
			get
			{
				if (this.enabled && this.ownerEnabled)
				{
					bool flag = this.wasRepeated;
					return;
				}
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x0600018C RID: 396 RVA: 0x000051A4 File Offset: 0x000033A4
		// (set) Token: 0x0600018D RID: 397 RVA: 0x000051B8 File Offset: 0x000033B8
		public float Sensitivity
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600018C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single InControl.OneAxisInputControl::get_Sensitivity()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(OneAxisInputControl::sensitivity, ldloc:OneAxisInputControl(this)))
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
			set
			{
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600018E RID: 398 RVA: 0x000051C8 File Offset: 0x000033C8
		// (set) Token: 0x0600018F RID: 399 RVA: 0x000051DC File Offset: 0x000033DC
		public float LowerDeadZone
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600018E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single InControl.OneAxisInputControl::get_LowerDeadZone()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(OneAxisInputControl::lowerDeadZone, ldloc:OneAxisInputControl(this)))
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
			set
			{
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000190 RID: 400 RVA: 0x000051EC File Offset: 0x000033EC
		// (set) Token: 0x06000191 RID: 401 RVA: 0x00005200 File Offset: 0x00003400
		public float UpperDeadZone
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000190)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single InControl.OneAxisInputControl::get_UpperDeadZone()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(OneAxisInputControl::upperDeadZone, ldloc:OneAxisInputControl(this)))
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
			set
			{
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000192 RID: 402 RVA: 0x00005210 File Offset: 0x00003410
		// (set) Token: 0x06000193 RID: 403 RVA: 0x00005224 File Offset: 0x00003424
		public float StateThreshold
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000192)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single InControl.OneAxisInputControl::get_StateThreshold()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(OneAxisInputControl::stateThreshold, ldloc:OneAxisInputControl(this)))
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
			set
			{
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000194 RID: 404 RVA: 0x00005234 File Offset: 0x00003434
		public bool IsNullControl
		{
			get
			{
				return this.isNullControl;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000195 RID: 405 RVA: 0x00005248 File Offset: 0x00003448
		// (set) Token: 0x06000196 RID: 406 RVA: 0x0000525C File Offset: 0x0000345C
		public bool Enabled
		{
			get
			{
				return this.enabled;
			}
			set
			{
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000197 RID: 407 RVA: 0x0000526C File Offset: 0x0000346C
		public bool EnabledInHierarchy
		{
			get
			{
				if (this.enabled)
				{
					bool flag = this.ownerEnabled;
					return;
				}
			}
		}

		// Token: 0x06000198 RID: 408 RVA: 0x0000528C File Offset: 0x0000348C
		public static implicit operator bool(OneAxisInputControl instance)
		{
		}

		// Token: 0x06000199 RID: 409 RVA: 0x000025E1 File Offset: 0x000007E1
		public static implicit operator float(OneAxisInputControl instance)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0000529C File Offset: 0x0000349C
		public OneAxisInputControl()
		{
		}

		// Token: 0x040001D2 RID: 466
		[CompilerGenerated]
		private ulong <UpdateTick>k__BackingField;

		// Token: 0x040001D3 RID: 467
		private float sensitivity;

		// Token: 0x040001D4 RID: 468
		private float lowerDeadZone;

		// Token: 0x040001D5 RID: 469
		private float upperDeadZone;

		// Token: 0x040001D6 RID: 470
		private float stateThreshold;

		// Token: 0x040001D7 RID: 471
		protected bool isNullControl;

		// Token: 0x040001D8 RID: 472
		public float FirstRepeatDelay;

		// Token: 0x040001D9 RID: 473
		public float RepeatDelay;

		// Token: 0x040001DA RID: 474
		public bool Raw;

		// Token: 0x040001DB RID: 475
		private bool enabled;

		// Token: 0x040001DC RID: 476
		protected bool ownerEnabled;

		// Token: 0x040001DD RID: 477
		private ulong pendingTick;

		// Token: 0x040001DE RID: 478
		private bool pendingCommit;

		// Token: 0x040001DF RID: 479
		private float nextRepeatTime;

		// Token: 0x040001E0 RID: 480
		private bool wasRepeated;

		// Token: 0x040001E1 RID: 481
		private bool clearInputState;

		// Token: 0x040001E2 RID: 482
		private InputControlState lastState;

		// Token: 0x040001E3 RID: 483
		private InputControlState nextState;

		// Token: 0x040001E4 RID: 484
		private InputControlState thisState;
	}
}
