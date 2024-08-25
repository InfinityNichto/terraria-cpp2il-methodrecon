using System;

namespace UnityEngine.EventSystems
{
	// Token: 0x020000B1 RID: 177
	public class BaseInput : UIBehaviour
	{
		// Token: 0x170001AC RID: 428
		// (get) Token: 0x0600064C RID: 1612 RVA: 0x000121C0 File Offset: 0x000103C0
		public virtual string compositionString
		{
			get
			{
				return Input.compositionString;
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x0600064D RID: 1613 RVA: 0x000121D4 File Offset: 0x000103D4
		// (set) Token: 0x0600064E RID: 1614 RVA: 0x000121E8 File Offset: 0x000103E8
		public virtual IMECompositionMode imeCompositionMode
		{
			get
			{
				return Input.imeCompositionMode;
			}
			set
			{
				Input.imeCompositionMode = value;
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x0600064F RID: 1615 RVA: 0x000121FC File Offset: 0x000103FC
		// (set) Token: 0x06000650 RID: 1616 RVA: 0x00012214 File Offset: 0x00010414
		public virtual Vector2 compositionCursorPos
		{
			get
			{
				Vector2 compositionCursorPos = Input.compositionCursorPos;
				Vector2 vector;
				return vector;
			}
			set
			{
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06000651 RID: 1617 RVA: 0x00012224 File Offset: 0x00010424
		public virtual bool mousePresent
		{
			get
			{
				return Input.mousePresent;
			}
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x00012238 File Offset: 0x00010438
		public virtual bool GetMouseButtonDown(int button)
		{
			return Input.GetMouseButtonDown(button);
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x0001224C File Offset: 0x0001044C
		public virtual bool GetMouseButtonUp(int button)
		{
			return Input.GetMouseButtonUp(button);
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x00012260 File Offset: 0x00010460
		public virtual bool GetMouseButton(int button)
		{
			return Input.GetMouseButton(button);
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06000655 RID: 1621 RVA: 0x00012274 File Offset: 0x00010474
		public virtual Vector2 mousePosition
		{
			get
			{
				Vector3 mousePosition = Input.mousePosition;
				Vector2 vector;
				return vector;
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06000656 RID: 1622 RVA: 0x0001228C File Offset: 0x0001048C
		public virtual Vector2 mouseScrollDelta
		{
			get
			{
				Vector2 mouseScrollDelta = Input.mouseScrollDelta;
				Vector2 vector;
				return vector;
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000657 RID: 1623 RVA: 0x000122A4 File Offset: 0x000104A4
		public virtual bool touchSupported
		{
			get
			{
				return Input.touchSupported;
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000658 RID: 1624 RVA: 0x000122B8 File Offset: 0x000104B8
		public virtual int touchCount
		{
			get
			{
				return Input.touchCount;
			}
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x000122CC File Offset: 0x000104CC
		public virtual Touch GetTouch(int index)
		{
			Touch touch = Input.GetTouch(index);
			Touch touch2;
			return touch2;
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x000122E4 File Offset: 0x000104E4
		public virtual float GetAxisRaw(string axisName)
		{
			/*
An exception occurred when decompiling this method (0600065A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single UnityEngine.EventSystems.BaseInput::GetAxisRaw(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, call:float32(Input::GetAxisRaw, ldloc:string(axisName)))
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

		// Token: 0x0600065B RID: 1627 RVA: 0x000122F8 File Offset: 0x000104F8
		public virtual bool GetButtonDown(string buttonName)
		{
			return Input.GetButtonDown(buttonName);
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x0001230C File Offset: 0x0001050C
		public BaseInput()
		{
		}
	}
}
