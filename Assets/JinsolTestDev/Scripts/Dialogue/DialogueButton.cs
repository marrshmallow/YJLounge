using UnityEngine;
using UnityEngine.Playables;

/// <summary>
/// 플레이어가 NPC와 대화 중일 때, 다음 컷씬(플레이어블 에셋)으로 넘어가야 할 경우
/// 현재 재생중인 컷씬을 종료하고 다음에 컷씬을 재생하는 기능
/// - 정진솔
/// </summary>

namespace Jinsol
{
    public class DialogueButton : MonoBehaviour
    {
        [SerializeField] private PlayableDirector director;
        [SerializeField] private PlayableAsset nextTimeline;
        public bool standby = false; // 다음 컷씬으로 넘어갈 준비가 되었으면 true (이 상태에서 대화창 버튼을 누르면 다음 씬 재생)

        void Update()
        {
            if (standby)
            {
                director.extrapolationMode = DirectorWrapMode.None;
                Debug.Log("Director stopped");
                director.Play(nextTimeline);
                Debug.Log("Playing nextTimeline...");
            }
        }
    }
}
