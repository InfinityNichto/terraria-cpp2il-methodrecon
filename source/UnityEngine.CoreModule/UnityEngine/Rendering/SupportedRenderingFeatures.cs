using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
	// Token: 0x02000117 RID: 279
	public class SupportedRenderingFeatures
	{
		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060005B1 RID: 1457 RVA: 0x0000A15C File Offset: 0x0000835C
		// (set) Token: 0x060005B2 RID: 1458 RVA: 0x0000A178 File Offset: 0x00008378
		public static SupportedRenderingFeatures active
		{
			get
			{
				if (!true)
				{
				}
				if (true || !true)
				{
				}
				if (!true)
				{
				}
				return 1;
			}
			set
			{
				if (!true)
				{
				}
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x060005B3 RID: 1459 RVA: 0x0000A188 File Offset: 0x00008388
		public SupportedRenderingFeatures.LightmapMixedBakeModes defaultMixedLightingModes
		{
			[CompilerGenerated]
			get
			{
				return this.<defaultMixedLightingModes>k__BackingField;
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x060005B4 RID: 1460 RVA: 0x0000A19C File Offset: 0x0000839C
		public SupportedRenderingFeatures.LightmapMixedBakeModes mixedLightingModes
		{
			[CompilerGenerated]
			get
			{
				return this.<mixedLightingModes>k__BackingField;
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060005B5 RID: 1461 RVA: 0x0000A1B0 File Offset: 0x000083B0
		public LightmapBakeType lightmapBakeTypes
		{
			[CompilerGenerated]
			get
			{
				return this.<lightmapBakeTypes>k__BackingField;
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060005B6 RID: 1462 RVA: 0x0000A1C4 File Offset: 0x000083C4
		public LightmapsMode lightmapsModes
		{
			[CompilerGenerated]
			get
			{
				return this.<lightmapsModes>k__BackingField;
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x060005B7 RID: 1463 RVA: 0x0000A1D8 File Offset: 0x000083D8
		public bool enlightenLightmapper
		{
			[CompilerGenerated]
			get
			{
				return this.<enlightenLightmapper>k__BackingField;
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060005B8 RID: 1464 RVA: 0x0000A1EC File Offset: 0x000083EC
		public bool enlighten
		{
			[CompilerGenerated]
			get
			{
				return this.<enlighten>k__BackingField;
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060005B9 RID: 1465 RVA: 0x0000A200 File Offset: 0x00008400
		public bool rendersUIOverlay
		{
			[CompilerGenerated]
			get
			{
				return this.<rendersUIOverlay>k__BackingField;
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x060005BA RID: 1466 RVA: 0x0000A214 File Offset: 0x00008414
		public bool autoAmbientProbeBaking
		{
			[CompilerGenerated]
			get
			{
				return this.<autoAmbientProbeBaking>k__BackingField;
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060005BB RID: 1467 RVA: 0x0000A228 File Offset: 0x00008428
		public bool autoDefaultReflectionProbeBaking
		{
			[CompilerGenerated]
			get
			{
				return this.<autoDefaultReflectionProbeBaking>k__BackingField;
			}
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x0000A23C File Offset: 0x0000843C
		[RequiredByNativeCode]
		internal unsafe static void FallbackMixedLightingModeByRef(IntPtr fallbackModePtr)
		{
			void* ptr = (void*)fallbackModePtr;
			if (SupportedRenderingFeatures.active.<defaultMixedLightingModes>k__BackingField == SupportedRenderingFeatures.LightmapMixedBakeModes.None)
			{
				return;
			}
			SupportedRenderingFeatures.LightmapMixedBakeModes lightmapMixedBakeModes = SupportedRenderingFeatures.active.<mixedLightingModes>k__BackingField;
			SupportedRenderingFeatures.LightmapMixedBakeModes lightmapMixedBakeModes2 = SupportedRenderingFeatures.active.<defaultMixedLightingModes>k__BackingField;
			SupportedRenderingFeatures.LightmapMixedBakeModes lightmapMixedBakeModes3 = SupportedRenderingFeatures.active.<defaultMixedLightingModes>k__BackingField;
			SupportedRenderingFeatures.LightmapMixedBakeModes lightmapMixedBakeModes4 = SupportedRenderingFeatures.active.<defaultMixedLightingModes>k__BackingField;
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x0000A2A8 File Offset: 0x000084A8
		internal static bool IsMixedLightingModeSupported(MixedLightingMode mixedMode)
		{
			/*
An exception occurred when decompiling this method (060005BD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean UnityEngine.Rendering.SupportedRenderingFeatures::IsMixedLightingModeSupported(UnityEngine.MixedLightingMode)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x0000A2B8 File Offset: 0x000084B8
		[RequiredByNativeCode]
		internal unsafe static void IsMixedLightingModeSupportedByRef(MixedLightingMode mixedMode, IntPtr isSupportedPtr)
		{
			void* ptr = (void*)isSupportedPtr;
			bool flag = SupportedRenderingFeatures.IsLightmapBakeTypeSupported(LightmapBakeType.Mixed);
			if (mixedMode == MixedLightingMode.IndirectOnly)
			{
				SupportedRenderingFeatures.LightmapMixedBakeModes lightmapMixedBakeModes = SupportedRenderingFeatures.active.<mixedLightingModes>k__BackingField;
				return;
			}
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x0000A304 File Offset: 0x00008504
		internal static bool IsLightmapBakeTypeSupported(LightmapBakeType bakeType)
		{
			/*
An exception occurred when decompiling this method (060005BF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean UnityEngine.Rendering.SupportedRenderingFeatures::IsLightmapBakeTypeSupported(UnityEngine.LightmapBakeType)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x0000A314 File Offset: 0x00008514
		[RequiredByNativeCode]
		internal unsafe static void IsLightmapBakeTypeSupportedByRef(LightmapBakeType bakeType, IntPtr isSupportedPtr)
		{
			void* ptr = (void*)isSupportedPtr;
			if (!true)
			{
			}
			bool flag = SupportedRenderingFeatures.IsLightmapBakeTypeSupported(LightmapBakeType.Baked);
			if (!true)
			{
			}
			SupportedRenderingFeatures.LightmapMixedBakeModes lightmapMixedBakeModes = SupportedRenderingFeatures.active.<mixedLightingModes>k__BackingField;
			if (lightmapMixedBakeModes != SupportedRenderingFeatures.LightmapMixedBakeModes.None)
			{
				if (lightmapMixedBakeModes == SupportedRenderingFeatures.LightmapMixedBakeModes.None)
				{
				}
				if (SupportedRenderingFeatures.active.<lightmapBakeTypes>k__BackingField == (LightmapBakeType)0)
				{
				}
				if (!SupportedRenderingFeatures.active.<enlighten>k__BackingField)
				{
				}
			}
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x0000A360 File Offset: 0x00008560
		[RequiredByNativeCode]
		internal unsafe static void IsLightmapsModeSupportedByRef(LightmapsMode mode, IntPtr isSupportedPtr)
		{
			void* ptr = (void*)isSupportedPtr;
			LightmapsMode lightmapsMode = SupportedRenderingFeatures.active.<lightmapsModes>k__BackingField;
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x0000A380 File Offset: 0x00008580
		[RequiredByNativeCode]
		internal unsafe static void IsLightmapperSupportedByRef(int lightmapper, IntPtr isSupportedPtr)
		{
			void* ptr = (void*)isSupportedPtr;
			if (lightmapper != 0)
			{
				return;
			}
			bool flag = SupportedRenderingFeatures.active.<enlightenLightmapper>k__BackingField;
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x0000A3A4 File Offset: 0x000085A4
		[RequiredByNativeCode]
		internal unsafe static void IsUIOverlayRenderedBySRP(IntPtr isSupportedPtr)
		{
			void* ptr = (void*)isSupportedPtr;
			bool flag = SupportedRenderingFeatures.active.<rendersUIOverlay>k__BackingField;
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x0000A3C4 File Offset: 0x000085C4
		[RequiredByNativeCode]
		internal unsafe static void IsAutoAmbientProbeBakingSupported(IntPtr isSupportedPtr)
		{
			void* ptr = (void*)isSupportedPtr;
			bool flag = SupportedRenderingFeatures.active.<autoAmbientProbeBaking>k__BackingField;
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x0000A3E4 File Offset: 0x000085E4
		[RequiredByNativeCode]
		internal unsafe static void IsAutoDefaultReflectionProbeBakingSupported(IntPtr isSupportedPtr)
		{
			void* ptr = (void*)isSupportedPtr;
			bool flag = SupportedRenderingFeatures.active.<autoDefaultReflectionProbeBaking>k__BackingField;
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x0000A404 File Offset: 0x00008604
		[RequiredByNativeCode]
		internal unsafe static void FallbackLightmapperByRef(IntPtr lightmapperPtr)
		{
			void* ptr = (void*)lightmapperPtr;
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x0000A418 File Offset: 0x00008618
		public SupportedRenderingFeatures()
		{
			long num = 16843009L;
			this.<rendererProbes>k__BackingField = num != 0L;
			this.<overrideShadowmaskMessage>k__BackingField = "";
			base..ctor();
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x0000A444 File Offset: 0x00008644
		// Note: this type is marked as 'beforefieldinit'.
		static SupportedRenderingFeatures()
		{
		}

		// Token: 0x04000494 RID: 1172
		private static SupportedRenderingFeatures s_Active;

		// Token: 0x04000495 RID: 1173
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private SupportedRenderingFeatures.ReflectionProbeModes <reflectionProbeModes>k__BackingField;

		// Token: 0x04000496 RID: 1174
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private SupportedRenderingFeatures.LightmapMixedBakeModes <defaultMixedLightingModes>k__BackingField;

		// Token: 0x04000497 RID: 1175
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private SupportedRenderingFeatures.LightmapMixedBakeModes <mixedLightingModes>k__BackingField;

		// Token: 0x04000498 RID: 1176
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private LightmapBakeType <lightmapBakeTypes>k__BackingField;

		// Token: 0x04000499 RID: 1177
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private LightmapsMode <lightmapsModes>k__BackingField;

		// Token: 0x0400049A RID: 1178
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private bool <enlightenLightmapper>k__BackingField;

		// Token: 0x0400049B RID: 1179
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private bool <enlighten>k__BackingField;

		// Token: 0x0400049C RID: 1180
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private bool <lightProbeProxyVolumes>k__BackingField;

		// Token: 0x0400049D RID: 1181
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private bool <motionVectors>k__BackingField;

		// Token: 0x0400049E RID: 1182
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private bool <receiveShadows>k__BackingField;

		// Token: 0x0400049F RID: 1183
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private bool <reflectionProbes>k__BackingField;

		// Token: 0x040004A0 RID: 1184
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private bool <reflectionProbesBlendDistance>k__BackingField;

		// Token: 0x040004A1 RID: 1185
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool <rendererPriority>k__BackingField;

		// Token: 0x040004A2 RID: 1186
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool <rendersUIOverlay>k__BackingField;

		// Token: 0x040004A3 RID: 1187
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool <overridesEnvironmentLighting>k__BackingField;

		// Token: 0x040004A4 RID: 1188
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool <overridesFog>k__BackingField;

		// Token: 0x040004A5 RID: 1189
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool <overridesRealtimeReflectionProbes>k__BackingField;

		// Token: 0x040004A6 RID: 1190
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool <overridesOtherLightingSettings>k__BackingField;

		// Token: 0x040004A7 RID: 1191
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private bool <editableMaterialRenderQueue>k__BackingField;

		// Token: 0x040004A8 RID: 1192
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool <overridesLODBias>k__BackingField;

		// Token: 0x040004A9 RID: 1193
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool <overridesMaximumLODLevel>k__BackingField;

		// Token: 0x040004AA RID: 1194
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private bool <rendererProbes>k__BackingField;

		// Token: 0x040004AB RID: 1195
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool <particleSystemInstancing>k__BackingField;

		// Token: 0x040004AC RID: 1196
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool <autoAmbientProbeBaking>k__BackingField;

		// Token: 0x040004AD RID: 1197
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private bool <autoDefaultReflectionProbeBaking>k__BackingField;

		// Token: 0x040004AE RID: 1198
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool <overridesShadowmask>k__BackingField;

		// Token: 0x040004AF RID: 1199
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string <overrideShadowmaskMessage>k__BackingField;

		// Token: 0x02000118 RID: 280
		[Flags]
		public enum ReflectionProbeModes
		{
			// Token: 0x040004B1 RID: 1201
			None = 0,
			// Token: 0x040004B2 RID: 1202
			Rotation = 1
		}

		// Token: 0x02000119 RID: 281
		[Flags]
		public enum LightmapMixedBakeModes
		{
			// Token: 0x040004B4 RID: 1204
			None = 0,
			// Token: 0x040004B5 RID: 1205
			IndirectOnly = 1,
			// Token: 0x040004B6 RID: 1206
			Subtractive = 2,
			// Token: 0x040004B7 RID: 1207
			Shadowmask = 4
		}
	}
}
