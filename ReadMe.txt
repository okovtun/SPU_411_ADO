https://github.com/okovtun/SPU_411_ADO.git
https://www.youtube.com/playlist?list=PLeqyOOqxeiINoom68S0P1Akoxr1nKSPpX

TODO:
1. Преотвратить добавление одинаковых записей в таблицы;
2. Упаковать класс 'Connector' в DLL, и проветрить эту DLL на другом проекте,
   например 'ADO\ConnectorCheck';

DONE:
1. В классе 'Connector' перегрузить функцию 'Select()' таким образом,	DONE
   чтобы она могла принимать весь запрос целиком;
2. Автоматизировать добавление первичного ключа;	DONE
3. В Connector-e написать метод 'Update(???)', который изменяет значение в заданном поле, DONE
   заданной записи в заданной таблице;