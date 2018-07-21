<h2>Создать веб-приложение ASP.Net MVC "Управление уч.записями"</h2>

В задании вам потребуется как минимум 2 контроллера: <br>
для управления уч.записями<br>
для управления ролями<br>

В каждом контроллере должны быть методы CRUD-операций и соответствующие View для каждой операции<br>

Классы(мин. набор свойств):<br>

User{<br>
+Id:int<br>
+FirstName:string<br>
+LastName:string<br>
+Login:string<br>
+Password:string<br>
+Email:string<br>
+Phone:string<br>
+Role:Role<br>
}<br>
<br>
Role{<br>
+Id:int<br>
+Name:string<br>
}<br>

<br>
Доп задание:<br>
Реализовать проверку правильности введенных данных перед добавлением в хранилище (нап. Свойства FirstName, Login, Password и т.д. не должны быть пустыми.<br>
Login и Password должен содержать минимальное кол.симовлов и т.п.)<br>