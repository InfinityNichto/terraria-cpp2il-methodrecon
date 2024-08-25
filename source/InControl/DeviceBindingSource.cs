using System;
using System.IO;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace InControl
{
	// Token: 0x02000007 RID: 7
	public class DeviceBindingSource : BindingSource
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00002178 File Offset: 0x00000378
		// (set) Token: 0x0600001B RID: 27 RVA: 0x0000218C File Offset: 0x0000038C
		public InputControlType Control
		{
			[CompilerGenerated]
			get
			{
				return this.<Control>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				this.<Control>k__BackingField = value;
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000021A0 File Offset: 0x000003A0
		internal DeviceBindingSource()
		{
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000021B4 File Offset: 0x000003B4
		public DeviceBindingSource(InputControlType control)
		{
			this.Control = control;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000021D0 File Offset: 0x000003D0
		public override float GetValue(InputDevice inputDevice)
		{
			/*
An exception occurred when decompiling this method (0600001E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single InControl.DeviceBindingSource::GetValue(InControl.InputDevice)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_2:
	stloc:float32(var_2_2D, ldfld:float32(InputControlState::Value, ldfld:InputControlState[exp:valuetype InControl.InputControlState&](OneAxisInputControl::thisState, ldloc:InputControl[exp:OneAxisInputControl](var_1_11))))
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

		// Token: 0x0600001F RID: 31 RVA: 0x0000220C File Offset: 0x0000040C
		public override bool GetState(InputDevice inputDevice)
		{
			if (inputDevice == null)
			{
				return;
			}
			InputControlType inputControlType = this.<Control>k__BackingField;
			InputControl control = inputDevice.GetControl(inputControlType);
			if (control.enabled && control.ownerEnabled)
			{
				InputControlState thisState = control.thisState;
				return;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00002244 File Offset: 0x00000444
		public override string Name
		{
			get
			{
				PlayerAction <BoundTo>k__BackingField = this.<BoundTo>k__BackingField;
				if (<BoundTo>k__BackingField != null)
				{
					InputDevice device;
					if (<BoundTo>k__BackingField.device == null)
					{
						InputDevice <Device>k__BackingField = <BoundTo>k__BackingField.<Owner>k__BackingField.<Device>k__BackingField;
						<BoundTo>k__BackingField.device = <Device>k__BackingField;
						<BoundTo>k__BackingField.UpdateVisibleBindings();
						device = <BoundTo>k__BackingField.device;
					}
					InputControlType inputControlType = this.<Control>k__BackingField;
					InputControl control = device.GetControl(inputControlType);
					InputControlType inputControlType2 = this.<Control>k__BackingField;
					return device.GetControl(inputControlType2).<Handle>k__BackingField;
				}
				return "";
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000021 RID: 33 RVA: 0x000022B4 File Offset: 0x000004B4
		public override string DeviceName
		{
			get
			{
				PlayerAction <BoundTo>k__BackingField = this.<BoundTo>k__BackingField;
				if (<BoundTo>k__BackingField != null)
				{
					InputDevice <Device>k__BackingField;
					if (<BoundTo>k__BackingField.device == null)
					{
						<Device>k__BackingField = <BoundTo>k__BackingField.<Owner>k__BackingField.<Device>k__BackingField;
						<BoundTo>k__BackingField.device = <Device>k__BackingField;
						<BoundTo>k__BackingField.UpdateVisibleBindings();
						InputDevice device = <BoundTo>k__BackingField.device;
					}
					if (<Device>k__BackingField == null)
					{
					}
				}
				return "";
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000022 RID: 34 RVA: 0x000022FC File Offset: 0x000004FC
		public override InputDeviceClass DeviceClass
		{
			get
			{
				PlayerAction <BoundTo>k__BackingField;
				do
				{
					<BoundTo>k__BackingField = this.<BoundTo>k__BackingField;
					if (<BoundTo>k__BackingField == null)
					{
						return;
					}
				}
				while (<BoundTo>k__BackingField.device != null);
				InputDevice <Device>k__BackingField = <BoundTo>k__BackingField.<Owner>k__BackingField.<Device>k__BackingField;
				<BoundTo>k__BackingField.device = <Device>k__BackingField;
				<BoundTo>k__BackingField.UpdateVisibleBindings();
				return <BoundTo>k__BackingField.device.<DeviceClass>k__BackingField;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000023 RID: 35 RVA: 0x00002344 File Offset: 0x00000544
		public override InputDeviceStyle DeviceStyle
		{
			get
			{
				PlayerAction <BoundTo>k__BackingField;
				do
				{
					<BoundTo>k__BackingField = this.<BoundTo>k__BackingField;
					if (<BoundTo>k__BackingField == null)
					{
						return;
					}
				}
				while (<BoundTo>k__BackingField.device != null);
				InputDevice <Device>k__BackingField = <BoundTo>k__BackingField.<Owner>k__BackingField.<Device>k__BackingField;
				<BoundTo>k__BackingField.device = <Device>k__BackingField;
				<BoundTo>k__BackingField.UpdateVisibleBindings();
				return <BoundTo>k__BackingField.device.<DeviceStyle>k__BackingField;
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0000238C File Offset: 0x0000058C
		public override bool Equals(BindingSource other)
		{
			/*
An exception occurred when decompiling this method (06000024)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean InControl.DeviceBindingSource::Equals(InControl.BindingSource)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:InputControlType(var_1_0B, ldfld:InputControlType(DeviceBindingSource::<Control>k__BackingField, ldloc:DeviceBindingSource(this)))
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

		// Token: 0x06000025 RID: 37 RVA: 0x000023A4 File Offset: 0x000005A4
		public override bool Equals(object other)
		{
			/*
An exception occurred when decompiling this method (06000025)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean InControl.DeviceBindingSource::Equals(System.Object)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:InputControlType(var_1_0B, ldfld:InputControlType(DeviceBindingSource::<Control>k__BackingField, ldloc:DeviceBindingSource(this)))
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

		// Token: 0x06000026 RID: 38 RVA: 0x000023BC File Offset: 0x000005BC
		public override int GetHashCode()
		{
			InputControlType inputControlType = this.<Control>k__BackingField;
			int num;
			return num;
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000027 RID: 39 RVA: 0x000023D4 File Offset: 0x000005D4
		public override BindingSourceType BindingSourceType
		{
			get
			{
				return BindingSourceType.DeviceBindingSource;
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000023E4 File Offset: 0x000005E4
		public override void Save(BinaryWriter writer)
		{
			InputControlType inputControlType = this.<Control>k__BackingField;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000023F8 File Offset: 0x000005F8
		public override void Load(BinaryReader reader, ushort dataFormatVersion)
		{
			this.<Control>k__BackingField = reader;
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600002A RID: 42 RVA: 0x0000240C File Offset: 0x0000060C
		internal override bool IsValid
		{
			get
			{
				PlayerAction <BoundTo>k__BackingField;
				do
				{
					<BoundTo>k__BackingField = this.<BoundTo>k__BackingField;
					if (<BoundTo>k__BackingField == null)
					{
						goto IL_003F;
					}
				}
				while (<BoundTo>k__BackingField.device != null);
				InputDevice <Device>k__BackingField = <BoundTo>k__BackingField.<Owner>k__BackingField.<Device>k__BackingField;
				<BoundTo>k__BackingField.device = <Device>k__BackingField;
				<BoundTo>k__BackingField.UpdateVisibleBindings();
				bool flag;
				if (<BoundTo>k__BackingField.device.<ControlsByTarget>k__BackingField.upperDeadZone == null)
				{
					return flag;
				}
				IL_003F:
				Debug.LogError("Cannot query property 'IsValid' for unbound BindingSource.");
				return flag;
			}
		}

		// Token: 0x0400001D RID: 29
		[CompilerGenerated]
		private InputControlType <Control>k__BackingField;
	}
}
