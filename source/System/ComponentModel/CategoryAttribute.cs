using System;
using Cpp2IlInjected;

namespace System.ComponentModel
{
	// Token: 0x020003D7 RID: 983
	[AttributeUsage(AttributeTargets.All)]
	public class CategoryAttribute : Attribute
	{
		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x060019E8 RID: 6632 RVA: 0x00002050 File Offset: 0x00000250
		public static CategoryAttribute Action
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x060019E9 RID: 6633 RVA: 0x00002050 File Offset: 0x00000250
		public static CategoryAttribute Appearance
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x060019EA RID: 6634 RVA: 0x00002050 File Offset: 0x00000250
		public static CategoryAttribute Asynchronous
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x060019EB RID: 6635 RVA: 0x00002050 File Offset: 0x00000250
		public static CategoryAttribute Behavior
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x060019EC RID: 6636 RVA: 0x00002050 File Offset: 0x00000250
		public static CategoryAttribute Data
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x060019ED RID: 6637 RVA: 0x00002050 File Offset: 0x00000250
		public static CategoryAttribute Default
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x060019EE RID: 6638 RVA: 0x00002050 File Offset: 0x00000250
		public static CategoryAttribute Design
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x060019EF RID: 6639 RVA: 0x00002050 File Offset: 0x00000250
		public static CategoryAttribute DragDrop
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x060019F0 RID: 6640 RVA: 0x00002050 File Offset: 0x00000250
		public static CategoryAttribute Focus
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x060019F1 RID: 6641 RVA: 0x00002050 File Offset: 0x00000250
		public static CategoryAttribute Format
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x060019F2 RID: 6642 RVA: 0x00002050 File Offset: 0x00000250
		public static CategoryAttribute Key
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x060019F3 RID: 6643 RVA: 0x00002050 File Offset: 0x00000250
		public static CategoryAttribute Layout
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x060019F4 RID: 6644 RVA: 0x00002050 File Offset: 0x00000250
		public static CategoryAttribute Mouse
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x060019F5 RID: 6645 RVA: 0x00002050 File Offset: 0x00000250
		public static CategoryAttribute WindowStyle
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x060019F6 RID: 6646 RVA: 0x00047D4C File Offset: 0x00045F4C
		public CategoryAttribute()
		{
			this.categoryValue = "Default";
		}

		// Token: 0x060019F7 RID: 6647 RVA: 0x00047D6C File Offset: 0x00045F6C
		public CategoryAttribute(string category)
		{
			this.categoryValue = category;
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x060019F8 RID: 6648 RVA: 0x00047D88 File Offset: 0x00045F88
		public string Category
		{
			get
			{
				if (!this.localized)
				{
					this.localized = true;
					string text = this.categoryValue;
					if (this != null)
					{
						this.categoryValue = this;
					}
				}
				return this.categoryValue;
			}
		}

		// Token: 0x060019F9 RID: 6649 RVA: 0x00047DBC File Offset: 0x00045FBC
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
			}
			int num;
			if (!this.localized)
			{
				num = 1;
				this.localized = num != 0;
				string text = this.categoryValue;
				if (this != null)
				{
					this.categoryValue = this;
				}
			}
			string text2 = this.categoryValue;
			if (num != 0 || obj != null)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x060019FA RID: 6650 RVA: 0x00047E0C File Offset: 0x0004600C
		public override int GetHashCode()
		{
			/*
An exception occurred when decompiling this method (060019FA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.ComponentModel.CategoryAttribute::GetHashCode()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0020:
	stloc:string(var_1_26, ldfld:string(CategoryAttribute::categoryValue, ldloc:CategoryAttribute(this)))
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

		// Token: 0x060019FB RID: 6651 RVA: 0x00047E40 File Offset: 0x00046040
		protected virtual string GetLocalizedString(string value)
		{
			uint num = global::<PrivateImplementationDetails>.ComputeStringHash(value);
			bool flag = value == "Action";
			bool flag2 = value == "Design";
			return value;
		}

		// Token: 0x060019FC RID: 6652 RVA: 0x00047E70 File Offset: 0x00046070
		public override bool IsDefaultAttribute()
		{
			if (!this.localized)
			{
				this.localized = true;
				string text = this.categoryValue;
				if (this != null)
				{
					this.categoryValue = this;
				}
			}
			string text2 = this.categoryValue;
			CategoryAttribute @default = CategoryAttribute.Default;
			if (!@default.localized)
			{
				string text3 = @default.categoryValue;
				if (@default != null)
				{
					@default.categoryValue = @default;
				}
			}
			string text4 = @default.categoryValue;
			return text2.Equals(text4);
		}

		// Token: 0x040012E6 RID: 4838
		private static CategoryAttribute appearance;

		// Token: 0x040012E7 RID: 4839
		private static CategoryAttribute asynchronous;

		// Token: 0x040012E8 RID: 4840
		private static CategoryAttribute behavior;

		// Token: 0x040012E9 RID: 4841
		private static CategoryAttribute data;

		// Token: 0x040012EA RID: 4842
		private static CategoryAttribute design;

		// Token: 0x040012EB RID: 4843
		private static CategoryAttribute action;

		// Token: 0x040012EC RID: 4844
		private static CategoryAttribute format;

		// Token: 0x040012ED RID: 4845
		private static CategoryAttribute layout;

		// Token: 0x040012EE RID: 4846
		private static CategoryAttribute mouse;

		// Token: 0x040012EF RID: 4847
		private static CategoryAttribute key;

		// Token: 0x040012F0 RID: 4848
		private static CategoryAttribute focus;

		// Token: 0x040012F1 RID: 4849
		private static CategoryAttribute windowStyle;

		// Token: 0x040012F2 RID: 4850
		private static CategoryAttribute dragDrop;

		// Token: 0x040012F3 RID: 4851
		private static CategoryAttribute defAttr;

		// Token: 0x040012F4 RID: 4852
		private bool localized;

		// Token: 0x040012F5 RID: 4853
		private string categoryValue;
	}
}
