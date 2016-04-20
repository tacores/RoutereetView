using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoutereetView
{
    /// <summary>
    /// 座標リストクラス
    /// </summary>
    public class CoordinateList
    {
        private LinkedList<Coordinate> list;
        private double maxAltitude;
        private double minAltitude;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public CoordinateList()
        {
            list = new LinkedList<Coordinate>();
            maxAltitude = -100000;
            minAltitude = 100000;
        }

        /// <summary>
        /// 座標を追加
        /// </summary>
        /// <param name="coordinate">座標</param>
        public void Add(Coordinate coordinate)
        {
            list.AddLast(coordinate);
            maxAltitude = Math.Max(maxAltitude, coordinate.Altitude);
            minAltitude = Math.Min(minAltitude, coordinate.Altitude);
        }

        /// <summary>
        /// イテレータ
        /// </summary>
        /// <returns>イテレータ</returns>
        public System.Collections.IEnumerable Iter()
        {
            foreach(Coordinate coordinate in list)
            {
                yield return coordinate;
            }
        }

        /// <summary>
        /// index番目の座標ペアを返す
        /// </summary>
        /// <param name="index">インデックス（0 <= Count - 2）</param>
        /// <returns>座標のペア</returns>
        public Tuple<Coordinate, Coordinate> GetTupleAtIndex(int index)
        {
            return new Tuple<Coordinate, Coordinate>
                (list.ElementAt(index), list.ElementAt(index + 1));
        }

        /// <summary>
        /// リストの要素数
        /// </summary>
        public int Count
        {
            get { return list.Count; }
        }

        /// <summary>
        /// 高度の最大値
        /// </summary>
        public double MaxAltitude
        {
            get { return maxAltitude; }
        }

        /// <summary>
        /// 高度の最小値
        /// </summary>
        public double MinAltitude
        {
            get { return minAltitude; }
        }
    }
}
