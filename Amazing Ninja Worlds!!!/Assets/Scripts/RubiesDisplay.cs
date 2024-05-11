using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubiesDisplay : MonoBehaviour
{
    public int levelNumber;
    public GameObject[] rubies;
<<<<<<< HEAD
    // Start is called before the first frame update
=======
>>>>>>> 02574cdd2d6a40b73f040208c19cf690e936134b
    void Start()
    {
        UpdateRubies();
    }

<<<<<<< HEAD
    // Update is called once per frame
=======
    
>>>>>>> 02574cdd2d6a40b73f040208c19cf690e936134b
    void Update()
    {
        
    }

<<<<<<< HEAD
    public void UpdateRubies(){
        gameObject.SetActive(PlayerPrefs.GetInt("Level" + levelNumber+ 
        "_Complete")!= 0);

        for (int i = 0; i<3; i++){
            rubies[i].SetActive(PlayerPrefs.GetInt("Level" + levelNumber + 
            "Gem" + (i + 1), 0) == 1);
        }
    }


=======

    public void UpdateRubies()
    {
        gameObject.SetActive(PlayerPrefs.GetInt("Level" + levelNumber +
            "_Complete") != 0);

        for (int i =0; i < 3; i++) 
        {
            rubies[i].SetActive(PlayerPrefs.GetInt("Level" + levelNumber +
            "_Gem" + (i + 1), 0) == 1);
        }
    }

>>>>>>> 02574cdd2d6a40b73f040208c19cf690e936134b
}
