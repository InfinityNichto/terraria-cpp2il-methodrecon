using System;
using UnityEngine;

namespace InControl
{
	// Token: 0x0200004A RID: 74
	public class TouchSwipeControl : TouchControl
	{
		// Token: 0x06000392 RID: 914 RVA: 0x0000BE18 File Offset: 0x0000A018
		public override void CreateControl()
		{
		}

		// Token: 0x06000393 RID: 915 RVA: 0x0000BE28 File Offset: 0x0000A028
		public override void DestroyControl()
		{
			if (this.currentTouch != null)
			{
			}
		}

		// Token: 0x06000394 RID: 916 RVA: 0x0000BE40 File Offset: 0x0000A040
		public override void ConfigureControl()
		{
			float xmin = this.activeArea.m_XMin;
			float ymin = this.activeArea.m_YMin;
			float width = this.activeArea.m_Width;
			float height = this.activeArea.m_Height;
			TouchUnitType touchUnitType = this.areaUnitType;
			this.worldActiveArea.m_Width = width;
			this.worldActiveArea.m_Height = height;
		}

		// Token: 0x06000395 RID: 917 RVA: 0x0000BEA0 File Offset: 0x0000A0A0
		public override void DrawGizmos()
		{
			float xmin = this.worldActiveArea.m_XMin;
			float ymin = this.worldActiveArea.m_YMin;
			float width = this.worldActiveArea.m_Width;
			float height = this.worldActiveArea.m_Height;
			if (!true)
			{
			}
		}

		// Token: 0x06000396 RID: 918 RVA: 0x0000BEE4 File Offset: 0x0000A0E4
		private void Update()
		{
			if (this.dirty)
			{
			}
		}

		// Token: 0x06000397 RID: 919 RVA: 0x0000BEFC File Offset: 0x0000A0FC
		public override void SubmitControlState(ulong updateTick, float deltaTime)
		{
			float x = this.currentVector.x;
			float y = this.currentVector.y;
			TouchControl.SnapAngles snapAngles = this.snapAngles;
			TouchControl.AnalogTarget analogTarget = this.target;
			bool flag = this.fireButtonTarget;
			TouchControl.ButtonTarget buttonTarget = this.upTarget;
			if (flag)
			{
				TouchControl.ButtonTarget buttonTarget2 = this.nextButtonTarget;
				return;
			}
			bool flag2 = this.fireButtonTarget;
			TouchControl.ButtonTarget buttonTarget3 = this.downTarget;
			if (flag2)
			{
				TouchControl.ButtonTarget buttonTarget4 = this.nextButtonTarget;
				return;
			}
			bool flag3 = this.fireButtonTarget;
			TouchControl.ButtonTarget buttonTarget5 = this.leftTarget;
			if (flag3)
			{
				TouchControl.ButtonTarget buttonTarget6 = this.nextButtonTarget;
				return;
			}
			bool flag4 = this.fireButtonTarget;
			TouchControl.ButtonTarget buttonTarget7 = this.rightTarget;
			if (flag4)
			{
				TouchControl.ButtonTarget buttonTarget8 = this.nextButtonTarget;
				return;
			}
			bool flag5 = this.fireButtonTarget;
			TouchControl.ButtonTarget buttonTarget9 = this.tapTarget;
			if (flag5)
			{
				TouchControl.ButtonTarget buttonTarget10 = this.nextButtonTarget;
				return;
			}
			if (this.fireButtonTarget)
			{
				TouchControl.ButtonTarget buttonTarget11 = this.nextButtonTarget;
				if (buttonTarget11 != TouchControl.ButtonTarget.None)
				{
					bool flag6 = this.oneSwipePerTouch;
					this.dirty = buttonTarget11 != TouchControl.ButtonTarget.None;
					this.fireButtonTarget = flag6;
				}
			}
		}

		// Token: 0x06000398 RID: 920 RVA: 0x0000BFFC File Offset: 0x0000A1FC
		public override void CommitControlState(ulong updateTick, float deltaTime)
		{
			TouchControl.AnalogTarget analogTarget = this.target;
			base.CommitAnalog(analogTarget);
			TouchControl.ButtonTarget buttonTarget = this.upTarget;
			base.CommitButton(buttonTarget);
			TouchControl.ButtonTarget buttonTarget2 = this.downTarget;
			base.CommitButton(buttonTarget2);
			TouchControl.ButtonTarget buttonTarget3 = this.leftTarget;
			base.CommitButton(buttonTarget3);
			TouchControl.ButtonTarget buttonTarget4 = this.rightTarget;
			base.CommitButton(buttonTarget4);
			TouchControl.ButtonTarget buttonTarget5 = this.tapTarget;
			base.CommitButton(buttonTarget5);
		}

		// Token: 0x06000399 RID: 921 RVA: 0x0000C064 File Offset: 0x0000A264
		public override void TouchBegan(Touch touch)
		{
			if (this.currentTouch == null)
			{
				float x = touch.position.x;
				float y = touch.position.y;
				this.beganPosition.x = x;
				this.beganPosition.y = y;
				Vector3 vector = this.beganPosition;
				float z = this.beganPosition.z;
				this.currentTouch = touch;
				this.lastPosition.z = z;
				int num = 1;
				this.fireButtonTarget = num != 0;
			}
		}

