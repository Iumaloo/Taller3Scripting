using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Factory : MonoBehaviour, IFactory
{
    [SerializeField]
    GameObject Template;

    public GameObject GetNewObject()
    {
        GameObject obj = Instantiate(Template, RandomizePosition(), Quaternion.identity);
        return obj;
    }

    Vector2 RandomizePosition()
    {
        return new Vector2(Random.Range(-4, 5), Random.Range(-4, 5));
    }
}
