using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;

namespace System.ComponentModel
{
	// Token: 0x0200035B RID: 859
	public class ComponentResourceManager : ResourceManager
	{
		// Token: 0x0600166D RID: 5741 RVA: 0x000417EC File Offset: 0x0003F9EC
		public ComponentResourceManager()
		{
			if (!true)
			{
			}
			base..ctor();
		}

		// Token: 0x0600166E RID: 5742 RVA: 0x00041804 File Offset: 0x0003FA04
		public ComponentResourceManager(Type t)
		{
			if (!true)
			{
			}
			base..ctor(t);
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x0600166F RID: 5743 RVA: 0x0004181C File Offset: 0x0003FA1C
		private CultureInfo NeutralResourcesCulture
		{
			get
			{
				while (this._neutralResourcesCulture != null)
				{
				}
				Assembly mainAssembly = this.MainAssembly;
				CultureInfo neutralResourcesLanguage = ResourceManager.GetNeutralResourcesLanguage(this.MainAssembly);
				this._neutralResourcesCulture = neutralResourcesLanguage;
				return neutralResourcesLanguage;
			}
		}

		// Token: 0x06001670 RID: 5744 RVA: 0x00041854 File Offset: 0x0003FA54
		public void ApplyResources(object value, string objectName)
		{
		}

		// Token: 0x06001671 RID: 5745 RVA: 0x00041864 File Offset: 0x0003FA64
		public virtual void ApplyResources(object value, string objectName, CultureInfo culture)
		{
			if (value == null)
			{
				return;
			}
			if (objectName == null)
			{
				throw new OutOfMemoryException();
			}
			if (culture == null)
			{
				CultureInfo currentUICulture = CultureInfo.CurrentUICulture;
			}
			Hashtable resourceSets = this._resourceSets;
			if (resourceSets != null)
			{
				if (resourceSets != null)
				{
					int version = resourceSets._version;
					if (!true)
					{
					}
				}
				return;
			}
			Hashtable resourceSets2 = this._resourceSets;
			if (value == null)
			{
				return;
			}
			if (value == null)
			{
				throw new InvalidCastException();
			}
			if (value != null)
			{
				return;
			}
			throw new InvalidCastException();
		}

		// Token: 0x06001672 RID: 5746 RVA: 0x00041974 File Offset: 0x0003FB74
		private global::System.Collections.Generic.SortedList<string, object> FillResources(CultureInfo culture, [Out] ResourceSet resourceSet)
		{
			if (!true)
			{
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			CultureInfo neutralResourcesCulture = this.NeutralResourcesCulture;
			if (!true)
			{
			}
			if (!true)
			{
			}
			global::System.Collections.Generic.SortedList<string, object> sortedList;
			if (this != null)
			{
				return sortedList;
			}
			return sortedList;
		}

		// Token: 0x040011E1 RID: 4577
		private Hashtable _resourceSets;

		// Token: 0x040011E2 RID: 4578
		private CultureInfo _neutralResourcesCulture;
	}
}
