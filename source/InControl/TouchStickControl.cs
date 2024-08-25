using System;
using UnityEngine;

namespace InControl
{
	// Token: 0x02000049 RID: 73
	public class TouchStickControl : TouchControl
	{
		// Token: 0x06000377 RID: 887 RVA: 0x0000B2A8 File Offset: 0x000094A8
		public override void CreateControl()
		{
			TouchSprite touchSprite = this.ring;
			Transform transform = base.transform;
			touchSprite.Create("Ring", transform, 1000);
			TouchSprite touchSprite2 = this.knob;
			Transform transform2 = base.transform;
			touchSprite2.Create("Knob", transform2, 1001);
		}

		// Token: 0x06000378 RID: 888 RVA: 0x0000B2F4 File Offset: 0x000094F4
		public override void DestroyControl()
		{
			this.ring.Delete();
			this.knob.Delete();
			if (this.currentTouch != null)
			{
			}
		}

		// Token: 0x06000379 RID: 889 RVA: 0x0000B320 File Offset: 0x00009520
		public override void ConfigureControl()
		{
			float x = this.offset.x;
			float y = this.offset.y;
			TouchControlAnchor touchControlAnchor = this.anchor;
			Vector2 vector = this.offset;
			this.resetPosition.x = x;
			this.resetPosition.y = y;
			Transform transform = base.transform;
			float x2 = this.resetPosition.x;
			float y2 = this.resetPosition.y;
			float z = this.resetPosition.z;
			this.ring.Update(true);
			this.knob.Update(true);
			float xmin = this.activeArea.m_XMin;
			float ymin = this.activeArea.m_YMin;
			float width = this.activeArea.m_Width;
			float height = this.activeArea.m_Height;
			TouchUnitType touchUnitType = this.areaUnitType;
			TouchSprite touchSprite = this.knob;
			this.worldActiveArea.m_XMin = xmin;
			this.worldActiveArea.m_YMin = ymin;
			this.worldActiveArea.m_Width = width;
			this.worldActiveArea.m_Height = height;
			float num = this.knobRange;
			TouchUnitType sizeUnitType = touchSprite.sizeUnitType;
			float pixelToWorld = TouchManager.PixelToWorld;
		}

		// Token: 0x0600037A RID: 890 RVA: 0x0000B454 File Offset: 0x00009654
		public override void DrawGizmos()
		{
			TouchSprite touchSprite = this.ring;
			Vector3 ringPosition = this.RingPosition;
			TouchSprite touchSprite2 = this.knob;
			Vector3 knobPosition = this.KnobPosition;
			Vector3 ringPosition2 = this.RingPosition;
			float num = this.worldKnobRange;
			float xmin = this.worldActiveArea.m_XMin;
			float ymin = this.worldActiveArea.m_YMin;
			float width = this.worldActiveArea.m_Width;
			float height = this.worldActiveArea.m_Height;
		}

		// Token: 0x0600037B RID: 891 RVA: 0x0000B4C8 File Offset: 0x000096C8
		private void Update()
		{
			if (this.dirty)
			{
				return;
			}
			TouchSprite touchSprite = this.ring;
			long num = 0L;
			touchSprite.Update(num != 0L);
			TouchSprite touchSprite2 = this.knob;
			long num2 = 0L;
			touchSprite2.Update(num2 != 0L);
			Touch touch = this.currentTouch;
			if (this.resetWhenDone)
			{
				Vector3 knobPosition = this.KnobPosition;
				float x = this.resetPosition.x;
				float y = this.resetPosition.y;
				float z = this.resetPosition.z;
				Vector3 knobPosition2 = this.KnobPosition;
				Vector3 ringPosition = this.RingPosition;
				Vector3 ringPosition2 = this.RingPosition;
				float num3 = this.ringResetSpeed;
				float x2 = this.resetPosition.x;
				float y2 = this.resetPosition.y;
				float z2 = this.resetPosition.z;
				float unscaledDeltaTime = Time.unscaledDeltaTime;
				if (!true)
				{
				}
				if (this.ring.<Ready>k__BackingField)
				{
				}
				Vector3 ringPosition3 = this.RingPosition;
				if (this.knob.<Ready>k__BackingField)
				{
				}
			}
			Vector3 knobPosition3 = this.KnobPosition;
			Vector3 ringPosition4 = this.RingPosition;
			Vector3 ringPosition5 = this.RingPosition;
			float num4 = this.knobResetSpeed;
			float unscaledDeltaTime2 = Time.unscaledDeltaTime;
			if (!true)
			{
			}
			if (this.knob.<Ready>k__BackingField)
			{
				return;
			}
		}

