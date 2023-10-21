using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(GameEvent))]
public class GameEventEditor : Editor
{
	private SerializedProperty _gameEvent;

	public override void OnInspectorGUI() {
		if (GUILayout.Button("Raise")) {
			((GameEvent)target).Raise();
		}
	}
}
