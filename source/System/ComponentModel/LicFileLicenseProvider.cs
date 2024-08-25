using System;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;

namespace System.ComponentModel
{
	// Token: 0x02000391 RID: 913
	public class LicFileLicenseProvider : LicenseProvider
	{
		// Token: 0x060017C4 RID: 6084 RVA: 0x0004385C File Offset: 0x00041A5C
		protected virtual bool IsKeyValid(string key, Type type)
		{
			if (key != null)
			{
				bool flag;
				return flag;
			}
		}

		// Token: 0x060017C5 RID: 6085 RVA: 0x00043870 File Offset: 0x00041A70
		protected virtual string GetKey(Type type)
		{
			if (!true)
			{
			}
			return string.Format(CultureInfo.InvariantCulture, "{0} is a licensed component.", type);
		}

		// Token: 0x060017C6 RID: 6086 RVA: 0x00043894 File Offset: 0x00041A94
		public override License GetLicense(LicenseContext context, Type type, object instance, bool allowExceptions)
		{
			if (context != null && context != null)
			{
				if (context == null)
				{
					goto IL_000F;
				}
				if (context == null)
				{
					goto IL_0016;
				}
			}
			while (context == null)
			{
			}
			IL_000F:
			string text;
			bool flag = File.Exists(text);
			IL_0016:
			throw new InvalidCastException();
		}

		// Token: 0x060017C7 RID: 6087 RVA: 0x000438BC File Offset: 0x00041ABC
		public LicFileLicenseProvider()
		{
		}

		// Token: 0x02000392 RID: 914
		private class LicFileLicense : License
		{
			// Token: 0x060017C8 RID: 6088 RVA: 0x000438D0 File Offset: 0x00041AD0
			public LicFileLicense(LicFileLicenseProvider owner, string key)
			{
				this._owner = owner;
				this.LicenseKey = key;
			}

			// Token: 0x1700056C RID: 1388
			// (get) Token: 0x060017C9 RID: 6089 RVA: 0x000438F4 File Offset: 0x00041AF4
			public override string LicenseKey
			{
				[CompilerGenerated]
				get
				{
					return this.<LicenseKey>k__BackingField;
				}
			}

			// Token: 0x060017CA RID: 6090 RVA: 0x00043908 File Offset: 0x00041B08
			public override void Dispose()
			{
				if (!true)
				{
				}
				GC.SuppressFinalize(this);
			}

			// Token: 0x0400122D RID: 4653
			private LicFileLicenseProvider _owner;

			// Token: 0x0400122E RID: 4654
			[CompilerGenerated]
			private readonly string <LicenseKey>k__BackingField;
		}
	}
}
