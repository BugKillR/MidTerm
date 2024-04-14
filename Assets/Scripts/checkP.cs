using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkP : MonoBehaviour
{
    public GameObject text1;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            text1.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            text1.SetActive(false);
        }
    }
}
