using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Terraria.Localization;

namespace Terraria.Achievements
{
	// Token: 0x02000690 RID: 1680
	[JsonObject(MemberSerialization.OptIn)]
	public class Achievement
	{
		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x0600381F RID: 14367 RVA: 0x00224F6C File Offset: 0x0022316C
		public AchievementCategory Category
		{
			get
			{
				return this._category;
			}
		}

		// Token: 0x14000041 RID: 65
		// (add) Token: 0x06003820 RID: 14368 RVA: 0x00224F80 File Offset: 0x00223180
		// (remove) Token: 0x06003821 RID: 14369 RVA: 0x00224FA4 File Offset: 0x002231A4
		public event Achievement.AchievementCompleted OnCompleted
		{
			[CompilerGenerated]
			add
			{
				if (Delegate.Combine(this.OnCompleted, value) != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (Delegate.Remove(this.OnCompleted, value) != null)
				{
				}
			}
		}

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x06003822 RID: 14370 RVA: 0x00224FC8 File Offset: 0x002231C8
		public bool HasTracker
		{
			get
			{
				/*
An exception occurred when decompiling this method (06003822)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Achievements.Achievement::get_HasTracker()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:IAchievementTracker(var_0_06, ldfld:IAchievementTracker(Achievement::_tracker, ldloc:Achievement(this)))
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

		// Token: 0x06003823 RID: 14371 RVA: 0x00224FDC File Offset: 0x002231DC
		public IAchievementTracker GetTracker()
		{
			return this._tracker;
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x06003824 RID: 14372 RVA: 0x00224FF0 File Offset: 0x002231F0
		public bool IsCompleted
		{
			get
			{
				/*
An exception occurred when decompiling this method (06003824)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Achievements.Achievement::get_IsCompleted()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.Dictionary`2<string, class Terraria.Achievements.AchievementCondition>(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<string, class Terraria.Achievements.AchievementCondition>(Achievement::_conditions, ldloc:Achievement(this)))
	stloc:int32(var_1_0D, ldfld:int32(Achievement::_completedCount, ldloc:Achievement(this)))
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

		// Token: 0x06003825 RID: 14373 RVA: 0x0022500C File Offset: 0x0022320C
		public Achievement(string name)
		{
			this.Name = name;
			LocalizedText text = Language.GetText("Achievements." + name + "_Name");
			this.FriendlyName = text;
			LocalizedText text2 = Language.GetText("Achievements." + name + "_Description");
			this.Description = text2;
		}

		// Token: 0x06003826 RID: 14374 RVA: 0x00225060 File Offset: 0x00223260
		public void ClearProgress()
		{
			Dictionary<string, AchievementCondition> conditions = this._conditions;
		}

		// Token: 0x06003827 RID: 14375 RVA: 0x00225094 File Offset: 0x00223294
		public void Shutdown()
		{
			Dictionary<string, AchievementCondition> conditions = this._conditions;
		}

		// Token: 0x06003828 RID: 14376 RVA: 0x002250BC File Offset: 0x002232BC
		public void Load(Dictionary<string, JObject> conditions)
		{
			Dictionary<string, AchievementCondition> conditions2 = this._conditions;
			Dictionary<string, AchievementCondition> conditions3 = this._conditions;
		}

		// Token: 0x06003829 RID: 14377 RVA: 0x002251FC File Offset: 0x002233FC
		public void AddCondition(AchievementCondition condition)
		{
			Dictionary<string, AchievementCondition> conditions = this._conditions;
			string name = condition.Name;
		}

		// Token: 0x0600382A RID: 14378 RVA: 0x00225218 File Offset: 0x00223418
		private void OnConditionComplete(AchievementCondition condition)
		{
			int completedCount = this._completedCount;
			Dictionary<string, AchievementCondition> conditions = this._conditions;
			if (this._tracker == null && conditions != null)
			{
				string name = this.Name;
			}
			Achievement.AchievementCompleted onCompleted = this.OnCompleted;
			IntPtr invoke_impl;
			if (onCompleted != null)
			{
				invoke_impl = onCompleted.invoke_impl;
				IntPtr method_code = onCompleted.method_code;
				IntPtr method = onCompleted.method;
			}
			bool flag = this.Name == "MARATHON_MEDALIST";
			if (onCompleted == null)
			{
			}
			Player localPlayer = Main.LocalPlayer;
			if (invoke_impl == 0)
			{
			}
			LocalUser localUser = UserManagement.FindLocalUserByPlayer(localPlayer);
			if (localUser != null)
			{
				IPlatformAwardNotifier platformAwards = localUser.PlatformAwards;
				if (invoke_impl != 0)
				{
				}
				return;
			}
		}

		// Token: 0x0600382B RID: 14379 RVA: 0x002252D8 File Offset: 0x002234D8
		private void UseTracker(IAchievementTracker tracker)
		{
			string name = this.Name;
			string text = "STAT_" + name;
		}

		// Token: 0x0600382C RID: 14380 RVA: 0x00225300 File Offset: 0x00223500
		public void UseTrackerFromCondition(string conditionName)
		{
			IAchievementTracker conditionTracker = this.GetConditionTracker(conditionName);
			this.UseTracker(conditionTracker);
		}

		// Token: 0x0600382D RID: 14381 RVA: 0x0022531C File Offset: 0x0022351C
		public void UseConditionsCompletedTracker()
		{
			Dictionary<string, AchievementCondition> conditions = this._conditions;
		}

		// Token: 0x0600382E RID: 14382 RVA: 0x00225344 File Offset: 0x00223544
		public void UseConditionsCompletedTracker(params string[] conditions)
		{
			Dictionary<string, AchievementCondition> conditions2 = this._conditions;
		}

		// Token: 0x0600382F RID: 14383 RVA: 0x0022535C File Offset: 0x0022355C
		public void ClearTracker()
		{
		}

		// Token: 0x06003830 RID: 14384 RVA: 0x0022536C File Offset: 0x0022356C
		private IAchievementTracker GetConditionTracker(string name)
		{
			/*
An exception occurred when decompiling this method (06003830)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.Achievements.IAchievementTracker Terraria.Achievements.Achievement::GetConditionTracker(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stfld:int32(Dictionary`2::_count, ldloc:class [mscorlib]System.Collections.Generic.Dictionary`2<string, class Terraria.Achievements.AchievementCondition>[exp:Dictionary`2](var_0_06), ldloc:class [mscorlib]System.Collections.Generic.Dictionary`2<string, class Terraria.Achievements.AchievementCondition>[exp:int32](var_0_06))
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

		// Token: 0x06003831 RID: 14385 RVA: 0x00225390 File Offset: 0x00223590
		public void AddConditions(params AchievementCondition[] conditions)
		{
			AchievementCondition.AchievementUpdate onComplete = conditions.OnComplete;
			this.AddCondition(conditions);
		}

		// Token: 0x06003832 RID: 14386 RVA: 0x002253B0 File Offset: 0x002235B0
		public AchievementCondition GetCondition(string conditionName)
		{
			/*
An exception occurred when decompiling this method (06003832)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.Achievements.AchievementCondition Terraria.Achievements.Achievement::GetCondition(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.Dictionary`2<string, class Terraria.Achievements.AchievementCondition>(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<string, class Terraria.Achievements.AchievementCondition>(Achievement::_conditions, ldloc:Achievement(this)))
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

		// Token: 0x06003833 RID: 14387 RVA: 0x002253C4 File Offset: 0x002235C4
		public void SetCategory(AchievementCategory category)
		{
			this._category = category;
		}

		// Token: 0x04007911 RID: 30993
		private static int _totalAchievements;

		// Token: 0x04007912 RID: 30994
		public readonly string Name;

		// Token: 0x04007913 RID: 30995
		public readonly LocalizedText FriendlyName;

		// Token: 0x04007914 RID: 30996
		public readonly LocalizedText Description;

		// Token: 0x04007915 RID: 30997
		public readonly int Id;

		// Token: 0x04007916 RID: 30998
		private AchievementCategory _category;

		// Token: 0x04007917 RID: 30999
		private IAchievementTracker _tracker;

		// Token: 0x04007918 RID: 31000
		[CompilerGenerated]
		private Achievement.AchievementCompleted OnCompleted;

		// Token: 0x04007919 RID: 31001
		[JsonProperty("Conditions")]
		private Dictionary<string, AchievementCondition> _conditions;

		// Token: 0x0400791A RID: 31002
		private int _completedCount;

		// Token: 0x02000691 RID: 1681
		public sealed class AchievementCompleted : MulticastDelegate
		{
			// Token: 0x06003834 RID: 14388 RVA: 0x002253D8 File Offset: 0x002235D8
			public AchievementCompleted(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x06003835 RID: 14389 RVA: 0x00225438 File Offset: 0x00223638
			public void Invoke(Achievement achievement)
			{
				IntPtr method_code = this.method_code;
				IntPtr invoke_impl = this.invoke_impl;
				IntPtr method = this.method;
			}

			// Token: 0x06003836 RID: 14390 RVA: 0x000021DB File Offset: 0x000003DB
			public IAsyncResult BeginInvoke(Achievement achievement, AsyncCallback callback, object @object)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06003837 RID: 14391 RVA: 0x0022545C File Offset: 0x0022365C
			public void EndInvoke(IAsyncResult result)
			{
			}
		}
	}
}