		// Token: 0x0600039A RID: 922 RVA: 0x0000C0E0 File Offset: 0x0000A2E0
		public override void TouchMoved(Touch touch)
		{
			Touch touch2 = this.currentTouch;
			float x = touch.position.x;
			float y = touch.position.y;
			float x2 = this.lastPosition.x;
			float y2 = this.lastPosition.y;
			float z = this.lastPosition.z;
			if (!true)
			{
			}
			float num = this.sensitivity;
			if (!this.oneSwipePerTouch || !this.currentVectorIsSet)
			{
				if (!true)
				{
				}
				return;
			}
			if (this.fireButtonTarget)
			{
				float x3 = this.currentVector.x;
				float y3 = this.currentVector.y;
				TouchControl.ButtonTarget buttonTarget = this.lastButtonTarget;
				TouchControl.ButtonTarget buttonTarget2;
				this.nextButtonTarget = buttonTarget2;
			}
		}

		// Token: 0x0600039B RID: 923 RVA: 0x0000C1A4 File Offset: 0x0000A3A4
		public override void TouchEnded(Touch touch)
		{
			Touch touch2 = this.currentTouch;
			float x = touch.position.x;
			float y = touch.position.y;
			float x2 = this.beganPosition.x;
			float y2 = this.beganPosition.y;
			float z = this.beganPosition.z;
			float num = this.sensitivity;
			TouchControl.ButtonTarget buttonTarget = this.tapTarget;
			this.fireButtonTarget = true;
		}

		// Token: 0x0600039C RID: 924 RVA: 0x0000C21C File Offset: 0x0000A41C
		private TouchControl.ButtonTarget GetButtonTargetForVector(Vector2 vector)
		{
			return this.upTarget;
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x0600039D RID: 925 RVA: 0x0000C248 File Offset: 0x0000A448
		// (set) Token: 0x0600039E RID: 926 RVA: 0x0000C284 File Offset: 0x0000A484
		public Rect ActiveArea
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600039D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.Rect InControl.TouchSwipeControl::get_ActiveArea()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_0B, ldfld:float32(Rect::m_XMin, ldfld:Rect[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Rect&](TouchSwipeControl::activeArea, ldloc:TouchSwipeControl(this))))
	stloc:float32(var_1_17, ldfld:float32(Rect::m_YMin, ldfld:Rect[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Rect&](TouchSwipeControl::activeArea, ldloc:TouchSwipeControl(this))))
	stloc:float32(var_2_23, ldfld:float32(Rect::m_Width, ldfld:Rect[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Rect&](TouchSwipeControl::activeArea, ldloc:TouchSwipeControl(this))))
	stloc:float32(var_3_2F, ldfld:float32(Rect::m_Height, ldfld:Rect[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Rect&](TouchSwipeControl::activeArea, ldloc:TouchSwipeControl(this))))
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

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x0600039F RID: 927 RVA: 0x0000C2CC File Offset: 0x0000A4CC
		// (set) Token: 0x060003A0 RID: 928 RVA: 0x0000C2E0 File Offset: 0x0000A4E0
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

		// Token: 0x060003A1 RID: 929 RVA: 0x0000C304 File Offset: 0x0000A504
		public TouchSwipeControl()
		{
		}

		// Token: 0x0400031F RID: 799
		[Header("Position")]
		[SerializeField]
		private TouchUnitType areaUnitType;

		// Token: 0x04000320 RID: 800
		[SerializeField]
		private Rect activeArea;

		// Token: 0x04000321 RID: 801
		[Header("Options")]
		[Range(0f, 1f)]
		public float sensitivity = (float)52429;

		// Token: 0x04000322 RID: 802
		public bool oneSwipePerTouch;

		// Token: 0x04000323 RID: 803
		[Header("Analog Target")]
		public TouchControl.AnalogTarget target;

		// Token: 0x04000324 RID: 804
		public TouchControl.SnapAngles snapAngles;

		// Token: 0x04000325 RID: 805
		[Header("Button Targets")]
		public TouchControl.ButtonTarget upTarget;

		// Token: 0x04000326 RID: 806
		public TouchControl.ButtonTarget downTarget;

		// Token: 0x04000327 RID: 807
		public TouchControl.ButtonTarget leftTarget;

		// Token: 0x04000328 RID: 808
		public TouchControl.ButtonTarget rightTarget;

		// Token: 0x04000329 RID: 809
		public TouchControl.ButtonTarget tapTarget;

		// Token: 0x0400032A RID: 810
		private Rect worldActiveArea;

		// Token: 0x0400032B RID: 811
		private Vector3 currentVector;

		// Token: 0x0400032C RID: 812
		private bool currentVectorIsSet;

		// Token: 0x0400032D RID: 813
		private Vector3 beganPosition;

		// Token: 0x0400032E RID: 814
		private Vector3 lastPosition;

		// Token: 0x0400032F RID: 815
		private Touch currentTouch;

		// Token: 0x04000330 RID: 816
		private bool fireButtonTarget;

		// Token: 0x04000331 RID: 817
		private TouchControl.ButtonTarget nextButtonTarget;

		// Token: 0x04000332 RID: 818
		private TouchControl.ButtonTarget lastButtonTarget;

		// Token: 0x04000333 RID: 819
		private bool dirty;
	}
}
