using UnityEngine;
using TMPro;
using System.Collections;

public class ChatBubble : MonoBehaviour
{
    [Header("Chat Bubble")]
    public GameObject chatBubbleObject;
    public TextMeshProUGUI bubbleText;
    public string[] messages;
    public float triggerDistance = 3f;
    public float fadeDuration = 0.3f;

    [Header("Player")]
    public Transform player;

    private bool bubbleVisible = false;
    private int messageIndex = 0;
    private CanvasGroup canvasGroup;
    private Camera mainCamera;

    void Start()
    {
        if (player == null)
        {
            PlayerController pc = FindObjectOfType<PlayerController>();
            if (pc != null)
                player = pc.transform;
            else
                Debug.LogError("ChatBubble: Could not find player!");
        }

        // get the camera once
        mainCamera = Camera.main;

        canvasGroup = chatBubbleObject.GetComponent<CanvasGroup>();
        if (canvasGroup == null)
            canvasGroup = chatBubbleObject.AddComponent<CanvasGroup>();

        canvasGroup.alpha = 0f;
        chatBubbleObject.SetActive(false);

        if (messages.Length > 0)
            bubbleText.text = messages[messageIndex];
    }

    void Update()
    {
        if (player == null) return;

        float distance = Vector3.Distance(transform.position, player.position);

        if (distance <= triggerDistance && !bubbleVisible)
            ShowBubble();
        else if (distance > triggerDistance && bubbleVisible)
            HideBubble();
    }

    // LateUpdate runs after all movement is done
    // so the bubble rotates AFTER the player/camera has moved
    void LateUpdate()
    {
        if (bubbleVisible && mainCamera != null)
        {
            // face the camera instead of the player transform
            chatBubbleObject.transform.LookAt(mainCamera.transform);
            chatBubbleObject.transform.Rotate(0, 180f, 0);
        }
    }

    void ShowBubble()
    {
        bubbleVisible = true;
        chatBubbleObject.SetActive(true);
        bubbleText.text = messages[messageIndex];
        messageIndex = (messageIndex + 1) % messages.Length;
        StartCoroutine(Fade(0f, 1f));
    }

    void HideBubble()
    {
        bubbleVisible = false;
        StartCoroutine(Fade(1f, 0f));
    }

    IEnumerator Fade(float startAlpha, float endAlpha)
    {
        float elapsed = 0f;
        canvasGroup.alpha = startAlpha;

        while (elapsed < fadeDuration)
        {
            elapsed += Time.deltaTime;
            canvasGroup.alpha = Mathf.Lerp(startAlpha, endAlpha, elapsed / fadeDuration);
            yield return null;
        }

        canvasGroup.alpha = endAlpha;
        if (endAlpha == 0f)
            chatBubbleObject.SetActive(false);
    }
}