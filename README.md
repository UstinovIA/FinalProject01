# Алгоритм программы

1. Начало

2. Ввод данных в массив

    2.1. Ввод количества элементов в массиве (count)

    2.2. Инициализация массива строк arr размерностью count

    2.3. Поэлементное заполнение массива

3. Определение размерности нового массива

    3.1. Инициализируем переменную newCount

    3.2. Приравниваем newCount к 0

    3.3. Поэлементно проходим массив arr

        3.3.1. Если длина элемента меньше или равна 3, увеличиваем значение newCount на 1.
    
4. Заполнение нового массива

    4.1. Инициализируем массив newArr размерностью newCount

    4.2. Инициализируем вспомогательную переменную j и приравниваем ее к 0

    4.3. Поэлементно проходим массив arr

        4.3.1. Если длина элемента меньше или равна 3, то:

            4.3.1.1. j-й элемент массива newArr приравниваем к текущему элементу массива arr

            4.3.1.2. Увеличиваем значение j на 1

5. Конец