using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace UnityEngine.UI
{
	// Token: 0x02000072 RID: 114
	[AddComponentMenu("UI/Legacy/Text", 100)]
	[RequireComponent(typeof(CanvasRenderer))]
	public class Text : MaskableGraphic, ILayoutElement
	{
		// Token: 0x0600049B RID: 1179 RVA: 0x0000EA94 File Offset: 0x0000CC94
		protected Text()
		{
			FontData defaultFontData = FontData.defaultFontData;
			this.m_FontData = defaultFontData;
			base..ctor();
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x0600049C RID: 1180 RVA: 0x0000EAB8 File Offset: 0x0000CCB8
		public TextGenerator cachedTextGenerator
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600049C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.TextGenerator UnityEngine.UI.Text::get_cachedTextGenerator()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	brtrue(IL_0000, logicnot:bool(ldfld:int32[exp:bool](string::_stringLength, ldfld:string(Text::m_Text, ldloc:Text(this)))))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
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
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x0600049D RID: 1181 RVA: 0x0000EADC File Offset: 0x0000CCDC
		public TextGenerator cachedTextGeneratorForLayout
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600049D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.TextGenerator UnityEngine.UI.Text::get_cachedTextGeneratorForLayout()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:TextGenerator[exp:bool](Text::m_TextCacheForLayout, ldloc:Text(this)))
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
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x0600049E RID: 1182 RVA: 0x0000EAF0 File Offset: 0x0000CCF0
		public override Texture mainTexture
		{
			get
			{
				Font font = this.m_FontData.m_Font;
				Material material = this.m_FontData.m_Font.material;
				Texture mainTexture = this.m_FontData.m_Font.material.mainTexture;
				FontData fontData = this.m_FontData;
				Material material2 = fontData.m_Font.material;
				Material material3 = this.m_Material;
				if (fontData == null)
				{
				}
				return this.m_Material.mainTexture;
			}
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x0000EB64 File Offset: 0x0000CD64
		public void FontTextureChanged()
		{
			if (!true)
			{
			}
			bool flag = this;
			if (!this.m_DisableFontTextureRebuiltCallback)
			{
				this.cachedTextGenerator.Invalidate();
				bool flag2 = CanvasUpdateRegistry.IsRebuildingGraphics();
				bool flag3 = CanvasUpdateRegistry.IsRebuildingLayout();
				return;
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060004A0 RID: 1184 RVA: 0x0000EBA4 File Offset: 0x0000CDA4
		// (set) Token: 0x060004A1 RID: 1185 RVA: 0x0000EBBC File Offset: 0x0000CDBC
		public Font font
		{
			get
			{
				return this.m_FontData.m_Font;
			}
			set
			{
				FontData fontData = this.m_FontData;
				bool flag = fontData.m_Font == value;
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060004A2 RID: 1186 RVA: 0x0000EC10 File Offset: 0x0000CE10
		// (set) Token: 0x060004A3 RID: 1187 RVA: 0x0000EC24 File Offset: 0x0000CE24
		public virtual string text
		{
			get
			{
				return this.m_Text;
			}
			set
			{
				bool flag = string.IsNullOrEmpty(value);
				bool flag2 = string.IsNullOrEmpty(this.m_Text);
				this.m_Text = "";
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x060004A4 RID: 1188 RVA: 0x0000EC64 File Offset: 0x0000CE64
		// (set) Token: 0x060004A5 RID: 1189 RVA: 0x0000EC7C File Offset: 0x0000CE7C
		public bool supportRichText
		{
			get
			{
				return this.m_FontData.m_RichText;
			}
			set
			{
				FontData fontData = this.m_FontData;
				bool richText = fontData.m_RichText;
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x060004A6 RID: 1190 RVA: 0x0000ECA0 File Offset: 0x0000CEA0
		// (set) Token: 0x060004A7 RID: 1191 RVA: 0x0000ECB8 File Offset: 0x0000CEB8
		public bool resizeTextForBestFit
		{
			get
			{
				return this.m_FontData.m_BestFit;
			}
			set
			{
				FontData fontData = this.m_FontData;
				bool bestFit = fontData.m_BestFit;
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060004A8 RID: 1192 RVA: 0x0000ECDC File Offset: 0x0000CEDC
		// (set) Token: 0x060004A9 RID: 1193 RVA: 0x0000ECF4 File Offset: 0x0000CEF4
		public int resizeTextMinSize
		{
			get
			{
				return this.m_FontData.m_MinSize;
			}
			set
			{
				FontData fontData = this.m_FontData;
				int minSize = fontData.m_MinSize;
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060004AA RID: 1194 RVA: 0x0000ED18 File Offset: 0x0000CF18
		// (set) Token: 0x060004AB RID: 1195 RVA: 0x0000ED30 File Offset: 0x0000CF30
		public int resizeTextMaxSize
		{
			get
			{
				return this.m_FontData.m_MaxSize;
			}
			set
			{
				FontData fontData = this.m_FontData;
				int maxSize = fontData.m_MaxSize;
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x060004AC RID: 1196 RVA: 0x0000ED54 File Offset: 0x0000CF54
		// (set) Token: 0x060004AD RID: 1197 RVA: 0x0000ED6C File Offset: 0x0000CF6C
		public TextAnchor alignment
		{
			get
			{
				return this.m_FontData.m_Alignment;
			}
			set
			{
				FontData fontData = this.m_FontData;
				TextAnchor alignment = fontData.m_Alignment;
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060004AE RID: 1198 RVA: 0x0000ED90 File Offset: 0x0000CF90
		// (set) Token: 0x060004AF RID: 1199 RVA: 0x0000EDA8 File Offset: 0x0000CFA8
		public bool alignByGeometry
		{
			get
			{
				return this.m_FontData.m_AlignByGeometry;
			}
			set
			{
				FontData fontData = this.m_FontData;
				bool alignByGeometry = fontData.m_AlignByGeometry;
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060004B0 RID: 1200 RVA: 0x0000EDCC File Offset: 0x0000CFCC
		// (set) Token: 0x060004B1 RID: 1201 RVA: 0x0000EDE4 File Offset: 0x0000CFE4
		public int fontSize
		{
			get
			{
				return this.m_FontData.m_FontSize;
			}
			set
			{
				FontData fontData = this.m_FontData;
				int fontSize = fontData.m_FontSize;
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x060004B2 RID: 1202 RVA: 0x0000EE08 File Offset: 0x0000D008
		// (set) Token: 0x060004B3 RID: 1203 RVA: 0x0000EE20 File Offset: 0x0000D020
		public HorizontalWrapMode horizontalOverflow
		{
			get
			{
				return this.m_FontData.m_HorizontalOverflow;
			}
			set
			{
				FontData fontData = this.m_FontData;
				HorizontalWrapMode horizontalOverflow = fontData.m_HorizontalOverflow;
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060004B4 RID: 1204 RVA: 0x0000EE44 File Offset: 0x0000D044
		// (set) Token: 0x060004B5 RID: 1205 RVA: 0x0000EE5C File Offset: 0x0000D05C
		public VerticalWrapMode verticalOverflow
		{
			get
			{
				return this.m_FontData.m_VerticalOverflow;
			}
			set
			{
				FontData fontData = this.m_FontData;
				VerticalWrapMode verticalOverflow = fontData.m_VerticalOverflow;
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060004B6 RID: 1206 RVA: 0x0000EE80 File Offset: 0x0000D080
		// (set) Token: 0x060004B7 RID: 1207 RVA: 0x0000EE98 File Offset: 0x0000D098
		public float lineSpacing
		{
			get
			{
				/*
An exception occurred when decompiling this method (060004B6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single UnityEngine.UI.Text::get_lineSpacing()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_0B, ldfld:float32(FontData::m_LineSpacing, ldfld:FontData(Text::m_FontData, ldloc:Text(this))))
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
				float lineSpacing = this.m_FontData.m_LineSpacing;
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060004B8 RID: 1208 RVA: 0x0000EEB4 File Offset: 0x0000D0B4
		// (set) Token: 0x060004B9 RID: 1209 RVA: 0x0000EECC File Offset: 0x0000D0CC
		public FontStyle fontStyle
		{
			get
			{
				return this.m_FontData.m_FontStyle;
			}
			set
			{
				FontData fontData = this.m_FontData;
				FontStyle fontStyle = fontData.m_FontStyle;
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060004BA RID: 1210 RVA: 0x0000EEF0 File Offset: 0x0000D0F0
		public float pixelsPerUnit
		{
			get
			{
				/*
An exception occurred when decompiling this method (060004BA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single UnityEngine.UI.Text::get_pixelsPerUnit()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Canvas(var_0_06, callgetter:Canvas(Graphic::get_canvas, ldloc:Text[exp:Graphic](this)))
	stloc:bool(var_1_0D, call:bool(Object::op_Implicit, ldloc:Canvas[exp:Object](var_0_06)))
	stloc:bool(var_2_1E, call:bool(Object::op_Implicit, ldfld:Font[exp:Object](FontData::m_Font, ldfld:FontData(Text::m_FontData, ldloc:Text(this)))))
	stloc:bool(var_3_2F, callgetter:bool(Font::get_dynamic, ldfld:Font(FontData::m_Font, ldfld:FontData(Text::m_FontData, ldloc:Text(this)))))
	stloc:float32(var_4_36, callgetter:float32(Canvas::get_scaleFactor, ldloc:Canvas(var_0_06)))
	stloc:FontData(var_5_3E, ldfld:FontData(Text::m_FontData, ldloc:Text(this)))
	stloc:int32(var_6_47, ldfld:int32(FontData::m_FontSize, ldloc:FontData(var_5_3E)))
	stloc:int32(var_7_55, callgetter:int32(Font::get_fontSize, ldfld:Font(FontData::m_Font, ldloc:FontData(var_5_3E))))
	stloc:int32(var_8_67, callgetter:int32(Font::get_fontSize, ldfld:Font(FontData::m_Font, ldfld:FontData(Text::m_FontData, ldloc:Text(this)))))
	stloc:int32(var_9_74, ldfld:int32(FontData::m_FontSize, ldfld:FontData(Text::m_FontData, ldloc:Text(this))))
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

		// Token: 0x060004BB RID: 1211 RVA: 0x0000EF74 File Offset: 0x0000D174
		protected override void OnEnable()
		{
			base.OnEnable();
			this.cachedTextGenerator.Invalidate();
			if (!true)
			{
			}
			FontUpdateTracker.TrackText(this);
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x0000EF9C File Offset: 0x0000D19C
		protected override void OnDisable()
		{
			if (!true)
			{
			}
			FontUpdateTracker.UntrackText(this);
			base.OnDisable();
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x0000EFB8 File Offset: 0x0000D1B8
		protected override void UpdateGeometry()
		{
			Font font = this.m_FontData.m_Font;
			base.UpdateGeometry();
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x0000EFD8 File Offset: 0x0000D1D8
		internal void AssignDefaultFont()
		{
			Font builtinResource = Resources.GetBuiltinResource<Font>("Arial.ttf");
			this.font = builtinResource;
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x0000EFF8 File Offset: 0x0000D1F8
		internal void AssignDefaultFontIfNecessary()
		{
			Font font = this.m_FontData.m_Font;
			Font builtinResource = Resources.GetBuiltinResource<Font>("Arial.ttf");
			this.font = builtinResource;
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x0000F024 File Offset: 0x0000D224
		public TextGenerationSettings GetGenerationSettings(Vector2 extents)
		{
			/*
An exception occurred when decompiling this method (060004C0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.TextGenerationSettings UnityEngine.UI.Text::GetGenerationSettings(UnityEngine.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Font(var_1_0B, ldfld:Font(FontData::m_Font, ldfld:FontData(Text::m_FontData, ldloc:Text(this))))
	stloc:bool(var_3_1C, callgetter:bool(Font::get_dynamic, ldfld:Font(FontData::m_Font, ldfld:FontData(Text::m_FontData, ldloc:Text(this)))))
	stloc:int32(var_4_28, ldfld:int32(FontData::m_FontSize, ldfld:FontData(Text::m_FontData, ldloc:Text(this))))
	stloc:int64(var_5_2B, ldc.i4:int64(0))
	stloc:FontData(var_6_33, ldfld:FontData(Text::m_FontData, ldloc:Text(this)))
	stloc:TextAnchor(var_7_3C, ldfld:TextAnchor(FontData::m_Alignment, ldloc:FontData(var_6_33)))
	stloc:bool(var_8_45, ldfld:bool(FontData::m_AlignByGeometry, ldloc:FontData(var_6_33)))
	stloc:float32(var_9_4D, callgetter:float32(Text::get_pixelsPerUnit, ldloc:Text(this)))
	stloc:Font(var_10_5A, ldfld:Font(FontData::m_Font, ldfld:FontData(Text::m_FontData, ldloc:Text(this))))
	stloc:Vector2(var_11_67, callgetter:Vector2(RectTransform::get_pivot, callgetter:RectTransform(Graphic::get_rectTransform, ldloc:Text[exp:Graphic](this))))
	stloc:FontData(var_12_6F, ldfld:FontData(Text::m_FontData, ldloc:Text(this)))
	stloc:bool(var_13_78, ldfld:bool(FontData::m_RichText, ldloc:FontData(var_12_6F)))
	stloc:float32(var_14_81, ldfld:float32(FontData::m_LineSpacing, ldloc:FontData(var_12_6F)))
	stloc:FontStyle(var_15_8A, ldfld:FontStyle(FontData::m_FontStyle, ldloc:FontData(var_12_6F)))
	stloc:bool(var_16_93, ldfld:bool(FontData::m_BestFit, ldloc:FontData(var_12_6F)))
	stfld:Font(TextGenerationSettings::font, ldloc:TextGenerationSettings[exp:valuetype [UnityEngine.TextRenderingModule]UnityEngine.TextGenerationSettings&](var_0), ldloc:Font(var_10_5A))
	stfld:bool(TextGenerationSettings::alignByGeometry, ldloc:TextGenerationSettings[exp:valuetype [UnityEngine.TextRenderingModule]UnityEngine.TextGenerationSettings&](var_0), ldloc:bool(var_8_45))
	stfld:int32(TextGenerationSettings::fontSize, ldloc:TextGenerationSettings[exp:valuetype [UnityEngine.TextRenderingModule]UnityEngine.TextGenerationSettings&](var_0), ldloc:int64[exp:int32](var_5_2B))
	stfld:bool(TextGenerationSettings::richText, ldloc:TextGenerationSettings[exp:valuetype [UnityEngine.TextRenderingModule]UnityEngine.TextGenerationSettings&](var_0), ldloc:float32[exp:bool](var_14_81))
	stfld:bool(TextGenerationSettings::richText, ldloc:TextGenerationSettings[exp:valuetype [UnityEngine.TextRenderingModule]UnityEngine.TextGenerationSettings&](var_0), ldloc:bool(var_13_78))
	stfld:FontStyle(TextGenerationSettings::fontStyle, ldloc:TextGenerationSettings[exp:valuetype [UnityEngine.TextRenderingModule]UnityEngine.TextGenerationSettings&](var_0), ldloc:FontStyle(var_15_8A))
	stfld:bool(TextGenerationSettings::alignByGeometry, ldloc:TextGenerationSettings[exp:valuetype [UnityEngine.TextRenderingModule]UnityEngine.TextGenerationSettings&](var_0), ldloc:TextAnchor[exp:bool](var_7_3C))
	stfld:bool(TextGenerationSettings::resizeTextForBestFit, ldloc:TextGenerationSettings[exp:valuetype [UnityEngine.TextRenderingModule]UnityEngine.TextGenerationSettings&](var_0), ldloc:bool(var_16_93))
	stfld:int32(VerticalWrapMode::value__, ldfld:VerticalWrapMode[exp:valuetype [UnityEngine.TextRenderingModule]UnityEngine.VerticalWrapMode&](TextGenerationSettings::verticalOverflow, ldloc:TextGenerationSettings[exp:valuetype [UnityEngine.TextRenderingModule]UnityEngine.TextGenerationSettings&](var_0)), ldloc:float32[exp:int32](var_9_4D))
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

		// Token: 0x060004C1 RID: 1217 RVA: 0x00002207 File Offset: 0x00000407
		public static Vector2 GetTextAnchorPivot(TextAnchor anchor)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x0000F114 File Offset: 0x0000D314
		protected override void OnPopulateMesh(VertexHelper toFill)
		{
			Font font = this.m_FontData.m_Font;
			int num = 1;
			this.m_DisableFontTextureRebuiltCallback = num != 0;
			Vector2 size = base.rectTransform.rect.size;
			TextGenerator cachedTextGenerator = this.cachedTextGenerator;
			GameObject gameObject = base.gameObject;
			IList<UIVertex> verts = this.cachedTextGenerator.verts;
			float pixelsPerUnit = this.pixelsPerUnit;
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x0000F26C File Offset: 0x0000D46C
		public virtual void CalculateLayoutInputHorizontal()
		{
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x0000F27C File Offset: 0x0000D47C
		public virtual void CalculateLayoutInputVertical()
		{
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060004C5 RID: 1221 RVA: 0x00002207 File Offset: 0x00000407
		public virtual float minWidth
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060004C6 RID: 1222 RVA: 0x0000F28C File Offset: 0x0000D48C
		public virtual float preferredWidth
		{
			get
			{
				/*
An exception occurred when decompiling this method (060004C6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single UnityEngine.UI.Text::get_preferredWidth()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:TextGenerator(var_1_06, callgetter:TextGenerator(Text::get_cachedTextGeneratorForLayout, ldloc:Text(this)))
	stloc:string(var_2_0D, ldfld:string(Text::m_Text, ldloc:Text(this)))
	stloc:float32(var_4_14, callgetter:float32(Text::get_pixelsPerUnit, ldloc:Text(this)))
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

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060004C7 RID: 1223 RVA: 0x00002207 File Offset: 0x00000407
		public virtual float flexibleWidth
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060004C8 RID: 1224 RVA: 0x00002207 File Offset: 0x00000407
		public virtual float minHeight
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x060004C9 RID: 1225 RVA: 0x0000F2B0 File Offset: 0x0000D4B0
		public virtual float preferredHeight
		{
			get
			{
				/*
An exception occurred when decompiling this method (060004C9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single UnityEngine.UI.Text::get_preferredHeight()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Vector2(var_0_0B, callgetter:Vector2(Rect::get_size, call:Rect[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Rect&](Graphic::GetPixelAdjustedRect, ldloc:Text[exp:Graphic](this))))
	stloc:TextGenerator(var_2_12, callgetter:TextGenerator(Text::get_cachedTextGeneratorForLayout, ldloc:Text(this)))
	stloc:string(var_3_19, ldfld:string(Text::m_Text, ldloc:Text(this)))
	stloc:float32(var_5_20, callgetter:float32(Text::get_pixelsPerUnit, ldloc:Text(this)))
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

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x060004CA RID: 1226 RVA: 0x00002207 File Offset: 0x00000407
		public virtual float flexibleHeight
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x060004CB RID: 1227 RVA: 0x0000F2E0 File Offset: 0x0000D4E0
		public virtual int layoutPriority
		{
			get
			{
			}
		}

		// Token: 0x04000243 RID: 579
		[SerializeField]
		private FontData m_FontData;

		// Token: 0x04000244 RID: 580
		[SerializeField]
		[TextArea(3, 10)]
		protected string m_Text;

		// Token: 0x04000245 RID: 581
		private TextGenerator m_TextCache;

		// Token: 0x04000246 RID: 582
		private TextGenerator m_TextCacheForLayout;

		// Token: 0x04000247 RID: 583
		protected static Material s_DefaultText;

		// Token: 0x04000248 RID: 584
		[NonSerialized]
		protected bool m_DisableFontTextureRebuiltCallback;

		// Token: 0x04000249 RID: 585
		private readonly UIVertex[] m_TempVerts;
	}
}
