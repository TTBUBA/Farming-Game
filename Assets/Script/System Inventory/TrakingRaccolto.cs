using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class TrakingRaccolto : MonoBehaviour
{
    private Tree tree;

    [Header("TOTALE RACCOLTO")]
    public int RaccoltoCarote;
    public int RaccoltoPatate;
    public int RaccoltoGrano;
    public int Raccoltocavolo;

    [Header("LEGNA RACCOLTA")]
    public int CountLegna;
    public Text Raccolto_Legna_Text;


    [Header("TEXT RACCOLTO")]
    public Text Raccolto_Carote_Text;
    public Text Raccolto_Patate_Text;
    public Text Raccolto_Grano_Text;
    public Text Raccolto_cavolo_Text;

    // Start is called before the first frame update
    void Start()
    {
        // Inizializza il testo della legna raccolta
        Raccolto_Legna_Text.text = CountLegna.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CollectItem(string itemType)
    {
        switch (itemType)
        {
            case "Carota":
                RaccoltoCarote++;
                Raccolto_Carote_Text.text = RaccoltoCarote.ToString();
                break;

            case "Patate":
                RaccoltoPatate++;
                Raccolto_Patate_Text.text = RaccoltoPatate.ToString();
                break;

            case "Grano":
                RaccoltoGrano++;
                Raccolto_Grano_Text.text = RaccoltoGrano.ToString();
                break;

            case "Cavolo":
                Raccoltocavolo++;
                Raccolto_cavolo_Text.text = Raccoltocavolo.ToString();
                break;
        }
    }

    public void SubtractVegetableQuantity(string vegetableName, int quantity)
    {
        switch (vegetableName)
        {
            case "Carota":
                RaccoltoCarote -= quantity;
                Raccolto_Carote_Text.text = RaccoltoCarote.ToString();
                break;

            case "Patate":
                RaccoltoPatate -= quantity;
                Raccolto_Patate_Text.text = RaccoltoPatate.ToString();
                break;

            case "Grano":
                RaccoltoGrano -= quantity;
                Raccolto_Grano_Text.text = RaccoltoGrano.ToString();
                break;

            case "Cavolo":
                Raccoltocavolo -= quantity;
                Raccolto_cavolo_Text.text = Raccoltocavolo.ToString();
                break;
        }

    }

    public void AddLegna(int amount)
    {
        CountLegna += amount;
        Raccolto_Legna_Text.text = CountLegna.ToString();
    }
}
