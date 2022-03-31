using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej2 : MonoBehaviour
{
    int num1 = 4;
    int num2 = 5;

    // Start is called before the first frame update
    void Start()
    {
        int suma = num1 + num2;
        int producto = num1 * num2;

        Debug.Log(suma +" es la suma de 4 y 5 y " +producto + " es su producto");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
