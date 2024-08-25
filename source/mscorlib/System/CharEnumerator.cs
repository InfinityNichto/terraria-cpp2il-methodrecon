using System;
using System.Collections;
using System.Collections.Generic;

namespace System
{
	// Token: 0x02000096 RID: 150
	[Serializable]
	public sealed class CharEnumerator : IEnumerator, IEnumerator<char>, IDisposable, ICloneable
	{
		// Token: 0x060004A6 RID: 1190 RVA: 0x0000D32C File Offset: 0x0000B52C
		internal CharEnumerator(string str)
		{
			this._str = str;
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x0000D348 File Offset: 0x0000B548
		public object Clone()
		{
			return base.MemberwiseClone();
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x0000D35C File Offset: 0x0000B55C
		public bool MoveNext()
		{
			/*
An exception occurred when decompiling this method (060004A8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.CharEnumerator::MoveNext()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_06, ldfld:string(CharEnumerator::_str, ldloc:CharEnumerator(this)))
	stloc:int32(var_1_0D, ldfld:int32(CharEnumerator::_index, ldloc:CharEnumerator(this)))
	stloc:int32(var_2_14, ldfld:int32(string::_stringLength, ldloc:string(var_0_06)))
	stfld:char(CharEnumerator::_currentElement, ldloc:CharEnumerator(this), ldloc:char(var_3))
	stfld:int32(CharEnumerator::_index, ldloc:CharEnumerator(this), ldloc:int32(var_2_14))
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

		// Token: 0x060004A9 RID: 1193 RVA: 0x0000D394 File Offset: 0x0000B594
		public void Dispose()
		{
			string str = this._str;
			if (str != null)
			{
				int stringLength = str._stringLength;
				this._index = stringLength;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060004AA RID: 1194 RVA: 0x0000D3BC File Offset: 0x0000B5BC
		object IEnumerator.Current
		{
			get
			{
				/*
An exception occurred when decompiling this method (060004AA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.CharEnumerator::System.Collections.IEnumerator.get_Current()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:char(var_0_06, callgetter:char(CharEnumerator::get_Current, ldloc:CharEnumerator(this)))
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

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060004AB RID: 1195 RVA: 0x0000D3D0 File Offset: 0x0000B5D0
		public char Current
		{
			get
			{
				int index = this._index;
				int stringLength = this._str._stringLength;
				return this._currentElement;
			}
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x0000D3FC File Offset: 0x0000B5FC
		public void Reset()
		{
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x0000D40C File Offset: 0x0000B60C
		internal CharEnumerator()
		{
			throw new NotSupportedException();
		}

		// Token: 0x04000214 RID: 532
		private string _str;

		// Token: 0x04000215 RID: 533
		private int _index;

		// Token: 0x04000216 RID: 534
		private char _currentElement;
	}
}
