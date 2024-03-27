using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AulaLista : MonoBehaviour
{
    public List<string> tiposInimigos = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        tiposInimigos.Add("Orc");
        tiposInimigos.Add("Elfo");
        tiposInimigos.Add("Anoes");

        //tiposInimigos.Clear(); limpa a lista
        //tiposInimigos.Contains("Orc"); verifica se constem a string citada, if tiposInimigos.Contains("Orc")
        tiposInimigos.Insert(0, "Lobos"); // insere na posicao o item

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
