using UnityEngine;
using UnityEngine.Events;

namespace EnterKratos.Unity.GameEvents.Listeners
{
    public class GameEventListenerGameObject : GameEventListener<GameObject>
    {
        public GameEventGameObject typedEvent;

        [SerializeField]
        private UnityEvent<GameObject> typedResponse;

        private void Awake()
        {
            Event = typedEvent;
            Response = typedResponse;
        }
    }
}