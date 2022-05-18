# Стартиране на изтеглен проект

- Изберете проект и го отворете със Visual Studio.
- Изтрийте папката Migrations.
- Отворете файл, който завършва на **...DbContext.cs**. (Обикновенно се намира в папка Data, Database, etc)
- Във файла променете името на **Server=.**, да отговаря на вашият SQL Server(името което пише като се отвори SQL Server Management Studio).
- Във Visual Studio, отворете вашата **Package Manager Console-a**. От лентата горе изберете **(View -> Other Windows -> Package Manager Console)**. Това ще ви отвори конзола в долната част на екрана.
- В конзолата напишете **add-migrations Initial** и изчакайте да зареди.
- След като зареди и няма грешки, напишете отново **update-database**.
- Може да проверите в **SQL Server Management Studio** дали се е създала база.
- Вече всичко е нагласено и може да стартирате проекта.

# Examples
<a href="https://github.com/alexpeev9/VTU-Desktop-Applications-Course-Resources">
  <img src="https://i.imgur.com/MdVZIIa.png" alt="Image 1" width="600">
</a>

<a href="https://github.com/alexpeev9/VTU-Desktop-Applications-Course-Resources">
  <img src="https://i.imgur.com/lzUjkOS.png" alt="Image 2" width="600">
</a>