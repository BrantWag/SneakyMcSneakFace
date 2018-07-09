using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Health : MonoBehaviour
{

    public Canvas healthbarCanvas;
    public Image healthbar;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float health = 1.0f; //- (Time.time % 10.0f) / 10.0f;
        healthbar.fillAmount = health;
        if (health < 0.2f)
        {
            healthbar.color = Color.red;
        }
        else if (health < 0.4f)
        {
            healthbar.color = Color.yellow;
        }
        else
        {
            healthbar.color = Color.green;
        }
    }
}
