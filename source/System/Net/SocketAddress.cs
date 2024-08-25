using System;
using System.Globalization;
using System.Net.Sockets;

namespace System.Net
{
	// Token: 0x020001C4 RID: 452
	public class SocketAddress
	{
		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000AD2 RID: 2770 RVA: 0x00023C40 File Offset: 0x00021E40
		public global::System.Net.Sockets.AddressFamily Family
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000AD2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Net.Sockets.AddressFamily System.Net.SocketAddress::get_Family()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint8[](var_0_06, ldfld:uint8[](SocketAddress::m_Buffer, ldloc:SocketAddress(this)))
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

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000AD3 RID: 2771 RVA: 0x00023C54 File Offset: 0x00021E54
		public int Size
		{
			get
			{
				return this.m_Size;
			}
		}

		// Token: 0x17000231 RID: 561
		public byte this[int offset]
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000AD4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte System.Net.SocketAddress::get_Item(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(SocketAddress::m_Size, ldloc:SocketAddress(this)))
	stloc:uint8[](var_1_0D, ldfld:uint8[](SocketAddress::m_Buffer, ldloc:SocketAddress(this)))
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
			set
			{
				int size = this.m_Size;
				byte[] buffer = this.m_Buffer;
				int num = 1;
				this.m_changed = num != 0;
				buffer.m_value = value;
			}
		}

		// Token: 0x06000AD6 RID: 2774 RVA: 0x00023CB0 File Offset: 0x00021EB0
		public SocketAddress(global::System.Net.Sockets.AddressFamily family)
		{
		}

		// Token: 0x06000AD7 RID: 2775 RVA: 0x00023CC0 File Offset: 0x00021EC0
		public SocketAddress(global::System.Net.Sockets.AddressFamily family, int size)
		{
			int num = 1;
			this.m_changed = num != 0;
			base..ctor();
			this.m_Size = size;
			int size2 = IntPtr.Size;
			int size3 = IntPtr.Size;
			byte[] buffer = this.m_Buffer;
		}

		// Token: 0x06000AD8 RID: 2776 RVA: 0x00023D00 File Offset: 0x00021F00
		internal SocketAddress(IPAddress ipAddress)
		{
			global::System.Net.Sockets.AddressFamily addressFamily = ipAddress.AddressFamily;
			global::System.Net.Sockets.AddressFamily addressFamily2 = ipAddress.AddressFamily;
			byte[] buffer = this.m_Buffer;
			byte[] buffer2 = this.m_Buffer;
			global::System.Net.Sockets.AddressFamily addressFamily3 = ipAddress.AddressFamily;
			byte[] buffer3 = this.m_Buffer;
			byte[] buffer4 = this.m_Buffer;
			byte[] buffer5 = this.m_Buffer;
			byte[] buffer6 = this.m_Buffer;
			long scopeId = ipAddress.ScopeId;
			byte[] buffer7 = this.m_Buffer;
			byte[] buffer8 = this.m_Buffer;
			byte[] buffer9 = this.m_Buffer;
			byte[] buffer10 = this.m_Buffer;
			byte[] addressBytes = ipAddress.GetAddressBytes();
			byte[] buffer11 = this.m_Buffer;
		}

		// Token: 0x06000AD9 RID: 2777 RVA: 0x00023DAC File Offset: 0x00021FAC
		internal SocketAddress(IPAddress ipaddress, int port)
		{
			byte[] buffer = this.m_Buffer;
			byte[] buffer2 = this.m_Buffer;
		}

