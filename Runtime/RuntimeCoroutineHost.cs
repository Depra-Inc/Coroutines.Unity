using System.Collections;
using Depra.Coroutines.Domain.Entities;
using UnityEngine;

namespace Depra.Coroutines.Unity.Runtime
{
    public sealed class RuntimeCoroutineHost : MonoBehaviour, ICoroutineHost
    {
        public new ICoroutine StartCoroutine(IEnumerator process)
        {
	        var coroutine = base.StartCoroutine(process);
	        return new RuntimeCoroutine(this, coroutine);
        }

        public void StopCoroutine(ICoroutine coroutine) => coroutine.Stop();
    }
}