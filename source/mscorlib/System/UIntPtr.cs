using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Cpp2IlInjected;

namespace System
{
	// Token: 0x020001A0 RID: 416
	[CLSCompliant(false)]
	[ComVisible(true)]
	[Serializable]
	public readonly struct UIntPtr : ISerializable, IEquatable<UIntPtr>
	{
		// Token: 0x06000FE4 RID: 4068 RVA: 0x00021FE8 File Offset: 0x000201E8
		public UIntPtr(ulong value)
		{
			if (true)
			{
			}
			this._pointer = value;
		}

		// Token: 0x06000FE5 RID: 4069 RVA: 0x00022000 File Offset: 0x00020200
		public UIntPtr(uint value)
		{
			this._pointer = value;
		}

		// Token: 0x06000FE6 RID: 4070 RVA: 0x00022014 File Offset: 0x00020214
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
				return;
			}
		}

		// Token: 0x06000FE7 RID: 4071 RVA: 0x0000207A File Offset: 0x0000027A
		public override int GetHashCode()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000FE8 RID: 4072 RVA: 0x00022028 File Offset: 0x00020228
		public override string ToString()
		{
			if (!true)
			{
			}
			string text;
			return text;
		}

		// Token: 0x06000FE9 RID: 4073 RVA: 0x0002203C File Offset: 0x0002023C
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			while (info == null)
			{
			}
		}

		// Token: 0x06000FEA RID: 4074 RVA: 0x0000207A File Offset: 0x0000027A
		public static bool operator ==(UIntPtr value1, UIntPtr value2)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000FEB RID: 4075 RVA: 0x0000207A File Offset: 0x0000027A
		public static bool operator !=(UIntPtr value1, UIntPtr value2)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000FEC RID: 4076 RVA: 0x0000207A File Offset: 0x0000027A
		public static explicit operator UIntPtr(ulong value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000FED RID: 4077 RVA: 0x0000207A File Offset: 0x0000027A
		public static explicit operator UIntPtr(uint value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000FEE RID: 4078 RVA: 0x0002204C File Offset: 0x0002024C
		public static int Size
		{
			get
			{
				return 8;
			}
		}

		// Token: 0x06000FEF RID: 4079 RVA: 0x0000207A File Offset: 0x0000027A
		bool IEquatable<UIntPtr>.Equals(UIntPtr other)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000FF0 RID: 4080 RVA: 0x0002205C File Offset: 0x0002025C
		// Note: this type is marked as 'beforefieldinit'.
		static UIntPtr()
		{
		}

		// Token: 0x04000890 RID: 2192
		public static readonly UIntPtr Zero;

		// Token: 0x04000891 RID: 2193
		private unsafe readonly void* _pointer;
	}
}
