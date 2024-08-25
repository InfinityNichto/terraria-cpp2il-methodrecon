using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;

namespace Terraria
{
	// Token: 0x02000433 RID: 1075
	public class Gore
	{
		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x06002821 RID: 10273 RVA: 0x0018FF48 File Offset: 0x0018E148
		public float Width
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002821)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.Gore::get_Width()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0005:
	stloc:float32(var_2_0B, ldfld:float32(Gore::scale, ldloc:Gore(this)))
	brtrue(IL_0000, ldloc:int32[exp:bool](var_0_01))
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

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x06002822 RID: 10274 RVA: 0x0018FF64 File Offset: 0x0018E164
		public float Height
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002822)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.Gore::get_Height()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0005:
	stloc:float32(var_2_0B, ldfld:float32(Gore::scale, ldloc:Gore(this)))
	brtrue(IL_0000, ldloc:int32[exp:bool](var_0_01))
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

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x06002823 RID: 10275 RVA: 0x0018FF80 File Offset: 0x0018E180
		public Rectangle AABBRectangle
		{
			get
			{
				int num = 1;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				float x = this.position.X;
				float y = this.position.Y;
				float num2 = this.scale;
				Rectangle rectangle;
				return rectangle;
			}
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x06002824 RID: 10276 RVA: 0x0018FFC8 File Offset: 0x0018E1C8
		// (set) Token: 0x06002825 RID: 10277 RVA: 0x0018FFE0 File Offset: 0x0018E1E0
		[Obsolete("Please use Frame instead.")]
		public byte frame
		{
			get
			{
				return this.Frame._currentRow;
			}
			set
			{
				this.Frame._currentRow = value;
			}
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06002826 RID: 10278 RVA: 0x0018FFFC File Offset: 0x0018E1FC
		// (set) Token: 0x06002827 RID: 10279 RVA: 0x00190014 File Offset: 0x0018E214
		[Obsolete("Please use Frame instead.")]
		public byte numFrames
		{
			get
			{
				return this.Frame.RowCount;
			}
			set
			{
				byte columnCount = this.Frame.ColumnCount;
				byte currentColumn = this.Frame._currentColumn;
				byte currentRow = this.Frame._currentRow;
				this.Frame._currentColumn = currentRow;
			}
		}

		// Token: 0x06002828 RID: 10280 RVA: 0x00190054 File Offset: 0x0018E254
		private void UpdateAmbientFloorCloud()
		{
			int num = 1;
			if (num == 0)
			{
			}
			this.timeLeft = num;
			float x = this.position.X;
			float y = this.position.Y;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x06002829 RID: 10281 RVA: 0x001900F0 File Offset: 0x0018E2F0
		private void UpdateAmbientAirborneCloud()
		{
			int num = 1;
			int num2 = this.timeLeft;
			if (num == 0)
			{
			}
			this.timeLeft = num;
			float x = this.position.X;
			float y = this.position.Y;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			float x2 = this.velocity.X;
			float y2 = this.velocity.Y;
			this.rotation = x2;
			if (num == 0)
			{
			}
			int num3 = this.timeLeft;
			if (this.alpha == 0)
			{
			}
			int num4;
			if (num4 == 0)
			{
				int num5 = this.alpha;
				this.alpha = num5;
				return;
			}
			float x3 = this.position.X;
			float y3 = this.position.Y;
			float x4 = this.velocity.X;
			float y4 = this.velocity.Y;
			int num6;
			if (num6 == 0)
			{
			}
			this.position.X = x2;
			this.position.Y = y2;
		}

		// Token: 0x0600282A RID: 10282 RVA: 0x001901F8 File Offset: 0x0018E3F8
		private void UpdateFogMachineCloud()
		{
			int num = 1;
			int num2 = this.timeLeft;
			if (num == 0)
			{
			}
			this.timeLeft = num;
			float x = this.position.X;
			float y = this.position.Y;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			int num3 = this.timeLeft;
			if (this.alpha == 0)
			{
			}
			int num4;
			if (num4 == 0)
			{
				int num5 = this.alpha;
				this.alpha = num5;
				return;
			}
			float x2 = this.position.X;
			float y2 = this.position.Y;
			float x3 = this.velocity.X;
			float y3 = this.velocity.Y;
			int num6;
			if (num6 == 0)
			{
			}
		}

		// Token: 0x0600282B RID: 10283 RVA: 0x001902BC File Offset: 0x0018E4BC
		private void UpdateLightningBunnySparks()
		{
			int num;
			if (this.frameCounter == 0)
			{
				num = 1;
				this.frameCounter = (byte)num;
				if (num == 0)
				{
				}
				int num2;
				this.Frame._currentRow = (byte)num2;
			}
			int num3 = this.timeLeft;
			if (num == 0)
			{
			}
			this.timeLeft = num;
			int num4 = 17279;
			float num5 = this.scale;
			float x = this.position.X;
			float y = this.position.Y;
			this.alpha = num4;
			float width = this.Width;
			float height = this.Height;
			if (num4 == 0)
			{
			}
			if (num4 == 0)
			{
			}
			float x2 = this.position.X;
			float y2 = this.position.Y;
			float x3 = this.velocity.X;
			float y3 = this.velocity.Y;
			this.position.X = x2;
			this.position.Y = y2;
		}

		// Token: 0x0600282C RID: 10284 RVA: 0x001903A0 File Offset: 0x0018E5A0
		private float ChumFloatingChunk_GetWaterLine(int X, int Y)
		{
			/*
An exception occurred when decompiling this method (0600282C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.Gore::ChumFloatingChunk_GetWaterLine(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_003E:
	stloc:uint8(var_10_45, callgetter:uint8(Tile::get_liquid, ldloc:Tile[exp:valuetype Terraria.Tile&](var_9)))
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

		// Token: 0x0600282D RID: 10285 RVA: 0x001903F4 File Offset: 0x0018E5F4
		private bool DeactivateIfOutsideOfWorld()
		{
			float x = this.position.X;
			float y = this.position.Y;
			if (!true)
			{
			}
			return true;
		}

		// Token: 0x0600282E RID: 10286 RVA: 0x00190424 File Offset: 0x0018E624
		public void Update()
		{
			if (!true)
			{
			}
			bool netHostOnly = Main.NetHostOnly;
			if (this.active)
			{
				int num2;
				if (this.sticky)
				{
					bool flag = this.DeactivateIfOutsideOfWorld();
					int num = 16896;
					float x = this.velocity.X;
					float y = this.velocity.Y;
					if (num == 0)
					{
					}
					num2 = 16896;
				}
				if (num2 == 0)
				{
				}
				return;
			}
		}

		// Token: 0x0600282F RID: 10287 RVA: 0x00191344 File Offset: 0x0018F544
		private void Gore_UpdateLeaf()
		{
			int num = 1;
			float x = this.position.X;
			float y = this.position.Y;
			if (num == 0)
			{
			}
			float x2 = this.position.X;
			float y2 = this.position.Y;
			float y3 = this.velocity.Y;
			float x3 = this.velocity.X;
			Tile tile;
			byte liquid = tile.liquid;
		}

		// Token: 0x06002830 RID: 10288 RVA: 0x001915D8 File Offset: 0x0018F7D8
		private void Gore_UpdateSail()
		{
		}

		// Token: 0x06002831 RID: 10289 RVA: 0x00191630 File Offset: 0x0018F830
		public static Gore NewGorePerfect(Vector2 Position, Vector2 Velocity, int Type, float Scale = 1f)
		{
			if (!true)
			{
			}
			Gore gore;
			return gore;
		}

		// Token: 0x06002832 RID: 10290 RVA: 0x00191644 File Offset: 0x0018F844
		public static Gore NewGoreDirect(Vector2 Position, Vector2 Velocity, int Type, float Scale = 1f)
		{
			/*
An exception occurred when decompiling this method (06002832)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.Gore Terraria.Gore::NewGoreDirect(Microsoft.Xna.Framework.Vector2,Microsoft.Xna.Framework.Vector2,System.Int32,System.Single)

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

		// Token: 0x06002833 RID: 10291 RVA: 0x00191654 File Offset: 0x0018F854
		public static int NewGore(Vector2 Position, Vector2 Velocity, int Type, float Scale = 1f)
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool netHostOnly = Main.NetHostOnly;
			if (num == 0)
			{
			}
			if (num != 0 || num == 0)
			{
			}
			return 600;
		}

		// Token: 0x06002834 RID: 10292 RVA: 0x00191738 File Offset: 0x0018F938
		public Color GetAlpha(Color newColor)
		{
			int num = this.alpha;
			float num2 = this.light;
			Color color;
			return color;
		}

		// Token: 0x06002835 RID: 10293 RVA: 0x00191778 File Offset: 0x0018F978
		public Gore()
		{
			if (!true)
			{
			}
			this.timeLeft = 1;
			this.Frame = 1;
			base..ctor();
		}

		// Token: 0x06002836 RID: 10294 RVA: 0x001917A4 File Offset: 0x0018F9A4
		// Note: this type is marked as 'beforefieldinit'.
		static Gore()
		{
		}

		// Token: 0x04003418 RID: 13336
		public static int goreTime;

		// Token: 0x04003419 RID: 13337
		public Vector2 position;

		// Token: 0x0400341A RID: 13338
		public Vector2 velocity;

		// Token: 0x0400341B RID: 13339
		public float rotation;

		// Token: 0x0400341C RID: 13340
		public float scale;

		// Token: 0x0400341D RID: 13341
		public int alpha;

		// Token: 0x0400341E RID: 13342
		public int type;

		// Token: 0x0400341F RID: 13343
		public float light;

		// Token: 0x04003420 RID: 13344
		public bool active;

		// Token: 0x04003421 RID: 13345
		public bool sticky = true;

		// Token: 0x04003422 RID: 13346
		public int timeLeft;

		// Token: 0x04003423 RID: 13347
		public bool behindTiles;

		// Token: 0x04003424 RID: 13348
		public byte frameCounter;

		// Token: 0x04003425 RID: 13349
		public SpriteFrame Frame;

		// Token: 0x04003426 RID: 13350
		public int PlayerOnly;
	}
}
