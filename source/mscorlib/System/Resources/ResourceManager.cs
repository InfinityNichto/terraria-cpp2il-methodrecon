using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Threading;

namespace System.Resources
{
	// Token: 0x020004B3 RID: 1203
	[ComVisible(true)]
	[Serializable]
	public class ResourceManager
	{
		// Token: 0x06002301 RID: 8961 RVA: 0x0004EE68 File Offset: 0x0004D068
		private void Init()
		{
			throw new InvalidCastException();
		}

		// Token: 0x06002302 RID: 8962 RVA: 0x0004EE84 File Offset: 0x0004D084
		protected ResourceManager()
		{
			this.Init();
		}

		// Token: 0x06002303 RID: 8963 RVA: 0x0004EEA0 File Offset: 0x0004D0A0
		public ResourceManager(Type resourceSource)
		{
			int num = 1;
			base..ctor();
			if (num == 0)
			{
			}
			if (resourceSource == null)
			{
				string resourceString = Environment.GetResourceString("Type must be a runtime Type object.");
				throw new InvalidCastException();
			}
			this._locationInfo = resourceSource;
			this.MainAssembly = resourceSource;
			this.BaseNameField = resourceSource;
			this.CommonAssemblyInit();
			if (this != null)
			{
				this.m_callingAssembly = this;
				throw new InvalidCastException();
			}
			this.m_callingAssembly = this;
			Assembly mainAssembly = this.MainAssembly;
			Assembly mainAssembly2 = this.MainAssembly;
		}

		// Token: 0x06002304 RID: 8964 RVA: 0x0004EF1C File Offset: 0x0004D11C
		[OnDeserializing]
		private void OnDeserializing(StreamingContext ctx)
		{
		}

		// Token: 0x06002305 RID: 8965 RVA: 0x0004EF2C File Offset: 0x0004D12C
		[OnDeserialized]
		private void OnDeserialized(StreamingContext ctx)
		{
			bool useManifest = this.UseManifest;
			if (this.m_callingAssembly == null)
			{
				Assembly callingAssembly = this._callingAssembly;
				if (callingAssembly != null)
				{
					this.m_callingAssembly = callingAssembly;
					throw new InvalidCastException();
				}
			}
			if (this.UseManifest && this._neutralResourcesCulture == null)
			{
				Assembly mainAssembly = this.MainAssembly;
				CultureInfo cultureInfo;
				this._neutralResourcesCulture = cultureInfo;
			}
		}

		// Token: 0x06002306 RID: 8966 RVA: 0x0004EF80 File Offset: 0x0004D180
		[OnSerializing]
		private void OnSerializing(StreamingContext ctx)
		{
			RuntimeAssembly callingAssembly = this.m_callingAssembly;
			bool useManifest = this.UseManifest;
			this._callingAssembly = callingAssembly;
			this.UseSatelliteAssem = useManifest;
		}

