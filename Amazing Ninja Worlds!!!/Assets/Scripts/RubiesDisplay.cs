using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubiesDisplay : MonoBehaviour
{
    public int levelNumber;
    public GameObject[] rubies;
    void Start()
    {
        UpdateRubies();
    }

    
    void Update()
    {
        
    }


    public void UpdateRubies()
    {
        gameObject.SetActive(PlayerPrefs.GetInt("Level" + levelNumber +
            "_Complete") != 0);
    }
    for(int i =0; i < 3; i++)
    {
        rubies[i].SetActive(PlayerPrefs.GetInt("Level" + levelNumber +
            "_Gem" + (int + 1), 0) == 1);
    }
}
