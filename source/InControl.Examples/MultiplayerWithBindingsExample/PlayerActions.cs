using System;
using Cpp2IlInjected;
using InControl;

namespace MultiplayerWithBindingsExample
{
	// Token: 0x02000006 RID: 6
	public class PlayerActions : PlayerActionSet
	{
		// Token: 0x06000019 RID: 25 RVA: 0x000026A4 File Offset: 0x000008A4
		public PlayerActions()
		{
			PlayerAction playerAction = base.CreatePlayerAction("Green");
			this.Green = playerAction;
			PlayerAction playerAction2 = base.CreatePlayerAction("Red");
			this.Red = playerAction2;
			PlayerAction playerAction3 = base.CreatePlayerAction("Blue");
			this.Blue = playerAction3;
			PlayerAction playerAction4 = base.CreatePlayerAction("Yellow");
			this.Yellow = playerAction4;
			PlayerAction playerAction5 = base.CreatePlayerAction("Left");
			this.Left = playerAction5;
			PlayerAction playerAction6 = base.CreatePlayerAction("Right");
			this.Right = playerAction6;
			PlayerAction playerAction7 = base.CreatePlayerAction("Up");
			this.Up = playerAction7;
			PlayerAction playerAction8 = base.CreatePlayerAction("Down");
			PlayerAction left = this.Left;
			PlayerAction right = this.Right;
			PlayerAction up = this.Up;
			this.Down = playerAction8;
			PlayerTwoAxisAction playerTwoAxisAction = base.CreateTwoAxisPlayerAction(left, right, playerAction8, up);
			this.Rotate = playerTwoAxisAction;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002295 File Offset: 0x00000495
		public static PlayerActions CreateWithKeyboardBindings()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002295 File Offset: 0x00000495
		public static PlayerActions CreateWithJoystickBindings()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0400000D RID: 13
		public PlayerAction Green;

		// Token: 0x0400000E RID: 14
		public PlayerAction Red;

		// Token: 0x0400000F RID: 15
		public PlayerAction Blue;

		// Token: 0x04000010 RID: 16
		public PlayerAction Yellow;

		// Token: 0x04000011 RID: 17
		public PlayerAction Left;

		// Token: 0x04000012 RID: 18
		public PlayerAction Right;

		// Token: 0x04000013 RID: 19
		public PlayerAction Up;

		// Token: 0x04000014 RID: 20
		public PlayerAction Down;

		// Token: 0x04000015 RID: 21
		public PlayerTwoAxisAction Rotate;
	}
}
