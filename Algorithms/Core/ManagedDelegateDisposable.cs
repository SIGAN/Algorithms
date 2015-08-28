using System;

namespace Algorithms.Core
{
	/// <summary>
	/// Disposes managed resources via disposer delegate
	/// </summary>
	public class ManagedDelegateDisposable : IDisposable
	{
		private readonly Action _disposer;

		/// <summary>
		/// Creates an instance of class that disposes managed resources via <paramref name="disposer"/> delegate
		/// </summary>
		/// <param name="disposer"></param>
		public ManagedDelegateDisposable(Action initializer, Action disposer)
		{
			_disposer = disposer;

			initializer();
		}

		private bool wasDisposed = false;

		protected virtual void Dispose(bool disposing)
		{
			if (!wasDisposed)
			{
				if (disposing)
					_disposer();

				wasDisposed = true;
			}
		}

		public void Dispose() =>
			Dispose(true);
	}
}
