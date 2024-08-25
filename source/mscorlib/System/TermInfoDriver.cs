using System;
using System.Collections;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;

namespace System
{
	// Token: 0x0200018D RID: 397
	internal class TermInfoDriver : IConsoleDriver
	{
		// Token: 0x06000F7A RID: 3962 RVA: 0x00020AA0 File Offset: 0x0001ECA0
		private static string TryTermInfoDir(string dir, string term)
		{
			long num = 0L;
			char c = dir[(int)num];
			string text;
			bool flag = File.Exists(text);
			return text;
		}

		// Token: 0x06000F7B RID: 3963 RVA: 0x00020AD8 File Offset: 0x0001ECD8
		private static string SearchTerminfo(string term)
		{
			for (;;)
			{
				string text = Environment.internalGetEnvironmentVariable("TERMINFO");
				if (text != null)
				{
					bool flag = Directory.Exists(text);
					if ("TERMINFO" == null)
					{
					}
					string text2;
					if (text2 != null)
					{
						continue;
					}
				}
				if ("TERMINFO" == null)
				{
				}
				bool flag2 = Directory.Exists(text);
				if ("TERMINFO" == null)
				{
				}
				string text3;
				if (text3 == null)
				{
					return;
				}
			}
		}

		// Token: 0x06000F7C RID: 3964 RVA: 0x00020B24 File Offset: 0x0001ED24
		private void WriteConsole(string str)
		{
			if (str != null)
			{
				this.stdout.InternalWriteString(str);
				return;
			}
		}

