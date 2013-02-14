using System;
using System.Runtime.InteropServices;
using Gecko.Interop;

namespace Gecko
{
	public static class ConsoleService
	{
		internal static ServiceWrapper<nsIConsoleService> _consoleService;

		static ConsoleService()
		{
			_consoleService = new ServiceWrapper<nsIConsoleService>(Contracts.ConsoleService);
		}

		public static void Reset()
		{
			_consoleService.Instance.Reset();
		}
	}
}