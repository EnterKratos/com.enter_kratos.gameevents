using UnityEditor;
using UnityEngine;

namespace EnterKratos.Unity.GameEvents.Editor
{
    [CustomEditor(typeof(GameEvent))]
    public class GameEventEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            if (GUILayout.Button("Raise Event"))
            {
                ((GameEvent)target)?.Raise();
            }
        }
    }
}
