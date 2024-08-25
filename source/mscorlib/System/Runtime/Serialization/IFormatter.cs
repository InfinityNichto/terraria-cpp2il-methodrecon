using System;
using System.IO;
using System.Runtime.InteropServices;

namespace System.Runtime.Serialization
{
	// Token: 0x020003DA RID: 986
	[ComVisible(true)]
	public interface IFormatter
	{
		// Token: 0x06001F1A RID: 7962
		object Deserialize(Stream serializationStream);
	}
}
