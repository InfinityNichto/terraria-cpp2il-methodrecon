using System;
using System.IO;

namespace System.Net.NetworkInformation
{
	// Token: 0x020002B2 RID: 690
	internal sealed class LinuxNetworkInterface : UnixNetworkInterface
	{
		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x060012AE RID: 4782 RVA: 0x0003A2E4 File Offset: 0x000384E4
		internal string IfacePath
		{
			get
			{
				return this.iface_path;
			}
		}

		// Token: 0x060012AF RID: 4783 RVA: 0x0003A2F8 File Offset: 0x000384F8
		internal LinuxNetworkInterface(string name)
			: base(name)
		{
			string text = "/sys/class/net/" + name + "/";
			this.iface_path = text;
			string text2 = text + "operstate";
			this.iface_operstate_path = text2;
			string text3 = this.iface_path + "flags";
			this.iface_flags_path = text3;
		}

		// Token: 0x060012B0 RID: 4784 RVA: 0x0003A350 File Offset: 0x00038550
		public override IPInterfaceProperties GetIPProperties()
		{
			/*
An exception occurred when decompiling this method (060012B0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Net.NetworkInformation.IPInterfaceProperties System.Net.NetworkInformation.LinuxNetworkInterface::GetIPProperties()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.List`1<class System.Net.IPAddress>(var_0_0E, ldfld:class [mscorlib]System.Collections.Generic.List`1<class System.Net.IPAddress>(UnixNetworkInterface::addresses, ldloc:LinuxNetworkInterface[exp:UnixNetworkInterface](this)))
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

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x060012B1 RID: 4785 RVA: 0x0003A36C File Offset: 0x0003856C
		public override OperationalStatus OperationalStatus
		{
			get
			{
				/*
An exception occurred when decompiling this method (060012B1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Net.NetworkInformation.OperationalStatus System.Net.NetworkInformation.LinuxNetworkInterface::get_OperationalStatus()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_0_0B, call:bool(Directory::Exists, ldfld:string(LinuxNetworkInterface::iface_path, ldloc:LinuxNetworkInterface(this))))
	stloc:string(var_1_17, call:string(LinuxNetworkInterface::ReadLine, ldfld:string(LinuxNetworkInterface::iface_operstate_path, ldloc:LinuxNetworkInterface(this))))
	stloc:uint32(var_2_1E, call:uint32('<PrivateImplementationDetails>'::ComputeStringHash, ldloc:string(var_1_17)))
	stloc:bool(var_7_45, call:bool(string::op_Equality, ldloc:string(var_1_17), ldstr:string("up")))
	stloc:bool(var_11_67, call:bool(string::op_Equality, ldloc:string(var_1_17), ldstr:string("lowerlayerdown")))
	stloc:bool(var_14_82, call:bool(string::op_Equality, ldloc:string(var_1_17), ldstr:string("testing")))
	stloc:bool(var_15_8F, call:bool(string::op_Equality, ldloc:string(var_1_17), ldstr:string("down")))
	stloc:bool(var_16_9C, call:bool(string::op_Equality, ldloc:string(var_1_17), ldstr:string("notpresent")))
	stloc:bool(var_17_A9, call:bool(string::op_Equality, ldloc:string(var_1_17), ldstr:string("unknown")))
	stloc:bool(var_18_B6, call:bool(string::op_Equality, ldloc:string(var_1_17), ldstr:string("dormant")))
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

		// Token: 0x060012B2 RID: 4786 RVA: 0x0003A438 File Offset: 0x00038638
		internal static string ReadLine(string path)
		{
			if (!false)
			{
				long num = 0L;
				FileStream fileStream;
				if (fileStream != null)
				{
				}
				if (num == 0L)
				{
				}
				throw new OutOfMemoryException();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x04000ED1 RID: 3793
		private string iface_path;

		// Token: 0x04000ED2 RID: 3794
		private string iface_operstate_path;

		// Token: 0x04000ED3 RID: 3795
		private string iface_flags_path;
	}
}
