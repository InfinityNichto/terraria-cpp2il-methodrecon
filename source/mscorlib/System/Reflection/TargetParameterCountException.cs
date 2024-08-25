using System;
using System.Runtime.Serialization;

namespace System.Reflection
{
	// Token: 0x020004F4 RID: 1268
	[Serializable]
	public sealed class TargetParameterCountException : ApplicationException
	{
		// Token: 0x060024D5 RID: 9429 RVA: 0x00051620 File Offset: 0x0004F820
		public TargetParameterCountException()
			: base("Number of parameters specified does not match the expected number.")
		{
			this._HResult = 14;
		}

		// Token: 0x060024D6 RID: 9430 RVA: 0x00051640 File Offset: 0x0004F840
		public TargetParameterCountException(string message)
			: base(message)
		{
			this._HResult = 14;
		}

		// Token: 0x060024D7 RID: 9431 RVA: 0x0005165C File Offset: 0x0004F85C
		internal TargetParameterCountException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}
