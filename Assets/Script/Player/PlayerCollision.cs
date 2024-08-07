using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [Header("UI Statistics_Animal")]
    public GameObject Button_Log_Box;
    public GameObject Button_Exit_Box;
    public GameObject Ui_Chicken;
    public GameObject Ui_cow;
    public GameObject Ui_goat;
    public GameObject Ui_pig;
    

    private string currentCollisionTag;

    public void OnTriggerEnter2D(Collider2D collider)
    {
        

        if (collider.gameObject.CompareTag("statistics_cow") ||
            collider.gameObject.CompareTag("statistics_chicken") ||
            collider.gameObject.CompareTag("statistics_goat") ||
            collider.gameObject.CompareTag("statistics_pig"))
            

        {
            currentCollisionTag = collider.gameObject.tag;
            Button_Log_Box.SetActive(true);
        }
    }

    public void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag(currentCollisionTag))
        {
            Button_Log_Box.SetActive(false);
            currentCollisionTag = null;
        }
    }

    // This function should be called when the button is clicked
    public void OnButtonLogBoxClick()
    {
        if (currentCollisionTag == "statistics_cow")
        {
            Ui_cow.SetActive(true);
        }
        else if (currentCollisionTag == "statistics_chicken")
        {
            Ui_Chicken.SetActive(true);
        }
        else if (currentCollisionTag == "statistics_goat")
        {
            Ui_goat.SetActive(true);
        }
        else if (currentCollisionTag == "statistics_pig")
        {
            Ui_pig.SetActive(true);
        }
        


        Button_Log_Box.SetActive(false);
        Button_Exit_Box.SetActive(true);
    }

     public void OnButtonExitBoxClick()
    {
        if (currentCollisionTag == "statistics_cow")
        {
            Ui_cow.SetActive(false);
        }
        else if (currentCollisionTag == "statistics_chicken")
        {
            Ui_Chicken.SetActive(false);
        }
        else if (currentCollisionTag == "statistics_goat")
        {
            Ui_goat.SetActive(false);
        }
        else if (currentCollisionTag == "statistics_pig")
        {
            Ui_pig.SetActive(false);
        }
        

        // Optionally, hide the button after it is clicked
        Button_Exit_Box.SetActive(false);
    }


}
