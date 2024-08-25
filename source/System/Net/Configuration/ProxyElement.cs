using System;
using System.Configuration;

namespace System.Net.Configuration
{
	// Token: 0x0200046B RID: 1131
	public sealed class ProxyElement : ConfigurationElement
	{
		// Token: 0x06001EB4 RID: 7860 RVA: 0x0005104C File Offset: 0x0004F24C
		public ProxyElement()
		{
			throw new NotSupportedException();
		}

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x06001EB5 RID: 7861 RVA: 0x00051060 File Offset: 0x0004F260
		// (set) Token: 0x06001EB6 RID: 7862 RVA: 0x00051074 File Offset: 0x0004F274
		public ProxyElement.AutoDetectValues AutoDetect
		{
			get
			{
				throw new NotSupportedException();
			}
			set
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x06001EB7 RID: 7863 RVA: 0x00051088 File Offset: 0x0004F288
		// (set) Token: 0x06001EB8 RID: 7864 RVA: 0x0005109C File Offset: 0x0004F29C
		public ProxyElement.BypassOnLocalValues BypassOnLocal
		{
			get
			{
				throw new NotSupportedException();
			}
			set
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x06001EB9 RID: 7865 RVA: 0x000510B0 File Offset: 0x0004F2B0
		protected override ConfigurationPropertyCollection Properties
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x06001EBA RID: 7866 RVA: 0x000510C4 File Offset: 0x0004F2C4
		// (set) Token: 0x06001EBB RID: 7867 RVA: 0x000510D8 File Offset: 0x0004F2D8
		public global::System.Uri ProxyAddress
		{
			get
			{
				throw new NotSupportedException();
			}
			set
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x06001EBC RID: 7868 RVA: 0x000510EC File Offset: 0x0004F2EC
		// (set) Token: 0x06001EBD RID: 7869 RVA: 0x00051100 File Offset: 0x0004F300
		public global::System.Uri ScriptLocation
		{
			get
			{
				throw new NotSupportedException();
			}
			set
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x06001EBE RID: 7870 RVA: 0x00051114 File Offset: 0x0004F314
		// (set) Token: 0x06001EBF RID: 7871 RVA: 0x00051128 File Offset: 0x0004F328
		public ProxyElement.UseSystemDefaultValues UseSystemDefault
		{
			get
			{
				throw new NotSupportedException();
			}
			set
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x0200046C RID: 1132
		public enum AutoDetectValues
		{
			// Token: 0x04001432 RID: 5170
			False,
			// Token: 0x04001433 RID: 5171
			True,
			// Token: 0x04001434 RID: 5172
			Unspecified = -1
		}

		// Token: 0x0200046D RID: 1133
		public enum BypassOnLocalValues
		{
			// Token: 0x04001436 RID: 5174
			False,
			// Token: 0x04001437 RID: 5175
			True,
			// Token: 0x04001438 RID: 5176
			Unspecified = -1
		}

		// Token: 0x0200046E RID: 1134
		public enum UseSystemDefaultValues
		{
			// Token: 0x0400143A RID: 5178
			False,
			// Token: 0x0400143B RID: 5179
			True,
			// Token: 0x0400143C RID: 5180
			Unspecified = -1
		}
	}
}
