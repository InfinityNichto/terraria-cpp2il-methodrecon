using System;
using Cpp2IlInjected;
using UnityEngine;

namespace InControl
{
	// Token: 0x02000021 RID: 33
	[Serializable]
	public struct InputControlSource
	{
		// Token: 0x17000060 RID: 96
		// (get) Token: 0x0600015B RID: 347 RVA: 0x000025E1 File Offset: 0x000007E1
		// (set) Token: 0x0600015C RID: 348 RVA: 0x00004A0C File Offset: 0x00002C0C
		public InputControlSourceType SourceType
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
				this.sourceType = value;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x0600015D RID: 349 RVA: 0x00004A20 File Offset: 0x00002C20
		// (set) Token: 0x0600015E RID: 350 RVA: 0x00004A34 File Offset: 0x00002C34
		public int Index
		{
			get
			{
				return this.index;
			}
			set
			{
				this.index = value;
			}
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00004A48 File Offset: 0x00002C48
		public InputControlSource(InputControlSourceType sourceType, int index)
		{
			this.sourceType = sourceType;
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00004A5C File Offset: 0x00002C5C
		public InputControlSource(KeyCode keyCode)
		{
			this.sourceType = InputControlSourceType.KeyCode;
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00004A70 File Offset: 0x00002C70
		public float GetValue(InputDevice inputDevice)
		{
			/*
An exception occurred when decompiling this method (06000161)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single InControl.InputControlSource::GetValue(InControl.InputDevice)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_0_07, call:bool(InputControlSource::GetState, ldloc:valuetype InControl.InputControlSource&(this), ldloc:InputDevice(inputDevice)))
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

		// Token: 0x06000162 RID: 354 RVA: 0x00004A84 File Offset: 0x00002C84
		public bool GetState(InputDevice inputDevice)
		{
			int num = this.index;
			float value = this.GetValue(inputDevice);
			return Utility.IsNotZero(value);
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00004AB4 File Offset: 0x00002CB4
		public string ToCode()
		{
			if ("new InputControlSource( InputControlSourceType." != null)
			{
			}
			string text;
			if ((text == null || text != null) && (", " == null || ", " != null))
			{
				int num = this.index;
				string text2;
				if ((text2 == null || text2 != null) && (" )" == null || " )" != null))
				{
					string text3;
					return text3;
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0400013F RID: 319
		[SerializeField]
		private InputControlSourceType sourceType;

		// Token: 0x04000140 RID: 320
		[SerializeField]
		private int index;
	}
}
