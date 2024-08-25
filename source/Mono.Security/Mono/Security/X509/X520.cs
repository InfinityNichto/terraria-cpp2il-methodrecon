using System;

namespace Mono.Security.X509
{
	// Token: 0x02000021 RID: 33
	public class X520
	{
		// Token: 0x0600017C RID: 380 RVA: 0x000075AC File Offset: 0x000057AC
		public X520()
		{
		}

		// Token: 0x02000022 RID: 34
		public abstract class AttributeTypeAndValue
		{
			// Token: 0x0600017D RID: 381 RVA: 0x000075C0 File Offset: 0x000057C0
			protected AttributeTypeAndValue(string oid, int upperBound)
			{
				this.oid = oid;
				this.upperBound = upperBound;
				this.encoding = byte.MaxValue;
			}

			// Token: 0x0600017E RID: 382 RVA: 0x000075EC File Offset: 0x000057EC
			protected AttributeTypeAndValue(string oid, int upperBound, byte encoding)
			{
				this.oid = oid;
				this.upperBound = upperBound;
				this.encoding = encoding;
			}

			// Token: 0x17000076 RID: 118
			// (get) Token: 0x0600017F RID: 383 RVA: 0x00007614 File Offset: 0x00005814
			// (set) Token: 0x06000180 RID: 384 RVA: 0x00007628 File Offset: 0x00005828
			public string Value
			{
				get
				{
					return this.attrValue;
				}
				set
				{
					string text = this.attrValue;
					if (text != null)
					{
						int stringLength = text._stringLength;
						int num = this.upperBound;
					}
					this.attrValue = value;
				}
			}

			// Token: 0x17000077 RID: 119
			// (get) Token: 0x06000181 RID: 385 RVA: 0x00007668 File Offset: 0x00005868
			public ASN1 ASN1
			{
				get
				{
					byte b = this.encoding;
					return this.GetASN1(b);
				}
			}

