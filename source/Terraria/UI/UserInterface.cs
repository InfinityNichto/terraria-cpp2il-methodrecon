using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;

namespace Terraria.UI
{
	// Token: 0x02000727 RID: 1831
	public class UserInterface
	{
		// Token: 0x06003C95 RID: 15509 RVA: 0x00236C60 File Offset: 0x00234E60
		public void ClearPointers()
		{
			UserInterface.InputPointerCache leftMouse = this.LeftMouse;
			UserInterface.InputPointerCache rightMouse = this.RightMouse;
		}

		// Token: 0x06003C96 RID: 15510 RVA: 0x00236C7C File Offset: 0x00234E7C
		public void ResetLasts()
		{
			if (this._lastElementHover != null)
			{
				Vector2 mousePosition = this.MousePosition;
			}
			UserInterface.InputPointerCache leftMouse = this.LeftMouse;
			UserInterface.InputPointerCache rightMouse = this.RightMouse;
		}

		// Token: 0x06003C97 RID: 15511 RVA: 0x00236CA8 File Offset: 0x00234EA8
		public void EscapeElements()
		{
			this.ResetLasts();
		}

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x06003C98 RID: 15512 RVA: 0x00236CBC File Offset: 0x00234EBC
		public UIState CurrentState
		{
			get
			{
				return this._currentState;
			}
		}

		// Token: 0x06003C99 RID: 15513 RVA: 0x00236CD0 File Offset: 0x00234ED0
		public UserInterface()
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			base..ctor();
		}

		// Token: 0x06003C9A RID: 15514 RVA: 0x00236CFC File Offset: 0x00234EFC
		public void Use()
		{
			if (true)
			{
				return;
			}
			if (true)
			{
				return;
			}
			if (this._currentState != null)
			{
				return;
			}
		}

		// Token: 0x06003C9B RID: 15515 RVA: 0x00236D1C File Offset: 0x00234F1C
		private void ImmediatelyUpdateInputPointers()
		{
			UserInterface.InputPointerCache leftMouse = this.LeftMouse;
			if (!true)
			{
			}
			bool mouseLeft = Main.mouseLeft;
			leftMouse.WasDown = true;
			UserInterface.InputPointerCache rightMouse = this.RightMouse;
			bool mouseRight = Main.mouseRight;
			rightMouse.WasDown = true;
		}

		// Token: 0x06003C9C RID: 15516 RVA: 0x00236D5C File Offset: 0x00234F5C
		private void ResetState()
		{
			if (!true)
			{
			}
			if (!true)
			{
				this.GetMousePosition();
				this.ImmediatelyUpdateInputPointers();
				if (this._lastElementHover != null)
				{
					Vector2 mousePosition = this.MousePosition;
				}
			}
			UserInterface.InputPointerCache leftMouse = this.LeftMouse;
			UserInterface.InputPointerCache rightMouse = this.RightMouse;
			double clickDisabledTimeRemaining = this._clickDisabledTimeRemaining;
			if (rightMouse == null)
			{
			}
			double num;
			this._clickDisabledTimeRemaining = num;
		}

		// Token: 0x06003C9D RID: 15517 RVA: 0x00236DB0 File Offset: 0x00234FB0
		private void GetMousePosition()
		{
			if (!true)
			{
			}
			int mouseX = Main.mouseX;
			int mouseY = Main.mouseY;
			this.MousePosition = 1;
		}

