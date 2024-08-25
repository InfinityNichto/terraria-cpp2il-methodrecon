using System;
using Cpp2IlInjected;

namespace UnityEngine.UI
{
	// Token: 0x0200000F RID: 15
	public static class DefaultControls
	{
		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000059 RID: 89 RVA: 0x00002B64 File Offset: 0x00000D64
		public static DefaultControls.IFactoryControls factory
		{
			get
			{
				if (!true)
				{
				}
				return 1;
			}
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002207 File Offset: 0x00000407
		private static GameObject CreateUIElementRoot(string name, Vector2 size, params Type[] components)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002B78 File Offset: 0x00000D78
		private static GameObject CreateUIObject(string name, GameObject parent, params Type[] components)
		{
			/*
An exception occurred when decompiling this method (0600005B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.GameObject UnityEngine.UI.DefaultControls::CreateUIObject(System.String,UnityEngine.GameObject,System.Type[])

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
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

		// Token: 0x0600005C RID: 92 RVA: 0x00002B8C File Offset: 0x00000D8C
		private static void SetDefaultTextValues(Text lbl)
		{
			if (!true)
			{
			}
			Font font = lbl.font;
			lbl.AssignDefaultFont();
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002BAC File Offset: 0x00000DAC
		private static void SetDefaultColorTransitionValues(Selectable slider)
		{
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002BBC File Offset: 0x00000DBC
		private static void SetParentAndAlign(GameObject child, GameObject parent)
		{
			if (!true)
			{
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002BF8 File Offset: 0x00000DF8
		private static void SetLayerRecursively(GameObject go, int layer)
		{
			go.layer = layer;
			Transform transform = go.transform;
			int childCount = transform.childCount;
			long num = 0L;
			DefaultControls.SetLayerRecursively(transform.GetChild((int)num).gameObject, layer);
			int childCount2 = transform.childCount;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002C38 File Offset: 0x00000E38
		public static GameObject CreatePanel(DefaultControls.Resources resources)
		{
			if (!true)
			{
			}
			Type type;
			if (type == null || type != null)
			{
				GameObject gameObject;
				RectTransform component = gameObject.GetComponent<RectTransform>();
				gameObject.GetComponent<Image>().type = Image.Type.Sliced;
				return gameObject;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002C68 File Offset: 0x00000E68
		public static GameObject CreateButton(DefaultControls.Resources resources)
		{
			if (!true)
			{
			}
			Type type;
			Type type2;
			Type type3;
			if ((type == null || type != null) && (type2 == null || type2 != null) && (type3 == null || type3 != null))
			{
				GameObject gameObject;
				gameObject.GetComponent<Image>().type = Image.Type.Sliced;
				Button component = gameObject.GetComponent<Button>();
				GameObject gameObject2;
				Text component2 = gameObject2.GetComponent<Text>();
				component2.alignment = TextAnchor.MiddleCenter;
				DefaultControls.SetDefaultTextValues(component2);
				RectTransform component3 = gameObject2.GetComponent<RectTransform>();
				return gameObject;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002CC8 File Offset: 0x00000EC8
		public static GameObject CreateText(DefaultControls.Resources resources)
		{
			if (!true)
			{
			}
			Type type;
			if (type == null || type != null)
			{
				GameObject gameObject;
				DefaultControls.SetDefaultTextValues(gameObject.GetComponent<Text>());
				return gameObject;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002CF0 File Offset: 0x00000EF0
		public static GameObject CreateImage(DefaultControls.Resources resources)
		{
			if (!true)
			{
			}
			Type type;
			if (type == null || type != null)
			{
				GameObject gameObject;
				return gameObject;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002D10 File Offset: 0x00000F10
		public static GameObject CreateRawImage(DefaultControls.Resources resources)
		{
			if (!true)
			{
			}
			Type type;
			if (type == null || type != null)
			{
				GameObject gameObject;
				return gameObject;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002D30 File Offset: 0x00000F30
		public static GameObject CreateSlider(DefaultControls.Resources resources)
		{
			if (!true)
			{
			}
			Type type;
			Type type2;
			Type type3;
			Type type4;
			Type type5;
			Type type6;
			if ((type == null || type != null) && (type2 == null || type2 != null) && (type3 == null || type3 != null) && (type4 == null || type4 != null) && (type5 == null || type5 != null) && (type6 == null || type6 != null))
			{
				GameObject gameObject;
				gameObject.GetComponent<Image>().type = Image.Type.Sliced;
				RectTransform component = gameObject.GetComponent<RectTransform>();
				GameObject gameObject2;
				RectTransform component2 = gameObject2.GetComponent<RectTransform>();
				GameObject gameObject3;
				gameObject3.GetComponent<Image>().type = Image.Type.Sliced;
				RectTransform component3 = gameObject3.GetComponent<RectTransform>();
				GameObject gameObject4;
				RectTransform component4 = gameObject4.GetComponent<RectTransform>();
				GameObject gameObject5;
				Image component5 = gameObject5.GetComponent<Image>();
				RectTransform component6 = gameObject5.GetComponent<RectTransform>();
				GameObject gameObject6;
				Slider component7 = gameObject6.GetComponent<Slider>();
				RectTransform component8 = gameObject3.GetComponent<RectTransform>();
				component7.fillRect = component8;
				RectTransform component9 = gameObject5.GetComponent<RectTransform>();
				component7.handleRect = component9;
				component7.targetGraphic = component5;
				return gameObject6;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002E08 File Offset: 0x00001008
		public static GameObject CreateScrollbar(DefaultControls.Resources resources)
		{
			if (!true)
			{
			}
			Type type;
			Type type2;
			Type type3;
			Type type4;
			if ((type == null || type != null) && (type2 == null || type2 != null) && (type3 == null || type3 != null) && (type4 == null || type4 != null))
			{
				GameObject gameObject;
				gameObject.GetComponent<Image>().type = Image.Type.Sliced;
				GameObject gameObject2;
				Image component = gameObject2.GetComponent<Image>();
				component.type = Image.Type.Sliced;
				GameObject gameObject3;
				RectTransform component2 = gameObject3.GetComponent<RectTransform>();
				RectTransform component3 = gameObject2.GetComponent<RectTransform>();
				Scrollbar component4 = gameObject.GetComponent<Scrollbar>();
				component4.handleRect = component3;
				component4.targetGraphic = component;
				return gameObject;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002E84 File Offset: 0x00001084
		public static GameObject CreateToggle(DefaultControls.Resources resources)
		{
			if (!true)
			{
			}
			Type type;
			Type type2;
			Type type3;
			Type type4;
			if ((type == null || type != null) && (type2 == null || type2 != null) && (type3 == null || type3 != null) && (type4 == null || type4 != null))
			{
				GameObject gameObject;
				Toggle component = gameObject.GetComponent<Toggle>();
				component.isOn = true;
				GameObject gameObject2;
				Image component2 = gameObject2.GetComponent<Image>();
				component2.type = Image.Type.Sliced;
				GameObject gameObject3;
				Image component3 = gameObject3.GetComponent<Image>();
				GameObject gameObject4;
				DefaultControls.SetDefaultTextValues(gameObject4.GetComponent<Text>());
				component.graphic = component3;
				component.targetGraphic = component2;
				RectTransform component4 = gameObject2.GetComponent<RectTransform>();
				RectTransform component5 = gameObject3.GetComponent<RectTransform>();
				RectTransform component6 = gameObject4.GetComponent<RectTransform>();
				return gameObject;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002F1C File Offset: 0x0000111C
		public static GameObject CreateInputField(DefaultControls.Resources resources)
		{
			if (!true)
			{
			}
			Type type;
			Type type2;
			Type type3;
			Type type4;
			if ((type == null || type != null) && (type2 == null || type2 != null) && (type3 == null || type3 != null) && (type4 == null || type4 != null))
			{
				GameObject gameObject;
				gameObject.GetComponent<Image>().type = Image.Type.Sliced;
				InputField component = gameObject.GetComponent<InputField>();
				GameObject gameObject2;
				Text component2 = gameObject2.GetComponent<Text>();
				DefaultControls.SetDefaultTextValues(component2);
				GameObject gameObject3;
				Text component3 = gameObject3.GetComponent<Text>();
				component3.fontStyle = FontStyle.Italic;
				RectTransform component4 = gameObject2.GetComponent<RectTransform>();
				RectTransform component5 = gameObject3.GetComponent<RectTransform>();
				component.textComponent = component2;
				component.placeholder = component3;
				return gameObject;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002207 File Offset: 0x00000407
		public static GameObject CreateDropdown(DefaultControls.Resources resources)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002FAC File Offset: 0x000011AC
		public static GameObject CreateScrollView(DefaultControls.Resources resources)
		{
			Type type;
			Type type2;
			Type type3;
			Type type4;
			Type type5;
			if ((type == null || type != null) && (type2 == null || type2 != null) && (type3 == null || type3 != null) && (type4 == null || type4 != null) && (type5 == null || type5 != null))
			{
				GameObject gameObject;
				gameObject.name = "Scrollbar Horizontal";
				GameObject gameObject2;
				DefaultControls.SetParentAndAlign(gameObject, gameObject2);
				Vector2 sizeDelta = gameObject.GetComponent<RectTransform>().sizeDelta;
				GameObject gameObject3;
				gameObject3.name = "Scrollbar Vertical";
				DefaultControls.SetParentAndAlign(gameObject3, gameObject2);
				gameObject3.GetComponent<Scrollbar>().SetDirection(Scrollbar.Direction.BottomToTop, true);
				Vector2 sizeDelta2 = gameObject3.GetComponent<RectTransform>().sizeDelta;
				GameObject gameObject4;
				RectTransform component = gameObject4.GetComponent<RectTransform>();
				ScrollRect component2 = gameObject2.GetComponent<ScrollRect>();
				RectTransform rectTransform;
				component2.m_Content = rectTransform;
				component2.viewport = component;
				Scrollbar component3 = gameObject.GetComponent<Scrollbar>();
				component2.horizontalScrollbar = component3;
				Scrollbar component4 = gameObject3.GetComponent<Scrollbar>();
				component2.verticalScrollbar = component4;
				component2.horizontalScrollbarVisibility = ScrollRect.ScrollbarVisibility.AutoHideAndExpandViewport;
				component2.verticalScrollbarVisibility = ScrollRect.ScrollbarVisibility.AutoHideAndExpandViewport;
				component2.horizontalScrollbarSpacing = float.Epsilon;
				component2.verticalScrollbarSpacing = float.Epsilon;
				Image image;
				image.type = Image.Type.Sliced;
				Mask component5 = gameObject4.GetComponent<Mask>();
				long num = 0L;
				component5.showMaskGraphic = num != 0L;
				Image image2;
				image2.type = Image.Type.Sliced;
				return gameObject2;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600006B RID: 107 RVA: 0x000030D8 File Offset: 0x000012D8
		// Note: this type is marked as 'beforefieldinit'.
		static DefaultControls()
		{
			if (!true)
			{
			}
		}

		// Token: 0x0400002C RID: 44
		private static DefaultControls.IFactoryControls m_CurrentFactory;

		// Token: 0x0400002D RID: 45
		private const float kWidth = 160f;

		// Token: 0x0400002E RID: 46
		private const float kThickHeight = 30f;

		// Token: 0x0400002F RID: 47
		private const float kThinHeight = 20f;

		// Token: 0x04000030 RID: 48
		private static Vector2 s_ThickElementSize;

		// Token: 0x04000031 RID: 49
		private static Vector2 s_ThinElementSize;

		// Token: 0x04000032 RID: 50
		private static Vector2 s_ImageElementSize;

		// Token: 0x04000033 RID: 51
		private static Color s_DefaultSelectableColor;

		// Token: 0x04000034 RID: 52
		private static Color s_PanelColor;

		// Token: 0x04000035 RID: 53
		private static Color s_TextColor;

		// Token: 0x02000010 RID: 16
		public interface IFactoryControls
		{
			// Token: 0x0600006C RID: 108
			GameObject CreateGameObject(string name, params Type[] components);
		}

		// Token: 0x02000011 RID: 17
		private class DefaultRuntimeFactory : DefaultControls.IFactoryControls
		{
			// Token: 0x0600006D RID: 109 RVA: 0x00002207 File Offset: 0x00000407
			public GameObject CreateGameObject(string name, params Type[] components)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x0600006E RID: 110 RVA: 0x000030E8 File Offset: 0x000012E8
			public DefaultRuntimeFactory()
			{
			}

			// Token: 0x0600006F RID: 111 RVA: 0x000030FC File Offset: 0x000012FC
			// Note: this type is marked as 'beforefieldinit'.
			static DefaultRuntimeFactory()
			{
			}

			// Token: 0x04000036 RID: 54
			public static DefaultControls.IFactoryControls Default;
		}

		// Token: 0x02000012 RID: 18
		public struct Resources
		{
			// Token: 0x04000037 RID: 55
			public Sprite standard;

			// Token: 0x04000038 RID: 56
			public Sprite background;

			// Token: 0x04000039 RID: 57
			public Sprite inputField;

			// Token: 0x0400003A RID: 58
			public Sprite knob;

			// Token: 0x0400003B RID: 59
			public Sprite checkmark;

			// Token: 0x0400003C RID: 60
			public Sprite dropdown;

			// Token: 0x0400003D RID: 61
			public Sprite mask;
		}
	}
}
