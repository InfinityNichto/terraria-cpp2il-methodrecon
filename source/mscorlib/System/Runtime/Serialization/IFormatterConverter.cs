using System;

namespace System.Runtime.Serialization
{
	// Token: 0x020003C5 RID: 965
	[CLSCompliant(false)]
	public interface IFormatterConverter
	{
		// Token: 0x06001EBE RID: 7870
		object Convert(object value, Type type);

		// Token: 0x06001EBF RID: 7871
		bool ToBoolean(object value);

		// Token: 0x06001EC0 RID: 7872
		int ToInt32(object value);

		// Token: 0x06001EC1 RID: 7873
		long ToInt64(object value);

		// Token: 0x06001EC2 RID: 7874
		float ToSingle(object value);

		// Token: 0x06001EC3 RID: 7875
		string ToString(object value);
	}
}
