using UnityEngine;
using UnityEngine.Rendering;

public class GroundMaker : MonoBehaviour
{
   public GameObject[] prefabs;
   public float offsetMin = -1f;
   public float offsetMax = 3f;
   int groundCount = 0;

    void Start()
    {
        InvokeRepeating("MakeGrounds", 1f, 2f);
        // 函式名稱，持續時間一秒，2秒間隔觸發 （每隔2秒呼叫一次）

    }
    
    void MakeGrounds()
    {
        int number = Random.Range(0,3);
        Instantiate(prefabs[number], 
        transform.position + new Vector3(Random.Range(offsetMin, offsetMax), 0, 0), 
        transform.rotation);
        groundCount ++; 
        Debug.Log("第" + groundCount + "個地面");
        if (groundCount % 10 == 0)
        {
            Debug.Log("地面速度加快");
            GroundMove.speed *= 1.5f;
        }
    }
}
