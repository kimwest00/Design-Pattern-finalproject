using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkManager : MonoBehaviour
{
    Dictionary<int, string[]> talkData;
    
    // Start is called before the first frame update
   
    void Awake()
    {
        talkData = new Dictionary<int, string[]>();
       
        GenerateData();

    }

    // Update is called once per frame
    void GenerateData()
    {
        talkData.Add(0, new string[]{"�� 20�й� ��ξ���..\n(space�ٸ� �����ּ���!)",
        "���õ� ���������� ���� �����ִ�",
        "�̴�� ���ֵ� ���ϰ� \n�������ϴٰ� �����ع����Ű���...",
        "�ҹ��� ���ϸ� ���濡 \n������ ������ �ִٰ��Ѵ�..",
        "�̰� ã�Ƽ� Ż���ϰ� �ູ������..!",
        "���� ���� ã�ƺ���?",
        "�켱 ������ Ž���غ���(������Ʈ�� Ŭ���ϱ�)",
        });
       
        /*//Quest Talk
        talkData.Add(10 + 1000, new string[] {"�ȳ�?:0",
                                            "���ε��� �°� ȯ���ؤ���:1",
                                            "�� ���� �ִ� �絵���� �ѹ� ���� �ɾ��?:0"});
        talkData.Add(11 + 2000, new string[] {"������������ �絵��:0",
                                            "�̰��� ó���Ա���?:1",
                                            "���� �����ٰ� �ִµ�..:0"
                                            ,"�����ִ� ���� �����ٷ�?:1"});
        talkData.Add(20 + 1000, new string[] {"���� ����İ�?:3",
                                            "�������� �ٷ���..:2",
                                            "�ؿ� �� ��������:1",});
        talkData.Add(20 + 2000, new string[] {"ã���� ���� ������:1"
                                           ,});
        talkData.Add(20 + 10, new string[] { "���� �߰��ߴ�", });
        talkData.Add(21 + 2000, new string[] { "ã�ұ���!����:2", });*/
      

    }
    public string GetTalk(int id, int talkIndex)
    {
        /*if (!talkData.ContainsKey(id))
        {
            if (!talkData.ContainsKey(id - id % 10))
                return GetTalk(id - id % 100, talkIndex);//Get First Talk
            else
                return GetTalk(id - id % 10, talkIndex);//Get First Quest Talk 
        }*/

        if (talkIndex == talkData[id].Length)
            return null;
        else
            return talkData[id][talkIndex];

    }

}
