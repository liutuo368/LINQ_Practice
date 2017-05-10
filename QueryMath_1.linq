<Query Kind="Statements">
  <Connection>
    <ID>92bc5abb-9915-4445-b868-5a0b0a7c9bd4</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from g in Genres
			  orderby g.Name
			  select new
			  {
			  	Genre = g.Name,
				TracksCount = g.Tracks.Count()
			  };
results.Dump("Query Math 1");