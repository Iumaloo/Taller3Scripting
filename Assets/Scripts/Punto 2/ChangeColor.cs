using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Renderer cubeRenderer;
    public GameObject cube;
    private Color[] colors = new Color[4];
     void OnEnable()
    {
        spriteGenerator.Instance.OnButtonClicked += ChangeColors;
    }
    void Start()
    {
        cubeRenderer = cube.GetComponent<Renderer>();
        
    }
    void ChangeColors()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
