using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Activation;

namespace System.Runtime.Remoting
{
	// Token: 0x02000343 RID: 835
	[ComVisible(true)]
	public static class RemotingConfiguration
	{
		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06001BE7 RID: 7143 RVA: 0x0003C1EC File Offset: 0x0003A3EC
		// (set) Token: 0x06001BE8 RID: 7144 RVA: 0x0003C1FC File Offset: 0x0003A3FC
		public static string ApplicationName
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001BE7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Runtime.Remoting.RemotingConfiguration::get_ApplicationName()

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
			set
			{
				if (!true)
				{
				}
			}
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06001BE9 RID: 7145 RVA: 0x0003C20C File Offset: 0x0003A40C
		public static string ProcessId
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001BE9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Runtime.Remoting.RemotingConfiguration::get_ProcessId()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_1_07, call:string(AppDomain::GetProcessGuid))
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
		}

		// Token: 0x06001BEA RID: 7146 RVA: 0x0003C220 File Offset: 0x0003A420
		internal static void LoadDefaultDelayedChannels()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (!false)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001BEB RID: 7147 RVA: 0x0003C2AC File Offset: 0x0003A4AC
		public static bool IsActivationAllowed(Type svrType)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!false)
			{
				return false;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001BEC RID: 7148 RVA: 0x0003C2DC File Offset: 0x0003A4DC
		public static ActivatedClientTypeEntry IsRemotelyActivatedClientType(Type svrType)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (!false)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001BED RID: 7149 RVA: 0x0003C310 File Offset: 0x0003A510
		public static WellKnownClientTypeEntry IsWellKnownClientType(Type svrType)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (!false)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001BEE RID: 7150 RVA: 0x0003C344 File Offset: 0x0003A544
		public static void RegisterActivatedClientType(ActivatedClientTypeEntry entry)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			Type obj_type = entry.obj_type;
			Type obj_type2 = entry.obj_type;
			Type obj_type3 = entry.obj_type;
			ActivationServices.EnableProxyActivation(entry.obj_type, true);
			if (!false)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001BEF RID: 7151 RVA: 0x0003C398 File Offset: 0x0003A598
		public static void RegisterActivatedServiceType(ActivatedServiceTypeEntry entry)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			Type obj_type = entry.obj_type;
			if (!false)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001BF0 RID: 7152 RVA: 0x0003C3D4 File Offset: 0x0003A5D4
		public static void RegisterWellKnownClientType(WellKnownClientTypeEntry entry)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			Type obj_type = entry.obj_type;
			Type obj_type2 = entry.obj_type;
			Type obj_type3 = entry.obj_type;
			ActivationServices.EnableProxyActivation(entry.obj_type, true);
			if (!false)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001BF1 RID: 7153 RVA: 0x0003C428 File Offset: 0x0003A628
		public static void RegisterWellKnownServiceType(WellKnownServiceTypeEntry entry)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			string obj_uri = entry.obj_uri;
			Type obj_type = entry.obj_type;
			string obj_uri2 = entry.obj_uri;
			WellKnownObjectMode obj_mode = entry.obj_mode;
			ServerIdentity serverIdentity = RemotingServices.CreateWellKnownServerIdentity(obj_type, obj_uri2, obj_mode);
			if (!false)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001BF2 RID: 7154 RVA: 0x0003C488 File Offset: 0x0003A688
		internal static void RegisterChannelTemplate(ChannelData channel)
		{
			if (!true)
			{
			}
			string id = channel.Id;
		}

		// Token: 0x06001BF3 RID: 7155 RVA: 0x0003C4A0 File Offset: 0x0003A6A0
		internal static void RegisterClientProviderTemplate(ProviderData prov)
		{
			if (!true)
			{
			}
			string id = prov.Id;
		}

		// Token: 0x06001BF4 RID: 7156 RVA: 0x0003C4B8 File Offset: 0x0003A6B8
		internal static void RegisterServerProviderTemplate(ProviderData prov)
		{
			if (!true)
			{
			}
			string id = prov.Id;
		}

		// Token: 0x06001BF5 RID: 7157 RVA: 0x0003C4D0 File Offset: 0x0003A6D0
		internal static void RegisterChannels(ArrayList channels, bool onlyDelayed)
		{
		}

		// Token: 0x06001BF6 RID: 7158 RVA: 0x0003C624 File Offset: 0x0003A824
		internal static void RegisterTypes(ArrayList types)
		{
		}

		// Token: 0x06001BF7 RID: 7159 RVA: 0x0003C684 File Offset: 0x0003A884
		public static bool CustomErrorsEnabled(bool isLocalRequest)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x06001BF8 RID: 7160 RVA: 0x0003C698 File Offset: 0x0003A898
		internal static void SetCustomErrorsMode(string mode)
		{
			string text = mode.ToLower();
			bool flag = text != "on";
			bool flag2 = text != "remoteonly";
			Type type;
			object obj = Enum.Parse(type, text, true);
		}

		// Token: 0x06001BF9 RID: 7161 RVA: 0x0003C6D8 File Offset: 0x0003A8D8
		// Note: this type is marked as 'beforefieldinit'.
		static RemotingConfiguration()
		{
		}

		// Token: 0x04000E32 RID: 3634
		private static string applicationID;

		// Token: 0x04000E33 RID: 3635
		private static string applicationName;

		// Token: 0x04000E34 RID: 3636
		private static string processGuid;

		// Token: 0x04000E35 RID: 3637
		private static bool defaultConfigRead;

		// Token: 0x04000E36 RID: 3638
		private static bool defaultDelayedConfigRead;

		// Token: 0x04000E37 RID: 3639
		private static CustomErrorsModes _errorMode;

		// Token: 0x04000E38 RID: 3640
		private static Hashtable wellKnownClientEntries;

		// Token: 0x04000E39 RID: 3641
		private static Hashtable activatedClientEntries;

		// Token: 0x04000E3A RID: 3642
		private static Hashtable wellKnownServiceEntries;

		// Token: 0x04000E3B RID: 3643
		private static Hashtable activatedServiceEntries;

		// Token: 0x04000E3C RID: 3644
		private static Hashtable channelTemplates;

		// Token: 0x04000E3D RID: 3645
		private static Hashtable clientProviderTemplates;

		// Token: 0x04000E3E RID: 3646
		private static Hashtable serverProviderTemplates;
	}
}
