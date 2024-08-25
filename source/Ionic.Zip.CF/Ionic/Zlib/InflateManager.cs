using System;

namespace Ionic.Zlib
{
	// Token: 0x02000049 RID: 73
	internal sealed class InflateManager
	{
		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000387 RID: 903 RVA: 0x0000D8F4 File Offset: 0x0000BAF4
		// (set) Token: 0x06000388 RID: 904 RVA: 0x0000D908 File Offset: 0x0000BB08
		internal bool HandleRfc1950HeaderBytes
		{
			get
			{
				return this._handleRfc1950HeaderBytes;
			}
			set
			{
			}
		}

		// Token: 0x06000389 RID: 905 RVA: 0x0000D918 File Offset: 0x0000BB18
		public InflateManager()
		{
		}

		// Token: 0x0600038A RID: 906 RVA: 0x0000D934 File Offset: 0x0000BB34
		public InflateManager(bool expectRfc1950HeaderBytes)
		{
		}

		// Token: 0x0600038B RID: 907 RVA: 0x0000D950 File Offset: 0x0000BB50
		internal int Reset()
		{
			/*
An exception occurred when decompiling this method (0600038B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Ionic.Zlib.InflateManager::Reset()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:ZlibCodec(var_0_06, ldfld:ZlibCodec(InflateManager::_codec, ldloc:InflateManager(this)))
	stloc:bool(var_1_0D, ldfld:bool(InflateManager::_handleRfc1950HeaderBytes, ldloc:InflateManager(this)))
	stloc:InflateBlocks(var_2_14, ldfld:InflateBlocks(InflateManager::blocks, ldloc:InflateManager(this)))
	stfld:InflateManagerMode(InflateManager::mode, ldloc:InflateManager(this), ldc.i4:InflateManagerMode(7))
	stloc:uint32(var_3_22, call:uint32(InflateBlocks::Reset, ldloc:InflateBlocks(var_2_14)))
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

		// Token: 0x0600038C RID: 908 RVA: 0x0000D984 File Offset: 0x0000BB84
		internal int End()
		{
			InflateBlocks inflateBlocks = this.blocks;
			if (inflateBlocks != null)
			{
				uint num = inflateBlocks.Reset();
				return;
			}
		}

		// Token: 0x0600038D RID: 909 RVA: 0x0000D9A4 File Offset: 0x0000BBA4
		internal int Initialize(ZlibCodec codec, int w)
		{
			/*
An exception occurred when decompiling this method (0600038D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Ionic.Zlib.InflateManager::Initialize(Ionic.Zlib.ZlibCodec,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stfld:ZlibCodec(InflateManager::_codec, ldloc:InflateManager(this), ldloc:ZlibCodec(codec))
	stloc:bool(var_0_0D, ldfld:bool(InflateManager::_handleRfc1950HeaderBytes, ldloc:InflateManager(this)))
	stfld:int32(InflateManager::wbits, ldloc:InflateManager(this), ldloc:int32(w))
	stloc:ZlibCodec(var_1_1B, ldfld:ZlibCodec(InflateManager::_codec, ldloc:InflateManager(this)))
	stloc:bool(var_2_22, ldfld:bool(InflateManager::_handleRfc1950HeaderBytes, ldloc:InflateManager(this)))
	stloc:InflateBlocks(var_3_29, ldfld:InflateBlocks(InflateManager::blocks, ldloc:InflateManager(this)))
	stfld:InflateManagerMode(InflateManager::mode, ldloc:InflateManager(this), ldc.i4:InflateManagerMode(7))
	stloc:uint32(var_4_37, call:uint32(InflateBlocks::Reset, ldloc:InflateBlocks(var_3_29)))
	stloc:int32(var_6_42, call:int32(InflateManager::End, ldloc:InflateManager(this)))
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

		// Token: 0x0600038E RID: 910 RVA: 0x0000D9F4 File Offset: 0x0000BBF4
		internal int Inflate(FlushType flush)
		{
			while (this._codec.InputBuffer == null)
			{
			}
			InflateManager.InflateManagerMode inflateManagerMode = this.mode;
			return 1;
		}

		// Token: 0x0600038F RID: 911 RVA: 0x0000DE94 File Offset: 0x0000C094
		internal int SetDictionary(byte[] dictionary)
		{
			/*
An exception occurred when decompiling this method (0600038F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Ionic.Zlib.InflateManager::SetDictionary(System.Byte[])

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0029:
	stloc:int32(var_4_2A, ldc.i4:int32(1))
	stfld:uint32(ZlibCodec::_Adler32, ldloc:ZlibCodec(var_3_20), ldloc:int32[exp:uint32](var_4_2A))
	stloc:int32(var_5_3A, ldfld:int32(InflateManager::wbits, ldloc:InflateManager(this)))
	stloc:int64(var_6_3D, ldc.i4:int64(0))
	stloc:InflateBlocks(var_7_45, ldfld:InflateBlocks(InflateManager::blocks, ldloc:InflateManager(this)))
	stloc:int64(var_8_48, ldc.i4:int64(0))
	stloc:uint8[](var_9_51, ldfld:uint8[](InflateBlocks::window, ldloc:InflateBlocks(var_7_45)))
	call:void(Array::Copy, ldloc:uint8[][exp:Array](dictionary), ldloc:int64[exp:int32](var_6_3D), ldloc:uint8[][exp:Array](var_9_51), ldloc:int64[exp:int32](var_8_48), ldc.i4:int32(43151360))
	stloc:int32(var_11_68, ldc.i4:int32(7))
	stfld:int32(InflateBlocks::readAt, ldloc:InflateBlocks(var_7_45), ldc.i4:int32(43151360))
	stfld:InflateManagerMode(InflateManager::mode, ldloc:InflateManager(this), ldloc:int32[exp:InflateManagerMode](var_11_68))
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

		// Token: 0x06000390 RID: 912 RVA: 0x0000DF20 File Offset: 0x0000C120
		internal int Sync()
		{
			/*
An exception occurred when decompiling this method (06000390)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Ionic.Zlib.InflateManager::Sync()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_003D:
	stloc:ZlibCodec(var_7_43, ldfld:ZlibCodec(InflateManager::_codec, ldloc:InflateManager(this)))
	stloc:ZlibCodec(var_8_4B, ldfld:ZlibCodec(InflateManager::_codec, ldloc:InflateManager(this)))
	stloc:uint8[](var_9_54, ldfld:uint8[](ZlibCodec::InputBuffer, ldloc:ZlibCodec(var_8_4B)))
	stloc:int32(var_10_5D, ldfld:int32(ZlibCodec::NextIn, ldloc:ZlibCodec(var_8_4B)))
	stloc:int64(var_11_66, ldfld:int64(ZlibCodec::TotalBytesIn, ldloc:ZlibCodec(var_8_4B)))
	stfld:int32(ZlibCodec::NextIn, ldloc:ZlibCodec(var_8_4B), ldloc:uint8[][exp:int32](var_9_54))
	stfld:int64(ZlibCodec::TotalBytesIn, ldloc:ZlibCodec(var_8_4B), ldloc:int32[exp:int64](var_3_1E))
	stfld:int64(ZlibCodec::TotalBytesIn, ldloc:ZlibCodec(var_8_4B), ldloc:int32[exp:int64](var_3_1E))
	stfld:int32(InflateManager::marker, ldloc:InflateManager(this), ldloc:int32(var_4))
	stloc:int64(var_12_90, ldfld:int64(ZlibCodec::TotalBytesOut, ldloc:ZlibCodec(var_8_4B)))
	stloc:bool(var_13_98, ldfld:bool(InflateManager::_handleRfc1950HeaderBytes, ldloc:InflateManager(this)))
	stloc:InflateBlocks(var_14_A0, ldfld:InflateBlocks(InflateManager::blocks, ldloc:InflateManager(this)))
	stloc:int32(var_15_A3, ldc.i4:int32(7))
	stfld:InflateManagerMode(InflateManager::mode, ldloc:InflateManager(this), ldloc:bool[exp:InflateManagerMode](var_13_98))
	stloc:uint32(var_16_B4, call:uint32(InflateBlocks::Reset, ldloc:InflateBlocks(var_14_A0)))
	stloc:ZlibCodec(var_17_BC, ldfld:ZlibCodec(InflateManager::_codec, ldloc:InflateManager(this)))
	stfld:int64(ZlibCodec::TotalBytesIn, ldloc:ZlibCodec(var_17_BC), ldloc:int32[exp:int64](var_3_1E))
	stfld:int64(ZlibCodec::TotalBytesOut, ldloc:ZlibCodec(var_17_BC), ldloc:int64(var_12_90))
	stfld:InflateManagerMode(InflateManager::mode, ldloc:InflateManager(this), ldloc:int32[exp:InflateManagerMode](var_15_A3))
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

		// Token: 0x06000391 RID: 913 RVA: 0x0000E008 File Offset: 0x0000C208
		internal int SyncPoint(ZlibCodec z)
		{
			/*
An exception occurred when decompiling this method (06000391)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Ionic.Zlib.InflateManager::SyncPoint(Ionic.Zlib.ZlibCodec)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:InflateBlockMode(var_0_0B, ldfld:InflateBlockMode(InflateBlocks::mode, ldfld:InflateBlocks(InflateManager::blocks, ldloc:InflateManager(this))))
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

		// Token: 0x06000392 RID: 914 RVA: 0x0000E020 File Offset: 0x0000C220
		// Note: this type is marked as 'beforefieldinit'.
		static InflateManager()
		{
		}

		// Token: 0x04000273 RID: 627
		private const int PRESET_DICT = 32;

		// Token: 0x04000274 RID: 628
		private const int Z_DEFLATED = 8;

		// Token: 0x04000275 RID: 629
		private InflateManager.InflateManagerMode mode;

		// Token: 0x04000276 RID: 630
		internal ZlibCodec _codec;

		// Token: 0x04000277 RID: 631
		internal int method;

		// Token: 0x04000278 RID: 632
		internal uint computedCheck;

		// Token: 0x04000279 RID: 633
		internal uint expectedCheck;

		// Token: 0x0400027A RID: 634
		internal int marker;

		// Token: 0x0400027B RID: 635
		private bool _handleRfc1950HeaderBytes = true;

		// Token: 0x0400027C RID: 636
		internal int wbits;

		// Token: 0x0400027D RID: 637
		internal InflateBlocks blocks;

		// Token: 0x0400027E RID: 638
		private static readonly byte[] mark;

		// Token: 0x0200004A RID: 74
		private enum InflateManagerMode
		{
			// Token: 0x04000280 RID: 640
			METHOD,
			// Token: 0x04000281 RID: 641
			FLAG,
			// Token: 0x04000282 RID: 642
			DICT4,
			// Token: 0x04000283 RID: 643
			DICT3,
			// Token: 0x04000284 RID: 644
			DICT2,
			// Token: 0x04000285 RID: 645
			DICT1,
			// Token: 0x04000286 RID: 646
			DICT0,
			// Token: 0x04000287 RID: 647
			BLOCKS,
			// Token: 0x04000288 RID: 648
			CHECK4,
			// Token: 0x04000289 RID: 649
			CHECK3,
			// Token: 0x0400028A RID: 650
			CHECK2,
			// Token: 0x0400028B RID: 651
			CHECK1,
			// Token: 0x0400028C RID: 652
			DONE,
			// Token: 0x0400028D RID: 653
			BAD
		}
	}
}
