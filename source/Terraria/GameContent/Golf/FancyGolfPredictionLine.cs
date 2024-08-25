using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;
using Terraria.Graphics;

namespace Terraria.GameContent.Golf
{
	// Token: 0x02000A07 RID: 2567
	public class FancyGolfPredictionLine
	{
		// Token: 0x06004BC5 RID: 19397 RVA: 0x002701AC File Offset: 0x0026E3AC
		public FancyGolfPredictionLine(int iterations)
		{
			this._iterations = iterations;
		}

		// Token: 0x06004BC6 RID: 19398 RVA: 0x000021DB File Offset: 0x000003DB
		public void Update(Entity golfBall, Vector2 impactVelocity, float roughLandResistance)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06004BC7 RID: 19399 RVA: 0x002701C8 File Offset: 0x0026E3C8
		public void Draw(Camera camera, SpriteBatch spriteBatch, float chargeProgress)
		{
			BasicDebugDrawer drawer = this._drawer;
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			Vector2 unscaledPosition = camera.UnscaledPosition;
			int size = this._positions._size;
			long num2 = 0L;
			this.GetSectionLength((int)num2, chargeProgress, chargeProgress);
			Vector2 position = this.GetPosition(chargeProgress);
			Color color = this.GetColor2(chargeProgress);
			int size2 = this._positions._size;
			float num3 = MathHelper.Clamp(chargeProgress, chargeProgress, chargeProgress);
			if (size2 == 0)
			{
			}
			float scale = this.GetScale(chargeProgress);
			int size3 = this._positions._size;
			this._drawer.End();
		}

		// Token: 0x06004BC8 RID: 19400 RVA: 0x00270268 File Offset: 0x0026E468
		private Color GetColor(float travelledLength)
		{
			/*
An exception occurred when decompiling this method (06004BC8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.Color Terraria.GameContent.Golf.FancyGolfPredictionLine::GetColor(System.Single)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0039:
	stloc:Color(var_8_41, call:Color(Color::op_Multiply, ldloc:Color(var_7), ldloc:float32(travelledLength)))
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

		// Token: 0x06004BC9 RID: 19401 RVA: 0x002702B8 File Offset: 0x0026E4B8
		private Color GetColor2(float index)
		{
			/*
An exception occurred when decompiling this method (06004BC9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.Color Terraria.GameContent.Golf.FancyGolfPredictionLine::GetColor2(System.Single)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0016:
	stloc:Color(var_3_1D, call:Color(Color::op_Multiply, ldloc:Color(var_2), ldloc:float32(index)))
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

		// Token: 0x06004BCA RID: 19402 RVA: 0x002702E4 File Offset: 0x0026E4E4
		private float GetScale(float travelledLength)
		{
			float time = this._time;
			if (16968 == 0)
			{
			}
			return float.Epsilon;
		}

		// Token: 0x06004BCB RID: 19403 RVA: 0x00270304 File Offset: 0x0026E504
		private void GetSectionLength(int startIndex, [Out] float length, [Out] float rotation)
		{
			int size = this._positions._size;
			List<Vector2> positions = this._positions;
			if (size == 0)
			{
			}
			List<Vector2> positions2 = this._positions;
			List<Vector2> positions3 = this._positions;
			if (size == 0)
			{
			}
		}

		// Token: 0x06004BCC RID: 19404 RVA: 0x00270344 File Offset: 0x0026E544
		private Vector2 GetPosition(float indexProgress)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int size = this._positions._size;
			List<Vector2> positions = this._positions;
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x04008605 RID: 34309
		private readonly List<Vector2> _positions;

		// Token: 0x04008606 RID: 34310
		private readonly Entity _entity;

		// Token: 0x04008607 RID: 34311
		private readonly int _iterations;

		// Token: 0x04008608 RID: 34312
		private readonly Color[] _colors;

		// Token: 0x04008609 RID: 34313
		private readonly BasicDebugDrawer _drawer;

		// Token: 0x0400860A RID: 34314
		private float _time;

		// Token: 0x02000A08 RID: 2568
		private class PredictionEntity : Entity
		{
			// Token: 0x06004BCD RID: 19405 RVA: 0x00270370 File Offset: 0x0026E570
			public PredictionEntity()
			{
			}
		}
	}
}
