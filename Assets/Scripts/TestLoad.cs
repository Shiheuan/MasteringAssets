using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class TestLoad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Addressables.InstantiateAsync("Cube");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
