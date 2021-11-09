using System;
using System.Collections.Generic;
using System.Text;

namespace LR_08
{
    interface ControlInterface<T>        //1.Создание обобщенного интефейса
    {
        void Show();
        void Add(T item);
        void Delete(T item);
    }
}
