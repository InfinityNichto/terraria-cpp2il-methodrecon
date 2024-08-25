using System;
using System.Runtime.Serialization;
using Cpp2IlInjected;

namespace System.Reflection
{
	// Token: 0x020004E0 RID: 1248
	public sealed class Missing : ISerializable
	{
		// Token: 0x060023F2 RID: 9202 RVA: 0x00050ACC File Offset: 0x0004ECCC
		private Missing()
		{
		}

		// Token: 0x060023F3 RID: 9203 RVA: 0x0000207A File Offset: 0x0000027A
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060023F4 RID: 9204 RVA: 0x00050AE0 File Offset: 0x0004ECE0
		// Note: this type is marked as 'beforefieldinit'.
		static Missing()
		{
		}

		// Token: 0x040013E8 RID: 5096
		public static readonly Missing Value;
	}
}
