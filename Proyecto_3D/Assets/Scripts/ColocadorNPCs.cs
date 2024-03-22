using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class ColocadorNPCs : MonoBehaviour
{
    private GameObject[] puntosSpawn;
    private int indicePunto = 0;
    private void Awake()
    {
        puntosSpawn = GameObject.FindGameObjectsWithTag("PuntoSpawn");
    }

    private void OnDrawGizmos()
    {
        if (puntosSpawn == null)
        {  return; }

        foreach (GameObject punto in puntosSpawn)
        {
            Gizmos.DrawIcon(punto.transform.position, "puntoSpawn");
        }
    }

    public void AlCrearNPC(GameObject generador, GameObject npc)
    {
        print("Se genero NPC " + npc.name);

        GameObject punto = puntosSpawn[indicePunto];
        npc.transform.position = punto.transform.position;

        indicePunto = (indicePunto + 1) % puntosSpawn.Length;
    }
}