		// Token: 0x06003C9E RID: 15518 RVA: 0x00236DD8 File Offset: 0x00234FD8
		public void Update(GameTime time)
		{
			UIState currentState = this._currentState;
			if (currentState == null)
			{
				return;
			}
			this.GetMousePosition();
			if (currentState == null)
			{
			}
			if (currentState != null)
			{
				UIState currentState2 = this._currentState;
				float x = this.MousePosition.X;
				float y = this.MousePosition.Y;
				return;
			}
			long num = 0L;
			TimeSpan elapsedGameTime = time.elapsedGameTime;
			double clickDisabledTimeRemaining = this._clickDisabledTimeRemaining;
			if (elapsedGameTime == null)
			{
			}
			UIElement lastElementHover = this._lastElementHover;
			double num2;
			this._clickDisabledTimeRemaining = num2;
			if (lastElementHover != null)
			{
				Vector2 mousePosition = this.MousePosition;
			}
			if (num != 0L)
			{
				Vector2 mousePosition2 = this.MousePosition;
			}
			this._lastElementHover = num;
			UserInterface.InputPointerCache leftMouse = this.LeftMouse;
			bool mouseLeft = Main.mouseLeft;
		}

		// Token: 0x06003C9F RID: 15519 RVA: 0x00236EA4 File Offset: 0x002350A4
		private void HandleClick(UserInterface.InputPointerCache cache, GameTime time, bool isDown, UIElement mouseElement)
		{
			bool wasDown = cache.WasDown;
			if (mouseElement != null && !wasDown)
			{
				cache.LastDown = mouseElement;
				UserInterface.MouseElementEvent mouseDownEvent = cache.MouseDownEvent;
				Vector2 mousePosition = this.MousePosition;
				IntPtr invoke_impl = mouseDownEvent.invoke_impl;
				IntPtr method_code = mouseDownEvent.method_code;
				IntPtr method = mouseDownEvent.method;
				UIElement lastClicked = cache.LastClicked;
				TimeSpan totalGameTime = time.totalGameTime;
				double lastTimeDown = cache.LastTimeDown;
				UserInterface.MouseElementEvent doubleClickEvent = cache.DoubleClickEvent;
				Vector2 mousePosition2 = this.MousePosition;
				IntPtr invoke_impl2 = doubleClickEvent.invoke_impl;
				IntPtr method_code2 = doubleClickEvent.method_code;
				IntPtr method2 = doubleClickEvent.method;
				TimeSpan totalGameTime2 = time.totalGameTime;
				double num;
				cache.LastTimeDown = num;
				return;
			}
		}

		// Token: 0x06003CA0 RID: 15520 RVA: 0x00236FA8 File Offset: 0x002351A8
		public void Draw(SpriteBatch spriteBatch, GameTime time)
		{
			this.Use();
			if (this._currentState != null)
			{
				if (this._isStateDirty)
				{
					UIState currentState = this._currentState;
				}
				return;
			}
		}

		// Token: 0x06003CA1 RID: 15521 RVA: 0x00236FD4 File Offset: 0x002351D4
		public void DrawDebugHitbox(BasicDebugDrawer drawer)
		{
		}

		// Token: 0x06003CA2 RID: 15522 RVA: 0x00236FE4 File Offset: 0x002351E4
		public void SetState(UIState state)
		{
			for (;;)
			{
				UIState currentState = this._currentState;
				if (state != null)
				{
					this.AddToHistory(state);
					if (this._currentState == null)
					{
						goto IL_0033;
					}
					if (this._lastElementHover != null)
					{
						break;
					}
				}
			}
			Vector2 mousePosition = this.MousePosition;
			this._currentState.Deactivate();
			IL_0033:
			this._currentState = state;
			this.ResetState();
			if (state != null)
			{
				this._isStateDirty = true;
				state.Activate();
				return;
			}
		}

		// Token: 0x06003CA3 RID: 15523 RVA: 0x00237044 File Offset: 0x00235244
		public void GoBack()
		{
			int size = this._history._size;
			int size2 = this._history._size;
		}

		// Token: 0x06003CA4 RID: 15524 RVA: 0x000021DB File Offset: 0x000003DB
		private void AddToHistory(UIState state)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003CA5 RID: 15525 RVA: 0x0023706C File Offset: 0x0023526C
		public void Recalculate()
		{
			if (this._currentState != null)
			{
				return;
			}
		}

