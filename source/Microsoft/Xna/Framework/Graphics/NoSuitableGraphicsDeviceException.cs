using System;
using System.Runtime.Serialization;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x02000382 RID: 898
	[DataContract]
	public sealed class NoSuitableGraphicsDeviceException : Exception
	{
		// Token: 0x060017C8 RID: 6088 RVA: 0x00065AF8 File Offset: 0x00063CF8
		public NoSuitableGraphicsDeviceException()
		{
			if (!true)
			{
			}
			base..ctor();
		}

		// Token: 0x060017C9 RID: 6089 RVA: 0x00065B10 File Offset: 0x00063D10
		public NoSuitableGraphicsDeviceException(string message)
		{
			if (!true)
			{
			}
			base..ctor(message);
		}

		// Token: 0x060017CA RID: 6090 RVA: 0x00065B28 File Offset: 0x00063D28
		public NoSuitableGraphicsDeviceException(string message, Exception inner)
		{
			if (!true)
			{
			}
			base..ctor(message, inner);
		}
	}
}
