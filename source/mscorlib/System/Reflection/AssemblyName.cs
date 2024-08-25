using System;
using System.Configuration.Assemblies;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Cpp2IlInjected;
using Mono;

namespace System.Reflection
{
	// Token: 0x02000501 RID: 1281
	[ComDefaultInterface(typeof(_AssemblyName))]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	[Serializable]
	[StructLayout(0)]
	public sealed class AssemblyName : ICloneable, ISerializable, IDeserializationCallback, _AssemblyName
	{
		// Token: 0x06002531 RID: 9521 RVA: 0x00052104 File Offset: 0x00050304
		public AssemblyName()
		{
			this.versioncompat = AssemblyVersionCompatibility.SameMachine;
		}

		// Token: 0x06002532 RID: 9522 RVA: 0x0000207A File Offset: 0x0000027A
		private static bool ParseAssemblyName(IntPtr name, [Out] MonoAssemblyName aname, [Out] bool is_version_definited, [Out] bool is_token_defined)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002533 RID: 9523 RVA: 0x00052120 File Offset: 0x00050320
		public AssemblyName(string assemblyName)
		{
			if (assemblyName == null)
			{
				return;
			}
			int stringLength = assemblyName._stringLength;
			IntPtr value = RuntimeMarshal.MarshalString(assemblyName).Value;
			if (!false)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06002534 RID: 9524 RVA: 0x00052178 File Offset: 0x00050378
		internal AssemblyName(SerializationInfo si, StreamingContext sc)
		{
			int num = 1;
			base..ctor();
			string @string = si.GetString("_Name");
			this.name = @string;
			string string2 = si.GetString("_CodeBase");
			this.codebase = string2;
			if (num == 0)
			{
			}
			Type type;
			object value = si.GetValue("_Version", type);
			if (value != null)
			{
				this.version = value;
				return;
			}
			Type type2;
			object value2 = si.GetValue("_PublicKey", type2);
			if (value2 != null)
			{
				if (value2 == null)
				{
					goto IL_0093;
				}
				this.publicKey = value2;
				if (value2 == null)
				{
					return;
				}
			}
			Type type3;
			object value3 = si.GetValue("_PublicKeyToken", type3);
			if (value3 != null)
			{
				if (value3 == null)
				{
					goto IL_0093;
				}
				this.keyToken = value3;
				if (value3 == null)
				{
					goto IL_0093;
				}
			}
			Type type4;
			object value4 = si.GetValue("_HashAlgorithm", type4);
			Type type5;
			object value5 = si.GetValue("_StrongNameKeyPair", type5);
			if (value5 != null)
			{
				this.keypair = value5;
				return;
			}
			Type type6;
			object value6 = si.GetValue("_VersionCompatibility", type6);
			this.cultureinfo = "_CultureInfo";
			return;
			IL_0093:
			throw new InvalidCastException();
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06002535 RID: 9525 RVA: 0x0005226C File Offset: 0x0005046C
		// (set) Token: 0x06002536 RID: 9526 RVA: 0x00052280 File Offset: 0x00050480
		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				this.name = value;
			}
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06002537 RID: 9527 RVA: 0x00052294 File Offset: 0x00050494
		// (set) Token: 0x06002538 RID: 9528 RVA: 0x000522A8 File Offset: 0x000504A8
		public CultureInfo CultureInfo
		{
			get
			{
				return this.cultureinfo;
			}
			set
			{
				this.cultureinfo = value;
			}
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06002539 RID: 9529 RVA: 0x000522BC File Offset: 0x000504BC
		// (set) Token: 0x0600253A RID: 9530 RVA: 0x000522D0 File Offset: 0x000504D0
		public AssemblyNameFlags Flags
		{
			get
			{
				return this.flags;
			}
			set
			{
				this.flags = value;
			}
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x0600253B RID: 9531 RVA: 0x000522E4 File Offset: 0x000504E4
		public string FullName
		{
			get
			{
				for (;;)
				{
					if (!true)
					{
						goto IL_0054;
					}
					string text = this.name;
					long num = 0L;
					bool flag = char.IsWhiteSpace(text[(int)num]);
					string text2 = this.name;
					string text3 = "\"" + text2 + "\"";
					Version version = this.version;
					if (this.cultureinfo != null)
					{
						CultureInfo cultureInfo = this.cultureinfo;
						CultureInfo invariantCulture = CultureInfo.InvariantCulture;
						goto IL_0054;
					}
					IL_005C:
					if (this.InternalGetPublicKeyToken() != null)
					{
						return;
					}
					continue;
					IL_0054:
					CultureInfo cultureInfo2 = this.cultureinfo;
					goto IL_005C;
				}
			}
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x0600253C RID: 9532 RVA: 0x00052358 File Offset: 0x00050558
		// (set) Token: 0x0600253D RID: 9533 RVA: 0x0005236C File Offset: 0x0005056C
		public Version Version
		{
			get
			{
				return this.version;
			}
			set
			{
				this.version = value;
				int num = value._Major;
				this.major = num;
			}
		}

		// Token: 0x0600253E RID: 9534 RVA: 0x00052390 File Offset: 0x00050590
		public override string ToString()
		{
			string fullName = this.FullName;
			if (fullName != null)
			{
				return fullName;
			}
			return base.ToString();
		}

		// Token: 0x0600253F RID: 9535 RVA: 0x000523B0 File Offset: 0x000505B0
		public byte[] GetPublicKey()
		{
			return this.publicKey;
		}

		// Token: 0x06002540 RID: 9536 RVA: 0x000523C4 File Offset: 0x000505C4
		public byte[] GetPublicKeyToken()
		{
			/*
An exception occurred when decompiling this method (06002540)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte[] System.Reflection.AssemblyName::GetPublicKeyToken()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0033:
	brtrue(IL_0000, ldloc:uint8[][exp:bool](var_1_12))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
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

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06002541 RID: 9537 RVA: 0x00052408 File Offset: 0x00050608
		private bool IsPublicKeyValid
		{
			get
			{
				byte[] array = this.publicKey;
				if (!false)
				{
					return;
				}
			}
		}

		// Token: 0x06002542 RID: 9538 RVA: 0x00052424 File Offset: 0x00050624
		private byte[] InternalGetPublicKeyToken()
		{
			/*
An exception occurred when decompiling this method (06002542)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte[] System.Reflection.AssemblyName::InternalGetPublicKeyToken()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0029:
	brtrue(IL_0000, ldloc:uint8[][exp:bool](var_1_12))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
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

		// Token: 0x06002543 RID: 9539 RVA: 0x0005245C File Offset: 0x0005065C
		private unsafe static void get_public_token(byte* token, byte* pubkey, int len)
		{
		}

		// Token: 0x06002544 RID: 9540 RVA: 0x0005246C File Offset: 0x0005066C
		private byte[] ComputePublicKeyToken()
		{
			/*
An exception occurred when decompiling this method (06002544)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte[] System.Reflection.AssemblyName::ComputePublicKeyToken()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, logicnot:bool(ldfld:uint8[][exp:bool](AssemblyName::publicKey, ldloc:AssemblyName(this))))
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

		// Token: 0x06002545 RID: 9541 RVA: 0x00052484 File Offset: 0x00050684
		public void SetPublicKey(byte[] publicKey)
		{
			AssemblyNameFlags assemblyNameFlags = this.flags;
			this.publicKey = publicKey;
			this.flags = assemblyNameFlags;
		}

		// Token: 0x06002546 RID: 9542 RVA: 0x000524A8 File Offset: 0x000506A8
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			while (info == null)
			{
			}
			string text = this.name;
			info.AddValue("_Name", text);
			byte[] array = this.publicKey;
			info.AddValue("_PublicKey", array);
			byte[] array2 = this.keyToken;
			info.AddValue("_PublicKeyToken", array2);
			if (this.cultureinfo != null)
			{
				return;
			}
			string text2 = this.codebase;
			info.AddValue("_CodeBase", text2);
			Version version = this.version;
			info.AddValue("_Version", version);
			AssemblyHashAlgorithm assemblyHashAlgorithm = this.hashalg;
			StrongNameKeyPair strongNameKeyPair = this.keypair;
			info.AddValue("_StrongNameKeyPair", strongNameKeyPair);
			AssemblyVersionCompatibility assemblyVersionCompatibility = this.versioncompat;
			AssemblyNameFlags assemblyNameFlags = this.flags;
			long num = 0L;
			info.AddValue("_HashForControl", num);
		}

		// Token: 0x06002547 RID: 9543 RVA: 0x00052560 File Offset: 0x00050760
		public object Clone()
		{
			/*
An exception occurred when decompiling this method (06002547)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Reflection.AssemblyName::Clone()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_06, ldfld:string(AssemblyName::name, ldloc:AssemblyName(this)))
	stloc:int32(var_1_0D, ldfld:int32(AssemblyName::major, ldloc:AssemblyName(this)))
	stloc:Version(var_2_14, ldfld:Version(AssemblyName::version, ldloc:AssemblyName(this)))
	stloc:CultureInfo(var_3_1B, ldfld:CultureInfo(AssemblyName::cultureinfo, ldloc:AssemblyName(this)))
	stloc:AssemblyNameFlags(var_4_22, ldfld:AssemblyNameFlags(AssemblyName::flags, ldloc:AssemblyName(this)))
	stloc:StrongNameKeyPair(var_5_2A, ldfld:StrongNameKeyPair(AssemblyName::keypair, ldloc:AssemblyName(this)))
	stloc:uint8[](var_6_32, ldfld:uint8[](AssemblyName::keyToken, ldloc:AssemblyName(this)))
	stloc:AssemblyVersionCompatibility(var_7_3A, ldfld:AssemblyVersionCompatibility(AssemblyName::versioncompat, ldloc:AssemblyName(this)))
	stloc:ProcessorArchitecture(var_8_42, ldfld:ProcessorArchitecture(AssemblyName::processor_architecture, ldloc:AssemblyName(this)))
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

		// Token: 0x06002548 RID: 9544 RVA: 0x000525B0 File Offset: 0x000507B0
		public void OnDeserialization(object sender)
		{
			Version version = this.version;
			this.Version = version;
		}

		// Token: 0x06002549 RID: 9545 RVA: 0x0000207A File Offset: 0x0000027A
		private unsafe static MonoAssemblyName* GetNativeName(IntPtr assembly_ptr)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600254A RID: 9546 RVA: 0x000525CC File Offset: 0x000507CC
		internal unsafe void FillName(MonoAssemblyName* native, string codeBase, bool addVersion, bool addPublickey, bool defaultToken, bool assemblyRef)
		{
			string text;
			this.name = text;
			ushort num = native->major;
			this.major = (int)num;
			ushort num2 = native->minor;
			this.minor = (int)num2;
			ushort num3 = native->build;
			this.build = (int)num3;
			ushort num4 = native->revision;
			this.revision = (int)num4;
			uint num5 = native->flags;
			this.flags = (AssemblyNameFlags)num5;
			uint hash_alg = native->hash_alg;
			this.hashalg = (AssemblyHashAlgorithm)hash_alg;
			int num6 = 1;
			this.versioncompat = (AssemblyVersionCompatibility)num6;
			ushort arch = native->arch;
			this.processor_architecture = (ProcessorArchitecture)arch;
			this.codebase = codeBase;
			IntPtr culture = native->culture;
			IntPtr culture2 = native->culture;
			long num7 = 0L;
			CultureInfo cultureInfo = CultureInfo.CreateCulture(RuntimeMarshal.PtrToUtf8String(culture2), num7 != 0L);
			this.cultureinfo = cultureInfo;
			IntPtr public_key = native->public_key;
			byte[] array = RuntimeMarshal.DecodeBlobArray(native->public_key);
			this.publicKey = array;
		}

		// Token: 0x0600254B RID: 9547 RVA: 0x0000207A File Offset: 0x0000027A
		internal static AssemblyName Create(Assembly assembly, bool fillCodebase)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x040014AC RID: 5292
		private string name;

		// Token: 0x040014AD RID: 5293
		private string codebase;

		// Token: 0x040014AE RID: 5294
		private int major;

		// Token: 0x040014AF RID: 5295
		private int minor;

		// Token: 0x040014B0 RID: 5296
		private int build;

		// Token: 0x040014B1 RID: 5297
		private int revision;

		// Token: 0x040014B2 RID: 5298
		private CultureInfo cultureinfo;

		// Token: 0x040014B3 RID: 5299
		private AssemblyNameFlags flags;

		// Token: 0x040014B4 RID: 5300
		private AssemblyHashAlgorithm hashalg;

		// Token: 0x040014B5 RID: 5301
		private StrongNameKeyPair keypair;

		// Token: 0x040014B6 RID: 5302
		private byte[] publicKey;

		// Token: 0x040014B7 RID: 5303
		private byte[] keyToken;

		// Token: 0x040014B8 RID: 5304
		private AssemblyVersionCompatibility versioncompat;

		// Token: 0x040014B9 RID: 5305
		private Version version;

		// Token: 0x040014BA RID: 5306
		private ProcessorArchitecture processor_architecture;

		// Token: 0x040014BB RID: 5307
		private AssemblyContentType contentType;
	}
}
