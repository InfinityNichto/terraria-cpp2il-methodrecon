using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameInput;

namespace Terraria.DataStructures
{
	// Token: 0x0200067E RID: 1662
	public abstract class TileEntity
	{
		// Token: 0x06003753 RID: 14163 RVA: 0x00221738 File Offset: 0x0021F938
		public static int AssignNewID()
		{
			/*
An exception occurred when decompiling this method (06003753)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.DataStructures.TileEntity::AssignNewID()

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

		// Token: 0x1400003F RID: 63
		// (add) Token: 0x06003754 RID: 14164 RVA: 0x00221748 File Offset: 0x0021F948
		// (remove) Token: 0x06003755 RID: 14165 RVA: 0x00221764 File Offset: 0x0021F964
		public static event Action _UpdateStart
		{
			[CompilerGenerated]
			add
			{
				if (!true)
				{
				}
				Delegate @delegate;
				if (@delegate != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (!true)
				{
				}
				Delegate @delegate;
				if (@delegate != null)
				{
				}
			}
		}

		// Token: 0x14000040 RID: 64
		// (add) Token: 0x06003756 RID: 14166 RVA: 0x00221780 File Offset: 0x0021F980
		// (remove) Token: 0x06003757 RID: 14167 RVA: 0x0022179C File Offset: 0x0021F99C
		public static event Action _UpdateEnd
		{
			[CompilerGenerated]
			add
			{
				if (!true)
				{
				}
				Delegate @delegate;
				if (@delegate != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (!true)
				{
				}
				Delegate @delegate;
				if (@delegate != null)
				{
				}
			}
		}

		// Token: 0x06003758 RID: 14168 RVA: 0x002217B8 File Offset: 0x0021F9B8
		public static void Clear()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06003759 RID: 14169 RVA: 0x002217C8 File Offset: 0x0021F9C8
		public static void UpdateStart()
		{
			if (!true)
			{
			}
			if (true)
			{
				return;
			}
		}

		// Token: 0x0600375A RID: 14170 RVA: 0x002217DC File Offset: 0x0021F9DC
		public static void UpdateEnd()
		{
			if (!true)
			{
			}
			if (true)
			{
				return;
			}
		}

		// Token: 0x0600375B RID: 14171 RVA: 0x002217F0 File Offset: 0x0021F9F0
		public static void InitializeAll()
		{
			if (!true)
			{
			}
		}

		// Token: 0x0600375C RID: 14172 RVA: 0x000021DB File Offset: 0x000003DB
		public static int GetKey(int x, int y)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600375D RID: 14173 RVA: 0x00221800 File Offset: 0x0021FA00
		public static void PlaceEntityNet(int x, int y, int type)
		{
			if (!true)
			{
			}
			long num = 0L;
			bool flag = WorldGen.InWorld(x, y, (int)num);
			if (!true)
			{
			}
		}

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x0600375E RID: 14174 RVA: 0x00221824 File Offset: 0x0021FA24
		public int PositionKey
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600375E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.DataStructures.TileEntity::get_PositionKey()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	stloc:int16(var_0_0B, ldfld:int16(Point16::Y, ldfld:Point16[exp:valuetype Terraria.DataStructures.Point16&](TileEntity::Position, ldloc:TileEntity(this))))
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

		// Token: 0x0600375F RID: 14175 RVA: 0x00221840 File Offset: 0x0021FA40
		public virtual void Update()
		{
		}

		// Token: 0x06003760 RID: 14176 RVA: 0x00221850 File Offset: 0x0021FA50
		public static void Write(BinaryWriter writer, TileEntity ent, bool networkSend = false)
		{
			byte b = ent.type;
		}

		// Token: 0x06003761 RID: 14177 RVA: 0x00221864 File Offset: 0x0021FA64
		public static TileEntity Read(BinaryReader reader, bool networkSend = false)
		{
			TileEntity tileEntity;
			tileEntity.ReadInner(reader, networkSend);
			return tileEntity;
		}

		// Token: 0x06003762 RID: 14178 RVA: 0x0022187C File Offset: 0x0021FA7C
		public static TileEntity ReadPos32(BinaryReader reader, bool networkSend = false)
		{
			TileEntity tileEntity;
			tileEntity.ReadInnerPos32(reader, networkSend);
			return tileEntity;
		}

		// Token: 0x06003763 RID: 14179 RVA: 0x00221894 File Offset: 0x0021FA94
		private void WriteInner(BinaryWriter writer, bool networkSend)
		{
			int id = this.ID;
			Point16 position = this.Position;
			short y = this.Position.Y;
		}

		// Token: 0x06003764 RID: 14180 RVA: 0x002218BC File Offset: 0x0021FABC
		private void ReadInner(BinaryReader reader, bool networkSend)
		{
			this.ID = reader;
			this.Position = reader;
		}

		// Token: 0x06003765 RID: 14181 RVA: 0x002218D8 File Offset: 0x0021FAD8
		private void ReadInnerPos32(BinaryReader reader, bool networkSend)
		{
			this.ID = reader;
			this.Position = reader;
		}

		// Token: 0x06003766 RID: 14182 RVA: 0x002218F4 File Offset: 0x0021FAF4
		public virtual void WriteExtraData(BinaryWriter writer, bool networkSend)
		{
		}

		// Token: 0x06003767 RID: 14183 RVA: 0x00221904 File Offset: 0x0021FB04
		public virtual void ReadExtraData(BinaryReader reader, bool networkSend)
		{
		}

		// Token: 0x06003768 RID: 14184 RVA: 0x00221914 File Offset: 0x0021FB14
		public virtual void OnPlayerUpdate(Player player)
		{
		}

		// Token: 0x06003769 RID: 14185 RVA: 0x00221924 File Offset: 0x0021FB24
		public static bool IsOccupied(int id, [Out] int interactingPlayer)
		{
			/*
An exception occurred when decompiling this method (06003769)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.DataStructures.TileEntity::IsOccupied(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0011:
	stfld:int32(int32::m_value, ldloc:int32[exp:int32&](id), ldloc:int64[exp:int32](var_1_0A))
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

		// Token: 0x0600376A RID: 14186 RVA: 0x0022194C File Offset: 0x0021FB4C
		public virtual void OnInventoryDraw(Player player, SpriteBatch spriteBatch)
		{
		}

		// Token: 0x0600376B RID: 14187 RVA: 0x0022195C File Offset: 0x0021FB5C
		public virtual string GetItemGamepadInstructions(int slot = 0)
		{
			return "";
		}

		// Token: 0x0600376C RID: 14188 RVA: 0x00221970 File Offset: 0x0021FB70
		public virtual bool TryGetItemGamepadOverrideInstructions(Item[] inv, int context, int slot, [Out] string instruction)
		{
		}

		// Token: 0x0600376D RID: 14189 RVA: 0x00221980 File Offset: 0x0021FB80
		public virtual bool OverrideItemSlotHover(Item[] inv, int context = 0, int slot = 0)
		{
		}

		// Token: 0x0600376E RID: 14190 RVA: 0x00221990 File Offset: 0x0021FB90
		public virtual bool OverrideItemSlotLeftClick(Item[] inv, int context = 0, int slot = 0)
		{
		}

		// Token: 0x0600376F RID: 14191 RVA: 0x002219A0 File Offset: 0x0021FBA0
		public static void BasicOpenCloseInteraction(Player player, int x, int y, int id)
		{
			int num = 1;
			player.CloseSign();
			if (num == 0)
			{
			}
			bool logicHost = Main.LogicHost;
			Main.stackSplit = 600;
			long num2 = 0L;
			player.GamepadEnableGrappleCooldown();
			bool flag = TileEntity.IsOccupied(id, (int)num2);
			TileEntity.SetInteractionAnchor(player, x, y, id);
			int whoAmI = player.whoAmI;
			int myPlayer = Main.myPlayer;
			TileEntity tileEntity;
			if (tileEntity != null)
			{
			}
		}

		// Token: 0x06003770 RID: 14192 RVA: 0x00221A34 File Offset: 0x0021FC34
		public static void SetInteractionAnchor(Player player, int x, int y, int id)
		{
			long num = 0L;
			player.chest = 1;
			player.SetTalkNPC(x, num != 0L);
			int whoAmI = player.whoAmI;
			if (!true)
			{
			}
			int myPlayer = Main.myPlayer;
			if (!true)
			{
			}
			Main.playerInventory = true;
			TriggersSet justPressed = PlayerInput.Triggers.JustPressed;
			long num2 = 0L;
			justPressed.Grapple = num2 != 0L;
			PlayerInteractionAnchor tileEntityAnchor = player.tileEntityAnchor;
			player.tileEntityAnchor = id;
			player.tileEntityAnchor.X = x;
			player.tileEntityAnchor.Y = y;
		}

		// Token: 0x06003771 RID: 14193 RVA: 0x00221AB0 File Offset: 0x0021FCB0
		public virtual void RegisterTileEntityID(int assignedID)
		{
		}

		// Token: 0x06003772 RID: 14194 RVA: 0x00221AC0 File Offset: 0x0021FCC0
		public virtual void NetPlaceEntityAttempt(int x, int y)
		{
		}

		// Token: 0x06003773 RID: 14195 RVA: 0x00221AD0 File Offset: 0x0021FCD0
		public virtual bool IsTileValidForEntity(int x, int y)
		{
		}

		// Token: 0x06003774 RID: 14196 RVA: 0x00221AE0 File Offset: 0x0021FCE0
		public virtual TileEntity GenerateInstance()
		{
		}

		// Token: 0x06003775 RID: 14197 RVA: 0x00221AF0 File Offset: 0x0021FCF0
		protected TileEntity()
		{
		}

		// Token: 0x06003776 RID: 14198 RVA: 0x00221B04 File Offset: 0x0021FD04
		// Note: this type is marked as 'beforefieldinit'.
		static TileEntity()
		{
		}

		// Token: 0x04007876 RID: 30838
		public static TileEntitiesManager manager;

		// Token: 0x04007877 RID: 30839
		public const int MaxEntitiesPerChunk = 1000;

		// Token: 0x04007878 RID: 30840
		public static object EntityCreationLock;

		// Token: 0x04007879 RID: 30841
		public static Dictionary<int, TileEntity> ByID;

		// Token: 0x0400787A RID: 30842
		public static Dictionary<int, TileEntity> ByPosition;

		// Token: 0x0400787B RID: 30843
		public static int TileEntitiesNextID;

		// Token: 0x0400787C RID: 30844
		[CompilerGenerated]
		private static Action _UpdateStart;

		// Token: 0x0400787D RID: 30845
		[CompilerGenerated]
		private static Action _UpdateEnd;

		// Token: 0x0400787E RID: 30846
		public int ID;

		// Token: 0x0400787F RID: 30847
		public Point16 Position;

		// Token: 0x04007880 RID: 30848
		public byte type;
	}
}
