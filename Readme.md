# Bomberman

Windows form project by: Emil Nikolovski and Viktor Siljanovski

## 1.  Опис на апликацијата

 Нашата апликацијата Bomberman е всуштност варијација на класичната и
 добро познатата игра Bomberman. Тоа e типична игра во која овозможивме
 да се натпреваруваат двајца или троица играчи. Играчите играат со
 таканаречениот робот Bomberman кој треба да преживее повеке од
 противничките роботи. Роботите треба да поставуваат бомби на одредени
 полиња за да им се отвори дел од мапата за играње.

 Мапата за играње се состои од три видови на блогови : Празен блок низ
 кој може да се поминува, Кршлив блок кој треба да се искрши со бомба и
 при негово кршење се претвра во празен блок и и блок кој неможе да се
 скрши.

 При кршење на кршливите блокови со бомба овозможува шанса за
 појавување на токен кој ке му даде одредени придонеси на бомберманот
 кој ке го подигне и ке му се зголемат шансите за победа на играта.

 Играта завршува кога ке остане само еден робот на мапата кој е означен
 како победник во играта, но исто така може да се случи играта да
 заврши нерешено, кога во исти момент двајцата преостанати играчи ке
 бидат убиени во исто време.

 Верзија на Bomberman може да се најде на следиот линк

<http://www.y8.com/games/playing_with_fire_2>

