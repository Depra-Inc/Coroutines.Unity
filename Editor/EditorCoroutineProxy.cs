using System.Collections;
using Depra.Coroutines.Runtime;
using Unity.EditorCoroutines.Editor;

namespace Depra.Coroutines.Editor
{
    public sealed class EditorCoroutineProxy : ICoroutine
    {
        private EditorCoroutine _coroutine;

        public EditorCoroutineProxy(IEnumerator enumerator) =>
            Enumerator = enumerator;

        public IEnumerator Enumerator { get; }

        public bool Done => _coroutine == null;

        public void Start()
        {
            _coroutine = EditorCoroutineUtility.StartCoroutine(Enumerator, this);
        }

        public void Stop()
        {
            if (Done)
            {
                return;
            }

            EditorCoroutineUtility.StopCoroutine(_coroutine);
            _coroutine = null;
        }
    }
}