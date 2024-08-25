using System;
using System.Collections;
using Cpp2IlInjected;

namespace System.ComponentModel
{
	// Token: 0x0200034A RID: 842
	public class AttributeCollection : ICollection, IEnumerable
	{
		// Token: 0x060015E1 RID: 5601 RVA: 0x00040BC4 File Offset: 0x0003EDC4
		public AttributeCollection(params Attribute[] attributes)
		{
			if (attributes == null)
			{
			}
		}

		// Token: 0x060015E2 RID: 5602 RVA: 0x00040BDC File Offset: 0x0003EDDC
		protected AttributeCollection()
		{
		}

		// Token: 0x060015E3 RID: 5603 RVA: 0x00040BF0 File Offset: 0x0003EDF0
		public static AttributeCollection FromExisting(AttributeCollection existing, params Attribute[] newAttributes)
		{
			if (existing == null)
			{
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x060015E4 RID: 5604 RVA: 0x00040C10 File Offset: 0x0003EE10
		protected virtual Attribute[] Attributes
		{
			get
			{
				return this._attributes;
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x060015E5 RID: 5605 RVA: 0x00040C24 File Offset: 0x0003EE24
		public int Count
		{
			get
			{
				/*
An exception occurred when decompiling this method (060015E5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.ComponentModel.AttributeCollection::get_Count()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:valuetype System.ComponentModel.AttributeCollection/AttributeEntry[](var_0_06, ldfld:valuetype System.ComponentModel.AttributeCollection/AttributeEntry[](AttributeCollection::_foundAttributeTypes, ldloc:AttributeCollection(this)))
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

		// Token: 0x170004F9 RID: 1273
		public virtual Attribute this[int index]
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170004FA RID: 1274
		public virtual Attribute this[Type attributeType]
		{
			get
			{
				if (!true)
				{
				}
				if (this._foundAttributeTypes == null)
				{
				}
				AttributeCollection.AttributeEntry[] foundAttributeTypes = this._foundAttributeTypes;
				AttributeCollection.AttributeEntry[] foundAttributeTypes2 = this._foundAttributeTypes;
				AttributeCollection.AttributeEntry[] foundAttributeTypes3 = this._foundAttributeTypes;
				AttributeCollection.AttributeEntry[] foundAttributeTypes4 = this._foundAttributeTypes;
				Type type;
				bool flag = type == attributeType;
				AttributeCollection.AttributeEntry[] foundAttributeTypes5 = this._foundAttributeTypes;
				Attribute attribute;
				return attribute;
			}
		}

		// Token: 0x060015E8 RID: 5608 RVA: 0x00040CD0 File Offset: 0x0003EED0
		public bool Contains(Attribute attribute)
		{
			/*
An exception occurred when decompiling this method (060015E8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.ComponentModel.AttributeCollection::Contains(System.Attribute)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	stloc:Type(var_0_06, call:Type(object::GetType, ldloc:Attribute[exp:object](attribute)))
	brtrue(IL_0000, logicnot:bool(ldloc:AttributeCollection[exp:bool](this)))
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

		// Token: 0x060015E9 RID: 5609 RVA: 0x00040CE8 File Offset: 0x0003EEE8
		public bool Contains(Attribute[] attributes)
		{
			if (attributes != null)
			{
				bool flag = this.Contains(attributes);
				return;
			}
		}

		// Token: 0x060015EA RID: 5610 RVA: 0x00040D08 File Offset: 0x0003EF08
		protected Attribute GetDefaultAttribute(Type attributeType)
		{
			if (!true)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x060015EB RID: 5611 RVA: 0x00040D54 File Offset: 0x0003EF54
		public IEnumerator GetEnumerator()
		{
			IEnumerator enumerator;
			return enumerator;
		}

		// Token: 0x060015EC RID: 5612 RVA: 0x00040D64 File Offset: 0x0003EF64
		public bool Matches(Attribute attribute)
		{
			/*
An exception occurred when decompiling this method (060015EC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.ComponentModel.AttributeCollection::Matches(System.Attribute)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:valuetype System.ComponentModel.AttributeCollection/AttributeEntry[](var_0_06, ldfld:valuetype System.ComponentModel.AttributeCollection/AttributeEntry[](AttributeCollection::_foundAttributeTypes, ldloc:AttributeCollection(this)))
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

		// Token: 0x060015ED RID: 5613 RVA: 0x00040D80 File Offset: 0x0003EF80
		public bool Matches(Attribute[] attributes)
		{
			/*
An exception occurred when decompiling this method (060015ED)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.ComponentModel.AttributeCollection::Matches(System.Attribute[])

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_1_09, call:bool(AttributeCollection::Matches, ldloc:AttributeCollection(this), ldloc:class [mscorlib]System.Attribute[][exp:Attribute](attributes)))
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

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x060015EE RID: 5614 RVA: 0x00040D9C File Offset: 0x0003EF9C
		bool ICollection.IsSynchronized
		{
			get
			{
			}
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x060015EF RID: 5615 RVA: 0x00040DAC File Offset: 0x0003EFAC
		object ICollection.SyncRoot
		{
			get
			{
			}
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x060015F0 RID: 5616 RVA: 0x00040DBC File Offset: 0x0003EFBC
		int ICollection.Count
		{
			get
			{
				/*
An exception occurred when decompiling this method (060015F0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.ComponentModel.AttributeCollection::System.Collections.ICollection.get_Count()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:valuetype System.ComponentModel.AttributeCollection/AttributeEntry[](var_0_06, ldfld:valuetype System.ComponentModel.AttributeCollection/AttributeEntry[](AttributeCollection::_foundAttributeTypes, ldloc:AttributeCollection(this)))
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

		// Token: 0x060015F1 RID: 5617 RVA: 0x00040DD0 File Offset: 0x0003EFD0
		IEnumerator IEnumerable.GetEnumerator()
		{
			IEnumerator enumerator;
			return enumerator;
		}

		// Token: 0x060015F2 RID: 5618 RVA: 0x00040DE0 File Offset: 0x0003EFE0
		public void CopyTo(Array array, int index)
		{
			AttributeCollection.AttributeEntry[] foundAttributeTypes = this._foundAttributeTypes;
		}

		// Token: 0x060015F3 RID: 5619 RVA: 0x00040DF4 File Offset: 0x0003EFF4
		// Note: this type is marked as 'beforefieldinit'.
		static AttributeCollection()
		{
		}

		// Token: 0x040011B3 RID: 4531
		public static readonly AttributeCollection Empty;

		// Token: 0x040011B4 RID: 4532
		private static Hashtable s_defaultAttributes;

		// Token: 0x040011B5 RID: 4533
		private readonly Attribute[] _attributes;

		// Token: 0x040011B6 RID: 4534
		private static readonly object s_internalSyncObject;

		// Token: 0x040011B7 RID: 4535
		private const int FOUND_TYPES_LIMIT = 5;

		// Token: 0x040011B8 RID: 4536
		private AttributeCollection.AttributeEntry[] _foundAttributeTypes;

		// Token: 0x040011B9 RID: 4537
		private int _index;

		// Token: 0x0200034B RID: 843
		private struct AttributeEntry
		{
			// Token: 0x040011BA RID: 4538
			public Type type;

			// Token: 0x040011BB RID: 4539
			public int index;
		}
	}
}
