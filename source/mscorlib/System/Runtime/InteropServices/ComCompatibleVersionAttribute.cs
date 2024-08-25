using System;

namespace System.Runtime.InteropServices
{
	// Token: 0x0200044B RID: 1099
	[ComVisible(true)]
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public sealed class ComCompatibleVersionAttribute : Attribute
	{
		// Token: 0x06002179 RID: 8569 RVA: 0x0004C1B0 File Offset: 0x0004A3B0
		public ComCompatibleVersionAttribute(int major, int minor, int build, int revision)
		{
			this._major = major;
			this._build = minor;
			this._build = build;
		}

		// Token: 0x04001271 RID: 4721
		internal int _major;

		// Token: 0x04001272 RID: 4722
		internal int _minor;

		// Token: 0x04001273 RID: 4723
		internal int _build;

		// Token: 0x04001274 RID: 4724
		internal int _revision;
	}
}
