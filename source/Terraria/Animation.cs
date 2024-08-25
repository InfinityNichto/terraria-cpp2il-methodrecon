using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Terraria.DataStructures;

namespace Terraria
{
	// Token: 0x02000421 RID: 1057
	public class Animation
	{
		// Token: 0x06002746 RID: 10054 RVA: 0x0018C5E4 File Offset: 0x0018A7E4
		public static void Initialize()
		{
		}

		// Token: 0x06002747 RID: 10055 RVA: 0x0018C5F4 File Offset: 0x0018A7F4
		private void SetDefaults(int type)
		{
		}

		// Token: 0x06002748 RID: 10056 RVA: 0x0018C6CC File Offset: 0x0018A8CC
		public static void NewTemporaryAnimation(int type, ushort tileType, int x, int y)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06002749 RID: 10057 RVA: 0x0018C6F0 File Offset: 0x0018A8F0
		private static void RemoveTemporaryAnimation(short x, short y)
		{
		}

		// Token: 0x0600274A RID: 10058 RVA: 0x0018C700 File Offset: 0x0018A900
		public static void UpdateAll()
		{
		}

		// Token: 0x0600274B RID: 10059 RVA: 0x0018C728 File Offset: 0x0018A928
		public void Update()
		{
			bool temporary = this._temporary;
			if (temporary)
			{
				if (!temporary)
				{
				}
				Tile tile;
				ushort type = tile.type;
				ushort tileType = this._tileType;
			}
			int frameCounter = this._frameCounter;
			int[] frameData = this._frameData;
			this._frameCounter = frameCounter;
			int frame = this._frame;
			int frameCounter2 = this._frameCounter;
			this._frame = frame;
			if (this._temporary)
			{
				short y = this._coordinates.Y;
				Point16 coordinates = this._coordinates;
			}
		}

		// Token: 0x0600274C RID: 10060 RVA: 0x0018C7A0 File Offset: 0x0018A9A0
		public static bool GetTemporaryFrame(int x, int y, [Out] int frameData)
		{
			/*
An exception occurred when decompiling this method (0600274C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Animation::GetTemporaryFrame(System.Int32,System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int64(var_1_03, ldc.i4:int64(0))
	stfld:int32(int32::m_value, ldloc:int32[exp:int32&](y), ldloc:int64[exp:int32](var_1_03))
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

		// Token: 0x0600274D RID: 10061 RVA: 0x0018C7BC File Offset: 0x0018A9BC
		public Animation()
		{
		}

		// Token: 0x0400338B RID: 13195
		private static List<Animation> _animations;

		// Token: 0x0400338C RID: 13196
		private static Dictionary<Point16, Animation> _temporaryAnimations;

		// Token: 0x0400338D RID: 13197
		private static List<Point16> _awaitingRemoval;

		// Token: 0x0400338E RID: 13198
		private static List<Animation> _awaitingAddition;

		// Token: 0x0400338F RID: 13199
		private bool _temporary;

		// Token: 0x04003390 RID: 13200
		private Point16 _coordinates;

		// Token: 0x04003391 RID: 13201
		private ushort _tileType;

		// Token: 0x04003392 RID: 13202
		private int _frame;

		// Token: 0x04003393 RID: 13203
		private int _frameMax;

		// Token: 0x04003394 RID: 13204
		private int _frameCounter;

		// Token: 0x04003395 RID: 13205
		private int _frameCounterMax;

		// Token: 0x04003396 RID: 13206
		private int[] _frameData;
	}
}
