using System;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x02000377 RID: 887
	public sealed class GraphicsAdapter
	{
		// Token: 0x170002BB RID: 699
		// (get) Token: 0x0600171E RID: 5918 RVA: 0x00064AA4 File Offset: 0x00062CA4
		// (set) Token: 0x0600171F RID: 5919 RVA: 0x00064AB8 File Offset: 0x00062CB8
		public static int VirtualScreenSize
		{
			get
			{
				if (!true)
				{
				}
				return 1;
			}
			set
			{
				if (!true)
				{
				}
				int screenWidth = XNAUnityRunner.ScreenWidth;
				int screenHeight = XNAUnityRunner.ScreenHeight;
			}
		}

		// Token: 0x06001720 RID: 5920 RVA: 0x00064AD8 File Offset: 0x00062CD8
		static GraphicsAdapter()
		{
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06001721 RID: 5921 RVA: 0x00064AE8 File Offset: 0x00062CE8
		public static GraphicsAdapter DefaultAdapter
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001721)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.GraphicsAdapter Microsoft.Xna.Framework.Graphics.GraphicsAdapter::get_DefaultAdapter()

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

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06001722 RID: 5922 RVA: 0x00064AF8 File Offset: 0x00062CF8
		public static ReadOnlyCollection<GraphicsAdapter> Adapters
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001722)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.ObjectModel.ReadOnlyCollection`1<Microsoft.Xna.Framework.Graphics.GraphicsAdapter> Microsoft.Xna.Framework.Graphics.GraphicsAdapter::get_Adapters()

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

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06001723 RID: 5923 RVA: 0x00064B08 File Offset: 0x00062D08
		// (set) Token: 0x06001724 RID: 5924 RVA: 0x00064B1C File Offset: 0x00062D1C
		public static bool UseReferenceDevice
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001723)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Microsoft.Xna.Framework.Graphics.GraphicsAdapter::get_UseReferenceDevice()

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
			set
			{
				if (!true)
				{
				}
				if (!true)
				{
				}
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06001725 RID: 5925 RVA: 0x00064B30 File Offset: 0x00062D30
		// (set) Token: 0x06001726 RID: 5926 RVA: 0x00064B40 File Offset: 0x00062D40
		public static GraphicsAdapter.DriverType UseDriverType
		{
			[CompilerGenerated]
			get
			{
				/*
An exception occurred when decompiling this method (06001725)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.GraphicsAdapter/DriverType Microsoft.Xna.Framework.Graphics.GraphicsAdapter::get_UseDriverType()

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
			[CompilerGenerated]
			set
			{
				if (!true)
				{
				}
			}
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06001727 RID: 5927 RVA: 0x00064B50 File Offset: 0x00062D50
		// (set) Token: 0x06001728 RID: 5928 RVA: 0x00064B60 File Offset: 0x00062D60
		public static bool UseDebugLayers
		{
			[CompilerGenerated]
			get
			{
				/*
An exception occurred when decompiling this method (06001727)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Microsoft.Xna.Framework.Graphics.GraphicsAdapter::get_UseDebugLayers()

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
			[CompilerGenerated]
			set
			{
				if ("BartenderSpecialText.AfterDD2Tier3" == null)
				{
				}
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06001729 RID: 5929 RVA: 0x00064B74 File Offset: 0x00062D74
		// (set) Token: 0x0600172A RID: 5930 RVA: 0x00064B88 File Offset: 0x00062D88
		public string Description
		{
			[CompilerGenerated]
			get
			{
				return this.<Description>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Description>k__BackingField = value;
			}
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x0600172B RID: 5931 RVA: 0x00064B9C File Offset: 0x00062D9C
		// (set) Token: 0x0600172C RID: 5932 RVA: 0x00064BB0 File Offset: 0x00062DB0
		public int DeviceId
		{
			[CompilerGenerated]
			get
			{
				return this.<DeviceId>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<DeviceId>k__BackingField = value;
			}
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x0600172D RID: 5933 RVA: 0x00064BC4 File Offset: 0x00062DC4
		// (set) Token: 0x0600172E RID: 5934 RVA: 0x00064BD8 File Offset: 0x00062DD8
		public string DeviceName
		{
			[CompilerGenerated]
			get
			{
				return this.<DeviceName>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<DeviceName>k__BackingField = value;
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x0600172F RID: 5935 RVA: 0x00064BEC File Offset: 0x00062DEC
		// (set) Token: 0x06001730 RID: 5936 RVA: 0x00064C00 File Offset: 0x00062E00
		public int VendorId
		{
			[CompilerGenerated]
			get
			{
				return this.<VendorId>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<VendorId>k__BackingField = value;
			}
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06001731 RID: 5937 RVA: 0x00064C14 File Offset: 0x00062E14
		// (set) Token: 0x06001732 RID: 5938 RVA: 0x00064C28 File Offset: 0x00062E28
		public bool IsDefaultAdapter
		{
			[CompilerGenerated]
			get
			{
				return this.<IsDefaultAdapter>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06001733 RID: 5939 RVA: 0x00064C38 File Offset: 0x00062E38
		// (set) Token: 0x06001734 RID: 5940 RVA: 0x00064C4C File Offset: 0x00062E4C
		public IntPtr MonitorHandle
		{
			[CompilerGenerated]
			get
			{
				return this.<MonitorHandle>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<MonitorHandle>k__BackingField = value;
			}
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06001735 RID: 5941 RVA: 0x00064C60 File Offset: 0x00062E60
		// (set) Token: 0x06001736 RID: 5942 RVA: 0x00064C74 File Offset: 0x00062E74
		public int Revision
		{
			[CompilerGenerated]
			get
			{
				return this.<Revision>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Revision>k__BackingField = value;
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06001737 RID: 5943 RVA: 0x00064C88 File Offset: 0x00062E88
		// (set) Token: 0x06001738 RID: 5944 RVA: 0x00064C9C File Offset: 0x00062E9C
		public int SubSystemId
		{
			[CompilerGenerated]
			get
			{
				return this.<SubSystemId>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06001739 RID: 5945 RVA: 0x00064CAC File Offset: 0x00062EAC
		public DisplayModeCollection SupportedDisplayModes
		{
			get
			{
				return this._supportedDisplayModes;
			}
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x0600173A RID: 5946 RVA: 0x00064CC0 File Offset: 0x00062EC0
		public DisplayMode CurrentDisplayMode
		{
			get
			{
				return this._currentDisplayMode;
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x0600173B RID: 5947 RVA: 0x00064CD4 File Offset: 0x00062ED4
		public bool IsWideScreen
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600173B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Microsoft.Xna.Framework.Graphics.GraphicsAdapter::get_IsWideScreen()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_0B, callgetter:float32(DisplayMode::get_AspectRatio, ldfld:DisplayMode(GraphicsAdapter::_currentDisplayMode, ldloc:GraphicsAdapter(this))))
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

		// Token: 0x0600173C RID: 5948 RVA: 0x00064CEC File Offset: 0x00062EEC
		public bool QueryRenderTargetFormat(GraphicsProfile graphicsProfile, SurfaceFormat format, DepthFormat depthFormat, int multiSampleCount, [Out] SurfaceFormat selectedFormat, [Out] DepthFormat selectedDepthFormat, [Out] int selectedMultiSampleCount)
		{
			/*
An exception occurred when decompiling this method (0600173C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Microsoft.Xna.Framework.Graphics.GraphicsAdapter::QueryRenderTargetFormat(Microsoft.Xna.Framework.Graphics.GraphicsProfile,Microsoft.Xna.Framework.Graphics.SurfaceFormat,Microsoft.Xna.Framework.Graphics.DepthFormat,System.Int32,Microsoft.Xna.Framework.Graphics.SurfaceFormat,Microsoft.Xna.Framework.Graphics.DepthFormat,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stfld:int32(SurfaceFormat::value__, ldloc:SurfaceFormat[exp:valuetype Microsoft.Xna.Framework.Graphics.SurfaceFormat&](selectedFormat), ldloc:SurfaceFormat[exp:int32](format))
	stfld:int32(DepthFormat::value__, ldloc:DepthFormat[exp:valuetype Microsoft.Xna.Framework.Graphics.DepthFormat&](selectedDepthFormat), ldloc:DepthFormat[exp:int32](depthFormat))
	stfld:int32(int32::m_value, ldloc:int32[exp:int32&](selectedMultiSampleCount), ldloc:int32(multiSampleCount))
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

		// Token: 0x0600173D RID: 5949 RVA: 0x00064D18 File Offset: 0x00062F18
		public bool IsProfileSupported(GraphicsProfile graphicsProfile)
		{
		}

		// Token: 0x0600173E RID: 5950 RVA: 0x00064D28 File Offset: 0x00062F28
		public void Dispose()
		{
		}

		// Token: 0x0600173F RID: 5951 RVA: 0x00064D38 File Offset: 0x00062F38
		private static void PlatformInitializeAdapters([Out] ReadOnlyCollection<GraphicsAdapter> adaptersResults)
		{
		}

		// Token: 0x06001740 RID: 5952 RVA: 0x00064D6C File Offset: 0x00062F6C
		public GraphicsAdapter()
		{
		}

		// Token: 0x040025BB RID: 9659
		private static int _virtualScreenSize;

		// Token: 0x040025BC RID: 9660
		private static readonly ReadOnlyCollection<GraphicsAdapter> _adapters;

		// Token: 0x040025BD RID: 9661
		private DisplayModeCollection _supportedDisplayModes;

		// Token: 0x040025BE RID: 9662
		private DisplayMode _currentDisplayMode;

		// Token: 0x040025BF RID: 9663
		[CompilerGenerated]
		private static GraphicsAdapter.DriverType <UseDriverType>k__BackingField;

		// Token: 0x040025C0 RID: 9664
		[CompilerGenerated]
		private static bool <UseDebugLayers>k__BackingField;

		// Token: 0x040025C1 RID: 9665
		[CompilerGenerated]
		private string <Description>k__BackingField;

		// Token: 0x040025C2 RID: 9666
		[CompilerGenerated]
		private int <DeviceId>k__BackingField;

		// Token: 0x040025C3 RID: 9667
		[CompilerGenerated]
		private string <DeviceName>k__BackingField;

		// Token: 0x040025C4 RID: 9668
		[CompilerGenerated]
		private int <VendorId>k__BackingField;

		// Token: 0x040025C5 RID: 9669
		[CompilerGenerated]
		private bool <IsDefaultAdapter>k__BackingField;

		// Token: 0x040025C6 RID: 9670
		[CompilerGenerated]
		private IntPtr <MonitorHandle>k__BackingField;

		// Token: 0x040025C7 RID: 9671
		[CompilerGenerated]
		private int <Revision>k__BackingField;

		// Token: 0x040025C8 RID: 9672
		[CompilerGenerated]
		private int <SubSystemId>k__BackingField;

		// Token: 0x02000378 RID: 888
		public enum DriverType
		{
			// Token: 0x040025CA RID: 9674
			Hardware,
			// Token: 0x040025CB RID: 9675
			Reference,
			// Token: 0x040025CC RID: 9676
			FastSoftware
		}
	}
}
