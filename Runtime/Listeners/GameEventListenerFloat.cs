using UnityEngine;
using UnityEngine.Events;

namespace EnterKratos.Unity.GameEvents.Listeners
{
    public class GameEventListenerFloat : GameEventListener<float>
    {
        public GameEventFloat typedEvent;

        [SerializeField]
        private UnityEvent<float> typedResponse;

        private void Awake()
        {
            Event = typedEvent;
            Response = typedResponse;
        }
    }
}