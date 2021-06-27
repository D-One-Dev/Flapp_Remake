using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesController : MonoBehaviour
{
    [SerializeField] private GameObject pipes1, pipes2, pipeUp1, pipeUp2, pipeDown1, pipeDown2;
    [SerializeField] private float maxUpPos, minUpPos, maxDownPos, minDownPos, minSpace, maxSpace;
    public float speed;
    public bool pipes1Passed, pipes2Passed;
    void Start()
    {
        while (true)
        {
            pipeUp1.transform.position = new Vector3(pipeUp1.transform.position.x, Random.Range(minUpPos, maxUpPos), pipeUp1.transform.position.z);
            pipeDown1.transform.position = new Vector3(pipeDown1.transform.position.x, Random.Range(minDownPos, maxDownPos), pipeDown1.transform.position.z);
            if (pipeUp1.transform.position.y - pipeDown1.transform.position.y > minSpace && pipeUp1.transform.position.y - pipeDown1.transform.position.y < maxSpace) break;
        }
        while (true)
        {
            pipeUp2.transform.position = new Vector3(pipeUp2.transform.position.x, Random.Range(minUpPos, maxUpPos), pipeUp2.transform.position.z);
            pipeDown2.transform.position = new Vector3(pipeDown2.transform.position.x, Random.Range(minDownPos, maxDownPos), pipeDown2.transform.position.z);
            if (pipeUp2.transform.position.y - pipeDown2.transform.position.y > minSpace && pipeUp2.transform.position.y - pipeDown2.transform.position.y < maxSpace) break;
        }
    }
    void FixedUpdate()
    {
        pipes1.transform.position -= new Vector3(speed * Time.fixedDeltaTime, 0f, 0f);
        pipes2.transform.position -= new Vector3(speed * Time.fixedDeltaTime, 0f, 0f);
        if (pipes1.transform.position.x <= -4f) SpawnNew1();
        if (pipes2.transform.position.x <= -4f) SpawnNew2();
    }

    void SpawnNew1()
    {
        pipes1.transform.position = new Vector3(4f, pipes1.transform.position.y, pipes1.transform.position.z);
        while (true)
        {
            pipeUp1.transform.position = new Vector3(pipeUp1.transform.position.x, Random.Range(minUpPos, maxUpPos), pipeUp1.transform.position.z);
            pipeDown1.transform.position = new Vector3(pipeDown1.transform.position.x, Random.Range(minDownPos, maxDownPos), pipeDown1.transform.position.z);
            if(pipeUp1.transform.position.y - pipeDown1.transform.position.y > minSpace && pipeUp1.transform.position.y - pipeDown1.transform.position.y < maxSpace) break;
        }
        pipes1Passed = false;
    }

    void SpawnNew2()
    {
        pipes2.transform.position = new Vector3(4f, pipes2.transform.position.y, pipes2.transform.position.z);
        while (true)
        {
            pipeUp2.transform.position = new Vector3(pipeUp2.transform.position.x, Random.Range(minUpPos, maxUpPos), pipeUp2.transform.position.z);
            pipeDown2.transform.position = new Vector3(pipeDown2.transform.position.x, Random.Range(minDownPos, maxDownPos), pipeDown2.transform.position.z);
            if (pipeUp2.transform.position.y - pipeDown2.transform.position.y > minSpace && pipeUp2.transform.position.y - pipeDown2.transform.position.y < maxSpace) break;
        }
        pipes2Passed = false;
    }
}
