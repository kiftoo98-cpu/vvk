using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class move_alien : MonoBehaviour
{

    GameObject Player;
    public float speed;


    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        
    }

    
    void Update()
    {
        gameObject.transform.position = Vector2.MoveTowards(gameObject.transform.position, Player.transform.position, Time.deltaTime * speed);

    }
}
