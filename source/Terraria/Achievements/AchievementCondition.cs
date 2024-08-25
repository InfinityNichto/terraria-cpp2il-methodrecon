using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Terraria.Achievements
{
	// Token: 0x02000693 RID: 1683
	[JsonObject(MemberSerialization.OptIn)]
	public abstract class AchievementCondition
	{
		// Token: 0x14000042 RID: 66
		// (add) Token: 0x06003838 RID: 14392 RVA: 0x0022546C File Offset: 0x0022366C
		// (remove) Token: 0x06003839 RID: 14393 RVA: 0x00225490 File Offset: 0x00223690
		public event AchievementCondition.AchievementUpdate OnComplete
		{
			[CompilerGenerated]
			add
			{
				if (Delegate.Combine(this.OnComplete, value) != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (Delegate.Remove(this.OnComplete, value) != null)
				{
				}
			}
		}

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x0600383A RID: 14394 RVA: 0x002254B4 File Offset: 0x002236B4
		public bool IsCompleted
		{
			get
			{
				return this._isCompleted;
			}
		}

		// Token: 0x0600383B RID: 14395 RVA: 0x002254C8 File Offset: 0x002236C8
		protected AchievementCondition(string name)
		{
			this.Name = name;
		}

		// Token: 0x0600383C RID: 14396 RVA: 0x002254E4 File Offset: 0x002236E4
		public virtual void Load(JObject state)
		{
			bool flag = (bool)state["Completed"];
		}

		// Token: 0x0600383D RID: 14397 RVA: 0x00225504 File Offset: 0x00223704
		public virtual void Shutdown()
		{
		}

		// Token: 0x0600383E RID: 14398 RVA: 0x00225514 File Offset: 0x00223714
		public virtual void Clear()
		{
		}

		// Token: 0x0600383F RID: 14399 RVA: 0x00225524 File Offset: 0x00223724
		public virtual void Complete()
		{
			if (this._isCompleted)
			{
				return;
			}
			AchievementCondition.AchievementUpdate onComplete = this.OnComplete;
			this._isCompleted = true;
			while (onComplete == null)
			{
			}
			IntPtr invoke_impl = onComplete.invoke_impl;
			IntPtr method_code = onComplete.method_code;
			IntPtr method = onComplete.method;
		}

		// Token: 0x06003840 RID: 14400 RVA: 0x00225560 File Offset: 0x00223760
		protected virtual IAchievementTracker CreateAchievementTracker()
		{
		}

		// Token: 0x06003841 RID: 14401 RVA: 0x00225570 File Offset: 0x00223770
		public IAchievementTracker GetAchievementTracker()
		{
			/*
An exception occurred when decompiling this method (06003841)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.Achievements.IAchievementTracker Terraria.Achievements.AchievementCondition::GetAchievementTracker()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stfld:IAchievementTracker(AchievementCondition::_tracker, ldloc:AchievementCondition(this), ldloc:AchievementCondition[exp:IAchievementTracker](this))
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

		// Token: 0x04007921 RID: 31009
		public readonly string Name;

		// Token: 0x04007922 RID: 31010
		[CompilerGenerated]
		private AchievementCondition.AchievementUpdate OnComplete;

		// Token: 0x04007923 RID: 31011
		protected IAchievementTracker _tracker;

		// Token: 0x04007924 RID: 31012
		[JsonProperty("Completed")]
		private bool _isCompleted;

		// Token: 0x02000694 RID: 1684
		public sealed class AchievementUpdate : MulticastDelegate
		{
			// Token: 0x06003842 RID: 14402 RVA: 0x0022558C File Offset: 0x0022378C
			public AchievementUpdate(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x06003843 RID: 14403 RVA: 0x002255EC File Offset: 0x002237EC
			public void Invoke(AchievementCondition condition)
			{
				IntPtr method_code = this.method_code;
				IntPtr invoke_impl = this.invoke_impl;
				IntPtr method = this.method;
			}

			// Token: 0x06003844 RID: 14404 RVA: 0x000021DB File Offset: 0x000003DB
			public IAsyncResult BeginInvoke(AchievementCondition condition, AsyncCallback callback, object @object)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06003845 RID: 14405 RVA: 0x00225610 File Offset: 0x00223810
			public void EndInvoke(IAsyncResult result)
			{
			}
		}
	}
}
