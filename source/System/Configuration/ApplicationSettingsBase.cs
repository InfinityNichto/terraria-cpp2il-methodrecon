using System;
using System.ComponentModel;

namespace System.Configuration
{
	// Token: 0x02000488 RID: 1160
	public abstract class ApplicationSettingsBase : SettingsBase, global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x06001F7F RID: 8063 RVA: 0x00052020 File Offset: 0x00050220
		protected ApplicationSettingsBase()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001F80 RID: 8064 RVA: 0x00052034 File Offset: 0x00050234
		protected ApplicationSettingsBase(global::System.ComponentModel.IComponent owner)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001F81 RID: 8065 RVA: 0x00052048 File Offset: 0x00050248
		protected ApplicationSettingsBase(global::System.ComponentModel.IComponent owner, string settingsKey)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001F82 RID: 8066 RVA: 0x0005205C File Offset: 0x0005025C
		protected ApplicationSettingsBase(string settingsKey)
		{
			throw new NotSupportedException();
		}

		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x06001F83 RID: 8067 RVA: 0x00052070 File Offset: 0x00050270
		public override SettingsContext Context
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x1700075B RID: 1883
		public override object this[string propertyName]
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

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x06001F86 RID: 8070 RVA: 0x000520AC File Offset: 0x000502AC
		public override SettingsPropertyCollection Properties
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x06001F87 RID: 8071 RVA: 0x000520C0 File Offset: 0x000502C0
		public override SettingsPropertyValueCollection PropertyValues
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x06001F88 RID: 8072 RVA: 0x000520D4 File Offset: 0x000502D4
		public override SettingsProviderCollection Providers
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x06001F89 RID: 8073 RVA: 0x000520E8 File Offset: 0x000502E8
		// (set) Token: 0x06001F8A RID: 8074 RVA: 0x000520FC File Offset: 0x000502FC
		public string SettingsKey
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

		// Token: 0x1400001C RID: 28
		// (add) Token: 0x06001F8B RID: 8075 RVA: 0x00052110 File Offset: 0x00050310
		// (remove) Token: 0x06001F8C RID: 8076 RVA: 0x00052124 File Offset: 0x00050324
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged
		{
			add
			{
				throw new NotSupportedException();
			}
			remove
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x1400001D RID: 29
		// (add) Token: 0x06001F8D RID: 8077 RVA: 0x00052138 File Offset: 0x00050338
		// (remove) Token: 0x06001F8E RID: 8078 RVA: 0x0005214C File Offset: 0x0005034C
		public event SettingChangingEventHandler SettingChanging
		{
			add
			{
				throw new NotSupportedException();
			}
			remove
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x1400001E RID: 30
		// (add) Token: 0x06001F8F RID: 8079 RVA: 0x00052160 File Offset: 0x00050360
		// (remove) Token: 0x06001F90 RID: 8080 RVA: 0x00052174 File Offset: 0x00050374
		public event SettingsLoadedEventHandler SettingsLoaded
		{
			add
			{
				throw new NotSupportedException();
			}
			remove
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x1400001F RID: 31
		// (add) Token: 0x06001F91 RID: 8081 RVA: 0x00052188 File Offset: 0x00050388
		// (remove) Token: 0x06001F92 RID: 8082 RVA: 0x0005219C File Offset: 0x0005039C
		public event SettingsSavingEventHandler SettingsSaving
		{
			add
			{
				throw new NotSupportedException();
			}
			remove
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x06001F93 RID: 8083 RVA: 0x000521B0 File Offset: 0x000503B0
		public object GetPreviousVersion(string propertyName)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001F94 RID: 8084 RVA: 0x000521C4 File Offset: 0x000503C4
		protected virtual void OnPropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001F95 RID: 8085 RVA: 0x000521D8 File Offset: 0x000503D8
		protected virtual void OnSettingChanging(object sender, SettingChangingEventArgs e)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001F96 RID: 8086 RVA: 0x000521EC File Offset: 0x000503EC
		protected virtual void OnSettingsLoaded(object sender, SettingsLoadedEventArgs e)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001F97 RID: 8087 RVA: 0x00052200 File Offset: 0x00050400
		protected virtual void OnSettingsSaving(object sender, global::System.ComponentModel.CancelEventArgs e)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001F98 RID: 8088 RVA: 0x00052214 File Offset: 0x00050414
		public void Reload()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001F99 RID: 8089 RVA: 0x00052228 File Offset: 0x00050428
		public void Reset()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001F9A RID: 8090 RVA: 0x0005223C File Offset: 0x0005043C
		public override void Save()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001F9B RID: 8091 RVA: 0x00052250 File Offset: 0x00050450
		public virtual void Upgrade()
		{
			throw new NotSupportedException();
		}
	}
}
