using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonPop : MonoBehaviour
{
    public GameObject descriptionbutton;
    public GameObject button;

    private void Start()
    {
        descriptionbutton.SetActive(false);
        button.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "player")
        {
            descriptionbutton.SetActive(true);
            button.SetActive(true);
        }
    }
    /*private void OnTriggerExit()
    {
        descriptionbutton.SetActive(false);
        button.SetActive(false);
    }*/

}
