using System;
using System.Runtime.CompilerServices;

namespace InControl
{
	// Token: 0x0200001E RID: 30
	public class InputControl : OneAxisInputControl
	{
		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000130 RID: 304 RVA: 0x000045FC File Offset: 0x000027FC
		// (set) Token: 0x06000131 RID: 305 RVA: 0x00004610 File Offset: 0x00002810
		public string Handle
		{
			[CompilerGenerated]
			get
			{
				return this.<Handle>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				this.<Handle>k__BackingField = value;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000132 RID: 306 RVA: 0x00004624 File Offset: 0x00002824
		// (set) Token: 0x06000133 RID: 307 RVA: 0x00004638 File Offset: 0x00002838
		public InputControlType Target
		{
			[CompilerGenerated]
			get
			{
				return this.<Target>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				this.<Target>k__BackingField = value;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000134 RID: 308 RVA: 0x0000464C File Offset: 0x0000284C
		// (set) Token: 0x06000135 RID: 309 RVA: 0x00004660 File Offset: 0x00002860
		public bool IsButton
		{
			[CompilerGenerated]
			get
			{
				return this.<IsButton>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000136 RID: 310 RVA: 0x00004670 File Offset: 0x00002870
		// (set) Token: 0x06000137 RID: 311 RVA: 0x00004684 File Offset: 0x00002884
		public bool IsAnalog
		{
			[CompilerGenerated]
			get
			{
				return this.<IsAnalog>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00004694 File Offset: 0x00002894
		private InputControl()
		{
			this.sensitivity = (float)16256;
			this.upperDeadZone = (float)16256;
			base..ctor();
			this.Handle = "None";
		}

		// Token: 0x06000139 RID: 313 RVA: 0x000046C8 File Offset: 0x000028C8
		public InputControl(string handle, InputControlType target)
		{
			this.sensitivity = (float)16256;
			this.upperDeadZone = (float)16256;
			base..ctor();
			this.Handle = handle;
			this.Target = target;
			if (16256 == 0)
			{
			}
			bool flag = Utility.TargetIsButton(target);
			this.<IsButton>k__BackingField = 16256 != 0;
			this.<IsAnalog>k__BackingField = 16256 != 0;
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00004724 File Offset: 0x00002924
		public InputControl(string handle, InputControlType target, bool passive)
		{
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00004734 File Offset: 0x00002934
		internal void SetZeroTick()
		{
			ulong <UpdateTick>k__BackingField = this.<UpdateTick>k__BackingField;
			this.zeroTick = <UpdateTick>k__BackingField;
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600013C RID: 316 RVA: 0x00004750 File Offset: 0x00002950
		internal bool IsOnZeroTick
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600013C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean InControl.InputControl::get_IsOnZeroTick()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint64(var_0_06, ldfld:uint64(OneAxisInputControl::<UpdateTick>k__BackingField, ldloc:InputControl[exp:OneAxisInputControl](this)))
	stloc:uint64(var_1_0D, ldfld:uint64(InputControl::zeroTick, ldloc:InputControl(this)))
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

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600013D RID: 317 RVA: 0x0000476C File Offset: 0x0000296C
		public bool IsStandard
		{
			get
			{
				InputControlType inputControlType = this.<Target>k__BackingField;
				if (!true)
				{
				}
				return Utility.TargetIsStandard(inputControlType);
			}
		}

		// Token: 0x0600013E RID: 318 RVA: 0x0000478C File Offset: 0x0000298C
		// Note: this type is marked as 'beforefieldinit'.
		static InputControl()
		{
		}

		// Token: 0x04000127 RID: 295
		public static readonly InputControl Null;

		// Token: 0x04000128 RID: 296
		[CompilerGenerated]
		private string <Handle>k__BackingField;

		// Token: 0x04000129 RID: 297
		[CompilerGenerated]
		private InputControlType <Target>k__BackingField;

		// Token: 0x0400012A RID: 298
		public bool Passive;

		// Token: 0x0400012B RID: 299
		[CompilerGenerated]
		private bool <IsButton>k__BackingField;

		// Token: 0x0400012C RID: 300
		[CompilerGenerated]
		private bool <IsAnalog>k__BackingField;

		// Token: 0x0400012D RID: 301
		private ulong zeroTick;
	}
}
