using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ReLogic.Content;
using ReLogic.Utilities;
using Terraria.DataStructures;
using Terraria.UI.Chat;
using Terraria.Utilities;
using Terraria.Utilities.Terraria.Utilities;

namespace Terraria
{
	// Token: 0x02000465 RID: 1125
	public static class Utils
	{
		// Token: 0x06002B40 RID: 11072 RVA: 0x001B4700 File Offset: 0x001B2900
		public static Color ColorLerp_BlackToWhite(float percent)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06002B41 RID: 11073 RVA: 0x000021DB File Offset: 0x000003DB
		public static double Lerp(double value1, double value2, double amount)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002B42 RID: 11074 RVA: 0x001B4714 File Offset: 0x001B2914
		public static Vector2 Round(Vector2 input)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06002B43 RID: 11075 RVA: 0x000021DB File Offset: 0x000003DB
		public static bool IsPowerOfTwo(int x)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002B44 RID: 11076 RVA: 0x001B4734 File Offset: 0x001B2934
		public static float SmoothStep(float min, float max, float x)
		{
		}

		// Token: 0x06002B45 RID: 11077 RVA: 0x001B4744 File Offset: 0x001B2944
		public static double SmoothStep(double min, double max, double x)
		{
			/*
An exception occurred when decompiling this method (06002B45)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Double Terraria.Utils::SmoothStep(System.Double,System.Double,System.Double)

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

		// Token: 0x06002B46 RID: 11078 RVA: 0x000021DB File Offset: 0x000003DB
		public static float UnclampedSmoothStep(float min, float max, float x)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002B47 RID: 11079 RVA: 0x000021DB File Offset: 0x000003DB
		public static double UnclampedSmoothStep(double min, double max, double x)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002B48 RID: 11080 RVA: 0x001B4754 File Offset: 0x001B2954
		public static Dictionary<string, string> ParseArguements(string[] args)
		{
			/*
An exception occurred when decompiling this method (06002B48)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.Dictionary`2<System.String,System.String> Terraria.Utils::ParseArguements(System.String[])

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_003D:
	brtrue(IL_0000, logicnot:bool(ldloc:int64[exp:bool](var_2_05)))
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

		// Token: 0x06002B49 RID: 11081 RVA: 0x001B47A0 File Offset: 0x001B29A0
		public static void Swap<T>(T t1, T t2)
		{
		}

		// Token: 0x06002B4A RID: 11082 RVA: 0x000021DB File Offset: 0x000003DB
		public static T Clamp<T>(T value, T min, T max) where T : IComparable<T>
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002B4B RID: 11083 RVA: 0x001B47B0 File Offset: 0x001B29B0
		public static float Turn01ToCyclic010(float value)
		{
			/*
An exception occurred when decompiling this method (06002B4B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.Utils::Turn01ToCyclic010(System.Single)

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

		// Token: 0x06002B4C RID: 11084 RVA: 0x000021DB File Offset: 0x000003DB
		public static float PingPongFrom01To010(float value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002B4D RID: 11085 RVA: 0x001B47C0 File Offset: 0x001B29C0
		public static float MultiLerp(float percent, params float[] floats)
		{
		}

		// Token: 0x06002B4E RID: 11086 RVA: 0x001B47D0 File Offset: 0x001B29D0
		public static float WrappedLerp(float value1, float value2, float percent)
		{
		}

		// Token: 0x06002B4F RID: 11087 RVA: 0x000021DB File Offset: 0x000003DB
		public static float GetLerpValue(float from, float to, float t, bool clamped = false)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002B50 RID: 11088 RVA: 0x001B47E0 File Offset: 0x001B29E0
		public static float Remap(float fromValue, float fromMin, float fromMax, float toMin, float toMax, bool clamped = true)
		{
			/*
An exception occurred when decompiling this method (06002B50)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.Utils::Remap(System.Single,System.Single,System.Single,System.Single,System.Single,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:float32(var_1_0D, call:float32(MathHelper::Lerp, ldloc:float32(fromMax), ldloc:float32(toMin), ldloc:float32(fromMin)))
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

		// Token: 0x06002B51 RID: 11089 RVA: 0x001B47FC File Offset: 0x001B29FC
		public static void ClampWithinWorld(int minX, int minY, int maxX, int maxY, bool lastValuesInclusiveToIteration = false, int fluffX = 0, int fluffY = 0)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06002B52 RID: 11090 RVA: 0x001B480C File Offset: 0x001B2A0C
		public static Utils.ChaseResults GetChaseResults(Vector2 chaserPosition, float chaserSpeed, Vector2 runnerPosition, Vector2 runnerVelocity)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			Utils.ChaseResults chaseResults;
			chaseResults.InterceptionHappens = true;
			chaseResults.ChaserVelocity = 1;
			return 1;
		}

		// Token: 0x06002B53 RID: 11091 RVA: 0x001B4870 File Offset: 0x001B2A70
		public static Vector2 FactorAcceleration(Vector2 currentVelocity, float timeToInterception, Vector2 descendOfProjectile, int framesOfLenience)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06002B54 RID: 11092 RVA: 0x001B4894 File Offset: 0x001B2A94
		public static bool SolveQuadratic(float a, float b, float c, [Out] float result1, [Out] float result2)
		{
			return true;
		}

		// Token: 0x06002B55 RID: 11093 RVA: 0x000021DB File Offset: 0x000003DB
		public static double GetLerpValue(double from, double to, double t, bool clamped = false)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002B56 RID: 11094 RVA: 0x001B48A4 File Offset: 0x001B2AA4
		public static float GetDayTimeAs24FloatStartingFromMidnight()
		{
			/*
An exception occurred when decompiling this method (06002B56)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.Utils::GetDayTimeAs24FloatStartingFromMidnight()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, logicnot:bool(ldc.i4:bool(1)))
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

		// Token: 0x06002B57 RID: 11095 RVA: 0x001B48B4 File Offset: 0x001B2AB4
		public static Vector2 GetDayTimeAsDirectionIn24HClock()
		{
			if (!true)
			{
			}
			Vector2 dayTimeAsDirectionIn24HClock = Utils.GetDayTimeAsDirectionIn24HClock(Utils.GetDayTimeAs24FloatStartingFromMidnight());
			return 1;
		}

		// Token: 0x06002B58 RID: 11096 RVA: 0x001B48D0 File Offset: 0x001B2AD0
		public static Vector2 GetDayTimeAsDirectionIn24HClock(float timeFrom0To24)
		{
			/*
An exception occurred when decompiling this method (06002B58)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Vector2 Terraria.Utils::GetDayTimeAsDirectionIn24HClock(System.Single)

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

		// Token: 0x06002B59 RID: 11097 RVA: 0x001B48E0 File Offset: 0x001B2AE0
		public static string[] ConvertMonoArgsToDotNet(string[] brokenArgs)
		{
			bool flag = "" != "";
			return "" + " " + " ";
		}

		// Token: 0x06002B5A RID: 11098 RVA: 0x000021DB File Offset: 0x000003DB
		public static T Max<T>(params T[] args) where T : IComparable
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002B5B RID: 11099 RVA: 0x001B491C File Offset: 0x001B2B1C
		public static float LineRectangleDistance(Rectangle rect, Vector2 lineStart, Vector2 lineEnd)
		{
			/*
An exception occurred when decompiling this method (06002B5B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.Utils::LineRectangleDistance(Microsoft.Xna.Framework.Rectangle,Microsoft.Xna.Framework.Vector2,Microsoft.Xna.Framework.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000B:
	stloc:float32(var_12_17, call:float32(MathHelper::Min, ldloc:float32(var_8), ldloc:float32(var_10)))
	stloc:float32(var_14_25, call:float32(MathHelper::Min, ldloc:float32(var_12_17), ldloc:float32(var_12_17)))
	stloc:float32(var_16_33, call:float32(MathHelper::Min, ldloc:float32(var_14_25), ldloc:float32(var_14_25)))
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

		// Token: 0x06002B5C RID: 11100 RVA: 0x001B4960 File Offset: 0x001B2B60
		public static List<List<TextSnippet>> WordwrapStringSmart(string text, Color c, SpriteFont font, int maxWidth, int maxLines)
		{
			if (!true)
			{
			}
			TextSnippet[] array;
			string textOriginal = array.TextOriginal;
			long num = 0L;
			if (num != 0L)
			{
				return;
			}
		}

		// Token: 0x06002B5D RID: 11101 RVA: 0x001B4990 File Offset: 0x001B2B90
		public static string[] WordwrapString(string text, SpriteFont font, int maxWidth, int maxLines, [Out] int lineAmount)
		{
			char c;
			string text2 = c.ToString();
			char c2;
			string text3 = c2.ToString();
			char c3;
			string text4 = c3.ToString();
			string text5;
			return text5;
		}

		// Token: 0x06002B5E RID: 11102 RVA: 0x000021DB File Offset: 0x000003DB
		public static Rectangle CenteredRectangle(Vector2 center, Vector2 size)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002B5F RID: 11103 RVA: 0x001B49F8 File Offset: 0x001B2BF8
		public static Vector2 Vector2FromElipse(Vector2 angleVector, Vector2 elipseSizes)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06002B60 RID: 11104 RVA: 0x001B4A38 File Offset: 0x001B2C38
		public static bool FloatIntersect(float r1StartX, float r1StartY, float r1Width, float r1Height, float r2StartX, float r2StartY, float r2Width, float r2Height)
		{
		}

		// Token: 0x06002B61 RID: 11105 RVA: 0x001B4A48 File Offset: 0x001B2C48
		public static long CoinsCount([Out] bool overFlowing, Item[] inv, params int[] ignoreSlots)
		{
			return 0L;
		}

		// Token: 0x06002B62 RID: 11106 RVA: 0x001B4A5C File Offset: 0x001B2C5C
		public static int[] CoinsSplit(long count)
		{
		}

		// Token: 0x06002B63 RID: 11107 RVA: 0x001B4A6C File Offset: 0x001B2C6C
		public static long CoinsCombineStacks([Out] bool overFlowing, params long[] coinCounts)
		{
			return 0L;
		}

		// Token: 0x06002B64 RID: 11108 RVA: 0x001B4A84 File Offset: 0x001B2C84
		public static void PoofOfSmoke(Vector2 position)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			double num2;
			Vector2 vector = ((float)num2).ToRotationVector2();
			double num3;
			Vector2 vector2 = ((float)num3).ToRotationVector2();
		}

		// Token: 0x06002B65 RID: 11109 RVA: 0x001B4AD8 File Offset: 0x001B2CD8
		public static Vector2 ToScreenPosition(this Vector2 worldPosition)
		{
			if (!true)
			{
			}
			Vector2 screenPosition = Main.screenPosition;
			if (!true)
			{
			}
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06002B66 RID: 11110 RVA: 0x001B4AFC File Offset: 0x001B2CFC
		public static string PrettifyPercentDisplay(float percent, string originalFormat)
		{
			if (!true)
			{
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			string text;
			return text + "%";
		}

		// Token: 0x06002B67 RID: 11111 RVA: 0x001B4B20 File Offset: 0x001B2D20
		public static void TrimTextIfNeeded(string text, SpriteFont font, float scale, float maxWidth)
		{
			int num = 1;
			if (num == 0)
			{
			}
			string text2;
			Vector2 vector = font.MeasureString(text2);
			if (num == 0)
			{
			}
			string text4;
			string text3 = text4 + "…";
		}

		// Token: 0x06002B68 RID: 11112 RVA: 0x001B4B60 File Offset: 0x001B2D60
		public static string FormatWith(string original, object obj)
		{
			if (!true)
			{
			}
			PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(original);
			if (!true)
			{
			}
			string text;
			return text;
		}

		// Token: 0x06002B69 RID: 11113 RVA: 0x001B4B7C File Offset: 0x001B2D7C
		public static bool TryCreatingDirectory(string folderPath)
		{
		}

		// Token: 0x06002B6A RID: 11114 RVA: 0x001B4B94 File Offset: 0x001B2D94
		public static void OpenFolder(string folderPath)
		{
			if (!true)
			{
			}
			long num = 0L;
			bool flag = FileUtilities.Exists(folderPath, num != 0L);
			if (!true)
			{
			}
			FileUtilities.CreateDirectory(folderPath);
			Process process = Process.Start(folderPath);
		}

		// Token: 0x06002B6B RID: 11115 RVA: 0x000021DB File Offset: 0x000003DB
		public static byte[] ToByteArray(this string str)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002B6C RID: 11116 RVA: 0x000021DB File Offset: 0x000003DB
		public static float NextFloat(this UnifiedRandom r)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002B6D RID: 11117 RVA: 0x000021DB File Offset: 0x000003DB
		public static float NextFloatDirection(this UnifiedRandom r)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002B6E RID: 11118 RVA: 0x001B4BC0 File Offset: 0x001B2DC0
		public static float NextFloat(this UnifiedRandom random, FloatRange range)
		{
			/*
An exception occurred when decompiling this method (06002B6E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.Utils::NextFloat(Terraria.Utilities.UnifiedRandom,Terraria.Utilities.Terraria.Utilities.FloatRange)

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

		// Token: 0x06002B6F RID: 11119 RVA: 0x001B4BD0 File Offset: 0x001B2DD0
		public static T NextFromList<T>(this UnifiedRandom random, params T[] objs)
		{
			/*
An exception occurred when decompiling this method (06002B6F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling T Terraria.Utils::NextFromList<T>(Terraria.Utilities.UnifiedRandom,T[])

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32[](var_0_06, ldfld:int32[](UnifiedRandom::SeedArray, ldloc:UnifiedRandom(random)))
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

		// Token: 0x06002B70 RID: 11120 RVA: 0x000021DB File Offset: 0x000003DB
		public static T NextFromCollection<T>(this UnifiedRandom random, List<T> objs)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002B71 RID: 11121 RVA: 0x001B4BE4 File Offset: 0x001B2DE4
		public static int Next(this UnifiedRandom random, IntRange range)
		{
			int num;
			return num;
		}

		// Token: 0x06002B72 RID: 11122 RVA: 0x001B4BF4 File Offset: 0x001B2DF4
		public static Vector2 NextVector2Square(this UnifiedRandom r, float min, float max)
		{
			double num = r.NextDouble();
			double num2 = r.NextDouble();
			Vector2 vector;
			return vector;
		}

		// Token: 0x06002B73 RID: 11123 RVA: 0x001B4C10 File Offset: 0x001B2E10
		public static Vector2 NextVector2FromRectangle(this UnifiedRandom r, Rectangle rect)
		{
			if (!true)
			{
			}
			double num = r.NextDouble();
			double num2 = r.NextDouble();
			return 1;
		}

		// Token: 0x06002B74 RID: 11124 RVA: 0x001B4C30 File Offset: 0x001B2E30
		public static Vector2 NextVector2Unit(this UnifiedRandom r, float startRotation = 0f, float rotationRange = 6.2831855f)
		{
			if (!true)
			{
			}
			Vector2 vector = ((float)r.NextDouble()).ToRotationVector2();
			return 1;
		}

		// Token: 0x06002B75 RID: 11125 RVA: 0x001B4C50 File Offset: 0x001B2E50
		public static Vector2 NextVector2Circular(this UnifiedRandom r, float circleHalfWidth, float circleHalfHeight)
		{
			/*
An exception occurred when decompiling this method (06002B75)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Vector2 Terraria.Utils::NextVector2Circular(Terraria.Utilities.UnifiedRandom,System.Single,System.Single)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:Vector2(var_0_0B, call:Vector2(Utils::NextVector2Unit, ldloc:UnifiedRandom(r), ldloc:float32(circleHalfWidth), ldloc:float32(circleHalfHeight)))
	stloc:float64(var_3_14, call:float64(UnifiedRandom::NextDouble, ldloc:UnifiedRandom(r)))
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

		// Token: 0x06002B76 RID: 11126 RVA: 0x001B4C74 File Offset: 0x001B2E74
		public static Vector2 NextVector2CircularEdge(this UnifiedRandom r, float circleHalfWidth, float circleHalfHeight)
		{
			/*
An exception occurred when decompiling this method (06002B76)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Vector2 Terraria.Utils::NextVector2CircularEdge(Terraria.Utilities.UnifiedRandom,System.Single,System.Single)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:Vector2(var_0_0B, call:Vector2(Utils::NextVector2Unit, ldloc:UnifiedRandom(r), ldloc:float32(circleHalfWidth), ldloc:float32(circleHalfHeight)))
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

		// Token: 0x06002B77 RID: 11127 RVA: 0x001B4C90 File Offset: 0x001B2E90
		public static int Width(this Asset<Texture2D> asset)
		{
		}

		// Token: 0x06002B78 RID: 11128 RVA: 0x001B4CA0 File Offset: 0x001B2EA0
		public static int Height(this Asset<Texture2D> asset)
		{
		}

		// Token: 0x06002B79 RID: 11129 RVA: 0x001B4CB0 File Offset: 0x001B2EB0
		public static Rectangle Frame(this Asset<Texture2D> tex, int horizontalFrames = 1, int verticalFrames = 1, int frameX = 0, int frameY = 0, int sizeOffsetX = 0, int sizeOffsetY = 0)
		{
			/*
An exception occurred when decompiling this method (06002B79)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Rectangle Terraria.Utils::Frame(ReLogic.Content.Asset`1<Microsoft.Xna.Framework.Graphics.Texture2D>,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0005:
	stloc:int32(var_2_0B, ldfld:int32(int32::m_value, ldloc:int32[exp:int32&](var_1_01)))
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

		// Token: 0x06002B7A RID: 11130 RVA: 0x000021DB File Offset: 0x000003DB
		public static Rectangle OffsetSize(this Rectangle rect, int xSize, int ySize)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002B7B RID: 11131 RVA: 0x001B4CC8 File Offset: 0x001B2EC8
		public static Vector2 Size(this Asset<Texture2D> tex)
		{
			bool isLoaded = tex.IsLoaded;
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06002B7C RID: 11132 RVA: 0x000021DB File Offset: 0x000003DB
		public static Rectangle Frame(this Texture2D tex, int horizontalFrames = 1, int verticalFrames = 1, int frameX = 0, int frameY = 0, int sizeOffsetX = 0, int sizeOffsetY = 0)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002B7D RID: 11133 RVA: 0x001B4CE0 File Offset: 0x001B2EE0
		public static Vector2 OriginFlip(this Rectangle rect, Vector2 origin, SpriteEffects effects)
		{
			Vector2 vector;
			return vector;
		}

		// Token: 0x06002B7E RID: 11134 RVA: 0x001B4CF0 File Offset: 0x001B2EF0
		public static Vector2 Size(this Texture2D tex)
		{
			int width = tex.Width;
			int height = tex.Height;
			Vector2 vector;
			return vector;
		}

		// Token: 0x06002B7F RID: 11135 RVA: 0x001B4D0C File Offset: 0x001B2F0C
		public static void WriteRGB(this BinaryWriter bb, Color c)
		{
		}

		// Token: 0x06002B80 RID: 11136 RVA: 0x001B4D1C File Offset: 0x001B2F1C
		public static void WriteVector2(this BinaryWriter bb, Vector2 v)
		{
		}

		// Token: 0x06002B81 RID: 11137 RVA: 0x001B4D2C File Offset: 0x001B2F2C
		public static void WritePackedVector2(this BinaryWriter bb, Vector2 v)
		{
		}

		// Token: 0x06002B82 RID: 11138 RVA: 0x000021DB File Offset: 0x000003DB
		public static Color ReadRGB(this BinaryReader bb)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002B83 RID: 11139 RVA: 0x000021DB File Offset: 0x000003DB
		public static Vector2 ReadVector2(this BinaryReader bb)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002B84 RID: 11140 RVA: 0x000021DB File Offset: 0x000003DB
		public static Vector2 ReadPackedVector2(this BinaryReader bb)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002B85 RID: 11141 RVA: 0x001B4D3C File Offset: 0x001B2F3C
		public static Vector2 Left(this Rectangle r)
		{
			Vector2 vector;
			return vector;
		}

		// Token: 0x06002B86 RID: 11142 RVA: 0x001B4D4C File Offset: 0x001B2F4C
		public static Vector2 Right(this Rectangle r)
		{
			Vector2 vector;
			return vector;
		}

		// Token: 0x06002B87 RID: 11143 RVA: 0x001B4D5C File Offset: 0x001B2F5C
		public static Vector2 Top(this Rectangle r)
		{
			Vector2 vector;
			return vector;
		}

		// Token: 0x06002B88 RID: 11144 RVA: 0x001B4D6C File Offset: 0x001B2F6C
		public static Vector2 Bottom(this Rectangle r)
		{
			Vector2 vector;
			return vector;
		}

		// Token: 0x06002B89 RID: 11145 RVA: 0x001B4D7C File Offset: 0x001B2F7C
		public static Vector2 TopLeft(this Rectangle r)
		{
			Vector2 vector;
			return vector;
		}

		// Token: 0x06002B8A RID: 11146 RVA: 0x001B4D8C File Offset: 0x001B2F8C
		public static Vector2 TopRight(this Rectangle r)
		{
			Vector2 vector;
			return vector;
		}

		// Token: 0x06002B8B RID: 11147 RVA: 0x001B4D9C File Offset: 0x001B2F9C
		public static Vector2 BottomLeft(this Rectangle r)
		{
			Vector2 vector;
			return vector;
		}

		// Token: 0x06002B8C RID: 11148 RVA: 0x001B4DAC File Offset: 0x001B2FAC
		public static Vector2 BottomRight(this Rectangle r)
		{
			Vector2 vector;
			return vector;
		}

		// Token: 0x06002B8D RID: 11149 RVA: 0x001B4DBC File Offset: 0x001B2FBC
		public static Vector2 Center(this Rectangle r)
		{
			Vector2 vector;
			return vector;
		}

		// Token: 0x06002B8E RID: 11150 RVA: 0x001B4DCC File Offset: 0x001B2FCC
		public static Vector2 Size(this Rectangle r)
		{
			Vector2 vector;
			return vector;
		}

		// Token: 0x06002B8F RID: 11151 RVA: 0x001B4DDC File Offset: 0x001B2FDC
		public static float Distance(this Rectangle r, Vector2 point)
		{
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
			Vector2 vector = r.BottomLeft();
			Vector2 vector2 = r.BottomRight();
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x06002B90 RID: 11152 RVA: 0x001B4E08 File Offset: 0x001B3008
		public static Vector2 ClosestPointInRect(this Rectangle r, Vector2 point)
		{
			int right = r.Right;
			Vector2 vector;
			return vector;
		}

		// Token: 0x06002B91 RID: 11153 RVA: 0x000021DB File Offset: 0x000003DB
		public static Rectangle Modified(this Rectangle r, int x, int y, int w, int h)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002B92 RID: 11154 RVA: 0x001B4E20 File Offset: 0x001B3020
		public static bool IntersectsConeFastInaccurate(this Rectangle targetRect, Vector2 coneCenter, float coneLength, float coneRotation, float maximumAngle)
		{
			/*
An exception occurred when decompiling this method (06002B92)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Utils::IntersectsConeFastInaccurate(Microsoft.Xna.Framework.Rectangle,Microsoft.Xna.Framework.Vector2,System.Single,System.Single,System.Single)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000D:
	stloc:float32(var_9_1B, call:float32(Utils::ToRotation, ldloc:Vector2(var_8)))
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

		// Token: 0x06002B93 RID: 11155 RVA: 0x001B4E4C File Offset: 0x001B304C
		public static bool IntersectsConeSlowMoreAccurate(this Rectangle targetRect, Vector2 coneCenter, float coneLength, float coneRotation, float maximumAngle)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Vector2 vector = coneLength.ToRotationVector2();
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
			if (num == 0)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06002B94 RID: 11156 RVA: 0x001B4E80 File Offset: 0x001B3080
		public static bool DoesFitInCone(Vector2 point, Vector2 coneCenter, float coneLength, float coneRotation, float maximumAngle)
		{
			/*
An exception occurred when decompiling this method (06002B94)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Utils::DoesFitInCone(Microsoft.Xna.Framework.Vector2,Microsoft.Xna.Framework.Vector2,System.Single,System.Single,System.Single)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0008:
	stloc:float32(var_3_0E, call:float32(Utils::ToRotation, ldloc:Vector2(var_2)))
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

		// Token: 0x06002B95 RID: 11157 RVA: 0x001B4EA0 File Offset: 0x001B30A0
		public static float ToRotation(this Vector2 v)
		{
			/*
An exception occurred when decompiling this method (06002B95)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.Utils::ToRotation(Microsoft.Xna.Framework.Vector2)

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

		// Token: 0x06002B96 RID: 11158 RVA: 0x001B4EB0 File Offset: 0x001B30B0
		public static Vector2 ToRotationVector2(this float f)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06002B97 RID: 11159 RVA: 0x001B4EC4 File Offset: 0x001B30C4
		public static Vector2 RotatedBy(this Vector2 spinningpoint, double radians, [Optional] Vector2 center)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06002B98 RID: 11160 RVA: 0x001B4EDC File Offset: 0x001B30DC
		public static Vector2D RotatedBy(this Vector2D spinningpoint, double radians, [Optional] Vector2D center)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06002B99 RID: 11161 RVA: 0x001B4EF4 File Offset: 0x001B30F4
		public static Vector2 RotatedByRandom(this Vector2 spinninpoint, double maxRadians)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06002B9A RID: 11162 RVA: 0x001B4F08 File Offset: 0x001B3108
		public static Vector2 Floor(this Vector2 vec)
		{
			Vector2 vector;
			return vector;
		}

		// Token: 0x06002B9B RID: 11163 RVA: 0x001B4F18 File Offset: 0x001B3118
		public static bool HasNaNs(this Vector2 vec)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			return true;
		}

		// Token: 0x06002B9C RID: 11164 RVA: 0x001B4F2C File Offset: 0x001B312C
		public static bool Between(this Vector2 vec, Vector2 minimum, Vector2 maximum)
		{
		}

		// Token: 0x06002B9D RID: 11165 RVA: 0x001B4F3C File Offset: 0x001B313C
		public static Vector2 ToVector2(this Point p)
		{
			Vector2 vector;
			return vector;
		}

		// Token: 0x06002B9E RID: 11166 RVA: 0x001B4F4C File Offset: 0x001B314C
		public static Vector2 ToVector2(this Point16 p)
		{
			Vector2 vector;
			return vector;
		}

		// Token: 0x06002B9F RID: 11167 RVA: 0x001B4F5C File Offset: 0x001B315C
		public static Vector2D ToVector2D(this Point p)
		{
			Vector2D vector2D;
			return vector2D;
		}

		// Token: 0x06002BA0 RID: 11168 RVA: 0x001B4F6C File Offset: 0x001B316C
		public static Vector2D ToVector2D(this Point16 p)
		{
			Vector2D vector2D;
			return vector2D;
		}

		// Token: 0x06002BA1 RID: 11169 RVA: 0x001B4F7C File Offset: 0x001B317C
		public static Vector2 ToWorldCoordinates(this Point p, float autoAddX = 8f, float autoAddY = 8f)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06002BA2 RID: 11170 RVA: 0x001B4F94 File Offset: 0x001B3194
		public static Vector2 ToWorldCoordinates(this Point16 p, float autoAddX = 8f, float autoAddY = 8f)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06002BA3 RID: 11171 RVA: 0x001B4FAC File Offset: 0x001B31AC
		public static Vector2 MoveTowards(this Vector2 currentPosition, Vector2 targetPosition, float maxAmountAllowedToMove)
		{
			if (!true)
			{
			}
			Vector2 vector;
			float num = vector.Length();
			if (!true)
			{
			}
			if (!true)
			{
				return;
			}
		}

		// Token: 0x06002BA4 RID: 11172 RVA: 0x000021DB File Offset: 0x000003DB
		public static Point16 ToTileCoordinates16(this Vector2 vec)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002BA5 RID: 11173 RVA: 0x000021DB File Offset: 0x000003DB
		public static Point16 ToTileCoordinates16(this Vector2D vec)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002BA6 RID: 11174 RVA: 0x000021DB File Offset: 0x000003DB
		public static Point ToTileCoordinates(this Vector2 vec)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002BA7 RID: 11175 RVA: 0x000021DB File Offset: 0x000003DB
		public static Point ToTileCoordinates(this Vector2D vec)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002BA8 RID: 11176 RVA: 0x000021DB File Offset: 0x000003DB
		public static Point ToPoint(this Vector2 v)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002BA9 RID: 11177 RVA: 0x000021DB File Offset: 0x000003DB
		public static Point ToPoint(this Vector2D v)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002BAA RID: 11178 RVA: 0x001B4FD0 File Offset: 0x001B31D0
		public static Vector2D ToVector2D(this Vector2 v)
		{
			Vector2D vector2D;
			return vector2D;
		}

		// Token: 0x06002BAB RID: 11179 RVA: 0x001B4FE0 File Offset: 0x001B31E0
		public static Vector2 SafeNormalize(this Vector2 v, Vector2 defaultValue)
		{
			if (!true)
			{
			}
			if (!true)
			{
				return;
			}
		}

		// Token: 0x06002BAC RID: 11180 RVA: 0x001B4FF8 File Offset: 0x001B31F8
		public static Vector2 ClosestPointOnLine(this Vector2 P, Vector2 A, Vector2 B)
		{
			if (!true)
			{
			}
			Vector2 vector;
			float num = vector.LengthSquared();
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06002BAD RID: 11181 RVA: 0x001B5024 File Offset: 0x001B3224
		public static bool RectangleLineCollision(Vector2 rectTopLeft, Vector2 rectBottomRight, Vector2 lineStart, Vector2 lineEnd)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x06002BAE RID: 11182 RVA: 0x001B5044 File Offset: 0x001B3244
		public static Vector2 RotateRandom(this Vector2 spinninpoint, double maxRadians)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06002BAF RID: 11183 RVA: 0x001B5058 File Offset: 0x001B3258
		public static float AngleTo(this Vector2 Origin, Vector2 Target)
		{
			/*
An exception occurred when decompiling this method (06002BAF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.Utils::AngleTo(Microsoft.Xna.Framework.Vector2,Microsoft.Xna.Framework.Vector2)

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

		// Token: 0x06002BB0 RID: 11184 RVA: 0x001B5068 File Offset: 0x001B3268
		public static float AngleFrom(this Vector2 Origin, Vector2 Target)
		{
			/*
An exception occurred when decompiling this method (06002BB0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.Utils::AngleFrom(Microsoft.Xna.Framework.Vector2,Microsoft.Xna.Framework.Vector2)

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

		// Token: 0x06002BB1 RID: 11185 RVA: 0x001B5078 File Offset: 0x001B3278
		public static Vector2 rotateTowards(Vector2 currentPosition, Vector2 currentVelocity, Vector2 targetPosition, float maxChange)
		{
			/*
An exception occurred when decompiling this method (06002BB1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Vector2 Terraria.Utils::rotateTowards(Microsoft.Xna.Framework.Vector2,Microsoft.Xna.Framework.Vector2,Microsoft.Xna.Framework.Vector2,System.Single)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:Vector2(var_4_09, call:Vector2(Utils::ToRotationVector2, ldloc:float32(var_3)))
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

		// Token: 0x06002BB2 RID: 11186 RVA: 0x001B5094 File Offset: 0x001B3294
		public static float Distance(this Vector2 Origin, Vector2 Target)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x06002BB3 RID: 11187 RVA: 0x001B50A8 File Offset: 0x001B32A8
		public static float DistanceSQ(this Vector2 Origin, Vector2 Target)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x06002BB4 RID: 11188 RVA: 0x001B50BC File Offset: 0x001B32BC
		public static Vector2 DirectionTo(this Vector2 Origin, Vector2 Target)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06002BB5 RID: 11189 RVA: 0x001B50D4 File Offset: 0x001B32D4
		public static Vector2 DirectionFrom(this Vector2 Origin, Vector2 Target)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06002BB6 RID: 11190 RVA: 0x001B50EC File Offset: 0x001B32EC
		public static bool WithinRange(this Vector2 Origin, Vector2 Target, float MaxRange)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x06002BB7 RID: 11191 RVA: 0x001B5100 File Offset: 0x001B3300
		public static Vector2 XY(this Vector4 vec)
		{
			Vector2 vector;
			return vector;
		}

		// Token: 0x06002BB8 RID: 11192 RVA: 0x001B5110 File Offset: 0x001B3310
		public static Vector2 ZW(this Vector4 vec)
		{
			Vector2 vector;
			return vector;
		}

		// Token: 0x06002BB9 RID: 11193 RVA: 0x001B5120 File Offset: 0x001B3320
		public static Vector3 XZW(this Vector4 vec)
		{
			Vector3 vector;
			return vector;
		}

		// Token: 0x06002BBA RID: 11194 RVA: 0x001B5130 File Offset: 0x001B3330
		public static Vector3 YZW(this Vector4 vec)
		{
			Vector3 vector;
			return vector;
		}

		// Token: 0x06002BBB RID: 11195 RVA: 0x001B5140 File Offset: 0x001B3340
		public static Color MultiplyRGB(this Color firstColor, Color secondColor)
		{
			Color color;
			return color;
		}

		// Token: 0x06002BBC RID: 11196 RVA: 0x001B5150 File Offset: 0x001B3350
		public static Color MultiplyRGBA(this Color firstColor, Color secondColor)
		{
			Color color;
			return color;
		}

		// Token: 0x06002BBD RID: 11197 RVA: 0x001B5160 File Offset: 0x001B3360
		public static string Hex3(this Color color)
		{
			string text;
			string text2;
			string text3;
			return (text + text2 + text3).ToLower();
		}

		// Token: 0x06002BBE RID: 11198 RVA: 0x001B517C File Offset: 0x001B337C
		public static string Hex4(this Color color)
		{
			string text;
			string text2;
			string text3;
			string text4;
			return (text + text2 + text3 + text4).ToLower();
		}

		// Token: 0x06002BBF RID: 11199 RVA: 0x000021DB File Offset: 0x000003DB
		public static int ToDirectionInt(this bool value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002BC0 RID: 11200 RVA: 0x000021DB File Offset: 0x000003DB
		public static int ToInt(this bool value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002BC1 RID: 11201 RVA: 0x000021DB File Offset: 0x000003DB
		public static int ModulusPositive(this int myInteger, int modulusNumber)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002BC2 RID: 11202 RVA: 0x001B5198 File Offset: 0x001B3398
		public static float AngleLerp(this float curAngle, float targetAngle, float amount)
		{
			/*
An exception occurred when decompiling this method (06002BC2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.Utils::AngleLerp(System.Single,System.Single,System.Single)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_3_0A, call:float32(MathHelper::WrapAngle, ldloc:float32(var_1)))
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

		// Token: 0x06002BC3 RID: 11203 RVA: 0x001B51B0 File Offset: 0x001B33B0
		public static float AngleTowards(this float curAngle, float targetAngle, float maxChange)
		{
			/*
An exception occurred when decompiling this method (06002BC3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.Utils::AngleTowards(System.Single,System.Single,System.Single)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_3_0A, call:float32(MathHelper::WrapAngle, ldloc:float32(curAngle)))
	stloc:float32(var_5_16, call:float32(MathHelper::Clamp, ldloc:float32(var_3_0A), ldloc:float32(curAngle), ldloc:float32(targetAngle)))
	stloc:float32(var_7_22, call:float32(MathHelper::WrapAngle, ldloc:float32(var_5_16)))
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

		// Token: 0x06002BC4 RID: 11204 RVA: 0x001B51E0 File Offset: 0x001B33E0
		public static bool deepCompare(this int[] firstArray, int[] secondArray)
		{
			while (firstArray == null)
			{
			}
		}

		// Token: 0x06002BC5 RID: 11205 RVA: 0x001B51F4 File Offset: 0x001B33F4
		public static List<int> GetTrueIndexes(this bool[] array)
		{
		}

		// Token: 0x06002BC6 RID: 11206 RVA: 0x001B5204 File Offset: 0x001B3404
		public static List<int> GetTrueIndexes(params bool[][] arrays)
		{
			/*
An exception occurred when decompiling this method (06002BC6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.List`1<System.Int32> Terraria.Utils::GetTrueIndexes(System.Boolean[][])

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

		// Token: 0x06002BC7 RID: 11207 RVA: 0x001B5218 File Offset: 0x001B3418
		public static int Count<T>(this T[] arr, T value)
		{
		}

		// Token: 0x06002BC8 RID: 11208 RVA: 0x001B5228 File Offset: 0x001B3428
		public static bool PressingShift(this KeyboardState kb)
		{
			return true;
		}

		// Token: 0x06002BC9 RID: 11209 RVA: 0x001B5238 File Offset: 0x001B3438
		public static bool PressingControl(this KeyboardState kb)
		{
			return true;
		}

		// Token: 0x06002BCA RID: 11210 RVA: 0x001B5248 File Offset: 0x001B3448
		public static R[] MapArray<R, T>(T[] array, Func<T, R> mapper)
		{
			return array;
		}

		// Token: 0x06002BCB RID: 11211 RVA: 0x001B5258 File Offset: 0x001B3458
		public static bool PlotLine(Point16 p0, Point16 p1, Utils.TileActionAttempt plot, bool jump = true)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06002BCC RID: 11212 RVA: 0x001B526C File Offset: 0x001B346C
		public static bool PlotLine(Point p0, Point p1, Utils.TileActionAttempt plot, bool jump = true)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06002BCD RID: 11213 RVA: 0x001B5280 File Offset: 0x001B3480
		private static void PlotLineLength(int x0, int y0, int x1, int y1, int length, bool jump = true)
		{
		}

		// Token: 0x06002BCE RID: 11214 RVA: 0x001B5290 File Offset: 0x001B3490
		private static bool PlotLineOffset(Vector2D start, Vector2D end, double halfWidth, int x0, int y0, int x1, int y1, Utils.TileActionAttempt plot, bool jump = true)
		{
			Vector2D vector2D;
			double num = vector2D.Length();
			Vector2D vector2D2;
			Point point = vector2D2.ToTileCoordinates();
			Point point2;
			if (point2 == null)
			{
			}
			if (point2 == null)
			{
				return;
			}
		}

		// Token: 0x06002BCF RID: 11215 RVA: 0x001B52C8 File Offset: 0x001B34C8
		private static bool PlotLineOffsetTale(Vector2D start, Vector2D end, int length, double halfWidth, int x0, int y0, int x1, int y1, Utils.TileActionAttempt plot, bool jump = true)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Vector2D vector2D;
			double num2 = vector2D.Length();
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (length == 0)
			{
			}
			if (length == 0)
			{
				return;
			}
		}

		// Token: 0x06002BD0 RID: 11216 RVA: 0x001B52F8 File Offset: 0x001B34F8
		private static bool PlotLine(int x0, int y0, int x1, int y1, Utils.TileActionAttempt plot, bool jump = true)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x06002BD1 RID: 11217 RVA: 0x001B5310 File Offset: 0x001B3510
		public static int RandomNext(ulong seed, int bits)
		{
			/*
An exception occurred when decompiling this method (06002BD1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.Utils::RandomNext(System.UInt64,System.Int32)

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

		// Token: 0x06002BD2 RID: 11218 RVA: 0x000021DB File Offset: 0x000003DB
		public static ulong RandomNextSeed(ulong seed)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002BD3 RID: 11219 RVA: 0x001B5320 File Offset: 0x001B3520
		public static float RandomFloat(ulong seed)
		{
			/*
An exception occurred when decompiling this method (06002BD3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.Utils::RandomFloat(System.UInt64)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:int32(var_0_14, call:int32(Utils::RandomNext, conv.u8:uint64(ldc.i8:int64[exp:uint64](4720931368828141568)), ldc.i4:int32(24)))
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

		// Token: 0x06002BD4 RID: 11220 RVA: 0x001B5344 File Offset: 0x001B3544
		public static int RandomInt(ulong seed, int max)
		{
			if (!true)
			{
			}
			int num = 31;
			return Utils.RandomNext((ulong)4720931368828141568L, num);
		}

		// Token: 0x06002BD5 RID: 11221 RVA: 0x001B5380 File Offset: 0x001B3580
		public static int RandomInt(ulong seed, int min, int max)
		{
			if (!true)
			{
			}
			return Utils.RandomInt((ulong)4720931368828141568L, (int)seed);
		}

		// Token: 0x06002BD6 RID: 11222 RVA: 0x001B53A0 File Offset: 0x001B35A0
		public static bool PlotTileLineInner(int x, int y)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06002BD7 RID: 11223 RVA: 0x001B53B4 File Offset: 0x001B35B4
		public static bool PlotTileLine(Vector2 start, Vector2 end, float width, Utils.TileActionAttempt plot)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06002BD8 RID: 11224 RVA: 0x001B53C8 File Offset: 0x001B35C8
		public static bool PlotTileLine(Vector2D start, Vector2D end, double width, Utils.TileActionAttempt plot)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Vector2D vector2D;
			double num2 = vector2D.Length();
			if (num == 0)
			{
			}
			Vector2D vector2D2;
			Point point = vector2D2.ToTileCoordinates();
			bool flag;
			return flag;
		}

		// Token: 0x06002BD9 RID: 11225 RVA: 0x001B5400 File Offset: 0x001B3600
		public static bool PlotTileTale(Vector2D start, Vector2D end, double width, Utils.TileActionAttempt plot)
		{
			if (!true)
			{
			}
			Vector2D vector2D;
			double num = vector2D.Length();
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06002BDA RID: 11226 RVA: 0x001B5420 File Offset: 0x001B3620
		public static bool PlotTileArea(int x, int y, Utils.TileActionAttempt plot)
		{
			if (!true)
			{
			}
			long num = 0L;
			bool flag = WorldGen.InWorld(0, x, (int)num);
			if (!flag)
			{
			}
			Tile.StartNewSearch();
			if (!flag)
			{
			}
			return false;
		}

		// Token: 0x06002BDB RID: 11227 RVA: 0x001B54C8 File Offset: 0x001B36C8
		public static int RandomConsecutive(double random, int odds)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x06002BDC RID: 11228 RVA: 0x001B54DC File Offset: 0x001B36DC
		public static Vector2 RandomVector2(UnifiedRandom random, float min, float max)
		{
			double num = random.NextDouble();
			double num2 = random.NextDouble();
			Vector2 vector;
			return vector;
		}

		// Token: 0x06002BDD RID: 11229 RVA: 0x001B54F8 File Offset: 0x001B36F8
		public static Vector2D RandomVector2D(UnifiedRandom random, double min, double max)
		{
			double num = random.NextDouble();
			double num2 = random.NextDouble();
			Vector2D vector2D;
			return vector2D;
		}

		// Token: 0x06002BDE RID: 11230 RVA: 0x001B5514 File Offset: 0x001B3714
		public static bool IndexInRange<T>(this T[] t, int index)
		{
		}

		// Token: 0x06002BDF RID: 11231 RVA: 0x001B5524 File Offset: 0x001B3724
		public static bool IndexInRange<T>(this List<T> t, int index)
		{
		}

		// Token: 0x06002BE0 RID: 11232 RVA: 0x001B5534 File Offset: 0x001B3734
		public static T SelectRandom<T>(UnifiedRandom random, params T[] choices)
		{
			/*
An exception occurred when decompiling this method (06002BE0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling T Terraria.Utils::SelectRandom<T>(Terraria.Utilities.UnifiedRandom,T[])

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32[](var_0_06, ldfld:int32[](UnifiedRandom::SeedArray, ldloc:UnifiedRandom(random)))
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

		// Token: 0x06002BE1 RID: 11233 RVA: 0x001B5548 File Offset: 0x001B3748
		public static void DrawBorderStringFourWay(SpriteBatch sb, SpriteFont font, string text, float x, float y, Color textColor, Color borderColor, Vector2 origin, float scale = 1f)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x06002BE2 RID: 11234 RVA: 0x001B5564 File Offset: 0x001B3764
		public static Vector2 DrawBorderString(SpriteBatch sb, string text, Vector2 pos, Color color, float scale = 1f, float anchorx = 0f, float anchory = 0f, int maxCharactersDisplayed = -1)
		{
			int stringLength = text._stringLength;
			if (stringLength == 0)
			{
			}
			if (stringLength == 0)
			{
			}
			if (stringLength == 0)
			{
			}
			return 16320;
		}

		// Token: 0x06002BE3 RID: 11235 RVA: 0x001B558C File Offset: 0x001B378C
		public static Vector2 DrawBorderStringBig(SpriteBatch spriteBatch, string text, Vector2 pos, Color color, float scale = 1f, float anchorx = 0f, float anchory = 0f, int maxCharactersDisplayed = -1)
		{
			int stringLength = text._stringLength;
			if (stringLength == 0)
			{
			}
			if (stringLength == 0)
			{
			}
			if (stringLength == 0)
			{
			}
			if (stringLength == 0)
			{
				return;
			}
		}

		// Token: 0x06002BE4 RID: 11236 RVA: 0x001B55B8 File Offset: 0x001B37B8
		public static void DrawInvBG(SpriteBatch sb, Rectangle R, [Optional] Color c)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06002BE5 RID: 11237 RVA: 0x001B55C8 File Offset: 0x001B37C8
		public static void DrawInvBG(SpriteBatch sb, float x, float y, float w, float h, [Optional] Color c)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06002BE6 RID: 11238 RVA: 0x001B55D8 File Offset: 0x001B37D8
		public static void DrawInvBG(SpriteBatch sb, int x, int y, int w, int h, [Optional] Color c)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x06002BE7 RID: 11239 RVA: 0x001B56A4 File Offset: 0x001B38A4
		public static string ReadEmbeddedResource(string path)
		{
			if (!false)
			{
				if (!false)
				{
				}
				throw new OutOfMemoryException();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06002BE8 RID: 11240 RVA: 0x001B56E4 File Offset: 0x001B38E4
		public static void DrawSplicedPanel(SpriteBatch sb, Texture2D texture, int x, int y, int w, int h, int leftEnd, int rightEnd, int topEnd, int bottomEnd, Color c)
		{
			int width = texture.Width;
			int width2 = texture.Width;
			int height = texture.Height;
			int width3 = texture.Width;
			int arraySize = texture.ArraySize;
			int width4 = texture.Width;
			int arraySize2 = texture.ArraySize;
			int height2 = texture.Height;
			int width5 = texture.Width;
			int arraySize3 = texture.ArraySize;
			int width6 = texture.Width;
			int arraySize4 = texture.ArraySize;
		}

		// Token: 0x06002BE9 RID: 11241 RVA: 0x001B575C File Offset: 0x001B395C
		public static void DrawSettingsPanel(SpriteBatch spriteBatch, Vector2 position, float width, Color color)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06002BEA RID: 11242 RVA: 0x001B576C File Offset: 0x001B396C
		public static void DrawSettings2Panel(SpriteBatch spriteBatch, Vector2 position, float width, Color color)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06002BEB RID: 11243 RVA: 0x001B577C File Offset: 0x001B397C
		public static void DrawPanel(Texture2D texture, int edgeWidth, int edgeShove, SpriteBatch spriteBatch, Vector2 position, float width, Color color)
		{
			int height = texture.Height;
			int width2 = texture.Width;
			int arraySize = texture.ArraySize;
			if (width2 == 0)
			{
			}
			int num = 1;
			if (num == 0)
			{
			}
			int width3 = texture.Width;
			int value = num.m_value;
			int width4 = texture.Width;
			int arraySize2 = texture.ArraySize;
		}

		// Token: 0x06002BEC RID: 11244 RVA: 0x001B57D4 File Offset: 0x001B39D4
		public static void DrawRectangle(SpriteBatch sb, Vector2 start, Vector2 end, Color colorStart, Color colorEnd, float width)
		{
			if (!true)
			{
			}
			Utils.DrawLine(sb, start, end, colorStart, colorEnd, width);
			Utils.DrawLine(sb, start, end, colorStart, colorEnd, width);
			Utils.DrawLine(sb, start, end, colorStart, colorEnd, width);
			Utils.DrawLine(sb, start, end, colorStart, colorEnd, width);
		}

		// Token: 0x06002BED RID: 11245 RVA: 0x001B5818 File Offset: 0x001B3A18
		public static void DrawLaser(SpriteBatch sb, Texture2D tex, Vector2 start, Vector2 end, Vector2 scale, Utils.LaserLineFraming framing)
		{
			if (!true)
			{
			}
			Vector2 vector;
			float num = vector.Length();
			if (!true)
			{
			}
		}

		// Token: 0x06002BEE RID: 11246 RVA: 0x001B5850 File Offset: 0x001B3A50
		public static void DrawLine(SpriteBatch spriteBatch, Point start, Point end, Color color)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06002BEF RID: 11247 RVA: 0x001B5860 File Offset: 0x001B3A60
		public static void DrawLine(SpriteBatch spriteBatch, Vector2 start, Vector2 end, Color color)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			Vector2 screenPosition = Main.screenPosition;
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x06002BF0 RID: 11248 RVA: 0x001B589C File Offset: 0x001B3A9C
		public static void DrawLine(SpriteBatch spriteBatch, Vector2 start, Vector2 end, Color colorStart, Color colorEnd, float width)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			Vector2 screenPosition = Main.screenPosition;
			if (!true)
			{
			}
			if (15744 == 0)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x06002BF1 RID: 11249 RVA: 0x001B58D8 File Offset: 0x001B3AD8
		public static void DrawRectForTilesInWorld(SpriteBatch spriteBatch, Rectangle rect, Color color)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06002BF2 RID: 11250 RVA: 0x001B58E8 File Offset: 0x001B3AE8
		public static void DrawRectForTilesInWorld(SpriteBatch spriteBatch, Point start, Point end, Color color)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06002BF3 RID: 11251 RVA: 0x001B58F8 File Offset: 0x001B3AF8
		public static void DrawRect(SpriteBatch spriteBatch, Rectangle rect, Color color)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06002BF4 RID: 11252 RVA: 0x001B5908 File Offset: 0x001B3B08
		public static void DrawRect(SpriteBatch spriteBatch, Vector2 start, Vector2 end, Color color)
		{
			if (!true)
			{
			}
			Utils.DrawLine(spriteBatch, start, end, color);
			Utils.DrawLine(spriteBatch, start, end, color);
			Utils.DrawLine(spriteBatch, start, end, color);
			Utils.DrawLine(spriteBatch, start, end, color);
		}

		// Token: 0x06002BF5 RID: 11253 RVA: 0x001B593C File Offset: 0x001B3B3C
		public static void DrawRect(SpriteBatch spriteBatch, Vector2 topLeft, Vector2 topRight, Vector2 bottomRight, Vector2 bottomLeft, Color color)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06002BF6 RID: 11254 RVA: 0x001B594C File Offset: 0x001B3B4C
		public static void DrawCursorSingle(SpriteBatch sb, Color color, float rot = float.NaN, float scale = 1f, [Optional] Vector2 manualPosition, int cursorSlot = 0, int specialMode = 0)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			int mouseX = Main.mouseX;
			int mouseY = Main.mouseY;
			int num = 1;
			if (num == 0)
			{
			}
			int value = num.m_value;
			if (cursorSlot == 0)
			{
				return;
			}
			if (!true)
			{
			}
			bool thickMouse = Main.ThickMouse;
			Vector2 vector = Main.DrawThickCursor(true);
			long num2;
			if (num2 != 0L)
			{
				if (!true)
				{
				}
				if (!true)
				{
				}
			}
		}

		// Token: 0x06002BF7 RID: 11255 RVA: 0x001B59C4 File Offset: 0x001B3BC4
		// Note: this type is marked as 'beforefieldinit'.
		static Utils()
		{
		}

		// Token: 0x06002BF8 RID: 11256 RVA: 0x001B59D4 File Offset: 0x001B3BD4
		[CompilerGenerated]
		internal static bool <PlotLineOffset>g__PlotAtOffset|149_0(int xVal, int yVal, Utils.<>c__DisplayClass149_0 cpp2il__autoParamName__idx_3)
		{
			int num = 1;
			int value = yVal.m_value;
			if (num == 0)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06002BF9 RID: 11257 RVA: 0x001B59F0 File Offset: 0x001B3BF0
		[CompilerGenerated]
		internal static bool <PlotLineOffsetTale>g__PlotAtOffset|150_0(int xVal, int yVal, Utils.<>c__DisplayClass150_0 cpp2il__autoParamName__idx_3)
		{
			int value = yVal.m_value;
			yVal.m_value = value;
			if (value == 0)
			{
			}
			if (value == 0)
			{
			}
			Vector2D vector2D;
			Point point = vector2D.ToTileCoordinates();
			bool flag;
			return flag;
		}

		// Token: 0x0400379F RID: 14239
		public const long MaxCoins = 999999999L;

		// Token: 0x040037A0 RID: 14240
		public static Dictionary<SpriteFont, float[]> charLengths;

		// Token: 0x040037A1 RID: 14241
		private static Regex _substitutionRegex;

		// Token: 0x040037A2 RID: 14242
		private const ulong RANDOM_MULTIPLIER = 25214903917UL;

		// Token: 0x040037A3 RID: 14243
		private const ulong RANDOM_ADD = 11UL;

		// Token: 0x040037A4 RID: 14244
		private const ulong RANDOM_MASK = 281474976710655UL;

		// Token: 0x040037A5 RID: 14245
		private static Utils.TileActionAttempt plotInnerCall;

		// Token: 0x040037A6 RID: 14246
		private static Point plotInnerLineMinOffset;

		// Token: 0x040037A7 RID: 14247
		private static Point plotInnerLineMaxOffset;

		// Token: 0x040037A8 RID: 14248
		private static Utils.TileActionAttempt PlotTileLineInnerInstance;

		// Token: 0x02000466 RID: 1126
		public sealed class TileActionAttempt : MulticastDelegate
		{
			// Token: 0x06002BFA RID: 11258 RVA: 0x001B5A2C File Offset: 0x001B3C2C
			public TileActionAttempt(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x06002BFB RID: 11259 RVA: 0x001B5A80 File Offset: 0x001B3C80
			public bool Invoke(int x, int y)
			{
				/*
An exception occurred when decompiling this method (06002BFB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Utils/TileActionAttempt::Invoke(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:native int(var_0_06, ldfld:native int(Delegate::method_code, ldloc:TileActionAttempt[exp:Delegate](this)))
	stloc:native int(var_1_0D, ldfld:native int(Delegate::invoke_impl, ldloc:TileActionAttempt[exp:Delegate](this)))
	stloc:native int(var_2_14, ldfld:native int(Delegate::method, ldloc:TileActionAttempt[exp:Delegate](this)))
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

			// Token: 0x06002BFC RID: 11260 RVA: 0x000021DB File Offset: 0x000003DB
			public IAsyncResult BeginInvoke(int x, int y, AsyncCallback callback, object @object)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06002BFD RID: 11261 RVA: 0x000021DB File Offset: 0x000003DB
			public bool EndInvoke(IAsyncResult result)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x02000467 RID: 1127
		public sealed class LaserLineFraming : MulticastDelegate
		{
			// Token: 0x06002BFE RID: 11262 RVA: 0x001B5AA4 File Offset: 0x001B3CA4
			public LaserLineFraming(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x06002BFF RID: 11263 RVA: 0x001B5AF8 File Offset: 0x001B3CF8
			public void Invoke(int stage, [Out] float distanceCovered, [Out] Rectangle frame, [Out] Vector2 origin, [Out] Color color)
			{
				IntPtr method_code = this.method_code;
				IntPtr invoke_impl = this.invoke_impl;
				IntPtr method = this.method;
			}

			// Token: 0x06002C00 RID: 11264 RVA: 0x000021DB File Offset: 0x000003DB
			public IAsyncResult BeginInvoke(int stage, [Out] float distanceCovered, [Out] Rectangle frame, [Out] Vector2 origin, [Out] Color color, AsyncCallback callback, object @object)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06002C01 RID: 11265 RVA: 0x001B5B1C File Offset: 0x001B3D1C
			public void EndInvoke([Out] float distanceCovered, [Out] Rectangle frame, [Out] Vector2 origin, [Out] Color color, IAsyncResult result)
			{
			}
		}

		// Token: 0x02000468 RID: 1128
		public sealed class ColorLerpMethod : MulticastDelegate
		{
			// Token: 0x06002C02 RID: 11266 RVA: 0x001B5B2C File Offset: 0x001B3D2C
			public ColorLerpMethod(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x06002C03 RID: 11267 RVA: 0x001B5B80 File Offset: 0x001B3D80
			public Color Invoke(float percent)
			{
				/*
An exception occurred when decompiling this method (06002C03)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.Color Terraria.Utils/ColorLerpMethod::Invoke(System.Single)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:native int(var_0_06, ldfld:native int(Delegate::method_code, ldloc:ColorLerpMethod[exp:Delegate](this)))
	stloc:native int(var_1_0D, ldfld:native int(Delegate::invoke_impl, ldloc:ColorLerpMethod[exp:Delegate](this)))
	stloc:native int(var_2_14, ldfld:native int(Delegate::method, ldloc:ColorLerpMethod[exp:Delegate](this)))
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

			// Token: 0x06002C04 RID: 11268 RVA: 0x000021DB File Offset: 0x000003DB
			public IAsyncResult BeginInvoke(float percent, AsyncCallback callback, object @object)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06002C05 RID: 11269 RVA: 0x001B5BA4 File Offset: 0x001B3DA4
			public Color EndInvoke(IAsyncResult result)
			{
				Color color;
				return color;
			}
		}

		// Token: 0x02000469 RID: 1129
		public struct ChaseResults
		{
			// Token: 0x040037A9 RID: 14249
			public bool InterceptionHappens;

			// Token: 0x040037AA RID: 14250
			public Vector2 InterceptionPosition;

			// Token: 0x040037AB RID: 14251
			public float InterceptionTime;

			// Token: 0x040037AC RID: 14252
			public Vector2 ChaserVelocity;
		}

		// Token: 0x0200046A RID: 1130
		[CompilerGenerated]
		private sealed class <>c__DisplayClass47_0
		{
			// Token: 0x06002C06 RID: 11270 RVA: 0x001B5BB4 File Offset: 0x001B3DB4
			public <>c__DisplayClass47_0()
			{
			}

			// Token: 0x06002C07 RID: 11271 RVA: 0x001B5BC8 File Offset: 0x001B3DC8
			internal string <FormatWith>b__0(Match match)
			{
				/*
An exception occurred when decompiling this method (06002C07)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String Terraria.Utils/<>c__DisplayClass47_0::<FormatWith>b__0(System.Text.RegularExpressions.Match)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_1:
	stloc:object(var_2_1C, ldfld:object('<>c__DisplayClass47_0'::obj, ldloc:'<>c__DisplayClass47_0'(this)))
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

			// Token: 0x040037AD RID: 14253
			public PropertyDescriptorCollection properties;

			// Token: 0x040037AE RID: 14254
			public object obj;
		}

		// Token: 0x0200046B RID: 1131
		[CompilerGenerated]
		[StructLayout(3)]
		private struct <>c__DisplayClass149_0
		{
			// Token: 0x040037AF RID: 14255
			public Point lineMinOffset;

			// Token: 0x040037B0 RID: 14256
			public Point lineMaxOffset;

			// Token: 0x040037B1 RID: 14257
			public Utils.TileActionAttempt plot;
		}

		// Token: 0x0200046C RID: 1132
		[CompilerGenerated]
		[StructLayout(3)]
		private struct <>c__DisplayClass150_0
		{
			// Token: 0x040037B2 RID: 14258
			public int curLength;

			// Token: 0x040037B3 RID: 14259
			public int length;

			// Token: 0x040037B4 RID: 14260
			public Point lineStartMinOffset;

			// Token: 0x040037B5 RID: 14261
			public Vector2D start;

			// Token: 0x040037B6 RID: 14262
			public Vector2D perpOffset;

			// Token: 0x040037B7 RID: 14263
			public double halfWidth;

			// Token: 0x040037B8 RID: 14264
			public Point lineStartMaxOffset;

			// Token: 0x040037B9 RID: 14265
			public Point lineMinOffset;

			// Token: 0x040037BA RID: 14266
			public int x0;

			// Token: 0x040037BB RID: 14267
			public int y0;

			// Token: 0x040037BC RID: 14268
			public Point lineMaxOffset;

			// Token: 0x040037BD RID: 14269
			public Utils.TileActionAttempt plot;
		}
	}
}
