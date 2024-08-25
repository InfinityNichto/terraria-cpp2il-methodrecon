using System;
using System.Collections.Generic;
using Terraria;
using UnityEngine;

namespace Microsoft.Xna.Framework.Input
{
	// Token: 0x02000350 RID: 848
	public static class Keyboard
	{
		// Token: 0x060015C8 RID: 5576 RVA: 0x0006116C File Offset: 0x0005F36C
		public static KeyboardState GetState()
		{
			if (!true)
			{
			}
			KeyboardState keyboardState = Keyboard.PlatformGetState();
			KeyboardState keyboardState2;
			keyboardState2.<CapsLock>k__BackingField = true;
			return 1;
		}

		// Token: 0x060015C9 RID: 5577 RVA: 0x0006118C File Offset: 0x0005F38C
		[Obsolete("Use GetState() instead. In future versions this method can be removed.")]
		public static KeyboardState GetState(PlayerIndex playerIndex)
		{
			if (!true)
			{
			}
			KeyboardState keyboardState = Keyboard.PlatformGetState();
			KeyboardState keyboardState2;
			keyboardState2.<CapsLock>k__BackingField = true;
			return 1;
		}

		// Token: 0x060015CA RID: 5578 RVA: 0x000611AC File Offset: 0x0005F3AC
		private static KeyboardState PlatformGetState()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			bool hasKeyboard = Main.HasKeyboard;
			if (num == 0)
			{
			}
			int num3;
			if (num != 0)
			{
				int num2 = 1;
				DrPlatform.DrPlatformType currentPlatform = DrPlatform.CurrentPlatform;
				if (num == 0)
				{
				}
				if (num2 != 0)
				{
					DrPlatform.DrPlatformType currentPlatform2 = DrPlatform.CurrentPlatform;
					DrPlatform.DrPlatformType currentPlatform3 = DrPlatform.CurrentPlatform;
				}
				if (num == 0)
				{
				}
				num3 = 1;
				if (num == 0)
				{
				}
			}
			if (num == 0)
			{
			}
			if (num3 == 0)
			{
			}
			if (num3 == 0)
			{
				return;
			}
		}

		// Token: 0x060015CB RID: 5579 RVA: 0x0006121C File Offset: 0x0005F41C
		internal static void SetKeys(List<Keys> keys)
		{
			if (!true)
			{
			}
		}

		// Token: 0x060015CC RID: 5580 RVA: 0x0006122C File Offset: 0x0005F42C
		// Note: this type is marked as 'beforefieldinit'.
		static Keyboard()
		{
		}

		// Token: 0x04002332 RID: 9010
		public static KeyCode[] keyCodes;

		// Token: 0x04002333 RID: 9011
		public static Keys[] keys;

		// Token: 0x04002334 RID: 9012
		public static bool keyboardActive;

		// Token: 0x04002335 RID: 9013
		private static List<Keys> _keys;

		// Token: 0x04002336 RID: 9014
		public static List<KeyCode> UnityKeys;

		// Token: 0x04002337 RID: 9015
		public static List<KeyCode> LastUnityKeys;

		// Token: 0x04002338 RID: 9016
		public static bool IgnoreEnterUntilClear;
	}
}
