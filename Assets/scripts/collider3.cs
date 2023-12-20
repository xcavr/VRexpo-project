using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class collider3 : MonoBehaviour
{
    public Text uiText;
    public Button actionButton;
    public float fadeSpeed = 1.0f;

    private void Start()
    {
        uiText.color = new Color(uiText.color.r, uiText.color.g, uiText.color.b, 0f);
        actionButton.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(FadeInUI());
            actionButton.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(FadeOutUI());
            actionButton.gameObject.SetActive(false);
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

    public void OnActionButtonClick()
    {
        // Handle the button click event here
        Debug.Log("Button clicked! You can add your own logic here.");
    }
}
