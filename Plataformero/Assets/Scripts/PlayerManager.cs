using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static Vector2 checkpointPos = new Vector2(-3, 0);

   private void Awake()
    {
        GameObject.FindGameObjectWithTag("Player").transform.position = checkpointPos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
