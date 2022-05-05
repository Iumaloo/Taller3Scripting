using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    Renderer cubeRenderer;

    
    private Color[] colors = new Color[4];
    Color a = new Color(0, 0, 1);
    Color r = new Color(1, 0, 0);
    Color m = new Color(1, 0, 1);
    Color v = new Color(0.1f, 1, 0, 1);
    public int colorValue;
  
    void Start()
    {

        spriteGenerator.OnButtonClicked += ChangeColors;
        cubeRenderer = GetComponent<Renderer>();
        colorValue = 0;
    }
    private void ChangeColors()
    {
      
        a = colors[0];
        r = colors[1];
        m = colors[2];
        v = colors[3];
        colorValue++;
        if (colorValue > 3)
        {
            colorValue = 0;
        }
        cubeRenderer.material.color = colors[colorValue];

    }
    private void OnDisable()
    {
        spriteGenerator.OnButtonClicked -= ChangeColors;
    }
    // Update is called once per frame
    void Update()
    {
       
    }
}
