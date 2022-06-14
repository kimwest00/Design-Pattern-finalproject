using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class QuestManager

{
    public int questId;
    public int questActionIndex;//퀘스트 대화순서
    public GameObject[] questObject;
    Dictionary<int, QuestData> questList;



    // Start is called before the first frame update
    void Start()
    {
        questList = new Dictionary<int, QuestData>();
        GenerateData();
    }

    // Update is called once per frame
    void GenerateData()
    {
        questList.Add(10, new QuestData("첫 무인도 방문"
                                        , new int[] { 1000, 2000 }));
        questList.Add(20, new QuestData("루도 도와주기"
                                        , new int[] { 10, 2000 }));
        questList.Add(30, new QuestData("퀘스트 올클리어"
                                        , new int[] { 0 }));
    }

    public int GetQuestTalkIndex(int id)
    {

        return questId + questActionIndex;

    }
    //오버로딩으로 매개변수에 따른 함수호출
    public string CheckQuest(int id)
    {
        //Control Quest Object
        if (id == questList[questId].npcId[questActionIndex])
            questActionIndex++;

        ControlObject();

        if (questActionIndex == questList[questId].npcId.Length)
            NextQuest();

        return questList[questId].questName;
    }
    public string CheckQuest()
    {
        //Quest Name
        return questList[questId].questName;
    }
    void NextQuest()
    {
        questId += 10;
        questActionIndex = 0;
    }
    public void ControlObject()
    {
        switch (questId)
        {
            case 10:
                if (questActionIndex == 2)
                    questObject[0].SetActive(true);
                break;
            case 20:
                if (questActionIndex == 0)
                    questObject[0].SetActive(true);
                else if (questActionIndex == 1)

                    questObject[0].SetActive(false);
                break;
        }
    }
}
