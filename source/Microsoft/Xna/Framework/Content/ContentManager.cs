using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using UnityEngine;

namespace Microsoft.Xna.Framework.Content
{
	// Token: 0x020003C3 RID: 963
	public class ContentManager
	{
		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06001A33 RID: 6707 RVA: 0x0006BE4C File Offset: 0x0006A04C
		public IServiceProvider ServiceProvider
		{
			get
			{
				return this.serviceProvider;
			}
		}

		// Token: 0x06001A34 RID: 6708 RVA: 0x0006BE60 File Offset: 0x0006A060
		public ContentManager(IServiceProvider serviceProvider, string p)
		{
			this.serviceProvider = serviceProvider;
			this.p = p;
			if (!true)
			{
			}
		}

		// Token: 0x06001A35 RID: 6709 RVA: 0x0006BE84 File Offset: 0x0006A084
		internal T1 Load<T1>(string A_1) where T1 : class
		{
			SpriteEffect effect4;
			do
			{
				string text = Path.Combine("Content", A_1).Replace("\\", "/");
				Type type;
				Type type2;
				bool flag = type == type2;
				object obj = Convert.ChangeType(this.LoadTexture2D(text), type);
				Type type3;
				bool flag2 = type == type3;
				bool flag3 = text == "Content/TileShader";
				TileShader effect = TileShader.Effect;
				Type type4;
				bool flag4 = type == type4;
				PixelShader effect2 = PixelShader.Effect;
				Type type5;
				bool flag5 = type == type5;
				bool flag6 = text == "Content/ScreenShader";
				ScreenShader effect3 = ScreenShader.Effect;
				effect4 = SpriteEffect.Effect;
				if (effect4 == null)
				{
					return;
				}
			}
			while (effect4 != null);
			throw new InvalidCastException();
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06001A36 RID: 6710 RVA: 0x0006BF38 File Offset: 0x0006A138
		public static bool AsyncLoadStillRequired
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001A36)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Microsoft.Xna.Framework.Content.ContentManager::get_AsyncLoadStillRequired()

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
		}

