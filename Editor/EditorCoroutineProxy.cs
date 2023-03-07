using Depra.Coroutines.Domain.Entities;
using Unity.EditorCoroutines.Editor;

namespace Depra.Coroutines.Unity.Editor
{
    public sealed class EditorCoroutineProxy : ICoroutine 
    {
        private EditorCoroutine _coroutine;

        public EditorCoroutineProxy(EditorCoroutine coroutine) => 
	        _coroutine = coroutine;
        
        public bool IsDone => _coroutine == null;
        
        public void Stop()
        {
            if (IsDone)
            {
                return;
            }

            EditorCoroutineUtility.StopCoroutine(_coroutine);
            _coroutine = null;
        }
    }
}