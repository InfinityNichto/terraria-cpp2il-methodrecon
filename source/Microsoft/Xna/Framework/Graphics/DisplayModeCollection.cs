using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x02000360 RID: 864
	public class DisplayModeCollection : IEnumerable<DisplayMode>, IEnumerable
	{
		// Token: 0x17000297 RID: 663
		public IEnumerable<DisplayMode> this[SurfaceFormat format]
		{
			get
			{
				List<DisplayMode> modes = this._modes;
				throw new OutOfMemoryException();
			}
		}

		// Token: 0x0600168A RID: 5770 RVA: 0x00062F3C File Offset: 0x0006113C
		public IEnumerator<DisplayMode> GetEnumerator()
		{
			/*
An exception occurred when decompiling this method (0600168A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IEnumerator`1<Microsoft.Xna.Framework.Graphics.DisplayMode> Microsoft.Xna.Framework.Graphics.DisplayModeCollection::GetEnumerator()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.List`1<class Microsoft.Xna.Framework.Graphics.DisplayMode>(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.List`1<class Microsoft.Xna.Framework.Graphics.DisplayMode>(DisplayModeCollection::_modes, ldloc:DisplayModeCollection(this)))
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

		// Token: 0x0600168B RID: 5771 RVA: 0x00062F50 File Offset: 0x00061150
		IEnumerator IEnumerable.GetEnumerator()
		{
			/*
An exception occurred when decompiling this method (0600168B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.IEnumerator Microsoft.Xna.Framework.Graphics.DisplayModeCollection::System.Collections.IEnumerable.GetEnumerator()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.List`1<class Microsoft.Xna.Framework.Graphics.DisplayMode>(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.List`1<class Microsoft.Xna.Framework.Graphics.DisplayMode>(DisplayModeCollection::_modes, ldloc:DisplayModeCollection(this)))
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

		// Token: 0x0600168C RID: 5772 RVA: 0x00062F64 File Offset: 0x00061164
		internal DisplayModeCollection(List<DisplayMode> modes)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			this._modes = modes;
		}

		// Token: 0x040024D2 RID: 9426
		private readonly List<DisplayMode> _modes;

		// Token: 0x02000361 RID: 865
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600168D RID: 5773 RVA: 0x00062F84 File Offset: 0x00061184
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x0600168E RID: 5774 RVA: 0x00062F94 File Offset: 0x00061194
			public <>c()
			{
			}

			// Token: 0x0600168F RID: 5775 RVA: 0x00062FA8 File Offset: 0x000611A8
			internal int <.ctor>b__5_0(DisplayMode a, DisplayMode b)
			{
				SurfaceFormat format = a.format;
				SurfaceFormat format2 = b.format;
				if (b != null && a != null)
				{
					int height = a.height;
					int height2 = b.height;
					int width = a.width;
					int width2 = b.width;
				}
				int width3 = a.width;
				int width4 = b.width;
				int height3 = a.height;
				int height4 = b.height;
				return 1;
			}

			// Token: 0x040024D3 RID: 9427
			public static readonly DisplayModeCollection.<>c <>9;

			// Token: 0x040024D4 RID: 9428
			public static Comparison<DisplayMode> <>9__5_0;
		}
	}
}
