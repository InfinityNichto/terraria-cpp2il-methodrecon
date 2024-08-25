using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x02000374 RID: 884
	public class MaterialBuffer
	{
		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x0600170D RID: 5901 RVA: 0x0006478C File Offset: 0x0006298C
		private static Dictionary<int, MaterialBuffer.MaterialPartition> _availableMaterials
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600170D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.Dictionary`2<System.Int32,Microsoft.Xna.Framework.Graphics.MaterialBuffer/MaterialPartition> Microsoft.Xna.Framework.Graphics.MaterialBuffer::get__availableMaterials()

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

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x0600170E RID: 5902 RVA: 0x0006479C File Offset: 0x0006299C
		private static List<MaterialBuffer.MaterialEntry> _usedMaterialsDefault
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600170E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.List`1<Microsoft.Xna.Framework.Graphics.MaterialBuffer/MaterialEntry> Microsoft.Xna.Framework.Graphics.MaterialBuffer::get__usedMaterialsDefault()

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

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x0600170F RID: 5903 RVA: 0x000647AC File Offset: 0x000629AC
		// (set) Token: 0x06001710 RID: 5904 RVA: 0x000647BC File Offset: 0x000629BC
		private static List<MaterialBuffer.MaterialEntry> _usedMaterials
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600170F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.List`1<Microsoft.Xna.Framework.Graphics.MaterialBuffer/MaterialEntry> Microsoft.Xna.Framework.Graphics.MaterialBuffer::get__usedMaterials()

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
			set
			{
				if (!true)
				{
				}
			}
		}

		// Token: 0x06001711 RID: 5905 RVA: 0x000647CC File Offset: 0x000629CC
		public static void SetUsedMaterialList(List<MaterialBuffer.MaterialEntry> list)
		{
			if (true)
			{
				if (list != null)
				{
					return;
				}
			}
			else
			{
				while (list != null)
				{
				}
			}
			MaterialBuffer._usedMaterials = MaterialBuffer._usedMaterialsDefault;
		}

		// Token: 0x06001712 RID: 5906 RVA: 0x000021DB File Offset: 0x000003DB
		public static void DestroyMaterials()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001713 RID: 5907 RVA: 0x000021DB File Offset: 0x000003DB
		public static Material GetMaterial(EffectPass baseEffect, Texture2D t0, Texture2D t1, Texture2D t2, Texture2D t3)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001714 RID: 5908 RVA: 0x000021DB File Offset: 0x000003DB
		public static void ClearInstances()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001715 RID: 5909 RVA: 0x000647F0 File Offset: 0x000629F0
		public MaterialBuffer()
		{
		}

		// Token: 0x06001716 RID: 5910 RVA: 0x00064804 File Offset: 0x00062A04
		// Note: this type is marked as 'beforefieldinit'.
		static MaterialBuffer()
		{
			int num = Shader.PropertyToID("_MainTex");
			int num2 = Shader.PropertyToID("_MainAlphaTex");
			int num3 = Shader.PropertyToID("_MainPalTex");
			int num4 = Shader.PropertyToID("_palScaleSize");
			int num5 = Shader.PropertyToID("_SecondaryTex");
			int num6 = Shader.PropertyToID("_ThirdTex");
			int num7 = Shader.PropertyToID("_ForthTex");
			int num8 = Shader.PropertyToID("_TrimMin");
			int num9 = Shader.PropertyToID("_TrimMax");
		}

		// Token: 0x040025A9 RID: 9641
		private static int MainTexId;

		// Token: 0x040025AA RID: 9642
		private static int MainAlphaTexId;

		// Token: 0x040025AB RID: 9643
		private static int MainPalTexId;

		// Token: 0x040025AC RID: 9644
		private static int PalScaleSizeId;

		// Token: 0x040025AD RID: 9645
		public static int SecTexId;

		// Token: 0x040025AE RID: 9646
		private static int ThirdTexId;

		// Token: 0x040025AF RID: 9647
		private static int ForthTexId;

		// Token: 0x040025B0 RID: 9648
		private static int TrimMinId;

		// Token: 0x040025B1 RID: 9649
		private static int TrimMaxId;

		// Token: 0x02000375 RID: 885
		public class MaterialEntry
		{
			// Token: 0x06001717 RID: 5911 RVA: 0x0006487C File Offset: 0x00062A7C
			public MaterialEntry(MaterialBuffer.MaterialPartition materialPartition, List<MaterialBuffer.MaterialEntry> list, Texture2D t0, Texture2D t1, Texture2D t2, Texture2D t3)
			{
				if (!true)
				{
				}
				if (true)
				{
					Debug.Log("Created");
				}
				this.MaterialList = list;
				Shader shader = materialPartition.BaseMaterial.shader;
				this.Material = int.MinValue;
				if (t0 != null)
				{
					Texture unityBindTexture = t0.UnityBindTexture;
					return;
				}
				if (-2147483648 == 0)
				{
				}
				if (t1 != null)
				{
					Texture unityBindTexture2 = t1.UnityBindTexture;
					return;
				}
				if (-2147483648 == 0)
				{
				}
				if (t2 != null)
				{
					Texture unityBindTexture3 = t2.UnityBindTexture;
					return;
				}
				if (-2147483648 == 0)
				{
				}
				if (t3 != null)
				{
					Texture unityBindTexture4 = t3.UnityBindTexture;
					return;
				}
				if (t0 != null)
				{
					Texture2D unityPalTexture = t0._unityPalTexture;
					if (-2147483648 == 0)
					{
					}
					Texture2D unityAlphaTexture = t0._unityAlphaTexture;
					if (-2147483648 == 0)
					{
					}
					if ("_MAIN_USE_PAL_A8" == null)
					{
					}
					Texture2D unityAlphaTexture2 = t0._unityAlphaTexture;
					Texture2D unityPalTexture2 = t0._unityPalTexture;
					Texture2D unityPalTexture3 = t0._unityPalTexture;
					return;
				}
			}

			// Token: 0x06001718 RID: 5912 RVA: 0x000649A8 File Offset: 0x00062BA8
			public void SetupTrimming(Vector2 min, Vector2 max)
			{
				if (!true)
				{
				}
				if ("_USE_TRIMMING" == null)
				{
				}
			}

			// Token: 0x06001719 RID: 5913 RVA: 0x000649C0 File Offset: 0x00062BC0
			public void ClearTrimming()
			{
				if (this.useTrimming)
				{
					this.Material.DisableKeyword("_USE_TRIMMING");
					return;
				}
			}

			// Token: 0x0600171A RID: 5914 RVA: 0x000021DB File Offset: 0x000003DB
			public void Relase()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x040025B2 RID: 9650
			public readonly List<MaterialBuffer.MaterialEntry> MaterialList;

			// Token: 0x040025B3 RID: 9651
			public readonly Texture2D T0;

			// Token: 0x040025B4 RID: 9652
			public readonly Texture2D T1;

			// Token: 0x040025B5 RID: 9653
			public readonly Material Material;

			// Token: 0x040025B6 RID: 9654
			private bool useTrimming;
		}

		// Token: 0x02000376 RID: 886
		public class MaterialPartition : Dictionary<int, List<MaterialBuffer.MaterialEntry>>
		{
			// Token: 0x0600171B RID: 5915 RVA: 0x000649E8 File Offset: 0x00062BE8
			public MaterialPartition(Material baseMaterial)
			{
				if (!true)
				{
				}
				bool flag = baseMaterial.HasProperty(42207640);
				this.HasTexture2 = true;
				bool flag2 = this.BaseMaterial.HasProperty(42207640);
				bool flag3 = this.BaseMaterial.HasProperty(42207640);
			}

			// Token: 0x0600171C RID: 5916 RVA: 0x00064A34 File Offset: 0x00062C34
			public void DestroyMaterials()
			{
			}

			// Token: 0x0600171D RID: 5917 RVA: 0x00064A78 File Offset: 0x00062C78
			public MaterialBuffer.MaterialEntry GetMaterial(Texture2D t0, Texture2D t1, Texture2D t2, Texture2D t3)
			{
				/*
An exception occurred when decompiling this method (0600171D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.MaterialBuffer/MaterialEntry Microsoft.Xna.Framework.Graphics.MaterialBuffer/MaterialPartition::GetMaterial(Microsoft.Xna.Framework.Graphics.Texture2D,Microsoft.Xna.Framework.Graphics.Texture2D,Microsoft.Xna.Framework.Graphics.Texture2D,Microsoft.Xna.Framework.Graphics.Texture2D)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000A:
	stloc:bool(var_1_10, ldfld:bool(MaterialPartition::HasTexture2, ldloc:MaterialPartition(this)))
	stloc:bool(var_2_17, ldfld:bool(MaterialPartition::HasTexture3, ldloc:MaterialPartition(this)))
	stloc:bool(var_3_1E, ldfld:bool(MaterialPartition::HasTexture4, ldloc:MaterialPartition(this)))
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

			// Token: 0x040025B7 RID: 9655
			public readonly Material BaseMaterial = baseMaterial;

			// Token: 0x040025B8 RID: 9656
			public readonly bool HasTexture2;

			// Token: 0x040025B9 RID: 9657
			public readonly bool HasTexture3;

			// Token: 0x040025BA RID: 9658
			public readonly bool HasTexture4;
		}
	}
}
