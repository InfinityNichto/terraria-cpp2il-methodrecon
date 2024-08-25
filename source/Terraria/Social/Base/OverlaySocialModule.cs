using System;

namespace Terraria.Social.Base
{
	// Token: 0x0200052C RID: 1324
	public abstract class OverlaySocialModule : ISocialModule
	{
		// Token: 0x060031E5 RID: 12773
		public abstract void Initialize();

		// Token: 0x060031E6 RID: 12774
		public abstract void Shutdown();

		// Token: 0x060031E7 RID: 12775
		public abstract bool IsGamepadTextInputActive();

		// Token: 0x060031E8 RID: 12776
		public abstract bool ShowGamepadTextInput(string description, uint maxLength, bool multiLine = false, string existingText = "", bool password = false);

		// Token: 0x060031E9 RID: 12777
		public abstract string GetGamepadText();

		// Token: 0x060031EA RID: 12778 RVA: 0x001F8DEC File Offset: 0x001F6FEC
		protected OverlaySocialModule()
		{
		}
	}
}
