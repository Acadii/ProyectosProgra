using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    public int hp = 100;
    public int hpMax = 100;
    public int score = 100;
    public int vidas = 3;

    private Animator miAnimador;



    void Start()
    {
        miAnimador = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void hacerDanio(int puntos, GameObject atacante)
    {
        print(name + " recibe daño de " + puntos + " por " + atacante.name);

        //Resto los puntos al HP actual
        hp = hp - puntos;
        miAnimador.SetTrigger("Dañar");

    }
}
