using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class notte_giorno : MonoBehaviour
{
    public Light2D Luce;
    // public GameObject LuceAbitazioni;
    public GameObject[] LucePali;
    public TimeManager TimeManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("e"))
        {
            Luce.intensity = 0.4f;
            // LuceAbitazioni.SetActive(true);

            foreach(GameObject lucepali in LucePali)
            {
                lucepali.SetActive(true);
            }
            Debug.Log("cliccato");
        }
        else if(Input.GetButtonDown("t"))
        {
         
            Luce.intensity = 1f;
            // LuceAbitazioni.SetActive(false);

            foreach (GameObject lucepali in LucePali)
            {
                lucepali.SetActive(true);
            }
            Debug.Log("cliccato");
        }

        CycleNight_day();
        
    }

    public void CycleNight_day()
    {
        int currentHour = TimeManager.Hour;
        if (currentHour >= 19 || currentHour < 8)
        {
            Luce.intensity = 0.4f;
            // LuceAbitazioni.SetActive(true);

            foreach (GameObject lucepali in LucePali)
            {
                lucepali.SetActive(true);
            }
        }
        else
        {
            Luce.intensity = 1f;
            // LuceAbitazioni.SetActive(true);

            foreach (GameObject lucepali in LucePali)
            {
                lucepali.SetActive(false);
            }
        }
    }
}
