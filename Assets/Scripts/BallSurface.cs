using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class BallSurface : MonoBehaviour
{
    public GameObject floor;
    public float score = 0f;
    public TMP_Text displyTxt;

    public TMP_Text HighTxt;

    public Text highScore;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(0.1f, 0, 0.1f);
      
    }




    // Update is called once per frame
    void Update()
    {
        transform.position.Set(0,
            floor.transform.position.y + 0.17501f
            , 0);
       



    }

}
