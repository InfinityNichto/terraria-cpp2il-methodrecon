using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using ReLogic.Content;
using Terraria.Audio;
using Terraria.GameContent;
using Terraria.GameContent.UI.Minimap;
using Terraria.GameContent.UI.ResourceSets;
using Terraria.IO;

namespace Terraria.Initializers
{
	// Token: 0x02000582 RID: 1410
	public static class AssetInitializer
	{
		// Token: 0x06003467 RID: 13415 RVA: 0x00204DF4 File Offset: 0x00202FF4
		public static void CreateAssetServices(GameServiceContainer services)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06003468 RID: 13416 RVA: 0x00204E04 File Offset: 0x00203004
		public static void LoadSplashAssets(bool asyncLoadForSounds)
		{
			int num;
			string text = num.ToString();
			Asset asset = AssetInitializer.LoadAsset("Images\\SplashScreens\\Splash_" + text + "_0", AssetRequestMode.ImmediateLoad);
			string text2;
			Asset asset2 = AssetInitializer.LoadAsset("Images\\SplashScreens\\Splash_" + text2 + "_1", AssetRequestMode.ImmediateLoad);
			string text3;
			Asset asset3 = AssetInitializer.LoadAsset("Images\\SplashScreens\\Splash_" + text3 + "_2", AssetRequestMode.ImmediateLoad);
			string text4;
			Asset asset4 = AssetInitializer.LoadAsset("Images\\Item_" + text4, AssetRequestMode.ImmediateLoad);
			if (asset4 == null || asset4 != null)
			{
				Asset asset5 = AssetInitializer.LoadAsset("Images\\UI\\Sunflower_Loading", AssetRequestMode.ImmediateLoad);
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06003469 RID: 13417 RVA: 0x000021DB File Offset: 0x000003DB
		public static IEnumerator LoadAssetsWhileInInitialBlackScreen_InSteps()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600346A RID: 13418 RVA: 0x00204E90 File Offset: 0x00203090
		public static void LoadAssetsWhileInInitialBlackScreen()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x0600346B RID: 13419 RVA: 0x00204F14 File Offset: 0x00203114
		public static void Load(bool asyncLoad)
		{
		}

		// Token: 0x0600346C RID: 13420 RVA: 0x000021DB File Offset: 0x000003DB
		private static IEnumerator LoadFonts_InSteps(AssetRequestMode mode)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600346D RID: 13421 RVA: 0x00204F24 File Offset: 0x00203124
		private static void LoadFonts(AssetRequestMode mode)
		{
			Asset asset = AssetInitializer.LoadAsset("Fonts/Item_Stack", mode);
			Asset asset2 = AssetInitializer.LoadAsset("Fonts/Mouse_Text", mode);
			Asset asset3 = AssetInitializer.LoadAsset("Fonts/Death_Text", mode);
			Asset asset4 = AssetInitializer.LoadAsset("Fonts/Combat_Text", mode);
			if (asset4 == null || asset4 != null)
			{
				Asset asset5 = AssetInitializer.LoadAsset("Fonts/Combat_Crit", mode);
				if (asset5 == null || asset5 != null)
				{
					return;
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600346E RID: 13422 RVA: 0x00204F84 File Offset: 0x00203184
		private static void LoadSounds(AssetRequestMode mode)
		{
			if (!true)
			{
			}
			GameServiceContainer gameServiceContainer;
			SoundEngine.Load(gameServiceContainer);
		}

		// Token: 0x0600346F RID: 13423 RVA: 0x00204F9C File Offset: 0x0020319C
		private static void LoadRenderTargetAssets(AssetRequestMode mode)
		{
		}

		// Token: 0x06003470 RID: 13424 RVA: 0x00204FAC File Offset: 0x002031AC
		private static void RegisterRenderTargetAsset(INeedRenderTargetContent content)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06003471 RID: 13425 RVA: 0x000021DB File Offset: 0x000003DB
		private static IEnumerator LoadTextures_InSteps(AssetRequestMode mode)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003472 RID: 13426 RVA: 0x00204FC0 File Offset: 0x002031C0
		private static void LoadTextures(AssetRequestMode mode)
		{
			int num = 1;
			long num2 = 0L;
			if (num == 0)
			{
			}
			if (num2 == 0L)
			{
				return;
			}
			Asset asset;
			if (asset != null)
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06003473 RID: 13427 RVA: 0x00206DCC File Offset: 0x00204FCC
		private static void LoadMinimapFrames(AssetRequestMode mode)
		{
			if ("Valkyrie" == null)
			{
			}
			Preferences configuration = Main.Configuration;
			if (Main.ActiveMinimapFrame == null)
			{
				MinimapFrame minimapFrame;
				Main.ActiveMinimapFrame = minimapFrame;
			}
		}

		// Token: 0x06003474 RID: 13428 RVA: 0x00206DF8 File Offset: 0x00204FF8
		private static void Configuration_OnSave_MinimapFrame(Preferences obj)
		{
		}

		// Token: 0x06003475 RID: 13429 RVA: 0x00206E08 File Offset: 0x00205008
		private static void LoadMinimap(string name, Vector2 frameOffset, Vector2 resetPosition, Vector2 zoomInPosition, Vector2 zoomOutPosition, AssetRequestMode mode)
		{
			string text = "Images\\UI\\Minimap\\" + name + "\\MinimapFrame";
			string text2 = "Images\\UI\\Minimap\\" + name + "\\MinimapButton_Reset";
			string text3 = "Images\\UI\\Minimap\\" + name + "\\MinimapButton_ZoomOut";
			string text4 = "Images\\UI\\Minimap\\" + name + "\\MinimapButton_ZoomIn";
		}

		// Token: 0x06003476 RID: 13430 RVA: 0x00206E5C File Offset: 0x0020505C
		private static void LoadPlayerResourceSets(AssetRequestMode mode)
		{
			if (!true)
			{
			}
			Preferences configuration = Main.Configuration;
			if (Main.ActivePlayerResourcesSet != null)
			{
				return;
			}
			IPlayerResourcesDisplaySet playerResourcesDisplaySet;
			Main.ActivePlayerResourcesSet = playerResourcesDisplaySet;
		}

		// Token: 0x06003477 RID: 13431 RVA: 0x00206E84 File Offset: 0x00205084
		private static void Configuration_OnSave_PlayerResourcesSet(Preferences obj)
		{
		}

		// Token: 0x06003478 RID: 13432 RVA: 0x00206E94 File Offset: 0x00205094
		private static Asset<T> LoadAsset<T>(string assetName, AssetRequestMode mode) where T : class
		{
			/*
An exception occurred when decompiling this method (06003478)

ICSharpCode.Decompiler.DecompilerException: Error decompiling ReLogic.Content.Asset`1<T> Terraria.Initializers.AssetInitializer::LoadAsset<T>(System.String,ReLogic.Content.AssetRequestMode)

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

		// Token: 0x0400414B RID: 16715
		public static bool initialAssetsLoaded;

		// Token: 0x02000583 RID: 1411
		[CompilerGenerated]
		private sealed class <LoadAssetsWhileInInitialBlackScreen_InSteps>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06003479 RID: 13433 RVA: 0x00206EA4 File Offset: 0x002050A4
			[DebuggerHidden]
			public <LoadAssetsWhileInInitialBlackScreen_InSteps>d__3(int <>1__state)
			{
				this.<>1__state = <>1__state;
			}

			// Token: 0x0600347A RID: 13434 RVA: 0x00206EC0 File Offset: 0x002050C0
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			// Token: 0x0600347B RID: 13435 RVA: 0x00206ED0 File Offset: 0x002050D0
			private bool MoveNext()
			{
				/*
An exception occurred when decompiling this method (0600347B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Initializers.AssetInitializer/<LoadAssetsWhileInInitialBlackScreen_InSteps>d__3::MoveNext()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0150:
	stloc:int64(var_38_157, ldfld:int64(int64::m_value, ldloc:int64[exp:int64&](var_36)))
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

			// Token: 0x17000680 RID: 1664
			// (get) Token: 0x0600347C RID: 13436 RVA: 0x00207038 File Offset: 0x00205238
			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return this.<>2__current;
				}
			}

			// Token: 0x0600347D RID: 13437 RVA: 0x000021DB File Offset: 0x000003DB
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x17000681 RID: 1665
			// (get) Token: 0x0600347E RID: 13438 RVA: 0x0020704C File Offset: 0x0020524C
			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return this.<>2__current;
				}
			}

			// Token: 0x0400414C RID: 16716
			private int <>1__state;

			// Token: 0x0400414D RID: 16717
			private object <>2__current;

			// Token: 0x0400414E RID: 16718
			private bool <doneLoadingFonts>5__2;

			// Token: 0x0400414F RID: 16719
			private IEnumerator <fontLoadProcedure>5__3;

			// Token: 0x04004150 RID: 16720
			private bool <doneLoadingTextures>5__4;

			// Token: 0x04004151 RID: 16721
			private IEnumerator <textureLoadProcedure>5__5;
		}

		// Token: 0x02000584 RID: 1412
		[CompilerGenerated]
		private sealed class <LoadFonts_InSteps>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x0600347F RID: 13439 RVA: 0x00207060 File Offset: 0x00205260
			[DebuggerHidden]
			public <LoadFonts_InSteps>d__6(int <>1__state)
			{
				this.<>1__state = <>1__state;
			}

			// Token: 0x06003480 RID: 13440 RVA: 0x0020707C File Offset: 0x0020527C
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06003481 RID: 13441 RVA: 0x0020708C File Offset: 0x0020528C
			private bool MoveNext()
			{
				int num = this.<>1__state;
				AssetRequestMode assetRequestMode = this.mode;
				Asset asset = AssetInitializer.LoadAsset("Fonts/Item_Stack", assetRequestMode);
				int num2 = 1;
				this.<>1__state = num2;
				if (num2 == 0)
				{
				}
				AssetRequestMode assetRequestMode2 = this.mode;
				Asset asset2 = AssetInitializer.LoadAsset("Fonts/Combat_Text", assetRequestMode2);
				if (asset2 == null || asset2 != null)
				{
					AssetRequestMode assetRequestMode3 = this.mode;
					Asset asset3 = AssetInitializer.LoadAsset("Fonts/Mouse_Text", assetRequestMode3);
					AssetRequestMode assetRequestMode4 = this.mode;
					Asset asset4 = AssetInitializer.LoadAsset("Fonts/Death_Text", assetRequestMode4);
					int num3 = 3;
					this.<>1__state = num3;
					if (num3 == 0)
					{
					}
					AssetRequestMode assetRequestMode5 = this.mode;
					Asset asset5 = AssetInitializer.LoadAsset("Fonts/Combat_Crit", assetRequestMode5);
					if (asset5 == null || asset5 != null)
					{
						int num4 = 5;
						this.<>1__state = num4;
					}
				}
				throw new ArrayTypeMismatchException();
			}

			// Token: 0x17000682 RID: 1666
			// (get) Token: 0x06003482 RID: 13442 RVA: 0x000021DB File Offset: 0x000003DB
			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			// Token: 0x06003483 RID: 13443 RVA: 0x000021DB File Offset: 0x000003DB
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x17000683 RID: 1667
			// (get) Token: 0x06003484 RID: 13444 RVA: 0x00207150 File Offset: 0x00205350
			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return this.<>2__current;
				}
			}

			// Token: 0x04004152 RID: 16722
			private int <>1__state;

			// Token: 0x04004153 RID: 16723
			private object <>2__current;

			// Token: 0x04004154 RID: 16724
			public AssetRequestMode mode;
		}

		// Token: 0x02000585 RID: 1413
		[CompilerGenerated]
		private sealed class <LoadTextures_InSteps>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06003485 RID: 13445 RVA: 0x00207164 File Offset: 0x00205364
			[DebuggerHidden]
			public <LoadTextures_InSteps>d__11(int <>1__state)
			{
				this.<>1__state = <>1__state;
			}

			// Token: 0x06003486 RID: 13446 RVA: 0x00207180 File Offset: 0x00205380
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06003487 RID: 13447 RVA: 0x00207190 File Offset: 0x00205390
			private bool MoveNext()
			{
				int num = this.<>1__state;
				return "Images\\WallOfFlesh" != null;
			}

			// Token: 0x17000684 RID: 1668
			// (get) Token: 0x06003488 RID: 13448 RVA: 0x002099A4 File Offset: 0x00207BA4
			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return this.<>2__current;
				}
			}

			// Token: 0x06003489 RID: 13449 RVA: 0x000021DB File Offset: 0x000003DB
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x17000685 RID: 1669
			// (get) Token: 0x0600348A RID: 13450 RVA: 0x002099B8 File Offset: 0x00207BB8
			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return this.<>2__current;
				}
			}

			// Token: 0x04004155 RID: 16725
			private int <>1__state;

			// Token: 0x04004156 RID: 16726
			private object <>2__current;

			// Token: 0x04004157 RID: 16727
			public AssetRequestMode mode;
		}

		// Token: 0x02000586 RID: 1414
		[CompilerGenerated]
		private sealed class <>c__DisplayClass13_0
		{
			// Token: 0x0600348B RID: 13451 RVA: 0x002099CC File Offset: 0x00207BCC
			public <>c__DisplayClass13_0()
			{
			}

			// Token: 0x0600348C RID: 13452 RVA: 0x002099E0 File Offset: 0x00207BE0
			internal bool <LoadMinimapFrames>b__0(KeyValuePair<string, MinimapFrame> pair)
			{
				string text = this.frameName;
				bool flag;
				return flag;
			}

			// Token: 0x04004158 RID: 16728
			public string frameName;
		}

		// Token: 0x02000587 RID: 1415
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600348D RID: 13453 RVA: 0x002099F8 File Offset: 0x00207BF8
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x0600348E RID: 13454 RVA: 0x00209A08 File Offset: 0x00207C08
			public <>c()
			{
			}

			// Token: 0x0600348F RID: 13455 RVA: 0x00209A1C File Offset: 0x00207C1C
			internal bool <Configuration_OnSave_MinimapFrame>b__14_0(KeyValuePair<string, MinimapFrame> pair)
			{
				/*
An exception occurred when decompiling this method (0600348F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Initializers.AssetInitializer/<>c::<Configuration_OnSave_MinimapFrame>b__14_0(System.Collections.Generic.KeyValuePair`2<System.String,Terraria.GameContent.UI.Minimap.MinimapFrame>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:MinimapFrame(var_1_0A, callgetter:MinimapFrame(Main::get_ActiveMinimapFrame))
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

			// Token: 0x06003490 RID: 13456 RVA: 0x00209A34 File Offset: 0x00207C34
			internal bool <Configuration_OnSave_PlayerResourcesSet>b__17_0(KeyValuePair<string, IPlayerResourcesDisplaySet> pair)
			{
				/*
An exception occurred when decompiling this method (06003490)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Initializers.AssetInitializer/<>c::<Configuration_OnSave_PlayerResourcesSet>b__17_0(System.Collections.Generic.KeyValuePair`2<System.String,Terraria.GameContent.UI.ResourceSets.IPlayerResourcesDisplaySet>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:IPlayerResourcesDisplaySet(var_1_0A, callgetter:IPlayerResourcesDisplaySet(Main::get_ActivePlayerResourcesSet))
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

			// Token: 0x04004159 RID: 16729
			public static readonly AssetInitializer.<>c <>9;

			// Token: 0x0400415A RID: 16730
			public static Func<KeyValuePair<string, MinimapFrame>, bool> <>9__14_0;

			// Token: 0x0400415B RID: 16731
			public static Func<KeyValuePair<string, IPlayerResourcesDisplaySet>, bool> <>9__17_0;
		}

		// Token: 0x02000588 RID: 1416
		[CompilerGenerated]
		private sealed class <>c__DisplayClass16_0
		{
			// Token: 0x06003491 RID: 13457 RVA: 0x00209A4C File Offset: 0x00207C4C
			public <>c__DisplayClass16_0()
			{
			}

			// Token: 0x06003492 RID: 13458 RVA: 0x00209A60 File Offset: 0x00207C60
			internal bool <LoadPlayerResourceSets>b__0(KeyValuePair<string, IPlayerResourcesDisplaySet> pair)
			{
				string text = this.frameName;
				bool flag;
				return flag;
			}

			// Token: 0x0400415C RID: 16732
			public string frameName;
		}
	}
}
