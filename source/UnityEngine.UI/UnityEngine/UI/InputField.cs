using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

namespace UnityEngine.UI
{
	// Token: 0x0200002C RID: 44
	[AddComponentMenu("UI/Legacy/Input Field", 103)]
	public class InputField : Selectable, IUpdateSelectedHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler, ISubmitHandler, ICanvasElement, ILayoutElement
	{
		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000187 RID: 391 RVA: 0x00005A3C File Offset: 0x00003C3C
		private BaseInput input
		{
			get
			{
				if (!true)
				{
				}
				bool flag = EventSystem.current;
				EventSystem current = EventSystem.current;
				bool flag2 = current.m_CurrentInputModule;
				if (current == null)
				{
				}
				return EventSystem.current.m_CurrentInputModule.input;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000188 RID: 392 RVA: 0x00005A88 File Offset: 0x00003C88
		private string compositionString
		{
			get
			{
				return Input.compositionString;
			}
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00005A9C File Offset: 0x00003C9C
		protected InputField()
		{
			int num = 42;
			this.m_AsteriskChar = (char)num;
			long num2 = 39322L;
			int num3 = 1;
			this.m_ShouldActivateOnSelect = num3 != 0;
			this.m_CaretBlinkRate = (float)num2;
			this.m_OriginalText = "";
			if ("" == null)
			{
			}
			base..ctor();
			this.EnforceTextHOverflow();
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x0600018A RID: 394 RVA: 0x00005AE8 File Offset: 0x00003CE8
		protected Mesh mesh
		{
			get
			{
				Mesh mesh = this.m_Mesh;
				if (!true)
				{
				}
				return this.m_Mesh;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x0600018B RID: 395 RVA: 0x00005B08 File Offset: 0x00003D08
		protected TextGenerator cachedInputTextGenerator
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600018B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.TextGenerator UnityEngine.UI.InputField::get_cachedInputTextGenerator()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:TextGenerator[exp:bool](InputField::m_InputTextCache, ldloc:InputField(this)))
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

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600018D RID: 397 RVA: 0x00005B2C File Offset: 0x00003D2C
		// (set) Token: 0x0600018C RID: 396 RVA: 0x00005B1C File Offset: 0x00003D1C
		public bool shouldHideMobileInput
		{
			get
			{
				RuntimePlatform platform = Application.platform;
				bool hideMobileInput = this.m_HideMobileInput;
				return true;
			}
			set
			{
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600018F RID: 399 RVA: 0x00005B5C File Offset: 0x00003D5C
		// (set) Token: 0x0600018E RID: 398 RVA: 0x00005B4C File Offset: 0x00003D4C
		public virtual bool shouldActivateOnSelect
		{
			get
			{
				if (this.m_ShouldActivateOnSelect)
				{
					RuntimePlatform platform = Application.platform;
					return;
				}
			}
			set
			{
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000190 RID: 400 RVA: 0x00005B7C File Offset: 0x00003D7C
		// (set) Token: 0x06000191 RID: 401 RVA: 0x00005B90 File Offset: 0x00003D90
		public string text
		{
			get
			{
				return this.m_Text;
			}
			set
			{
				this.SetText(value, true);
			}
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00005BA8 File Offset: 0x00003DA8
		public void SetTextWithoutNotify(string input)
		{
			long num = 0L;
			this.SetText(input, num != 0L);
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00005BC0 File Offset: 0x00003DC0
		private void SetText(string value, bool sendCallback = true)
		{
			bool flag = this.m_Text == value;
			string text;
			if (this.m_LineType == InputField.LineType.SingleLine)
			{
				string text2;
				text = text2.Replace("\n", "").Replace("\t", "");
			}
			if (this.m_OnValidateInput != null)
			{
				this.m_Text = "";
				return;
			}
			if (this.m_CharacterValidation != InputField.CharacterValidation.None)
			{
				this.m_Text = "";
				int characterLimit = this.m_CharacterLimit;
				int stringLength = text._stringLength;
				this.m_CaretSelectPosition = stringLength;
				this.m_CaretPosition = stringLength;
				int num = Math.Min(characterLimit, stringLength);
				long num2 = 0L;
				int stringLength2 = this.m_Text._stringLength;
				char c = text[(int)num2];
				string text4;
				string text3 = this.m_Text + text4;
				this.m_Text = text3;
				return;
			}
			int characterLimit2 = this.m_CharacterLimit;
			int stringLength3 = text._stringLength;
			long num3 = 0L;
			string text5 = text.Substring((int)num3, characterLimit2);
			this.m_Text = text5;
			TouchScreenKeyboard keyboard = this.m_Keyboard;
			if (keyboard != null)
			{
				string text6 = this.m_Text;
				keyboard.text = text6;
			}
			string text7 = this.m_Text;
			int caretPosition = this.m_CaretPosition;
			int stringLength4 = text7._stringLength;
			this.m_CaretSelectPosition = stringLength4;
			this.m_CaretPosition = stringLength4;
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000194 RID: 404 RVA: 0x00005D10 File Offset: 0x00003F10
		public bool isFocused
		{
			get
			{
				return this.m_AllowInput;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000195 RID: 405 RVA: 0x00005D24 File Offset: 0x00003F24
		// (set) Token: 0x06000196 RID: 406 RVA: 0x00005D38 File Offset: 0x00003F38
		public float caretBlinkRate
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000195)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single UnityEngine.UI.InputField::get_caretBlinkRate()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(InputField::m_CaretBlinkRate, ldloc:InputField(this)))
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
				if (this.m_AllowInput)
				{
					this.SetCaretActive();
					return;
				}
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000197 RID: 407 RVA: 0x00005D54 File Offset: 0x00003F54
		// (set) Token: 0x06000198 RID: 408 RVA: 0x00005D68 File Offset: 0x00003F68
		public int caretWidth
		{
			get
			{
				return this.m_CaretWidth;
			}
			set
			{
				this.MarkGeometryAsDirty();
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000199 RID: 409 RVA: 0x00005D7C File Offset: 0x00003F7C
		// (set) Token: 0x0600019A RID: 410 RVA: 0x00005D90 File Offset: 0x00003F90
		public Text textComponent
		{
			get
			{
				return this.m_TextComponent;
			}
			set
			{
				int num = 1;
				Text textComponent = this.m_TextComponent;
				if (num == 0)
				{
				}
				Text textComponent2 = this.m_TextComponent;
				Text textComponent3 = this.m_TextComponent;
				Text textComponent4 = this.m_TextComponent;
				this.EnforceTextHOverflow();
				Text textComponent5 = this.m_TextComponent;
				if (num == 0)
				{
				}
				Text textComponent6 = this.m_TextComponent;
				Text textComponent7 = this.m_TextComponent;
				Text textComponent8 = this.m_TextComponent;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600019B RID: 411 RVA: 0x00005DEC File Offset: 0x00003FEC
		// (set) Token: 0x0600019C RID: 412 RVA: 0x00005E00 File Offset: 0x00004000
		public Graphic placeholder
		{
			get
			{
				return this.m_Placeholder;
			}
			set
			{
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600019D RID: 413 RVA: 0x00005E10 File Offset: 0x00004010
		// (set) Token: 0x0600019E RID: 414 RVA: 0x00005E5C File Offset: 0x0000405C
		public Color caretColor
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600019D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.Color UnityEngine.UI.InputField::get_caretColor()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0038:
	stloc:Text(var_4_3E, ldfld:Text(InputField::m_TextComponent, ldloc:InputField(this)))
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
				this.MarkGeometryAsDirty();
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600019F RID: 415 RVA: 0x00005E70 File Offset: 0x00004070
		// (set) Token: 0x060001A0 RID: 416 RVA: 0x00005E84 File Offset: 0x00004084
		public bool customCaretColor
		{
			get
			{
				return this.m_CustomCaretColor;
			}
			set
			{
				bool customCaretColor = this.m_CustomCaretColor;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x00005EA0 File Offset: 0x000040A0
		// (set) Token: 0x060001A2 RID: 418 RVA: 0x00005EDC File Offset: 0x000040DC
		public Color selectionColor
		{
			get
			{
				/*
An exception occurred when decompiling this method (060001A1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.Color UnityEngine.UI.InputField::get_selectionColor()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_0B, ldfld:float32(Color::r, ldfld:Color[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Color&](InputField::m_SelectionColor, ldloc:InputField(this))))
	stloc:float32(var_1_17, ldfld:float32(Color::g, ldfld:Color[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Color&](InputField::m_SelectionColor, ldloc:InputField(this))))
	stloc:float32(var_2_23, ldfld:float32(Color::b, ldfld:Color[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Color&](InputField::m_SelectionColor, ldloc:InputField(this))))
	stloc:float32(var_3_2F, ldfld:float32(Color::a, ldfld:Color[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Color&](InputField::m_SelectionColor, ldloc:InputField(this))))
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
				this.MarkGeometryAsDirty();
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x00005EF0 File Offset: 0x000040F0
		// (set) Token: 0x060001A4 RID: 420 RVA: 0x00005F04 File Offset: 0x00004104
		public InputField.EndEditEvent onEndEdit
		{
			get
			{
				return this.m_OnDidEndEdit;
			}
			set
			{
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x00005F14 File Offset: 0x00004114
		// (set) Token: 0x060001A6 RID: 422 RVA: 0x00005F28 File Offset: 0x00004128
		public InputField.SubmitEvent onSubmit
		{
			get
			{
				return this.m_OnSubmit;
			}
			set
			{
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x00005F38 File Offset: 0x00004138
		// (set) Token: 0x060001A8 RID: 424 RVA: 0x00005F4C File Offset: 0x0000414C
		[Obsolete("onValueChange has been renamed to onValueChanged")]
		public InputField.OnChangeEvent onValueChange
		{
			get
			{
				return this.m_OnValueChanged;
			}
			set
			{
				this.onValueChanged = value;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x00005F60 File Offset: 0x00004160
		// (set) Token: 0x060001AA RID: 426 RVA: 0x00005F74 File Offset: 0x00004174
		public InputField.OnChangeEvent onValueChanged
		{
			get
			{
				return this.m_OnValueChanged;
			}
			set
			{
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060001AB RID: 427 RVA: 0x00005F84 File Offset: 0x00004184
		// (set) Token: 0x060001AC RID: 428 RVA: 0x00005F98 File Offset: 0x00004198
		public InputField.OnValidateInput onValidateInput
		{
			get
			{
				return this.m_OnValidateInput;
			}
			set
			{
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060001AD RID: 429 RVA: 0x00005FA8 File Offset: 0x000041A8
		// (set) Token: 0x060001AE RID: 430 RVA: 0x00005FBC File Offset: 0x000041BC
		public int characterLimit
		{
			get
			{
				return this.m_CharacterLimit;
			}
			set
			{
				if (!true)
				{
				}
				int num = Math.Max(0, value);
				this.UpdateLabel();
				TouchScreenKeyboard keyboard = this.m_Keyboard;
				if (keyboard != null)
				{
					keyboard.characterLimit = value;
					return;
				}
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001AF RID: 431 RVA: 0x00005FEC File Offset: 0x000041EC
		// (set) Token: 0x060001B0 RID: 432 RVA: 0x00006000 File Offset: 0x00004200
		public InputField.ContentType contentType
		{
			get
			{
				return this.m_ContentType;
			}
			set
			{
				this.EnforceContentType();
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x00006014 File Offset: 0x00004214
		// (set) Token: 0x060001B2 RID: 434 RVA: 0x00006028 File Offset: 0x00004228
		public InputField.LineType lineType
		{
			get
			{
				return this.m_LineType;
			}
			set
			{
				this.EnforceTextHOverflow();
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x00006040 File Offset: 0x00004240
		// (set) Token: 0x060001B4 RID: 436 RVA: 0x00006054 File Offset: 0x00004254
		public InputField.InputType inputType
		{
			get
			{
				return this.m_InputType;
			}
			set
			{
				InputField.ContentType contentType = this.m_ContentType;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x0000606C File Offset: 0x0000426C
		public TouchScreenKeyboard touchScreenKeyboard
		{
			get
			{
				return this.m_Keyboard;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x00006080 File Offset: 0x00004280
		// (set) Token: 0x060001B7 RID: 439 RVA: 0x00006094 File Offset: 0x00004294
		public TouchScreenKeyboardType keyboardType
		{
			get
			{
				return this.m_KeyboardType;
			}
			set
			{
				InputField.ContentType contentType = this.m_ContentType;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x000060AC File Offset: 0x000042AC
		// (set) Token: 0x060001B9 RID: 441 RVA: 0x000060C0 File Offset: 0x000042C0
		public InputField.CharacterValidation characterValidation
		{
			get
			{
				return this.m_CharacterValidation;
			}
			set
			{
				InputField.ContentType contentType = this.m_ContentType;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060001BA RID: 442 RVA: 0x000060D8 File Offset: 0x000042D8
		// (set) Token: 0x060001BB RID: 443 RVA: 0x000060EC File Offset: 0x000042EC
		public bool readOnly
		{
			get
			{
				return this.m_ReadOnly;
			}
			set
			{
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060001BC RID: 444 RVA: 0x000060FC File Offset: 0x000042FC
		public bool multiLine
		{
			get
			{
				/*
An exception occurred when decompiling this method (060001BC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean UnityEngine.UI.InputField::get_multiLine()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:LineType(var_0_06, ldfld:LineType(InputField::m_LineType, ldloc:InputField(this)))
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

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060001BD RID: 445 RVA: 0x00006110 File Offset: 0x00004310
		// (set) Token: 0x060001BE RID: 446 RVA: 0x00006124 File Offset: 0x00004324
		public char asteriskChar
		{
			get
			{
				return this.m_AsteriskChar;
			}
			set
			{
				this.UpdateLabel();
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060001BF RID: 447 RVA: 0x00006138 File Offset: 0x00004338
		public bool wasCanceled
		{
			get
			{
				return this.m_WasCanceled;
			}
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x0000614C File Offset: 0x0000434C
		protected void ClampPos(int pos)
		{
			int stringLength = this.m_Text._stringLength;
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060001C1 RID: 449 RVA: 0x00006170 File Offset: 0x00004370
		// (set) Token: 0x060001C2 RID: 450 RVA: 0x00006190 File Offset: 0x00004390
		protected int caretPositionInternal
		{
			get
			{
				/*
An exception occurred when decompiling this method (060001C1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 UnityEngine.UI.InputField::get_caretPositionInternal()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(InputField::m_CaretPosition, ldloc:InputField(this)))
	stloc:int32(var_1_12, ldfld:int32(string::_stringLength, callgetter:string(InputField::get_compositionString, ldloc:InputField(this))))
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
				this.m_CaretPosition = value;
				int stringLength = this.m_Text._stringLength;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060001C3 RID: 451 RVA: 0x000061BC File Offset: 0x000043BC
		// (set) Token: 0x060001C4 RID: 452 RVA: 0x000061DC File Offset: 0x000043DC
		protected int caretSelectPositionInternal
		{
			get
			{
				/*
An exception occurred when decompiling this method (060001C3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 UnityEngine.UI.InputField::get_caretSelectPositionInternal()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(InputField::m_CaretSelectPosition, ldloc:InputField(this)))
	stloc:int32(var_1_12, ldfld:int32(string::_stringLength, callgetter:string(InputField::get_compositionString, ldloc:InputField(this))))
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
				this.m_CaretSelectPosition = value;
				int stringLength = this.m_Text._stringLength;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060001C5 RID: 453 RVA: 0x00006208 File Offset: 0x00004408
		private bool hasSelection
		{
			get
			{
				/*
An exception occurred when decompiling this method (060001C5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean UnityEngine.UI.InputField::get_hasSelection()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(InputField::m_CaretPosition, ldloc:InputField(this)))
	stloc:int32(var_1_12, ldfld:int32(string::_stringLength, callgetter:string(InputField::get_compositionString, ldloc:InputField(this))))
	stloc:int32(var_2_19, ldfld:int32(InputField::m_CaretSelectPosition, ldloc:InputField(this)))
	stloc:int32(var_4_20, ldfld:int32(string::_stringLength, ldloc:string(var_3)))
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

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x00006238 File Offset: 0x00004438
		// (set) Token: 0x060001C7 RID: 455 RVA: 0x00006258 File Offset: 0x00004458
		public int caretPosition
		{
			get
			{
				/*
An exception occurred when decompiling this method (060001C6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 UnityEngine.UI.InputField::get_caretPosition()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(InputField::m_CaretSelectPosition, ldloc:InputField(this)))
	stloc:int32(var_1_12, ldfld:int32(string::_stringLength, callgetter:string(InputField::get_compositionString, ldloc:InputField(this))))
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
				this.selectionAnchorPosition = value;
				this.selectionFocusPosition = value;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x00006274 File Offset: 0x00004474
		// (set) Token: 0x060001C9 RID: 457 RVA: 0x00006294 File Offset: 0x00004494
		public int selectionAnchorPosition
		{
			get
			{
				/*
An exception occurred when decompiling this method (060001C8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 UnityEngine.UI.InputField::get_selectionAnchorPosition()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(InputField::m_CaretPosition, ldloc:InputField(this)))
	stloc:int32(var_1_12, ldfld:int32(string::_stringLength, callgetter:string(InputField::get_compositionString, ldloc:InputField(this))))
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
				if (this.compositionString._stringLength != 0)
				{
					return;
				}
				this.m_CaretPosition = value;
				int stringLength = this.m_Text._stringLength;
				this.m_CaretPosition = stringLength;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060001CA RID: 458 RVA: 0x000062CC File Offset: 0x000044CC
		// (set) Token: 0x060001CB RID: 459 RVA: 0x000062EC File Offset: 0x000044EC
		public int selectionFocusPosition
		{
			get
			{
				/*
An exception occurred when decompiling this method (060001CA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 UnityEngine.UI.InputField::get_selectionFocusPosition()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(InputField::m_CaretSelectPosition, ldloc:InputField(this)))
	stloc:int32(var_1_12, ldfld:int32(string::_stringLength, callgetter:string(InputField::get_compositionString, ldloc:InputField(this))))
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
				if (this.compositionString._stringLength != 0)
				{
					return;
				}
				this.m_CaretSelectPosition = value;
				int stringLength = this.m_Text._stringLength;
				this.m_CaretSelectPosition = stringLength;
			}
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00006324 File Offset: 0x00004524
		protected override void Awake()
		{
			base.Awake();
			if (!true)
			{
			}
			bool flag = SystemInfo.deviceModel == "Oculus Quest";
		}

		// Token: 0x060001CD RID: 461 RVA: 0x0000634C File Offset: 0x0000454C
		protected override void OnEnable()
		{
			base.OnEnable();
			if (this.m_Text == null)
			{
			}
			CanvasRenderer cachedInputRenderer = this.m_CachedInputRenderer;
			CanvasRenderer cachedInputRenderer2 = this.m_CachedInputRenderer;
			Text textComponent = this.m_TextComponent;
			Material defaultGraphicMaterial = Graphic.defaultGraphicMaterial;
			Texture2D whiteTexture = Texture2D.whiteTexture;
			Text textComponent2 = this.m_TextComponent;
			Text textComponent3 = this.m_TextComponent;
			Text textComponent4 = this.m_TextComponent;
			Text textComponent5 = this.m_TextComponent;
			this.UpdateLabel();
		}

		// Token: 0x060001CE RID: 462 RVA: 0x000063B8 File Offset: 0x000045B8
		protected override void OnDisable()
		{
			this.DeactivateInputField();
			Text textComponent = this.m_TextComponent;
			if (!true)
			{
			}
			Text textComponent2 = this.m_TextComponent;
			Text textComponent3 = this.m_TextComponent;
			Text textComponent4 = this.m_TextComponent;
			if (!true)
			{
			}
			CanvasUpdateRegistry.DisableCanvasElementForRebuild(this);
			CanvasRenderer cachedInputRenderer = this.m_CachedInputRenderer;
			if (!true)
			{
			}
			this.m_CachedInputRenderer.Clear();
			Mesh mesh = this.m_Mesh;
			if (!true)
			{
			}
			Mesh mesh2 = this.m_Mesh;
			if (!true)
			{
			}
			Object.DestroyImmediate(mesh2);
			base.OnDisable();
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00006430 File Offset: 0x00004630
		protected override void OnDestroy()
		{
			if (!true)
			{
			}
			CanvasUpdateRegistry.UnRegisterCanvasElementForRebuild(this);
			base.OnDestroy();
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00002207 File Offset: 0x00000407
		private IEnumerator CaretBlink()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x0000644C File Offset: 0x0000464C
		private void SetCaretVisible()
		{
			if (this.m_AllowInput)
			{
				this.m_CaretVisible = true;
				float unscaledTime = Time.unscaledTime;
				this.SetCaretActive();
				return;
			}
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00006478 File Offset: 0x00004678
		private void SetCaretActive()
		{
			if (this.m_AllowInput)
			{
				float caretBlinkRate = this.m_CaretBlinkRate;
				if (this.m_BlinkCoroutine == null)
				{
					IEnumerator enumerator = this.CaretBlink();
					Coroutine coroutine = base.StartCoroutine(enumerator);
					this.m_BlinkCoroutine = coroutine;
					return;
				}
			}
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x000064BC File Offset: 0x000046BC
		private void UpdateCaretMaterial()
		{
			Text textComponent = this.m_TextComponent;
			if (!true)
			{
			}
			CanvasRenderer cachedInputRenderer = this.m_CachedInputRenderer;
			if (!true)
			{
			}
			CanvasRenderer cachedInputRenderer2 = this.m_CachedInputRenderer;
			Text textComponent2 = this.m_TextComponent;
			Material defaultGraphicMaterial = Graphic.defaultGraphicMaterial;
			Texture2D whiteTexture = Texture2D.whiteTexture;
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00006504 File Offset: 0x00004704
		protected void OnFocus()
		{
			string text = this.m_Text;
			int stringLength = text._stringLength;
			this.m_CaretPosition = stringLength;
			int stringLength2 = text._stringLength;
			this.m_CaretSelectPosition = stringLength2;
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00006534 File Offset: 0x00004734
		protected void SelectAll()
		{
			string text = this.m_Text;
			int stringLength = text._stringLength;
			this.m_CaretPosition = stringLength;
			int stringLength2 = text._stringLength;
			this.m_CaretSelectPosition = stringLength2;
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00006564 File Offset: 0x00004764
		public void MoveTextEnd(bool shift)
		{
			int stringLength = this.m_Text._stringLength;
			this.m_CaretSelectPosition = stringLength;
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x000065B4 File Offset: 0x000047B4
		public void MoveTextStart(bool shift)
		{
			int stringLength = this.m_Text._stringLength;
			this.m_CaretSelectPosition = stringLength;
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x00006610 File Offset: 0x00004810
		// (set) Token: 0x060001D9 RID: 473 RVA: 0x00006624 File Offset: 0x00004824
		private static string clipboard
		{
			get
			{
				return GUIUtility.systemCopyBuffer;
			}
			set
			{
				GUIUtility.systemCopyBuffer = value;
			}
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00006638 File Offset: 0x00004838
		private bool TouchScreenKeyboardShouldBeUsed()
		{
			RuntimePlatform platform = Application.platform;
			if (!true)
			{
			}
			if (true)
			{
				return TouchScreenKeyboard.isSupported;
			}
			return TouchScreenKeyboard.isInPlaceEditingAllowed;
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00006664 File Offset: 0x00004864
		private bool InPlaceEditing()
		{
			bool isSupported = TouchScreenKeyboard.isSupported;
			bool touchKeyboardAllowsInPlaceEditing = this.m_TouchKeyboardAllowsInPlaceEditing;
			return isSupported;
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00006684 File Offset: 0x00004884
		private bool InPlaceEditingChanged()
		{
			if (!true)
			{
			}
			if (true)
			{
			}
			bool touchKeyboardAllowsInPlaceEditing = this.m_TouchKeyboardAllowsInPlaceEditing;
			return TouchScreenKeyboard.isInPlaceEditingAllowed;
		}

		// Token: 0x060001DD RID: 477 RVA: 0x000066A8 File Offset: 0x000048A8
		private void UpdateCaretFromKeyboard()
		{
			int end = this.m_Keyboard.selection.end;
			int caretPosition = this.m_CaretPosition;
			string text;
			int stringLength = text._stringLength;
		}

		// Token: 0x060001DE RID: 478 RVA: 0x0000673C File Offset: 0x0000493C
		protected virtual void LateUpdate()
		{
			if (this.m_ShouldActivateNextUpdate && !this.m_AllowInput)
			{
				this.ActivateInputFieldInternal();
				return;
			}
			this.AssignPositioningIfNeeded();
			if (this.m_AllowInput)
			{
				bool flag = this.InPlaceEditingChanged();
				CanvasRenderer cachedInputRenderer = this.m_CachedInputRenderer;
				Mesh mesh = this.mesh;
				return;
			}
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00006AAC File Offset: 0x00004CAC
		[Obsolete("This function is no longer used. Please use RectTransformUtility.ScreenPointToLocalPointInRectangle() instead.")]
		public Vector2 ScreenToLocal(Vector2 screen)
		{
			/*
An exception occurred when decompiling this method (060001DF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.Vector2 UnityEngine.UI.InputField::ScreenToLocal(UnityEngine.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Camera(var_2_1A, callgetter:Camera(Canvas::get_worldCamera, ldloc:Canvas(var_0_0B)))
	stloc:Camera(var_4_21, callgetter:Camera(Canvas::get_worldCamera, ldloc:Canvas(var_0_0B)))
	stloc:Vector3(var_6_33, callgetter:Vector3(Transform::get_forward, callgetter:Transform(Component::get_transform, ldfld:Text[exp:Component](InputField::m_TextComponent, ldloc:InputField(this)))))
	stloc:Vector3(var_7_45, callgetter:Vector3(Transform::get_position, callgetter:Transform(Component::get_transform, ldfld:Text[exp:Component](InputField::m_TextComponent, ldloc:InputField(this)))))
	stloc:Transform(var_10_57, callgetter:Transform(Component::get_transform, callgetter:Transform[exp:Component](Component::get_transform, ldfld:Text[exp:Component](InputField::m_TextComponent, ldloc:InputField(this)))))
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

		// Token: 0x060001E0 RID: 480 RVA: 0x00006B14 File Offset: 0x00004D14
		private int GetUnclampedCharacterLineFromPosition(Vector2 pos, TextGenerator generator)
		{
			InputField.LineType lineType = this.m_LineType;
			float pixelsPerUnit = this.m_TextComponent.pixelsPerUnit;
			int num;
			return num;
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00006B3C File Offset: 0x00004D3C
		protected int GetCharacterIndexFromPosition(Vector2 pos)
		{
			TextGenerator cachedTextGenerator = this.m_TextComponent.cachedTextGenerator;
			if (cachedTextGenerator.lineCount != 0)
			{
				int lineCount = cachedTextGenerator.lineCount;
				IList<UILineInfo> lines = cachedTextGenerator.lines;
			}
			return cachedTextGenerator.characterCountVisible;
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00006BB8 File Offset: 0x00004DB8
		private bool MayDrag(PointerEventData eventData)
		{
			/*
An exception occurred when decompiling this method (060001E2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean UnityEngine.UI.InputField::MayDrag(UnityEngine.EventSystems.PointerEventData)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0024:
	stloc:bool(var_5_2A, ldfld:bool(InputField::m_HideMobileInput, ldloc:InputField(this)))
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

		// Token: 0x060001E3 RID: 483 RVA: 0x00006BF0 File Offset: 0x00004DF0
		public virtual void OnBeginDrag(PointerEventData eventData)
		{
			bool flag = this.MayDrag(eventData);
			this.m_UpdateDrag = true;
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00006C0C File Offset: 0x00004E0C
		public virtual void OnDrag(PointerEventData eventData)
		{
			bool flag = this.MayDrag(eventData);
			RectTransform rectTransform = this.m_TextComponent.rectTransform;
			Camera pressEventCamera = eventData.pressEventCamera;
			int drawStart = this.m_DrawStart;
			int stringLength = this.m_Text._stringLength;
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00002207 File Offset: 0x00000407
		private IEnumerator MouseDragOutsideRect(PointerEventData eventData)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00006CB8 File Offset: 0x00004EB8
		public virtual void OnEndDrag(PointerEventData eventData)
		{
			bool flag = this.MayDrag(eventData);
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00006CD0 File Offset: 0x00004ED0
		public override void OnPointerDown(PointerEventData eventData)
		{
			bool flag = this.MayDrag(eventData);
			EventSystem current = EventSystem.current;
			GameObject gameObject = base.gameObject;
			current.SetSelectedGameObject(gameObject, eventData);
			bool allowInput = this.m_AllowInput;
			base.OnPointerDown(eventData);
			bool isSupported = TouchScreenKeyboard.isSupported;
			if (!this.m_TouchKeyboardAllowsInPlaceEditing)
			{
				TouchScreenKeyboard keyboard = this.m_Keyboard;
				if (keyboard != null)
				{
					bool active = keyboard.active;
				}
				throw new MissingMethodException();
			}
			if (allowInput)
			{
				RectTransform rectTransform = this.m_TextComponent.rectTransform;
				float x = eventData.<pointerPressRaycast>k__BackingField.screenPosition.x;
				float y = eventData.<pointerPressRaycast>k__BackingField.screenPosition.y;
				Camera pressEventCamera = eventData.pressEventCamera;
				int drawStart = this.m_DrawStart;
				this.m_CaretPosition = drawStart;
				string text = this.m_Text;
				int stringLength = text._stringLength;
				int stringLength2 = text._stringLength;
				this.m_CaretSelectPosition = drawStart;
				return;
			}
			this.UpdateLabel();
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00006DB0 File Offset: 0x00004FB0
		protected InputField.EditState KeyPressed(Event evt)
		{
			EventModifiers modifiers = evt.modifiers;
			OperatingSystemFamily operatingSystemFamily = SystemInfo.operatingSystemFamily;
			long num = 0L;
			KeyCode keyCode = evt.keyCode;
			int num2 = 1;
			this.MoveUp(num != 0L, num2 != 0);
			string text = this.m_Text;
			int stringLength = text._stringLength;
			this.m_CaretPosition = stringLength;
			int stringLength2 = text._stringLength;
			this.m_CaretSelectPosition = stringLength2;
			if (stringLength2 == 0)
			{
			}
			string systemCopyBuffer = GUIUtility.systemCopyBuffer;
			InputField.LineType lineType = this.m_LineType;
			int num3 = 1;
			this.m_WasCanceled = num3 != 0;
			this.Backspace();
			this.ForwardSpace();
			if (this.m_InputType == InputField.InputType.Standard)
			{
			}
			return "";
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00006E84 File Offset: 0x00005084
		private bool IsValidChar(char c)
		{
			return this.m_TextComponent.font.HasCharacter(c);
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00006EA4 File Offset: 0x000050A4
		public void ProcessEvent(Event e)
		{
			InputField.EditState editState = this.KeyPressed(e);
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00006EBC File Offset: 0x000050BC
		public virtual void OnUpdateSelected(BaseEventData eventData)
		{
			bool allowInput = this.m_AllowInput;
			if (allowInput)
			{
				bool flag = Event.PopEvent(this.m_ProcessingEvent);
				EventType rawType = this.m_ProcessingEvent.rawType;
				string text;
				if (allowInput && text._stringLength == 0)
				{
					char character = this.m_ProcessingEvent.character;
					if (this.m_ProcessingEvent.modifiers == EventModifiers.None)
					{
						bool flag2 = Event.PopEvent(this.m_ProcessingEvent);
						this.UpdateLabel();
						return;
					}
				}
				Event processingEvent = this.m_ProcessingEvent;
				InputField.EditState editState = this.KeyPressed(processingEvent);
				if (!this.m_WasCanceled)
				{
					this.SendOnSubmit();
				}
				this.DeactivateInputField();
				return;
			}
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00006FA4 File Offset: 0x000051A4
		private string GetSelectedString()
		{
			bool hasSelection = this.hasSelection;
			int caretPosition = this.m_CaretPosition;
			string text;
			int stringLength = text._stringLength;
			int caretSelectPosition = this.m_CaretSelectPosition;
			string text2;
			int stringLength2 = text2._stringLength;
			string text3 = this.m_Text;
			string text4;
			return text4;
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00006FE8 File Offset: 0x000051E8
		private int FindtNextWordBegin()
		{
			int caretSelectPosition = this.m_CaretSelectPosition;
			string text = this.m_Text;
			string text2;
			int stringLength = text2._stringLength;
			int stringLength2 = text._stringLength;
			if (stringLength == 0)
			{
			}
			int caretSelectPosition2 = this.m_CaretSelectPosition;
			string text3;
			int stringLength3 = text3._stringLength;
			int num;
			return num;
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00007034 File Offset: 0x00005234
		private void MoveRight(bool shift, bool ctrl)
		{
			bool hasSelection = this.hasSelection;
			int caretPosition = this.m_CaretPosition;
			string text;
			int stringLength = text._stringLength;
			int caretSelectPosition = this.m_CaretSelectPosition;
			string text2;
			int stringLength2 = text2._stringLength;
			this.m_CaretSelectPosition = stringLength2;
			string text3 = this.m_Text;
			int stringLength3 = text3._stringLength;
			this.m_CaretSelectPosition = stringLength3;
			int stringLength4 = text3._stringLength;
			shift.m_value = stringLength2 != 0;
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00007100 File Offset: 0x00005300
		private int FindtPrevWordBegin()
		{
			int caretSelectPosition = this.m_CaretSelectPosition;
			string text;
			int stringLength = text._stringLength;
			string text2 = this.m_Text;
			if (stringLength == 0)
			{
			}
			int caretSelectPosition2 = this.m_CaretSelectPosition;
			string text3;
			int stringLength2 = text3._stringLength;
			int num;
			return num;
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x0000713C File Offset: 0x0000533C
		private void MoveLeft(bool shift, bool ctrl)
		{
			bool hasSelection = this.hasSelection;
			int caretPosition = this.m_CaretPosition;
			string text;
			int stringLength = text._stringLength;
			int caretSelectPosition = this.m_CaretSelectPosition;
			string text2;
			int stringLength2 = text2._stringLength;
			this.m_CaretSelectPosition = stringLength2;
			string text3 = this.m_Text;
			int stringLength3 = text3._stringLength;
			this.m_CaretSelectPosition = stringLength3;
			int stringLength4 = text3._stringLength;
			shift.m_value = stringLength2 != 0;
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00007208 File Offset: 0x00005408
		private int DetermineCharacterLine(int charPos, TextGenerator generator)
		{
			/*
An exception occurred when decompiling this method (060001F1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 UnityEngine.UI.InputField::DetermineCharacterLine(System.Int32,UnityEngine.TextGenerator)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_2_0A, callgetter:int32(TextGenerator::get_lineCount, ldloc:TextGenerator(generator)))
	stloc:class [mscorlib]System.Collections.Generic.IList`1<valuetype [UnityEngine.TextRenderingModule]UnityEngine.UILineInfo>(var_3_11, callgetter:IList`1[exp:class [mscorlib]System.Collections.Generic.IList`1<valuetype [UnityEngine.TextRenderingModule]UnityEngine.UILineInfo>](TextGenerator::get_lines, ldloc:TextGenerator(generator)))
	stloc:int32(var_4_18, callgetter:int32(TextGenerator::get_lineCount, ldloc:TextGenerator(generator)))
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

		// Token: 0x060001F2 RID: 498 RVA: 0x00007230 File Offset: 0x00005430
		private int LineUpCharacterPosition(int originalPos, bool goToFirstChar)
		{
			/*
An exception occurred when decompiling this method (060001F2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 UnityEngine.UI.InputField::LineUpCharacterPosition(System.Int32,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.IList`1<valuetype [UnityEngine.TextRenderingModule]UnityEngine.UICharInfo>(var_0_0B, callgetter:IList`1[exp:class [mscorlib]System.Collections.Generic.IList`1<valuetype [UnityEngine.TextRenderingModule]UnityEngine.UICharInfo>](TextGenerator::get_characters, callgetter:TextGenerator(InputField::get_cachedInputTextGenerator, ldloc:InputField(this))))
	stloc:class [mscorlib]System.Collections.Generic.IList`1<valuetype [UnityEngine.TextRenderingModule]UnityEngine.UICharInfo>(var_1_17, callgetter:IList`1[exp:class [mscorlib]System.Collections.Generic.IList`1<valuetype [UnityEngine.TextRenderingModule]UnityEngine.UICharInfo>](TextGenerator::get_characters, callgetter:TextGenerator(InputField::get_cachedInputTextGenerator, ldloc:InputField(this))))
	stloc:TextGenerator(var_3_20, callgetter:TextGenerator(InputField::get_cachedInputTextGenerator, ldloc:InputField(this)))
	stloc:class [mscorlib]System.Collections.Generic.IList`1<valuetype [UnityEngine.TextRenderingModule]UnityEngine.UILineInfo>(var_5_2C, callgetter:IList`1[exp:class [mscorlib]System.Collections.Generic.IList`1<valuetype [UnityEngine.TextRenderingModule]UnityEngine.UILineInfo>](TextGenerator::get_lines, callgetter:TextGenerator(InputField::get_cachedInputTextGenerator, ldloc:InputField(this))))
	stloc:class [mscorlib]System.Collections.Generic.IList`1<valuetype [UnityEngine.TextRenderingModule]UnityEngine.UILineInfo>(var_6_39, callgetter:IList`1[exp:class [mscorlib]System.Collections.Generic.IList`1<valuetype [UnityEngine.TextRenderingModule]UnityEngine.UILineInfo>](TextGenerator::get_lines, callgetter:TextGenerator(InputField::get_cachedInputTextGenerator, ldloc:InputField(this))))
	stloc:class [mscorlib]System.Collections.Generic.IList`1<valuetype [UnityEngine.TextRenderingModule]UnityEngine.UICharInfo>(var_7_46, callgetter:IList`1[exp:class [mscorlib]System.Collections.Generic.IList`1<valuetype [UnityEngine.TextRenderingModule]UnityEngine.UICharInfo>](TextGenerator::get_characters, callgetter:TextGenerator(InputField::get_cachedInputTextGenerator, ldloc:InputField(this))))
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

		// Token: 0x060001F3 RID: 499 RVA: 0x00007284 File Offset: 0x00005484
		private int LineDownCharacterPosition(int originalPos, bool goToLastChar)
		{
			int characterCountVisible = this.cachedInputTextGenerator.characterCountVisible;
			IList<UICharInfo> characters = this.cachedInputTextGenerator.characters;
			TextGenerator cachedInputTextGenerator = this.cachedInputTextGenerator;
			int lineCount = this.cachedInputTextGenerator.lineCount;
			int num;
			int lineEndPosition = InputField.GetLineEndPosition(this.cachedInputTextGenerator, num);
			IList<UILineInfo> lines = this.cachedInputTextGenerator.lines;
			return this.m_Text._stringLength;
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00007300 File Offset: 0x00005500
		private void MoveDown(bool shift)
		{
			this.MoveDown(shift, true);
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00007318 File Offset: 0x00005518
		private void MoveDown(bool shift, bool goToLastChar)
		{
			bool hasSelection = this.hasSelection;
			int caretPosition = this.m_CaretPosition;
			string text;
			int stringLength = text._stringLength;
			int caretSelectPosition = this.m_CaretSelectPosition;
			string text2;
			int stringLength2 = text2._stringLength;
			this.m_CaretSelectPosition = stringLength2;
			string text3 = this.m_Text;
			int stringLength3 = text3._stringLength;
			this.m_CaretSelectPosition = stringLength3;
			int stringLength4 = text3._stringLength;
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x000073E8 File Offset: 0x000055E8
		private void MoveUp(bool shift)
		{
			this.MoveUp(shift, true);
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00007400 File Offset: 0x00005600
		private void MoveUp(bool shift, bool goToFirstChar)
		{
			bool hasSelection = this.hasSelection;
			int caretPosition = this.m_CaretPosition;
			string text;
			int stringLength = text._stringLength;
			int caretSelectPosition = this.m_CaretSelectPosition;
			string text2;
			int stringLength2 = text2._stringLength;
			this.m_CaretSelectPosition = stringLength2;
			string text3 = this.m_Text;
			int stringLength3 = text3._stringLength;
			this.m_CaretSelectPosition = stringLength3;
			int stringLength4 = text3._stringLength;
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x000074DC File Offset: 0x000056DC
		private void Delete()
		{
			if (!this.m_ReadOnly)
			{
				int caretPosition = this.m_CaretPosition;
				int stringLength = this.compositionString._stringLength;
				int caretSelectPosition = this.m_CaretSelectPosition;
				string text;
				int stringLength2 = text._stringLength;
			}
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00007670 File Offset: 0x00005870
		private void ForwardSpace()
		{
			if (this.m_ReadOnly)
			{
				return;
			}
			bool hasSelection = this.hasSelection;
			this.Delete();
		}

		// Token: 0x060001FA RID: 506 RVA: 0x000076E4 File Offset: 0x000058E4
		private void Backspace()
		{
			if (this.m_ReadOnly)
			{
				return;
			}
			bool hasSelection = this.hasSelection;
			this.Delete();
			this.UpdateTouchKeyboardFromEditChanges();
			this.SendOnValueChanged();
			this.UpdateLabel();
		}

		// Token: 0x060001FB RID: 507 RVA: 0x000077A4 File Offset: 0x000059A4
		private void Insert(char c)
		{
			if (!this.m_ReadOnly)
			{
				this.Delete();
				int characterLimit = this.m_CharacterLimit;
				string text = this.m_Text;
				int stringLength = text._stringLength;
				int caretPosition = this.m_CaretPosition;
				string text3;
				string text2 = text.Insert(caretPosition, text3);
				int caretPosition2 = this.m_CaretPosition;
				this.m_Text = text2;
				string text4;
				int stringLength2 = text4._stringLength;
				int stringLength3 = text3._stringLength;
				this.m_CaretPosition = stringLength2;
				string text5 = this.m_Text;
				int stringLength4 = text5._stringLength;
				int stringLength5 = text5._stringLength;
				this.m_CaretSelectPosition = stringLength2;
				return;
			}
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00007844 File Offset: 0x00005A44
		private void UpdateTouchKeyboardFromEditChanges()
		{
			if (this.m_Keyboard != null)
			{
				bool isSupported = TouchScreenKeyboard.isSupported;
				if (this.m_TouchKeyboardAllowsInPlaceEditing)
				{
					TouchScreenKeyboard keyboard = this.m_Keyboard;
					string text = this.m_Text;
					keyboard.text = text;
					return;
				}
			}
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00007880 File Offset: 0x00005A80
		private void SendOnValueChangedAndUpdateLabel()
		{
			this.SendOnValueChanged();
			this.UpdateLabel();
		}

		// Token: 0x060001FE RID: 510 RVA: 0x0000789C File Offset: 0x00005A9C
		private void SendOnValueChanged()
		{
			UISystemProfilerApi.AddMarker("InputField.value", this);
			if (this.m_OnValueChanged != null)
			{
				string text = this.m_Text;
				return;
			}
		}

		// Token: 0x060001FF RID: 511 RVA: 0x000078C4 File Offset: 0x00005AC4
		protected void SendOnEndEdit()
		{
			UISystemProfilerApi.AddMarker("InputField.onEndEdit", this);
			if (this.m_OnDidEndEdit != null)
			{
				string text = this.m_Text;
				return;
			}
		}

		// Token: 0x06000200 RID: 512 RVA: 0x000078EC File Offset: 0x00005AEC
		protected void SendOnSubmit()
		{
			UISystemProfilerApi.AddMarker("InputField.onSubmit", this);
			if (this.m_OnSubmit != null)
			{
				string text = this.m_Text;
				return;
			}
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00007914 File Offset: 0x00005B14
		protected virtual void Append(string input)
		{
			if (!this.m_ReadOnly)
			{
				bool isSupported = TouchScreenKeyboard.isSupported;
				if (this.m_TouchKeyboardAllowsInPlaceEditing)
				{
					int stringLength = input._stringLength;
					long num = 0L;
					char c = input[(int)num];
				}
			}
		}

		// Token: 0x06000202 RID: 514 RVA: 0x0000794C File Offset: 0x00005B4C
		protected virtual void Append(char input)
		{
			if (!true)
			{
			}
			bool flag = char.IsSurrogate(input);
			if (!this.m_ReadOnly)
			{
				string text = this.m_Text;
				int num = 16381;
				int stringLength = text._stringLength;
				bool isSupported = TouchScreenKeyboard.isSupported;
				if (this.m_TouchKeyboardAllowsInPlaceEditing)
				{
					string text2;
					int stringLength2 = text2._stringLength;
					int caretPosition = this.m_CaretPosition;
					string text3;
					int stringLength3 = text3._stringLength;
					if (num == 0)
					{
					}
					int num2 = Math.Min(1073741824, 0);
					string text4 = this.m_Text;
					int caretSelectPosition = this.m_CaretSelectPosition;
					string text5;
					int stringLength4 = text5._stringLength;
					int caretPosition2 = this.m_CaretPosition;
					string text6;
					int stringLength5 = text6._stringLength;
					int caretPosition3 = this.m_CaretPosition;
					string text7;
					int stringLength6 = text7._stringLength;
					int caretSelectPosition2 = this.m_CaretSelectPosition;
					string text8;
					int stringLength7 = text8._stringLength;
					string text9 = this.m_Text;
					int caretPosition4 = this.m_CaretPosition;
					string text10;
					int stringLength8 = text10._stringLength;
					string text11 = this.m_Text;
					int caretSelectPosition3 = this.m_CaretSelectPosition;
					string text12 = this.m_Text;
					string text13;
					int stringLength9 = text13._stringLength;
					int caretSelectPosition4 = this.m_CaretSelectPosition;
					return;
				}
			}
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00007AF0 File Offset: 0x00005CF0
		protected void UpdateLabel()
		{
			int num = 1;
			Text textComponent = this.m_TextComponent;
			if (num == 0)
			{
			}
			Font font = this.m_TextComponent.font;
			if (!this.m_PreventFontCallback)
			{
				int num2 = 1;
				this.m_PreventFontCallback = num2 != 0;
				if (num2 == 0)
				{
				}
				EventSystem current = EventSystem.current;
				GameObject gameObject = base.gameObject;
				GameObject currentSelected = EventSystem.current.m_CurrentSelected;
				bool flag = gameObject == currentSelected;
				string text;
				int stringLength = text._stringLength;
				string text2 = this.m_Text;
				int caretPosition = this.m_CaretPosition;
				int num3 = 1;
				long num4 = 0L;
				this.m_IsCompositionActive = num3 != 0;
				string text3 = text2.Substring((int)num4, caretPosition);
				string text4 = this.m_Text;
				int caretPosition2 = this.m_CaretPosition;
				string text5 = text4.Substring(caretPosition2);
				string text7;
				string text6 = text3 + text7 + text5;
				return;
			}
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00007C90 File Offset: 0x00005E90
		private bool IsSelectionVisible()
		{
			/*
An exception occurred when decompiling this method (06000204)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean UnityEngine.UI.InputField::IsSelectionVisible()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(InputField::m_DrawStart, ldloc:InputField(this)))
	stloc:int32(var_1_0D, ldfld:int32(InputField::m_CaretPosition, ldloc:InputField(this)))
	stloc:int32(var_2_19, ldfld:int32(string::_stringLength, callgetter:string(InputField::get_compositionString, ldloc:InputField(this))))
	stloc:int32(var_3_20, ldfld:int32(InputField::m_DrawStart, ldloc:InputField(this)))
	stloc:int32(var_4_27, ldfld:int32(InputField::m_CaretSelectPosition, ldloc:InputField(this)))
	stloc:int32(var_6_30, ldfld:int32(string::_stringLength, ldloc:string(var_5)))
	stloc:int32(var_7_38, ldfld:int32(InputField::m_DrawEnd, ldloc:InputField(this)))
	stloc:int32(var_8_40, ldfld:int32(InputField::m_CaretPosition, ldloc:InputField(this)))
	stloc:int32(var_10_49, ldfld:int32(string::_stringLength, ldloc:string(var_9)))
	stloc:int32(var_12_54, ldfld:int32(InputField::m_DrawEnd, ldloc:InputField(this)))
	stloc:int32(var_13_5C, ldfld:int32(InputField::m_CaretSelectPosition, ldloc:InputField(this)))
	stloc:int32(var_15_65, ldfld:int32(string::_stringLength, ldloc:string(var_14)))
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

		// Token: 0x06000205 RID: 517 RVA: 0x00002207 File Offset: 0x00000407
		private static int GetLineStartPosition(TextGenerator gen, int line)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00007D04 File Offset: 0x00005F04
		private static int GetLineEndPosition(TextGenerator gen, int line)
		{
			int num;
			return num;
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00007D1C File Offset: 0x00005F1C
		private void SetDrawRangeToContainCaretPosition(int caretPos)
		{
			int lineCount = this.cachedInputTextGenerator.lineCount;
			Vector2 size = this.cachedInputTextGenerator.rectExtents.size;
			InputField.LineType lineType = this.m_LineType;
			TextGenerator textGenerator;
			IList<UILineInfo> lines = textGenerator.lines;
			TextGenerator cachedInputTextGenerator = this.cachedInputTextGenerator;
			int drawEnd = this.m_DrawEnd;
			int num;
			int lineEndPosition = InputField.GetLineEndPosition(this.cachedInputTextGenerator, num);
			this.m_DrawEnd = lineEndPosition;
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00007EAC File Offset: 0x000060AC
		public void ForceLabelUpdate()
		{
			this.UpdateLabel();
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00007EC0 File Offset: 0x000060C0
		private void MarkGeometryAsDirty()
		{
			if (!true)
			{
			}
			CanvasUpdateRegistry.RegisterCanvasElementForGraphicRebuild(this);
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00007ED8 File Offset: 0x000060D8
		public virtual void Rebuild(CanvasUpdate update)
		{
			this.UpdateGeometry();
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00007EEC File Offset: 0x000060EC
		public virtual void LayoutComplete()
		{
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00007EFC File Offset: 0x000060FC
		public virtual void GraphicUpdateComplete()
		{
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00007F0C File Offset: 0x0000610C
		private void UpdateGeometry()
		{
			bool isSupported = TouchScreenKeyboard.isSupported;
			bool hideMobileInput;
			if (!this.m_TouchKeyboardAllowsInPlaceEditing)
			{
				RuntimePlatform platform = Application.platform;
				hideMobileInput = this.m_HideMobileInput;
				if (!hideMobileInput)
				{
					return;
				}
			}
			CanvasRenderer cachedInputRenderer = this.m_CachedInputRenderer;
			if (!hideMobileInput)
			{
			}
			Text textComponent = this.m_TextComponent;
			if (!hideMobileInput)
			{
			}
			string text = base.transform.name + " Input Caret";
			if (2304 == 0)
			{
			}
			Type type;
			Type type2;
			if ((type != null && type == null) || (type2 != null && type2 == null))
			{
				throw new ArrayTypeMismatchException();
			}
			Text textComponent2 = this.m_TextComponent;
			Transform parent = textComponent2.transform.parent;
			Transform transform;
			transform.SetParent(parent);
			Transform transform2;
			transform2.SetAsFirstSibling();
			int layer = base.gameObject.layer;
			RectTransform rectTransform;
			this.caretRectTrans = rectTransform;
			CanvasRenderer canvasRenderer;
			this.m_CachedInputRenderer = canvasRenderer;
			Text textComponent3 = this.m_TextComponent;
			if (textComponent2 == null)
			{
			}
			Material defaultGraphicMaterial = Graphic.defaultGraphicMaterial;
			Texture2D whiteTexture = Texture2D.whiteTexture;
			this.AssignPositioningIfNeeded();
			CanvasRenderer cachedInputRenderer2 = this.m_CachedInputRenderer;
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00008030 File Offset: 0x00006230
		private void AssignPositioningIfNeeded()
		{
			Text textComponent = this.m_TextComponent;
			if (!true)
			{
			}
			RectTransform rectTransform = this.caretRectTrans;
			if (!true)
			{
			}
			Vector3 localPosition = this.caretRectTrans.localPosition;
			RectTransform rectTransform2;
			Vector3 localPosition2 = rectTransform2.localPosition;
			Quaternion localRotation = this.caretRectTrans.localRotation;
			Quaternion localRotation2 = this.m_TextComponent.rectTransform.localRotation;
			Vector3 localScale = this.caretRectTrans.localScale;
			Vector3 localScale2 = this.m_TextComponent.rectTransform.localScale;
			Vector2 anchorMin = this.caretRectTrans.anchorMin;
			Vector2 anchorMin2 = this.m_TextComponent.rectTransform.anchorMin;
			Vector2 anchorMax = this.caretRectTrans.anchorMax;
			Vector2 anchorMax2 = this.m_TextComponent.rectTransform.anchorMax;
			Vector2 anchoredPosition = this.caretRectTrans.anchoredPosition;
			Vector2 anchoredPosition2 = this.m_TextComponent.rectTransform.anchoredPosition;
			Vector2 sizeDelta = this.caretRectTrans.sizeDelta;
			Vector2 sizeDelta2 = this.m_TextComponent.rectTransform.sizeDelta;
			Vector2 pivot = this.caretRectTrans.pivot;
			Vector2 pivot2 = this.m_TextComponent.rectTransform.pivot;
			Text textComponent2 = this.m_TextComponent;
			RectTransform rectTransform3 = this.caretRectTrans;
			Vector3 localPosition3 = textComponent2.rectTransform.localPosition;
			Text textComponent3 = this.m_TextComponent;
			RectTransform rectTransform4 = this.caretRectTrans;
			Quaternion localRotation3 = textComponent3.rectTransform.localRotation;
			long num = 0L;
			rectTransform4.localRotation = num;
			Text textComponent4 = this.m_TextComponent;
			RectTransform rectTransform5 = this.caretRectTrans;
			Vector3 localScale3 = textComponent4.rectTransform.localScale;
			Text textComponent5 = this.m_TextComponent;
			RectTransform rectTransform6 = this.caretRectTrans;
			Vector2 anchorMin3 = textComponent5.rectTransform.anchorMin;
			Text textComponent6 = this.m_TextComponent;
			RectTransform rectTransform7 = this.caretRectTrans;
			Vector2 anchorMax3 = textComponent6.rectTransform.anchorMax;
			Text textComponent7 = this.m_TextComponent;
			RectTransform rectTransform8 = this.caretRectTrans;
			Vector2 anchoredPosition3 = textComponent7.rectTransform.anchoredPosition;
			Text textComponent8 = this.m_TextComponent;
			RectTransform rectTransform9 = this.caretRectTrans;
			Vector2 sizeDelta3 = textComponent8.rectTransform.sizeDelta;
			Text textComponent9 = this.m_TextComponent;
			RectTransform rectTransform10 = this.caretRectTrans;
			Vector2 pivot3 = textComponent9.rectTransform.pivot;
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00008240 File Offset: 0x00006440
		private void OnFillVBO(Mesh vbo)
		{
			if (this.m_AllowInput)
			{
				Text textComponent = this.m_TextComponent;
				bool hasSelection = this.hasSelection;
				return;
			}
		}

		// Token: 0x06000210 RID: 528 RVA: 0x0000828C File Offset: 0x0000648C
		private void GenerateCaret(VertexHelper vbo, Vector2 roundingOffset)
		{
			if (this.m_CaretVisible)
			{
				if (this.m_CursorVerts == null)
				{
					this.CreateCursorVerts();
				}
				int caretWidth = this.m_CaretWidth;
				int caretPosition = this.m_CaretPosition;
				int stringLength = this.compositionString._stringLength;
				Text textComponent = this.m_TextComponent;
				int drawStart = this.m_DrawStart;
				TextGenerator cachedTextGenerator = textComponent.cachedTextGenerator;
				if (cachedTextGenerator != null && cachedTextGenerator.lineCount != 0)
				{
					IList<UICharInfo> characters = cachedTextGenerator.characters;
					return;
				}
			}
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00008468 File Offset: 0x00006668
		private void CreateCursorVerts()
		{
			if (!true)
			{
			}
			UIVertex[] cursorVerts = this.m_CursorVerts;
			UIVertex[] cursorVerts2 = this.m_CursorVerts;
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00008490 File Offset: 0x00006690
		private void GenerateHighlight(VertexHelper vbo, Vector2 roundingOffset)
		{
			int caretPosition = this.m_CaretPosition;
			string text;
			int stringLength = text._stringLength;
			int drawStart = this.m_DrawStart;
			int caretSelectPosition = this.m_CaretSelectPosition;
			string text2;
			int stringLength2 = text2._stringLength;
			int drawStart2 = this.m_DrawStart;
			TextGenerator cachedTextGenerator = this.m_TextComponent.cachedTextGenerator;
			int lineCount = cachedTextGenerator.lineCount;
			if (drawStart2 == 0)
			{
			}
			int num;
			int lineEndPosition = InputField.GetLineEndPosition(cachedTextGenerator, num);
			if (drawStart2 == 0)
			{
			}
			float r = this.m_SelectionColor.r;
			float g = this.m_SelectionColor.g;
			float b = this.m_SelectionColor.b;
			float a = this.m_SelectionColor.a;
		}

		// Token: 0x06000213 RID: 531 RVA: 0x0000860C File Offset: 0x0000680C
		protected char Validate(string text, int pos, char ch)
		{
			while (this.m_CharacterValidation == InputField.CharacterValidation.None)
			{
			}
			bool enabled = base.enabled;
			InputField.CharacterValidation characterValidation = this.m_CharacterValidation;
			if (pos != 0)
			{
				if (characterValidation == InputField.CharacterValidation.None)
				{
				}
				bool flag = char.IsLetter(ch);
				if (characterValidation == InputField.CharacterValidation.None)
				{
				}
				bool flag2 = char.IsLower(ch);
				if (pos != 0)
				{
				}
				if (characterValidation == InputField.CharacterValidation.None)
				{
				}
				return char.ToUpper(ch);
			}
			int stringLength = text._stringLength;
			long num = 0L;
			char c = text[(int)num];
			int stringLength2 = text._stringLength;
			long num2 = 0L;
			char c2 = text[(int)num2];
			int caretPosition = this.m_CaretPosition;
			string text2;
			int stringLength3 = text2._stringLength;
			int caretSelectPosition = this.m_CaretSelectPosition;
			string text3;
			int stringLength4 = text3._stringLength;
			bool flag3 = text.Contains("'");
			int num3;
			char c3 = text[num3];
			char c4 = text[num3];
			char c5 = text[num3];
			int stringLength5 = text._stringLength;
			char c6 = text[pos];
			char c7 = text[pos];
			return text[pos];
		}

		// Token: 0x06000214 RID: 532 RVA: 0x000087DC File Offset: 0x000069DC
		public void ActivateInputField()
		{
			Text textComponent = this.m_TextComponent;
			if (!true)
			{
			}
			Font font = this.m_TextComponent.font;
			if (this.m_AllowInput)
			{
				TouchScreenKeyboard keyboard = this.m_Keyboard;
				if (keyboard != null)
				{
					bool active = keyboard.active;
					this.m_Keyboard.active = true;
					TouchScreenKeyboard keyboard2 = this.m_Keyboard;
					string text = this.m_Text;
					keyboard2.text = text;
				}
			}
			this.m_ShouldActivateNextUpdate = true;
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00008848 File Offset: 0x00006A48
		private void ActivateInputFieldInternal()
		{
			if (!true)
			{
			}
			EventSystem current = EventSystem.current;
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00008984 File Offset: 0x00006B84
		public override void OnSelect(BaseEventData eventData)
		{
			base.OnSelect(eventData);
			this.ActivateInputField();
		}

		// Token: 0x06000217 RID: 535 RVA: 0x000089A0 File Offset: 0x00006BA0
		public virtual void OnPointerClick(PointerEventData eventData)
		{
			if (eventData.<button>k__BackingField != PointerEventData.InputButton.Left)
			{
				return;
			}
			this.ActivateInputField();
		}

		// Token: 0x06000218 RID: 536 RVA: 0x000089BC File Offset: 0x00006BBC
		public void DeactivateInputField()
		{
			bool allowInput = this.m_AllowInput;
			if (allowInput)
			{
				Graphic placeholder = this.m_Placeholder;
				if (!allowInput)
				{
				}
				string text = this.m_Text;
				Graphic placeholder2 = this.m_Placeholder;
				long num = 0L;
				bool flag = string.IsNullOrEmpty(text);
				placeholder2.enabled = num != 0L;
				Text textComponent = this.m_TextComponent;
				if (!allowInput)
				{
				}
				if (this.m_WasCanceled)
				{
					string originalText = this.m_OriginalText;
					this.SetText(originalText, true);
				}
				this.SendOnEndEdit();
				TouchScreenKeyboard keyboard = this.m_Keyboard;
				if (keyboard != null)
				{
					long num2 = 0L;
					keyboard.active = num2 != 0L;
				}
				this.MarkGeometryAsDirty();
				return;
			}
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00008A4C File Offset: 0x00006C4C
		public override void OnDeselect(BaseEventData eventData)
		{
			this.DeactivateInputField();
			base.OnDeselect(eventData);
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00008A68 File Offset: 0x00006C68
		public virtual void OnSubmit(BaseEventData eventData)
		{
			if (!this.m_AllowInput)
			{
				this.m_ShouldActivateNextUpdate = true;
			}
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00008A84 File Offset: 0x00006C84
		private void EnforceContentType()
		{
			InputField.ContentType contentType = this.m_ContentType;
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00008AC0 File Offset: 0x00006CC0
		private void EnforceTextHOverflow()
		{
			int num = 1;
			Text textComponent = this.m_TextComponent;
			if (num == 0)
			{
			}
			InputField.LineType lineType = this.m_LineType;
			Text textComponent2 = this.m_TextComponent;
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00008AEC File Offset: 0x00006CEC
		private void SetToCustomIfContentTypeIsNot(params InputField.ContentType[] allowedContentTypes)
		{
			InputField.ContentType contentType = this.m_ContentType;
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00008B04 File Offset: 0x00006D04
		private void SetToCustom()
		{
			InputField.ContentType contentType = this.m_ContentType;
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00008B24 File Offset: 0x00006D24
		protected override void DoStateTransition(Selectable.SelectionState state, bool instant)
		{
			if (this.m_HasDoneFocusTransition)
			{
				return;
			}
			this.m_HasDoneFocusTransition = true;
			base.DoStateTransition(Selectable.SelectionState.Selected, instant);
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00008B4C File Offset: 0x00006D4C
		public virtual void CalculateLayoutInputHorizontal()
		{
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00008B5C File Offset: 0x00006D5C
		public virtual void CalculateLayoutInputVertical()
		{
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000222 RID: 546 RVA: 0x00002207 File Offset: 0x00000407
		public virtual float minWidth
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000223 RID: 547 RVA: 0x00008B6C File Offset: 0x00006D6C
		public virtual float preferredWidth
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000223)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single UnityEngine.UI.InputField::get_preferredWidth()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000A:
	stloc:Text(var_2_10, ldfld:Text(InputField::m_TextComponent, ldloc:InputField(this)))
	stloc:TextGenerator(var_4_1C, callgetter:TextGenerator(Text::get_cachedTextGeneratorForLayout, ldfld:Text(InputField::m_TextComponent, ldloc:InputField(this))))
	stloc:string(var_5_24, ldfld:string(InputField::m_Text, ldloc:InputField(this)))
	stloc:float32(var_7_31, callgetter:float32(Text::get_pixelsPerUnit, ldfld:Text(InputField::m_TextComponent, ldloc:InputField(this))))
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

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000224 RID: 548 RVA: 0x00002207 File Offset: 0x00000407
		public virtual float flexibleWidth
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000225 RID: 549 RVA: 0x00002207 File Offset: 0x00000407
		public virtual float minHeight
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000226 RID: 550 RVA: 0x00008BAC File Offset: 0x00006DAC
		public virtual float preferredHeight
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000226)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single UnityEngine.UI.InputField::get_preferredHeight()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000A:
	stloc:Vector2(var_2_1F, callgetter:Vector2(Rect::get_size, callgetter:Rect[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Rect&](RectTransform::get_rect, callgetter:RectTransform(Graphic::get_rectTransform, ldfld:Text[exp:Graphic](InputField::m_TextComponent, ldloc:InputField(this))))))
	stloc:TextGenerator(var_4_2B, callgetter:TextGenerator(Text::get_cachedTextGeneratorForLayout, ldfld:Text(InputField::m_TextComponent, ldloc:InputField(this))))
	stloc:string(var_5_33, ldfld:string(InputField::m_Text, ldloc:InputField(this)))
	stloc:float32(var_7_40, callgetter:float32(Text::get_pixelsPerUnit, ldfld:Text(InputField::m_TextComponent, ldloc:InputField(this))))
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

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000227 RID: 551 RVA: 0x00002207 File Offset: 0x00000407
		public virtual float flexibleHeight
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000228 RID: 552 RVA: 0x00008BFC File Offset: 0x00006DFC
		public virtual int layoutPriority
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00008C0C File Offset: 0x00006E0C
		// Note: this type is marked as 'beforefieldinit'.
		static InputField()
		{
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00008C1C File Offset: 0x00006E1C
		Transform ICanvasElement.get_transform()
		{
			return base.transform;
		}

		// Token: 0x040000C6 RID: 198
		protected TouchScreenKeyboard m_Keyboard;

		// Token: 0x040000C7 RID: 199
		private static readonly char[] kSeparators;

		// Token: 0x040000C8 RID: 200
		private static bool s_IsQuestDeviceEvaluated;

		// Token: 0x040000C9 RID: 201
		private static bool s_IsQuestDevice;

		// Token: 0x040000CA RID: 202
		[FormerlySerializedAs("text")]
		[SerializeField]
		protected Text m_TextComponent;

		// Token: 0x040000CB RID: 203
		[SerializeField]
		protected Graphic m_Placeholder;

		// Token: 0x040000CC RID: 204
		[SerializeField]
		private InputField.ContentType m_ContentType;

		// Token: 0x040000CD RID: 205
		[SerializeField]
		[FormerlySerializedAs("inputType")]
		private InputField.InputType m_InputType;

		// Token: 0x040000CE RID: 206
		[FormerlySerializedAs("asteriskChar")]
		[SerializeField]
		private char m_AsteriskChar;

		// Token: 0x040000CF RID: 207
		[FormerlySerializedAs("keyboardType")]
		[SerializeField]
		private TouchScreenKeyboardType m_KeyboardType;

		// Token: 0x040000D0 RID: 208
		[SerializeField]
		private InputField.LineType m_LineType;

		// Token: 0x040000D1 RID: 209
		[FormerlySerializedAs("hideMobileInput")]
		[SerializeField]
		private bool m_HideMobileInput;

		// Token: 0x040000D2 RID: 210
		[FormerlySerializedAs("validation")]
		[SerializeField]
		private InputField.CharacterValidation m_CharacterValidation;

		// Token: 0x040000D3 RID: 211
		[SerializeField]
		[FormerlySerializedAs("characterLimit")]
		private int m_CharacterLimit;

		// Token: 0x040000D4 RID: 212
		[FormerlySerializedAs("m_EndEdit")]
		[FormerlySerializedAs("m_OnSubmit")]
		[FormerlySerializedAs("onSubmit")]
		[SerializeField]
		[FormerlySerializedAs("m_OnEndEdit")]
		private InputField.SubmitEvent m_OnSubmit;

		// Token: 0x040000D5 RID: 213
		[SerializeField]
		private InputField.EndEditEvent m_OnDidEndEdit;

		// Token: 0x040000D6 RID: 214
		[SerializeField]
		[FormerlySerializedAs("m_OnValueChange")]
		[FormerlySerializedAs("onValueChange")]
		private InputField.OnChangeEvent m_OnValueChanged;

		// Token: 0x040000D7 RID: 215
		[SerializeField]
		[FormerlySerializedAs("onValidateInput")]
		private InputField.OnValidateInput m_OnValidateInput;

		// Token: 0x040000D8 RID: 216
		[FormerlySerializedAs("selectionColor")]
		[SerializeField]
		private Color m_CaretColor;

		// Token: 0x040000D9 RID: 217
		[SerializeField]
		private bool m_CustomCaretColor;

		// Token: 0x040000DA RID: 218
		[SerializeField]
		private Color m_SelectionColor;

		// Token: 0x040000DB RID: 219
		[SerializeField]
		[Multiline]
		[FormerlySerializedAs("mValue")]
		protected string m_Text;

		// Token: 0x040000DC RID: 220
		[SerializeField]
		[Range(0f, 4f)]
		private float m_CaretBlinkRate;

		// Token: 0x040000DD RID: 221
		[SerializeField]
		[Range(1f, 5f)]
		private int m_CaretWidth;

		// Token: 0x040000DE RID: 222
		[SerializeField]
		private bool m_ReadOnly;

		// Token: 0x040000DF RID: 223
		[SerializeField]
		private bool m_ShouldActivateOnSelect;

		// Token: 0x040000E0 RID: 224
		protected int m_CaretPosition;

		// Token: 0x040000E1 RID: 225
		protected int m_CaretSelectPosition;

		// Token: 0x040000E2 RID: 226
		private RectTransform caretRectTrans;

		// Token: 0x040000E3 RID: 227
		protected UIVertex[] m_CursorVerts;

		// Token: 0x040000E4 RID: 228
		private TextGenerator m_InputTextCache;

		// Token: 0x040000E5 RID: 229
		private CanvasRenderer m_CachedInputRenderer;

		// Token: 0x040000E6 RID: 230
		private bool m_PreventFontCallback;

		// Token: 0x040000E7 RID: 231
		[NonSerialized]
		protected Mesh m_Mesh;

		// Token: 0x040000E8 RID: 232
		private bool m_AllowInput;

		// Token: 0x040000E9 RID: 233
		private bool m_ShouldActivateNextUpdate;

		// Token: 0x040000EA RID: 234
		private bool m_UpdateDrag;

		// Token: 0x040000EB RID: 235
		private bool m_DragPositionOutOfBounds;

		// Token: 0x040000EC RID: 236
		private const float kHScrollSpeed = 0.05f;

		// Token: 0x040000ED RID: 237
		private const float kVScrollSpeed = 0.1f;

		// Token: 0x040000EE RID: 238
		protected bool m_CaretVisible;

		// Token: 0x040000EF RID: 239
		private Coroutine m_BlinkCoroutine;

		// Token: 0x040000F0 RID: 240
		private float m_BlinkStartTime;

		// Token: 0x040000F1 RID: 241
		protected int m_DrawStart;

		// Token: 0x040000F2 RID: 242
		protected int m_DrawEnd;

		// Token: 0x040000F3 RID: 243
		private Coroutine m_DragCoroutine;

		// Token: 0x040000F4 RID: 244
		private string m_OriginalText;

		// Token: 0x040000F5 RID: 245
		private bool m_WasCanceled;

		// Token: 0x040000F6 RID: 246
		private bool m_HasDoneFocusTransition;

		// Token: 0x040000F7 RID: 247
		private WaitForSecondsRealtime m_WaitForSecondsRealtime;

		// Token: 0x040000F8 RID: 248
		private bool m_TouchKeyboardAllowsInPlaceEditing;

		// Token: 0x040000F9 RID: 249
		private bool m_IsCompositionActive;

		// Token: 0x040000FA RID: 250
		private const string kEmailSpecialCharacters = "!#$%&'*+-/=?^_`{|}~";

		// Token: 0x040000FB RID: 251
		private const string kOculusQuestDeviceModel = "Oculus Quest";

		// Token: 0x040000FC RID: 252
		private Event m_ProcessingEvent;

		// Token: 0x040000FD RID: 253
		private const int k_MaxTextLength = 16382;

		// Token: 0x0200002D RID: 45
		public enum ContentType
		{
			// Token: 0x040000FF RID: 255
			Standard,
			// Token: 0x04000100 RID: 256
			Autocorrected,
			// Token: 0x04000101 RID: 257
			IntegerNumber,
			// Token: 0x04000102 RID: 258
			DecimalNumber,
			// Token: 0x04000103 RID: 259
			Alphanumeric,
			// Token: 0x04000104 RID: 260
			Name,
			// Token: 0x04000105 RID: 261
			EmailAddress,
			// Token: 0x04000106 RID: 262
			Password,
			// Token: 0x04000107 RID: 263
			Pin,
			// Token: 0x04000108 RID: 264
			Custom
		}

		// Token: 0x0200002E RID: 46
		public enum InputType
		{
			// Token: 0x0400010A RID: 266
			Standard,
			// Token: 0x0400010B RID: 267
			AutoCorrect,
			// Token: 0x0400010C RID: 268
			Password
		}

		// Token: 0x0200002F RID: 47
		public enum CharacterValidation
		{
			// Token: 0x0400010E RID: 270
			None,
			// Token: 0x0400010F RID: 271
			Integer,
			// Token: 0x04000110 RID: 272
			Decimal,
			// Token: 0x04000111 RID: 273
			Alphanumeric,
			// Token: 0x04000112 RID: 274
			Name,
			// Token: 0x04000113 RID: 275
			EmailAddress
		}

		// Token: 0x02000030 RID: 48
		public enum LineType
		{
			// Token: 0x04000115 RID: 277
			SingleLine,
			// Token: 0x04000116 RID: 278
			MultiLineSubmit,
			// Token: 0x04000117 RID: 279
			MultiLineNewline
		}

		// Token: 0x02000031 RID: 49
		public sealed class OnValidateInput : MulticastDelegate
		{
			// Token: 0x0600022B RID: 555 RVA: 0x00008C30 File Offset: 0x00006E30
			public OnValidateInput(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x0600022C RID: 556 RVA: 0x00008C84 File Offset: 0x00006E84
			public char Invoke(string text, int charIndex, char addedChar)
			{
				/*
An exception occurred when decompiling this method (0600022C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Char UnityEngine.UI.InputField/OnValidateInput::Invoke(System.String,System.Int32,System.Char)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:native int(var_0_06, ldfld:native int(Delegate::method_code, ldloc:OnValidateInput[exp:Delegate](this)))
	stloc:native int(var_1_0D, ldfld:native int(Delegate::invoke_impl, ldloc:OnValidateInput[exp:Delegate](this)))
	stloc:native int(var_2_14, ldfld:native int(Delegate::method, ldloc:OnValidateInput[exp:Delegate](this)))
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

			// Token: 0x0600022D RID: 557 RVA: 0x00002207 File Offset: 0x00000407
			public IAsyncResult BeginInvoke(string text, int charIndex, char addedChar, AsyncCallback callback, object @object)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x0600022E RID: 558 RVA: 0x00002207 File Offset: 0x00000407
			public char EndInvoke(IAsyncResult result)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x02000032 RID: 50
		[Serializable]
		public class SubmitEvent : UnityEvent<string>
		{
			// Token: 0x0600022F RID: 559 RVA: 0x00008CA8 File Offset: 0x00006EA8
			public SubmitEvent()
			{
			}
		}

		// Token: 0x02000033 RID: 51
		[Serializable]
		public class EndEditEvent : UnityEvent<string>
		{
			// Token: 0x06000230 RID: 560 RVA: 0x00008CB8 File Offset: 0x00006EB8
			public EndEditEvent()
			{
			}
		}

		// Token: 0x02000034 RID: 52
		[Serializable]
		public class OnChangeEvent : UnityEvent<string>
		{
			// Token: 0x06000231 RID: 561 RVA: 0x00008CC8 File Offset: 0x00006EC8
			public OnChangeEvent()
			{
			}
		}

		// Token: 0x02000035 RID: 53
		protected enum EditState
		{
			// Token: 0x04000119 RID: 281
			Continue,
			// Token: 0x0400011A RID: 282
			Finish
		}

		// Token: 0x02000036 RID: 54
		[CompilerGenerated]
		private sealed class <CaretBlink>d__172 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06000232 RID: 562 RVA: 0x00008CD8 File Offset: 0x00006ED8
			[DebuggerHidden]
			public <CaretBlink>d__172(int <>1__state)
			{
				this.<>1__state = <>1__state;
			}

			// Token: 0x06000233 RID: 563 RVA: 0x00008CF4 File Offset: 0x00006EF4
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06000234 RID: 564 RVA: 0x00008D04 File Offset: 0x00006F04
			private bool MoveNext()
			{
				/*
An exception occurred when decompiling this method (06000234)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean UnityEngine.UI.InputField/<CaretBlink>d__172::MoveNext()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_003F:
	stloc:float32(var_8_4A, callgetter:float32(Time::get_unscaledTime))
	stloc:float32(var_9_52, ldfld:float32(InputField::m_BlinkStartTime, ldloc:InputField(var_1_0D)))
	stloc:bool(var_10_5A, ldfld:bool(InputField::m_CaretVisible, ldloc:InputField(var_1_0D)))
	stfld:bool(InputField::m_CaretVisible, ldloc:InputField(var_1_0D), ldloc:bool(var_10_5A))
	stloc:bool(var_11_6A, callgetter:bool(InputField::get_hasSelection, ldloc:InputField(var_1_0D)))
	stloc:int32(var_12_6D, ldc.i4:int32(2))
	stfld:int32('<CaretBlink>d__172'::<>1__state, ldloc:'<CaretBlink>d__172'(this), ldloc:int32(var_12_6D))
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

			// Token: 0x17000094 RID: 148
			// (get) Token: 0x06000235 RID: 565 RVA: 0x00008D8C File Offset: 0x00006F8C
			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return this.<>2__current;
				}
			}

			// Token: 0x06000236 RID: 566 RVA: 0x00002207 File Offset: 0x00000407
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x17000095 RID: 149
			// (get) Token: 0x06000237 RID: 567 RVA: 0x00008DA0 File Offset: 0x00006FA0
			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return this.<>2__current;
				}
			}

			// Token: 0x0400011B RID: 283
			private int <>1__state;

			// Token: 0x0400011C RID: 284
			private object <>2__current;

			// Token: 0x0400011D RID: 285
			public InputField <>4__this;
		}

		// Token: 0x02000037 RID: 55
		[CompilerGenerated]
		private sealed class <MouseDragOutsideRect>d__194 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06000238 RID: 568 RVA: 0x00008DB4 File Offset: 0x00006FB4
			[DebuggerHidden]
			public <MouseDragOutsideRect>d__194(int <>1__state)
			{
				this.<>1__state = <>1__state;
			}

			// Token: 0x06000239 RID: 569 RVA: 0x00008DD0 File Offset: 0x00006FD0
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			// Token: 0x0600023A RID: 570 RVA: 0x00008DE0 File Offset: 0x00006FE0
			private bool MoveNext()
			{
				/*
An exception occurred when decompiling this method (0600023A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean UnityEngine.UI.InputField/<MouseDragOutsideRect>d__194::MoveNext()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_00C5:
	stloc:int32(var_24_C6, ldc.i4:int32(1))
	stfld:int32('<MouseDragOutsideRect>d__194'::<>1__state, ldloc:'<MouseDragOutsideRect>d__194'(this), ldloc:int32(var_24_C6))
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

			// Token: 0x17000096 RID: 150
			// (get) Token: 0x0600023B RID: 571 RVA: 0x00008EBC File Offset: 0x000070BC
			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return this.<>2__current;
				}
			}

			// Token: 0x0600023C RID: 572 RVA: 0x00002207 File Offset: 0x00000407
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x17000097 RID: 151
			// (get) Token: 0x0600023D RID: 573 RVA: 0x00008ED0 File Offset: 0x000070D0
			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return this.<>2__current;
				}
			}

			// Token: 0x0400011E RID: 286
			private int <>1__state;

			// Token: 0x0400011F RID: 287
			private object <>2__current;

			// Token: 0x04000120 RID: 288
			public PointerEventData eventData;

			// Token: 0x04000121 RID: 289
			public InputField <>4__this;
		}
	}
}
