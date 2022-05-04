using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryManager : MonoBehaviour
{
    FactoryManager instance;

    Factory cubeFactory;
    Factory sphereFactory;
    Factory capsuleFactory;

    Factory selectedFactory;

    public FactoryManager Instance { get => instance; }

    private void Awake()
    {
        if(instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        cubeFactory = GetComponent<CubeFactory>();
        sphereFactory = GetComponent <SphereFactory>();
        capsuleFactory = GetComponent<CapsuleFactory>();
        selectedFactory = cubeFactory;
    }

    public void SelectCubeFactory()
    {
        selectedFactory = cubeFactory;
    }

    public void SelectSphereFactory()
    {
        selectedFactory = sphereFactory;
    }

    public void SelectCapsuleFactory()
    {
        selectedFactory = capsuleFactory;
    }

    public void CreateObject()
    {
        selectedFactory.GetNewObject();
    }

}
