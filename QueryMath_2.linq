<Query Kind="Statements">
  <Connection>
    <ID>92bc5abb-9915-4445-b868-5a0b0a7c9bd4</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from g in Genres
			  where g.Name.Equals("Heavy Metal")
			  select new
			  {
			  	TracksCount = g.Tracks.Count(),
				Tracks = from t in g.Tracks
						 select new
						 {
						 	TrackName = t.Name,
							AlbumName = t.Album.Title,
							Milliseconds = t.Milliseconds,
							Size = (t.Bytes / 1000) + " kb",
							Price = t.UnitPrice
						 }
			  };
results.Dump("Query Math 2");