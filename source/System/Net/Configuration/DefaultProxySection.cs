using System;
using System.Configuration;

namespace System.Net.Configuration
{
	// Token: 0x02000469 RID: 1129
	public sealed class DefaultProxySection : ConfigurationSection
	{
		// Token: 0x06001EA5 RID: 7845 RVA: 0x00050F20 File Offset: 0x0004F120
		public DefaultProxySection()
		{
			throw new NotSupportedException();
		}

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x06001EA6 RID: 7846 RVA: 0x00050F34 File Offset: 0x0004F134
		public BypassElementCollection BypassList
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x06001EA7 RID: 7847 RVA: 0x00050F48 File Offset: 0x0004F148
		// (set) Token: 0x06001EA8 RID: 7848 RVA: 0x00050F5C File Offset: 0x0004F15C
		public bool Enabled
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

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x06001EA9 RID: 7849 RVA: 0x00050F70 File Offset: 0x0004F170
		public ModuleElement Module
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x06001EAA RID: 7850 RVA: 0x00050F84 File Offset: 0x0004F184
		protected override ConfigurationPropertyCollection Properties
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x06001EAB RID: 7851 RVA: 0x00050F98 File Offset: 0x0004F198
		public ProxyElement Proxy
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x06001EAC RID: 7852 RVA: 0x00050FAC File Offset: 0x0004F1AC
		// (set) Token: 0x06001EAD RID: 7853 RVA: 0x00050FC0 File Offset: 0x0004F1C0
		public bool UseDefaultCredentials
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

		// Token: 0x06001EAE RID: 7854 RVA: 0x00050FD4 File Offset: 0x0004F1D4
		protected override void PostDeserialize()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001EAF RID: 7855 RVA: 0x00050FE8 File Offset: 0x0004F1E8
		protected override void Reset(ConfigurationElement parentElement)
		{
			throw new NotSupportedException();
		}
	}
}
