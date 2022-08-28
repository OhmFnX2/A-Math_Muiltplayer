using System.Collections;
using System.Threading;
using TMPro;
using UnityEngine;

public class RandomSymMainMenu : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI text;
    [SerializeField]
    private TextMeshProUGUI subText;

    private string[][] symbol = new string[][] { new string[] { "0", "1" }, new string[] { "1", "1" }, new string[] { "2", "1" }, new string[] { "3", "1" }, new string[] { "4", "2" }, new string[] { "5", "2" }, new string[] { "6", "2" }, new string[] { "7", "2" }, new string[] { "8", "2" }, new string[] { "9", "2" }, new string[] { "10", "3" }, new string[] { "11", "4" }, new string[] { "12", "3" }, new string[] { "13", "6" }, new string[] { "14", "4" }, new string[] { "15", "4" }, new string[] { "16", "4" }, new string[] { "17", "6" }, new string[] { "18", "4" }, new string[] { "19", "7" }, new string[] { "20", "5" }, new string[] { "+", "2" }, new string[] { "-", "2" }, new string[] { "×", "2" }, new string[] { "÷", "2" }, new string[] { "+/-", "1" }, new string[] { "×/÷", "1" }, new string[] { "=", "1" }, new string[] { "", "0" } };

    void Start()
    {
        StartCoroutine(RandomTimer());
    }

    IEnumerator RandomTimer()
    {
        while (true)
        {
            int randomRange = Random.Range(0, symbol.Length);
            text.text = symbol[randomRange][0];
            subText.text = symbol[randomRange][1];
            yield return new WaitForSeconds(Random.Range(0.016f, 0.5f));
        }
    }
}
