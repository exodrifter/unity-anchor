using System;

namespace Exodrifter.Anchor
{
	/// <summary>
	/// Robert Penner's easing functions: http://www.robertpenner.com/easing/
	/// A visual guide: http://easings.net/
	/// </summary>
	public enum Easing
	{
		Linear,
		EaseInSine,
		EaseOutSine,
		EaseInOutSine,
		EaseInQuad,
		EaseOutQuad,
		EaseInOutQuad,
		EaseInCubic,
		EaseOutCubic,
		EaseInOutCubic,
		EaseInQuart,
		EaseOutQuart,
		EaseInOutQuart,
		EaseInQuint,
		EaseOutQuint,
		EaseInOutQuint,
		EaseInExpo,
		EaseOutExpo,
		EaseInOutExpo,
		EaseInCirc,
		EaseOutCirc,
		EaseInOutCirc,
		EaseInBack,
		EaseOutBack,
		EaseInOutBack,
		EaseInElastic,
		EaseOutElastic,
		EaseInOutElastic,
		EaseInBounce,
		EaseOutBounce,
		EaseInOutBounce
	}

	public static class EasingExtensions
	{
		private const double PI = Math.PI;
		private const double HALFPI = Math.PI / 2;

		public static float Interpolate(this Easing easing, float p)
		{
			switch (easing)
			{
				default:
				case Easing.Linear: return Linear(p);
				case Easing.EaseInSine: return EaseInSine(p);
				case Easing.EaseOutSine: return EaseOutSine(p);
				case Easing.EaseInOutSine: return EaseInOutSine(p);
				case Easing.EaseOutQuad: return EaseOutQuad(p);
				case Easing.EaseInQuad: return EaseInQuad(p);
				case Easing.EaseInOutQuad: return EaseInOutQuad(p);
				case Easing.EaseInCubic: return EaseInCubic(p);
				case Easing.EaseOutCubic: return EaseOutCubic(p);
				case Easing.EaseInOutCubic: return EaseInOutCubic(p);
				case Easing.EaseInQuart: return EaseInQuart(p);
				case Easing.EaseOutQuart: return EaseOutQuart(p);
				case Easing.EaseInOutQuart: return EaseInOutQuart(p);
				case Easing.EaseInQuint: return EaseInQuint(p);
				case Easing.EaseOutQuint: return EaseOutQuint(p);
				case Easing.EaseInOutQuint: return EaseInOutQuint(p);
				case Easing.EaseInExpo: return EaseInExpo(p);
				case Easing.EaseOutExpo: return EaseOutExpo(p);
				case Easing.EaseInOutExpo: return EaseInOutExpo(p);
				case Easing.EaseInCirc: return EaseInCirc(p);
				case Easing.EaseOutCirc: return EaseOutCirc(p);
				case Easing.EaseInOutCirc: return EaseInOutCirc(p);
				case Easing.EaseInBack: return EaseInBack(p);
				case Easing.EaseOutBack: return EaseOutBack(p);
				case Easing.EaseInOutBack: return EaseInOutBack(p);
				case Easing.EaseInElastic: return EaseInElastic(p);
				case Easing.EaseOutElastic: return EaseOutElastic(p);
				case Easing.EaseInOutElastic: return EaseInOutElastic(p);
				case Easing.EaseInBounce: return EaseInBounce(p);
				case Easing.EaseOutBounce: return EaseOutBounce(p);
				case Easing.EaseInOutBounce: return EaseInOutBounce(p);
			}
		}

