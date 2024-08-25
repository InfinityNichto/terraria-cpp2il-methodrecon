using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000093 RID: 147
	public class PointerEventData : BaseEventData
	{
		// Token: 0x1700016E RID: 366
		// (get) Token: 0x0600058D RID: 1421 RVA: 0x0001103C File Offset: 0x0000F23C
		// (set) Token: 0x0600058E RID: 1422 RVA: 0x00011050 File Offset: 0x0000F250
		public GameObject pointerEnter
		{
			[CompilerGenerated]
			get
			{
				return this.<pointerEnter>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<pointerEnter>k__BackingField = value;
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x0600058F RID: 1423 RVA: 0x00011064 File Offset: 0x0000F264
		// (set) Token: 0x06000590 RID: 1424 RVA: 0x00011078 File Offset: 0x0000F278
		public GameObject lastPress
		{
			[CompilerGenerated]
			get
			{
				return this.<lastPress>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<lastPress>k__BackingField = value;
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000591 RID: 1425 RVA: 0x0001108C File Offset: 0x0000F28C
		// (set) Token: 0x06000592 RID: 1426 RVA: 0x000110A0 File Offset: 0x0000F2A0
		public GameObject rawPointerPress
		{
			[CompilerGenerated]
			get
			{
				return this.<rawPointerPress>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<rawPointerPress>k__BackingField = value;
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000593 RID: 1427 RVA: 0x000110B4 File Offset: 0x0000F2B4
		// (set) Token: 0x06000594 RID: 1428 RVA: 0x000110C8 File Offset: 0x0000F2C8
		public GameObject pointerDrag
		{
			[CompilerGenerated]
			get
			{
				return this.<pointerDrag>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<pointerDrag>k__BackingField = value;
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000595 RID: 1429 RVA: 0x000110DC File Offset: 0x0000F2DC
		// (set) Token: 0x06000596 RID: 1430 RVA: 0x000110F0 File Offset: 0x0000F2F0
		public GameObject pointerClick
		{
			[CompilerGenerated]
			get
			{
				return this.<pointerClick>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<pointerClick>k__BackingField = value;
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000597 RID: 1431 RVA: 0x00011104 File Offset: 0x0000F304
		// (set) Token: 0x06000598 RID: 1432 RVA: 0x00011114 File Offset: 0x0000F314
		public RaycastResult pointerCurrentRaycast
		{
			[CompilerGenerated]
			get
			{
				RaycastResult raycastResult;
				return raycastResult;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000599 RID: 1433 RVA: 0x00011124 File Offset: 0x0000F324
		// (set) Token: 0x0600059A RID: 1434 RVA: 0x00011134 File Offset: 0x0000F334
		public RaycastResult pointerPressRaycast
		{
			[CompilerGenerated]
			get
			{
				RaycastResult raycastResult;
				return raycastResult;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x0600059B RID: 1435 RVA: 0x00011144 File Offset: 0x0000F344
		// (set) Token: 0x0600059C RID: 1436 RVA: 0x00011158 File Offset: 0x0000F358
		public bool eligibleForClick
		{
			[CompilerGenerated]
			get
			{
				return this.<eligibleForClick>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x0600059D RID: 1437 RVA: 0x00011168 File Offset: 0x0000F368
		// (set) Token: 0x0600059E RID: 1438 RVA: 0x0001117C File Offset: 0x0000F37C
		public int pointerId
		{
			[CompilerGenerated]
			get
			{
				return this.<pointerId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<pointerId>k__BackingField = value;
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x0600059F RID: 1439 RVA: 0x00011190 File Offset: 0x0000F390
		// (set) Token: 0x060005A0 RID: 1440 RVA: 0x000111B8 File Offset: 0x0000F3B8
		public Vector2 position
		{
			[CompilerGenerated]
			get
			{
				float x = this.<position>k__BackingField.x;
				float y = this.<position>k__BackingField.y;
				Vector2 vector;
				return vector;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x060005A1 RID: 1441 RVA: 0x000111C8 File Offset: 0x0000F3C8
		// (set) Token: 0x060005A2 RID: 1442 RVA: 0x000111F0 File Offset: 0x0000F3F0
		public Vector2 delta
		{
			[CompilerGenerated]
			get
			{
				float x = this.<delta>k__BackingField.x;
				float y = this.<delta>k__BackingField.y;
				Vector2 vector;
				return vector;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x060005A3 RID: 1443 RVA: 0x00011200 File Offset: 0x0000F400
		// (set) Token: 0x060005A4 RID: 1444 RVA: 0x00011228 File Offset: 0x0000F428
		public Vector2 pressPosition
		{
			[CompilerGenerated]
			get
			{
				float x = this.<pressPosition>k__BackingField.x;
				float y = this.<pressPosition>k__BackingField.y;
				Vector2 vector;
				return vector;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x060005A5 RID: 1445 RVA: 0x00011238 File Offset: 0x0000F438
		// (set) Token: 0x060005A6 RID: 1446 RVA: 0x0001126C File Offset: 0x0000F46C
		[Obsolete("Use either pointerCurrentRaycast.worldPosition or pointerPressRaycast.worldPosition")]
		public Vector3 worldPosition
		{
			[CompilerGenerated]
			get
			{
				float x = this.<worldPosition>k__BackingField.x;
				float y = this.<worldPosition>k__BackingField.y;
				float z = this.<worldPosition>k__BackingField.z;
				Vector3 vector;
				return vector;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x060005A7 RID: 1447 RVA: 0x0001127C File Offset: 0x0000F47C
		// (set) Token: 0x060005A8 RID: 1448 RVA: 0x000112B0 File Offset: 0x0000F4B0
		[Obsolete("Use either pointerCurrentRaycast.worldNormal or pointerPressRaycast.worldNormal")]
		public Vector3 worldNormal
		{
			[CompilerGenerated]
			get
			{
				float x = this.<worldNormal>k__BackingField.x;
				float y = this.<worldNormal>k__BackingField.y;
				float z = this.<worldNormal>k__BackingField.z;
				Vector3 vector;
				return vector;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x060005A9 RID: 1449 RVA: 0x000112C0 File Offset: 0x0000F4C0
		// (set) Token: 0x060005AA RID: 1450 RVA: 0x000112D4 File Offset: 0x0000F4D4
		public float clickTime
		{
			[CompilerGenerated]
			get
			{
				/*
An exception occurred when decompiling this method (060005A9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single UnityEngine.EventSystems.PointerEventData::get_clickTime()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(PointerEventData::<clickTime>k__BackingField, ldloc:PointerEventData(this)))
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
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x060005AB RID: 1451 RVA: 0x000112E4 File Offset: 0x0000F4E4
		// (set) Token: 0x060005AC RID: 1452 RVA: 0x000112F8 File Offset: 0x0000F4F8
		public int clickCount
		{
			[CompilerGenerated]
			get
			{
				return this.<clickCount>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<clickCount>k__BackingField = value;
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x060005AD RID: 1453 RVA: 0x0001130C File Offset: 0x0000F50C
		// (set) Token: 0x060005AE RID: 1454 RVA: 0x00011334 File Offset: 0x0000F534
		public Vector2 scrollDelta
		{
			[CompilerGenerated]
			get
			{
				float x = this.<scrollDelta>k__BackingField.x;
				float y = this.<scrollDelta>k__BackingField.y;
				Vector2 vector;
				return vector;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x060005AF RID: 1455 RVA: 0x00011344 File Offset: 0x0000F544
		// (set) Token: 0x060005B0 RID: 1456 RVA: 0x00011358 File Offset: 0x0000F558
		public bool useDragThreshold
		{
			[CompilerGenerated]
			get
			{
				return this.<useDragThreshold>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x060005B1 RID: 1457 RVA: 0x00011368 File Offset: 0x0000F568
		// (set) Token: 0x060005B2 RID: 1458 RVA: 0x0001137C File Offset: 0x0000F57C
		public bool dragging
		{
			[CompilerGenerated]
			get
			{
				return this.<dragging>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x060005B3 RID: 1459 RVA: 0x0001138C File Offset: 0x0000F58C
		// (set) Token: 0x060005B4 RID: 1460 RVA: 0x000113A0 File Offset: 0x0000F5A0
		public PointerEventData.InputButton button
		{
			[CompilerGenerated]
			get
			{
				return this.<button>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<button>k__BackingField = value;
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x060005B5 RID: 1461 RVA: 0x000113B4 File Offset: 0x0000F5B4
		// (set) Token: 0x060005B6 RID: 1462 RVA: 0x000113C8 File Offset: 0x0000F5C8
		public float pressure
		{
			[CompilerGenerated]
			get
			{
				/*
An exception occurred when decompiling this method (060005B5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single UnityEngine.EventSystems.PointerEventData::get_pressure()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(PointerEventData::<pressure>k__BackingField, ldloc:PointerEventData(this)))
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
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x060005B7 RID: 1463 RVA: 0x000113D8 File Offset: 0x0000F5D8
		// (set) Token: 0x060005B8 RID: 1464 RVA: 0x000113EC File Offset: 0x0000F5EC
		public float tangentialPressure
		{
			[CompilerGenerated]
			get
			{
				/*
An exception occurred when decompiling this method (060005B7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single UnityEngine.EventSystems.PointerEventData::get_tangentialPressure()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(PointerEventData::<tangentialPressure>k__BackingField, ldloc:PointerEventData(this)))
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
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x060005B9 RID: 1465 RVA: 0x000113FC File Offset: 0x0000F5FC
		// (set) Token: 0x060005BA RID: 1466 RVA: 0x00011410 File Offset: 0x0000F610
		public float altitudeAngle
		{
			[CompilerGenerated]
			get
			{
				/*
An exception occurred when decompiling this method (060005B9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single UnityEngine.EventSystems.PointerEventData::get_altitudeAngle()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(PointerEventData::<altitudeAngle>k__BackingField, ldloc:PointerEventData(this)))
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
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x060005BB RID: 1467 RVA: 0x00011420 File Offset: 0x0000F620
		// (set) Token: 0x060005BC RID: 1468 RVA: 0x00011434 File Offset: 0x0000F634
		public float azimuthAngle
		{
			[CompilerGenerated]
			get
			{
				/*
An exception occurred when decompiling this method (060005BB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single UnityEngine.EventSystems.PointerEventData::get_azimuthAngle()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(PointerEventData::<azimuthAngle>k__BackingField, ldloc:PointerEventData(this)))
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
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x060005BD RID: 1469 RVA: 0x00011444 File Offset: 0x0000F644
		// (set) Token: 0x060005BE RID: 1470 RVA: 0x00011458 File Offset: 0x0000F658
		public float twist
		{
			[CompilerGenerated]
			get
			{
				/*
An exception occurred when decompiling this method (060005BD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single UnityEngine.EventSystems.PointerEventData::get_twist()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(PointerEventData::<twist>k__BackingField, ldloc:PointerEventData(this)))
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
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x060005BF RID: 1471 RVA: 0x00011468 File Offset: 0x0000F668
		// (set) Token: 0x060005C0 RID: 1472 RVA: 0x00011490 File Offset: 0x0000F690
		public Vector2 radius
		{
			[CompilerGenerated]
			get
			{
				float x = this.<radius>k__BackingField.x;
				float y = this.<radius>k__BackingField.y;
				Vector2 vector;
				return vector;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x060005C1 RID: 1473 RVA: 0x000114A0 File Offset: 0x0000F6A0
		// (set) Token: 0x060005C2 RID: 1474 RVA: 0x000114C8 File Offset: 0x0000F6C8
		public Vector2 radiusVariance
		{
			[CompilerGenerated]
			get
			{
				float x = this.<radiusVariance>k__BackingField.x;
				float y = this.<radiusVariance>k__BackingField.y;
				Vector2 vector;
				return vector;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x060005C3 RID: 1475 RVA: 0x000114D8 File Offset: 0x0000F6D8
		// (set) Token: 0x060005C4 RID: 1476 RVA: 0x000114EC File Offset: 0x0000F6EC
		public bool fullyExited
		{
			[CompilerGenerated]
			get
			{
				return this.<fullyExited>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x060005C5 RID: 1477 RVA: 0x000114FC File Offset: 0x0000F6FC
		// (set) Token: 0x060005C6 RID: 1478 RVA: 0x00011510 File Offset: 0x0000F710
		public bool reentered
		{
			[CompilerGenerated]
			get
			{
				return this.<reentered>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x00011520 File Offset: 0x0000F720
		public PointerEventData(EventSystem eventSystem)
		{
			int num = 1;
			base..ctor();
			this.m_EventSystem = eventSystem;
			this.pointerId = num;
			int num2 = 1;
			this.<useDragThreshold>k__BackingField = num2 != 0;
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x0001154C File Offset: 0x0000F74C
		public bool IsPointerMoving()
		{
			/*
An exception occurred when decompiling this method (060005C8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean UnityEngine.EventSystems.PointerEventData::IsPointerMoving()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_0B, ldfld:float32(Vector2::x, ldfld:Vector2[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Vector2&](PointerEventData::<delta>k__BackingField, ldloc:PointerEventData(this))))
	stloc:float32(var_1_17, ldfld:float32(Vector2::y, ldfld:Vector2[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Vector2&](PointerEventData::<delta>k__BackingField, ldloc:PointerEventData(this))))
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

		// Token: 0x060005C9 RID: 1481 RVA: 0x00011570 File Offset: 0x0000F770
		public bool IsScrolling()
		{
			/*
An exception occurred when decompiling this method (060005C9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean UnityEngine.EventSystems.PointerEventData::IsScrolling()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_0B, ldfld:float32(Vector2::x, ldfld:Vector2[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Vector2&](PointerEventData::<scrollDelta>k__BackingField, ldloc:PointerEventData(this))))
	stloc:float32(var_1_17, ldfld:float32(Vector2::y, ldfld:Vector2[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Vector2&](PointerEventData::<scrollDelta>k__BackingField, ldloc:PointerEventData(this))))
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

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x060005CA RID: 1482 RVA: 0x00011594 File Offset: 0x0000F794
		public Camera enterEventCamera
		{
			get
			{
				/*
An exception occurred when decompiling this method (060005CA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.Camera UnityEngine.EventSystems.PointerEventData::get_enterEventCamera()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000F:
	stloc:BaseRaycaster(var_3_1C, ldfld:BaseRaycaster(RaycastResult::module, ldfld:RaycastResult[exp:valuetype UnityEngine.EventSystems.RaycastResult&](PointerEventData::<pointerCurrentRaycast>k__BackingField, ldloc:PointerEventData(this))))
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

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x060005CB RID: 1483 RVA: 0x000115C0 File Offset: 0x0000F7C0
		public Camera pressEventCamera
		{
			get
			{
				/*
An exception occurred when decompiling this method (060005CB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.Camera UnityEngine.EventSystems.PointerEventData::get_pressEventCamera()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:BaseRaycaster(var_0_0B, ldfld:BaseRaycaster(RaycastResult::module, ldfld:RaycastResult[exp:valuetype UnityEngine.EventSystems.RaycastResult&](PointerEventData::<pointerPressRaycast>k__BackingField, ldloc:PointerEventData(this))))
	stloc:BaseRaycaster(var_3_19, ldfld:BaseRaycaster(RaycastResult::module, ldfld:RaycastResult[exp:valuetype UnityEngine.EventSystems.RaycastResult&](PointerEventData::<pointerPressRaycast>k__BackingField, ldloc:PointerEventData(this))))
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

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x060005CC RID: 1484 RVA: 0x000115E8 File Offset: 0x0000F7E8
		// (set) Token: 0x060005CD RID: 1485 RVA: 0x000115FC File Offset: 0x0000F7FC
		public GameObject pointerPress
		{
			get
			{
				return this.m_PointerPress;
			}
			set
			{
				GameObject pointerPress = this.m_PointerPress;
				if (!true)
				{
				}
				bool flag = pointerPress == value;
				GameObject pointerPress2 = this.m_PointerPress;
				this.m_PointerPress = value;
				this.<lastPress>k__BackingField = pointerPress2;
			}
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x00011630 File Offset: 0x0000F830
		public override string ToString()
		{
			/*
An exception occurred when decompiling this method (060005CE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String UnityEngine.EventSystems.PointerEventData::ToString()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_005F:
	stloc:bool(var_20_65, ldfld:bool(PointerEventData::<useDragThreshold>k__BackingField, ldloc:PointerEventData(this)))
	stloc:string(var_22_73, call:string(string::Concat, ldstr:string("<b>Use Drag Threshold</b>: "), ldloc:string(var_21)))
	stloc:float32(var_30_7B, ldfld:float32(PointerEventData::<pressure>k__BackingField, ldloc:PointerEventData(this)))
	stloc:string(var_32_89, call:string(string::Concat, ldstr:string("<b>pressure</b>: "), ldloc:string(var_31)))
	stloc:float32(var_34_91, ldfld:float32(PointerEventData::<tangentialPressure>k__BackingField, ldloc:PointerEventData(this)))
	stloc:string(var_36_9F, call:string(string::Concat, ldstr:string("<b>tangentialPressure</b>: "), ldloc:string(var_35)))
	stloc:float32(var_38_A7, ldfld:float32(PointerEventData::<altitudeAngle>k__BackingField, ldloc:PointerEventData(this)))
	stloc:string(var_40_B5, call:string(string::Concat, ldstr:string("<b>altitudeAngle</b>: "), ldloc:string(var_39)))
	stloc:float32(var_42_BD, ldfld:float32(PointerEventData::<azimuthAngle>k__BackingField, ldloc:PointerEventData(this)))
	stloc:string(var_44_CB, call:string(string::Concat, ldstr:string("<b>azimuthAngle</b>: "), ldloc:string(var_43)))
	stloc:float32(var_46_D3, ldfld:float32(PointerEventData::<twist>k__BackingField, ldloc:PointerEventData(this)))
	stloc:string(var_48_E1, call:string(string::Concat, ldstr:string("<b>twist</b>: "), ldloc:string(var_47)))
	stloc:string(var_51_EF, call:string(string::Concat, ldstr:string("<b>radius</b>: "), ldloc:string(var_50)))
	stloc:string(var_54_FD, call:string(string::Concat, ldstr:string("<b>radiusVariance</b>: "), ldloc:string(var_53)))
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

		// Token: 0x0400028B RID: 651
		[CompilerGenerated]
		private GameObject <pointerEnter>k__BackingField;

		// Token: 0x0400028C RID: 652
		private GameObject m_PointerPress;

		// Token: 0x0400028D RID: 653
		[CompilerGenerated]
		private GameObject <lastPress>k__BackingField;

		// Token: 0x0400028E RID: 654
		[CompilerGenerated]
		private GameObject <rawPointerPress>k__BackingField;

		// Token: 0x0400028F RID: 655
		[CompilerGenerated]
		private GameObject <pointerDrag>k__BackingField;

		// Token: 0x04000290 RID: 656
		[CompilerGenerated]
		private GameObject <pointerClick>k__BackingField;

		// Token: 0x04000291 RID: 657
		[CompilerGenerated]
		private RaycastResult <pointerCurrentRaycast>k__BackingField;

		// Token: 0x04000292 RID: 658
		[CompilerGenerated]
		private RaycastResult <pointerPressRaycast>k__BackingField;

		// Token: 0x04000293 RID: 659
		public List<GameObject> hovered;

		// Token: 0x04000294 RID: 660
		[CompilerGenerated]
		private bool <eligibleForClick>k__BackingField;

		// Token: 0x04000295 RID: 661
		[CompilerGenerated]
		private int <pointerId>k__BackingField;

		// Token: 0x04000296 RID: 662
		[CompilerGenerated]
		private Vector2 <position>k__BackingField;

		// Token: 0x04000297 RID: 663
		[CompilerGenerated]
		private Vector2 <delta>k__BackingField;

		// Token: 0x04000298 RID: 664
		[CompilerGenerated]
		private Vector2 <pressPosition>k__BackingField;

		// Token: 0x04000299 RID: 665
		[CompilerGenerated]
		private Vector3 <worldPosition>k__BackingField;

		// Token: 0x0400029A RID: 666
		[CompilerGenerated]
		private Vector3 <worldNormal>k__BackingField;

		// Token: 0x0400029B RID: 667
		[CompilerGenerated]
		private float <clickTime>k__BackingField;

		// Token: 0x0400029C RID: 668
		[CompilerGenerated]
		private int <clickCount>k__BackingField;

		// Token: 0x0400029D RID: 669
		[CompilerGenerated]
		private Vector2 <scrollDelta>k__BackingField;

		// Token: 0x0400029E RID: 670
		[CompilerGenerated]
		private bool <useDragThreshold>k__BackingField;

		// Token: 0x0400029F RID: 671
		[CompilerGenerated]
		private bool <dragging>k__BackingField;

		// Token: 0x040002A0 RID: 672
		[CompilerGenerated]
		private PointerEventData.InputButton <button>k__BackingField;

		// Token: 0x040002A1 RID: 673
		[CompilerGenerated]
		private float <pressure>k__BackingField;

		// Token: 0x040002A2 RID: 674
		[CompilerGenerated]
		private float <tangentialPressure>k__BackingField;

		// Token: 0x040002A3 RID: 675
		[CompilerGenerated]
		private float <altitudeAngle>k__BackingField;

		// Token: 0x040002A4 RID: 676
		[CompilerGenerated]
		private float <azimuthAngle>k__BackingField;

		// Token: 0x040002A5 RID: 677
		[CompilerGenerated]
		private float <twist>k__BackingField;

		// Token: 0x040002A6 RID: 678
		[CompilerGenerated]
		private Vector2 <radius>k__BackingField;

		// Token: 0x040002A7 RID: 679
		[CompilerGenerated]
		private Vector2 <radiusVariance>k__BackingField;

		// Token: 0x040002A8 RID: 680
		[CompilerGenerated]
		private bool <fullyExited>k__BackingField;

		// Token: 0x040002A9 RID: 681
		[CompilerGenerated]
		private bool <reentered>k__BackingField;

		// Token: 0x02000094 RID: 148
		public enum InputButton
		{
			// Token: 0x040002AB RID: 683
			Left,
			// Token: 0x040002AC RID: 684
			Right,
			// Token: 0x040002AD RID: 685
			Middle
		}

		// Token: 0x02000095 RID: 149
		public enum FramePressState
		{
			// Token: 0x040002AF RID: 687
			Pressed,
			// Token: 0x040002B0 RID: 688
			Released,
			// Token: 0x040002B1 RID: 689
			PressedAndReleased,
			// Token: 0x040002B2 RID: 690
			NotChanged
		}
	}
}
