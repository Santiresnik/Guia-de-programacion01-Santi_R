using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej5 : MonoBehaviour
{
    public int num1, num2;
    // Start is called before the first frame update
    void Start()
    {
        if (num2 != 0)
        {
            int resultado = num1 / num2;
            Debug.Log(num1 + "/" + num2 + " = " + resultado);
        }
        else
        {
            Debug.Log("No se puede dividir por cero.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
