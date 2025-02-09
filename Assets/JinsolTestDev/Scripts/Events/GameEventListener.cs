using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// 
/// 게임이벤트를 추적하는 기능
/// 
/// - 정진솔
/// </summary>

namespace Jinsol
{
    public class GameEventListener : MonoBehaviour
    {
        public GameEvent gameEvent;
        public UnityEvent response; // 함수를 직접 호출할 수 있게 해주는 유니티 기능

        private void OnEnable()
        {
            gameEvent.RegisterListener(this);
        }

        private void OnDisable()
        {
            gameEvent.UnregisterListener(this);
        }

        public void OnEventRaised()
        {
            response.Invoke(); // 이벤트가 송출될 때 호출
        }
    }
}
