// SPDX-License-Identifier: Apache-2.0
// © 2023 Nikolay Melnikov <n.melnikov@depra.org>

using System.Collections;
using Depra.Coroutines.Entities;
using Unity.EditorCoroutines.Editor;

namespace Depra.Coroutines.Editor
{
	public sealed class EditorCoroutineHost : ICoroutineHost
	{
		public ICoroutine StartCoroutine(IEnumerator process) => new EditorCoroutineProxy(
			EditorCoroutineUtility.StartCoroutine(process, this));

		public void StopCoroutine(ICoroutine coroutine) => coroutine.Stop();
	}
}