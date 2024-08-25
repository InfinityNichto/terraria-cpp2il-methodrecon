using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.IO.Enumeration
{
	// Token: 0x0200057A RID: 1402
	internal static class FileSystemEnumerableFactory
	{
		// Token: 0x06002A23 RID: 10787 RVA: 0x0005B9E8 File Offset: 0x00059BE8
		internal static void NormalizeInputs(string directory, string expression, EnumerationOptions options)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06002A24 RID: 10788 RVA: 0x0005BA5C File Offset: 0x00059C5C
		private static bool MatchesPattern(string expression, ReadOnlySpan<char> name, EnumerationOptions options)
		{
			do
			{
				MatchCasing <MatchCasing>k__BackingField = options.<MatchCasing>k__BackingField;
				if (<MatchCasing>k__BackingField == MatchCasing.PlatformDefault)
				{
					if (<MatchCasing>k__BackingField == MatchCasing.PlatformDefault)
					{
					}
					if (!true)
					{
					}
					if (!true)
					{
						bool flag;
						return flag;
					}
					MatchCasing <MatchCasing>k__BackingField2 = options.<MatchCasing>k__BackingField;
				}
			}
			while (options.<MatchType>k__BackingField != MatchType.Simple);
			if (!true)
			{
			}
			bool flag2;
			return flag2;
		}

		// Token: 0x06002A25 RID: 10789 RVA: 0x0005BAA0 File Offset: 0x00059CA0
		internal static IEnumerable<string> UserFiles(string directory, string expression, EnumerationOptions options)
		{
			/*
An exception occurred when decompiling this method (06002A25)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IEnumerable`1<System.String> System.IO.Enumeration.FileSystemEnumerableFactory::UserFiles(System.String,System.String,System.IO.EnumerationOptions)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	brtrue(IL_0000, ldc.i4:bool(1))
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

		// Token: 0x06002A26 RID: 10790 RVA: 0x0005BAB8 File Offset: 0x00059CB8
		internal static IEnumerable<string> UserDirectories(string directory, string expression, EnumerationOptions options)
		{
			/*
An exception occurred when decompiling this method (06002A26)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IEnumerable`1<System.String> System.IO.Enumeration.FileSystemEnumerableFactory::UserDirectories(System.String,System.String,System.IO.EnumerationOptions)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	brtrue(IL_0000, ldc.i4:bool(1))
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

		// Token: 0x06002A27 RID: 10791 RVA: 0x0005BAD0 File Offset: 0x00059CD0
		internal static IEnumerable<string> UserEntries(string directory, string expression, EnumerationOptions options)
		{
			/*
An exception occurred when decompiling this method (06002A27)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IEnumerable`1<System.String> System.IO.Enumeration.FileSystemEnumerableFactory::UserEntries(System.String,System.String,System.IO.EnumerationOptions)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	brtrue(IL_0000, ldc.i4:bool(1))
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

		// Token: 0x06002A28 RID: 10792 RVA: 0x0005BAE8 File Offset: 0x00059CE8
		// Note: this type is marked as 'beforefieldinit'.
		static FileSystemEnumerableFactory()
		{
		}

		// Token: 0x0400169D RID: 5789
		private static readonly char[] s_unixEscapeChars;

		// Token: 0x0200057B RID: 1403
		[CompilerGenerated]
		private sealed class <>c__DisplayClass3_0
		{
			// Token: 0x06002A29 RID: 10793 RVA: 0x0005BAF8 File Offset: 0x00059CF8
			public <>c__DisplayClass3_0()
			{
			}

			// Token: 0x06002A2A RID: 10794 RVA: 0x0005BB0C File Offset: 0x00059D0C
			internal bool <UserFiles>b__1(FileSystemEntry entry)
			{
				bool <InitiallyDirectory>k__BackingField = entry._status.<InitiallyDirectory>k__BackingField;
				if (<InitiallyDirectory>k__BackingField)
				{
				}
				string text = this.expression;
				ReadOnlySpan<char> fileName = entry.FileName;
				EnumerationOptions enumerationOptions = this.options;
				if (!<InitiallyDirectory>k__BackingField)
				{
				}
				bool flag;
				return flag;
			}

			// Token: 0x0400169E RID: 5790
			public string expression;

			// Token: 0x0400169F RID: 5791
			public EnumerationOptions options;
		}

		// Token: 0x0200057C RID: 1404
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06002A2B RID: 10795 RVA: 0x0005BB48 File Offset: 0x00059D48
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06002A2C RID: 10796 RVA: 0x0005BB58 File Offset: 0x00059D58
			public <>c()
			{
			}

			// Token: 0x06002A2D RID: 10797 RVA: 0x0005BB6C File Offset: 0x00059D6C
			internal string <UserFiles>b__3_0(FileSystemEntry entry)
			{
				return entry.ToSpecifiedFullPath();
			}

			// Token: 0x06002A2E RID: 10798 RVA: 0x0005BB80 File Offset: 0x00059D80
			internal string <UserDirectories>b__4_0(FileSystemEntry entry)
			{
				return entry.ToSpecifiedFullPath();
			}

			// Token: 0x06002A2F RID: 10799 RVA: 0x0005BB94 File Offset: 0x00059D94
			internal string <UserEntries>b__5_0(FileSystemEntry entry)
			{
				return entry.ToSpecifiedFullPath();
			}

			// Token: 0x040016A0 RID: 5792
			public static readonly FileSystemEnumerableFactory.<>c <>9;

			// Token: 0x040016A1 RID: 5793
			public static FileSystemEnumerable<string>.FindTransform <>9__3_0;

			// Token: 0x040016A2 RID: 5794
			public static FileSystemEnumerable<string>.FindTransform <>9__4_0;

			// Token: 0x040016A3 RID: 5795
			public static FileSystemEnumerable<string>.FindTransform <>9__5_0;
		}

		// Token: 0x0200057D RID: 1405
		[CompilerGenerated]
		private sealed class <>c__DisplayClass4_0
		{
			// Token: 0x06002A30 RID: 10800 RVA: 0x0005BBA8 File Offset: 0x00059DA8
			public <>c__DisplayClass4_0()
			{
			}

			// Token: 0x06002A31 RID: 10801 RVA: 0x0005BBBC File Offset: 0x00059DBC
			internal bool <UserDirectories>b__1(FileSystemEntry entry)
			{
				bool <InitiallyDirectory>k__BackingField = entry._status.<InitiallyDirectory>k__BackingField;
				if (<InitiallyDirectory>k__BackingField)
				{
					string text = this.expression;
					ReadOnlySpan<char> fileName = entry.FileName;
					EnumerationOptions enumerationOptions = this.options;
					if (!<InitiallyDirectory>k__BackingField)
					{
					}
					bool flag;
					return flag;
				}
			}

			// Token: 0x040016A4 RID: 5796
			public string expression;

			// Token: 0x040016A5 RID: 5797
			public EnumerationOptions options;
		}

		// Token: 0x0200057E RID: 1406
		[CompilerGenerated]
		private sealed class <>c__DisplayClass5_0
		{
			// Token: 0x06002A32 RID: 10802 RVA: 0x0005BBF8 File Offset: 0x00059DF8
			public <>c__DisplayClass5_0()
			{
			}

			// Token: 0x06002A33 RID: 10803 RVA: 0x0005BC0C File Offset: 0x00059E0C
			internal bool <UserEntries>b__1(FileSystemEntry entry)
			{
				string text = this.expression;
				ReadOnlySpan<char> fileName = entry.FileName;
				EnumerationOptions enumerationOptions = this.options;
				if (!true)
				{
				}
				bool flag;
				return flag;
			}

			// Token: 0x040016A6 RID: 5798
			public string expression;

			// Token: 0x040016A7 RID: 5799
			public EnumerationOptions options;
		}
	}
}
