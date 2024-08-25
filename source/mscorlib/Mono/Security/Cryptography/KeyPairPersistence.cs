using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using Cpp2IlInjected;

namespace Mono.Security.Cryptography
{
	// Token: 0x02000044 RID: 68
	internal class KeyPairPersistence
	{
		// Token: 0x0600012F RID: 303 RVA: 0x00004B6C File Offset: 0x00002D6C
		public KeyPairPersistence(CspParameters parameters)
		{
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00004B7C File Offset: 0x00002D7C
		public KeyPairPersistence(CspParameters parameters, string keyPair)
		{
			do
			{
				base..ctor();
			}
			while (parameters == null);
			CspParameters cspParameters = this.Copy(parameters);
			this._params = cspParameters;
			this._keyvalue = keyPair;
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000131 RID: 305 RVA: 0x00004BA8 File Offset: 0x00002DA8
		public string Filename
		{
			get
			{
				if (this._filename == null)
				{
					CultureInfo invariantCulture = CultureInfo.InvariantCulture;
					int providerType = this._params.ProviderType;
					string containerName = this.ContainerName;
					int keyNumber = this._params.KeyNumber;
					string text;
					this._filename = text;
					int flags = this._params.m_flags;
					return KeyPairPersistence.UserPath;
				}
				string text2;
				return text2;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000132 RID: 306 RVA: 0x00004C24 File Offset: 0x00002E24
		// (set) Token: 0x06000133 RID: 307 RVA: 0x00004C38 File Offset: 0x00002E38
		public string KeyValue
		{
			get
			{
				return this._keyvalue;
			}
			set
			{
				if (this._keyvalue != null)
				{
					return;
				}
				this._keyvalue = value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000134 RID: 308 RVA: 0x00004C58 File Offset: 0x00002E58
		public CspParameters Parameters
		{
			get
			{
				CspParameters @params = this._params;
				return this.Copy(@params);
			}
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00004C74 File Offset: 0x00002E74
		public bool Load()
		{
			bool flag = File.Exists(this.Filename);
			StreamReader streamReader = File.OpenText(this.Filename);
			long num = 0L;
			if (streamReader != null)
			{
			}
			if (num == 0L)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00004CC0 File Offset: 0x00002EC0
		public void Save()
		{
			string filename = this.Filename;
			Encoding utf = Encoding.UTF8;
			string text = this.ToXml();
			long num = 0L;
			FileStream fileStream;
			if (fileStream != null)
			{
				return;
			}
			if (num == 0L)
			{
				int flags = this._params.m_flags;
				string filename2 = this.Filename;
				bool flag = KeyPairPersistence.ProtectUser(filename2);
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00004D34 File Offset: 0x00002F34
		public void Remove()
		{
			File.Delete(this.Filename);
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000138 RID: 312 RVA: 0x00004D4C File Offset: 0x00002F4C
		private static string UserPath
		{
			get
			{
				if (!true)
				{
				}
				string text2;
				string text = Path.Combine(text2, ".mono");
				if (".mono" == null)
				{
				}
				bool flag = Directory.Exists(Path.Combine(text, "keypairs"));
				if ("keypairs" == null)
				{
				}
				if ("keypairs" == null)
				{
				}
				long num = 0L;
				int num2 = 11;
				if (num != 0L || num2 == 0)
				{
				}
				throw new OutOfMemoryException();
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000139 RID: 313 RVA: 0x00004DD0 File Offset: 0x00002FD0
		private static string MachinePath
		{
			get
			{
				if (!true)
				{
				}
				string text2;
				string text = Path.Combine(text2, ".mono");
				if (".mono" == null)
				{
				}
				bool flag = Directory.Exists(Path.Combine(text, "keypairs"));
				if ("keypairs" == null)
				{
				}
				if ("keypairs" == null)
				{
				}
				long num = 0L;
				int num2 = 11;
				if (num != 0L || num2 == 0)
				{
				}
				throw new OutOfMemoryException();
			}
		}

		// Token: 0x0600013A RID: 314 RVA: 0x0000207A File Offset: 0x0000027A
		internal unsafe static bool _CanSecure(char* root)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600013B RID: 315 RVA: 0x0000207A File Offset: 0x0000027A
		internal unsafe static bool _ProtectUser(char* path)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600013C RID: 316 RVA: 0x0000207A File Offset: 0x0000027A
		internal unsafe static bool _ProtectMachine(char* path)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600013D RID: 317 RVA: 0x0000207A File Offset: 0x0000027A
		internal unsafe static bool _IsUserProtected(char* path)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600013E RID: 318 RVA: 0x0000207A File Offset: 0x0000027A
		internal unsafe static bool _IsMachineProtected(char* path)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00004E54 File Offset: 0x00003054
		private static bool CanSecure(string path)
		{
			/*
An exception occurred when decompiling this method (0600013F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Mono.Security.Cryptography.KeyPairPersistence::CanSecure(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	stloc:PlatformID(var_1_0C, ldfld:PlatformID(OperatingSystem::_platform, callgetter:OperatingSystem(Environment::get_OSVersion)))
	stloc:int32(var_4_16, callgetter:int32(RuntimeHelpers::get_OffsetToStringData))
	brtrue(IL_0000, ldloc:PlatformID[exp:bool](var_1_0C))
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

		// Token: 0x06000140 RID: 320 RVA: 0x00004E7C File Offset: 0x0000307C
		private static bool ProtectUser(string path)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int offsetToStringData = RuntimeHelpers.OffsetToStringData;
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00004E9C File Offset: 0x0000309C
		private static bool ProtectMachine(string path)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int offsetToStringData = RuntimeHelpers.OffsetToStringData;
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00004EBC File Offset: 0x000030BC
		private static bool IsUserProtected(string path)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int offsetToStringData = RuntimeHelpers.OffsetToStringData;
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00004EDC File Offset: 0x000030DC
		private static bool IsMachineProtected(string path)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int offsetToStringData = RuntimeHelpers.OffsetToStringData;
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000144 RID: 324 RVA: 0x00004EFC File Offset: 0x000030FC
		private bool CanChange
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000144)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Mono.Security.Cryptography.KeyPairPersistence::get_CanChange()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_06, ldfld:string(KeyPairPersistence::_keyvalue, ldloc:KeyPairPersistence(this)))
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

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000145 RID: 325 RVA: 0x00004F10 File Offset: 0x00003110
		private bool UseDefaultKeyContainer
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000145)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Mono.Security.Cryptography.KeyPairPersistence::get_UseDefaultKeyContainer()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_0B, ldfld:int32(CspParameters::m_flags, ldfld:CspParameters(KeyPairPersistence::_params, ldloc:KeyPairPersistence(this))))
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

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000146 RID: 326 RVA: 0x00004F28 File Offset: 0x00003128
		private bool UseMachineKeyStore
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000146)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Mono.Security.Cryptography.KeyPairPersistence::get_UseMachineKeyStore()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_0B, ldfld:int32(CspParameters::m_flags, ldfld:CspParameters(KeyPairPersistence::_params, ldloc:KeyPairPersistence(this))))
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

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000147 RID: 327 RVA: 0x00004F40 File Offset: 0x00003140
		private string ContainerName
		{
			get
			{
				string text;
				if (this._container == null)
				{
					CspParameters @params = this._params;
					int flags = @params.m_flags;
					string keyContainerName = @params.KeyContainerName;
					if (keyContainerName != null && keyContainerName._stringLength != 0)
					{
						Encoding utf = Encoding.UTF8;
						string keyContainerName2 = this._params.KeyContainerName;
						MD5 md = MD5.Create();
						return "default";
					}
					text = Guid.NewGuid().ToString();
					this._container = text;
				}
				return text;
			}
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00004FB4 File Offset: 0x000031B4
		private CspParameters Copy(CspParameters p)
		{
			/*
An exception occurred when decompiling this method (06000148)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Security.Cryptography.CspParameters Mono.Security.Cryptography.KeyPairPersistence::Copy(System.Security.Cryptography.CspParameters)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(CspParameters::ProviderType, ldloc:CspParameters(p)))
	stloc:string(var_1_0D, ldfld:string(CspParameters::ProviderName, ldloc:CspParameters(p)))
	stloc:string(var_2_14, ldfld:string(CspParameters::KeyContainerName, ldloc:CspParameters(p)))
	stloc:int32(var_3_1B, ldfld:int32(CspParameters::KeyNumber, ldloc:CspParameters(p)))
	stloc:int32(var_4_22, ldfld:int32(CspParameters::m_flags, ldloc:CspParameters(p)))
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

		// Token: 0x06000149 RID: 329 RVA: 0x00004FE4 File Offset: 0x000031E4
		private void FromXml(string xml)
		{
			SecurityElement securityElement;
			ArrayList children = securityElement.children;
			ArrayList children2 = securityElement.children;
			this._keyvalue = children2;
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00005008 File Offset: 0x00003208
		private string ToXml()
		{
			/*
An exception occurred when decompiling this method (0600014A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String Mono.Security.Cryptography.KeyPairPersistence::ToXml()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_1:
	stloc:int32(var_5_2A, ldfld:int32(CspParameters::ProviderType, ldfld:CspParameters(KeyPairPersistence::_params, ldloc:KeyPairPersistence(this))))
	stloc:string(var_7_34, callgetter:string(Environment::get_NewLine))
	stloc:string(var_9_3C, callgetter:string(KeyPairPersistence::get_ContainerName, ldloc:KeyPairPersistence(this)))
	stloc:string(var_11_46, callgetter:string(Environment::get_NewLine))
	stloc:int32(var_13_53, ldfld:int32(CspParameters::KeyNumber, ldfld:CspParameters(KeyPairPersistence::_params, ldloc:KeyPairPersistence(this))))
	stloc:string(var_15_5B, ldfld:string(KeyPairPersistence::_keyvalue, ldloc:KeyPairPersistence(this)))
	stloc:string(var_17_65, callgetter:string(Environment::get_NewLine))
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

		// Token: 0x0600014B RID: 331 RVA: 0x0000507C File Offset: 0x0000327C
		// Note: this type is marked as 'beforefieldinit'.
		static KeyPairPersistence()
		{
		}

		// Token: 0x0400013F RID: 319
		private static bool _userPathExists;

		// Token: 0x04000140 RID: 320
		private static string _userPath;

		// Token: 0x04000141 RID: 321
		private static bool _machinePathExists;

		// Token: 0x04000142 RID: 322
		private static string _machinePath;

		// Token: 0x04000143 RID: 323
		private CspParameters _params;

		// Token: 0x04000144 RID: 324
		private string _keyvalue;

		// Token: 0x04000145 RID: 325
		private string _filename;

		// Token: 0x04000146 RID: 326
		private string _container;

		// Token: 0x04000147 RID: 327
		private static object lockobj;
	}
}