		public static double Interpolate(this Easing easing, double p)
		{
			switch (easing)
			{
				default:
				case Easing.Linear: return Linear(p);
				case Easing.EaseInSine: return EaseInSine(p);
				case Easing.EaseOutSine: return EaseOutSine(p);
				case Easing.EaseInOutSine: return EaseInOutSine(p);
				case Easing.EaseOutQuad: return EaseOutQuad(p);
				case Easing.EaseInQuad: return EaseInQuad(p);
				case Easing.EaseInOutQuad: return EaseInOutQuad(p);
				case Easing.EaseInCubic: return EaseInCubic(p);
				case Easing.EaseOutCubic: return EaseOutCubic(p);
				case Easing.EaseInOutCubic: return EaseInOutCubic(p);
				case Easing.EaseInQuart: return EaseInQuart(p);
				case Easing.EaseOutQuart: return EaseOutQuart(p);
				case Easing.EaseInOutQuart: return EaseInOutQuart(p);
				case Easing.EaseInQuint: return EaseInQuint(p);
				case Easing.EaseOutQuint: return EaseOutQuint(p);
				case Easing.EaseInOutQuint: return EaseInOutQuint(p);
				case Easing.EaseInExpo: return EaseInExpo(p);
				case Easing.EaseOutExpo: return EaseOutExpo(p);
				case Easing.EaseInOutExpo: return EaseInOutExpo(p);
				case Easing.EaseInCirc: return EaseInCirc(p);
				case Easing.EaseOutCirc: return EaseOutCirc(p);
				case Easing.EaseInOutCirc: return EaseInOutCirc(p);
				case Easing.EaseInBack: return EaseInBack(p);
				case Easing.EaseOutBack: return EaseOutBack(p);
				case Easing.EaseInOutBack: return EaseInOutBack(p);
				case Easing.EaseInElastic: return EaseInElastic(p);
				case Easing.EaseOutElastic: return EaseOutElastic(p);
				case Easing.EaseInOutElastic: return EaseInOutElastic(p);
				case Easing.EaseInBounce: return EaseInBounce(p);
				case Easing.EaseOutBounce: return EaseOutBounce(p);
				case Easing.EaseInOutBounce: return EaseInOutBounce(p);
			}
		}

		/// <summary>
		/// Modeled after the line y = x
		/// </summary>
		static double Linear(double p)
		{
			return p;
		}

		/// <summary>
		/// Modeled after the line y = x
		/// </summary>
		static float Linear(float p)
		{
			return p;
		}

		/// <summary>
		/// Modeled after quarter-cycle of sine wave
		/// </summary>
		static double EaseInSine(double p)
		{
			return Math.Sin((p - 1) * HALFPI) + 1;
		}

		/// <summary>
		/// Modeled after quarter-cycle of sine wave
		/// </summary>
		static float EaseInSine(float p)
		{
			return (float)Math.Sin((p - 1) * HALFPI) + 1;
		}

		/// <summary>
		/// Modeled after quarter-cycle of sine wave (different phase)
		/// </summary>
		static double EaseOutSine(double p)
		{
			return Math.Sin(p * HALFPI);
		}

		/// <summary>
		/// Modeled after quarter-cycle of sine wave (different phase)
		/// </summary>
		static float EaseOutSine(float p)
		{
			return (float)Math.Sin(p * HALFPI);
		}

		/// <summary>
		/// Modeled after half sine wave
		/// </summary>
		static double EaseInOutSine(double p)
		{
			return 0.5 * (1 - Math.Cos(p * PI));
		}

		/// <summary>
		/// Modeled after half sine wave
		/// </summary>
		static float EaseInOutSine(float p)
		{
			return 0.5f * (1 - (float)Math.Cos(p * PI));
		}

		/// <summary>
		/// Modeled after the parabola y = x^2
		/// </summary>
		static double EaseInQuad(double p)
		{
			return p * p;
		}

		/// <summary>
		/// Modeled after the parabola y = x^2
		/// </summary>
		static float EaseInQuad(float p)
		{
			return p * p;
		}

		/// <summary>
		/// Modeled after the parabola y = -x^2 + 2x
		/// </summary>
		static double EaseOutQuad(double p)
		{
			return -(p * (p - 2));
		}

		/// <summary>
		/// Modeled after the parabola y = -x^2 + 2x
		/// </summary>
		static float EaseOutQuad(float p)
		{
			return -(p * (p - 2));
		}

		/// <summary>
		/// Modeled after the piecewise quadratic
		/// y = (1/2)((2x)^2)             ; [0, 0.5)
		/// y = -(1/2)((2x-1)*(2x-3) - 1) ; [0.5, 1]
		/// </summary>
		static double EaseInOutQuad(double p)
		{
			if (p < 0.5)
			{
				return 2 * p * p;
			}
			else
			{
				return (-2 * p * p) + (4 * p) - 1;
			}
		}

		/// <summary>
		/// Modeled after the piecewise quadratic
		/// y = (1/2)((2x)^2)             ; [0, 0.5)
		/// y = -(1/2)((2x-1)*(2x-3) - 1) ; [0.5, 1]
		/// </summary>
		static float EaseInOutQuad(float p)
		{
			if (p < 0.5f)
			{
				return 2 * p * p;
			}
			else
			{
				return (-2 * p * p) + (4 * p) - 1;
			}
		}

