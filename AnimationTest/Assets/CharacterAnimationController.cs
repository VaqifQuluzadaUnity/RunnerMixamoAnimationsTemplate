using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationController : MonoBehaviour
{
    [SerializeField] private AnimationClip[] animations;
    private Animator playerAnimator;

    int sequenceIndex=0;
    private void Start()
    {
        playerAnimator = GetComponent<Animator>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerAnimator.Play(animations[sequenceIndex].name,0);
            Debug.Log(animations[sequenceIndex].name);
            sequenceIndex++;
            if (sequenceIndex == animations.Length)
            {
                sequenceIndex = 0;
            }
            
        }
    }
}