		// Token: 0x06002307 RID: 8967 RVA: 0x0004EFAC File Offset: 0x0004D1AC
		private void CommonAssemblyInit()
		{
			this.UseManifest = true;
			Assembly mainAssembly = this.MainAssembly;
			CultureInfo cultureInfo;
			this._neutralResourcesCulture = cultureInfo;
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06002308 RID: 8968 RVA: 0x0004EFD0 File Offset: 0x0004D1D0
		public virtual string BaseName
		{
			get
			{
				return this.BaseNameField;
			}
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06002309 RID: 8969 RVA: 0x0004EFE4 File Offset: 0x0004D1E4
		public virtual bool IgnoreCase
		{
			get
			{
				return this._ignoreCase;
			}
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x0600230A RID: 8970 RVA: 0x0004EFF8 File Offset: 0x0004D1F8
		protected UltimateResourceFallbackLocation FallbackLocation
		{
			get
			{
				return this._fallbackLoc;
			}
		}

		// Token: 0x0600230B RID: 8971 RVA: 0x0004F00C File Offset: 0x0004D20C
		protected virtual string GetResourceFileName(CultureInfo culture)
		{
			/*
An exception occurred when decompiling this method (0600230B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Resources.ResourceManager::GetResourceFileName(System.Globalization.CultureInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_06, ldfld:string(ResourceManager::BaseNameField, ldloc:ResourceManager(this)))
	stloc:bool(var_2_0D, callgetter:bool(CultureInfo::get_HasInvariantCultureName, ldloc:CultureInfo(culture)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x0600230C RID: 8972 RVA: 0x0004F028 File Offset: 0x0004D228
		public virtual ResourceSet GetResourceSet(CultureInfo culture, bool createIfNotExists, bool tryParents)
		{
			if (culture != null)
			{
				Dictionary<string, ResourceSet> resourceSets = this._resourceSets;
				if (resourceSets != null)
				{
					long num = 0L;
					Monitor.Exit(resourceSets);
					if (num != 0L)
					{
						goto IL_005D;
					}
				}
				if (this.UseManifest)
				{
					bool hasInvariantCultureName = culture.HasInvariantCultureName;
					RuntimeAssembly callingAssembly = this.m_callingAssembly;
					Assembly mainAssembly = this.MainAssembly;
					Type locationInfo = this._locationInfo;
					if (mainAssembly != null)
					{
					}
					Stream stream;
					if (stream != null)
					{
						IResourceGroveler resourceGroveler = this.resourceGroveler;
						Assembly mainAssembly2 = this.MainAssembly;
						if (resourceGroveler != null)
						{
						}
					}
				}
			}
			IL_005D:
			throw new OutOfMemoryException();
		}

		// Token: 0x0600230D RID: 8973 RVA: 0x0004F0B0 File Offset: 0x0004D2B0
		protected virtual ResourceSet InternalGetResourceSet(CultureInfo culture, bool createIfNotExists, bool tryParents)
		{
			ResourceSet resourceSet;
			return resourceSet;
		}

		// Token: 0x0600230E RID: 8974 RVA: 0x0004F0C0 File Offset: 0x0004D2C0
		private ResourceSet InternalGetResourceSet(CultureInfo requestedCulture, bool createIfNotExists, bool tryParents, StackCrawlMark stackMark)
		{
			Dictionary<string, ResourceSet> resourceSets = this._resourceSets;
			int num = 3;
			long num2 = 0L;
			Monitor.Exit(resourceSets);
			if (num2 != 0L)
			{
				throw new OutOfMemoryException();
			}
			CultureInfo neutralResourcesCulture = this._neutralResourcesCulture;
			if (num != 0)
			{
			}
			if (num != 0)
			{
			}
			Monitor.Enter(resourceSets, true);
			long num3 = 0L;
			int num4 = 10;
			Monitor.Exit(resourceSets);
			if (num3 != 0L)
			{
				throw new OutOfMemoryException();
			}
			if (num4 == 0)
			{
				IResourceGroveler resourceGroveler = this.resourceGroveler;
				if (num != 0)
				{
				}
				while (resourceGroveler == null)
				{
				}
			}
			long num5 = 0L;
			int num6 = 9;
			IEnumerator<CultureInfo> enumerator;
			if (enumerator == null || num != 0)
			{
			}
			if (num5 != 0L)
			{
				throw new OutOfMemoryException();
			}
			long num7;
			if (num6 == 0 && enumerator != null)
			{
				if (num != 0)
				{
				}
				if (num != 0)
				{
				}
				num7 = 0L;
				int num8 = 11;
				IEnumerator<CultureInfo> enumerator2;
				if (enumerator2 == null || num != 0)
				{
				}
				if (num7 != 0L)
				{
					throw new OutOfMemoryException();
				}
				if (num8 == 0)
				{
				}
			}
			long num9 = 0L;
			Monitor.Exit(num7);
			if (num9 != 0L)
			{
				throw new OutOfMemoryException();
			}
			long num10 = 0L;
			long num11;
			if (num11 != 0L)
			{
				if (num != 0)
				{
				}
				long value = num11.m_value;
			}
			if (num10 == 0L)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x0600230F RID: 8975 RVA: 0x0004F1F4 File Offset: 0x0004D3F4
		private static void AddResourceSet(Dictionary<string, ResourceSet> localResourceSets, string cultureName, ResourceSet rs)
		{
		}

		// Token: 0x06002310 RID: 8976 RVA: 0x0004F234 File Offset: 0x0004D434
		protected static Version GetSatelliteContractVersion(Assembly a)
		{
			Type type;
			if (type != null)
			{
			}
			RuntimeTypeHandle impl = type._impl;
			long num = 0L;
			if (num != 0L)
			{
			}
			if (!false)
			{
				if (num == 0L)
				{
					throw new ArrayTypeMismatchException();
				}
				string resourceString = Environment.GetResourceString("Assembly cannot be null.");
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06002311 RID: 8977 RVA: 0x0004F2B4 File Offset: 0x0004D4B4
		protected static CultureInfo GetNeutralResourcesLanguage(Assembly a)
		{
			CultureInfo cultureInfo;
			return cultureInfo;
		}

		// Token: 0x06002312 RID: 8978 RVA: 0x0004F2C4 File Offset: 0x0004D4C4
		internal static bool CompareNames(string asmTypeName1, string typeName2, AssemblyName asmName2)
		{
			int stringLength = asmTypeName1._stringLength;
			int num;
			if (num == 0)
			{
				char c;
				bool flag = char.IsWhiteSpace(c);
				int stringLength2 = typeName2._stringLength;
				int num2;
				if (num2 != 0)
				{
				}
			}
			int num3;
			if (num3 != 0)
			{
				if (num3 != 0)
				{
				}
				byte[] array;
				while (array == null)
				{
				}
				byte[] array2;
				while (array2 == null)
				{
				}
				return;
			}
		}

		// Token: 0x06002313 RID: 8979 RVA: 0x0004F310 File Offset: 0x0004D510
		private void SetAppXConfiguration()
		{
		}

		// Token: 0x06002314 RID: 8980 RVA: 0x0004F320 File Offset: 0x0004D520
		// Note: this type is marked as 'beforefieldinit'.
		static ResourceManager()
		{
		}

		// Token: 0x04001323 RID: 4899
		protected string BaseNameField;

		// Token: 0x04001324 RID: 4900
		[Obsolete("call InternalGetResourceSet instead")]
		protected Hashtable ResourceSets;

		// Token: 0x04001325 RID: 4901
		[NonSerialized]
		private Dictionary<string, ResourceSet> _resourceSets;

		// Token: 0x04001326 RID: 4902
		private string moduleDir;

		// Token: 0x04001327 RID: 4903
		protected Assembly MainAssembly;

		// Token: 0x04001328 RID: 4904
		private Type _locationInfo;

		// Token: 0x04001329 RID: 4905
		private Type _userResourceSet;

		// Token: 0x0400132A RID: 4906
		private CultureInfo _neutralResourcesCulture;

		// Token: 0x0400132B RID: 4907
		[NonSerialized]
		private ResourceManager.CultureNameResourceSetPair _lastUsedResourceCache;

		// Token: 0x0400132C RID: 4908
		private bool _ignoreCase;

		// Token: 0x0400132D RID: 4909
		private bool UseManifest;

		// Token: 0x0400132E RID: 4910
		[OptionalField(VersionAdded = 1)]
		private bool UseSatelliteAssem;

		// Token: 0x0400132F RID: 4911
		[OptionalField]
		private UltimateResourceFallbackLocation _fallbackLoc;

		// Token: 0x04001330 RID: 4912
		[OptionalField]
		private Version _satelliteContractVersion;

		// Token: 0x04001331 RID: 4913
		[OptionalField]
		private bool _lookedForSatelliteContractVersion;

		// Token: 0x04001332 RID: 4914
		[OptionalField(VersionAdded = 1)]
		private Assembly _callingAssembly;

		// Token: 0x04001333 RID: 4915
		[OptionalField(VersionAdded = 4)]
		private RuntimeAssembly m_callingAssembly;

		// Token: 0x04001334 RID: 4916
		[NonSerialized]
		private IResourceGroveler resourceGroveler;

		// Token: 0x04001335 RID: 4917
		public static readonly int MagicNumber;

		// Token: 0x04001336 RID: 4918
		public static readonly int HeaderVersionNumber;

		// Token: 0x04001337 RID: 4919
		private static readonly Type _minResourceSet;

		// Token: 0x04001338 RID: 4920
		internal static readonly string ResReaderTypeName;

		// Token: 0x04001339 RID: 4921
		internal static readonly string ResSetTypeName;

		// Token: 0x0400133A RID: 4922
		internal static readonly string MscorlibName;

		// Token: 0x0400133B RID: 4923
		internal static readonly int DEBUG;

		// Token: 0x020004B4 RID: 1204
		internal class CultureNameResourceSetPair
		{
			// Token: 0x06002315 RID: 8981 RVA: 0x0004F330 File Offset: 0x0004D530
			public CultureNameResourceSetPair()
			{
			}
		}

		// Token: 0x020004B5 RID: 1205
		internal class ResourceManagerMediator
		{
			// Token: 0x06002316 RID: 8982 RVA: 0x0004F344 File Offset: 0x0004D544
			internal ResourceManagerMediator(ResourceManager rm)
			{
				do
				{
					base..ctor();
				}
				while (rm == null);
				this._rm = rm;
			}

			// Token: 0x17000487 RID: 1159
			// (get) Token: 0x06002317 RID: 8983 RVA: 0x0004F364 File Offset: 0x0004D564
			internal string ModuleDir
			{
				get
				{
					return this._rm.moduleDir;
				}
			}

			// Token: 0x17000488 RID: 1160
			// (get) Token: 0x06002318 RID: 8984 RVA: 0x0004F37C File Offset: 0x0004D57C
			internal Type LocationInfo
			{
				get
				{
					return this._rm._locationInfo;
				}
			}

			// Token: 0x17000489 RID: 1161
			// (get) Token: 0x06002319 RID: 8985 RVA: 0x0004F394 File Offset: 0x0004D594
			internal Type UserResourceSet
			{
				get
				{
					return this._rm._userResourceSet;
				}
			}

			// Token: 0x1700048A RID: 1162
			// (get) Token: 0x0600231A RID: 8986 RVA: 0x0004F3AC File Offset: 0x0004D5AC
			internal string BaseNameField
			{
				get
				{
					return this._rm.BaseNameField;
				}
			}

			// Token: 0x1700048B RID: 1163
			// (get) Token: 0x0600231B RID: 8987 RVA: 0x0004F3C4 File Offset: 0x0004D5C4
			internal CultureInfo NeutralResourcesCulture
			{
				get
				{
					return this._rm._neutralResourcesCulture;
				}
			}

			// Token: 0x0600231C RID: 8988 RVA: 0x0004F3DC File Offset: 0x0004D5DC
			internal string GetResourceFileName(CultureInfo culture)
			{
				/*
An exception occurred when decompiling this method (0600231C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Resources.ResourceManager/ResourceManagerMediator::GetResourceFileName(System.Globalization.CultureInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:ResourceManager(var_0_06, ldfld:ResourceManager(ResourceManagerMediator::_rm, ldloc:ResourceManagerMediator(this)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}

			// Token: 0x1700048C RID: 1164
			// (get) Token: 0x0600231D RID: 8989 RVA: 0x0004F3F0 File Offset: 0x0004D5F0
			// (set) Token: 0x0600231E RID: 8990 RVA: 0x0004F408 File Offset: 0x0004D608
			internal bool LookedForSatelliteContractVersion
			{
				get
				{
					return this._rm._lookedForSatelliteContractVersion;
				}
				set
				{
					ResourceManager rm = this._rm;
				}
			}

			// Token: 0x1700048D RID: 1165
			// (get) Token: 0x0600231F RID: 8991 RVA: 0x0004F41C File Offset: 0x0004D61C
			// (set) Token: 0x06002320 RID: 8992 RVA: 0x0004F434 File Offset: 0x0004D634
			internal Version SatelliteContractVersion
			{
				get
				{
					return this._rm._satelliteContractVersion;
				}
				set
				{
					this._rm._satelliteContractVersion = value;
				}
			}

			// Token: 0x06002321 RID: 8993 RVA: 0x0004F450 File Offset: 0x0004D650
			internal Version ObtainSatelliteContractVersion(Assembly a)
			{
				if (!true)
				{
				}
				return ResourceManager.GetSatelliteContractVersion(a);
			}

			// Token: 0x1700048E RID: 1166
			// (get) Token: 0x06002322 RID: 8994 RVA: 0x0004F468 File Offset: 0x0004D668
			internal UltimateResourceFallbackLocation FallbackLoc
			{
				get
				{
					return this._rm._fallbackLoc;
				}
			}

			// Token: 0x1700048F RID: 1167
			// (get) Token: 0x06002323 RID: 8995 RVA: 0x0004F480 File Offset: 0x0004D680
			internal RuntimeAssembly CallingAssembly
			{
				get
				{
					return this._rm.m_callingAssembly;
				}
			}

			// Token: 0x17000490 RID: 1168
			// (get) Token: 0x06002324 RID: 8996 RVA: 0x0004F498 File Offset: 0x0004D698
			internal RuntimeAssembly MainAssembly
			{
				get
				{
					if (this._rm.MainAssembly != null)
					{
					}
					throw new InvalidCastException();
				}
			}

			// Token: 0x17000491 RID: 1169
			// (get) Token: 0x06002325 RID: 8997 RVA: 0x0004F4B8 File Offset: 0x0004D6B8
			internal string BaseName
			{
				get
				{
					/*
An exception occurred when decompiling this method (06002325)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Resources.ResourceManager/ResourceManagerMediator::get_BaseName()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:ResourceManager(var_0_06, ldfld:ResourceManager(ResourceManagerMediator::_rm, ldloc:ResourceManagerMediator(this)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
				}
			}

			// Token: 0x0400133C RID: 4924
			private ResourceManager _rm;
		}
	}
}
