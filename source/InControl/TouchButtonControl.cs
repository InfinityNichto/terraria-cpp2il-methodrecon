using System;
using UnityEngine;

namespace InControl
{
	// Token: 0x02000046 RID: 70
	public class TouchButtonControl : TouchControl
	{
		// Token: 0x06000362 RID: 866 RVA: 0x0000ADEC File Offset: 0x00008FEC
		public override void CreateControl()
		{
			TouchSprite touchSprite = this.button;
			Transform transform = base.transform;
		}

		// Token: 0x06000363 RID: 867 RVA: 0x0000AE08 File Offset: 0x00009008
		public override void DestroyControl()
		{
			this.button.Delete();
			if (this.currentTouch != null)
			{
			}
		}

		// Token: 0x06000364 RID: 868 RVA: 0x0000AE28 File Offset: 0x00009028
		public override void ConfigureControl()
		{
			Transform transform = base.transform;
			float x = this.offset.x;
			float y = this.offset.y;
			TouchControlAnchor touchControlAnchor = this.anchor;
			Vector2 vector = this.offset;
			bool flag = this.lockAspectRatio;
			this.button.Update(true);
		}

		// Token: 0x06000365 RID: 869 RVA: 0x0000AE78 File Offset: 0x00009078
		public override void DrawGizmos()
		{
			TouchSprite touchSprite = this.button;
			Vector3 buttonPosition = this.ButtonPosition;
		}

		// Token: 0x06000366 RID: 870 RVA: 0x0000AE94 File Offset: 0x00009094
		private void Update()
		{
			if (this.dirty)
			{
				return;
			}
			TouchSprite touchSprite = this.button;
			long num = 0L;
			touchSprite.Update(num != 0L);
		}

		// Token: 0x06000367 RID: 871 RVA: 0x0000AEBC File Offset: 0x000090BC
		public override void SubmitControlState(ulong updateTick, float deltaTime)
		{
			Touch touch;
			int num;
			for (;;)
			{
				bool flag = this.pressureSensitive;
				touch = this.currentTouch;
				if (flag)
				{
					if (touch != null)
					{
						break;
					}
					if (this.allowSlideToggle)
					{
						goto Block_3;
					}
				}
				else
				{
					if (num != 0)
					{
						goto Block_2;
					}
					if (this.allowSlideToggle)
					{
						goto Block_4;
					}
				}
			}
			float maximumPossiblePressure = touch.maximumPossiblePressure;
			float pressure = touch.pressure;
			bool flag2 = this.buttonState;
			TouchSprite touchSprite = this.button;
			this.buttonState = false;
			bool state = touchSprite.state;
			touchSprite.state = false;
			num = 1;
			touchSprite.<Dirty>k__BackingField = num != 0;
			TouchControl.ButtonTarget buttonTarget = this.target;
			return;
			Block_2:
			TouchControl.ButtonTarget buttonTarget2 = this.target;
			bool flag3 = this.buttonState;
			return;
			Block_3:
			int touchCount = TouchManager.TouchCount;
			Touch touch2 = TouchManager.GetTouch(0);
			TouchSprite touchSprite2 = this.button;
			bool flag4 = touchSprite2.Contains(touch2);
			float maximumPossiblePressure2 = touch2.maximumPossiblePressure;
			float pressure2 = touch2.pressure;
			if (touchSprite2 == null)
			{
			}
			float num2 = Utility.Max(deltaTime, deltaTime);
			return;
			Block_4:
			if (this.buttonState)
			{
				TouchSprite touchSprite3 = this.button;
				if (touchSprite3.state)
				{
					int num3 = 256;
					touchSprite3.state = num3 != 0;
				}
			}
			int touchCount2 = TouchManager.TouchCount;
			bool flag5 = this.buttonState;
		}

		// Token: 0x06000368 RID: 872 RVA: 0x0000B024 File Offset: 0x00009224
		public override void CommitControlState(ulong updateTick, float deltaTime)
		{
			TouchControl.ButtonTarget buttonTarget = this.target;
			base.CommitButton(buttonTarget);
		}

