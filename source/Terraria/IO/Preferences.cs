using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using Newtonsoft.Json;
using Terraria.Utilities;

namespace Terraria.IO
{
	// Token: 0x02000564 RID: 1380
	public class Preferences
	{
		// Token: 0x1400003B RID: 59
		// (add) Token: 0x0600338F RID: 13199 RVA: 0x001FFCC4 File Offset: 0x001FDEC4
		// (remove) Token: 0x06003390 RID: 13200 RVA: 0x001FFCEC File Offset: 0x001FDEEC
		public event Action<Preferences> OnSave
		{
			[CompilerGenerated]
			add
			{
				Delegate @delegate = Delegate.Combine(this.OnSave, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = Delegate.Remove(this.OnSave, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
		}

		// Token: 0x1400003C RID: 60
		// (add) Token: 0x06003391 RID: 13201 RVA: 0x001FFD14 File Offset: 0x001FDF14
		// (remove) Token: 0x06003392 RID: 13202 RVA: 0x001FFD3C File Offset: 0x001FDF3C
		public event Action<Preferences> OnLoad
		{
			[CompilerGenerated]
			add
			{
				Delegate @delegate = Delegate.Combine(this.OnLoad, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = Delegate.Remove(this.OnLoad, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
		}

		// Token: 0x1400003D RID: 61
		// (add) Token: 0x06003393 RID: 13203 RVA: 0x001FFD64 File Offset: 0x001FDF64
		// (remove) Token: 0x06003394 RID: 13204 RVA: 0x001FFD88 File Offset: 0x001FDF88
		public event Preferences.TextProcessAction OnProcessText
		{
			[CompilerGenerated]
			add
			{
				if (Delegate.Combine(this.OnProcessText, value) != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (Delegate.Remove(this.OnProcessText, value) != null)
				{
				}
			}
		}

		// Token: 0x06003395 RID: 13205 RVA: 0x001FFDAC File Offset: 0x001FDFAC
		public Preferences(string path, bool parseAllTypes = false, bool useBson = false)
		{
			this._path = path;
		}

		// Token: 0x06003396 RID: 13206 RVA: 0x001FFDC8 File Offset: 0x001FDFC8
		public bool Load()
		{
			int num = 1;
			object @lock = this._lock;
			string path = this._path;
			if (num == 0)
			{
			}
			long num2 = 0L;
			bool flag = FileUtilities.Exists(path, num2 != 0L);
			bool useBson = this.UseBson;
			string path2 = this._path;
			int num4;
			if (useBson)
			{
				if (num == 0)
				{
				}
				long num3 = 0L;
				byte[] array = FileUtilities.ReadAllBytes(path2, num3 != 0L);
				JsonSerializer jsonSerializer = JsonSerializer.Create(this._serializerSettings);
				this._data = jsonSerializer;
				num4 = 6;
				if (useBson)
				{
				}
			}
			JsonSerializerSettings serializerSettings = this._serializerSettings;
			string text;
			this._data = text;
			if (text == null)
			{
				if (serializerSettings != null)
				{
					throw new OutOfMemoryException();
				}
				int num5;
				if (num4 == 0)
				{
					num5 = 5;
					if (text != null)
					{
						goto IL_0089;
					}
				}
				long num6 = 0L;
				if (text == null)
				{
					goto IL_008D;
				}
				IL_0089:
				if (useBson)
				{
				}
				IL_008D:
				if (num6 != 0L)
				{
					goto IL_00AB;
				}
				if (num5 != 0)
				{
					long num7 = 0L;
					Monitor.Exit(@lock);
					if (num7 == 0L)
					{
					}
					throw new OutOfMemoryException();
				}
				if (this._data == null)
				{
				}
			}
			if (this.OnLoad != null)
			{
			}
			IL_00AB:
			throw new OutOfMemoryException();
		}

		// Token: 0x06003397 RID: 13207 RVA: 0x001FFF0C File Offset: 0x001FE10C
		public bool Save(bool canCreateFile = true)
		{
			object @lock = this._lock;
			Monitor.Enter(@lock, canCreateFile);
			Action<Preferences> onSave = this.OnSave;
			if (onSave != null)
			{
			}
			string path = this._path;
			if (onSave == null)
			{
			}
			long num = 0L;
			bool flag = FileUtilities.Exists(path, num != 0L);
			Directory.GetParent(this._path).Create();
			string path2 = this._path;
			if (onSave == null)
			{
			}
			string path3 = this._path;
			if (onSave == null)
			{
			}
			if (this.UseBson)
			{
				JsonSerializer jsonSerializer = JsonSerializer.Create(this._serializerSettings);
				Dictionary<string, object> data = this._data;
			}
			Dictionary<string, object> data2 = this._data;
			string path4 = this._path;
			JsonSerializerSettings serializerSettings = this._serializerSettings;
			string path5 = this._path;
			string text;
			if (text == null)
			{
				string path6 = this._path;
				long num2 = 0L;
				int num3 = 7;
				if (num2 != 0L)
				{
					throw new OutOfMemoryException();
				}
				if (num3 != 0)
				{
				}
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06003398 RID: 13208 RVA: 0x0020005C File Offset: 0x001FE25C
		public void Clear()
		{
			Dictionary<string, object> data = this._data;
		}

		// Token: 0x06003399 RID: 13209 RVA: 0x00200070 File Offset: 0x001FE270
		public void Put(string name, object value)
		{
			object @lock = this._lock;
			Dictionary<string, object> data = this._data;
			bool autoSave = this.AutoSave;
			if (autoSave)
			{
				bool flag = this.Save(true);
			}
			long num = 0L;
			if (autoSave)
			{
				Monitor.Exit(@lock);
			}
			if (num == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x0600339A RID: 13210 RVA: 0x002000D8 File Offset: 0x001FE2D8
		public bool Contains(string name)
		{
			object @lock = this._lock;
			Dictionary<string, object> data = this._data;
			long num = 0L;
			Monitor.Exit(@lock);
			if (num == 0L)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x0600339B RID: 13211 RVA: 0x00200120 File Offset: 0x001FE320
		public T Get<T>(string name, T defaultValue)
		{
			object @lock = this._lock;
			Dictionary<string, object> data = this._data;
			if (name != null)
			{
			}
			if (name != null)
			{
			}
			Type type;
			object obj = Convert.ChangeType(name, type);
			throw new InvalidCastException();
		}

		// Token: 0x0600339C RID: 13212 RVA: 0x0020018C File Offset: 0x001FE38C
		public void Get<T>(string name, T currentValue)
		{
		}

		// Token: 0x0600339D RID: 13213 RVA: 0x0020019C File Offset: 0x001FE39C
		public List<string> GetAllKeys()
		{
			/*
An exception occurred when decompiling this method (0600339D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.List`1<System.String> Terraria.IO.Preferences::GetAllKeys()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.Dictionary`2<string, object>(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<string, object>(Preferences::_data, ldloc:Preferences(this)))
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

		// Token: 0x0600339E RID: 13214 RVA: 0x002001B0 File Offset: 0x001FE3B0
		public void Clear(string name)
		{
			if (this._data != null)
			{
				return;
			}
		}

		// Token: 0x04003C4C RID: 15436
		private Dictionary<string, object> _data;

		// Token: 0x04003C4D RID: 15437
		private readonly string _path;

		// Token: 0x04003C4E RID: 15438
		private readonly JsonSerializerSettings _serializerSettings;

		// Token: 0x04003C4F RID: 15439
		public readonly bool UseBson;

		// Token: 0x04003C50 RID: 15440
		private readonly object _lock;

		// Token: 0x04003C51 RID: 15441
		public bool AutoSave;

		// Token: 0x04003C52 RID: 15442
		[CompilerGenerated]
		private Action<Preferences> OnSave;

		// Token: 0x04003C53 RID: 15443
		[CompilerGenerated]
		private Action<Preferences> OnLoad;

		// Token: 0x04003C54 RID: 15444
		[CompilerGenerated]
		private Preferences.TextProcessAction OnProcessText;

		// Token: 0x02000565 RID: 1381
		public sealed class TextProcessAction : MulticastDelegate
		{
			// Token: 0x0600339F RID: 13215 RVA: 0x002001C8 File Offset: 0x001FE3C8
			public TextProcessAction(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x060033A0 RID: 13216 RVA: 0x00200214 File Offset: 0x001FE414
			public void Invoke(string text)
			{
				IntPtr method_code = this.method_code;
				IntPtr invoke_impl = this.invoke_impl;
				IntPtr method = this.method;
			}

			// Token: 0x060033A1 RID: 13217 RVA: 0x000021DB File Offset: 0x000003DB
			public IAsyncResult BeginInvoke(string text, AsyncCallback callback, object @object)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x060033A2 RID: 13218 RVA: 0x00200238 File Offset: 0x001FE438
			public void EndInvoke(string text, IAsyncResult result)
			{
			}
		}
	}
}
