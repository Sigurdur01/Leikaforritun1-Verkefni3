using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseHide : MonoBehaviour
{

    public bool cursorLocked = true;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (cursorLocked == true)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            if (Input.GetKeyDown(KeyCode.F1))
            {
                cursorLocked = false;
            }
        }
        else if (cursorLocked == false)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            if (Input.GetKeyDown(KeyCode.F1))
            {
                cursorLocked = true;
            }
        }

    }
}