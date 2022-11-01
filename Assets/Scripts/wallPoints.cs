using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallPoints : MonoBehaviour
{
    // Start is called before the first frame update
    public float value = 5f;

    private async void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Ball"))
        {
            KeepScore.score += value;

        }
    }
}
