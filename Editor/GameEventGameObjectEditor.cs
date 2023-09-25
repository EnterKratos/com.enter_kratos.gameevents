using UnityEditor;
using UnityEngine;

namespace EnterKratos.Unity.GameEvents.Editor
{
    [CustomEditor(typeof(GameEventGameObject))]
    public class GameEventGameObjectEditor : UnityEditor.Editor
    {
        private GameObject _currentEventValue;

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            _currentEventValue = (GameObject)EditorGUILayout.ObjectField(
                "Event Value", _currentEventValue, typeof(GameObject), allowSceneObjects: true
            );

            if (GUILayout.Button("Raise Event"))
            {
                ((GameEventGameObject)target)?.Raise(_currentEventValue);
            }
        }
    }
}