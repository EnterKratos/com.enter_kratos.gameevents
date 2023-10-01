using UnityEditor;
using UnityEngine;

namespace EnterKratos.Unity.GameEvents.Editor
{
    [CustomEditor(typeof(GameEventString))]
    public class GameEventStringEditor : UnityEditor.Editor
    {
        private string _currentEventValue;

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            _currentEventValue = EditorGUILayout.TextField("Event Value", _currentEventValue);

            if (GUILayout.Button("Raise Event"))
            {
                ((GameEventString)target)?.Raise(_currentEventValue);
            }
        }
    }
}