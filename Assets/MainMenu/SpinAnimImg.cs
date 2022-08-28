using System.Collections;
using TMPro;
using UnityEngine;

public class SpinAnimImg: MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI username;

    private float degree = 0f;
    private float degreex = 0f;
    private float degreey = 0f;
    private float degreew = 0f;
    private float randomReset = 0f;

    void Start()
    {
        StartCoroutine(addTime());
    }

    IEnumerator addTime()
    {
        while (true)
        {
            if (degree >= randomReset)
            {
                degree = 0f;
            }
            if(degree == 0)
            {
                randomReset = Random.Range(500, 1500);
                degreex = Random.Range(0, 360);
                degreey = Random.Range(0, 360);
                degreew = Random.Range(0, 360);
            }
            gameObject.GetComponent<RectTransform>().transform.rotation = new Quaternion(degreex, degreey, degree, degreew);
            degree = degree + Random.Range(1, 11);
            yield return new WaitForSeconds(Random.Range(0.001f, 0.041f));
        }
    }

    public void UpdateUsername()
    {
        username.text = GlobalVariables.username;
    }
}