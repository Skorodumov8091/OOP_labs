# OOP_labs
## Lab_1
### Вариант 1
Описать классы Student и StudentGroup, описывающие отношение между студентом и группой. Студент может быть добавлен в группу, может быть удален из нее. В одной группе могут находиться не более N студентов, один студент может находиться в неограниченном количестве групп.
Реализовать методы:
- для получения студента группы по ФИО;
- для получения списка студентов, отсортированного в лексикографическом порядке, по оценкам;
- для вывода обоих классов в ostream.

Для демонстрации создать несколько групп и заполнить их студентами. Вывести группы в ostream. Продемонстрировать работу всех публичных методов классов (кроме геттеров и сеттеров).
## Lab_2
### Вариант 1
Продолжение первой лабораторной работы.<br>
Класс Student, реализованный в рамках лабораторной работы №1, следует сделать абстрактным, предоставив производным классам определять разные варианты поведения студентов. Произвести от класса Студент производные «Ботаник» (сдает все экзамены с первого раза на 4 и 5), «Обычный студент» (реализует рандомное поведение) и «Член студенческого совета» (является производным «обычного студента», но на последней пересдаче всегда получает 3 балла минимум и, следовательно, никогда не бывает отчислен).
