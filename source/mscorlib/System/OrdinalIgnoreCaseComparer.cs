using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x02000101 RID: 257
	[Serializable]
	internal sealed class OrdinalIgnoreCaseComparer : OrdinalComparer, ISerializable
	{
		// Token: 0x0600099C RID: 2460 RVA: 0x000171C4 File Offset: 0x000153C4
		public OrdinalIgnoreCaseComparer()
			: base(true)
		{
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x000171D8 File Offset: 0x000153D8
		public override int Compare(string x, string y)
		{
			return string.Compare(x, y, StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x0600099E RID: 2462 RVA: 0x000171F0 File Offset: 0x000153F0
		public override bool Equals(string x, string y)
		{
			return string.Equals(x, y, StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x00017208 File Offset: 0x00015408
		public override int GetHashCode(string obj)
		{
			if (obj != null)
			{
				return CompareInfo.GetIgnoreCaseHash(obj);
			}
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x00017220 File Offset: 0x00015420
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (!true)
			{
			}
			Type type;
			info.SetType(type);
			info.AddValue("_ignoreCase", true);
		}
	}
}
