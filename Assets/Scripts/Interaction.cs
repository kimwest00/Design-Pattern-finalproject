using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 vec = Camera.main.ScreenToWorldPoint(Input.mousePosition); 
            RaycastHit2D hit = Physics2D.Raycast(vec, Vector2.zero);
            

            if (hit.collider != null) 
            {
                GameObject rayObj = hit.collider.gameObject;
                if (rayObj.layer == LayerMask.NameToLayer("Object"))
                {
                    if (rayObj.name == "Door")
                    {
                        
                        Debug.Log(rayObj);
                    }
                   
                }
            }
        }
    }


}
