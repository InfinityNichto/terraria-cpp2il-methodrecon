using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent;
using Terraria.GameContent.Events;
using Terraria.Graphics.Shaders;
using Unity.IL2CPP.CompilerServices;

namespace Terraria
{
	// Token: 0x020003EC RID: 1004
	public class Dust
	{
		// Token: 0x06001AD1 RID: 6865 RVA: 0x0007138C File Offset: 0x0006F58C
		public static void Reset()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001AD2 RID: 6866 RVA: 0x000021DB File Offset: 0x000003DB
		public static Dust NewDustPerfect(Vector2 Position, int Type, [Optional] Vector2? Velocity, int Alpha = 0, [Optional] Color newColor, float Scale = 1f)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001AD3 RID: 6867 RVA: 0x000713AC File Offset: 0x0006F5AC
		public static Dust NewDustDirect(Vector2 Position, int Width, int Height, int Type, float SpeedX = 0f, float SpeedY = 0f, int Alpha = 0, [Optional] Color newColor, float Scale = 1f)
		{
			/*
An exception occurred when decompiling this method (06001AD3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.Dust Terraria.Dust::NewDustDirect(Microsoft.Xna.Framework.Vector2,System.Int32,System.Int32,System.Int32,System.Single,System.Single,System.Int32,Microsoft.Xna.Framework.Graphics.Color,System.Single)

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

		// Token: 0x06001AD4 RID: 6868 RVA: 0x000713C0 File Offset: 0x0006F5C0
		public static int NewDust(Vector2 Position, int Width, int Height, int Type, float SpeedX = 0f, float SpeedY = 0f, int Alpha = 0, [Optional] Color newColor, float Scale = 1f)
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool gameMenu = Main.gameMenu;
			if (num == 0)
			{
			}
			long ticks = DateTime.Now.Ticks;
			bool netHostOnly = Main.NetHostOnly;
			int num2 = 32640;
			int num3 = 32768;
			if (num2 == 0)
			{
			}
			if (num2 == 0)
			{
			}
			if (num3 == 0)
			{
			}
			int num4;
			if (num4 != 0)
			{
				return 6000;
			}
			if (!true)
			{
			}
			int num5;
			return num5;
		}

		// Token: 0x06001AD5 RID: 6869 RVA: 0x00071478 File Offset: 0x0006F678
		public static Dust CloneDust(int dustIndex)
		{
			if (!true)
			{
			}
			Dust dust;
			return dust;
		}

		// Token: 0x06001AD6 RID: 6870 RVA: 0x0007148C File Offset: 0x0006F68C
		public static Dust CloneDust(Dust rf)
		{
			for (;;)
			{
				int num = 1;
				if (num == 0)
				{
				}
				if (num != 0)
				{
					return;
				}
			}
		}

		// Token: 0x06001AD7 RID: 6871 RVA: 0x000714A4 File Offset: 0x0006F6A4
		public static void SetNotActive(Dust dust)
		{
			if (dust.active)
			{
				int num = dust.dustIndex;
				int num2 = 6000;
				if (num == 0)
				{
				}
				num.m_value = num2;
				if (dust == null)
				{
					throw new ArrayTypeMismatchException();
				}
			}
		}

		// Token: 0x06001AD8 RID: 6872 RVA: 0x000714DC File Offset: 0x0006F6DC
		public static Dust QuickDust(int x, int y, Color color)
		{
			if (!true)
			{
			}
			Dust dust;
			return dust;
		}

		// Token: 0x06001AD9 RID: 6873 RVA: 0x000714F0 File Offset: 0x0006F6F0
		public static Dust QuickDust(Point tileCoords, Color color)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			Dust dust;
			return dust;
		}

		// Token: 0x06001ADA RID: 6874 RVA: 0x00071504 File Offset: 0x0006F704
		public static void QuickBox(Vector2 topLeft, Vector2 bottomRight, int divisions, Color color, Action<Dust> manipulator)
		{
			if (!true)
			{
			}
			if (divisions != 0)
			{
			}
			if (!true)
			{
			}
			if (divisions != 0)
			{
			}
			if (!true)
			{
			}
			if (divisions != 0)
			{
			}
			if (!true)
			{
			}
			if (divisions != 0)
			{
			}
		}

		// Token: 0x06001ADB RID: 6875 RVA: 0x00071534 File Offset: 0x0006F734
		public static void DrawDebugBox(Rectangle itemRectangle)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Vector2 vector = itemRectangle.TopLeft();
			Vector2 vector2 = itemRectangle.BottomRight();
			long num2 = 0L;
			int num3 = 16256;
			long num4 = 0L;
			if (num2 == 0L || num4 == 0L)
			{
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				Dust dust;
				dust.scale = (float)num3;
			}
		}

		// Token: 0x06001ADC RID: 6876 RVA: 0x0007157C File Offset: 0x0006F77C
		public static Dust QuickDust(Vector2 pos, Color color)
		{
			/*
An exception occurred when decompiling this method (06001ADC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.Dust Terraria.Dust::QuickDust(Microsoft.Xna.Framework.Vector2,Microsoft.Xna.Framework.Graphics.Color)

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

		// Token: 0x06001ADD RID: 6877 RVA: 0x00071590 File Offset: 0x0006F790
		public static Dust QuickDustSmall(Vector2 pos, Color color, bool floorPositionValues = false)
		{
			if (!true)
			{
			}
			Dust dust;
			dust.scale = (float)13107;
			float x = dust.position.X;
			float y = dust.position.Y;
			return dust;
		}

		// Token: 0x06001ADE RID: 6878 RVA: 0x000715C8 File Offset: 0x0006F7C8
		public static void QuickDustLine(Vector2 start, Vector2 end, float splits, Color color)
		{
			if (!true)
			{
			}
			Dust dust;
			dust.scale = (float)39322;
			Dust dust2;
			dust2.scale = (float)39322;
			if (!true)
			{
			}
			if (!true)
			{
			}
			Dust dust3;
			dust3.scale = (float)39322;
		}

		// Token: 0x06001ADF RID: 6879 RVA: 0x00071604 File Offset: 0x0006F804
		public static int dustWater()
		{
			if (!true)
			{
			}
			int waterStyle = Main.waterStyle;
			return 33;
		}

		// Token: 0x06001AE0 RID: 6880 RVA: 0x00071620 File Offset: 0x0006F820
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		[Il2CppSetOption(Option.NullChecks, false)]
		public static void UpdateDust()
		{
			if (!true)
			{
			}
			bool flag = Sandstorm.ShouldSandstormDustPersist();
			bool disabled = ChildSafety.Disabled;
			bool flag2 = ChildSafety.DangerousDust(42189448);
			int num;
			if (num != 0)
			{
				return;
			}
		}

		// Token: 0x06001AE1 RID: 6881 RVA: 0x000720E0 File Offset: 0x000702E0
		private static void SetupAlpha(short id, Color value)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001AE2 RID: 6882 RVA: 0x000720F0 File Offset: 0x000702F0
		public static void InitAlphaTable()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001AE3 RID: 6883 RVA: 0x00072164 File Offset: 0x00070364
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		[Il2CppSetOption(Option.NullChecks, false)]
		public void GetAlpha(Color newColor)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001AE4 RID: 6884 RVA: 0x00072358 File Offset: 0x00070558
		public Color GetAlpha(Color newColor)
		{
			int num = this.alpha;
			int num2 = this.type;
			byte r = this.color.R;
			int num3 = 255;
			int num4 = Math.Min(0, num3);
			byte g = this.color.G;
			int num5 = 255;
			int num6 = Math.Min(num4, num5);
			byte b = this.color.B;
			int num7 = 255;
			int num8 = Math.Min(num6, num7);
			Color color = this.color;
			if (color == null)
			{
			}
			return color;
		}

		// Token: 0x06001AE5 RID: 6885 RVA: 0x0007252C File Offset: 0x0007072C
		public void GetColor(Color newColor)
		{
			int num = this.type;
		}

		// Token: 0x06001AE6 RID: 6886 RVA: 0x000725A4 File Offset: 0x000707A4
		public float GetVisualRotation()
		{
			/*
An exception occurred when decompiling this method (06001AE6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.Dust::GetVisualRotation()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Dust::type, ldloc:Dust(this)))
	stloc:float32(var_1_0D, ldfld:float32(Dust::rotation, ldloc:Dust(this)))
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

		// Token: 0x06001AE7 RID: 6887 RVA: 0x000725C0 File Offset: 0x000707C0
		public float GetVisualScale()
		{
			/*
An exception occurred when decompiling this method (06001AE7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.Dust::GetVisualScale()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Dust::type, ldloc:Dust(this)))
	stloc:float32(var_1_0D, ldfld:float32(Dust::scale, ldloc:Dust(this)))
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

		// Token: 0x06001AE8 RID: 6888 RVA: 0x000725DC File Offset: 0x000707DC
		public Dust()
		{
		}

		// Token: 0x06001AE9 RID: 6889 RVA: 0x000725F0 File Offset: 0x000707F0
		// Note: this type is marked as 'beforefieldinit'.
		static Dust()
		{
		}

		// Token: 0x04002806 RID: 10246
		public static int activeDustCount;

		// Token: 0x04002807 RID: 10247
		public static Dust[] freeDust;

		// Token: 0x04002808 RID: 10248
		public static int freeDustCount;

		// Token: 0x04002809 RID: 10249
		public static float dCount;

		// Token: 0x0400280A RID: 10250
		public static int lavaBubbles;

		// Token: 0x0400280B RID: 10251
		public static int SandStormCount;

		// Token: 0x0400280C RID: 10252
		public int dustIndex;

		// Token: 0x0400280D RID: 10253
		public Vector2 position;

		// Token: 0x0400280E RID: 10254
		public Vector2 velocity;

		// Token: 0x0400280F RID: 10255
		public float fadeIn;

		// Token: 0x04002810 RID: 10256
		public bool noGravity;

		// Token: 0x04002811 RID: 10257
		public float scale;

		// Token: 0x04002812 RID: 10258
		public float rotation;

		// Token: 0x04002813 RID: 10259
		public bool noLight;

		// Token: 0x04002814 RID: 10260
		public bool noLightEmittence;

		// Token: 0x04002815 RID: 10261
		public bool active;

		// Token: 0x04002816 RID: 10262
		public int type;

		// Token: 0x04002817 RID: 10263
		public Color color;

		// Token: 0x04002818 RID: 10264
		public int alpha;

		// Token: 0x04002819 RID: 10265
		public Rectangle frame;

		// Token: 0x0400281A RID: 10266
		public ArmorShaderData shader;

		// Token: 0x0400281B RID: 10267
		public object customData;

		// Token: 0x0400281C RID: 10268
		public bool firstFrame;

		// Token: 0x0400281D RID: 10269
		private static bool[] StaticAlpha;

		// Token: 0x0400281E RID: 10270
		private static Color[] StaticAlphaValue;
	}
}
