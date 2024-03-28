using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AulaGetComponent : MonoBehaviour
{

    public Rigidbody rig;
    private BoxCollider box;

    private GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
        box = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
