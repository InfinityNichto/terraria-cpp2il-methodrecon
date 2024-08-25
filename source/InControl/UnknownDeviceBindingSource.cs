using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace InControl
{
	// Token: 0x02000015 RID: 21
	public class UnknownDeviceBindingSource : BindingSource
	{
		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x00003E04 File Offset: 0x00002004
		// (set) Token: 0x060000F7 RID: 247 RVA: 0x00003E28 File Offset: 0x00002028
		public UnknownDeviceControl Control
		{
			[CompilerGenerated]
			get
			{
				UnknownDeviceControl unknownDeviceControl = this.<Control>k__BackingField;
				bool isButton = this.<Control>k__BackingField.IsButton;
				return unknownDeviceControl;
			}
			[CompilerGenerated]
			protected set
			{
				this.<Control>k__BackingField = value;
			}
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00003E3C File Offset: 0x0000203C
		internal UnknownDeviceBindingSource()
		{
			if (!true)
			{
			}
			this.<Control>k__BackingField = 1;
			this.<Control>k__BackingField.IsButton = true;
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00003E68 File Offset: 0x00002068
		public UnknownDeviceBindingSource(UnknownDeviceControl control)
		{
			this.<Control>k__BackingField = control;
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00003E84 File Offset: 0x00002084
		public override float GetValue(InputDevice device)
		{
			/*
An exception occurred when decompiling this method (060000FA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single InControl.UnknownDeviceBindingSource::GetValue(InControl.InputDevice)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:UnknownDeviceControl(var_0_06, ldfld:UnknownDeviceControl(UnknownDeviceBindingSource::<Control>k__BackingField, ldloc:UnknownDeviceBindingSource(this)))
	stloc:bool(var_1_12, ldfld:bool(UnknownDeviceControl::IsButton, ldfld:UnknownDeviceControl[exp:valuetype InControl.UnknownDeviceControl&](UnknownDeviceBindingSource::<Control>k__BackingField, ldloc:UnknownDeviceBindingSource(this))))
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

		// Token: 0x060000FB RID: 251 RVA: 0x00003EA4 File Offset: 0x000020A4
		public override bool GetState(InputDevice device)
		{
			if (device != null)
			{
				bool flag;
				return flag;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000FC RID: 252 RVA: 0x00003EBC File Offset: 0x000020BC
		public override string Name
		{
			get
			{
				PlayerAction <BoundTo>k__BackingField;
				do
				{
					<BoundTo>k__BackingField = this.<BoundTo>k__BackingField;
				}
				while (<BoundTo>k__BackingField == null);
				InputRangeType sourceRange = this.<Control>k__BackingField.SourceRange;
				return "";
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000FD RID: 253 RVA: 0x00003F50 File Offset: 0x00002150
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

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000FE RID: 254 RVA: 0x00003F98 File Offset: 0x00002198
		public override InputDeviceClass DeviceClass
		{
			get
			{
				return InputDeviceClass.Controller;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000FF RID: 255 RVA: 0x00003FA8 File Offset: 0x000021A8
		public override InputDeviceStyle DeviceStyle
		{
			get
			{
			}
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00003FB8 File Offset: 0x000021B8
		public override bool Equals(BindingSource other)
		{
			/*
An exception occurred when decompiling this method (06000100)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean InControl.UnknownDeviceBindingSource::Equals(InControl.BindingSource)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:UnknownDeviceControl(var_1_0B, ldfld:UnknownDeviceControl(UnknownDeviceBindingSource::<Control>k__BackingField, ldloc:UnknownDeviceBindingSource(this)))
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

		// Token: 0x06000101 RID: 257 RVA: 0x00003FD4 File Offset: 0x000021D4
		public override bool Equals(object other)
		{
			/*
An exception occurred when decompiling this method (06000101)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean InControl.UnknownDeviceBindingSource::Equals(System.Object)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:UnknownDeviceControl(var_1_0B, ldfld:UnknownDeviceControl(UnknownDeviceBindingSource::<Control>k__BackingField, ldloc:UnknownDeviceBindingSource(this)))
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

		// Token: 0x06000102 RID: 258 RVA: 0x00003FF0 File Offset: 0x000021F0
		public override int GetHashCode()
		{
			UnknownDeviceControl unknownDeviceControl = this.<Control>k__BackingField;
			bool isButton = this.<Control>k__BackingField.IsButton;
			int num;
			return num.GetHashCode();
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000103 RID: 259 RVA: 0x00004018 File Offset: 0x00002218
		public override BindingSourceType BindingSourceType
		{
			get
			{
				return BindingSourceType.UnknownDeviceBindingSource;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000104 RID: 260 RVA: 0x00004028 File Offset: 0x00002228
		internal override bool IsValid
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000104)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean InControl.UnknownDeviceBindingSource::get_IsValid()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0044:
	call:void(Debug::LogError, ldstr:string[exp:object]("Cannot query property 'IsValid' for unbound BindingSource."))
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

		// Token: 0x06000105 RID: 261 RVA: 0x00004088 File Offset: 0x00002288
		public override void Load(BinaryReader reader, ushort dataFormatVersion)
		{
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00004098 File Offset: 0x00002298
		public override void Save(BinaryWriter writer)
		{
			UnknownDeviceControl unknownDeviceControl = this.<Control>k__BackingField;
			bool isButton = this.<Control>k__BackingField.IsButton;
		}

		// Token: 0x04000103 RID: 259
		[CompilerGenerated]
		private UnknownDeviceControl <Control>k__BackingField;
	}
}
