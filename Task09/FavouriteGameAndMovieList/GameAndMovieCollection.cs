using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace FavouriteGameAndMovieList
{
    class GameAndMovieCollection<T> : IEnumerable
    {
        private ArrayList MyList = new ArrayList();
        public T GetList(int pos) => (T)MyList[pos];
        public void AddList(T p)
        {
            MyList.Add(p);
        }
        public void ClearList()
        {
            MyList.Clear();
        }
        public int Count => MyList.Count;

        IEnumerator IEnumerable.GetEnumerator() => MyList.GetEnumerator();
    }
}
