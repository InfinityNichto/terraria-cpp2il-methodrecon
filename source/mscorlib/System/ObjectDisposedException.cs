using System;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x020000E8 RID: 232
	[Serializable]
	public class ObjectDisposedException : InvalidOperationException
	{
		// Token: 0x060008B8 RID: 2232 RVA: 0x0001557C File Offset: 0x0001377C
		private ObjectDisposedException()
			: base("Cannot access a disposed object.")
		{
			this._HResult = 5666;
		}

		// Token: 0x060008B9 RID: 2233 RVA: 0x000155A0 File Offset: 0x000137A0
		public ObjectDisposedException(string objectName)
			: base("Cannot access a disposed object.")
		{
			this._HResult = 5666;
			this._objectName = objectName;
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x000155CC File Offset: 0x000137CC
		public ObjectDisposedException(string objectName, string message)
			: base(message)
		{
			this._HResult = 5666;
			this._objectName = objectName;
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x000155F4 File Offset: 0x000137F4
		protected ObjectDisposedException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			string @string = info.GetString("ObjectName");
			this._objectName = @string;
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x0001561C File Offset: 0x0001381C
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			if (this._objectName == null)
			{
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060008BD RID: 2237 RVA: 0x0001563C File Offset: 0x0001383C
		public override string Message
		{
			get
			{
				if (this._objectName == null)
				{
				}
				string message = base.Message;
				string newLine = Environment.NewLine;
				string text;
				return message + newLine + text;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060008BE RID: 2238 RVA: 0x0001566C File Offset: 0x0001386C
		public string ObjectName
		{
			get
			{
				/*
An exception occurred when decompiling this method (060008BE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.ObjectDisposedException::get_ObjectName()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:string[exp:bool](ObjectDisposedException::_objectName, ldloc:ObjectDisposedException(this)))
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
		}

		// Token: 0x0400037E RID: 894
		private string _objectName;
	}
}
