using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartArea : MonoBehaviour
{
    [SerializeField] private BallController ballController;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out BallController ballController))
        {
            //Debug.Log("enter");
            this.ballController = ballController;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out BallController ballController))
        {
            //Debug.Log("exit");
            this.ballController = null;
        }
    }

    private void Update()
    {
        if (ballController != null)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                ballController.Jump();
            }
        }
    }
}
