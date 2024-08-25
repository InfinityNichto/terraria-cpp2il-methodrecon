using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework.Graphics;

namespace Microsoft.Xna.Framework
{
	// Token: 0x02000339 RID: 825
	public class GameComponent : IGameComponent, IUpdateable, IComparable<GameComponent>
	{
		// Token: 0x1400000A RID: 10
		// (add) Token: 0x060014C8 RID: 5320 RVA: 0x0005F4AC File Offset: 0x0005D6AC
		// (remove) Token: 0x060014C9 RID: 5321 RVA: 0x0005F4D4 File Offset: 0x0005D6D4
		public event EventHandler<EventArgs> UpdateOrderChanged
		{
			[CompilerGenerated]
			add
			{
				Delegate @delegate = Delegate.Combine(this.UpdateOrderChanged, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = Delegate.Remove(this.UpdateOrderChanged, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
		}

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x060014CA RID: 5322 RVA: 0x0005F4FC File Offset: 0x0005D6FC
		// (remove) Token: 0x060014CB RID: 5323 RVA: 0x0005F524 File Offset: 0x0005D724
		public event EventHandler<EventArgs> EnabledChanged
		{
			[CompilerGenerated]
			add
			{
				Delegate @delegate = Delegate.Combine(this.EnabledChanged, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = Delegate.Remove(this.EnabledChanged, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
		}

		// Token: 0x060014CC RID: 5324 RVA: 0x0005F54C File Offset: 0x0005D74C
		public GameComponent(Game game)
		{
			this._game = game;
			this.Enabled = true;
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x060014CD RID: 5325 RVA: 0x0005F570 File Offset: 0x0005D770
		public Game Game
		{
			get
			{
				return this._game;
			}
		}

		// Token: 0x060014CE RID: 5326 RVA: 0x0005F584 File Offset: 0x0005D784
		public virtual void Initialize()
		{
		}

		// Token: 0x060014CF RID: 5327 RVA: 0x0005F594 File Offset: 0x0005D794
		public virtual void Update(GameTime gameTime)
		{
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x060014D0 RID: 5328 RVA: 0x0005F5A4 File Offset: 0x0005D7A4
		public GraphicsDevice GraphicsDevice
		{
			get
			{
				return this._game.GraphicsDevice;
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x060014D1 RID: 5329 RVA: 0x0005F5BC File Offset: 0x0005D7BC
		// (set) Token: 0x060014D2 RID: 5330 RVA: 0x0005F5D0 File Offset: 0x0005D7D0
		public bool Enabled
		{
			get
			{
				return this._enabled;
			}
			set
			{
				EventHandler<EventArgs> enabledChanged = this.EnabledChanged;
				if (true)
				{
					if (enabledChanged != null)
					{
					}
					return;
				}
				while (enabledChanged != null)
				{
				}
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x060014D3 RID: 5331 RVA: 0x0005F5F0 File Offset: 0x0005D7F0
		// (set) Token: 0x060014D4 RID: 5332 RVA: 0x0005F604 File Offset: 0x0005D804
		public int UpdateOrder
		{
			get
			{
				return this._updateOrder;
			}
			set
			{
				this._updateOrder = value;
				EventHandler<EventArgs> updateOrderChanged = this.UpdateOrderChanged;
				if (true)
				{
					if (updateOrderChanged != null)
					{
					}
					return;
				}
				while (updateOrderChanged != null)
				{
				}
			}
		}

		// Token: 0x060014D5 RID: 5333 RVA: 0x0005F62C File Offset: 0x0005D82C
		private void Raise(EventHandler<EventArgs> handler, EventArgs e)
		{
			if (handler != null)
			{
				return;
			}
		}

		// Token: 0x060014D6 RID: 5334 RVA: 0x0005F640 File Offset: 0x0005D840
		protected virtual void OnUpdateOrderChanged(object sender, EventArgs args)
		{
		}

		// Token: 0x060014D7 RID: 5335 RVA: 0x0005F650 File Offset: 0x0005D850
		protected virtual void OnEnabledChanged(object sender, EventArgs args)
		{
		}

		// Token: 0x060014D8 RID: 5336 RVA: 0x0005F660 File Offset: 0x0005D860
		public void Dispose()
		{
		}

		// Token: 0x060014D9 RID: 5337 RVA: 0x0005F670 File Offset: 0x0005D870
		public int CompareTo(GameComponent other)
		{
			/*
An exception occurred when decompiling this method (060014D9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Microsoft.Xna.Framework.GameComponent::CompareTo(Microsoft.Xna.Framework.GameComponent)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(GameComponent::_updateOrder, ldloc:GameComponent(other)))
	stloc:int32(var_1_0D, ldfld:int32(GameComponent::_updateOrder, ldloc:GameComponent(this)))
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

		// Token: 0x040022BD RID: 8893
		private Game _game;

		// Token: 0x040022BE RID: 8894
		private int _updateOrder;

		// Token: 0x040022BF RID: 8895
		private bool _enabled;

		// Token: 0x040022C0 RID: 8896
		[CompilerGenerated]
		private EventHandler<EventArgs> UpdateOrderChanged;

		// Token: 0x040022C1 RID: 8897
		[CompilerGenerated]
		private EventHandler<EventArgs> EnabledChanged;
	}
}
