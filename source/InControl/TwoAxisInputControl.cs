using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

namespace InControl
{
	// Token: 0x02000027 RID: 39
	public class TwoAxisInputControl : IInputControl
	{
		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600019B RID: 411 RVA: 0x000052B0 File Offset: 0x000034B0
		// (set) Token: 0x0600019C RID: 412 RVA: 0x000052C4 File Offset: 0x000034C4
		public float X
		{
			[CompilerGenerated]
			get
			{
				/*
An exception occurred when decompiling this method (0600019B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single InControl.TwoAxisInputControl::get_X()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(TwoAxisInputControl::<X>k__BackingField, ldloc:TwoAxisInputControl(this)))
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
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600019D RID: 413 RVA: 0x000052D4 File Offset: 0x000034D4
		// (set) Token: 0x0600019E RID: 414 RVA: 0x000052E8 File Offset: 0x000034E8
		public float Y
		{
			[CompilerGenerated]
			get
			{
				/*
An exception occurred when decompiling this method (0600019D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single InControl.TwoAxisInputControl::get_Y()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(TwoAxisInputControl::<Y>k__BackingField, ldloc:TwoAxisInputControl(this)))
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
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600019F RID: 415 RVA: 0x000052F8 File Offset: 0x000034F8
		// (set) Token: 0x060001A0 RID: 416 RVA: 0x0000530C File Offset: 0x0000350C
		public OneAxisInputControl Left
		{
			[CompilerGenerated]
			get
			{
				return this.<Left>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				this.<Left>k__BackingField = value;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x00005320 File Offset: 0x00003520
		// (set) Token: 0x060001A2 RID: 418 RVA: 0x00005334 File Offset: 0x00003534
		public OneAxisInputControl Right
		{
			[CompilerGenerated]
			get
			{
				return this.<Right>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				this.<Right>k__BackingField = value;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x00005348 File Offset: 0x00003548
		// (set) Token: 0x060001A4 RID: 420 RVA: 0x0000535C File Offset: 0x0000355C
		public OneAxisInputControl Up
		{
			[CompilerGenerated]
			get
			{
				return this.<Up>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				this.<Up>k__BackingField = value;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x00005370 File Offset: 0x00003570
		// (set) Token: 0x060001A6 RID: 422 RVA: 0x00005384 File Offset: 0x00003584
		public OneAxisInputControl Down
		{
			[CompilerGenerated]
			get
			{
				return this.<Down>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				this.<Down>k__BackingField = value;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x00005398 File Offset: 0x00003598
		// (set) Token: 0x060001A8 RID: 424 RVA: 0x000053AC File Offset: 0x000035AC
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

		// Token: 0x060001A9 RID: 425 RVA: 0x000053C0 File Offset: 0x000035C0
		public TwoAxisInputControl()
		{
		}

		// Token: 0x060001AA RID: 426 RVA: 0x000053EC File Offset: 0x000035EC
		public void ClearInputState()
		{
			this.<Left>k__BackingField.wasRepeated = 256 != 0;
			this.<Right>k__BackingField.wasRepeated = 256 != 0;
			this.<Up>k__BackingField.wasRepeated = 256 != 0;
			this.<Down>k__BackingField.wasRepeated = 256 != 0;
			this.clearInputState = true;
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00005440 File Offset: 0x00003640
		public void Filter(TwoAxisInputControl twoAxisInputControl, float deltaTime)
		{
			float num = twoAxisInputControl.<X>k__BackingField;
			float num2 = twoAxisInputControl.<Y>k__BackingField;
			if (!true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00005464 File Offset: 0x00003664
		internal void UpdateWithAxes(float x, float y, ulong updateTick, float deltaTime)
		{
			bool flag = this.thisState;
			bool raw = this.Raw;
			this.lastState = flag;
			DeadZoneFunc deadZoneFunc;
			if (!raw)
			{
				deadZoneFunc = this.DeadZoneFunc;
				float num = this.lowerDeadZone;
				float num2 = this.upperDeadZone;
				IntPtr invoke_impl = deadZoneFunc.invoke_impl;
				IntPtr method_code = deadZoneFunc.method_code;
				IntPtr method = deadZoneFunc.method;
			}
			OneAxisInputControl oneAxisInputControl = this.<Left>k__BackingField;
			bool flag2 = oneAxisInputControl.UpdateWithValue(x, updateTick, y);
			oneAxisInputControl.Commit();
			float num3 = this.<X>k__BackingField;
			OneAxisInputControl oneAxisInputControl2 = this.<Right>k__BackingField;
			bool flag3 = oneAxisInputControl2.UpdateWithValue(x, updateTick, y);
			oneAxisInputControl2.Commit();
			if (deadZoneFunc == null)
			{
			}
			if (!true)
			{
			}
			OneAxisInputControl oneAxisInputControl3 = this.<Up>k__BackingField;
			float num4 = this.<Y>k__BackingField;
			if (true)
			{
				bool flag4 = oneAxisInputControl3.UpdateWithValue(x, updateTick, y);
				oneAxisInputControl3.Commit();
				float num5 = this.<Y>k__BackingField;
				return;
			}
			bool flag5 = oneAxisInputControl3.UpdateWithValue(x, updateTick, y);
			oneAxisInputControl3.Commit();
			float num6 = this.<Y>k__BackingField;
			OneAxisInputControl oneAxisInputControl4 = this.<Down>k__BackingField;
			bool flag6 = oneAxisInputControl4.UpdateWithValue(x, updateTick, y);
			oneAxisInputControl4.Commit();
			OneAxisInputControl oneAxisInputControl5 = this.<Up>k__BackingField;
			if (!oneAxisInputControl5.enabled || !oneAxisInputControl5.ownerEnabled || oneAxisInputControl5.thisState == null)
			{
				OneAxisInputControl oneAxisInputControl6 = this.<Down>k__BackingField;
				if (!oneAxisInputControl6.enabled || !oneAxisInputControl6.ownerEnabled || oneAxisInputControl6.thisState == null)
				{
					OneAxisInputControl oneAxisInputControl7 = this.<Left>k__BackingField;
					if (!oneAxisInputControl7.enabled || !oneAxisInputControl7.ownerEnabled || oneAxisInputControl7.thisState == null)
					{
						OneAxisInputControl oneAxisInputControl8 = this.<Right>k__BackingField;
						if (oneAxisInputControl8.enabled && oneAxisInputControl8.ownerEnabled)
						{
							InputControlState inputControlState = oneAxisInputControl8.thisState;
							return;
						}
						long num7 = 0L;
						bool flag7 = this.clearInputState;
						this.thisState = num7 != 0L;
						if (flag7)
						{
							this.lastState = num7 != 0L;
							return;
						}
						this.<UpdateTick>k__BackingField = updateTick;
						return;
					}
				}
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060001AD RID: 429 RVA: 0x00005624 File Offset: 0x00003824
		// (set) Token: 0x060001AE RID: 430 RVA: 0x00005638 File Offset: 0x00003838
		public float Sensitivity
		{
			get
			{
				/*
An exception occurred when decompiling this method (060001AD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single InControl.TwoAxisInputControl::get_Sensitivity()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(TwoAxisInputControl::sensitivity, ldloc:TwoAxisInputControl(this)))
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
				OneAxisInputControl oneAxisInputControl = this.<Left>k__BackingField;
				OneAxisInputControl oneAxisInputControl2 = this.<Right>k__BackingField;
				OneAxisInputControl oneAxisInputControl3 = this.<Up>k__BackingField;
				OneAxisInputControl oneAxisInputControl4 = this.<Down>k__BackingField;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060001AF RID: 431 RVA: 0x00005664 File Offset: 0x00003864
		// (set) Token: 0x060001B0 RID: 432 RVA: 0x00005678 File Offset: 0x00003878
		public float StateThreshold
		{
			get
			{
				/*
An exception occurred when decompiling this method (060001AF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single InControl.TwoAxisInputControl::get_StateThreshold()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(TwoAxisInputControl::stateThreshold, ldloc:TwoAxisInputControl(this)))
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
				OneAxisInputControl oneAxisInputControl = this.<Left>k__BackingField;
				OneAxisInputControl oneAxisInputControl2 = this.<Right>k__BackingField;
				OneAxisInputControl oneAxisInputControl3 = this.<Up>k__BackingField;
				OneAxisInputControl oneAxisInputControl4 = this.<Down>k__BackingField;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x000056A4 File Offset: 0x000038A4
		// (set) Token: 0x060001B2 RID: 434 RVA: 0x000056B8 File Offset: 0x000038B8
		public float LowerDeadZone
		{
			get
			{
				/*
An exception occurred when decompiling this method (060001B1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single InControl.TwoAxisInputControl::get_LowerDeadZone()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(TwoAxisInputControl::lowerDeadZone, ldloc:TwoAxisInputControl(this)))
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
				OneAxisInputControl oneAxisInputControl = this.<Left>k__BackingField;
				OneAxisInputControl oneAxisInputControl2 = this.<Right>k__BackingField;
				OneAxisInputControl oneAxisInputControl3 = this.<Up>k__BackingField;
				OneAxisInputControl oneAxisInputControl4 = this.<Down>k__BackingField;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x000056E4 File Offset: 0x000038E4
		// (set) Token: 0x060001B4 RID: 436 RVA: 0x000056F8 File Offset: 0x000038F8
		public float UpperDeadZone
		{
			get
			{
				/*
An exception occurred when decompiling this method (060001B3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single InControl.TwoAxisInputControl::get_UpperDeadZone()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(TwoAxisInputControl::upperDeadZone, ldloc:TwoAxisInputControl(this)))
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
				OneAxisInputControl oneAxisInputControl = this.<Left>k__BackingField;
				OneAxisInputControl oneAxisInputControl2 = this.<Right>k__BackingField;
				OneAxisInputControl oneAxisInputControl3 = this.<Up>k__BackingField;
				OneAxisInputControl oneAxisInputControl4 = this.<Down>k__BackingField;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x00005724 File Offset: 0x00003924
		public bool State
		{
			get
			{
				return this.thisState;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x00005738 File Offset: 0x00003938
		public bool LastState
		{
			get
			{
				return this.lastState;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x0000574C File Offset: 0x0000394C
		public Vector2 Value
		{
			get
			{
				float x = this.thisValue.x;
				float y = this.thisValue.y;
				Vector2 vector;
				return vector;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x00005774 File Offset: 0x00003974
		public Vector2 LastValue
		{
			get
			{
				float x = this.lastValue.x;
				float y = this.lastValue.y;
				Vector2 vector;
				return vector;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x0000579C File Offset: 0x0000399C
		public Vector2 Vector
		{
			get
			{
				float x = this.thisValue.x;
				float y = this.thisValue.y;
				Vector2 vector;
				return vector;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060001BA RID: 442 RVA: 0x000057C4 File Offset: 0x000039C4
		// (set) Token: 0x060001BB RID: 443 RVA: 0x000057D8 File Offset: 0x000039D8
		public bool HasChanged
		{
			[CompilerGenerated]
			get
			{
				return this.<HasChanged>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060001BC RID: 444 RVA: 0x000057E8 File Offset: 0x000039E8
		public bool IsPressed
		{
			get
			{
				return this.thisState;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060001BD RID: 445 RVA: 0x000057FC File Offset: 0x000039FC
		public bool WasPressed
		{
			get
			{
				if (this.thisState)
				{
					bool flag = this.lastState;
					return;
				}
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060001BE RID: 446 RVA: 0x0000581C File Offset: 0x00003A1C
		public bool WasReleased
		{
			get
			{
				while (!this.thisState)
				{
				}
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060001BF RID: 447 RVA: 0x00005834 File Offset: 0x00003A34
		public float Angle
		{
			get
			{
				float x = this.thisValue.x;
				float y = this.thisValue.y;
				if (!true)
				{
					return;
				}
			}
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x000025E1 File Offset: 0x000007E1
		public static implicit operator bool(TwoAxisInputControl instance)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00005860 File Offset: 0x00003A60
		public static implicit operator Vector2(TwoAxisInputControl instance)
		{
			float x = instance.thisValue.x;
			float y = instance.thisValue.y;
			Vector2 vector;
			return vector;
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00005888 File Offset: 0x00003A88
		public static implicit operator Vector3(TwoAxisInputControl instance)
		{
			float x = instance.thisValue.x;
			float y = instance.thisValue.y;
			Vector3 vector;
			return vector;
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x000058B0 File Offset: 0x00003AB0
		// Note: this type is marked as 'beforefieldinit'.
		static TwoAxisInputControl()
		{
		}

		// Token: 0x040001E5 RID: 485
		public static readonly TwoAxisInputControl Null;

		// Token: 0x040001E6 RID: 486
		[CompilerGenerated]
		private float <X>k__BackingField;

		// Token: 0x040001E7 RID: 487
		[CompilerGenerated]
		private float <Y>k__BackingField;

		// Token: 0x040001E8 RID: 488
		[CompilerGenerated]
		private OneAxisInputControl <Left>k__BackingField;

		// Token: 0x040001E9 RID: 489
		[CompilerGenerated]
		private OneAxisInputControl <Right>k__BackingField;

		// Token: 0x040001EA RID: 490
		[CompilerGenerated]
		private OneAxisInputControl <Up>k__BackingField;

		// Token: 0x040001EB RID: 491
		[CompilerGenerated]
		private OneAxisInputControl <Down>k__BackingField;

		// Token: 0x040001EC RID: 492
		[CompilerGenerated]
		private ulong <UpdateTick>k__BackingField;

		// Token: 0x040001ED RID: 493
		public DeadZoneFunc DeadZoneFunc;

		// Token: 0x040001EE RID: 494
		private float sensitivity = (float)16256;

		// Token: 0x040001EF RID: 495
		private float lowerDeadZone;

		// Token: 0x040001F0 RID: 496
		private float upperDeadZone = (float)16256;

		// Token: 0x040001F1 RID: 497
		private float stateThreshold;

		// Token: 0x040001F2 RID: 498
		public bool Raw;

		// Token: 0x040001F3 RID: 499
		private bool thisState;

		// Token: 0x040001F4 RID: 500
		private bool lastState;

		// Token: 0x040001F5 RID: 501
		private Vector2 thisValue;

		// Token: 0x040001F6 RID: 502
		private Vector2 lastValue;

		// Token: 0x040001F7 RID: 503
		private bool clearInputState;

		// Token: 0x040001F8 RID: 504
		[CompilerGenerated]
		private bool <HasChanged>k__BackingField;
	}
}
