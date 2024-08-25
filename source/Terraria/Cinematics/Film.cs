using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.Cinematics
{
	// Token: 0x02000792 RID: 1938
	public class Film
	{
		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x06003F67 RID: 16231 RVA: 0x00240950 File Offset: 0x0023EB50
		public int Frame
		{
			get
			{
				return this._frame;
			}
		}

		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x06003F68 RID: 16232 RVA: 0x00240964 File Offset: 0x0023EB64
		public int FrameCount
		{
			get
			{
				return this._frameCount;
			}
		}

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x06003F69 RID: 16233 RVA: 0x00240978 File Offset: 0x0023EB78
		public int AppendPoint
		{
			get
			{
				return this._nextSequenceAppendTime;
			}
		}

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x06003F6A RID: 16234 RVA: 0x0024098C File Offset: 0x0023EB8C
		public bool IsActive
		{
			get
			{
				return this._isActive;
			}
		}

		// Token: 0x06003F6B RID: 16235 RVA: 0x000021DB File Offset: 0x000003DB
		public void AddSequence(int start, int duration, FrameEvent frameEvent)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003F6C RID: 16236 RVA: 0x002409A0 File Offset: 0x0023EBA0
		public void AppendSequence(int duration, FrameEvent frameEvent)
		{
			int nextSequenceAppendTime = this._nextSequenceAppendTime;
			this.AddSequence(nextSequenceAppendTime, duration, frameEvent);
		}

		// Token: 0x06003F6D RID: 16237 RVA: 0x002409C0 File Offset: 0x0023EBC0
		public void AddSequences(int start, int duration, params FrameEvent[] frameEvents)
		{
			IntPtr invoke_impl = frameEvents.invoke_impl;
			this.AddSequence(start, duration, frameEvents);
		}

		// Token: 0x06003F6E RID: 16238 RVA: 0x000021DB File Offset: 0x000003DB
		public void AppendSequences(int duration, params FrameEvent[] frameEvents)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003F6F RID: 16239 RVA: 0x002409E0 File Offset: 0x0023EBE0
		public void AppendEmptySequence(int duration)
		{
			int nextSequenceAppendTime = this._nextSequenceAppendTime;
		}

		// Token: 0x06003F70 RID: 16240 RVA: 0x002409F8 File Offset: 0x0023EBF8
		public void AppendKeyFrame(FrameEvent frameEvent)
		{
			int nextSequenceAppendTime = this._nextSequenceAppendTime;
			this.AddKeyFrame(nextSequenceAppendTime, frameEvent);
		}

		// Token: 0x06003F71 RID: 16241 RVA: 0x000021DB File Offset: 0x000003DB
		public void AppendKeyFrames(params FrameEvent[] frameEvents)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003F72 RID: 16242 RVA: 0x000021DB File Offset: 0x000003DB
		public void AddKeyFrame(int frame, FrameEvent frameEvent)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003F73 RID: 16243 RVA: 0x00240A14 File Offset: 0x0023EC14
		public void AddKeyFrames(int frame, params FrameEvent[] frameEvents)
		{
			IntPtr invoke_impl = frameEvents.invoke_impl;
			this.AddKeyFrame(frame, frameEvents);
		}

		// Token: 0x06003F74 RID: 16244 RVA: 0x00240A34 File Offset: 0x0023EC34
		public bool OnUpdate(GameTime gameTime)
		{
			if (this._sequences._size != 0)
			{
				int frame = this._frame;
				int frame2 = this._frame;
				int nextSequenceAppendTime = this._nextSequenceAppendTime;
				this._frame = frame2;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06003F75 RID: 16245 RVA: 0x00240A7C File Offset: 0x0023EC7C
		public virtual void OnBegin()
		{
			this._isActive = true;
		}

		// Token: 0x06003F76 RID: 16246 RVA: 0x00240A90 File Offset: 0x0023EC90
		public virtual void OnEnd()
		{
		}

		// Token: 0x06003F77 RID: 16247 RVA: 0x00240AA0 File Offset: 0x0023ECA0
		private static void EmptyFrameEvent(FrameEventData evt)
		{
		}

		// Token: 0x06003F78 RID: 16248 RVA: 0x00240AB0 File Offset: 0x0023ECB0
		public Film()
		{
		}

		// Token: 0x04007DB1 RID: 32177
		private int _frame;

		// Token: 0x04007DB2 RID: 32178
		private int _frameCount;

		// Token: 0x04007DB3 RID: 32179
		private int _nextSequenceAppendTime;

		// Token: 0x04007DB4 RID: 32180
		private bool _isActive;

		// Token: 0x04007DB5 RID: 32181
		private List<Film.Sequence> _sequences;

		// Token: 0x02000793 RID: 1939
		private class Sequence
		{
			// Token: 0x170007B3 RID: 1971
			// (get) Token: 0x06003F79 RID: 16249 RVA: 0x00240AC4 File Offset: 0x0023ECC4
			public FrameEvent Event
			{
				get
				{
					return this._frameEvent;
				}
			}

			// Token: 0x170007B4 RID: 1972
			// (get) Token: 0x06003F7A RID: 16250 RVA: 0x00240AD8 File Offset: 0x0023ECD8
			public int Duration
			{
				get
				{
					return this._duration;
				}
			}

			// Token: 0x170007B5 RID: 1973
			// (get) Token: 0x06003F7B RID: 16251 RVA: 0x00240AEC File Offset: 0x0023ECEC
			public int Start
			{
				get
				{
					return this._start;
				}
			}

			// Token: 0x06003F7C RID: 16252 RVA: 0x00240B00 File Offset: 0x0023ED00
			public Sequence(FrameEvent frameEvent, int start, int duration)
			{
				this._frameEvent = frameEvent;
				this._duration = duration;
			}

			// Token: 0x04007DB6 RID: 32182
			private FrameEvent _frameEvent;

			// Token: 0x04007DB7 RID: 32183
			private int _duration;

			// Token: 0x04007DB8 RID: 32184
			private int _start;
		}
	}
}
