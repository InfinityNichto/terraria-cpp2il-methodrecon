using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

namespace Controller
{
	// Token: 0x02000B54 RID: 2900
	public class ControllerActionAxis
	{
		// Token: 0x1700092C RID: 2348
		// (get) Token: 0x0600545A RID: 21594 RVA: 0x00285DB4 File Offset: 0x00283FB4
		public bool HasMapping
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600545A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Controller.ControllerActionAxis::get_HasMapping()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_0B, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<class Controller.ControllerActionAxis/Entry>[exp:List`1](ControllerActionAxis::_entries, ldloc:ControllerActionAxis(this))))
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

		// Token: 0x0600545B RID: 21595 RVA: 0x00285DCC File Offset: 0x00283FCC
		public bool RequiredStateValid(ControllerDevice controller)
		{
			if (controller != null)
			{
				int size = this._entries._size;
				if (this.RequiredState != null)
				{
					ControllerActionButton.RequiredButtonState requiredState = this.RequiredState;
					Axis axis = this.FirstEntry.Axis0;
					float axisTime = controller.GetAxisTime(axis);
					return requiredState.Valid(controller, axisTime);
				}
			}
			return true;
		}

		// Token: 0x0600545C RID: 21596 RVA: 0x00285E18 File Offset: 0x00284018
		public bool Active(ControllerDevice controller)
		{
			if (controller != null)
			{
				int size = this._entries._size;
				if (this.RequiredState == null)
				{
					float value = this.GetValue(controller);
				}
				ControllerActionButton.RequiredButtonState requiredState = this.RequiredState;
				Axis axis = this.FirstEntry.Axis0;
				float axisTime = controller.GetAxisTime(axis);
				float value2 = this.GetValue(controller);
				return requiredState.Active(controller, axisTime, value2);
			}
			return true;
		}

		// Token: 0x1700092D RID: 2349
		// (get) Token: 0x0600545D RID: 21597 RVA: 0x00285E78 File Offset: 0x00284078
		public ControllerActionButton.RequiredButtonState RequiredState
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600545D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Controller.ControllerActionButton/RequiredButtonState Controller.ControllerActionAxis::get_RequiredState()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.List`1<class Controller.ControllerActionAxis/Entry>(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.List`1<class Controller.ControllerActionAxis/Entry>(ControllerActionAxis::_entries, ldloc:ControllerActionAxis(this)))
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

		// Token: 0x1700092E RID: 2350
		// (get) Token: 0x0600545E RID: 21598 RVA: 0x00285E8C File Offset: 0x0028408C
		public ControllerActionAxis.Entry FirstEntry
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600545E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Controller.ControllerActionAxis/Entry Controller.ControllerActionAxis::get_FirstEntry()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.List`1<class Controller.ControllerActionAxis/Entry>(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.List`1<class Controller.ControllerActionAxis/Entry>(ControllerActionAxis::_entries, ldloc:ControllerActionAxis(this)))
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

		// Token: 0x0600545F RID: 21599 RVA: 0x000021DB File Offset: 0x000003DB
		public void MapAxis(Axis axis, float threshold = 0f, [Optional] ControllerActionButton.RequiredButtonState requiredButtonState)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06005460 RID: 21600 RVA: 0x000021DB File Offset: 0x000003DB
		public void MapMultipleAxis(Axis axis1, Axis axis2)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06005461 RID: 21601 RVA: 0x000021DB File Offset: 0x000003DB
		public void MapButtons(Buttons button0, Buttons button1)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06005462 RID: 21602 RVA: 0x000021DB File Offset: 0x000003DB
		public void MapKeys(KeyCode key0, KeyCode key1)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06005463 RID: 21603 RVA: 0x000021DB File Offset: 0x000003DB
		public float GetValue(ControllerDevice controller)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06005464 RID: 21604 RVA: 0x000021DB File Offset: 0x000003DB
		public void Clear()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06005465 RID: 21605 RVA: 0x00285EA0 File Offset: 0x002840A0
		public ControllerActionAxis()
		{
		}

		// Token: 0x04008D26 RID: 36134
		public static float ElapsedTime;

		// Token: 0x04008D27 RID: 36135
		public string Id;

		// Token: 0x04008D28 RID: 36136
		public bool Enabled = 257 != 0;

		// Token: 0x04008D29 RID: 36137
		public bool TimeBased;

		// Token: 0x04008D2A RID: 36138
		public float Scale = (float)16256;

		// Token: 0x04008D2B RID: 36139
		private List<ControllerActionAxis.Entry> _entries;

		// Token: 0x02000B55 RID: 2901
		public class Entry
		{
			// Token: 0x06005466 RID: 21606 RVA: 0x00285ECC File Offset: 0x002840CC
			public Entry()
			{
			}

			// Token: 0x04008D2C RID: 36140
			public ControllerActionAxis.Entry.Type MappingType;

			// Token: 0x04008D2D RID: 36141
			public Axis Axis0;

			// Token: 0x04008D2E RID: 36142
			public Axis Axis1;

			// Token: 0x04008D2F RID: 36143
			public float Threshold;

			// Token: 0x04008D30 RID: 36144
			public Buttons Button0;

			// Token: 0x04008D31 RID: 36145
			public Buttons Button1;

			// Token: 0x04008D32 RID: 36146
			public KeyCode Key0;

			// Token: 0x04008D33 RID: 36147
			public KeyCode Key1;

			// Token: 0x04008D34 RID: 36148
			public ControllerActionButton.RequiredButtonState RequiredState;

			// Token: 0x02000B56 RID: 2902
			public enum Type
			{
				// Token: 0x04008D36 RID: 36150
				SingleAxis,
				// Token: 0x04008D37 RID: 36151
				MultipleAxis,
				// Token: 0x04008D38 RID: 36152
				Buttons,
				// Token: 0x04008D39 RID: 36153
				Keys
			}
		}
	}
}
