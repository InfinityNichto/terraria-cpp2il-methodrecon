using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine
{
	// Token: 0x02000093 RID: 147
	[NativeHeader("Runtime/Input/KeyboardOnScreen.h")]
	[NativeConditional("ENABLE_ONSCREEN_KEYBOARD")]
	[NativeHeader("Runtime/Export/TouchScreenKeyboard/TouchScreenKeyboard.bindings.h")]
	public class TouchScreenKeyboard
	{
		// Token: 0x0600028F RID: 655 RVA: 0x00005BCC File Offset: 0x00003DCC
		[FreeFunction("TouchScreenKeyboard_Destroy", IsThreadSafe = true)]
		private static void Internal_Destroy(IntPtr ptr)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00005BE0 File Offset: 0x00003DE0
		private void Destroy()
		{
			IntPtr ptr = this.m_Ptr;
			IntPtr ptr2 = this.m_Ptr;
			throw new MissingMethodException();
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00005C08 File Offset: 0x00003E08
		protected override void Finalize()
		{
			this.Destroy();
			base.Finalize();
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00005C44 File Offset: 0x00003E44
		public TouchScreenKeyboard(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit)
		{
			uint num2;
			uint num = Convert.ToUInt32(Convert.ToUInt32(Convert.ToUInt32(Convert.ToUInt32(num2 != 0U) != 0U) != 0U) != 0U);
			throw new MissingMethodException();
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00005C74 File Offset: 0x00003E74
		[FreeFunction("TouchScreenKeyboard_InternalConstructorHelper")]
		private static IntPtr TouchScreenKeyboard_InternalConstructorHelper(TouchScreenKeyboard_InternalConstructorHelperArguments arguments, string text, string textPlaceholder)
		{
			throw new MissingMethodException();
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000294 RID: 660 RVA: 0x00005C88 File Offset: 0x00003E88
		public static bool isSupported
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000294)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean UnityEngine.TouchScreenKeyboard::get_isSupported()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:RuntimePlatform(var_1_07, callgetter:RuntimePlatform(Application::get_platform))
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

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000295 RID: 661 RVA: 0x000021B3 File Offset: 0x000003B3
		internal static bool disableInPlaceEditing
		{
			[CompilerGenerated]
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000296 RID: 662 RVA: 0x00005CA0 File Offset: 0x00003EA0
		public static bool isInPlaceEditingAllowed
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00005CB4 File Offset: 0x00003EB4
		[FreeFunction("TouchScreenKeyboard_IsInplaceEditingAllowed")]
		private static bool IsInPlaceEditingAllowed()
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000298 RID: 664 RVA: 0x000021B3 File Offset: 0x000003B3
		public static TouchScreenKeyboard Open(string text, [DefaultValue("TouchScreenKeyboardType.Default")] TouchScreenKeyboardType keyboardType, [DefaultValue("true")] bool autocorrection, [DefaultValue("false")] bool multiline, [DefaultValue("false")] bool secure, [DefaultValue("false")] bool alert, [DefaultValue("\"\"")] string textPlaceholder, [DefaultValue("0")] int characterLimit)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000299 RID: 665 RVA: 0x00005CC8 File Offset: 0x00003EC8
		// (set) Token: 0x0600029A RID: 666 RVA: 0x00005CDC File Offset: 0x00003EDC
		public string text
		{
			[NativeName("GetText")]
			get
			{
				throw new MissingMethodException();
			}
			[NativeName("SetText")]
			set
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x1700009B RID: 155
		// (set) Token: 0x0600029B RID: 667 RVA: 0x00005CF0 File Offset: 0x00003EF0
		public static bool hideInput
		{
			[NativeName("SetInputHidden")]
			set
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x0600029C RID: 668 RVA: 0x00005D04 File Offset: 0x00003F04
		// (set) Token: 0x0600029D RID: 669 RVA: 0x00005D18 File Offset: 0x00003F18
		public bool active
		{
			[NativeName("IsActive")]
			get
			{
				throw new MissingMethodException();
			}
			[NativeName("SetActive")]
			set
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x0600029E RID: 670 RVA: 0x00005D2C File Offset: 0x00003F2C
		public TouchScreenKeyboard.Status status
		{
			[NativeName("GetKeyboardStatus")]
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x1700009E RID: 158
		// (set) Token: 0x0600029F RID: 671 RVA: 0x00005D40 File Offset: 0x00003F40
		public int characterLimit
		{
			[NativeName("SetCharacterLimit")]
			set
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060002A0 RID: 672 RVA: 0x00005D54 File Offset: 0x00003F54
		public bool canGetSelection
		{
			[NativeName("CanGetSelection")]
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060002A1 RID: 673 RVA: 0x00005D68 File Offset: 0x00003F68
		public bool canSetSelection
		{
			[NativeName("CanSetSelection")]
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060002A2 RID: 674 RVA: 0x00005D7C File Offset: 0x00003F7C
		// (set) Token: 0x060002A3 RID: 675 RVA: 0x00005D90 File Offset: 0x00003F90
		public RangeInt selection
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

		// Token: 0x060002A4 RID: 676 RVA: 0x00005DB0 File Offset: 0x00003FB0
		private static void GetSelection([Out] int start, [Out] int length)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00005DC4 File Offset: 0x00003FC4
		private static void SetSelection(int start, int length)
		{
			throw new MissingMethodException();
		}

		// Token: 0x04000330 RID: 816
		[NonSerialized]
		internal IntPtr m_Ptr;

		// Token: 0x04000331 RID: 817
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static bool <disableInPlaceEditing>k__BackingField;

		// Token: 0x02000094 RID: 148
		public enum Status
		{
			// Token: 0x04000333 RID: 819
			Visible,
			// Token: 0x04000334 RID: 820
			Done,
			// Token: 0x04000335 RID: 821
			Canceled,
			// Token: 0x04000336 RID: 822
			LostFocus
		}
	}
}
