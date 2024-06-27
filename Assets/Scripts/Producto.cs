using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Producto : MonoBehaviour
{
    public GameObject[] Productos;
    public int[] Precios = {10, 20, 15, 8, 23, 16, 31, 9, 6, 14, 12, 19, 16, 29, 21, 26, 28, 25, 4};
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    GameObject Selector()
    {
        Random.Range(-1, 18)
    }
}