		/// <summary>
		/// Modeled after the cubic y = x^3
		/// </summary>
		static double EaseInCubic(double p)
		{
			return p * p * p;
		}

		/// <summary>
		/// Modeled after the cubic y = x^3
		/// </summary>
		static float EaseInCubic(float p)
		{
			return p * p * p;
		}

		/// <summary>
		/// Modeled after the cubic y = (x - 1)^3 + 1
		/// </summary>
		static double EaseOutCubic(double p)
		{
			double f = (p - 1);
			return f * f * f + 1;
		}

		/// <summary>
		/// Modeled after the cubic y = (x - 1)^3 + 1
		/// </summary>
		static float EaseOutCubic(float p)
		{
			float f = (p - 1);
			return f * f * f + 1;
		}

		/// <summary>	
		/// Modeled after the piecewise cubic
		/// y = (1/2)((2x)^3)       ; [0, 0.5)
		/// y = (1/2)((2x-2)^3 + 2) ; [0.5, 1]
		/// </summary>
		static double EaseInOutCubic(double p)
		{
			if (p < 0.5)
			{
				return 4 * p * p * p;
			}
			else
			{
				double f = ((2 * p) - 2);
				return 0.5 * f * f * f + 1;
			}
		}

		/// <summary>	
		/// Modeled after the piecewise cubic
		/// y = (1/2)((2x)^3)       ; [0, 0.5)
		/// y = (1/2)((2x-2)^3 + 2) ; [0.5, 1]
		/// </summary>
		static float EaseInOutCubic(float p)
		{
			if (p < 0.5f)
			{
				return 4 * p * p * p;
			}
			else
			{
				float f = ((2 * p) - 2);
				return 0.5f * f * f * f + 1;
			}
		}

		/// <summary>
		/// Modeled after the quartic x^4
		/// </summary>
		static double EaseInQuart(double p)
		{
			return p * p * p * p;
		}

		/// <summary>
		/// Modeled after the quartic x^4
		/// </summary>
		static float EaseInQuart(float p)
		{
			return p * p * p * p;
		}

		/// <summary>
		/// Modeled after the quartic y = 1 - (x - 1)^4
		/// </summary>
		static double EaseOutQuart(double p)
		{
			double f = (p - 1);
			return f * f * f * (1 - p) + 1;
		}

		/// <summary>
		/// Modeled after the quartic y = 1 - (x - 1)^4
		/// </summary>
		static float EaseOutQuart(float p)
		{
			float f = (p - 1);
			return f * f * f * (1 - p) + 1;
		}

		/// <summary>
		// Modeled after the piecewise quartic
		// y = (1/2)((2x)^4)        ; [0, 0.5)
		// y = -(1/2)((2x-2)^4 - 2) ; [0.5, 1]
		/// </summary>
		static double EaseInOutQuart(double p)
		{
			if (p < 0.5)
			{
				return 8 * p * p * p * p;
			}
			else
			{
				double f = (p - 1);
				return -8 * f * f * f * f + 1;
			}
		}

		/// <summary>
		// Modeled after the piecewise quartic
		// y = (1/2)((2x)^4)        ; [0, 0.5)
		// y = -(1/2)((2x-2)^4 - 2) ; [0.5, 1]
		/// </summary>
		static float EaseInOutQuart(float p)
		{
			if (p < 0.5f)
			{
				return 8 * p * p * p * p;
			}
			else
			{
				float f = (p - 1);
				return -8 * f * f * f * f + 1;
			}
		}

		/// <summary>
		/// Modeled after the quintic y = x^5
		/// </summary>
		static double EaseInQuint(double p)
		{
			return p * p * p * p * p;
		}

		/// <summary>
		/// Modeled after the quintic y = x^5
		/// </summary>
		static float EaseInQuint(float p)
		{
			return p * p * p * p * p;
		}

		/// <summary>
		/// Modeled after the quintic y = (x - 1)^5 + 1
		/// </summary>
		static double EaseOutQuint(double p)
		{
			double f = (p - 1);
			return f * f * f * f * f + 1;
		}

		/// <summary>
		/// Modeled after the quintic y = (x - 1)^5 + 1
		/// </summary>
		static float EaseOutQuint(float p)
		{
			float f = (p - 1);
			return f * f * f * f * f + 1;
		}

