using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x020000FE RID: 254
	[Serializable]
	public sealed class CultureAwareComparer : StringComparer, ISerializable
	{
		// Token: 0x06000988 RID: 2440 RVA: 0x00016EF0 File Offset: 0x000150F0
		internal CultureAwareComparer(CultureInfo culture, CompareOptions options)
		{
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x00016F00 File Offset: 0x00015100
		internal CultureAwareComparer(CompareInfo compareInfo, CompareOptions options)
		{
			if (!true)
			{
			}
			base..ctor();
			this._compareInfo = compareInfo;
			this._options = options;
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x00016F24 File Offset: 0x00015124
		private CultureAwareComparer(SerializationInfo info, StreamingContext context)
		{
			int num = 1;
			if (num == 0)
			{
			}
			base..ctor();
			if (num == 0)
			{
			}
			Type type;
			object value = info.GetValue("_compareInfo", type);
			if (value != null)
			{
				this._compareInfo = value;
				return;
			}
			bool boolean = info.GetBoolean("_ignoreCase");
			Type type2;
			if (info.GetValueNoThrow("_options", type2) != null)
			{
				return;
			}
			CompareOptions options = this._options;
			this._options = options;
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x00016F8C File Offset: 0x0001518C
		public override int Compare(string x, string y)
		{
			if (x != null && y != null)
			{
				CompareInfo compareInfo = this._compareInfo;
			}
			return 1;
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x00016FAC File Offset: 0x000151AC
		public override bool Equals(string x, string y)
		{
			if (x != null && y != null)
			{
				CompareInfo compareInfo = this._compareInfo;
				CompareOptions options = this._options;
			}
			return true;
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x00016FD0 File Offset: 0x000151D0
		public override int GetHashCode(string obj)
		{
			while (obj == null)
			{
			}
			CompareInfo compareInfo = this._compareInfo;
			CompareOptions options = this._options;
			return compareInfo.GetHashCodeOfString(obj, options);
		}

		// Token: 0x0600098E RID: 2446 RVA: 0x00016FF8 File Offset: 0x000151F8
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
				CompareOptions options = this._options;
				CompareInfo compareInfo = this._compareInfo;
				return;
			}
		}

		// Token: 0x0600098F RID: 2447 RVA: 0x00017018 File Offset: 0x00015218
		public override int GetHashCode()
		{
			/*
An exception occurred when decompiling this method (0600098F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.CultureAwareComparer::GetHashCode()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:CompareInfo(var_0_06, ldfld:CompareInfo(CultureAwareComparer::_compareInfo, ldloc:CultureAwareComparer(this)))
	stloc:CompareOptions(var_1_0D, ldfld:CompareOptions(CultureAwareComparer::_options, ldloc:CultureAwareComparer(this)))
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

		// Token: 0x06000990 RID: 2448 RVA: 0x00017034 File Offset: 0x00015234
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			CompareInfo compareInfo = this._compareInfo;
			info.AddValue("_compareInfo", compareInfo);
			CompareOptions options = this._options;
			CompareOptions options2 = this._options;
			info.AddValue("_ignoreCase", true);
		}

		// Token: 0x040003A6 RID: 934
		private readonly CompareInfo _compareInfo;

		// Token: 0x040003A7 RID: 935
		private CompareOptions _options;
	}
}
