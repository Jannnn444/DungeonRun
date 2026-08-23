using UnityEngine;

public class GroundMaker : MonoBehaviour
{
   public GameObject prefabs;
    void Start()
    {
        InvokeRepeating("MakeGrounds", 1f, 2f);
    }

    // 函式名稱，持續時間一秒，2秒間隔觸發 （每隔2秒呼叫一次）
    
    void MakeGrounds()
    {
        Instantiate(prefabs, transform.position, transform.rotation);
    }
}
