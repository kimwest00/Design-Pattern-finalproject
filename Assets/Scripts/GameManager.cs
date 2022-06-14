using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TalkManager talkManager;
   
    public GameObject talkPanel;
    /*public GameObject scanObject;*/
    public Text talkText;
    /*public bool isAction;*/
    public int id=0;
    public int talkIndex=0;
    public static GameManager instance = null;
    public GameObject StartButton;

    // Start is called before the first frame update
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    void Start()
    {
        
        talkPanel.SetActive(true);
        Talk(id, talkIndex);
        /*GameLoad();*/
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))//spacebar
        {
            talkIndex++;
            Talk(id, talkIndex);
        }
        if (talkIndex == 5)
        {
            StartButton.SetActive(true);
            
        }
        else if(talkIndex == 6){

            talkPanel.SetActive(false);
        }
    }
    
/*public void Action(GameObject scanObj)
    {
        isAction = true;
        talkPanel.SetActive(true);
        scanObject = scanObj;
        talkText.text = "이것의 이름은" + scanObject.name + "이라고한다";
        //QuestPanel.SetActive(isQuest);

    }*/
void Talk(int id,int talkIndex)
  {
        string talkData;
        if (id == 0)
        {
            talkData = talkManager.GetTalk(0, talkIndex);
            if (talkData == null)
            {
                talkIndex = 0;
                return;
            }
            
            talkText.text = talkData;
            
               
               
          
            
        }
        else
        {
            print("wrong");
        }
    /*if (talkData == null)
    {
        talkIndex = 0;
        return;
    }
    
    talkText.text = talkData;
    if (id == 0)
        {
            talkIndex++;
        }*/
            
    
    
    
}
}
