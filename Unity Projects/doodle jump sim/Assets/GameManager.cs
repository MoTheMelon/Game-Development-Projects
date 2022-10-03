using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject Platform;
    public float width = 6f;
    public float numberOfPlatforms = 300f;
    public float minY = 0.5f;
    public float maxY = 1f;


    // Start is called before the first frame update
    void Start()
    {
        
        Vector3 platformPosition = new Vector3();

        for(int i = 0; i < numberOfPlatforms; i++){
            platformPosition.y += Random.Range(minY, maxY);
            platformPosition.x = Random.Range(-width/2 , width/2);

            Instantiate(Platform, platformPosition, Quaternion.identity);

        }


    }

}
