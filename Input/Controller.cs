namespace Exodrifter.Anchor
{
	public static class Controller
	{
		public static bool GetButton
			(ButtonCode code, PlayerCode player = PlayerCode.Any)
		{
			return GetButtonInternal(code, player,
				ButtonState.Down, ButtonState.On);
		}

		public static bool GetButtonDown
			(ButtonCode code, PlayerCode player = PlayerCode.Any)
		{
			return GetButtonInternal(code, player,
				ButtonState.Down);
		}

		public static bool GetButtonUp
			(ButtonCode code, PlayerCode player = PlayerCode.Any)
		{
			return GetButtonInternal(code, player,
				ButtonState.Up);
		}

		public static float GetAxis(AxisCode code, PlayerCode player = PlayerCode.Any)
		{
			return GetAxisInternal(code, player);
		}

		#region Utility

		private static float GetAxisInternal(AxisCode code, PlayerCode player)
		{
			var states = ControllerHelper.Instance.States;
			if (player == PlayerCode.Any)
			{
				float value = 0;
				int count = 0;
				for (int i = 0; i < states.Length; ++i)
				{
					if (!Connected(i))
					{
						continue;
					}

					count++;
					value += states[i].axis[code];
				}

				if (count == 0)
				{
					return 0;
				}
				return value / count;
			}
			else
			{
				if (!Connected((int)player))
				{
					return 0;
				}

				return states[(int)player].axis[code];
			}
		}

		private static bool GetButtonInternal
			(ButtonCode code, PlayerCode player, params ButtonState[] wanted)
		{
			var states = ControllerHelper.Instance.States;

			if (player == PlayerCode.Any)
			{
				for (int i = 0; i < states.Length; ++i)
				{
					if (!Connected(i))
					{
						continue;
					}

					var state = states[i];
					foreach (var want in wanted)
					{
						if (state.buttons[code] == want)
						{
							return true;
						}
					}
				}
				return false;
			}
			else
			{
				if (!Connected((int)player))
				{
					return false;
				}

				var state = states[(int)player];
				foreach (var want in wanted)
				{
					if (state.buttons[code] == want)
					{
						return true;
					}
				}
				return false;
			}
		}

		private static bool Connected(int player)
		{
			return ControllerHelper.Instance.States[player].connected;
		}

		#endregion
	}
}
