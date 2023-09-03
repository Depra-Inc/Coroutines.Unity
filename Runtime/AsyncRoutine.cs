// SPDX-License-Identifier: Apache-2.0
// © 2023 Nikolay Melnikov <n.melnikov@depra.org>

using System.Collections;
using UnityEngine;

namespace Depra.Coroutines.Runtime
{
	public static class AsyncRoutine
	{
		public static IEnumerator WaitSeconds(float seconds)
		{
			var startTime = Time.realtimeSinceStartup;
			while (Time.realtimeSinceStartup - startTime < seconds)
			{
				yield return null;
			}
		}
	}
}