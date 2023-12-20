using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class collider2 : MonoBehaviour
{
    public Text uiText;
    public float fadeSpeed = 1.0f;

    private void Start()
    {
        uiText.color = new Color(uiText.color.r, uiText.color.g, uiText.color.b, 0f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(FadeInUI());
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(FadeOutUI());
        }
    }

    IEnumerator FadeInUI()
    {
        while (uiText.color.a < 1.0f)
        {
            uiText.color = new Color(uiText.color.r, uiText.color.g, uiText.color.b, uiText.color.a + fadeSpeed * Time.deltaTime);
            yield return null;
        }
    }

    IEnumerator FadeOutUI()
    {
        while (uiText.color.a > 0.0f)
        {
            uiText.color = new Color(uiText.color.r, uiText.color.g, uiText.color.b, uiText.color.a - fadeSpeed * Time.deltaTime);
            yield return null;
        }
    }
}
