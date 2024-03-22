using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AsignadorDestinoNav : MonoBehaviour
{
    private NavMeshAgent navegadorIA;
    public GameObject destino;

    void Start()
    {
        navegadorIA = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (destino != null) 
        {
            navegadorIA.destination = destino.transform.position;        
        }
    }
}
