using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Terraria.Utilities;

namespace Terraria.IO
{
	// Token: 0x02000562 RID: 1378
	public class PlayerFileData : FileData
	{
		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x0600337A RID: 13178 RVA: 0x001FF7B8 File Offset: 0x001FD9B8
		// (set) Token: 0x0600337B RID: 13179 RVA: 0x001FF7CC File Offset: 0x001FD9CC
		public Player Player
		{
			get
			{
				return this._player;
			}
			set
			{
				this._player = value;
				if (value != null)
				{
					string name = value.name;
					this.Name = name;
				}
			}
		}

		// Token: 0x0600337C RID: 13180 RVA: 0x001FF7F4 File Offset: 0x001FD9F4
		public void PreparePetProjectiles()
		{
			Player player = this._player;
			Vector2 position = this._player.miscEquips.position;
			Projectile uipetProjectile = this.UIPetProjectile;
			int num = 1;
			uipetProjectile.isAPreviewDummy = num != 0;
		}

		// Token: 0x0600337D RID: 13181 RVA: 0x001FF830 File Offset: 0x001FDA30
		public PlayerFileData()
		{
			if (!true)
			{
			}
			this._playTime = 1;
			base..ctor();
			this.Type = "Player";
		}

		// Token: 0x0600337E RID: 13182 RVA: 0x001FF858 File Offset: 0x001FDA58
		public PlayerFileData(string path, bool cloudSave)
		{
			if (!true)
			{
			}
			this._playTime = 1;
		}

