using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public GameObject FinishPanel;
    //public AudioSource FinishAudio;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            FinishPanel.SetActive(true);
            //FinishAudio.Play();
            Time.timeScale = 0f;
        }
    }
}
