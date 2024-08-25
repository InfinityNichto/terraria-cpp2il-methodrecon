using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Threading;

namespace System.Resources
{
	// Token: 0x020004B2 RID: 1202
	internal class ManifestBasedResourceGroveler : IResourceGroveler
	{
		// Token: 0x060022F4 RID: 8948 RVA: 0x0004E8D8 File Offset: 0x0004CAD8
		public ManifestBasedResourceGroveler(ResourceManager.ResourceManagerMediator mediator)
		{
			this._mediator = mediator;
		}

		// Token: 0x060022F5 RID: 8949 RVA: 0x0004E8F4 File Offset: 0x0004CAF4
		public ResourceSet GrovelForResourceSet(CultureInfo culture, Dictionary<string, ResourceSet> localResourceSets, bool tryParents, bool createIfNotExists, StackCrawlMark stackMark)
		{
			CultureInfo cultureInfo = this.UltimateFallbackFixup(culture);
			bool hasInvariantCultureName = cultureInfo.HasInvariantCultureName;
			if (this._mediator._rm._fallbackLoc != UltimateResourceFallbackLocation.MainAssembly && this.GetSatelliteAssembly(cultureInfo, stackMark) == null)
			{
				bool hasInvariantCultureName2 = culture.HasInvariantCultureName;
				UltimateResourceFallbackLocation fallbackLoc = this._mediator._rm._fallbackLoc;
			}
			ResourceManager rm = this._mediator._rm;
			RuntimeAssembly runtimeAssembly;
			if (runtimeAssembly != null)
			{
				long num = 0L;
				Monitor.Exit(localResourceSets);
				if (num != 0L || 7 != 0)
				{
					goto IL_0082;
				}
				Stream stream;
				if (stream != null)
				{
					return this.CreateResourceSet(stream, runtimeAssembly);
				}
			}
			if (true)
			{
				bool hasInvariantCultureName3 = culture.HasInvariantCultureName;
			}
			IL_0082:
			throw new OutOfMemoryException();
		}

		// Token: 0x060022F6 RID: 8950 RVA: 0x0004E9A8 File Offset: 0x0004CBA8
		private CultureInfo UltimateFallbackFixup(CultureInfo lookForCulture)
		{
			CultureInfo neutralResourcesCulture = this._mediator._rm._neutralResourcesCulture;
			if (this._mediator._rm._fallbackLoc != UltimateResourceFallbackLocation.MainAssembly)
			{
				bool hasInvariantCultureName = lookForCulture.HasInvariantCultureName;
				ResourceManager rm = this._mediator._rm;
				UltimateResourceFallbackLocation fallbackLoc = rm._fallbackLoc;
				return rm._neutralResourcesCulture;
			}
			return CultureInfo.InvariantCulture;
		}

		// Token: 0x060022F7 RID: 8951 RVA: 0x0004EA04 File Offset: 0x0004CC04
		internal static CultureInfo GetNeutralResourcesLanguage(Assembly a, UltimateResourceFallbackLocation fallbackLocation)
		{
			if (!true)
			{
			}
			CultureInfo cultureInfo;
			return cultureInfo;
		}

