using System;
using System.Globalization;
using System.Net.Sockets;

namespace System.Net
{
	// Token: 0x02000142 RID: 322
	[Serializable]
	public class IPEndPoint : EndPoint
	{
		// Token: 0x1700019E RID: 414
		// (get) Token: 0x060007D1 RID: 2001 RVA: 0x0001B488 File Offset: 0x00019688
		public override global::System.Net.Sockets.AddressFamily AddressFamily
		{
			get
			{
				/*
An exception occurred when decompiling this method (060007D1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Net.Sockets.AddressFamily System.Net.IPEndPoint::get_AddressFamily()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint16[](var_0_0B, ldfld:uint16[](IPAddress::_numbers, ldfld:IPAddress(IPEndPoint::_address, ldloc:IPEndPoint(this))))
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

		// Token: 0x060007D2 RID: 2002 RVA: 0x0001B4A0 File Offset: 0x000196A0
		public IPEndPoint(long address, int port)
		{
			this._port = port;
		}

		// Token: 0x060007D3 RID: 2003 RVA: 0x0001B4BC File Offset: 0x000196BC
		public IPEndPoint(IPAddress address, int port)
		{
			if (address != null)
			{
				this._port = port;
				this._address = address;
				return;
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x060007D4 RID: 2004 RVA: 0x0001B4E4 File Offset: 0x000196E4
		// (set) Token: 0x060007D5 RID: 2005 RVA: 0x0001B4F8 File Offset: 0x000196F8
		public IPAddress Address
		{
			get
			{
				return this._address;
			}
			set
			{
				this._address = value;
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x060007D6 RID: 2006 RVA: 0x0001B50C File Offset: 0x0001970C
		// (set) Token: 0x060007D7 RID: 2007 RVA: 0x0001B520 File Offset: 0x00019720
		public int Port
		{
			get
			{
				return this._port;
			}
			set
			{
				this._port = value;
			}
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x0001B534 File Offset: 0x00019734
		public override string ToString()
		{
			ushort[] numbers = this._address._numbers;
			int port = this._port;
			NumberFormatInfo invariantInfo = NumberFormatInfo.InvariantInfo;
			string text;
			return text;
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x0001B560 File Offset: 0x00019760
		public override SocketAddress Serialize()
		{
			/*
An exception occurred when decompiling this method (060007D9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Net.SocketAddress System.Net.IPEndPoint::Serialize()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:IPAddress(var_0_06, ldfld:IPAddress(IPEndPoint::_address, ldloc:IPEndPoint(this)))
	stloc:int32(var_1_0D, ldfld:int32(IPEndPoint::_port, ldloc:IPEndPoint(this)))
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

		// Token: 0x060007DA RID: 2010 RVA: 0x0001B57C File Offset: 0x0001977C
		public override EndPoint Create(SocketAddress socketAddress)
		{
			/*
An exception occurred when decompiling this method (060007DA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Net.EndPoint System.Net.IPEndPoint::Create(System.Net.SocketAddress)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:AddressFamily(var_0_06, callgetter:AddressFamily(SocketAddress::get_Family, ldloc:SocketAddress(socketAddress)))
	stloc:int32(var_1_0D, ldfld:int32(SocketAddress::m_Size, ldloc:SocketAddress(socketAddress)))
	stloc:IPEndPoint(var_2_14, call:IPEndPoint(SocketAddress::GetIPEndPoint, ldloc:SocketAddress(socketAddress)))
	stloc:AddressFamily(var_3_1B, callgetter:AddressFamily(SocketAddress::get_Family, ldloc:SocketAddress(socketAddress)))
	stloc:Type(var_5_22, call:Type(object::GetType, ldloc:IPEndPoint[exp:object](this)))
	stloc:Type(var_7_39, call:Type(object::GetType, call:string[exp:object](SR::Format, ldstr:string("The AddressFamily {0} is not valid for the {1} end point, use {2} instead."), ldloc:string[exp:object](var_4), ldloc:Type[exp:object](var_5_22), ldloc:string[exp:object](var_6))))
	stloc:Type(var_8_42, call:Type(object::GetType, ldloc:string[exp:object](var_6)))
	stloc:string(var_9_52, call:string(SR::Format, ldstr:string("The supplied {0} is an invalid size for the {1} end point."), ldloc:Type[exp:object](var_7_39), ldloc:Type[exp:object](var_8_42)))
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

		// Token: 0x060007DB RID: 2011 RVA: 0x0001B5DC File Offset: 0x000197DC
		public override bool Equals(object comparand)
		{
			if (comparand != null)
			{
				IPAddress address = this._address;
				int port = this._port;
				return;
			}
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x0001B5FC File Offset: 0x000197FC
		public override int GetHashCode()
		{
			/*
An exception occurred when decompiling this method (060007DC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Net.IPEndPoint::GetHashCode()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:IPAddress(var_0_06, ldfld:IPAddress(IPEndPoint::_address, ldloc:IPEndPoint(this)))
	stloc:int32(var_1_0D, ldfld:int32(IPEndPoint::_port, ldloc:IPEndPoint(this)))
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

		// Token: 0x060007DD RID: 2013 RVA: 0x0001B618 File Offset: 0x00019818
		// Note: this type is marked as 'beforefieldinit'.
		static IPEndPoint()
		{
			if (!true)
			{
			}
		}

		// Token: 0x04000647 RID: 1607
		public const int MinPort = 0;

		// Token: 0x04000648 RID: 1608
		public const int MaxPort = 65535;

		// Token: 0x04000649 RID: 1609
		private IPAddress _address;

		// Token: 0x0400064A RID: 1610
		private int _port;

		// Token: 0x0400064B RID: 1611
		internal const int AnyPort = 0;

		// Token: 0x0400064C RID: 1612
		internal static IPEndPoint Any;

		// Token: 0x0400064D RID: 1613
		internal static IPEndPoint IPv6Any;
	}
}