		// Token: 0x0600037C RID: 892 RVA: 0x0000B5F4 File Offset: 0x000097F4
		public override void SubmitControlState(ulong updateTick, float deltaTime)
		{
			TouchControl.AnalogTarget analogTarget = this.target;
			float x = this.value.x;
			float y = this.value.y;
			float num = this.lowerDeadZone;
			float num2 = this.upperDeadZone;
		}

		// Token: 0x0600037D RID: 893 RVA: 0x0000B630 File Offset: 0x00009830
		public override void CommitControlState(ulong updateTick, float deltaTime)
		{
			TouchControl.AnalogTarget analogTarget = this.target;
			base.CommitAnalog(analogTarget);
		}

		// Token: 0x0600037E RID: 894 RVA: 0x0000B64C File Offset: 0x0000984C
		public override void TouchBegan(Touch touch)
		{
			if (this.currentTouch != null)
			{
				return;
			}
			float x = touch.position.x;
			float y = touch.position.y;
			this.beganPosition.x = x;
			this.beganPosition.y = y;
			TouchSprite touchSprite = this.ring;
			float x2 = this.beganPosition.x;
			float y2 = this.beganPosition.y;
			if (this.snapToInitialTouch)
			{
				if (this.ring.<Ready>k__BackingField)
				{
					float x3 = this.beganPosition.x;
					float y3 = this.beganPosition.y;
					float z = this.beganPosition.z;
				}
				if (this.knob.<Ready>k__BackingField)
				{
					float x4 = this.beganPosition.x;
					float y4 = this.beganPosition.y;
					float z2 = this.beganPosition.z;
					return;
				}
			}
			else
			{
				float x5;
				float y5;
				float z3;
				if (this.knob.<Ready>k__BackingField)
				{
					x5 = this.beganPosition.x;
					y5 = this.beganPosition.y;
					z3 = this.beganPosition.z;
				}
				Vector3 ringPosition = this.RingPosition;
				this.beganPosition.x = x5;
				this.beganPosition.y = y5;
				this.beganPosition.z = z3;
			}
			this.currentTouch = touch;
			if (touch == null)
			{
				return;
			}
			TouchSprite touchSprite2 = this.ring;
			bool state = touchSprite2.state;
			int num = 257;
			touchSprite2.state = num != 0;
			TouchSprite touchSprite3 = this.knob;
			bool state2 = touchSprite3.state;
			int num2 = 257;
			touchSprite3.state = num2 != 0;
		}

		// Token: 0x0600037F RID: 895 RVA: 0x0000B7E4 File Offset: 0x000099E4
		public override void TouchMoved(Touch touch)
		{
			Touch touch2 = this.currentTouch;
			float x = touch.position.x;
			float y = touch.position.y;
			LockAxis lockAxis = this.lockToAxis;
			this.movedPosition.x = x;
			this.movedPosition.y = y;
			DragAxis dragAxis = this.allowDraggingAxis;
			float y2 = this.beganPosition.y;
			this.movedPosition.y = y2;
		}

