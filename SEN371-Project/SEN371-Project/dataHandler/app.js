const sql = require("msnodesqlv8");
const express = require("express");
const app = express();
const connectionstring =
  "server=DESKTOP-P3PTCL8\\SQLEXPRESS;Database=PremierServiceSolutions;Trusted_Connection=Yes;Driver={SQL Server Native Client 11.0}";
const query = "SELECT * FROM dbo.Customer";

// Get request
app.get("/", function (req, res) {
  // Config your database credential
  sql.query(connectionstring, query, function (err, rows) {
    if (err) {
      console.error("Error executing query:", err);
      return res.status(500).send("An error occurred while fetching data.");
    }

    if (!rows) {
      console.log("No data found.");
      return res.status(404).send("No data found.");
    }

    console.log(rows);
    res.json(rows); // Send the fetched data as JSON response
  });
});

let server = app.listen(5000, function () {
  console.log("Server is listening at port 5000...");
});
