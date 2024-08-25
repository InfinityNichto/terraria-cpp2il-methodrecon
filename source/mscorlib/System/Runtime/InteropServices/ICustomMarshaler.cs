using System;

namespace System.Runtime.InteropServices
{
	// Token: 0x02000436 RID: 1078
	public interface ICustomMarshaler
	{
		// Token: 0x06002161 RID: 8545
		object MarshalNativeToManaged(IntPtr pNativeData);

		// Token: 0x06002162 RID: 8546
		IntPtr MarshalManagedToNative(object ManagedObj);

		// Token: 0x06002163 RID: 8547
		void CleanUpNativeData(IntPtr pNativeData);

		// Token: 0x06002164 RID: 8548
		void CleanUpManagedData(object ManagedObj);

		// Token: 0x06002165 RID: 8549
		int GetNativeDataSize();
	}
}
