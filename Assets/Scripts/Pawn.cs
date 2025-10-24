using UnityEngine;
using UnityEngine.Rendering;

public class Pawn : MonoBehaviour
{
    [SerializeField] private PlayerDatas _playerData;
    [SerializeField] private Board _board;

    private void Start()
    {
        MoveToCell();
    }

    private void MoveToCell()
    {
        Transform NewPos = _board.GetCellByNumber(_playerData._cellNumber).transform; // TODO: Get cell number
        transform.position = NewPos.position;
        transform.rotation = NewPos.rotation;
    }

    public void TryMoving(int value)
    {
        _playerData._cellNumber = _board.GetNextCellToMove(_playerData._cellNumber+value);
        MoveToCell();
    }
}



