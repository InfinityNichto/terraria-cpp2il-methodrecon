using System;
using ReLogic.Reflection;

namespace Terraria.ID
{
	// Token: 0x020005F3 RID: 1523
	public class StatusID
	{
		// Token: 0x0600359B RID: 13723 RVA: 0x00211464 File Offset: 0x0020F664
		public StatusID()
		{
		}

		// Token: 0x0600359C RID: 13724 RVA: 0x00211478 File Offset: 0x0020F678
		// Note: this type is marked as 'beforefieldinit'.
		static StatusID()
		{
		}

		// Token: 0x04006FA8 RID: 28584
		public const int Ok = 0;

		// Token: 0x04006FA9 RID: 28585
		public const int LaterVersion = 1;

		// Token: 0x04006FAA RID: 28586
		public const int UnknownError = 2;

		// Token: 0x04006FAB RID: 28587
		public const int EmptyFile = 3;

		// Token: 0x04006FAC RID: 28588
		public const int DecryptionError = 4;

		// Token: 0x04006FAD RID: 28589
		public const int BadSectionPointer = 5;

		// Token: 0x04006FAE RID: 28590
		public const int BadFooter = 6;

		// Token: 0x04006FAF RID: 28591
		public static readonly IdDictionary Search;
	}
}
