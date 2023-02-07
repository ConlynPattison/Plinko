using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{

    public GameObject ballPrefab;

    private Transform _transform;
    // Start is called before the first frame update
    void Start()
    {
        _transform = GetComponent<Transform>();
        Instantiate(ballPrefab, _transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 pos = _transform.position;
            Instantiate(ballPrefab, new Vector3(Random.Range(pos.x -7f, pos.x + 7f), pos.y, pos.z), Quaternion.identity);
        }
    }
}
