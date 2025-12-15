using UnityEngine;

public class DialogueComponent : MonoBehaviour, IActivable
{
    [SerializeField] private DialogueDatas _dialogueData;
    private DialogueRow _currentRow;
    private int _currentRowIndex;

    public void Action(Pawn CurrentPawn)
    {

    }

    public DialogueRow GetDialogueRow()
    {
        return _dialogueData.rows[_currentRowIndex];
    }

    public string GetDialogueText()
    {
        return _currentRow.longDialogue;
    }

    public string GetCharacterName()
    {
        return _currentRow.characterName;
    }

}