		/// <summary>
		/// Modeled after the piecewise quintic
		/// y = (1/2)((2x)^5)       ; [0, 0.5)
		/// y = (1/2)((2x-2)^5 + 2) ; [0.5, 1]
		/// </summary>
		static double EaseInOutQuint(double p)
		{
			if (p < 0.5)
			{
				return 16 * p * p * p * p * p;
			}
			else
			{
				double f = ((2 * p) - 2);
				return 0.5 * f * f * f * f * f + 1;
			}
		}

		/// <summary>
		/// Modeled after the piecewise quintic
		/// y = (1/2)((2x)^5)       ; [0, 0.5)
		/// y = (1/2)((2x-2)^5 + 2) ; [0.5, 1]
		/// </summary>
		static float EaseInOutQuint(float p)
		{
			if (p < 0.5f)
			{
				return 16 * p * p * p * p * p;
			}
			else
			{
				float f = ((2 * p) - 2);
				return 0.5f * f * f * f * f * f + 1;
			}
		}

		/// <summary>
		/// Modeled after the exponential function y = 2^(10(x - 1))
		/// </summary>
		static double EaseInExpo(double p)
		{
			return (p == 0.0) ? p : Math.Pow(2, 10 * (p - 1));
		}

		/// <summary>
		/// Modeled after the exponential function y = 2^(10(x - 1))
		/// </summary>
		static float EaseInExpo(float p)
		{
			return (p == 0.0f) ? p : (float)Math.Pow(2, 10 * (p - 1));
		}

		/// <summary>
		/// Modeled after the exponential function y = -2^(-10x) + 1
		/// </summary>
		static double EaseOutExpo(double p)
		{
			return (p == 1.0) ? p : 1 - Math.Pow(2, -10 * p);
		}

		/// <summary>
		/// Modeled after the exponential function y = -2^(-10x) + 1
		/// </summary>
		static float EaseOutExpo(float p)
		{
			return (p == 1.0f) ? p : 1 - (float)Math.Pow(2, -10 * p);
		}

		/// <summary>
		/// Modeled after the piecewise exponential
		/// y = (1/2)2^(10(2x - 1))         ; [0,0.5)
		/// y = -(1/2)*2^(-10(2x - 1))) + 1 ; [0.5,1]
		/// </summary>
		static double EaseInOutExpo(double p)
		{
			if (p == 0.0 || p == 1.0) return p;

			if (p < 0.5)
			{
				return 0.5 * Math.Pow(2, (20 * p) - 10);
			}
			else
			{
				return -0.5 * Math.Pow(2, (-20 * p) + 10) + 1;
			}
		}

		/// <summary>
		/// Modeled after the piecewise exponential
		/// y = (1/2)2^(10(2x - 1))         ; [0,0.5)
		/// y = -(1/2)*2^(-10(2x - 1))) + 1 ; [0.5,1]
		/// </summary>
		static float EaseInOutExpo(float p)
		{
			if (p == 0.0f || p == 1.0f) return p;

			if (p < 0.5f)
			{
				return 0.5f * (float)Math.Pow(2, (20 * p) - 10);
			}
			else
			{
				return -0.5f * (float)Math.Pow(2, (-20 * p) + 10) + 1;
			}
		}

		/// <summary>
		/// Modeled after shifted quadrant IV of unit circle
		/// </summary>
		static double EaseInCirc(double p)
		{
			return 1 - Math.Sqrt(1 - (p * p));
		}

		/// <summary>
		/// Modeled after shifted quadrant IV of unit circle
		/// </summary>
		static float EaseInCirc(float p)
		{
			return 1 - (float)Math.Sqrt(1 - (p * p));
		}

		/// <summary>
		/// Modeled after shifted quadrant II of unit circle
		/// </summary>
		static double EaseOutCirc(double p)
		{
			return Math.Sqrt((2 - p) * p);
		}

		/// <summary>
		/// Modeled after shifted quadrant II of unit circle
		/// </summary>
		static float EaseOutCirc(float p)
		{
			return (float)Math.Sqrt((2 - p) * p);
		}

