using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface ICar
    {
        /*модификатор задается один для всех перед объявлением
        замого интерфейса*/
        //по умолчанию модификатор internal (в рамках проекта)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="distance">Расстояние</param>
        /// <returns>Время движения</returns>
        int Move(int distance);
    }
}
