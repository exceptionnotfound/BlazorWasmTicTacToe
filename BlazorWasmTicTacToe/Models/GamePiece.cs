using BlazorWasmTicTacToe.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWasmTicTacToe.Models
{
    public class GamePiece
    {
        public PieceStyle Style;

        public GamePiece()
        {
            Style = PieceStyle.Blank;
        }
    }
}
