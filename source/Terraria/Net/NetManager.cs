using System;
using System.Collections.Generic;
using System.IO;
using Cpp2IlInjected;
using Terraria.UI;

namespace Terraria.Net
{
	// Token: 0x0200069D RID: 1693
	public class NetManager
	{
		// Token: 0x06003875 RID: 14453 RVA: 0x00225C78 File Offset: 0x00223E78
		private NetManager()
		{
		}

		// Token: 0x06003876 RID: 14454 RVA: 0x00225C8C File Offset: 0x00223E8C
		public void Register<T>() where T : NetModule, new()
		{
			int num = 1;
			ushort moduleCount = this._moduleCount;
			num.m_value = (int)moduleCount;
			Dictionary<ushort, NetModule> modules = this._modules;
			ushort moduleCount2 = this._moduleCount;
			ushort moduleCount3 = this._moduleCount;
			this._moduleCount = moduleCount3;
		}

		// Token: 0x06003877 RID: 14455 RVA: 0x000021DB File Offset: 0x000003DB
		public NetModule GetModule<T>() where T : NetModule
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003878 RID: 14456 RVA: 0x000021DB File Offset: 0x000003DB
		public ushort GetId<T>() where T : NetModule
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003879 RID: 14457 RVA: 0x00225CC8 File Offset: 0x00223EC8
		public void Read(BinaryReader reader, int userId, int readLength)
		{
			Dictionary<ushort, NetModule> modules = this._modules;
			Dictionary<ushort, NetModule> modules2 = this._modules;
			INetDiagnosticsUI activeNetDiagnosticsUI = Main.ActiveNetDiagnosticsUI;
		}

		// Token: 0x0600387A RID: 14458 RVA: 0x00225CEC File Offset: 0x00223EEC
		public void Broadcast(NetPacket packet, int ignoreClient = -1)
		{
			if (!true)
			{
			}
			this.SendToClient(packet, ignoreClient);
		}

		// Token: 0x0600387B RID: 14459 RVA: 0x00225D08 File Offset: 0x00223F08
		public void Broadcast(NetPacket packet, NetManager.BroadcastCondition conditionToBroadcast, int ignoreClient = -1)
		{
			if (!true)
			{
			}
		}

		// Token: 0x0600387C RID: 14460 RVA: 0x00225D1C File Offset: 0x00223F1C
		public void SendToSelf(NetPacket packet)
		{
			int myPlayer = Main.myPlayer;
			INetDiagnosticsUI activeNetDiagnosticsUI = Main.ActiveNetDiagnosticsUI;
		}

		// Token: 0x0600387D RID: 14461 RVA: 0x00225D3C File Offset: 0x00223F3C
		public void BroadcastOrLoopback(NetPacket packet)
		{
			if (!true)
			{
			}
			bool netHost = Main.NetHost;
		}

		// Token: 0x0600387E RID: 14462 RVA: 0x00225D68 File Offset: 0x00223F68
		public void SendToServerOrLoopback(NetPacket packet)
		{
			if (!true)
			{
			}
			bool netClientOnly = Main.NetClientOnly;
		}

		// Token: 0x0600387F RID: 14463 RVA: 0x00225D94 File Offset: 0x00223F94
		public void SendToServerAndSelf(NetPacket packet)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06003880 RID: 14464 RVA: 0x00225DB0 File Offset: 0x00223FB0
		public void SendToServer(NetPacket packet)
		{
		}

		// Token: 0x06003881 RID: 14465 RVA: 0x00225DC0 File Offset: 0x00223FC0
		public void SendToClient(NetPacket packet, int clientId)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				if (num == 0)
				{
				}
				return;
			}
			if (num == 0)
			{
			}
			if (num != 0)
			{
				this.SendToServerOrLoopback(packet);
				return;
			}
		}

		// Token: 0x06003882 RID: 14466 RVA: 0x00225E08 File Offset: 0x00224008
		public static void SendCallback(object state)
		{
		}

		// Token: 0x06003883 RID: 14467 RVA: 0x00225E1C File Offset: 0x0022401C
		// Note: this type is marked as 'beforefieldinit'.
		static NetManager()
		{
		}

		// Token: 0x04007937 RID: 31031
		public static NetManager Instance;

		// Token: 0x04007938 RID: 31032
		private Dictionary<ushort, NetModule> _modules;

		// Token: 0x04007939 RID: 31033
		private ushort _moduleCount;

		// Token: 0x0400793A RID: 31034
		public static bool LoopbackClientSends;

		// Token: 0x0200069E RID: 1694
		private class PacketTypeStorage<T> where T : NetModule
		{
			// Token: 0x06003884 RID: 14468 RVA: 0x00225E2C File Offset: 0x0022402C
			public PacketTypeStorage()
			{
			}

			// Token: 0x0400793B RID: 31035
			public static ushort Id;

			// Token: 0x0400793C RID: 31036
			public static T Module;
		}

		// Token: 0x0200069F RID: 1695
		public sealed class BroadcastCondition : MulticastDelegate
		{
			// Token: 0x06003885 RID: 14469 RVA: 0x00225E40 File Offset: 0x00224040
			public BroadcastCondition(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x06003886 RID: 14470 RVA: 0x00225E94 File Offset: 0x00224094
			public bool Invoke(int clientIndex)
			{
				/*
An exception occurred when decompiling this method (06003886)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Net.NetManager/BroadcastCondition::Invoke(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:native int(var_0_06, ldfld:native int(Delegate::method_code, ldloc:BroadcastCondition[exp:Delegate](this)))
	stloc:native int(var_1_0D, ldfld:native int(Delegate::invoke_impl, ldloc:BroadcastCondition[exp:Delegate](this)))
	stloc:native int(var_2_14, ldfld:native int(Delegate::method, ldloc:BroadcastCondition[exp:Delegate](this)))
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

			// Token: 0x06003887 RID: 14471 RVA: 0x000021DB File Offset: 0x000003DB
			public IAsyncResult BeginInvoke(int clientIndex, AsyncCallback callback, object @object)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06003888 RID: 14472 RVA: 0x000021DB File Offset: 0x000003DB
			public bool EndInvoke(IAsyncResult result)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}
	}
}
