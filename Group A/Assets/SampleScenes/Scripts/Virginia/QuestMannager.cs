using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//test

public class QuestMannager : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("StartQuest"))
        {
            Quest quest = this.gameObject.AddComponent<Quest>();
            quest.SetQuestSteps(other.GetComponent<QuestStart>().QuestSteps);
            quest.QuestName = other.gameObject.GetComponent<QuestStart>().QuestName;
            quest.CurrentStep = 0;
            quest.QuestTextBox = GameObject.Find("PlayerQuestDisplay").GetComponent<Text>();
            quest.QuestTextBox.text = other.gameObject.GetComponent<QuestStart>().QuestName;
            Destroy(other.gameObject);
        }
    }

}
