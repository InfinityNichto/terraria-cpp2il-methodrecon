using System;
using UnityEngine;

namespace InControl
{
	// Token: 0x0200004C RID: 76
	public class Touch
	{
		// Token: 0x060003B2 RID: 946 RVA: 0x0000C70C File Offset: 0x0000A90C
		internal Touch()
		{
			this.phase = TouchPhase.Ended;
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x0000C728 File Offset: 0x0000A928
		internal void Reset()
		{
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x060003B4 RID: 948 RVA: 0x0000C738 File Offset: 0x0000A938
		[Obsolete("normalizedPressure is deprecated, please use NormalizedPressure instead.")]
		public float normalizedPressure
		{
			get
			{
				/*
An exception occurred when decompiling this method (060003B4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single InControl.Touch::get_normalizedPressure()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(Touch::maximumPossiblePressure, ldloc:Touch(this)))
	stloc:float32(var_1_0D, ldfld:float32(Touch::pressure, ldloc:Touch(this)))
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

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x060003B5 RID: 949 RVA: 0x0000C754 File Offset: 0x0000A954
		public float NormalizedPressure
		{
			get
			{
				/*
An exception occurred when decompiling this method (060003B5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single InControl.Touch::get_NormalizedPressure()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(Touch::maximumPossiblePressure, ldloc:Touch(this)))
	stloc:float32(var_1_0D, ldfld:float32(Touch::pressure, ldloc:Touch(this)))
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

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x060003B6 RID: 950 RVA: 0x0000C770 File Offset: 0x0000A970
		public bool IsMouse
		{
			get
			{
				/*
An exception occurred when decompiling this method (060003B6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean InControl.Touch::get_IsMouse()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:TouchType(var_0_06, ldfld:TouchType(Touch::type, ldloc:Touch(this)))
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

		// Token: 0x060003B7 RID: 951 RVA: 0x0000C784 File Offset: 0x0000A984
		internal void SetWithTouchData(Touch touch, ulong updateTick, float deltaTime)
		{
			TouchPhase touchPhase = touch.phase;
			this.phase = touchPhase;
			int num = touch.tapCount;
			this.tapCount = num;
			float num2 = touch.altitudeAngle;
			float num3 = touch.azimuthAngle;
			float num4 = touch.maximumPossiblePressure;
			float num5 = touch.pressure;
			float num6 = touch.radius;
			float num7 = touch.radiusVariance;
			Vector2 vector = touch.position;
			int width = Screen.width;
			int height = Screen.height;
			if (this.phase == TouchPhase.Began)
			{
				return;
			}
			float x = this.lastPosition.x;
			float y = this.lastPosition.y;
			Vector2 vector2 = this.position;
			this.deltaPosition.x = x;
			this.deltaPosition.y = y;
			this.lastPosition = vector2;
			this.updateTick = updateTick;
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x0000C854 File Offset: 0x0000AA54
		internal bool SetWithMouseData(int button, ulong updateTick, float deltaTime)
		{
			int touchCount = Input.touchCount;
			Vector3 mousePosition = Input.mousePosition;
			Vector3 mousePosition2 = Input.mousePosition;
			bool mouseButtonDown = Input.GetMouseButtonDown(button);
			this.mouseButton = button;
			this.type = TouchType.Mouse;
			this.updateTick = updateTick;
			bool mouseButtonUp = Input.GetMouseButtonUp(43134976);
			this.mouseButton = 43134976;
			this.updateTick = updateTick;
			float x = this.lastPosition.x;
			Vector2 vector = this.position;
			this.type = TouchType.Mouse;
			this.lastPosition = vector;
			return mouseButtonUp;
		}

		// Token: 0x04000343 RID: 835
		public const int FingerID_None = -1;

		// Token: 0x04000344 RID: 836
		public const int FingerID_Mouse = -2;

		// Token: 0x04000345 RID: 837
		public int fingerId;

		// Token: 0x04000346 RID: 838
		public int mouseButton;

		// Token: 0x04000347 RID: 839
		public TouchPhase phase;

		// Token: 0x04000348 RID: 840
		public int tapCount;

		// Token: 0x04000349 RID: 841
		public Vector2 position;

		// Token: 0x0400034A RID: 842
		public Vector2 startPosition;

		// Token: 0x0400034B RID: 843
		public Vector2 deltaPosition;

		// Token: 0x0400034C RID: 844
		public Vector2 lastPosition;

		// Token: 0x0400034D RID: 845
		public float deltaTime;

		// Token: 0x0400034E RID: 846
		public ulong updateTick;

		// Token: 0x0400034F RID: 847
		public TouchType type;

		// Token: 0x04000350 RID: 848
		public float altitudeAngle;

		// Token: 0x04000351 RID: 849
		public float azimuthAngle;

		// Token: 0x04000352 RID: 850
		public float maximumPossiblePressure;

		// Token: 0x04000353 RID: 851
		public float pressure;

		// Token: 0x04000354 RID: 852
		public float radius;

		// Token: 0x04000355 RID: 853
		public float radiusVariance;
	}
}
