using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorJugador : MonoBehaviour
{
    public float movHorizontal;
    public float movVertical;
    public CharacterController player;

    public float velocidad;
    void Start()
    {
        player = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        movHorizontal = Input.GetAxis("Horizontal");
        movVertical = Input.GetAxis("Vertical");

    }

    private void FixedUpdate()
    {
        player.Move(new Vector3(movHorizontal, 0, movVertical) * velocidad * Time.deltaTime);
    }
}
