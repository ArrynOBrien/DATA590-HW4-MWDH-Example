using UnityEngine;

public class HW4Prob3b : MonoBehaviour
{
    public GameObject headtracker;
    public GameObject lhandtracker;
    public GameObject rhandtracker;
    public GameObject head;
    public GameObject lhand;
    public GameObject rhand;
    public GameObject ball;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Updating head position
        Vector3 pos = headtracker.transform.position; 
        Quaternion q = headtracker.transform.rotation;
        pos.z = 1.5f - pos.z;
        q.x = -q.x;
        q.y = -q.y;
        head.transform.position = pos;
        head.transform.rotation = q;

        // Updating hand positions
        Vector3 lpos = lhandtracker.transform.position;
        Quaternion lrot = lhandtracker.transform.rotation;
        lpos.z = 1.5f - lpos.z;
        lrot.x = -lrot.x;
        lrot.y = -lrot.y;
		lhand.transform.position = lpos;
		lhand.transform.rotation = lrot;

        Vector3 rpos = rhandtracker.transform.position;
        Quaternion rrot = rhandtracker.transform.rotation;
        rpos.z = 1.5f - rpos.z;
        rrot.x = -rrot.x;
        rrot.y = -rrot.y;
		rhand.transform.position = rpos;
        rhand.transform.rotation = rrot;

        // Reading triggers
        rhand.transform.localScale = new Vector3(0.1f, 0.05f, 0.2f + OVRInput.Get(OVRInput.RawAxis1D.RHandTrigger));
        lhand.transform.localScale = new Vector3(0.1f, 0.05f, 0.2f + OVRInput.Get(OVRInput.RawAxis1D.LHandTrigger));

        // Code for ball
        if (OVRInput.Get(OVRInput.RawButton.RIndexTrigger))
        {
            ball.transform.position = rhand.transform.position;
            Vector3 vel = OVRInput.GetLocalControllerVelocity(OVRInput.Controller.RHand);
            vel.z = -vel.z;
            ball.GetComponent<Rigidbody>().linearVelocity = vel;
        }

	}
}