		// Token: 0x060022F8 RID: 8952 RVA: 0x0004EA40 File Offset: 0x0004CC40
		internal ResourceSet CreateResourceSet(Stream store, Assembly assembly)
		{
			Type userResourceSet = this._mediator._rm._userResourceSet;
			if (store != null)
			{
				Type userResourceSet2 = this._mediator._rm._userResourceSet;
				object obj;
				if (obj != null)
				{
				}
				if (store != null)
				{
					object obj2;
					if (obj2 != null)
					{
						if (obj2 == null)
						{
							throw new InvalidCastException();
						}
						if (obj2 == null)
						{
							goto IL_0040;
						}
					}
					ResourceManager rm = this._mediator._rm;
					Type userResourceSet3 = rm._userResourceSet;
					if (rm == null)
					{
					}
					string baseNameField = rm.BaseNameField;
					object obj3;
					while (obj3 == null)
					{
					}
					throw new InvalidCastException();
				}
			}
			IL_0040:
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060022F9 RID: 8953 RVA: 0x0004EB18 File Offset: 0x0004CD18
		private Stream GetManifestResourceStream(RuntimeAssembly satellite, string fileName, StackCrawlMark stackMark)
		{
			RuntimeAssembly mainAssembly = this._mediator.MainAssembly;
			ResourceManager.ResourceManagerMediator mediator = this._mediator;
			RuntimeAssembly callingAssembly = mediator._rm.m_callingAssembly;
			RuntimeAssembly mainAssembly2 = mediator.MainAssembly;
			Type locationInfo = this._mediator._rm._locationInfo;
			Stream stream;
			if (stream != null)
			{
				return stream;
			}
			return this.CaseInsensitiveManifestResourceStreamLookup(satellite, fileName);
		}

		// Token: 0x060022FA RID: 8954 RVA: 0x0004EB6C File Offset: 0x0004CD6C
		private Stream CaseInsensitiveManifestResourceStreamLookup(RuntimeAssembly satellite, string name)
		{
			Type locationInfo = this._mediator._rm._locationInfo;
			if (this._mediator._rm._locationInfo == null || name != null)
			{
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			object evidence = satellite._evidence;
			long num = 0L;
			if (invariantCulture != null)
			{
			}
			if (num == 0L)
			{
				if (num != 0L)
				{
					RuntimeAssembly mainAssembly = this._mediator.MainAssembly;
					ResourceManager.ResourceManagerMediator mediator = this._mediator;
					RuntimeAssembly callingAssembly = mediator._rm.m_callingAssembly;
					RuntimeAssembly mainAssembly2 = mediator.MainAssembly;
					Stream stream;
					return stream;
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060022FB RID: 8955 RVA: 0x0004EC04 File Offset: 0x0004CE04
		private RuntimeAssembly GetSatelliteAssembly(CultureInfo lookForCulture, StackCrawlMark stackMark)
		{
			ResourceManager.ResourceManagerMediator mediator = this._mediator;
			if (!mediator._rm._lookedForSatelliteContractVersion)
			{
				RuntimeAssembly mainAssembly = mediator.MainAssembly;
				ResourceManager rm = mediator._rm;
				int num = 1;
				Version version;
				rm._satelliteContractVersion = version;
				this._mediator._rm._lookedForSatelliteContractVersion = num != 0;
			}
			string satelliteAssemblyName = this.GetSatelliteAssemblyName();
			RuntimeAssembly mainAssembly2 = this._mediator.MainAssembly;
			Version satelliteContractVersion = this._mediator._rm._satelliteContractVersion;
			long num2 = 0L;
			return mainAssembly2.InternalGetSatelliteAssembly(satelliteAssemblyName, lookForCulture, satelliteContractVersion, num2 != 0L, stackMark);
		}

		// Token: 0x060022FC RID: 8956 RVA: 0x0004EC98 File Offset: 0x0004CE98
		private bool CanUseDefaultResourceClasses(string readerTypeName, string resSetTypeName)
		{
			ResourceManager rm = this._mediator._rm;
			Type userResourceSet = rm._userResourceSet;
			if (rm == null)
			{
			}
			Dictionary<string, ResourceSet> resourceSets = rm._resourceSets;
			if (readerTypeName != null)
			{
				if (rm == null)
				{
				}
				string baseNameField = rm.BaseNameField;
			}
			if (resSetTypeName != null)
			{
				if (rm == null)
				{
				}
				Hashtable resourceSets2 = rm.ResourceSets;
			}
			return true;
		}

		// Token: 0x060022FD RID: 8957 RVA: 0x0004ECE4 File Offset: 0x0004CEE4
		private string GetSatelliteAssemblyName()
		{
			IntPtr mono_assembly = this._mediator.MainAssembly._mono_assembly;
			string text;
			return text;
		}

		// Token: 0x060022FE RID: 8958 RVA: 0x0004ED04 File Offset: 0x0004CF04
		private void HandleSatelliteMissing()
		{
			IntPtr mono_assembly = this._mediator.MainAssembly._mono_assembly;
			Version satelliteContractVersion = this._mediator._rm._satelliteContractVersion;
			Version satelliteContractVersion2 = this._mediator._rm._satelliteContractVersion;
			RuntimeAssembly mainAssembly = this._mediator.MainAssembly;
			object denied = mainAssembly._denied;
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			byte[] array;
			string text = array.ToString("x", invariantCulture);
		}

		// Token: 0x060022FF RID: 8959 RVA: 0x0004EDB0 File Offset: 0x0004CFB0
		private void HandleResourceStreamMissing(string fileName)
		{
			RuntimeAssembly mainAssembly = this._mediator.MainAssembly;
			ResourceManager rm = this._mediator._rm;
			Environment.FailFast("mscorlib.resources couldn't be found!  Large parts of the BCL won't work!");
			ResourceManager rm2 = this._mediator._rm;
			Type locationInfo = rm2._locationInfo;
			if (rm2 == null)
			{
			}
			if (this._mediator._rm._locationInfo != null)
			{
				Type locationInfo2 = this._mediator._rm._locationInfo;
			}
			string text2;
			string text = text2 + fileName;
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06002300 RID: 8960 RVA: 0x0004EE48 File Offset: 0x0004D048
		private static bool GetNeutralResourcesLanguageAttribute(Assembly assembly, string cultureName, short fallbackLocation)
		{
			NeutralResourcesLanguageAttribute neutralResourcesLanguageAttribute;
			if (neutralResourcesLanguageAttribute != null)
			{
				string <CultureName>k__BackingField = neutralResourcesLanguageAttribute.<CultureName>k__BackingField;
				UltimateResourceFallbackLocation <Location>k__BackingField = neutralResourcesLanguageAttribute.<Location>k__BackingField;
			}
			return true;
		}

		// Token: 0x04001322 RID: 4898
		private ResourceManager.ResourceManagerMediator _mediator;
	}
}
