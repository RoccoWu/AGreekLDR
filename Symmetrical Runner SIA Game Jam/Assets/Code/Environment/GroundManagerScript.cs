using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ground spawn 5


public class GroundManagerScript : MonoBehaviour
{
    public GameObject groundPrefab;
    private GameObject[] groundInstances;

    public Transform playerTransform;
    public Transform groundContainerTransform;
    public Transform zaWarudoTransform;

    public int groundCount;
    private int maxGrounds;

    private float groundDistance;

   private void Start()
    {
        // current ground the player mostly sees
        groundCount = 0;

        // maxGrounds must be an even number, otherwise the maxGround'th ground will not line up perfectly.
        maxGrounds = 4;

        groundDistance = 17.677f;


        groundInstances = new GameObject[maxGrounds];

        for (int i = 0; i < maxGrounds; i++)
        {
            groundInstances[i] = Instantiate(
                groundPrefab,
                new Vector3(i * groundDistance + (-1.87942f), 0f, 0f), // don't move yet
                Quaternion.Euler(
                    180f,
                    (i % 2 == 0 ? 180f : 0), // flip every other instance 180
                    0f
                )
            );

            groundInstances[i].transform.SetParent(groundContainerTransform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (-zaWarudoTransform.position.x / groundDistance >= groundCount + 2)
        {
            groundInstances[groundCount % maxGrounds].transform.localPosition += new Vector3(groundDistance * maxGrounds, 0f, 0f);
            groundCount = groundCount + 1;
        }
    }
}
