using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.y = Mathf.Max(pos.y, player.transform.position.y);
        transform.position = pos;
    }
}
