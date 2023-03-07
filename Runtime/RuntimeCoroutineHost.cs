using System.Collections;
using UnityEngine;

namespace Depra.Coroutines.Runtime
{
    public sealed class RuntimeCoroutineHost : MonoBehaviour, ICoroutineHost
    {
        public new ICoroutine StartCoroutine(IEnumerator coroutine)
        {
            var coroutineProxy = new RuntimeCoroutine(this, coroutine);
            coroutineProxy.Start();
            return coroutineProxy;
        }

        public void StopCoroutine(ICoroutine coroutine) => 
            coroutine.Stop();

        internal Coroutine StartCoroutineInternal(IEnumerator enumerator) => 
            base.StartCoroutine(enumerator);
    }
}