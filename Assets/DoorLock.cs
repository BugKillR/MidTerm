using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLock : MonoBehaviour
{
    public GameObject door, door2;

    public bool canPressE = false;

    private bool openDoor = false;

    private void Update()
    {
        openDoor = FindAnyObjectByType<FirstPersonMovement>().pressed;

        if (openDoor == true)
        {
            door.transform.Translate(0, 1 * Time.deltaTime, 0);
            door2.transform.Translate(0, 1 * Time.deltaTime, 0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            canPressE = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            canPressE = false;
        }
    }
}
