using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2IlInjected;
using Terraria.Graphics;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x0200038C RID: 908
	public class SpriteBatch : GraphicsResource
	{
		// Token: 0x0600180B RID: 6155 RVA: 0x00066174 File Offset: 0x00064374
		public SpriteBatch(GraphicsDevice graphicsDevice)
		{
			this.graphicsDevice = graphicsDevice;
			SpriteEffect effect = SpriteEffect.Effect;
			this._spriteEffect = effect;
			EffectTechnique <CurrentTechnique>k__BackingField = effect.<CurrentTechnique>k__BackingField;
			long num = 0L;
			EffectPass effectPass = <CurrentTechnique>k__BackingField.<Passes>k__BackingField[(int)num];
			this._spritePass = effectPass;
		}

		// Token: 0x0600180C RID: 6156 RVA: 0x000661CC File Offset: 0x000643CC
		public void Begin(SpriteSortMode sortMode, bool useTransformMatrix, bool defferedBatch)
		{
			/*
An exception occurred when decompiling this method (0600180C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Microsoft.Xna.Framework.Graphics.SpriteBatch::Begin(Microsoft.Xna.Framework.Graphics.SpriteSortMode,System.Boolean,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0041:
	call:void(Debug::LogError, ldstr:string[exp:object]("End must be called before calling Begin."))
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

		// Token: 0x0600180D RID: 6157 RVA: 0x00066224 File Offset: 0x00064424
		public void Begin(SpriteSortMode sortMode = SpriteSortMode.Deferred, [Optional] BlendState blendState, [Optional] SamplerState samplerState, [Optional] DepthStencilState depthStencilState, [Optional] RasterizerState rasterizerState, [Optional] Effect effect, [Optional] Matrix? transformMatrix, bool defferedBatch = true)
		{
			/*
An exception occurred when decompiling this method (0600180D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Microsoft.Xna.Framework.Graphics.SpriteBatch::Begin(Microsoft.Xna.Framework.Graphics.SpriteSortMode,Microsoft.Xna.Framework.Graphics.BlendState,Microsoft.Xna.Framework.Graphics.SamplerState,Microsoft.Xna.Framework.Graphics.DepthStencilState,Microsoft.Xna.Framework.Graphics.RasterizerState,Microsoft.Xna.Framework.Graphics.Effect,System.Nullable`1<Microsoft.Xna.Framework.Matrix>,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_003E:
	call:void(Debug::LogError, ldstr:string[exp:object]("End must be called before calling Begin."))
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

		// Token: 0x0600180E RID: 6158 RVA: 0x00066278 File Offset: 0x00064478
		public void End()
		{
			if (!this._beginCalled)
			{
				Debug.LogError("Begin must be called before calling End.");
				return;
			}
			SpriteSortMode sortMode = this._sortMode;
			EffectPass spritePass = this._spritePass;
			SpriteSortMode sortMode2 = this._sortMode;
			bool batchDeffered = this.BatchDeffered;
			SpriteBatcher batcher = this._batcher;
			Effect effect = this._effect;
			bool hasMatrix = this._hasMatrix;
			if (!batchDeffered)
			{
				return;
			}
			SpriteBatchItemList firstBatchList = this._firstBatchList;
			if (firstBatchList != null)
			{
				SpriteBatchItem first = firstBatchList.First;
				return;
			}
		}

		// Token: 0x0600180F RID: 6159 RVA: 0x000662E8 File Offset: 0x000644E8
		public void Flush()
		{
			this._batcher.FlushBatches();
		}

		// Token: 0x06001810 RID: 6160 RVA: 0x00066300 File Offset: 0x00064500
		private void Setup()
		{
			EffectPass spritePass = this._spritePass;
		}

		// Token: 0x06001811 RID: 6161 RVA: 0x00066314 File Offset: 0x00064514
		private void CheckValid(Texture2D texture)
		{
			while (texture != null)
			{
				if (this._beginCalled)
				{
					return;
				}
			}
		}

		// Token: 0x06001812 RID: 6162 RVA: 0x00066330 File Offset: 0x00064530
		private void CheckValid(SpriteFont spriteFont, string text)
		{
			while (spriteFont != null)
			{
				if (text == null)
				{
					return;
				}
				if (this._beginCalled)
				{
					return;
				}
			}
		}

		// Token: 0x06001813 RID: 6163 RVA: 0x00066350 File Offset: 0x00064550
		private void CheckValid(SpriteFont spriteFont, StringBuilder text)
		{
			while (spriteFont != null)
			{
				if (text == null)
				{
					return;
				}
				if (this._beginCalled)
				{
					return;
				}
			}
		}

		// Token: 0x06001814 RID: 6164 RVA: 0x000021DB File Offset: 0x000003DB
		public void Draw(Texture2D texture, [Optional] Vector2? position, [Optional] Rectangle? destinationRectangle, [Optional] Rectangle? sourceRectangle, [Optional] Vector2? origin, float rotation = 0f, [Optional] Vector2? scale, [Optional] Color? color, SpriteEffects effects = SpriteEffects.None, float layerDepth = 0f)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001815 RID: 6165 RVA: 0x000021DB File Offset: 0x000003DB
		public void Draw(Texture2D texture, Vector2? position, Rectangle? destinationRectangle, Rectangle? sourceRectangle, Vector2? origin, float rotation, Vector2? scale, VertexColors color, SpriteEffects effects = SpriteEffects.None, float layerDepth = 0f)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001816 RID: 6166 RVA: 0x00066370 File Offset: 0x00064570
		[Il2CppSetOption(Option.NullChecks, false)]
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		public SpriteBatchItem InsertNewBatchItem(Texture2D texture)
		{
			do
			{
				Texture2D texture2 = this._batcher._batchItemList.Texture;
				SpriteBatcher batcher = this._batcher;
				SpriteBatchItem[] batchItemList = batcher._batchItemList;
				GraphicsDevice device = batcher._device;
				SpriteBatchItem[] batchItemList2 = batcher._batchItemList;
				EffectPass overloadedEffectPass = this.OverloadedEffectPass;
				if (overloadedEffectPass != null)
				{
					int batchIndex = overloadedEffectPass.BatchIndex;
				}
				int batchTextureIndex = texture.BatchTextureIndex;
				if (this.BatchDeffered)
				{
					int lastBatchListId = batcher._lastBatchListId;
					SpriteBatchItemList lastBatchList = batcher._lastBatchList;
				}
				SpriteBatchItem lastBatchItem = this._lastBatchItem;
				if (lastBatchItem != null)
				{
				}
				SpriteBatchItem nextBatchItem = lastBatchItem.NextBatchItem;
				SpriteBatcher batcher2 = this._batcher;
				SpriteBatcher batcher3 = this._batcher;
				Dictionary<int, SpriteBatchItemList> activeBatchLists = batcher3._activeBatchLists;
				this._batcher._lastBatchList = batcher3;
				if (batcher3._batchItemList != null)
				{
					int batchItemCount = batcher3._batchItemCount;
				}
				if (this.BatchDefferedHeadInsert)
				{
					SpriteBatchItemList firstBatchList = this._firstBatchList;
					if (firstBatchList != null)
					{
						SpriteBatchItem first = firstBatchList.First;
					}
					if (this._lastBatchList == null)
					{
						this._lastBatchList = batcher3;
					}
					this._firstBatchList = batcher3;
				}
				if (texture.SharedBatching)
				{
					SpriteBatchItemList lastBatchList2 = this._lastBatchList;
					if (lastBatchList2 != null)
					{
						SpriteBatchItem last = lastBatchList2.Last;
					}
					if (this._firstBatchList == null)
					{
						this._firstBatchList = batcher3;
					}
					this._lastBatchList = batcher3;
				}
			}
			while (texture.NonSharedHeadInsert);
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06001817 RID: 6167 RVA: 0x000664A8 File Offset: 0x000646A8
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		[Il2CppSetOption(Option.NullChecks, false)]
		public void Draw(Texture2D texture, Vector2 position, Rectangle srcRect, Color color, float rotation, Vector2 origin, float scale, SpriteEffects effects = SpriteEffects.None)
		{
			SpriteBatchItem spriteBatchItem = this.InsertNewBatchItem(texture);
			float texelWidth = texture.TexelWidth;
			float texelHeight = texture.TexelHeight;
			int width = srcRect.Width;
			int y = srcRect.Y;
			this._texCoordBR.X = texelWidth;
			this._texCoordBR.Y = texelHeight;
			this._texCoordTL.Y = texelHeight;
			float x = position.X;
			float y2 = position.Y;
		}

		// Token: 0x06001818 RID: 6168 RVA: 0x0006653C File Offset: 0x0006473C
		[Il2CppSetOption(Option.NullChecks, false)]
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		public void Draw(Texture2D texture, Vector2 position, Rectangle srcRect, Color color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects = SpriteEffects.None)
		{
			SpriteBatchItem spriteBatchItem = this.InsertNewBatchItem(texture);
			int width = srcRect.Width;
			int y = srcRect.Y;
			float x = position.X;
			float y2 = position.Y;
		}

		// Token: 0x06001819 RID: 6169 RVA: 0x0006659C File Offset: 0x0006479C
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		[Il2CppSetOption(Option.NullChecks, false)]
		public void Draw(Texture2D texture, Vector2 position, Rectangle srcRect, Color color, float rotation, Vector2 origin, float scale)
		{
			SpriteBatchItem spriteBatchItem = this.InsertNewBatchItem(texture);
			int width = srcRect.Width;
			float texelWidth = texture.TexelWidth;
			srcRect.X = (int)texelWidth;
			float x = position.X;
			float y = position.Y;
		}

		// Token: 0x0600181A RID: 6170 RVA: 0x00066600 File Offset: 0x00064800
		public void Draw(Texture2D texture, Vector2 position, Color color, float rotation, Vector2 origin, float scale)
		{
			SpriteBatchItem spriteBatchItem = this.InsertNewBatchItem(texture);
			int width = texture.Width;
			int height = texture.Height;
			if (!true)
			{
			}
			if (!true)
			{
			}
			float x = position.X;
			float y = position.Y;
		}

		// Token: 0x0600181B RID: 6171 RVA: 0x00066668 File Offset: 0x00064868
		public void Draw(Texture2D texture, Vector2 position, Rectangle? sourceRectangle, Color color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects, float layerDepth)
		{
			SpriteBatchItem spriteBatchItem = this.InsertNewBatchItem(texture);
			float texelWidth = texture.TexelWidth;
			float texelHeight = texture.TexelHeight;
			this._texCoordBR.X = texelWidth;
			this._texCoordBR.Y = texelHeight;
			float y = this._texCoordTL.Y;
			Vector2 texCoordTL = this._texCoordTL;
			this._texCoordBR = texCoordTL;
		}

		// Token: 0x0600181C RID: 6172 RVA: 0x00066720 File Offset: 0x00064920
		public void Draw(Texture2D texture, Vector2 position, Rectangle srcRect, Color color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects, float layerDepth)
		{
			SpriteBatchItem spriteBatchItem = this.InsertNewBatchItem(texture);
			float texelWidth = texture.TexelWidth;
			float texelHeight = texture.TexelHeight;
			float y = position.Y;
			this._texCoordBR.X = texelWidth;
			this._texCoordBR.Y = texelHeight;
			this._texCoordTL.Y = texelHeight;
			position.X = texelWidth;
		}

		// Token: 0x0600181D RID: 6173 RVA: 0x000667A0 File Offset: 0x000649A0
		public void Draw(Texture2D texture, Vector2 position, Rectangle? sourceRectangle, VertexColors color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects, float layerDepth)
		{
			SpriteBatchItem spriteBatchItem = this.InsertNewBatchItem(texture);
			float y = position.Y;
			float texelWidth = texture.TexelWidth;
			float texelHeight = texture.TexelHeight;
			this._texCoordBR.X = texelWidth;
			this._texCoordBR.Y = texelHeight;
			float y2 = this._texCoordTL.Y;
			this._texCoordBR.Y = y2;
			Vector2 texCoordTL = this._texCoordTL;
			this._texCoordTL = y;
			this._texCoordBR = texCoordTL;
		}

		// Token: 0x0600181E RID: 6174 RVA: 0x00066874 File Offset: 0x00064A74
		public void Draw(Texture2D texture, Vector2 position, Rectangle srcRect, VertexColors color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects, float layerDepth)
		{
			SpriteBatchItem spriteBatchItem = this.InsertNewBatchItem(texture);
			float texelWidth = texture.TexelWidth;
			float texelHeight = texture.TexelHeight;
			float y = position.Y;
			this._texCoordBR.X = texelWidth;
			this._texCoordBR.Y = texelHeight;
			this._texCoordTL.Y = texelHeight;
		}

		// Token: 0x0600181F RID: 6175 RVA: 0x000668F0 File Offset: 0x00064AF0
		public void Draw(Texture2D texture, Vector2 position, Rectangle srcRect, VertexColors color, float rotation, Vector2 origin, float scale, SpriteEffects effects, float layerDepth)
		{
			SpriteBatchItem spriteBatchItem = this.InsertNewBatchItem(texture);
			float texelWidth = texture.TexelWidth;
			float texelHeight = texture.TexelHeight;
			float y = position.Y;
			this._texCoordBR.X = texelWidth;
			this._texCoordBR.Y = texelHeight;
			this._texCoordTL.Y = texelHeight;
		}

		// Token: 0x06001820 RID: 6176 RVA: 0x0006696C File Offset: 0x00064B6C
		public static void ForceDrawScale(float scale, Vector2 origin, Vector2 position)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001821 RID: 6177 RVA: 0x0006697C File Offset: 0x00064B7C
		public static void ClearDrawScale()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001822 RID: 6178 RVA: 0x0006698C File Offset: 0x00064B8C
		public static void TransformPosition(Vector2 position, Vector2 scale)
		{
			float x = position.X;
			float y = position.Y;
			if (!true)
			{
			}
			float x2 = scale.X;
			float y2 = scale.Y;
			scale.X = x2;
			scale.Y = y2;
		}

		// Token: 0x06001823 RID: 6179 RVA: 0x000669D8 File Offset: 0x00064BD8
		public void Draw(Texture2D texture, Vector2 position, Rectangle? sourceRectangle, Color color, float rotation, Vector2 origin, float scale, SpriteEffects effects, float layerDepth = 0f)
		{
		}

		// Token: 0x06001824 RID: 6180 RVA: 0x000669E8 File Offset: 0x00064BE8
		public void Draw(Texture2D texture, Vector2 position, Rectangle srcRect, Color color)
		{
			SpriteBatchItem spriteBatchItem = this.InsertNewBatchItem(texture);
			int width = srcRect.Width;
			int height = srcRect.Height;
			float texelWidth = texture.TexelWidth;
			float x = position.X;
			float y = position.Y;
			SpriteSortMode sortMode = this._sortMode;
			if (this.BatchDeffered)
			{
				return;
			}
			SpriteBatcher batcher = this._batcher;
			Effect effect = this._effect;
			batcher.DrawImmediateBatch(effect);
		}

		// Token: 0x06001825 RID: 6181 RVA: 0x00066A4C File Offset: 0x00064C4C
		public void Draw(Texture2D texture, Vector2 position, Rectangle srcRect, VertexColors color)
		{
			SpriteBatchItem spriteBatchItem = this.InsertNewBatchItem(texture);
			int width = srcRect.Width;
			int height = srcRect.Height;
			float texelWidth = texture.TexelWidth;
			float x = position.X;
			float y = position.Y;
			SpriteSortMode sortMode = this._sortMode;
			if (this.BatchDeffered)
			{
				return;
			}
			SpriteBatcher batcher = this._batcher;
			Effect effect = this._effect;
			batcher.DrawImmediateBatch(effect);
		}

		// Token: 0x06001826 RID: 6182 RVA: 0x00066AB0 File Offset: 0x00064CB0
		public void Draw(Texture2D texture, Vector2 position, Rectangle srcRect, Color color, SpriteEffects effects)
		{
			SpriteBatchItem spriteBatchItem = this.InsertNewBatchItem(texture);
			int width = srcRect.Width;
			int height = srcRect.Height;
			float texelWidth = texture.TexelWidth;
			float texelHeight = texture.TexelHeight;
			this._texCoordBR.X = texelWidth;
			this._texCoordTL.X = (float)width;
			int y = srcRect.Y;
			this._texCoordBR.Y = texelWidth;
			this._texCoordTL.Y = (float)y;
			float x = position.X;
			float y2 = position.Y;
			SpriteSortMode sortMode = this._sortMode;
			if (this.BatchDeffered)
			{
				return;
			}
			SpriteBatcher batcher = this._batcher;
			Effect effect = this._effect;
			batcher.DrawImmediateBatch(effect);
		}

		// Token: 0x06001827 RID: 6183 RVA: 0x00066B58 File Offset: 0x00064D58
		public void Draw(Texture2D texture, Vector2 position, Rectangle srcRect, VertexColors color, SpriteEffects effects)
		{
			SpriteBatchItem spriteBatchItem = this.InsertNewBatchItem(texture);
			int width = srcRect.Width;
			int height = srcRect.Height;
			float texelWidth = texture.TexelWidth;
			float texelHeight = texture.TexelHeight;
			this._texCoordBR.X = texelWidth;
			this._texCoordTL.X = (float)width;
			int y = srcRect.Y;
			this._texCoordBR.Y = texelWidth;
			this._texCoordTL.Y = (float)y;
			float x = position.X;
			float y2 = position.Y;
			SpriteSortMode sortMode = this._sortMode;
			if (this.BatchDeffered)
			{
				return;
			}
			SpriteBatcher batcher = this._batcher;
			Effect effect = this._effect;
			batcher.DrawImmediateBatch(effect);
		}

		// Token: 0x06001828 RID: 6184 RVA: 0x00066C00 File Offset: 0x00064E00
		public void Draw(Texture2D texture, Vector2 position, Rectangle srcRect, Color color, float rotation, Vector2 origin, float scale, SpriteEffects effects, float layerDepth = 0f)
		{
			SpriteBatchItem spriteBatchItem = this.InsertNewBatchItem(texture);
			float texelWidth = texture.TexelWidth;
			float texelHeight = texture.TexelHeight;
			float y = position.Y;
			this._texCoordBR.X = texelWidth;
			this._texCoordBR.Y = texelHeight;
			this._texCoordTL.Y = texelHeight;
			position.X = texelWidth;
		}

		// Token: 0x06001829 RID: 6185 RVA: 0x00066C80 File Offset: 0x00064E80
		public void Draw(Texture2D texture, Vector2 position, Rectangle? sourceRectangle, VertexColors color, float rotation, Vector2 origin, float scale, SpriteEffects effects, float layerDepth = 0f)
		{
		}

		// Token: 0x0600182A RID: 6186 RVA: 0x00066C90 File Offset: 0x00064E90
		public void Draw(Texture2D texture, Rectangle destinationRectangle, Rectangle? sourceRectangle, Color color, float rotation, Vector2 origin, SpriteEffects effects, float layerDepth)
		{
			SpriteBatchItem spriteBatchItem = this.InsertNewBatchItem(texture);
			float texelWidth = texture.TexelWidth;
			float texelHeight = texture.TexelHeight;
		}

		// Token: 0x0600182B RID: 6187 RVA: 0x00066D2C File Offset: 0x00064F2C
		public void Draw(Texture2D texture, Rectangle destinationRectangle, Rectangle? sourceRectangle, VertexColors color, float rotation, Vector2 origin, SpriteEffects effects, float layerDepth)
		{
			SpriteBatchItem spriteBatchItem = this.InsertNewBatchItem(texture);
			Color topRightColor = color.TopRightColor;
			Color bottomRightColor = color.BottomRightColor;
			float texelWidth = texture.TexelWidth;
			Color bottomRightColor2 = color.BottomRightColor;
			float texelHeight = texture.TexelHeight;
			if (bottomRightColor2 != null)
			{
				return;
			}
			float y = this._texCoordTL.Y;
			this._texCoordTL.Y = bottomRightColor;
			this._texCoordBR.Y = y;
			Vector2 texCoordTL = this._texCoordTL;
			int num;
			this._texCoordTL = num;
			this._texCoordBR = texCoordTL;
		}

		// Token: 0x0600182C RID: 6188 RVA: 0x00066E0C File Offset: 0x0006500C
		internal void FlushIfNeeded()
		{
			SpriteSortMode sortMode = this._sortMode;
			if (this.BatchDeffered)
			{
				return;
			}
			SpriteBatcher batcher = this._batcher;
			Effect effect = this._effect;
			batcher.DrawImmediateBatch(effect);
		}

		// Token: 0x0600182D RID: 6189 RVA: 0x00066E40 File Offset: 0x00065040
		public void Draw(Texture2D texture, Vector2 position, Rectangle? sourceRectangle, Color color)
		{
			SpriteBatchItem spriteBatchItem = this.InsertNewBatchItem(texture);
			float y = position.Y;
			float texelWidth = texture.TexelWidth;
		}

		// Token: 0x0600182E RID: 6190 RVA: 0x00066EA4 File Offset: 0x000650A4
		public void Draw(Texture2D texture, Vector2 position, Rectangle? sourceRectangle, VertexColors color)
		{
			SpriteBatchItem spriteBatchItem = this.InsertNewBatchItem(texture);
			float y = position.Y;
			float texelWidth = texture.TexelWidth;
		}

		// Token: 0x0600182F RID: 6191 RVA: 0x00066F08 File Offset: 0x00065108
		public void Draw(Texture2D texture, Rectangle destinationRectangle, Rectangle? sourceRectangle, Color color)
		{
			SpriteBatchItem spriteBatchItem = this.InsertNewBatchItem(texture);
			float texelWidth = texture.TexelWidth;
		}

		// Token: 0x06001830 RID: 6192 RVA: 0x00066F54 File Offset: 0x00065154
		public void Draw(Texture2D texture, Vector2 position, Color color)
		{
			SpriteBatchItem spriteBatchItem = this.InsertNewBatchItem(texture);
			if (!true)
			{
			}
			if (!true)
			{
			}
			int width = texture.Width;
			int height = texture.Height;
			SpriteSortMode sortMode = this._sortMode;
			if (!this.BatchDeffered)
			{
				SpriteBatcher batcher = this._batcher;
				Effect effect = this._effect;
				batcher.DrawImmediateBatch(effect);
			}
		}

		// Token: 0x06001831 RID: 6193 RVA: 0x00066FA8 File Offset: 0x000651A8
		public void Draw(Texture2D texture, Rectangle destinationRectangle, Color color)
		{
			SpriteBatchItem spriteBatchItem = this.InsertNewBatchItem(texture);
			if (!true)
			{
			}
			if (!true)
			{
			}
			SpriteSortMode sortMode = this._sortMode;
			if (!this.BatchDeffered)
			{
				SpriteBatcher batcher = this._batcher;
				Effect effect = this._effect;
				batcher.DrawImmediateBatch(effect);
			}
		}

		// Token: 0x06001832 RID: 6194 RVA: 0x00066FE8 File Offset: 0x000651E8
		public void DrawString(SpriteFont spriteFont, string text, Vector2 position, Color color)
		{
			this.CheckValid(spriteFont, text);
			SpriteFont.Glyph[] glyphs = spriteFont._glyphs;
			if (glyphs != null && glyphs.Cropping.Y != 0)
			{
				return;
			}
			int stringLength = text._stringLength;
			long num = 0L;
			char c = text[(int)num];
			int <LineSpacing>k__BackingField = spriteFont.<LineSpacing>k__BackingField;
		}

		// Token: 0x06001833 RID: 6195 RVA: 0x00067094 File Offset: 0x00065294
		public void DrawString(SpriteFont spriteFont, StringBuilder text, Vector2 position, Color color)
		{
			this.CheckValid(spriteFont, text);
			if (this._lastViewport.y == 0)
			{
			}
			int num = 1;
			if (num == 0)
			{
			}
			int value = num.m_value;
			SpriteFont.Glyph[] glyphs = spriteFont._glyphs;
			if (glyphs != null && glyphs.Cropping.Y != 0)
			{
				return;
			}
			int length = text.Length;
			long num2 = 0L;
			char c = text[(int)num2];
			int <LineSpacing>k__BackingField = spriteFont.<LineSpacing>k__BackingField;
		}

		// Token: 0x06001834 RID: 6196 RVA: 0x00067180 File Offset: 0x00065380
		public void DrawString(SpriteFont spriteFont, string text, Vector2 position, Color color, float rotation, Vector2 origin, float scale, SpriteEffects effects, float layerDepth)
		{
		}

		// Token: 0x06001835 RID: 6197 RVA: 0x00067190 File Offset: 0x00065390
		public void DrawString(SpriteFont spriteFont, StringBuilder text, Vector2 position, Color color, float rotation, Vector2 origin, float scale, SpriteEffects effects, float layerDepth)
		{
		}

		// Token: 0x06001836 RID: 6198 RVA: 0x000671A0 File Offset: 0x000653A0
		public void DrawString(SpriteFont spriteFont, string text, Vector2 position, Color color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects, float layerDepth)
		{
			int num = 1;
			this.CheckValid(spriteFont, text);
			if (num == 0)
			{
			}
			int num2 = 1;
			if (num2 == 0)
			{
			}
			int value = num2.m_value;
			if (num2 != 0)
			{
				int <LineSpacing>k__BackingField = spriteFont.<LineSpacing>k__BackingField;
			}
			if (num2 == 0)
			{
			}
			int num3 = 1;
			if (num3 == 0)
			{
			}
			int value2 = num3.m_value;
		}

		// Token: 0x06001837 RID: 6199 RVA: 0x000672AC File Offset: 0x000654AC
		public void DrawStringMultiLineRight(SpriteFont spriteFont, string text, Vector2 position, Color color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects, float layerDepth)
		{
			int num = 1;
			this.CheckValid(spriteFont, text);
			if (num == 0)
			{
			}
			int num2 = 1;
			if (num2 == 0)
			{
			}
			int value = num2.m_value;
			if (num2 != 0)
			{
				if (color != null)
				{
				}
				int <LineSpacing>k__BackingField = spriteFont.<LineSpacing>k__BackingField;
			}
			int num3 = 1;
			if (num3 == 0)
			{
			}
			int value2 = num3.m_value;
		}

		// Token: 0x06001838 RID: 6200 RVA: 0x00067448 File Offset: 0x00065648
		public void DrawStringMultiLineCentre(SpriteFont spriteFont, string text, Vector2 position, Color color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects, float layerDepth)
		{
			int num = 1;
			this.CheckValid(spriteFont, text);
			if (num == 0)
			{
			}
			int num2 = 1;
			if (num2 == 0)
			{
			}
			int value = num2.m_value;
			if (num2 != 0)
			{
				if (color != null)
				{
				}
				int <LineSpacing>k__BackingField = spriteFont.<LineSpacing>k__BackingField;
			}
			if (num2 == 0)
			{
			}
			int num3 = 1;
			if (num3 == 0)
			{
			}
			int value2 = num3.m_value;
		}

		// Token: 0x06001839 RID: 6201 RVA: 0x000675D0 File Offset: 0x000657D0
		public void DrawString(SpriteFont spriteFont, StringBuilder text, Vector2 position, Color color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects, float layerDepth)
		{
			int num = 1;
			this.CheckValid(spriteFont, text);
			if (num == 0)
			{
			}
			int num2 = 1;
			if (num2 == 0)
			{
			}
			int value = num2.m_value;
			if (num2 != 0)
			{
				int <LineSpacing>k__BackingField = spriteFont.<LineSpacing>k__BackingField;
			}
			if (num2 == 0)
			{
			}
			int num3 = 1;
			if (num3 == 0)
			{
			}
			int value2 = num3.m_value;
		}

		// Token: 0x0600183A RID: 6202 RVA: 0x000676B8 File Offset: 0x000658B8
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		[Il2CppSetOption(Option.NullChecks, false)]
		public void DrawString(SpriteFont spriteFont, string text, int start, int end, Vector2 position, Color color, float rotation, Vector2 origin, Vector2 scale, Vector2[] offsets)
		{
			int num = 1;
			this.CheckValid(spriteFont, text);
			if (num == 0)
			{
			}
			int num2 = 1;
			if (num2 == 0)
			{
			}
			int value = num2.m_value;
		}

		// Token: 0x0600183B RID: 6203 RVA: 0x0006774C File Offset: 0x0006594C
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		[Il2CppSetOption(Option.NullChecks, false)]
		public void DrawString(SpriteFont spriteFont, StringBuilder text, int start, int end, Vector2 position, Color color, float rotation, Vector2 origin, Vector2 scale, Vector2[] offsets)
		{
			int num = 1;
			this.CheckValid(spriteFont, text);
			if (num == 0)
			{
			}
			int num2 = 1;
			if (num2 == 0)
			{
			}
			int value = num2.m_value;
			if (text.m_ChunkChars != null)
			{
				return;
			}
		}

		// Token: 0x0600183C RID: 6204 RVA: 0x00067810 File Offset: 0x00065A10
		public void DrawString(SpriteFont spriteFont, string text, int start, int end, Vector2 position, Color color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects, float layerDepth)
		{
			int num = 1;
			this.CheckValid(spriteFont, text);
			if (num == 0)
			{
			}
			int num2 = 1;
			if (num2 == 0)
			{
			}
			int value = num2.m_value;
			if (num2 != 0)
			{
				int <LineSpacing>k__BackingField = spriteFont.<LineSpacing>k__BackingField;
			}
			if (num2 == 0)
			{
			}
			int num3 = 1;
			if (num3 == 0)
			{
			}
			int value2 = num3.m_value;
		}

		// Token: 0x0600183D RID: 6205 RVA: 0x00067938 File Offset: 0x00065B38
		public void DrawString(SpriteFont spriteFont, StringBuilder text, int start, int end, Vector2 position, Color color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects, float layerDepth)
		{
			int num = 1;
			this.CheckValid(spriteFont, text);
			if (num == 0)
			{
			}
			int num2 = 1;
			if (num2 == 0)
			{
			}
			int value = num2.m_value;
			if (num2 != 0)
			{
				int <LineSpacing>k__BackingField = spriteFont.<LineSpacing>k__BackingField;
			}
			if (num2 == 0)
			{
			}
			int num3 = 1;
			if (num3 == 0)
			{
			}
			int value2 = num3.m_value;
		}

		// Token: 0x0600183E RID: 6206 RVA: 0x00067A6C File Offset: 0x00065C6C
		// Note: this type is marked as 'beforefieldinit'.
		static SpriteBatch()
		{
			if (!true)
			{
			}
		}

		// Token: 0x0400264D RID: 9805
		public bool BatchDeffered;

		// Token: 0x0400264E RID: 9806
		public bool BatchDefferedHeadInsert;

		// Token: 0x0400264F RID: 9807
		private readonly SpriteBatcher _batcher;

		// Token: 0x04002650 RID: 9808
		private SpriteSortMode _sortMode;

		// Token: 0x04002651 RID: 9809
		private BlendState _blendState;

		// Token: 0x04002652 RID: 9810
		private DepthStencilState _depthStencilState;

		// Token: 0x04002653 RID: 9811
		private RasterizerState _rasterizerState;

		// Token: 0x04002654 RID: 9812
		private Effect _effect;

		// Token: 0x04002655 RID: 9813
		public bool _beginCalled;

		// Token: 0x04002656 RID: 9814
		private int _batchOffset;

		// Token: 0x04002657 RID: 9815
		private SpriteBatchItem _lastBatchItem;

		// Token: 0x04002658 RID: 9816
		private SpriteBatchItemList _firstBatchList;

		// Token: 0x04002659 RID: 9817
		private SpriteBatchItemList _lastBatchList;

		// Token: 0x0400265A RID: 9818
		private Effect _spriteEffect;

		// Token: 0x0400265B RID: 9819
		private readonly EffectPass _spritePass;

		// Token: 0x0400265C RID: 9820
		private Matrix _renderMatrix;

		// Token: 0x0400265D RID: 9821
		private bool _hasMatrix;

		// Token: 0x0400265E RID: 9822
		private Viewport _lastViewport;

		// Token: 0x0400265F RID: 9823
		private Matrix _projection;

		// Token: 0x04002660 RID: 9824
		private Rectangle _tempRect;

		// Token: 0x04002661 RID: 9825
		private Vector2 _texCoordTL;

		// Token: 0x04002662 RID: 9826
		private Vector2 _texCoordBR;

		// Token: 0x04002663 RID: 9827
		internal static bool NeedsHalfPixelOffset;

		// Token: 0x04002664 RID: 9828
		public static string LastBeginCall;

		// Token: 0x04002665 RID: 9829
		public EffectPass OverloadedEffectPass;

		// Token: 0x04002666 RID: 9830
		public static bool forceDrawScale;

		// Token: 0x04002667 RID: 9831
		public static Vector2 forcedDrawScale;

		// Token: 0x04002668 RID: 9832
		public static Vector2 forcedDrawOrigin;

		// Token: 0x04002669 RID: 9833
		public static Vector2 forcedDrawPosition;

		// Token: 0x0400266A RID: 9834
		private static List<float> rightLineLengths;

		// Token: 0x0400266B RID: 9835
		private static List<int> rightLineOffsets;

		// Token: 0x0400266C RID: 9836
		private static List<SpriteBatchItem> rightLineElements;
	}
}
