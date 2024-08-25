using System;

namespace System.ComponentModel.Design
{
	// Token: 0x02000411 RID: 1041
	public interface IReferenceService
	{
		// Token: 0x06001C0F RID: 7183
		object GetReference(string name);

		// Token: 0x06001C10 RID: 7184
		string GetName(object reference);

		// Token: 0x06001C11 RID: 7185
		object[] GetReferences(Type baseType);
	}
}
