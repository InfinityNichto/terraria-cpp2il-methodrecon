using System;
using System.IO;
using System.Runtime.CompilerServices;
using Terraria.GameContent.Ambience;
using Terraria.Net;

namespace Terraria.GameContent.NetModules
{
	// Token: 0x020009F2 RID: 2546
	public class NetAmbienceModule : NetModule
	{
		// Token: 0x06004B68 RID: 19304 RVA: 0x0026EC7C File Offset: 0x0026CE7C
		public static NetPacket SerializeSkyEntitySpawn(Player player, SkyEntityType type)
		{
			/*
An exception occurred when decompiling this method (06004B68)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.Net.NetPacket Terraria.GameContent.NetModules.NetAmbienceModule::SerializeSkyEntitySpawn(Terraria.Player,Terraria.GameContent.Ambience.SkyEntityType)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:BinaryWriter(var_1_0E, callgetter:BinaryWriter(NetPacket::get_Writer, call:NetPacket[exp:valuetype Terraria.Net.NetPacket&](NetModule::CreatePacket, ldc.i4:int32(6))))
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

		// Token: 0x06004B69 RID: 19305 RVA: 0x0026EC98 File Offset: 0x0026CE98
		public override bool Deserialize(BinaryReader reader, int userId)
		{
			if (!true)
			{
			}
			if (true)
			{
			}
			return true;
		}

		// Token: 0x06004B6A RID: 19306 RVA: 0x0026ECB0 File Offset: 0x0026CEB0
		public NetAmbienceModule()
		{
		}

		// Token: 0x020009F3 RID: 2547
		[CompilerGenerated]
		private sealed class <>c__DisplayClass1_0
		{
			// Token: 0x06004B6B RID: 19307 RVA: 0x0026ECC4 File Offset: 0x0026CEC4
			public <>c__DisplayClass1_0()
			{
			}

			// Token: 0x06004B6C RID: 19308 RVA: 0x0026ECD8 File Offset: 0x0026CED8
			internal void <Deserialize>b__0()
			{
				if (!true)
				{
				}
				byte b = this.playerId;
				SkyEntityType skyEntityType = this.type;
				int num = this.seed;
				!0 !;
				if (! != null)
				{
				}
			}

			// Token: 0x040085B0 RID: 34224
			public byte playerId;

			// Token: 0x040085B1 RID: 34225
			public SkyEntityType type;

			// Token: 0x040085B2 RID: 34226
			public int seed;
		}
	}
}
