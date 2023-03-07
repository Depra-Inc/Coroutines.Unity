using System.Collections;

namespace Depra.Coroutines.Runtime
{
    public interface ICoroutineHost
    {
        ICoroutine StartCoroutine(IEnumerator coroutine);

        void StopCoroutine(ICoroutine coroutine);
    }
}