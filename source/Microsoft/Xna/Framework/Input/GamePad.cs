using System;

namespace Microsoft.Xna.Framework.Input
{
	// Token: 0x02000341 RID: 833
	public static class GamePad
	{
		// Token: 0x060014F6 RID: 5366 RVA: 0x0005F818 File Offset: 0x0005DA18
		public static GamePadCapabilities GetCapabilities(PlayerIndex playerIndex)
		{
			GamePadCapabilities gamePadCapabilities;
			return gamePadCapabilities;
		}

		// Token: 0x060014F7 RID: 5367 RVA: 0x0005F828 File Offset: 0x0005DA28
		public static GamePadCapabilities GetCapabilities(int index)
		{
			GamePadCapabilities gamePadCapabilities;
			return gamePadCapabilities;
		}

		// Token: 0x060014F8 RID: 5368 RVA: 0x0005F838 File Offset: 0x0005DA38
		public static GamePadState GetState(PlayerIndex playerIndex)
		{
			GamePadState gamePadState;
			gamePadState.<Triggers>k__BackingField = gamePadState;
			return gamePadState;
		}

		// Token: 0x060014F9 RID: 5369 RVA: 0x0005F850 File Offset: 0x0005DA50
		public static GamePadState GetState(int index)
		{
			GamePadState state = GamePad.GetState(index, GamePadDeadZone.IndependentAxes);
			GamePadState gamePadState;
			gamePadState.<Triggers>k__BackingField = gamePadState;
			return gamePadState;
		}

		// Token: 0x060014FA RID: 5370 RVA: 0x0005F870 File Offset: 0x0005DA70
		public static GamePadState GetState(PlayerIndex playerIndex, GamePadDeadZone deadZoneMode)
		{
			GamePadState gamePadState;
			gamePadState.<Triggers>k__BackingField = gamePadState;
			return gamePadState;
		}

		// Token: 0x060014FB RID: 5371 RVA: 0x0005F888 File Offset: 0x0005DA88
		public static GamePadState GetState(int index, GamePadDeadZone deadZoneMode)
		{
			if (!true)
			{
			}
			GamePadState gamePadState;
			gamePadState.<IsConnected>k__BackingField = true;
			return 1;
		}

		// Token: 0x060014FC RID: 5372 RVA: 0x0005F8A0 File Offset: 0x0005DAA0
		public static GamePadState GetState(PlayerIndex playerIndex, GamePadDeadZone leftDeadZoneMode, GamePadDeadZone rightDeadZoneMode)
		{
			if (!true)
			{
			}
			GamePadState gamePadState;
			gamePadState.<IsConnected>k__BackingField = true;
			return 1;
		}

		// Token: 0x060014FD RID: 5373 RVA: 0x0005F8B8 File Offset: 0x0005DAB8
		public static GamePadState GetState(int index, GamePadDeadZone leftDeadZoneMode, GamePadDeadZone rightDeadZoneMode)
		{
			if (!true)
			{
			}
			GamePadState gamePadState;
			gamePadState.<IsConnected>k__BackingField = true;
			return 1;
		}

		// Token: 0x060014FE RID: 5374 RVA: 0x0005F8D0 File Offset: 0x0005DAD0
		public static bool SetVibration(PlayerIndex playerIndex, float leftMotor, float rightMotor)
		{
		}

		// Token: 0x060014FF RID: 5375 RVA: 0x0005F8E0 File Offset: 0x0005DAE0
		public static bool SetVibration(int index, float leftMotor, float rightMotor)
		{
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06001500 RID: 5376 RVA: 0x0005F8F0 File Offset: 0x0005DAF0
		public static int MaximumGamePadCount
		{
			get
			{
			}
		}
	}
}
