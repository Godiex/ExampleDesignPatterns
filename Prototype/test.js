class ConnectionPrototype {
    constructor(proto){
        this.proto = proto;
        return this.clone();
    }

    clone(){
        let connection = new Connection();
        connection.driver = this.proto.driver;
        connection.server= this.proto.server;
        connection.database = this.proto.database;
        connection.user = this.proto.user;
        connection.password = this.proto.password;

        return connection;
    }
}

class Connection{
    constructor(driver, server, database, user, password){
        this.driver = driver;
        this.server = server;
        this.database = database;
        this.user = user;
        this.password = password;

        this.status = 0;
    }

    getConnection(){
        this.status = 1;
        return this.driver + "://server=" +this.server+ ";database=" +this.database +";user="+this.user+ ";password="+this.password;
    }

    close(){
        this.status = 0;
    }

}

let connectionSQLServerPrototype =
    new Connection("sqlserver","localhost","beerDB","sa","123456");
let connectionMysqlPrototype =
    new Connection("mysql","localhost","beerDB","sa","123456");

let connectionSQLServer =
    new ConnectionPrototype(connectionSQLServerPrototype);

let connectionMysql =new ConnectionPrototype(connectionMysqlPrototype);

console.log(connectionSQLServer.getConnection());
let copyFalse = connectionSQLServer;
copyFalse.driver = "MongoDb";
console.log(copyFalse.driver);
console.log(copyFalse);
console.log(connectionSQLServer);
console.log(connectionMysql.getConnection());


