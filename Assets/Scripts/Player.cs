using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;

public class Player : MonoBehaviour
{
    //variavel estatica é compartilhada com todas as instancias da classe
    // public static int contadorAmigos;

    // public Player()
    // {
    //     contadorAmigos++;
    
    // }

    public static int Adicionar(int num1, int num2)
    {
        return num1 + num2;
    }
    
}
