using System;

namespace System
{
	// Token: 0x0200017C RID: 380
	internal interface IConsoleDriver
	{
		// Token: 0x06000EE8 RID: 3816
		void Clear();

		// Token: 0x06000EE9 RID: 3817
		ConsoleKeyInfo ReadKey(bool intercept);

		// Token: 0x06000EEA RID: 3818
		string ReadLine();
	}
}
