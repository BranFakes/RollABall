using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalTrigger : MonoBehaviour
{


    public class LoadSceneOnEnter : MonoBehaviour
    {


        public string SceneName;


        void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Player")
            {
                SceneManager.LoadScene(SceneName); // loads scene When player enter the trigger collider
            }
        }
    }
}
