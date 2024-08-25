using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace Terraria.Graphics
{
	// Token: 0x02000738 RID: 1848
	public struct FinalFractalHelper
	{
		// Token: 0x06003D14 RID: 15636 RVA: 0x002384BC File Offset: 0x002366BC
		public static int GetRandomProfileIndex()
		{
			/*
An exception occurred when decompiling this method (06003D14)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.Graphics.FinalFractalHelper::GetRandomProfileIndex()

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

		// Token: 0x06003D15 RID: 15637 RVA: 0x002384CC File Offset: 0x002366CC
		public void Draw(Projectile proj)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			int num = 32768;
			FinalFractalHelper.FinalFractalProfile finalFractalProfile = FinalFractalHelper.GetFinalFractalProfile(-1073741824);
			if (num == 0)
			{
			}
			string text2;
			string text = "Images/Extra_" + text2;
		}

		// Token: 0x06003D16 RID: 15638 RVA: 0x00238594 File Offset: 0x00236794
		public static FinalFractalHelper.FinalFractalProfile GetFinalFractalProfile(int usedSwordId)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06003D17 RID: 15639 RVA: 0x002385A8 File Offset: 0x002367A8
		private Color StripColors(float progressOnStrip)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x06003D18 RID: 15640 RVA: 0x000021DB File Offset: 0x000003DB
		private float StripWidth(float progressOnStrip)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003D19 RID: 15641 RVA: 0x002385BC File Offset: 0x002367BC
		// Note: this type is marked as 'beforefieldinit'.
		static FinalFractalHelper()
		{
			if (16960 == 0)
			{
			}
		}

		// Token: 0x04007C09 RID: 31753
		public const int TotalIllusions = 4;

		// Token: 0x04007C0A RID: 31754
		public const int FramesPerImportantTrail = 15;

		// Token: 0x04007C0B RID: 31755
		private static VertexStrip _vertexStrip;

		// Token: 0x04007C0C RID: 31756
		private static Dictionary<int, FinalFractalHelper.FinalFractalProfile> _fractalProfiles;

		// Token: 0x04007C0D RID: 31757
		private static FinalFractalHelper.FinalFractalProfile _defaultProfile;

		// Token: 0x04007C0E RID: 31758
		private Asset<Texture2D> FinalFractalAsset;

		// Token: 0x04007C0F RID: 31759
		private Asset<Texture2D> MagicMissileTrailErosionAsset;

		// Token: 0x02000739 RID: 1849
		public sealed class SpawnDustMethod : MulticastDelegate
		{
			// Token: 0x06003D1A RID: 15642 RVA: 0x002385D4 File Offset: 0x002367D4
			public SpawnDustMethod(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x06003D1B RID: 15643 RVA: 0x00238628 File Offset: 0x00236828
			public void Invoke(Vector2 centerPosition, float rotation, Vector2 velocity)
			{
				IntPtr method_code = this.method_code;
				IntPtr invoke_impl = this.invoke_impl;
				IntPtr method = this.method;
			}

			// Token: 0x06003D1C RID: 15644 RVA: 0x000021DB File Offset: 0x000003DB
			public IAsyncResult BeginInvoke(Vector2 centerPosition, float rotation, Vector2 velocity, AsyncCallback callback, object @object)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06003D1D RID: 15645 RVA: 0x0023864C File Offset: 0x0023684C
			public void EndInvoke(IAsyncResult result)
			{
			}
		}

		// Token: 0x0200073A RID: 1850
		public struct FinalFractalProfile
		{
			// Token: 0x06003D1E RID: 15646 RVA: 0x0023865C File Offset: 0x0023685C
			public FinalFractalProfile(float fullBladeLength, Color color)
			{
				this.trailColor = color;
				float num = this.trailWidth;
				byte a = this.trailColor.A;
				float num2 = this.trailWidth;
				byte a2 = this.trailColor.A;
				float num3 = this.trailWidth;
				byte a3 = this.trailColor.A;
			}

			// Token: 0x06003D1F RID: 15647 RVA: 0x002386AC File Offset: 0x002368AC
			private void StripDust(Vector2 centerPosition, float rotation, Vector2 velocity)
			{
				if (!true)
				{
				}
				int num;
				if (num == 0)
				{
					if (!true)
					{
					}
					byte a = this.trailColor.A;
					Dust dust;
					dust.scale = (float)52429;
					float x = dust.velocity.X;
					float y = dust.velocity.Y;
					dust.noGravity = true;
					float num2;
					Vector2 vector = num2.ToRotationVector2();
				}
			}

			// Token: 0x06003D20 RID: 15648 RVA: 0x00238710 File Offset: 0x00236910
			private void StripColors(float progressOnStrip, [Out] Color col)
			{
				Color color = this.trailColor;
				if (!true)
				{
				}
				float num;
				Color color2 = color * num;
				col.A = color2;
			}

			// Token: 0x06003D21 RID: 15649 RVA: 0x000021DB File Offset: 0x000003DB
			private float StripWidth(float progressOnStrip)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x04007C10 RID: 31760
			public float trailWidth;

			// Token: 0x04007C11 RID: 31761
			public Color trailColor;

			// Token: 0x04007C12 RID: 31762
			public FinalFractalHelper.SpawnDustMethod dustMethod;

			// Token: 0x04007C13 RID: 31763
			public VertexStrip.StripColorFunction colorMethod;

			// Token: 0x04007C14 RID: 31764
			public VertexStrip.StripHalfWidthFunction widthMethod;
		}
	}
}
