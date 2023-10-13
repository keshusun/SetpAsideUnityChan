using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    public GameObject carPrefab;

    public GameObject coinPrefab;

    public GameObject conePrefab;
    
    private float startPos = 40;

    private float goalPos = 360;

    private float posRange = 3.4f;

    private GameObject unitychan;

    
    // Start is called before the first frame update
    void Start()
    {
        this.unitychan = GameObject.Find("unitychan");

    }

    // Update is called once per frame
    void Update()
    {
        //unitychanが40m地点に到達したら40ｍ先にアイテムを生成し、その後15m進むごとにunitychanのz座標から４０ｍ先に常にアイテムを生成する。
        if (this.unitychan.transform.position.z >= startPos)
        {
            startPos += 15;

            int num = Random.Range(1, 11);
            if (num <= 2)
            {
                for (float j = -1; j <= 1; j += 0.4f)
                {
                    GameObject cone = Instantiate(conePrefab);
                    cone.transform.position = new Vector3(4 * j, cone.transform.position.y, startPos + 40);
                }
            }
            else
            {
                for (int j = -1; j <= 1; j++)
                {
                    int item = Random.Range(1, 11);
                    int offsetZ = Random.Range(-5, 6);
                    if (1 <= item && item <= 6)
                    {
                        GameObject coin = Instantiate(coinPrefab);
                        coin.transform.position = new Vector3(posRange * j, coin.transform.position.y, startPos + 40);
                    }
                    else if (7 <= item && item <= 9)
                    {
                        GameObject car = Instantiate(carPrefab);
                        car.transform.position = new Vector3(posRange * j, car.transform.position.y, startPos + 40);
                    }
                }
            }
        }
    }
}
