using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej01 : MonoBehaviour
{
    public int num1 = 0;
    public int num2 = 0;

    // Start is called before the first frame update
    void Start()
    {
        if (num1 == num2)
        {
            Debug.Log("Ambos numeros son iguales");
        }
        else
        {
            Debug.Log("Los numeros no son iguales");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
