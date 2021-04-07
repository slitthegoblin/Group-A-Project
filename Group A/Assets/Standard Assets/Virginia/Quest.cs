using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest : MonoBehaviour
{
    public string QuestName;
    private string[] QuestSteps;
    public int CurrentStep;
    public string QuestDisplay;
    public Text QuestTextBox;

    public bool QuestFinished;


    private void Start()
    {
        QuestDisplay = QuestSteps[CurrentStep];
    }
    public void SetQuestSteps(string[] input)
    {
        QuestSteps = input;
    }

    //test
    // Update is called once per frame

    private void OnTriggerEnter(Collider other)
    {
        if (QuestFinished) return;
        if (other.gameObject.GetComponent<QuestStep>())
        {
            if (other.gameObject.GetComponent<QuestStep>().Quest.Equals(QuestName))
            {
                Debug.Log("Found Quest Step");
                if (other.gameObject.GetComponent<QuestStep>().ThisStep == CurrentStep + 1)
                {
                    QuestDisplay = QuestSteps[other.gameObject.GetComponent<QuestStep>().ThisStep];
                    CurrentStep = other.gameObject.GetComponent<QuestStep>().ThisStep;
                    if (QuestTextBox != null) QuestTextBox.text = QuestSteps[CurrentStep];
                    Destroy(other.gameObject, 0.1f);
                }
            }

        }
        if (other.gameObject.GetComponent<QuestEnd>())
        {
            if (other.gameObject.CompareTag("QuestEnd"))
            {
                if (other.gameObject.GetComponent<QuestEnd>().LastStep == CurrentStep + 1)
                {
                    QuestDisplay = QuestSteps[other.gameObject.GetComponent<QuestEnd>().LastStep];
                    CurrentStep = other.gameObject.GetComponent<QuestEnd>().LastStep;
                    if (QuestTextBox != null) QuestTextBox.text = QuestSteps[CurrentStep];
                    QuestFinished = true;
                    Destroy(other.gameObject, 0.1f);
                }
            }
        }
    }
}
