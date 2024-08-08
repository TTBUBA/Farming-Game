using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tracking_vegetable : MonoBehaviour
{
    [Header("TOTALE RACCOLTO")]
    public int RaccoltoCarote;
    public int RaccoltoPatate;
    public int RaccoltoGrano;
    public int Raccoltocavolo;


    [Header("TEXT RACCOLTO")]
    public Text Raccolto_Carote_Text;
    public Text Raccolto_Patate_Text;
    public Text Raccolto_Grano_Text;
    public Text Raccolto_cavolo_Text;

    public TrakingLocal trakingRaccolto;
    // Start is called before the first frame update
    void Start()
    {
        

        UpdateUi();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateUi();
    }



    public void UpdateUi()
    {
        RaccoltoCarote = trakingRaccolto.RaccoltoCarote;
        Raccoltocavolo = trakingRaccolto.Raccoltocavolo;
        RaccoltoGrano = trakingRaccolto.RaccoltoGrano;
        RaccoltoPatate = trakingRaccolto.RaccoltoPatate;
        

        Raccolto_Carote_Text.text = RaccoltoCarote.ToString();
        Raccolto_Patate_Text.text = RaccoltoPatate.ToString();
        Raccolto_Grano_Text.text =  RaccoltoGrano.ToString();
        Raccolto_cavolo_Text.text = Raccoltocavolo.ToString();
        
    }
}
