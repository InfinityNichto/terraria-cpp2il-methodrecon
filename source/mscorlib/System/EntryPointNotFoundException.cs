using System;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x020000A2 RID: 162
	[Serializable]
	public class EntryPointNotFoundException : TypeLoadException
	{
		// Token: 0x0600066F RID: 1647 RVA: 0x0000F8A0 File Offset: 0x0000DAA0
		public EntryPointNotFoundException()
			: base("Entry point was not found.")
		{
			this._HResult = 5411;
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x0000F8C4 File Offset: 0x0000DAC4
		public EntryPointNotFoundException(string message)
			: base(message)
		{
			this._HResult = 5411;
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x0000F8E4 File Offset: 0x0000DAE4
		protected EntryPointNotFoundException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}
