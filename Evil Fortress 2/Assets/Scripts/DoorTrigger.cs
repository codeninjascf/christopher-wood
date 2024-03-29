using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public DoorSwitch[] switches;

    private bool _opened;
    private Animator  _animator;

    void Start()
    {
        _animator = GetComponent<Animator>(); 
    }

   
    void Update()
    {
        if (!_opened)
        {
            bool switchesEnabled = true;
            foreach (DoorSwitch s in switches)
            {
                if (!s.SwitchEnabled)
                {
                    switchesEnabled = false;
                }
            }
            if (switchesEnabled)
            {
                _animator.SetBool("DoorActive", true);
                _opened = true;
            }
        }
    }
}
