using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Bumper : MonoBehaviour
{
    [SerializeField] private Animator myAnimator;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            myAnimator.SetTrigger("Shake");
            Debug.Log("Hit");
        }
    }
}
