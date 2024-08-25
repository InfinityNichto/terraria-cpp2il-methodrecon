using System;
using System.Runtime.Serialization;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x0200035F RID: 863
	[DataContract]
	public class DisplayMode
	{
		// Token: 0x0600167D RID: 5757 RVA: 0x00062D48 File Offset: 0x00060F48
		public void UpdateSize(int newWidth, int newHeight)
		{
			this.height = newHeight;
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x0600167E RID: 5758 RVA: 0x00062D5C File Offset: 0x00060F5C
		public float AspectRatio
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600167E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Microsoft.Xna.Framework.Graphics.DisplayMode::get_AspectRatio()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(DisplayMode::height, ldloc:DisplayMode(this)))
	stloc:int32(var_1_0D, ldfld:int32(DisplayMode::width, ldloc:DisplayMode(this)))
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

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x0600167F RID: 5759 RVA: 0x00062D78 File Offset: 0x00060F78
		public SurfaceFormat Format
		{
			get
			{
				return this.format;
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06001680 RID: 5760 RVA: 0x00062D8C File Offset: 0x00060F8C
		public int Height
		{
			get
			{
				return this.height;
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06001681 RID: 5761 RVA: 0x00062DA0 File Offset: 0x00060FA0
		public int Width
		{
			get
			{
				return this.width;
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06001682 RID: 5762 RVA: 0x00062DB4 File Offset: 0x00060FB4
		public Rectangle TitleSafeArea
		{
			get
			{
				int num = this.height;
				if (!true)
				{
				}
				Rectangle rectangle;
				return rectangle;
			}
		}

		// Token: 0x06001683 RID: 5763 RVA: 0x00062DD0 File Offset: 0x00060FD0
		internal DisplayMode(int width, int height, SurfaceFormat format)
		{
			this.height = height;
			this.format = format;
		}

		// Token: 0x06001684 RID: 5764 RVA: 0x00062DF4 File Offset: 0x00060FF4
		public static bool operator !=(DisplayMode left, DisplayMode right)
		{
			if (left != null)
			{
				SurfaceFormat surfaceFormat = left.format;
				int num = left.height;
				int num2 = left.width;
			}
			return true;
		}

		// Token: 0x06001685 RID: 5765 RVA: 0x00062E20 File Offset: 0x00061020
		public static bool operator ==(DisplayMode left, DisplayMode right)
		{
			/*
An exception occurred when decompiling this method (06001685)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Microsoft.Xna.Framework.Graphics.DisplayMode::op_Equality(Microsoft.Xna.Framework.Graphics.DisplayMode,Microsoft.Xna.Framework.Graphics.DisplayMode)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:SurfaceFormat(var_1_0B, ldfld:SurfaceFormat(DisplayMode::format, ldloc:DisplayMode(left)))
	stloc:int32(var_2_12, ldfld:int32(DisplayMode::height, ldloc:DisplayMode(left)))
	stloc:int32(var_3_19, ldfld:int32(DisplayMode::width, ldloc:DisplayMode(left)))
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

		// Token: 0x06001686 RID: 5766 RVA: 0x00062E4C File Offset: 0x0006104C
		public override bool Equals(object obj)
		{
			/*
An exception occurred when decompiling this method (06001686)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Microsoft.Xna.Framework.Graphics.DisplayMode::Equals(System.Object)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_1:
	stloc:SurfaceFormat(var_1_0E, ldfld:SurfaceFormat(DisplayMode::format, ldloc:DisplayMode(this)))
	stloc:int32(var_2_15, ldfld:int32(DisplayMode::height, ldloc:DisplayMode(this)))
	stloc:int32(var_3_1C, ldfld:int32(DisplayMode::width, ldloc:DisplayMode(this)))
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

		// Token: 0x06001687 RID: 5767 RVA: 0x00062E78 File Offset: 0x00061078
		public override int GetHashCode()
		{
			int num;
			return num.GetHashCode().GetHashCode();
		}

		// Token: 0x06001688 RID: 5768 RVA: 0x00062E90 File Offset: 0x00061090
		public override string ToString()
		{
			string text;
			string text2;
			if (("{Width:" == null || "{Width:" != null) && (text == null || text != null) && (" Height:" == null || " Height:" != null) && (text2 == null || text2 != null) && (" Format:" == null || " Format:" != null))
			{
				SurfaceFormat surfaceFormat = this.format;
				string text3;
				string text4;
				if ((text3 == null || text3 != null) && (" AspectRatio:" == null || " AspectRatio:" != null) && (text4 == null || text4 != null) && ("}" == null || "}" != null))
				{
					string text5;
					return text5;
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x040024CF RID: 9423
		private SurfaceFormat format;

		// Token: 0x040024D0 RID: 9424
		private int height;

		// Token: 0x040024D1 RID: 9425
		private int width;
	}
}
