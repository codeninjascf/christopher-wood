using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public static UIController instance;

    private void Awake ()
    {
        instance = this;   
    }

    public Slider healthSlider;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateHealth(int currentHealth, int maxHealth)
    {
        healthSlider.maxValue = maxHealth;
        healthSlider.value = currentHealth;

        if(currentHealth <= 0)
        {
            currentHealth = 0;
            gameObject.SetActive(false);
        }

        UIController.instance.UpdateHealth(currentHealth, maxHealth);
    }
}
