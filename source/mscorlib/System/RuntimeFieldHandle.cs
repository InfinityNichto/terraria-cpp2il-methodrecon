using System;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Cpp2IlInjected;

namespace System
{
	// Token: 0x0200018A RID: 394
	[ComVisible(true)]
	[Serializable]
	public struct RuntimeFieldHandle : ISerializable
	{
		// Token: 0x06000F3E RID: 3902 RVA: 0x000207F8 File Offset: 0x0001E9F8
		internal RuntimeFieldHandle(IntPtr v)
		{
			this.value = v;
		}

		// Token: 0x06000F3F RID: 3903 RVA: 0x0002080C File Offset: 0x0001EA0C
		private RuntimeFieldHandle(SerializationInfo info, StreamingContext context)
		{
			if (info != null)
			{
				Type type;
				object obj = info.GetValue("FieldObj", type);
				this.value = obj;
				return;
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000F40 RID: 3904 RVA: 0x0000207A File Offset: 0x0000027A
		public IntPtr Value
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06000F41 RID: 3905 RVA: 0x00020838 File Offset: 0x0001EA38
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info != null)
			{
				FieldInfo fieldInfo;
				if (fieldInfo != null)
				{
				}
				Type type;
				info.AddValue("FieldObj", fieldInfo, type);
				return;
			}
		}

		// Token: 0x06000F42 RID: 3906 RVA: 0x00020860 File Offset: 0x0001EA60
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000F43 RID: 3907 RVA: 0x0000207A File Offset: 0x0000027A
		public override int GetHashCode()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000F44 RID: 3908 RVA: 0x00020878 File Offset: 0x0001EA78
		private static void SetValueInternal(FieldInfo fi, object obj, object value)
		{
		}

		// Token: 0x06000F45 RID: 3909 RVA: 0x00020888 File Offset: 0x0001EA88
		internal static void SetValue(RuntimeFieldInfo field, object obj, object value, RuntimeType fieldType, FieldAttributes fieldAttr, RuntimeType declaringType, bool domainInitialized)
		{
		}

		// Token: 0x06000F46 RID: 3910 RVA: 0x00020898 File Offset: 0x0001EA98
		internal unsafe static void SetValueDirect(RuntimeFieldInfo field, RuntimeType fieldType, void* pTypedRef, object value, RuntimeType contextType)
		{
		}

		// Token: 0x04000695 RID: 1685
		private IntPtr value;
	}
}
