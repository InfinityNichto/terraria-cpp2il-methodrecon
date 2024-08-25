using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace System.IO.Enumeration
{
	// Token: 0x02000576 RID: 1398
	public class FileSystemEnumerable<TResult> : IEnumerable<TResult>, IEnumerable
	{
		// Token: 0x06002A15 RID: 10773 RVA: 0x0005B8E8 File Offset: 0x00059AE8
		public FileSystemEnumerable(string directory, FileSystemEnumerable<TResult>.FindTransform transform, [Optional] EnumerationOptions options)
		{
			do
			{
				base..ctor();
				if (directory == null)
				{
					return;
				}
				this._directory = directory;
			}
			while (transform == null);
			this._transform = transform;
			if (options == null)
			{
				if (!true)
				{
				}
				if (!true)
				{
				}
			}
			this._enumerator = 1;
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x06002A16 RID: 10774 RVA: 0x0005B920 File Offset: 0x00059B20
		// (set) Token: 0x06002A17 RID: 10775 RVA: 0x0005B934 File Offset: 0x00059B34
		public FileSystemEnumerable<TResult>.FindPredicate ShouldIncludePredicate
		{
			[CompilerGenerated]
			get
			{
				return this.<ShouldIncludePredicate>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ShouldIncludePredicate>k__BackingField = value;
			}
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x06002A18 RID: 10776 RVA: 0x0005B948 File Offset: 0x00059B48
		public FileSystemEnumerable<TResult>.FindPredicate ShouldRecursePredicate
		{
			[CompilerGenerated]
			get
			{
				return this.<ShouldRecursePredicate>k__BackingField;
			}
		}

		// Token: 0x06002A19 RID: 10777 RVA: 0x0005B95C File Offset: 0x00059B5C
		public IEnumerator<TResult> GetEnumerator()
		{
			/*
An exception occurred when decompiling this method (06002A19)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IEnumerator`1<TResult> System.IO.Enumeration.FileSystemEnumerable`1::GetEnumerator()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldloc:FileSystemEnumerable`1[exp:bool](this))
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

		// Token: 0x06002A1A RID: 10778 RVA: 0x0000207A File Offset: 0x0000027A
		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x04001696 RID: 5782
		private FileSystemEnumerable<TResult>.DelegateEnumerator _enumerator;

		// Token: 0x04001697 RID: 5783
		private readonly FileSystemEnumerable<TResult>.FindTransform _transform;

		// Token: 0x04001698 RID: 5784
		private readonly EnumerationOptions _options;

		// Token: 0x04001699 RID: 5785
		private readonly string _directory;

		// Token: 0x0400169A RID: 5786
		[CompilerGenerated]
		private FileSystemEnumerable<TResult>.FindPredicate <ShouldIncludePredicate>k__BackingField;

		// Token: 0x0400169B RID: 5787
		[CompilerGenerated]
		private FileSystemEnumerable<TResult>.FindPredicate <ShouldRecursePredicate>k__BackingField;

		// Token: 0x02000577 RID: 1399
		public sealed class FindPredicate : MulticastDelegate
		{
			// Token: 0x06002A1B RID: 10779 RVA: 0x0005B96C File Offset: 0x00059B6C
			public FindPredicate(object @object, IntPtr method)
			{
			}

			// Token: 0x06002A1C RID: 10780 RVA: 0x0000207A File Offset: 0x0000027A
			public bool Invoke(FileSystemEntry entry)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x02000578 RID: 1400
		public sealed class FindTransform : MulticastDelegate
		{
			// Token: 0x06002A1D RID: 10781 RVA: 0x0005B988 File Offset: 0x00059B88
			public FindTransform(object @object, IntPtr method)
			{
			}

			// Token: 0x06002A1E RID: 10782 RVA: 0x0000207A File Offset: 0x0000027A
			public TResult Invoke(FileSystemEntry entry)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x02000579 RID: 1401
		private sealed class DelegateEnumerator : FileSystemEnumerator<TResult>
		{
			// Token: 0x06002A1F RID: 10783 RVA: 0x0005B9A4 File Offset: 0x00059BA4
			public DelegateEnumerator(FileSystemEnumerable<TResult> enumerable)
			{
				EnumerationOptions options = enumerable._options;
				string directory = enumerable._directory;
			}

			// Token: 0x06002A20 RID: 10784 RVA: 0x0000207A File Offset: 0x0000027A
			protected override TResult TransformEntry(FileSystemEntry entry)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06002A21 RID: 10785 RVA: 0x0005B9C0 File Offset: 0x00059BC0
			protected override bool ShouldRecurseIntoEntry(FileSystemEntry entry)
			{
				if (this != null)
				{
				}
				return true;
			}

			// Token: 0x06002A22 RID: 10786 RVA: 0x0005B9D4 File Offset: 0x00059BD4
			protected override bool ShouldIncludeEntry(FileSystemEntry entry)
			{
				if (this != null)
				{
				}
				return true;
			}

			// Token: 0x0400169C RID: 5788
			private readonly FileSystemEnumerable<TResult> _enumerable;
		}
	}
}
