using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x02000076 RID: 118
	[DisallowMultipleComponent]
	[AddComponentMenu("UI/Toggle Group", 31)]
	public class ToggleGroup : UIBehaviour
	{
		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060004E2 RID: 1250 RVA: 0x0000F5E0 File Offset: 0x0000D7E0
		// (set) Token: 0x060004E3 RID: 1251 RVA: 0x0000F5F4 File Offset: 0x0000D7F4
		public bool allowSwitchOff
		{
			get
			{
				return this.m_AllowSwitchOff;
			}
			set
			{
			}
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x0000F604 File Offset: 0x0000D804
		protected ToggleGroup()
		{
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x0000F618 File Offset: 0x0000D818
		protected override void Start()
		{
			this.EnsureValidState();
			base.Start();
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x0000F634 File Offset: 0x0000D834
		protected override void OnEnable()
		{
			this.EnsureValidState();
			base.OnEnable();
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x0000F650 File Offset: 0x0000D850
		private void ValidateToggleIsInGroup(Toggle toggle)
		{
			if (!true)
			{
			}
			List<Toggle> toggles = this.m_Toggles;
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x0000F674 File Offset: 0x0000D874
		public void NotifyToggleOn(Toggle toggle, bool sendCallback = true)
		{
			this.ValidateToggleIsInGroup(toggle);
			int size = this.m_Toggles._size;
			List<Toggle> toggles = this.m_Toggles;
			int size2 = this.m_Toggles._size;
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x0000F6B0 File Offset: 0x0000D8B0
		public void UnregisterToggle(Toggle toggle)
		{
			List<Toggle> toggles = this.m_Toggles;
			List<Toggle> toggles2 = this.m_Toggles;
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x00002207 File Offset: 0x00000407
		public void RegisterToggle(Toggle toggle)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x0000F6CC File Offset: 0x0000D8CC
		public void EnsureValidState()
		{
			if (!this.m_AllowSwitchOff)
			{
				bool flag = this.AnyTogglesOn();
				if (this.m_Toggles._size != 0)
				{
					List<Toggle> toggles = this.m_Toggles;
				}
			}
			IEnumerable<Toggle> enumerable = this.ActiveToggles();
			int num = Enumerable.Count(enumerable);
			Toggle firstActiveToggle = this.GetFirstActiveToggle();
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x0000F758 File Offset: 0x0000D958
		public bool AnyTogglesOn()
		{
			List<Toggle> toggles = this.m_Toggles;
			if (!true)
			{
			}
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x0000F774 File Offset: 0x0000D974
		public IEnumerable<Toggle> ActiveToggles()
		{
			/*
An exception occurred when decompiling this method (060004ED)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IEnumerable`1<UnityEngine.UI.Toggle> UnityEngine.UI.ToggleGroup::ActiveToggles()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000A:
	brtrue(IL_0000, ldc.i4:bool(1))
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

		// Token: 0x060004EE RID: 1262 RVA: 0x0000F790 File Offset: 0x0000D990
		public Toggle GetFirstActiveToggle()
		{
			IEnumerable<Toggle> enumerable = this.ActiveToggles();
			int num = Enumerable.Count(enumerable);
			return Enumerable.First<Toggle>(enumerable);
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x0000F7B4 File Offset: 0x0000D9B4
		public void SetAllTogglesOff(bool sendCallback = true)
		{
			List<Toggle> toggles = this.m_Toggles;
			int num = 1;
			bool allowSwitchOff = this.m_AllowSwitchOff;
			this.m_AllowSwitchOff = num != 0;
			int size = toggles._size;
			int size2 = this.m_Toggles._size;
		}

		// Token: 0x04000252 RID: 594
		[SerializeField]
		private bool m_AllowSwitchOff;

		// Token: 0x04000253 RID: 595
		protected List<Toggle> m_Toggles;

		// Token: 0x02000077 RID: 119
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060004F0 RID: 1264 RVA: 0x0000F814 File Offset: 0x0000DA14
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060004F1 RID: 1265 RVA: 0x0000F824 File Offset: 0x0000DA24
			public <>c()
			{
			}

			// Token: 0x060004F2 RID: 1266 RVA: 0x0000F838 File Offset: 0x0000DA38
			internal bool <AnyTogglesOn>b__13_0(Toggle x)
			{
				return x.m_IsOn;
			}

			// Token: 0x060004F3 RID: 1267 RVA: 0x0000F84C File Offset: 0x0000DA4C
			internal bool <ActiveToggles>b__14_0(Toggle x)
			{
				return x.m_IsOn;
			}

			// Token: 0x04000254 RID: 596
			public static readonly ToggleGroup.<>c <>9;

			// Token: 0x04000255 RID: 597
			public static Predicate<Toggle> <>9__13_0;

			// Token: 0x04000256 RID: 598
			public static Func<Toggle, bool> <>9__14_0;
		}
	}
}
