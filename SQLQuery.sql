
/* Finds all Movies wheres the movie Name have "the" in them */
SELECT Movies.Name, Movies.Year FROM Movies WHERE Name LIKE '%The%'


/* Finds the Movies directly by searching the movie Name */
SELECT Movies.Name, Movies.Year FROM Movies WHERE Name = 'Titanic'


/* Finds all Movies where actor ID is 3 (Christian Bale) */
select Movies.Name, Movies.Year FROM MovieActors 
join Movies on Movies.ID = MovieActors.MovieID
Where ActorID = 3


/* Finds all Movies where GenreID is 1 (Action) */
select Movies.Name, Movies.Year FROM MovieGenres 
join Movies on Movies.ID = MovieGenres.MovieID
Where GenreID = 1


/* Finds all Movies where the genre is Action */
select Movies.Name, Movies.Year FROM MovieGenres 
join Movies on Movies.ID = MovieGenres.MovieID
join Genres on MovieGenres.GenreID = Genres.ID
Where Genres.Name = 'Action'
