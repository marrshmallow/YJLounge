using System;

/// <summary>
/// 퀘스트 진행과 관련한 이벤트를 관리해주는 스크립트
/// - 정진솔
/// </summary>

namespace Jinsol
{
    public class QuestEvents
    {
        public event Action<string> onStartQuest; // 퀘스트 수락했으면

        public void StartQuest(string id) // 퀘스트 시작
        {
            if (onStartQuest != null)
                onStartQuest(id);
        }

        public event Action<string> onProceedQuest; // 다음 퀘스트로 진행하면
        public void ProceedQuest(string id)
        {
            if (onProceedQuest != null)
                onProceedQuest(id);
        }

        public event Action<string> onCompleteQuest; // 퀘스트 완료
        public void CompleteQuest(string id)
        {
            if (onCompleteQuest != null)
            {
                onCompleteQuest(id);
            }
        }

        public event Action<Quest> onQuestStateChange; // 퀘스트 상태변화 있으면
        public void QuestStateChange(Quest quest)
        {
            onQuestStateChange?.Invoke(quest);
        }

        public event Action<string, int, QuestStepState> onQuestStepStateChange; // 퀘스트 속의 단계의 상태변화 있으면
        public void QuestStepStateChange(string id, int stepIndex, QuestStepState questStepState)
        {
            if (onQuestStepStateChange != null)
                onQuestStepStateChange(id, stepIndex, questStepState);
        }
    }
}
