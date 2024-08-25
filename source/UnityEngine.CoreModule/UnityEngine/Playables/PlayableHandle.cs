using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Playables
{
	// Token: 0x02000154 RID: 340
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
	[NativeHeader("Runtime/Export/Director/PlayableHandle.bindings.h")]
	[UsedByNativeCode]
	public struct PlayableHandle : IEquatable<PlayableHandle>
	{
		// Token: 0x06000654 RID: 1620 RVA: 0x0000B558 File Offset: 0x00009758
		[VisibleToOtherModules]
		internal bool IsPlayableOfType<T>()
		{
			/*
An exception occurred when decompiling this method (06000654)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean UnityEngine.Playables.PlayableHandle::IsPlayableOfType<T>()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Type(var_0_06, call:Type(PlayableHandle::GetPlayableType, ldloc:valuetype UnityEngine.Playables.PlayableHandle&(this)))
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

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000655 RID: 1621 RVA: 0x0000B56C File Offset: 0x0000976C
		public static PlayableHandle Null
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000655)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.Playables.PlayableHandle UnityEngine.Playables.PlayableHandle::get_Null()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
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

		// Token: 0x06000656 RID: 1622 RVA: 0x0000B57C File Offset: 0x0000977C
		public static bool operator ==(PlayableHandle x, PlayableHandle y)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x0000B590 File Offset: 0x00009790
		public override bool Equals(object p)
		{
			if (p != null)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x0000B5A4 File Offset: 0x000097A4
		public bool Equals(PlayableHandle other)
		{
			IntPtr handle = this.m_Handle;
			uint version = this.m_Version;
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x0000B5C4 File Offset: 0x000097C4
		public override int GetHashCode()
		{
			int num;
			return num;
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x0000B5D4 File Offset: 0x000097D4
		internal static bool CompareVersion(PlayableHandle lhs, PlayableHandle rhs)
		{
			bool flag;
			return flag;
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x0000B5E4 File Offset: 0x000097E4
		[VisibleToOtherModules]
		internal bool IsValid()
		{
			if (!true)
			{
			}
			throw new MissingMethodException();
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x0000B5FC File Offset: 0x000097FC
		[FreeFunction("PlayableHandleBindings::GetPlayableType", HasExplicitThis = true, ThrowsException = true)]
		[VisibleToOtherModules]
		internal Type GetPlayableType()
		{
			if (!true)
			{
			}
			throw new MissingMethodException();
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x0000B614 File Offset: 0x00009814
		// Note: this type is marked as 'beforefieldinit'.
		static PlayableHandle()
		{
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x0000B624 File Offset: 0x00009824
		private static bool IsValid_Injected(PlayableHandle _unity_self)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x0000B638 File Offset: 0x00009838
		private static Type GetPlayableType_Injected(PlayableHandle _unity_self)
		{
			throw new MissingMethodException();
		}

		// Token: 0x04000633 RID: 1587
		internal IntPtr m_Handle;

		// Token: 0x04000634 RID: 1588
		internal uint m_Version;

		// Token: 0x04000635 RID: 1589
		private static readonly PlayableHandle m_Null;
	}
}
