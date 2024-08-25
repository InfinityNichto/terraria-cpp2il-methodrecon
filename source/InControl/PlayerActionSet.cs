using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2IlInjected;

namespace InControl
{
	// Token: 0x02000012 RID: 18
	public abstract class PlayerActionSet
	{
		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x0000351C File Offset: 0x0000171C
		// (set) Token: 0x060000B5 RID: 181 RVA: 0x00003530 File Offset: 0x00001730
		public InputDevice Device
		{
			[CompilerGenerated]
			get
			{
				return this.<Device>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Device>k__BackingField = value;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x00003544 File Offset: 0x00001744
		// (set) Token: 0x060000B7 RID: 183 RVA: 0x00003558 File Offset: 0x00001758
		public List<InputDevice> IncludeDevices
		{
			[CompilerGenerated]
			get
			{
				return this.<IncludeDevices>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<IncludeDevices>k__BackingField = value;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x0000356C File Offset: 0x0000176C
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x00003580 File Offset: 0x00001780
		public List<InputDevice> ExcludeDevices
		{
			[CompilerGenerated]
			get
			{
				return this.<ExcludeDevices>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<ExcludeDevices>k__BackingField = value;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000BA RID: 186 RVA: 0x00003594 File Offset: 0x00001794
		// (set) Token: 0x060000BB RID: 187 RVA: 0x000035A8 File Offset: 0x000017A8
		public ReadOnlyCollection<PlayerAction> Actions
		{
			[CompilerGenerated]
			get
			{
				return this.<Actions>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Actions>k__BackingField = value;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000BC RID: 188 RVA: 0x000035BC File Offset: 0x000017BC
		// (set) Token: 0x060000BD RID: 189 RVA: 0x000035D0 File Offset: 0x000017D0
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

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x060000BE RID: 190 RVA: 0x000035E4 File Offset: 0x000017E4
		// (remove) Token: 0x060000BF RID: 191 RVA: 0x0000360C File Offset: 0x0000180C
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

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x00003634 File Offset: 0x00001834
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x00003648 File Offset: 0x00001848
		public bool Enabled
		{
			[CompilerGenerated]
			get
			{
				return this.<Enabled>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x00003658 File Offset: 0x00001858
		// (set) Token: 0x060000C3 RID: 195 RVA: 0x0000366C File Offset: 0x0000186C
		public bool PreventInputWhileListeningForBinding
		{
			[CompilerGenerated]
			get
			{
				return this.<PreventInputWhileListeningForBinding>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x0000367C File Offset: 0x0000187C
		// (set) Token: 0x060000C5 RID: 197 RVA: 0x00003690 File Offset: 0x00001890
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

		// Token: 0x060000C6 RID: 198 RVA: 0x000036A4 File Offset: 0x000018A4
		protected PlayerActionSet()
		{
			this.<Enabled>k__BackingField = 257 != 0;
			List<PlayerAction> list = this.actions;
			InputManager.AttachPlayerActionSet(this);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x000036D0 File Offset: 0x000018D0
		public void Destroy()
		{
			InputManager.DetachPlayerActionSet(this);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x000025E1 File Offset: 0x000007E1
		protected PlayerAction CreatePlayerAction(string name)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x000025E1 File Offset: 0x000007E1
		internal void AddPlayerAction(PlayerAction action)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060000CA RID: 202 RVA: 0x000025E1 File Offset: 0x000007E1
		protected PlayerOneAxisAction CreateOneAxisPlayerAction(PlayerAction negativeAction, PlayerAction positiveAction)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060000CB RID: 203 RVA: 0x000025E1 File Offset: 0x000007E1
		protected PlayerTwoAxisAction CreateTwoAxisPlayerAction(PlayerAction negativeXAction, PlayerAction positiveXAction, PlayerAction negativeYAction, PlayerAction positiveYAction)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x17000035 RID: 53
		public PlayerAction this[string actionName]
		{
			get
			{
				/*
An exception occurred when decompiling this method (060000CC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling InControl.PlayerAction InControl.PlayerActionSet::get_Item(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.Dictionary`2<string, class InControl.PlayerAction>(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<string, class InControl.PlayerAction>(PlayerActionSet::actionsByName, ldloc:PlayerActionSet(this)))
	stloc:string(var_1_17, call:string(string::Concat, ldstr:string("Action '"), ldloc:string(actionName), ldstr:string("' does not exist in this action set.")))
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

		// Token: 0x060000CD RID: 205 RVA: 0x00003708 File Offset: 0x00001908
		public PlayerAction GetPlayerActionByName(string actionName)
		{
			/*
An exception occurred when decompiling this method (060000CD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling InControl.PlayerAction InControl.PlayerActionSet::GetPlayerActionByName(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.Dictionary`2<string, class InControl.PlayerAction>(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<string, class InControl.PlayerAction>(PlayerActionSet::actionsByName, ldloc:PlayerActionSet(this)))
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

		// Token: 0x060000CE RID: 206 RVA: 0x000025E1 File Offset: 0x000007E1
		internal void Update(ulong updateTick, float deltaTime)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0000371C File Offset: 0x0000191C
		public void Reset()
		{
			int size = this.actions._size;
			List<PlayerAction> list = this.actions;
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00003740 File Offset: 0x00001940
		private InputDevice FindActiveDevice()
		{
			List<InputDevice> list = this.<IncludeDevices>k__BackingField;
			List<InputDevice> list2 = this.<ExcludeDevices>k__BackingField;
			int size = list._size;
			int size2 = list2._size;
			if (list == null)
			{
			}
			return InputManager.ActiveDevice;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x0000378C File Offset: 0x0000198C
		public void ClearInputState()
		{
			int size = this.actions._size;
			List<PlayerAction> list = this.actions;
			int size2 = this.oneAxisActions._size;
			List<PlayerOneAxisAction> list2 = this.oneAxisActions;
			int size3 = this.twoAxisActions._size;
			List<PlayerTwoAxisAction> list3 = this.twoAxisActions;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x000037EC File Offset: 0x000019EC
		public bool HasBinding(BindingSource binding)
		{
			if (binding != null)
			{
				int size = this.actions._size;
				BindingSource bindingSource;
				if (bindingSource != null)
				{
					PlayerAction <BoundTo>k__BackingField = bindingSource.<BoundTo>k__BackingField;
				}
				List<PlayerAction> list = this.actions;
				return;
			}
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00003824 File Offset: 0x00001A24
		public void RemoveBinding(BindingSource binding)
		{
			if (binding != null)
			{
				int size = this.actions._size;
				BindingSource bindingSource;
				if (bindingSource != null)
				{
					PlayerAction <BoundTo>k__BackingField = bindingSource.<BoundTo>k__BackingField;
				}
				List<PlayerAction> list = this.actions;
				return;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x00003858 File Offset: 0x00001A58
		public bool IsListeningForBinding
		{
			get
			{
				/*
An exception occurred when decompiling this method (060000D4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean InControl.PlayerActionSet::get_IsListeningForBinding()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:PlayerAction(var_0_06, ldfld:PlayerAction(PlayerActionSet::listenWithAction, ldloc:PlayerActionSet(this)))
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

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x0000386C File Offset: 0x00001A6C
		// (set) Token: 0x060000D6 RID: 214 RVA: 0x00003880 File Offset: 0x00001A80
		public BindingListenOptions ListenOptions
		{
			get
			{
				return this.listenOptions;
			}
			set
			{
				if (value == null)
				{
				}
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x00003890 File Offset: 0x00001A90
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

		// Token: 0x060000D8 RID: 216 RVA: 0x000038AC File Offset: 0x00001AAC
		public byte[] SaveData()
		{
			Encoding utf = Encoding.UTF8;
			int size = this.actions._size;
			List<PlayerAction> list = this.actions;
			if (!false)
			{
				if (!false)
				{
				}
				throw new OutOfMemoryException();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0000392C File Offset: 0x00001B2C
		public void LoadData(byte[] data)
		{
			if (data != null)
			{
				Dictionary<string, PlayerAction> dictionary = this.actionsByName;
				return;
			}
		}

		// Token: 0x060000DA RID: 218 RVA: 0x000039BC File Offset: 0x00001BBC
		public string Save()
		{
			return Convert.ToBase64String(this.SaveData());
		}

		// Token: 0x060000DB RID: 219 RVA: 0x000039D4 File Offset: 0x00001BD4
		public void Load(string data)
		{
			if (data != null)
			{
				byte[] array = Convert.FromBase64String(data);
				this.LoadData(array);
			}
		}

		// Token: 0x040000E0 RID: 224
		[CompilerGenerated]
		private InputDevice <Device>k__BackingField;

		// Token: 0x040000E1 RID: 225
		[CompilerGenerated]
		private List<InputDevice> <IncludeDevices>k__BackingField;

		// Token: 0x040000E2 RID: 226
		[CompilerGenerated]
		private List<InputDevice> <ExcludeDevices>k__BackingField;

		// Token: 0x040000E3 RID: 227
		[CompilerGenerated]
		private ReadOnlyCollection<PlayerAction> <Actions>k__BackingField;

		// Token: 0x040000E4 RID: 228
		[CompilerGenerated]
		private ulong <UpdateTick>k__BackingField;

		// Token: 0x040000E5 RID: 229
		public BindingSourceType LastInputType;

		// Token: 0x040000E6 RID: 230
		[CompilerGenerated]
		private Action<BindingSourceType> OnLastInputTypeChanged;

		// Token: 0x040000E7 RID: 231
		public ulong LastInputTypeChangedTick;

		// Token: 0x040000E8 RID: 232
		public InputDeviceClass LastDeviceClass;

		// Token: 0x040000E9 RID: 233
		public InputDeviceStyle LastDeviceStyle;

		// Token: 0x040000EA RID: 234
		[CompilerGenerated]
		private bool <Enabled>k__BackingField;

		// Token: 0x040000EB RID: 235
		[CompilerGenerated]
		private bool <PreventInputWhileListeningForBinding>k__BackingField;

		// Token: 0x040000EC RID: 236
		[CompilerGenerated]
		private object <UserData>k__BackingField;

		// Token: 0x040000ED RID: 237
		private List<PlayerAction> actions;

		// Token: 0x040000EE RID: 238
		private List<PlayerOneAxisAction> oneAxisActions;

		// Token: 0x040000EF RID: 239
		private List<PlayerTwoAxisAction> twoAxisActions;

		// Token: 0x040000F0 RID: 240
		private Dictionary<string, PlayerAction> actionsByName;

		// Token: 0x040000F1 RID: 241
		private BindingListenOptions listenOptions;

		// Token: 0x040000F2 RID: 242
		internal PlayerAction listenWithAction;

		// Token: 0x040000F3 RID: 243
		private InputDevice activeDevice;

		// Token: 0x040000F4 RID: 244
		private const ushort currentDataFormatVersion = 2;
	}
}
