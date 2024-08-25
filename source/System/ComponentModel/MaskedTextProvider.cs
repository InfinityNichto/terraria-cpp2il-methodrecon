using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2IlInjected;

namespace System.ComponentModel
{
	// Token: 0x020003A2 RID: 930
	public class MaskedTextProvider : ICloneable
	{
		// Token: 0x06001834 RID: 6196 RVA: 0x0004434C File Offset: 0x0004254C
		public MaskedTextProvider(string mask)
		{
		}

		// Token: 0x06001835 RID: 6197 RVA: 0x0004435C File Offset: 0x0004255C
		public MaskedTextProvider(string mask, bool restrictToAscii)
		{
		}

		// Token: 0x06001836 RID: 6198 RVA: 0x0004436C File Offset: 0x0004256C
		public MaskedTextProvider(string mask, CultureInfo culture)
		{
		}

		// Token: 0x06001837 RID: 6199 RVA: 0x00044380 File Offset: 0x00042580
		public MaskedTextProvider(string mask, CultureInfo culture, bool restrictToAscii)
		{
		}

		// Token: 0x06001838 RID: 6200 RVA: 0x00044390 File Offset: 0x00042590
		public MaskedTextProvider(string mask, char passwordChar, bool allowPromptAsInput)
		{
		}

		// Token: 0x06001839 RID: 6201 RVA: 0x000443A0 File Offset: 0x000425A0
		public MaskedTextProvider(string mask, CultureInfo culture, char passwordChar, bool allowPromptAsInput)
		{
		}

		// Token: 0x0600183A RID: 6202 RVA: 0x000443B0 File Offset: 0x000425B0
		public MaskedTextProvider(string mask, CultureInfo culture, bool allowPromptAsInput, char promptChar, char passwordChar, bool restrictToAscii)
		{
			bool flag = string.IsNullOrEmpty(mask);
			int stringLength = mask._stringLength;
			long num = 0L;
			bool flag2 = MaskedTextProvider.IsPrintableChar(mask[(int)num]);
			int stringLength2 = mask._stringLength;
			if (culture == null)
			{
				if (stringLength2 == 0)
				{
				}
				CultureInfo currentCulture = CultureInfo.CurrentCulture;
			}
			this.AssignedEditPositionCount = mask;
			CultureInfo[] array;
			int parent_lcid = array.parent_lcid;
		}

		// Token: 0x0600183B RID: 6203 RVA: 0x00002050 File Offset: 0x00000250
		private void Initialize()
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x0600183C RID: 6204 RVA: 0x0004447C File Offset: 0x0004267C
		public bool AllowPromptAsInput
		{
			get
			{
				if (!true)
				{
				}
				bool flag;
				return flag;
			}
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x0600183D RID: 6205 RVA: 0x00044490 File Offset: 0x00042690
		// (set) Token: 0x0600183E RID: 6206 RVA: 0x000444A4 File Offset: 0x000426A4
		public int AssignedEditPositionCount
		{
			[CompilerGenerated]
			get
			{
				return this.<AssignedEditPositionCount>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<AssignedEditPositionCount>k__BackingField = value;
			}
		}

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x0600183F RID: 6207 RVA: 0x000444B8 File Offset: 0x000426B8
		public int AvailableEditPositionCount
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600183F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.ComponentModel.MaskedTextProvider::get_AvailableEditPositionCount()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(MaskedTextProvider::_requiredEditChars, ldloc:MaskedTextProvider(this)))
	stloc:char(var_1_0D, ldfld:char(MaskedTextProvider::_passwordChar, ldloc:MaskedTextProvider(this)))
	stloc:int32(var_2_14, ldfld:int32(MaskedTextProvider::<AssignedEditPositionCount>k__BackingField, ldloc:MaskedTextProvider(this)))
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

