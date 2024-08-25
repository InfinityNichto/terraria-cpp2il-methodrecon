using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2IlInjected;

namespace System
{
	// Token: 0x02000122 RID: 290
	[Serializable]
	public sealed class Version : ICloneable, IComparable, IComparable<Version>, IEquatable<Version>, ISpanFormattable
	{
		// Token: 0x06000B72 RID: 2930 RVA: 0x00019BB4 File Offset: 0x00017DB4
		public Version(int major, int minor, int build, int revision)
		{
			this._Major = major;
			this._Build = minor;
			this._Build = build;
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x00019BE0 File Offset: 0x00017DE0
		public Version(int major, int minor, int build)
		{
			this._Major = major;
			this._Build = minor;
			this._Build = build;
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x00019C0C File Offset: 0x00017E0C
		public Version(int major, int minor)
		{
			this._Major = major;
			this._Build = minor;
		}

		// Token: 0x06000B75 RID: 2933 RVA: 0x00019C30 File Offset: 0x00017E30
		public Version(string version)
		{
			Version version2 = Version.Parse(version);
			int major = version2._Major;
			this._Major = major;
			int build = version2._Build;
			this._Build = build;
			int revision = version2._Revision;
			this._Revision = revision;
		}

		// Token: 0x06000B76 RID: 2934 RVA: 0x00019C74 File Offset: 0x00017E74
		public Version()
		{
		}

		// Token: 0x06000B77 RID: 2935 RVA: 0x00019C88 File Offset: 0x00017E88
		private Version(Version version)
		{
			int major = version._Major;
			this._Major = major;
			int build = version._Build;
			this._Build = build;
			int revision = version._Revision;
			this._Revision = revision;
		}

		// Token: 0x06000B78 RID: 2936 RVA: 0x00019CC8 File Offset: 0x00017EC8
		public object Clone()
		{
			/*
An exception occurred when decompiling this method (06000B78)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Version::Clone()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Version::_Major, ldloc:Version(this)))
	stloc:int32(var_1_0D, ldfld:int32(Version::_Build, ldloc:Version(this)))
	stloc:int32(var_2_14, ldfld:int32(Version::_Revision, ldloc:Version(this)))
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

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000B79 RID: 2937 RVA: 0x00019CEC File Offset: 0x00017EEC
		public int Major
		{
			get
			{
				return this._Major;
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000B7A RID: 2938 RVA: 0x00019D00 File Offset: 0x00017F00
		public int Minor
		{
			get
			{
				return this._Minor;
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000B7B RID: 2939 RVA: 0x00019D14 File Offset: 0x00017F14
		public int Build
		{
			get
			{
				return this._Build;
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000B7C RID: 2940 RVA: 0x00019D28 File Offset: 0x00017F28
		public int Revision
		{
			get
			{
				return this._Revision;
			}
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x00019D3C File Offset: 0x00017F3C
		public int CompareTo(object version)
		{
			if (version != null)
			{
				int num;
				return num;
			}
			return 1;
		}

		// Token: 0x06000B7E RID: 2942 RVA: 0x00019D50 File Offset: 0x00017F50
		public int CompareTo(Version value)
		{
			if (value != null)
			{
				int major = this._Major;
				int major2 = value._Major;
				int minor = this._Minor;
				int minor2 = value._Minor;
				int build = this._Build;
				int build2 = value._Build;
				int revision = this._Revision;
				int revision2 = value._Revision;
			}
			return 1;
		}

		// Token: 0x06000B7F RID: 2943 RVA: 0x00019DA0 File Offset: 0x00017FA0
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x00019DB4 File Offset: 0x00017FB4
		public bool Equals(Version obj)
		{
			if (obj != null)
			{
				int major = this._Major;
				int major2 = obj._Major;
				int minor = this._Minor;
				int minor2 = obj._Minor;
				int build = this._Build;
				int build2 = obj._Build;
				int revision = this._Revision;
				int revision2 = obj._Revision;
			}
			return true;
		}

		// Token: 0x06000B81 RID: 2945 RVA: 0x00019E04 File Offset: 0x00018004
		public override int GetHashCode()
		{
			/*
An exception occurred when decompiling this method (06000B81)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Version::GetHashCode()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Version::_Major, ldloc:Version(this)))
	stloc:int32(var_1_0D, ldfld:int32(Version::_Build, ldloc:Version(this)))
	stloc:int32(var_2_14, ldfld:int32(Version::_Build, ldloc:Version(this)))
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

		// Token: 0x06000B82 RID: 2946 RVA: 0x00019E28 File Offset: 0x00018028
		public override string ToString()
		{
			int build = this._Build;
			int revision = this._Revision;
			string text;
			return text;
		}

		// Token: 0x06000B83 RID: 2947 RVA: 0x00019E48 File Offset: 0x00018048
		public string ToString(int fieldCount)
		{
			if (fieldCount != 0)
			{
				string text;
				return text;
			}
			StringBuilder stringBuilder;
			return StringBuilderCache.GetStringAndRelease(stringBuilder);
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x00019E60 File Offset: 0x00018060
		public bool TryFormat(Span<char> destination, [Out] int charsWritten)
		{
			int build = this._Build;
			int revision = this._Revision;
			bool flag;
			return flag;
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x00019E80 File Offset: 0x00018080
		public bool TryFormat(Span<char> destination, int fieldCount, [Out] int charsWritten)
		{
			/*
An exception occurred when decompiling this method (06000B85)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Version::TryFormat(System.Span`1<System.Char>,System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0007:
	stloc:StringBuilder(var_1_0E, call:StringBuilder(Version::ToCachedStringBuilder, ldloc:Version(this), ldloc:int32(charsWritten)))
	stloc:int32(var_2_15, callgetter:int32(StringBuilder::get_Length, ldloc:StringBuilder(var_1_0E)))
	call:void(StringBuilderCache::Release, ldloc:StringBuilder(var_1_0E))
	stloc:int32(var_4_24, callgetter:int32(StringBuilder::get_Length, ldloc:StringBuilder(var_1_0E)))
	stloc:int64(var_5_27, ldc.i4:int64(0))
	call:void(StringBuilder::CopyTo, ldloc:StringBuilder(var_1_0E), ldloc:int64[exp:int32](var_5_27), ldloc:valuetype System.Span`1<char>[exp:Span`1](destination), ldloc:int32(fieldCount))
	call:void(StringBuilderCache::Release, ldloc:StringBuilder(var_1_0E))
	stloc:int32(var_6_3F, callgetter:int32(StringBuilder::get_Length, ldloc:StringBuilder(var_1_0E)))
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

		// Token: 0x06000B86 RID: 2950 RVA: 0x00019ED0 File Offset: 0x000180D0
		bool ISpanFormattable.TryFormat(Span<char> destination, [Out] int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider)
		{
			int build = this._Build;
			int revision = this._Revision;
			bool flag;
			return flag;
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000B87 RID: 2951 RVA: 0x00019EF0 File Offset: 0x000180F0
		private int DefaultFormatFieldCount
		{
			get
			{
				int build = this._Build;
				int revision = this._Revision;
				return 2;
			}
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x00019F0C File Offset: 0x0001810C
		private StringBuilder ToCachedStringBuilder(int fieldCount)
		{
			StringBuilder stringBuilder = StringBuilderCache.Acquire(16);
			int major = this._Major;
			StringBuilder stringBuilder2 = stringBuilder.Append(major);
			int minor = this._Minor;
			StringBuilder stringBuilder3;
			return stringBuilder3;
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x0001A000 File Offset: 0x00018200
		public static Version Parse(string input)
		{
			Version version;
			return version;
		}

		// Token: 0x06000B8A RID: 2954 RVA: 0x0001A010 File Offset: 0x00018210
		private static Version ParseVersion(ReadOnlySpan<char> input, bool throwOnFailure)
		{
			/*
An exception occurred when decompiling this method (06000B8A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Version System.Version::ParseVersion(System.ReadOnlySpan`1<System.Char>,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(ThrowHelper::ThrowArgumentOutOfRangeException)
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

		// Token: 0x06000B8B RID: 2955 RVA: 0x0001A024 File Offset: 0x00018224
		private static bool TryParseComponent(ReadOnlySpan<char> component, string componentName, bool throwOnFailure, [Out] int parsedComponent)
		{
			if (!true)
			{
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			int num;
			parsedComponent.m_value = num;
			return true;
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x0001A04C File Offset: 0x0001824C
		public static bool operator ==(Version v1, Version v2)
		{
			bool flag;
			return flag;
		}

		// Token: 0x06000B8D RID: 2957 RVA: 0x0001A05C File Offset: 0x0001825C
		public static bool operator !=(Version v1, Version v2)
		{
			bool flag;
			return flag;
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x0000207A File Offset: 0x0000027A
		public static bool operator <(Version v1, Version v2)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x0000207A File Offset: 0x0000027A
		public static bool operator <=(Version v1, Version v2)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x0001A06C File Offset: 0x0001826C
		public static bool operator >(Version v1, Version v2)
		{
			return v1 < v1;
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x0001A080 File Offset: 0x00018280
		public static bool operator >=(Version v1, Version v2)
		{
			return v1 <= v1;
		}

		// Token: 0x04000418 RID: 1048
		private readonly int _Major;

		// Token: 0x04000419 RID: 1049
		private readonly int _Minor;

		// Token: 0x0400041A RID: 1050
		private readonly int _Build;

		// Token: 0x0400041B RID: 1051
		private readonly int _Revision;
	}
}
