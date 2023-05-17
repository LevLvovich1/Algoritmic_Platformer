using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
   
    void OnTriggerEnter(Collider other)
    {
      other.GetComponent<FirstPersonMovement>().runSpeed /= speedFactor;
    }

    void OnTriggerExit(Collider other)
    {
      
    }
    
}
