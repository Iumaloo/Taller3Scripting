using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    CubePool cubePool;
    SpherePool spherePool;
    CapsulePool capsulePool;
    Pool selectedPool;

    int poolIndex;
    private void Start()
    {
        cubePool = GetComponent<CubePool>();
        spherePool = GetComponent<SpherePool>();
        capsulePool = GetComponent<CapsulePool>();

        selectedPool = cubePool;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Rigidbody bullet = selectedPool.GetBullet();
            bullet.transform.position = transform.position;
        }

        if (Input.GetMouseButtonDown(1))
        {
            ChangePool();
        }
    }

    void ChangePool()
    {
        poolIndex++;

        if(poolIndex > 3)
            poolIndex = 0;

        switch (poolIndex)
        {
            case 0: selectedPool = cubePool;
                break;
            case 1: selectedPool = spherePool;
                break ; 
            case 2: selectedPool = capsulePool;
                break;
        }
    }
}
