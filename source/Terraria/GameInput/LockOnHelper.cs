using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameInput
{
	// Token: 0x020006C3 RID: 1731
	public class LockOnHelper
	{
		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x06003946 RID: 14662 RVA: 0x0022D134 File Offset: 0x0022B334
		// (set) Token: 0x06003947 RID: 14663 RVA: 0x0022D150 File Offset: 0x0022B350
		public static LockOnHelper.LockOnMode UseMode
		{
			get
			{
				return LockOnHelperStaticData.Instance.UseMode;
			}
			set
			{
				LockOnHelperStaticData.Instance.UseMode = value;
			}
		}

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x06003948 RID: 14664 RVA: 0x0022D16C File Offset: 0x0022B36C
		// (set) Token: 0x06003949 RID: 14665 RVA: 0x0022D188 File Offset: 0x0022B388
		private static bool _enabled
		{
			get
			{
				return LockOnHelperStaticData.Instance._enabled;
			}
			set
			{
				LockOnHelperStaticData instance = LockOnHelperStaticData.Instance;
			}
		}

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x0600394A RID: 14666 RVA: 0x0022D1A0 File Offset: 0x0022B3A0
		// (set) Token: 0x0600394B RID: 14667 RVA: 0x0022D1BC File Offset: 0x0022B3BC
		private static bool _canLockOn
		{
			get
			{
				return LockOnHelperStaticData.Instance._canLockOn;
			}
			set
			{
				LockOnHelperStaticData instance = LockOnHelperStaticData.Instance;
			}
		}

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x0600394C RID: 14668 RVA: 0x0022D1D4 File Offset: 0x0022B3D4
		// (set) Token: 0x0600394D RID: 14669 RVA: 0x0022D1F0 File Offset: 0x0022B3F0
		private static List<int> _targets
		{
			get
			{
				return LockOnHelperStaticData.Instance._targets;
			}
			set
			{
				LockOnHelperStaticData.Instance._targets = value;
			}
		}

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x0600394E RID: 14670 RVA: 0x0022D20C File Offset: 0x0022B40C
		// (set) Token: 0x0600394F RID: 14671 RVA: 0x0022D228 File Offset: 0x0022B428
		private static int _pickedTarget
		{
			get
			{
				return LockOnHelperStaticData.Instance._pickedTarget;
			}
			set
			{
				LockOnHelperStaticData.Instance._pickedTarget = value;
			}
		}

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x06003950 RID: 14672 RVA: 0x0022D244 File Offset: 0x0022B444
		// (set) Token: 0x06003951 RID: 14673 RVA: 0x0022D260 File Offset: 0x0022B460
		private static int _lifeTimeCounter
		{
			get
			{
				return LockOnHelperStaticData.Instance._lifeTimeCounter;
			}
			set
			{
				LockOnHelperStaticData.Instance._lifeTimeCounter = value;
			}
		}

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x06003952 RID: 14674 RVA: 0x0022D27C File Offset: 0x0022B47C
		// (set) Token: 0x06003953 RID: 14675 RVA: 0x0022D298 File Offset: 0x0022B498
		private static int _lifeTimeArrowDisplay
		{
			get
			{
				return LockOnHelperStaticData.Instance._lifeTimeArrowDisplay;
			}
			set
			{
				LockOnHelperStaticData.Instance._lifeTimeArrowDisplay = value;
			}
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x06003954 RID: 14676 RVA: 0x0022D2B4 File Offset: 0x0022B4B4
		// (set) Token: 0x06003955 RID: 14677 RVA: 0x0022D2D0 File Offset: 0x0022B4D0
		private static int _threeDSTarget
		{
			get
			{
				return LockOnHelperStaticData.Instance._threeDSTarget;
			}
			set
			{
				LockOnHelperStaticData.Instance._threeDSTarget = value;
			}
		}

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x06003956 RID: 14678 RVA: 0x0022D2EC File Offset: 0x0022B4EC
		// (set) Token: 0x06003957 RID: 14679 RVA: 0x0022D308 File Offset: 0x0022B508
		private static int _targetClosestTarget
		{
			get
			{
				return LockOnHelperStaticData.Instance._targetClosestTarget;
			}
			set
			{
				LockOnHelperStaticData.Instance._targetClosestTarget = value;
			}
		}

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x06003958 RID: 14680 RVA: 0x0022D324 File Offset: 0x0022B524
		// (set) Token: 0x06003959 RID: 14681 RVA: 0x0022D340 File Offset: 0x0022B540
		public static bool ForceUsability
		{
			get
			{
				return LockOnHelperStaticData.Instance.ForceUsability;
			}
			set
			{
				LockOnHelperStaticData instance = LockOnHelperStaticData.Instance;
			}
		}

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x0600395A RID: 14682 RVA: 0x0022D358 File Offset: 0x0022B558
		// (set) Token: 0x0600395B RID: 14683 RVA: 0x0022D374 File Offset: 0x0022B574
		public static bool LockOnAvailable
		{
			get
			{
				return LockOnHelperStaticData.Instance.LockOnAvailable;
			}
			set
			{
				LockOnHelperStaticData instance = LockOnHelperStaticData.Instance;
			}
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x0600395C RID: 14684 RVA: 0x0022D38C File Offset: 0x0022B58C
		// (set) Token: 0x0600395D RID: 14685 RVA: 0x0022D3A8 File Offset: 0x0022B5A8
		private static int _lastFrame
		{
			get
			{
				return LockOnHelperStaticData.Instance._lastFrame;
			}
			set
			{
				LockOnHelperStaticData.Instance._lastFrame = value;
			}
		}

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x0600395E RID: 14686 RVA: 0x0022D3C4 File Offset: 0x0022B5C4
		// (set) Token: 0x0600395F RID: 14687 RVA: 0x0022D3E0 File Offset: 0x0022B5E0
		private static float[,] _drawProgress
		{
			get
			{
				return LockOnHelperStaticData.Instance._drawProgress;
			}
			set
			{
				LockOnHelperStaticData.Instance._drawProgress = value;
			}
		}

		// Token: 0x06003960 RID: 14688 RVA: 0x0022D3FC File Offset: 0x0022B5FC
		public static void CycleUseModes()
		{
			if (!true)
			{
			}
			LockOnHelper.LockOnMode useMode = LockOnHelperStaticData.Instance.UseMode;
			if (useMode == LockOnHelper.LockOnMode.FocusTarget)
			{
				if (useMode == LockOnHelper.LockOnMode.FocusTarget)
				{
				}
				return;
			}
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x06003961 RID: 14689 RVA: 0x0022D430 File Offset: 0x0022B630
		public static NPC AimedTarget
		{
			get
			{
				/*
An exception occurred when decompiling this method (06003961)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.NPC Terraria.GameInput.LockOnHelper::get_AimedTarget()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0024:
	stloc:class [mscorlib]System.Collections.Generic.List`1<int32>(var_3_30, ldfld:class [mscorlib]System.Collections.Generic.List`1<int32>(LockOnHelperStaticData::_targets, callgetter:LockOnHelperStaticData(LockOnHelperStaticData::get_Instance)))
	stloc:int32(var_5_3E, ldfld:int32(LockOnHelperStaticData::_pickedTarget, callgetter:LockOnHelperStaticData(LockOnHelperStaticData::get_Instance)))
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

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x06003962 RID: 14690 RVA: 0x0022D480 File Offset: 0x0022B680
		public static Vector2 PredictedPosition
		{
			get
			{
				/*
An exception occurred when decompiling this method (06003962)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Vector2 Terraria.GameInput.LockOnHelper::get_PredictedPosition()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0096:
	stloc:int32(var_34_9D, ldfld:int32(int32::m_value, ldloc:int32[exp:int32&](var_33_90)))
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

		// Token: 0x06003963 RID: 14691 RVA: 0x0022D52C File Offset: 0x0022B72C
		public static void Update()
		{
			int num = 1;
			if (num == 0)
			{
			}
			LockOnHelperStaticData instance = LockOnHelperStaticData.Instance;
			if (num == 0)
			{
			}
			LockOnHelperStaticData instance2 = LockOnHelperStaticData.Instance;
			int lastFrame = instance2._lastFrame;
			int lifeTimeCounter = instance2._lifeTimeCounter;
		}

		// Token: 0x06003964 RID: 14692 RVA: 0x0022D750 File Offset: 0x0022B950
		public static bool CanUseLockonSystem()
		{
			return true;
		}

		// Token: 0x06003965 RID: 14693 RVA: 0x0022D760 File Offset: 0x0022B960
		public static void SetUP()
		{
			if (!true)
			{
			}
			bool canLockOn = LockOnHelperStaticData.Instance._canLockOn;
			if (canLockOn)
			{
				if (!canLockOn)
				{
				}
				NPC aimedTarget = LockOnHelper.AimedTarget;
				Vector2 predictedPosition = LockOnHelper.PredictedPosition;
				if (!canLockOn)
				{
				}
				Vector2 screenPosition = Main.screenPosition;
				if (!canLockOn)
				{
				}
				Vector2 vector;
				LockOnHelper.SetLockPosition(vector);
				return;
			}
		}

		// Token: 0x06003966 RID: 14694 RVA: 0x0022D7B0 File Offset: 0x0022B9B0
		public static void SetDOWN()
		{
			if (!true)
			{
			}
			bool canLockOn = LockOnHelperStaticData.Instance._canLockOn;
			if (canLockOn)
			{
				if (!canLockOn)
				{
				}
				LockOnHelper.ResetLockPosition();
				return;
			}
		}

		// Token: 0x06003967 RID: 14695 RVA: 0x000021DB File Offset: 0x000003DB
		private static bool ShouldLockOn(Player p)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003968 RID: 14696 RVA: 0x0022D7DC File Offset: 0x0022B9DC
		public static void Toggle(bool forceOff = false)
		{
			LockOnHelperStaticData.Instance._lifeTimeCounter = 40;
			LockOnHelperStaticData.Instance._lifeTimeArrowDisplay = 30;
			LockOnHelper.HandlePressing();
			LockOnHelperStaticData instance = LockOnHelperStaticData.Instance;
		}

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x06003969 RID: 14697 RVA: 0x0022D814 File Offset: 0x0022BA14
		public static bool Enabled
		{
			get
			{
				if (!true)
				{
				}
				return LockOnHelperStaticData.Instance._enabled;
			}
		}

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x0600396A RID: 14698 RVA: 0x0022D830 File Offset: 0x0022BA30
		public static Vector2 MouseWorld
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600396A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Vector2 Terraria.GameInput.LockOnHelper::get_MouseWorld()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0023:
	stloc:int32(var_10_2E, callgetter:int32(Main::get_myPlayer))
	stloc:Vector2(var_12_38, callgetter:Vector2(Main::get_screenPosition))
	stloc:int32(var_14_42, callgetter:int32(Main::get_screenHeight))
	stloc:int32(var_16_4C, callgetter:int32(Main::get_mouseY))
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

		// Token: 0x0600396B RID: 14699 RVA: 0x0022D88C File Offset: 0x0022BA8C
		private static void FindMostViableTarget(LockOnHelper.LockOnMode context, int targetVar)
		{
			int num = 1;
			targetVar.m_value = num;
			if (num == 0)
			{
			}
			LockOnHelper.LockOnMode useMode = LockOnHelperStaticData.Instance.UseMode;
			if (useMode != LockOnHelper.LockOnMode.FocusTarget || useMode == LockOnHelper.LockOnMode.FocusTarget)
			{
			}
			List<int> targets = LockOnHelperStaticData.Instance._targets;
			int pickedTarget = LockOnHelperStaticData.Instance._pickedTarget;
			LockOnHelperStaticData instance = LockOnHelperStaticData.Instance;
			LockOnHelperStaticData instance2 = LockOnHelperStaticData.Instance;
			Vector2 mouseWorld = LockOnHelper.MouseWorld;
			LockOnHelper.GetClosestTarget(LockOnHelper.MouseWorld);
			List<int> targets2 = LockOnHelperStaticData.Instance._targets;
			int pickedTarget2 = LockOnHelperStaticData.Instance._pickedTarget;
			LockOnHelperStaticData instance3 = LockOnHelperStaticData.Instance;
			LockOnHelperStaticData.Instance._pickedTarget = pickedTarget;
		}

		// Token: 0x0600396C RID: 14700 RVA: 0x0022D934 File Offset: 0x0022BB34
		private static void HandlePressing()
		{
			if (!true)
			{
			}
			LockOnHelper.LockOnMode useMode = LockOnHelperStaticData.Instance.UseMode;
			LockOnHelperStaticData instance = LockOnHelperStaticData.Instance;
			bool enabled = instance._enabled;
		}

		// Token: 0x0600396D RID: 14701 RVA: 0x0022D994 File Offset: 0x0022BB94
		private static void CycleTargetFocus()
		{
			if (!true)
			{
			}
			List<int> targets = LockOnHelperStaticData.Instance._targets;
			int pickedTarget = LockOnHelperStaticData.Instance._pickedTarget;
			Vector2 mouseWorld = LockOnHelper.MouseWorld;
			if (LockOnHelperStaticData.Instance._targets._size == 0)
			{
			}
			int size = LockOnHelperStaticData.Instance._targets._size;
			List<int> targets2 = LockOnHelperStaticData.Instance._targets;
			if (size == 0)
			{
			}
			LockOnHelper.SetActive(false);
		}

		// Token: 0x0600396E RID: 14702 RVA: 0x0022DA58 File Offset: 0x0022BC58
		private static void CycleTargetThreeDS()
		{
			if (!true)
			{
			}
			List<int> targets = LockOnHelperStaticData.Instance._targets;
			int pickedTarget = LockOnHelperStaticData.Instance._pickedTarget;
			Vector2 mouseWorld = LockOnHelper.MouseWorld;
			LockOnHelper.GetClosestTarget(LockOnHelper.MouseWorld);
			if (LockOnHelperStaticData.Instance._targets._size == 0)
			{
			}
			int size = LockOnHelperStaticData.Instance._targets._size;
			if (size == 0)
			{
			}
			List<int> targets2 = LockOnHelperStaticData.Instance._targets;
			if (size == 0)
			{
			}
			List<int> targets3 = LockOnHelperStaticData.Instance._targets;
			int pickedTarget2 = LockOnHelperStaticData.Instance._pickedTarget;
			if (size == 0)
			{
			}
			LockOnHelper.SetActive(false);
		}

		// Token: 0x0600396F RID: 14703 RVA: 0x0022DAFC File Offset: 0x0022BCFC
		private static bool CanEnable()
		{
			/*
An exception occurred when decompiling this method (0600396F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameInput.LockOnHelper::CanEnable()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:int32(var_1_0A, callgetter:int32(Main::get_myPlayer))
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

		// Token: 0x06003970 RID: 14704 RVA: 0x0022DB14 File Offset: 0x0022BD14
		private static void SetActive(bool on)
		{
			int num = 1;
			int num2;
			if (num != 0)
			{
				bool flag = LockOnHelper.CanEnable();
				if (num == 0)
				{
				}
				Vector2 mouseWorld = LockOnHelper.MouseWorld;
				LockOnHelper.GetClosestTarget(LockOnHelper.MouseWorld);
				int pickedTarget = LockOnHelperStaticData.Instance._pickedTarget;
				LockOnHelperStaticData instance = LockOnHelperStaticData.Instance;
				num2 = 1;
				instance._enabled = num2 != 0;
				LockOnHelperStaticData.Instance.LockOnAvailable = num2 != 0;
				return;
			}
			LockOnHelperStaticData instance2 = LockOnHelperStaticData.Instance;
			List<int> targets = LockOnHelperStaticData.Instance._targets;
			int version = targets._version;
			targets._syncRoot = version;
			LockOnHelperStaticData instance3 = LockOnHelperStaticData.Instance;
			LockOnHelperStaticData.Instance._threeDSTarget = num2;
			LockOnHelperStaticData instance4 = LockOnHelperStaticData.Instance;
			instance4._targetClosestTarget = num2;
		}

		// Token: 0x06003971 RID: 14705 RVA: 0x000021DB File Offset: 0x000003DB
		private static void RefreshTargets(Vector2 position, float radius)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003972 RID: 14706 RVA: 0x0022DBE0 File Offset: 0x0022BDE0
		private static void GetClosestTarget(Vector2 position)
		{
			int num = 1;
			if (num == 0)
			{
			}
			LockOnHelperStaticData.Instance._pickedTarget = num;
			if (LockOnHelperStaticData.Instance.UseMode == LockOnHelper.LockOnMode.FocusTarget)
			{
			}
			int myPlayer = Main.myPlayer;
			int myPlayer2 = Main.myPlayer;
			Vector2 mouseWorld = LockOnHelper.MouseWorld;
			long num2 = 0L;
			if (myPlayer2 == 0)
			{
			}
			if (LockOnHelperStaticData.Instance._targets._size == 0)
			{
			}
			List<int> targets = LockOnHelperStaticData.Instance._targets;
			if (LockOnHelperStaticData.Instance._pickedTarget == 0)
			{
			}
			LockOnHelperStaticData.Instance._pickedTarget = (int)num2;
		}

		// Token: 0x06003973 RID: 14707 RVA: 0x0022DCC0 File Offset: 0x0022BEC0
		private static bool ValidTarget(NPC n)
		{
			return true;
		}

		// Token: 0x06003974 RID: 14708 RVA: 0x0022DCD0 File Offset: 0x0022BED0
		private static void SetLockPosition(Vector2 position)
		{
			if (!true)
			{
			}
			PlayerInput.LockOnCachePosition();
			PlayerInput.MouseX = 0;
			if (32640 == 0)
			{
			}
			Main.mouseX = 0;
			PlayerInput.MouseY = 0;
			Main.mouseY = 0;
		}

		// Token: 0x06003975 RID: 14709 RVA: 0x0022DD04 File Offset: 0x0022BF04
		private static void ResetLockPosition()
		{
			if (!true)
			{
			}
			PlayerInput.LockOnUnCachePosition();
			Main.mouseX = PlayerInput.MouseX;
			Main.mouseY = PlayerInput.MouseY;
		}

		// Token: 0x06003976 RID: 14710 RVA: 0x0022DD30 File Offset: 0x0022BF30
		public static void Draw(SpriteBatch spriteBatch)
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool gameMenu = Main.gameMenu;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			int num2 = 220;
			if (num2 == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			if (num2 == 0)
			{
			}
			float[,] drawProgress = LockOnHelperStaticData.Instance._drawProgress;
			LockOnHelper.LockOnMode useMode = LockOnHelperStaticData.Instance.UseMode;
			List<int> targets = LockOnHelperStaticData.Instance._targets;
			int pickedTarget = LockOnHelperStaticData.Instance._pickedTarget;
		}

		// Token: 0x06003977 RID: 14711 RVA: 0x0022DEC4 File Offset: 0x0022C0C4
		public LockOnHelper()
		{
		}

		// Token: 0x06003978 RID: 14712 RVA: 0x0022DED8 File Offset: 0x0022C0D8
		// Note: this type is marked as 'beforefieldinit'.
		static LockOnHelper()
		{
		}

		// Token: 0x040079D9 RID: 31193
		private const float LOCKON_RANGE = 2000f;

		// Token: 0x040079DA RID: 31194
		private const int LOCKON_HOLD_LIFETIME = 40;

		// Token: 0x040079DB RID: 31195
		private static List<int> tempTargets;

		// Token: 0x020006C4 RID: 1732
		public enum LockOnMode
		{
			// Token: 0x040079DD RID: 31197
			FocusTarget,
			// Token: 0x040079DE RID: 31198
			TargetClosest,
			// Token: 0x040079DF RID: 31199
			ThreeDS
		}
	}
}
