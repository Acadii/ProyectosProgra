using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;




public class CoontroladorUI : MonoBehaviour
{

    public static CoontroladorUI Instancia;

    public GameObject grupoPromptInteraccion;
    public TextMeshProUGUI textoPrompt;

    private void Start()
    {
        Instancia = this;
    }

    public void MostrarInteractuable(ObjetoInteractuable obj)
    {
        if (obj != null)
        {
            grupoPromptInteraccion.SetActive(true);
            textoPrompt.text = obj.nombreAccion;
        }

        else
        {
            grupoPromptInteraccion.SetActive(false);
        }
    }

}
