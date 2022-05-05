using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spriteGenerator : MonoBehaviour
{
    private static spriteGenerator instance;
    public delegate void Action();
    public event Action OnButtonClicked;

    public static spriteGenerator Instance
    {
        get
        {
            return instance;
        }
    }
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else Destroy(gameObject);
    }
    public void ClickAction()
    {
        if(Input.GetMouseButtonDown(0))
            {
             OnButtonClicked(); 
            }
    }
   
    void Start()
    {
        
    }
  
    // Update is called once per frame
    void Update()
    {
        
    }
}
