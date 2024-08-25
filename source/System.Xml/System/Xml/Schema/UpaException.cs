using System;

namespace System.Xml.Schema
{
	// Token: 0x020000C4 RID: 196
	internal class UpaException : Exception
	{
		// Token: 0x06000811 RID: 2065 RVA: 0x00019DF4 File Offset: 0x00017FF4
		public UpaException(object particle1, object particle2)
		{
			if (!true)
			{
			}
			base..ctor();
			this.particle1 = particle1;
			this.particle2 = particle2;
		}

		// Token: 0x04000418 RID: 1048
		private object particle1;

		// Token: 0x04000419 RID: 1049
		private object particle2;
	}
}
