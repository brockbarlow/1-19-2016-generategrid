using UnityEngine;
using System.Collections;

public class GenerateGrid : MonoBehaviour {

    private Vector3 startPos, scurrent, snext, current, next;
    public Vector3 space;
    public GameObject clone;
    public int n;

    void Awake()
    {
        startPos = new Vector3(0, 0, 0);
        current = startPos;
    }

	// Use this for initialization
	void Start ()
    {
        for (int i = 0; i < n; i++)
        {
            snext.z = scurrent.z + space.x;
            Instantiate(clone, scurrent, new Quaternion());
            current = scurrent + space;

            for (int t = 0; t < n - 1; t++)
            {
                next = current + space;
                Instantiate(clone, current, new Quaternion());
                current = next;
            }

            scurrent = snext;
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
