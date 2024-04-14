using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{

    public GameObject elevatorCollider, elevator;

    private bool lift = false, max = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {

        elevatorCollider.SetActive(true);

        lift = true;
        }
    }

    private void Update()
    {

        if(elevator.transform.position.y > 62)
        {
            max = true;
        }

        if(lift == true && max == false)
        {
            elevator.transform.Translate(0, 0, 5 * Time.deltaTime);
        }


    }
}
