using System;
using System.IO;
using Terraria.Net;

namespace Terraria.GameContent.NetModules
{
	// Token: 0x020009F8 RID: 2552
	public class NetCreativeUnlocksPlayerReportModule : NetModule
	{
		// Token: 0x06004B79 RID: 19321 RVA: 0x0026EE24 File Offset: 0x0026D024
		public static NetPacket SerializeSacrificeRequest(int itemId, int amount)
		{
			/*
An exception occurred when decompiling this method (06004B79)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.Net.NetPacket Terraria.GameContent.NetModules.NetCreativeUnlocksPlayerReportModule::SerializeSacrificeRequest(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:BinaryWriter(var_0_0B, callgetter:BinaryWriter(NetPacket::get_Writer, call:NetPacket[exp:valuetype Terraria.Net.NetPacket&](NetModule::CreatePacket, ldc.i4:int32(5))))
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

		// Token: 0x06004B7A RID: 19322 RVA: 0x0026EE3C File Offset: 0x0026D03C
		public override bool Deserialize(BinaryReader reader, int userId)
		{
			return true;
		}

		// Token: 0x06004B7B RID: 19323 RVA: 0x0026EE4C File Offset: 0x0026D04C
		public NetCreativeUnlocksPlayerReportModule()
		{
		}

		// Token: 0x040085B8 RID: 34232
		private const byte _requestItemSacrificeId = 0;
	}
}
