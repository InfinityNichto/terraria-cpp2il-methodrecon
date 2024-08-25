using System;
using UnityEngine;

namespace InControl
{
	// Token: 0x0200004B RID: 75
	public class TouchTrackControl : TouchControl
	{
		// Token: 0x060003A2 RID: 930 RVA: 0x0000C324 File Offset: 0x0000A524
		public override void CreateControl()
		{
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x0000C334 File Offset: 0x0000A534
		public override void DestroyControl()
		{
			if (this.currentTouch != null)
			{
			}
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x0000C34C File Offset: 0x0000A54C
		public override void ConfigureControl()
		{
			float xmin = this.activeArea.m_XMin;
			float ymin = this.activeArea.m_YMin;
			float width = this.activeArea.m_Width;
			float height = this.activeArea.m_Height;
			TouchUnitType touchUnitType = this.areaUnitType;
			this.worldActiveArea.m_XMin = xmin;
			this.worldActiveArea.m_YMin = ymin;
			this.worldActiveArea.m_Width = width;
			this.worldActiveArea.m_Height = height;
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x0000C3C4 File Offset: 0x0000A5C4
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

		// Token: 0x060003A6 RID: 934 RVA: 0x0000C408 File Offset: 0x0000A608
		private void OnValidate()
		{
			float num = this.maxTapDuration;
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x0000C41C File Offset: 0x0000A61C
		private void Update()
		{
			if (this.dirty)
			{
			}
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x0000C434 File Offset: 0x0000A634
		public override void SubmitControlState(ulong updateTick, float deltaTime)
		{
			float x = this.lastPosition.x;
			float num = this.scale;
			TouchControl.AnalogTarget analogTarget = this.target;
			float z = this.thisPosition.z;
			TouchControl.ButtonTarget buttonTarget = this.tapTarget;
			bool flag = this.fireButtonTarget;
			this.lastPosition.z = z;
			base.SubmitButtonState(buttonTarget, flag, updateTick, deltaTime);
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x0000C490 File Offset: 0x0000A690
		public override void CommitControlState(ulong updateTick, float deltaTime)
		{
			TouchControl.AnalogTarget analogTarget = this.target;
			base.CommitAnalog(analogTarget);
			TouchControl.ButtonTarget buttonTarget = this.tapTarget;
			base.CommitButton(buttonTarget);
		}

		// Token: 0x060003AA RID: 938 RVA: 0x0000C4BC File Offset: 0x0000A6BC
		public override void TouchBegan(Touch touch)
		{
			if (this.currentTouch == null)
			{
				float x = touch.position.x;
				float y = touch.position.y;
				this.beganPosition.x = x;
				this.beganPosition.y = y;
				float x2 = touch.position.x;
				float y2 = touch.position.y;
				int num = 17096;
				this.thisPosition.x = x2;
				this.thisPosition.y = y2;
				float z = this.thisPosition.z;
				this.currentTouch = touch;
				this.lastPosition = num;
				this.lastPosition.z = z;
				float realtimeSinceStartup = Time.realtimeSinceStartup;
				this.beganTime = x2;
			}
		}

		// Token: 0x060003AB RID: 939 RVA: 0x0000C57C File Offset: 0x0000A77C
		public override void TouchMoved(Touch touch)
		{
			Touch touch2 = this.currentTouch;
			float x = touch.position.x;
			float y = touch.position.y;
			this.thisPosition.x = x;
			this.thisPosition.y = y;
		}

		// Token: 0x060003AC RID: 940 RVA: 0x0000C5C0 File Offset: 0x0000A7C0
		public override void TouchEnded(Touch touch)
		{
			Touch touch2 = this.currentTouch;
			float x = touch.position.x;
			float y = touch.position.y;
			float x2 = this.beganPosition.x;
			float y2 = this.beganPosition.y;
			float z = this.beganPosition.z;
			float realtimeSinceStartup = Time.realtimeSinceStartup;
			float num = this.beganTime;
			float num2 = this.maxTapMovement;
			float num3 = this.maxTapDuration;
			if (this.tapTarget != TouchControl.ButtonTarget.None)
			{
				this.fireButtonTarget = true;
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x060003AD RID: 941 RVA: 0x0000C644 File Offset: 0x0000A844
		// (set) Token: 0x060003AE RID: 942 RVA: 0x0000C680 File Offset: 0x0000A880
		public Rect ActiveArea
		{
			get
			{
				/*
An exception occurred when decompiling this method (060003AD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.Rect InControl.TouchTrackControl::get_ActiveArea()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_0B, ldfld:float32(Rect::m_XMin, ldfld:Rect[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Rect&](TouchTrackControl::activeArea, ldloc:TouchTrackControl(this))))
	stloc:float32(var_1_17, ldfld:float32(Rect::m_YMin, ldfld:Rect[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Rect&](TouchTrackControl::activeArea, ldloc:TouchTrackControl(this))))
	stloc:float32(var_2_23, ldfld:float32(Rect::m_Width, ldfld:Rect[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Rect&](TouchTrackControl::activeArea, ldloc:TouchTrackControl(this))))
	stloc:float32(var_3_2F, ldfld:float32(Rect::m_Height, ldfld:Rect[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Rect&](TouchTrackControl::activeArea, ldloc:TouchTrackControl(this))))
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
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x060003AF RID: 943 RVA: 0x0000C6C0 File Offset: 0x0000A8C0
		// (set) Token: 0x060003B0 RID: 944 RVA: 0x0000C6D4 File Offset: 0x0000A8D4
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

		// Token: 0x060003B1 RID: 945 RVA: 0x0000C6F8 File Offset: 0x0000A8F8
		public TouchTrackControl()
		{
		}

		// Token: 0x04000334 RID: 820
		[Header("Dimensions")]
		[SerializeField]
		private TouchUnitType areaUnitType;

		// Token: 0x04000335 RID: 821
		[SerializeField]
		private Rect activeArea;

		// Token: 0x04000336 RID: 822
		[Header("Analog Target")]
		public TouchControl.AnalogTarget target;

		// Token: 0x04000337 RID: 823
		public float scale;

		// Token: 0x04000338 RID: 824
		[Header("Button Target")]
		public TouchControl.ButtonTarget tapTarget;

		// Token: 0x04000339 RID: 825
		public float maxTapDuration;

		// Token: 0x0400033A RID: 826
		public float maxTapMovement;

		// Token: 0x0400033B RID: 827
		private Rect worldActiveArea;

		// Token: 0x0400033C RID: 828
		private Vector3 lastPosition;

		// Token: 0x0400033D RID: 829
		private Vector3 thisPosition;

		// Token: 0x0400033E RID: 830
		private Touch currentTouch;

		// Token: 0x0400033F RID: 831
		private bool dirty;

		// Token: 0x04000340 RID: 832
		private bool fireButtonTarget;

		// Token: 0x04000341 RID: 833
		private float beganTime;

		// Token: 0x04000342 RID: 834
		private Vector3 beganPosition;
	}
}
