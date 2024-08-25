using System;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x020000D3 RID: 211
	[Serializable]
	public sealed class InvalidProgramException : SystemException
	{
		// Token: 0x060007DA RID: 2010 RVA: 0x00012AF4 File Offset: 0x00010CF4
		public InvalidProgramException()
			: base("Common Language Runtime detected an invalid program.")
		{
			this._HResult = 5434;
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x00012B18 File Offset: 0x00010D18
		public InvalidProgramException(string message)
			: base(message)
		{
			this._HResult = 5434;
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x00012B38 File Offset: 0x00010D38
		internal InvalidProgramException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}
