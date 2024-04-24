namespace BinhoChess.Pieces.Interfaces;

interface IMovement
{
    bool CanMove(ISquare destiny);
    void Move(ISquare destiny);
}