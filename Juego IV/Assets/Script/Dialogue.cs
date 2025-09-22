using System.Collections;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
    [SerializeField, TextArea (4,6)] private string[] dialogoLines;
    [SerializeField] private GameObject dialoguePanel;
    [SerializeField] private TMP_Text dialogueText;

    private float typingTime = 0.05f;
    private bool didDialogueStart;
    private int lineIndex;

    void Start()
    {
        StartDialogue(); // Asegúrate de llamar a StartDialogue al inicio
    }

    void Update()
    {
            if (Input.GetButtonDown("Fire1"))
            {
                // Asegúrate de que lineIndex no supere el tamaño del array
                if (lineIndex < dialogoLines.Length)
                {
                    NextDialogueLine();
                }
                else
                {
                    // Si ya no hay más líneas de diálogo, puedes desactivar el panel o realizar otra acción.
                    dialoguePanel.SetActive(false);
                }
            }

    }

    private void NextDialogueLine()
    {
        lineIndex++;
        if(lineIndex<dialogoLines.Length)
        {
            StartCoroutine(ShowLine() );
        }
        else
        {
            didDialogueStart = false;
            dialoguePanel.SetActive(false);
        }
    }
    void StartDialogue()
    {
        didDialogueStart=true;
        dialoguePanel.SetActive(true);
        lineIndex = 0;
        StartCoroutine(ShowLine());
    }

    private IEnumerator ShowLine()
    {
        dialogueText.text = string.Empty;
        foreach (char ch in dialogoLines[lineIndex])
        {
            dialogueText.text += ch;
            yield return new WaitForSeconds(typingTime);
        }
    }

}
