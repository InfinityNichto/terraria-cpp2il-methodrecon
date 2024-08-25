using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace Terraria.GameContent.Creative
{
	// Token: 0x02000A0B RID: 2571
	public class CreativePowerManager
	{
		// Token: 0x17000871 RID: 2161
		// (get) Token: 0x06004BE5 RID: 19429 RVA: 0x000021DB File Offset: 0x000003DB
		public static CreativePowerManager Instance
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000872 RID: 2162
		// (get) Token: 0x06004BE6 RID: 19430 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06004BE7 RID: 19431 RVA: 0x00270744 File Offset: 0x0026E944
		private static bool _initialized
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x06004BE8 RID: 19432 RVA: 0x00270754 File Offset: 0x0026E954
		public CreativePowerManager()
		{
		}

		// Token: 0x06004BE9 RID: 19433 RVA: 0x00270768 File Offset: 0x0026E968
		public void Register<T>(string nameInServerConfig) where T : ICreativePower, new()
		{
			int num = 1;
			ushort powersCount = this._powersCount;
			num.m_value = (int)powersCount;
		}

		// Token: 0x06004BEA RID: 19434 RVA: 0x002707B8 File Offset: 0x0026E9B8
		public T GetPower<T>() where T : class, ICreativePower
		{
			Dictionary<ushort, ICreativePower> powersById;
			do
			{
				powersById = this._powersById;
				if (powersById == null)
				{
					return;
				}
			}
			while (powersById != null);
			throw new InvalidCastException();
		}

		// Token: 0x06004BEB RID: 19435 RVA: 0x000021DB File Offset: 0x000003DB
		public ushort GetPowerId<T>() where T : ICreativePower
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06004BEC RID: 19436 RVA: 0x002707DC File Offset: 0x0026E9DC
		public bool TryGetPower(ushort id, [Out] ICreativePower power)
		{
			/*
An exception occurred when decompiling this method (06004BEC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.Creative.CreativePowerManager::TryGetPower(System.UInt16,Terraria.GameContent.Creative.ICreativePower)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.Dictionary`2<uint16, class Terraria.GameContent.Creative.ICreativePower>(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<uint16, class Terraria.GameContent.Creative.ICreativePower>(CreativePowerManager::_powersById, ldloc:CreativePowerManager(this)))
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

		// Token: 0x06004BED RID: 19437 RVA: 0x002707F0 File Offset: 0x0026E9F0
		public static void TryListingPermissionsFrom(string line)
		{
			int stringLength = line._stringLength;
			bool flag = line.ToLower().StartsWith("journeypermission_");
			string text = line.Substring(43134976);
			long num = 0L;
			string[] array;
			bool flag2 = int.TryParse(array.Trim(), (int)num);
			string text3;
			string text2 = text3.ToLower();
			CreativePowerManager.Initialize();
			Dictionary<string, ICreativePower> powersByName = CreativePowerManager.Instance._powersByName;
		}

		// Token: 0x06004BEE RID: 19438 RVA: 0x00270850 File Offset: 0x0026EA50
		public static void Initialize()
		{
			bool initialized = CreativePowerManager._initialized;
		}

		// Token: 0x06004BEF RID: 19439 RVA: 0x00270944 File Offset: 0x0026EB44
		public void Reset()
		{
			Dictionary<ushort, ICreativePower> powersById = this._powersById;
		}

		// Token: 0x06004BF0 RID: 19440 RVA: 0x0027097C File Offset: 0x0026EB7C
		public void SaveToWorld(BinaryWriter writer)
		{
			while (this._powersById == null)
			{
			}
		}

		// Token: 0x06004BF1 RID: 19441 RVA: 0x002709AC File Offset: 0x0026EBAC
		public void LoadFromWorld(BinaryReader reader, int versionGameWasLastSavedOn)
		{
			if (this._powersById != null)
			{
				return;
			}
		}

		// Token: 0x06004BF2 RID: 19442 RVA: 0x002709C4 File Offset: 0x0026EBC4
		public void ValidateWorld(BinaryReader reader, int versionGameWasLastSavedOn)
		{
			if (this._powersById != null)
			{
				return;
			}
		}

		// Token: 0x06004BF3 RID: 19443 RVA: 0x002709DC File Offset: 0x0026EBDC
		public static void SyncSplitScreenPlayer(int playerIndex)
		{
			if (!true)
			{
			}
			CreativePowerManager.Instance.SyncSplitScreenPlayerInternal(playerIndex);
		}

		// Token: 0x06004BF4 RID: 19444 RVA: 0x002709F8 File Offset: 0x0026EBF8
		private void SyncSplitScreenPlayerInternal(int playerIndex)
		{
			int num = 1;
			if (num == 0)
			{
			}
			num.m_value = playerIndex;
			if (num == 0)
			{
			}
			num.m_value = playerIndex;
			if (num == 0)
			{
			}
			int num2 = 1;
			Dictionary<ushort, ICreativePower> powersById = this._powersById;
			if (num2 != 0)
			{
			}
		}

		// Token: 0x06004BF5 RID: 19445 RVA: 0x00270A70 File Offset: 0x0026EC70
		public void SyncThingsToJoiningPlayer(int playerIndex)
		{
			Dictionary<ushort, ICreativePower> powersById = this._powersById;
		}

		// Token: 0x06004BF6 RID: 19446 RVA: 0x00270AC4 File Offset: 0x0026ECC4
		public void SaveToPlayer(Player player, BinaryWriter writer)
		{
			while (this._powersById == null)
			{
			}
		}

		// Token: 0x06004BF7 RID: 19447 RVA: 0x00270AF4 File Offset: 0x0026ECF4
		public void LoadToPlayer(Player player, BinaryReader reader, int versionGameWasLastSavedOn)
		{
			if (this._powersById != null)
			{
				return;
			}
			byte difficulty = player.difficulty;
			this.ResetPowersForPlayer(player);
		}

		// Token: 0x06004BF8 RID: 19448 RVA: 0x00270B18 File Offset: 0x0026ED18
		public void ApplyLoadedDataToPlayer(Player player)
		{
			while (this._powersById == null)
			{
			}
		}

		// Token: 0x06004BF9 RID: 19449 RVA: 0x00270B44 File Offset: 0x0026ED44
		public void ResetPowersForPlayer(Player player)
		{
			while (this._powersById == null)
			{
			}
		}

		// Token: 0x06004BFA RID: 19450 RVA: 0x00270B70 File Offset: 0x0026ED70
		public void ResetDataForNewPlayer(Player player)
		{
			while (this._powersById == null)
			{
			}
		}

		// Token: 0x04008617 RID: 34327
		private Dictionary<ushort, ICreativePower> _powersById;

		// Token: 0x04008618 RID: 34328
		private Dictionary<string, ICreativePower> _powersByName;

		// Token: 0x04008619 RID: 34329
		private ushort _powersCount;

		// Token: 0x0400861A RID: 34330
		private const string _powerPermissionsLineHeader = "journeypermission_";

		// Token: 0x02000A0C RID: 2572
		private class PowerTypeStorage<T> where T : ICreativePower
		{
			// Token: 0x06004BFB RID: 19451 RVA: 0x00270BA0 File Offset: 0x0026EDA0
			public PowerTypeStorage()
			{
			}

			// Token: 0x0400861B RID: 34331
			public static ushort Id;

			// Token: 0x0400861C RID: 34332
			public static string Name;
		}
	}
}
