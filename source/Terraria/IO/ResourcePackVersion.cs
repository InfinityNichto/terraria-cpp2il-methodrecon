using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Newtonsoft.Json;

namespace Terraria.IO
{
	// Token: 0x02000567 RID: 1383
	[DebuggerDisplay("Version {Major}.{Minor}")]
	public struct ResourcePackVersion : IComparable, IComparable<ResourcePackVersion>
	{
		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x060033B7 RID: 13239 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x060033B8 RID: 13240 RVA: 0x002005C8 File Offset: 0x001FE7C8
		[JsonProperty("major")]
		public int Major
		{
			[CompilerGenerated]
			readonly get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[CompilerGenerated]
			private set
			{
				this.<Major>k__BackingField = value;
			}
		}

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x060033B9 RID: 13241 RVA: 0x002005DC File Offset: 0x001FE7DC
		// (set) Token: 0x060033BA RID: 13242 RVA: 0x002005F0 File Offset: 0x001FE7F0
		[JsonProperty("minor")]
		public int Minor
		{
			[CompilerGenerated]
			readonly get
			{
				return this.<Minor>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Minor>k__BackingField = value;
			}
		}

		// Token: 0x060033BB RID: 13243 RVA: 0x00200604 File Offset: 0x001FE804
		public int CompareTo(object obj)
		{
			if (obj != null)
			{
				int num;
				return num;
			}
			return 1;
		}

		// Token: 0x060033BC RID: 13244 RVA: 0x00200618 File Offset: 0x001FE818
		public int CompareTo(ResourcePackVersion other)
		{
			int num;
			if (num == 0)
			{
				int num2 = this.<Minor>k__BackingField;
			}
			int num3;
			return num3;
		}

		// Token: 0x060033BD RID: 13245 RVA: 0x000021DB File Offset: 0x000003DB
		public static bool operator ==(ResourcePackVersion lhs, ResourcePackVersion rhs)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060033BE RID: 13246 RVA: 0x000021DB File Offset: 0x000003DB
		public static bool operator !=(ResourcePackVersion lhs, ResourcePackVersion rhs)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060033BF RID: 13247 RVA: 0x000021DB File Offset: 0x000003DB
		public static bool operator <(ResourcePackVersion lhs, ResourcePackVersion rhs)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060033C0 RID: 13248 RVA: 0x000021DB File Offset: 0x000003DB
		public static bool operator >(ResourcePackVersion lhs, ResourcePackVersion rhs)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060033C1 RID: 13249 RVA: 0x00200630 File Offset: 0x001FE830
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
				return;
			}
		}

		// Token: 0x060033C2 RID: 13250 RVA: 0x00200644 File Offset: 0x001FE844
		public override int GetHashCode()
		{
			int num = this.<Major>k__BackingField;
			int num2;
			return num2;
		}

		// Token: 0x060033C3 RID: 13251 RVA: 0x0020065C File Offset: 0x001FE85C
		public string GetFormattedVersion()
		{
			int num = this.<Minor>k__BackingField;
			string text;
			string text2;
			return text + "." + text2;
		}

		// Token: 0x04003C65 RID: 15461
		[CompilerGenerated]
		private int <Major>k__BackingField;

		// Token: 0x04003C66 RID: 15462
		[CompilerGenerated]
		private int <Minor>k__BackingField;
	}
}
