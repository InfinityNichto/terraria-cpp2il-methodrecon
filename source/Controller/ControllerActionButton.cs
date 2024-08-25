using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

namespace Controller
{
	// Token: 0x02000B57 RID: 2903
	public class ControllerActionButton
	{
		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x06005467 RID: 21607 RVA: 0x00285EE0 File Offset: 0x002840E0
		public bool HasMapping
		{
			get
			{
				/*
An exception occurred when decompiling this method (06005467)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Controller.ControllerActionButton::get_HasMapping()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_0B, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<class Controller.ControllerActionButton/Entry>[exp:List`1](ControllerActionButton::_entries, ldloc:ControllerActionButton(this))))
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

		// Token: 0x17000930 RID: 2352
		// (get) Token: 0x06005468 RID: 21608 RVA: 0x00285EF8 File Offset: 0x002840F8
		public ControllerActionButton.RequiredButtonState RequiredState
		{
			get
			{
				/*
An exception occurred when decompiling this method (06005468)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Controller.ControllerActionButton/RequiredButtonState Controller.ControllerActionButton::get_RequiredState()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.List`1<class Controller.ControllerActionButton/Entry>(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.List`1<class Controller.ControllerActionButton/Entry>(ControllerActionButton::_entries, ldloc:ControllerActionButton(this)))
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

		// Token: 0x17000931 RID: 2353
		// (get) Token: 0x06005469 RID: 21609 RVA: 0x00285F0C File Offset: 0x0028410C
		public ControllerActionButton.Entry FirstEntry
		{
			get
			{
				/*
An exception occurred when decompiling this method (06005469)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Controller.ControllerActionButton/Entry Controller.ControllerActionButton::get_FirstEntry()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.List`1<class Controller.ControllerActionButton/Entry>(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.List`1<class Controller.ControllerActionButton/Entry>(ControllerActionButton::_entries, ldloc:ControllerActionButton(this)))
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

		// Token: 0x0600546A RID: 21610 RVA: 0x00285F20 File Offset: 0x00284120
		public ControllerActionButton.Entry GetEntry(int index)
		{
			/*
An exception occurred when decompiling this method (0600546A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Controller.ControllerActionButton/Entry Controller.ControllerActionButton::GetEntry(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_0B, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<class Controller.ControllerActionButton/Entry>[exp:List`1](ControllerActionButton::_entries, ldloc:ControllerActionButton(this))))
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

		// Token: 0x0600546B RID: 21611 RVA: 0x00285F3C File Offset: 0x0028413C
		public bool Conflicts(ControllerActionButton other)
		{
			ControllerActionButton.RequiredButtonState requiredState;
			ControllerActionButton.RequiredButtonState requiredState2;
			for (;;)
			{
				int size = this._entries._size;
				int size2 = other._entries._size;
				ControllerActionButton.Entry firstEntry = this.FirstEntry;
				ControllerActionButton.Entry firstEntry2 = other.FirstEntry;
				ControllerActionButton.Entry.Type mappingType = firstEntry.MappingType;
				ControllerActionButton.Entry.Type mappingType2 = firstEntry2.MappingType;
				if (mappingType != ControllerActionButton.Entry.Type.Axis)
				{
					Buttons button = firstEntry.Button;
					Buttons button2 = firstEntry2.Button;
				}
				Axis axis = firstEntry.Axis0;
				Axis axis2 = firstEntry2.Axis0;
				float threshold = firstEntry.Threshold;
				float threshold2 = firstEntry2.Threshold;
				requiredState = firstEntry.RequiredState;
				if (requiredState != null)
				{
					requiredState2 = firstEntry2.RequiredState;
					if (requiredState2 != null)
					{
						break;
					}
				}
			}
			Buttons button3 = requiredState.Button;
			if (requiredState.state)
			{
				Buttons button4 = requiredState.Button2;
			}
			Buttons button5 = requiredState.Button2;
			bool state = requiredState.state2;
			if (requiredState.state)
			{
			}
			Buttons button6 = requiredState2.Button;
			if (requiredState2.state)
			{
				Buttons button7 = requiredState2.Button2;
			}
			Buttons button8 = requiredState2.Button2;
			bool state2 = requiredState2.state2;
			if (requiredState2.state)
			{
				return;
			}
		}

		// Token: 0x0600546C RID: 21612 RVA: 0x000021DB File Offset: 0x000003DB
		public void MapAxis(Axis axis, float threshold, [Optional] ControllerActionButton.RequiredButtonState requiredButtonState, bool ignoreOthersIfExists = true)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600546D RID: 21613 RVA: 0x000021DB File Offset: 0x000003DB
		public void MapButton(Buttons button, [Optional] ControllerActionButton.RequiredButtonState requiredButtonState, bool ignoreOthersIfExists = true)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600546E RID: 21614 RVA: 0x00286048 File Offset: 0x00284248
		public void MapAxisButton(AxisButtons button, [Optional] ControllerActionButton.RequiredButtonState requiredButtonState, bool ignoreOthersIfExists = true)
		{
		}

		// Token: 0x0600546F RID: 21615 RVA: 0x000021DB File Offset: 0x000003DB
		public void MapKey(KeyCode key, bool ignoreOthersIfExists = false)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06005470 RID: 21616 RVA: 0x00286058 File Offset: 0x00284258
		public bool RequiredStateValid(ControllerDevice controller)
		{
			int size = this._entries._size;
			ControllerActionButton.Entry firstEntry = this.FirstEntry;
			if (firstEntry.MappingType == ControllerActionButton.Entry.Type.Axis && controller != null)
			{
				Axis axis = firstEntry.Axis0;
				bool flag = controller.HasAxis(axis);
				if (firstEntry.RequiredState != null)
				{
					Axis axis2 = firstEntry.Axis0;
					float axisTime = controller.GetAxisTime(axis2);
					ControllerActionButton.RequiredButtonState requiredState = firstEntry.RequiredState;
					if (controller != null)
					{
						Buttons button = firstEntry.Button;
						ControllerActionButton.RequiredButtonState requiredState2 = firstEntry.RequiredState;
						if (requiredState2 != null)
						{
							Buttons button2 = firstEntry.Button;
							float num = controller.ButtonTime(button2);
							return requiredState2.Valid(controller, num);
						}
					}
				}
			}
			return true;
		}

		// Token: 0x06005471 RID: 21617 RVA: 0x000021DB File Offset: 0x000003DB
		public bool GetButtonState(ControllerDevice controller)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06005472 RID: 21618 RVA: 0x000021DB File Offset: 0x000003DB
		public bool GetButtonDown(ControllerDevice controller)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06005473 RID: 21619 RVA: 0x000021DB File Offset: 0x000003DB
		public bool GetButtonUp(ControllerDevice controller)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06005474 RID: 21620 RVA: 0x000021DB File Offset: 0x000003DB
		public void Clear()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06005475 RID: 21621 RVA: 0x002860EC File Offset: 0x002842EC
		public ControllerActionButton()
		{
		}

		// Token: 0x04008D3A RID: 36154
		public string Id;

		// Token: 0x04008D3B RID: 36155
		public bool Enabled;

		// Token: 0x04008D3C RID: 36156
		public bool DisableUnitlClear;

		// Token: 0x04008D3D RID: 36157
		public int DisplayPriority;

		// Token: 0x04008D3E RID: 36158
		public ControllerActionButton LinkedAction;

		// Token: 0x04008D3F RID: 36159
		private List<ControllerActionButton.Entry> _entries;

		// Token: 0x02000B58 RID: 2904
		public class RequiredButtonState
		{
			// Token: 0x06005476 RID: 21622 RVA: 0x002860FC File Offset: 0x002842FC
			public RequiredButtonState()
			{
			}

			// Token: 0x06005477 RID: 21623 RVA: 0x00286120 File Offset: 0x00284320
			public RequiredButtonState(Buttons button, bool requiredState)
			{
				this.Button = button;
			}

			// Token: 0x06005478 RID: 21624 RVA: 0x0028614C File Offset: 0x0028434C
			public RequiredButtonState(Buttons button, bool requiredState, Buttons button2, bool requiredState2)
			{
				this.Button = button;
				this.Button2 = button2;
			}

			// Token: 0x06005479 RID: 21625 RVA: 0x00286180 File Offset: 0x00284380
			public bool Active(ControllerDevice device, float buttonPressTime, float axisValue)
			{
				while (device == null)
				{
				}
				Buttons button = this.Button;
				Buttons button2 = this.Button2;
				return true;
			}

			// Token: 0x0600547A RID: 21626 RVA: 0x002861E8 File Offset: 0x002843E8
			public bool Valid(ControllerDevice device, float buttonPressTime)
			{
				if (device != null)
				{
					Buttons button = this.Button;
					Buttons button2 = this.Button2;
					return true;
				}
			}

			// Token: 0x0600547B RID: 21627 RVA: 0x00286278 File Offset: 0x00284478
			public void ConsumeModifiers(ControllerDevice device)
			{
				if (device != null)
				{
					Buttons button = this.Button;
					if (this.state)
					{
						device.SetButtonConsumbed(button);
					}
					Buttons button2 = this.Button2;
					if (this.state2)
					{
						device.SetButtonConsumbed(button2);
						return;
					}
				}
			}

			// Token: 0x04008D40 RID: 36160
			public Buttons Button = Buttons.Count;

			// Token: 0x04008D41 RID: 36161
			public bool state;

			// Token: 0x04008D42 RID: 36162
			public Buttons Button2 = Buttons.Count;

			// Token: 0x04008D43 RID: 36163
			public bool state2;
		}

		// Token: 0x02000B59 RID: 2905
		public class Entry
		{
			// Token: 0x0600547C RID: 21628 RVA: 0x002862B8 File Offset: 0x002844B8
			public Entry()
			{
			}

			// Token: 0x04008D44 RID: 36164
			public ControllerActionButton.Entry.Type MappingType;

			// Token: 0x04008D45 RID: 36165
			public Axis Axis0;

			// Token: 0x04008D46 RID: 36166
			public float Threshold;

			// Token: 0x04008D47 RID: 36167
			public Buttons Button;

			// Token: 0x04008D48 RID: 36168
			public KeyCode InputKey;

			// Token: 0x04008D49 RID: 36169
			public bool IgnoreOthersIfExists;

			// Token: 0x04008D4A RID: 36170
			public ControllerActionButton.RequiredButtonState RequiredState;

			// Token: 0x02000B5A RID: 2906
			public enum Type
			{
				// Token: 0x04008D4C RID: 36172
				Axis,
				// Token: 0x04008D4D RID: 36173
				Button,
				// Token: 0x04008D4E RID: 36174
				InputKey
			}
		}
	}
}
