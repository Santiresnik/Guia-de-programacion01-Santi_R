using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej4 : MonoBehaviour
{
    public int num1, num2;
    // Start is called before the first frame update
    void Start()
    {
        int resultado = num1 + num2;
        Debug.Log("La suma entre " + num1 + " y " + num2 + " es: " + resultado);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
