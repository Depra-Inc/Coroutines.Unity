using System.Collections;
using Depra.Coroutines.Domain.Entities;
using Unity.EditorCoroutines.Editor;

namespace Depra.Coroutines.Unity.Editor
{
    public sealed class EditorCoroutineHost : ICoroutineHost
    {
        public ICoroutine StartCoroutine(IEnumerator process) 
        {
	        var coroutine = EditorCoroutineUtility.StartCoroutine(process, this);
	        return new EditorCoroutineProxy(coroutine);
        }

        public void StopCoroutine(ICoroutine coroutine) => coroutine.Stop();
    }
}