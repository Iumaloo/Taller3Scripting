using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Mastermain : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Escena_Main()
    {
        SceneManager.LoadScene("Master");
    }
    public void Escena_uno ()
    {
        SceneManager.LoadScene("Punto 1");
    }
    public void Escena_dos()
    {
        SceneManager.LoadScene("Punto 2");
    }
    public void Escena_tres()
    {
        SceneManager.LoadScene("Punto 3");
    }
    public void Escena_cuatro()
    {
        SceneManager.LoadScene("Punto 4");
    }
    public void Salir()
    {
        Application.Quit();
    }

}
