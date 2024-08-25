using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000017 RID: 23
	[AssetFileNameExtension("guiskin", new string[] { })]
	[RequiredByNativeCode]
	[ExecuteInEditMode]
	[Serializable]
	public sealed class GUISkin : ScriptableObject
	{
		// Token: 0x060000A0 RID: 160 RVA: 0x00003538 File Offset: 0x00001738
		public GUISkin()
		{
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x0000354C File Offset: 0x0000174C
		internal void OnEnable()
		{
			this.Apply();
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00003560 File Offset: 0x00001760
		internal static void CleanupRoots()
		{
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x00003570 File Offset: 0x00001770
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x00003584 File Offset: 0x00001784
		public Font font
		{
			get
			{
				return this.m_Font;
			}
			set
			{
				this.m_Font = value;
				bool flag = value == this;
				Font font = this.m_Font;
				throw new MissingMethodException();
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x000035B4 File Offset: 0x000017B4
		// (set) Token: 0x060000A6 RID: 166 RVA: 0x000035C8 File Offset: 0x000017C8
		public GUIStyle box
		{
			get
			{
				return this.m_box;
			}
			set
			{
				this.m_box = value;
				this.Apply();
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x000035E4 File Offset: 0x000017E4
		// (set) Token: 0x060000A8 RID: 168 RVA: 0x000035F8 File Offset: 0x000017F8
		public GUIStyle label
		{
			get
			{
				return this.m_label;
			}
			set
			{
				this.m_label = value;
				this.Apply();
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x00003614 File Offset: 0x00001814
		// (set) Token: 0x060000AA RID: 170 RVA: 0x00003628 File Offset: 0x00001828
		public GUIStyle textField
		{
			get
			{
				return this.m_textField;
			}
			set
			{
				this.m_textField = value;
				this.Apply();
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000AB RID: 171 RVA: 0x00003644 File Offset: 0x00001844
		// (set) Token: 0x060000AC RID: 172 RVA: 0x00003658 File Offset: 0x00001858
		public GUIStyle textArea
		{
			get
			{
				return this.m_textArea;
			}
			set
			{
				this.m_textArea = value;
				this.Apply();
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000AD RID: 173 RVA: 0x00003674 File Offset: 0x00001874
		// (set) Token: 0x060000AE RID: 174 RVA: 0x00003688 File Offset: 0x00001888
		public GUIStyle button
		{
			get
			{
				return this.m_button;
			}
			set
			{
				this.m_button = value;
				this.Apply();
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000AF RID: 175 RVA: 0x000036A4 File Offset: 0x000018A4
		// (set) Token: 0x060000B0 RID: 176 RVA: 0x000036B8 File Offset: 0x000018B8
		public GUIStyle toggle
		{
			get
			{
				return this.m_toggle;
			}
			set
			{
				this.m_toggle = value;
				this.Apply();
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x000036D4 File Offset: 0x000018D4
		// (set) Token: 0x060000B2 RID: 178 RVA: 0x000036E8 File Offset: 0x000018E8
		public GUIStyle window
		{
			get
			{
				return this.m_window;
			}
			set
			{
				this.m_window = value;
				this.Apply();
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x00003704 File Offset: 0x00001904
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x00003718 File Offset: 0x00001918
		public GUIStyle horizontalSlider
		{
			get
			{
				return this.m_horizontalSlider;
			}
			set
			{
				this.m_horizontalSlider = value;
				this.Apply();
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x00003734 File Offset: 0x00001934
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x00003748 File Offset: 0x00001948
		public GUIStyle horizontalSliderThumb
		{
			get
			{
				return this.m_horizontalSliderThumb;
			}
			set
			{
				this.m_horizontalSliderThumb = value;
				this.Apply();
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x00003764 File Offset: 0x00001964
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x00003778 File Offset: 0x00001978
		internal GUIStyle horizontalSliderThumbExtent
		{
			get
			{
				return this.m_horizontalSliderThumbExtent;
			}
			set
			{
				this.m_horizontalSliderThumbExtent = value;
				this.Apply();
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x00003794 File Offset: 0x00001994
		// (set) Token: 0x060000BA RID: 186 RVA: 0x000037A8 File Offset: 0x000019A8
		internal GUIStyle sliderMixed
		{
			get
			{
				return this.m_SliderMixed;
			}
			set
			{
				this.m_SliderMixed = value;
				this.Apply();
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000BB RID: 187 RVA: 0x000037C4 File Offset: 0x000019C4
		// (set) Token: 0x060000BC RID: 188 RVA: 0x000037D8 File Offset: 0x000019D8
		public GUIStyle verticalSlider
		{
			get
			{
				return this.m_verticalSlider;
			}
			set
			{
				this.m_verticalSlider = value;
				this.Apply();
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000BD RID: 189 RVA: 0x000037F4 File Offset: 0x000019F4
		// (set) Token: 0x060000BE RID: 190 RVA: 0x00003808 File Offset: 0x00001A08
		public GUIStyle verticalSliderThumb
		{
			get
			{
				return this.m_verticalSliderThumb;
			}
			set
			{
				this.m_verticalSliderThumb = value;
				this.Apply();
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000BF RID: 191 RVA: 0x00003824 File Offset: 0x00001A24
		// (set) Token: 0x060000C0 RID: 192 RVA: 0x00003838 File Offset: 0x00001A38
		internal GUIStyle verticalSliderThumbExtent
		{
			get
			{
				return this.m_verticalSliderThumbExtent;
			}
			set
			{
				this.m_verticalSliderThumbExtent = value;
				this.Apply();
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x00003854 File Offset: 0x00001A54
		// (set) Token: 0x060000C2 RID: 194 RVA: 0x00003868 File Offset: 0x00001A68
		public GUIStyle horizontalScrollbar
		{
			get
			{
				return this.m_horizontalScrollbar;
			}
			set
			{
				this.m_horizontalScrollbar = value;
				this.Apply();
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x00003884 File Offset: 0x00001A84
		// (set) Token: 0x060000C4 RID: 196 RVA: 0x00003898 File Offset: 0x00001A98
		public GUIStyle horizontalScrollbarThumb
		{
			get
			{
				return this.m_horizontalScrollbarThumb;
			}
			set
			{
				this.m_horizontalScrollbarThumb = value;
				this.Apply();
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x000038B4 File Offset: 0x00001AB4
		// (set) Token: 0x060000C6 RID: 198 RVA: 0x000038C8 File Offset: 0x00001AC8
		public GUIStyle horizontalScrollbarLeftButton
		{
			get
			{
				return this.m_horizontalScrollbarLeftButton;
			}
			set
			{
				this.m_horizontalScrollbarLeftButton = value;
				this.Apply();
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x000038E4 File Offset: 0x00001AE4
		// (set) Token: 0x060000C8 RID: 200 RVA: 0x000038F8 File Offset: 0x00001AF8
		public GUIStyle horizontalScrollbarRightButton
		{
			get
			{
				return this.m_horizontalScrollbarRightButton;
			}
			set
			{
				this.m_horizontalScrollbarRightButton = value;
				this.Apply();
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x00003914 File Offset: 0x00001B14
		// (set) Token: 0x060000CA RID: 202 RVA: 0x00003928 File Offset: 0x00001B28
		public GUIStyle verticalScrollbar
		{
			get
			{
				return this.m_verticalScrollbar;
			}
			set
			{
				this.m_verticalScrollbar = value;
				this.Apply();
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000CB RID: 203 RVA: 0x00003944 File Offset: 0x00001B44
		// (set) Token: 0x060000CC RID: 204 RVA: 0x00003958 File Offset: 0x00001B58
		public GUIStyle verticalScrollbarThumb
		{
			get
			{
				return this.m_verticalScrollbarThumb;
			}
			set
			{
				this.m_verticalScrollbarThumb = value;
				this.Apply();
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000CD RID: 205 RVA: 0x00003974 File Offset: 0x00001B74
		// (set) Token: 0x060000CE RID: 206 RVA: 0x00003988 File Offset: 0x00001B88
		public GUIStyle verticalScrollbarUpButton
		{
			get
			{
				return this.m_verticalScrollbarUpButton;
			}
			set
			{
				this.m_verticalScrollbarUpButton = value;
				this.Apply();
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000CF RID: 207 RVA: 0x000039A4 File Offset: 0x00001BA4
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x000039B8 File Offset: 0x00001BB8
		public GUIStyle verticalScrollbarDownButton
		{
			get
			{
				return this.m_verticalScrollbarDownButton;
			}
			set
			{
				this.m_verticalScrollbarDownButton = value;
				this.Apply();
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x000039D4 File Offset: 0x00001BD4
		// (set) Token: 0x060000D2 RID: 210 RVA: 0x000039E8 File Offset: 0x00001BE8
		public GUIStyle scrollView
		{
			get
			{
				return this.m_ScrollView;
			}
			set
			{
				this.m_ScrollView = value;
				this.Apply();
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x00003A04 File Offset: 0x00001C04
		// (set) Token: 0x060000D4 RID: 212 RVA: 0x00003A18 File Offset: 0x00001C18
		public GUIStyle[] customStyles
		{
			get
			{
				return this.m_CustomStyles;
			}
			set
			{
				this.m_CustomStyles = value;
				this.Apply();
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x00003A34 File Offset: 0x00001C34
		public GUISettings settings
		{
			get
			{
				return this.m_Settings;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x00003A48 File Offset: 0x00001C48
		internal static GUIStyle error
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00003A5C File Offset: 0x00001C5C
		internal void Apply()
		{
			if (this.m_CustomStyles == null)
			{
				Debug.Log("custom styles is null");
			}
			this.BuildStyleCache();
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00003A84 File Offset: 0x00001C84
		private void BuildStyleCache()
		{
			if (this.m_box == null)
			{
			}
			if (this.m_button == null)
			{
			}
			if (this.m_toggle == null)
			{
			}
			if (this.m_label == null)
			{
			}
			if (this.m_window == null)
			{
			}
			if (this.m_textField == null)
			{
			}
			if (this.m_textArea == null)
			{
			}
			if (this.m_horizontalSlider == null)
			{
			}
			if (this.m_horizontalSliderThumb == null)
			{
			}
			if (this.m_verticalSlider == null)
			{
			}
			if (this.m_verticalSliderThumb == null)
			{
			}
			if (this.m_horizontalScrollbar == null)
			{
			}
			if (this.m_horizontalScrollbarThumb == null)
			{
			}
			if (this.m_horizontalScrollbarLeftButton == null)
			{
			}
			if (this.m_horizontalScrollbarRightButton == null)
			{
			}
			if (this.m_verticalScrollbar == null)
			{
			}
			if (this.m_verticalScrollbarThumb == null)
			{
			}
			if (this.m_verticalScrollbarUpButton == null)
			{
			}
			if (this.m_verticalScrollbarDownButton == null)
			{
			}
			GUIStyle scrollView = this.m_ScrollView;
			if (scrollView == null)
			{
			}
			if (scrollView == null)
			{
			}
			if (!true)
			{
			}
			GUIStyle box = this.m_box;
			this.m_box.m_Name = "box";
			throw new MissingMethodException();
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00003EEC File Offset: 0x000020EC
		public GUIStyle GetStyle(string styleName)
		{
			while (this.FindStyle(styleName) != null)
			{
			}
			if (("Unable to find style '" == null || "Unable to find style '" != null) && (styleName == null || styleName != null) && ("' in skin '" == null || "' in skin '" != null))
			{
				string name = base.name;
				if ((name == null || name != null) && ("' " == null || "' " != null))
				{
					throw new MissingMethodException();
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00003F6C File Offset: 0x0000216C
		public GUIStyle FindStyle(string styleName)
		{
			/*
An exception occurred when decompiling this method (060000DA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.GUIStyle UnityEngine.GUISkin::FindStyle(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(GUISkin::BuildStyleCache, ldloc:GUISkin(this))
	stloc:class [mscorlib]System.Collections.Generic.Dictionary`2<string, class UnityEngine.GUIStyle>(var_0_14, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<string, class UnityEngine.GUIStyle>(GUISkin::m_Styles, ldloc:GUISkin(this)))
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

		// Token: 0x060000DB RID: 219 RVA: 0x00003F90 File Offset: 0x00002190
		internal void MakeCurrent()
		{
			Font font = this.m_Font;
			throw new MissingMethodException();
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00003FAC File Offset: 0x000021AC
		public IEnumerator GetEnumerator()
		{
			/*
An exception occurred when decompiling this method (060000DC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.IEnumerator UnityEngine.GUISkin::GetEnumerator()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(GUISkin::BuildStyleCache, ldloc:GUISkin(this))
	stloc:class [mscorlib]System.Collections.Generic.Dictionary`2<string, class UnityEngine.GUIStyle>(var_0_14, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<string, class UnityEngine.GUIStyle>(GUISkin::m_Styles, ldloc:GUISkin(this)))
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

		// Token: 0x04000089 RID: 137
		[SerializeField]
		private Font m_Font;

		// Token: 0x0400008A RID: 138
		[SerializeField]
		private GUIStyle m_box;

		// Token: 0x0400008B RID: 139
		[SerializeField]
		private GUIStyle m_button;

		// Token: 0x0400008C RID: 140
		[SerializeField]
		private GUIStyle m_toggle;

		// Token: 0x0400008D RID: 141
		[SerializeField]
		private GUIStyle m_label;

		// Token: 0x0400008E RID: 142
		[SerializeField]
		private GUIStyle m_textField;

		// Token: 0x0400008F RID: 143
		[SerializeField]
		private GUIStyle m_textArea;

		// Token: 0x04000090 RID: 144
		[SerializeField]
		private GUIStyle m_window;

		// Token: 0x04000091 RID: 145
		[SerializeField]
		private GUIStyle m_horizontalSlider;

		// Token: 0x04000092 RID: 146
		[SerializeField]
		private GUIStyle m_horizontalSliderThumb;

		// Token: 0x04000093 RID: 147
		[NonSerialized]
		private GUIStyle m_horizontalSliderThumbExtent;

		// Token: 0x04000094 RID: 148
		[SerializeField]
		private GUIStyle m_verticalSlider;

		// Token: 0x04000095 RID: 149
		[SerializeField]
		private GUIStyle m_verticalSliderThumb;

		// Token: 0x04000096 RID: 150
		[NonSerialized]
		private GUIStyle m_verticalSliderThumbExtent;

		// Token: 0x04000097 RID: 151
		[NonSerialized]
		private GUIStyle m_SliderMixed;

		// Token: 0x04000098 RID: 152
		[SerializeField]
		private GUIStyle m_horizontalScrollbar;

		// Token: 0x04000099 RID: 153
		[SerializeField]
		private GUIStyle m_horizontalScrollbarThumb;

		// Token: 0x0400009A RID: 154
		[SerializeField]
		private GUIStyle m_horizontalScrollbarLeftButton;

		// Token: 0x0400009B RID: 155
		[SerializeField]
		private GUIStyle m_horizontalScrollbarRightButton;

		// Token: 0x0400009C RID: 156
		[SerializeField]
		private GUIStyle m_verticalScrollbar;

		// Token: 0x0400009D RID: 157
		[SerializeField]
		private GUIStyle m_verticalScrollbarThumb;

		// Token: 0x0400009E RID: 158
		[SerializeField]
		private GUIStyle m_verticalScrollbarUpButton;

		// Token: 0x0400009F RID: 159
		[SerializeField]
		private GUIStyle m_verticalScrollbarDownButton;

		// Token: 0x040000A0 RID: 160
		[SerializeField]
		private GUIStyle m_ScrollView;

		// Token: 0x040000A1 RID: 161
		[SerializeField]
		internal GUIStyle[] m_CustomStyles;

		// Token: 0x040000A2 RID: 162
		[SerializeField]
		private GUISettings m_Settings;

		// Token: 0x040000A3 RID: 163
		internal static GUIStyle ms_Error;

		// Token: 0x040000A4 RID: 164
		private Dictionary<string, GUIStyle> m_Styles;

		// Token: 0x040000A5 RID: 165
		internal static GUISkin.SkinChangedDelegate m_SkinChanged;

		// Token: 0x040000A6 RID: 166
		internal static GUISkin current;

		// Token: 0x02000018 RID: 24
		internal sealed class SkinChangedDelegate : MulticastDelegate
		{
			// Token: 0x060000DD RID: 221 RVA: 0x00003FD0 File Offset: 0x000021D0
			public SkinChangedDelegate(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x060000DE RID: 222 RVA: 0x00004024 File Offset: 0x00002224
			public void Invoke()
			{
				IntPtr method_code = this.method_code;
				IntPtr invoke_impl = this.invoke_impl;
				IntPtr method = this.method;
			}
		}
	}
}
