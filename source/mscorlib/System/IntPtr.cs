using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Cpp2IlInjected;

namespace System
{
	// Token: 0x0200017D RID: 381
	[ComVisible(true)]
	[Serializable]
	public readonly struct IntPtr : ISerializable, IEquatable<IntPtr>
	{
		// Token: 0x06000EEB RID: 3819 RVA: 0x00020014 File Offset: 0x0001E214
		[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
		public IntPtr(int value)
		{
		}

		// Token: 0x06000EEC RID: 3820 RVA: 0x00020024 File Offset: 0x0001E224
		[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
		public IntPtr(long value)
		{
			this.m_value = value;
		}

		// Token: 0x06000EED RID: 3821 RVA: 0x00020038 File Offset: 0x0001E238
		[CLSCompliant(false)]
		[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
		public unsafe IntPtr(void* value)
		{
			this.m_value = value;
		}

		// Token: 0x06000EEE RID: 3822 RVA: 0x0002004C File Offset: 0x0001E24C
		private IntPtr(SerializationInfo info, StreamingContext context)
		{
			long num;
			this.m_value = num;
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000EEF RID: 3823 RVA: 0x00020060 File Offset: 0x0001E260
		public static int Size
		{
			[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
			get
			{
				return 8;
			}
		}

		// Token: 0x06000EF0 RID: 3824 RVA: 0x00020070 File Offset: 0x0001E270
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			while (info == null)
			{
			}
		}

		// Token: 0x06000EF1 RID: 3825 RVA: 0x00020080 File Offset: 0x0001E280
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
				return;
			}
		}

		// Token: 0x06000EF2 RID: 3826 RVA: 0x0000207A File Offset: 0x0000027A
		public override int GetHashCode()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000EF3 RID: 3827 RVA: 0x0000207A File Offset: 0x0000027A
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public long ToInt64()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000EF4 RID: 3828 RVA: 0x0000207A File Offset: 0x0000027A
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[CLSCompliant(false)]
		public unsafe void* ToPointer()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000EF5 RID: 3829 RVA: 0x00020094 File Offset: 0x0001E294
		public override string ToString()
		{
			string text;
			return text;
		}

		// Token: 0x06000EF6 RID: 3830 RVA: 0x000200A4 File Offset: 0x0001E2A4
		public string ToString(string format)
		{
			string text;
			return text;
		}

		// Token: 0x06000EF7 RID: 3831 RVA: 0x0000207A File Offset: 0x0000027A
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static bool operator ==(IntPtr value1, IntPtr value2)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000EF8 RID: 3832 RVA: 0x0000207A File Offset: 0x0000027A
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static bool operator !=(IntPtr value1, IntPtr value2)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000EF9 RID: 3833 RVA: 0x0000207A File Offset: 0x0000027A
		[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
		public static explicit operator IntPtr(int value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000EFA RID: 3834 RVA: 0x0000207A File Offset: 0x0000027A
		[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
		public static explicit operator IntPtr(long value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000EFB RID: 3835 RVA: 0x0000207A File Offset: 0x0000027A
		[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
		[CLSCompliant(false)]
		public unsafe static explicit operator IntPtr(void* value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000EFC RID: 3836 RVA: 0x0000207A File Offset: 0x0000027A
		public static explicit operator int(IntPtr value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000EFD RID: 3837 RVA: 0x0000207A File Offset: 0x0000027A
		public static explicit operator long(IntPtr value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000EFE RID: 3838 RVA: 0x0000207A File Offset: 0x0000027A
		[CLSCompliant(false)]
		public unsafe static explicit operator void*(IntPtr value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000EFF RID: 3839 RVA: 0x0000207A File Offset: 0x0000027A
		[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
		public static IntPtr Add(IntPtr pointer, int offset)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000F00 RID: 3840 RVA: 0x0000207A File Offset: 0x0000027A
		[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
		public static IntPtr operator +(IntPtr pointer, int offset)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000F01 RID: 3841 RVA: 0x0000207A File Offset: 0x0000027A
		[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
		public static IntPtr operator -(IntPtr pointer, int offset)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000F02 RID: 3842 RVA: 0x0000207A File Offset: 0x0000027A
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		internal bool IsNull()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000F03 RID: 3843 RVA: 0x0000207A File Offset: 0x0000027A
		bool IEquatable<IntPtr>.Equals(IntPtr other)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0400067A RID: 1658
		private unsafe readonly void* m_value;

		// Token: 0x0400067B RID: 1659
		public static readonly IntPtr Zero;
	}
}
