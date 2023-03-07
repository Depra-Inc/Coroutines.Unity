using System.Collections;

namespace Depra.Coroutines.Runtime
{
    public interface ICoroutine
    {
        IEnumerator Enumerator { get; }
        
        void Start();
        
        void Stop();
    }
}