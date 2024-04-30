using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class Mugpickup : MonoBehaviour
{
    public AudioClip drinkWater;
    public GameObject ui;

    // Start is called before the first frame update
    void Start()
    {
        HideUI();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            ShowUI();
        }
    }
    public void Drink()
    {
        gameObject.GetComponent<AudioSource>().PlayOneShot(drinkWater);
    }

    public void HideUI()
    {
        ui.SetActive(false);

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void ShowUI()
    {
        ui.SetActive (true);

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

    }

    public void Press_Yes()
    {
        HideUI();
        Drink();
    }

    public void Press_No() 
    { 
        HideUI();
    }
}
