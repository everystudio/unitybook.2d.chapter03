using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;

public class Bumper : MonoBehaviour
{
    [SerializeField] private Animator myAnimator;

    public static event EventHandler<int> OnAddScore;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            myAnimator.SetTrigger("Shake");
            //Debug.Log("Hit");
            OnAddScore.Invoke(this, 10);
        }
    }
}
