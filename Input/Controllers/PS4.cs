#if UNITY_EDITOR_WIN
#define WINDOWS
#elif UNITY_EDITOR_OSX
#define OSX
#elif UNITY_EDITOR_LINUX
#define LINUX
#elif UNITY_STANDALONE_WIN
#define WINDOWS
#elif UNITY_STANDALONE_OSX
#define OSX
#elif UNITY_STANDALONE_LINUX
#define LINUX
#endif

using System;

namespace Exodrifter.Anchor
{
	public class PS4
	{

		public static int Convert(ButtonCode code)
		{
			switch (code)
			{
				case ButtonCode.ButtonA:
					return ButtonA();
				case ButtonCode.ButtonB:
					return ButtonB();
				case ButtonCode.ButtonX:
					return ButtonX();
				case ButtonCode.ButtonY:
					return ButtonY();
			}

			throw new ArgumentException();
		}

		private static int ButtonA()
		{
#if WINDOWS
			return 1;
#elif OSX
			return 1;
#elif LINUX
			return 1;
#else
			throw new InvalidOperationException();
#endif
		}

		private static int ButtonB()
		{
#if WINDOWS
			return 2;
#elif OSX
			return 2;
#elif LINUX
			return 2;
#else
			throw new InvalidOperationException();
#endif
		}

		private static int ButtonX()
		{
#if WINDOWS
			return 0;
#elif OSX
			return 0;
#elif LINUX
			return 0;
#else
			throw new InvalidOperationException();
#endif
		}

		private static int ButtonY()
		{
#if WINDOWS
			return 3;
#elif OSX
			return 3;
#elif LINUX
			return 3;
#else
			throw new InvalidOperationException();
#endif
		}
	}
}
