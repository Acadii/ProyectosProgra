using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    public int hp = 100;
    public int hpMax = 100;
    public int score = 100;
    public int vidas = 3;
    public bool aturdido = false;
    public bool morido = false;
    public GameObject efectoSangrePrefab;
    private ReproductorSonido misSonidos;
    private Animator miAnimador;

 

    void Start()
    {
        miAnimador = GetComponent<Animator>();
        misSonidos = GetComponent<ReproductorSonido>();
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

        if (hp <= 0)
        {
            morido = true;
            miAnimador.SetTrigger("Morido");
        }

        miAnimador.SetTrigger("Dañar");

        //Creo una instancia de la parte de sangre
        GameObject sangre = Instantiate(efectoSangrePrefab, transform);
        misSonidos.reproducir("Dañar");

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
        misSonidos.reproducir("Morir");
    }


}