		/// <summary>	
		/// Modeled after the piecewise circular function
		/// y = (1/2)(1 - Math.Sqrt(1 - 4x^2))           ; [0, 0.5)
		/// y = (1/2)(Math.Sqrt(-(2x - 3)*(2x - 1)) + 1) ; [0.5, 1]
		/// </summary>
		static double EaseInOutCirc(double p)
		{
			if (p < 0.5)
			{
				return 0.5 * (1 - Math.Sqrt(1 - 4 * (p * p)));
			}
			else
			{
				return 0.5 * (Math.Sqrt(-((2 * p) - 3) * ((2 * p) - 1)) + 1);
			}
		}

		/// <summary>	
		/// Modeled after the piecewise circular function
		/// y = (1/2)(1 - Math.Sqrt(1 - 4x^2))           ; [0, 0.5)
		/// y = (1/2)(Math.Sqrt(-(2x - 3)*(2x - 1)) + 1) ; [0.5, 1]
		/// </summary>
		static float EaseInOutCirc(float p)
		{
			if (p < 0.5f)
			{
				return 0.5f * (1 - (float)Math.Sqrt(1 - 4 * (p * p)));
			}
			else
			{
				return 0.5f * ((float)Math.Sqrt(-((2 * p) - 3) * ((2 * p) - 1)) + 1);
			}
		}

		/// <summary>
		/// Modeled after the overshooting cubic y = x^3-x*sin(x*pi)
		/// </summary>
		static double EaseInBack(double p)
		{
			return p * p * p - p * Math.Sin(p * PI);
		}

		/// <summary>
		/// Modeled after the overshooting cubic y = x^3-x*sin(x*pi)
		/// </summary>
		static float EaseInBack(float p)
		{
			return p * p * p - p * (float)Math.Sin(p * PI);
		}

		/// <summary>
		/// Modeled after overshooting cubic y = 1-((1-x)^3-(1-x)*sin((1-x)*pi))
		/// </summary>	
		static double EaseOutBack(double p)
		{
			double f = (1 - p);
			return 1 - (f * f * f - f * Math.Sin(f * PI));
		}

		/// <summary>
		/// Modeled after overshooting cubic y = 1-((1-x)^3-(1-x)*sin((1-x)*pi))
		/// </summary>	
		static float EaseOutBack(float p)
		{
			float f = (1 - p);
			return 1 - (f * f * f - f * (float)Math.Sin(f * PI));
		}

		/// <summary>
		/// Modeled after the piecewise overshooting cubic function:
		/// y = (1/2)*((2x)^3-(2x)*sin(2*x*pi))           ; [0, 0.5)
		/// y = (1/2)*(1-((1-x)^3-(1-x)*sin((1-x)*pi))+1) ; [0.5, 1]
		/// </summary>
		static double EaseInOutBack(double p)
		{
			if (p < 0.5)
			{
				double f = 2 * p;
				return 0.5 * (f * f * f - f * Math.Sin(f * PI));
			}
			else
			{
				double f = (1 - (2 * p - 1));
				return 0.5 * (1 - (f * f * f - f * Math.Sin(f * PI))) + 0.5;
			}
		}

		/// <summary>
		/// Modeled after the piecewise overshooting cubic function:
		/// y = (1/2)*((2x)^3-(2x)*sin(2*x*pi))           ; [0, 0.5)
		/// y = (1/2)*(1-((1-x)^3-(1-x)*sin((1-x)*pi))+1) ; [0.5, 1]
		/// </summary>
		static float EaseInOutBack(float p)
		{
			if (p < 0.5f)
			{
				float f = 2 * p;
				return 0.5f * (f * f * f - f * (float)Math.Sin(f * PI));
			}
			else
			{
				float f = (1 - (2 * p - 1));
				return 0.5f * (1 - (f * f * f - f * (float)Math.Sin(f * PI))) + 0.5f;
			}
		}

		/// <summary>
		/// Modeled after the damped sine wave y = sin(13pi/2*x)*Math.Pow(2, 10 * (x - 1))
		/// </summary>
		static double EaseInElastic(double p)
		{
			return Math.Sin(13 * HALFPI * p) * Math.Pow(2, 10 * (p - 1));
		}

		/// <summary>
		/// Modeled after the damped sine wave y = sin(13pi/2*x)*Math.Pow(2, 10 * (x - 1))
		/// </summary>
		static float EaseInElastic(float p)
		{
			return (float)Math.Sin(13 * HALFPI * p) * (float)Math.Pow(2, 10 * (p - 1));
		}

