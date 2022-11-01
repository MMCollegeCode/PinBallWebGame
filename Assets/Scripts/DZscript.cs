using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DZscript : MonoBehaviour
{

    public GameObject newBall;
    public int count = 0;
    public Image Ball1;
    public Image Ball2;
    public Image Ball3;

    public GameObject canvasGO;
    public GameObject canvasM;

    // Start is called before the first frame update
    void Start()
    {

        canvasGO.SetActive(false);
        canvasM.SetActive(true);
    }

 
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.GetComponent<Rigidbody>().CompareTag("Ball"))
        {
            
            Destroy(collision.gameObject);
            count++;
            switch (count) {

                case 1:
                    Ball1.GetComponent<Image>().color = new Color32(0, 100, 100, 0);
                    Instantiate(newBall);
                    break;
                case 2:
                    Ball2.GetComponent<Image>().color = new Color32(0, 100, 100, 0);
                    Instantiate(newBall);
                    break;
                case 3:
                    Ball3.GetComponent<Image>().color = new Color32(0, 100, 100, 0);
                    canvasM.SetActive(false);
                    canvasGO.SetActive(true);
                    break;
                default:
                    break;

        }
            
        }
    }
}
