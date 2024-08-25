using System;

namespace System.ComponentModel.Design
{
	// Token: 0x0200040F RID: 1039
	public interface IDictionaryService
	{
		// Token: 0x06001C0C RID: 7180
		object GetValue(object key);

		// Token: 0x06001C0D RID: 7181
		void SetValue(object key, object value);
	}
}
