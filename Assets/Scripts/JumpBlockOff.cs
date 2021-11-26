using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBlockOff : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown("Jump"))
        {
            gameObject.SetActive(true);
        }
        if (Input.GetKeyDown("Jump"))
        {
            gameObject.SetActive(false);
        }

    }


}
