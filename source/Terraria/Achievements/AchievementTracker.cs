using System;
using Cpp2IlInjected;

namespace Terraria.Achievements
{
	// Token: 0x02000697 RID: 1687
	public abstract class AchievementTracker<T> : IAchievementTracker
	{
		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x0600385A RID: 14426 RVA: 0x00225B10 File Offset: 0x00223D10
		public T Value
		{
			get
			{
				return this._value;
			}
		}

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x0600385B RID: 14427 RVA: 0x000021DB File Offset: 0x000003DB
		public T MaxValue
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x0600385C RID: 14428 RVA: 0x00225B24 File Offset: 0x00223D24
		protected AchievementTracker(TrackerType type)
		{
			this._name = type;
		}

		// Token: 0x0600385D RID: 14429 RVA: 0x00225B40 File Offset: 0x00223D40
		void IAchievementTracker.ReportAs(string name)
		{
			this._maxValue = name;
		}

		// Token: 0x0600385E RID: 14430 RVA: 0x00225B54 File Offset: 0x00223D54
		TrackerType IAchievementTracker.GetTrackerType()
		{
			/*
An exception occurred when decompiling this method (0600385E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.Achievements.TrackerType Terraria.Achievements.AchievementTracker`1::Terraria.Achievements.IAchievementTracker.GetTrackerType()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_06, ldfld:string(AchievementTracker`1::_name, ldloc:AchievementTracker`1(this)))
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

		// Token: 0x0600385F RID: 14431 RVA: 0x00225B68 File Offset: 0x00223D68
		void IAchievementTracker.Clear()
		{
		}

		// Token: 0x06003860 RID: 14432 RVA: 0x000021DB File Offset: 0x000003DB
		public void SetValue(T newValue, bool reportUpdate = true)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003861 RID: 14433
		public abstract void ReportUpdate();

		// Token: 0x06003862 RID: 14434
		protected abstract void Load();

		// Token: 0x06003863 RID: 14435 RVA: 0x00225B78 File Offset: 0x00223D78
		void IAchievementTracker.Load()
		{
		}

		// Token: 0x06003864 RID: 14436 RVA: 0x00225B88 File Offset: 0x00223D88
		protected void OnComplete()
		{
		}

		// Token: 0x0400792F RID: 31023
		protected T _value;

		// Token: 0x04007930 RID: 31024
		protected T _maxValue;

		// Token: 0x04007931 RID: 31025
		protected string _name;

		// Token: 0x04007932 RID: 31026
		private TrackerType _type;
	}
}
