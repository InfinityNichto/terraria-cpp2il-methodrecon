using System;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Input
{
	// Token: 0x02000356 RID: 854
	public static class Mouse
	{
		// Token: 0x060015E9 RID: 5609 RVA: 0x000615AC File Offset: 0x0005F7AC
		public static MouseState GetState(GameWindow window)
		{
			if (!true)
			{
			}
			MouseState mouseState;
			mouseState._horizontalScrollWheelValue = 1;
			return 1;
		}

		// Token: 0x060015EA RID: 5610 RVA: 0x000615C4 File Offset: 0x0005F7C4
		public static MouseState GetState()
		{
			if (!true)
			{
			}
			MouseState mouseState;
			mouseState._horizontalScrollWheelValue = 1;
			return 1;
		}

		// Token: 0x060015EB RID: 5611 RVA: 0x000615E0 File Offset: 0x0005F7E0
		public static void SetPosition(int x, int y)
		{
			if (true)
			{
				return;
			}
		}

		// Token: 0x060015EC RID: 5612 RVA: 0x000615F4 File Offset: 0x0005F7F4
		public static void SetCursor(MouseCursor cursor)
		{
			if (true)
			{
				return;
			}
		}

		// Token: 0x060015ED RID: 5613 RVA: 0x000021DB File Offset: 0x000003DB
		private static IntPtr PlatformGetWindowHandle()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060015EE RID: 5614 RVA: 0x00061608 File Offset: 0x0005F808
		private static void PlatformSetWindowHandle(IntPtr windowHandle)
		{
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x060015EF RID: 5615 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x060015F0 RID: 5616 RVA: 0x00061618 File Offset: 0x0005F818
		private static int scrollAccum
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x060015F1 RID: 5617 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x060015F2 RID: 5618 RVA: 0x00061628 File Offset: 0x0005F828
		private static float _uiX
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x060015F3 RID: 5619 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x060015F4 RID: 5620 RVA: 0x00061638 File Offset: 0x0005F838
		private static float _uiY
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x060015F5 RID: 5621 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x060015F6 RID: 5622 RVA: 0x00061648 File Offset: 0x0005F848
		private static float _X
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x060015F7 RID: 5623 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x060015F8 RID: 5624 RVA: 0x00061658 File Offset: 0x0005F858
		private static float _Y
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x060015F9 RID: 5625 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x060015FA RID: 5626 RVA: 0x00061668 File Offset: 0x0005F868
		private static float _worldScreenOffsetY
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x060015FB RID: 5627 RVA: 0x00061678 File Offset: 0x0005F878
		public static void SetWorldScreenOffset(float yValue)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			int screenHeight = XNAUnityRunner.ScreenHeight;
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x060015FC RID: 5628 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x060015FD RID: 5629 RVA: 0x00061694 File Offset: 0x0005F894
		public static int _overloadScreenWidth
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x060015FE RID: 5630 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x060015FF RID: 5631 RVA: 0x000616A4 File Offset: 0x0005F8A4
		public static int _overloadScreenHeight
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06001600 RID: 5632 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001601 RID: 5633 RVA: 0x000616B4 File Offset: 0x0005F8B4
		public static int _overloadScreenOffsetX
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06001602 RID: 5634 RVA: 0x000616C4 File Offset: 0x0005F8C4
		// (set) Token: 0x06001603 RID: 5635 RVA: 0x000616D8 File Offset: 0x0005F8D8
		public static int _overloadScreenOffsetY
		{
			get
			{
				return 41684992;
			}
			set
			{
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06001604 RID: 5636 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001605 RID: 5637 RVA: 0x000616E8 File Offset: 0x0005F8E8
		public static Mouse.OverrideState _virtualCursorOverride
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06001606 RID: 5638 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001607 RID: 5639 RVA: 0x000616F8 File Offset: 0x0005F8F8
		public static ButtonState _virtualCursorOverrideState
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06001608 RID: 5640 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001609 RID: 5641 RVA: 0x00061708 File Offset: 0x0005F908
		public static float _virtualCursorOverrideX
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x0600160A RID: 5642 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x0600160B RID: 5643 RVA: 0x00061718 File Offset: 0x0005F918
		public static float _virtualCursorOverrideY
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x0600160C RID: 5644 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x0600160D RID: 5645 RVA: 0x00061728 File Offset: 0x0005F928
		public static bool _overrideRMB
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x0600160E RID: 5646 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x0600160F RID: 5647 RVA: 0x00061738 File Offset: 0x0005F938
		public static ButtonState _rmbOverrideState
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06001610 RID: 5648 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001611 RID: 5649 RVA: 0x00061748 File Offset: 0x0005F948
		private static float scrollAccumPartial
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x06001612 RID: 5650 RVA: 0x00061758 File Offset: 0x0005F958
		public static void SetRMBOverride(bool overrideRMB, ButtonState overrideState)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001613 RID: 5651 RVA: 0x00061768 File Offset: 0x0005F968
		public static Mouse.OverrideState GetOverrideState()
		{
			/*
An exception occurred when decompiling this method (06001613)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Input.Mouse/OverrideState Microsoft.Xna.Framework.Input.Mouse::GetOverrideState()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
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

		// Token: 0x06001614 RID: 5652 RVA: 0x00061778 File Offset: 0x0005F978
		public static void SetVirtualCursorOverride(Mouse.OverrideState overrideMouse, ButtonState overrideState, float x, float y)
		{
			if (overrideMouse != Mouse.OverrideState.None)
			{
				if (!true)
				{
				}
				return;
			}
		}

		// Token: 0x06001615 RID: 5653 RVA: 0x0006178C File Offset: 0x0005F98C
		public static Vector2 GetUICursorPosition()
		{
			/*
An exception occurred when decompiling this method (06001615)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Vector2 Microsoft.Xna.Framework.Input.Mouse::GetUICursorPosition()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
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

		// Token: 0x06001616 RID: 5654 RVA: 0x0006179C File Offset: 0x0005F99C
		public static void UpdateUICursorPoint()
		{
			Cursor cursor;
			if (cursor != null)
			{
				float x = cursor.Position.x;
				float y = cursor.Position.y;
			}
		}

		// Token: 0x06001617 RID: 5655 RVA: 0x000617C8 File Offset: 0x0005F9C8
		private static MouseState PlatformGetState(GameWindow window)
		{
			/*
An exception occurred when decompiling this method (06001617)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Input.MouseState Microsoft.Xna.Framework.Input.Mouse::PlatformGetState(Microsoft.Xna.Framework.GameWindow)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0081:
	stloc:int64(var_18_82, ldc.i4:int64(0))
	stloc:int32(var_19_85, ldc.i4:int32(1))
	stloc:int64(var_20_88, ldc.i4:int64(0))
	stloc:bool(var_21_93, call:bool(XNAUnityRunner::GetMouseButton, ldloc:int32(var_19_85), ldloc:int64[exp:bool](var_20_88)))
	stfld:ButtonState(MouseState::_xButton1, ldloc:MouseState[exp:valuetype Microsoft.Xna.Framework.Input.MouseState&](var_0), ldloc:int64[exp:ButtonState](var_18_82))
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

		// Token: 0x06001618 RID: 5656 RVA: 0x00061874 File Offset: 0x0005FA74
		private static Cursor ActiveCursor()
		{
			Cursor cursor;
			while (cursor.InputLayer == null)
			{
			}
		}

		// Token: 0x06001619 RID: 5657 RVA: 0x0006188C File Offset: 0x0005FA8C
		private static void PlatformSetPosition(int x, int y)
		{
		}

		// Token: 0x0600161A RID: 5658 RVA: 0x0006189C File Offset: 0x0005FA9C
		public static void PlatformSetCursor(MouseCursor cursor)
		{
		}

		// Token: 0x0600161B RID: 5659 RVA: 0x000618AC File Offset: 0x0005FAAC
		// Note: this type is marked as 'beforefieldinit'.
		static Mouse()
		{
		}

		// Token: 0x040023F4 RID: 9204
		private static readonly MouseState _defaultState;

		// Token: 0x02000357 RID: 855
		public enum OverrideState
		{
			// Token: 0x040023F6 RID: 9206
			None,
			// Token: 0x040023F7 RID: 9207
			Position,
			// Token: 0x040023F8 RID: 9208
			Click,
			// Token: 0x040023F9 RID: 9209
			PositionAndClick
		}
	}
}
