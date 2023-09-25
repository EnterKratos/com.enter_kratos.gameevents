using UnityEngine;
using UnityEngine.Events;

namespace EnterKratos.Unity.GameEvents.Listeners
{
    public class GameEventListener : MonoBehaviour
    {
        [SerializeField]
        private GameEvent @event;

        [SerializeField]
        private UnityEvent response;

        private void OnEnable() => @event.RegisterListener(this);

        private void OnDisable() => @event.UnregisterListener(this);

        public void OnEventRaised() => response.Invoke();
    }

    public abstract class GameEventListener<T> : MonoBehaviour
    {
        protected GameEvent<T> Event;

        protected UnityEvent<T> Response;

        private void OnEnable() => Event.RegisterListener(this);

        private void OnDisable() => Event.UnregisterListener(this);

        public virtual void OnEventRaised(T value) => Response.Invoke(value);
    }
}