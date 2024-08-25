using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Text;
using System.Threading;

namespace Terraria
{
	// Token: 0x02000452 RID: 1106
	public static class Program
	{
		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x06002972 RID: 10610 RVA: 0x0019B850 File Offset: 0x00199A50
		public static float LoadedPercentage
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002972)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.Program::get_LoadedPercentage()

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

		// Token: 0x06002973 RID: 10611 RVA: 0x0019B860 File Offset: 0x00199A60
		public static void StartForceLoad()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06002974 RID: 10612 RVA: 0x0019B870 File Offset: 0x00199A70
		public static void ForceLoadThread(object threadContext)
		{
		}

		// Token: 0x06002975 RID: 10613 RVA: 0x0019B880 File Offset: 0x00199A80
		private static void ForceJITOnAssembly(Assembly assembly)
		{
		}

		// Token: 0x06002976 RID: 10614 RVA: 0x0019B898 File Offset: 0x00199A98
		private static void ForceStaticInitializers(Assembly assembly)
		{
		}

		// Token: 0x06002977 RID: 10615 RVA: 0x0019B8A8 File Offset: 0x00199AA8
		private static void ForceLoadAssembly(Assembly assembly, bool initializeStaticMembers)
		{
			Program.ForceJITOnAssembly(assembly);
			Program.ForceStaticInitializers(assembly);
		}

		// Token: 0x06002978 RID: 10616 RVA: 0x0019B8C4 File Offset: 0x00199AC4
		private static void ForceLoadAssembly(string name, bool initializeStaticMembers)
		{
			Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
		}

		// Token: 0x06002979 RID: 10617 RVA: 0x0019B8F8 File Offset: 0x00199AF8
		private static void SetupLogging()
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			string text;
			bool flag = text == "";
			if (!true)
			{
			}
			DateTime now = DateTime.Now;
		}

		// Token: 0x0600297A RID: 10618 RVA: 0x0019B94C File Offset: 0x00199B4C
		private static void InitializeConsoleOutput()
		{
			if (!true)
			{
			}
			bool isAttached = Debugger.IsAttached;
			Console.OutputEncoding = Encoding.UTF8;
			Encoding utf = Encoding.UTF8;
			Console.InputEncoding = utf;
		}

		// Token: 0x0600297B RID: 10619 RVA: 0x0019B988 File Offset: 0x00199B88
		public static void LaunchGame(string[] args, bool monoArgs = false)
		{
			int num = 1;
			Thread.CurrentThread.Name = "Main Thread";
			if (num == 0)
			{
			}
			string[] array = Utils.ConvertMonoArgsToDotNet(args);
			if (num == 0)
			{
			}
			Dictionary<string, string> dictionary = Utils.ParseArguements(array);
			int num2 = 8;
			int num3 = 8;
			bool flag = ThreadPool.SetMinThreads(num2, num3);
			int num4 = 1;
			if (num4 == 0)
			{
			}
			Program.InitializeConsoleOutput();
			Program.SetupLogging();
			if (num4 == 0)
			{
			}
			Lang.InitializeLegacyLocalization();
		}

		// Token: 0x0600297C RID: 10620 RVA: 0x0019BA18 File Offset: 0x00199C18
		private static void DisplayException(Exception e)
		{
		}

		// Token: 0x0600297D RID: 10621 RVA: 0x0019BA28 File Offset: 0x00199C28
		// Note: this type is marked as 'beforefieldinit'.
		static Program()
		{
		}

		// Token: 0x040036A2 RID: 13986
		public static bool IsXna;

		// Token: 0x040036A3 RID: 13987
		public static bool IsFna;

		// Token: 0x040036A4 RID: 13988
		public static bool IsMono;

		// Token: 0x040036A5 RID: 13989
		public const bool IsDebug = false;

		// Token: 0x040036A6 RID: 13990
		public static Dictionary<string, string> LaunchParameters;

		// Token: 0x040036A7 RID: 13991
		public static string SavePath;

		// Token: 0x040036A8 RID: 13992
		public const string TerrariaSaveFolderPath = "Terraria";

		// Token: 0x040036A9 RID: 13993
		private static int ThingsToLoad;

		// Token: 0x040036AA RID: 13994
		private static int ThingsLoaded;

		// Token: 0x040036AB RID: 13995
		public static bool LoadedEverything;

		// Token: 0x040036AC RID: 13996
		public static IntPtr JitForcedMethodCache;
	}
}
