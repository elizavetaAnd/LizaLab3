﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LizaLab3
{
    //объявление класса Range (диапазон) 
    public class Range
    {
        //инкапсуляция
        private readonly int _min;
        private readonly int _max;

        public Range() //принимает два значения: нижнюю и верхнюю границу
        {
        
            _min = 0;
            _max = 15;
        }
        public Range(int min, int max) //принимает два значения: нижнюю и верхнюю границу
        {
            //если минимум больше максимума - ошибка
            if (min > max)
                throw new ArgumentException();
            _min = min;
            _max = max;
        }

        //принимает значение, возвращает результат, находится ли число в заданном диапазоне
        public bool inRange(int current)
        {
            bool result = current >= _min && current <= _max;
            return result;
        }
    }

    class Counter
    {
        //объявляем и инапсулируем переменные типа Range и типа _int
        private Range _range;
        private int _current;

        //тут хранится ошибка
        private bool _error = false;

        //конструктор класса, задаем значения по умолчанию
        public Counter()
        {

            //по умолчанию диапазон от 0 до 15
            _range = new Range(0, 15);
            /// текущая переменная = 0
            _current = 0;
        }


        //перегрузка примет два параметра - число и диапазон
        public Counter(int current, Range range)
        {
            if (!range.inRange(current))
            {
                _error = true;

                throw new ArgumentException(string.Format("Заданное значение не входит в диапазон"));
            }

            //по умолчанию диапазон от 0 до 15
            _range = range;
            ///и текущая переменная = 0
            _current = current;

        }


        //геттер для текущего значения
        public int Current
        {
            get { return _current; }
        }
        //геттер для ошибок

        public Range GetRange
        {
            get { return _range; }

        }
        //Прибавляем единицу
        public void Increment()
        {
            int value = _current + 1;
            setValue(value);
        }
        //Уменьшаем на единицу
        public void Decrement()
        {
            int value = _current - 1;
            setValue(value);
        }

        //Метод setValue.Принимает value, которое нужно установить в _current

    
        private void setValue(int value)
        {
            //если value не входит в диапазон, возвращаем ошибку
            if(!_range.inRange(value))
            {
                throw new ArgumentException(string.Format("Вышли за диапазон"));
            }

            _current = value;
        }


    }
}
