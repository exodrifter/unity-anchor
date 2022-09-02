using System;
using System.Collections;
using System.Threading;

namespace Exodrifter.Anchor
{
	public class Job
	{
		private readonly Thread thread;

		/// <summary>
		/// The exception from the thread, if an exception was raised.
		/// </summary>
		public Exception Exception
		{
			get { return exception; }
		}
		private Exception exception;

		/// <summary>
		/// True if the thread finished execution.
		/// </summary>
		public bool Done { get; private set; }

		public Job(Action action)
		{
			Done = false;
			thread = new Thread(new ThreadStart(() => {
				try
				{
					action();
				}
				catch (Exception e)
				{
					exception = e;
				}
				finally
				{
					Done = true;
				}
			}));
			thread.Start();
		}

		public IEnumerator Wait()
		{
			while (!Done)
			{
				yield return null;
			}

			if (exception != null)
			{
				throw exception;
			}
		}
	}
}
