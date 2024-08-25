using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.DataStructures;
using Terraria.GameInput;

namespace Terraria.GameContent.UI.Minimap
{
	// Token: 0x02000A8A RID: 2698
	public class MinimapFrame : IConfigKeyHolder
	{
		// Token: 0x170008B4 RID: 2228
		// (get) Token: 0x06004FAC RID: 20396 RVA: 0x0027B164 File Offset: 0x00279364
		// (set) Token: 0x06004FAD RID: 20397 RVA: 0x0027B178 File Offset: 0x00279378
		public string ConfigKey
		{
			[CompilerGenerated]
			get
			{
				return this.<ConfigKey>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ConfigKey>k__BackingField = value;
			}
		}

		// Token: 0x170008B5 RID: 2229
		// (get) Token: 0x06004FAE RID: 20398 RVA: 0x0027B18C File Offset: 0x0027938C
		// (set) Token: 0x06004FAF RID: 20399 RVA: 0x0027B1A0 File Offset: 0x002793A0
		public string NameKey
		{
			[CompilerGenerated]
			get
			{
				return this.<NameKey>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<NameKey>k__BackingField = value;
			}
		}

		// Token: 0x170008B6 RID: 2230
		// (get) Token: 0x06004FB0 RID: 20400 RVA: 0x0027B1B4 File Offset: 0x002793B4
		// (set) Token: 0x06004FB1 RID: 20401 RVA: 0x0027B1DC File Offset: 0x002793DC
		public Vector2 MinimapPosition
		{
			[CompilerGenerated]
			get
			{
				float x = this.<MinimapPosition>k__BackingField.X;
				float y = this.<MinimapPosition>k__BackingField.Y;
				Vector2 vector;
				return vector;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170008B7 RID: 2231
		// (get) Token: 0x06004FB2 RID: 20402 RVA: 0x0027B1EC File Offset: 0x002793EC
		// (set) Token: 0x06004FB3 RID: 20403 RVA: 0x0027B230 File Offset: 0x00279430
		private Vector2 FramePosition
		{
			get
			{
				float x = this.<MinimapPosition>k__BackingField.X;
				float y = this.<MinimapPosition>k__BackingField.Y;
				float x2 = this._frameOffset.X;
				float y2 = this._frameOffset.Y;
				if (!true)
				{
				}
				return 1;
			}
			set
			{
				float x = this._frameOffset.X;
				float y = this._frameOffset.Y;
				if (!true)
				{
				}
			}
		}

		// Token: 0x06004FB4 RID: 20404 RVA: 0x0027B25C File Offset: 0x0027945C
		public MinimapFrame(Asset<Texture2D> frameTexture, Vector2 frameOffset)
		{
			this._frameTexture = frameTexture;
		}

		// Token: 0x06004FB5 RID: 20405 RVA: 0x0027B278 File Offset: 0x00279478
		public void SetResetButton(Asset<Texture2D> hoverTexture, Vector2 position)
		{
		}

		// Token: 0x06004FB6 RID: 20406 RVA: 0x0027B288 File Offset: 0x00279488
		private void ResetZoom()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06004FB7 RID: 20407 RVA: 0x0027B29C File Offset: 0x0027949C
		public void SetZoomInButton(Asset<Texture2D> hoverTexture, Vector2 position)
		{
		}

		// Token: 0x06004FB8 RID: 20408 RVA: 0x0027B2AC File Offset: 0x002794AC
		private void ZoomInButton()
		{
			if (!true)
			{
			}
			float mapMinimapScale = Main.mapMinimapScale;
			Main.mapMinimapScale = mapMinimapScale;
		}

		// Token: 0x06004FB9 RID: 20409 RVA: 0x0027B2CC File Offset: 0x002794CC
		public void SetZoomOutButton(Asset<Texture2D> hoverTexture, Vector2 position)
		{
		}

		// Token: 0x06004FBA RID: 20410 RVA: 0x0027B2DC File Offset: 0x002794DC
		private void ZoomOutButton()
		{
			if (!true)
			{
			}
			float mapMinimapScale = Main.mapMinimapScale;
			Main.mapMinimapScale = mapMinimapScale;
		}

		// Token: 0x06004FBB RID: 20411 RVA: 0x0027B2FC File Offset: 0x002794FC
		public void Update()
		{
			MinimapFrame.Button buttonUnderMouse = this.GetButtonUnderMouse();
			MinimapFrame.Button zoomInButton = this._zoomInButton;
			MinimapFrame.Button zoomOutButton = this._zoomOutButton;
			MinimapFrame.Button resetButton = this._resetButton;
			if (buttonUnderMouse != null)
			{
				if (resetButton == null)
				{
				}
				if (!Main.LocalPlayer.lastMouseInterface)
				{
					buttonUnderMouse.IsHighlighted = true;
					bool ignoreMouseInterface = PlayerInput.IgnoreMouseInterface;
					Main.LocalPlayer.mouseInterface = true;
					bool mouseLeft = Main.mouseLeft;
					Action onMouseDown = buttonUnderMouse._onMouseDown;
					IntPtr invoke_impl = onMouseDown.invoke_impl;
					IntPtr method_code = onMouseDown.method_code;
					IntPtr method = onMouseDown.method;
					if (onMouseDown == null)
					{
					}
					bool mouseLeftRelease = Main.mouseLeftRelease;
					return;
				}
			}
		}

		// Token: 0x06004FBC RID: 20412 RVA: 0x0027B398 File Offset: 0x00279598
		public void DrawBackground(SpriteBatch spriteBatch)
		{
			int num = 1;
			if (num == 0)
			{
			}
			float x = this.<MinimapPosition>k__BackingField.X;
			float y = this.<MinimapPosition>k__BackingField.Y;
			int num2 = 65530;
			if (num == 0)
			{
			}
			if (num2 == 0)
			{
			}
			float mapMinimapAlpha = Main.mapMinimapAlpha;
		}

		// Token: 0x06004FBD RID: 20413 RVA: 0x0027B3D8 File Offset: 0x002795D8
		public void DrawForeground(SpriteBatch spriteBatch)
		{
			Asset<Texture2D> frameTexture = this._frameTexture;
			Vector2 framePosition = this.FramePosition;
			if (frameTexture == null)
			{
			}
			MinimapFrame.Button zoomInButton = this._zoomInButton;
			Vector2 framePosition2 = this.FramePosition;
			MinimapFrame.Button zoomOutButton = this._zoomOutButton;
			Vector2 framePosition3 = this.FramePosition;
			MinimapFrame.Button resetButton = this._resetButton;
			Vector2 framePosition4 = this.FramePosition;
		}

		// Token: 0x06004FBE RID: 20414 RVA: 0x0027B424 File Offset: 0x00279624
		private MinimapFrame.Button GetButtonUnderMouse()
		{
			/*
An exception occurred when decompiling this method (06004FBE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.GameContent.UI.Minimap.MinimapFrame/Button Terraria.GameContent.UI.Minimap.MinimapFrame::GetButtonUnderMouse()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:int32(var_1_0A, callgetter:int32(Main::get_mouseX))
	stloc:int32(var_3_12, callgetter:int32(Main::get_mouseY))
	stloc:Button(var_4_19, ldfld:Button(MinimapFrame::_zoomInButton, ldloc:MinimapFrame(this)))
	stloc:Vector2(var_5_21, callgetter:Vector2(MinimapFrame::get_FramePosition, ldloc:MinimapFrame(this)))
	stloc:Button(var_7_29, ldfld:Button(MinimapFrame::_zoomOutButton, ldloc:MinimapFrame(this)))
	stloc:Vector2(var_8_31, callgetter:Vector2(MinimapFrame::get_FramePosition, ldloc:MinimapFrame(this)))
	stloc:Button(var_10_39, ldfld:Button(MinimapFrame::_resetButton, ldloc:MinimapFrame(this)))
	stloc:Vector2(var_11_41, callgetter:Vector2(MinimapFrame::get_FramePosition, ldloc:MinimapFrame(this)))
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

		// Token: 0x06004FBF RID: 20415 RVA: 0x0027B478 File Offset: 0x00279678
		[Conditional("DEBUG")]
		private void ValidateState()
		{
		}

		// Token: 0x06004FC0 RID: 20416 RVA: 0x0027B488 File Offset: 0x00279688
		[CompilerGenerated]
		private void <SetResetButton>b__24_0()
		{
			this.ResetZoom();
		}

		// Token: 0x06004FC1 RID: 20417 RVA: 0x0027B49C File Offset: 0x0027969C
		[CompilerGenerated]
		private void <SetZoomInButton>b__26_0()
		{
			this.ZoomInButton();
		}

		// Token: 0x06004FC2 RID: 20418 RVA: 0x0027B4B0 File Offset: 0x002796B0
		[CompilerGenerated]
		private void <SetZoomOutButton>b__28_0()
		{
			this.ZoomOutButton();
		}

		// Token: 0x04008898 RID: 34968
		private const float DEFAULT_ZOOM = 1.05f;

		// Token: 0x04008899 RID: 34969
		private const float ZOOM_OUT_MULTIPLIER = 0.975f;

		// Token: 0x0400889A RID: 34970
		private const float ZOOM_IN_MULTIPLIER = 1.025f;

		// Token: 0x0400889B RID: 34971
		[CompilerGenerated]
		private string <ConfigKey>k__BackingField;

		// Token: 0x0400889C RID: 34972
		[CompilerGenerated]
		private string <NameKey>k__BackingField;

		// Token: 0x0400889D RID: 34973
		[CompilerGenerated]
		private Vector2 <MinimapPosition>k__BackingField;

		// Token: 0x0400889E RID: 34974
		private readonly Asset<Texture2D> _frameTexture;

		// Token: 0x0400889F RID: 34975
		private readonly Vector2 _frameOffset;

		// Token: 0x040088A0 RID: 34976
		private MinimapFrame.Button _resetButton;

		// Token: 0x040088A1 RID: 34977
		private MinimapFrame.Button _zoomInButton;

		// Token: 0x040088A2 RID: 34978
		private MinimapFrame.Button _zoomOutButton;

		// Token: 0x02000A8B RID: 2699
		private class Button
		{
			// Token: 0x170008B8 RID: 2232
			// (get) Token: 0x06004FC3 RID: 20419 RVA: 0x0027B4C4 File Offset: 0x002796C4
			private Vector2 Size
			{
				get
				{
					/*
An exception occurred when decompiling this method (06004FC3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Vector2 Terraria.GameContent.UI.Minimap.MinimapFrame/Button::get_Size()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000A:
	stloc:int32(var_1_10, call:int32(Utils::Width, ldloc:class ReLogic.Content.Asset`1<class Microsoft.Xna.Framework.Graphics.Texture2D>[exp:Asset`1](var_0_06)))
	stloc:int32(var_2_1C, call:int32(Utils::Height, ldfld:class ReLogic.Content.Asset`1<class Microsoft.Xna.Framework.Graphics.Texture2D>[exp:Asset`1](Button::_hoverTexture, ldloc:Button(this))))
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

			// Token: 0x06004FC4 RID: 20420 RVA: 0x0027B4F0 File Offset: 0x002796F0
			public Button(Asset<Texture2D> hoverTexture, Vector2 position, Action mouseDownCallback)
			{
				this._hoverTexture = hoverTexture;
				this._onMouseDown = position;
			}

			// Token: 0x06004FC5 RID: 20421 RVA: 0x0027B514 File Offset: 0x00279714
			public void Click()
			{
				Action onMouseDown = this._onMouseDown;
				IntPtr invoke_impl = onMouseDown.invoke_impl;
				IntPtr method_code = onMouseDown.method_code;
				IntPtr method = onMouseDown.method;
			}

			// Token: 0x06004FC6 RID: 20422 RVA: 0x0027B540 File Offset: 0x00279740
			public void Draw(SpriteBatch spriteBatch, Vector2 parentPosition)
			{
				if (this.IsHighlighted)
				{
					Asset<Texture2D> hoverTexture = this._hoverTexture;
					float x = this._position.X;
					float y = this._position.Y;
					return;
				}
			}

			// Token: 0x06004FC7 RID: 20423 RVA: 0x0027B578 File Offset: 0x00279778
			public bool IsTouchingPoint(Vector2 testPoint, Vector2 parentPosition)
			{
				float x = this._position.X;
				float y = this._position.Y;
				if (!true)
				{
				}
				Vector2 size = this.Size;
				Vector2 size2 = this.Size;
				if (!true)
				{
				}
				if (!true)
				{
					return;
				}
			}

			// Token: 0x040088A3 RID: 34979
			public bool IsHighlighted;

			// Token: 0x040088A4 RID: 34980
			private readonly Vector2 _position;

			// Token: 0x040088A5 RID: 34981
			private readonly Asset<Texture2D> _hoverTexture;

			// Token: 0x040088A6 RID: 34982
			private readonly Action _onMouseDown;
		}
	}
}
