using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EventManager : MonoBehaviour
{
   
    //public delegate void Action();
    public static event Action OnButtonClicked;

  
    public void ClickAction()
    {
        
    }
   
    void Start()
    {
        
    }
  
    // Update is called once per frame
   private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("wepaa");
            if (OnButtonClicked != null)
            {
                OnButtonClicked();
               
            }
           
        }
    }
}
