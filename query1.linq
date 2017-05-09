<Query Kind="Statements">
  <Connection>
    <ID>8f332372-de67-4340-9207-f57f490e8306</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>


var results = from x in Artists
			  orderby x.Name
			  select new
			  {
			  	  ID = x.ArtistId,
				  Name = x.Name
			  };
results.Dump();