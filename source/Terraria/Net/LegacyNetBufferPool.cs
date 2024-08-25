using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace Terraria.Net
{
	// Token: 0x020006A0 RID: 1696
	public class LegacyNetBufferPool
	{
		// Token: 0x06003889 RID: 14473 RVA: 0x000021DB File Offset: 0x000003DB
		public static byte[] RequestBuffer(int size)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600388A RID: 14474 RVA: 0x00225EB8 File Offset: 0x002240B8
		public static byte[] RequestBuffer(byte[] data, int offset, int size)
		{
			if (!true)
			{
			}
			return LegacyNetBufferPool.RequestBuffer(offset);
		}

		// Token: 0x0600388B RID: 14475 RVA: 0x00225ED0 File Offset: 0x002240D0
		public static void ReturnBuffer(byte[] buffer)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x0600388C RID: 14476 RVA: 0x00225F14 File Offset: 0x00224114
		public static void DisplayBufferSizes()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			string text2;
			string text3;
			string text = "Small Buffers:  " + text2 + " queued of " + text3;
			int num2 = 255;
			int num3 = 255;
			int num4 = 255;
			Main.NewText(text, (byte)num2, (byte)num3, (byte)num4);
			string text5;
			string text6;
			string text4 = "Medium Buffers: " + text5 + " queued of " + text6;
			int num5 = 255;
			int num6 = 255;
			int num7 = 255;
			Main.NewText(text4, (byte)num5, (byte)num6, (byte)num7);
			string text8;
			string text9;
			string text7 = "Large Buffers:  " + text8 + " queued of " + text9;
			int num8 = 255;
			int num9 = 255;
			int num10 = 255;
			Main.NewText(text7, (byte)num8, (byte)num9, (byte)num10);
			string text11;
			string text10 = "Custom Buffers: 0 queued of " + text11;
			int num11 = 255;
			int num12 = 255;
			int num13 = 255;
			Main.NewText(text10, (byte)num11, (byte)num12, (byte)num13);
			long num14 = 0L;
			if ("Custom Buffers: 0 queued of " != null)
			{
			}
			if (num14 == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x0600388D RID: 14477 RVA: 0x00226038 File Offset: 0x00224238
		public static void PrintBufferSizes()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			string text;
			string text2;
			Console.WriteLine("Small Buffers:  " + text + " queued of " + text2);
			string text3;
			string text4;
			Console.WriteLine("Medium Buffers: " + text3 + " queued of " + text4);
			string text5;
			string text6;
			Console.WriteLine("Large Buffers:  " + text5 + " queued of " + text6);
			string text7;
			Console.WriteLine("Custom Buffers: 0 queued of " + text7);
			Console.WriteLine("");
			long num2 = 0L;
			if ("" != null)
			{
			}
			if (num2 == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x0600388E RID: 14478 RVA: 0x002260EC File Offset: 0x002242EC
		public LegacyNetBufferPool()
		{
		}

		// Token: 0x0600388F RID: 14479 RVA: 0x00226100 File Offset: 0x00224300
		// Note: this type is marked as 'beforefieldinit'.
		static LegacyNetBufferPool()
		{
		}

		// Token: 0x0400793D RID: 31037
		private const int SMALL_BUFFER_SIZE = 256;

		// Token: 0x0400793E RID: 31038
		private const int MEDIUM_BUFFER_SIZE = 1024;

		// Token: 0x0400793F RID: 31039
		private const int LARGE_BUFFER_SIZE = 16384;

		// Token: 0x04007940 RID: 31040
		private static object bufferLock;

		// Token: 0x04007941 RID: 31041
		private static Queue<byte[]> _smallBufferQueue;

		// Token: 0x04007942 RID: 31042
		private static Queue<byte[]> _mediumBufferQueue;

		// Token: 0x04007943 RID: 31043
		private static Queue<byte[]> _largeBufferQueue;

		// Token: 0x04007944 RID: 31044
		private static int _smallBufferCount;

		// Token: 0x04007945 RID: 31045
		private static int _mediumBufferCount;

		// Token: 0x04007946 RID: 31046
		private static int _largeBufferCount;

		// Token: 0x04007947 RID: 31047
		private static int _customBufferCount;
	}
}
