using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.Map;
using Unity.IL2CPP.CompilerServices;

namespace Terraria.Graphics.Light
{
	// Token: 0x02000773 RID: 1907
	public class LegacyLighting : ILightingEngine
	{
		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x06003E76 RID: 15990 RVA: 0x0023D534 File Offset: 0x0023B734
		// (set) Token: 0x06003E77 RID: 15991 RVA: 0x0023D548 File Offset: 0x0023B748
		public int Mode
		{
			[CompilerGenerated]
			get
			{
				return this.<Mode>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Mode>k__BackingField = value;
			}
		}

		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x06003E78 RID: 15992 RVA: 0x0023D55C File Offset: 0x0023B75C
		public bool IsColorOrWhiteMode
		{
			get
			{
				/*
An exception occurred when decompiling this method (06003E78)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Graphics.Light.LegacyLighting::get_IsColorOrWhiteMode()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(LegacyLighting::<Mode>k__BackingField, ldloc:LegacyLighting(this)))
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

		// Token: 0x06003E79 RID: 15993 RVA: 0x0023D570 File Offset: 0x0023B770
		public LegacyLighting(Camera camera)
		{
			this._camera = camera;
		}

		// Token: 0x06003E7A RID: 15994 RVA: 0x0023D58C File Offset: 0x0023B78C
		public LightMap GetLightMap([Out] Rectangle lightMapRegion)
		{
			int x = this._activeProcessedArea.X;
			lightMapRegion.X = x;
			return this._activeLightMap;
		}

		// Token: 0x06003E7B RID: 15995 RVA: 0x0023D5B4 File Offset: 0x0023B7B4
		[Il2CppSetOption(Option.NullChecks, false)]
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		public Vector3 GetColor(int x, int y)
		{
			/*
An exception occurred when decompiling this method (06003E7B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Vector3 Terraria.Graphics.Light.LegacyLighting::GetColor(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_002B:
	stloc:int32(var_5_32, ldfld:int32(int32::m_value, ldloc:int32[exp:int32&](var_4_25)))
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

		// Token: 0x06003E7C RID: 15996 RVA: 0x0023D5F4 File Offset: 0x0023B7F4
		public void Rebuild()
		{
			if (!true)
			{
			}
			Vector2 unscaledSize = this._camera.UnscaledSize;
			Camera camera = this._camera;
			int num = 100;
			Vector2 unscaledSize2 = camera.UnscaledSize;
			this._workingLightMap.SetSize(1073741824, num);
			this._activeLightMap.SetSize(1073741824, num);
		}

		// Token: 0x06003E7D RID: 15997 RVA: 0x0023D644 File Offset: 0x0023B844
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		[Il2CppSetOption(Option.NullChecks, false)]
		public void AddLight(int x, int y, Vector3 color)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x06003E7E RID: 15998 RVA: 0x0023D65C File Offset: 0x0023B85C
		public void ProcessArea(Rectangle area)
		{
			float skyColor = this._skyColor;
			this._oldSkyColor = skyColor;
			if (skyColor == null)
			{
			}
			Main.renderCount = Main.renderCount;
			Vector2 unscaledSize = this._camera.UnscaledSize;
			if (skyColor == null)
			{
			}
			Vector2 unscaledSize2 = this._camera.UnscaledSize;
			Vector2 screenLastPosition = Main.screenLastPosition;
			int renderCount = Main.renderCount;
			this.DoColors();
			if (skyColor == null)
			{
			}
			int renderCount2 = Main.renderCount;
			this.Present();
		}

		// Token: 0x06003E7F RID: 15999 RVA: 0x000021DB File Offset: 0x000003DB
		public Rectangle GetScanRegion()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003E80 RID: 16000 RVA: 0x0023D760 File Offset: 0x0023B960
		[Il2CppSetOption(Option.NullChecks, false)]
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		private void ExportToMiniMap()
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool mapEnabled = Main.mapEnabled;
			if (num == 0)
			{
			}
			bool mapReady = Main.mapReady;
			int width = this._activeProcessedArea.Width;
			int height = this._activeProcessedArea.Height;
			Rectangle activeProcessedArea = this._activeProcessedArea;
			int width2 = this._activeProcessedArea.Width;
			if (width == 0)
			{
			}
			if (width == 0)
			{
			}
			Rectangle rectangle;
			Main.mapMaxX = rectangle.Right;
			int num2;
			Main.mapMaxY = num2;
			WorldMap map = Main.Map;
			LightMap activeLightMap = this._activeLightMap;
			Vector3[] colors = activeLightMap._colors;
			int <Height>k__BackingField = activeLightMap.<Height>k__BackingField;
			if (colors != null && <Height>k__BackingField != 0)
			{
				return;
			}
			if (colors == null)
			{
			}
			if (<Height>k__BackingField != 0 && activeProcessedArea != null)
			{
				return;
			}
			if (<Height>k__BackingField == 0)
			{
			}
			if (<Height>k__BackingField != 0)
			{
				return;
			}
			Rectangle rectangle2 = this.screenRegionScan;
			int width3 = this.screenRegionScan.Width;
			int width4 = this.screenRegionScan.Width;
			Rectangle activeProcessedArea2 = this._activeProcessedArea;
			int y = this._activeProcessedArea.Y;
		}

		// Token: 0x06003E81 RID: 16001 RVA: 0x0023D954 File Offset: 0x0023BB54
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		[Il2CppSetOption(Option.NullChecks, false)]
		private void UpdateLightToSkyColor(float tileR, float tileG, float tileB)
		{
			Rectangle activeProcessedArea = this._activeProcessedArea;
			if (this == null)
			{
			}
			int y = this._activeProcessedArea.Y;
			LightMap activeLightMap = this._activeLightMap;
			Vector3[] colors = activeLightMap._colors;
			int <Height>k__BackingField = activeLightMap.<Height>k__BackingField;
			if (colors != null && <Height>k__BackingField != 0)
			{
				return;
			}
			if (colors == null)
			{
			}
			int y2 = this._activeProcessedArea.Y;
			float skyColor = this._skyColor;
			if (y2 == 0)
			{
			}
			if (y2 != 0)
			{
				float skyColor2 = this._skyColor;
			}
		}

		// Token: 0x06003E82 RID: 16002 RVA: 0x0023D9C4 File Offset: 0x0023BBC4
		private void Present()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06003E83 RID: 16003 RVA: 0x0023D9D4 File Offset: 0x0023BBD4
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		[Il2CppSetOption(Option.NullChecks, false)]
		public void Clear()
		{
			this._activeLightMap.Clear();
			this._workingLightMap.Clear();
		}

		// Token: 0x06003E84 RID: 16004 RVA: 0x0023D9F8 File Offset: 0x0023BBF8
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		[Il2CppSetOption(Option.NullChecks, false)]
		private void PreRenderPhase(Rectangle area)
		{
			if (!true)
			{
			}
			this._workingLightMap.Clear();
			int num = 20;
			int num2 = 20;
			this._workingLightMap.SetSize(num, num2);
			SceneMetrics sceneMetrics = Main.SceneMetrics;
			Vector2 center = Main.LocalPlayer.Center;
			bool accOreFinder = Main.LocalPlayer.accOreFinder;
			this._tileScanner.Update();
			int width = this._workingProcessedArea.Width;
			TileLightScanner tileScanner = this._tileScanner;
			LightMap workingLightMap = this._workingLightMap;
			Rectangle workingProcessedArea = this._workingProcessedArea;
			if (!accOreFinder)
			{
			}
			Vector3[] colors = this._workingLightMap._colors;
			if (colors != null)
			{
				return;
			}
			if (colors == null)
			{
			}
			if (colors == null)
			{
			}
			float z = colors.Z;
			LightMap workingLightMap2 = this._workingLightMap;
			Rectangle workingProcessedArea2 = this._workingProcessedArea;
			int width2 = this._workingProcessedArea.Width;
			int <Height>k__BackingField = workingLightMap2.<Height>k__BackingField;
		}

		// Token: 0x06003E85 RID: 16005 RVA: 0x0023DB14 File Offset: 0x0023BD14
		private void UpdateLightDecay()
		{
			LightMap workingLightMap = this._workingLightMap;
			int myPlayer = Main.myPlayer;
			float lightDecayThroughAir = workingLightMap.LightDecayThroughAir;
			workingLightMap.LightDecayThroughAir = lightDecayThroughAir;
			float lightDecayThroughSolid = workingLightMap.LightDecayThroughSolid;
			workingLightMap.LightDecayThroughSolid = lightDecayThroughSolid;
			int myPlayer2 = Main.myPlayer;
			float lightDecayThroughAir2 = workingLightMap.LightDecayThroughAir;
			workingLightMap.LightDecayThroughAir = lightDecayThroughAir2;
			float lightDecayThroughSolid2 = workingLightMap.LightDecayThroughSolid;
			workingLightMap.LightDecayThroughSolid = lightDecayThroughSolid2;
			int myPlayer3 = Main.myPlayer;
			float lightDecayThroughAir3 = workingLightMap.LightDecayThroughAir;
			workingLightMap.LightDecayThroughAir = lightDecayThroughAir3;
			float lightDecayThroughSolid3 = workingLightMap.LightDecayThroughSolid;
			workingLightMap.LightDecayThroughSolid = lightDecayThroughSolid3;
			int myPlayer4 = Main.myPlayer;
			float lightDecayThroughAir4 = workingLightMap.LightDecayThroughAir;
			workingLightMap.LightDecayThroughAir = lightDecayThroughAir4;
			float lightDecayThroughSolid4 = workingLightMap.LightDecayThroughSolid;
			workingLightMap.LightDecayThroughSolid = lightDecayThroughSolid4;
			float lightDecayThroughAir5 = workingLightMap.LightDecayThroughAir;
			float lightDecayThroughAir6 = workingLightMap.LightDecayThroughAir;
			float lightDecayThroughAir7 = workingLightMap.LightDecayThroughAir;
			Vector3 lightDecayThroughWater = workingLightMap.LightDecayThroughWater;
		}

		// Token: 0x06003E86 RID: 16006 RVA: 0x0023DBEC File Offset: 0x0023BDEC
		private void DoColors()
		{
			int num = 1;
			this.UpdateLightDecay();
			if (num == 0)
			{
			}
			int renderCount = Main.renderCount;
			this._workingLightMap.ExecutePartialBlur(0);
		}

		// Token: 0x06003E87 RID: 16007 RVA: 0x0023DC18 File Offset: 0x0023BE18
		// Note: this type is marked as 'beforefieldinit'.
		static LegacyLighting()
		{
		}

		// Token: 0x04007D2D RID: 32045
		public static int RenderPhases;

		// Token: 0x04007D2E RID: 32046
		private static short tempLightOffset;

		// Token: 0x04007D2F RID: 32047
		private static List<LegacyLighting.ColorTriplet> tempLightData;

		// Token: 0x04007D30 RID: 32048
		private static Dictionary<int, short> tempLights;

		// Token: 0x04007D31 RID: 32049
		private const int AREA_PADDING = 20;

		// Token: 0x04007D32 RID: 32050
		private const int NON_VISIBLE_PADDING = 0;

		// Token: 0x04007D33 RID: 32051
		private float _oldSkyColor;

		// Token: 0x04007D34 RID: 32052
		private float _skyColor;

		// Token: 0x04007D35 RID: 32053
		private LightMap _activeLightMap;

		// Token: 0x04007D36 RID: 32054
		private Rectangle _activeProcessedArea;

		// Token: 0x04007D37 RID: 32055
		private LightMap _workingLightMap;

		// Token: 0x04007D38 RID: 32056
		private Rectangle _workingProcessedArea;

		// Token: 0x04007D39 RID: 32057
		private const int MAX_TEMP_LIGHTS = 2000;

		// Token: 0x04007D3A RID: 32058
		private TileLightScanner _tileScanner;

		// Token: 0x04007D3B RID: 32059
		private readonly Camera _camera;

		// Token: 0x04007D3C RID: 32060
		[CompilerGenerated]
		private int <Mode>k__BackingField;

		// Token: 0x04007D3D RID: 32061
		private Rectangle screenRegionScan;

		// Token: 0x02000774 RID: 1908
		private class ColorTriplet
		{
			// Token: 0x06003E88 RID: 16008 RVA: 0x0023DC28 File Offset: 0x0023BE28
			public ColorTriplet(float R, float G, float B)
			{
			}

			// Token: 0x06003E89 RID: 16009 RVA: 0x0023DC3C File Offset: 0x0023BE3C
			public ColorTriplet(float averageColor)
			{
			}

			// Token: 0x04007D3E RID: 32062
			public float R;

			// Token: 0x04007D3F RID: 32063
			public float G;

			// Token: 0x04007D40 RID: 32064
			public float B;
		}
	}
}
