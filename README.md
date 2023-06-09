# Итоговая Работа 
## Задача: 
>Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символ.
#### Примечание:
* Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
* При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами
***
## Решение:
### Входные данные задачи:
| Идентификатор | Тип |
| ------------- | ------------- |
| element | string |
### Переменные данные задачи:
| Идентификатор | Тип |
| ------------- | ------------- |
| index | int |
| i | int |
| FirstArray | string[] |
| SecondArray | string[] |
### Алгоритм решения задачи:
![Изображение Алгоритма](/image/image.png)
***
## Этапы решения задачи:
* Этап 1:
В начале создаем одномерный массив и условие для вывода нужных нам элементам:
```
string[] FirstArray = new string [] {  "haha", "not", "ok", "hehe" };
for (int i = 0; i < FirstArray.Length; i++)
{
    if ( FirstArray[i].Length <= 3) {
    Console.Write(FirstArray[i] + " "); // not ok
    }
}
```
* Этап 2:
Создаем второй пустой одномерный массив, выделяем память [0] и добавляем в него подходящие по условию элементы из первого массива, каждый раз изменая размер выделяемой памяти на элемент.
```
string[] SecondArray = new string [0];

if ( FirstArray[i].Length <= 3){
    Array.Resize(ref SecondArray, SecondArray.Length + 1);
    SecondArray[SecondArray.Length - 1] = FirstArray[i];
    }
```
* Этап 3: 
Убираем заранее созданный массив и пишим алгоритм позволяющий записывать элемены в массив с консоли
```
string[] FirstArray = new string[1];
    int index = 0; 
    string element;
do
{
    element = Console.ReadLine() ?? "Null";
    if (element == "stop") break;
    FirstArray[index] = (element) ?? "Null";
    ++index; Array.Resize(ref FirstArray, FirstArray.Length + 1);
} while (true);
``` 
> Так как массив не имеет ограничения в памети (поскольку кол-во выделяемой памяти увеличивается на каждый новый элемент) добавляем стоп слово "stop" для перехода к другому этапу задачи.

* Этап 4:
Редактирум и оптимизируем код