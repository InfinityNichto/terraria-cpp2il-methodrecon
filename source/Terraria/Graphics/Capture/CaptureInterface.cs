using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent.UI;
using Terraria.GameInput;
using Terraria.Localization;

namespace Terraria.Graphics.Capture
{
	// Token: 0x02000767 RID: 1895
	public class CaptureInterface
	{
		// Token: 0x06003E23 RID: 15907 RVA: 0x000021DB File Offset: 0x000003DB
		private static Dictionary<int, CaptureInterface.CaptureInterfaceMode> FillModes()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003E24 RID: 15908 RVA: 0x0023BE70 File Offset: 0x0023A070
		public static Rectangle GetArea()
		{
			/*
An exception occurred when decompiling this method (06003E24)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Rectangle Terraria.Graphics.Capture.CaptureInterface::GetArea()

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

		// Token: 0x06003E25 RID: 15909 RVA: 0x0023BE80 File Offset: 0x0023A080
		public void Update()
		{
			int num = 1;
			if (num == 0)
			{
			}
			PlayerInput.SetZoom_UI();
			if (num == 0)
			{
			}
			if (num == 0)
			{
				if (num == 0)
				{
				}
				TriggersSet current = PlayerInput.Triggers.Current;
				long num2 = 0L;
				bool toggleCameraMode = current.ToggleCameraMode;
				bool keyToggleActiveHeld = this.KeyToggleActiveHeld;
				if (!keyToggleActiveHeld)
				{
					if (!keyToggleActiveHeld)
					{
					}
					bool active;
					if (Main.mouseItem.type != 0)
					{
						active = this.Active;
						if (!active)
						{
							goto IL_0083;
						}
					}
					if (!active)
					{
					}
					int myPlayer = Main.myPlayer;
					int myPlayer2 = Main.myPlayer;
					bool active2 = this.Active;
					this.ToggleCamera(num2 != 0L);
				}
				IL_0083:
				bool active3 = this.Active;
				if (active3)
				{
					if (!active3)
					{
					}
					if (!active3)
					{
					}
					if (active3)
					{
						if (!active3)
						{
						}
						bool mouseLeftRelease = Main.mouseLeftRelease;
						if (!active3)
						{
						}
						bool mouseLeft = Main.mouseLeft;
						if (!active3)
						{
						}
					}
					if (!active3)
					{
					}
					int mouseX = Main.mouseX;
					int mouseY = Main.mouseY;
					if (!active3)
					{
					}
					bool mouseLeft2 = Main.mouseLeft;
					if (!active3)
					{
					}
					int selectedMode = this.SelectedMode;
					return;
				}
			}
		}

		// Token: 0x06003E26 RID: 15910 RVA: 0x0023BFA4 File Offset: 0x0023A1A4
		public void Draw(SpriteBatch sb)
		{
			bool active = this.Active;
			if (active)
			{
				sb.End();
				if (!active)
				{
				}
				if (!true)
				{
				}
				PlayerInput.SetZoom_UI();
				return;
			}
		}

		// Token: 0x06003E27 RID: 15911 RVA: 0x0023C028 File Offset: 0x0023A228
		public void ToggleCamera(bool On = true)
		{
			if (16777216 == 0)
			{
			}
			if (16777216 != 0)
			{
				return;
			}
			bool active = this.Active;
			if (16777216 == 0)
			{
			}
			int selectedMode = this.SelectedMode;
			this.Active = 16777216 != 0;
			if (10 == 0)
			{
			}
			if (this.Active)
			{
				int selectedMode2 = this.SelectedMode;
				return;
			}
		}

		// Token: 0x06003E28 RID: 15912 RVA: 0x0023C094 File Offset: 0x0023A294
		private bool UpdateButtons(Vector2 mouse)
		{
			int num = 1;
			this.HoveredMode = num;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06003E29 RID: 15913 RVA: 0x0023C170 File Offset: 0x0023A370
		public static void QuickScreenshot()
		{
			int num = 1;
			if (num == 0)
			{
			}
			Vector2 viewPosition = Main.ViewPosition;
			if (num == 0)
			{
			}
			Vector2 viewPosition2 = Main.ViewPosition;
			Vector2 viewSize = Main.ViewSize;
			if (num == 0)
			{
			}
			bool drawWires = WiresUI.Settings.DrawWires;
		}

		// Token: 0x06003E2A RID: 15914 RVA: 0x0023C1B8 File Offset: 0x0023A3B8
		private void DrawButtons(SpriteBatch sb)
		{
			if (!true)
			{
			}
			int mouseX = Main.mouseX;
			int mouseY = Main.mouseY;
		}

		// Token: 0x06003E2B RID: 15915 RVA: 0x0023C288 File Offset: 0x0023A488
		private static bool GetMapCoords(int PinX, int PinY, int Goal, [Out] Point result)
		{
			/*
An exception occurred when decompiling this method (06003E2B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Graphics.Capture.CaptureInterface::GetMapCoords(System.Int32,System.Int32,System.Int32,Microsoft.Xna.Framework.Point)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_00C1:
	stfld:int32(int32::m_value, ldloc:int32[exp:int32&](Goal), ldloc:Point[exp:int32](var_38))
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

		// Token: 0x06003E2C RID: 15916 RVA: 0x0023C364 File Offset: 0x0023A564
		private static void ConstraintPoints()
		{
		}

		// Token: 0x06003E2D RID: 15917 RVA: 0x0023C374 File Offset: 0x0023A574
		private static void PointWorldClamp(Point point, int fluff)
		{
			int num = 1;
			point.X = fluff;
			if (num == 0)
			{
			}
			point.X = num;
			int y = point.Y;
			point.Y = fluff;
			if (num == 0)
			{
			}
		}

		// Token: 0x06003E2E RID: 15918 RVA: 0x0023C3A8 File Offset: 0x0023A5A8
		public bool UsingMap()
		{
			if (!true)
			{
			}
			if (true)
			{
				return true;
			}
			if (!true)
			{
			}
			int selectedMode = this.SelectedMode;
			return true;
		}

		// Token: 0x06003E2F RID: 15919 RVA: 0x0023C3C8 File Offset: 0x0023A5C8
		public static void ResetFocus()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06003E30 RID: 15920 RVA: 0x0023C3D8 File Offset: 0x0023A5D8
		public void Scrolling()
		{
			if (!true)
			{
			}
			int scrollWheelDelta = PlayerInput.ScrollWheelDelta;
			int selectedMode = this.SelectedMode;
		}

		// Token: 0x06003E31 RID: 15921 RVA: 0x0023C3FC File Offset: 0x0023A5FC
		private void UpdateCamera()
		{
			if (!true)
			{
			}
			int num = true.ToDirectionInt();
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (16544 == 0)
			{
			}
			if (num == 0)
			{
			}
			if (17008 == 0)
			{
			}
		}

		// Token: 0x06003E32 RID: 15922 RVA: 0x0023C430 File Offset: 0x0023A630
		private void DrawCameraLock(SpriteBatch sb)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			int screenWidth = Main.screenWidth;
			int screenHeight = Main.screenHeight;
			if (!true)
			{
			}
			string text2;
			string text = text2 + " ";
			int screenWidth2 = Main.screenWidth;
			int screenHeight2 = Main.screenHeight;
			if (!true)
			{
			}
			if (!true)
			{
			}
			int screenWidth3 = Main.screenWidth;
			int screenHeight3 = Main.screenHeight;
			if (!true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x06003E33 RID: 15923 RVA: 0x0023C4B0 File Offset: 0x0023A6B0
		public static void StartCamera(CaptureSettings settings)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06003E34 RID: 15924 RVA: 0x0023C4C0 File Offset: 0x0023A6C0
		public static void EndCamera()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06003E35 RID: 15925 RVA: 0x0023C4D0 File Offset: 0x0023A6D0
		public CaptureInterface()
		{
		}

		// Token: 0x06003E36 RID: 15926 RVA: 0x0023C4E4 File Offset: 0x0023A6E4
		// Note: this type is marked as 'beforefieldinit'.
		static CaptureInterface()
		{
			Dictionary<int, CaptureInterface.CaptureInterfaceMode> dictionary = CaptureInterface.FillModes();
		}

		// Token: 0x04007CF9 RID: 31993
		private static Dictionary<int, CaptureInterface.CaptureInterfaceMode> Modes;

		// Token: 0x04007CFA RID: 31994
		public bool Active;

		// Token: 0x04007CFB RID: 31995
		public static bool JustActivated;

		// Token: 0x04007CFC RID: 31996
		private bool KeyToggleActiveHeld;

		// Token: 0x04007CFD RID: 31997
		public int SelectedMode;

		// Token: 0x04007CFE RID: 31998
		public int HoveredMode;

		// Token: 0x04007CFF RID: 31999
		public static bool EdgeAPinned;

		// Token: 0x04007D00 RID: 32000
		public static bool EdgeBPinned;

		// Token: 0x04007D01 RID: 32001
		public static Point EdgeA;

		// Token: 0x04007D02 RID: 32002
		public static Point EdgeB;

		// Token: 0x04007D03 RID: 32003
		public static bool CameraLock;

		// Token: 0x04007D04 RID: 32004
		private static float CameraFrame;

		// Token: 0x04007D05 RID: 32005
		private static float CameraWaiting;

		// Token: 0x04007D06 RID: 32006
		private const float CameraMaxFrame = 5f;

		// Token: 0x04007D07 RID: 32007
		private const float CameraMaxWait = 60f;

		// Token: 0x04007D08 RID: 32008
		private static CaptureSettings CameraSettings;

		// Token: 0x02000768 RID: 1896
		public static class Settings
		{
			// Token: 0x06003E37 RID: 15927 RVA: 0x0023C4F8 File Offset: 0x0023A6F8
			// Note: this type is marked as 'beforefieldinit'.
			static Settings()
			{
			}

			// Token: 0x04007D09 RID: 32009
			public static bool PackImage;

			// Token: 0x04007D0A RID: 32010
			public static bool IncludeEntities;

			// Token: 0x04007D0B RID: 32011
			public static bool TransparentBackground;

			// Token: 0x04007D0C RID: 32012
			public static int BiomeChoiceIndex;

			// Token: 0x04007D0D RID: 32013
			public static int ScreenAnchor;

			// Token: 0x04007D0E RID: 32014
			public static Color MarkedAreaColor;
		}

		// Token: 0x02000769 RID: 1897
		private abstract class CaptureInterfaceMode
		{
			// Token: 0x06003E38 RID: 15928
			public abstract void Update();

			// Token: 0x06003E39 RID: 15929
			public abstract void Draw(SpriteBatch sb);

			// Token: 0x06003E3A RID: 15930
			public abstract void ToggleActive(bool tickedOn);

			// Token: 0x06003E3B RID: 15931
			public abstract bool UsingMap();

			// Token: 0x06003E3C RID: 15932 RVA: 0x0023C508 File Offset: 0x0023A708
			protected CaptureInterfaceMode()
			{
			}

			// Token: 0x04007D0F RID: 32015
			public bool Selected;
		}

		// Token: 0x0200076A RID: 1898
		private class ModeEdgeSelection : CaptureInterface.CaptureInterfaceMode
		{
			// Token: 0x06003E3D RID: 15933 RVA: 0x0023C51C File Offset: 0x0023A71C
			public override void Update()
			{
				bool selected = this.Selected;
				PlayerInput.SetZoom_Context();
				int mouseX = Main.mouseX;
				int mouseY = Main.mouseY;
			}

			// Token: 0x06003E3E RID: 15934 RVA: 0x0023C54C File Offset: 0x0023A74C
			public override void Draw(SpriteBatch sb)
			{
				bool selected = this.Selected;
				if (selected)
				{
					sb.End();
					if (!selected)
					{
					}
					if (!true)
					{
					}
					if (!true)
					{
					}
					PlayerInput.SetZoom_Context();
					sb.End();
					if (!true)
					{
					}
					PlayerInput.SetZoom_UI();
				}
			}

			// Token: 0x06003E3F RID: 15935 RVA: 0x0023C58C File Offset: 0x0023A78C
			public override void ToggleActive(bool tickedOn)
			{
			}

			// Token: 0x06003E40 RID: 15936 RVA: 0x0023C59C File Offset: 0x0023A79C
			public override bool UsingMap()
			{
				return true;
			}

			// Token: 0x06003E41 RID: 15937 RVA: 0x0023C5AC File Offset: 0x0023A7AC
			private void EdgePlacement(Vector2 mouse)
			{
				if (!true)
				{
				}
				if (!true)
				{
					if (!true)
					{
					}
					bool mapFullscreen = Main.mapFullscreen;
					if (!true)
					{
					}
					bool mouseLeft = Main.mouseLeft;
					if (!true)
					{
					}
					if (!true)
					{
					}
					bool mouseRight = Main.mouseRight;
					if (!true)
					{
					}
					return;
				}
			}

			// Token: 0x06003E42 RID: 15938 RVA: 0x0023C650 File Offset: 0x0023A850
			private void DrawMarkedArea(SpriteBatch sb)
			{
				if (!true)
				{
				}
				bool mapFullscreen = Main.mapFullscreen;
				if (-2147483648 == 0)
				{
				}
				if (-2147483648 == 0)
				{
				}
				int screenWidth = Main.screenWidth;
				int screenHeight = Main.screenHeight;
				if (-2147483648 == 0)
				{
				}
				if (-2147483648 != 0 && -2147483648 != 0)
				{
					if (-2147483648 == 0)
					{
					}
					if (-2147483648 == 0)
					{
					}
					if (-2147483648 == 0)
					{
					}
					if (-2147483648 == 0)
					{
					}
					if (-2147483648 == 0)
					{
					}
					return;
				}
			}

			// Token: 0x06003E43 RID: 15939 RVA: 0x0023C74C File Offset: 0x0023A94C
			private void DrawCursors(SpriteBatch sb)
			{
				int num = 1;
				if (num == 0)
				{
				}
				float cursorScale = Main.cursorScale;
				Vector2 screenPosition = Main.screenPosition;
				if (num == 0)
				{
				}
				int screenWidth = Main.screenWidth;
				int screenHeight = Main.screenHeight;
				int num2 = 17008;
				bool mapFullscreen = Main.mapFullscreen;
				if (num2 == 0)
				{
				}
				Vector2 screenPosition2 = Main.screenPosition;
				if (num2 == 0)
				{
				}
				Vector2 screenPosition3 = Main.screenPosition;
				if (num2 == 0)
				{
				}
				Vector3 vector = Main.rgbToHsl(Main.cursorColor);
				int myPlayer = Main.myPlayer;
				int num3 = 1;
				if (num3 == 0)
				{
				}
				if (num3 == 0)
				{
				}
				bool mapFullscreen2 = Main.mapFullscreen;
				int num4 = (true.ToInt() != 0).ToInt();
			}

			// Token: 0x06003E44 RID: 15940 RVA: 0x0023CA0C File Offset: 0x0023AC0C
			public ModeEdgeSelection()
			{
			}
		}

		// Token: 0x0200076B RID: 1899
		private class ModeDragBounds : CaptureInterface.CaptureInterfaceMode
		{
			// Token: 0x06003E45 RID: 15941 RVA: 0x0023CA20 File Offset: 0x0023AC20
			public override void Update()
			{
				bool selected = this.Selected;
				if (selected)
				{
					if (!selected)
					{
					}
					if (!selected)
					{
						PlayerInput.SetZoom_Context();
						int mouseX = Main.mouseX;
						int mouseY = Main.mouseY;
					}
				}
			}

			// Token: 0x06003E46 RID: 15942 RVA: 0x0023CA58 File Offset: 0x0023AC58
			public override void Draw(SpriteBatch sb)
			{
				bool selected = this.Selected;
				if (selected)
				{
					sb.End();
					if (!selected)
					{
					}
					if (!true)
					{
					}
					if (!true)
					{
					}
					PlayerInput.SetZoom_Context();
					this.DrawMarkedArea(sb);
					sb.End();
					if (!true)
					{
					}
					PlayerInput.SetZoom_UI();
				}
			}

			// Token: 0x06003E47 RID: 15943 RVA: 0x0023CA9C File Offset: 0x0023AC9C
			public override void ToggleActive(bool tickedOn)
			{
			}

			// Token: 0x06003E48 RID: 15944 RVA: 0x0023CAAC File Offset: 0x0023ACAC
			public override bool UsingMap()
			{
				/*
An exception occurred when decompiling this method (06003E48)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Graphics.Capture.CaptureInterface/ModeDragBounds::UsingMap()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(ModeDragBounds::caughtEdge, ldloc:ModeDragBounds(this)))
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

			// Token: 0x06003E49 RID: 15945 RVA: 0x0023CAC0 File Offset: 0x0023ACC0
			private void DragBounds(Vector2 mouse)
			{
				if (!true)
				{
				}
				bool mouseLeft = Main.mouseLeft;
				bool mapFullscreen = Main.mapFullscreen;
			}

			// Token: 0x06003E4A RID: 15946 RVA: 0x0023CCDC File Offset: 0x0023AEDC
			private Rectangle GetBound(Rectangle drawbox, int boundIndex)
			{
				if (!true)
				{
				}
				if (!true)
				{
					return;
				}
			}

			// Token: 0x06003E4B RID: 15947 RVA: 0x0023CCF4 File Offset: 0x0023AEF4
			public void DrawMarkedArea(SpriteBatch sb)
			{
				if (!true)
				{
				}
				int num = Math.Min(0, 0);
				int num2 = Math.Min(int.MinValue, 0);
				bool mapFullscreen = Main.mapFullscreen;
				if (-2147483648 == 0)
				{
				}
				if (-2147483648 == 0)
				{
				}
				int screenWidth = Main.screenWidth;
				int screenHeight = Main.screenHeight;
			}

			// Token: 0x06003E4C RID: 15948 RVA: 0x0023CDB4 File Offset: 0x0023AFB4
			private void DrawBound(SpriteBatch sb, Rectangle r, int mode)
			{
				if (!true)
				{
				}
			}

			// Token: 0x06003E4D RID: 15949 RVA: 0x0023CDCC File Offset: 0x0023AFCC
			public ModeDragBounds()
			{
			}

			// Token: 0x04007D10 RID: 32016
			public int currentAim;

			// Token: 0x04007D11 RID: 32017
			private bool dragging;

			// Token: 0x04007D12 RID: 32018
			private int caughtEdge;

			// Token: 0x04007D13 RID: 32019
			private bool inMap;
		}

		// Token: 0x0200076C RID: 1900
		private class ModeChangeSettings : CaptureInterface.CaptureInterfaceMode
		{
			// Token: 0x06003E4E RID: 15950 RVA: 0x0023CDE0 File Offset: 0x0023AFE0
			private Rectangle GetRect()
			{
				/*
An exception occurred when decompiling this method (06003E4E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Rectangle Terraria.Graphics.Capture.CaptureInterface/ModeChangeSettings::GetRect()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0016:
	brtrue(IL_0000, ldloc:int32[exp:bool](var_0_01))
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

			// Token: 0x06003E4F RID: 15951 RVA: 0x0023CE08 File Offset: 0x0023B008
			private void ButtonDraw(int button, string key, string value)
			{
			}

			// Token: 0x06003E50 RID: 15952 RVA: 0x0023CE2C File Offset: 0x0023B02C
			private void PressButton(int button)
			{
			}

			// Token: 0x06003E51 RID: 15953 RVA: 0x0023CE5C File Offset: 0x0023B05C
			private void DrawWaterChoices(SpriteBatch spritebatch, Point start, Point mouse)
			{
				int num = 1;
				if (num == 0)
				{
				}
				bool mouseLeft = Main.mouseLeft;
				if (num == 0)
				{
				}
				bool mouseLeftRelease = Main.mouseLeftRelease;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				string text;
				string textValue = Language.GetTextValue("CaptureBiomeChoice." + text);
			}

			// Token: 0x06003E52 RID: 15954 RVA: 0x0023CF1C File Offset: 0x0023B11C
			private int UnnecessaryBiomeSelectionTypeConversion(int index)
			{
			}

			// Token: 0x06003E53 RID: 15955 RVA: 0x0023CF2C File Offset: 0x0023B12C
			public override void Update()
			{
				bool selected = this.Selected;
				if (selected)
				{
					if (!selected)
					{
					}
					if (!selected)
					{
						PlayerInput.SetZoom_UI();
						int mouseX = Main.mouseX;
						int mouseY = Main.mouseY;
						this.hoveredButton = 0;
						this.inUI = false;
						return;
					}
				}
			}

			// Token: 0x06003E54 RID: 15956 RVA: 0x0023CFA8 File Offset: 0x0023B1A8
			public override void Draw(SpriteBatch sb)
			{
				int num = 1;
				if (num != 0)
				{
					if (num == 0)
					{
					}
					if (!true)
					{
					}
					int num2 = 1;
					if (num2 == 0)
					{
					}
					PlayerInput.SetZoom_Context();
					if (num2 == 0)
					{
					}
					if (!true)
					{
					}
					int num3 = 1;
					PlayerInput.SetZoom_UI();
					if (num3 == 0)
					{
					}
					if ("" == null)
					{
					}
					return;
				}
			}

			// Token: 0x06003E55 RID: 15957 RVA: 0x0023D058 File Offset: 0x0023B258
			public override void ToggleActive(bool tickedOn)
			{
			}

			// Token: 0x06003E56 RID: 15958 RVA: 0x0023D068 File Offset: 0x0023B268
			public override bool UsingMap()
			{
				return this.inUI;
			}

			// Token: 0x06003E57 RID: 15959 RVA: 0x0023D07C File Offset: 0x0023B27C
			public ModeChangeSettings()
			{
			}

			// Token: 0x04007D14 RID: 32020
			private const int ButtonsCount = 7;

			// Token: 0x04007D15 RID: 32021
			private int hoveredButton;

			// Token: 0x04007D16 RID: 32022
			private bool inUI;
		}
	}
}
