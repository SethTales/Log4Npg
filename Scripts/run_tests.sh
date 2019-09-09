dotnet clean ../ Log4Npg.sln
./create_test_db.sh
dotnet test ../Log4Npg.Tests/Log4Npg.Tests.csproj
./teardown_test_db.sh