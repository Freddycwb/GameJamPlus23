using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class GameEvent : ScriptableObject
{
	private List<GameEventListener> listeners = new List<GameEventListener>();

	public void Raise() {
		for (int i = 0; i < listeners.Count; ++i) {
			listeners[i].OnEventRaised();
		}
	}

	public void Listen(GameEventListener listener) {
		listeners.Add(listener);
	}

	public void StopListening(GameEventListener listener) {
		listeners.Remove(listener);
	}
}
