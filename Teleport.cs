using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Teleport : MonoBehaviour
{
    public Transform teleportPoint;
 
    void OnTriggerEnter(Collider other)
    {
        //Меняет позицию игрока на позицию другого телепорта
        other.transform.position = teleportPoint.position;
    }
}
