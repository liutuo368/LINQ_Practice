<Query Kind="Statements">
  <Connection>
    <ID>8f332372-de67-4340-9207-f57f490e8306</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from a in Artists
			  where a.ArtistId == 1
			  orderby a.Name
			  select new
			  {
			  	Artist = a.Name,
				Albums = from b in a.Albums
						 orderby b.Title
						 select new
						 {
						 	Title = b.Title,
							Year = b.ReleaseYear,
							Label = b.ReleaseLabel
						 }
			  };
results.Dump();