		/// <summary>
		/// Modeled after the damped sine wave y = sin(-13pi/2*(x + 1))*Math.Pow(2, -10x) + 1
		/// </summary>
		static double EaseOutElastic(double p)
		{
			return Math.Sin(-13 * HALFPI * (p + 1)) * Math.Pow(2, -10 * p) + 1;
		}

		/// <summary>
		/// Modeled after the damped sine wave y = sin(-13pi/2*(x + 1))*Math.Pow(2, -10x) + 1
		/// </summary>
		static float EaseOutElastic(float p)
		{
			return (float)Math.Sin(-13 * HALFPI * (p + 1)) * (float)Math.Pow(2, -10 * p) + 1;
		}

		/// <summary>
		/// Modeled after the piecewise exponentially-damped sine wave:
		/// y = (1/2)*sin(13pi/2*(2*x))*Math.Pow(2, 10 * ((2*x) - 1))      ; [0,0.5)
		/// y = (1/2)*(sin(-13pi/2*((2x-1)+1))*Math.Pow(2,-10(2*x-1)) + 2) ; [0.5, 1]
		/// </summary>
		static double EaseInOutElastic(double p)
		{
			if (p < 0.5)
			{
				return 0.5 * Math.Sin(13 * HALFPI * (2 * p)) * Math.Pow(2, 10 * ((2 * p) - 1));
			}
			else
			{
				return 0.5 * (Math.Sin(-13 * HALFPI * ((2 * p - 1) + 1)) * Math.Pow(2, -10 * (2 * p - 1)) + 2);
			}
		}

		/// <summary>
		/// Modeled after the piecewise exponentially-damped sine wave:
		/// y = (1/2)*sin(13pi/2*(2*x))*Math.Pow(2, 10 * ((2*x) - 1))      ; [0,0.5)
		/// y = (1/2)*(sin(-13pi/2*((2x-1)+1))*Math.Pow(2,-10(2*x-1)) + 2) ; [0.5, 1]
		/// </summary>
		static float EaseInOutElastic(float p)
		{
			if (p < 0.5f)
			{
				return 0.5f * (float)Math.Sin(13 * HALFPI * (2 * p)) * (float)Math.Pow(2, 10 * ((2 * p) - 1));
			}
			else
			{
				return 0.5f * (float)(Math.Sin(-13 * HALFPI * ((2 * p - 1) + 1)) * Math.Pow(2, -10 * (2 * p - 1)) + 2);
			}
		}

		static double EaseInBounce(double p)
		{
			return 1 - EaseOutBounce(1 - p);
		}

		static float EaseInBounce(float p)
		{
			return 1 - EaseOutBounce(1 - p);
		}

		static double EaseOutBounce(double p)
		{
			if (p < 4 / 11.0)
			{
				return (121 * p * p) / 16.0;
			}
			else if (p < 8 / 11.0)
			{
				return (363 / 40.0 * p * p) - (99 / 10.0 * p) + 17 / 5.0;
			}
			else if (p < 9 / 10.0)
			{
				return (4356 / 361.0 * p * p) - (35442 / 1805.0 * p) + 16061 / 1805.0;
			}
			else
			{
				return (54 / 5.0 * p * p) - (513 / 25.0 * p) + 268 / 25.0;
			}
		}

		static float EaseOutBounce(float p)
		{
			if (p < 4 / 11.0f)
			{
				return (121 * p * p) / 16.0f;
			}
			else if (p < 8 / 11.0f)
			{
				return (363 / 40.0f * p * p) - (99 / 10.0f * p) + 17 / 5.0f;
			}
			else if (p < 9 / 10.0f)
			{
				return (4356 / 361.0f * p * p) - (35442 / 1805.0f * p) + 16061 / 1805.0f;
			}
			else
			{
				return (54 / 5.0f * p * p) - (513 / 25.0f * p) + 268 / 25.0f;
			}
		}

		static double EaseInOutBounce(double p)
		{
			if (p < 0.5)
			{
				return 0.5 * EaseInBounce(p * 2);
			}
			else
			{
				return 0.5 * EaseOutBounce(p * 2 - 1) + 0.5;
			}
		}

		static float EaseInOutBounce(float p)
		{
			if (p < 0.5f)
			{
				return 0.5f * EaseInBounce(p * 2);
			}
			else
			{
				return 0.5f * EaseOutBounce(p * 2 - 1) + 0.5f;
			}
		}
	}
}
