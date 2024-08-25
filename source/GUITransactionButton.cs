using System;
using Controller;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using UnityEngine;

// Token: 0x0200011C RID: 284
public static class GUITransactionButton
{
	// Token: 0x06000720 RID: 1824 RVA: 0x000190D8 File Offset: 0x000172D8
	public static Rectangle GetRegion(TransactionButton_Layout layout)
	{
		if (true)
		{
			Rectangle rectangle;
			return rectangle;
		}
		Microsoft.Xna.Framework.Graphics.Texture2D texture2D;
		RenderTexture unityRenderTexture = texture2D._unityRenderTexture;
		Rectangle rectangle2;
		return rectangle2;
	}

	// Token: 0x06000721 RID: 1825 RVA: 0x000190F8 File Offset: 0x000172F8
	public static Rectangle GetPickRegion(TransactionButton_Layout layout)
	{
		if (true)
		{
			Rectangle rectangle;
			return rectangle;
		}
		Rectangle rectangle2;
		return rectangle2;
	}

	// Token: 0x06000722 RID: 1826 RVA: 0x0001910C File Offset: 0x0001730C
	private static void DrawBacking(TransactionButton_Layout layout, Microsoft.Xna.Framework.Graphics.Texture2D backing, Microsoft.Xna.Framework.Graphics.Texture2D additionalBacking, Microsoft.Xna.Framework.Graphics.Color backingColour, Microsoft.Xna.Framework.Graphics.Color additionalbackingColour, Microsoft.Xna.Framework.Graphics.Texture2D border, Microsoft.Xna.Framework.Graphics.Color borderColour, float scale, bool over)
	{
		if (layout.overloadSize)
		{
			ControlAnchor.ControlId anchorControl = layout.AnchorControl;
			Microsoft.Xna.Framework.Vector2 location = layout.Location;
			float x = layout.Location.X;
			float y = layout.Location.Y;
			float x2 = layout.overloadedSize.X;
			float y2 = layout.overloadedSize.Y;
			if (backing != null)
			{
			}
			if (additionalBacking != null)
			{
				Microsoft.Xna.Framework.Vector2 vector = backing.Size();
				Microsoft.Xna.Framework.Vector2 vector2 = additionalBacking.Size();
				float y3 = layout.overloadedSize.Y;
				float x3 = layout.overloadedSize.X;
				ControlAnchor.ControlId anchorControl2 = layout.AnchorControl;
				Microsoft.Xna.Framework.Vector2 location2 = layout.Location;
			}
			if (border != null)
			{
				Microsoft.Xna.Framework.Vector2 vector3 = backing.Size();
				Microsoft.Xna.Framework.Vector2 vector4 = border.Size();
				float y4 = layout.overloadedSize.Y;
				float x4 = layout.overloadedSize.X;
				ControlAnchor.ControlId anchorControl3 = layout.AnchorControl;
				Microsoft.Xna.Framework.Vector2 location3 = layout.Location;
				float x5 = layout.Location.X;
				float y5 = layout.Location.Y;
			}
			global::Cursor cursor;
			if (layout.OverBackingHighlight.Texture != null && cursor != null)
			{
				Microsoft.Xna.Framework.Vector2 vector5 = backing.Size();
				Microsoft.Xna.Framework.Vector2 vector6 = layout.OverBackingHighlight.Texture.Size();
				float y6 = layout.overloadedSize.Y;
				float x6 = layout.overloadedSize.X;
				ControlAnchor.ControlId anchorControl4 = layout.AnchorControl;
				Microsoft.Xna.Framework.Vector2 location4 = layout.Location;
				float x7 = layout.Location.X;
				float y7 = layout.Location.Y;
				Microsoft.Xna.Framework.Graphics.Texture2D texture = layout.OverBackingHighlight.Texture;
				return;
			}
		}
		else
		{
			if (backing != null)
			{
				return;
			}
			Microsoft.Xna.Framework.Vector2 location3;
			Microsoft.Xna.Framework.Graphics.Texture2D texture;
			if (location3 != null)
			{
				GraphicsDevice graphicsDevice = texture.graphicsDevice;
				EventHandler<EventArgs> disposing = texture.Disposing;
				EventHandler<EventArgs> disposing2 = texture.Disposing;
			}
			GraphicsDevice graphicsDevice2 = texture.graphicsDevice;
			EventHandler<EventArgs> disposing3 = texture.Disposing;
			EventHandler<EventArgs> disposing4 = texture.Disposing;
			TextureAtlasDB textureAtlas = texture._textureAtlas;
			Microsoft.Xna.Framework.Graphics.Texture2D texture2D;
			global::Cursor cursor2;
			if (texture2D != null && cursor2 != null)
			{
				TextureAtlasDB textureAtlas2 = texture._textureAtlas;
				GraphicsDevice graphicsDevice3 = texture.graphicsDevice;
				EventHandler<EventArgs> disposing5 = texture.Disposing;
				EventHandler<EventArgs> disposing6 = texture.Disposing;
			}
		}
	}

