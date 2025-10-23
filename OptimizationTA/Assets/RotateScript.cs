using UnityEngine;


public class RotateScript : MonoBehaviour
{
    private float rnd;
   
    void Start()
    {
        rnd = Random.Range(10, 100);
        
    }

    // Update is called once per frame
    void Update()
    {
       gameObject.transform.Rotate(new Vector3(30f, 30f, 0f), Time.deltaTime * rnd);
    }
}
