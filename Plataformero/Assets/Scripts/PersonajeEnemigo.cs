using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeEnemigo : MonoBehaviour
{
    public int hp = 10;
    public int hpMax = 10;
    public int score = 0;
    public int vidas = 1;
    public bool aturdido = false;
    public bool morido = false;
    public GameObject efectoGolpePrefab;
    private Animator miAnimador;



    void Start()
    {
        miAnimador = GetComponent<Animator>();
    }

    public void recibirDanio(int puntos, GameObject atacante)
    {
        print(name + " recibe daño de " + puntos + " por " + atacante.name);

        //Resto los puntos al HP actual
        hp = hp - puntos;

        if (hp <= 0)
        {
            morido = true;
            miAnimador.SetTrigger("Morido");
        }

        miAnimador.SetTrigger("Dañar");

        //Creo una instancia de la parte de sangre
        GameObject sangre = Instantiate(efectoGolpePrefab, transform);

        aturdido = true;

        Invoke("desaturdir", 1);
    }

    private void desaturdir()
    {
        aturdido = false;
    }

    public void matar()
    {
        hp = 0;
    }


}

