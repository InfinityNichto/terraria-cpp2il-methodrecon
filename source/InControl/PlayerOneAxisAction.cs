using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace InControl
{
	// Token: 0x02000013 RID: 19
	public class PlayerOneAxisAction : OneAxisInputControl
	{
		// Token: 0x14000004 RID: 4
		// (add) Token: 0x060000DC RID: 220 RVA: 0x00003A04 File Offset: 0x00001C04
		// (remove) Token: 0x060000DD RID: 221 RVA: 0x00003A2C File Offset: 0x00001C2C
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

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000DE RID: 222 RVA: 0x00003A54 File Offset: 0x00001C54
		// (set) Token: 0x060000DF RID: 223 RVA: 0x00003A68 File Offset: 0x00001C68
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

		// Token: 0x060000E0 RID: 224 RVA: 0x00003A7C File Offset: 0x00001C7C
		internal PlayerOneAxisAction(PlayerAction negativeAction, PlayerAction positiveAction)
		{
			this.sensitivity = (float)16256;
			this.upperDeadZone = (float)16256;
			base..ctor();
			this.negativeAction = negativeAction;
			this.positiveAction = positiveAction;
			this.Raw = true;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00003ABC File Offset: 0x00001CBC
		internal void Update(ulong updateTick, float deltaTime)
		{
			PlayerAction playerAction = this.negativeAction;
			this.ProcessActionUpdate(playerAction);
			PlayerAction playerAction2 = this.positiveAction;
			this.ProcessActionUpdate(playerAction2);
			PlayerAction playerAction3 = this.negativeAction;
			if (playerAction3.enabled && playerAction3.ownerEnabled)
			{
				float value = playerAction3.thisState.Value;
			}
			PlayerAction playerAction4 = this.positiveAction;
			if (playerAction4.enabled && playerAction4.ownerEnabled)
			{
				float value2 = playerAction4.thisState.Value;
			}
			base.Commit();
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00003B3C File Offset: 0x00001D3C
		private void ProcessActionUpdate(PlayerAction action)
		{
			ulong <UpdateTick>k__BackingField = action.<UpdateTick>k__BackingField;
			ulong <UpdateTick>k__BackingField2 = this.<UpdateTick>k__BackingField;
			this.<UpdateTick>k__BackingField = <UpdateTick>k__BackingField;
			BindingSourceType lastInputType = this.LastInputType;
			BindingSourceType lastInputType2 = action.LastInputType;
			Action<BindingSourceType> onLastInputTypeChanged = this.OnLastInputTypeChanged;
			this.LastInputType = lastInputType2;
			if (onLastInputTypeChanged != null)
			{
				return;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x000025E1 File Offset: 0x000007E1
		// (set) Token: 0x060000E4 RID: 228 RVA: 0x00003B80 File Offset: 0x00001D80
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

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x000025E1 File Offset: 0x000007E1
		// (set) Token: 0x060000E6 RID: 230 RVA: 0x00003B90 File Offset: 0x00001D90
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

		// Token: 0x040000F5 RID: 245
		private PlayerAction negativeAction;

		// Token: 0x040000F6 RID: 246
		private PlayerAction positiveAction;

		// Token: 0x040000F7 RID: 247
		public BindingSourceType LastInputType;

		// Token: 0x040000F8 RID: 248
		[CompilerGenerated]
		private Action<BindingSourceType> OnLastInputTypeChanged;

		// Token: 0x040000F9 RID: 249
		[CompilerGenerated]
		private object <UserData>k__BackingField;
	}
}
