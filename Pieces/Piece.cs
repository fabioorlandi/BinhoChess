using BinhoChess.Pieces.Interfaces;

namespace BinhoChess.Pieces;

abstract class Piece : IMovement
{
    public Piece(ISquare square, eType type)
    {
        this.Square = square;
        this.Type = type;
    }


    ISquare Square { get; set; }
    eType Type { get; set; }

    public abstract bool CanMove(ISquare destiny);

    public abstract void Move(ISquare destiny);
}