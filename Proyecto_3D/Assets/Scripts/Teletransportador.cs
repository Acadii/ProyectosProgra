using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teletransportador : MonoBehaviour
{
    public GameObject areaDestino;
    public GameObject areaActual;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            areaActual.SetActive(false);
            GameObject player = other.gameObject;
            player.SetActive(false);

            GameObject areaNueva = Instantiate(areaDestino);
            areaActual.transform.position = Vector3.zero;

            Destroy(areaActual);

            Spawnpoint punto =
                GameObject.FindAnyObjectByType<Spawnpoint>();

            player.transform.position = punto.transform.position;
            player.SetActive(true);


        }
    }


}
