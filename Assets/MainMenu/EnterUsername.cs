using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;
using Image = UnityEngine.UI.Image;

public class EnterUsername: MonoBehaviour
{
    [SerializeField]
    private TMP_InputField inputF;
    [SerializeField]
    private TextMeshProUGUI errorText;
    [SerializeField]
    private TextMeshProUGUI username;

    private GameObject isGameObject;

    private float colorAdd = 0f;

    private bool textError = false;

    void Start()
    {
        isGameObject = gameObject;

        if (GlobalVariables.username != "")
        {
            isGameObject.SetActive(false);
            username.text = GlobalVariables.username;
            return;
        }
        isGameObject.SetActive(true);
        textError = true;
        errorText.text = "Is null username";

        StartCoroutine(RandomTimer());
    }

    IEnumerator RandomTimer()
    {
        while (true)
        {
            if (colorAdd >= 1f) colorAdd = 0f;
            gameObject.GetComponent<Image>().color = new Color(Color.HSVToRGB(colorAdd, 0.33f, 1f).r, Color.HSVToRGB(colorAdd, 0.33f, 1f).g, Color.HSVToRGB(colorAdd, 0.33f, 1f).b, 0.33f);
            colorAdd += 0.01f;
            yield return new WaitForSeconds(Random.Range(0.016f, 0.1f));
        }
    }

    public void ifTextError()
    {
        if (inputF.text.Length <= 4 && inputF.text.Length != 0)
        {
            textError = true;
            errorText.text = "Is too short username";
        } else if(inputF.text.Length == 0)
        {
            textError = true;
            errorText.text = "Is null username";
        }
        else
        {
            textError = false;
            errorText.text = "";
        }
    }

    public void onClickSubmitButton()
    {
        if(!textError)
        {
            GlobalVariables.username = inputF.text;
            isGameObject.SetActive(false);
        }
    }
}