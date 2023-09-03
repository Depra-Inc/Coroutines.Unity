using System.Collections;
using Depra.Coroutines.Domain.Entities;
using Unity.EditorCoroutines.Editor;

namespace Depra.Coroutines.Unity.Editor
{
	public sealed class EditorCoroutineHost : ICoroutineHost
	{
		public ICoroutine StartCoroutine(IEnumerator process) => new EditorCoroutineProxy(
			EditorCoroutineUtility.StartCoroutine(process, this));

		public void StopCoroutine(ICoroutine coroutine) => coroutine.Stop();
	}
}