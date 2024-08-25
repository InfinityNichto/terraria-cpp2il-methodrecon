using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.Graphics.Effects
{
	// Token: 0x02000781 RID: 1921
	public abstract class EffectManager<T> where T : GameEffect
	{
		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x06003EE7 RID: 16103 RVA: 0x0023F628 File Offset: 0x0023D828
		public bool IsLoaded
		{
			get
			{
				return this._isLoaded;
			}
		}

		// Token: 0x170007A4 RID: 1956
		public T this[string key]
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x06003EEA RID: 16106 RVA: 0x0023F64C File Offset: 0x0023D84C
		public void Bind(string name, T effect)
		{
			if (this._isLoaded)
			{
				return;
			}
		}

		// Token: 0x06003EEB RID: 16107 RVA: 0x0023F664 File Offset: 0x0023D864
		public void Load()
		{
			if (!this._isLoaded)
			{
				this._isLoaded = true;
				return;
			}
		}

		// Token: 0x06003EEC RID: 16108 RVA: 0x0023F6A0 File Offset: 0x0023D8A0
		public T Activate(string name, [Optional] Vector2 position, params object[] args)
		{
			if (("Unable to find effect named: " != null && "Unable to find effect named: " == null) || "Unable to find effect named: " == null || (". Type: " != null && ". Type: " == null))
			{
				throw new ArrayTypeMismatchException();
			}
			Type type;
			if (type != null)
			{
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06003EED RID: 16109 RVA: 0x0023F6E4 File Offset: 0x0023D8E4
		public void Deactivate(string name, params object[] args)
		{
		}

		// Token: 0x06003EEE RID: 16110 RVA: 0x0023F72C File Offset: 0x0023D92C
		public virtual void OnActivate(T effect, Vector2 position)
		{
		}

		// Token: 0x06003EEF RID: 16111 RVA: 0x0023F73C File Offset: 0x0023D93C
		public virtual void OnDeactivate(T effect)
		{
		}

		// Token: 0x06003EF0 RID: 16112 RVA: 0x0023F74C File Offset: 0x0023D94C
		protected EffectManager()
		{
		}

		// Token: 0x04007D72 RID: 32114
		protected bool _isLoaded;

		// Token: 0x04007D73 RID: 32115
		protected Dictionary<string, T> _effects;
	}
}
