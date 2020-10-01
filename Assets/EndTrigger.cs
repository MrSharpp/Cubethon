using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{

    public GameManager GameManager;


    void OnTriggerEnter()
    {
        GameManager.CompleteLevel();
    }
}
