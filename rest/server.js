const express        = require('express');
const MongoClient    = require('mongodb').MongoClient;
const bodyParser = require('body-parser');
const db             = require('./config/db');
const app = express();
const port = 8000;
require('./app/routes')(app, {});
app.use(bodyParser.urlencoded({ extended: true }));
const mongoClient = new MongoClient(db.url);
async function run() {
try {
    await mongoClient.connect();
    // обращаемся к базе данных admin
    const database = mongoClient.db("MyDataBases");
    // выполняем пинг для проверки подключения
    const result = await database.command({ ping: 1 });
    console.log("Подключение с сервером успешно установлено");
    console.log(result);
    require('./app/routes')(app, database);
    app.listen(port, () => {
      console.log('We are live on ' + port);
    });               
}catch(err) {
    console.log("Error");
    console.log(err);
} finally {
    // Закрываем подключение при завершении работы или при ошибке
    await mongoClient.close();
    console.log("Подключение закрыто");
}
}
run().catch(console.error);