		// Token: 0x06000369 RID: 873 RVA: 0x0000B040 File Offset: 0x00009240
		public override void TouchBegan(Touch touch)
		{
			if (this.currentTouch == null)
			{
				bool flag = this.button.Contains(touch);
				bool flag2 = this.buttonState;
				TouchSprite touchSprite = this.button;
				this.buttonState = true;
				bool state = touchSprite.state;
				touchSprite.state = 257 != 0;
				this.currentTouch = touch;
			}
		}

		// Token: 0x0600036A RID: 874 RVA: 0x0000B090 File Offset: 0x00009290
		public override void TouchMoved(Touch touch)
		{
			Touch touch2 = this.currentTouch;
		}

		// Token: 0x0600036B RID: 875 RVA: 0x0000B0DC File Offset: 0x000092DC
		public override void TouchEnded(Touch touch)
		{
			Touch touch2 = this.currentTouch;
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x0600036C RID: 876 RVA: 0x0000B114 File Offset: 0x00009314
		// (set) Token: 0x0600036D RID: 877 RVA: 0x0000B128 File Offset: 0x00009328
		private bool ButtonState
		{
			get
			{
				return this.buttonState;
			}
			set
			{
				bool flag = this.buttonState;
				TouchSprite touchSprite = this.button;
				bool state = touchSprite.state;
				touchSprite.<Dirty>k__BackingField = true;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x0600036E RID: 878 RVA: 0x0000B154 File Offset: 0x00009354
		// (set) Token: 0x0600036F RID: 879 RVA: 0x0000B180 File Offset: 0x00009380
		public Vector3 ButtonPosition
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600036E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.Vector3 InControl.TouchButtonControl::get_ButtonPosition()

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
				TouchSprite touchSprite = this.button;
				if (touchSprite.<Ready>k__BackingField)
				{
					touchSprite.Position = value;
					return;
				}
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000370 RID: 880 RVA: 0x0000B1A4 File Offset: 0x000093A4
		// (set) Token: 0x06000371 RID: 881 RVA: 0x0000B1B8 File Offset: 0x000093B8
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

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000372 RID: 882 RVA: 0x0000B1DC File Offset: 0x000093DC
		// (set) Token: 0x06000373 RID: 883 RVA: 0x0000B204 File Offset: 0x00009404
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

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000374 RID: 884 RVA: 0x0000B230 File Offset: 0x00009430
		// (set) Token: 0x06000375 RID: 885 RVA: 0x0000B244 File Offset: 0x00009444
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

		// Token: 0x06000376 RID: 886 RVA: 0x0000B268 File Offset: 0x00009468
		public TouchButtonControl()
		{
			this.offset.x = 0f;
			this.allowSlideToggle = true;
			base..ctor();
		}

		// Token: 0x040002EE RID: 750
		[SerializeField]
		[Header("Position")]
		private TouchControlAnchor anchor = TouchControlAnchor.BottomRight;

		// Token: 0x040002EF RID: 751
		[SerializeField]
		private TouchUnitType offsetUnitType;

		// Token: 0x040002F0 RID: 752
		[SerializeField]
		private Vector2 offset;

		// Token: 0x040002F1 RID: 753
		[SerializeField]
		private bool lockAspectRatio = true;

		// Token: 0x040002F2 RID: 754
		[Header("Options")]
		public TouchControl.ButtonTarget target = TouchControl.ButtonTarget.Action1;

		// Token: 0x040002F3 RID: 755
		public bool allowSlideToggle;

		// Token: 0x040002F4 RID: 756
		public bool toggleOnLeave;

		// Token: 0x040002F5 RID: 757
		public bool pressureSensitive;

		// Token: 0x040002F6 RID: 758
		[Header("Sprites")]
		public TouchSprite button;

		// Token: 0x040002F7 RID: 759
		private bool buttonState;

		// Token: 0x040002F8 RID: 760
		private Touch currentTouch;

		// Token: 0x040002F9 RID: 761
		private bool dirty;
	}
}
