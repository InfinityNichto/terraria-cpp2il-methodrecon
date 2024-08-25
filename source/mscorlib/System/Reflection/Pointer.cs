using System;
using System.Runtime.Serialization;
using Cpp2IlInjected;

namespace System.Reflection
{
	// Token: 0x020004E5 RID: 1253
	[CLSCompliant(false)]
	public sealed class Pointer : ISerializable
	{
		// Token: 0x06002416 RID: 9238 RVA: 0x00050D90 File Offset: 0x0004EF90
		private unsafe Pointer(void* ptr, Type ptrType)
		{
			this._ptr = ptr;
			this._ptrType = ptrType;
		}

		// Token: 0x06002417 RID: 9239 RVA: 0x00050DB4 File Offset: 0x0004EFB4
		public unsafe static object Box(void* ptr, Type type)
		{
			if (!true)
			{
			}
			return "Type must be a Pointer.";
		}

		// Token: 0x06002418 RID: 9240 RVA: 0x0000207A File Offset: 0x0000027A
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x04001400 RID: 5120
		private unsafe readonly void* _ptr;

		// Token: 0x04001401 RID: 5121
		private readonly Type _ptrType;
	}
}
