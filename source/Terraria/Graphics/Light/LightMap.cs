using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Drawing;
using Terraria.Utilities;
using Unity.IL2CPP.CompilerServices;

namespace Terraria.Graphics.Light
{
	// Token: 0x02000779 RID: 1913
	public class LightMap
	{
		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x06003EA6 RID: 16038 RVA: 0x0023E28C File Offset: 0x0023C48C
		// (set) Token: 0x06003EA7 RID: 16039 RVA: 0x0023E2A0 File Offset: 0x0023C4A0
		public int NonVisiblePadding
		{
			[CompilerGenerated]
			get
			{
				return this.<NonVisiblePadding>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<NonVisiblePadding>k__BackingField = value;
			}
		}

		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x06003EA8 RID: 16040 RVA: 0x0023E2B4 File Offset: 0x0023C4B4
		// (set) Token: 0x06003EA9 RID: 16041 RVA: 0x0023E2C8 File Offset: 0x0023C4C8
		public int Width
		{
			[CompilerGenerated]
			get
			{
				return this.<Width>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Width>k__BackingField = value;
			}
		}

		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x06003EAA RID: 16042 RVA: 0x0023E2DC File Offset: 0x0023C4DC
		// (set) Token: 0x06003EAB RID: 16043 RVA: 0x0023E2F0 File Offset: 0x0023C4F0
		public int Height
		{
			[CompilerGenerated]
			get
			{
				return this.<Height>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Height>k__BackingField = value;
			}
		}

		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x06003EAC RID: 16044 RVA: 0x0023E304 File Offset: 0x0023C504
		// (set) Token: 0x06003EAD RID: 16045 RVA: 0x0023E318 File Offset: 0x0023C518
		public float LightDecayThroughAir
		{
			get
			{
				/*
An exception occurred when decompiling this method (06003EAC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.Graphics.Light.LightMap::get_LightDecayThroughAir()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:valuetype Microsoft.Xna.Framework.Vector3[](var_0_06, ldfld:valuetype Microsoft.Xna.Framework.Vector3[](LightMap::_decayColors, ldloc:LightMap(this)))
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
				Vector3[] decayColors = this._decayColors;
			}
		}

		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x06003EAE RID: 16046 RVA: 0x0023E32C File Offset: 0x0023C52C
		// (set) Token: 0x06003EAF RID: 16047 RVA: 0x0023E340 File Offset: 0x0023C540
		public float LightDecayThroughSolid
		{
			get
			{
				/*
An exception occurred when decompiling this method (06003EAE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.Graphics.Light.LightMap::get_LightDecayThroughSolid()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:valuetype Microsoft.Xna.Framework.Vector3[](var_0_06, ldfld:valuetype Microsoft.Xna.Framework.Vector3[](LightMap::_decayColors, ldloc:LightMap(this)))
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
				Vector3[] decayColors = this._decayColors;
			}
		}

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x06003EB0 RID: 16048 RVA: 0x0023E354 File Offset: 0x0023C554
		// (set) Token: 0x06003EB1 RID: 16049 RVA: 0x0023E368 File Offset: 0x0023C568
		public Vector3 LightDecayThroughWater
		{
			get
			{
				return this._decayColors;
			}
			set
			{
				Vector3[] decayColors = this._decayColors;
			}
		}

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x06003EB2 RID: 16050 RVA: 0x0023E37C File Offset: 0x0023C57C
		// (set) Token: 0x06003EB3 RID: 16051 RVA: 0x0023E390 File Offset: 0x0023C590
		public Vector3 LightDecayThroughHoney
		{
			get
			{
				return this._decayColors;
			}
			set
			{
				Vector3[] decayColors = this._decayColors;
			}
		}

		// Token: 0x170007A0 RID: 1952
		public Vector3 this[int x, int y]
		{
			get
			{
				/*
An exception occurred when decompiling this method (06003EB4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Vector3 Terraria.Graphics.Light.LightMap::get_Item(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(LightMap::<Height>k__BackingField, ldloc:LightMap(this)))
	stloc:valuetype Microsoft.Xna.Framework.Vector3[](var_1_0D, ldfld:valuetype Microsoft.Xna.Framework.Vector3[](LightMap::_colors, ldloc:LightMap(this)))
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
				int num = this.<Height>k__BackingField;
				Vector3[] colors = this._colors;
			}
		}

		// Token: 0x06003EB6 RID: 16054 RVA: 0x0023E3DC File Offset: 0x0023C5DC
		public LightMap()
		{
			FastRandom fastRandom = FastRandom.CreateWithRandomSeed();
			this._random = fastRandom;
			if (!true)
			{
			}
			this._threadManager = 1;
			Vector3[] decayColors = this._decayColors;
			Vector3[] decayColors2 = this._decayColors;
			Vector3[] decayColors3 = this._decayColors;
		}

		// Token: 0x06003EB7 RID: 16055 RVA: 0x0023E420 File Offset: 0x0023C620
		public void GetLight(int x, int y, [Out] Vector3 color)
		{
			int num = this.<Height>k__BackingField;
			Vector3[] colors = this._colors;
			color.X = colors;
			color.Z = (float)num;
		}

		// Token: 0x06003EB8 RID: 16056 RVA: 0x0023E44C File Offset: 0x0023C64C
		public LightMaskMode GetMask(int x, int y)
		{
			/*
An exception occurred when decompiling this method (06003EB8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.Graphics.Light.LightMaskMode Terraria.Graphics.Light.LightMap::GetMask(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(LightMap::<Height>k__BackingField, ldloc:LightMap(this)))
	stloc:valuetype Terraria.Graphics.Light.LightMaskMode[](var_1_0D, ldfld:valuetype Terraria.Graphics.Light.LightMaskMode[](LightMap::_mask, ldloc:LightMap(this)))
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

		// Token: 0x06003EB9 RID: 16057 RVA: 0x0023E468 File Offset: 0x0023C668
		[Il2CppSetOption(Option.NullChecks, false)]
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		public void Clear()
		{
			Vector3[] colors = this._colors;
			LightMaskMode[] mask = this._mask;
		}

		// Token: 0x06003EBA RID: 16058 RVA: 0x0023E484 File Offset: 0x0023C684
		public void SetMaskAt(int x, int y, LightMaskMode mode)
		{
			int num = this.<Height>k__BackingField;
			LightMaskMode[] mask = this._mask;
		}

		// Token: 0x06003EBB RID: 16059 RVA: 0x0023E4A0 File Offset: 0x0023C6A0
		public void BlurPass1()
		{
			this.BlurPass();
		}

		// Token: 0x06003EBC RID: 16060 RVA: 0x0023E4B4 File Offset: 0x0023C6B4
		public void BlurPass2()
		{
			this.BlurPass();
		}

		// Token: 0x06003EBD RID: 16061 RVA: 0x0023E4C8 File Offset: 0x0023C6C8
		public void Blur()
		{
			this.BlurPass();
			this.BlurPass();
		}

		// Token: 0x06003EBE RID: 16062 RVA: 0x0023E4E4 File Offset: 0x0023C6E4
		private void ExportBatchFinished(int index)
		{
		}

		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x06003EBF RID: 16063 RVA: 0x0023E4F4 File Offset: 0x0023C6F4
		private ThreadedRenderManager.BatchProcessCallback ExportBatchFinishedCallback
		{
			get
			{
				/*
An exception occurred when decompiling this method (06003EBF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling ThreadedRenderManager/BatchProcessCallback Terraria.Graphics.Light.LightMap::get_ExportBatchFinishedCallback()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:BatchProcessCallback[exp:bool](LightMap::_processBatchFinishedCallback, ldloc:LightMap(this)))
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

		// Token: 0x06003EC0 RID: 16064 RVA: 0x0023E508 File Offset: 0x0023C708
		private void Blur1PassThreaded(int start, int end)
		{
			LightingEngine lightingEngine = this._threadManager.DrawThreads.lightingEngine;
			WallDrawing wallDrawing = this._threadManager.DrawThreads.wallDrawing;
			TileDrawing tileDrawing = this._threadManager.DrawThreads.tileDrawing;
			this.Blur1Pass(start, end);
			ThreadedRenderManager threadManager = this._threadManager;
			ThreadedRenderManager.BatchProcessCallback exportBatchFinishedCallback = this.ExportBatchFinishedCallback;
			int num = 3;
			threadManager.WaitAndProcess(exportBatchFinishedCallback, num);
		}

		// Token: 0x06003EC1 RID: 16065
		public unsafe static extern void Blur1PassNative(Vector3* colors, Vector3* decayData, LightMaskMode* maskData, int start, int end, int width, int height);

		// Token: 0x06003EC2 RID: 16066
		public unsafe static extern void Blur2PassNative(Vector3* colors, Vector3* decayData, LightMaskMode* maskData, int start, int end, int width, int height);

		// Token: 0x06003EC3 RID: 16067 RVA: 0x0023E56C File Offset: 0x0023C76C
		public void Blur1Pass(int start, int end)
		{
			if (this._colors != null)
			{
			}
			if (this._decayColors != null)
			{
				return;
			}
			if (this._mask != null)
			{
				return;
			}
			int num = this.<Width>k__BackingField;
		}

		// Token: 0x06003EC4 RID: 16068 RVA: 0x0023E59C File Offset: 0x0023C79C
		private void Blur2PassThreaded(int start, int end)
		{
			LightingEngine lightingEngine = this._threadManager.DrawThreads.lightingEngine;
			WallDrawing wallDrawing = this._threadManager.DrawThreads.wallDrawing;
			TileDrawing tileDrawing = this._threadManager.DrawThreads.tileDrawing;
			this.Blur2Pass(start, end);
			ThreadedRenderManager threadManager = this._threadManager;
			ThreadedRenderManager.BatchProcessCallback exportBatchFinishedCallback = this.ExportBatchFinishedCallback;
			int num = 3;
			threadManager.WaitAndProcess(exportBatchFinishedCallback, num);
		}

		// Token: 0x06003EC5 RID: 16069 RVA: 0x0023E600 File Offset: 0x0023C800
		public void Blur2Pass(int start, int end)
		{
			if (this._colors != null)
			{
			}
			if (this._decayColors != null)
			{
				return;
			}
			if (this._mask != null)
			{
				return;
			}
			int num = this.<Width>k__BackingField;
		}

		// Token: 0x06003EC6 RID: 16070 RVA: 0x0023E630 File Offset: 0x0023C830
		private void BlurPass()
		{
			int num = this.<Width>k__BackingField;
			if (!true)
			{
			}
			if (true)
			{
				long num2 = 0L;
				this.Blur1PassThreaded((int)num2, num);
				return;
			}
			long num3 = 0L;
			this.Blur1Pass((int)num3, num);
			int num4 = this.<Height>k__BackingField;
			if (!true)
			{
			}
			if (true)
			{
				long num5 = 0L;
				this.Blur2PassThreaded((int)num5, num);
				return;
			}
			long num6 = 0L;
			this.Blur2Pass((int)num6, num4);
		}

		// Token: 0x06003EC7 RID: 16071 RVA: 0x0023E688 File Offset: 0x0023C888
		public void ExecutePartialBlur(int pass)
		{
		}

		// Token: 0x06003EC8 RID: 16072 RVA: 0x0023E75C File Offset: 0x0023C95C
		[Il2CppSetOption(Option.NullChecks, false)]
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		private void BlurLine(int startIndex, int endIndex, int stride)
		{
			if (!true)
			{
			}
			int num = 1;
			if (num == 0)
			{
			}
			Vector3[] decayColors = this._decayColors;
			int value = num.m_value;
			Vector3[] colors = this._colors;
			if (decayColors != null)
			{
				return;
			}
			if (this._mask != null)
			{
				return;
			}
		}

		// Token: 0x06003EC9 RID: 16073 RVA: 0x0023E794 File Offset: 0x0023C994
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		[Il2CppSetOption(Option.NullChecks, false)]
		private void BlurLine2(int startIndex, int endIndex, int stride)
		{
			if (!true)
			{
			}
			int num = 1;
			if (num == 0)
			{
			}
			Vector3[] decayColors = this._decayColors;
			int value = num.m_value;
			Vector3[] colors = this._colors;
			if (decayColors != null)
			{
				return;
			}
			if (this._mask != null)
			{
				return;
			}
		}

		// Token: 0x06003ECA RID: 16074 RVA: 0x0023E7CC File Offset: 0x0023C9CC
		private int IndexOf(int x, int y)
		{
			/*
An exception occurred when decompiling this method (06003ECA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.Graphics.Light.LightMap::IndexOf(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(LightMap::<Height>k__BackingField, ldloc:LightMap(this)))
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

		// Token: 0x06003ECB RID: 16075 RVA: 0x0023E7E0 File Offset: 0x0023C9E0
		public void SetSize(int width, int height)
		{
			Vector3[] colors = this._colors;
			this.<Width>k__BackingField = width;
		}

		// Token: 0x04007D56 RID: 32086
		[CompilerGenerated]
		private int <NonVisiblePadding>k__BackingField;

		// Token: 0x04007D57 RID: 32087
		[CompilerGenerated]
		private int <Width>k__BackingField;

		// Token: 0x04007D58 RID: 32088
		[CompilerGenerated]
		private int <Height>k__BackingField;

		// Token: 0x04007D59 RID: 32089
		public Vector3[] _colors;

		// Token: 0x04007D5A RID: 32090
		public LightMaskMode[] _mask;

		// Token: 0x04007D5B RID: 32091
		private Vector3[] _decayColors;

		// Token: 0x04007D5C RID: 32092
		private FastRandom _random;

		// Token: 0x04007D5D RID: 32093
		private const int DEFAULT_WIDTH = 203;

		// Token: 0x04007D5E RID: 32094
		private const int DEFAULT_HEIGHT = 203;

		// Token: 0x04007D5F RID: 32095
		private ThreadedRenderManager.BatchProcessCallback _processBatchFinishedCallback;

		// Token: 0x04007D60 RID: 32096
		private ThreadedRenderManager _threadManager;
	}
}