		// Token: 0x06003CA6 RID: 15526 RVA: 0x00237084 File Offset: 0x00235284
		public CalculatedStyle GetDimensions()
		{
			/*
An exception occurred when decompiling this method (06003CA6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.UI.CalculatedStyle Terraria.UI.UserInterface::GetDimensions()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0011:
	brtrue(IL_0000, ldc.i4:bool(1))
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

		// Token: 0x06003CA7 RID: 15527 RVA: 0x002370A4 File Offset: 0x002352A4
		internal void RefreshState()
		{
			UIState currentState = this._currentState;
			if (currentState != null)
			{
				currentState.Deactivate();
			}
			this.ResetState();
			this._currentState.Activate();
			UIState currentState2 = this._currentState;
		}

		// Token: 0x06003CA8 RID: 15528 RVA: 0x002370DC File Offset: 0x002352DC
		public bool IsElementUnderMouse()
		{
			if (!this.IsVisible || this._lastElementHover != null)
			{
				return;
			}
		}

		// Token: 0x06003CA9 RID: 15529 RVA: 0x002370FC File Offset: 0x002352FC
		// Note: this type is marked as 'beforefieldinit'.
		static UserInterface()
		{
		}

		// Token: 0x04007BB6 RID: 31670
		private const double DOUBLE_CLICK_TIME = 500.0;

		// Token: 0x04007BB7 RID: 31671
		private const double STATE_CHANGE_CLICK_DISABLE_TIME = 200.0;

		// Token: 0x04007BB8 RID: 31672
		private const int MAX_HISTORY_SIZE = 32;

		// Token: 0x04007BB9 RID: 31673
		private const int HISTORY_PRUNE_SIZE = 4;

		// Token: 0x04007BBA RID: 31674
		public static UserInterface ActiveInstance;

		// Token: 0x04007BBB RID: 31675
		private List<UIState> _history;

		// Token: 0x04007BBC RID: 31676
		private UserInterface.InputPointerCache LeftMouse;

		// Token: 0x04007BBD RID: 31677
		private UserInterface.InputPointerCache RightMouse;

		// Token: 0x04007BBE RID: 31678
		public Vector2 MousePosition;

		// Token: 0x04007BBF RID: 31679
		private UIElement _lastElementHover;

		// Token: 0x04007BC0 RID: 31680
		private double _clickDisabledTimeRemaining;

		// Token: 0x04007BC1 RID: 31681
		private bool _isStateDirty;

		// Token: 0x04007BC2 RID: 31682
		public bool IsVisible;

		// Token: 0x04007BC3 RID: 31683
		private UIState _currentState;

		// Token: 0x02000728 RID: 1832
		private sealed class MouseElementEvent : MulticastDelegate
		{
			// Token: 0x06003CAA RID: 15530 RVA: 0x0023710C File Offset: 0x0023530C
			public MouseElementEvent(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x06003CAB RID: 15531 RVA: 0x0023716C File Offset: 0x0023536C
			public void Invoke(UIElement element, UIMouseEvent evt)
			{
				IntPtr method_code = this.method_code;
				IntPtr invoke_impl = this.invoke_impl;
				IntPtr method = this.method;
			}

			// Token: 0x06003CAC RID: 15532 RVA: 0x000021DB File Offset: 0x000003DB
			public IAsyncResult BeginInvoke(UIElement element, UIMouseEvent evt, AsyncCallback callback, object @object)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06003CAD RID: 15533 RVA: 0x00237190 File Offset: 0x00235390
			public void EndInvoke(IAsyncResult result)
			{
			}
		}

		// Token: 0x02000729 RID: 1833
		private class InputPointerCache
		{
			// Token: 0x06003CAE RID: 15534 RVA: 0x002371A0 File Offset: 0x002353A0
			public void Clear()
			{
			}

			// Token: 0x06003CAF RID: 15535 RVA: 0x002371B0 File Offset: 0x002353B0
			public InputPointerCache()
			{
			}

			// Token: 0x04007BC4 RID: 31684
			public double LastTimeDown;

			// Token: 0x04007BC5 RID: 31685
			public bool WasDown;

			// Token: 0x04007BC6 RID: 31686
			public UIElement LastDown;

			// Token: 0x04007BC7 RID: 31687
			public UIElement LastClicked;

			// Token: 0x04007BC8 RID: 31688
			public UserInterface.MouseElementEvent MouseDownEvent;

			// Token: 0x04007BC9 RID: 31689
			public UserInterface.MouseElementEvent MouseUpEvent;

			// Token: 0x04007BCA RID: 31690
			public UserInterface.MouseElementEvent ClickEvent;

			// Token: 0x04007BCB RID: 31691
			public UserInterface.MouseElementEvent DoubleClickEvent;
		}

		// Token: 0x0200072A RID: 1834
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06003CB0 RID: 15536 RVA: 0x002371C4 File Offset: 0x002353C4
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06003CB1 RID: 15537 RVA: 0x002371D4 File Offset: 0x002353D4
			public <>c()
			{
			}

			// Token: 0x06003CB2 RID: 15538 RVA: 0x002371E8 File Offset: 0x002353E8
			internal void <.ctor>b__21_0(UIElement element, UIMouseEvent evt)
			{
			}

			// Token: 0x06003CB3 RID: 15539 RVA: 0x002371F8 File Offset: 0x002353F8
			internal void <.ctor>b__21_1(UIElement element, UIMouseEvent evt)
			{
			}

			// Token: 0x06003CB4 RID: 15540 RVA: 0x00237208 File Offset: 0x00235408
			internal void <.ctor>b__21_2(UIElement element, UIMouseEvent evt)
			{
			}

			// Token: 0x06003CB5 RID: 15541 RVA: 0x00237218 File Offset: 0x00235418
			internal void <.ctor>b__21_3(UIElement element, UIMouseEvent evt)
			{
			}

			// Token: 0x06003CB6 RID: 15542 RVA: 0x00237228 File Offset: 0x00235428
			internal void <.ctor>b__21_4(UIElement element, UIMouseEvent evt)
			{
			}

			// Token: 0x06003CB7 RID: 15543 RVA: 0x00237238 File Offset: 0x00235438
			internal void <.ctor>b__21_5(UIElement element, UIMouseEvent evt)
			{
			}

			// Token: 0x06003CB8 RID: 15544 RVA: 0x00237248 File Offset: 0x00235448
			internal void <.ctor>b__21_6(UIElement element, UIMouseEvent evt)
			{
			}

			// Token: 0x06003CB9 RID: 15545 RVA: 0x00237258 File Offset: 0x00235458
			internal void <.ctor>b__21_7(UIElement element, UIMouseEvent evt)
			{
			}

			// Token: 0x04007BCC RID: 31692
			public static readonly UserInterface.<>c <>9;

			// Token: 0x04007BCD RID: 31693
			public static UserInterface.MouseElementEvent <>9__21_0;

			// Token: 0x04007BCE RID: 31694
			public static UserInterface.MouseElementEvent <>9__21_1;

			// Token: 0x04007BCF RID: 31695
			public static UserInterface.MouseElementEvent <>9__21_2;

			// Token: 0x04007BD0 RID: 31696
			public static UserInterface.MouseElementEvent <>9__21_3;

			// Token: 0x04007BD1 RID: 31697
			public static UserInterface.MouseElementEvent <>9__21_4;

			// Token: 0x04007BD2 RID: 31698
			public static UserInterface.MouseElementEvent <>9__21_5;

			// Token: 0x04007BD3 RID: 31699
			public static UserInterface.MouseElementEvent <>9__21_6;

			// Token: 0x04007BD4 RID: 31700
			public static UserInterface.MouseElementEvent <>9__21_7;
		}
	}
}
