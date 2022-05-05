using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintNumber : MonoBehaviour
{
    // Start is called before the first frame update
    ChangeColor changeColors;
    void Start()
    {
        spriteGenerator.OnButtonClicked += PrintNumbers;
        changeColors = FindObjectOfType<ChangeColor>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void PrintNumbers()
    {
             Debug.Log(changeColors.colorValue);
        
       
    }
    private void OnDisable()
    {
        spriteGenerator.OnButtonClicked -= PrintNumbers;
    }
}
