using System;

namespace System.Configuration
{
	// Token: 0x02000454 RID: 1108
	public abstract class SettingsBase
	{
		// Token: 0x06001E04 RID: 7684 RVA: 0x0005031C File Offset: 0x0004E51C
		protected SettingsBase()
		{
			throw new NotSupportedException();
		}

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x06001E05 RID: 7685 RVA: 0x00050330 File Offset: 0x0004E530
		public virtual SettingsContext Context
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x06001E06 RID: 7686 RVA: 0x00050344 File Offset: 0x0004E544
		public bool IsSynchronized
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x170006C1 RID: 1729
		public virtual object this[string propertyName]
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

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x06001E09 RID: 7689 RVA: 0x00050380 File Offset: 0x0004E580
		public virtual SettingsPropertyCollection Properties
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x06001E0A RID: 7690 RVA: 0x00050394 File Offset: 0x0004E594
		public virtual SettingsPropertyValueCollection PropertyValues
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x06001E0B RID: 7691 RVA: 0x000503A8 File Offset: 0x0004E5A8
		public virtual SettingsProviderCollection Providers
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x06001E0C RID: 7692 RVA: 0x000503BC File Offset: 0x0004E5BC
		public void Initialize(SettingsContext context, SettingsPropertyCollection properties, SettingsProviderCollection providers)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001E0D RID: 7693 RVA: 0x000503D0 File Offset: 0x0004E5D0
		public virtual void Save()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001E0E RID: 7694 RVA: 0x000503E4 File Offset: 0x0004E5E4
		public static SettingsBase Synchronized(SettingsBase settingsBase)
		{
			throw new NotSupportedException();
		}
	}
}