		// Token: 0x06000F7D RID: 3965 RVA: 0x00020B44 File Offset: 0x0001ED44
		public TermInfoDriver(string term)
		{
			int num = 1;
			this.cursorVisible = num != 0;
			int num2 = 15;
			this.fgcolor = (ConsoleColor)num2;
			this.term = term;
			if (num2 == 0)
			{
			}
			if (TermInfoDriver.SearchTerminfo(term) != null)
			{
				return;
			}
			byte[] xterm = KnownTerminals.xterm;
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000F7E RID: 3966 RVA: 0x00020BB4 File Offset: 0x0001EDB4
		public bool Initialized
		{
			get
			{
				return this.inited;
			}
		}

		// Token: 0x06000F7F RID: 3967 RVA: 0x00020BC8 File Offset: 0x0001EDC8
		public void Init()
		{
			bool flag = this.inited;
			if (!flag)
			{
				object obj = this.initLock;
				if (flag)
				{
					return;
				}
				if (!flag)
				{
				}
				bool isConsole = ConsoleDriver.IsConsole;
				if (!flag)
				{
				}
				int num = 88;
				if (num != 0 && num != 0)
				{
					return;
				}
				if (!flag)
				{
				}
				int num2 = 16;
				int num4;
				int num3 = Math.Min(num4, num2);
				int num5 = 1;
				int num6 = Math.Max(num3, num5);
				int num7 = 184;
				if (num7 == 0)
				{
				}
				if (num7 == 0)
				{
				}
				Stream stream = Console.OpenStandardInput(0);
				if (!true)
				{
				}
				string text2;
				string text3;
				string text = text2 + text3;
				string text4;
				if (text4 == null)
				{
				}
				string text5;
				bool flag2 = text5 == "cygwin";
				bool flag3;
				if (flag3)
				{
				}
				int num8 = 10;
				if ("\u001b]0;{0}\a" == null || num8 != 0)
				{
				}
				long num9 = 0L;
				if ("\u001b]0;{0}\a" != null)
				{
					Monitor.Exit(obj);
				}
				if (num9 != 0L)
				{
					throw new OutOfMemoryException();
				}
			}
		}

		// Token: 0x06000F80 RID: 3968 RVA: 0x00020CF4 File Offset: 0x0001EEF4
		private void IncrementX()
		{
			int num = this.cursorLeft;
			int num2 = this.WindowWidth;
			int num3 = this.cursorTop;
			int num4 = this.WindowHeight;
			int num5 = this.rl_starty;
			this.rl_starty = num5;
			this.cursorTop = num5;
		}

		// Token: 0x06000F81 RID: 3969 RVA: 0x00020D38 File Offset: 0x0001EF38
		public void WriteSpecialKey(ConsoleKeyInfo key)
		{
			int num = this.cursorLeft;
			int num2 = this.rl_startx;
			int num3 = this.cursorTop;
			int num4 = this.rl_starty;
			this.cursorLeft = key;
			if (" " != null)
			{
				this.stdout.InternalWriteString(" ");
			}
			int num5 = this.cursorLeft;
			string text = this.title;
		}

		// Token: 0x06000F82 RID: 3970 RVA: 0x00020DD0 File Offset: 0x0001EFD0
		public void WriteSpecialKey(char c)
		{
			long num = 0L;
			ConsoleKeyInfo consoleKeyInfo = this.CreateKeyInfoFromInt((int)c, num != 0L);
			this.WriteSpecialKey(consoleKeyInfo);
		}

		// Token: 0x06000F83 RID: 3971 RVA: 0x00020DF0 File Offset: 0x0001EFF0
		public bool IsSpecialKey(ConsoleKeyInfo key)
		{
			if (this.inited)
			{
				int num = this.cursorTop;
				int num2 = this.WindowHeight;
				int num3 = this.cursorTop;
				this.cursorTop = num3;
				this.IncrementX();
				return;
			}
		}

		// Token: 0x06000F84 RID: 3972 RVA: 0x00020E2C File Offset: 0x0001F02C
		public bool IsSpecialKey(char c)
		{
			long num = 0L;
			ConsoleKeyInfo consoleKeyInfo = this.CreateKeyInfoFromInt((int)c, num != 0L);
			return this.IsSpecialKey(consoleKeyInfo);
		}

		// Token: 0x06000F85 RID: 3973 RVA: 0x00020E4C File Offset: 0x0001F04C
		private void GetCursorPosition()
		{
			if (!true)
			{
			}
			StreamReader streamReader = this.stdin;
			if ("\u001b[6n" != null)
			{
				this.stdout.InternalWriteString("\u001b[6n");
			}
			StreamReader streamReader2 = this.stdin;
			StreamReader streamReader3 = this.stdin;
			StreamReader streamReader4 = this.stdin;
			StreamReader streamReader5 = this.stdin;
		}

		// Token: 0x06000F86 RID: 3974 RVA: 0x00020EFC File Offset: 0x0001F0FC
		private void CheckWindowDimensions()
		{
			if (!true)
			{
			}
			if (true)
			{
				if (!true)
				{
				}
				if (!true)
				{
				}
				if (!true)
				{
				}
				return;
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000F87 RID: 3975 RVA: 0x00020F5C File Offset: 0x0001F15C
		public int WindowHeight
		{
			get
			{
				if (!this.inited)
				{
					this.Init();
				}
				this.CheckWindowDimensions();
				return this.windowHeight;
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000F88 RID: 3976 RVA: 0x00020F84 File Offset: 0x0001F184
		public int WindowWidth
		{
			get
			{
				if (!this.inited)
				{
					this.Init();
				}
				this.CheckWindowDimensions();
				return this.windowWidth;
			}
		}

		// Token: 0x06000F89 RID: 3977 RVA: 0x00020FAC File Offset: 0x0001F1AC
		public void Clear()
		{
			if (!this.inited)
			{
				this.Init();
			}
			string text = this.clear;
			if (text != null)
			{
				this.stdout.InternalWriteString(text);
			}
		}

		// Token: 0x06000F8A RID: 3978 RVA: 0x00020FE0 File Offset: 0x0001F1E0
		private void AddToBuffer(int b)
		{
			if (this.buffer != null)
			{
				int num = this.writepos;
				char[] array = this.buffer;
				return;
			}
		}

		// Token: 0x06000F8B RID: 3979 RVA: 0x0002100C File Offset: 0x0001F20C
		private void AdjustBuffer()
		{
			int num = this.readpos;
			string text = this.keypadXmit;
		}

		// Token: 0x06000F8C RID: 3980 RVA: 0x00021028 File Offset: 0x0001F228
		private ConsoleKeyInfo CreateKeyInfoFromInt(int n, bool alt)
		{
		}

		// Token: 0x06000F8D RID: 3981 RVA: 0x00021038 File Offset: 0x0001F238
		private object GetKeyFromBuffer(bool cooked)
		{
			int num = this.readpos;
			string text = this.keypadXmit;
			char[] array = this.buffer;
			bool flag = this.rootmap.StartsWith(43155456);
			int num2 = this.readpos;
			string text2 = this.keypadXmit;
			ByteMatcher byteMatcher = this.rootmap;
			char[] array2 = this.buffer;
			if (this.keymap != null)
			{
				Hashtable hashtable = this.keymap;
				int num3 = this.readpos;
				string text3 = this.keypadXmit;
				int num4 = this.readpos;
				string text4 = this.keypadXmit;
				this.readpos = num4;
				char[] array3 = this.buffer;
				int num5 = this.writepos;
				this.readpos = text4;
			}
			int num6 = this.readpos;
			string text5 = this.keypadXmit;
			throw new InvalidCastException();
		}

		// Token: 0x06000F8E RID: 3982 RVA: 0x000210F4 File Offset: 0x0001F2F4
		private ConsoleKeyInfo ReadKeyInternal([Out] bool fresh)
		{
			do
			{
				bool flag = this.inited;
				if (!flag)
				{
					this.Init();
				}
				this.InitKeys();
				if (this.GetKeyFromBuffer(true) != null)
				{
				}
				if (!flag)
				{
				}
				StreamReader streamReader = this.stdin;
				bool flag2 = this.stdin.DataAvailable();
				StreamReader streamReader2 = this.stdin;
				bool flag3 = this.stdin.DataAvailable();
				long num = 0L;
				if (this.GetKeyFromBuffer(num != 0L) != null)
				{
					goto IL_0071;
				}
				StreamReader streamReader3 = this.stdin;
			}
			while (this.GetKeyFromBuffer(true) == null);
			fresh.m_value = true;
			IL_0071:
			throw new InvalidCastException();
		}

		// Token: 0x06000F8F RID: 3983 RVA: 0x00021178 File Offset: 0x0001F378
		private bool InputPending()
		{
			int num = this.readpos;
			string text = this.keypadXmit;
			return true;
		}

		// Token: 0x06000F90 RID: 3984 RVA: 0x00021198 File Offset: 0x0001F398
		private void QueueEcho(char c)
		{
			if (this.echobuf == null)
			{
			}
			int num = this.readpos;
			string text = this.keypadXmit;
			bool flag = this.stdin.DataAvailable();
			char[] array = this.echobuf;
			int num2 = this.echon;
			this.stdout.InternalWriteChars(array, num2);
		}

		// Token: 0x06000F91 RID: 3985 RVA: 0x000211EC File Offset: 0x0001F3EC
		private void Echo(ConsoleKeyInfo key)
		{
			bool flag = this.IsSpecialKey(key);
		}

		// Token: 0x06000F92 RID: 3986 RVA: 0x00021204 File Offset: 0x0001F404
		private void EchoFlush()
		{
			int num = this.echon;
			if (num != 0)
			{
				CStreamWriter cstreamWriter = this.stdout;
				char[] array = this.echobuf;
				cstreamWriter.InternalWriteChars(array, num);
			}
		}

		// Token: 0x06000F93 RID: 3987 RVA: 0x00021234 File Offset: 0x0001F434
		public int Read([In] [Out] char[] dest, int index, int count)
		{
			int num2;
			do
			{
				int num = 1;
				object keyFromBuffer = this.GetKeyFromBuffer(num != 0);
				if (keyFromBuffer == null)
				{
					break;
				}
				num2 = 1;
			}
			while (this.GetKeyFromBuffer(num2 != 0) != null);
			int num3 = this.cursorLeft;
			this.rl_startx = num3;
			ConsoleKeyInfo consoleKeyInfo;
			this.Echo(consoleKeyInfo);
			int num4 = this.echon;
			if (num4 != 0)
			{
				CStreamWriter cstreamWriter = this.stdout;
				char[] array = this.echobuf;
				cstreamWriter.InternalWriteChars(array, num4);
			}
			long num5 = 0L;
			this.AddToBuffer((int)num5);
			throw new InvalidCastException();
		}

		// Token: 0x06000F94 RID: 3988 RVA: 0x000212B8 File Offset: 0x0001F4B8
		public ConsoleKeyInfo ReadKey(bool intercept)
		{
			ConsoleKeyInfo consoleKeyInfo = this.ReadKeyInternal(intercept);
			this.Echo(consoleKeyInfo);
			int num = this.echon;
			if (num != 0)
			{
				CStreamWriter cstreamWriter = this.stdout;
				char[] array = this.echobuf;
				cstreamWriter.InternalWriteChars(array, num);
			}
			return consoleKeyInfo;
		}

		// Token: 0x06000F95 RID: 3989 RVA: 0x000212F8 File Offset: 0x0001F4F8
		public string ReadLine()
		{
			return this.ReadUntilConditionInternal(true);
		}

		// Token: 0x06000F96 RID: 3990 RVA: 0x0002130C File Offset: 0x0001F50C
		public string ReadToEnd()
		{
			long num = 0L;
			return this.ReadUntilConditionInternal(num != 0L);
		}

		// Token: 0x06000F97 RID: 3991 RVA: 0x00021324 File Offset: 0x0001F524
		private string ReadUntilConditionInternal(bool haltOnNewLine)
		{
			for (;;)
			{
				if (!this.inited)
				{
					this.Init();
				}
				this.GetCursorPosition();
				long num = 0L;
				int num2 = this.cursorLeft;
				byte[] array = this.control_characters;
				this.rl_startx = num2;
				ConsoleKeyInfo consoleKeyInfo = this.ReadKeyInternal(num != 0L);
				int num3;
				if (num3 == 0)
				{
					return;
				}
				if (true)
				{
					long num4 = 0L;
					this.Echo(consoleKeyInfo);
					while (num4 == 0L)
					{
					}
					if (false)
					{
						break;
					}
				}
			}
			int num5 = this.echon;
			if (num5 != 0)
			{
				CStreamWriter cstreamWriter = this.stdout;
				char[] array2 = this.echobuf;
				cstreamWriter.InternalWriteChars(array2, num5);
				return;
			}
		}

		// Token: 0x06000F98 RID: 3992 RVA: 0x000213A8 File Offset: 0x0001F5A8
		public void SetCursorPosition(int left, int top)
		{
			if (!this.inited)
			{
				this.Init();
			}
			this.CheckWindowDimensions();
			int num = this.bufferWidth;
			int num2 = this.bufferHeight;
			string text;
			if (text != null)
			{
				this.stdout.InternalWriteString(text);
			}
			this.cursorLeft = left;
			this.title = top;
		}

		// Token: 0x06000F99 RID: 3993 RVA: 0x000213F8 File Offset: 0x0001F5F8
		private void CreateKeyMap()
		{
			Hashtable hashtable = this.keymap;
			Hashtable hashtable2 = this.keymap;
			Hashtable hashtable3 = this.keymap;
			Hashtable hashtable4 = this.keymap;
			Hashtable hashtable5 = this.keymap;
			Hashtable hashtable6 = this.keymap;
			Hashtable hashtable7 = this.keymap;
			Hashtable hashtable8 = this.keymap;
			Hashtable hashtable9 = this.keymap;
			Hashtable hashtable10 = this.keymap;
			Hashtable hashtable11 = this.keymap;
			Hashtable hashtable12 = this.keymap;
			Hashtable hashtable13 = this.keymap;
			Hashtable hashtable14 = this.keymap;
			Hashtable hashtable15 = this.keymap;
			Hashtable hashtable16 = this.keymap;
			Hashtable hashtable17 = this.keymap;
			Hashtable hashtable18 = this.keymap;
			Hashtable hashtable19 = this.keymap;
			Hashtable hashtable20 = this.keymap;
			Hashtable hashtable21 = this.keymap;
			Hashtable hashtable22 = this.keymap;
			Hashtable hashtable23 = this.keymap;
			Hashtable hashtable24 = this.keymap;
			Hashtable hashtable25 = this.keymap;
			Hashtable hashtable26 = this.keymap;
			Hashtable hashtable27 = this.keymap;
			Hashtable hashtable28 = this.keymap;
			Hashtable hashtable29 = this.keymap;
			Hashtable hashtable30 = this.keymap;
			Hashtable hashtable31 = this.keymap;
			Hashtable hashtable32 = this.keymap;
			Hashtable hashtable33 = this.keymap;
			Hashtable hashtable34 = this.keymap;
			Hashtable hashtable35 = this.keymap;
			Hashtable hashtable36 = this.keymap;
			Hashtable hashtable37 = this.keymap;
			Hashtable hashtable38 = this.keymap;
			Hashtable hashtable39 = this.keymap;
			Hashtable hashtable40 = this.keymap;
			Hashtable hashtable41 = this.keymap;
			Hashtable hashtable42 = this.keymap;
			Hashtable hashtable43 = this.keymap;
			Hashtable hashtable44 = this.keymap;
			Hashtable hashtable45 = this.keymap;
			Hashtable hashtable46 = this.keymap;
			Hashtable hashtable47 = this.keymap;
			Hashtable hashtable48 = this.keymap;
			Hashtable hashtable49 = this.keymap;
			Hashtable hashtable50 = this.keymap;
			Hashtable hashtable51 = this.keymap;
			Hashtable hashtable52 = this.keymap;
			Hashtable hashtable53 = this.keymap;
			Hashtable hashtable54 = this.keymap;
			Hashtable hashtable55 = this.keymap;
			Hashtable hashtable56 = this.keymap;
		}

		// Token: 0x06000F9A RID: 3994 RVA: 0x000215C4 File Offset: 0x0001F7C4
		private void InitKeys()
		{
			if (!this.initKeys)
			{
				this.CreateKeyMap();
				ByteMatcher byteMatcher = this.rootmap;
				int num = 1;
				byte[] array = this.control_characters;
				this.initKeys = num != 0;
			}
		}

		// Token: 0x06000F9B RID: 3995 RVA: 0x00021600 File Offset: 0x0001F800
		private void AddStringMapping(TermInfoStrings s)
		{
			byte[] stringBytes = this.reader.GetStringBytes(s);
			if (stringBytes != null)
			{
				this.rootmap.AddMapping(s, stringBytes);
				return;
			}
		}

		// Token: 0x06000F9C RID: 3996 RVA: 0x0002162C File Offset: 0x0001F82C
		// Note: this type is marked as 'beforefieldinit'.
		static TermInfoDriver()
		{
			if (("/usr/share/terminfo" == null || "/usr/share/terminfo" != null) && ("/etc/terminfo" == null || "/etc/terminfo" != null) && ("/usr/lib/terminfo" == null || "/usr/lib/terminfo" != null) && ("/lib/terminfo" == null || "/lib/terminfo" != null))
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x04000698 RID: 1688
		private unsafe static int* native_terminal_size;

		// Token: 0x04000699 RID: 1689
		private static int terminal_size;

		// Token: 0x0400069A RID: 1690
		private static readonly string[] locations;

		// Token: 0x0400069B RID: 1691
		private TermInfoReader reader;

		// Token: 0x0400069C RID: 1692
		private int cursorLeft;

		// Token: 0x0400069D RID: 1693
		private int cursorTop;

		// Token: 0x0400069E RID: 1694
		private string title;

		// Token: 0x0400069F RID: 1695
		private string titleFormat;

		// Token: 0x040006A0 RID: 1696
		private bool cursorVisible;

		// Token: 0x040006A1 RID: 1697
		private string csrVisible;

		// Token: 0x040006A2 RID: 1698
		private string csrInvisible;

		// Token: 0x040006A3 RID: 1699
		private string clear;

		// Token: 0x040006A4 RID: 1700
		private string bell;

		// Token: 0x040006A5 RID: 1701
		private string term;

		// Token: 0x040006A6 RID: 1702
		private StreamReader stdin;

		// Token: 0x040006A7 RID: 1703
		private CStreamWriter stdout;

		// Token: 0x040006A8 RID: 1704
		private int windowWidth;

		// Token: 0x040006A9 RID: 1705
		private int windowHeight;

		// Token: 0x040006AA RID: 1706
		private int bufferHeight;

		// Token: 0x040006AB RID: 1707
		private int bufferWidth;

		// Token: 0x040006AC RID: 1708
		private char[] buffer;

		// Token: 0x040006AD RID: 1709
		private int readpos;

		// Token: 0x040006AE RID: 1710
		private int writepos;

		// Token: 0x040006AF RID: 1711
		private string keypadXmit;

		// Token: 0x040006B0 RID: 1712
		private string keypadLocal;

		// Token: 0x040006B1 RID: 1713
		private bool inited;

		// Token: 0x040006B2 RID: 1714
		private object initLock;

		// Token: 0x040006B3 RID: 1715
		private bool initKeys;

		// Token: 0x040006B4 RID: 1716
		private string origPair;

		// Token: 0x040006B5 RID: 1717
		private string origColors;

		// Token: 0x040006B6 RID: 1718
		private string cursorAddress;

		// Token: 0x040006B7 RID: 1719
		private ConsoleColor fgcolor;

		// Token: 0x040006B8 RID: 1720
		private string setfgcolor;

		// Token: 0x040006B9 RID: 1721
		private string setbgcolor;

		// Token: 0x040006BA RID: 1722
		private int maxColors;

		// Token: 0x040006BB RID: 1723
		private bool noGetPosition;

		// Token: 0x040006BC RID: 1724
		private Hashtable keymap;

		// Token: 0x040006BD RID: 1725
		private ByteMatcher rootmap;

		// Token: 0x040006BE RID: 1726
		private int rl_startx;

		// Token: 0x040006BF RID: 1727
		private int rl_starty;

		// Token: 0x040006C0 RID: 1728
		private byte[] control_characters;

		// Token: 0x040006C1 RID: 1729
		private static readonly int[] _consoleColorToAnsiCode;

		// Token: 0x040006C2 RID: 1730
		private char[] echobuf;

		// Token: 0x040006C3 RID: 1731
		private int echon;
	}
}
