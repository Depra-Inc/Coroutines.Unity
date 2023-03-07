using System.Collections;
using Depra.Coroutines.Runtime;

namespace Depra.Coroutines.Editor
{
    public sealed class EditorCoroutineHost : ICoroutineHost
    {
        public ICoroutine StartCoroutine(IEnumerator enumerator) =>
            new EditorCoroutineProxy(enumerator);

        public void StopCoroutine(ICoroutine coroutine) =>
            coroutine.Stop();
    }
}