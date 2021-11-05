using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacStudentController : MonoBehaviour
{
    private Vector3 nextPosition = new Vector3(-1, 1, 0);
    private Vector3 initialPosition;
    private float testDuration = 1f;
    private float time;
    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        float percentageComplete = time / testDuration;
        transform.position = Vector3.Lerp(initialPosition, nextPosition, percentageComplete);

    }
}
