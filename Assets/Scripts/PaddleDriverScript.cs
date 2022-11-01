using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class PaddleDriverScript : MonoBehaviour {

    public float hitPower = 2000f;
    public float paddleDamper = 10f;
    public float upPosition = 45f;
    public float downPosition = 0f;

    public float value = 20f;

    public HingeJoint hinge;
    public string inputName;

    public float bounceForce;


    // Use this for initialization
    void Start () {
        hinge = GetComponent<HingeJoint>();
        hinge.useSpring = true;
		
	}


        // Update is called once per frame
        void Update () {
        JointSpring spring = new JointSpring
        {
            spring = hitPower,
            damper = paddleDamper
        };
        spring.targetPosition =Input.GetKey(KeyCode.Space) ? upPosition : downPosition;
        hinge.spring = spring;
        hinge.useLimits = true;	
	}






    private async void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Ball"))
        {
            collision.rigidbody.AddExplosionForce(
                bounceForce,
                collision.contacts[0].point, 15);

            GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
            await Task.Delay(200);
            GetComponent<Renderer>().material.DisableKeyword("_EMISSION");

            KeepScore.score += value;

        }
    }

}
