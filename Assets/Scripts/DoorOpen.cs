using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public SphereCollider _Sphere;
    public Animator _Animator;
    
    private void OnTriggerStay(Collider other)
    {
        if (_Sphere)
        {
            if (other.CompareTag("Player"))
            {
                _Animator.SetBool("character_nearby",true);
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (_Sphere)
        {
            if (other.CompareTag("Player"))
            {
                _Animator.SetBool("character_nearby",false);
            }
        }
    }
}
