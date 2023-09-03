// SPDX-License-Identifier: Apache-2.0
// © 2023 Nikolay Melnikov <n.melnikov@depra.org>

using System;
using Depra.Coroutines.Entities;
using Unity.EditorCoroutines.Editor;

namespace Depra.Coroutines.Editor
{
	public sealed class EditorCoroutineProxy : ICoroutine
	{
		private EditorCoroutine _coroutine;

		public EditorCoroutineProxy(EditorCoroutine coroutine) =>
			_coroutine = coroutine ?? throw new ArgumentNullException(nameof(coroutine));

		public bool IsDone => _coroutine == null;

		public void Stop()
		{
			if (IsDone)
			{
				return;
			}

			EditorCoroutineUtility.StopCoroutine(_coroutine);
			_coroutine = null;
		}
	}
}