using UnityEngine;
using UnityEngine.Events;

namespace EnterKratos.Unity.GameEvents.Listeners
{
    public class GameEventListenerString : GameEventListener<string>
    {
        [SerializeField]
        private GameEventString typedEvent;

        [SerializeField]
        private UnityEvent<string> typedResponse;

        private void Awake()
        {
            Event = typedEvent;
            Response = typedResponse;
        }
    }
}