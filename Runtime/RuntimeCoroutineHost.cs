﻿// SPDX-License-Identifier: Apache-2.0
// © 2023 Nikolay Melnikov <n.melnikov@depra.org>

using System.Collections;
using Depra.Coroutines.Entities;
using UnityEngine;

namespace Depra.Coroutines.Runtime
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