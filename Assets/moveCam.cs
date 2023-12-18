using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCam : MonoBehaviour
{
    [SerializeField]
    private GameObject player;
    void Update()
    {
        transform.position = new Vector3(-2.5f, player.transform.position.y + 10f, -10f);
    }
}
