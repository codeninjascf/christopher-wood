using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSwitch : MonoBehaviour
{
    public GameObject enabledObject;
    public GameObject disbledObject;

    
    void Start()
    {
        enabledObject.SetActive(false);
        disbledObject.SetActive(true);

        SwitchEnabled = false;
    }


    void Update()
    {

    }


    public bool SwitchEnabled;
    {
        get;
        private set;
    }
    void OnTriggerExit(Collider other)
    {
        enabledObject.SetActive(false);
        disabledObject.SetActive(true);

        SwitchEnabled = false;
    }


}