		// Token: 0x06001A37 RID: 6711 RVA: 0x0006BF48 File Offset: 0x0006A148
		public static void UpdateAysncLoad()
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			DateTime now = DateTime.Now;
			if (!true)
			{
			}
			Debug.Log("Loaded Texture Assets");
			double totalMilliseconds = (DateTime.Now - now).TotalMilliseconds;
		}

		// Token: 0x06001A38 RID: 6712 RVA: 0x0006BF84 File Offset: 0x0006A184
		public static void LoadUnityTexturePageAsync(string asset0, string asset1, string asset2, int pageIndex, Action<global::UnityEngine.Texture2D, global::UnityEngine.Texture2D, global::UnityEngine.Texture2D, int> loadedCallback)
		{
			Thread currentThread = Thread.CurrentThread;
			Debug.LogError("Not Main thread");
		}

		// Token: 0x06001A39 RID: 6713 RVA: 0x0006BFA8 File Offset: 0x0006A1A8
		public static ResourceType LoadUnityResource<ResourceType>(string A_0) where ResourceType : global::UnityEngine.Object
		{
			global::UnityEngine.Object @object;
			do
			{
				Thread currentThread = Thread.CurrentThread;
				if (@object == null)
				{
					return;
				}
			}
			while (@object != null);
			throw new InvalidCastException();
		}

		// Token: 0x06001A3A RID: 6714 RVA: 0x0006BFCC File Offset: 0x0006A1CC
		public static ResourceType ConstructFromUnityResource<ResourceType>(string asset, ThreadContentRequest.ObjectCreate createFunction) where ResourceType : class
		{
			IntPtr extra_arg;
			do
			{
				Thread currentThread = Thread.CurrentThread;
				extra_arg = createFunction.extra_arg;
				IntPtr extra_arg2 = createFunction.extra_arg;
				IntPtr extra_arg3 = createFunction.extra_arg;
				if (extra_arg == 0)
				{
					return;
				}
			}
			while (extra_arg != 0);
			throw new InvalidCastException();
		}

		// Token: 0x06001A3B RID: 6715 RVA: 0x0006C008 File Offset: 0x0006A208
		public static ResourceType ConstructFromUnityResources<ResourceType>(string asset, string asset2, ThreadContentRequest.ObjectCreate2 createFunction) where ResourceType : class
		{
			IntPtr extra_arg;
			do
			{
				Thread currentThread = Thread.CurrentThread;
				extra_arg = createFunction.extra_arg;
				global::UnityEngine.Object @object = Resources.Load(asset);
				IntPtr extra_arg2 = createFunction.extra_arg;
				IntPtr extra_arg3 = createFunction.extra_arg;
				if (extra_arg == 0)
				{
					return;
				}
			}
			while (extra_arg != 0);
			throw new InvalidCastException();
		}

		// Token: 0x06001A3C RID: 6716 RVA: 0x0006C04C File Offset: 0x0006A24C
		public static ResourceType ConstructFromUnityResources<ResourceType>(string asset, string asset2, string asset3, ThreadContentRequest.ObjectCreate3 createFunction) where ResourceType : class
		{
			IntPtr extra_arg;
			do
			{
				Thread currentThread = Thread.CurrentThread;
				extra_arg = createFunction.extra_arg;
				global::UnityEngine.Object @object = Resources.Load(asset);
				global::UnityEngine.Object object2 = Resources.Load(asset2);
				IntPtr extra_arg2 = createFunction.extra_arg;
				IntPtr extra_arg3 = createFunction.extra_arg;
				if (extra_arg == 0)
				{
					return;
				}
			}
			while (extra_arg != 0);
			throw new InvalidCastException();
		}

		// Token: 0x06001A3D RID: 6717 RVA: 0x000021DB File Offset: 0x000003DB
		private static object CreateTextureAsset(object resource)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001A3E RID: 6718 RVA: 0x0006C098 File Offset: 0x0006A298
		private static object CreateTextureAssets(object resource, object resource2)
		{
			/*
An exception occurred when decompiling this method (06001A3E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object Microsoft.Xna.Framework.Content.ContentManager::CreateTextureAssets(System.Object,System.Object)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:Texture2D(var_1_08, callgetter:Texture2D(ContentManager::get_Empty))
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

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06001A3F RID: 6719 RVA: 0x0006C0B0 File Offset: 0x0006A2B0
		private static global::UnityEngine.Texture2D Empty
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001A3F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.Texture2D Microsoft.Xna.Framework.Content.ContentManager::get_Empty()

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
		}

		// Token: 0x06001A40 RID: 6720 RVA: 0x0006C0C0 File Offset: 0x0006A2C0
		private static object CreateTextureAssetsWithPal(object resource, object resource2, object resource3)
		{
			/*
An exception occurred when decompiling this method (06001A40)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object Microsoft.Xna.Framework.Content.ContentManager::CreateTextureAssetsWithPal(System.Object,System.Object,System.Object)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0006:
	stloc:Texture2D(var_1_0B, callgetter:Texture2D(ContentManager::get_Empty))
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

		// Token: 0x06001A41 RID: 6721 RVA: 0x0006C0D8 File Offset: 0x0006A2D8
		public void UnloadSourceTextures()
		{
			int size = this._sourceTexturesLoaded._size;
			int size2 = this._sourceTexturesLoaded._size;
		}

		// Token: 0x06001A42 RID: 6722 RVA: 0x0006C100 File Offset: 0x0006A300
		private Microsoft.Xna.Framework.Graphics.Texture2D LoadTexture2D(string asset)
		{
			string text = asset.ToLower();
			int num = 92;
			int num2 = 47;
			string text2 = text.Replace((char)num, (char)num2);
			Dictionary<string, Microsoft.Xna.Framework.Graphics.Texture2D> loadedTextures = this._loadedTextures;
			bool flag = text2.Contains("images/misc/perlin");
			bool flag2 = text2.Contains("images/misc/noise");
			bool flag3 = text2.Contains("images/misc/ripples");
			bool flag4 = asset.Contains("Fonts/");
			bool flag5 = asset.StartsWith("Content/Fonts/Mouse_Text_");
			bool flag6 = asset.StartsWith("Content/Fonts/Death_Text_");
			bool flag7 = asset.Contains("SplashScreens/");
			string text3 = asset + "_A";
			string text4 = asset + "_P";
			List<Microsoft.Xna.Framework.Graphics.Texture2D> sourceTexturesLoaded = this._sourceTexturesLoaded;
			int size = sourceTexturesLoaded._size;
			object syncRoot = sourceTexturesLoaded._syncRoot;
			sourceTexturesLoaded._version = syncRoot;
			string text5 = asset + "_A";
			Microsoft.Xna.Framework.Graphics.Texture2D texture2D;
			return texture2D;
		}

		// Token: 0x06001A43 RID: 6723 RVA: 0x0006C21C File Offset: 0x0006A41C
		private SpriteFont LoadSpriteFont(string asset)
		{
			if (!true)
			{
			}
			byte[] bytes = ContentManager.LoadUnityResource<TextAsset>(asset).bytes;
			Encoding unicode = Encoding.Unicode;
			if (!true)
			{
			}
			string text2;
			string text = asset + "_" + text2;
			Microsoft.Xna.Framework.Graphics.Texture2D texture2D = this.LoadTexture2D(text);
			if (texture2D == null || texture2D != null)
			{
				long num = 0L;
				if (asset != null)
				{
				}
				if (num != 0L)
				{
					throw new OutOfMemoryException();
				}
				if (false)
				{
					throw new OutOfMemoryException();
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06001A44 RID: 6724 RVA: 0x000021DB File Offset: 0x000003DB
		private static object CreateSoundEffect(object resource)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001A45 RID: 6725 RVA: 0x0006C2B0 File Offset: 0x0006A4B0
		private SoundEffect LoadSoundEffect(string asset)
		{
			if (!true)
			{
			}
			SoundEffect soundEffect;
			bool flag = string.IsNullOrEmpty(soundEffect.Definition.Id);
			Debug.LogError("Missing sound " + asset);
			return soundEffect;
		}

		// Token: 0x06001A46 RID: 6726 RVA: 0x0006C2E4 File Offset: 0x0006A4E4
		internal void Unload()
		{
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06001A47 RID: 6727 RVA: 0x0006C2F4 File Offset: 0x0006A4F4
		// (set) Token: 0x06001A48 RID: 6728 RVA: 0x0006C308 File Offset: 0x0006A508
		public string RootDirectory
		{
			[CompilerGenerated]
			get
			{
				return this.<RootDirectory>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<RootDirectory>k__BackingField = value;
			}
		}

		// Token: 0x06001A49 RID: 6729 RVA: 0x0006C31C File Offset: 0x0006A51C
		// Note: this type is marked as 'beforefieldinit'.
		static ContentManager()
		{
		}

		// Token: 0x040027AD RID: 10157
		public static ContentManager Instance;

		// Token: 0x040027AE RID: 10158
		private IServiceProvider serviceProvider;

		// Token: 0x040027AF RID: 10159
		private string p;

		// Token: 0x040027B0 RID: 10160
		private static List<ContentManager.TextureLoadEntry> LoadingAssets;

		// Token: 0x040027B1 RID: 10161
		private static global::UnityEngine.Texture2D emptyTexture;

		// Token: 0x040027B2 RID: 10162
		private static ContentManager.SourceAssetEntry[] sourceAssets;

		// Token: 0x040027B3 RID: 10163
		private List<Microsoft.Xna.Framework.Graphics.Texture2D> _sourceTexturesLoaded;

		// Token: 0x040027B4 RID: 10164
		private Dictionary<string, Microsoft.Xna.Framework.Graphics.Texture2D> _loadedTextures;

		// Token: 0x040027B5 RID: 10165
		private static int total;

		// Token: 0x040027B6 RID: 10166
		[CompilerGenerated]
		private string <RootDirectory>k__BackingField;

		// Token: 0x020003C4 RID: 964
		public class TextureLoadEntry
		{
			// Token: 0x06001A4A RID: 6730 RVA: 0x0006C330 File Offset: 0x0006A530
			public bool Update()
			{
				bool flag = string.IsNullOrEmpty(this.loadAsset0);
				bool flag2 = string.IsNullOrEmpty(this.loadAsset1);
				bool flag3 = string.IsNullOrEmpty(this.loadAsset2);
				if (Resources.Load(this.loadAsset0) == null || Resources.Load(this.loadAsset1) != null)
				{
					long num = 0L;
					this.request0 = num;
					if (Resources.Load(this.loadAsset2) == null)
					{
						goto IL_0069;
					}
				}
				long num2 = 0L;
				this.request1 = num2;
				IL_0069:
				Action<global::UnityEngine.Texture2D, global::UnityEngine.Texture2D, global::UnityEngine.Texture2D, int> callback = this.Callback;
				global::UnityEngine.Texture2D texture2D = this.request0;
				global::UnityEngine.Texture2D texture2D2 = this.request1;
				int num3 = this.page;
				return true;
			}

			// Token: 0x06001A4B RID: 6731 RVA: 0x0006C3C8 File Offset: 0x0006A5C8
			public TextureLoadEntry()
			{
			}

			// Token: 0x040027B7 RID: 10167
			public string loadAsset0;

			// Token: 0x040027B8 RID: 10168
			public string loadAsset1;

			// Token: 0x040027B9 RID: 10169
			public string loadAsset2;

			// Token: 0x040027BA RID: 10170
			public global::UnityEngine.Texture2D request0;

			// Token: 0x040027BB RID: 10171
			public global::UnityEngine.Texture2D request1;

			// Token: 0x040027BC RID: 10172
			public global::UnityEngine.Texture2D request2;

			// Token: 0x040027BD RID: 10173
			public int page;

			// Token: 0x040027BE RID: 10174
			public Action<global::UnityEngine.Texture2D, global::UnityEngine.Texture2D, global::UnityEngine.Texture2D, int> Callback;
		}

		// Token: 0x020003C5 RID: 965
		public struct SourceAssetEntry
		{
			// Token: 0x06001A4C RID: 6732 RVA: 0x0006C3DC File Offset: 0x0006A5DC
			public SourceAssetEntry(string asset, int width, int height)
			{
				this.Asset = asset;
				this.Width = width;
			}

			// Token: 0x040027BF RID: 10175
			public readonly string Asset;

			// Token: 0x040027C0 RID: 10176
			public readonly int Width;

			// Token: 0x040027C1 RID: 10177
			public readonly int Height;
		}
	}
}