		// Token: 0x0600337F RID: 13183 RVA: 0x001FF870 File Offset: 0x001FDA70
		public static PlayerFileData CreateAndSave(Player player)
		{
			/*
An exception occurred when decompiling this method (0600337F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.IO.PlayerFileData Terraria.IO.PlayerFileData::CreateAndSave(Terraria.Player)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:FileMetadata(var_0_06, call:FileMetadata(FileMetadata::FromCurrentSettings, ldc.i4:FileType(3)))
	stloc:FavoritesFile(var_4_10, callgetter:FavoritesFile(Main::get_LocalFavoriteData))
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

		// Token: 0x06003380 RID: 13184 RVA: 0x001FF890 File Offset: 0x001FDA90
		public override void SetAsActive()
		{
			if (!true)
			{
			}
			Main.ActivePlayerFileData = this;
			int myPlayer = Main.myPlayer;
			Player player = this._player;
			if (player == null || player != null)
			{
				Player player2 = this._player;
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06003381 RID: 13185 RVA: 0x001FF900 File Offset: 0x001FDB00
		public override void MoveToCloud()
		{
			if (this._isCloudSave)
			{
				return;
			}
			string name = this.Name;
			int num = 1;
			string playerPathFromName = Main.GetPlayerPathFromName(name, num != 0);
			bool flag = FileUtilities.MoveToCloud(this._path, playerPathFromName);
			long num2 = 0L;
			string fileName = base.GetFileName(num2 != 0L);
			string playerPath = Main.PlayerPath;
			string text2;
			string text3;
			string text = text2 + text3 + fileName + text2;
			bool flag2 = Directory.Exists(text);
			string[] files = Directory.GetFiles(text);
			string text4;
			if (("/" == null || "/" != null) && (fileName == null || fileName != null) && ("/" == null || "/" != null) && (text4 == null || text4 != null))
			{
				FavoritesFile localFavoriteData = Main.LocalFavoriteData;
				localFavoriteData.ClearEntry(this);
				int num3 = 1;
				this._isCloudSave = num3 != 0;
				this._path = num3;
				localFavoriteData.SaveFavorite(this);
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06003382 RID: 13186 RVA: 0x001FF9D4 File Offset: 0x001FDBD4
		public override void MoveToLocal()
		{
			if (this._isCloudSave)
			{
				string name = this.Name;
				long num = 0L;
				string playerPathFromName = Main.GetPlayerPathFromName(name, num != 0L);
				bool flag = FileUtilities.MoveToLocal(this._path, playerPathFromName);
				long num2 = 0L;
				string fileName = base.GetFileName(num2 != 0L);
				return;
			}
		}

		// Token: 0x06003383 RID: 13187 RVA: 0x001FFAA4 File Offset: 0x001FDCA4
		private bool MapBelongsToPath(string mapPath, string filePath)
		{
			bool flag = filePath.EndsWith(".map", StringComparison.CurrentCultureIgnoreCase);
			string text;
			return filePath.StartsWith(text, StringComparison.CurrentCultureIgnoreCase);
		}

		// Token: 0x06003384 RID: 13188 RVA: 0x001FFAC8 File Offset: 0x001FDCC8
		public void UpdatePlayTimer()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06003385 RID: 13189 RVA: 0x001FFB10 File Offset: 0x001FDD10
		public void OnLostFocus()
		{
			this.StopPlayTimer();
		}

		// Token: 0x06003386 RID: 13190 RVA: 0x001FFB24 File Offset: 0x001FDD24
		public void StartPlayTimer()
		{
			if (!this._isTimerActive)
			{
				Stopwatch timer = this._timer;
				this._isTimerActive = true;
				if (!timer.is_running)
				{
					timer.Start();
					return;
				}
			}
		}

		// Token: 0x06003387 RID: 13191 RVA: 0x001FFB58 File Offset: 0x001FDD58
		public void PausePlayTimer()
		{
			this.StopPlayTimer();
		}

		// Token: 0x06003388 RID: 13192 RVA: 0x001FFB6C File Offset: 0x001FDD6C
		public TimeSpan GetPlayTime()
		{
			/*
An exception occurred when decompiling this method (06003388)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.TimeSpan Terraria.IO.PlayerFileData::GetPlayTime()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:TimeSpan(var_2_11, call:TimeSpan(TimeSpan::op_Addition, ldloc:TimeSpan(var_0_06), ldloc:TimeSpan(var_1)))
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

		// Token: 0x06003389 RID: 13193 RVA: 0x001FFB8C File Offset: 0x001FDD8C
		public void UpdatePlayTimerAndKeepState()
		{
			TimeSpan playTime = this._playTime;
			Stopwatch timer = this._timer;
			bool is_running = timer.is_running;
			TimeSpan elapsed = timer.Elapsed;
			TimeSpan timeSpan = playTime + elapsed;
			Stopwatch timer2 = this._timer;
			this._playTime = timeSpan;
			timer2.Reset();
			if (is_running)
			{
				this._timer.Start();
				return;
			}
		}

		// Token: 0x0600338A RID: 13194 RVA: 0x001FFBE4 File Offset: 0x001FDDE4
		public void StopPlayTimer()
		{
			if (this._isTimerActive)
			{
				Stopwatch timer = this._timer;
				if (timer.is_running)
				{
					TimeSpan playTime = this._playTime;
					TimeSpan elapsed = timer.Elapsed;
					TimeSpan timeSpan = playTime + elapsed;
					Stopwatch timer2 = this._timer;
					this._playTime = timeSpan;
					timer2.Reset();
					return;
				}
			}
		}

		// Token: 0x0600338B RID: 13195 RVA: 0x001FFC38 File Offset: 0x001FDE38
		public void SetPlayTime(TimeSpan time)
		{
			this._playTime = time;
		}

		// Token: 0x0600338C RID: 13196 RVA: 0x001FFC4C File Offset: 0x001FDE4C
		public void Rename(string newName)
		{
			Player player = this._player;
			if (player != null)
			{
				string text = newName.Trim();
				player.name = text;
			}
			if (!true)
			{
			}
			long num = 0L;
			long num2 = 0L;
			Player.SavePlayer(this, num != 0L, num2 != 0L);
		}

		// Token: 0x04003C46 RID: 15430
		private Player _player;

		// Token: 0x04003C47 RID: 15431
		private TimeSpan _playTime;

		// Token: 0x04003C48 RID: 15432
		private readonly Stopwatch _timer;

		// Token: 0x04003C49 RID: 15433
		private bool _isTimerActive;

		// Token: 0x04003C4A RID: 15434
		public Projectile UIPetProjectile;

		// Token: 0x02000563 RID: 1379
		[CompilerGenerated]
		private sealed class <>c__DisplayClass14_0
		{
			// Token: 0x0600338D RID: 13197 RVA: 0x001FFC84 File Offset: 0x001FDE84
			public <>c__DisplayClass14_0()
			{
			}

			// Token: 0x0600338E RID: 13198 RVA: 0x001FFC98 File Offset: 0x001FDE98
			internal bool <MoveToLocal>b__0(string path)
			{
				string text = this.mapPath;
				bool flag = path.StartsWith(text, StringComparison.CurrentCultureIgnoreCase);
				return path.EndsWith(".map", StringComparison.CurrentCultureIgnoreCase);
			}

			// Token: 0x04003C4B RID: 15435
			public string mapPath;
		}
	}
}
