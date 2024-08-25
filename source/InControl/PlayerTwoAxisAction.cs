using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace InControl
{
	// Token: 0x02000014 RID: 20
	public class PlayerTwoAxisAction : TwoAxisInputControl
	{
		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x00003BA0 File Offset: 0x00001DA0
		// (set) Token: 0x060000E8 RID: 232 RVA: 0x00003BB4 File Offset: 0x00001DB4
		public bool InvertXAxis
		{
			[CompilerGenerated]
			get
			{
				return this.<InvertXAxis>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x00003BC4 File Offset: 0x00001DC4
		// (set) Token: 0x060000EA RID: 234 RVA: 0x00003BD8 File Offset: 0x00001DD8
		public bool InvertYAxis
		{
			[CompilerGenerated]
			get
			{
				return this.<InvertYAxis>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x060000EB RID: 235 RVA: 0x00003BE8 File Offset: 0x00001DE8
		// (remove) Token: 0x060000EC RID: 236 RVA: 0x00003C10 File Offset: 0x00001E10
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

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000ED RID: 237 RVA: 0x00003C38 File Offset: 0x00001E38
		// (set) Token: 0x060000EE RID: 238 RVA: 0x00003C4C File Offset: 0x00001E4C
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

		// Token: 0x060000EF RID: 239 RVA: 0x00003C60 File Offset: 0x00001E60
		internal PlayerTwoAxisAction(PlayerAction negativeXAction, PlayerAction positiveXAction, PlayerAction negativeYAction, PlayerAction positiveYAction)
		{
			if (!true)
			{
			}
			base..ctor();
			this.negativeXAction = negativeXAction;
			this.positiveXAction = positiveXAction;
			this.negativeYAction = negativeYAction;
			this.positiveYAction = positiveYAction;
			this.Raw = true;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00003C9C File Offset: 0x00001E9C
		internal void Update(ulong updateTick, float deltaTime)
		{
			PlayerAction playerAction = this.negativeXAction;
			this.ProcessActionUpdate(playerAction);
			PlayerAction playerAction2 = this.positiveXAction;
			this.ProcessActionUpdate(playerAction2);
			PlayerAction playerAction3 = this.negativeYAction;
			this.ProcessActionUpdate(playerAction3);
			PlayerAction playerAction4 = this.positiveYAction;
			this.ProcessActionUpdate(playerAction4);
			PlayerAction playerAction5 = this.negativeXAction;
			if (playerAction5.enabled && playerAction5.ownerEnabled)
			{
				float value = playerAction5.thisState.Value;
			}
			PlayerAction playerAction6 = this.positiveXAction;
			if (playerAction6.enabled && playerAction6.ownerEnabled)
			{
				float value2 = playerAction6.thisState.Value;
			}
			bool flag = this.<InvertXAxis>k__BackingField;
			if (playerAction6 == null)
			{
			}
			PlayerAction playerAction7 = this.negativeYAction;
			if (playerAction7.enabled && playerAction7.ownerEnabled)
			{
				float value3 = playerAction7.thisState.Value;
			}
			PlayerAction playerAction8 = this.positiveYAction;
			if (playerAction8.enabled && playerAction8.ownerEnabled)
			{
				float value4 = playerAction8.thisState.Value;
			}
			if (playerAction8 == null)
			{
			}
			if (!true)
			{
			}
			if (true)
			{
				return;
			}
			if (!this.<InvertYAxis>k__BackingField)
			{
			}
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00003DA0 File Offset: 0x00001FA0
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

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x000025E1 File Offset: 0x000007E1
		// (set) Token: 0x060000F3 RID: 243 RVA: 0x00003DE4 File Offset: 0x00001FE4
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

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x000025E1 File Offset: 0x000007E1
		// (set) Token: 0x060000F5 RID: 245 RVA: 0x00003DF4 File Offset: 0x00001FF4
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

		// Token: 0x040000FA RID: 250
		private PlayerAction negativeXAction;

		// Token: 0x040000FB RID: 251
		private PlayerAction positiveXAction;

		// Token: 0x040000FC RID: 252
		private PlayerAction negativeYAction;

		// Token: 0x040000FD RID: 253
		private PlayerAction positiveYAction;

		// Token: 0x040000FE RID: 254
		[CompilerGenerated]
		private bool <InvertXAxis>k__BackingField;

		// Token: 0x040000FF RID: 255
		[CompilerGenerated]
		private bool <InvertYAxis>k__BackingField;

		// Token: 0x04000100 RID: 256
		public BindingSourceType LastInputType;

		// Token: 0x04000101 RID: 257
		[CompilerGenerated]
		private Action<BindingSourceType> OnLastInputTypeChanged;

		// Token: 0x04000102 RID: 258
		[CompilerGenerated]
		private object <UserData>k__BackingField;
	}
}
