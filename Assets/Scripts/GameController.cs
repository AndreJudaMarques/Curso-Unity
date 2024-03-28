using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Player amigo1 = new Player();
        // Player amigo2 = new Player();
        // Player amigo3 = new Player();

        // Debug.Log(Player.contadorAmigos);
        Debug.Log(Player.Adicionar(5,5));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
