using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Initializers;
using Terraria.Utilities;
using UnityEngine;

namespace Terraria.Localization
{
	// Token: 0x02000557 RID: 1367
	public class LanguageManager
	{
		// Token: 0x14000039 RID: 57
		// (add) Token: 0x06003318 RID: 13080 RVA: 0x001FE660 File Offset: 0x001FC860
		// (remove) Token: 0x06003319 RID: 13081 RVA: 0x001FE684 File Offset: 0x001FC884
		public event LanguageChangeCallback OnLanguageChanging
		{
			[CompilerGenerated]
			add
			{
				if (Delegate.Combine(this.OnLanguageChanging, value) != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (Delegate.Remove(this.OnLanguageChanging, value) != null)
				{
				}
			}
		}

		// Token: 0x1400003A RID: 58
		// (add) Token: 0x0600331A RID: 13082 RVA: 0x001FE6A8 File Offset: 0x001FC8A8
		// (remove) Token: 0x0600331B RID: 13083 RVA: 0x001FE6CC File Offset: 0x001FC8CC
		public event LanguageChangeCallback OnLanguageChanged
		{
			[CompilerGenerated]
			add
			{
				if (Delegate.Combine(this.OnLanguageChanged, value) != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (Delegate.Remove(this.OnLanguageChanged, value) != null)
				{
				}
			}
		}

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x0600331C RID: 13084 RVA: 0x001FE6F0 File Offset: 0x001FC8F0
		// (set) Token: 0x0600331D RID: 13085 RVA: 0x001FE704 File Offset: 0x001FC904
		public GameCulture ActiveCulture
		{
			[CompilerGenerated]
			get
			{
				return this.<ActiveCulture>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<ActiveCulture>k__BackingField = value;
			}
		}

		// Token: 0x0600331E RID: 13086 RVA: 0x001FE718 File Offset: 0x001FC918
		private LanguageManager()
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			this._fallbackCulture = 1;
			base..ctor();
			Dictionary<string, LocalizedText> localizedTexts = this._localizedTexts;
			if (!true)
			{
			}
		}

		// Token: 0x0600331F RID: 13087 RVA: 0x001FE744 File Offset: 0x001FC944
		public int GetCategorySize(string name)
		{
			/*
An exception occurred when decompiling this method (0600331F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.Localization.LanguageManager::GetCategorySize(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.Dictionary`2<string, class [mscorlib]System.Collections.Generic.List`1<string>>(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<string, class [mscorlib]System.Collections.Generic.List`1<string>>(LanguageManager::_categoryGroupedKeys, ldloc:LanguageManager(this)))
	stloc:valuetype [mscorlib]System.Collections.Generic.Dictionary`2/Entry[](var_1_12, ldfld:valuetype [mscorlib]System.Collections.Generic.Dictionary`2/Entry<!0, !1>[][exp:valuetype [mscorlib]System.Collections.Generic.Dictionary`2/Entry[]](Dictionary`2::_entries, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<string, class [mscorlib]System.Collections.Generic.List`1<string>>[exp:Dictionary`2](LanguageManager::_categoryGroupedKeys, ldloc:LanguageManager(this))))
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

		// Token: 0x06003320 RID: 13088 RVA: 0x001FE768 File Offset: 0x001FC968
		public void SetLanguage(int legacyId)
		{
			if (!true)
			{
			}
			GameCulture gameCulture = GameCulture.FromLegacyId(legacyId);
			this.SetLanguage(gameCulture);
		}

		// Token: 0x06003321 RID: 13089 RVA: 0x001FE788 File Offset: 0x001FC988
		public void SetLanguage(string cultureName)
		{
			if (!true)
			{
			}
			GameCulture gameCulture = GameCulture.FromName(cultureName);
			this.SetLanguage(gameCulture);
		}

		// Token: 0x06003322 RID: 13090 RVA: 0x001FE7A8 File Offset: 0x001FC9A8
		public int EstimateWordCount()
		{
			Dictionary<string, LocalizedText> localizedTexts = this._localizedTexts;
			string text2;
			string text = text2.Replace(",", "").Replace(".", "").Replace("\"", "")
				.Trim();
			bool flag = string.IsNullOrWhiteSpace(text2);
			int stringLength = text2._stringLength;
			throw new OutOfMemoryException();
		}

		// Token: 0x06003323 RID: 13091 RVA: 0x001FE818 File Offset: 0x001FCA18
		private void SetAllTextValuesToKeys()
		{
			Dictionary<string, LocalizedText> localizedTexts = this._localizedTexts;
		}

		// Token: 0x06003324 RID: 13092 RVA: 0x000021DB File Offset: 0x000003DB
		private string[] GetLanguageFilesForCulture(GameCulture culture)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003325 RID: 13093 RVA: 0x001FE840 File Offset: 0x001FCA40
		public void DelayedInit()
		{
			GameCulture gameCulture = this.delayedActiveCulture;
			this.intialLoadDone = true;
			this.SetLanguage(gameCulture);
		}

		// Token: 0x06003326 RID: 13094 RVA: 0x001FE864 File Offset: 0x001FCA64
		public void SetLanguage(GameCulture culture)
		{
			if (this.intialLoadDone)
			{
				GameCulture gameCulture = this.<ActiveCulture>k__BackingField;
				GameCulture fallbackCulture = this._fallbackCulture;
				this.SetAllTextValuesToKeys();
				GameCulture fallbackCulture2 = this._fallbackCulture;
				this.LoadLanguage(fallbackCulture2, true);
				this.LoadLanguage(culture, true);
				this.<ActiveCulture>k__BackingField = culture;
				Thread currentThread = Thread.CurrentThread;
				CultureInfo cultureInfo = culture.CultureInfo;
				currentThread.CurrentCulture = cultureInfo;
				Thread currentThread2 = Thread.CurrentThread;
				CultureInfo cultureInfo2 = culture.CultureInfo;
				currentThread2.CurrentUICulture = cultureInfo2;
				LanguageChangeCallback onLanguageChanged = this.OnLanguageChanged;
				if (onLanguageChanged != null)
				{
					IntPtr invoke_impl = onLanguageChanged.invoke_impl;
					IntPtr method_code = onLanguageChanged.method_code;
					IntPtr method = onLanguageChanged.method;
				}
				if (onLanguageChanged == null)
				{
					return;
				}
			}
			else
			{
				this.delayedActiveCulture = culture;
			}
		}

		// Token: 0x06003327 RID: 13095 RVA: 0x001FE918 File Offset: 0x001FCB18
		private void LoadLanguage(GameCulture culture, bool processCopyCommands = true)
		{
			this.LoadFilesForCulture(culture);
			LanguageChangeCallback onLanguageChanging = this.OnLanguageChanging;
			if (onLanguageChanging != null)
			{
				IntPtr invoke_impl = onLanguageChanging.invoke_impl;
				IntPtr method_code = onLanguageChanging.method_code;
				IntPtr method = onLanguageChanging.method;
			}
			this.ProcessCopyCommandsInTexts();
			ChatInitializer.PrepareAliases();
		}

		// Token: 0x06003328 RID: 13096 RVA: 0x001FE95C File Offset: 0x001FCB5C
		private void LoadFilesForCulture(GameCulture culture)
		{
			CultureInfo cultureInfo = culture.CultureInfo;
			string text;
			TextAsset[] array = Resources.LoadAll<TextAsset>(text);
			string text2;
			bool flag = text2.EndsWith(".XBO");
			DrPlatform.DrPlatformType currentPlatform = DrPlatform.CurrentPlatform;
		}

		// Token: 0x06003329 RID: 13097 RVA: 0x001FEA1C File Offset: 0x001FCC1C
		private void ProcessCopyCommandsInTexts()
		{
			Dictionary<string, LocalizedText> localizedTexts = this._localizedTexts;
		}

		// Token: 0x0600332A RID: 13098 RVA: 0x001FEA48 File Offset: 0x001FCC48
		public void LoadLanguageFromFileText(string fileText)
		{
			if (!true)
			{
			}
			if (("LoadingTips_Default.98" == null || "LoadingTips_Default.98" != null) && ("LoadingTips_Default.103" == null || "LoadingTips_Default.103" != null) && ("LoadingTips_GamePad.0" == null || "LoadingTips_GamePad.0" != null) && ("LoadingTips_GamePad.1" == null || "LoadingTips_GamePad.1" != null) && ("LoadingTips_GamePad.3" == null || "LoadingTips_GamePad.3" != null) && ("LoadingTips_GamePad.10" == null || "LoadingTips_GamePad.10" != null) && ("LoadingTips_GamePad.11" == null || "LoadingTips_GamePad.11" != null) && ("LoadingTips_GamePad.12" == null || "LoadingTips_GamePad.12" != null) && ("LoadingTips_Keyboard.0" == null || "LoadingTips_Keyboard.0" != null) && ("LoadingTips_Keyboard.2" == null || "LoadingTips_Keyboard.2" != null) && ("LoadingTips_Keyboard.3" == null || "LoadingTips_Keyboard.3" != null) && ("LoadingTips_Keyboard.7" == null || "LoadingTips_Keyboard.7" != null))
			{
				Dictionary<string, List<string>> categoryGroupedKeys = this._categoryGroupedKeys;
				Dictionary<string, List<string>> categoryGroupedKeys2 = this._categoryGroupedKeys;
				string text2;
				string text = text2 + "LoadingTips_Keyboard.7";
				Dictionary<string, LocalizedText> localizedTexts = this._localizedTexts;
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600332B RID: 13099 RVA: 0x001FEBC0 File Offset: 0x001FCDC0
		[Conditional("ENABLE_DEBUG")]
		[Conditional("UNITY_EDITOR")]
		private void ValidateAllCharactersContainedInFont(SpriteFont font)
		{
		}

		// Token: 0x0600332C RID: 13100 RVA: 0x001FEBD0 File Offset: 0x001FCDD0
		public LocalizedText[] FindAll(Regex regex)
		{
			Dictionary<string, LocalizedText> localizedTexts = this._localizedTexts;
			long num = 0L;
			Dictionary<string, LocalizedText> localizedTexts2 = this._localizedTexts;
			if (num == 0L || num != 0L)
			{
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600332D RID: 13101 RVA: 0x001FEC1C File Offset: 0x001FCE1C
		public LocalizedText[] FindAll(LanguageSearchFilter filter)
		{
			Dictionary<string, LocalizedText> localizedTexts = this._localizedTexts;
			IntPtr method_code = filter.method_code;
			IntPtr invoke_impl = filter.invoke_impl;
			IntPtr method = filter.method;
			throw new OutOfMemoryException();
		}

		// Token: 0x0600332E RID: 13102 RVA: 0x001FEC54 File Offset: 0x001FCE54
		public LocalizedText[] FindAll(string categoryName)
		{
			Dictionary<string, List<string>> categoryGroupedKeys = this._categoryGroupedKeys;
			Dictionary<string, List<string>> categoryGroupedKeys2 = this._categoryGroupedKeys;
			Dictionary.Entry[] entries = categoryGroupedKeys2._entries;
			string text;
			return this.GetText(text);
		}

		// Token: 0x0600332F RID: 13103 RVA: 0x001FEC88 File Offset: 0x001FCE88
		public LocalizedText SelectRandom(LanguageSearchFilter filter, [Optional] UnifiedRandom random)
		{
			Dictionary<string, LocalizedText> localizedTexts = this._localizedTexts;
			IntPtr method_code = filter.method_code;
			IntPtr invoke_impl = filter.invoke_impl;
			IntPtr method = filter.method;
			if (random != null || invoke_impl == 0)
			{
			}
			Dictionary<string, LocalizedText> localizedTexts2 = this._localizedTexts;
			IntPtr method_code2 = filter.method_code;
			IntPtr invoke_impl2 = filter.invoke_impl;
			IntPtr method2 = filter.method;
			if (invoke_impl2 == 0)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06003330 RID: 13104 RVA: 0x001FECFC File Offset: 0x001FCEFC
		public LocalizedText RandomFromCategory(string categoryName, [Optional] UnifiedRandom random)
		{
			Dictionary<string, List<string>> categoryGroupedKeys = this._categoryGroupedKeys;
			Dictionary<string, List<string>> categoryGroupedKeys2 = this._categoryGroupedKeys;
			if (random == null)
			{
			}
			Dictionary.Entry[] entries = categoryGroupedKeys2._entries;
			string text;
			return this.GetText(text);
		}

		// Token: 0x06003331 RID: 13105 RVA: 0x001FED44 File Offset: 0x001FCF44
		public LocalizedText RandomFromCategories(string[] categoryNames, int keyIndexToSkip, [Optional] UnifiedRandom random)
		{
			Dictionary<string, List<string>> categoryGroupedKeys = this._categoryGroupedKeys;
			Dictionary<string, List<string>> categoryGroupedKeys2 = this._categoryGroupedKeys;
			Dictionary.Entry[] entries = this._categoryGroupedKeys._entries;
			string text;
			bool flag = Lang.CanSubstituteBindings(text);
			throw new OutOfMemoryException();
		}

		// Token: 0x06003332 RID: 13106 RVA: 0x001FEDA8 File Offset: 0x001FCFA8
		public LocalizedText IndexedFromCategory(string categoryName, int index)
		{
			Dictionary<string, List<string>> categoryGroupedKeys = this._categoryGroupedKeys;
			Dictionary.Entry[] entries = this._categoryGroupedKeys._entries;
			string text;
			return this.GetText(text);
		}

		// Token: 0x06003333 RID: 13107 RVA: 0x001FEDE8 File Offset: 0x001FCFE8
		public bool Exists(string key)
		{
			/*
An exception occurred when decompiling this method (06003333)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Localization.LanguageManager::Exists(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.Dictionary`2<string, class Terraria.Localization.LocalizedText>(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<string, class Terraria.Localization.LocalizedText>(LanguageManager::_localizedTexts, ldloc:LanguageManager(this)))
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

		// Token: 0x06003334 RID: 13108 RVA: 0x001FEDFC File Offset: 0x001FCFFC
		public LocalizedText GetText(string key)
		{
			/*
An exception occurred when decompiling this method (06003334)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.Localization.LocalizedText Terraria.Localization.LanguageManager::GetText(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.Dictionary`2<string, class Terraria.Localization.LocalizedText>(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<string, class Terraria.Localization.LocalizedText>(LanguageManager::_localizedTexts, ldloc:LanguageManager(this)))
	stloc:class [mscorlib]System.Collections.Generic.Dictionary`2<string, class Terraria.Localization.LocalizedText>(var_1_0D, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<string, class Terraria.Localization.LocalizedText>(LanguageManager::_localizedTexts, ldloc:LanguageManager(this)))
	stloc:class [mscorlib]System.Collections.Generic.Dictionary`2<string, class Terraria.Localization.LocalizedText>(var_2_14, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<string, class Terraria.Localization.LocalizedText>(LanguageManager::_localizedTexts, ldloc:LanguageManager(this)))
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

		// Token: 0x06003335 RID: 13109 RVA: 0x001FEE20 File Offset: 0x001FD020
		public string GetTextValue(string key)
		{
			/*
An exception occurred when decompiling this method (06003335)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String Terraria.Localization.LanguageManager::GetTextValue(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.Dictionary`2<string, class Terraria.Localization.LocalizedText>(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<string, class Terraria.Localization.LocalizedText>(LanguageManager::_localizedTexts, ldloc:LanguageManager(this)))
	stloc:valuetype [mscorlib]System.Collections.Generic.Dictionary`2/Entry[](var_1_12, ldfld:valuetype [mscorlib]System.Collections.Generic.Dictionary`2/Entry<!0, !1>[][exp:valuetype [mscorlib]System.Collections.Generic.Dictionary`2/Entry[]](Dictionary`2::_entries, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<string, class Terraria.Localization.LocalizedText>[exp:Dictionary`2](LanguageManager::_localizedTexts, ldloc:LanguageManager(this))))
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

		// Token: 0x06003336 RID: 13110 RVA: 0x001FEE40 File Offset: 0x001FD040
		public string GetTextValue(string key, object arg0)
		{
			Dictionary<string, LocalizedText> localizedTexts = this._localizedTexts;
			Dictionary.Entry[] entries = this._localizedTexts._entries;
			string text;
			return text;
		}

		// Token: 0x06003337 RID: 13111 RVA: 0x001FEE64 File Offset: 0x001FD064
		public string GetTextValue(string key, object arg0, object arg1)
		{
			Dictionary<string, LocalizedText> localizedTexts = this._localizedTexts;
			Dictionary.Entry[] entries = this._localizedTexts._entries;
			string text;
			return text;
		}

		// Token: 0x06003338 RID: 13112 RVA: 0x001FEE88 File Offset: 0x001FD088
		public string GetTextValue(string key, object arg0, object arg1, object arg2)
		{
			Dictionary<string, LocalizedText> localizedTexts = this._localizedTexts;
			Dictionary.Entry[] entries = this._localizedTexts._entries;
			string text;
			return text;
		}

		// Token: 0x06003339 RID: 13113 RVA: 0x001FEEAC File Offset: 0x001FD0AC
		public string GetTextValue(string key, params object[] args)
		{
			Dictionary<string, LocalizedText> localizedTexts = this._localizedTexts;
			Dictionary.Entry[] entries = this._localizedTexts._entries;
			string text;
			return text;
		}

		// Token: 0x0600333A RID: 13114 RVA: 0x001FEED0 File Offset: 0x001FD0D0
		public void SetFallbackCulture(GameCulture culture)
		{
			this._fallbackCulture = culture;
		}

		// Token: 0x0600333B RID: 13115 RVA: 0x001FEEE4 File Offset: 0x001FD0E4
		// Note: this type is marked as 'beforefieldinit'.
		static LanguageManager()
		{
		}

		// Token: 0x0600333C RID: 13116 RVA: 0x001FEEF4 File Offset: 0x001FD0F4
		[CompilerGenerated]
		private string <ProcessCopyCommandsInTexts>b__27_0(Match match)
		{
			string text;
			return text;
		}

		// Token: 0x04003C1A RID: 15386
		public static LanguageManager Instance;

		// Token: 0x04003C1B RID: 15387
		[CompilerGenerated]
		private LanguageChangeCallback OnLanguageChanging;

		// Token: 0x04003C1C RID: 15388
		[CompilerGenerated]
		private LanguageChangeCallback OnLanguageChanged;

		// Token: 0x04003C1D RID: 15389
		[CompilerGenerated]
		private GameCulture <ActiveCulture>k__BackingField;

		// Token: 0x04003C1E RID: 15390
		private readonly Dictionary<string, LocalizedText> _localizedTexts;

		// Token: 0x04003C1F RID: 15391
		private readonly Dictionary<string, List<string>> _categoryGroupedKeys;

		// Token: 0x04003C20 RID: 15392
		private GameCulture _fallbackCulture;

		// Token: 0x04003C21 RID: 15393
		public bool intialLoadDone;

		// Token: 0x04003C22 RID: 15394
		public GameCulture delayedActiveCulture;

		// Token: 0x02000558 RID: 1368
		[CompilerGenerated]
		private sealed class <>c__DisplayClass21_0
		{
			// Token: 0x0600333D RID: 13117 RVA: 0x001FEF04 File Offset: 0x001FD104
			public <>c__DisplayClass21_0()
			{
			}

			// Token: 0x0600333E RID: 13118 RVA: 0x001FEF18 File Offset: 0x001FD118
			internal bool <GetLanguageFilesForCulture>b__0(string element)
			{
				CultureInfo cultureInfo = this.culture.CultureInfo;
				string text;
				bool flag = element.StartsWith(text);
				return element.EndsWith(".json");
			}

			// Token: 0x04003C23 RID: 15395
			public GameCulture culture;
		}
	}
}
