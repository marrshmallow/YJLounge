namespace TestingNewFeature
{
using UnityEngine;
//using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.Playables;

public class DialogueManager1 : MonoBehaviour
{
    private Queue<string> sentences;
    public TextMeshProUGUI showName;
    //public TextMeshProUGUI showDialogue;
    public DialogueButton dButton; // 대화창 계속 버튼
    [SerializeField] private PlayableDirector director;
    #region 테스트
    [SerializeField] private Typewriter typewriter;
    #endregion

    private void Start()
    {
        sentences = new Queue<string>();
        dButton.standby = false;
    }

    public void StartDialogue(Dialogue dialogue)
    {
        sentences.Clear();
        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence); // 첫번째 문장을 큐에 추가
        }
        
        DisplayNextSentence();
    }
        
    public void DisplayNextSentence() // Continue 버튼
    {
        if(sentences.Count == 0)
        {
            dButton.standby = true;
            return;
        }

        string sentence = sentences.Dequeue(); // 대기열에서 제거
        StopAllCoroutines();
        typewriter.PrepareText(gameObject);
        //StartCoroutine(TypeSentence(sentence));
    }

/*     private IEnumerator TypeSentence(string sentence)
    {
        showDialogue.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            showDialogue.text += letter;
            yield return null;
        }
    } */
}

}