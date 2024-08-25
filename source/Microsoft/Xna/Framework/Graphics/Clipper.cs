using System;
using System.Runtime.InteropServices;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x0200035B RID: 859
	public class Clipper
	{
		// Token: 0x06001654 RID: 5716 RVA: 0x00061E0C File Offset: 0x0006000C
		public Clipper(SpriteBatch owner)
		{
			this.clippingBatch = owner;
		}

		// Token: 0x06001655 RID: 5717 RVA: 0x00061E28 File Offset: 0x00060028
		public void SetClipState(bool horizonal, bool vertical)
		{
		}

		// Token: 0x06001656 RID: 5718 RVA: 0x00061E38 File Offset: 0x00060038
		public void SetClipRegionInner(int left, int right, int top, int bottom)
		{
			this.Left = left;
			this.Top = right;
			this.Top = top;
			this.OuterLeft = bottom;
		}

		// Token: 0x06001657 RID: 5719 RVA: 0x00061E64 File Offset: 0x00060064
		public void PushExpandedClippingRegion()
		{
			int left = this.Left;
			int right = this.Right;
			int fadeOuterLeft = this.FadeOuterLeft;
			this.Left = left;
			this.Right = right;
		}

		// Token: 0x06001658 RID: 5720 RVA: 0x00061E94 File Offset: 0x00060094
		public void PopExpandedClippingRegion()
		{
			int left = this.Left;
			int right = this.Right;
			int fadeOuterLeft = this.FadeOuterLeft;
			this.Left = left;
			this.Right = right;
		}

		// Token: 0x06001659 RID: 5721 RVA: 0x00061EC4 File Offset: 0x000600C4
		public void SetClipRegionOuter(int left, int right, int top, int bottom)
		{
			this.OuterLeft = left;
			this.OuterTop = right;
			this.FadeOuterLeft = left;
			this.FadeOuterTop = right;
			this.OuterTop = top;
			this.FadeOuterLeft = bottom;
			this.FadeOuterTop = top;
			this.clipVertical = bottom != 0;
		}

		// Token: 0x0600165A RID: 5722 RVA: 0x00061F0C File Offset: 0x0006010C
		public void SetClipRegionOuter(int left, int right, int top, int bottom, int fadeLeft, int fadeRight, int fadeTop, int fadeBottom)
		{
			this.OuterLeft = left;
			this.OuterTop = right;
			this.FadeOuterLeft = fadeLeft;
			this.FadeOuterTop = fadeRight;
			this.OuterTop = top;
			this.FadeOuterLeft = bottom;
			this.FadeOuterTop = fadeTop;
		}

		// Token: 0x0600165B RID: 5723 RVA: 0x00061F50 File Offset: 0x00060150
		public void SetGeometryScale(bool enable, Vector2 centre, float scale)
		{
		}

		// Token: 0x0600165C RID: 5724 RVA: 0x00061F60 File Offset: 0x00060160
		public void SetGeometryOffset(bool enable, Vector2 offset)
		{
		}

		// Token: 0x0600165D RID: 5725 RVA: 0x00061F70 File Offset: 0x00060170
		[Il2CppSetOption(Option.NullChecks, false)]
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		public void Offset(SpriteBatchItem item)
		{
			if (this.geometryOffsetEnabled)
			{
				float x = this.geometryOffset.X;
				Vector2 position = item.vertexTL.Position;
				item.vertexTL.Position = x;
				float y = this.geometryOffset.Y;
				float x2 = this.geometryOffset.X;
				Vector2 position2 = item.vertexTR.Position;
				item.vertexTR.Position = x2;
				float y2 = this.geometryOffset.Y;
				float x3 = this.geometryOffset.X;
				Vector2 position3 = item.vertexBR.Position;
				item.vertexBR.Position = x3;
				float y3 = this.geometryOffset.Y;
				float x4 = this.geometryOffset.X;
				Vector2 position4 = item.vertexBL.Position;
				item.vertexBL.Position = x4;
				float y4 = this.geometryOffset.Y;
			}
		}

		// Token: 0x0600165E RID: 5726 RVA: 0x00062054 File Offset: 0x00060254
		[Il2CppSetOption(Option.NullChecks, false)]
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		public void Clip(SpriteBatchItem item)
		{
			if (this.geometryScaleEnabled)
			{
				Vector2 position = item.vertexTL.Position;
				Vector2 position2 = item.vertexBL.Position;
				float num = this.geometryScale;
				item.vertexTL.Position = position;
			}
			float y = item.vertexTL.TextureCoordinate.y;
			Vector2 position3 = item.vertexTL.Position;
			float y2 = item.vertexTR.TextureCoordinate.y;
			float y3 = item.vertexBR.TextureCoordinate.y;
			float y4 = item.vertexBL.TextureCoordinate.y;
			float y5 = item.vertexTL.TextureCoordinate.y;
			Vector2 position4 = item.vertexTL.Position;
			float y6 = item.vertexTR.TextureCoordinate.y;
			float y7 = item.vertexBR.TextureCoordinate.y;
			float y8 = item.vertexBL.TextureCoordinate.y;
			int left = this.Left;
			int top = this.Top;
			int top2 = this.Top;
			int outerLeft = this.OuterLeft;
		}

		// Token: 0x0600165F RID: 5727 RVA: 0x00062274 File Offset: 0x00060474
		[Il2CppSetOption(Option.NullChecks, false)]
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		private void InjectBatches(SpriteBatchItem item, bool resuseItem, int outNumPoints, SpriteBatcher.VertexData[] output)
		{
			SpriteBatch spriteBatch = this.clippingBatch;
			Texture2D texture = item.Texture;
			SpriteBatchItem spriteBatchItem = spriteBatch.InsertNewBatchItem(texture);
		}

		// Token: 0x06001660 RID: 5728 RVA: 0x000622B8 File Offset: 0x000604B8
		[Il2CppSetOption(Option.NullChecks, false)]
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		private bool Clip(SpriteBatcher.VertexData p0, SpriteBatcher.VertexData p1, SpriteBatcher.VertexData p2, SpriteBatcher.VertexData p3, int clipLeft, int clipRight, int clipTop, int clipBottom, [Out] int numResultPoints, [Out] SpriteBatcher.VertexData[] result)
		{
			/*
An exception occurred when decompiling this method (06001660)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Microsoft.Xna.Framework.Graphics.Clipper::Clip(Microsoft.Xna.Framework.Graphics.SpriteBatcher/VertexData,Microsoft.Xna.Framework.Graphics.SpriteBatcher/VertexData,Microsoft.Xna.Framework.Graphics.SpriteBatcher/VertexData,Microsoft.Xna.Framework.Graphics.SpriteBatcher/VertexData,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,Microsoft.Xna.Framework.Graphics.SpriteBatcher/VertexData[])

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0327:
	stloc:int32(var_73_32D, ldfld:int32(Clipper::outputCount, ldloc:Clipper(this)))
	stloc:valuetype Microsoft.Xna.Framework.Graphics.SpriteBatcher/VertexData[](var_76_33C, ldfld:valuetype Microsoft.Xna.Framework.Graphics.SpriteBatcher/VertexData[](Clipper::input, ldloc:Clipper(this)))
	stloc:valuetype Microsoft.Xna.Framework.Graphics.SpriteBatcher/VertexData[](var_77_344, ldfld:valuetype Microsoft.Xna.Framework.Graphics.SpriteBatcher/VertexData[](Clipper::output, ldloc:Clipper(this)))
	stloc:int32(var_78_34C, ldfld:int32(Clipper::outputCount, ldloc:Clipper(this)))
	stfld:int32(Clipper::outputCount, ldloc:Clipper(this), ldloc:int32(var_78_34C))
	stloc:valuetype Microsoft.Xna.Framework.Graphics.SpriteBatcher/VertexData[](var_79_35C, ldfld:valuetype Microsoft.Xna.Framework.Graphics.SpriteBatcher/VertexData[](Clipper::input, ldloc:Clipper(this)))
	stloc:valuetype Microsoft.Xna.Framework.Graphics.SpriteBatcher/VertexData[](var_80_364, ldfld:valuetype Microsoft.Xna.Framework.Graphics.SpriteBatcher/VertexData[](Clipper::output, ldloc:Clipper(this)))
	stloc:int32(var_81_36C, ldfld:int32(Clipper::outputCount, ldloc:Clipper(this)))
	stfld:int32(Clipper::outputCount, ldloc:Clipper(this), ldloc:int32(var_78_34C))
	stloc:valuetype Microsoft.Xna.Framework.Graphics.SpriteBatcher/VertexData[](var_82_37C, ldfld:valuetype Microsoft.Xna.Framework.Graphics.SpriteBatcher/VertexData[](Clipper::input, ldloc:Clipper(this)))
	stloc:Color32(var_84_389, ldfld:Color32(VertexData::Color, ldloc:valuetype Microsoft.Xna.Framework.Graphics.SpriteBatcher/VertexData[][exp:valuetype Microsoft.Xna.Framework.Graphics.SpriteBatcher/VertexData&](var_82_37C)))
	stloc:valuetype Microsoft.Xna.Framework.Graphics.SpriteBatcher/VertexData[](var_85_391, ldfld:valuetype Microsoft.Xna.Framework.Graphics.SpriteBatcher/VertexData[](Clipper::output, ldloc:Clipper(this)))
	stloc:int32(var_86_399, ldfld:int32(Clipper::outputCount, ldloc:Clipper(this)))
	stfld:int32(Clipper::outputCount, ldloc:Clipper(this), ldloc:int32(var_78_34C))
	stfld:Vector2(VertexData::Position, ldloc:valuetype Microsoft.Xna.Framework.Graphics.SpriteBatcher/VertexData[][exp:valuetype Microsoft.Xna.Framework.Graphics.SpriteBatcher/VertexData&](var_46), ldloc:int32[exp:Vector2](var_78_34C))
	stloc:valuetype Microsoft.Xna.Framework.Graphics.SpriteBatcher/VertexData[](var_87_3B2, ldfld:valuetype Microsoft.Xna.Framework.Graphics.SpriteBatcher/VertexData[](Clipper::output, ldloc:Clipper(this)))
	stfld:int32(int32::m_value, ldloc:int32[exp:int32&](var_47), ldloc:valuetype Microsoft.Xna.Framework.Graphics.SpriteBatcher/VertexData[][exp:int32](var_87_3B2))
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

		// Token: 0x04002414 RID: 9236
		private SpriteBatch clippingBatch;

		// Token: 0x04002415 RID: 9237
		private SpriteBatcher.VertexData[] cache1;

		// Token: 0x04002416 RID: 9238
		private SpriteBatcher.VertexData[] cache2;

		// Token: 0x04002417 RID: 9239
		private int inputCount;

		// Token: 0x04002418 RID: 9240
		private int outputCount;

		// Token: 0x04002419 RID: 9241
		private SpriteBatcher.VertexData[] input;

		// Token: 0x0400241A RID: 9242
		private SpriteBatcher.VertexData[] output;

		// Token: 0x0400241B RID: 9243
		private int Left;

		// Token: 0x0400241C RID: 9244
		private int Right;

		// Token: 0x0400241D RID: 9245
		private int Top;

		// Token: 0x0400241E RID: 9246
		private int Bottom;

		// Token: 0x0400241F RID: 9247
		private int OuterLeft;

		// Token: 0x04002420 RID: 9248
		private int OuterRight;

		// Token: 0x04002421 RID: 9249
		private int OuterTop;

		// Token: 0x04002422 RID: 9250
		private int OuterBottom;

		// Token: 0x04002423 RID: 9251
		private int FadeOuterLeft;

		// Token: 0x04002424 RID: 9252
		private int FadeOuterRight;

		// Token: 0x04002425 RID: 9253
		private int FadeOuterTop;

		// Token: 0x04002426 RID: 9254
		private int FadeOuterBottom;

		// Token: 0x04002427 RID: 9255
		private bool clipVertical;

		// Token: 0x04002428 RID: 9256
		private bool clipHorizontal;

		// Token: 0x04002429 RID: 9257
		private bool geometryScaleEnabled;

		// Token: 0x0400242A RID: 9258
		private Vector2 geometryScaleCentre;

		// Token: 0x0400242B RID: 9259
		private float geometryScale;

		// Token: 0x0400242C RID: 9260
		private bool geometryOffsetEnabled;

		// Token: 0x0400242D RID: 9261
		private Vector2 geometryOffset;
	}
}
