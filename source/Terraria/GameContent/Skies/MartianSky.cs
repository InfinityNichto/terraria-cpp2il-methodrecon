using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Graphics.Effects;
using Terraria.Utilities;

namespace Terraria.GameContent.Skies
{
	// Token: 0x020009D0 RID: 2512
	public class MartianSky : CustomSky
	{
		// Token: 0x06004A10 RID: 18960 RVA: 0x00264F08 File Offset: 0x00263108
		public override void Update(GameTime gameTime)
		{
			if (!true)
			{
			}
			MartianSky.Ufo[] ufos = this._ufos;
			int activeUfos = this._activeUfos;
			if (this._leaving)
			{
				return;
			}
			MartianSky.Ufo[] ufos2 = this._ufos;
			MartianSky.Ufo[] ufos3 = this._ufos;
			if (this._leaving)
			{
				return;
			}
			int maxUfos = this._maxUfos;
			bool leaving = this._leaving;
			this._active = leaving;
			this._activeUfos = activeUfos;
		}

		// Token: 0x06004A11 RID: 18961 RVA: 0x00264F6C File Offset: 0x0026316C
		public override void Draw(SpriteBatch spriteBatch, float minDepth, float maxDepth)
		{
			if (!true)
			{
			}
			Vector2 screenPosition = Main.screenPosition;
			Texture2D glowTexture = this._ufos.GlowTexture;
		}

		// Token: 0x06004A12 RID: 18962 RVA: 0x00265040 File Offset: 0x00263240
		private void GenerateUfos()
		{
			if (!true)
			{
			}
			int num = 32768;
			int maxUfos = this._maxUfos;
			if (num == 0)
			{
			}
			Texture2D glowTexture = this._ufos.GlowTexture;
			if (glowTexture == null)
			{
			}
			float texelWidth = glowTexture.TexelWidth;
			MartianSky.Ufo[] ufos = this._ufos;
		}

		// Token: 0x06004A13 RID: 18963 RVA: 0x00265090 File Offset: 0x00263290
		public override void Activate(Vector2 position, params object[] args)
		{
			this.GenerateUfos();
			MartianSky.Ufo[] ufos = this._ufos;
			if (!true)
			{
			}
			if (!true)
			{
			}
			this._active = true;
		}

		// Token: 0x06004A14 RID: 18964 RVA: 0x002650B8 File Offset: 0x002632B8
		public override void Deactivate(params object[] args)
		{
			this._leaving = true;
		}

		// Token: 0x06004A15 RID: 18965 RVA: 0x002650CC File Offset: 0x002632CC
		public override bool IsActive()
		{
			return this._active;
		}

		// Token: 0x06004A16 RID: 18966 RVA: 0x002650E0 File Offset: 0x002632E0
		public override void Reset()
		{
		}

		// Token: 0x06004A17 RID: 18967 RVA: 0x002650F0 File Offset: 0x002632F0
		public MartianSky()
		{
		}

		// Token: 0x040084B7 RID: 33975
		private MartianSky.Ufo[] _ufos;

		// Token: 0x040084B8 RID: 33976
		private UnifiedRandom _random;

		// Token: 0x040084B9 RID: 33977
		private int _maxUfos;

		// Token: 0x040084BA RID: 33978
		private bool _active;

		// Token: 0x040084BB RID: 33979
		private bool _leaving;

		// Token: 0x040084BC RID: 33980
		private int _activeUfos;

		// Token: 0x020009D1 RID: 2513
		private abstract class IUfoController
		{
			// Token: 0x06004A18 RID: 18968
			public abstract void InitializeUfo(MartianSky.Ufo ufo);

			// Token: 0x06004A19 RID: 18969
			public abstract bool Update(MartianSky.Ufo ufo);

			// Token: 0x06004A1A RID: 18970 RVA: 0x00265104 File Offset: 0x00263304
			protected IUfoController()
			{
			}
		}