			// Token: 0x06000182 RID: 386 RVA: 0x00007684 File Offset: 0x00005884
			internal ASN1 GetASN1(byte encoding)
			{
				/*
An exception occurred when decompiling this method (06000182)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Mono.Security.ASN1 Mono.Security.X509.X520/AttributeTypeAndValue::GetASN1(System.Byte)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint8(var_0_06, call:uint8(AttributeTypeAndValue::SelectBestEncoding, ldloc:AttributeTypeAndValue(this)))
	stloc:ASN1(var_1_12, call:ASN1(ASN1Convert::FromOid, ldfld:string(AttributeTypeAndValue::oid, ldloc:AttributeTypeAndValue(this))))
	stloc:Encoding(var_4_1A, callgetter:Encoding(Encoding::get_ASCII))
	stloc:string(var_5_22, ldfld:string(AttributeTypeAndValue::attrValue, ldloc:AttributeTypeAndValue(this)))
	stloc:Encoding(var_7_2C, callgetter:Encoding(Encoding::get_BigEndianUnicode))
	stloc:Encoding(var_9_36, callgetter:Encoding(Encoding::get_ASCII))
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

			// Token: 0x06000183 RID: 387 RVA: 0x000076C8 File Offset: 0x000058C8
			internal ASN1 GetASN1()
			{
				byte b = this.encoding;
				return this.GetASN1(b);
			}

			// Token: 0x06000184 RID: 388 RVA: 0x000076E4 File Offset: 0x000058E4
			public byte[] GetBytes(byte encoding)
			{
				/*
An exception occurred when decompiling this method (06000184)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte[] Mono.Security.X509.X520/AttributeTypeAndValue::GetBytes(System.Byte)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:ASN1(var_0_07, call:ASN1(AttributeTypeAndValue::GetASN1, ldloc:AttributeTypeAndValue(this), ldloc:uint8(encoding)))
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

			// Token: 0x06000185 RID: 389 RVA: 0x000076F8 File Offset: 0x000058F8
			public byte[] GetBytes()
			{
				/*
An exception occurred when decompiling this method (06000185)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte[] Mono.Security.X509.X520/AttributeTypeAndValue::GetBytes()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint8(var_0_06, ldfld:uint8(AttributeTypeAndValue::encoding, ldloc:AttributeTypeAndValue(this)))
	stloc:ASN1(var_1_0E, call:ASN1(AttributeTypeAndValue::GetASN1, ldloc:AttributeTypeAndValue(this), ldloc:uint8(var_0_06)))
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

			// Token: 0x06000186 RID: 390 RVA: 0x00007714 File Offset: 0x00005914
			private byte SelectBestEncoding()
			{
				/*
An exception occurred when decompiling this method (06000186)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte Mono.Security.X509.X520/AttributeTypeAndValue::SelectBestEncoding()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_06, ldfld:string(AttributeTypeAndValue::attrValue, ldloc:AttributeTypeAndValue(this)))
	stloc:int32(var_1_0D, ldfld:int32(string::_stringLength, ldloc:string(var_0_06)))
	stloc:int64(var_2_0F, ldc.i4:int64(0))
	stloc:char(var_3_17, callgetter:char(string::get_Chars, ldloc:string(var_0_06), ldloc:int64[exp:int32](var_2_0F)))
	stloc:int32(var_4_1E, ldfld:int32(string::_stringLength, ldloc:string(var_0_06)))
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

			// Token: 0x040000B9 RID: 185
			private string oid;

			// Token: 0x040000BA RID: 186
			private string attrValue;

			// Token: 0x040000BB RID: 187
			private int upperBound;

			// Token: 0x040000BC RID: 188
			private byte encoding;
		}

		// Token: 0x02000023 RID: 35
		public class Name : X520.AttributeTypeAndValue
		{
			// Token: 0x06000187 RID: 391 RVA: 0x00007748 File Offset: 0x00005948
			public Name()
			{
				this.oid = "2.5.4.41";
				this.upperBound = 32768;
				this.encoding = byte.MaxValue;
			}
		}

		// Token: 0x02000024 RID: 36
		public class CommonName : X520.AttributeTypeAndValue
		{
			// Token: 0x06000188 RID: 392 RVA: 0x0000777C File Offset: 0x0000597C
			public CommonName()
			{
				this.oid = "2.5.4.3";
				this.upperBound = 64;
				this.encoding = byte.MaxValue;
			}
		}

		// Token: 0x02000025 RID: 37
		public class SerialNumber : X520.AttributeTypeAndValue
		{
			// Token: 0x06000189 RID: 393 RVA: 0x000077B0 File Offset: 0x000059B0
			public SerialNumber()
			{
				this.oid = "2.5.4.5";
				this.upperBound = 64;
				this.encoding = 19;
			}
		}

		// Token: 0x02000026 RID: 38
		public class LocalityName : X520.AttributeTypeAndValue
		{
			// Token: 0x0600018A RID: 394 RVA: 0x000077E0 File Offset: 0x000059E0
			public LocalityName()
			{
				this.oid = "2.5.4.7";
				this.upperBound = 128;
				this.encoding = byte.MaxValue;
			}
		}

		// Token: 0x02000027 RID: 39
		public class StateOrProvinceName : X520.AttributeTypeAndValue
		{
			// Token: 0x0600018B RID: 395 RVA: 0x00007814 File Offset: 0x00005A14
			public StateOrProvinceName()
			{
				this.oid = "2.5.4.8";
				this.upperBound = 128;
				this.encoding = byte.MaxValue;
			}
		}

		// Token: 0x02000028 RID: 40
		public class OrganizationName : X520.AttributeTypeAndValue
		{
			// Token: 0x0600018C RID: 396 RVA: 0x00007848 File Offset: 0x00005A48
			public OrganizationName()
			{
				this.oid = "2.5.4.10";
				this.upperBound = 64;
				this.encoding = byte.MaxValue;
			}
		}

		// Token: 0x02000029 RID: 41
		public class OrganizationalUnitName : X520.AttributeTypeAndValue
		{
			// Token: 0x0600018D RID: 397 RVA: 0x0000787C File Offset: 0x00005A7C
			public OrganizationalUnitName()
			{
				this.oid = "2.5.4.11";
				this.upperBound = 64;
				this.encoding = byte.MaxValue;
			}
		}

		// Token: 0x0200002A RID: 42
		public class EmailAddress : X520.AttributeTypeAndValue
		{
			// Token: 0x0600018E RID: 398 RVA: 0x000078B0 File Offset: 0x00005AB0
			public EmailAddress()
			{
				this.oid = "1.2.840.113549.1.9.1";
				this.upperBound = 128;
				this.encoding = 22;
			}
		}

		// Token: 0x0200002B RID: 43
		public class DomainComponent : X520.AttributeTypeAndValue
		{
			// Token: 0x0600018F RID: 399 RVA: 0x000078E4 File Offset: 0x00005AE4
			public DomainComponent()
			{
				this.oid = "0.9.2342.19200300.100.1.25";
				this.upperBound = 1;
				this.encoding = 22;
			}
		}

		// Token: 0x0200002C RID: 44
		public class UserId : X520.AttributeTypeAndValue
		{
			// Token: 0x06000190 RID: 400 RVA: 0x00007914 File Offset: 0x00005B14
			public UserId()
			{
				this.oid = "0.9.2342.19200300.100.1.1";
				this.upperBound = 256;
				this.encoding = byte.MaxValue;
			}
		}

		// Token: 0x0200002D RID: 45
		public class Oid : X520.AttributeTypeAndValue
		{
			// Token: 0x06000191 RID: 401 RVA: 0x00007948 File Offset: 0x00005B48
			public Oid(string oid)
			{
				this.oid = oid;
				this.encoding = byte.MaxValue;
			}
		}

		// Token: 0x0200002E RID: 46
		public class Title : X520.AttributeTypeAndValue
		{
			// Token: 0x06000192 RID: 402 RVA: 0x00007970 File Offset: 0x00005B70
			public Title()
			{
				this.oid = "2.5.4.12";
				this.upperBound = 64;
				this.encoding = byte.MaxValue;
			}
		}

		// Token: 0x0200002F RID: 47
		public class CountryName : X520.AttributeTypeAndValue
		{
			// Token: 0x06000193 RID: 403 RVA: 0x000079A4 File Offset: 0x00005BA4
			public CountryName()
			{
				this.oid = "2.5.4.6";
				this.upperBound = 2;
				this.encoding = 19;
			}
		}

		// Token: 0x02000030 RID: 48
		public class DnQualifier : X520.AttributeTypeAndValue
		{
			// Token: 0x06000194 RID: 404 RVA: 0x000079D4 File Offset: 0x00005BD4
			public DnQualifier()
			{
				this.oid = "2.5.4.46";
				this.upperBound = 2;
				this.encoding = 19;
			}
		}

		// Token: 0x02000031 RID: 49
		public class Surname : X520.AttributeTypeAndValue
		{
			// Token: 0x06000195 RID: 405 RVA: 0x00007A04 File Offset: 0x00005C04
			public Surname()
			{
				this.oid = "2.5.4.4";
				this.upperBound = 32768;
				this.encoding = byte.MaxValue;
			}
		}

		// Token: 0x02000032 RID: 50
		public class GivenName : X520.AttributeTypeAndValue
		{
			// Token: 0x06000196 RID: 406 RVA: 0x00007A38 File Offset: 0x00005C38
			public GivenName()
			{
				this.oid = "2.5.4.42";
				this.upperBound = 16;
				this.encoding = byte.MaxValue;
			}
		}

		// Token: 0x02000033 RID: 51
		public class Initial : X520.AttributeTypeAndValue
		{
			// Token: 0x06000197 RID: 407 RVA: 0x00007A6C File Offset: 0x00005C6C
			public Initial()
			{
				this.oid = "2.5.4.43";
				this.upperBound = 5;
				this.encoding = byte.MaxValue;
			}
		}
	}
}
