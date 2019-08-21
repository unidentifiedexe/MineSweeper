using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper
{

    struct CellState
    {
        public CellType Type { get; }

        const uint _maxNumber = 8;
        public int Number { get; }

        /// <summary> セルの状態が初期値かどうかを判断します </summary>
        public bool IsDefault => Type == CellType.Error;

        public CellState(CellType type)
        {

            if (type == CellType.Number)
                Type = CellType.Error;
            else
                Type = type;

            Number = 0;
        }

        public CellState(int number)
        {
            Number = number;
            if (number == 0)
                Type = CellType.Empty;
            else if ((uint)Number < _maxNumber)
                Type = CellType.Number;
            else
                Type = CellType.Error;
        }

        private CellState(CellType type, int number)
        {
            Type = type;
            Number = number;
        }

        static public implicit operator CellState(int val)
        {
            return new CellState(val);
        }

        static public implicit operator CellState(CellType type)
        {
            return new CellState(type);
        }

    }

    enum CellType
    {
        /// <summary> 不正値(未定義)  </summary>
        Error = 0,
        /// <summary> 存在しない </summary>
        None ,
        /// <summary> 爆弾 </summary>
        Bomb,
        /// <summary> 旗 </summary>
        Flag,
        /// <summary> カラ(=0) </summary>
        Empty,
        /// <summary> 数字 </summary>
        Number,
        /// <summary> ミスフラッグ </summary>
        WrongFlag,
        /// <summary> 未オープン </summary>
        UnOpend,
    }

    static class CellTypeHelper
    {

        static private void ThrowHelper(string name)
        {
            throw new ArgumentException(name);
        }

       public static bool? IsOpend(this CellType type)
        {
            switch (type)
            {
                case CellType.None:
                    return null;
                case CellType.Bomb:
                case CellType.Flag:
                case CellType.Empty:
                case CellType.Number:
                case CellType.WrongFlag:
                    return true;
                case CellType.UnOpend:
                    return false;
                default:
                    ThrowHelper(nameof(type));
                    return null;
            }
        }
    }


}
