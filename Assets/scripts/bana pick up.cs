using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class banapickup : MonoBehaviour
{
    public AudioClip eatBana;
    public GameObject ui;
    GameObject Bana;

    public void DestroyGameObject()
    {
        Destroy(Bana);
    }

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
    public void Eat()
    {
        gameObject.GetComponent<AudioSource>().PlayOneShot(eatBana);
    }



    public void HideUI()
    {
        ui.SetActive(false);

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void ShowUI()
    {
        ui.SetActive(true);

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void PressYes()
    {
        HideUI();
        Eat();
        Destroy(Bana);
    }

    public void PressNo()
    {
        HideUI();
    }
}
