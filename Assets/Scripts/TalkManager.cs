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
        talkData.Add(0, new string[]{"나 20학번 김부엉이..\n(space바를 눌러주세요!)",
        "오늘도 과제때문에 밤을 새고있다",
        "이대론 연애도 못하고 \n과제만하다가 졸업해버릴거같아...",
        "소문에 의하면 과방에 \n전설의 족보가 있다고한다..",
        "이걸 찾아서 탈출하고 행복해지자..!",
        "나와 같이 찾아볼래?",
        "우선 과방을 탐색해보자(오브젝트들 클릭하기)",
        });
       
        /*//Quest Talk
        talkData.Add(10 + 1000, new string[] {"안녕?:0",
                                            "무인도에 온걸 환영해ㅎㅎ:1",
                                            "내 옆에 있는 루도한테 한번 말을 걸어볼래?:0"});
        talkData.Add(11 + 2000, new string[] {"ㅎㅇㅎㅇ내가 루도야:0",
                                            "이곳에 처음왔구나?:1",
                                            "그좀 도와줄게 있는데..:0"
                                            ,"저기있는 꽃좀 갖다줄래?:1"});
        talkData.Add(20 + 1000, new string[] {"꽃이 어딨냐고?:3",
                                            "누구한테 줄려고..:2",
                                            "밑에 쭉 내려가봐:1",});
        talkData.Add(20 + 2000, new string[] {"찾으면 꼭꼭 갖다줘:1"
                                           ,});
        talkData.Add(20 + 10, new string[] { "꽃을 발견했다", });
        talkData.Add(21 + 2000, new string[] { "찾았구나!고마워:2", });*/
      

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
