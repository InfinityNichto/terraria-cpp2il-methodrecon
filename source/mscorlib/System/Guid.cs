using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Cpp2IlInjected;

namespace System
{
	// Token: 0x020000BD RID: 189
	[NonVersionable]
	[Serializable]
	public struct Guid : IFormattable, IComparable, IComparable<Guid>, IEquatable<Guid>, ISpanFormattable
	{
		// Token: 0x06000728 RID: 1832 RVA: 0x0000207A File Offset: 0x0000027A
		public static Guid NewGuid()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x00011B54 File Offset: 0x0000FD54
		public Guid(byte[] b)
		{
			while (b == null)
			{
			}
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x00011B64 File Offset: 0x0000FD64
		public Guid(ReadOnlySpan<byte> b)
		{
			int length = b._length;
			this._d = (byte)length;
			this._e = (byte)length;
			this._f = (byte)length;
			this._g = (byte)length;
			this._h = (byte)length;
			this._i = (byte)length;
			this._j = (byte)length;
			this._k = (byte)length;
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x00011BC0 File Offset: 0x0000FDC0
		public Guid(int a, short b, short c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k)
		{
			this._a = a;
			this._b = b;
			this._c = c;
			this._d = d;
			this._e = e;
			this._f = f;
			this._g = g;
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x00011C04 File Offset: 0x0000FE04
		public Guid(string g)
		{
			if (g != null)
			{
				char rawStringData = g.GetRawStringData();
				int stringLength = g._stringLength;
				return;
			}
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x00011C24 File Offset: 0x0000FE24
		public static Guid Parse(string input)
		{
			Guid guid;
			return guid;
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x0000207A File Offset: 0x0000027A
		public static Guid Parse(ReadOnlySpan<char> input)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x00011C34 File Offset: 0x0000FE34
		public static bool TryParse(string input, [Out] Guid result)
		{
			return true;
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x00011C44 File Offset: 0x0000FE44
		public static bool TryParse(ReadOnlySpan<char> input, [Out] Guid result)
		{
			return true;
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x00011C54 File Offset: 0x0000FE54
		private static bool TryParseGuid(ReadOnlySpan<char> guidString, Guid.GuidStyles flags, Guid.GuidResult result)
		{
			ReadOnlySpan<char> readOnlySpan2;
			ReadOnlySpan<char> readOnlySpan = MemoryExtensions.TrimEnd(readOnlySpan2);
			if (guidString != null)
			{
				bool flag;
				return flag;
			}
			bool flag2;
			return flag2;
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x00011C80 File Offset: 0x0000FE80
		private static bool TryParseGuidWithHexPrefix(ReadOnlySpan<char> guidString, Guid.GuidResult result)
		{
			if (guidString != null)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException();
				ThrowHelper.ThrowArgumentOutOfRangeException();
				ThrowHelper.ThrowArgumentOutOfRangeException();
				ThrowHelper.ThrowArgumentOutOfRangeException();
				ThrowHelper.ThrowArgumentOutOfRangeException();
				ThrowHelper.ThrowArgumentOutOfRangeException();
				ThrowHelper.ThrowArgumentOutOfRangeException();
				return false;
			}
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x00011CD8 File Offset: 0x0000FED8
		private static bool TryParseGuidWithNoStyle(ReadOnlySpan<char> guidString, Guid.GuidResult result)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x00011CF8 File Offset: 0x0000FEF8
		private static bool TryParseGuidWithDashes(ReadOnlySpan<char> guidString, Guid.GuidResult result)
		{
			return "Guid should contain 32 digits with 4 dashes (xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx)." != null;
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x00011D24 File Offset: 0x0000FF24
		private static bool StringToShort(ReadOnlySpan<char> str, int requiredLength, int flags, [Out] short result, Guid.GuidResult parseResult)
		{
			bool flag;
			return flag;
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x00011D34 File Offset: 0x0000FF34
		private static bool StringToShort(ReadOnlySpan<char> str, int parsePos, int requiredLength, int flags, [Out] short result, Guid.GuidResult parseResult)
		{
			bool flag;
			return flag;
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x00011D44 File Offset: 0x0000FF44
		private static bool StringToInt(ReadOnlySpan<char> str, int requiredLength, int flags, [Out] int result, Guid.GuidResult parseResult)
		{
			bool flag;
			return flag;
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x00011D54 File Offset: 0x0000FF54
		private static bool StringToInt(ReadOnlySpan<char> str, int parsePos, int requiredLength, int flags, [Out] int result, Guid.GuidResult parseResult)
		{
			do
			{
				int num;
				result.m_value = num;
				Guid.GuidParseThrowStyle throwStyle = parseResult._throwStyle;
				int num2 = 4;
				parseResult._failure = (Guid.ParseFailureKind)num2;
			}
			while (parseResult._throwStyle == Guid.GuidParseThrowStyle.None);
			throw new OutOfMemoryException();
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x00011D98 File Offset: 0x0000FF98
		private static bool StringToLong(ReadOnlySpan<char> str, int parsePos, int flags, [Out] long result, Guid.GuidResult parseResult)
		{
			do
			{
				long num;
				result.m_value = num;
				Guid.GuidParseThrowStyle throwStyle = parseResult._throwStyle;
				int num2 = 4;
				parseResult._failure = (Guid.ParseFailureKind)num2;
			}
			while (parseResult._throwStyle == Guid.GuidParseThrowStyle.None);
			throw new OutOfMemoryException();
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x00011DD8 File Offset: 0x0000FFD8
		private static ReadOnlySpan<char> EatAllWhitespace(ReadOnlySpan<char> str)
		{
			if (!true)
			{
			}
			long num = 0L;
			if (num != 0L)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException();
			}
			if (num == 0L)
			{
			}
			ThrowHelper.ThrowArgumentOutOfRangeException();
			if (num != 0L)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException();
				return;
			}
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x00011E14 File Offset: 0x00010014
		private static bool IsHexPrefix(ReadOnlySpan<char> str, int i)
		{
			/*
An exception occurred when decompiling this method (0600073B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Guid::IsHexPrefix(System.ReadOnlySpan`1<System.Char>,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:char(var_3_0C, call:char(char::ToLowerInvariant, ldloc:int32[exp:char](i)))
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

		// Token: 0x0600073C RID: 1852 RVA: 0x00011E30 File Offset: 0x00010030
		private void WriteByteHelper(Span<byte> destination)
		{
			short b = this._b;
			short c = this._c;
			byte d = this._d;
			destination._length = (int)d;
			byte e = this._e;
			byte f = this._f;
			byte g = this._g;
			byte h = this._h;
			byte i = this._i;
			byte j = this._j;
			byte k = this._k;
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x00011E90 File Offset: 0x00010090
		public byte[] ToByteArray()
		{
			/*
An exception occurred when decompiling this method (0600073D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte[] System.Guid::ToByteArray()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int16(var_1_06, ldfld:int16(Guid::_b, ldloc:valuetype System.Guid&(this)))
	stloc:int16(var_2_0D, ldfld:int16(Guid::_c, ldloc:valuetype System.Guid&(this)))
	stloc:uint8(var_3_14, ldfld:uint8(Guid::_d, ldloc:valuetype System.Guid&(this)))
	stfld:int32(Span`1::_length, ldloc:Span`1[exp:valuetype System.Span`1&](var_0), ldloc:uint8[exp:int32](var_3_14))
	stloc:uint8(var_4_22, ldfld:uint8(Guid::_e, ldloc:valuetype System.Guid&(this)))
	stloc:uint8(var_5_2A, ldfld:uint8(Guid::_f, ldloc:valuetype System.Guid&(this)))
	stloc:uint8(var_6_32, ldfld:uint8(Guid::_g, ldloc:valuetype System.Guid&(this)))
	stloc:uint8(var_7_3A, ldfld:uint8(Guid::_h, ldloc:valuetype System.Guid&(this)))
	stloc:uint8(var_8_42, ldfld:uint8(Guid::_i, ldloc:valuetype System.Guid&(this)))
	stloc:uint8(var_9_4A, ldfld:uint8(Guid::_j, ldloc:valuetype System.Guid&(this)))
	stloc:uint8(var_10_52, ldfld:uint8(Guid::_k, ldloc:valuetype System.Guid&(this)))
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

		// Token: 0x0600073E RID: 1854 RVA: 0x00011EF0 File Offset: 0x000100F0
		public override string ToString()
		{
			string text;
			return text;
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x00011F00 File Offset: 0x00010100
		public override int GetHashCode()
		{
			/*
An exception occurred when decompiling this method (0600073F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Guid::GetHashCode()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Guid::_a, ldloc:valuetype System.Guid&(this)))
	stloc:uint8(var_1_0D, ldfld:uint8(Guid::_d, ldloc:valuetype System.Guid&(this)))
	stloc:uint8(var_2_14, ldfld:uint8(Guid::_d, ldloc:valuetype System.Guid&(this)))
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

		// Token: 0x06000740 RID: 1856 RVA: 0x00011F24 File Offset: 0x00010124
		public override bool Equals(object o)
		{
			if (o != null)
			{
				short b = this._b;
				byte d = this._d;
				byte h = this._h;
				return;
			}
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x00011F4C File Offset: 0x0001014C
		public bool Equals(Guid g)
		{
			/*
An exception occurred when decompiling this method (06000741)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Guid::Equals(System.Guid)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int16(var_0_06, ldfld:int16(Guid::_b, ldloc:valuetype System.Guid&(this)))
	stloc:uint8(var_1_0D, ldfld:uint8(Guid::_d, ldloc:valuetype System.Guid&(this)))
	stloc:uint8(var_2_14, ldfld:uint8(Guid::_h, ldloc:valuetype System.Guid&(this)))
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

		// Token: 0x06000742 RID: 1858 RVA: 0x0000207A File Offset: 0x0000027A
		private int GetResult(uint me, uint them)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x00011F70 File Offset: 0x00010170
		public int CompareTo(object value)
		{
			if (value != null)
			{
				short b = this._b;
				short c = this._c;
				byte d = this._d;
				byte e = this._e;
				byte f = this._f;
				byte g = this._g;
				byte h = this._h;
				byte i = this._i;
				byte j = this._j;
				byte k = this._k;
			}
			return 1;
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x00011FD0 File Offset: 0x000101D0
		public int CompareTo(Guid value)
		{
			/*
An exception occurred when decompiling this method (06000744)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Guid::CompareTo(System.Guid)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int16(var_0_06, ldfld:int16(Guid::_b, ldloc:valuetype System.Guid&(this)))
	stloc:int16(var_1_0D, ldfld:int16(Guid::_c, ldloc:valuetype System.Guid&(this)))
	stloc:uint8(var_2_14, ldfld:uint8(Guid::_d, ldloc:valuetype System.Guid&(this)))
	stloc:uint8(var_3_1B, ldfld:uint8(Guid::_e, ldloc:valuetype System.Guid&(this)))
	stloc:uint8(var_4_22, ldfld:uint8(Guid::_f, ldloc:valuetype System.Guid&(this)))
	stloc:uint8(var_5_2A, ldfld:uint8(Guid::_g, ldloc:valuetype System.Guid&(this)))
	stloc:uint8(var_6_32, ldfld:uint8(Guid::_h, ldloc:valuetype System.Guid&(this)))
	stloc:uint8(var_7_3A, ldfld:uint8(Guid::_i, ldloc:valuetype System.Guid&(this)))
	stloc:uint8(var_8_42, ldfld:uint8(Guid::_j, ldloc:valuetype System.Guid&(this)))
	stloc:uint8(var_9_4A, ldfld:uint8(Guid::_k, ldloc:valuetype System.Guid&(this)))
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

		// Token: 0x06000745 RID: 1861 RVA: 0x0001202C File Offset: 0x0001022C
		public static bool operator ==(Guid a, Guid b)
		{
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x0001203C File Offset: 0x0001023C
		public string ToString(string format)
		{
			string text;
			return text;
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x0000207A File Offset: 0x0000027A
		private static char HexToChar(int a)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x0001204C File Offset: 0x0001024C
		private unsafe static int HexsToChars(char* guidChars, int a, int b)
		{
			return 4;
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x00012060 File Offset: 0x00010260
		private unsafe static int HexsToCharsHexOutput(char* guidChars, int a, int b)
		{
			return 9;
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x00012074 File Offset: 0x00010274
		public string ToString(string format, IFormatProvider provider)
		{
			if (format == null || format._stringLength == 0)
			{
			}
			string text = string.FastAllocateString(32);
			if (text != null)
			{
				int offsetToStringData = RuntimeHelpers.OffsetToStringData;
			}
			int stringLength = text._stringLength;
			ThrowHelper.ThrowArgumentOutOfRangeException();
			return text;
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x000120C4 File Offset: 0x000102C4
		public bool TryFormat(Span<char> destination, [Out] int charsWritten, [Optional] ReadOnlySpan<char> format)
		{
			int num = 123;
			long num2 = 0L;
			if (num != 0)
			{
			}
			int num4;
			int num5;
			if (num2 != 0L)
			{
				int num3 = 48;
				destination._pointer = num3;
				num4 = 120;
				byte d = this._d;
				byte e = this._e;
				byte f = this._f;
				byte g = this._g;
				byte h = this._h;
				byte i = this._i;
				byte j = this._j;
				byte k = this._k;
				num5 = 125;
				if (num != 0)
				{
					goto IL_00DF;
				}
			}
			if (num4 != 0)
			{
			}
			if (num4 != 0)
			{
			}
			if (num4 != 0)
			{
				int num6 = 45;
				destination._length = num6;
			}
			byte d2 = this._d;
			byte e2 = this._e;
			int num7;
			if (num4 != 0)
			{
				num7 = 45;
			}
			byte f2 = this._f;
			byte g2 = this._g;
			byte h2 = this._h;
			byte i2 = this._i;
			byte j2 = this._j;
			byte k2 = this._k;
			if (num == 0)
			{
				return;
			}
			IL_00DF:
			num7.m_value = num5;
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x000121BC File Offset: 0x000103BC
		bool ISpanFormattable.TryFormat(Span<char> destination, [Out] int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider)
		{
			return this.TryFormat(destination, charsWritten, format);
		}

		// Token: 0x0400032D RID: 813
		public static readonly Guid Empty;

		// Token: 0x0400032E RID: 814
		private int _a;

		// Token: 0x0400032F RID: 815
		private short _b;

		// Token: 0x04000330 RID: 816
		private short _c;

		// Token: 0x04000331 RID: 817
		private byte _d;

		// Token: 0x04000332 RID: 818
		private byte _e;

		// Token: 0x04000333 RID: 819
		private byte _f;

		// Token: 0x04000334 RID: 820
		private byte _g;

		// Token: 0x04000335 RID: 821
		private byte _h;

		// Token: 0x04000336 RID: 822
		private byte _i;

		// Token: 0x04000337 RID: 823
		private byte _j;

		// Token: 0x04000338 RID: 824
		private byte _k;

		// Token: 0x020000BE RID: 190
		[Flags]
		private enum GuidStyles
		{
			// Token: 0x0400033A RID: 826
			None = 0,
			// Token: 0x0400033B RID: 827
			AllowParenthesis = 1,
			// Token: 0x0400033C RID: 828
			AllowBraces = 2,
			// Token: 0x0400033D RID: 829
			AllowDashes = 4,
			// Token: 0x0400033E RID: 830
			AllowHexPrefix = 8,
			// Token: 0x0400033F RID: 831
			RequireParenthesis = 16,
			// Token: 0x04000340 RID: 832
			RequireBraces = 32,
			// Token: 0x04000341 RID: 833
			RequireDashes = 64,
			// Token: 0x04000342 RID: 834
			RequireHexPrefix = 128,
			// Token: 0x04000343 RID: 835
			HexFormat = 160,
			// Token: 0x04000344 RID: 836
			NumberFormat = 0,
			// Token: 0x04000345 RID: 837
			DigitFormat = 64,
			// Token: 0x04000346 RID: 838
			BraceFormat = 96,
			// Token: 0x04000347 RID: 839
			ParenthesisFormat = 80,
			// Token: 0x04000348 RID: 840
			Any = 15
		}

		// Token: 0x020000BF RID: 191
		private enum GuidParseThrowStyle
		{
			// Token: 0x0400034A RID: 842
			None,
			// Token: 0x0400034B RID: 843
			All,
			// Token: 0x0400034C RID: 844
			AllButOverflow
		}

		// Token: 0x020000C0 RID: 192
		private enum ParseFailureKind
		{
			// Token: 0x0400034E RID: 846
			None,
			// Token: 0x0400034F RID: 847
			ArgumentNull,
			// Token: 0x04000350 RID: 848
			Format,
			// Token: 0x04000351 RID: 849
			FormatWithParameter,
			// Token: 0x04000352 RID: 850
			NativeException,
			// Token: 0x04000353 RID: 851
			FormatWithInnerException
		}

		// Token: 0x020000C1 RID: 193
		private struct GuidResult
		{
			// Token: 0x0600074D RID: 1869 RVA: 0x000121D4 File Offset: 0x000103D4
			internal void Init(Guid.GuidParseThrowStyle canThrow)
			{
				this._throwStyle = canThrow;
			}

			// Token: 0x0600074E RID: 1870 RVA: 0x000121E8 File Offset: 0x000103E8
			internal void SetFailure(Exception nativeException)
			{
				this._failure = Guid.ParseFailureKind.NativeException;
				this._innerException = nativeException;
			}

			// Token: 0x0600074F RID: 1871 RVA: 0x00012204 File Offset: 0x00010404
			internal void SetFailure(Guid.ParseFailureKind failure, string failureMessageID)
			{
			}

			// Token: 0x06000750 RID: 1872 RVA: 0x00012214 File Offset: 0x00010414
			internal void SetFailure(Guid.ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument)
			{
			}

			// Token: 0x06000751 RID: 1873 RVA: 0x00012224 File Offset: 0x00010424
			internal void SetFailure(Guid.ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument, string failureArgumentName, Exception innerException)
			{
				/*
An exception occurred when decompiling this method (06000751)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Guid/GuidResult::SetFailure(System.Guid/ParseFailureKind,System.String,System.Object,System.String,System.Exception)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0030:
	stloc:Exception(var_1_36, call:Exception(GuidResult::GetGuidParseException, ldloc:valuetype System.Guid/GuidResult&(this)))
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

			// Token: 0x06000752 RID: 1874 RVA: 0x00012268 File Offset: 0x00010468
			internal Exception GetGuidParseException()
			{
				Guid.ParseFailureKind failure = this._failure;
				return "Unrecognized Guid format.";
			}

			// Token: 0x04000354 RID: 852
			internal Guid _parsedGuid;

			// Token: 0x04000355 RID: 853
			internal Guid.GuidParseThrowStyle _throwStyle;

			// Token: 0x04000356 RID: 854
			private Guid.ParseFailureKind _failure;

			// Token: 0x04000357 RID: 855
			private string _failureMessageID;

			// Token: 0x04000358 RID: 856
			private object _failureMessageFormatArgument;

			// Token: 0x04000359 RID: 857
			private string _failureArgumentName;

			// Token: 0x0400035A RID: 858
			private Exception _innerException;
		}
	}
}