### 1.1.  Опис на интерфејсот

    При стартување на апликацијата се отвара Windows форма ( сликата 1)
    која содржи копчиња Start game , Options копче , Highscores и
    Exit game.

 ![mainmenu](http://s32.postimg.org/e45k7isqd/pic1.jpg)
  *Слика 1*

###1.2.  Опис на стартуваната игра

    При клик на копчето Start game се отвара нова форма која претставува
    формата на играта (Слика 2).

   ![startgame](http://s32.postimg.org/ojgbu6fat/pic2.jpg)
   *Слика 2*

     При започнување на играта се отвара диалог форма оф играта и на
    почеток се на середина на прозорецот се појавува панела која почнува
    да одбројува и четири секунди за да можат играчте за се спремат и да
    започнат да играат во исто време. После тие четири секунди панелата
    ја снемува од екранот и се овозможуваат контролите на карактерите и
    се стартува тајмерот. Кога играта ке заврши се појавува повторно
    панела на која се прикажува победикот и овозможува опција заповторно
    започнување на нова ига или да се изгаси играта.

###1.3.  Опис на опциите

    На клик на копчето Options се отвара панела на која се прикажуваат
    командите на играчите и овозможува избор на мод на играта – колку
    играчи ке играат (двајца или троица) и имиња на играчите. Со клик на
    Save се зачувуваат внесените промени, доколку се кликне Back to main
    menu се откажуваат сите направени промени ( Слика 3).

    Доколку се кликне Start game без да се постават посакуваните опции
    на играта, играта ке започне со дваица игачи и со предефинирани
    имиња на играчите односно Player1 и Player2.

  ![options](http://s32.postimg.org/du2n1x3hx/pic3.jpg)
   *Слика 3*

##2.  Опис на решението
###2.1.  Користени класи
    Апликацијата Bomberman се состои од две windows form класи 
    MainMenu i StartGame и уште единаесет дефинирани класи кои 
    овозможуваат функционирање на сите елементи во играта.

    -	MeinMenu е обична форма која се појавува на екран со старт на апликацијата
    содржи неколку копчиња и неколку панели кои се појавуваат во кога ке биде 
    притиснато одредено копче/ активиран некој настан. На клик на Start game се 
    повикува втората windows форма StartGame која се отвара како диалог прозорец.

    -	StartGame е исто така windows форма каде се игра играта и се прикажуваат
    соодветни податоци за играчите во текот на играта. Содржи неколку лабели 
    за приказ на податоците и еден тајмер и прогрес бар кој одбројува до крајот
    на играта. Исто така содржи податоци за играчите како и обиект од класта 
    Scene преку кој се одвива играта.

    -	Scene е класа во содржи листа од класата Bomberman и обиект од класата Map.
    Во листата се додаваат играчите а со обиектот од класата Мap се креира мапата,
    се уништува мапата се вршиат сите исцртувања на мапата, и сите важни проверки.

    -	Map една од најважнаите класи во која се имплементира голем дел од логиката
    на играта. Во неа се содржат следниве атрибути
 ![Map class attributes](http://s32.postimg.org/z783bpgfp/Untitled1.png)

    -	Со класата Tiles се претставуваат блоковите во играта и истата содржи 
    енумерација на блокот, статички променливи Bitmap, односно слики за секој од 
    блоковите и Boolean неколку променливи 
      
    -	Класата Item која е всушност абстракна класа која содржи стринг име како атрибут
    и три абстрактни методи кои се препокриени во класите IncreaseBombsItem,
    IncreaseRadiusItem и SpeedUpItem 

    -	Bomb класата има две битмапи (црвена и црна бомба), радиус на бомбата и време до
    експлозија. 

    -	Во класата Stats се чуваат податоци за моќите на бомберманот и се состои од
    три примитивни интеџер променливи (бзрина, број на бомби и радиус на бомба)

    -	Класата Bomberman содржи најмногу атрибути во која се чуваат енумерации за 
    насоката и бојата на карактерот, командите за движење и уште неколку променливи.

###2.2.  Опис на метод

## 3.  Упатство за играње
###  3.1.  Контроли и правила на игра

    Контролите на играчите се предефинирани во играта и истите не
    можат да се сменат.
         
    За првиот играч контролите за движење на карактерот се на
    стрелките на тастатурата:
    Arrow up – Движење нагоре
    Arrow down – Движење надоле
    Arrow left - Движење на лево
    Arrow right - Движење на десно
    Space – поставува бомба на соодветното поле каде се наога
        карактерот
        
    За вториот играч:
      W – Движење нагоре
      S – Движење надоле
      D - Движење на десно
      E – поставува бомба на соодветното поле
      
    За третиот играч:
      NumPad8-– Движење нагоре
      NumPad5– Движење надоле
      NumPad4– Движење лево
      NumPad6 – Движење десно
      Numpad0– Поставува бомба на соодветното поле

 Правила на игра и опис на сликите:

   ![bomb](https://github.com/Siljan95/VPSeminarska/blob/master/BomberMan/BomberMan/resources/bomb_v3.png)- Поставена бомба, пет секунди до
     експлозија

   ![redbomb](https://github.com/Siljan95/VPSeminarska/blob/master/BomberMan/BomberMan/resources/bomb_v3_red.png) - Бомба пред експлозија

   ![explosion](https://github.com/Siljan95/VPSeminarska/blob/master/BomberMan/BomberMan/resources/exlode.png) - Радиус на експлозија

   ![block1](https://github.com/Siljan95/VPSeminarska/blob/master/BomberMan/BomberMan/resources/TextureEmpty.png) - Празен блок низ кој може да се поминува

   ![block2](https://github.com/Siljan95/VPSeminarska/blob/master/BomberMan/BomberMan/resources/TextureBlock_v2.png) -Некршлив блок неуништлив со бомба

   ![block3](https://github.com/Siljan95/VPSeminarska/blob/master/BomberMan/BomberMan/resources/TextureWood.png) - Кршлив блок кој се уништува при експлозија на бомба

 Токени за зајачување на моќите на играчот

  ![powerup1](https://github.com/Siljan95/VPSeminarska/blob/master/BomberMan/BomberMan/resources/PowerUpBomb%2B.png) - Овозможува игачот да постави уште една бомба во исто време

  ![powerup2](https://github.com/Siljan95/VPSeminarska/blob/master/BomberMan/BomberMan/resources/PowerUpBombR.png)- Го зголемува радиусот на бомбата

  ![powerup3](https://github.com/Siljan95/VPSeminarska/blob/master/BomberMan/BomberMan/resources/PowerUpSpeed.png)- Го забрзува движењето на играчот низ мапата

    Со секој собран токен се зголемуваат моќите на играчот, овие моќи 
    траат до крајот на играта.

    На почетокот сите играчи почнуваат со исти моќи и наразлични позиции.
    Сите играчи имаат исти моќи: Одредена брзина, радиус на бомба од едно
    поле и една бомба за поставување (кога бомбата ке експлодира ке може 
    да постави друга)

    Играчите треба да поставуваат бомби за да можат имаат повеќе простор 
    за движење и притоа треба стратешки да ги поставуваат бомбите.
    Доколку играчот се наоѓа на позиција зафатен од радиусот на бомбата,
    тој умира.

## 3.2.  Стратегија на играње

    Играчот со поголеми моќи има поголема шанса за победа,
    препорачливо е да се поставуваат бомбите на месо каде ке скршат
    два или повеке блокови за да може побрзо да се соберат што е
    можно повеке токени.
  ![game strategy](http://s32.postimg.org/gmvuly3ud/pic4.jpg)
      *Слика 4*

    Бомбата прикажана на слика 4 ке експлодира насоките претставени со
    стрелки и ке скрши три блока каде ке има шанса да се појават три
    блока.

    Играчот треба да остане единствен преживеан за да победи во играта па
    затоа треба да се внимава каде ке ја постави бомбата и да се внимава
    на радиусот на бомбата.

    После поставување на бомбата играчот ке има само една шанса да одбера
    насока на која ке се движи, доколку ја поставил бомбата и се тгнал од
    полето нема да може да се врати назад да помине низ бомбата.



-   Да се опише решението на проблемот (кои податоци се чуваат, во какви
    структури, класи)

-   Да се опише барем една ваша функција или класа од изворниот код на
    проектот


