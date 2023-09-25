using UnityEngine;
using UnityEngine.Events;

namespace EnterKratos.Unity.GameEvents.Listeners
{
    public class GameEventListenerInt : GameEventListener<int>
    {
        [SerializeField]
        private GameEventInt typedEvent;

        [SerializeField]
        private UnityEvent<int> typedResponse;

        private void Awake()
        {
            Event = typedEvent;
            Response = typedResponse;
        }
    }
}