		// Token: 0x06001840 RID: 6208 RVA: 0x000444DC File Offset: 0x000426DC
		public object Clone()
		{
			Type type = base.GetType();
			if (fieldof(global::<PrivateImplementationDetails>.A5BD4B1718E46B13C0771AD632FC5E42B140BD94B602D5F6D7F9304B41DF51F6).FieldHandle == null)
			{
			}
			CultureInfo cultureInfo = this.<Culture>k__BackingField;
			string text = this.<Mask>k__BackingField;
			bool allowPromptAsInput = this.AllowPromptAsInput;
			char passwordChar = this._passwordChar;
			char promptChar = this._promptChar;
			bool asciiOnly = this.AsciiOnly;
			string text2 = this.<Mask>k__BackingField;
			if (text2 == null || text2 != null)
			{
				CultureInfo cultureInfo2 = this.<Culture>k__BackingField;
				if (cultureInfo2 == null || cultureInfo2 != null)
				{
					bool allowPromptAsInput2 = this.AllowPromptAsInput;
					char promptChar2 = this._promptChar;
					char passwordChar2 = this._passwordChar;
					bool asciiOnly2 = this.AsciiOnly;
					object obj;
					if (obj != null)
					{
					}
					return obj;
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x06001841 RID: 6209 RVA: 0x000445FC File Offset: 0x000427FC
		public CultureInfo Culture
		{
			[CompilerGenerated]
			get
			{
				return this.<Culture>k__BackingField;
			}
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x06001842 RID: 6210 RVA: 0x00002050 File Offset: 0x00000250
		public static char DefaultPasswordChar
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x06001843 RID: 6211 RVA: 0x00044610 File Offset: 0x00042810
		public int EditPositionCount
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001843)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.ComponentModel.MaskedTextProvider::get_EditPositionCount()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(MaskedTextProvider::_requiredEditChars, ldloc:MaskedTextProvider(this)))
	stloc:char(var_1_0D, ldfld:char(MaskedTextProvider::_passwordChar, ldloc:MaskedTextProvider(this)))
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

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x06001844 RID: 6212 RVA: 0x0004462C File Offset: 0x0004282C
		public IEnumerator EditPositions
		{
			get
			{
				List<MaskedTextProvider.CharDescriptor> stringDescriptor = this._stringDescriptor;
				throw new OutOfMemoryException();
			}
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06001845 RID: 6213 RVA: 0x00044650 File Offset: 0x00042850
		// (set) Token: 0x06001846 RID: 6214 RVA: 0x00044664 File Offset: 0x00042864
		public bool IncludeLiterals
		{
			get
			{
				if (!true)
				{
				}
				bool flag;
				return flag;
			}
			set
			{
				if (!true)
				{
				}
			}
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06001847 RID: 6215 RVA: 0x00044674 File Offset: 0x00042874
		// (set) Token: 0x06001848 RID: 6216 RVA: 0x00044688 File Offset: 0x00042888
		public bool IncludePrompt
		{
			get
			{
				if (!true)
				{
				}
				bool flag;
				return flag;
			}
			set
			{
				if (!true)
				{
				}
			}
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06001849 RID: 6217 RVA: 0x00044698 File Offset: 0x00042898
		public bool AsciiOnly
		{
			get
			{
				if (!true)
				{
				}
				bool flag;
				return flag;
			}
		}

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x0600184A RID: 6218 RVA: 0x000446AC File Offset: 0x000428AC
		// (set) Token: 0x0600184B RID: 6219 RVA: 0x000446C0 File Offset: 0x000428C0
		public bool IsPassword
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600184A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.ComponentModel.MaskedTextProvider::get_IsPassword()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:char(var_0_06, ldfld:char(MaskedTextProvider::_passwordChar, ldloc:MaskedTextProvider(this)))
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
				char passwordChar = this._passwordChar;
			}
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x0600184C RID: 6220 RVA: 0x00002050 File Offset: 0x00000250
		public static int InvalidIndex
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x0600184D RID: 6221 RVA: 0x000446E0 File Offset: 0x000428E0
		public int LastAssignedPosition
		{
			get
			{
				int length = this._testString.Length;
				int num;
				if (this.<AssignedEditPositionCount>k__BackingField != 0)
				{
					return num;
				}
				return num;
			}
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x0600184E RID: 6222 RVA: 0x00044704 File Offset: 0x00042904
		public int Length
		{
			get
			{
				return this._testString.Length;
			}
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x0600184F RID: 6223 RVA: 0x0004471C File Offset: 0x0004291C
		public string Mask
		{
			[CompilerGenerated]
			get
			{
				return this.<Mask>k__BackingField;
			}
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x06001850 RID: 6224 RVA: 0x00044730 File Offset: 0x00042930
		public bool MaskCompleted
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001850)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.ComponentModel.MaskedTextProvider::get_MaskCompleted()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(MaskedTextProvider::_requiredCharCount, ldloc:MaskedTextProvider(this)))
	stloc:int32(var_1_0D, ldfld:int32(MaskedTextProvider::_optionalEditChars, ldloc:MaskedTextProvider(this)))
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

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x06001851 RID: 6225 RVA: 0x0004474C File Offset: 0x0004294C
		public bool MaskFull
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001851)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.ComponentModel.MaskedTextProvider::get_MaskFull()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(MaskedTextProvider::_requiredEditChars, ldloc:MaskedTextProvider(this)))
	stloc:char(var_1_0D, ldfld:char(MaskedTextProvider::_passwordChar, ldloc:MaskedTextProvider(this)))
	stloc:int32(var_2_14, ldfld:int32(MaskedTextProvider::<AssignedEditPositionCount>k__BackingField, ldloc:MaskedTextProvider(this)))
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

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x06001852 RID: 6226 RVA: 0x00044770 File Offset: 0x00042970
		// (set) Token: 0x06001853 RID: 6227 RVA: 0x00044784 File Offset: 0x00042984
		public char PasswordChar
		{
			get
			{
				return this._passwordChar;
			}
			set
			{
				char promptChar = this._promptChar;
				bool flag = MaskedTextProvider.IsValidPasswordChar(value);
				char passwordChar = this._passwordChar;
			}
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x06001854 RID: 6228 RVA: 0x000447A8 File Offset: 0x000429A8
		// (set) Token: 0x06001855 RID: 6229 RVA: 0x000447BC File Offset: 0x000429BC
		public char PromptChar
		{
			get
			{
				return this._promptChar;
			}
			set
			{
				char passwordChar = this._passwordChar;
				bool flag = MaskedTextProvider.IsPrintableChar(value);
				char promptChar = this._promptChar;
				StringBuilder testString = this._testString;
				this._promptChar = value;
				int length = testString.Length;
				long num = 0L;
				List<MaskedTextProvider.CharDescriptor> stringDescriptor = this._stringDescriptor;
				bool flag2 = this.IsEditPosition((int)num);
				if (stringDescriptor._version == 0)
				{
					StringBuilder testString2 = this._testString;
					char promptChar2 = this._promptChar;
					testString2[(int)num] = promptChar2;
				}
				int length2 = this._testString.Length;
			}
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x06001856 RID: 6230 RVA: 0x0004483C File Offset: 0x00042A3C
		// (set) Token: 0x06001857 RID: 6231 RVA: 0x00044850 File Offset: 0x00042A50
		public bool ResetOnPrompt
		{
			get
			{
				if (!true)
				{
				}
				bool flag;
				return flag;
			}
			set
			{
				if (!true)
				{
				}
			}
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x06001858 RID: 6232 RVA: 0x00044860 File Offset: 0x00042A60
		// (set) Token: 0x06001859 RID: 6233 RVA: 0x00044874 File Offset: 0x00042A74
		public bool ResetOnSpace
		{
			get
			{
				if (!true)
				{
				}
				bool flag;
				return flag;
			}
			set
			{
				if (!true)
				{
				}
			}
		}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x0600185A RID: 6234 RVA: 0x00044884 File Offset: 0x00042A84
		// (set) Token: 0x0600185B RID: 6235 RVA: 0x00044898 File Offset: 0x00042A98
		public bool SkipLiterals
		{
			get
			{
				if (!true)
				{
				}
				bool flag;
				return flag;
			}
			set
			{
				if (!true)
				{
				}
			}
		}

		// Token: 0x1700059F RID: 1439
		public char this[int index]
		{
			get
			{
				int length = this._testString.Length;
				return this._testString[index];
			}
		}

		// Token: 0x0600185D RID: 6237 RVA: 0x000448D8 File Offset: 0x00042AD8
		public bool Add(char input)
		{
			bool flag;
			return flag;
		}

		// Token: 0x0600185E RID: 6238 RVA: 0x000448E8 File Offset: 0x00042AE8
		public bool Add(char input, [Out] int testPosition, [Out] MaskedTextResultHint resultHint)
		{
			int lastAssignedPosition = this.LastAssignedPosition;
			StringBuilder testString = this._testString;
			int length = testString.Length;
			int length2 = this._testString.Length;
			testPosition.m_value = length2;
			resultHint.value__ = testString;
			testPosition.m_value = lastAssignedPosition;
			int length3 = this._testString.Length;
			int num;
			testPosition.m_value = num;
			return this.TestSetChar(input, num, resultHint);
		}

		// Token: 0x0600185F RID: 6239 RVA: 0x0004496C File Offset: 0x00042B6C
		public bool Add(string input)
		{
			bool flag;
			return flag;
		}

		// Token: 0x06001860 RID: 6240 RVA: 0x0004497C File Offset: 0x00042B7C
		public bool Add(string input, [Out] int testPosition, [Out] MaskedTextResultHint resultHint)
		{
			/*
An exception occurred when decompiling this method (06001860)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.ComponentModel.MaskedTextProvider::Add(System.String,System.Int32,System.ComponentModel.MaskedTextResultHint)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0024:
	stloc:int32(var_1_25, ldc.i4:int32(2))
	stfld:int32(MaskedTextResultHint::value__, ldloc:MaskedTextResultHint[exp:valuetype System.ComponentModel.MaskedTextResultHint&](resultHint), ldloc:int32(var_1_25))
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

		// Token: 0x06001861 RID: 6241 RVA: 0x000449B8 File Offset: 0x00042BB8
		public void Clear()
		{
		}

		// Token: 0x06001862 RID: 6242 RVA: 0x000449C8 File Offset: 0x00042BC8
		public void Clear([Out] MaskedTextResultHint resultHint)
		{
			long num3;
			if (this.<AssignedEditPositionCount>k__BackingField != 0)
			{
				int num = 4;
				resultHint.value__ = num;
				int length = this._testString.Length;
				long num2 = 0L;
				this.ResetChar((int)num2);
				StringBuilder testString = this._testString;
				num3 = 0L;
				int length2 = testString.Length;
				return;
			}
			int num4 = 2;
			num3.m_value = (long)num4;
		}

		// Token: 0x06001863 RID: 6243 RVA: 0x00044A1C File Offset: 0x00042C1C
		public int FindAssignedEditPositionFrom(int position, bool direction)
		{
			int length;
			if (this.<AssignedEditPositionCount>k__BackingField != 0)
			{
				length = this._testString.Length;
				if (this.<AssignedEditPositionCount>k__BackingField != 0)
				{
					return length;
				}
			}
			return length;
		}

		// Token: 0x06001864 RID: 6244 RVA: 0x00044A4C File Offset: 0x00042C4C
		public int FindAssignedEditPositionInRange(int startPosition, int endPosition, bool direction)
		{
			int num;
			if (this.<AssignedEditPositionCount>k__BackingField != 0)
			{
				return num;
			}
			return num;
		}

		// Token: 0x06001865 RID: 6245 RVA: 0x00044A64 File Offset: 0x00042C64
		public int FindEditPositionFrom(int position, bool direction)
		{
			return this._testString.Length;
		}

		// Token: 0x06001866 RID: 6246 RVA: 0x00044A80 File Offset: 0x00042C80
		public int FindEditPositionInRange(int startPosition, int endPosition, bool direction)
		{
			return this.FindPositionInRange(startPosition, endPosition, direction, MaskedTextProvider.CharType.EditOptional | MaskedTextProvider.CharType.EditRequired);
		}

		// Token: 0x06001867 RID: 6247 RVA: 0x00044A98 File Offset: 0x00042C98
		private int FindEditPositionInRange(int startPosition, int endPosition, bool direction, byte assignedStatus)
		{
			List<MaskedTextProvider.CharDescriptor> stringDescriptor = this._stringDescriptor;
			if (stringDescriptor._version != 0 || stringDescriptor._version == 0)
			{
			}
			int num;
			return num;
		}

		// Token: 0x06001868 RID: 6248 RVA: 0x00044AC0 File Offset: 0x00042CC0
		public int FindNonEditPositionFrom(int position, bool direction)
		{
			return this._testString.Length;
		}

		// Token: 0x06001869 RID: 6249 RVA: 0x00044ADC File Offset: 0x00042CDC
		public int FindNonEditPositionInRange(int startPosition, int endPosition, bool direction)
		{
			return this.FindPositionInRange(startPosition, endPosition, direction, MaskedTextProvider.CharType.Separator | MaskedTextProvider.CharType.Literal);
		}

		// Token: 0x0600186A RID: 6250 RVA: 0x00044AF4 File Offset: 0x00042CF4
		private int FindPositionInRange(int startPosition, int endPosition, bool direction, MaskedTextProvider.CharType charTypeFlags)
		{
			int length = this._testString.Length;
			int length2 = this._testString.Length;
			int size = this._stringDescriptor._size;
			return startPosition;
		}

		// Token: 0x0600186B RID: 6251 RVA: 0x00044B28 File Offset: 0x00042D28
		public int FindUnassignedEditPositionFrom(int position, bool direction)
		{
			return this._testString.Length;
		}

		// Token: 0x0600186C RID: 6252 RVA: 0x00044B44 File Offset: 0x00042D44
		public int FindUnassignedEditPositionInRange(int startPosition, int endPosition, bool direction)
		{
			long num = 0L;
			int num2 = this.FindEditPositionInRange(startPosition, endPosition, direction, (byte)num);
			int num5;
			if (this._stringDescriptor._version != 0)
			{
				int num3 = 1;
				long num4 = 0L;
				num5 = this.FindEditPositionInRange(num2, endPosition, num3 != 0, (byte)num4);
				return num5;
			}
			return num5;
		}

		// Token: 0x0600186D RID: 6253 RVA: 0x00002050 File Offset: 0x00000250
		public static bool GetOperationResultFromHint(MaskedTextResultHint hint)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600186E RID: 6254 RVA: 0x00044B94 File Offset: 0x00042D94
		public bool InsertAt(char input, int position)
		{
			int length = this._testString.Length;
			bool flag;
			return flag;
		}

		// Token: 0x0600186F RID: 6255 RVA: 0x00044BB0 File Offset: 0x00042DB0
		public bool InsertAt(char input, int position, [Out] int testPosition, [Out] MaskedTextResultHint resultHint)
		{
			string text;
			return this.InsertAt(text, position, testPosition, resultHint);
		}

		// Token: 0x06001870 RID: 6256 RVA: 0x00044BC8 File Offset: 0x00042DC8
		public bool InsertAt(string input, int position)
		{
			bool flag;
			return flag;
		}

		// Token: 0x06001871 RID: 6257 RVA: 0x00044BD8 File Offset: 0x00042DD8
		public bool InsertAt(string input, int position, [Out] int testPosition, [Out] MaskedTextResultHint resultHint)
		{
			while (input == null)
			{
			}
			int length = this._testString.Length;
			long num = 0L;
			return this.InsertAtInt(input, position, testPosition, resultHint, num != 0L);
		}

		// Token: 0x06001872 RID: 6258 RVA: 0x00044C0C File Offset: 0x00042E0C
		private bool InsertAtInt(string input, int position, [Out] int testPosition, [Out] MaskedTextResultHint resultHint, bool testOnly)
		{
			/*
An exception occurred when decompiling this method (06001872)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.ComponentModel.MaskedTextProvider::InsertAtInt(System.String,System.Int32,System.Int32,System.ComponentModel.MaskedTextResultHint,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_00F6:
	call:void(MaskedTextProvider::ResetChar, ldloc:MaskedTextProvider(this), ldloc:int32(var_19))
	call:void(MaskedTextProvider::SetString, ldloc:MaskedTextProvider(this), ldloc:string(input), ldloc:int32(position))
	stfld:int32(MaskedTextResultHint::value__, ldloc:MaskedTextResultHint[exp:valuetype System.ComponentModel.MaskedTextResultHint&](resultHint), ldloc:int32(var_22_D7))
	stfld:int32(MaskedTextResultHint::value__, ldloc:MaskedTextResultHint[exp:valuetype System.ComponentModel.MaskedTextResultHint&](resultHint), ldloc:int32(var_22_D7))
	stfld:int32(int32::m_value, ldloc:int32[exp:int32&](testPosition), ldloc:int32(var_24))
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

		// Token: 0x06001873 RID: 6259 RVA: 0x00002050 File Offset: 0x00000250
		private static bool IsAscii(char c)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001874 RID: 6260 RVA: 0x00044D3C File Offset: 0x00042F3C
		private static bool IsAciiAlphanumeric(char c)
		{
		}

		// Token: 0x06001875 RID: 6261 RVA: 0x00044D4C File Offset: 0x00042F4C
		private static bool IsAlphanumeric(char c)
		{
			if (!true)
			{
			}
			return true;
		}

		// Token: 0x06001876 RID: 6262 RVA: 0x00044D64 File Offset: 0x00042F64
		private static bool IsAsciiLetter(char c)
		{
		}

		// Token: 0x06001877 RID: 6263 RVA: 0x00044D74 File Offset: 0x00042F74
		public bool IsAvailablePosition(int position)
		{
			/*
An exception occurred when decompiling this method (06001877)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.ComponentModel.MaskedTextProvider::IsAvailablePosition(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_0B, callgetter:int32(StringBuilder::get_Length, ldfld:StringBuilder(MaskedTextProvider::_testString, ldloc:MaskedTextProvider(this))))
	stloc:class [mscorlib]System.Collections.Generic.List`1<class System.ComponentModel.MaskedTextProvider/CharDescriptor>(var_1_12, ldfld:class [mscorlib]System.Collections.Generic.List`1<class System.ComponentModel.MaskedTextProvider/CharDescriptor>(MaskedTextProvider::_stringDescriptor, ldloc:MaskedTextProvider(this)))
	stloc:int32(var_2_19, ldfld:int32(List`1::_size, ldloc:class [mscorlib]System.Collections.Generic.List`1<class System.ComponentModel.MaskedTextProvider/CharDescriptor>[exp:List`1](var_1_12)))
	stloc:int32(var_3_20, ldfld:int32(List`1::_version, ldloc:class [mscorlib]System.Collections.Generic.List`1<class System.ComponentModel.MaskedTextProvider/CharDescriptor>[exp:List`1](var_1_12)))
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

		// Token: 0x06001878 RID: 6264 RVA: 0x00044DA4 File Offset: 0x00042FA4
		public bool IsEditPosition(int position)
		{
			/*
An exception occurred when decompiling this method (06001878)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.ComponentModel.MaskedTextProvider::IsEditPosition(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_0B, callgetter:int32(StringBuilder::get_Length, ldfld:StringBuilder(MaskedTextProvider::_testString, ldloc:MaskedTextProvider(this))))
	stloc:int32(var_1_17, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<class System.ComponentModel.MaskedTextProvider/CharDescriptor>[exp:List`1](MaskedTextProvider::_stringDescriptor, ldloc:MaskedTextProvider(this))))
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

		// Token: 0x06001879 RID: 6265 RVA: 0x00002050 File Offset: 0x00000250
		private static bool IsEditPosition(MaskedTextProvider.CharDescriptor charDescriptor)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600187A RID: 6266 RVA: 0x00002050 File Offset: 0x00000250
		private static bool IsLiteralPosition(MaskedTextProvider.CharDescriptor charDescriptor)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600187B RID: 6267 RVA: 0x00044DCC File Offset: 0x00042FCC
		private static bool IsPrintableChar(char c)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			return true;
		}

		// Token: 0x0600187C RID: 6268 RVA: 0x00044DE8 File Offset: 0x00042FE8
		public static bool IsValidInputChar(char c)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x0600187D RID: 6269 RVA: 0x00044DFC File Offset: 0x00042FFC
		public static bool IsValidMaskChar(char c)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x0600187E RID: 6270 RVA: 0x00044E10 File Offset: 0x00043010
		public static bool IsValidPasswordChar(char c)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x0600187F RID: 6271 RVA: 0x00044E24 File Offset: 0x00043024
		public bool Remove()
		{
			int lastAssignedPosition = this.LastAssignedPosition;
			this.ResetChar(lastAssignedPosition);
			return true;
		}

		// Token: 0x06001880 RID: 6272 RVA: 0x00044E40 File Offset: 0x00043040
		public bool Remove([Out] int testPosition, [Out] MaskedTextResultHint resultHint)
		{
			int lastAssignedPosition = this.LastAssignedPosition;
			this.ResetChar(lastAssignedPosition);
			long num = 0L;
			testPosition.m_value = (int)num;
			resultHint.value__ = 2;
			return true;
		}

		// Token: 0x06001881 RID: 6273 RVA: 0x00044E6C File Offset: 0x0004306C
		public bool RemoveAt(int position)
		{
			bool flag;
			return flag;
		}

		// Token: 0x06001882 RID: 6274 RVA: 0x00044E7C File Offset: 0x0004307C
		public bool RemoveAt(int startPosition, int endPosition)
		{
			bool flag;
			return flag;
		}

		// Token: 0x06001883 RID: 6275 RVA: 0x00044E8C File Offset: 0x0004308C
		public bool RemoveAt(int startPosition, int endPosition, [Out] int testPosition, [Out] MaskedTextResultHint resultHint)
		{
			int length = this._testString.Length;
			long num = 0L;
			return this.RemoveAtInt(startPosition, endPosition, testPosition, resultHint, num != 0L);
		}

		// Token: 0x06001884 RID: 6276 RVA: 0x00044EC8 File Offset: 0x000430C8
		private bool RemoveAtInt(int startPosition, int endPosition, [Out] int testPosition, [Out] MaskedTextResultHint resultHint, bool testOnly)
		{
			/*
An exception occurred when decompiling this method (06001884)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.ComponentModel.MaskedTextProvider::RemoveAtInt(System.Int32,System.Int32,System.Int32,System.ComponentModel.MaskedTextResultHint,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_010F:
	call:void(MaskedTextProvider::ResetString, ldloc:MaskedTextProvider(this), ldloc:int32(var_24), ldloc:int32(endPosition))
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

		// Token: 0x06001885 RID: 6277 RVA: 0x00044FF0 File Offset: 0x000431F0
		public bool Replace(char input, int position)
		{
			bool flag;
			return flag;
		}

		// Token: 0x06001886 RID: 6278 RVA: 0x00045000 File Offset: 0x00043200
		public bool Replace(char input, int position, [Out] int testPosition, [Out] MaskedTextResultHint resultHint)
		{
			int length = this._testString.Length;
			testPosition.m_value = position;
			bool flag = this.TestEscapeChar(input, position);
			int length2 = this._testString.Length;
			int num;
			testPosition.m_value = num;
			return this.TestSetChar(input, num, resultHint);
		}

		// Token: 0x06001887 RID: 6279 RVA: 0x00045058 File Offset: 0x00043258
		public bool Replace(char input, int startPosition, int endPosition, [Out] int testPosition, [Out] MaskedTextResultHint resultHint)
		{
			int length = this._testString.Length;
			testPosition.m_value = endPosition;
			return this.TestSetChar(input, endPosition, resultHint);
		}

		// Token: 0x06001888 RID: 6280 RVA: 0x0004509C File Offset: 0x0004329C
		public bool Replace(string input, int position)
		{
			bool flag;
			return flag;
		}

		// Token: 0x06001889 RID: 6281 RVA: 0x000450AC File Offset: 0x000432AC
		public bool Replace(string input, int position, [Out] int testPosition, [Out] MaskedTextResultHint resultHint)
		{
			while (input == null)
			{
			}
			int length = this._testString.Length;
			int stringLength = input._stringLength;
			if (stringLength != 0)
			{
				return this.TestSetString(input, position, testPosition, resultHint);
			}
			return this.RemoveAt(position, position, testPosition, resultHint);
		}

		// Token: 0x0600188A RID: 6282 RVA: 0x000450FC File Offset: 0x000432FC
		public bool Replace(string input, int startPosition, int endPosition, [Out] int testPosition, [Out] MaskedTextResultHint resultHint)
		{
			while (input == null)
			{
			}
			int length = this._testString.Length;
			if (input._stringLength != 0)
			{
				bool flag = this.TestString(input, startPosition, testPosition, resultHint);
				int num = this.<AssignedEditPositionCount>k__BackingField;
				int num2 = 3;
				resultHint.value__ = num2;
				bool flag2;
				return flag2;
			}
			return this.RemoveAt(startPosition, endPosition, testPosition, resultHint);
		}

		// Token: 0x0600188B RID: 6283 RVA: 0x000451EC File Offset: 0x000433EC
		private void ResetChar(int testPosition)
		{
			List<MaskedTextProvider.CharDescriptor> stringDescriptor = this._stringDescriptor;
			bool flag = this.IsEditPosition(testPosition);
			if (stringDescriptor._version != 0)
			{
				StringBuilder testString = this._testString;
				char promptChar = this._promptChar;
				testString[testPosition] = promptChar;
				int num = this.<AssignedEditPositionCount>k__BackingField;
				this.<AssignedEditPositionCount>k__BackingField = num;
				int size = stringDescriptor._size;
				int requiredCharCount = this._requiredCharCount;
				this._requiredCharCount = requiredCharCount;
			}
		}

		// Token: 0x0600188C RID: 6284 RVA: 0x00045250 File Offset: 0x00043450
		private void ResetString(int startPosition, int endPosition)
		{
			int num = 1;
			int num2 = this.FindAssignedEditPositionFrom(startPosition, num != 0);
			if (this.<AssignedEditPositionCount>k__BackingField != 0)
			{
				int num3 = 2;
				long num4 = 0L;
				long num5 = 0L;
				int num6 = this.FindEditPositionInRange((int)num4, endPosition, num5 != 0L, (byte)num3);
				return;
			}
		}

		// Token: 0x0600188D RID: 6285 RVA: 0x0004529C File Offset: 0x0004349C
		public bool Set(string input)
		{
			bool flag;
			return flag;
		}

		// Token: 0x0600188E RID: 6286 RVA: 0x000452AC File Offset: 0x000434AC
		public bool Set(string input, [Out] int testPosition, [Out] MaskedTextResultHint resultHint)
		{
			/*
An exception occurred when decompiling this method (0600188E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.ComponentModel.MaskedTextProvider::Set(System.String,System.Int32,System.ComponentModel.MaskedTextResultHint)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_002F:
	call:void(MaskedTextProvider::Clear, ldloc:MaskedTextProvider(this), ldloc:MaskedTextResultHint(resultHint))
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

		// Token: 0x0600188F RID: 6287 RVA: 0x000452F4 File Offset: 0x000434F4
		private void SetChar(char input, int position)
		{
			List<MaskedTextProvider.CharDescriptor> stringDescriptor = this._stringDescriptor;
		}

		// Token: 0x06001890 RID: 6288 RVA: 0x00045308 File Offset: 0x00043508
		private void SetChar(char input, int position, MaskedTextProvider.CharDescriptor charDescriptor)
		{
			List<MaskedTextProvider.CharDescriptor> stringDescriptor = this._stringDescriptor;
			bool flag = this.TestEscapeChar(input, position, charDescriptor);
			this.ResetChar(position);
		}

		// Token: 0x06001891 RID: 6289 RVA: 0x000453A4 File Offset: 0x000435A4
		private void SetString(string input, int testPosition)
		{
			int stringLength = input._stringLength;
			long num = 0L;
			char c = input[(int)num];
			bool flag = this.TestEscapeChar(c, testPosition);
			int length = this._testString.Length;
			int num2;
			this.SetChar(c, num2);
			int stringLength2 = input._stringLength;
		}

		// Token: 0x06001892 RID: 6290 RVA: 0x00002050 File Offset: 0x00000250
		private bool TestChar(char input, int position, [Out] MaskedTextResultHint resultHint)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001893 RID: 6291 RVA: 0x000453EC File Offset: 0x000435EC
		private bool TestEscapeChar(char input, int position)
		{
			List<MaskedTextProvider.CharDescriptor> stringDescriptor = this._stringDescriptor;
			bool flag;
			return flag;
		}

		// Token: 0x06001894 RID: 6292 RVA: 0x00045404 File Offset: 0x00043604
		private bool TestEscapeChar(char input, int position, MaskedTextProvider.CharDescriptor charDex)
		{
			if (!true)
			{
			}
			MaskedTextProvider.CharType charType = charDex.CharType;
			bool skipLiterals = this.SkipLiterals;
			char c = this._testString[position];
			bool resetOnPrompt = this.ResetOnPrompt;
			char promptChar = this._promptChar;
			return true;
		}

		// Token: 0x06001895 RID: 6293 RVA: 0x0004544C File Offset: 0x0004364C
		private bool TestSetChar(char input, int position, [Out] MaskedTextResultHint resultHint)
		{
			/*
An exception occurred when decompiling this method (06001895)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.ComponentModel.MaskedTextProvider::TestSetChar(System.Char,System.Int32,System.ComponentModel.MaskedTextResultHint)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_0_09, call:bool(MaskedTextProvider::TestChar, ldloc:MaskedTextProvider(this), ldloc:char(input), ldloc:int32(position), ldloc:MaskedTextResultHint(resultHint)))
	call:void(MaskedTextProvider::SetChar, ldloc:MaskedTextProvider(this), ldloc:char(input), ldloc:int32(position))
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

		// Token: 0x06001896 RID: 6294 RVA: 0x00045470 File Offset: 0x00043670
		private bool TestSetString(string input, int position, [Out] int testPosition, [Out] MaskedTextResultHint resultHint)
		{
			bool flag = this.TestString(input, position, testPosition, resultHint);
			this.SetString(input, position);
			return true;
		}

		// Token: 0x06001897 RID: 6295 RVA: 0x00045494 File Offset: 0x00043694
		private bool TestString(string input, int position, [Out] int testPosition, [Out] MaskedTextResultHint resultHint)
		{
			/*
An exception occurred when decompiling this method (06001897)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.ComponentModel.MaskedTextProvider::TestString(System.String,System.Int32,System.Int32,System.ComponentModel.MaskedTextResultHint)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_005C:
	stloc:int32(var_12_70, callgetter:int32(StringBuilder::get_Length, ldfld:StringBuilder(MaskedTextProvider::_testString, ldloc:MaskedTextProvider(this))))
	stfld:int32(int32::m_value, ldloc:int32[exp:int32&](testPosition), ldloc:int32(var_12_70))
	stfld:int32(MaskedTextResultHint::value__, ldloc:MaskedTextResultHint[exp:valuetype System.ComponentModel.MaskedTextResultHint&](resultHint), ldloc:int32(var_12_70))
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

		// Token: 0x06001898 RID: 6296 RVA: 0x00045528 File Offset: 0x00043728
		public string ToDisplayString()
		{
			/*
An exception occurred when decompiling this method (06001898)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.ComponentModel.MaskedTextProvider::ToDisplayString()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_1:
	stloc:int32(var_6_11, callgetter:int32(StringBuilder::get_Length, ldloc:StringBuilder(var_5)))
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

		// Token: 0x06001899 RID: 6297 RVA: 0x00045548 File Offset: 0x00043748
		public override string ToString()
		{
			bool includePrompt = this.IncludePrompt;
			bool includeLiterals = this.IncludeLiterals;
			int length = this._testString.Length;
			string text;
			return text;
		}

		// Token: 0x0600189A RID: 6298 RVA: 0x00045570 File Offset: 0x00043770
		public string ToString(bool ignorePasswordChar)
		{
			bool includePrompt = this.IncludePrompt;
			bool includeLiterals = this.IncludeLiterals;
			int length = this._testString.Length;
			string text;
			return text;
		}

		// Token: 0x0600189B RID: 6299 RVA: 0x00045598 File Offset: 0x00043798
		public string ToString(int startPosition, int length)
		{
			bool includePrompt = this.IncludePrompt;
			bool includeLiterals = this.IncludeLiterals;
			string text;
			return text;
		}

		// Token: 0x0600189C RID: 6300 RVA: 0x000455B4 File Offset: 0x000437B4
		public string ToString(bool ignorePasswordChar, int startPosition, int length)
		{
			bool includePrompt = this.IncludePrompt;
			bool includeLiterals = this.IncludeLiterals;
			return this.ToString(ignorePasswordChar, startPosition != 0, length != 0, startPosition, length);
		}

		// Token: 0x0600189D RID: 6301 RVA: 0x000455DC File Offset: 0x000437DC
		public string ToString(bool includePrompt, bool includeLiterals)
		{
			int length = this._testString.Length;
			string text;
			return text;
		}

		// Token: 0x0600189E RID: 6302 RVA: 0x000455F8 File Offset: 0x000437F8
		public string ToString(bool includePrompt, bool includeLiterals, int startPosition, int length)
		{
			return this.ToString(true, includeLiterals, startPosition != 0, startPosition, length);
		}

		// Token: 0x0600189F RID: 6303 RVA: 0x00045614 File Offset: 0x00043814
		public string ToString(bool ignorePasswordChar, bool includePrompt, bool includeLiterals, int startPosition, int length)
		{
			int length2 = this._testString.Length;
			int length3 = this._testString.Length;
			char passwordChar = this._passwordChar;
			return this._testString.ToString(startPosition, 43163648);
		}

		// Token: 0x060018A0 RID: 6304 RVA: 0x000456B8 File Offset: 0x000438B8
		public bool VerifyChar(char input, int position, [Out] MaskedTextResultHint hint)
		{
			hint.value__ = 2;
			int length = this._testString.Length;
			return this.TestChar(input, position, hint);
		}

		// Token: 0x060018A1 RID: 6305 RVA: 0x000456EC File Offset: 0x000438EC
		public bool VerifyEscapeChar(char input, int position)
		{
			int length = this._testString.Length;
			return this.TestEscapeChar(input, position);
		}

		// Token: 0x060018A2 RID: 6306 RVA: 0x00045710 File Offset: 0x00043910
		public bool VerifyString(string input)
		{
			bool flag;
			return input == null || input._stringLength == 0 || flag;
		}

		// Token: 0x060018A3 RID: 6307 RVA: 0x0004572C File Offset: 0x0004392C
		public bool VerifyString(string input, [Out] int testPosition, [Out] MaskedTextResultHint resultHint)
		{
			if (input != null && input._stringLength != 0)
			{
				long num = 0L;
				return this.TestString(input, (int)num, testPosition, resultHint);
			}
			resultHint.value__ = 2;
			return true;
		}

		// Token: 0x060018A4 RID: 6308 RVA: 0x0004575C File Offset: 0x0004395C
		// Note: this type is marked as 'beforefieldinit'.
		static MaskedTextProvider()
		{
			int num = global::System.Collections.Specialized.BitVector32.CreateMask(global::System.Collections.Specialized.BitVector32.CreateMask(global::System.Collections.Specialized.BitVector32.CreateMask(global::System.Collections.Specialized.BitVector32.CreateMask(global::System.Collections.Specialized.BitVector32.CreateMask(global::System.Collections.Specialized.BitVector32.CreateMask(global::System.Collections.Specialized.BitVector32.CreateMask()))))));
		}

		// Token: 0x0400125B RID: 4699
		private const char SPACE_CHAR = ' ';

		// Token: 0x0400125C RID: 4700
		private const char DEFAULT_PROMPT_CHAR = '_';

		// Token: 0x0400125D RID: 4701
		private const char NULL_PASSWORD_CHAR = '\0';

		// Token: 0x0400125E RID: 4702
		private const bool DEFAULT_ALLOW_PROMPT = true;

		// Token: 0x0400125F RID: 4703
		private const int INVALID_INDEX = -1;

		// Token: 0x04001260 RID: 4704
		private const byte EDIT_ANY = 0;

		// Token: 0x04001261 RID: 4705
		private const byte EDIT_UNASSIGNED = 1;

		// Token: 0x04001262 RID: 4706
		private const byte EDIT_ASSIGNED = 2;

		// Token: 0x04001263 RID: 4707
		private const bool FORWARD = true;

		// Token: 0x04001264 RID: 4708
		private const bool BACKWARD = false;

		// Token: 0x04001265 RID: 4709
		private static int s_ASCII_ONLY;

		// Token: 0x04001266 RID: 4710
		private static int s_ALLOW_PROMPT_AS_INPUT;

		// Token: 0x04001267 RID: 4711
		private static int s_INCLUDE_PROMPT;

		// Token: 0x04001268 RID: 4712
		private static int s_INCLUDE_LITERALS;

		// Token: 0x04001269 RID: 4713
		private static int s_RESET_ON_PROMPT;

		// Token: 0x0400126A RID: 4714
		private static int s_RESET_ON_LITERALS;

		// Token: 0x0400126B RID: 4715
		private static int s_SKIP_SPACE;

		// Token: 0x0400126C RID: 4716
		private static Type s_maskTextProviderType;

		// Token: 0x0400126D RID: 4717
		private global::System.Collections.Specialized.BitVector32 _flagState;

		// Token: 0x0400126E RID: 4718
		private StringBuilder _testString;

		// Token: 0x0400126F RID: 4719
		private int _requiredCharCount;

		// Token: 0x04001270 RID: 4720
		private int _requiredEditChars;

		// Token: 0x04001271 RID: 4721
		private int _optionalEditChars;

		// Token: 0x04001272 RID: 4722
		private char _passwordChar;

		// Token: 0x04001273 RID: 4723
		private char _promptChar;

		// Token: 0x04001274 RID: 4724
		private List<MaskedTextProvider.CharDescriptor> _stringDescriptor;

		// Token: 0x04001275 RID: 4725
		[CompilerGenerated]
		private int <AssignedEditPositionCount>k__BackingField;

		// Token: 0x04001276 RID: 4726
		[CompilerGenerated]
		private readonly CultureInfo <Culture>k__BackingField;

		// Token: 0x04001277 RID: 4727
		[CompilerGenerated]
		private readonly string <Mask>k__BackingField;

		// Token: 0x020003A3 RID: 931
		private enum CaseConversion
		{
			// Token: 0x04001279 RID: 4729
			None,
			// Token: 0x0400127A RID: 4730
			ToLower,
			// Token: 0x0400127B RID: 4731
			ToUpper
		}

		// Token: 0x020003A4 RID: 932
		[Flags]
		private enum CharType
		{
			// Token: 0x0400127D RID: 4733
			EditOptional = 1,
			// Token: 0x0400127E RID: 4734
			EditRequired = 2,
			// Token: 0x0400127F RID: 4735
			Separator = 4,
			// Token: 0x04001280 RID: 4736
			Literal = 8,
			// Token: 0x04001281 RID: 4737
			Modifier = 16
		}

		// Token: 0x020003A5 RID: 933
		private class CharDescriptor
		{
			// Token: 0x060018A5 RID: 6309 RVA: 0x00045790 File Offset: 0x00043990
			public CharDescriptor(int maskPos, MaskedTextProvider.CharType charType)
			{
				this.MaskPosition = maskPos;
				this.CharType = charType;
			}

			// Token: 0x060018A6 RID: 6310 RVA: 0x000457B4 File Offset: 0x000439B4
			public override string ToString()
			{
				if (!true)
				{
				}
				CultureInfo invariantCulture = CultureInfo.InvariantCulture;
				int maskPosition = this.MaskPosition;
				MaskedTextProvider.CaseConversion caseConversion = this.CaseConversion;
				MaskedTextProvider.CharType charType = this.CharType;
				bool isAssigned = this.IsAssigned;
				string text;
				return text;
			}

			// Token: 0x04001282 RID: 4738
			public int MaskPosition;

			// Token: 0x04001283 RID: 4739
			public MaskedTextProvider.CaseConversion CaseConversion;

			// Token: 0x04001284 RID: 4740
			public MaskedTextProvider.CharType CharType;

			// Token: 0x04001285 RID: 4741
			public bool IsAssigned;
		}
	}
}
