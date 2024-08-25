using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata;

namespace System.Runtime.Remoting
{
	// Token: 0x02000341 RID: 833
	[ComVisible(true)]
	public class InternalRemotingServices
	{
		// Token: 0x06001BD2 RID: 7122 RVA: 0x0003BE9C File Offset: 0x0003A09C
		public static SoapAttribute GetCachedSoapAttribute(object reflectionObject)
		{
			Type type;
			do
			{
				if (!true)
				{
				}
				if (type == null)
				{
					goto IL_002B;
				}
			}
			while (type != null);
			throw new InvalidCastException();
			IL_002B:
			throw new InvalidCastException();
		}

		// Token: 0x06001BD3 RID: 7123 RVA: 0x0003BEE4 File Offset: 0x0003A0E4
		// Note: this type is marked as 'beforefieldinit'.
		static InternalRemotingServices()
		{
		}

		// Token: 0x04000E29 RID: 3625
		private static Hashtable _soapAttributes;
	}
}
