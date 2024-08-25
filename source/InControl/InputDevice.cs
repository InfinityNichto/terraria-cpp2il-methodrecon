using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

namespace InControl
{
	// Token: 0x0200002C RID: 44
	public class InputDevice
	{
		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060001CD RID: 461 RVA: 0x00005984 File Offset: 0x00003B84
		// (set) Token: 0x060001CE RID: 462 RVA: 0x00005998 File Offset: 0x00003B98
		public string Name
		{
			[CompilerGenerated]
			get
			{
				return this.<Name>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				this.<Name>k__BackingField = value;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060001CF RID: 463 RVA: 0x000059AC File Offset: 0x00003BAC
		// (set) Token: 0x060001D0 RID: 464 RVA: 0x000059C0 File Offset: 0x00003BC0
		public string Meta
		{
			[CompilerGenerated]
			get
			{
				return this.<Meta>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				this.<Meta>k__BackingField = value;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x000059D4 File Offset: 0x00003BD4
		// (set) Token: 0x060001D2 RID: 466 RVA: 0x000059E8 File Offset: 0x00003BE8
		public int SortOrder
		{
			[CompilerGenerated]
			get
			{
				return this.<SortOrder>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				this.<SortOrder>k__BackingField = value;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x000059FC File Offset: 0x00003BFC
		// (set) Token: 0x060001D4 RID: 468 RVA: 0x00005A10 File Offset: 0x00003C10
		public InputDeviceClass DeviceClass
		{
			[CompilerGenerated]
			get
			{
				return this.<DeviceClass>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				this.<DeviceClass>k__BackingField = value;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x00005A24 File Offset: 0x00003C24
		// (set) Token: 0x060001D6 RID: 470 RVA: 0x00005A38 File Offset: 0x00003C38
		public InputDeviceStyle DeviceStyle
		{
			[CompilerGenerated]
			get
			{
				return this.<DeviceStyle>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				this.<DeviceStyle>k__BackingField = value;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x000025E1 File Offset: 0x000007E1
		// (set) Token: 0x060001D8 RID: 472 RVA: 0x00005A4C File Offset: 0x00003C4C
		public Guid GUID
		{
			[CompilerGenerated]
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x00005A5C File Offset: 0x00003C5C
		// (set) Token: 0x060001DA RID: 474 RVA: 0x00005A70 File Offset: 0x00003C70
		public ulong LastInputTick
		{
			[CompilerGenerated]
			get
			{
				return this.<LastInputTick>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<LastInputTick>k__BackingField = value;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060001DB RID: 475 RVA: 0x00005A84 File Offset: 0x00003C84
		// (set) Token: 0x060001DC RID: 476 RVA: 0x00005A98 File Offset: 0x00003C98
		public bool IsActive
		{
			[CompilerGenerated]
			get
			{
				return this.<IsActive>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060001DD RID: 477 RVA: 0x00005AA8 File Offset: 0x00003CA8
		// (set) Token: 0x060001DE RID: 478 RVA: 0x00005ABC File Offset: 0x00003CBC
		public bool IsAttached
		{
			[CompilerGenerated]
			get
			{
				return this.<IsAttached>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060001DF RID: 479 RVA: 0x00005ACC File Offset: 0x00003CCC
		// (set) Token: 0x060001E0 RID: 480 RVA: 0x00005AE0 File Offset: 0x00003CE0
		private protected bool RawSticks
		{
			[CompilerGenerated]
			protected get
			{
				return this.<RawSticks>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060001E1 RID: 481 RVA: 0x00005AF0 File Offset: 0x00003CF0
		// (set) Token: 0x060001E2 RID: 482 RVA: 0x00005B04 File Offset: 0x00003D04
		public ReadOnlyCollection<InputControl> Controls
		{
			[CompilerGenerated]
			get
			{
				return this.<Controls>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				this.<Controls>k__BackingField = value;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x00005B18 File Offset: 0x00003D18
		// (set) Token: 0x060001E4 RID: 484 RVA: 0x00005B2C File Offset: 0x00003D2C
		private protected InputControl[] ControlsByTarget
		{
			[CompilerGenerated]
			protected get
			{
				return this.<ControlsByTarget>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<ControlsByTarget>k__BackingField = value;
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x00005B40 File Offset: 0x00003D40
		// (set) Token: 0x060001E6 RID: 486 RVA: 0x00005B54 File Offset: 0x00003D54
		public TwoAxisInputControl LeftStick
		{
			[CompilerGenerated]
			get
			{
				return this.<LeftStick>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<LeftStick>k__BackingField = value;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060001E7 RID: 487 RVA: 0x00005B68 File Offset: 0x00003D68
		// (set) Token: 0x060001E8 RID: 488 RVA: 0x00005B7C File Offset: 0x00003D7C
		public TwoAxisInputControl RightStick
		{
			[CompilerGenerated]
			get
			{
				return this.<RightStick>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<RightStick>k__BackingField = value;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x00005B90 File Offset: 0x00003D90
		// (set) Token: 0x060001EA RID: 490 RVA: 0x00005BA4 File Offset: 0x00003DA4
		public TwoAxisInputControl DPad
		{
			[CompilerGenerated]
			get
			{
				return this.<DPad>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<DPad>k__BackingField = value;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060001EB RID: 491 RVA: 0x00005BB8 File Offset: 0x00003DB8
		// (set) Token: 0x060001EC RID: 492 RVA: 0x00005BCC File Offset: 0x00003DCC
		protected InputDevice.AnalogSnapshotEntry[] AnalogSnapshot
		{
			[CompilerGenerated]
			get
			{
				return this.<AnalogSnapshot>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<AnalogSnapshot>k__BackingField = value;
			}
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00005BE0 File Offset: 0x00003DE0
		public InputDevice()
		{
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00005BF0 File Offset: 0x00003DF0
		public InputDevice(string name)
		{
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00005C00 File Offset: 0x00003E00
		public InputDevice(string name, bool rawSticks)
		{
			this.<RawSticks>k__BackingField = true;
			this.Name = name;
			this.Meta = "";
			Guid guid = Guid.NewGuid();
			this.RemoveAliasControls();
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00005C3C File Offset: 0x00003E3C
		internal void OnAttached()
		{
			this.<IsAttached>k__BackingField = true;
			this.AddAliasControls();
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00005C58 File Offset: 0x00003E58
		internal void OnDetached()
		{
			this.RemoveAliasControls();
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00005C6C File Offset: 0x00003E6C
		protected void AddAliasControls()
		{
			this.RemoveAliasControls();
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00005C84 File Offset: 0x00003E84
		private void RemoveAliasControls()
		{
			if (!true)
			{
			}
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x000025E1 File Offset: 0x000007E1
		protected void ClearControls()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00005C94 File Offset: 0x00003E94
		public bool HasControl(InputControlType controlType)
		{
			/*
An exception occurred when decompiling this method (060001F5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean InControl.InputDevice::HasControl(InControl.InputControlType)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_0B, ldfld:float32(OneAxisInputControl::upperDeadZone, ldfld:class InControl.InputControl[][exp:OneAxisInputControl](InputDevice::<ControlsByTarget>k__BackingField, ldloc:InputDevice(this))))
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

		// Token: 0x060001F6 RID: 502 RVA: 0x00005CAC File Offset: 0x00003EAC
		public InputControl GetControl(InputControlType controlType)
		{
			/*
An exception occurred when decompiling this method (060001F6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling InControl.InputControl InControl.InputDevice::GetControl(InControl.InputControlType)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	brtrue(IL_0000, ldloc:class InControl.InputControl[][exp:bool](var_0_06))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
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

		// Token: 0x1700009B RID: 155
		public InputControl this[InputControlType controlType]
		{
			get
			{
				return this.GetControl(controlType);
			}
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00005CE0 File Offset: 0x00003EE0
		public static InputControlType GetInputControlTypeByName(string inputControlName)
		{
			if (!true)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00005CF8 File Offset: 0x00003EF8
		public InputControl GetControlByName(string controlName)
		{
			if (!true)
			{
			}
			InputControlType inputControlTypeByName = InputDevice.GetInputControlTypeByName(controlName);
			return this.GetControl(inputControlTypeByName);
		}

		// Token: 0x060001FA RID: 506 RVA: 0x000025E1 File Offset: 0x000007E1
		public InputControl AddControl(InputControlType controlType, string handle)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00005D18 File Offset: 0x00003F18
		public InputControl AddControl(InputControlType controlType, string handle, float lowerDeadZone, float upperDeadZone)
		{
			return this.AddControl(controlType, handle);
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00005D30 File Offset: 0x00003F30
		private void RemoveControl(InputControlType controlType)
		{
			if (this.<ControlsByTarget>k__BackingField.upperDeadZone != null)
			{
				List<InputControl> list = this.controls;
				return;
			}
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00005D54 File Offset: 0x00003F54
		public void ClearInputState()
		{
			this.<LeftStick>k__BackingField.ClearInputState();
			this.<RightStick>k__BackingField.ClearInputState();
			this.<DPad>k__BackingField.ClearInputState();
			ReadOnlyCollection<InputControl> readOnlyCollection = this.<Controls>k__BackingField;
			if (this.<Controls>k__BackingField != null)
			{
			}
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00005D9C File Offset: 0x00003F9C
		protected void UpdateWithState(InputControlType controlType, bool state, ulong updateTick, float deltaTime)
		{
			InputControl control = this.GetControl(controlType);
			if (!control.isNullControl)
			{
				control.PrepareForUpdate(updateTick);
				control.nextState = 1;
				return;
			}
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00005DD4 File Offset: 0x00003FD4
		protected void UpdateWithValue(InputControlType controlType, float value, ulong updateTick, float deltaTime)
		{
			bool flag = this.GetControl(controlType).UpdateWithValue(value, updateTick, deltaTime);
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00005DF4 File Offset: 0x00003FF4
		public void UpdateLeftStickWithValue(Vector2 value, ulong updateTick, float deltaTime)
		{
			if (this.cachedLeftStickLeft == null)
			{
				InputControl control = this.GetControl(InputControlType.LeftStickLeft);
				this.cachedLeftStickLeft = control;
			}
			if (this.cachedLeftStickRight == null)
			{
				InputControl control2 = this.GetControl(InputControlType.LeftStickRight);
				this.cachedLeftStickRight = control2;
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (this.cachedLeftStickUp != null)
			{
				if (this.cachedLeftStickDown == null)
				{
					InputControl control3 = this.GetControl(InputControlType.LeftStickDown);
					this.cachedLeftStickDown = control3;
					return;
				}
			}
			else
			{
				InputControl control4 = this.GetControl(InputControlType.LeftStickUp);
				this.cachedLeftStickUp = control4;
				if (this.cachedLeftStickDown == null)
				{
					InputControl control5 = this.GetControl(InputControlType.LeftStickDown);
					this.cachedLeftStickDown = control5;
				}
			}
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00005E84 File Offset: 0x00004084
		public void UpdateLeftStickWithRawValue(Vector2 value, ulong updateTick, float deltaTime)
		{
			if (this.cachedLeftStickLeft == null)
			{
				InputControl control = this.GetControl(InputControlType.LeftStickLeft);
				this.cachedLeftStickLeft = control;
			}
			if (this.cachedLeftStickRight == null)
			{
				InputControl control2 = this.GetControl(InputControlType.LeftStickRight);
				this.cachedLeftStickRight = control2;
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (this.cachedLeftStickUp != null)
			{
				if (this.cachedLeftStickDown == null)
				{
					InputControl control3 = this.GetControl(InputControlType.LeftStickDown);
					this.cachedLeftStickDown = control3;
					return;
				}
			}
			else
			{
				InputControl control4 = this.GetControl(InputControlType.LeftStickUp);
				this.cachedLeftStickUp = control4;
				if (this.cachedLeftStickDown == null)
				{
					InputControl control5 = this.GetControl(InputControlType.LeftStickDown);
					this.cachedLeftStickDown = control5;
				}
			}
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00005F14 File Offset: 0x00004114
		public void CommitLeftStick()
		{
			InputControl control;
			if (this.cachedLeftStickUp == null)
			{
				control = this.GetControl(InputControlType.LeftStickUp);
				this.cachedLeftStickUp = control;
			}
			control.Commit();
			InputControl control2;
			if (this.cachedLeftStickDown == null)
			{
				control2 = this.GetControl(InputControlType.LeftStickDown);
				this.cachedLeftStickDown = control2;
			}
			control2.Commit();
			InputControl control3;
			if (this.cachedLeftStickLeft == null)
			{
				control3 = this.GetControl(InputControlType.LeftStickLeft);
				this.cachedLeftStickLeft = control3;
			}
			control3.Commit();
			InputControl control4;
			if (this.cachedLeftStickRight == null)
			{
				control4 = this.GetControl(InputControlType.LeftStickRight);
				this.cachedLeftStickRight = control4;
			}
			control4.Commit();
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00005F98 File Offset: 0x00004198
		public void UpdateRightStickWithValue(Vector2 value, ulong updateTick, float deltaTime)
		{
			if (this.cachedRightStickLeft == null)
			{
				InputControl control = this.GetControl(InputControlType.RightStickLeft);
				this.cachedRightStickLeft = control;
			}
			if (this.cachedRightStickRight == null)
			{
				InputControl control2 = this.GetControl(InputControlType.RightStickRight);
				this.cachedRightStickRight = control2;
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (this.cachedRightStickUp != null)
			{
				if (this.cachedRightStickDown == null)
				{
					InputControl control3 = this.GetControl(InputControlType.RightStickDown);
					this.cachedRightStickDown = control3;
					return;
				}
			}
			else
			{
				InputControl control4 = this.GetControl(InputControlType.RightStickUp);
				this.cachedRightStickUp = control4;
				if (this.cachedRightStickDown == null)
				{
					InputControl control5 = this.GetControl(InputControlType.RightStickDown);
					this.cachedRightStickDown = control5;
				}
			}
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00006028 File Offset: 0x00004228
		public void UpdateRightStickWithRawValue(Vector2 value, ulong updateTick, float deltaTime)
		{
			if (this.cachedRightStickLeft == null)
			{
				InputControl control = this.GetControl(InputControlType.RightStickLeft);
				this.cachedRightStickLeft = control;
			}
			if (this.cachedRightStickRight == null)
			{
				InputControl control2 = this.GetControl(InputControlType.RightStickRight);
				this.cachedRightStickRight = control2;
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (this.cachedRightStickUp != null)
			{
				if (this.cachedRightStickDown == null)
				{
					InputControl control3 = this.GetControl(InputControlType.RightStickDown);
					this.cachedRightStickDown = control3;
					return;
				}
			}
			else
			{
				InputControl control4 = this.GetControl(InputControlType.RightStickUp);
				this.cachedRightStickUp = control4;
				if (this.cachedRightStickDown == null)
				{
					InputControl control5 = this.GetControl(InputControlType.RightStickDown);
					this.cachedRightStickDown = control5;
				}
			}
		}

		// Token: 0x06000205 RID: 517 RVA: 0x000060B8 File Offset: 0x000042B8
		public void CommitRightStick()
		{
			InputControl control;
			if (this.cachedRightStickUp == null)
			{
				control = this.GetControl(InputControlType.RightStickUp);
				this.cachedRightStickUp = control;
			}
			control.Commit();
			InputControl control2;
			if (this.cachedRightStickDown == null)
			{
				control2 = this.GetControl(InputControlType.RightStickDown);
				this.cachedRightStickDown = control2;
			}
			control2.Commit();
			InputControl control3;
			if (this.cachedRightStickLeft == null)
			{
				control3 = this.GetControl(InputControlType.RightStickLeft);
				this.cachedRightStickLeft = control3;
			}
			control3.Commit();
			InputControl control4;
			if (this.cachedRightStickRight == null)
			{
				control4 = this.GetControl(InputControlType.RightStickRight);
				this.cachedRightStickRight = control4;
			}
			control4.Commit();
		}

		// Token: 0x06000206 RID: 518 RVA: 0x0000613C File Offset: 0x0000433C
		public virtual void Update(ulong updateTick, float deltaTime)
		{
		}

		// Token: 0x06000207 RID: 519 RVA: 0x0000614C File Offset: 0x0000434C
		private void ProcessLeftStick(ulong updateTick, float deltaTime)
		{
			InputControl control;
			if (this.cachedLeftStickLeft == null)
			{
				control = this.GetControl(InputControlType.LeftStickLeft);
				this.cachedLeftStickLeft = control;
			}
			if (control.enabled && control.ownerEnabled)
			{
				float rawValue = control.nextState.RawValue;
			}
			InputControl control2;
			if (this.cachedLeftStickRight == null)
			{
				control2 = this.GetControl(InputControlType.LeftStickRight);
				this.cachedLeftStickRight = control2;
			}
			bool ownerEnabled;
			if (control2.enabled)
			{
				ownerEnabled = control2.ownerEnabled;
				if (ownerEnabled)
				{
					float rawValue2 = control2.nextState.RawValue;
				}
			}
			if (!ownerEnabled)
			{
			}
			InputControl control3;
			if (this.cachedLeftStickDown == null)
			{
				control3 = this.GetControl(InputControlType.LeftStickDown);
				this.cachedLeftStickDown = control3;
			}
			if (control3.enabled && control3.ownerEnabled)
			{
				float rawValue3 = control3.nextState.RawValue;
			}
			InputControl control4;
			if (this.cachedLeftStickUp == null)
			{
				control4 = this.GetControl(InputControlType.LeftStickUp);
				this.cachedLeftStickUp = control4;
			}
			bool ownerEnabled2;
			if (control4.enabled)
			{
				ownerEnabled2 = control4.ownerEnabled;
				if (ownerEnabled2)
				{
					float rawValue4 = control4.nextState.RawValue;
				}
			}
			if (!ownerEnabled2)
			{
			}
			if (!true)
			{
			}
			if (!this.<RawSticks>k__BackingField)
			{
				InputControl control5;
				if (this.cachedLeftStickLeft == null)
				{
					control5 = this.GetControl(InputControlType.LeftStickLeft);
					this.cachedLeftStickLeft = control5;
				}
				if (!control5.Raw)
				{
					InputControl control6;
					if (this.cachedLeftStickRight == null)
					{
						control6 = this.GetControl(InputControlType.LeftStickRight);
						this.cachedLeftStickRight = control6;
					}
					if (!control6.Raw)
					{
						InputControl control7;
						if (this.cachedLeftStickUp == null)
						{
							control7 = this.GetControl(InputControlType.LeftStickUp);
							this.cachedLeftStickUp = control7;
						}
						if (!control7.Raw)
						{
							InputControl control8;
							if (this.cachedLeftStickDown == null)
							{
								control8 = this.GetControl(InputControlType.LeftStickDown);
								this.cachedLeftStickDown = control8;
							}
							if (!control8.Raw)
							{
								InputControl control9;
								if (this.cachedLeftStickLeft == null)
								{
									control9 = this.GetControl(InputControlType.LeftStickLeft);
									this.cachedLeftStickLeft = control9;
								}
								InputControl inputControl = this.cachedLeftStickRight;
								float lowerDeadZone = control9.lowerDeadZone;
								InputControl control10;
								if (inputControl == null)
								{
									control10 = this.GetControl(InputControlType.LeftStickRight);
									this.cachedLeftStickRight = control10;
								}
								InputControl inputControl2 = this.cachedLeftStickUp;
								float lowerDeadZone2 = control10.lowerDeadZone;
								InputControl control11;
								if (inputControl2 == null)
								{
									control11 = this.GetControl(InputControlType.LeftStickUp);
									this.cachedLeftStickUp = control11;
								}
								InputControl inputControl3 = this.cachedLeftStickDown;
								float lowerDeadZone3 = control11.lowerDeadZone;
								InputControl control12;
								if (inputControl3 == null)
								{
									control12 = this.GetControl(InputControlType.LeftStickDown);
									this.cachedLeftStickDown = control12;
								}
								float lowerDeadZone4 = control12.lowerDeadZone;
								if (control11 == null)
								{
								}
								InputControl control13;
								if (this.cachedLeftStickLeft == null)
								{
									control13 = this.GetControl(InputControlType.LeftStickLeft);
									this.cachedLeftStickLeft = control13;
								}
								InputControl inputControl4 = this.cachedLeftStickRight;
								float upperDeadZone = control13.upperDeadZone;
								InputControl control14;
								if (inputControl4 == null)
								{
									control14 = this.GetControl(InputControlType.LeftStickRight);
									this.cachedLeftStickRight = control14;
								}
								InputControl inputControl5 = this.cachedLeftStickUp;
								float upperDeadZone2 = control14.upperDeadZone;
								InputControl control15;
								if (inputControl5 == null)
								{
									control15 = this.GetControl(InputControlType.LeftStickUp);
									this.cachedLeftStickUp = control15;
								}
								InputControl inputControl6 = this.cachedLeftStickDown;
								float upperDeadZone3 = control15.upperDeadZone;
								if (inputControl6 == null)
								{
									InputControl control16 = this.GetControl(InputControlType.LeftStickDown);
									this.cachedLeftStickDown = control16;
								}
								float upperDeadZone4 = inputControl6.upperDeadZone;
								DeadZoneFunc deadZoneFunc = this.<LeftStick>k__BackingField.DeadZoneFunc;
								IntPtr invoke_impl = deadZoneFunc.invoke_impl;
								IntPtr method_code = deadZoneFunc.method_code;
								IntPtr method = deadZoneFunc.method;
							}
						}
					}
				}
			}
			TwoAxisInputControl twoAxisInputControl = this.<LeftStick>k__BackingField;
			twoAxisInputControl.Raw = true;
			float num;
			float num2;
			float num3;
			twoAxisInputControl.UpdateWithAxes(num, num2, updateTick, num3);
			InputControl inputControl7 = this.cachedLeftStickX;
			if (inputControl7 != null)
			{
				inputControl7.Raw = true;
				return;
			}
			InputControl control17 = this.GetControl(InputControlType.LeftStickX);
			this.cachedLeftStickX = control17;
			control17.Raw = true;
			InputControl control18;
			if (control17 == null)
			{
				control18 = this.GetControl(InputControlType.LeftStickX);
				this.cachedLeftStickX = control18;
			}
			bool flag = control18.UpdateWithValue(num, updateTick, num2);
			control18.Commit();
			InputControl inputControl8 = this.cachedLeftStickY;
			if (inputControl8 != null)
			{
				inputControl8.Raw = true;
				return;
			}
			InputControl control19 = this.GetControl(InputControlType.LeftStickY);
			this.cachedLeftStickY = control19;
			control19.Raw = true;
			InputControl control20;
			if (control19 == null)
			{
				control20 = this.GetControl(InputControlType.LeftStickY);
				this.cachedLeftStickY = control20;
			}
			bool flag2 = control20.UpdateWithValue(num2, updateTick, num2);
			control20.Commit();
			InputControl inputControl9;
			if (this.cachedLeftStickLeft == null)
			{
				this.cachedLeftStickLeft = inputControl9;
			}
			OneAxisInputControl <Left>k__BackingField = this.<LeftStick>k__BackingField.<Left>k__BackingField;
			if (<Left>k__BackingField.enabled && <Left>k__BackingField.ownerEnabled)
			{
				float value = <Left>k__BackingField.thisState.Value;
			}
			inputControl9.SetValue(num2, updateTick);
			InputControl control21;
			if (this.cachedLeftStickRight == null)
			{
				control21 = this.GetControl(InputControlType.LeftStickRight);
				this.cachedLeftStickRight = control21;
			}
			OneAxisInputControl <Right>k__BackingField = this.<LeftStick>k__BackingField.<Right>k__BackingField;
			if (<Right>k__BackingField.enabled && <Right>k__BackingField.ownerEnabled)
			{
				float value2 = <Right>k__BackingField.thisState.Value;
			}
			control21.SetValue(num2, updateTick);
			InputControl control22;
			if (this.cachedLeftStickUp == null)
			{
				control22 = this.GetControl(InputControlType.LeftStickUp);
				this.cachedLeftStickUp = control22;
			}
			OneAxisInputControl <Up>k__BackingField = this.<LeftStick>k__BackingField.<Up>k__BackingField;
			if (<Up>k__BackingField.enabled && <Up>k__BackingField.ownerEnabled)
			{
				float value3 = <Up>k__BackingField.thisState.Value;
			}
			control22.SetValue(num2, updateTick);
			InputControl control23;
			if (this.cachedLeftStickDown == null)
			{
				control23 = this.GetControl(InputControlType.LeftStickDown);
				this.cachedLeftStickDown = control23;
			}
			OneAxisInputControl <Down>k__BackingField = this.<LeftStick>k__BackingField.<Down>k__BackingField;
			if (<Down>k__BackingField.enabled && <Down>k__BackingField.ownerEnabled)
			{
				float value4 = <Down>k__BackingField.thisState.Value;
			}
			control23.SetValue(num2, updateTick);
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00006654 File Offset: 0x00004854
		private void ProcessRightStick(ulong updateTick, float deltaTime)
		{
			InputControl control;
			if (this.cachedRightStickLeft == null)
			{
				control = this.GetControl(InputControlType.RightStickLeft);
				this.cachedRightStickLeft = control;
			}
			if (control.enabled && control.ownerEnabled)
			{
				float rawValue = control.nextState.RawValue;
			}
			InputControl control2;
			if (this.cachedRightStickRight == null)
			{
				control2 = this.GetControl(InputControlType.RightStickRight);
				this.cachedRightStickRight = control2;
			}
			bool ownerEnabled;
			if (control2.enabled)
			{
				ownerEnabled = control2.ownerEnabled;
				if (ownerEnabled)
				{
					float rawValue2 = control2.nextState.RawValue;
				}
			}
			if (!ownerEnabled)
			{
			}
			InputControl control3;
			if (this.cachedRightStickDown == null)
			{
				control3 = this.GetControl(InputControlType.RightStickDown);
				this.cachedRightStickDown = control3;
			}
			if (control3.enabled && control3.ownerEnabled)
			{
				float rawValue3 = control3.nextState.RawValue;
			}
			InputControl control4;
			if (this.cachedRightStickUp == null)
			{
				control4 = this.GetControl(InputControlType.RightStickUp);
				this.cachedRightStickUp = control4;
			}
			bool ownerEnabled2;
			if (control4.enabled)
			{
				ownerEnabled2 = control4.ownerEnabled;
				if (ownerEnabled2)
				{
					float rawValue4 = control4.nextState.RawValue;
				}
			}
			if (!ownerEnabled2)
			{
			}
			if (!true)
			{
			}
			if (!this.<RawSticks>k__BackingField)
			{
				InputControl control5;
				if (this.cachedRightStickLeft == null)
				{
					control5 = this.GetControl(InputControlType.RightStickLeft);
					this.cachedRightStickLeft = control5;
				}
				if (!control5.Raw)
				{
					InputControl control6;
					if (this.cachedRightStickRight == null)
					{
						control6 = this.GetControl(InputControlType.RightStickRight);
						this.cachedRightStickRight = control6;
					}
					if (!control6.Raw)
					{
						InputControl control7;
						if (this.cachedRightStickUp == null)
						{
							control7 = this.GetControl(InputControlType.RightStickUp);
							this.cachedRightStickUp = control7;
						}
						if (!control7.Raw)
						{
							InputControl control8;
							if (this.cachedRightStickDown == null)
							{
								control8 = this.GetControl(InputControlType.RightStickDown);
								this.cachedRightStickDown = control8;
							}
							if (!control8.Raw)
							{
								InputControl control9;
								if (this.cachedRightStickLeft == null)
								{
									control9 = this.GetControl(InputControlType.RightStickLeft);
									this.cachedRightStickLeft = control9;
								}
								InputControl inputControl = this.cachedRightStickRight;
								float lowerDeadZone = control9.lowerDeadZone;
								InputControl control10;
								if (inputControl == null)
								{
									control10 = this.GetControl(InputControlType.RightStickRight);
									this.cachedRightStickRight = control10;
								}
								InputControl inputControl2 = this.cachedRightStickUp;
								float lowerDeadZone2 = control10.lowerDeadZone;
								InputControl control11;
								if (inputControl2 == null)
								{
									control11 = this.GetControl(InputControlType.RightStickUp);
									this.cachedRightStickUp = control11;
								}
								InputControl inputControl3 = this.cachedRightStickDown;
								float lowerDeadZone3 = control11.lowerDeadZone;
								InputControl control12;
								if (inputControl3 == null)
								{
									control12 = this.GetControl(InputControlType.RightStickDown);
									this.cachedRightStickDown = control12;
								}
								float lowerDeadZone4 = control12.lowerDeadZone;
								if (control11 == null)
								{
								}
								InputControl control13;
								if (this.cachedRightStickLeft == null)
								{
									control13 = this.GetControl(InputControlType.RightStickLeft);
									this.cachedRightStickLeft = control13;
								}
								InputControl inputControl4 = this.cachedRightStickRight;
								float upperDeadZone = control13.upperDeadZone;
								InputControl control14;
								if (inputControl4 == null)
								{
									control14 = this.GetControl(InputControlType.RightStickRight);
									this.cachedRightStickRight = control14;
								}
								InputControl inputControl5 = this.cachedRightStickUp;
								float upperDeadZone2 = control14.upperDeadZone;
								InputControl control15;
								if (inputControl5 == null)
								{
									control15 = this.GetControl(InputControlType.RightStickUp);
									this.cachedRightStickUp = control15;
								}
								InputControl inputControl6 = this.cachedRightStickDown;
								float upperDeadZone3 = control15.upperDeadZone;
								InputControl control16;
								if (inputControl6 == null)
								{
									control16 = this.GetControl(InputControlType.RightStickDown);
									this.cachedRightStickDown = control16;
								}
								float upperDeadZone4 = control16.upperDeadZone;
								DeadZoneFunc deadZoneFunc = this.<RightStick>k__BackingField.DeadZoneFunc;
								IntPtr invoke_impl = deadZoneFunc.invoke_impl;
								IntPtr method_code = deadZoneFunc.method_code;
								IntPtr method = deadZoneFunc.method;
							}
						}
					}
				}
			}
			TwoAxisInputControl twoAxisInputControl = this.<RightStick>k__BackingField;
			twoAxisInputControl.Raw = true;
			float num;
			float num2;
			float num3;
			twoAxisInputControl.UpdateWithAxes(num, num2, updateTick, num3);
			InputControl inputControl7 = this.cachedRightStickX;
			if (inputControl7 != null)
			{
				inputControl7.Raw = true;
				return;
			}
			InputControl control17 = this.GetControl(InputControlType.RightStickX);
			this.cachedRightStickX = control17;
			control17.Raw = true;
			InputControl control18;
			if (control17 == null)
			{
				control18 = this.GetControl(InputControlType.RightStickX);
				this.cachedRightStickX = control18;
			}
			bool flag = control18.UpdateWithValue(num, updateTick, num2);
			control18.Commit();
			InputControl inputControl8 = this.cachedRightStickY;
			if (inputControl8 != null)
			{
				inputControl8.Raw = true;
				return;
			}
			InputControl control19 = this.GetControl(InputControlType.RightStickY);
			this.cachedRightStickY = control19;
			control19.Raw = true;
			InputControl control20;
			if (control19 == null)
			{
				control20 = this.GetControl(InputControlType.RightStickY);
				this.cachedRightStickY = control20;
			}
			bool flag2 = control20.UpdateWithValue(num2, updateTick, num2);
			control20.Commit();
			InputControl control21;
			if (this.cachedRightStickLeft == null)
			{
				control21 = this.GetControl(InputControlType.RightStickLeft);
				this.cachedRightStickLeft = control21;
			}
			OneAxisInputControl <Left>k__BackingField = this.<RightStick>k__BackingField.<Left>k__BackingField;
			if (<Left>k__BackingField.enabled && <Left>k__BackingField.ownerEnabled)
			{
				float value = <Left>k__BackingField.thisState.Value;
			}
			control21.SetValue(num2, updateTick);
			InputControl control22;
			if (this.cachedRightStickRight == null)
			{
				control22 = this.GetControl(InputControlType.RightStickRight);
				this.cachedRightStickRight = control22;
			}
			OneAxisInputControl <Right>k__BackingField = this.<RightStick>k__BackingField.<Right>k__BackingField;
			if (<Right>k__BackingField.enabled && <Right>k__BackingField.ownerEnabled)
			{
				float value2 = <Right>k__BackingField.thisState.Value;
			}
			control22.SetValue(num2, updateTick);
			InputControl control23;
			if (this.cachedRightStickUp == null)
			{
				control23 = this.GetControl(InputControlType.RightStickUp);
				this.cachedRightStickUp = control23;
			}
			OneAxisInputControl <Up>k__BackingField = this.<RightStick>k__BackingField.<Up>k__BackingField;
			if (<Up>k__BackingField.enabled && <Up>k__BackingField.ownerEnabled)
			{
				float value3 = <Up>k__BackingField.thisState.Value;
			}
			control23.SetValue(num2, updateTick);
			InputControl control24;
			if (this.cachedRightStickDown == null)
			{
				control24 = this.GetControl(InputControlType.RightStickDown);
				this.cachedRightStickDown = control24;
			}
			OneAxisInputControl <Down>k__BackingField = this.<RightStick>k__BackingField.<Down>k__BackingField;
			if (<Down>k__BackingField.enabled && <Down>k__BackingField.ownerEnabled)
			{
				float value4 = <Down>k__BackingField.thisState.Value;
			}
			control24.SetValue(num2, updateTick);
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00006B6C File Offset: 0x00004D6C
		private void ProcessDPad(ulong updateTick, float deltaTime)
		{
			InputControl control;
			if (this.cachedDPadLeft == null)
			{
				control = this.GetControl(InputControlType.DPadLeft);
				this.cachedDPadLeft = control;
			}
			if (control.enabled && control.ownerEnabled)
			{
				float rawValue = control.nextState.RawValue;
			}
			InputControl control2;
			if (this.cachedDPadRight == null)
			{
				control2 = this.GetControl(InputControlType.DPadRight);
				this.cachedDPadRight = control2;
			}
			bool ownerEnabled;
			if (control2.enabled)
			{
				ownerEnabled = control2.ownerEnabled;
				if (ownerEnabled)
				{
					float rawValue2 = control2.nextState.RawValue;
				}
			}
			if (!ownerEnabled)
			{
			}
			InputControl control3;
			if (this.cachedDPadDown == null)
			{
				control3 = this.GetControl(InputControlType.DPadDown);
				this.cachedDPadDown = control3;
			}
			if (control3.enabled && control3.ownerEnabled)
			{
				float rawValue3 = control3.nextState.RawValue;
			}
			InputControl control4;
			if (this.cachedDPadUp == null)
			{
				control4 = this.GetControl(InputControlType.DPadUp);
				this.cachedDPadUp = control4;
			}
			bool ownerEnabled2;
			if (control4.enabled)
			{
				ownerEnabled2 = control4.ownerEnabled;
				if (ownerEnabled2)
				{
					float rawValue4 = control4.nextState.RawValue;
				}
			}
			if (!ownerEnabled2)
			{
			}
			if (!true)
			{
			}
			if (!this.<RawSticks>k__BackingField)
			{
				InputControl control5;
				if (this.cachedDPadLeft == null)
				{
					control5 = this.GetControl(InputControlType.DPadLeft);
					this.cachedDPadLeft = control5;
				}
				if (!control5.Raw)
				{
					InputControl control6;
					if (this.cachedDPadRight == null)
					{
						control6 = this.GetControl(InputControlType.DPadRight);
						this.cachedDPadRight = control6;
					}
					if (!control6.Raw)
					{
						InputControl control7;
						if (this.cachedDPadUp == null)
						{
							control7 = this.GetControl(InputControlType.DPadUp);
							this.cachedDPadUp = control7;
						}
						if (!control7.Raw)
						{
							InputControl control8;
							if (this.cachedDPadDown == null)
							{
								control8 = this.GetControl(InputControlType.DPadDown);
								this.cachedDPadDown = control8;
							}
							if (!control8.Raw)
							{
								InputControl control9;
								if (this.cachedDPadLeft == null)
								{
									control9 = this.GetControl(InputControlType.DPadLeft);
									this.cachedDPadLeft = control9;
								}
								InputControl inputControl = this.cachedDPadRight;
								float lowerDeadZone = control9.lowerDeadZone;
								InputControl control10;
								if (inputControl == null)
								{
									control10 = this.GetControl(InputControlType.DPadRight);
									this.cachedDPadRight = control10;
								}
								InputControl inputControl2 = this.cachedDPadUp;
								float lowerDeadZone2 = control10.lowerDeadZone;
								InputControl control11;
								if (inputControl2 == null)
								{
									control11 = this.GetControl(InputControlType.DPadUp);
									this.cachedDPadUp = control11;
								}
								InputControl inputControl3 = this.cachedDPadDown;
								float lowerDeadZone3 = control11.lowerDeadZone;
								InputControl control12;
								if (inputControl3 == null)
								{
									control12 = this.GetControl(InputControlType.DPadDown);
									this.cachedDPadDown = control12;
								}
								float lowerDeadZone4 = control12.lowerDeadZone;
								if (control11 == null)
								{
								}
								InputControl control13;
								if (this.cachedDPadLeft == null)
								{
									control13 = this.GetControl(InputControlType.DPadLeft);
									this.cachedDPadLeft = control13;
								}
								InputControl inputControl4 = this.cachedDPadRight;
								float upperDeadZone = control13.upperDeadZone;
								InputControl control14;
								if (inputControl4 == null)
								{
									control14 = this.GetControl(InputControlType.DPadRight);
									this.cachedDPadRight = control14;
								}
								InputControl inputControl5 = this.cachedDPadUp;
								float upperDeadZone2 = control14.upperDeadZone;
								InputControl control15;
								if (inputControl5 == null)
								{
									control15 = this.GetControl(InputControlType.DPadUp);
									this.cachedDPadUp = control15;
								}
								InputControl inputControl6 = this.cachedDPadDown;
								float upperDeadZone3 = control15.upperDeadZone;
								InputControl control16;
								if (inputControl6 == null)
								{
									control16 = this.GetControl(InputControlType.DPadDown);
									this.cachedDPadDown = control16;
								}
								float upperDeadZone4 = control16.upperDeadZone;
								DeadZoneFunc deadZoneFunc = this.<DPad>k__BackingField.DeadZoneFunc;
								IntPtr invoke_impl = deadZoneFunc.invoke_impl;
								IntPtr method_code = deadZoneFunc.method_code;
								IntPtr method = deadZoneFunc.method;
							}
						}
					}
				}
			}
			TwoAxisInputControl twoAxisInputControl = this.<DPad>k__BackingField;
			twoAxisInputControl.Raw = true;
			float num;
			float num2;
			float num3;
			twoAxisInputControl.UpdateWithAxes(num, num2, updateTick, num3);
			InputControl inputControl7 = this.cachedDPadX;
			if (inputControl7 != null)
			{
				inputControl7.Raw = true;
				return;
			}
			InputControl control17 = this.GetControl(InputControlType.DPadX);
			this.cachedDPadX = control17;
			control17.Raw = true;
			InputControl control18;
			if (control17 == null)
			{
				control18 = this.GetControl(InputControlType.DPadX);
				this.cachedDPadX = control18;
			}
			bool flag = control18.UpdateWithValue(num, updateTick, num2);
			control18.Commit();
			InputControl inputControl8 = this.cachedDPadY;
			if (inputControl8 != null)
			{
				inputControl8.Raw = true;
				return;
			}
			InputControl control19 = this.GetControl(InputControlType.DPadY);
			this.cachedDPadY = control19;
			control19.Raw = true;
			InputControl control20;
			if (control19 == null)
			{
				control20 = this.GetControl(InputControlType.DPadY);
				this.cachedDPadY = control20;
			}
			bool flag2 = control20.UpdateWithValue(num2, updateTick, num2);
			control20.Commit();
			InputControl control21;
			if (this.cachedDPadLeft == null)
			{
				control21 = this.GetControl(InputControlType.DPadLeft);
				this.cachedDPadLeft = control21;
			}
			OneAxisInputControl <Left>k__BackingField = this.<DPad>k__BackingField.<Left>k__BackingField;
			if (<Left>k__BackingField.enabled && <Left>k__BackingField.ownerEnabled)
			{
				float value = <Left>k__BackingField.thisState.Value;
			}
			control21.SetValue(num2, updateTick);
			InputControl control22;
			if (this.cachedDPadRight == null)
			{
				control22 = this.GetControl(InputControlType.DPadRight);
				this.cachedDPadRight = control22;
			}
			OneAxisInputControl <Right>k__BackingField = this.<DPad>k__BackingField.<Right>k__BackingField;
			if (<Right>k__BackingField.enabled && <Right>k__BackingField.ownerEnabled)
			{
				float value2 = <Right>k__BackingField.thisState.Value;
			}
			control22.SetValue(num2, updateTick);
			InputControl control23;
			if (this.cachedDPadUp == null)
			{
				control23 = this.GetControl(InputControlType.DPadUp);
				this.cachedDPadUp = control23;
			}
			OneAxisInputControl <Up>k__BackingField = this.<DPad>k__BackingField.<Up>k__BackingField;
			if (<Up>k__BackingField.enabled && <Up>k__BackingField.ownerEnabled)
			{
				float value3 = <Up>k__BackingField.thisState.Value;
			}
			control23.SetValue(num2, updateTick);
			InputControl control24;
			if (this.cachedDPadDown == null)
			{
				control24 = this.GetControl(InputControlType.DPadDown);
				this.cachedDPadDown = control24;
			}
			OneAxisInputControl <Down>k__BackingField = this.<DPad>k__BackingField.<Down>k__BackingField;
			if (<Down>k__BackingField.enabled && <Down>k__BackingField.ownerEnabled)
			{
				float value4 = <Down>k__BackingField.thisState.Value;
			}
			control24.SetValue(num2, updateTick);
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00007090 File Offset: 0x00005290
		public void Commit(ulong updateTick, float deltaTime)
		{
			this.ProcessLeftStick(updateTick, deltaTime);
			this.ProcessRightStick(updateTick, deltaTime);
			this.ProcessDPad(updateTick, deltaTime);
			ReadOnlyCollection<InputControl> readOnlyCollection = this.<Controls>k__BackingField;
			if (this.<Controls>k__BackingField != null)
			{
			}
			InputControl[] array = this.<ControlsByTarget>k__BackingField;
			long num = 0L;
			InputControl inputControl = this.cachedCommand;
			if (inputControl != null)
			{
				inputControl.Passive = num != 0L;
				return;
			}
			InputControl inputControl2;
			this.cachedCommand = inputControl2;
			inputControl2.Passive = num != 0L;
			int num2;
			InputControl inputControl3;
			if (inputControl2 == null)
			{
				num2 = 300;
				this.cachedCommand = inputControl3;
			}
			inputControl3.CommitWithState(num2 != 0, updateTick, deltaTime);
			int num3 = 1;
			if (this.<Controls>k__BackingField != null && num == 0L)
			{
				this.<LastInputTick>k__BackingField = updateTick;
				this.<IsActive>k__BackingField = num3 != 0;
			}
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00007134 File Offset: 0x00005334
		public bool LastInputAfter(InputDevice device)
		{
			if (device != null)
			{
				ulong num = this.<LastInputTick>k__BackingField;
				ulong num2 = device.<LastInputTick>k__BackingField;
			}
			return true;
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00007154 File Offset: 0x00005354
		internal void RequestActivation()
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			this.<IsActive>k__BackingField = true;
			this.<LastInputTick>k__BackingField = 1UL;
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00007178 File Offset: 0x00005378
		public virtual void Vibrate(float leftMotor, float rightMotor)
		{
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00007188 File Offset: 0x00005388
		public void Vibrate(float intensity)
		{
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00007198 File Offset: 0x00005398
		public void StopVibration()
		{
		}

		// Token: 0x06000210 RID: 528 RVA: 0x000071A8 File Offset: 0x000053A8
		public virtual void SetLightColor(float red, float green, float blue)
		{
		}

		// Token: 0x06000211 RID: 529 RVA: 0x000071B8 File Offset: 0x000053B8
		public void SetLightColor(Color color)
		{
		}

		// Token: 0x06000212 RID: 530 RVA: 0x000071C8 File Offset: 0x000053C8
		public virtual void SetLightFlash(float flashOnDuration, float flashOffDuration)
		{
		}

		// Token: 0x06000213 RID: 531 RVA: 0x000071D8 File Offset: 0x000053D8
		public void StopLightFlash()
		{
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000214 RID: 532 RVA: 0x000071E8 File Offset: 0x000053E8
		public virtual bool IsSupportedOnThisPlatform
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000215 RID: 533 RVA: 0x000071F8 File Offset: 0x000053F8
		public virtual bool IsKnown
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000216 RID: 534 RVA: 0x000025E1 File Offset: 0x000007E1
		public bool IsUnknown
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000217 RID: 535 RVA: 0x00007208 File Offset: 0x00005408
		[Obsolete("Use InputDevice.CommandIsPressed instead.", false)]
		public bool MenuIsPressed
		{
			get
			{
				InputControl control;
				if (this.cachedCommand == null)
				{
					control = this.GetControl(InputControlType.Command);
					this.cachedCommand = control;
				}
				if (control.enabled && control.ownerEnabled)
				{
					InputControlState thisState = control.thisState;
					return;
				}
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000218 RID: 536 RVA: 0x00007248 File Offset: 0x00005448
		[Obsolete("Use InputDevice.CommandWasPressed instead.", false)]
		public bool MenuWasPressed
		{
			get
			{
				InputControl control;
				if (this.cachedCommand == null)
				{
					control = this.GetControl(InputControlType.Command);
					this.cachedCommand = control;
				}
				if (control.enabled && control.ownerEnabled)
				{
					InputControlState thisState = control.thisState;
					return;
				}
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000219 RID: 537 RVA: 0x00007288 File Offset: 0x00005488
		[Obsolete("Use InputDevice.CommandWasReleased instead.", false)]
		public bool MenuWasReleased
		{
			get
			{
				InputControl control;
				if (this.cachedCommand == null)
				{
					control = this.GetControl(InputControlType.Command);
					this.cachedCommand = control;
				}
				if (control.enabled && control.ownerEnabled)
				{
					InputControlState thisState = control.thisState;
					InputControlState lastState = control.lastState;
					return;
				}
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x0600021A RID: 538 RVA: 0x000072D0 File Offset: 0x000054D0
		public bool CommandIsPressed
		{
			get
			{
				InputControl control;
				if (this.cachedCommand == null)
				{
					control = this.GetControl(InputControlType.Command);
					this.cachedCommand = control;
				}
				if (control.enabled && control.ownerEnabled)
				{
					InputControlState thisState = control.thisState;
					return;
				}
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600021B RID: 539 RVA: 0x00007310 File Offset: 0x00005510
		public bool CommandWasPressed
		{
			get
			{
				InputControl control;
				if (this.cachedCommand == null)
				{
					control = this.GetControl(InputControlType.Command);
					this.cachedCommand = control;
				}
				if (control.enabled && control.ownerEnabled)
				{
					InputControlState thisState = control.thisState;
					return;
				}
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x0600021C RID: 540 RVA: 0x00007350 File Offset: 0x00005550
		public bool CommandWasReleased
		{
			get
			{
				InputControl control;
				if (this.cachedCommand == null)
				{
					control = this.GetControl(InputControlType.Command);
					this.cachedCommand = control;
				}
				if (control.enabled && control.ownerEnabled)
				{
					InputControlState thisState = control.thisState;
					InputControlState lastState = control.lastState;
					return;
				}
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x0600021D RID: 541 RVA: 0x00007398 File Offset: 0x00005598
		public InputControl AnyButton
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600021D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling InControl.InputControl InControl.InputDevice::get_AnyButton()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001F:
	brtrue(IL_0000, ldloc:int32[exp:bool](var_0_01))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
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
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x0600021E RID: 542 RVA: 0x000073C8 File Offset: 0x000055C8
		public bool AnyButtonIsPressed
		{
			get
			{
				int num = 1;
				ReadOnlyCollection<InputControl> readOnlyCollection = this.<Controls>k__BackingField;
				if (this.<Controls>k__BackingField == null || num == 0 || num == 0 || num == 0 || num == 0)
				{
					return;
				}
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600021F RID: 543 RVA: 0x000073F8 File Offset: 0x000055F8
		public bool AnyButtonWasPressed
		{
			get
			{
				int num = 1;
				ReadOnlyCollection<InputControl> readOnlyCollection = this.<Controls>k__BackingField;
				if (this.<Controls>k__BackingField == null || num == 0 || num == 0 || num != 0)
				{
					return;
				}
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000220 RID: 544 RVA: 0x00007428 File Offset: 0x00005628
		public bool AnyButtonWasReleased
		{
			get
			{
				int num = 1;
				ReadOnlyCollection<InputControl> readOnlyCollection = this.<Controls>k__BackingField;
				if (this.<Controls>k__BackingField == null || num == 0 || num == 0 || num != 0)
				{
					return;
				}
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000221 RID: 545 RVA: 0x00007458 File Offset: 0x00005658
		public TwoAxisInputControl Direction
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000221)

ICSharpCode.Decompiler.DecompilerException: Error decompiling InControl.TwoAxisInputControl InControl.InputDevice::get_Direction()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:TwoAxisInputControl(var_0_06, ldfld:TwoAxisInputControl(InputDevice::<DPad>k__BackingField, ldloc:InputDevice(this)))
	stloc:TwoAxisInputControl(var_1_0D, ldfld:TwoAxisInputControl(InputDevice::<LeftStick>k__BackingField, ldloc:InputDevice(this)))
	stloc:uint64(var_2_14, ldfld:uint64(TwoAxisInputControl::<UpdateTick>k__BackingField, ldloc:TwoAxisInputControl(var_0_06)))
	stloc:uint64(var_3_1B, ldfld:uint64(TwoAxisInputControl::<UpdateTick>k__BackingField, ldloc:TwoAxisInputControl(var_1_0D)))
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

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000222 RID: 546 RVA: 0x00007480 File Offset: 0x00005680
		public InputControl LeftStickUp
		{
			get
			{
				InputControl control;
				if (this.cachedLeftStickUp == null)
				{
					control = this.GetControl(InputControlType.LeftStickUp);
					this.cachedLeftStickUp = control;
				}
				return control;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000223 RID: 547 RVA: 0x000074A8 File Offset: 0x000056A8
		public InputControl LeftStickDown
		{
			get
			{
				InputControl control;
				if (this.cachedLeftStickDown == null)
				{
					control = this.GetControl(InputControlType.LeftStickDown);
					this.cachedLeftStickDown = control;
				}
				return control;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000224 RID: 548 RVA: 0x000074D0 File Offset: 0x000056D0
		public InputControl LeftStickLeft
		{
			get
			{
				InputControl control;
				if (this.cachedLeftStickLeft == null)
				{
					control = this.GetControl(InputControlType.LeftStickLeft);
					this.cachedLeftStickLeft = control;
				}
				return control;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000225 RID: 549 RVA: 0x000074F8 File Offset: 0x000056F8
		public InputControl LeftStickRight
		{
			get
			{
				InputControl control;
				if (this.cachedLeftStickRight == null)
				{
					control = this.GetControl(InputControlType.LeftStickRight);
					this.cachedLeftStickRight = control;
				}
				return control;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000226 RID: 550 RVA: 0x00007520 File Offset: 0x00005720
		public InputControl RightStickUp
		{
			get
			{
				InputControl control;
				if (this.cachedRightStickUp == null)
				{
					control = this.GetControl(InputControlType.RightStickUp);
					this.cachedRightStickUp = control;
				}
				return control;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000227 RID: 551 RVA: 0x00007548 File Offset: 0x00005748
		public InputControl RightStickDown
		{
			get
			{
				InputControl control;
				if (this.cachedRightStickDown == null)
				{
					control = this.GetControl(InputControlType.RightStickDown);
					this.cachedRightStickDown = control;
				}
				return control;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000228 RID: 552 RVA: 0x00007570 File Offset: 0x00005770
		public InputControl RightStickLeft
		{
			get
			{
				InputControl control;
				if (this.cachedRightStickLeft == null)
				{
					control = this.GetControl(InputControlType.RightStickLeft);
					this.cachedRightStickLeft = control;
				}
				return control;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000229 RID: 553 RVA: 0x00007598 File Offset: 0x00005798
		public InputControl RightStickRight
		{
			get
			{
				InputControl control;
				if (this.cachedRightStickRight == null)
				{
					control = this.GetControl(InputControlType.RightStickRight);
					this.cachedRightStickRight = control;
				}
				return control;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x0600022A RID: 554 RVA: 0x000075C0 File Offset: 0x000057C0
		public InputControl DPadUp
		{
			get
			{
				InputControl control;
				if (this.cachedDPadUp == null)
				{
					control = this.GetControl(InputControlType.DPadUp);
					this.cachedDPadUp = control;
				}
				return control;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x0600022B RID: 555 RVA: 0x000075E8 File Offset: 0x000057E8
		public InputControl DPadDown
		{
			get
			{
				InputControl control;
				if (this.cachedDPadDown == null)
				{
					control = this.GetControl(InputControlType.DPadDown);
					this.cachedDPadDown = control;
				}
				return control;
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x0600022C RID: 556 RVA: 0x00007610 File Offset: 0x00005810
		public InputControl DPadLeft
		{
			get
			{
				InputControl control;
				if (this.cachedDPadLeft == null)
				{
					control = this.GetControl(InputControlType.DPadLeft);
					this.cachedDPadLeft = control;
				}
				return control;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x0600022D RID: 557 RVA: 0x00007638 File Offset: 0x00005838
		public InputControl DPadRight
		{
			get
			{
				InputControl control;
				if (this.cachedDPadRight == null)
				{
					control = this.GetControl(InputControlType.DPadRight);
					this.cachedDPadRight = control;
				}
				return control;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x0600022E RID: 558 RVA: 0x00007660 File Offset: 0x00005860
		public InputControl Action1
		{
			get
			{
				InputControl control;
				if (this.cachedAction1 == null)
				{
					control = this.GetControl(InputControlType.Action1);
					this.cachedAction1 = control;
				}
				return control;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x0600022F RID: 559 RVA: 0x00007688 File Offset: 0x00005888
		public InputControl Action2
		{
			get
			{
				InputControl control;
				if (this.cachedAction2 == null)
				{
					control = this.GetControl(InputControlType.Action2);
					this.cachedAction2 = control;
				}
				return control;
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000230 RID: 560 RVA: 0x000076B0 File Offset: 0x000058B0
		public InputControl Action3
		{
			get
			{
				InputControl control;
				if (this.cachedAction3 == null)
				{
					control = this.GetControl(InputControlType.Action3);
					this.cachedAction3 = control;
				}
				return control;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000231 RID: 561 RVA: 0x000076D8 File Offset: 0x000058D8
		public InputControl Action4
		{
			get
			{
				InputControl control;
				if (this.cachedAction4 == null)
				{
					control = this.GetControl(InputControlType.Action4);
					this.cachedAction4 = control;
				}
				return control;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000232 RID: 562 RVA: 0x00007700 File Offset: 0x00005900
		public InputControl LeftTrigger
		{
			get
			{
				InputControl control;
				if (this.cachedLeftTrigger == null)
				{
					control = this.GetControl(InputControlType.LeftTrigger);
					this.cachedLeftTrigger = control;
				}
				return control;
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000233 RID: 563 RVA: 0x00007728 File Offset: 0x00005928
		public InputControl RightTrigger
		{
			get
			{
				InputControl control;
				if (this.cachedRightTrigger == null)
				{
					control = this.GetControl(InputControlType.RightTrigger);
					this.cachedRightTrigger = control;
				}
				return control;
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000234 RID: 564 RVA: 0x00007750 File Offset: 0x00005950
		public InputControl LeftBumper
		{
			get
			{
				InputControl control;
				if (this.cachedLeftBumper == null)
				{
					control = this.GetControl(InputControlType.LeftBumper);
					this.cachedLeftBumper = control;
				}
				return control;
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000235 RID: 565 RVA: 0x00007778 File Offset: 0x00005978
		public InputControl RightBumper
		{
			get
			{
				InputControl control;
				if (this.cachedRightBumper == null)
				{
					control = this.GetControl(InputControlType.RightBumper);
					this.cachedRightBumper = control;
				}
				return control;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000236 RID: 566 RVA: 0x000077A0 File Offset: 0x000059A0
		public InputControl LeftStickButton
		{
			get
			{
				InputControl control;
				if (this.cachedLeftStickButton == null)
				{
					control = this.GetControl(InputControlType.LeftStickButton);
					this.cachedLeftStickButton = control;
				}
				return control;
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000237 RID: 567 RVA: 0x000077C8 File Offset: 0x000059C8
		public InputControl RightStickButton
		{
			get
			{
				InputControl control;
				if (this.cachedRightStickButton == null)
				{
					control = this.GetControl(InputControlType.RightStickButton);
					this.cachedRightStickButton = control;
				}
				return control;
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000238 RID: 568 RVA: 0x000077F0 File Offset: 0x000059F0
		public InputControl LeftStickX
		{
			get
			{
				InputControl control;
				if (this.cachedLeftStickX == null)
				{
					control = this.GetControl(InputControlType.LeftStickX);
					this.cachedLeftStickX = control;
				}
				return control;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000239 RID: 569 RVA: 0x0000781C File Offset: 0x00005A1C
		public InputControl LeftStickY
		{
			get
			{
				InputControl control;
				if (this.cachedLeftStickY == null)
				{
					control = this.GetControl(InputControlType.LeftStickY);
					this.cachedLeftStickY = control;
				}
				return control;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x0600023A RID: 570 RVA: 0x00007848 File Offset: 0x00005A48
		public InputControl RightStickX
		{
			get
			{
				InputControl control;
				if (this.cachedRightStickX == null)
				{
					control = this.GetControl(InputControlType.RightStickX);
					this.cachedRightStickX = control;
				}
				return control;
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x0600023B RID: 571 RVA: 0x00007874 File Offset: 0x00005A74
		public InputControl RightStickY
		{
			get
			{
				InputControl control;
				if (this.cachedRightStickY == null)
				{
					control = this.GetControl(InputControlType.RightStickY);
					this.cachedRightStickY = control;
				}
				return control;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x0600023C RID: 572 RVA: 0x000078A0 File Offset: 0x00005AA0
		public InputControl DPadX
		{
			get
			{
				InputControl control;
				if (this.cachedDPadX == null)
				{
					control = this.GetControl(InputControlType.DPadX);
					this.cachedDPadX = control;
				}
				return control;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x0600023D RID: 573 RVA: 0x000078CC File Offset: 0x00005ACC
		public InputControl DPadY
		{
			get
			{
				InputControl control;
				if (this.cachedDPadY == null)
				{
					control = this.GetControl(InputControlType.DPadY);
					this.cachedDPadY = control;
				}
				return control;
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x0600023E RID: 574 RVA: 0x000078F8 File Offset: 0x00005AF8
		public InputControl Command
		{
			get
			{
				InputControl control;
				if (this.cachedCommand == null)
				{
					control = this.GetControl(InputControlType.Command);
					this.cachedCommand = control;
				}
				return control;
			}
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00007924 File Offset: 0x00005B24
		private void ExpireControlCache()
		{
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000240 RID: 576 RVA: 0x00007934 File Offset: 0x00005B34
		public virtual int NumUnknownAnalogs
		{
			get
			{
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000241 RID: 577 RVA: 0x00007944 File Offset: 0x00005B44
		public virtual int NumUnknownButtons
		{
			get
			{
			}
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00007954 File Offset: 0x00005B54
		public virtual bool ReadRawButtonState(int index)
		{
		}

		// Token: 0x06000243 RID: 579 RVA: 0x000025E1 File Offset: 0x000007E1
		public virtual float ReadRawAnalogValue(int index)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00007964 File Offset: 0x00005B64
		public void TakeSnapshot()
		{
			if (this.<AnalogSnapshot>k__BackingField == null)
			{
			}
			InputDevice.AnalogSnapshotEntry[] array = this.<AnalogSnapshot>k__BackingField;
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00007984 File Offset: 0x00005B84
		public UnknownDeviceControl GetFirstPressedAnalog()
		{
			/*
An exception occurred when decompiling this method (06000245)

ICSharpCode.Decompiler.DecompilerException: Error decompiling InControl.UnknownDeviceControl InControl.InputDevice::GetFirstPressedAnalog()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:valuetype InControl.InputDevice/AnalogSnapshotEntry[](var_3_12, ldfld:valuetype InControl.InputDevice/AnalogSnapshotEntry[](InputDevice::<AnalogSnapshot>k__BackingField, ldloc:InputDevice(this)))
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

		// Token: 0x06000246 RID: 582 RVA: 0x000025E1 File Offset: 0x000007E1
		public UnknownDeviceControl GetFirstPressedButton()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000247 RID: 583 RVA: 0x000079A4 File Offset: 0x00005BA4
		// Note: this type is marked as 'beforefieldinit'.
		static InputDevice()
		{
		}

		// Token: 0x04000200 RID: 512
		public static readonly InputDevice Null;

		// Token: 0x04000201 RID: 513
		[CompilerGenerated]
		private string <Name>k__BackingField;

		// Token: 0x04000202 RID: 514
		[CompilerGenerated]
		private string <Meta>k__BackingField;

		// Token: 0x04000203 RID: 515
		[CompilerGenerated]
		private int <SortOrder>k__BackingField;

		// Token: 0x04000204 RID: 516
		[CompilerGenerated]
		private InputDeviceClass <DeviceClass>k__BackingField;

		// Token: 0x04000205 RID: 517
		[CompilerGenerated]
		private InputDeviceStyle <DeviceStyle>k__BackingField;

		// Token: 0x04000206 RID: 518
		[CompilerGenerated]
		private Guid <GUID>k__BackingField;

		// Token: 0x04000207 RID: 519
		[CompilerGenerated]
		private ulong <LastInputTick>k__BackingField;

		// Token: 0x04000208 RID: 520
		[CompilerGenerated]
		private bool <IsActive>k__BackingField;

		// Token: 0x04000209 RID: 521
		[CompilerGenerated]
		private bool <IsAttached>k__BackingField;

		// Token: 0x0400020A RID: 522
		[CompilerGenerated]
		private bool <RawSticks>k__BackingField;

		// Token: 0x0400020B RID: 523
		private readonly List<InputControl> controls;

		// Token: 0x0400020C RID: 524
		[CompilerGenerated]
		private ReadOnlyCollection<InputControl> <Controls>k__BackingField;

		// Token: 0x0400020D RID: 525
		[CompilerGenerated]
		private InputControl[] <ControlsByTarget>k__BackingField;

		// Token: 0x0400020E RID: 526
		[CompilerGenerated]
		private TwoAxisInputControl <LeftStick>k__BackingField;

		// Token: 0x0400020F RID: 527
		[CompilerGenerated]
		private TwoAxisInputControl <RightStick>k__BackingField;

		// Token: 0x04000210 RID: 528
		[CompilerGenerated]
		private TwoAxisInputControl <DPad>k__BackingField;

		// Token: 0x04000211 RID: 529
		public bool Passive;

		// Token: 0x04000212 RID: 530
		[CompilerGenerated]
		private InputDevice.AnalogSnapshotEntry[] <AnalogSnapshot>k__BackingField;

		// Token: 0x04000213 RID: 531
		private InputControl cachedLeftStickUp;

		// Token: 0x04000214 RID: 532
		private InputControl cachedLeftStickDown;

		// Token: 0x04000215 RID: 533
		private InputControl cachedLeftStickLeft;

		// Token: 0x04000216 RID: 534
		private InputControl cachedLeftStickRight;

		// Token: 0x04000217 RID: 535
		private InputControl cachedRightStickUp;

		// Token: 0x04000218 RID: 536
		private InputControl cachedRightStickDown;

		// Token: 0x04000219 RID: 537
		private InputControl cachedRightStickLeft;

		// Token: 0x0400021A RID: 538
		private InputControl cachedRightStickRight;

		// Token: 0x0400021B RID: 539
		private InputControl cachedDPadUp;

		// Token: 0x0400021C RID: 540
		private InputControl cachedDPadDown;

		// Token: 0x0400021D RID: 541
		private InputControl cachedDPadLeft;

		// Token: 0x0400021E RID: 542
		private InputControl cachedDPadRight;

		// Token: 0x0400021F RID: 543
		private InputControl cachedAction1;

		// Token: 0x04000220 RID: 544
		private InputControl cachedAction2;

		// Token: 0x04000221 RID: 545
		private InputControl cachedAction3;

		// Token: 0x04000222 RID: 546
		private InputControl cachedAction4;

		// Token: 0x04000223 RID: 547
		private InputControl cachedLeftTrigger;

		// Token: 0x04000224 RID: 548
		private InputControl cachedRightTrigger;

		// Token: 0x04000225 RID: 549
		private InputControl cachedLeftBumper;

		// Token: 0x04000226 RID: 550
		private InputControl cachedRightBumper;

		// Token: 0x04000227 RID: 551
		private InputControl cachedLeftStickButton;

		// Token: 0x04000228 RID: 552
		private InputControl cachedRightStickButton;

		// Token: 0x04000229 RID: 553
		private InputControl cachedLeftStickX;

		// Token: 0x0400022A RID: 554
		private InputControl cachedLeftStickY;

		// Token: 0x0400022B RID: 555
		private InputControl cachedRightStickX;

		// Token: 0x0400022C RID: 556
		private InputControl cachedRightStickY;

		// Token: 0x0400022D RID: 557
		private InputControl cachedDPadX;

		// Token: 0x0400022E RID: 558
		private InputControl cachedDPadY;

		// Token: 0x0400022F RID: 559
		private InputControl cachedCommand;

		// Token: 0x0200002D RID: 45
		protected struct AnalogSnapshotEntry
		{
			// Token: 0x06000248 RID: 584 RVA: 0x000079B4 File Offset: 0x00005BB4
			public void TrackMinMaxValue(float currentValue)
			{
				float num = this.maxValue;
				float num2 = this.minValue;
				this.maxValue = num;
			}

			// Token: 0x04000230 RID: 560
			public float value;

			// Token: 0x04000231 RID: 561
			public float maxValue;

			// Token: 0x04000232 RID: 562
			public float minValue;
		}
	}
}
