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
	public class Xbox360
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
			return 0;
#elif OSX
			return 16;
#elif LINUX
			return 0;
#else
			throw new InvalidOperationException();
#endif
		}

		private static int ButtonB()
		{
#if WINDOWS
			return 1;
#elif OSX
			return 17;
#elif LINUX
			return 1;
#else
			throw new InvalidOperationException();
#endif
		}

		private static int ButtonX()
		{
#if WINDOWS
			return 2;
#elif OSX
			return 18;
#elif LINUX
			return 2;
#else
			throw new InvalidOperationException();
#endif
		}

		private static int ButtonY()
		{
#if WINDOWS
			return 3;
#elif OSX
			return 19;
#elif LINUX
			return 3;
#else
			throw new InvalidOperationException();
#endif
		}

		private static int LeftOption()
		{
#if WINDOWS
			return 6;
#elif OSX
			return 10;
#elif LINUX
			return 6;
#else
			throw new InvalidOperationException();
#endif
		}

		private static int Guide()
		{
#if OSX
			return 15;
#else
			throw new InvalidOperationException();
#endif
		}

		private static int RightOption()
		{
#if WINDOWS
			return 7;
#elif OSX
			return 9;
#elif LINUX
			return 7;
#else
			throw new InvalidOperationException();
#endif
		}

		private static int L1()
		{
#if WINDOWS
			return 4;
#elif OSX
			return 13;
#elif LINUX
			return 4;
#else
			throw new InvalidOperationException();
#endif
		}

		private static int R1()
		{
#if WINDOWS
			return 5;
#elif OSX
			return 14;
#elif LINUX
			return 5;
#else
			throw new InvalidOperationException();
#endif
		}

		private static int LeftAnalog()
		{
#if WINDOWS
			return 8;
#elif OSX
			return 11;
#elif LINUX
			return 9;
#else
			throw new InvalidOperationException();
#endif
		}

		private static int RightAnalog()
		{
#if WINDOWS
			return 9;
#elif OSX
			return 12;
#elif LINUX
			return 10;
#else
			throw new InvalidOperationException();
#endif
		}
	}
}
