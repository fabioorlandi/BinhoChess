using BinhoChess.Pieces.Interfaces;

namespace BinhoChess.Pieces;

class Knight : Piece
{
    public Knight(ISquare square, eType type) : base(square, type)
    {
    }

    public override bool CanMove(ISquare destiny)
    {
        throw new NotImplementedException();
    }

    public override void Move(ISquare destiny)
    {
        throw new NotImplementedException();
    }
}