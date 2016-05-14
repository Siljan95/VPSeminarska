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

    ![mainmenu](https://octodex.github.com/images/yaktocat.png)

    *Слика 1*

###1.2.  Опис на стартуваната игра

    При клик на копчето Start game се отвара нова форма која претставува
    формата на играта (Слика 2).

    ![](http://s32.postimg.org/ojgbu6fat/pic2.jpg)
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

    ![](http://s32.postimg.org/du2n1x3hx/pic3.jpg)
    *Слика 3*



##2.  Опис на решението

    ###  2.1.  Користени класи

    ###  2.2.  Опис на метод

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

        A - Движење на лево

        D - Движење на десно

        E – поставува бомба на соодветното поле

        За третиот играч:

        NumPad8-– Движење нагоре

        NumPad5– Движење надоле

        NumPad4– Движење лево

        NumPad6 – Движење десно

        Numpad0– Поставува бомба на соодветното поле

        Правила на игра и опис на сликите:

        ![bomb](http://postimg.org/image/sv0c5fwtt) - Поставена бомба, пет секунди до
        експлозија

        ![](media/image5.png){width="0.416667760279965in"
        height="0.426667760279965in"} - Бомба пред експлозија

        ![](media/image6.png){width="0.49833333333333335in"
        height="0.4791666666666667in"} - Радиус на експлозија

        ![](media/image7.png){width="0.5520833333333334in"
        height="0.5520833333333334in"} - Празен блок низ кој може да се
        поминува

        ![](media/image8.png){width="0.5625in" height="0.5625in"} -
        Некршлив блок, неуништлив со бомба

        ![](media/image9.png){width="0.5625in"
        height="0.5739785651793525in"}- Кршлив блок кој се уништува при
        експлозија на бомба

        Токени за зајачување на моќите на играчот

        ![](media/image10.png){width="0.6321073928258968in"
        height="0.6354166666666666in"} - Овозможува игачот да постави
        уште една бомба во исто време

        ![](media/image11.png){width="0.6217443132108487in"
        height="0.625in"}- Го зголемува радиусот на бомбата

        ![](media/image12.png){width="0.6113823272090989in"
        height="0.6145833333333334in"}- Го забрзува движењето на играчот
        низ мапата

        Со секој собран токен се зголемуваат моќите на играчот, овие
        моќи траат до крајот на играта.

        На почетокот сите играчи почнуваат со исти моќи и на
        различни позиции.

        Сите играчи имаат исти моќи: Одредена брзина, радиус на бомба од
        едно поле и една бомба за поставување (кога бомбата ке
        експлодира ке може да постави друга)

        Играчите треба да поставуваат бомби за да можат имаат повеќе
        простор за движење и притоа треба стратешки да ги
        поставуваат бомбите.

        Доколку играчот се наоѓа на позиција зафатен од радиусот на
        бомбата , тој умира.

   ## 3.2.  Стратегија на играње

        Играчот со поголеми моќи има поголема шанса за победа,
    препорачливо е да се поставуваат бомбите на месо каде ке скршат
    два или повеке блокови за да може побрзо да се соберат што е
    можно повеке токени.
    ![](media/image13.jpg){width="5.177083333333333in"
        height="5.0520592738407695in"}
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


