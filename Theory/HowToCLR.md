# Платформа .NET

## Компиляция и устройство среды CLR

### Компилятор языка и Управляемые модули

CLR поддерживает множество языков программирования и на каждый из них написан свой компилятор (или же не несколько) который:

1. Способен компилировать исходные файлы с кодом ЯП в (для CLR) промежуточный IL код
2. Реализовывать спецификации среды CLR 

Компилятор языка в результате своей работы выдает **управляемый модуль** (*managed module*), для выполнения которого требуется среда CLR (*прим.: если после компиляции получился только один управляемый модуль, то он становится автоматически сборкой (далее)*). 

**Управляемый модуль** содержит в себе:

* **Заголовок CLR** (версия CLR, точки входа в модуль (метод Main), расположение метаданных, ресурсов и др)
* **Метаданные**
  * Результаты **верификации** (все типы соблюдены; методы вызываются с нужными параметрами; контроль типов передаваемых значений в параметры; типы возвращаемых значений и тд)

* **IL код** (полученный в результате работы компилятора языка)

![](.\imgs\How_to_CLR\1.png)

> Метаданные - это набор таблиц, описывающих то, что определено в (управляемом) модуле, например типы и их члены, а также импортированные типы данных из других сборок. Метаданные расширяют возможности старых типов библиотек как COM и файлы IDL.

Метаданные полезны в следующем:

* Используется в IntelliSence для анализа и выдачи рекомендаций и подсказок по использованию типов и их методов
* Позволяют сборщику мусора (GL) отслеживать жизненный цикл объектов 

### Создание сборок (Assembly)

Но CLR работает не с модулями, а со сборками. **Сборка (Assembly)** обеспечивает логическую группировку управляемых модулей и файлов ресурсов. В контексте CLR сборки также называют *компонентами*. 

В сборке хранится:

* Набор управляемых модулей
* Манифест (описывает набор файлов, входящих в сборку)
* Файлы ресурсов (.jpeg, .png, .gif, .html и тд)

Для создания этой самой сборки используется компоновщик сборок AL.exe

![](.\imgs\How_to_CLR\2.png)



Несмотря на то, что IL код, это фактически объектно-ориентированный машинный код, для его выполнения необходимо его преобразование в байт-код. Этим будет заниматься JIT-компилятор

### JIT компилятор

![](.\imgs\How_to_CLR\3.png)

Поскольку IL-код компилируется непосредственно перед выполнением, этот компилятор стали называть **Just in time compiler**. Снижение производительности наблюдается только в период первичного вызова метода. В последующие разы JIT берет уже скомпилированный код метода из памяти, который хранится в ней в процессе выполнения самой программы, после чего удаляется. Также JIT имеет возможность оптимизировать машинный код.

Ниже показаны команды, которые можно передать **компилятору C# кода**:

![](.\imgs\How_to_CLR\4.png)

При неоптимизированной компиляции C#-compiler выдает код с множеством пустых команд, которые используются для дальнейшего деббага и расстановки breakpoints. При оптимизированной же, все ненужные и пустые команды будут удалены, что препятствует проведению отладки программы.

Ниже перечислены некоторые возможности повышения производительности JIT компилятором:

* JIT может определить тип процессора, на котором будет выполняться программа и сгенерировать машинный код, оптимизированный под конкретную модель (например: Intel Pentium 4)
*  JIT также может определить, что некоторое условие в коде постоянно является ложным, что позволяет ему очищать код, который в теории должен выполниться, если условие станет true
* Если на ПК несколько процессоров, то JIT будет параллельно компилировать код методов, что в разы ускорит процесс выполнения программы

### Верификация

О верификации упоминалось ранее, но повторюсь. **Верификация** - это анализ кода высокоуровневого кода IL и проверка безопасности всех операций.

Верификация управляемого кода, в отличии от неуправляемого кода, гарантирует, что код не будет обращаться в недопустимые области памяти, будет пользоваться только виртуальной выделенной памятью

### Framework Class Library (FCL)

Это базовая библиотека, состоящая из множества типов и структур. 

### Common Type System (CTS)

Описывает способ определения и поведение типов.

CTS описывает такие вещи как Поле, Метод, Свойство, Событие. Задает правила видимости типа: public, internal, protected, private и другие.

### Common Langugae Sertification (CLS)

В спецификации среды выполнения CLR перечислен минимальный набор возможностей, которые должны быть доступны во всех остальных языках (которые написаны на других CLS-совместимых языках на базе CLR). Проще говоря, CLS-совместимый код позволит использовать код вашего ЯП в других ЯП. Но возможности конкретного языка выходят далеко за рамки подмножества, определяемого в CLS. Поэтому, чтобы была поддержка интеграции программного кода из одного языка в другой (в данном примере из языка C#), необходимо следить за CLS-совместимостью. Для этого достаточно написать в начале файла с кодом:

```C#
using System;
[assembly: CLSCompliant(true)]
```









Управляемые сборки содержат в себе функции безопасности (DEP - Data execution prevention и ASLR - Address space layout optimization).

