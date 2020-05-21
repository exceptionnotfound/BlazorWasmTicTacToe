using BlazorWasmTicTacToe.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWasmTicTacToe.Models
{
    public class GameBoard
    {
        public GamePiece[,] Board { get; set; }


        public GameBoard()
        {
            Board = new GamePiece[3, 3];

            //Populate the Board with blank pieces
            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    Board[i, j] = new GamePiece(PieceStyle.Blank);
                }
            }
        }
    }
}
