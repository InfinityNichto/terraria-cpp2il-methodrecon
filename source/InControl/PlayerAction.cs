using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

namespace InControl
{
	// Token: 0x02000011 RID: 17
	public class PlayerAction : OneAxisInputControl
	{
		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000082 RID: 130 RVA: 0x00002E60 File Offset: 0x00001060
		// (set) Token: 0x06000083 RID: 131 RVA: 0x00002E74 File Offset: 0x00001074
		public string Name
		{
			[CompilerGenerated]
			get
			{
				return this.<Name>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Name>k__BackingField = value;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000084 RID: 132 RVA: 0x00002E88 File Offset: 0x00001088
		// (set) Token: 0x06000085 RID: 133 RVA: 0x00002E9C File Offset: 0x0000109C
		public PlayerActionSet Owner
		{
			[CompilerGenerated]
			get
			{
				return this.<Owner>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Owner>k__BackingField = value;
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000086 RID: 134 RVA: 0x00002EB0 File Offset: 0x000010B0
		// (remove) Token: 0x06000087 RID: 135 RVA: 0x00002ED8 File Offset: 0x000010D8
		public event Action<BindingSourceType> OnLastInputTypeChanged
		{
			[CompilerGenerated]
			add
			{
				Delegate @delegate = Delegate.Combine(this.OnLastInputTypeChanged, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = Delegate.Remove(this.OnLastInputTypeChanged, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000088 RID: 136 RVA: 0x00002F00 File Offset: 0x00001100
		// (remove) Token: 0x06000089 RID: 137 RVA: 0x00002F24 File Offset: 0x00001124
		public event Action OnBindingsChanged
		{
			[CompilerGenerated]
			add
			{
				if (Delegate.Combine(this.OnBindingsChanged, value) != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (Delegate.Remove(this.OnBindingsChanged, value) != null)
				{
				}
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600008A RID: 138 RVA: 0x00002F48 File Offset: 0x00001148
		// (set) Token: 0x0600008B RID: 139 RVA: 0x00002F5C File Offset: 0x0000115C
		public object UserData
		{
			[CompilerGenerated]
			get
			{
				return this.<UserData>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<UserData>k__BackingField = value;
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00002F70 File Offset: 0x00001170
		public PlayerAction(string name, PlayerActionSet owner)
		{
			this.sensitivity = (float)16256;
			this.upperDeadZone = (float)16256;
			this.Name = name;
			this.Owner = owner;
			this.Raw = 16256 != 0;
			List<BindingSource> list = this.visibleBindings;
			List<BindingSource> list2 = this.regularBindings;
			owner.AddPlayerAction(this);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x000025E1 File Offset: 0x000007E1
		public void AddDefaultBinding(BindingSource binding)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00002FC8 File Offset: 0x000011C8
		public void AddDefaultBinding(params Key[] keys)
		{
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00002FD8 File Offset: 0x000011D8
		public void AddDefaultBinding(KeyCombo keyCombo)
		{
			int includeSize = keyCombo.includeSize;
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00002FEC File Offset: 0x000011EC
		public void AddDefaultBinding(Mouse control)
		{
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00002FFC File Offset: 0x000011FC
		public void AddDefaultBinding(InputControlType control)
		{
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0000300C File Offset: 0x0000120C
		public bool AddBinding(BindingSource binding)
		{
			/*
An exception occurred when decompiling this method (06000092)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean InControl.PlayerAction::AddBinding(InControl.BindingSource)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0027:
	stfld:PlayerAction(BindingSource::<BoundTo>k__BackingField, ldloc:BindingSource(binding), ldloc:string[exp:PlayerAction](var_2))
	stloc:float32(var_4_3B, ldfld:float32(OneAxisInputControl::sensitivity, ldfld:PlayerAction[exp:OneAxisInputControl](BindingSource::<BoundTo>k__BackingField, ldloc:BindingSource(binding))))
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

		// Token: 0x06000093 RID: 147 RVA: 0x00003058 File Offset: 0x00001258
		public bool InsertBindingAt(int index, BindingSource binding)
		{
			int size = this.visibleBindings._size;
			return this.AddBinding(binding);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x000030B4 File Offset: 0x000012B4
		public bool ReplaceBinding(BindingSource findBinding, BindingSource withBinding)
		{
			if (findBinding != null && withBinding != null)
			{
				PlayerAction <BoundTo>k__BackingField = withBinding.<BoundTo>k__BackingField;
				string text2;
				if (<BoundTo>k__BackingField != null)
				{
					string text = <BoundTo>k__BackingField.<Name>k__BackingField;
					text2 = "Binding source is already bound to action " + text;
					if ("Binding source is already bound to action " == null)
					{
					}
					Debug.LogWarning(text2);
				}
				withBinding.<BoundTo>k__BackingField = text2;
			}
			return true;
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00003104 File Offset: 0x00001304
		public bool HasBinding(BindingSource binding)
		{
			while (binding != null)
			{
				BindingSource bindingSource = this.FindBinding(binding);
				if (bindingSource != null)
				{
					PlayerAction <BoundTo>k__BackingField = bindingSource.<BoundTo>k__BackingField;
					return;
				}
			}
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00003128 File Offset: 0x00001328
		public BindingSource FindBinding(BindingSource binding)
		{
			/*
An exception occurred when decompiling this method (06000096)

ICSharpCode.Decompiler.DecompilerException: Error decompiling InControl.BindingSource InControl.PlayerAction::FindBinding(InControl.BindingSource)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.List`1<class InControl.BindingSource>(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.List`1<class InControl.BindingSource>(PlayerAction::regularBindings, ldloc:PlayerAction(this)))
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

		// Token: 0x06000097 RID: 151 RVA: 0x000025E1 File Offset: 0x000007E1
		private void HardRemoveBinding(BindingSource binding)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00003140 File Offset: 0x00001340
		public void RemoveBinding(BindingSource binding)
		{
			BindingSource bindingSource = this.FindBinding(binding);
			if (bindingSource != null)
			{
				PlayerAction <BoundTo>k__BackingField = bindingSource.<BoundTo>k__BackingField;
				this.triggerBindingChanged = true;
			}
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00003168 File Offset: 0x00001368
		public void RemoveBindingAt(int index)
		{
			int size = this.regularBindings._size;
			this.triggerBindingChanged = true;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x000025E1 File Offset: 0x000007E1
		private int CountBindingsOfType(BindingSourceType bindingSourceType)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600009B RID: 155 RVA: 0x000025E1 File Offset: 0x000007E1
		private void RemoveFirstBindingOfType(BindingSourceType bindingSourceType)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00003188 File Offset: 0x00001388
		private int IndexOfFirstInvalidBinding()
		{
			/*
An exception occurred when decompiling this method (0600009C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 InControl.PlayerAction::IndexOfFirstInvalidBinding()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_0B, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<class InControl.BindingSource>[exp:List`1](PlayerAction::regularBindings, ldloc:PlayerAction(this))))
	stloc:class [mscorlib]System.Collections.Generic.List`1<class InControl.BindingSource>(var_2_14, ldfld:class [mscorlib]System.Collections.Generic.List`1<class InControl.BindingSource>(PlayerAction::regularBindings, ldloc:PlayerAction(this)))
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

		// Token: 0x0600009D RID: 157 RVA: 0x000025E1 File Offset: 0x000007E1
		public void ClearBindings()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600009E RID: 158 RVA: 0x000025E1 File Offset: 0x000007E1
		public void ResetBindings()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600009F RID: 159 RVA: 0x000031AC File Offset: 0x000013AC
		public void ListenForBinding()
		{
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x000031BC File Offset: 0x000013BC
		public void ListenForBindingReplacing(BindingSource binding)
		{
			PlayerActionSet playerActionSet = this.<Owner>k__BackingField;
			BindingListenOptions listenOptions;
			if (this.ListenOptions == null)
			{
				listenOptions = playerActionSet.listenOptions;
			}
			listenOptions.ReplaceBinding = binding;
			playerActionSet.listenWithAction = this;
			BindingSourceListener[] array = this.bindingSourceListeners;
			if (listenOptions != null)
			{
			}
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00003204 File Offset: 0x00001404
		public void StopListeningForBinding()
		{
			PlayerAction listenWithAction = this.<Owner>k__BackingField.listenWithAction;
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x00003228 File Offset: 0x00001428
		public bool IsListeningForBinding
		{
			get
			{
				/*
An exception occurred when decompiling this method (060000A2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean InControl.PlayerAction::get_IsListeningForBinding()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:PlayerAction(var_0_0B, ldfld:PlayerAction(PlayerActionSet::listenWithAction, ldfld:PlayerActionSet(PlayerAction::<Owner>k__BackingField, ldloc:PlayerAction(this))))
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

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x00003240 File Offset: 0x00001440
		public ReadOnlyCollection<BindingSource> Bindings
		{
			get
			{
				return this.bindings;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x00003254 File Offset: 0x00001454
		public ReadOnlyCollection<BindingSource> UnfilteredBindings
		{
			get
			{
				return this.unfilteredBindings;
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x000025E1 File Offset: 0x000007E1
		private void RemoveOrphanedBindings()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00003268 File Offset: 0x00001468
		internal void Update(ulong updateTick, float deltaTime, InputDevice device)
		{
			do
			{
				InputDevice inputDevice = this.device;
				this.device = device;
				this.UpdateVisibleBindings();
				this.UpdateBindings(updateTick, deltaTime);
				if (this.triggerBindingChanged)
				{
					Action onBindingsChanged = this.OnBindingsChanged;
					if (onBindingsChanged != null)
					{
						IntPtr invoke_impl = onBindingsChanged.invoke_impl;
						IntPtr method_code = onBindingsChanged.method_code;
						IntPtr method = onBindingsChanged.method;
					}
				}
				if (!this.triggerBindingEnded)
				{
					goto IL_0066;
				}
			}
			while (this.ListenOptions != null);
			if (this.<Owner>k__BackingField.listenOptions.OnBindingEnded != null)
			{
			}
			IL_0066:
			this.DetectBindings();
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x000025E1 File Offset: 0x000007E1
		private void UpdateBindings(ulong updateTick, float deltaTime)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x000032E4 File Offset: 0x000014E4
		private void DetectBindings()
		{
			PlayerActionSet playerActionSet = this.<Owner>k__BackingField;
			PlayerAction listenWithAction = playerActionSet.listenWithAction;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x000025E1 File Offset: 0x000007E1
		private void UpdateVisibleBindings()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000AA RID: 170 RVA: 0x00003420 File Offset: 0x00001620
		// (set) Token: 0x060000AB RID: 171 RVA: 0x00003454 File Offset: 0x00001654
		internal InputDevice Device
		{
			get
			{
				while (this.device != null)
				{
				}
				InputDevice <Device>k__BackingField = this.<Owner>k__BackingField.<Device>k__BackingField;
				this.device = <Device>k__BackingField;
				this.UpdateVisibleBindings();
				return this.device;
			}
			set
			{
				InputDevice inputDevice = this.device;
				this.device = value;
				this.UpdateVisibleBindings();
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000AC RID: 172 RVA: 0x00003478 File Offset: 0x00001678
		public InputDevice ActiveDevice
		{
			get
			{
				if (this.activeDevice != null || !true)
				{
				}
				return 1;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000AD RID: 173 RVA: 0x00003494 File Offset: 0x00001694
		private bool LastInputTypeIsDevice
		{
			get
			{
				/*
An exception occurred when decompiling this method (060000AD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean InControl.PlayerAction::get_LastInputTypeIsDevice()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:BindingSourceType(var_0_06, ldfld:BindingSourceType(PlayerAction::LastInputType, ldloc:PlayerAction(this)))
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

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000AE RID: 174 RVA: 0x000025E1 File Offset: 0x000007E1
		// (set) Token: 0x060000AF RID: 175 RVA: 0x000034A8 File Offset: 0x000016A8
		[Obsolete("Please set this property on device controls directly. It does nothing here.")]
		public new float LowerDeadZone
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x000025E1 File Offset: 0x000007E1
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x000034B8 File Offset: 0x000016B8
		[Obsolete("Please set this property on device controls directly. It does nothing here.")]
		public new float UpperDeadZone
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x000034C8 File Offset: 0x000016C8
		internal void Load(BinaryReader reader, ushort dataFormatVersion)
		{
			this.ClearBindings();
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x000034EC File Offset: 0x000016EC
		internal void Save(BinaryWriter writer)
		{
			this.RemoveOrphanedBindings();
			string text = this.<Name>k__BackingField;
			int size = this.regularBindings._size;
			List<BindingSource> list = this.regularBindings;
		}

		// Token: 0x040000CC RID: 204
		[CompilerGenerated]
		private string <Name>k__BackingField;

		// Token: 0x040000CD RID: 205
		[CompilerGenerated]
		private PlayerActionSet <Owner>k__BackingField;

		// Token: 0x040000CE RID: 206
		public BindingListenOptions ListenOptions;

		// Token: 0x040000CF RID: 207
		public BindingSourceType LastInputType;

		// Token: 0x040000D0 RID: 208
		[CompilerGenerated]
		private Action<BindingSourceType> OnLastInputTypeChanged;

		// Token: 0x040000D1 RID: 209
		public ulong LastInputTypeChangedTick;

		// Token: 0x040000D2 RID: 210
		public InputDeviceClass LastDeviceClass;

		// Token: 0x040000D3 RID: 211
		public InputDeviceStyle LastDeviceStyle;

		// Token: 0x040000D4 RID: 212
		[CompilerGenerated]
		private Action OnBindingsChanged;

		// Token: 0x040000D5 RID: 213
		[CompilerGenerated]
		private object <UserData>k__BackingField;

		// Token: 0x040000D6 RID: 214
		private readonly List<BindingSource> defaultBindings;

		// Token: 0x040000D7 RID: 215
		private readonly List<BindingSource> regularBindings;

		// Token: 0x040000D8 RID: 216
		private readonly List<BindingSource> visibleBindings;

		// Token: 0x040000D9 RID: 217
		private readonly ReadOnlyCollection<BindingSource> bindings;

		// Token: 0x040000DA RID: 218
		private readonly ReadOnlyCollection<BindingSource> unfilteredBindings;

		// Token: 0x040000DB RID: 219
		private readonly BindingSourceListener[] bindingSourceListeners;

		// Token: 0x040000DC RID: 220
		private bool triggerBindingEnded;

		// Token: 0x040000DD RID: 221
		private bool triggerBindingChanged;

		// Token: 0x040000DE RID: 222
		private InputDevice device;

		// Token: 0x040000DF RID: 223
		private InputDevice activeDevice;
	}
}
