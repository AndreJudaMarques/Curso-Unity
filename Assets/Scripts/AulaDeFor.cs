using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AulaDeFor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int contador;
        //(comando de inicializacao; condicao; incremento ou decremento){}
        for(contador = 0; contador < 10; contador++)
        {
            Debug.Log(contador);
        }
        Debug.Log("O valor final do contador é: " + contador);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