		// Token: 0x06000380 RID: 896 RVA: 0x0000BAB4 File Offset: 0x00009CB4
		public override void TouchEnded(Touch touch)
		{
			Touch touch2 = this.currentTouch;
			float x = this.resetPosition.x;
			float y = this.resetPosition.y;
			float z = this.resetPosition.z;
			Vector3 ringPosition = this.RingPosition;
			if (!true)
			{
			}
			float num = this.resetDuration;
			if (!true)
			{
			}
			float num2 = this.resetDuration;
			Vector3 ringPosition2 = this.RingPosition;
			Vector3 knobPosition = this.KnobPosition;
			if (!true)
			{
			}
			float num3 = this.resetDuration;
			if (!true)
			{
			}
			float num4 = this.knobRange;
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000381 RID: 897 RVA: 0x0000BB84 File Offset: 0x00009D84
		public bool IsActive
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000381)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean InControl.TouchStickControl::get_IsActive()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Touch(var_0_06, ldfld:Touch(TouchStickControl::currentTouch, ldloc:TouchStickControl(this)))
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

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000382 RID: 898 RVA: 0x0000BB98 File Offset: 0x00009D98
		public bool IsNotActive
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000382)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean InControl.TouchStickControl::get_IsNotActive()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Touch(var_0_06, ldfld:Touch(TouchStickControl::currentTouch, ldloc:TouchStickControl(this)))
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

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000383 RID: 899 RVA: 0x0000BBAC File Offset: 0x00009DAC
		// (set) Token: 0x06000384 RID: 900 RVA: 0x0000BBD8 File Offset: 0x00009DD8
		public Vector3 RingPosition
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000383)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.Vector3 InControl.TouchStickControl::get_RingPosition()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0016:
	stloc:Vector3(var_3_1C, callgetter:Vector3(Transform::get_position, ldloc:Transform(var_2)))
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
			set
			{
				TouchSprite touchSprite = this.ring;
				if (touchSprite.<Ready>k__BackingField)
				{
					touchSprite.Position = value;
					return;
				}
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000385 RID: 901 RVA: 0x0000BBFC File Offset: 0x00009DFC
		// (set) Token: 0x06000386 RID: 902 RVA: 0x0000BC28 File Offset: 0x00009E28
		public Vector3 KnobPosition
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000385)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.Vector3 InControl.TouchStickControl::get_KnobPosition()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0016:
	stloc:Vector3(var_3_1C, callgetter:Vector3(Transform::get_position, ldloc:Transform(var_2)))
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
			set
			{
				TouchSprite touchSprite = this.knob;
				if (touchSprite.<Ready>k__BackingField)
				{
					touchSprite.Position = value;
					return;
				}
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000387 RID: 903 RVA: 0x0000BC4C File Offset: 0x00009E4C
		// (set) Token: 0x06000388 RID: 904 RVA: 0x0000BC60 File Offset: 0x00009E60
		public TouchControlAnchor Anchor
		{
			get
			{
				return this.anchor;
			}
			set
			{
				TouchControlAnchor touchControlAnchor = this.anchor;
				this.anchor = value;
				this.dirty = true;
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000389 RID: 905 RVA: 0x0000BC84 File Offset: 0x00009E84
		// (set) Token: 0x0600038A RID: 906 RVA: 0x0000BCAC File Offset: 0x00009EAC
		public Vector2 Offset
		{
			get
			{
				float x = this.offset.x;
				float y = this.offset.y;
				Vector2 vector;
				return vector;
			}
			set
			{
				float x = this.offset.x;
				float y = this.offset.y;
				this.dirty = true;
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x0600038B RID: 907 RVA: 0x0000BCD8 File Offset: 0x00009ED8
		// (set) Token: 0x0600038C RID: 908 RVA: 0x0000BCEC File Offset: 0x00009EEC
		public TouchUnitType OffsetUnitType
		{
			get
			{
				return this.offsetUnitType;
			}
			set
			{
				TouchUnitType touchUnitType = this.offsetUnitType;
				this.offsetUnitType = value;
				this.dirty = true;
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x0600038D RID: 909 RVA: 0x0000BD10 File Offset: 0x00009F10
		// (set) Token: 0x0600038E RID: 910 RVA: 0x0000BD4C File Offset: 0x00009F4C
		public Rect ActiveArea
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600038D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.Rect InControl.TouchStickControl::get_ActiveArea()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_0B, ldfld:float32(Rect::m_XMin, ldfld:Rect[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Rect&](TouchStickControl::activeArea, ldloc:TouchStickControl(this))))
	stloc:float32(var_1_17, ldfld:float32(Rect::m_YMin, ldfld:Rect[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Rect&](TouchStickControl::activeArea, ldloc:TouchStickControl(this))))
	stloc:float32(var_2_23, ldfld:float32(Rect::m_Width, ldfld:Rect[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Rect&](TouchStickControl::activeArea, ldloc:TouchStickControl(this))))
	stloc:float32(var_3_2F, ldfld:float32(Rect::m_Height, ldfld:Rect[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Rect&](TouchStickControl::activeArea, ldloc:TouchStickControl(this))))
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
			set
			{
				float xmin = this.activeArea.m_XMin;
				float ymin = this.activeArea.m_YMin;
				float width = this.activeArea.m_Width;
				float height = this.activeArea.m_Height;
				this.dirty = true;
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x0600038F RID: 911 RVA: 0x0000BD94 File Offset: 0x00009F94
		// (set) Token: 0x06000390 RID: 912 RVA: 0x0000BDA8 File Offset: 0x00009FA8
		public TouchUnitType AreaUnitType
		{
			get
			{
				return this.areaUnitType;
			}
			set
			{
				TouchUnitType touchUnitType = this.areaUnitType;
				this.areaUnitType = value;
				this.dirty = true;
			}
		}

		// Token: 0x06000391 RID: 913 RVA: 0x0000BDCC File Offset: 0x00009FCC
		public TouchStickControl()
		{
			AnimationCurve animationCurve;
			this.inputCurve = animationCurve;
			this.snapToInitialTouch = 257 != 0;
			this.resetDuration = (float)52429;
			this.knobRange = (float)16624;
			base..ctor();
		}

		// Token: 0x04000302 RID: 770
		[Header("Position")]
		[SerializeField]
		private TouchControlAnchor anchor = TouchControlAnchor.BottomLeft;

		// Token: 0x04000303 RID: 771
		[SerializeField]
		private TouchUnitType offsetUnitType;

		// Token: 0x04000304 RID: 772
		[SerializeField]
		private Vector2 offset;

		// Token: 0x04000305 RID: 773
		[SerializeField]
		private TouchUnitType areaUnitType;

		// Token: 0x04000306 RID: 774
		[SerializeField]
		private Rect activeArea;

		// Token: 0x04000307 RID: 775
		[Header("Options")]
		public TouchControl.AnalogTarget target = TouchControl.AnalogTarget.LeftStick;

		// Token: 0x04000308 RID: 776
		public TouchControl.SnapAngles snapAngles;

		// Token: 0x04000309 RID: 777
		public LockAxis lockToAxis;

		// Token: 0x0400030A RID: 778
		[Range(0f, 1f)]
		public float lowerDeadZone;

		// Token: 0x0400030B RID: 779
		[Range(0f, 1f)]
		public float upperDeadZone;

		// Token: 0x0400030C RID: 780
		public AnimationCurve inputCurve;

		// Token: 0x0400030D RID: 781
		public bool allowDragging;

		// Token: 0x0400030E RID: 782
		public DragAxis allowDraggingAxis;

		// Token: 0x0400030F RID: 783
		public bool snapToInitialTouch;

		// Token: 0x04000310 RID: 784
		public bool resetWhenDone;

		// Token: 0x04000311 RID: 785
		public float resetDuration;

		// Token: 0x04000312 RID: 786
		[Header("Sprites")]
		public TouchSprite ring;

		// Token: 0x04000313 RID: 787
		public TouchSprite knob;

		// Token: 0x04000314 RID: 788
		public float knobRange;

		// Token: 0x04000315 RID: 789
		private Vector3 resetPosition;

		// Token: 0x04000316 RID: 790
		private Vector3 beganPosition;

		// Token: 0x04000317 RID: 791
		private Vector3 movedPosition;

		// Token: 0x04000318 RID: 792
		private float ringResetSpeed;

		// Token: 0x04000319 RID: 793
		private float knobResetSpeed;

		// Token: 0x0400031A RID: 794
		private Rect worldActiveArea;

		// Token: 0x0400031B RID: 795
		private float worldKnobRange;

		// Token: 0x0400031C RID: 796
		private Vector3 value;

		// Token: 0x0400031D RID: 797
		private Touch currentTouch;

		// Token: 0x0400031E RID: 798
		private bool dirty;
	}
}