	// Token: 0x06000723 RID: 1827 RVA: 0x00019348 File Offset: 0x00017548
	private static void DrawControlIcon(TransactionButton_Layout layout, Microsoft.Xna.Framework.Graphics.Texture2D backing, Microsoft.Xna.Framework.Graphics.Color iconColour, float scale, bool hasControllerFocus)
	{
		if (layout.DrawControlsIconOnFocus)
		{
			GUIControllerInputButton.LinkedControlType linkedControl = layout.LinkedControl;
			int iconMaxSizeInset = layout.IconMaxSizeInset;
			int width = backing.Width;
			int arraySize = backing.ArraySize;
			float x = layout.ControlIconOffset.X;
			float y = layout.ControlIconOffset.Y;
			return;
		}
	}

	// Token: 0x06000724 RID: 1828 RVA: 0x0001940C File Offset: 0x0001760C
	public static GUITransactionButton.InputState DrawWithBanner(TransactionButton_Layout layout, GUIControlsBanner.ActionSource source, ControllerActionButton action, GUITransactionButton.DrawItemHandler itemHandler, Microsoft.Xna.Framework.Vector2 itemSize, string label, bool disabled, float scale, bool forcePressed = false, bool hasControllerFocus = false, bool forceOver = false, bool disablePressedState = false, bool drawWhenControllerConnected = false)
	{
		bool anyControllerConnected = ControllerActionManager.AnyControllerConnected;
		GUITransactionButton.InputState inputState;
		return inputState;
	}

	// Token: 0x06000725 RID: 1829 RVA: 0x00019428 File Offset: 0x00017628
	public static GUITransactionButton.InputState Draw(TransactionButton_Layout layout, GUITransactionButton.DrawItemHandler itemHandler, Microsoft.Xna.Framework.Vector2 itemSize, string label, bool disabled, float scale, bool forcePressed = false, bool hasControllerFocus = false, bool forceOver = false, bool disablePressedState = false)
	{
		int num = 1;
		if (num == 0)
		{
		}
		if (num == 0)
		{
		}
		long num2 = 0L;
		bool mouseLeft = Main.mouseLeft;
		if (58 != 0)
		{
			bool mouseLeft2 = Main.mouseLeft;
			bool mouseLeftRelease = Main.mouseLeftRelease;
		}
		bool mouseLeft3 = Main.mouseLeft;
		bool mouseLeftRelease2 = Main.mouseLeftRelease;
		Microsoft.Xna.Framework.Graphics.Texture2D texture2D;
		if (texture2D != null)
		{
			Microsoft.Xna.Framework.Graphics.Texture2D texture2D2;
			if (texture2D2 != null)
			{
				long value = num2.m_value;
				Microsoft.Xna.Framework.Graphics.Texture2D texture2D3;
				if (texture2D3 != null)
				{
				}
			}
		}
		Microsoft.Xna.Framework.Graphics.Texture2D texture2D4;
		int width = texture2D4.Width;
		int arraySize = texture2D4.ArraySize;
		Microsoft.Xna.Framework.Vector2 vector2;
		Microsoft.Xna.Framework.Vector2 vector = vector2 * scale;
		Microsoft.Xna.Framework.Graphics.Texture2D texture2D5;
		global::Cursor cursor;
		if (texture2D5 == null || cursor != null)
		{
		}
		int width2 = texture2D4.Width;
		int arraySize2 = texture2D4.ArraySize;
		Microsoft.Xna.Framework.Graphics.Texture2D texture2D6;
		int width3 = texture2D6.Width;
		if (texture2D6.ArraySize == 0)
		{
		}
		int num3 = 32640;
		Rectangle rectangle;
		if (rectangle == null)
		{
		}
		if (width3 == 0)
		{
			return;
		}
		if (rectangle == null)
		{
		}
		if (rectangle == null)
		{
		}
		int width4 = texture2D4.Width;
		int height = texture2D4.Height;
		Microsoft.Xna.Framework.Vector2 vector4;
		Microsoft.Xna.Framework.Vector2 vector3 = vector4 / scale;
		if (rectangle == null)
		{
		}
		if (num3 == 0)
		{
			return;
		}
	}

