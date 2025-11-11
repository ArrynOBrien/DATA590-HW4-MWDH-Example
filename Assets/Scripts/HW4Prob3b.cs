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
        pos.z = 1.5f + pos.z;
        head.transform.position = pos;
        head.transform.rotation = q;

        // Updating hand positions
        lhand.transform.position = lhandtracker.transform.position + new Vector3(0, 0, 1.5f);
        rhand.transform.position = rhandtracker.transform.position + new Vector3(0, 0, 1.5f);
        lhand.transform.rotation = lhandtracker.transform.rotation;
        rhand.transform.rotation = rhandtracker.transform.rotation;

    }
}
