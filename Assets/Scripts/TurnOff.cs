using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOff : MonoBehaviour
{
    public GameObject Vaccine;




    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Vaccine.SetActive(false);
        }
    }
}
