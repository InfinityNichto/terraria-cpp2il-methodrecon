using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200001C RID: 28
	[NativeHeader("Modules/IMGUI/GUIStyle.bindings.h")]
	[RequiredByNativeCode]
	[NativeHeader("IMGUIScriptingClasses.h")]
	[Serializable]
	[StructLayout(0)]
	public sealed class GUIStyle
	{
		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000FC RID: 252 RVA: 0x00004A50 File Offset: 0x00002C50
		// (set) Token: 0x060000FD RID: 253 RVA: 0x00004A64 File Offset: 0x00002C64
		[NativeProperty("Name", false, TargetType.Function)]
		internal string rawName
		{
			get
			{
				throw new MissingMethodException();
			}
			set
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000FE RID: 254 RVA: 0x00004A78 File Offset: 0x00002C78
		[NativeProperty("m_ImagePosition", false, TargetType.Field)]
		public ImagePosition imagePosition
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000FF RID: 255 RVA: 0x00004A8C File Offset: 0x00002C8C
		[NativeProperty("m_WordWrap", false, TargetType.Field)]
		public bool wordWrap
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000100 RID: 256 RVA: 0x00004AA0 File Offset: 0x00002CA0
		[NativeProperty("m_FixedWidth", false, TargetType.Field)]
		public float fixedWidth
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000101 RID: 257 RVA: 0x00004AB4 File Offset: 0x00002CB4
		[NativeProperty("m_FixedHeight", false, TargetType.Field)]
		public float fixedHeight
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000102 RID: 258 RVA: 0x00004AC8 File Offset: 0x00002CC8
		[NativeProperty("m_StretchWidth", false, TargetType.Field)]
		public bool stretchWidth
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000103 RID: 259 RVA: 0x00004ADC File Offset: 0x00002CDC
		// (set) Token: 0x06000104 RID: 260 RVA: 0x00004AF0 File Offset: 0x00002CF0
		[NativeProperty("m_StretchHeight", false, TargetType.Field)]
		public bool stretchHeight
		{
			get
			{
				throw new MissingMethodException();
			}
			set
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00004B04 File Offset: 0x00002D04
		[FreeFunction(Name = "GUIStyle_Bindings::Internal_Create", IsThreadSafe = true)]
		private static IntPtr Internal_Create(GUIStyle self)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00004B18 File Offset: 0x00002D18
		[FreeFunction(Name = "GUIStyle_Bindings::Internal_Destroy", IsThreadSafe = true)]
		private static void Internal_Destroy(IntPtr self)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00004B2C File Offset: 0x00002D2C
		[FreeFunction(Name = "GUIStyle_Bindings::GetStyleStatePtr", IsThreadSafe = true, HasExplicitThis = true)]
		private IntPtr GetStyleStatePtr(int idx)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00004B40 File Offset: 0x00002D40
		[FreeFunction(Name = "GUIStyle_Bindings::GetRectOffsetPtr", HasExplicitThis = true)]
		private IntPtr GetRectOffsetPtr(int idx)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00004B54 File Offset: 0x00002D54
		[FreeFunction(Name = "GUIStyle_Bindings::Internal_Draw", HasExplicitThis = true)]
		private void Internal_Draw(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00004B68 File Offset: 0x00002D68
		[FreeFunction(Name = "GUIStyle_Bindings::Internal_Draw2", HasExplicitThis = true)]
		private void Internal_Draw2(Rect position, GUIContent content, int controlID, bool on)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00004B7C File Offset: 0x00002D7C
		[FreeFunction(Name = "GUIStyle_Bindings::Internal_CalcSizeWithConstraints", HasExplicitThis = true)]
		internal Vector2 Internal_CalcSizeWithConstraints(GUIContent content, Vector2 maxSize)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00004B90 File Offset: 0x00002D90
		[FreeFunction(Name = "GUIStyle_Bindings::Internal_CalcHeight", HasExplicitThis = true)]
		private float Internal_CalcHeight(GUIContent content, float width)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00004BA4 File Offset: 0x00002DA4
		[FreeFunction(Name = "GUIStyle_Bindings::Internal_CalcMinMaxWidth", HasExplicitThis = true)]
		private Vector2 Internal_CalcMinMaxWidth(GUIContent content)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00004BB8 File Offset: 0x00002DB8
		[FreeFunction(Name = "GUIStyle_Bindings::SetMouseTooltip")]
		internal static void SetMouseTooltip(string tooltip, Rect screenRect)
		{
			if (!true)
			{
			}
			throw new MissingMethodException();
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00004BD0 File Offset: 0x00002DD0
		[FreeFunction(Name = "GUIStyle_Bindings::IsTooltipActive")]
		internal static bool IsTooltipActive(string tooltip)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00004BE4 File Offset: 0x00002DE4
		[FreeFunction(Name = "GUIStyle::SetDefaultFont")]
		internal static void SetDefaultFont(Font font)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00004BF8 File Offset: 0x00002DF8
		public GUIStyle()
		{
			int num = 1;
			base..ctor();
			if (num == 0)
			{
			}
			throw new MissingMethodException();
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00004C20 File Offset: 0x00002E20
		protected override void Finalize()
		{
			IntPtr ptr = this.m_Ptr;
			IntPtr ptr2 = this.m_Ptr;
			throw new MissingMethodException();
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000113 RID: 275 RVA: 0x00004C6C File Offset: 0x00002E6C
		// (set) Token: 0x06000114 RID: 276 RVA: 0x00004C90 File Offset: 0x00002E90
		public string name
		{
			get
			{
				while (this.m_Name != null)
				{
				}
				throw new MissingMethodException();
			}
			set
			{
				this.m_Name = value;
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000115 RID: 277 RVA: 0x00004CAC File Offset: 0x00002EAC
		public GUIStyleState normal
		{
			get
			{
				if (this.m_Normal == null)
				{
					throw new MissingMethodException();
				}
				GUIStyleState guistyleState;
				return guistyleState;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000116 RID: 278 RVA: 0x00004CD0 File Offset: 0x00002ED0
		public RectOffset margin
		{
			get
			{
				while (this.m_Margin != null)
				{
				}
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000117 RID: 279 RVA: 0x00004CEC File Offset: 0x00002EEC
		public RectOffset padding
		{
			get
			{
				while (this.m_Padding != null)
				{
				}
				throw new MissingMethodException();
			}
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00004D08 File Offset: 0x00002F08
		public void Draw(Rect position, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
		{
			this.Internal_Draw(position, content, isHover, isActive, on, hasKeyboardFocus);
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00004D24 File Offset: 0x00002F24
		public void Draw(Rect position, GUIContent content, int controlID)
		{
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00004D34 File Offset: 0x00002F34
		public void Draw(Rect position, GUIContent content, int controlID, bool on, bool hover)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00004D48 File Offset: 0x00002F48
		private void Draw(Rect position, GUIContent content, int controlId, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
		{
			this.Internal_Draw2(position, content, controlId, isHover);
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600011C RID: 284 RVA: 0x00004D70 File Offset: 0x00002F70
		public static GUIStyle none
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600011C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.GUIStyle UnityEngine.GUIStyle::get_none()

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
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00004D84 File Offset: 0x00002F84
		internal Vector2 CalcSizeWithConstraints(GUIContent content, Vector2 constraints)
		{
			Vector2 vector = this.Internal_CalcSizeWithConstraints(content, constraints);
			Vector2 vector2;
			return vector2;
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00004D9C File Offset: 0x00002F9C
		public float CalcHeight(GUIContent content, float width)
		{
			throw new MissingMethodException();
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600011F RID: 287 RVA: 0x00004DB0 File Offset: 0x00002FB0
		public bool isHeightDependantOnWidth
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00004DD0 File Offset: 0x00002FD0
		public void CalcMinMaxWidth(GUIContent content, [Out] float minWidth, [Out] float maxWidth)
		{
			Vector2 vector = this.Internal_CalcMinMaxWidth(content);
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00004DE8 File Offset: 0x00002FE8
		public override string ToString()
		{
			if (this.m_Name == null)
			{
				throw new MissingMethodException();
			}
			if (this != null)
			{
				string text;
				return text;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00004E1C File Offset: 0x0000301C
		// Note: this type is marked as 'beforefieldinit'.
		static GUIStyle()
		{
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00004E2C File Offset: 0x0000302C
		private void Internal_Draw_Injected(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00004E40 File Offset: 0x00003040
		private void Internal_Draw2_Injected(Rect position, GUIContent content, int controlID, bool on)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00004E54 File Offset: 0x00003054
		private void Internal_CalcSizeWithConstraints_Injected(GUIContent content, Vector2 maxSize, [Out] Vector2 ret)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00004E68 File Offset: 0x00003068
		private void Internal_CalcMinMaxWidth_Injected(GUIContent content, [Out] Vector2 ret)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00004E7C File Offset: 0x0000307C
		private static void SetMouseTooltip_Injected(string tooltip, Rect screenRect)
		{
			throw new MissingMethodException();
		}

		// Token: 0x040000CA RID: 202
		[NonSerialized]
		internal IntPtr m_Ptr;

		// Token: 0x040000CB RID: 203
		[NonSerialized]
		private GUIStyleState m_Normal;

		// Token: 0x040000CC RID: 204
		[NonSerialized]
		private GUIStyleState m_Hover;

		// Token: 0x040000CD RID: 205
		[NonSerialized]
		private GUIStyleState m_Active;

		// Token: 0x040000CE RID: 206
		[NonSerialized]
		private GUIStyleState m_Focused;

		// Token: 0x040000CF RID: 207
		[NonSerialized]
		private GUIStyleState m_OnNormal;

		// Token: 0x040000D0 RID: 208
		[NonSerialized]
		private GUIStyleState m_OnHover;

		// Token: 0x040000D1 RID: 209
		[NonSerialized]
		private GUIStyleState m_OnActive;

		// Token: 0x040000D2 RID: 210
		[NonSerialized]
		private GUIStyleState m_OnFocused;

		// Token: 0x040000D3 RID: 211
		[NonSerialized]
		private RectOffset m_Border;

		// Token: 0x040000D4 RID: 212
		[NonSerialized]
		private RectOffset m_Padding;

		// Token: 0x040000D5 RID: 213
		[NonSerialized]
		private RectOffset m_Margin;

		// Token: 0x040000D6 RID: 214
		[NonSerialized]
		private RectOffset m_Overflow;

		// Token: 0x040000D7 RID: 215
		[NonSerialized]
		private string m_Name;

		// Token: 0x040000D8 RID: 216
		internal static bool showKeyboardFocus;

		// Token: 0x040000D9 RID: 217
		private static GUIStyle s_None;
	}
}
