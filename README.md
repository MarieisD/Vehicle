# Vehicle
Разработать приложение для имитации автоматизированной системы контроля автотрассы

Разработать иерархию классов Транспорт: Транспортное средство, Автомобиль, Грузовик, Погрузчик, Автобус, Троллейбус, Трамвай, Мотоцикл, Гужевая повозка, Велосипед, Самокат, Танк. Топливо.
Важным представляется определение максимального расстояния, которое может преодолеть транспортное средство без остановок.
Для каждого объекта должен вестись журнал мониторинга всех изменения свойств и действий объекта (над объектом), который можно вывести на экран

Разработать приложение, использующее разработанные классы и реализующее следующие функции:
1.	По указанию пользователя создать список из некоторых видов топлива (бензин, дизельное топливо, газ и т.д.) 
2.	Изобразить на экране дорогу с пятью полосами движения длиною 500 км в разумном масштабе. На каждой полосе могут присутствовать сооружения, необходимые для движения определенных транспортных средств.
3.	По указанию пользователя создать пять транспортных средств (если для транспортного средства необходим вид топлива, отсутствующего в заданном списке, генерировать сообщение о невозможности создания объекта такого типа). При создании каждого объекта обязательно указывать начальную и максимальную скорость, расход топлива и емкость топливного бака (если эти понятия применимы к объекту), количество пассажиров и т.д.
4.	Разместить созданные транспортные средства на дороге – одно ТС на одной полосе, учитывая ограничения
a.	по полосе с трамвайными путями может двигаться только трамвай
b.	трамвай не может двигаться без трамвайных путей
c.	троллейбус может двигаться только по полосе, оборудованной троллейбусными проводами
d.	 по полосе, оборудованной троллейбусными проводами, может двигаться не только троллейбус
e.	на гужевой повозке, велосипеде, самокате и танке можно двигаться только по крайним полосам
5.	Функция “Старт”, в результате выполнения которой созданные ТС должны начать прямолинейное движение с начальной скорость. Через 50% максимально возможного пути ТС должен двигаться с максимальной скоростью. Старт и изменение скорости ТС необходимо фиксировать в его журнале
6.	Через каждые 50 км пройденного расстояния, каждое транспортное средство должно делать запись об этом в своем журнале 
7.	Все созданные объекты ТС должны преодолеть максимально возможное для них расстояние и остановиться. Остановка должна фиксироваться в журнале
8.	Дополнительно: Функция остановки в любой момент всех ТС (фиксировать в журналах), после чего выполнить функцию 5 с того места, где была остановка
9.	По выбору пользователя вывести на экран (а также в MS Excel или MS Word) журнал выбранного ТС.


	В строке статуса приложения (Status bar) выводить время, прошедшее с момента старта, и общее количество движущихся ТС, суммарное время движения всех ТС в тек. сеансе, суммарное время остановки всех ТС.
