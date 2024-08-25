using System;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x020000A0 RID: 160
	[Serializable]
	public class DllNotFoundException : TypeLoadException
	{
		// Token: 0x06000647 RID: 1607 RVA: 0x0000F4DC File Offset: 0x0000D6DC
		public DllNotFoundException()
			: base("Dll was not found.")
		{
			this._HResult = 5412;
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x0000F500 File Offset: 0x0000D700
		public DllNotFoundException(string message)
			: base(message)
		{
			this._HResult = 5412;
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x0000F520 File Offset: 0x0000D720
		protected DllNotFoundException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}