	// Token: 0x06000726 RID: 1830 RVA: 0x00019528 File Offset: 0x00017728
	public static Rectangle GetOverloadedPickingRegion(TransactionButton_Layout layout, float scale)
	{
		if (!true)
		{
		}
		Rectangle rectangle;
		return rectangle;
	}

	// Token: 0x06000727 RID: 1831 RVA: 0x0001953C File Offset: 0x0001773C
	public static Rectangle LoadButtonRegion(TransactionButton_Layout layout, float scale)
	{
		if (true)
		{
			Rectangle rectangle;
			return rectangle;
		}
		Microsoft.Xna.Framework.Graphics.Texture2D texture2D;
		RenderTexture unityRenderTexture = texture2D._unityRenderTexture;
		Rectangle rectangle2;
		ControlAnchor.SetButtonRegion(rectangle2);
		return rectangle2;
	}

	// Token: 0x06000728 RID: 1832 RVA: 0x00019564 File Offset: 0x00017764
	public static GUITransactionButton.InputState DrawWithBanner(TransactionButton_Layout layout, GUIControlsBanner.ActionSource source, ControllerActionButton action, Item item, string label, bool disabled, float scale, bool forcedPressed = false, bool hasControllerFocus = true, bool forceOver = false, bool disablePressedState = false, bool drawWhenControllerConnected = false, bool addTouchBanner = false)
	{
		bool anyControllerConnected = ControllerActionManager.AnyControllerConnected;
		GUITransactionButton.InputState inputState;
		return inputState;
	}

