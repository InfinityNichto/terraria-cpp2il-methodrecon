using System;
using System.Runtime.Serialization;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x020003AD RID: 941
	[DataContract]
	public struct Viewport
	{
		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06001932 RID: 6450 RVA: 0x0006AD38 File Offset: 0x00068F38
		// (set) Token: 0x06001933 RID: 6451 RVA: 0x0006AD4C File Offset: 0x00068F4C
		[DataMember]
		public int Height
		{
			get
			{
				return this.height;
			}
			set
			{
				this.height = value;
			}
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06001934 RID: 6452 RVA: 0x0006AD60 File Offset: 0x00068F60
		// (set) Token: 0x06001935 RID: 6453 RVA: 0x0006AD74 File Offset: 0x00068F74
		[DataMember]
		public float MaxDepth
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001934)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Microsoft.Xna.Framework.Graphics.Viewport::get_MaxDepth()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(Viewport::maxDepth, ldloc:valuetype Microsoft.Xna.Framework.Graphics.Viewport&(this)))
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
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06001936 RID: 6454 RVA: 0x0006AD84 File Offset: 0x00068F84
		// (set) Token: 0x06001937 RID: 6455 RVA: 0x0006AD98 File Offset: 0x00068F98
		[DataMember]
		public float MinDepth
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001936)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Microsoft.Xna.Framework.Graphics.Viewport::get_MinDepth()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(Viewport::minDepth, ldloc:valuetype Microsoft.Xna.Framework.Graphics.Viewport&(this)))
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
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06001938 RID: 6456 RVA: 0x0006ADA8 File Offset: 0x00068FA8
		// (set) Token: 0x06001939 RID: 6457 RVA: 0x0006ADBC File Offset: 0x00068FBC
		[DataMember]
		public int Width
		{
			get
			{
				return this.width;
			}
			set
			{
				this.width = value;
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x0600193A RID: 6458 RVA: 0x0006ADD0 File Offset: 0x00068FD0
		// (set) Token: 0x0600193B RID: 6459 RVA: 0x0006ADE4 File Offset: 0x00068FE4
		[DataMember]
		public int Y
		{
			get
			{
				return this.y;
			}
			set
			{
				this.y = value;
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x0600193C RID: 6460 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x0600193D RID: 6461 RVA: 0x0006ADF8 File Offset: 0x00068FF8
		[DataMember]
		public int X
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
				this.x = value;
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x0600193E RID: 6462 RVA: 0x0006AE0C File Offset: 0x0006900C
		public float AspectRatio
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600193E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Microsoft.Xna.Framework.Graphics.Viewport::get_AspectRatio()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	brtrue(IL_0000, logicnot:bool(ldfld:int32[exp:bool](Viewport::width, ldloc:valuetype Microsoft.Xna.Framework.Graphics.Viewport&(this))))
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
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x0600193F RID: 6463 RVA: 0x0006AE28 File Offset: 0x00069028
		// (set) Token: 0x06001940 RID: 6464 RVA: 0x0006AE50 File Offset: 0x00069050
		public Rectangle Bounds
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600193F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Rectangle Microsoft.Xna.Framework.Graphics.Viewport::get_Bounds()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Viewport::x, ldloc:valuetype Microsoft.Xna.Framework.Graphics.Viewport&(this)))
	stloc:int32(var_1_0D, ldfld:int32(Viewport::width, ldloc:valuetype Microsoft.Xna.Framework.Graphics.Viewport&(this)))
	stloc:int32(var_2_14, ldfld:int32(Viewport::width, ldloc:valuetype Microsoft.Xna.Framework.Graphics.Viewport&(this)))
	stloc:float32(var_3_1B, ldfld:float32(Viewport::minDepth, ldloc:valuetype Microsoft.Xna.Framework.Graphics.Viewport&(this)))
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
				this.x = value;
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06001941 RID: 6465 RVA: 0x0006AE64 File Offset: 0x00069064
		public Rectangle TitleSafeArea
		{
			get
			{
				int num = this.x;
				int num2 = this.width;
				int num3 = this.width;
				float num4 = this.minDepth;
				if (!true)
				{
				}
				return GraphicsDevice.GetTitleSafeArea(num, num2, num3, (int)num4);
			}
		}

		// Token: 0x06001942 RID: 6466 RVA: 0x0006AE9C File Offset: 0x0006909C
		public Viewport(int x, int y, int width, int height)
		{
			this.x = x;
			this.width = y;
			this.width = width;
			this.minDepth = (float)height;
		}

		// Token: 0x06001943 RID: 6467 RVA: 0x0006AEC8 File Offset: 0x000690C8
		public Viewport(int x, int y, int width, int height, float minDepth, float maxDepth)
		{
			this.x = x;
			this.width = y;
			this.width = width;
			this.minDepth = (float)height;
		}

		// Token: 0x06001944 RID: 6468 RVA: 0x0006AEF4 File Offset: 0x000690F4
		public Viewport(Rectangle bounds)
		{
			this.x = bounds;
		}

		// Token: 0x06001945 RID: 6469 RVA: 0x0006AF08 File Offset: 0x00069108
		public Vector3 Project(Vector3 source, Matrix projection, Matrix view, Matrix world)
		{
			float m = view.M31;
			float m2 = view.M32;
			float m3 = view.M11;
			float m4 = view.M12;
			float m5 = projection.M31;
			float m6 = projection.M32;
			float m7 = projection.M11;
			float m8 = projection.M12;
			if (!true)
			{
			}
			float num = source.X;
			float num2 = source.Y;
			if (!true)
			{
			}
			int num3 = this.x;
			int num4 = this.y;
			float num5 = this.minDepth;
			float num6 = this.maxDepth;
			return 1;
		}

		// Token: 0x06001946 RID: 6470 RVA: 0x0006AF88 File Offset: 0x00069188
		public Vector3 Unproject(Vector3 source, Matrix projection, Matrix view, Matrix world)
		{
			float m = view.M31;
			float m2 = view.M32;
			float m3 = view.M11;
			float m4 = view.M12;
			float m5 = projection.M31;
			float m6 = projection.M32;
			float m7 = projection.M11;
			float m8 = projection.M12;
			if (!true)
			{
			}
			float num = source.X;
			float num2 = source.Y;
			Matrix matrix2;
			Matrix matrix = Matrix.Invert(matrix2);
			float num3 = this.minDepth;
			float num4 = this.maxDepth;
			int num5 = this.x;
			int num6 = this.y;
			int num7 = this.width;
			int num8 = this.height;
			if (!true)
			{
				return;
			}
		}

		// Token: 0x06001947 RID: 6471 RVA: 0x000021DB File Offset: 0x000003DB
		private static bool WithinEpsilon(float a, float b)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001948 RID: 6472 RVA: 0x0006B028 File Offset: 0x00069228
		public override string ToString()
		{
			string text;
			string text2;
			string text3;
			string text4;
			string text5;
			string text6;
			if (("{X:" == null || "{X:" != null) && (text == null || text != null) && (" Y:" == null || " Y:" != null) && (text2 == null || text2 != null) && (" Width:" == null || " Width:" != null) && (text3 == null || text3 != null) && (" Height:" == null || " Height:" != null) && (text4 == null || text4 != null) && " MinDepth:" != null && (text5 == null || text5 != null) && (" MaxDepth:" == null || " MaxDepth:" != null) && (text6 == null || text6 != null) && ("}" == null || "}" != null))
			{
				string text7;
				return text7;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x04002793 RID: 10131
		private int x;

		// Token: 0x04002794 RID: 10132
		private int y;

		// Token: 0x04002795 RID: 10133
		private int width;

		// Token: 0x04002796 RID: 10134
		private int height;

		// Token: 0x04002797 RID: 10135
		private float minDepth;

		// Token: 0x04002798 RID: 10136
		private float maxDepth;
	}
}
