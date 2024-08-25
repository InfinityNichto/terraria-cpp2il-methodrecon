using System;
using UnityEngine;

namespace Controller
{
	// Token: 0x02000B5B RID: 2907
	public class ControllerActionVector
	{
		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x0600547D RID: 21629 RVA: 0x002862CC File Offset: 0x002844CC
		public ControllerActionAxis MappedX
		{
			get
			{
				int size = this.X._entries._size;
				return this.X;
			}
		}

		// Token: 0x17000933 RID: 2355
		// (get) Token: 0x0600547E RID: 21630 RVA: 0x00286310 File Offset: 0x00284510
		public ControllerActionAxis MappedY
		{
			get
			{
				int size = this.X._entries._size;
				return this.X;
			}
		}

		// Token: 0x17000934 RID: 2356
		// (get) Token: 0x0600547F RID: 21631 RVA: 0x00286354 File Offset: 0x00284554
		public bool HasMapping
		{
			get
			{
				for (;;)
				{
					int size = this.X._entries._size;
					int size2 = this.Y._entries._size;
					if (this.LinkedAction == null)
					{
						return;
					}
				}
			}
		}

		// Token: 0x17000935 RID: 2357
		// (get) Token: 0x06005480 RID: 21632 RVA: 0x0028638C File Offset: 0x0028458C
		public ControllerActionButton.RequiredButtonState RequiredState
		{
			get
			{
				int size = this.X._entries._size;
				ControllerActionVector linkedAction = this.LinkedAction;
				ControllerActionVector linkedAction2;
				if (linkedAction != null)
				{
					bool hasMapping = linkedAction.HasMapping;
					linkedAction2 = this.LinkedAction;
				}
				return linkedAction2.X.RequiredState;
			}
		}

		// Token: 0x17000936 RID: 2358
		// (get) Token: 0x06005481 RID: 21633 RVA: 0x002863D0 File Offset: 0x002845D0
		public bool HasMappingExcludeLinked
		{
			get
			{
				/*
An exception occurred when decompiling this method (06005481)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Controller.ControllerActionVector::get_HasMappingExcludeLinked()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_10, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<class Controller.ControllerActionAxis/Entry>[exp:List`1](ControllerActionAxis::_entries, ldfld:ControllerActionAxis(ControllerActionVector::X, ldloc:ControllerActionVector(this)))))
	stloc:int32(var_1_21, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<class Controller.ControllerActionAxis/Entry>[exp:List`1](ControllerActionAxis::_entries, ldfld:ControllerActionAxis(ControllerActionVector::Y, ldloc:ControllerActionVector(this)))))
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

		// Token: 0x17000937 RID: 2359
		// (get) Token: 0x06005482 RID: 21634 RVA: 0x00286400 File Offset: 0x00284600
		public ControllerActionButton.RequiredButtonState RequiredStateExcludeLinked
		{
			get
			{
				int size = this.X._entries._size;
				return this.X.RequiredState;
			}
		}

		// Token: 0x06005483 RID: 21635 RVA: 0x0028642C File Offset: 0x0028462C
		public bool Active(ControllerDevice device)
		{
			do
			{
				bool flag = this.X.Active(device);
				bool flag2 = this.Y.Active(device);
			}
			while (this.LinkedAction != null);
			return true;
		}

		// Token: 0x06005484 RID: 21636 RVA: 0x00286460 File Offset: 0x00284660
		public bool RequiredStateValid(ControllerDevice device)
		{
			bool flag = this.X.RequiredStateValid(device);
			return this.Y.RequiredStateValid(device);
		}

		// Token: 0x06005485 RID: 21637 RVA: 0x00286488 File Offset: 0x00284688
		public Vector2 GetValue(ControllerDevice controller)
		{
			/*
An exception occurred when decompiling this method (06005485)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.Vector2 Controller.ControllerActionVector::GetValue(Controller.ControllerDevice)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0042:
	brtrue(IL_0000, logicnot:bool(ldfld:bool(ControllerActionVector::DisabledUntilClear, ldloc:ControllerActionVector(this))))
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

		// Token: 0x06005486 RID: 21638 RVA: 0x002864E0 File Offset: 0x002846E0
		public ControllerActionVector()
		{
		}

		// Token: 0x04008D4F RID: 36175
		public string Id;

		// Token: 0x04008D50 RID: 36176
		public ControllerActionAxis X;

		// Token: 0x04008D51 RID: 36177
		public ControllerActionAxis Y;

		// Token: 0x04008D52 RID: 36178
		public int DisplayPriority;

		// Token: 0x04008D53 RID: 36179
		public ControllerActionVector LinkedAction;

		// Token: 0x04008D54 RID: 36180
		public bool Enabled = true;

		// Token: 0x04008D55 RID: 36181
		public bool DisabledUntilClear;
	}
}
