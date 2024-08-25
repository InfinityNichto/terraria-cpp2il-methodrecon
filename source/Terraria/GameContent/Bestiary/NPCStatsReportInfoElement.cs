using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Terraria.DataStructures;
using Terraria.Localization;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x0200096E RID: 2414
	public class NPCStatsReportInfoElement : IBestiaryInfoElement, IUpdateBeforeSorting
	{
		// Token: 0x06004831 RID: 18481 RVA: 0x00260018 File Offset: 0x0025E218
		public NPCStatsReportInfoElement(int npcNetId)
		{
			this.NpcId = npcNetId;
			if (!true)
			{
			}
			if (!true)
			{
			}
			NPC instance = this._instance;
		}

		// Token: 0x14000055 RID: 85
		// (add) Token: 0x06004832 RID: 18482 RVA: 0x00260040 File Offset: 0x0025E240
		// (remove) Token: 0x06004833 RID: 18483 RVA: 0x00260064 File Offset: 0x0025E264
		public event NPCStatsReportInfoElement.StatAdjustmentStep OnRefreshStats
		{
			[CompilerGenerated]
			add
			{
				if (Delegate.Combine(this.OnRefreshStats, value) != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (Delegate.Remove(this.OnRefreshStats, value) != null)
				{
				}
			}
		}

		// Token: 0x06004834 RID: 18484 RVA: 0x00260088 File Offset: 0x0025E288
		public void Refresh()
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			NPC instance = this._instance;
		}

		// Token: 0x06004835 RID: 18485 RVA: 0x002600A4 File Offset: 0x0025E2A4
		public void UpdateBeforeSorting()
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			NPC instance = this._instance;
		}

		// Token: 0x06004836 RID: 18486 RVA: 0x002600C0 File Offset: 0x0025E2C0
		private void RefreshStats(GameModeData gameModeFound, NPC instance)
		{
			int npcId = this.NpcId;
			int damage = instance.damage;
			this.Damage = damage;
			int lifeMax = instance.lifeMax;
			this.LifeMax = lifeMax;
			float value = instance.value;
			this.MonetaryValue = value;
			int defense = instance.defense;
			this.Defense = defense;
			float knockBackResist = instance.knockBackResist;
			NPCStatsReportInfoElement.StatAdjustmentStep onRefreshStats = this.OnRefreshStats;
			this.KnockbackResist = knockBackResist;
			if (onRefreshStats != null)
			{
				IntPtr invoke_impl = onRefreshStats.invoke_impl;
				IntPtr method_code = onRefreshStats.method_code;
				IntPtr method = onRefreshStats.method;
			}
		}

		// Token: 0x06004837 RID: 18487 RVA: 0x00260148 File Offset: 0x0025E348
		public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
		{
			/*
An exception occurred when decompiling this method (06004837)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.UI.UIElement Terraria.GameContent.Bestiary.NPCStatsReportInfoElement::ProvideUIElement(Terraria.GameContent.Bestiary.BestiaryUICollectionInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0095:
	stloc:bool(var_33_A4, call:bool(string::op_Inequality, ldstr:string("Images/UI/Bestiary/Stat_Copper"), ldstr:string("-")))
	stloc:bool(var_34_B5, call:bool(string::op_Inequality, ldstr:string("Images/UI/Bestiary/Stat_Silver"), ldstr:string("-")))
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

		// Token: 0x06004838 RID: 18488 RVA: 0x0026020C File Offset: 0x0025E40C
		private void ShowStats_Attack(UIElement element)
		{
			bool <IsMouseHovering>k__BackingField = element.<IsMouseHovering>k__BackingField;
			if (<IsMouseHovering>k__BackingField)
			{
				if (!<IsMouseHovering>k__BackingField)
				{
				}
				string textValue = Language.GetTextValue("BestiaryInfo.Attack");
			}
		}

		// Token: 0x06004839 RID: 18489 RVA: 0x00260234 File Offset: 0x0025E434
		private void ShowStats_Defense(UIElement element)
		{
			bool <IsMouseHovering>k__BackingField = element.<IsMouseHovering>k__BackingField;
			if (<IsMouseHovering>k__BackingField)
			{
				if (!<IsMouseHovering>k__BackingField)
				{
				}
				string textValue = Language.GetTextValue("BestiaryInfo.Defense");
			}
		}

		// Token: 0x0600483A RID: 18490 RVA: 0x0026025C File Offset: 0x0025E45C
		private void ShowStats_Knockback(UIElement element)
		{
			bool <IsMouseHovering>k__BackingField = element.<IsMouseHovering>k__BackingField;
			if (<IsMouseHovering>k__BackingField)
			{
				if (!<IsMouseHovering>k__BackingField)
				{
				}
				string textValue = Language.GetTextValue("BestiaryInfo.Knockback");
			}
		}

		// Token: 0x0600483B RID: 18491 RVA: 0x00260284 File Offset: 0x0025E484
		private void ShowStats_Life(UIElement element)
		{
			bool <IsMouseHovering>k__BackingField = element.<IsMouseHovering>k__BackingField;
			if (<IsMouseHovering>k__BackingField)
			{
				if (!<IsMouseHovering>k__BackingField)
				{
				}
				string textValue = Language.GetTextValue("BestiaryInfo.Life");
			}
		}

		// Token: 0x040083B3 RID: 33715
		public int NpcId;

		// Token: 0x040083B4 RID: 33716
		public int Damage;

		// Token: 0x040083B5 RID: 33717
		public int LifeMax;

		// Token: 0x040083B6 RID: 33718
		public float MonetaryValue;

		// Token: 0x040083B7 RID: 33719
		public int Defense;

		// Token: 0x040083B8 RID: 33720
		public float KnockbackResist;

		// Token: 0x040083B9 RID: 33721
		public NPC _instance;

		// Token: 0x040083BA RID: 33722
		[CompilerGenerated]
		private NPCStatsReportInfoElement.StatAdjustmentStep OnRefreshStats;

		// Token: 0x0200096F RID: 2415
		public sealed class StatAdjustmentStep : MulticastDelegate
		{
			// Token: 0x0600483C RID: 18492 RVA: 0x002602AC File Offset: 0x0025E4AC
			public StatAdjustmentStep(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x0600483D RID: 18493 RVA: 0x0026030C File Offset: 0x0025E50C
			public void Invoke(NPCStatsReportInfoElement element)
			{
				IntPtr method_code = this.method_code;
				IntPtr invoke_impl = this.invoke_impl;
				IntPtr method = this.method;
			}

			// Token: 0x0600483E RID: 18494 RVA: 0x000021DB File Offset: 0x000003DB
			public IAsyncResult BeginInvoke(NPCStatsReportInfoElement element, AsyncCallback callback, object @object)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x0600483F RID: 18495 RVA: 0x00260330 File Offset: 0x0025E530
			public void EndInvoke(IAsyncResult result)
			{
			}
		}
	}
}
