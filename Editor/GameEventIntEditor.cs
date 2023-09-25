using UnityEditor;
using UnityEngine;

namespace EnterKratos.Unity.GameEvents.Editor
{
    [CustomEditor(typeof(GameEventInt))]
    public class GameEventIntEditor : UnityEditor.Editor
    {
        private int _currentEventValue;

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            _currentEventValue = EditorGUILayout.IntField("Event Value", _currentEventValue);

            if (GUILayout.Button("Raise Event"))
            {
                ((GameEventInt)target)?.Raise(_currentEventValue);
            }
        }
    }
}