# Clean Code

## 1. Что есть чистый код

> *Чистый код прост и прямолинеен. Чистый код читается как хорошая проза. Может читаться и усовершенствоваться другими разработчиками. Для него написаны модульные и приемочные тесты. Чистый код обладает минимальными зависимостями  и имеет минимальный и понятный API. Чистый код должен выглядеть так, словно автор над ним изрядно потрудился.* (с) 29-33 стр.

Заветные правила Кент Бека касательно чистого кода:

1. Проходят все тесты
2. Не повторяется
3. Выражает все концепции проектирования
4. Содержит минимальное количество сущностей

## Правило Бойскаутов

> *Оставь место стоянки чище, чем оно было до твоего прихода*

Идеальный раслад таков, что с каждый разом, чистая свой или чужой код, нужно попытаться "почистить" его и оставить лучше, чем он был до нашего визита. Таким образом, со временем качество кода проекта будет расти, следовательно код будет лучше поддерживаться, а по сравнению с некоторыми "хотя бы поддерживаться".

## 2. Содержательные имена переменных

#### **Имена должны передавать намерения программиста и отражать свою суть**

Плохое именование:

```C#
int d;
```

Хорошее именование:

```C#
int elapsedTimeInDays;
```

#### Избегайте дезинформации

Дезинформация:

```C#
Account[] accountsList;
```

Понятное именование:

```C#
List<Account> accountsList;
Account[] accountsArray;
IEnumerable<Account> accountsEnumerable;
```

#### Используйте осмысленные различия

Не надо так:

```c#
public void CopyChars(char[] a1, char[] a2){
    for(int i = 0; i < a1.Length; i++){
        a2[i] = a1[i];
    }
}
```

```C#
GetActiveAccount();
GetActiveAccounts();
GetActiveAccountInfo();
```

#### Используйте удобопроизносимые имена

Нет:

```C#
private DateTime _credate;
private DateTime _genymdhms;
```

Да:

```C#
private DateTime _dateAtCreated;
private DateTime _generationTimestamp;
```

#### Префиксы членов классов

Не надо:

```C#
string m_text;
```

Разрешаю:

```C#
string text;
```

#### Имена классов

> Имена классов и объектов представляют собой имена существительные

Примеры: Customer, Account, WikiPage

Старайтесь избегать использование Info, Manager, Processor, Data

#### Имена методов

> Имена методов представляют собой глаголы и глагольные словосочетания

Примеры: PostPayment(), DeletePage()

#### Выберите одно слово для каждой концепции

Не используйте несколько подобных слов для, например, получения чего либо: fetch, receive, get

#### Не добавляйте избыточный контекст

* Не нужно добавлять префиксы GSD в проекте Gas Station Deluxe к членам классов, например, GSDAccount, GSDUser и тд
* accountAddress, customerAddress подходящее имя для экземпляров класса, но не для самих классов. Address - более подходящее имя для класса.

## 3. Функции

### Компактность

* функции должны быть компактными (30 - 50 строк)
* функции должны быть еще компактнее (5 - 15 строк)

### Блоки и отступы

* блоки в командах if else while должны состоять из одного вызова метода
* максимальный размер отступов в методе не должен превышать одного-двух

### Правило одной операции

> Функция должна выполнять только одну операцию, должна выполнять ее хорошо и ничего другого она делать не должна

Но **<u>не нужно</u>** переформулировать этот код:

```C#
private void Foo(bool argument){
    if(argument){
        DoSomething();
    }
}
```

В нечто подобное:

```C#
private void Foo(bool argument){
    DoSomethingIfArgument();
}
```

Нужно постараться вытянуть из большой функции несколько и поместить их в отдельные методы.  

### Секции в функциях

Хорошую функцию невозможно поделить на внутренние секции (инициализация, объявление, отбор)

### Один уровень абстракции на функцию

Пример трех уровней абстракций:

```C#
// Высокий уровень абстракции
getFile();
```

```C#
// Средний уровень абстракции
string filePathName = Path.GetFilePathWithoutExtension(file.Path);
```

```C#
// Низкий уровень абстракции
stringBuilder.Append(value);
```

При смещении уровней абстракций в одной функции может быть затруднительно понимание и чтение кода.

### Аргументы функций

* Функция без параметров - нуль-арная - **Идеальная функция**
* Функция с одним параметром - унарная
* Функция с двумя аргументами - бинарная
* Функция с тремя аргументами - тернарная - Такие **следует избегать**
* Функция с более чем тремя аргументами - полиарная - **Ужас**

Основные причины, почему следует использовать минимальное кол-во параметров:

* Сложно тестировать
* Теряется концептуальная мощь и придается лишний контекст

### Стандартные унарные функции

Избегайте передачи параметров в функцию с целью преобразования внутри, используя при этом `void` в качестве возвращаемого значения. 

```C#
private void ParseHtml(string html);
```

Если функция преобразует входной аргумент, то результатом должно быть тип входного аргумента.

```C#
// соответсвует основной форме преобразования
private string ParseHtml(string html);
private ParsedHtml ParseHtml(string html);
```

### Аргументы-флаги

> *Ну это уже пипяу*

* Во-истину усложняет чтение и понимание кода беглым взглядом
* Усложняет и засоряет сигнатуру метода
* Говорит о том, что состояние функции и ее выполнение может изменять от значения флага

Осуждаем:

```C#
public string RenderHtml(bool isSuite);
```

Одобряем:

```C#
public string RenderHtmlForSuite();
public string RenderHtmlForSingleTest();
```

### Объекты как аргументы

```C#
public Circle MakeCircle(double x, double y, double radius);
```

Изменим на:

```C#
public Circle MakeCirlce(Point point, double radius);
```

### Побочные эффекты в функциях

Побочные эффекты дело весьма неприятное и гадкое. Функции с побочными эффектами создают лишние (временные) привязки и могут поломать функциональность программы. Примеры, надеюсь, можно не приводить.

### Выходные аргументы

> *Если функция должна изменять чье-то состояние, пусть она изменяет состояние своего объекта владельца*

```C#
// может затруднить процесс чтения и понимания кода
public void AppendFooter(HtmlDocument document); 
```

```C#
// выглядит чисто и хорошо читается
document.AppendFooter();
```

### Разделение команд и запросов

> *Функция должна либо изменять чье-то состояние, либо отвечать на какой-либо вопрос*

```C#
public bool Set(string key, string value); // осуждаем
```

Данный код и изменяет состояние, присвоив значение `value` по ключу `key`, а также сообщает успешно ли прошло присвоение.

Лучше изменить этот код на следующий:

```C#
if(!keyExists(key)){
    Set(key, value);
}
```

### Используйте исключения вместо кодов ошибок

> *Здесь все понятно, просто хочу подчеркнуть, что об этом забывать не стоит*

### Изолируйте блоки try/catch

```C#
public void Foo(){
    try{
        /*
        
        
        	some more code
        
        
        */
    }
    catch(ArgumentException){
        // process
    }
    catch(Exception){
        // process
    }
}
```

Изменим на:

```C#
public void Foo(){
    try{
        DoSomething();
    }
    catch(ArgumentException){
        // process
    }
    catch(Exception){
        // process
    }
}

private void DoSomething();
```

***Примечание***: После кода try/catch/finally должен быть **только конец функции** и ничего более.
