using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadVictory : MonoBehaviour
{
    [SerializeField] private float delayBeforeLoading = 3f;
    [SerializeField] private string sceneNameToLoad;

    private float timeElapsed;
    
    void Update()
    {
        timeElapsed += Time.deltaTime;

        if(timeElapsed > delayBeforeLoading)
        {
            SceneManager.LoadScene(sceneNameToLoad);
        }
    }
}
