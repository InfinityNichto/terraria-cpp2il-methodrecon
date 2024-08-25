using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace Controller
{
	// Token: 0x02000B5F RID: 2911
	public class ControllerActionManager
	{
		// Token: 0x06005487 RID: 21639 RVA: 0x000021DB File Offset: 0x000003DB
		public static ControllerActionManager Create()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06005488 RID: 21640 RVA: 0x002864FC File Offset: 0x002846FC
		public static Axis GetAxisThreshold(AxisButtons button, [Out] float threshold)
		{
		}

		// Token: 0x06005489 RID: 21641 RVA: 0x000021DB File Offset: 0x000003DB
		public ControllerActionManager()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600548A RID: 21642 RVA: 0x000021DB File Offset: 0x000003DB
		public ControllerActionButton CreateButtonMapping(string id)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600548B RID: 21643 RVA: 0x000021DB File Offset: 0x000003DB
		public ControllerActionAxis CreateAxisMapping(string id, bool timeBased, float axisScale)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600548C RID: 21644 RVA: 0x000021DB File Offset: 0x000003DB
		public ControllerActionVector CreateVectorMapping(string id, ControllerActionAxis axisX, ControllerActionAxis axisY)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600548D RID: 21645 RVA: 0x000021DB File Offset: 0x000003DB
		public ControllerActionAxis GetAxisMapping(string id)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600548E RID: 21646 RVA: 0x000021DB File Offset: 0x000003DB
		public ControllerActionButton GetButtonMapping(string id)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600548F RID: 21647 RVA: 0x000021DB File Offset: 0x000003DB
		public ControllerActionVector GetVectorMapping(string id)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x17000938 RID: 2360
		// (get) Token: 0x06005490 RID: 21648 RVA: 0x0028650C File Offset: 0x0028470C
		public bool HasController
		{
			get
			{
				/*
An exception occurred when decompiling this method (06005490)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Controller.ControllerActionManager::get_HasController()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:ControllerDevice(var_1_08, ldfld:ControllerDevice(ControllerActionManager::_controller, ldloc:ControllerActionManager(this)))
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

		// Token: 0x17000939 RID: 2361
		// (get) Token: 0x06005491 RID: 21649 RVA: 0x00286524 File Offset: 0x00284724
		public bool IsControllerActive
		{
			get
			{
				return this._controllerActive;
			}
		}

		// Token: 0x06005492 RID: 21650 RVA: 0x00286538 File Offset: 0x00284738
		public void ForceActiveController(ControllerDevice controller)
		{
			this._forcedActiveController = controller;
			this._controller = controller;
		}

		// Token: 0x06005493 RID: 21651 RVA: 0x00286554 File Offset: 0x00284754
		public void OnUpdate(float elapsedTime)
		{
			if (this._forcedActiveController != null)
			{
				ControllerDevice forcedActiveController = this._forcedActiveController;
				return;
			}
			int num = 1;
			this._controllerActive = num != 0;
			ControllerDevice controller = this._controller;
		}

		// Token: 0x1700093A RID: 2362
		// (get) Token: 0x06005494 RID: 21652 RVA: 0x0028659C File Offset: 0x0028479C
		public ControllerDevice ActiveController
		{
			get
			{
				return this._controller;
			}
		}

		// Token: 0x1700093B RID: 2363
		// (get) Token: 0x06005495 RID: 21653 RVA: 0x002865B4 File Offset: 0x002847B4
		public static bool AnyControllerConnected
		{
			get
			{
				bool flag = DrPlatform.IsCurrentPlatform(DrPlatform.DrPlatformType.Mobile);
				if (!true)
				{
				}
				while (!true)
				{
				}
				return true;
			}
		}

		// Token: 0x04008D7D RID: 36221
		public static ControllerActionManager Instance;

		// Token: 0x04008D7E RID: 36222
		private List<ControllerActionAxis> _axisMappings;

		// Token: 0x04008D7F RID: 36223
		private List<ControllerActionButton> _buttonMappings;

		// Token: 0x04008D80 RID: 36224
		private List<ControllerActionVector> _vectorMappings;

		// Token: 0x04008D81 RID: 36225
		private ControllerDevice _controller;

		// Token: 0x04008D82 RID: 36226
		private bool _controllerActive;

		// Token: 0x04008D83 RID: 36227
		private ControllerDevice _forcedActiveController;

		// Token: 0x04008D84 RID: 36228
		private bool _pendingDisableActions;

		// Token: 0x04008D85 RID: 36229
		private string[] _pendingDisableActionsList;

		// Token: 0x04008D86 RID: 36230
		private bool _pendingEnableActions;
	}
}
