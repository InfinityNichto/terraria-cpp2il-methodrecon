using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2IlInjected;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Terraria.Achievements
{
	// Token: 0x02000695 RID: 1685
	public class AchievementManager
	{
		// Token: 0x14000043 RID: 67
		// (add) Token: 0x06003846 RID: 14406 RVA: 0x00225620 File Offset: 0x00223820
		// (remove) Token: 0x06003847 RID: 14407 RVA: 0x00225644 File Offset: 0x00223844
		public event Achievement.AchievementCompleted OnAchievementCompleted
		{
			[CompilerGenerated]
			add
			{
				if (Delegate.Combine(this.OnAchievementCompleted, value) != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (Delegate.Remove(this.OnAchievementCompleted, value) != null)
				{
				}
			}
		}

		// Token: 0x06003848 RID: 14408 RVA: 0x00225668 File Offset: 0x00223868
		public AchievementManager(LocalUser user)
		{
			this.User = user;
			if (this != null)
			{
				this._savePath = this;
				this._isCloudSave = true;
				return;
			}
			string text2;
			string text = Main.SavePath + text2 + "achievements.dat";
			this._savePath = text;
			Encoding ascii = Encoding.ASCII;
			this._cryptoKey = ascii;
		}

		// Token: 0x06003849 RID: 14409 RVA: 0x002256C0 File Offset: 0x002238C0
		public void Save()
		{
			string savePath = this._savePath;
			bool isCloudSave = this._isCloudSave;
			this.Save(savePath, isCloudSave);
			LocalUser user = this.User;
			if (user != null)
			{
				user.SavePersistantData();
				return;
			}
		}

		// Token: 0x0600384A RID: 14410 RVA: 0x002256F4 File Offset: 0x002238F4
		private void Save(string path, bool cloud)
		{
			if (!true)
			{
			}
			byte[] cryptoKey = this._cryptoKey;
			JsonSerializer jsonSerializer = JsonSerializer.Create(this._serializerSettings);
			Dictionary<string, Achievement> achievements = this._achievements;
		}

		// Token: 0x0600384B RID: 14411 RVA: 0x002257EC File Offset: 0x002239EC
		public List<Achievement> CreateAchievementsList()
		{
			/*
An exception occurred when decompiling this method (0600384B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.List`1<Terraria.Achievements.Achievement> Terraria.Achievements.AchievementManager::CreateAchievementsList()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.Dictionary`2<string, class Terraria.Achievements.Achievement>(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<string, class Terraria.Achievements.Achievement>(AchievementManager::_achievements, ldloc:AchievementManager(this)))
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

		// Token: 0x0600384C RID: 14412 RVA: 0x00225800 File Offset: 0x00223A00
		public void Load()
		{
			string savePath = this._savePath;
			bool isCloudSave = this._isCloudSave;
			this.Load(savePath, isCloudSave);
			LocalUser user = this.User;
			if (user != null)
			{
				user.LoadPersistantData();
				return;
			}
		}

		// Token: 0x0600384D RID: 14413 RVA: 0x00225834 File Offset: 0x00223A34
		private void Load(string path, bool cloud)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			byte[] cryptoKey = this._cryptoKey;
			JsonSerializer jsonSerializer = JsonSerializer.Create(this._serializerSettings);
		}

		// Token: 0x0600384E RID: 14414 RVA: 0x002259CC File Offset: 0x00223BCC
		public void ClearAll()
		{
			Dictionary<string, Achievement> achievements = this._achievements;
		}

		// Token: 0x0600384F RID: 14415 RVA: 0x002259FC File Offset: 0x00223BFC
		public void Shutdown()
		{
			Dictionary<string, Achievement> achievements = this._achievements;
		}

		// Token: 0x06003850 RID: 14416 RVA: 0x00225A24 File Offset: 0x00223C24
		private void AchievementCompleted(Achievement achievement)
		{
			this.Save();
			Achievement.AchievementCompleted onAchievementCompleted = this.OnAchievementCompleted;
			if (onAchievementCompleted != null)
			{
				IntPtr invoke_impl = onAchievementCompleted.invoke_impl;
				IntPtr method_code = onAchievementCompleted.method_code;
				IntPtr method = onAchievementCompleted.method;
				return;
			}
		}

		// Token: 0x06003851 RID: 14417 RVA: 0x000021DB File Offset: 0x000003DB
		public void Register(Achievement achievement)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003852 RID: 14418 RVA: 0x00225A58 File Offset: 0x00223C58
		public void RegisterIconIndex(string achievementName, int iconIndex)
		{
			Dictionary<string, int> achievementIconIndexes = this._achievementIconIndexes;
		}

		// Token: 0x06003853 RID: 14419 RVA: 0x00225A6C File Offset: 0x00223C6C
		public void RegisterAchievementCategory(string achievementName, AchievementCategory category)
		{
			this._achievements._version = (int)category;
		}

		// Token: 0x06003854 RID: 14420 RVA: 0x00225A88 File Offset: 0x00223C88
		public Achievement GetAchievement(string achievementName)
		{
			/*
An exception occurred when decompiling this method (06003854)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.Achievements.Achievement Terraria.Achievements.AchievementManager::GetAchievement(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.Dictionary`2<string, class Terraria.Achievements.Achievement>(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<string, class Terraria.Achievements.Achievement>(AchievementManager::_achievements, ldloc:AchievementManager(this)))
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

		// Token: 0x06003855 RID: 14421 RVA: 0x00225A9C File Offset: 0x00223C9C
		public T GetCondition<T>(string achievementName, string conditionName) where T : AchievementCondition
		{
			AchievementCondition condition;
			do
			{
				condition = this.GetCondition(achievementName, conditionName);
				if (condition == null)
				{
					return;
				}
			}
			while (condition != null);
			throw new InvalidCastException();
		}

		// Token: 0x06003856 RID: 14422 RVA: 0x00225AC0 File Offset: 0x00223CC0
		public AchievementCondition GetCondition(string achievementName, string conditionName)
		{
			Dictionary<string, Achievement> achievements = this._achievements;
			AchievementCondition achievementCondition;
			return achievementCondition;
		}

		// Token: 0x06003857 RID: 14423 RVA: 0x00225AD8 File Offset: 0x00223CD8
		public int GetIconIndex(string achievementName)
		{
			/*
An exception occurred when decompiling this method (06003857)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.Achievements.AchievementManager::GetIconIndex(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.Dictionary`2<string, int32>(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<string, int32>(AchievementManager::_achievementIconIndexes, ldloc:AchievementManager(this)))
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

		// Token: 0x06003858 RID: 14424 RVA: 0x00225AEC File Offset: 0x00223CEC
		// Note: this type is marked as 'beforefieldinit'.
		static AchievementManager()
		{
		}

		// Token: 0x04007925 RID: 31013
		private string _savePath;

		// Token: 0x04007926 RID: 31014
		private bool _isCloudSave;

		// Token: 0x04007927 RID: 31015
		private LocalUser User;

		// Token: 0x04007928 RID: 31016
		[CompilerGenerated]
		private Achievement.AchievementCompleted OnAchievementCompleted;

		// Token: 0x04007929 RID: 31017
		private Dictionary<string, Achievement> _achievements;

		// Token: 0x0400792A RID: 31018
		private readonly JsonSerializerSettings _serializerSettings;

		// Token: 0x0400792B RID: 31019
		private byte[] _cryptoKey;

		// Token: 0x0400792C RID: 31020
		private Dictionary<string, int> _achievementIconIndexes;

		// Token: 0x0400792D RID: 31021
		private static object _ioLock;

		// Token: 0x02000696 RID: 1686
		private class StoredAchievement
		{
			// Token: 0x06003859 RID: 14425 RVA: 0x00225AFC File Offset: 0x00223CFC
			public StoredAchievement()
			{
			}

			// Token: 0x0400792E RID: 31022
			[JsonProperty]
			public Dictionary<string, JObject> Conditions;
		}
	}
}
