using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door2Trigger : MonoBehaviour
{
    public GameObject door1, door2, doorCollider;

    private bool isTriggered = false, door1Max = false, door2Max = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            isTriggered = true;
            doorCollider.SetActive(true);
        }
    }

    private void Update()
    {
        if(isTriggered == true)
        {

            if(door1.transform.position.x >= 192)
            {
                door1Max = true;
            }

            if(door2.transform.position.x <= 197.73)
            {
                door2Max = true;
            }

            if(door1Max == false)
            {
                door1.transform.Translate(0, 2 * Time.deltaTime, 0);
            }

            if(door2Max == false)
            {
                door2.transform.Translate(0, 1.75f * Time.deltaTime, 0);
            }

        }
    }
}
