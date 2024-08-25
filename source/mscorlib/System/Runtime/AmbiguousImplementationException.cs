using System;
using System.Runtime.Serialization;

namespace System.Runtime
{
	// Token: 0x02000335 RID: 821
	[Serializable]
	public sealed class AmbiguousImplementationException : Exception
	{
		// Token: 0x06001BA7 RID: 7079 RVA: 0x0003BA60 File Offset: 0x00039C60
		public AmbiguousImplementationException()
		{
			if (!true)
			{
			}
			base..ctor("Ambiguous implementation found.");
			this._HResult = 4202;
		}

		// Token: 0x06001BA8 RID: 7080 RVA: 0x0003BA88 File Offset: 0x00039C88
		public AmbiguousImplementationException(string message)
		{
			if (!true)
			{
			}
			base..ctor(message);
			this._HResult = 4202;
		}

		// Token: 0x06001BA9 RID: 7081 RVA: 0x0003BAAC File Offset: 0x00039CAC
		private AmbiguousImplementationException(SerializationInfo info, StreamingContext context)
		{
			if (!true)
			{
			}
			base..ctor(info, context);
		}
	}
}
