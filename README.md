# Проект "C Pool" — School21

## Описание

В этом проекте вам предстоит создать программу для реализации базовых концепций
программирования с использованием языка **C#**. Цель проекта — изучить основы
работы с памятью, переменными, а также научиться эффективно работать с
различными структурами данных.

Вместо работы с указателями, как в языке C, вы будете работать с типами данных и
ссылочными типами в C#. Основное внимание будет уделено операциям с массивами,
списками и коллекциями.

---

## Задание

### Часть 1: Работа с массивами

- Реализуйте программу, которая создает массив целых чисел. Размер массива и его
  элементы должны быть введены пользователем.
- Напишите функцию для нахождения минимального и максимального значения в
  массиве.
- Реализуйте функцию для вычисления суммы всех элементов массива.
- Напишите функцию для поиска среднего арифметического всех элементов массива.

### Часть 2: Работа со списками

- Используя List<int>, реализуйте программу, которая добавляет элементы в список
  и сортирует их в порядке убывания.
- Напишите функцию, которая удаляет все дубликаты из списка.
- Реализуйте функцию для поиска элемента в списке (поиск по индексу и значение).
- Реализуйте метод для поиска второго максимального числа в списке.

### Часть 3: Строки и манипуляции с ними

- Реализуйте программу, которая принимает строку от пользователя и выводит на
  экран: Длину строки. Перевернутую строку.
- Количество слов в строке (разделитель — пробел).
- Напишите функцию, которая заменяет все пробелы в строке на подчеркивания
  (например, "Hello world" → "Hello_world").
- Реализуйте метод, который проверяет, является ли строка палиндромом (например,
  "madam" — да, а "hello" — нет).

### Часть 4: Основы ООП

- Создайте класс Person, который будет содержать поля: имя, возраст и метод для
  вывода этой информации.
- Реализуйте класс Student, который будет наследовать от Person и добавлять поле
  для хранения курса (номер курса) и метод, который выводит всю информацию о
  студенте.
- Напишите метод, который будет сравнивать два объекта типа Student по возрасту
  и выводить старшего из них.

---

## Ожидаемые результаты

По завершению проекта вы должны:

- Получить базовые навыки работы с массивами, списками и строками.
- Научиться работать с базовыми структурами данных в **C#**.
- Понимать разницу между значимыми и ссылочными типами данных.
- Научиться работать с основными операциями для работы с памятью в языке C#.
- Освоить основы объектно-ориентированного программирования (ООП) на примере
  классов и наследования.

---

## Технологии

- **Язык программирования**: C#
- **Среда разработки**: Visual Studio или Visual Studio Code (с установленным
  расширением C#)
- **Платформа**: .NET Core (желательно использовать последнюю версию)

---

##Структура проекта

```text
C-Pool-Project/ 
│ 
├── Program.cs (Главный файл программы) 
├── Person.cs (Класс для модели данных Person) 
├── Student.cs (Класс для модели данных Student)
├── README.md (Этот файл)
```

---

## Требования

- Программа должна быть консольным приложением.
- Все данные (массивы, списки, строки) должны обрабатываться в рамках класса
  **Program**.
- Используйте методы, а не просто написание всего кода в одном месте.
- Программа должна работать без ошибок и выполнять все требуемые функции.

---

## Инструкции по запуску

- Откройте проект в **Visual Studio** или **Visual Studio Code**.
- Запустите программу с помощью кнопки Run или выполните команду dotnet run в
  терминале.
- Следуйте инструкциям на экране и вводите данные для выполнения всех операций.

---

## Оценка проекта

Проект оценивается по следующим критериям:

- Работоспособность программы.
- Корректность выполнения всех функций. Качество кода: ясность, правильность
  наименования переменных и методов, использование комментариев.
- Структура программы: правильное разделение логики на методы, классы и файлы.

---

## Примечания

- Программу можно расширять, добавляя новые функции и улучшая пользовательский
  интерфейс.
- Вы можете использовать дополнительные библиотеки и инструменты для улучшения
  функционала (например, LINQ для работы с коллекциями).

---

### Удачи в выполнении задания!
