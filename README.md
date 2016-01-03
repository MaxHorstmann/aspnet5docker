# aspnet5docker
just messing around with ASP.NET 5 and Docker

To run on any Docker server:

Fire up a Postgres instance:

```
docker run -p 5432:5432 --name some-postgres -e POSTGRES_PASSWORD=mysecretpassword -d postgres
```

Then, fire up the app:

```
docker run -d -p 80:5000 quay.io/max_horstmann/aspnet5docker
```


