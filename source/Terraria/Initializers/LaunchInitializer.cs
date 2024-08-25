using System;
using System.Diagnostics;

namespace Terraria.Initializers
{
	// Token: 0x0200058C RID: 1420
	public static class LaunchInitializer
	{
		// Token: 0x060034AC RID: 13484 RVA: 0x0020A238 File Offset: 0x00208438
		public static void LoadParameters(Main game)
		{
			LaunchInitializer.LoadSharedParameters(game);
			if (!true)
			{
			}
			if (true)
			{
				LaunchInitializer.LoadServerParameters(game);
			}
			LaunchInitializer.LoadClientParameters(game);
		}

		// Token: 0x060034AD RID: 13485 RVA: 0x0020A260 File Offset: 0x00208460
		private static void LoadSharedParameters(Main game)
		{
			if ("-loadlib" == null || "-loadlib" != null)
			{
				string text;
				if (text != null)
				{
					game.loadLib(text);
				}
				if (("-p" == null || "-p" != null) && ("-port" == null || "-port" != null))
				{
					string text2;
					if (text2 != null)
					{
						bool flag = int.TryParse(text2, 2);
					}
					return;
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060034AE RID: 13486 RVA: 0x0020A2B4 File Offset: 0x002084B4
		private static void LoadClientParameters(Main game)
		{
			if (("-j" == null || "-j" != null) && ("-join" == null || "-join" != null))
			{
				string text;
				if (text != null)
				{
					game.AutoJoin(text);
				}
				if (("-pass" == null || "-pass" != null) && ("-password" == null || "-password" != null))
				{
					string text2;
					if (text2 != null)
					{
						string text3 = Main.ConvertFromSafeArgument(text2);
						game.AutoPass();
					}
					if ("-host" == null || "-host" != null)
					{
						game.AutoHost();
						return;
					}
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060034AF RID: 13487 RVA: 0x0020A330 File Offset: 0x00208530
		private static void LoadServerParameters(Main game)
		{
			int num = 1;
			if ("-forcepriority" != null && "-forcepriority" == null)
			{
				throw new ArrayTypeMismatchException();
			}
			string text;
			if (text != null)
			{
				Process currentProcess = Process.GetCurrentProcess();
				bool flag = int.TryParse(text, num);
				return;
			}
			Process currentProcess2 = Process.GetCurrentProcess();
		}

		// Token: 0x060034B0 RID: 13488 RVA: 0x0020A5CC File Offset: 0x002087CC
		private static bool HasParameter(params string[] keys)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x060034B1 RID: 13489 RVA: 0x0020A5E4 File Offset: 0x002087E4
		private static string TryParameter(params string[] keys)
		{
			if (!true)
			{
			}
			if (!false)
			{
			}
			return "";
		}
	}
}
