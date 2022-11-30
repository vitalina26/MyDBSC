const DBsRoutes = require('./DB_routes');
module.exports = function(app, db) {
  DBsRoutes(app, db);
  
};