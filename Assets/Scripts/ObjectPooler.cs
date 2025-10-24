using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    public static ObjectPooler Instance;

    void Awake()
    {
        Instance = this;
    }
    
    void Start()
    {
        
    }
}
