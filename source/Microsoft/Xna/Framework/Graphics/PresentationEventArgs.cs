using System;
using System.Runtime.CompilerServices;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x02000383 RID: 899
	internal class PresentationEventArgs : EventArgs
	{
		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x060017CB RID: 6091 RVA: 0x00065B40 File Offset: 0x00063D40
		// (set) Token: 0x060017CC RID: 6092 RVA: 0x00065B54 File Offset: 0x00063D54
		public PresentationParameters PresentationParameters
		{
			[CompilerGenerated]
			get
			{
				return this.<PresentationParameters>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<PresentationParameters>k__BackingField = value;
			}
		}

		// Token: 0x060017CD RID: 6093 RVA: 0x00065B68 File Offset: 0x00063D68
		public PresentationEventArgs(PresentationParameters presentationParameters)
		{
			if (!true)
			{
			}
			base..ctor();
			this.PresentationParameters = presentationParameters;
		}

		// Token: 0x04002623 RID: 9763
		[CompilerGenerated]
		private PresentationParameters <PresentationParameters>k__BackingField;
	}
}
