<Query Kind="Statements">
  <Connection>
    <ID>92bc5abb-9915-4445-b868-5a0b0a7c9bd4</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from m in MediaTypes
			  select new
			  {
			  	Name = m.Name,
				Tracks = from n in m.Tracks
						 select new
						 {
						 	TrackName = n.Name,
							Album = n.Album.Title,
							Artist = n.Album.Artist.Name,
							ReleaseYear = n.Album.ReleaseYear,
							ReleaseLabel = n.Album.ReleaseLabel,
							Genre = n.Genre.Name
						 }
			  }; 
results.Dump();