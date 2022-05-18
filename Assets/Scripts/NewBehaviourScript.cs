using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextPopup : MonoBehaviour
{
    public Text Joe;



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Joe.gameObject.SetActive(true);
        }
    }
}
