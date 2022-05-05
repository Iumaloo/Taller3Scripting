using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    Renderer cubeRenderer;

    [SerializeField] private Color newColor;
    [SerializeField] private Color[] colors = new Color[4];
  
    public int colorValue;
  
    void Start()
    {

        spriteGenerator.OnButtonClicked += ChangeColors;
        cubeRenderer = GetComponent<Renderer>();
        colorValue = 0;
    }
    private void ChangeColors()
    {
      
       
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
