using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChainPullController : MonoBehaviour
{
    [SerializeField] private Animator chainAnim = null;

    private bool chainPull = false;

    [SerializeField] private string openAnimationName = "ChainPull";
    [SerializeField] private string closeAnimationName = "DoorClose";

    [SerializeField] private int waitchainTimer = 1;
    [SerializeField] private bool pausechainInteraction = false;

    private IEnumerator PauseChainInteraction()
    {
        pausechainInteraction = true;
        yield return new WaitForSeconds(waitchainTimer);
        pausechainInteraction = false;
    }

    public void PlayChainAnimation()
    {
        if (!chainPull && !pausechainInteraction)
        {
            chainAnim.Play(openAnimationName, 0, 0.0f);
            chainPull = true;
            StartCoroutine(PauseChainInteraction());
        }

        else if (chainPull && !pausechainInteraction)
        {
            chainAnim.Play(closeAnimationName, 0, 0.0f);
            chainPull = false;
            StartCoroutine(PauseChainInteraction());
        }
    }
}