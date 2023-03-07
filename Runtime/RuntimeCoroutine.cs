using System.Collections;
using UnityEngine;

namespace Depra.Coroutines.Runtime
{
    public sealed class RuntimeCoroutine : ICoroutine
    {
        private readonly RuntimeCoroutineHost _host;
        private Coroutine _coroutine;

        public RuntimeCoroutine(RuntimeCoroutineHost host, IEnumerator enumerator)
        {
            _host = host;
            Enumerator = enumerator;
        }

        public IEnumerator Enumerator { get; }

        public bool Done => _coroutine == null;

        public void Start()
        {
            _coroutine = _host.StartCoroutineInternal(Enumerator);
        }

        public void Stop()
        {
            if (Done)
            {
                return;
            }
            
            _host.StopCoroutine(_coroutine);
            _coroutine = null;
        }
    }
}