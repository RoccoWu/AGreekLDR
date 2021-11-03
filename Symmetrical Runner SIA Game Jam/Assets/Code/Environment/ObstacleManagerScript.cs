using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManagerScript : MonoBehaviour
{
    public Transform zaWarudoTransform;

    public GameObject persephoneSpike;
    public GameObject hadesSpike;

    public float minDistance;
    public float maxDistance;

    public float persephoneSpikeYOffset;
    public float hadesSpikeYOffset;

    public float swapX;

    // using the same technique groundManager uses, but with spikes;
    private int spikeCount;
    public int maxSpikes;

    private float glspx;

    private GameObject[] spikeInstances;

    public Transform obstaclesContainerTransform;

    void Start()
    {
        spikeInstances = new GameObject[maxSpikes];

        // starting distance for first spike
        float lspx = 5;
        glspx = lspx;

        for (int i = 0; i < maxSpikes; i++)
        {
            float dist = Random.Range(minDistance, maxDistance);

            // heads for persephone tails for hades
            // Elliot, from "In Other Lands": Do you have to ask? Tails for mermaids.
            int headsOrTails = Random.Range(0, 2);

            spikeInstances[i] = Instantiate(
                headsOrTails == 1 ? persephoneSpike : hadesSpike,

                new Vector3(
                    // last spike + random
                    lspx + dist,
                    headsOrTails == 1 ? persephoneSpikeYOffset : hadesSpikeYOffset,
                    0f
                ),

                Quaternion.Euler(
                    headsOrTails == 1 ? 0f : 180f,
                    0f,
                    0f
                )
            );

            lspx += dist;
            spikeInstances[i].transform.SetParent(obstaclesContainerTransform);
        }
    }

    void Update()
    {
        float spx = spikeInstances[spikeCount].transform.position.x;

        if (spx < swapX)
        {
            /**
             * confusing as it is, getting the index of the last spike would be
             * (currentSpike + maxSpike - 1) % maxSpike
             * 
             * spike count 5
             * 0 1 2 3 4
             * (0 + 5 - 1) % 5 = 4
             * 
             * 3 4 0 1 2
             * (3 + 5 - 1) % 5 = 2
             **/
            // get x of last spike
            float dist = Random.Range(minDistance, maxDistance);

            spikeInstances[spikeCount].transform.position = new Vector3(
                glspx + dist,
                spikeInstances[spikeCount].transform.position.y,
                0f
            );
            // new Vector3(spikeInstances[maxSpikes - 1].transform.position.x + Random.Range(-10.0f, 10.0f), 0f, 0f)

            glspx += dist;
            spikeCount = (spikeCount + 1) % maxSpikes;
        }
    }
}