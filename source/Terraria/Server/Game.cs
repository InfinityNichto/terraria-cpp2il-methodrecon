using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Server
{
	// Token: 0x0200053A RID: 1338
	public class Game : IDisposable
	{
		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x06003226 RID: 12838 RVA: 0x001F9518 File Offset: 0x001F7718
		public GameComponentCollection Components
		{
			get
			{
			}
		}

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x06003227 RID: 12839 RVA: 0x001F9528 File Offset: 0x001F7728
		// (set) Token: 0x06003228 RID: 12840 RVA: 0x001F9538 File Offset: 0x001F7738
		public ContentManager Content
		{
			get
			{
			}
			set
			{
			}
		}

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x06003229 RID: 12841 RVA: 0x001F9548 File Offset: 0x001F7748
		public GraphicsDevice GraphicsDevice
		{
			get
			{
			}
		}

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x0600322A RID: 12842 RVA: 0x001F9558 File Offset: 0x001F7758
		// (set) Token: 0x0600322B RID: 12843 RVA: 0x001F956C File Offset: 0x001F776C
		public TimeSpan InactiveSleepTime
		{
			get
			{
				if (!true)
				{
				}
				return 1;
			}
			set
			{
			}
		}

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x0600322C RID: 12844 RVA: 0x001F957C File Offset: 0x001F777C
		public bool IsActive
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x0600322D RID: 12845 RVA: 0x001F958C File Offset: 0x001F778C
		// (set) Token: 0x0600322E RID: 12846 RVA: 0x001F959C File Offset: 0x001F779C
		public bool IsFixedTimeStep
		{
			get
			{
				return true;
			}
			set
			{
			}
		}

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x0600322F RID: 12847 RVA: 0x001F95AC File Offset: 0x001F77AC
		// (set) Token: 0x06003230 RID: 12848 RVA: 0x001F95BC File Offset: 0x001F77BC
		public bool IsMouseVisible
		{
			get
			{
			}
			set
			{
			}
		}

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x06003231 RID: 12849 RVA: 0x001F95CC File Offset: 0x001F77CC
		public GameServiceContainer Services
		{
			get
			{
			}
		}

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x06003232 RID: 12850 RVA: 0x001F95DC File Offset: 0x001F77DC
		// (set) Token: 0x06003233 RID: 12851 RVA: 0x001F95F0 File Offset: 0x001F77F0
		public TimeSpan TargetElapsedTime
		{
			get
			{
				if (!true)
				{
				}
				return 1;
			}
			set
			{
			}
		}

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x06003234 RID: 12852 RVA: 0x001F9600 File Offset: 0x001F7800
		public GameWindow Window
		{
			get
			{
			}
		}

		// Token: 0x14000035 RID: 53
		// (add) Token: 0x06003235 RID: 12853 RVA: 0x001F9610 File Offset: 0x001F7810
		// (remove) Token: 0x06003236 RID: 12854 RVA: 0x001F9638 File Offset: 0x001F7838
		public event EventHandler<EventArgs> Activated
		{
			[CompilerGenerated]
			add
			{
				Delegate @delegate = Delegate.Combine(this.Activated, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = Delegate.Remove(this.Activated, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
		}

		// Token: 0x14000036 RID: 54
		// (add) Token: 0x06003237 RID: 12855 RVA: 0x001F9660 File Offset: 0x001F7860
		// (remove) Token: 0x06003238 RID: 12856 RVA: 0x001F9688 File Offset: 0x001F7888
		public event EventHandler<EventArgs> Deactivated
		{
			[CompilerGenerated]
			add
			{
				Delegate @delegate = Delegate.Combine(this.Deactivated, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = Delegate.Remove(this.Deactivated, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
		}

		// Token: 0x14000037 RID: 55
		// (add) Token: 0x06003239 RID: 12857 RVA: 0x001F96B0 File Offset: 0x001F78B0
		// (remove) Token: 0x0600323A RID: 12858 RVA: 0x001F96D8 File Offset: 0x001F78D8
		public event EventHandler<EventArgs> Disposed
		{
			[CompilerGenerated]
			add
			{
				Delegate @delegate = Delegate.Combine(this.Disposed, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = Delegate.Remove(this.Disposed, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
		}

		// Token: 0x14000038 RID: 56
		// (add) Token: 0x0600323B RID: 12859 RVA: 0x001F9700 File Offset: 0x001F7900
		// (remove) Token: 0x0600323C RID: 12860 RVA: 0x001F9728 File Offset: 0x001F7928
		public event EventHandler<EventArgs> Exiting
		{
			[CompilerGenerated]
			add
			{
				Delegate @delegate = Delegate.Combine(this.Exiting, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = Delegate.Remove(this.Exiting, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
		}

		// Token: 0x0600323D RID: 12861 RVA: 0x001F9750 File Offset: 0x001F7950
		protected virtual bool BeginDraw()
		{
			return true;
		}

		// Token: 0x0600323E RID: 12862 RVA: 0x001F9760 File Offset: 0x001F7960
		protected virtual void BeginRun()
		{
		}

		// Token: 0x0600323F RID: 12863 RVA: 0x001F9770 File Offset: 0x001F7970
		public void Dispose()
		{
		}

		// Token: 0x06003240 RID: 12864 RVA: 0x001F9780 File Offset: 0x001F7980
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x06003241 RID: 12865 RVA: 0x001F9790 File Offset: 0x001F7990
		protected virtual void Draw(GameTime gameTime)
		{
		}

		// Token: 0x06003242 RID: 12866 RVA: 0x001F97A0 File Offset: 0x001F79A0
		protected virtual void EndDraw()
		{
		}

		// Token: 0x06003243 RID: 12867 RVA: 0x001F97B0 File Offset: 0x001F79B0
		protected virtual void EndRun()
		{
		}

		// Token: 0x06003244 RID: 12868 RVA: 0x001F97C0 File Offset: 0x001F79C0
		public void Exit()
		{
		}

		// Token: 0x06003245 RID: 12869 RVA: 0x001F97D0 File Offset: 0x001F79D0
		protected virtual void Initialize()
		{
		}

		// Token: 0x06003246 RID: 12870 RVA: 0x001F97E0 File Offset: 0x001F79E0
		protected virtual void LoadContent()
		{
		}

		// Token: 0x06003247 RID: 12871 RVA: 0x001F97F0 File Offset: 0x001F79F0
		protected virtual void OnActivated(object sender, EventArgs args)
		{
		}

		// Token: 0x06003248 RID: 12872 RVA: 0x001F9800 File Offset: 0x001F7A00
		protected virtual void OnDeactivated(object sender, EventArgs args)
		{
		}

		// Token: 0x06003249 RID: 12873 RVA: 0x001F9810 File Offset: 0x001F7A10
		protected virtual void OnExiting(object sender, EventArgs args)
		{
		}

		// Token: 0x0600324A RID: 12874 RVA: 0x001F9820 File Offset: 0x001F7A20
		public void ResetElapsedTime()
		{
		}

		// Token: 0x0600324B RID: 12875 RVA: 0x001F9830 File Offset: 0x001F7A30
		public void Run()
		{
		}

		// Token: 0x0600324C RID: 12876 RVA: 0x001F9840 File Offset: 0x001F7A40
		public void RunOneFrame()
		{
		}

		// Token: 0x0600324D RID: 12877 RVA: 0x001F9850 File Offset: 0x001F7A50
		protected virtual bool ShowMissingRequirementMessage(Exception exception)
		{
			return true;
		}

		// Token: 0x0600324E RID: 12878 RVA: 0x001F9860 File Offset: 0x001F7A60
		public void SuppressDraw()
		{
		}

		// Token: 0x0600324F RID: 12879 RVA: 0x001F9870 File Offset: 0x001F7A70
		public void Tick()
		{
		}

		// Token: 0x06003250 RID: 12880 RVA: 0x001F9880 File Offset: 0x001F7A80
		protected virtual void UnloadContent()
		{
		}

		// Token: 0x06003251 RID: 12881 RVA: 0x001F9890 File Offset: 0x001F7A90
		protected virtual void Update(GameTime gameTime)
		{
		}

		// Token: 0x06003252 RID: 12882 RVA: 0x001F98A0 File Offset: 0x001F7AA0
		public Game()
		{
		}

		// Token: 0x04003B7F RID: 15231
		[CompilerGenerated]
		private EventHandler<EventArgs> Activated;

		// Token: 0x04003B80 RID: 15232
		[CompilerGenerated]
		private EventHandler<EventArgs> Deactivated;

		// Token: 0x04003B81 RID: 15233
		[CompilerGenerated]
		private EventHandler<EventArgs> Disposed;

		// Token: 0x04003B82 RID: 15234
		[CompilerGenerated]
		private EventHandler<EventArgs> Exiting;
	}
}
