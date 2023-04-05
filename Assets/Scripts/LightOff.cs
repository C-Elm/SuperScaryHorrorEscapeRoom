using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LightOff : MonoBehaviour
{
    public GameObject destroyedObject;
    public GameObject destroyedObject2;
    public GameObject destroyedObject3;

    public string SceneName;

    private bool doorOpen = false;

    [SerializeField] private string openAnimationName = "DoorOpen";
    [SerializeField] private string closeAnimationName = "DoorClose";

    [SerializeField] private int waitTimer = 1;
    [SerializeField] private bool pauseInteraction = false;

    private float timeElapsed;

    private IEnumerator PauseDoorInteraction()
    {
        pauseInteraction = true;
        yield return new WaitForSeconds(waitTimer);
        pauseInteraction = false;
    }



    public void PlayAnimation()
    {
        if (!doorOpen && !pauseInteraction)
        {
            Destroy(destroyedObject);
            Destroy(destroyedObject2);
            Destroy(destroyedObject3);

            SceneManager.LoadScene(SceneName);

            doorOpen = true;
            StartCoroutine(PauseDoorInteraction());
        }

        else if (doorOpen && !pauseInteraction)
        {
            Destroy(destroyedObject);
            doorOpen = false;
            StartCoroutine(PauseDoorInteraction());
        }
    }





}