		// Token: 0x06000ADA RID: 2778 RVA: 0x00023DC8 File Offset: 0x00021FC8
		internal IPAddress GetIPAddress()
		{
			/*
An exception occurred when decompiling this method (06000ADA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Net.IPAddress System.Net.SocketAddress::GetIPAddress()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint8[](var_0_06, ldfld:uint8[](SocketAddress::m_Buffer, ldloc:SocketAddress(this)))
	stloc:uint8[](var_2_10, ldfld:uint8[](SocketAddress::m_Buffer, ldloc:SocketAddress(this)))
	stloc:uint8[](var_4_19, ldfld:uint8[](SocketAddress::m_Buffer, ldloc:SocketAddress(this)))
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

		// Token: 0x06000ADB RID: 2779 RVA: 0x00023DF0 File Offset: 0x00021FF0
		internal IPEndPoint GetIPEndPoint()
		{
			/*
An exception occurred when decompiling this method (06000ADB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Net.IPEndPoint System.Net.SocketAddress::GetIPEndPoint()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:IPAddress(var_0_06, call:IPAddress(SocketAddress::GetIPAddress, ldloc:SocketAddress(this)))
	stloc:uint8[](var_1_0D, ldfld:uint8[](SocketAddress::m_Buffer, ldloc:SocketAddress(this)))
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

		// Token: 0x06000ADC RID: 2780 RVA: 0x00023E0C File Offset: 0x0002200C
		internal void CopyAddressSizeIntoBuffer()
		{
			byte[] buffer = this.m_Buffer;
			int size = IntPtr.Size;
			int size2 = this.m_Size;
			byte[] buffer2 = this.m_Buffer;
			int size3 = IntPtr.Size;
			int size4 = this.m_Size;
			byte[] buffer3 = this.m_Buffer;
			int size5 = IntPtr.Size;
			byte[] buffer4 = this.m_Buffer;
			int size6 = IntPtr.Size;
		}

		// Token: 0x06000ADD RID: 2781 RVA: 0x00023E70 File Offset: 0x00022070
		internal int GetAddressSizeOffset()
		{
			byte[] buffer = this.m_Buffer;
			return IntPtr.Size;
		}

		// Token: 0x06000ADE RID: 2782 RVA: 0x00023E8C File Offset: 0x0002208C
		internal unsafe void SetSize(IntPtr ptr)
		{
			void* ptr2 = (void*)ptr;
		}

		// Token: 0x06000ADF RID: 2783 RVA: 0x00023EA0 File Offset: 0x000220A0
		public override bool Equals(object comparand)
		{
			if (comparand != null)
			{
				int size = this.m_Size;
				long num = 0L;
				byte b = this[(int)num];
				int size2 = this.m_Size;
				return;
			}
		}

		// Token: 0x06000AE0 RID: 2784 RVA: 0x00023ED4 File Offset: 0x000220D4
		public override int GetHashCode()
		{
			if (this.m_changed)
			{
				long num = 0L;
				byte[] buffer = this.m_Buffer;
				this.m_hash = (int)num;
			}
			int hash = this.m_hash;
			byte[] buffer2 = this.m_Buffer;
			this.m_hash = hash;
			return hash;
		}

		// Token: 0x06000AE1 RID: 2785 RVA: 0x00023F18 File Offset: 0x00022118
		public override string ToString()
		{
			int size = this.m_Size;
			int num = 2;
			byte b = this[num];
			NumberFormatInfo invariantInfo = NumberFormatInfo.InvariantInfo;
			int size2 = this.m_Size;
			byte[] buffer = this.m_Buffer;
			string text;
			if ((text == null || text != null) && (":" == null || ":" != null))
			{
				int size3 = this.m_Size;
				NumberFormatInfo invariantInfo2 = NumberFormatInfo.InvariantInfo;
				string text2;
				if ((text2 == null || text2 != null) && (":{" == null || ":{" != null) && ("}" == null || "}" != null))
				{
					string text3;
					return text3;
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x04000986 RID: 2438
		internal const int IPv6AddressSize = 28;

		// Token: 0x04000987 RID: 2439
		internal const int IPv4AddressSize = 16;

		// Token: 0x04000988 RID: 2440
		internal int m_Size;

		// Token: 0x04000989 RID: 2441
		internal byte[] m_Buffer;

		// Token: 0x0400098A RID: 2442
		private const int WriteableOffset = 2;

		// Token: 0x0400098B RID: 2443
		private const int MaxSize = 32;

		// Token: 0x0400098C RID: 2444
		private bool m_changed;

		// Token: 0x0400098D RID: 2445
		private int m_hash;
	}
}
