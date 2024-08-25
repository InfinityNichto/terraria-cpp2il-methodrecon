using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.ComponentModel
{
	// Token: 0x0200032B RID: 811
	[AttributeUsage(AttributeTargets.All)]
	public class DefaultValueAttribute : Attribute
	{
		// Token: 0x06001519 RID: 5401 RVA: 0x0003F8A0 File Offset: 0x0003DAA0
		public DefaultValueAttribute(Type type, string value)
		{
			int num = 1;
			base..ctor();
			bool flag = DefaultValueAttribute.<.ctor>g__TryConvertFromInvariantString|2_0(type, value, value);
			this._value = num;
		}

		// Token: 0x0600151A RID: 5402 RVA: 0x0003F90C File Offset: 0x0003DB0C
		public DefaultValueAttribute(char value)
		{
		}

		// Token: 0x0600151B RID: 5403 RVA: 0x0003F920 File Offset: 0x0003DB20
		public DefaultValueAttribute(byte value)
		{
		}

		// Token: 0x0600151C RID: 5404 RVA: 0x0003F934 File Offset: 0x0003DB34
		public DefaultValueAttribute(short value)
		{
		}

		// Token: 0x0600151D RID: 5405 RVA: 0x0003F948 File Offset: 0x0003DB48
		public DefaultValueAttribute(int value)
		{
		}

		// Token: 0x0600151E RID: 5406 RVA: 0x0003F95C File Offset: 0x0003DB5C
		public DefaultValueAttribute(long value)
		{
		}

		// Token: 0x0600151F RID: 5407 RVA: 0x0003F970 File Offset: 0x0003DB70
		public DefaultValueAttribute(float value)
		{
		}

		// Token: 0x06001520 RID: 5408 RVA: 0x0003F984 File Offset: 0x0003DB84
		public DefaultValueAttribute(double value)
		{
		}

		// Token: 0x06001521 RID: 5409 RVA: 0x0003F998 File Offset: 0x0003DB98
		public DefaultValueAttribute(bool value)
		{
		}

		// Token: 0x06001522 RID: 5410 RVA: 0x0003F9AC File Offset: 0x0003DBAC
		public DefaultValueAttribute(string value)
		{
			this._value = value;
		}

		// Token: 0x06001523 RID: 5411 RVA: 0x0003F9C8 File Offset: 0x0003DBC8
		public DefaultValueAttribute(object value)
		{
			this._value = value;
		}

		// Token: 0x06001524 RID: 5412 RVA: 0x0003F9E4 File Offset: 0x0003DBE4
		[CLSCompliant(false)]
		public DefaultValueAttribute(sbyte value)
		{
		}

		// Token: 0x06001525 RID: 5413 RVA: 0x0003F9F8 File Offset: 0x0003DBF8
		[CLSCompliant(false)]
		public DefaultValueAttribute(ushort value)
		{
		}

		// Token: 0x06001526 RID: 5414 RVA: 0x0003FA0C File Offset: 0x0003DC0C
		[CLSCompliant(false)]
		public DefaultValueAttribute(uint value)
		{
		}

		// Token: 0x06001527 RID: 5415 RVA: 0x0003FA20 File Offset: 0x0003DC20
		[CLSCompliant(false)]
		public DefaultValueAttribute(ulong value)
		{
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06001528 RID: 5416 RVA: 0x0003FA34 File Offset: 0x0003DC34
		public virtual object Value
		{
			get
			{
				return this._value;
			}
		}

		// Token: 0x06001529 RID: 5417 RVA: 0x0003FA48 File Offset: 0x0003DC48
		public override bool Equals(object obj)
		{
			/*
An exception occurred when decompiling this method (06001529)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.ComponentModel.DefaultValueAttribute::Equals(System.Object)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	brtrue(IL_0000, logicnot:bool(ldloc:DefaultValueAttribute[exp:bool](this)))
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

		// Token: 0x0600152A RID: 5418 RVA: 0x0003FA60 File Offset: 0x0003DC60
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x0600152B RID: 5419 RVA: 0x0003FA74 File Offset: 0x0003DC74
		protected void SetValue(object value)
		{
			this._value = value;
		}

		// Token: 0x0600152C RID: 5420 RVA: 0x0003FA88 File Offset: 0x0003DC88
		[CompilerGenerated]
		internal static bool <.ctor>g__TryConvertFromInvariantString|2_0(Type typeToConvert, string stringValue, [Out] object conversionResult)
		{
			return true;
		}

		// Token: 0x0400116C RID: 4460
		private object _value;

		// Token: 0x0400116D RID: 4461
		private static object s_convertFromInvariantString;
	}
}
