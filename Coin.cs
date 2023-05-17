using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();
        //Прибавляет монетку к игроку
        player.coins += 1;
        
        //Удаляет монетку
        Destroy(gameobject); 
    }
}
