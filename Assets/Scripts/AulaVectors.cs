using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AulaVectors : MonoBehaviour
{

    public Vector2 pos; //usado em jogos 2d
    public Vector3 pos2; // usado em 3d, com profundidade, eixo Z

    // Start is called before the first frame update
    void Start()
    {
        pos2 = new Vector3(1f, 1f, 1f);

        transform.position = pos2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
