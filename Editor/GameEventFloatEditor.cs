using UnityEditor;
using UnityEngine;

namespace EnterKratos.Unity.GameEvents.Editor
{
    [CustomEditor(typeof(GameEventFloat))]
    public class GameEventFloatEditor : UnityEditor.Editor
    {
        private float _currentEventValue;

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            _currentEventValue = EditorGUILayout.FloatField("Event Value", _currentEventValue);

            if (GUILayout.Button("Raise Event"))
            {
                ((GameEventFloat)target)?.Raise(_currentEventValue);
            }
        }
    }
}