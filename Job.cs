using System;
using System.Collections;
using System.Threading;

namespace Exodrifter.Anchor
{
	public class Job
	{
		private readonly Thread thread;

		public bool Done { get; private set; }

		public Job(Action action)
		{
			Done = false;
			thread = new Thread(new ThreadStart(() => {
				action();
				Done = true;
			}));
			thread.Start();
		}

		public IEnumerator Wait()
		{
			while (!Done)
			{
				yield return null;
			}
		}
	}
}
