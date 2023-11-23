using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Personaje : MonoBehaviour
{
    public int hp = 100;
    public int hpMax = 100;
    public float score = 00;
    public float scoreMoneda = 00;
    public Text etiquetaScore;
    public Text etiquetaMoneda;
    public int vidas = 3;
    public bool aturdido = false;
    public bool morido = false;
    public GameObject efectoSangrePrefab;
    private ReproductorSonido misSonidos;
    private Animator miAnimador;
    public CapsuleCollider2D vanishCoin;

 

    void Start()
    {
        miAnimador = GetComponent<Animator>();
        misSonidos = GetComponent<ReproductorSonido>();
        scoreMoneda = 00;
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            scoreMoneda++;
            etiquetaMoneda.text = "" + scoreMoneda;

            score += 100;
            etiquetaScore.text = "" + score;

        }
    }

}
