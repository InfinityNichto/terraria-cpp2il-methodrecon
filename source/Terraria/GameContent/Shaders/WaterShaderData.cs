using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Graphics;
using Terraria.Graphics.Shaders;

namespace Terraria.GameContent.Shaders
{
	// Token: 0x02000826 RID: 2086
	public class WaterShaderData : ScreenShaderData
	{
		// Token: 0x14000054 RID: 84
		// (add) Token: 0x060042C0 RID: 17088 RVA: 0x0024C3F8 File Offset: 0x0024A5F8
		// (remove) Token: 0x060042C1 RID: 17089 RVA: 0x0024C420 File Offset: 0x0024A620
		public event Action<TileBatch> OnWaveDraw
		{
			[CompilerGenerated]
			add
			{
				Delegate @delegate = Delegate.Combine(this.OnWaveDraw, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = Delegate.Remove(this.OnWaveDraw, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
		}

		// Token: 0x060042C2 RID: 17090 RVA: 0x0024C448 File Offset: 0x0024A648
		public WaterShaderData(string passName)
		{
			int num = 1;
			this._useViscosityFilter = num != 0;
			if (num == 0)
			{
			}
			if (!true)
			{
			}
			long num2 = 16843009L;
			this._useProjectileWaves = num2 != 0L;
			this._useCustomWaves = num2 != 0L;
			int num3 = 1;
			this._isWaveBufferDirty = num3 != 0;
			base..ctor(passName);
			if (num3 == 0)
			{
			}
		}

		// Token: 0x060042C3 RID: 17091 RVA: 0x0024C498 File Offset: 0x0024A698
		public override void Update(GameTime gameTime)
		{
			if ("Only TraceListeners can be added to a TraceListenerCollection." == null)
			{
			}
			int waveQuality = Main.WaveQuality;
		}

		// Token: 0x060042C4 RID: 17092 RVA: 0x0024C5A4 File Offset: 0x0024A7A4
		private void StepLiquids()
		{
			int num = 1;
			this._isWaveBufferDirty = num != 0;
			if (num == 0)
			{
			}
			Vector2 screenPosition = Main.screenPosition;
			DistortionRenderTargetManager instance = DistortionRenderTargetManager.Instance;
			bool clearNextFrame = this._clearNextFrame;
			bool clearNextFrame2 = this._clearNextFrame;
			if (clearNextFrame2)
			{
			}
			this.DrawWaves();
			DistortionRenderTargetManager.Instance.EndRenderTarget();
			DistortionRenderTargetManager.Instance.SwapTargets();
			DistortionRenderTargetManager instance2 = DistortionRenderTargetManager.Instance;
			if (!clearNextFrame2)
			{
			}
			if (!clearNextFrame2)
			{
			}
			if (!clearNextFrame2)
			{
			}
			float x = this._lastDistortionDrawOffset.X;
			float y = this._lastDistortionDrawOffset.Y;
			DistortionRenderTargetManager instance3 = DistortionRenderTargetManager.Instance;
			Texture2D gameDistortionTargetSwap = instance3.GameDistortionTargetSwap;
			IntPtr cachedPtr = instance3.m_CachedPtr;
			if (!true)
			{
			}
			int width = gameDistortionTargetSwap.Width;
			int height = gameDistortionTargetSwap.Height;
			DistortionRenderTargetManager.Instance.EndRenderTarget();
		}

		// Token: 0x060042C5 RID: 17093 RVA: 0x0024C678 File Offset: 0x0024A878
		private void DrawWaves()
		{
			int num = 1;
			if (num == 0)
			{
			}
			Vector2 screenPosition = Main.screenPosition;
			if (num == 0)
			{
			}
			int num2 = 1;
			if (num2 == 0)
			{
			}
			float x = this._lastDistortionDrawOffset.X;
			float y = this._lastDistortionDrawOffset.Y;
			int value = num2.m_value;
			int screenWidth = Main.screenWidth;
			int screenHeight = Main.screenHeight;
			if (!true)
			{
			}
			float num6;
			if (this._useNPCWaves)
			{
				Vector2 vector;
				float num3 = vector.LengthSquared();
				Vector2 vector2;
				float num4 = vector2.Length();
				vector2.Normalize();
				vector2.Normalize();
				bool useViscosityFilter = this._useViscosityFilter;
				if (useViscosityFilter || useViscosityFilter || useViscosityFilter)
				{
				}
				if (useViscosityFilter)
				{
					if (!useViscosityFilter)
					{
					}
				}
				float num5 = MathHelper.Clamp(num6, num6, num4);
			}
			if (this._usePlayerWaves)
			{
				bool useViscosityFilter2 = this._useViscosityFilter;
				if (useViscosityFilter2 || useViscosityFilter2 || useViscosityFilter2)
				{
				}
				if (useViscosityFilter2)
				{
					if (!useViscosityFilter2)
					{
					}
				}
				float num7 = MathHelper.Clamp(num6, num6, num6);
			}
			if (this._useProjectileWaves)
			{
				return;
			}
			if (this._useRippleWaves)
			{
				int rippleQueueCount = this._rippleQueueCount;
				WaterShaderData.Ripple[] rippleQueue = this._rippleQueue;
				WaterShaderData.Ripple[] rippleQueue2 = this._rippleQueue;
				if (this._rippleShapeTexture == null)
				{
				}
				WaterShaderData.Ripple[] rippleQueue3 = this._rippleQueue;
				WaterShaderData.Ripple[] rippleQueue4 = this._rippleQueue;
			}
			if (this._useCustomWaves && this.OnWaveDraw != null)
			{
				Action<TileBatch> onWaveDraw = this.OnWaveDraw;
			}
		}

		// Token: 0x060042C6 RID: 17094 RVA: 0x0024C870 File Offset: 0x0024AA70
		private void PreDraw(GameTime gameTime)
		{
			this.ValidateRenderTargets();
			if (this._usingRenderTargets)
			{
				bool isGraphicsDeviceAvailable = Main.IsGraphicsDeviceAvailable;
				bool usePlayerWaves;
				if (!this._useProjectileWaves && !this._useRippleWaves && !this._useCustomWaves)
				{
					usePlayerWaves = this._usePlayerWaves;
					if (!usePlayerWaves)
					{
						if (this._isWaveBufferDirty || this._clearNextFrame)
						{
							DistortionRenderTargetManager.Instance.ClearRenderTarget();
							return;
						}
						return;
					}
				}
				int queuedSteps = this._queuedSteps;
				if (!usePlayerWaves)
				{
				}
				int num = 1;
				int num2 = Math.Min(queuedSteps, num);
				this.StepLiquids();
				return;
			}
		}

		// Token: 0x060042C7 RID: 17095 RVA: 0x0024C8F4 File Offset: 0x0024AAF4
		public override void Apply()
		{
			bool usingRenderTargets = this._usingRenderTargets;
			if (usingRenderTargets)
			{
				if (!usingRenderTargets)
				{
				}
				bool isGraphicsDeviceAvailable = Main.IsGraphicsDeviceAvailable;
				float progress = this._progress;
				if (!usingRenderTargets)
				{
				}
				int screenWidth = Main.screenWidth;
				int screenHeight = Main.screenHeight;
				if (!usingRenderTargets)
				{
				}
				if (true)
				{
					return;
				}
				if (!true)
				{
				}
				Texture2D gameDistortionTarget = DistortionRenderTargetManager.Instance.GameDistortionTarget;
				if (gameDistortionTarget != null)
				{
					Vector2 screenPosition = Main.screenPosition;
					Texture2D gameRenderTarget = WaterRenderTargetManager.Instance.GameRenderTarget;
					Vector2 screenPosition2 = Main.screenPosition;
					float x = this._lastDistortionDrawOffset.X;
					float y = this._lastDistortionDrawOffset.Y;
					int width = gameDistortionTarget.Width;
					int height = gameDistortionTarget.Height;
				}
				base.Apply();
			}
		}

		// Token: 0x060042C8 RID: 17096 RVA: 0x0024C9D0 File Offset: 0x0024ABD0
		private void ValidateRenderTargets()
		{
			if (!true)
			{
			}
			GraphicsDevice graphicsDevice;
			int backBufferWidth = graphicsDevice.<PresentationParameters>k__BackingField.backBufferWidth;
			GraphicsDevice graphicsDevice2;
			PresentationParameters <PresentationParameters>k__BackingField = graphicsDevice2.<PresentationParameters>k__BackingField;
			int backBufferHeight = <PresentationParameters>k__BackingField.backBufferHeight;
			int waveQuality = Main.WaveQuality;
			if (this._usingRenderTargets)
			{
				return;
			}
			this._lastScreenWidth = backBufferWidth;
			this._useProjectileWaves = backBufferHeight != 0;
			this._usingRenderTargets = true;
			this._clearNextFrame = true;
		}

		// Token: 0x060042C9 RID: 17097 RVA: 0x0024CA2C File Offset: 0x0024AC2C
		private void InitRenderTargets(int width, int height)
		{
			this._lastScreenWidth = width;
			this._useProjectileWaves = height != 0;
			this._usingRenderTargets = true;
			this._clearNextFrame = true;
		}

		// Token: 0x060042CA RID: 17098 RVA: 0x0024CA58 File Offset: 0x0024AC58
		private void ReleaseRenderTargets()
		{
		}

		// Token: 0x060042CB RID: 17099 RVA: 0x0024CA68 File Offset: 0x0024AC68
		public void QueueRipple(Vector2 position, float strength = 1f, RippleShape shape = RippleShape.Square, float rotation = 0f)
		{
			if (!true)
			{
			}
			float num = Math.Min(strength, rotation);
			if (!true)
			{
			}
			float num2 = Math.Max(num, rotation);
		}

		// Token: 0x060042CC RID: 17100 RVA: 0x0024CA94 File Offset: 0x0024AC94
		public void QueueRipple(Vector2 position, float strength, Vector2 size, RippleShape shape = RippleShape.Square, float rotation = 0f)
		{
			if (!true)
			{
			}
			float num = Math.Min(strength, rotation);
			if (!true)
			{
			}
		}

		// Token: 0x060042CD RID: 17101 RVA: 0x0024CAB4 File Offset: 0x0024ACB4
		public void QueueRipple(Vector2 position, Color waveData, Vector2 size, RippleShape shape = RippleShape.Square, float rotation = 0f)
		{
			if (this._useRippleWaves)
			{
				float rotation2 = this._rippleQueue.Rotation;
				this._rippleQueueCount = (int)rotation2;
				return;
			}
		}

		// Token: 0x040080FB RID: 33019
		public const float DISTORTION_BUFFER_SCALE = 0.25f;

		// Token: 0x040080FC RID: 33020
		private const float WAVE_FRAMERATE = 0.016666668f;

		// Token: 0x040080FD RID: 33021
		private const int MAX_RIPPLES_QUEUED = 200;

		// Token: 0x040080FE RID: 33022
		[CompilerGenerated]
		private Action<TileBatch> OnWaveDraw;

		// Token: 0x040080FF RID: 33023
		public bool _useViscosityFilter;

		// Token: 0x04008100 RID: 33024
		private bool _usingRenderTargets;

		// Token: 0x04008101 RID: 33025
		private Vector2 _lastDistortionDrawOffset;

		// Token: 0x04008102 RID: 33026
		private float _progress;

		// Token: 0x04008103 RID: 33027
		private WaterShaderData.Ripple[] _rippleQueue;

		// Token: 0x04008104 RID: 33028
		private int _rippleQueueCount;

		// Token: 0x04008105 RID: 33029
		private int _lastScreenWidth;

		// Token: 0x04008106 RID: 33030
		private int _lastScreenHeight;

		// Token: 0x04008107 RID: 33031
		public bool _useProjectileWaves;

		// Token: 0x04008108 RID: 33032
		private bool _useNPCWaves;

		// Token: 0x04008109 RID: 33033
		private bool _usePlayerWaves;

		// Token: 0x0400810A RID: 33034
		private bool _useRippleWaves;

		// Token: 0x0400810B RID: 33035
		private bool _useCustomWaves;

		// Token: 0x0400810C RID: 33036
		private bool _clearNextFrame;

		// Token: 0x0400810D RID: 33037
		private Texture2D[] _viscosityMaskChain;

		// Token: 0x0400810E RID: 33038
		private int _activeViscosityMask;

		// Token: 0x0400810F RID: 33039
		private Asset<Texture2D> _rippleShapeTexture;

		// Token: 0x04008110 RID: 33040
		private bool _isWaveBufferDirty;

		// Token: 0x04008111 RID: 33041
		private int _queuedSteps;

		// Token: 0x04008112 RID: 33042
		private const int MAX_QUEUED_STEPS = 1;

		// Token: 0x02000827 RID: 2087
		private struct Ripple
		{
			// Token: 0x170007C4 RID: 1988
			// (get) Token: 0x060042CE RID: 17102 RVA: 0x0024CAE0 File Offset: 0x0024ACE0
			public Rectangle SourceRectangle
			{
				get
				{
					/*
An exception occurred when decompiling this method (060042CE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Rectangle Terraria.GameContent.Shaders.WaterShaderData/Ripple::get_SourceRectangle()

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

			// Token: 0x060042CF RID: 17103 RVA: 0x0024CAF0 File Offset: 0x0024ACF0
			public Ripple(Vector2 position, Color waveData, Vector2 size, RippleShape shape, float rotation)
			{
				this.WaveData = position;
				this.Shape = waveData;
			}

			// Token: 0x060042D0 RID: 17104 RVA: 0x0024CB0C File Offset: 0x0024AD0C
			// Note: this type is marked as 'beforefieldinit'.
			static Ripple()
			{
			}

			// Token: 0x04008113 RID: 33043
			private static readonly Rectangle[] RIPPLE_SHAPE_SOURCE_RECTS;

			// Token: 0x04008114 RID: 33044
			public readonly Vector2 Position;

			// Token: 0x04008115 RID: 33045
			public readonly Color WaveData;

			// Token: 0x04008116 RID: 33046
			public readonly Vector2 Size;

			// Token: 0x04008117 RID: 33047
			public readonly RippleShape Shape;

			// Token: 0x04008118 RID: 33048
			public readonly float Rotation;
		}
	}
}
