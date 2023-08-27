using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideAtHidePoints : MonoBehaviour
{

    public Transform[] hidepoints;
    public float speed;
    private int currentHidePoint;
    private Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        currentHidePoint = 0;
        direction = hidepoints[currentHidePoint].position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(hidepoints[currentHidePoint].position, transform.position) > 1f)
        {
            transform.Translate(direction * speed * Time.deltaTime);
        }
        else
        {
            currentHidePoint++;
            if (currentHidePoint >= hidepoints.Length)
            {
                currentHidePoint = 0;
            }
            direction = hidepoints[currentHidePoint].position - transform.position;
        }
    }

    public void HideBehindWall()
    {
        
    }
}
