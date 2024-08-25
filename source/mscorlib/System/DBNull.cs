using System;
using System.Runtime.Serialization;
using Cpp2IlInjected;

namespace System
{
	// Token: 0x0200009A RID: 154
	[Serializable]
	public sealed class DBNull : ISerializable, IConvertible
	{
		// Token: 0x06000597 RID: 1431 RVA: 0x0000E44C File Offset: 0x0000C64C
		private DBNull()
		{
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x0000E460 File Offset: 0x0000C660
		private DBNull(SerializationInfo info, StreamingContext context)
		{
			/*
An exception occurred when decompiling this method (06000598)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.DBNull::.ctor(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(object::.ctor, ldloc:DBNull[exp:object](this))
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

		// Token: 0x06000599 RID: 1433 RVA: 0x0000E474 File Offset: 0x0000C674
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x0000207A File Offset: 0x0000027A
		public override string ToString()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x0000207A File Offset: 0x0000027A
		public string ToString(IFormatProvider provider)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x0000E484 File Offset: 0x0000C684
		public TypeCode GetTypeCode()
		{
			return TypeCode.DBNull;
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x0000207A File Offset: 0x0000027A
		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x0000207A File Offset: 0x0000027A
		char IConvertible.ToChar(IFormatProvider provider)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x0000207A File Offset: 0x0000027A
		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x0000207A File Offset: 0x0000027A
		byte IConvertible.ToByte(IFormatProvider provider)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x0000207A File Offset: 0x0000027A
		short IConvertible.ToInt16(IFormatProvider provider)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x0000207A File Offset: 0x0000027A
		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x0000207A File Offset: 0x0000027A
		int IConvertible.ToInt32(IFormatProvider provider)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x0000207A File Offset: 0x0000027A
		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x0000207A File Offset: 0x0000027A
		long IConvertible.ToInt64(IFormatProvider provider)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x0000207A File Offset: 0x0000027A
		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x0000207A File Offset: 0x0000027A
		float IConvertible.ToSingle(IFormatProvider provider)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x0000207A File Offset: 0x0000027A
		double IConvertible.ToDouble(IFormatProvider provider)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x0000207A File Offset: 0x0000027A
		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x0000207A File Offset: 0x0000027A
		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x0000E494 File Offset: 0x0000C694
		object IConvertible.ToType(Type type, IFormatProvider provider)
		{
			if (!true)
			{
			}
			return Convert.DefaultToType(this, type, provider);
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x0000E4AC File Offset: 0x0000C6AC
		// Note: this type is marked as 'beforefieldinit'.
		static DBNull()
		{
		}

		// Token: 0x04000223 RID: 547
		public static readonly DBNull Value;
	}
}
