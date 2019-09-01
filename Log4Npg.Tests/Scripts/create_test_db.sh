docker pull postgres
docker run --name test-db-instance -d -p 5422:5432 -e POSTGRES_USER=postgres -e POSTGRES_PASSWORD=postgres postgres
