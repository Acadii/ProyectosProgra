using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cofre : MonoBehaviour
{
    private Animator miAnimador;
    public GameObject chestItem;
    void Start()
    {
        miAnimador = GetComponent<Animator>();
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                print("Si colisiona");
                miAnimador.Play("Cofre_Open");
                StartCoroutine(getChestItem());
            }
        }

    }

    IEnumerator getChestItem()
    {
        yield return new WaitForSeconds(1f);
        Instantiate(chestItem, transform.position, Quaternion.identity);
    }
}
