using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000005 RID: 5
	[UsedByNativeCode]
	[NativeHeader("Modules/TextRendering/TextGenerator.h")]
	[StructLayout(0)]
	public sealed class TextGenerator : IDisposable
	{
		// Token: 0x06000004 RID: 4 RVA: 0x00002220 File Offset: 0x00000420
		public TextGenerator()
		{
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002230 File Offset: 0x00000430
		public TextGenerator(int initialCapacity)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000224C File Offset: 0x0000044C
		protected override void Finalize()
		{
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002284 File Offset: 0x00000484
		void IDisposable.Dispose()
		{
			IntPtr ptr = this.m_Ptr;
			IntPtr ptr2 = this.m_Ptr;
			throw new MissingMethodException();
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000008 RID: 8 RVA: 0x000022A8 File Offset: 0x000004A8
		public int characterCountVisible
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000022BC File Offset: 0x000004BC
		private TextGenerationSettings ValidatedSettings(TextGenerationSettings settings)
		{
			if (!true)
			{
			}
			throw new MissingMethodException();
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000230C File Offset: 0x0000050C
		public void Invalidate()
		{
		}

		// Token: 0x0600000B RID: 11 RVA: 0x0000231C File Offset: 0x0000051C
		public void GetCharacters(List<UICharInfo> characters)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002330 File Offset: 0x00000530
		public void GetLines(List<UILineInfo> lines)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002344 File Offset: 0x00000544
		public void GetVertices(List<UIVertex> vertices)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002358 File Offset: 0x00000558
		public float GetPreferredWidth(string str, TextGenerationSettings settings)
		{
			/*
An exception occurred when decompiling this method (0600000E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single UnityEngine.TextGenerator::GetPreferredWidth(System.String,UnityEngine.TextGenerationSettings)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stfld:bool(TextGenerationSettings::updateBounds, ldloc:TextGenerationSettings[exp:valuetype UnityEngine.TextGenerationSettings&](settings), ldc.i4:bool(1))
	stloc:float32(var_1_12, callgetter:float32(Rect::get_width, callgetter:Rect[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Rect&](TextGenerator::get_rectExtents, ldloc:TextGenerator(this))))
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

		// Token: 0x0600000F RID: 15 RVA: 0x00002378 File Offset: 0x00000578
		public float GetPreferredHeight(string str, TextGenerationSettings settings)
		{
			/*
An exception occurred when decompiling this method (0600000F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single UnityEngine.TextGenerator::GetPreferredHeight(System.String,UnityEngine.TextGenerationSettings)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stfld:VerticalWrapMode(TextGenerationSettings::verticalOverflow, ldloc:TextGenerationSettings[exp:valuetype UnityEngine.TextGenerationSettings&](settings), ldc.i4:VerticalWrapMode(1))
	stfld:bool(TextGenerationSettings::updateBounds, ldloc:TextGenerationSettings[exp:valuetype UnityEngine.TextGenerationSettings&](settings), ldc.i4:bool(1))
	stloc:float32(var_1_19, callgetter:float32(Rect::get_height, callgetter:Rect[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Rect&](TextGenerator::get_rectExtents, ldloc:TextGenerator(this))))
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

		// Token: 0x06000010 RID: 16 RVA: 0x000023A0 File Offset: 0x000005A0
		public bool PopulateWithErrors(string str, TextGenerationSettings settings, GameObject context)
		{
			TextGenerationError textGenerationError;
			if (textGenerationError != TextGenerationError.None)
			{
			}
			return true;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000023B9 File Offset: 0x000005B9
		public bool Populate(string str, TextGenerationSettings settings)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000023C8 File Offset: 0x000005C8
		private TextGenerationError PopulateWithError(string str, TextGenerationSettings settings)
		{
			if (this.m_HasGenerated)
			{
				string lastString = this.m_LastString;
				bool flag = str == lastString;
				return this.m_LastValid;
			}
			TextGenerationError textGenerationError;
			this.m_LastValid = textGenerationError;
			return textGenerationError;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000023FC File Offset: 0x000005FC
		private TextGenerationError PopulateAlways(string str, TextGenerationSettings settings)
		{
			/*
An exception occurred when decompiling this method (06000013)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.TextGenerationError UnityEngine.TextGenerator::PopulateAlways(System.String,UnityEngine.TextGenerationSettings)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_01, ldc.i4:int32(1))
	stfld:string(TextGenerator::m_LastString, ldloc:TextGenerator(this), ldloc:string(str))
	stfld:bool(TextGenerator::m_HasGenerated, ldloc:TextGenerator(this), ldloc:int32[exp:bool](var_0_01))
	stloc:TextGenerationSettings(var_1_17, call:TextGenerationSettings(TextGenerator::ValidatedSettings, ldloc:TextGenerator(this), ldloc:TextGenerationSettings(settings)))
	stfld:TextGenerationError(TextGenerator::m_LastValid, ldloc:TextGenerator(this), ldloc:bool[exp:TextGenerationError](var_2))
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

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000014 RID: 20 RVA: 0x00002428 File Offset: 0x00000628
		public IList<UIVertex> verts
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000014)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IList`1<UnityEngine.UIVertex> UnityEngine.TextGenerator::get_verts()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001E:
	stloc:class [mscorlib]System.Collections.Generic.List`1<valuetype UnityEngine.UIVertex>(var_2_24, ldfld:class [mscorlib]System.Collections.Generic.List`1<valuetype UnityEngine.UIVertex>(TextGenerator::m_Verts, ldloc:TextGenerator(this)))
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

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000015 RID: 21 RVA: 0x0000245C File Offset: 0x0000065C
		public IList<UICharInfo> characters
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000015)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IList`1<UnityEngine.UICharInfo> UnityEngine.TextGenerator::get_characters()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001E:
	stloc:class [mscorlib]System.Collections.Generic.List`1<valuetype UnityEngine.UICharInfo>(var_2_24, ldfld:class [mscorlib]System.Collections.Generic.List`1<valuetype UnityEngine.UICharInfo>(TextGenerator::m_Characters, ldloc:TextGenerator(this)))
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

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000016 RID: 22 RVA: 0x00002490 File Offset: 0x00000690
		public IList<UILineInfo> lines
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000016)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IList`1<UnityEngine.UILineInfo> UnityEngine.TextGenerator::get_lines()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001E:
	stloc:class [mscorlib]System.Collections.Generic.List`1<valuetype UnityEngine.UILineInfo>(var_2_24, ldfld:class [mscorlib]System.Collections.Generic.List`1<valuetype UnityEngine.UILineInfo>(TextGenerator::m_Lines, ldloc:TextGenerator(this)))
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

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000017 RID: 23 RVA: 0x000024C4 File Offset: 0x000006C4
		public Rect rectExtents
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000018 RID: 24 RVA: 0x000024D8 File Offset: 0x000006D8
		public int characterCount
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000019 RID: 25 RVA: 0x000024EC File Offset: 0x000006EC
		public int lineCount
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002500 File Offset: 0x00000700
		[NativeMethod(IsThreadSafe = true)]
		private static IntPtr Internal_Create()
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002514 File Offset: 0x00000714
		[NativeMethod(IsThreadSafe = true)]
		private static void Internal_Destroy(IntPtr ptr)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002528 File Offset: 0x00000728
		internal bool Populate_Internal(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, [Out] uint error)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600001D RID: 29 RVA: 0x0000253C File Offset: 0x0000073C
		internal bool Populate_Internal(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, VerticalWrapMode verticalOverFlow, HorizontalWrapMode horizontalOverflow, bool updateBounds, TextAnchor anchor, Vector2 extents, Vector2 pivot, bool generateOutOfBounds, bool alignByGeometry, [Out] TextGenerationError error)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002550 File Offset: 0x00000750
		[NativeThrows]
		private void GetVerticesInternal(object vertices)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002564 File Offset: 0x00000764
		[NativeThrows]
		private void GetCharactersInternal(object characters)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002578 File Offset: 0x00000778
		[NativeThrows]
		private void GetLinesInternal(object lines)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000021 RID: 33 RVA: 0x0000258C File Offset: 0x0000078C
		private void get_rectExtents_Injected([Out] Rect ret)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000025A0 File Offset: 0x000007A0
		private bool Populate_Internal_Injected(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, [Out] uint error)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0400001D RID: 29
		internal IntPtr m_Ptr;

		// Token: 0x0400001E RID: 30
		private string m_LastString;

		// Token: 0x0400001F RID: 31
		private TextGenerationSettings m_LastSettings;

		// Token: 0x04000020 RID: 32
		private bool m_HasGenerated;

		// Token: 0x04000021 RID: 33
		private TextGenerationError m_LastValid;

		// Token: 0x04000022 RID: 34
		private readonly List<UIVertex> m_Verts;

		// Token: 0x04000023 RID: 35
		private readonly List<UICharInfo> m_Characters;

		// Token: 0x04000024 RID: 36
		private readonly List<UILineInfo> m_Lines;

		// Token: 0x04000025 RID: 37
		private bool m_CachedVerts;

		// Token: 0x04000026 RID: 38
		private bool m_CachedCharacters;

		// Token: 0x04000027 RID: 39
		private bool m_CachedLines;
	}
}
