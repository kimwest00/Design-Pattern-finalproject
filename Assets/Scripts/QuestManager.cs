using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class QuestManager

{
    public int questId;
    public int questActionIndex;//����Ʈ ��ȭ����
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
        questList.Add(10, new QuestData("ù ���ε� �湮"
                                        , new int[] { 1000, 2000 }));
        questList.Add(20, new QuestData("�絵 �����ֱ�"
                                        , new int[] { 10, 2000 }));
        questList.Add(30, new QuestData("����Ʈ ��Ŭ����"
                                        , new int[] { 0 }));
    }

    public int GetQuestTalkIndex(int id)
    {

        return questId + questActionIndex;

    }
    //�����ε����� �Ű������� ���� �Լ�ȣ��
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