		// Token: 0x020009D2 RID: 2514
		private class ZipBehavior : MartianSky.IUfoController
		{
			// Token: 0x06004A1B RID: 18971 RVA: 0x000021DB File Offset: 0x000003DB
			public override void InitializeUfo(MartianSky.Ufo ufo)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06004A1C RID: 18972 RVA: 0x00265118 File Offset: 0x00263318
			public override bool Update(MartianSky.Ufo ufo)
			{
				/*
An exception occurred when decompiling this method (06004A1C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.Skies.MartianSky/ZipBehavior::Update(Terraria.GameContent.Skies.MartianSky/Ufo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(ZipBehavior::_ticks, ldloc:ZipBehavior(this)))
	stloc:int32(var_1_0D, ldfld:int32(ZipBehavior::_maxTicks, ldloc:ZipBehavior(this)))
	stloc:float32(var_2_14, ldfld:float32(Ufo::Opacity, ldloc:Ufo[exp:valuetype Terraria.GameContent.Skies.MartianSky/Ufo&](ufo)))
	stloc:float32(var_3_20, ldfld:float32(Vector2::X, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](Ufo::Position, ldloc:Ufo[exp:valuetype Terraria.GameContent.Skies.MartianSky/Ufo&](ufo))))
	stloc:float32(var_4_2C, ldfld:float32(Vector2::Y, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](Ufo::Position, ldloc:Ufo[exp:valuetype Terraria.GameContent.Skies.MartianSky/Ufo&](ufo))))
	stloc:float32(var_5_39, ldfld:float32(Vector2::X, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](ZipBehavior::_speed, ldloc:ZipBehavior(this))))
	stloc:float32(var_6_46, ldfld:float32(Vector2::Y, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](ZipBehavior::_speed, ldloc:ZipBehavior(this))))
	stfld:float32(Vector2::Y, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](Ufo::Position, ldloc:Ufo[exp:valuetype Terraria.GameContent.Skies.MartianSky/Ufo&](ufo)), ldloc:float32(var_2_14))
	stloc:int32(var_9_5D, ldfld:int32(ZipBehavior::_ticks, ldloc:ZipBehavior(this)))
	stfld:int32(ZipBehavior::_ticks, ldloc:ZipBehavior(this), ldloc:int32(var_9_5D))
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

			// Token: 0x06004A1D RID: 18973 RVA: 0x00265194 File Offset: 0x00263394
			public ZipBehavior()
			{
			}

			// Token: 0x040084BD RID: 33981
			private Vector2 _speed;

			// Token: 0x040084BE RID: 33982
			private int _ticks;

			// Token: 0x040084BF RID: 33983
			private int _maxTicks;
		}

		// Token: 0x020009D3 RID: 2515
		private class HoverBehavior : MartianSky.IUfoController
		{
			// Token: 0x06004A1E RID: 18974 RVA: 0x002651A8 File Offset: 0x002633A8
			public override void InitializeUfo(MartianSky.Ufo ufo)
			{
				if (!true)
				{
				}
				if (!true)
				{
				}
				int num;
				this._maxTicks = num;
			}

			// Token: 0x06004A1F RID: 18975 RVA: 0x002651C4 File Offset: 0x002633C4
			public override bool Update(MartianSky.Ufo ufo)
			{
				/*
An exception occurred when decompiling this method (06004A1F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.Skies.MartianSky/HoverBehavior::Update(Terraria.GameContent.Skies.MartianSky/Ufo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(HoverBehavior::_ticks, ldloc:HoverBehavior(this)))
	stloc:float32(var_1_0D, ldfld:float32(Ufo::Opacity, ldloc:Ufo[exp:valuetype Terraria.GameContent.Skies.MartianSky/Ufo&](ufo)))
	stfld:float32(Ufo::Opacity, ldloc:Ufo[exp:valuetype Terraria.GameContent.Skies.MartianSky/Ufo&](ufo), ldloc:float32(var_1_0D))
	stloc:int32(var_2_1B, ldfld:int32(HoverBehavior::_maxTicks, ldloc:HoverBehavior(this)))
	stloc:int32(var_3_22, ldfld:int32(HoverBehavior::_maxTicks, ldloc:HoverBehavior(this)))
	stloc:float32(var_4_29, ldfld:float32(Ufo::Opacity, ldloc:Ufo[exp:valuetype Terraria.GameContent.Skies.MartianSky/Ufo&](ufo)))
	stfld:float32(Ufo::Opacity, ldloc:Ufo[exp:valuetype Terraria.GameContent.Skies.MartianSky/Ufo&](ufo), ldloc:float32(var_4_29))
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

			// Token: 0x06004A20 RID: 18976 RVA: 0x0026520C File Offset: 0x0026340C
			public HoverBehavior()
			{
			}

			// Token: 0x040084C0 RID: 33984
			private int _ticks;

			// Token: 0x040084C1 RID: 33985
			private int _maxTicks;
		}

		// Token: 0x020009D4 RID: 2516
		private struct Ufo
		{
			// Token: 0x17000853 RID: 2131
			// (get) Token: 0x06004A21 RID: 18977 RVA: 0x000021DB File Offset: 0x000003DB
			// (set) Token: 0x06004A22 RID: 18978 RVA: 0x00265220 File Offset: 0x00263420
			public int Frame
			{
				get
				{
					throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
				set
				{
					int num = 43691;
					this._frame = num;
				}
			}

			// Token: 0x17000854 RID: 2132
			// (get) Token: 0x06004A23 RID: 18979 RVA: 0x0026523C File Offset: 0x0026343C
			// (set) Token: 0x06004A24 RID: 18980 RVA: 0x00265250 File Offset: 0x00263450
			public Texture2D Texture
			{
				get
				{
					return this._texture;
				}
				set
				{
					this._texture = value;
					int width = value.Width;
					this.FrameWidth = width;
					this.FrameHeight = width;
				}
			}

			// Token: 0x17000855 RID: 2133
			// (get) Token: 0x06004A25 RID: 18981 RVA: 0x0026527C File Offset: 0x0026347C
			// (set) Token: 0x06004A26 RID: 18982 RVA: 0x00265290 File Offset: 0x00263490
			public MartianSky.IUfoController Controller
			{
				get
				{
					return this._controller;
				}
				set
				{
					this._controller = value;
				}
			}

			// Token: 0x06004A27 RID: 18983 RVA: 0x002652A4 File Offset: 0x002634A4
			public Ufo(Texture2D texture, float depth = 1f)
			{
				if (!true)
				{
				}
				if (!true)
				{
				}
				this._texture = texture;
				int width = texture.Width;
				this.FrameWidth = width;
				int num = 21846;
				this.FrameHeight = num;
			}

			// Token: 0x06004A28 RID: 18984 RVA: 0x002652DC File Offset: 0x002634DC
			public Rectangle GetSourceRectangle()
			{
				/*
An exception occurred when decompiling this method (06004A28)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Rectangle Terraria.GameContent.Skies.MartianSky/Ufo::GetSourceRectangle()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Ufo::FrameHeight, ldloc:valuetype Terraria.GameContent.Skies.MartianSky/Ufo&(this)))
	stloc:float32(var_1_0D, ldfld:float32(Ufo::Depth, ldloc:valuetype Terraria.GameContent.Skies.MartianSky/Ufo&(this)))
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

			// Token: 0x06004A29 RID: 18985 RVA: 0x002652F8 File Offset: 0x002634F8
			public bool Update()
			{
				/*
An exception occurred when decompiling this method (06004A29)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.Skies.MartianSky/Ufo::Update()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:IUfoController(var_0_06, ldfld:IUfoController(Ufo::_controller, ldloc:valuetype Terraria.GameContent.Skies.MartianSky/Ufo&(this)))
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

			// Token: 0x06004A2A RID: 18986 RVA: 0x0026530C File Offset: 0x0026350C
			public void AssignNewBehavior()
			{
				if (!true)
				{
				}
				int num;
				if (num == 0)
				{
					return;
				}
			}

			// Token: 0x06004A2B RID: 18987 RVA: 0x00265324 File Offset: 0x00263524
			// Note: this type is marked as 'beforefieldinit'.
			static Ufo()
			{
			}

			// Token: 0x040084C2 RID: 33986
			private const int MAX_FRAMES = 3;

			// Token: 0x040084C3 RID: 33987
			private const int FRAME_RATE = 4;

			// Token: 0x040084C4 RID: 33988
			public static UnifiedRandom Random;

			// Token: 0x040084C5 RID: 33989
			private int _frame;

			// Token: 0x040084C6 RID: 33990
			private Texture2D _texture;

			// Token: 0x040084C7 RID: 33991
			private MartianSky.IUfoController _controller;

			// Token: 0x040084C8 RID: 33992
			public Texture2D GlowTexture;

			// Token: 0x040084C9 RID: 33993
			public Vector2 Position;

			// Token: 0x040084CA RID: 33994
			public int FrameHeight;

			// Token: 0x040084CB RID: 33995
			public int FrameWidth;

			// Token: 0x040084CC RID: 33996
			public float Depth;

			// Token: 0x040084CD RID: 33997
			public float Scale;

			// Token: 0x040084CE RID: 33998
			public float Opacity;

			// Token: 0x040084CF RID: 33999
			public bool IsActive;

			// Token: 0x040084D0 RID: 34000
			public float Rotation;
		}

		// Token: 0x020009D5 RID: 2517
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004A2C RID: 18988 RVA: 0x00265334 File Offset: 0x00263534
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06004A2D RID: 18989 RVA: 0x00265344 File Offset: 0x00263544
			public <>c()
			{
			}

			// Token: 0x06004A2E RID: 18990 RVA: 0x00265358 File Offset: 0x00263558
			internal int <Activate>b__13_0(MartianSky.Ufo ufo1, MartianSky.Ufo ufo2)
			{
				float depth = ufo1.Depth;
				int num;
				return num;
			}

			// Token: 0x040084D1 RID: 34001
			public static readonly MartianSky.<>c <>9;

			// Token: 0x040084D2 RID: 34002
			public static Comparison<MartianSky.Ufo> <>9__13_0;
		}
	}
}
