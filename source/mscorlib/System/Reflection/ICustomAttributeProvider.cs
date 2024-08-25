using System;

namespace System.Reflection
{
	// Token: 0x020004D6 RID: 1238
	public interface ICustomAttributeProvider
	{
		// Token: 0x060023AB RID: 9131
		object[] GetCustomAttributes(bool inherit);

		// Token: 0x060023AC RID: 9132
		object[] GetCustomAttributes(Type attributeType, bool inherit);

		// Token: 0x060023AD RID: 9133
		bool IsDefined(Type attributeType, bool inherit);
	}
}