	// Token: 0x06000729 RID: 1833 RVA: 0x00019580 File Offset: 0x00017780
	public static GUITransactionButton.InputState Draw(TransactionButton_Layout layout, Item item, string label, bool disabled, float scale, bool forcedPressed = false, bool hasControllerFocus = false, bool forceOver = false, bool disablePressedState = false)
	{
		/*
An exception occurred when decompiling this method (06000729)

ICSharpCode.Decompiler.DecompilerException: Error decompiling GUITransactionButton/InputState GUITransactionButton::Draw(TransactionButton_Layout,Terraria.Item,System.String,System.Boolean,System.Single,System.Boolean,System.Boolean,System.Boolean,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_021B:
	brtrue(IL_0000, logicnot:bool(ldloc:Rectangle[exp:bool](var_112)))
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

	// Token: 0x0600072A RID: 1834 RVA: 0x000197B0 File Offset: 0x000179B0
	private static void DrawItem(TransactionButton_Layout layout, Microsoft.Xna.Framework.Graphics.Texture2D backing, Microsoft.Xna.Framework.Graphics.Texture2D itemTexture, Microsoft.Xna.Framework.Graphics.Color itemColour, float scale)
	{
		if (itemTexture != null && layout.DrawItem)
		{
			float x = layout.ItemOffset.X;
			int iconMaxSizeInset = layout.IconMaxSizeInset;
			int width = backing.Width;
			int arraySize = backing.ArraySize;
			float y = layout.ItemOffset.Y;
			int width2 = itemTexture.Width;
			int arraySize2 = itemTexture.ArraySize;
			return;
		}
	}

	// Token: 0x0600072B RID: 1835 RVA: 0x0001987C File Offset: 0x00017A7C
	private static GUITransactionButton.InputState HandleControllerAction(TransactionButton_Layout layout, ControllerActionButton action, string label, bool disabled, bool disablePressedState, bool hasControllerFocus)
	{
		if (layout != null)
		{
		}
		if (layout != null)
		{
			int myPlayer = Main.myPlayer;
			return;
		}
	}

	// Token: 0x0600072C RID: 1836 RVA: 0x000198A4 File Offset: 0x00017AA4
	public static GUITransactionButton.InputState DrawWithBanner(TransactionButton_Layout layout, GUIControlsBanner.ActionSource source, ControllerActionButton action, Microsoft.Xna.Framework.Graphics.Texture2D itemTexture, string label, bool disabled, float scale, Microsoft.Xna.Framework.Graphics.Color? overloadedItemColour, bool forcedPressed = false, bool hasControllerFocus = false, bool forceOver = false, bool disablePressedState = false, bool drawWhenControllerConnected = false)
	{
		bool anyControllerConnected = ControllerActionManager.AnyControllerConnected;
		if (action != null)
		{
			if (!true)
			{
			}
			if (action == null || !true)
			{
			}
			GUITransactionButton.InputState inputState;
			return inputState;
		}
		GUITransactionButton.InputState inputState2;
		return inputState2;
	}

	// Token: 0x0600072D RID: 1837 RVA: 0x000198CC File Offset: 0x00017ACC
	public static GUITransactionButton.InputState Draw(TransactionButton_Layout layout, Microsoft.Xna.Framework.Graphics.Texture2D itemTexture, string label, bool disabled, float scale, Microsoft.Xna.Framework.Graphics.Color? overloadedItemColour, bool forcedPressed = false, bool hasControllerFocus = false, bool forceOver = false, bool disablePressedState = false)
	{
		if (layout != null)
		{
		}
		GUITransactionButton.InputState inputState;
		return inputState;
	}

	// Token: 0x0600072E RID: 1838 RVA: 0x000198E0 File Offset: 0x00017AE0
	public static GUITransactionButton.InputState DrawWithBanner(TransactionButton_Layout layout, GUIControlsBanner.ActionSource source, ControllerActionButton action, Microsoft.Xna.Framework.Graphics.Texture2D itemTexture, Rectangle srcRect, string label, bool disabled, float scale, Microsoft.Xna.Framework.Graphics.Color? overloadedItemColour, bool forcedPressed = false, bool hasControllerFocus = false, bool forceOver = false, bool disablePressedState = false, bool drawWhenControllerConnected = false)
	{
		GUITransactionButton.InputState inputState;
		return inputState;
	}

	// Token: 0x0600072F RID: 1839 RVA: 0x000198F0 File Offset: 0x00017AF0
	public static GUITransactionButton.InputState DrawWithBanner(TransactionButton_Layout layout, GUIControlsBanner.ActionSource source, ControllerActionButton action, Microsoft.Xna.Framework.Graphics.Texture2D itemTexture, Rectangle srcRect, Microsoft.Xna.Framework.Graphics.Texture2D itemTextureHighlight, Rectangle srcRectHighlight, string label, bool disabled, float scale, Microsoft.Xna.Framework.Graphics.Color? overloadedItemColour, bool forcedPressed = false, bool hasControllerFocus = false, bool forceOver = false, bool disablePressedState = false, bool drawWhenControllerConnected = false)
	{
		bool anyControllerConnected = ControllerActionManager.AnyControllerConnected;
		GUITransactionButton.InputState inputState;
		return inputState;
	}

	// Token: 0x06000730 RID: 1840 RVA: 0x0001990C File Offset: 0x00017B0C
	private static void DrawLabel(TransactionButton_Layout layout, string label, Microsoft.Xna.Framework.Graphics.Color labelColour, bool over)
	{
		bool drawLabel = layout.DrawLabel;
		if (drawLabel)
		{
			if (!drawLabel)
			{
			}
			bool mouseHoverFade = layout.MouseHoverFade;
			if (mouseHoverFade)
			{
				if (!mouseHoverFade)
				{
				}
				int tooltipTime = Main.tooltipTime;
				if (17279 == 0)
				{
				}
				return;
			}
			String_Layout label2 = layout.Label;
		}
	}

	// Token: 0x06000731 RID: 1841 RVA: 0x00019958 File Offset: 0x00017B58
	public static GUITransactionButton.InputState Draw(TransactionButton_Layout layout, Microsoft.Xna.Framework.Graphics.Texture2D itemTexture, Rectangle srcRect, string label, bool disabled, float scale, Microsoft.Xna.Framework.Graphics.Color? overloadedItemColour, bool forcedPressed = false, bool hasControllerFocus = false, bool forceOver = false, bool disablePressedState = false)
	{
		GUITransactionButton.InputState inputState;
		return inputState;
	}

	// Token: 0x06000732 RID: 1842 RVA: 0x00019968 File Offset: 0x00017B68
	public static GUITransactionButton.InputState Draw(TransactionButton_Layout layout, Microsoft.Xna.Framework.Graphics.Texture2D itemTexture, Rectangle srcRect, Microsoft.Xna.Framework.Graphics.Texture2D itemTextureHighlight, Rectangle srcRectHighlight, string label, bool disabled, float scale, Microsoft.Xna.Framework.Graphics.Color? overloadedItemColour, bool forcedPressed = false, bool hasControllerFocus = false, bool forceOver = false, bool disablePressedState = false)
	{
		int num = 1;
		if (num == 0)
		{
		}
		if (num == 0)
		{
		}
		bool mouseLeft = Main.mouseLeft;
		int num2 = 67;
		if (num2 != 0)
		{
			if (num2 == 0)
			{
			}
			bool mouseLeft2 = Main.mouseLeft;
			if (num2 == 0)
			{
			}
			bool mouseLeftRelease = Main.mouseLeftRelease;
		}
		bool mouseLeft3 = Main.mouseLeft;
		bool mouseLeftRelease2 = Main.mouseLeftRelease;
		Microsoft.Xna.Framework.Graphics.Texture2D texture2D;
		if (texture2D != null)
		{
			Microsoft.Xna.Framework.Graphics.Texture2D texture2D2;
			if (texture2D2 == null)
			{
				goto IL_005C;
			}
			Microsoft.Xna.Framework.Graphics.Texture2D texture2D3;
			if (texture2D3 != null)
			{
			}
		}
		long num3 = 0L;
		IL_005C:
		Microsoft.Xna.Framework.Graphics.Texture2D texture2D4;
		int width = texture2D4.Width;
		int arraySize = texture2D4.ArraySize;
		global::Cursor cursor;
		if ((num3 == 0L && num3 == 0L) || cursor != null)
		{
		}
		if (width == 0)
		{
		}
		Rectangle rectangle;
		int num4;
		int num6;
		if (rectangle != null && rectangle == null)
		{
			Microsoft.Xna.Framework.Graphics.Texture2D texture2D5;
			global::Cursor cursor2;
			if (texture2D5 == null || cursor2 != null)
			{
			}
			int width2 = texture2D4.Width;
			int arraySize2 = texture2D4.ArraySize;
			num4 = 32640;
			int num5 = 32768;
			Microsoft.Xna.Framework.Graphics.Texture2D texture2D6;
			int width3 = texture2D6.Width;
			int arraySize3 = texture2D6.ArraySize;
			if (42190736 != 0)
			{
			}
			if (42190736 == 0)
			{
			}
			num6 = 32640;
			if (num5 == 0)
			{
			}
		}
		Rectangle rectangle2;
		if (rectangle2 == null)
		{
		}
		if (num4 == 0)
		{
			return;
		}
		if (rectangle2 != null)
		{
			if (rectangle2 == null)
			{
			}
			if (rectangle2 == null)
			{
			}
		}
		if (rectangle2 == null)
		{
		}
		if (rectangle2 == null)
		{
		}
		int width4 = texture2D4.Width;
		int height = texture2D4.Height;
		if (rectangle2 == null)
		{
		}
		if (num6 == 0)
		{
		}
		if (disabled)
		{
			return;
		}
	}

	// Token: 0x04000594 RID: 1428
	public static bool disableControllerInput;

	// Token: 0x0200011D RID: 285
	public sealed class DrawItemHandler : MulticastDelegate
	{
		// Token: 0x06000733 RID: 1843 RVA: 0x00019AA0 File Offset: 0x00017CA0
		public DrawItemHandler(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x00019AF4 File Offset: 0x00017CF4
		public void Invoke(Microsoft.Xna.Framework.Vector2 position, float itemScale)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x000021DB File Offset: 0x000003DB
		public IAsyncResult BeginInvoke(Microsoft.Xna.Framework.Vector2 position, float itemScale, AsyncCallback callback, object @object)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x00019B18 File Offset: 0x00017D18
		public void EndInvoke(IAsyncResult result)
		{
		}
	}

	// Token: 0x0200011E RID: 286
	public enum InputState
	{
		// Token: 0x04000596 RID: 1430
		Clicked,
		// Token: 0x04000597 RID: 1431
		Over,
		// Token: 0x04000598 RID: 1432
		Down,
		// Token: 0x04000599 RID: 1433
		None
	}
}
